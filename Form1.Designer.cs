namespace IconMaker
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
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selectExportDirBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.selectFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFileBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectFileBtn.Location = new System.Drawing.Point(143, 173);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(209, 100);
            this.selectFileBtn.TabIndex = 0;
            this.selectFileBtn.Text = "Select File";
            this.selectFileBtn.UseVisualStyleBackColor = false;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFile);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Images|*.*";
            // 
            // selectExportDirBtn
            // 
            this.selectExportDirBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.selectExportDirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectExportDirBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectExportDirBtn.Location = new System.Drawing.Point(456, 173);
            this.selectExportDirBtn.Name = "selectExportDirBtn";
            this.selectExportDirBtn.Size = new System.Drawing.Size(209, 100);
            this.selectExportDirBtn.TabIndex = 1;
            this.selectExportDirBtn.Text = "Select Export Directory";
            this.selectExportDirBtn.UseVisualStyleBackColor = false;
            this.selectExportDirBtn.Click += new System.EventHandler(this.selectExportDir);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.selectExportDirBtn);
            this.Controls.Add(this.selectFileBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IcoMaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button selectExportDirBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

