using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void RunButton_Click(object sender, EventArgs e)
        {

            string userInput = Input.Text;
            string results = PerformSkipCodeAnalysis(userInput);
            Output.Text = results;
        }


        private string PerformSkipCodeAnalysis(string inputText)
        {
            StringBuilder result = new StringBuilder();

            // Define the skip values
            int everyNthLetter = 4;
            int skipValue = 42;

            for (int i = 0; i < inputText.Length; i += everyNthLetter + skipValue)
            {
                // Check if the character is a letter
                if (char.IsLetter(inputText[i]))
                {
                    // Append the selected letter
                    result.Append(inputText[i]);
                }
                // If it's a number or other character, skip it
            }

            return result.ToString();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Input.Clear();
        }
    }
}
