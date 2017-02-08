using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class ResultScreen : UserControl
    {
        public ResultScreen()
        {
            InitializeComponent();
        }

        private void ResultScreen_Load(object sender, EventArgs e)
        {
            //answerOutput.Text = Convert.ToString(Form1.guessList);
            numGuess.Text = Convert.ToString(Form1.guessList.Count);

            answerOutput.Text = "" + Form1.guessList[Form1.guessList.Count() - 1];

            for (int i = 0; i < Form1.guessList.Count; i++)
            {
                guessOutput.Text += Convert.ToString(Form1.guessList[i]) + ", "; 
            }

            Form1.guessList.Sort();

            for (int i = 0; i < Form1.guessList.Count; i++)
            {
                guessOutput.Text += Convert.ToString(Form1.guessList[i]) + ", ";
            }
        }
    }
}
