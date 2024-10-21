using System;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class Form1 : Form
    {
        private int randomNumber;  
        private int attemptsLeft = 5; 
        private int userGuess;        

        public Form1()
        {
            InitializeComponent();
            StartNewGame();  
        }
        private void StartNewGame()
        {
            Random random = new Random();
            randomNumber = random.Next(1, 101); 
            attemptsLeft = 5;
            lblAttempts.Text = "Remaining attempts: " + attemptsLeft;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtGuess.Text, out userGuess))
            {
                if (userGuess < 1 || userGuess > 100)
                {
                    MessageBox.Show("Please enter a number between 1 and 100.");
                    return;
                }

                if (userGuess == randomNumber)
                {
                    MessageBox.Show("Congratulations! You guessed the correct number!", "Success");
                    StartNewGame(); 
                }
                else
                {
                    attemptsLeft--;
                    lblAttempts.Text = "Remaining attempts: " + attemptsLeft;

                    if (attemptsLeft == 0)
                    {
                        MessageBox.Show($"You've run out of attempts! The correct number was {randomNumber}.", "Fail");
                        StartNewGame(); 
                    }
                    else
                    {
                        if (userGuess < randomNumber)
                        {
                            MessageBox.Show("Your guess is too low. Try again!", "Hint");
                        }
                        else
                        {
                            MessageBox.Show("Your guess is too high. Try again!", "Hint");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}
