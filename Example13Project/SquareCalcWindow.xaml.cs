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
    /// Interaction logic for SquareCalcWindow.xaml
    /// </summary>
    public partial class SquareCalcWindow : Window
    {
        public SquareCalcWindow()
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

        private void btnFindSquare_Click(object sender, RoutedEventArgs e)
        {

            if (!IsNum(txtNumber1.Text))
            {

                MessageBox.Show("please enter valid number");
                txtNumber1.Focus();
                txtNumber1.SelectAll();
                return;
            }
           
            int number1 = int.Parse(txtNumber1.Text);
            int result =(int) Math.Pow(number1,2) ;
            txtResult.Text = result.ToString();
            lblResult.Text ="Square";

        }

        private void btnCube_Click(object sender, RoutedEventArgs e)
        {

            if (!IsNum(txtNumber1.Text))
            {

                MessageBox.Show("please enter valid number");
                txtNumber1.Focus();
                txtNumber1.SelectAll();
                return;
            }

            int number1 = int.Parse(txtNumber1.Text);
            int result = (int)Math.Pow(number1, 3);
            txtResult.Text = result.ToString();
            lblResult.Text = "Cube";
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
