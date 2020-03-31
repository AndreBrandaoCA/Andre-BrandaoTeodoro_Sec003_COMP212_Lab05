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

        private async void calculateFactorialButton_Click(object sender, EventArgs e)
        {
            factorialResultLabel.Text = "Calculating";
            var task1 = Task.Run(() => Factorial(Convert.ToInt64(factorialTextBox.Text)));
            await Task.WhenAll(task1);
            factorialResultLabel.Text = Convert.ToString(task1.Result);
        }

        private long Factorial(long num)
        {
            long factorial = 1;
            for (var i = 1; i<= num; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
