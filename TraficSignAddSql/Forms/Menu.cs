using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraficSignAddSql
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddToSql addToSql = new AddToSql();
            addToSql.ShowDialog();
            
        }
        private void GuessBtn_Click(object sender, EventArgs e)
        {
            GuessPic guessPic = new GuessPic();
            guessPic.ShowDialog();
        }

        private void SqlLinqBtn_Click(object sender, EventArgs e)
        {
            AddWithLinq linqToSql = new AddWithLinq();
            linqToSql.ShowDialog();
        }
    }
}
