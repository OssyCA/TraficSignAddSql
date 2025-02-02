using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraficSignAddSql
{
    public partial class AddToSql : Form
    {
        private readonly SqlConnection con;
        private readonly string connectionString = 
            "Data Source=DESKTOP-0Q2CI4E\\OSSYSQL;Initial Catalog=OssmanDemoDB;Persist Security Info=True;User ID=sa;Password=pispotta12";
        
        public AddToSql()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString); // Creating the connection
            ShowAllSignNames();  
        }
        #region Methods
        private void AddToSql_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }
        private void UpdateDataGridView()
        {
            try
            {
                var ossmanDemoDBDataSet1 = new OssmanDemoDBDataSet1();
                ossmanDemoDBDataSet1.EnforceConstraints = false;
                // TODO: This line of code loads data into the 'ossmanDemoDBDataSet1.Picture' table. You can move, or remove it, as needed
                var pictureTableAdapter = new OssmanDemoDBDataSet1TableAdapters.PictureTableAdapter();
                pictureTableAdapter.Fill(ossmanDemoDBDataSet1.Picture);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        private void ShowAllSignNames()
        {
            // All Names for signs
            con.Open();
            string query = "select SignName from Picture";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
            using (sqlDataAdapter)
            {
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                listBox1.DataSource = dataTable;
                listBox1.DisplayMember = "SignName";
                countLbl.Text = listBox1.Items.Count.ToString();

            }
            con.Close();
        }
        private void AddPictureAndName()
        {
            if (addToDbPb.Image == null)
            {
                return;
            }
            if (nameTb.Text == null)
            {
                return;
            }
            con.Open(); // opens the connectionm
            SqlCommand command = con.CreateCommand(); // CreateCommaand to send to sql
            var image = new ImageConverter().ConvertTo(addToDbPb.Image, typeof(byte[])); // Convert Image
            command.Parameters.AddWithValue("@imageSign", image);
            command.Parameters.AddWithValue("@SignName", nameTb.Text);
            command.CommandText = "INSERT INTO Picture (imageSign, SignName) VALUES(@imageSign, @SignName)";
            if (command.ExecuteNonQuery() > 0)
            {
                UpdateDataGridView(); // update the datagridVieww
            }
            else
            {
                MessageBox.Show("image NOT Added");
            }
            con.Close();
        }
        private void ClearUi()
        {
            answerTb.Clear();
            dbPicBox.Image = null;
            addToDbPb.Image = null;
            nameTb.Clear();
            sqlTb.Clear();
        }
        #endregion
        #region Buttons
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog // Open the Explorer
            {
                FileName = "", // whats in the search box/display filename 
                Filter = "Supported image| *.gif" // The text in the filter textbox
            };
            if (od.ShowDialog() == DialogResult.OK) // Return the selected object 
            {
                addToDbPb.Load(od.FileName); // Load the selected picture
            }
        } // Load pic to first picbox
        private void FetchBtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = con.CreateCommand();
            con.Open();
            command.Parameters.AddWithValue("@id", sqlTb.Text);
            command.CommandText = "SELECT * FROM Picture WHERE id = @id";
            SqlDataReader sqlDataReader = command.ExecuteReader();
            try
            {
                if (sqlDataReader.Read())
                {
                    Image im;
                    MemoryStream ms = new MemoryStream(sqlDataReader.GetSqlBytes(1).Buffer);
                    im = Image.FromStream(ms);
                    dbPicBox.Image = im;

                }
                else
                {
                    MessageBox.Show("Cant find Pic");
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message + " FetchBtn Error");
            }
            sqlTb.Clear();
            con.Close();
        }  // Fetch the pic with Id
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                // No row selected, no delete.
                return;
            }
            string query = "DELETE FROM Picture WHERE Id = @Id";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Please ensure that your datagrid property for SelectionMode is set to 'FullRowSelect

                    con.Open();
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    // gets the RowID from the first column in the grid
                    int rowID = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);

                    cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = rowID; // Gets the selected row int sql form
                    cmd.ExecuteScalar();
                    // Remove the data from datagrindViw
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                    UpdateDataGridView();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Delete error");
            }
            finally
            {
                //DisplayAllId();
                con.Close();
            }
        } // Delete from database
        private void NameBtn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Picture Set SignName = @SignName WHERE Id = @Id";
            try
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                // gets the RowID from the first column in the grid
                int rowID = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = rowID;
                    cmd.Parameters.AddWithValue("@SignName", $"{nameTb.Text}");
                    cmd.ExecuteScalar();
                    UpdateDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            nameTb.Clear();
        } // Update the name for pic
        private void FindIdBtn_Click(object sender, EventArgs e)
        {
            // Searth for Name of sign and if found messegebox tell user.
            SqlCommand command = con.CreateCommand();
            con.Open();
            command.Parameters.AddWithValue("@SignName", answerTb.Text);
            command.CommandText = "SELECT * FROM Picture WHERE SignName = @SignName";
            SqlDataReader sqlDataReader = command.ExecuteReader();

            try
            {
                if (sqlDataReader.Read())
                {
                    MessageBox.Show("RIGHT");
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message + " Answer Error");
            }
            con.Close();
        } // Show if right aswer with messegebox
        private void RightBtn_Click(object sender, EventArgs e)
        {
            // FEtch Picture depending on whats typed in textbox
            SqlCommand command = con.CreateCommand();
            con.Open();
            command.Parameters.AddWithValue("@SignName", answerTb.Text);
            command.CommandText = "SELECT * FROM Picture WHERE SignName = @SignName";
            SqlDataReader sqlDataReader = command.ExecuteReader();
            try
            {
                if (sqlDataReader.Read())
                {
                    MemoryStream ms = new MemoryStream(sqlDataReader.GetSqlBytes(1).Buffer);
                    dbPicBox.Image = Image.FromStream(ms);
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
            con.Close();
        } // Place Pic in picbox when you seartch for name.
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearUi();
        }
        private void Addbtn_Click_1(object sender, EventArgs e)
        {
            AddPictureAndName();
            ClearUi();
        }
        #endregion
        #region OldBtns
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (addToDbPb.Image == null)
            {
                return;
            }

            con.Open(); // opens the connectionm
            SqlCommand command = con.CreateCommand(); // CreateCommaand to send to sql
            var image = new ImageConverter().ConvertTo(addToDbPb.Image, typeof(byte[])); // Convert Image
            command.Parameters.AddWithValue("@imageSign", image);
            command.CommandText = "INSERT INTO Picture (imageSign) VALUES(@imageSign)";
            if (command.ExecuteNonQuery() > 0)
            {
                UpdateDataGridView(); // update the datagridVieww
            }
            else
            {
                MessageBox.Show("image NOT Added");
            }
            con.Close();
        } // Add to ddatabase
        #endregion
    }
}
