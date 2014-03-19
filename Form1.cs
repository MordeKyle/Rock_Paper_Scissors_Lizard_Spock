using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Program: Paper Rock Scissors Lizard Spock
  Author: Kyle McBride A02609917
  Date: 03/18/2014
  Description: Application that lets the user play the game of Rock, Paper, Scissors, Lizard, Spock against the computer.
                                          ***SEE CHANGELOG IN SOLUTION DIRECTORY***				*/

namespace Rock_Paper_Scissors_Lizard_Spock
{
    public partial class Form1 : Form
    {
        private const int superWinConstant = 2;
        private const int winConstant = 1;
        private const int drawConstant = 0;
        private const int loseConstant = -1;
        private const int superLoseConstant = -2;
        private const int userInputConstant = 3;
        private int resultHolder;
        private int computerChoice;
        private string rockString = "Rock";
        private string paperString = "Paper";
        private string scissorsString = "Scissors";
        private string lizardString = "Lizard";
        private string spockString = "Spock";
        private string winString = "You Win!";
        private string drawString = "Draw";
        private string loseString = "You Lose";

        public Form1()
        {
            InitializeComponent();
        }

        private void generateRandom()
        {
            Random rand = new Random();
            computerChoice = rand.Next(5) + 1;
        }

        private void compareResults()
        {
            resultHolder = userInputConstant - computerChoice;
        }

        private void rockSelected()
        {
            if(resultHolder == superWinConstant)
            {
                computerChoiceLabel.Text = lizardString;
                resultLabel.Text = winString;
            }
            else if(resultHolder == winConstant)
            {
                computerChoiceLabel.Text = scissorsString;
                resultLabel.Text = winString;
            }
            else if(resultHolder == drawConstant)
            {
                computerChoiceLabel.Text = rockString;
                resultLabel.Text = drawString;
            }
            else if(resultHolder == loseConstant)
            {
                computerChoiceLabel.Text = paperString;
                resultLabel.Text = loseString;
            }
            else
            {
                computerChoiceLabel.Text = spockString;
                resultLabel.Text = loseString;
            }
        }

        private void paperSelected()
        {
            if(resultHolder == superWinConstant)
            {
                computerChoiceLabel.Text = spockString;
                resultLabel.Text = winString;
            }
            else if(resultHolder == winConstant)
            {
                computerChoiceLabel.Text = rockString;
                resultLabel.Text = winString;
            }
            else if(resultHolder == drawConstant)
            {
                computerChoiceLabel.Text = paperString;
                resultLabel.Text = drawString;
            }
            else if(resultHolder == loseConstant)
            {
                computerChoiceLabel.Text = scissorsString;
                resultLabel.Text = loseString;
            }
            else
            {
                computerChoiceLabel.Text = lizardString;
                resultLabel.Text = loseString;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
