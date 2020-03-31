using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Andre_BrandaoTeodoro_Sec003_Lab05_Ex01
{
    public partial class AsynchronousProgrammingForm : Form
    {

        public AsynchronousProgrammingForm()
        {
            InitializeComponent();
        }
        #region GroupBox1
        private async void calculateFactorialButton_Click(object sender, EventArgs e)
        {
            factorialResultLabel.Text = "Calculating";
            try {
                Task<long> task1 = Task.Run(() => Factorial(Convert.ToInt64(factorialTextBox.Text)));
                await Task.WhenAll(task1);
                factorialResultLabel.Text = Convert.ToString(task1.Result);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Please enter an integer", "Error", MessageBoxButtons.OK);
                factorialResultLabel.Text = "";
            }
        }
        private long Factorial(long num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }
        #endregion
        #region GroupBox2
        private void checkEvenOddButton_Click(object sender, EventArgs e)
        {
            evenOddResultLabel.Text = "Calculating";

            try
            {
                evenOddResultLabel.Text = Convert.ToString(IsEven(Convert.ToInt32(evenOddTextBox.Text)));
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Please enter an integer", "Error", MessageBoxButtons.OK);
                evenOddResultLabel.Text = "";
            }
        }
        private bool IsEven(int n)
        {
            return n % 2 == 0;
        }
        private bool IsOdd(int n)
        {
            return n % 2 != 0;
        }
        #endregion

        #region GroupBox3
        static Random random = new Random();
        private void generateValuesButton_Click(object sender, EventArgs e)
        {
            List<int> intArray = new List<int>();
            List<double> doubleArray = new List<double>();
            List<char> charArray = new List<char>();
            if (integerRadioButton.Checked == true)
            {
                valuesListBox.Items.Clear();
                for (int i = 0; i < 10; i++)
                {
                    intArray.Add(random.Next(10,99));
                }
                foreach(int i in intArray)
                {
                    valuesListBox.Items.Add(i);
                }
            } 
            else if (doubleRadioButton.Checked == true)
            {
                valuesListBox.Items.Clear();
                for (int i = 0; i < 10; i++)
                {
                    doubleArray.Add(random.NextDouble()*100);
                }
                foreach (int i in doubleArray)
                {
                    valuesListBox.Items.Add(i);
                }
            }
            //else if (charRadioButton.Checked == true)
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        charArray.Add(random.());
            //    }
            //}
        }










        #endregion
    }
}
