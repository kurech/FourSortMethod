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

namespace FourSortMethod
{
    public partial class MainWindow : Window
    {
        public string SourceString = "";
        public string FinalString = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnForSort_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (int.Parse(txtForLengthMas.Text) > 1 && int.Parse(txtForLengthMas.Text) < 8)
                {
                    txtForSourceMas.Text = "";
                    txtForFinalMas.Text = "";

                    SourceString = "";
                    FinalString = "";

                    int[] SourceArray = new int[int.Parse(txtForLengthMas.Text)];
                    int[] FinalArray = new int[int.Parse(txtForLengthMas.Text)];

                    Random rand = new Random();

                    int x = 0;

                    for (x = 0; x < SourceArray.Length; x++)
                    {
                        SourceArray[x] = rand.Next(-100, 100);
                        SourceString += Convert.ToString(SourceArray[x]);
                        SourceString += "  ";
                    }

                    txtForSourceMas.Text = SourceString;

                    if (rbtnBubbleMethod.IsChecked == true)
                    {
                        FinalArray = SortingByExchange.ExchangeMethod(SourceArray);
                    }

                    else if (rbtnInsertMethod.IsChecked == true)
                    {
                        FinalArray = SortingByInserts.InsertionMethod(SourceArray);
                    }

                    else if (rbtnChoseMethod.IsChecked == true)
                    {
                        FinalArray = SortingByChoice.SelectionMethod(SourceArray);
                    }

                    else if (rbtnShellMethod.IsChecked == true)
                    {
                        FinalArray = SortingByShell.ShellMethod(SourceArray);
                    }

                    for (x = 0; x < FinalArray.Length; x++)
                    {
                        FinalString += Convert.ToString(FinalArray[x]);
                        FinalString += "  ";
                    }

                    txtForFinalMas.Text = FinalString;
                }
                else
                {
                    MessageBox.Show("Length of array so long!", "SortMethod", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "SortMethod", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
