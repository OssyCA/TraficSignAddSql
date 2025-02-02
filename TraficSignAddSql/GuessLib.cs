using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Diagnostics;

namespace TraficSignAddSql
{
    public class GuessLib
    {
        #region Fields
        // Connection string to the database
        private readonly string con;
        // Data context for LINQ to SQL operations
        private readonly LinqToSql dataContext;
        // Static field to keep track of the number of turns
        private static int turns = 10;
        // Property to store the correct answer
        public string CorrectAnswer { get; set; }
        // Static property to keep track of the turn counter
        public static int TurnCounter { get; set; }
        // Static property to keep track of the score
        public static int Score { get; set; }
        // Property to get or set the number of turns
        public static int Turns { get => turns; set => turns = value; }
        #endregion

        // Constructor to initialize the connection string and data context
        public GuessLib()
        {
            // Create Sql connection
            con = ConfigurationManager.ConnectionStrings["TraficSignAddSql.Properties.Settings.OssmanDemoDBConnectionString"].ConnectionString;
            dataContext = new LinqToSql(con);
        }

        #region Obj
        // Method to get the titles of all signs
        public List<string> SignTitle()
        {
            List<string> picName = new List<string>();
            try
            {
                // LINQ query to select all sign names from the Pictures table
                var SignTitle = from sign in dataContext.Pictures
                                select sign.SignName;

                // Add each sign name to the list
                foreach (var item in SignTitle)
                {
                    picName.Add(item);
                }
            }
            catch (Exception ex)
            {
                // In case of an exception, add the exception message to the list
                picName.Add(ex.Message);
            }

            return picName;
        }

        // Method to get the IDs of all signs
        public List<int> SignsID()
        {
            List<int> allsignId = new List<int>();
            try
            {
                // LINQ query to select all IDs from the Pictures table
                var Ids = from id in dataContext.Pictures
                          select id.Id;

                // Add each ID to the list
                foreach (var id in Ids)
                {
                    allsignId.Add(id);
                }
            }
            catch (Exception ex)
            {
                // In case of an exception, write the exception message to the debug output
                Debug.WriteLine(ex.Message);
            }
            return allsignId;
        }

        // Method to generate the image of a sign based on the correct answer
        public byte[] GenerateSignImage(string op1, string op2, string op3, string op4)
        {
            byte[] imageByte = null;

            // LINQ query to select the image of the sign that matches the correct answer
            var image = from im in dataContext.Pictures
                        where im.SignName == GetCorrectAnswer(op1, op2, op3, op4)
                        select im.ImageSign;

            // Assign the image byte array to the variable
            foreach (var item in image)
            {
                imageByte = item;
            }
            return imageByte;
        }

        // Method to randomly select the correct answer from four options
        public string GetCorrectAnswer(string op1, string op2, string op3, string op4)
        {
            Random rd = new Random();
            string[] options = { op1, op2, op3, op4 }; // Get name to get sign image from sql.
            return CorrectAnswer = options[rd.Next(0, 4)];
        }
        #endregion
    }
}
