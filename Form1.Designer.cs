namespace unique_files
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainDirectory = new System.Windows.Forms.TextBox();
            this.newDirectory = new System.Windows.Forms.TextBox();
            this.outputDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.proceed = new System.Windows.Forms.Button();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.progressCoutLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveMain = new System.Windows.Forms.Button();
            this.loaderPic = new System.Windows.Forms.PictureBox();
            this.saveNew = new System.Windows.Forms.Button();
            this.saveOutput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loaderPic)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDirectory
            // 
            this.mainDirectory.Location = new System.Drawing.Point(272, 27);
            this.mainDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.mainDirectory.Name = "mainDirectory";
            this.mainDirectory.Size = new System.Drawing.Size(302, 20);
            this.mainDirectory.TabIndex = 0;
            // 
            // newDirectory
            // 
            this.newDirectory.Location = new System.Drawing.Point(272, 75);
            this.newDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.newDirectory.Name = "newDirectory";
            this.newDirectory.Size = new System.Drawing.Size(302, 20);
            this.newDirectory.TabIndex = 1;
            // 
            // outputDirectory
            // 
            this.outputDirectory.Location = new System.Drawing.Point(272, 165);
            this.outputDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.outputDirectory.Name = "outputDirectory";
            this.outputDirectory.Size = new System.Drawing.Size(302, 20);
            this.outputDirectory.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Main directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "New directory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output directory";
            // 
            // proceed
            // 
            this.proceed.Location = new System.Drawing.Point(27, 209);
            this.proceed.Margin = new System.Windows.Forms.Padding(2);
            this.proceed.Name = "proceed";
            this.proceed.Size = new System.Drawing.Size(547, 39);
            this.proceed.TabIndex = 6;
            this.proceed.Text = "Extract different files";
            this.proceed.UseVisualStyleBackColor = true;
            this.proceed.Click += new System.EventHandler(this.proceed_Click);
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.loadingLabel.Location = new System.Drawing.Point(66, 261);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(51, 13);
            this.loadingLabel.TabIndex = 10;
            this.loadingLabel.Text = "Progress:";
            this.loadingLabel.Visible = false;
            // 
            // progressCoutLabel
            // 
            this.progressCoutLabel.AutoSize = true;
            this.progressCoutLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.progressCoutLabel.Location = new System.Drawing.Point(114, 261);
            this.progressCoutLabel.Name = "progressCoutLabel";
            this.progressCoutLabel.Size = new System.Drawing.Size(24, 13);
            this.progressCoutLabel.TabIndex = 11;
            this.progressCoutLabel.Text = "0/0";
            this.progressCoutLabel.Visible = false;
            // 
            // saveMain
            // 
            this.saveMain.FlatAppearance.BorderSize = 0;
            this.saveMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveMain.Image = global::unique_files.Properties.Resources.save;
            this.saveMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveMain.Location = new System.Drawing.Point(237, 14);
            this.saveMain.Name = "saveMain";
            this.saveMain.Size = new System.Drawing.Size(30, 44);
            this.saveMain.TabIndex = 12;
            this.saveMain.UseVisualStyleBackColor = true;
            this.saveMain.Click += new System.EventHandler(this.saveMain_Click);
            // 
            // loaderPic
            // 
            this.loaderPic.Image = global::unique_files.Properties.Resources.loader;
            this.loaderPic.Location = new System.Drawing.Point(-18, 227);
            this.loaderPic.Name = "loaderPic";
            this.loaderPic.Size = new System.Drawing.Size(124, 82);
            this.loaderPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loaderPic.TabIndex = 9;
            this.loaderPic.TabStop = false;
            this.loaderPic.Visible = false;
            // 
            // saveNew
            // 
            this.saveNew.FlatAppearance.BorderSize = 0;
            this.saveNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveNew.Image = global::unique_files.Properties.Resources.save;
            this.saveNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveNew.Location = new System.Drawing.Point(237, 64);
            this.saveNew.Name = "saveNew";
            this.saveNew.Size = new System.Drawing.Size(30, 44);
            this.saveNew.TabIndex = 13;
            this.saveNew.UseVisualStyleBackColor = true;
            this.saveNew.Click += new System.EventHandler(this.saveNew_Click);
            // 
            // saveOutput
            // 
            this.saveOutput.FlatAppearance.BorderSize = 0;
            this.saveOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveOutput.Image = global::unique_files.Properties.Resources.save;
            this.saveOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveOutput.Location = new System.Drawing.Point(237, 152);
            this.saveOutput.Name = "saveOutput";
            this.saveOutput.Size = new System.Drawing.Size(30, 44);
            this.saveOutput.TabIndex = 14;
            this.saveOutput.UseVisualStyleBackColor = true;
            this.saveOutput.Click += new System.EventHandler(this.saveOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 286);
            this.Controls.Add(this.progressCoutLabel);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.proceed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputDirectory);
            this.Controls.Add(this.newDirectory);
            this.Controls.Add(this.mainDirectory);
            this.Controls.Add(this.loaderPic);
            this.Controls.Add(this.saveMain);
            this.Controls.Add(this.saveNew);
            this.Controls.Add(this.saveOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(616, 325);
            this.MinimumSize = new System.Drawing.Size(616, 325);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DFE";
            ((System.ComponentModel.ISupportInitialize)(this.loaderPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainDirectory;
        private System.Windows.Forms.TextBox newDirectory;
        private System.Windows.Forms.TextBox outputDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button proceed;
        private System.Windows.Forms.PictureBox loaderPic;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.Label progressCoutLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button saveMain;
        private System.Windows.Forms.Button saveNew;
        private System.Windows.Forms.Button saveOutput;
    }
}

