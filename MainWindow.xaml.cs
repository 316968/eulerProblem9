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

namespace eulerProblem9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        int a = 0;
        int b = 0;
        int c = 0;
        int total = 1000;
        //I use this boolean to end loops
        bool correct = false;

        public MainWindow()
        {
            InitializeComponent();
            //a < b < c. I had to search up some math strategies for this problem, and i found that a < total / 3 and b < total / 2
            for(a = 1; a < total / 3; a++)
            {
                for(b = a; b < total / 2; b++)
                {   // I find c by subtracting a and b from the total
                    c = total - a - b;
                    //loop ends if the pythagorean theorem is true here
                    if(a * a + b * b == c * c)
                    {
                        correct = true;
                        break;
                    }
                }
                if (correct == true)
                {
                    break;
                    
                }
            }
            MessageBox.Show("a: " + a + "\n" + "b: " + b + "\n" + "c: " + c + "\n" + "product: " + (a * b * c));
        }
    }
}
