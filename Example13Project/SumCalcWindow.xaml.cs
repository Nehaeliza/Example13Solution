using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Example13Project
{
    /// <summary>
    /// Interaction logic for SumCalcWindow.xaml
    /// </summary>
    public partial class SumCalcWindow : Window
    {
        public SumCalcWindow()
        {
            InitializeComponent();
        }
        private bool IsNum(string numStr)
        {
            try
            {
                int.Parse(numStr);
                return true;

            }
            catch
            {
                return false;
            }

        }
        private void btnFindSum_Click(object sender, RoutedEventArgs e)
        {
                if (!IsNum(txtNumber1.Text))
                {
                    MessageBox.Show("please enter valid number");
                    txtNumber1.Focus();
                    txtNumber1.SelectAll();
                    return;
                }
                if (!IsNum(txtNumber2.Text))
                {
                    MessageBox.Show("please enter valid number");
                    txtNumber2.Focus();
                    txtNumber2.SelectAll();
                
                    return;
                }
                int number1 = int.Parse(txtNumber1.Text);
                int number2 = int.Parse(txtNumber2.Text);
                int sum = number1 + number2;
                txtSum.Text = sum.ToString();

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
