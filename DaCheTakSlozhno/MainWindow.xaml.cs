using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using System.ComponentModel;
using OxyPlot;
using OxyPlot.Series;
using System.Data;

namespace DaCheTakSlozhno
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model XUY = new Model();
        public string Xmin
        {
            get => XUY.Xmin;
            set => XUY.Xmin = value;
        }
        public string Xmax
        {
            get => XUY.Xmax;
            set => XUY.Xmax = value;
        }

        public MainWindow()
        {
            this.Title = "Example 2";
            this.Points = new List<DataPoint>
                              {
                                  new DataPoint(0, 4),
                                  new DataPoint(10, 13),
                                  new DataPoint(20, 15),
                                  new DataPoint(30, 16),
                                  new DataPoint(40, 12),
                                  new DataPoint(50, 12)
                              };
            DataContext = this;
        }


        public IList<DataPoint> Points { get; private set; }
    }
    


        
}
