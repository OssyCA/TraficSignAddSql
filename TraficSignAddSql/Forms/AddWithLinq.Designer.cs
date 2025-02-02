
namespace TraficSignAddSql
{
    partial class AddWithLinq
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
            this.picturePb = new System.Windows.Forms.PictureBox();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturePb)).BeginInit();
            this.SuspendLayout();
            // 
            // picturePb
            // 
            this.picturePb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePb.Location = new System.Drawing.Point(93, 12);
            this.picturePb.Name = "picturePb";
            this.picturePb.Size = new System.Drawing.Size(224, 189);
            this.picturePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picturePb.TabIndex = 0;
            this.picturePb.TabStop = false;
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(12, 12);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenBtn.TabIndex = 1;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(242, 206);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(93, 209);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(143, 20);
            this.nameTb.TabIndex = 3;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(242, 249);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 21);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // AddWithLinq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 296);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.picturePb);
            this.Name = "AddWithLinq";
            this.Text = "AddWithLinq";
            ((System.ComponentModel.ISupportInitialize)(this.picturePb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePb;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Button DeleteBtn;
    }
}