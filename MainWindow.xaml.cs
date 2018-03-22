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

namespace u2ManSnow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            int i = 0;
            InitializeComponent();

           
            {for(i = 0; i < 3; i++)
                if (i == 0)
                {
                    Ellipse myEllipse = new Ellipse();
                    myEllipse.Width = 100;
                    myEllipse.Height = 100;
                    myEllipse.Stroke = Brushes.Black;
                    myCanvas.Children.Add(myEllipse);
                    
                }
                else if (i == 1)
                {
                    Ellipse myEllipse2 = new Ellipse();
                    myEllipse2.Width = 200;
                    myEllipse2.Height = 200;
                    myCanvas.Children.Add(myEllipse2);
                    
                }
                 else if (i == 2)
                {
                    Ellipse myEllipse3 = new Ellipse();
                    myEllipse3.Width = 300;
                    myEllipse3.Height = 300;
                    myCanvas.Children.Add(myEllipse3);
                    
                }
            }
        }
    }
}
