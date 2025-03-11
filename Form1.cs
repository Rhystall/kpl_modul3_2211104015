using System;
using System.Windows.Forms;

namespace modul3_2211104015
{
    public partial class Form1 : Form
    {
        private string currentInput = ""; // Menyimpan angka yang sedang diketik
        private double firstNumber = 0;   // Menyimpan angka pertama
        private bool isAdding = false;    // Menandakan apakah sedang dalam mode penjumlahan

        public Form1()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            currentInput += "0";
            lblOutput.Text = currentInput;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            currentInput += "1";
            lblOutput.Text = currentInput;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            currentInput += "2";
            lblOutput.Text = currentInput;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            currentInput += "3";
            lblOutput.Text = currentInput;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            currentInput += "4";
            lblOutput.Text = currentInput;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            currentInput += "5";
            lblOutput.Text = currentInput;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            currentInput += "6";
            lblOutput.Text = currentInput;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            currentInput += "7";
            lblOutput.Text = currentInput;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            currentInput += "8";
            lblOutput.Text = currentInput;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            currentInput += "9";
            lblOutput.Text = currentInput;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                firstNumber = double.Parse(currentInput);
                isAdding = true;
                currentInput = ""; // Reset input setelah memilih operasi
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Kosongkan jika tidak digunakan
        }


        private void btnResult_Click(object sender, EventArgs e)
        {
            if (isAdding && !string.IsNullOrEmpty(currentInput))
            {
                double secondNumber = double.Parse(currentInput);
                double result = firstNumber + secondNumber;
                lblOutput.Text = result.ToString();
                currentInput = result.ToString(); // Menyimpan hasil untuk operasi berikutnya
                isAdding = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
