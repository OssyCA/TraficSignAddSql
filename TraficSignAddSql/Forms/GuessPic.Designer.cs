
namespace TraficSignAddSql
{
    partial class GuessPic
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
            this.signPb = new System.Windows.Forms.PictureBox();
            this.GuessBtn = new System.Windows.Forms.Button();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd4 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.countLbl = new System.Windows.Forms.Label();
            this.ResetTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.signPb)).BeginInit();
            this.SuspendLayout();
            // 
            // signPb
            // 
            this.signPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signPb.Location = new System.Drawing.Point(12, 41);
            this.signPb.Name = "signPb";
            this.signPb.Size = new System.Drawing.Size(280, 179);
            this.signPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.signPb.TabIndex = 0;
            this.signPb.TabStop = false;
            // 
            // GuessBtn
            // 
            this.GuessBtn.Location = new System.Drawing.Point(28, 376);
            this.GuessBtn.Name = "GuessBtn";
            this.GuessBtn.Size = new System.Drawing.Size(85, 23);
            this.GuessBtn.TabIndex = 1;
            this.GuessBtn.Text = "Guess";
            this.GuessBtn.UseVisualStyleBackColor = true;
            this.GuessBtn.Click += new System.EventHandler(this.GuessBtn_Click);
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Location = new System.Drawing.Point(12, 240);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(31, 17);
            this.rd1.TabIndex = 3;
            this.rd1.TabStop = true;
            this.rd1.Text = "1";
            this.rd1.UseVisualStyleBackColor = true;
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Location = new System.Drawing.Point(12, 274);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(31, 17);
            this.rd2.TabIndex = 4;
            this.rd2.TabStop = true;
            this.rd2.Text = "2";
            this.rd2.UseVisualStyleBackColor = true;
            // 
            // rd4
            // 
            this.rd4.AutoSize = true;
            this.rd4.Location = new System.Drawing.Point(12, 344);
            this.rd4.Name = "rd4";
            this.rd4.Size = new System.Drawing.Size(31, 17);
            this.rd4.TabIndex = 5;
            this.rd4.TabStop = true;
            this.rd4.Text = "4";
            this.rd4.UseVisualStyleBackColor = true;
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.Location = new System.Drawing.Point(12, 310);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(31, 17);
            this.rd3.TabIndex = 6;
            this.rd3.TabStop = true;
            this.rd3.Text = "3";
            this.rd3.UseVisualStyleBackColor = true;
            // 
            // countLbl
            // 
            this.countLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countLbl.AutoSize = true;
            this.countLbl.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLbl.Location = new System.Drawing.Point(246, 13);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(43, 19);
            this.countLbl.TabIndex = 8;
            this.countLbl.Text = "0/10";
            // 
            // ResetTest
            // 
            this.ResetTest.Location = new System.Drawing.Point(168, 12);
            this.ResetTest.Name = "ResetTest";
            this.ResetTest.Size = new System.Drawing.Size(75, 23);
            this.ResetTest.TabIndex = 9;
            this.ResetTest.Text = "Reset";
            this.ResetTest.UseVisualStyleBackColor = true;
            this.ResetTest.Click += new System.EventHandler(this.ResetTest_Click);
            // 
            // GuessPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(333, 424);
            this.Controls.Add(this.ResetTest);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.rd3);
            this.Controls.Add(this.rd4);
            this.Controls.Add(this.rd2);
            this.Controls.Add(this.rd1);
            this.Controls.Add(this.GuessBtn);
            this.Controls.Add(this.signPb);
            this.Name = "GuessPic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuessPic";
            ((System.ComponentModel.ISupportInitialize)(this.signPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox signPb;
        private System.Windows.Forms.Button GuessBtn;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd4;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Button ResetTest;
    }
}