
namespace TraficSignAddSql
{
    partial class Menu
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.GuessBtn = new System.Windows.Forms.Button();
            this.SqlLinqBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 78);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(126, 37);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add to Sql";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // GuessBtn
            // 
            this.GuessBtn.Location = new System.Drawing.Point(12, 155);
            this.GuessBtn.Name = "GuessBtn";
            this.GuessBtn.Size = new System.Drawing.Size(126, 37);
            this.GuessBtn.TabIndex = 1;
            this.GuessBtn.Text = "Guess ";
            this.GuessBtn.UseVisualStyleBackColor = true;
            this.GuessBtn.Click += new System.EventHandler(this.GuessBtn_Click);
            // 
            // SqlLinqBtn
            // 
            this.SqlLinqBtn.Location = new System.Drawing.Point(12, 234);
            this.SqlLinqBtn.Name = "SqlLinqBtn";
            this.SqlLinqBtn.Size = new System.Drawing.Size(126, 37);
            this.SqlLinqBtn.TabIndex = 2;
            this.SqlLinqBtn.Text = "SQL LINQ";
            this.SqlLinqBtn.UseVisualStyleBackColor = true;
            this.SqlLinqBtn.Click += new System.EventHandler(this.SqlLinqBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 328);
            this.Controls.Add(this.SqlLinqBtn);
            this.Controls.Add(this.GuessBtn);
            this.Controls.Add(this.AddBtn);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button GuessBtn;
        private System.Windows.Forms.Button SqlLinqBtn;
    }
}