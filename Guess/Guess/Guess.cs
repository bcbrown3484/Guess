using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess
{
    public partial class guess : Form
    {
        private int answer;
        private int count;
        public guess()
        {
            InitializeComponent();
            Random rnd = new Random();
            answer = rnd.Next(1, 1000);
        }
      
    private void submitGuess_Click(object sender, EventArgs e)
        {
            count++;
            string dispGuess= count.ToString();
            var tempGuess = guessBox.Text;
            int value;
            bool result = Int32.TryParse(tempGuess, out value);
            if (result)
            {

                int playerInput = Int32.Parse(guessBox.Text);
                if (playerInput <= 0)
                {
                    mainDipsplay.Text = "Thats not a valid interger you utterly useless idiot!";
                }
                else if (playerInput >= 1000)
                {
                    mainDipsplay.Text = "Thats not a valid interger you utterly useless idiot!";
                }
                else if (answer == playerInput)
                {
                    string endans = answer.ToString();
                    mainDipsplay.Text = "You have defeated me surely you are a jedi master. You guessed "+ endans + "correctly";
                    guessBox.ReadOnly = true;
                    submitGuess.Enabled = false;
                }
                else if (playerInput > answer)
                {
                    hintbox.Text = "It's Lower than that bud.";
                }
                else if (playerInput < answer)
                {
                    hintbox.Text = "It's Higher than that bud.";
                }
                else
                {
                    mainDipsplay.Text = "That isn't even a number! What are you STUPID?!?!?!?";
                }
            }
            else
            {
                hintbox.Text = "That isn't even a number! What are STUPID?!?!?!?";
            }
                    if (count == 11)
                    {
                string endans = answer.ToString();
                guessBox.Text = "XXXX";
                        guessBox.ReadOnly = true;
                        submitGuess.Enabled = false;
                mainDipsplay.Text = "YOU FAILED! YOU ARE A FAILURE! The number I was looking for was " +endans ;
                        countDisplay.Text = "X";
                    }
            guessBox.Text = null;
            countDisplay.Text = dispGuess;
          }

        private void reset_Click(object sender, EventArgs e)
        {
            guessBox.ReadOnly = false;
            submitGuess.Enabled = true;
            count = 0;
            mainDipsplay.Text = "Guess a number, 1 to 1000!";
            Application.Restart();
        }
    }
    }