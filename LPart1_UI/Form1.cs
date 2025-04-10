using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPart1_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void helloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Get all the values from the input boxes
            string input = StringInput.Text; // Text from TextBox
            int shift = (int)ShiftInput.Value; // Value NumericUpDown
            string encoded = ""; // Encoded string
            
            //Input ASCII value of the first character
            List<int> asciiValues = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                asciiValues.Add((int)input[i]);
            }
            //Join into a string
            string asciiString = string.Join(" ", asciiValues);

            // Working on Encoded
            foreach (char c in input)
            {
                // Shift each character by the shift value
                char shiftedChar = (char)(c + shift);
                encoded += shiftedChar;
            }

            //Working on Sorted
            char[] sortedChars = input.ToCharArray();
            Array.Sort(sortedChars);
            string sortedString = new string(sortedChars);

            //All displays for output
            StringOutput.Text = input; // Text
            ShiftOutput.Text = shift.ToString(); // Shift
            SortedOutput.Text = sortedString; // Sorted
            ASCIIOutput.Text = asciiString; // ASCII
            EncodedOutput.Text = encoded; // Encoded string
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
