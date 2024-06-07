using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unique_files
{
    public partial class Form1 : Form
    {
        public static int cloneCount = 0;
        public Form1()
        {
            InitializeComponent();

            //Load saved autofill
            mainDirectory.Text = Convert.ToString(Properties.Settings.Default.mainDirectory);
            newDirectory.Text = Convert.ToString(Properties.Settings.Default.newDirectory);
            outputDirectory.Text = Convert.ToString(Properties.Settings.Default.outputDirectory);

            //Setup backgroundworker
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = false;
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_EndWork);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
        }

        private void proceed_Click(object sender, EventArgs e)
        {
            //Visual changes
            this.Text = "DFE - In process...";
            loaderPic.Visible = true;
            loadingLabel.Visible = true;
            progressCoutLabel.Visible = true;
            proceed.Enabled = false;
            //Runs background file copying
            backgroundWorker1.RunWorkerAsync();
        }
        private void backgroundWorker1_EndWork(object sender, RunWorkerCompletedEventArgs e)
        {
            //Visual changes
            this.Text = "DFE";
            proceed.Enabled = true;
            loaderPic.Visible = false;
            loadingLabel.Visible = false;
            progressCoutLabel.Visible = false;
            progressCoutLabel.Text = "0/0";
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Progress stage counter
            int alreadyDone = Convert.ToInt32(progressCoutLabel.Text.Substring(0, progressCoutLabel.Text.LastIndexOf('/')));
            alreadyDone++;
            progressCoutLabel.Text = alreadyDone + "/" + cloneCount;
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            //Checks if directory fields are incorrect
            if (!mainDirectory.Text.Contains('\\') || mainDirectory.Text.Length < 3) 
            {
                if (mainDirectory.Text.Contains('/')) mainDirectory.Text.Replace("/", "\\");
                else { error(0); return; }
            }
            if (!newDirectory.Text.Contains('\\') || newDirectory.Text.Length < 3) 
            {
                if (newDirectory.Text.Contains('/')) newDirectory.Text.Replace("/", "\\");
                else { error(1); return; }
            }
            if (!outputDirectory.Text.Contains('\\') || outputDirectory.Text.Length < 3) 
            {
                if (outputDirectory.Text.Contains('/')) outputDirectory.Text.Replace("/", "\\");
                else { error(2); return; }
            }
            if (outputDirectory.Text.Equals(newDirectory.Text) || outputDirectory.Text.Equals(mainDirectory.Text)) { error(6); return; };
            if (mainDirectory.Text.Equals(outputDirectory.Text)) { error(7); return; };

            //Get directories infos
            DirectoryInfo dirNew = new DirectoryInfo(newDirectory.Text);
            DirectoryInfo dirMain = new DirectoryInfo(mainDirectory.Text);

            //Get files infos
            IEnumerable<FileInfo> list1 = null;
            IEnumerable<FileInfo> list2 = null;
            try
            {
                list1 = dirNew.GetFiles("*.*", SearchOption.AllDirectories);
                list2 = dirMain.GetFiles("*.*", SearchOption.AllDirectories);
            }
            catch
            {
                error(4);
                return;
            }

            //Custom FileCompare
            FileCompare fileCompare = new FileCompare();

            //Check if directories are the same and return if true
            if (list1.SequenceEqual(list2, fileCompare)) { error(3); return; }

            //Makes a list of files are present in newDirectory but not in mainDirectory
            var queryList1Only = (from file in list1 select file).Except(list2, fileCompare);

            //Creates an array of full paths to clone. 
            ArrayList fromWhereToClone = new ArrayList();
            foreach (var v in queryList1Only) fromWhereToClone.Add(v.FullName);
            cloneCount = fromWhereToClone.Count;
            if (cloneCount == 0) { error(5); return; } //If nothing changed in newDirectory - end

            //Copy selected files to output directory           
            foreach (object o in fromWhereToClone)
            {
                string copyTo = outputDirectory.Text + o.ToString().Substring(newDirectory.Text.Length);
                try
                {
                    File.Copy(o.ToString(), copyTo, true);
                }
                //Creates subfolder in outputDirectory if found such in newDirectory
                catch
                {
                    string directoryToCreate = copyTo.Substring(0, copyTo.LastIndexOf('\\'));
                    Directory.CreateDirectory(directoryToCreate);
                    File.Copy(o.ToString(), copyTo, true);
                }
                backgroundWorker1.ReportProgress(1);
            }
        }
        private void error(int number)
        {
            switch (number)
            {
                case 0:
                    MessageBox.Show("В работе программы произошла ошибка. Попробуйте ввести главную директорию в формате - C:\\myfolder\\folder2", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    break;
                case 1:
                    MessageBox.Show("В работе программы произошла ошибка. Попробуйте ввести новую директорию в формате - C:\\myfolder\\folder2", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    break;
                case 2:
                    MessageBox.Show("В работе программы произошла ошибка. Попробуйте ввести директорию выхода в формате - C:\\myfolder\\folder2", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    break;
                case 3:
                    MessageBox.Show("Директории идентичны, действия не требуются.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    break;
                case 4:
                    MessageBox.Show("Задана несуществующая директория.Проверьте вводимые данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    break;
                case 5:
                    MessageBox.Show("Изменений или дополнений в новой директории относительно главной не найдено.Возможно, вы перепутали директории местами.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    break;
                case 6:
                    MessageBox.Show("Директория выхода не должна совпадать с другими директориями.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    break;
                case 7:
                    MessageBox.Show("Главная директория и новая директория не должны совпадать.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    break;
                default:
                    MessageBox.Show("В работе программы произошла непридвиденная ошибка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    break;
            }
        }

        private void saveMain_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.mainDirectory = mainDirectory.Text;
            Properties.Settings.Default.Save();
        }

        private void saveNew_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.newDirectory = newDirectory.Text;
            Properties.Settings.Default.Save();
        }

        private void saveOutput_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.outputDirectory = outputDirectory.Text;
            Properties.Settings.Default.Save();
        }  
    }
}
