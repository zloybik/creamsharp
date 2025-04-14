namespace Creamsharp
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
            this.downloadButton = new System.Windows.Forms.Button();
            this.countDownloadedFilesLabel = new System.Windows.Forms.Label();
            this.progressBarOfDownloading = new System.Windows.Forms.ProgressBar();
            this.PClabeldownloaded = new System.Windows.Forms.Label();
            this.textBoxTags = new System.Windows.Forms.TextBox();
            this.richBoxTags = new System.Windows.Forms.RichTextBox();
            this.buttonAcceptTag = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDelteAllTags = new System.Windows.Forms.Button();
            this.checkBoxShowTags = new System.Windows.Forms.CheckBox();
            this.numericLimitCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericLimitCount)).BeginInit();
            this.SuspendLayout();
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(329, 349);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(138, 89);
            this.downloadButton.TabIndex = 0;
            this.downloadButton.Text = "downloadButton";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // countDownloadedFilesLabel
            // 
            this.countDownloadedFilesLabel.AutoSize = true;
            this.countDownloadedFilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.countDownloadedFilesLabel.Location = new System.Drawing.Point(712, 59);
            this.countDownloadedFilesLabel.Name = "countDownloadedFilesLabel";
            this.countDownloadedFilesLabel.Size = new System.Drawing.Size(29, 31);
            this.countDownloadedFilesLabel.TabIndex = 1;
            this.countDownloadedFilesLabel.Text = "0";
            // 
            // progressBarOfDownloading
            // 
            this.progressBarOfDownloading.Location = new System.Drawing.Point(580, 109);
            this.progressBarOfDownloading.Name = "progressBarOfDownloading";
            this.progressBarOfDownloading.Size = new System.Drawing.Size(185, 23);
            this.progressBarOfDownloading.TabIndex = 2;
            // 
            // PClabeldownloaded
            // 
            this.PClabeldownloaded.AutoSize = true;
            this.PClabeldownloaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PClabeldownloaded.Location = new System.Drawing.Point(584, 59);
            this.PClabeldownloaded.Name = "PClabeldownloaded";
            this.PClabeldownloaded.Size = new System.Drawing.Size(122, 31);
            this.PClabeldownloaded.TabIndex = 3;
            this.PClabeldownloaded.Text = "Скачано";
            // 
            // textBoxTags
            // 
            this.textBoxTags.Location = new System.Drawing.Point(48, 134);
            this.textBoxTags.Name = "textBoxTags";
            this.textBoxTags.Size = new System.Drawing.Size(100, 20);
            this.textBoxTags.TabIndex = 4;
            // 
            // richBoxTags
            // 
            this.richBoxTags.Location = new System.Drawing.Point(48, 295);
            this.richBoxTags.Name = "richBoxTags";
            this.richBoxTags.ReadOnly = true;
            this.richBoxTags.Size = new System.Drawing.Size(188, 57);
            this.richBoxTags.TabIndex = 5;
            this.richBoxTags.Text = "";
            this.richBoxTags.Visible = false;
            // 
            // buttonAcceptTag
            // 
            this.buttonAcceptTag.Location = new System.Drawing.Point(48, 160);
            this.buttonAcceptTag.Name = "buttonAcceptTag";
            this.buttonAcceptTag.Size = new System.Drawing.Size(75, 23);
            this.buttonAcceptTag.TabIndex = 6;
            this.buttonAcceptTag.Text = "Add Tag";
            this.buttonAcceptTag.UseVisualStyleBackColor = true;
            this.buttonAcceptTag.Click += new System.EventHandler(this.buttonAcceptTag_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(42, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Tag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(164, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Delete All Tags";
            // 
            // buttonDelteAllTags
            // 
            this.buttonDelteAllTags.Location = new System.Drawing.Point(217, 160);
            this.buttonDelteAllTags.Name = "buttonDelteAllTags";
            this.buttonDelteAllTags.Size = new System.Drawing.Size(75, 23);
            this.buttonDelteAllTags.TabIndex = 9;
            this.buttonDelteAllTags.Text = "Delete tags";
            this.buttonDelteAllTags.UseVisualStyleBackColor = true;
            this.buttonDelteAllTags.Click += new System.EventHandler(this.buttonDelteAllTags_Click);
            // 
            // checkBoxShowTags
            // 
            this.checkBoxShowTags.AutoSize = true;
            this.checkBoxShowTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.checkBoxShowTags.Location = new System.Drawing.Point(67, 254);
            this.checkBoxShowTags.Name = "checkBoxShowTags";
            this.checkBoxShowTags.Size = new System.Drawing.Size(169, 35);
            this.checkBoxShowTags.TabIndex = 10;
            this.checkBoxShowTags.Text = "Show Tags";
            this.checkBoxShowTags.UseVisualStyleBackColor = true;
            this.checkBoxShowTags.CheckedChanged += new System.EventHandler(this.checkBoxShowTags_CheckedChanged);
            // 
            // numericLimitCount
            // 
            this.numericLimitCount.Location = new System.Drawing.Point(395, 163);
            this.numericLimitCount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericLimitCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericLimitCount.Name = "numericLimitCount";
            this.numericLimitCount.Size = new System.Drawing.Size(120, 20);
            this.numericLimitCount.TabIndex = 11;
            this.numericLimitCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(410, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Limit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericLimitCount);
            this.Controls.Add(this.checkBoxShowTags);
            this.Controls.Add(this.buttonDelteAllTags);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAcceptTag);
            this.Controls.Add(this.richBoxTags);
            this.Controls.Add(this.textBoxTags);
            this.Controls.Add(this.PClabeldownloaded);
            this.Controls.Add(this.progressBarOfDownloading);
            this.Controls.Add(this.countDownloadedFilesLabel);
            this.Controls.Add(this.downloadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericLimitCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Label countDownloadedFilesLabel;
        private System.Windows.Forms.ProgressBar progressBarOfDownloading;
        private System.Windows.Forms.Label PClabeldownloaded;
        private System.Windows.Forms.TextBox textBoxTags;
        private System.Windows.Forms.RichTextBox richBoxTags;
        private System.Windows.Forms.Button buttonAcceptTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDelteAllTags;
        private System.Windows.Forms.CheckBox checkBoxShowTags;
        private System.Windows.Forms.NumericUpDown numericLimitCount;
        private System.Windows.Forms.Label label3;
    }
}

