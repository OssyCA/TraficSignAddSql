
namespace TraficSignAddSql
{
    partial class AddToSql
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
            this.components = new System.ComponentModel.Container();
            this.addToDbPb = new System.Windows.Forms.PictureBox();
            this.dbPicBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FetchBtn = new System.Windows.Forms.Button();
            this.sqlTb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.NameBtn = new System.Windows.Forms.Button();
            this.answerTb = new System.Windows.Forms.TextBox();
            this.FindIdBtn = new System.Windows.Forms.Button();
            this.RightBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.countLbl = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addToDbPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addToDbPb
            // 
            this.addToDbPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addToDbPb.Location = new System.Drawing.Point(34, 21);
            this.addToDbPb.Name = "addToDbPb";
            this.addToDbPb.Size = new System.Drawing.Size(184, 160);
            this.addToDbPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addToDbPb.TabIndex = 0;
            this.addToDbPb.TabStop = false;
            // 
            // dbPicBox
            // 
            this.dbPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dbPicBox.Location = new System.Drawing.Point(242, 21);
            this.dbPicBox.Name = "dbPicBox";
            this.dbPicBox.Size = new System.Drawing.Size(184, 160);
            this.dbPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dbPicBox.TabIndex = 1;
            this.dbPicBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // FetchBtn
            // 
            this.FetchBtn.Location = new System.Drawing.Point(351, 191);
            this.FetchBtn.Name = "FetchBtn";
            this.FetchBtn.Size = new System.Drawing.Size(75, 23);
            this.FetchBtn.TabIndex = 4;
            this.FetchBtn.Text = "Fetch";
            this.FetchBtn.UseVisualStyleBackColor = true;
            this.FetchBtn.Click += new System.EventHandler(this.FetchBtn_Click);
            // 
            // sqlTb
            // 
            this.sqlTb.Location = new System.Drawing.Point(242, 191);
            this.sqlTb.Name = "sqlTb";
            this.sqlTb.Size = new System.Drawing.Size(100, 20);
            this.sqlTb.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.pictureBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(348, 160);
            this.dataGridView1.TabIndex = 6;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(307, 408);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(34, 411);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(100, 20);
            this.nameTb.TabIndex = 8;
            // 
            // NameBtn
            // 
            this.NameBtn.Location = new System.Drawing.Point(307, 437);
            this.NameBtn.Name = "NameBtn";
            this.NameBtn.Size = new System.Drawing.Size(75, 23);
            this.NameBtn.TabIndex = 9;
            this.NameBtn.Text = "NAME";
            this.NameBtn.UseVisualStyleBackColor = true;
            this.NameBtn.Click += new System.EventHandler(this.NameBtn_Click);
            // 
            // answerTb
            // 
            this.answerTb.Location = new System.Drawing.Point(432, 23);
            this.answerTb.Name = "answerTb";
            this.answerTb.Size = new System.Drawing.Size(64, 20);
            this.answerTb.TabIndex = 10;
            // 
            // FindIdBtn
            // 
            this.FindIdBtn.Location = new System.Drawing.Point(432, 49);
            this.FindIdBtn.Name = "FindIdBtn";
            this.FindIdBtn.Size = new System.Drawing.Size(64, 23);
            this.FindIdBtn.TabIndex = 11;
            this.FindIdBtn.TabStop = false;
            this.FindIdBtn.Text = "ANSWER";
            this.FindIdBtn.UseVisualStyleBackColor = true;
            this.FindIdBtn.Click += new System.EventHandler(this.FindIdBtn_Click);
            // 
            // RightBtn
            // 
            this.RightBtn.Location = new System.Drawing.Point(432, 78);
            this.RightBtn.Name = "RightBtn";
            this.RightBtn.Size = new System.Drawing.Size(64, 23);
            this.RightBtn.TabIndex = 15;
            this.RightBtn.Text = "RIGHT";
            this.RightBtn.UseVisualStyleBackColor = true;
            this.RightBtn.Click += new System.EventHandler(this.RightBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(388, 245);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 160);
            this.listBox1.TabIndex = 17;
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Location = new System.Drawing.Point(514, 245);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(19, 13);
            this.countLbl.TabIndex = 23;
            this.countLbl.Text = "00";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(433, 437);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 24;
            this.ClearBtn.Text = "Clear UI";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(140, 408);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 23);
            this.Addbtn.TabIndex = 25;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click_1);
            // 
            // AddToSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 509);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.RightBtn);
            this.Controls.Add(this.FindIdBtn);
            this.Controls.Add(this.answerTb);
            this.Controls.Add(this.NameBtn);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sqlTb);
            this.Controls.Add(this.FetchBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dbPicBox);
            this.Controls.Add(this.addToDbPb);
            this.Name = "AddToSql";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Signs";
            this.Load += new System.EventHandler(this.AddToSql_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addToDbPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox addToDbPb;
        private System.Windows.Forms.PictureBox dbPicBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button FetchBtn;
        private System.Windows.Forms.TextBox sqlTb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Button NameBtn;
        private System.Windows.Forms.BindingSource pictureBindingSource;
        private System.Windows.Forms.TextBox answerTb;
        private System.Windows.Forms.Button FindIdBtn;
        private System.Windows.Forms.Button RightBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button Addbtn;
    }
}

