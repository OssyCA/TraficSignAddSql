using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing.Imaging;

namespace TraficSignAddSql
{
    public partial class AddWithLinq : Form
    {
        private readonly LinqToSql dataContext;
        public AddWithLinq()
        {
            InitializeComponent();
            string con = ConfigurationManager.ConnectionStrings["TraficSignAddSql.Properties.Settings.OssmanDemoDBConnectionString"].ConnectionString;
            dataContext = new LinqToSql(con);

        }
        #region Methods
        private void AddSign()
        {
            if (nameTb.Text == null || picturePb.Image == null)
            {
                return;
            }
            Picture picture = new Picture
            {
                SignName = nameTb.Text
            };
            using (MemoryStream ms = new MemoryStream())
            {
                picturePb.Image.Save(ms, ImageFormat.Gif);
                var binary = new System.Data.Linq.Binary(ms.GetBuffer());
              //  picture.ImageSign = binary;
            }
            dataContext.Pictures.InsertOnSubmit(picture);
            dataContext.SubmitChanges();
            MessageBox.Show("Sign Added");
            nameTb.Clear();
            picturePb.Image = null;
        }
#pragma warning disable IDE0051 // Remove unused private members
        private void DeleteSign(int id)
#pragma warning restore IDE0051 // Remove unused private members
        {
            Picture picture = dataContext.Pictures.FirstOrDefault(sign => sign.Id == id);
            dataContext.Pictures.DeleteOnSubmit(picture);
            dataContext.SubmitChanges();
        }
        #endregion
        #region Btns
        private void OpenBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog // Open the Explorer
            {
                FileName = "", // whats in the search box/display filename 
                Filter = "Supported image| *.gif" // The text in the filter textbox
            };
            if (od.ShowDialog() == DialogResult.OK) // Return the selected object 
            {
                picturePb.Load(od.FileName); // Load the selected picture
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddSign();
        }
        #endregion
    }
}
