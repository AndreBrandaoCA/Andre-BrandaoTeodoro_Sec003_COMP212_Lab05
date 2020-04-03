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
            // Update ResultLabel to show intermediate state while system process the request
            factorialResultLabel.Text = "Calculating";
            // try catch block to handle exceptions
            try {
                // if the input is higher than 20, the systems shows an error because it exceeds the size of long datatype
                if (Convert.ToInt64(factorialTextBox.Text) > 20) { throw new System.StackOverflowException(); }
                // create a task to be run asynchronously
                Task<long> task1 = Task.Run(() => Factorial(Convert.ToInt64(factorialTextBox.Text)));
                // wait for task execution to proceed with the execution
                await Task.WhenAll(task1);
                // update result label with task result
                factorialResultLabel.Text = Convert.ToString(task1.Result);
            }
            // first exception, if the user type a input other than an integer
            catch (System.FormatException)
            {
                MessageBox.Show("Please enter an integer", "Error", MessageBoxButtons.OK);
                factorialResultLabel.Text = "";
            }
            // second exception, if the user type a number that the result will be out of range of the datatype long
            catch (System.StackOverflowException)
            {
                MessageBox.Show("Result exceed long datatype range", "Error", MessageBoxButtons.OK);
                factorialResultLabel.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        // recursive function to calculate factorial
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
            // predicate to use delegates
            Predicate<int> evenP = IsEven;
            Predicate<int> oddP = IsOdd;
            try
            {
                int typedNumber = Convert.ToInt32(evenOddTextBox.Text);
                //evaluate user input
                if (typedNumber < 0)
                {
                    throw new Exception("Please enter a positive value");
                }
                else if (evenP(typedNumber))
                {
                    evenOddResultLabel.Text = "Even";
                } 
                else if (oddP(typedNumber))
                {
                    evenOddResultLabel.Text = "Odd";
                }
            }
            // Catch exceptions
            catch (FormatException)
            {
                MessageBox.Show("Please enter an integer", "Error", MessageBoxButtons.OK);
                evenOddResultLabel.Text = "";
            }
            catch (OverflowException)
            {
                MessageBox.Show("Please enter an integer up to to 2,147,483,647 ", "Error", MessageBoxButtons.OK);
                evenOddResultLabel.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                evenOddResultLabel.Text = "";
            }
        }
        // first delegate 
        private static bool IsEven(int n) => n % 2 == 0;
        // second delegate 
        private bool IsOdd(int n) => n % 2 != 0;
        #endregion

        #region GroupBox3
        static Random random = new Random();

        private void generateValuesButton_Click(object sender, EventArgs e)
        {
            try
            {
               // List initialization for each datatype stored in the list
                List<int> intArray = new List<int>();
                List<double> doubleArray = new List<double>();
                List<char> charArray = new List<char>();
                // check for radio buttond for the option the user selected
                if (integerRadioButton.Checked == true)
                {
                    // clear the valuesListBox 
                    valuesListBox.Items.Clear();
                    // run through the loop adding radom numbers 
                    for (int i = 0; i < 10; i++)
                    {
                        intArray.Add(random.Next(10, 99));
                    }
                    // adds each number generated randomly to the valuesListBox
                    foreach (int i in intArray)
                    {
                        valuesListBox.Items.Add(i);
                    }
                }
                else if (doubleRadioButton.Checked == true)
                {
                    // clear the valuesListBox 
                    valuesListBox.Items.Clear();
                    // run through the loop adding radom numbers 
                    for (int i = 0; i < 10; i++)
                    {
                        doubleArray.Add(Math.Round(random.NextDouble() * 100, 2));
                    }
                    // adds each number generated randomly to the valuesListBox
                    foreach (double i in doubleArray)
                    {
                        valuesListBox.Items.Add(i);
                    }
                }
                else if (charRadioButton.Checked == true)
                {
                    // clear the valuesListBox 
                    valuesListBox.Items.Clear();
                    // run through the loop adding radom numbers
                    for (int i = 0; i < 10; i++)
                    {
                        charArray.Add(Convert.ToChar(random.Next(20, 99)));
                    }
                    // adds each number generated randomly to the valuesListBox
                    foreach (char i in charArray)
                    {
                        valuesListBox.Items.Add(i);
                    }
                }
                // if no radio button selected, throw an error
                else
                {
                    throw new Exception("Please select a datatype");
                }
            }
            // catch exceptions
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            // create a string list
            List<string> list = new List<string>();
            // loop through valueListBox and clone the list
            foreach(var item in valuesListBox.Items)
            {
                list.Add(item.ToString());
            }
            //call method to search with the string list and the user's input to be search
            if(SearchData(list, valueForSearchTextBox.Text) == true)
            {
                // if the input matches one item of the list, display success message
                MessageBox.Show( "Item found","Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // if the input does not matches one item of the list, display error message
                MessageBox.Show("Item not found", "NOT Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // generic Search method
        private bool SearchData<T>(List<T> list, T searched)
        {
            //returns true or false if the element searched existis in the list
            return list.Exists(elementSearched => elementSearched.Equals(searched));
        }
        private void displayButton_Click(object sender, EventArgs e)
        {
            try
            {
                // initialize the low and high index
                int lowIndex = Convert.ToInt32(lowIndexTextBox.Text);
                int highIndex = Convert.ToInt32(highIndexTextBox.Text);
                // checks if the indexes are out of range
                if (lowIndex < 0 | highIndex > 9)
                {
                    throw new FormatException();
                }
                // display list of items in the output box
                OutputValueSearchTextBox.Text = Display(lowIndex, highIndex);
            }
            // catch exceptions
            catch (ArgumentOutOfRangeException)
            {
                OutputValueSearchTextBox.Text = "Please click \"Generate Values\" first";
            }

            catch (FormatException)
            {
                OutputValueSearchTextBox.Text = "Please index between 0 and 9";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        public string Display(int lowIndex, int highIndex)
        {
            //initialize the result string
            string result = "";
            // loop through the list between the indexes informed and append the item to the result string
            for (int i = lowIndex; i <= highIndex; i++)
            {
                result += valuesListBox.Items[i].ToString() + " | ";
            }
            // return the string to be shown 
            return result;
        }
        #endregion
    }
}
