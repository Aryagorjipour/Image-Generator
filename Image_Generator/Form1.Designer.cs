namespace Image_Generator
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNames = new System.Windows.Forms.TextBox();
            this.btnStartGenerate = new System.Windows.Forms.Button();
            this.OpnFile = new System.Windows.Forms.OpenFileDialog();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.fontDFontFam = new System.Windows.Forms.FontDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDFont = new System.Windows.Forms.ColorDialog();
            this.flderbrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImage.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnChooseImage.Location = new System.Drawing.Point(579, 12);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(237, 35);
            this.btnChooseImage.TabIndex = 0;
            this.btnChooseImage.Text = "عکس خود را انتخاب کنید";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.BtnChooseImage_Click);
            // 
            // picBox
            // 
            this.picBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picBox.Location = new System.Drawing.Point(410, 106);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(406, 264);
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            this.picBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PicBox_Paint);
            this.picBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicBox_MouseDown);
            this.picBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicBox_MouseMove);
            this.picBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicBox_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = ": رنگ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNames
            // 
            this.txtNames.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNames.Location = new System.Drawing.Point(12, 106);
            this.txtNames.Multiline = true;
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(392, 264);
            this.txtNames.TabIndex = 5;
            this.txtNames.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnStartGenerate
            // 
            this.btnStartGenerate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStartGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGenerate.ForeColor = System.Drawing.Color.Black;
            this.btnStartGenerate.Location = new System.Drawing.Point(263, 376);
            this.btnStartGenerate.Name = "btnStartGenerate";
            this.btnStartGenerate.Size = new System.Drawing.Size(291, 35);
            this.btnStartGenerate.TabIndex = 6;
            this.btnStartGenerate.Text = "شروع ساخت";
            this.btnStartGenerate.UseVisualStyleBackColor = true;
            this.btnStartGenerate.Click += new System.EventHandler(this.BtnStartGenerate_Click);
            // 
            // OpnFile
            // 
            this.OpnFile.FileName = "Choose Your Image";
            // 
            // btnFont
            // 
            this.btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFont.Location = new System.Drawing.Point(13, 12);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(113, 41);
            this.btnFont.TabIndex = 7;
            this.btnFont.Text = "انتخاب قلم";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.BtnFont_Click);
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(13, 59);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(113, 41);
            this.btnColor.TabIndex = 9;
            this.btnColor.Text = "انتخاب رنگ";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = ": انتخاب قلم و اندازه";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(434, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Copyright © 2020 , all rights reserved. Developed by Arya Gorjipour";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 443);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnStartGenerate);
            this.Controls.Add(this.txtNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnChooseImage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(844, 482);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(844, 482);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNames;
        private System.Windows.Forms.Button btnStartGenerate;
        private System.Windows.Forms.OpenFileDialog OpnFile;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.FontDialog fontDFontFam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDFont;
        private System.Windows.Forms.FolderBrowserDialog flderbrowser;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
    }
}

