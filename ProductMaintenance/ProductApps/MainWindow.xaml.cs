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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProductApps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Product cProduct;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cProduct = new Product(Convert.ToDecimal(priceTextBox.Text), Convert.ToInt16(quantityTextBox.Text));
                
                cProduct.calTotalPayment();
                totalPaymentTextBlock.Text = Convert.ToString(cProduct.TotalPayment);
                
                // Call Product to Calculate and add Total Charge to Text Block
                cProduct.calTotalCharge();
                totalChargeTextBlock.Text = Convert.ToString(cProduct.TotalCharge);

                // Call Product to Calculate and add Total Wrap Charge to Text Block
                cProduct.calTotalWrapCharge();
                totalWrapChargeTextBlock.Text = Convert.ToString(cProduct.TotalWrapCharge);

                // Call Product to Calculate and add Total GST Charge to Text Block
                cProduct.calTotalGSTCharge();
                totalGSTChargeTextBlock.Text = Convert.ToString(cProduct.TotalGSTCharge);

            }
            catch (FormatException)
            {
                MessageBox.Show("Enter data again", "Data Entry Error");
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            productTextBox.Text = "";
            priceTextBox.Text = "";
            quantityTextBox.Text = "";
            totalPaymentTextBlock.Text = "";
            totalChargeTextBlock.Text = "";
            totalWrapChargeTextBlock.Text = "";
            totalGSTChargeTextBlock.Text = "";
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
