using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraficSignAddSql
{
    public partial class GuessPic : Form
    {
        private readonly GuessLib guessLib = new GuessLib();
        public GuessPic()
        {
            InitializeComponent();
            ResetTest.Visible = false;
            GuessLib.TurnCounter = 1;
            countLbl.Text = $"{GuessLib.TurnCounter}/10";
            GenerateQuestion();
        }
        private void NextQuestion()

        {
            foreach (var rd in RadioButtons())
            {
                rd.BackColor = default; // Reset color.
            }
            if (GuessLib.TurnCounter < GuessLib.Turns)
            {
                GuessBtn.Enabled = true;
                GuessLib.TurnCounter++;
                countLbl.Text = $"{GuessLib.TurnCounter}/{GuessLib.Turns}";
                GenerateQuestion();
            }
            else
            {
                Finished();
            } 
        }
        private void GenerateQuestion()
        {
            // Setting buttons.Texts to random signs Name
            Random rd = new Random();
            int x = guessLib.SignsID().Count - 1;

            foreach (var item in RadioButtons())
            {
                item.Checked = false;
                item.Text = guessLib.SignTitle()[rd.Next(0, x)]; // Get a random description/option from sql
            }
            signPb.Image = ByteArrayToImage(guessLib.GenerateSignImage(rd1.Text, rd2.Text, rd3.Text, rd4.Text));
        }
        private void Guess(string guess, RadioButton radio)
        {
            if (guess == guessLib.CorrectAnswer)
            {
                radio.BackColor = Color.Green;
                GuessLib.Score++;
            }
            else
            {
                radio.BackColor = Color.Red;
                foreach (var rd in RadioButtons())
                {
                    // Loop through all radioBtns and set the correct one green.
                    if (rd.Text == guessLib.CorrectAnswer)
                    {
                        rd.BackColor = Color.Green;
                    }
                }
            }
            GuessBtn.Enabled = false;
            Task.Delay(1500).Wait(); // Wait to let user see answer
            NextQuestion();
        }
        private void Finished()
        {
            MessageBox.Show($"FINISHED TEST\nScore {GuessLib.Score}/{GuessLib.Turns}");
            GuessLib.TurnCounter = 0;
            GuessLib.Score = 0;
            countLbl.Text = $"{GuessLib.Score}/{GuessLib.Turns}";
            GuessBtn.Enabled = false;
            ResetTest.Visible = true;
        }
        #region FormComponents
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private RadioButton[] RadioButtons()
        {
            RadioButton[] radioButtons = { rd1, rd2, rd3, rd4 };
            return radioButtons;
        } 
        #endregion
        #region Btns        
        private void GuessBtn_Click(object sender, EventArgs e)
        {
            foreach (var rd in RadioButtons())
            {
                if (rd.Checked)
                {
                    Guess(rd.Text, rd);
                }
            }
           // GenerateQuestion();
        }
        private void ResetTest_Click(object sender, EventArgs e)
        {
            
            GuessBtn.Enabled = true;
            ResetTest.Visible = false;
            GenerateQuestion();
        }
        #endregion

    }
}