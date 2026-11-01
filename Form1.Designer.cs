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
            this.loaderPic = new System.Windows.Forms.PictureBox();
            this.mainDirectorySetButton = new System.Windows.Forms.Button();
            this.newDirectorySetButton = new System.Windows.Forms.Button();
            this.outputDirectorySetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loaderPic)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDirectory
            // 
            this.mainDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainDirectory.Location = new System.Drawing.Point(236, 27);
            this.mainDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.mainDirectory.Name = "mainDirectory";
            this.mainDirectory.Size = new System.Drawing.Size(313, 26);
            this.mainDirectory.TabIndex = 0;
            // 
            // newDirectory
            // 
            this.newDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newDirectory.Location = new System.Drawing.Point(236, 75);
            this.newDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.newDirectory.Name = "newDirectory";
            this.newDirectory.Size = new System.Drawing.Size(313, 26);
            this.newDirectory.TabIndex = 1;
            // 
            // outputDirectory
            // 
            this.outputDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputDirectory.Location = new System.Drawing.Point(236, 156);
            this.outputDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.outputDirectory.Name = "outputDirectory";
            this.outputDirectory.Size = new System.Drawing.Size(313, 26);
            this.outputDirectory.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Main directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "New directory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
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
            // mainDirectorySetButton
            // 
            this.mainDirectorySetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainDirectorySetButton.Location = new System.Drawing.Point(553, 22);
            this.mainDirectorySetButton.Margin = new System.Windows.Forms.Padding(2);
            this.mainDirectorySetButton.Name = "mainDirectorySetButton";
            this.mainDirectorySetButton.Size = new System.Drawing.Size(36, 36);
            this.mainDirectorySetButton.TabIndex = 12;
            this.mainDirectorySetButton.Text = "📁";
            this.mainDirectorySetButton.UseVisualStyleBackColor = true;
            this.mainDirectorySetButton.Click += new System.EventHandler(this.mainDirectorySetButton_Click);
            // 
            // newDirectorySetButton
            // 
            this.newDirectorySetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newDirectorySetButton.Location = new System.Drawing.Point(553, 70);
            this.newDirectorySetButton.Margin = new System.Windows.Forms.Padding(2);
            this.newDirectorySetButton.Name = "newDirectorySetButton";
            this.newDirectorySetButton.Size = new System.Drawing.Size(36, 36);
            this.newDirectorySetButton.TabIndex = 13;
            this.newDirectorySetButton.Text = "📁";
            this.newDirectorySetButton.UseVisualStyleBackColor = true;
            this.newDirectorySetButton.Click += new System.EventHandler(this.newDirectorySetButton_Click);
            // 
            // outputDirectorySetButton
            // 
            this.outputDirectorySetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputDirectorySetButton.Location = new System.Drawing.Point(553, 151);
            this.outputDirectorySetButton.Margin = new System.Windows.Forms.Padding(2);
            this.outputDirectorySetButton.Name = "outputDirectorySetButton";
            this.outputDirectorySetButton.Size = new System.Drawing.Size(36, 36);
            this.outputDirectorySetButton.TabIndex = 14;
            this.outputDirectorySetButton.Text = "📁";
            this.outputDirectorySetButton.UseVisualStyleBackColor = true;
            this.outputDirectorySetButton.Click += new System.EventHandler(this.outputDirectorySetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 286);
            this.Controls.Add(this.outputDirectorySetButton);
            this.Controls.Add(this.newDirectorySetButton);
            this.Controls.Add(this.mainDirectorySetButton);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(616, 325);
            this.MinimumSize = new System.Drawing.Size(616, 325);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unique files catcher";
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
        private System.Windows.Forms.Button mainDirectorySetButton;
        private System.Windows.Forms.Button newDirectorySetButton;
        private System.Windows.Forms.Button outputDirectorySetButton;
    }
}

