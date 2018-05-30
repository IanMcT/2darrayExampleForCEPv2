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

namespace _2darray
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int[,] myarray = new int[5, 4];
            MessageBox.Show(myarray.Length.ToString());
            MessageBox.Show(myarray.GetLength(0).ToString());
            MessageBox.Show(myarray.GetLength(1).ToString());
            MessageBox.Show(myarray.GetType().ToString());
            MessageBox.Show(myarray.Rank.ToString());
            string temp = "";
            for (int x = 0; x < myarray.GetLength(0); x++) {
                for (int y = 0; y < myarray.GetLength(1); y++) {
                    myarray[x, y] = x + y;
                    temp += myarray[x,y] + "\t";
                }
                temp += "\n";
            }
            MessageBox.Show(temp);
        }
    }
}
