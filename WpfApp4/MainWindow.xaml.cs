using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem newItem= new ListBoxItem();

TextBlock textBlock1= new TextBlock();
TextBlock textBlock2= new TextBlock();

            int a = DateTime.Now.Hour;
            int b = DateTime.Now.Minute;
            textBlock1.Text =a+":"+b;
            textBlock2.Text="                                                 "+myText.Text;


            Grid grid = new Grid();
            Grid.SetRow(textBlock1, 2); // Satır numarasını ayarla
            Grid.SetColumn(textBlock1, 0); // Sütun numarasını ayarla
            grid.Children.Add(textBlock1);

            Grid.SetRow(textBlock2, 0);
            Grid.SetColumn(textBlock2, 1);
            grid.Children.Add(textBlock2);

            ColumnDefinition column1 = new ColumnDefinition();
            ColumnDefinition column2 = new ColumnDefinition();
            column1.Width = new GridLength(1, GridUnitType.Star); // İlk sütunun genişliği
            column2.Width = new GridLength(10, GridUnitType.Star); // İkinci sütunun genişliği
            grid.ColumnDefinitions.Add(column1);
            grid.ColumnDefinitions.Add(column2);

            newItem.Content = grid;

            myListBox.Items.Add(newItem);


        }
    }
}
