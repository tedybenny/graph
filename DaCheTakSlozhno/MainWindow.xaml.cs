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
using org.mariuszgromada.math.mxparser;
using System.Windows.Threading;

namespace DaCheTakSlozhno
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model model = new Model();
        public string Xmin
        {
            get => model.Xmin;
            set => model.Xmin = value;
        }
        public string Xmax
        {
            get => model.Xmax;
            set => model.Xmax = value;
        }
        public string userFormula
        {
            get => model.userFormula;
            set => model.userFormula = value;
        }

        public List<DataPoint> Points { get; }

        int loadText = 0;
        int count = 0;
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            
            Points = new List<DataPoint>();
            DataContext = this;
            Loading();
        }

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            Title = "Your graphic";
            Points.Clear();
            for (int i = Convert.ToInt32(Xmin);i<= Convert.ToInt32(Xmax);i++)
            {
                Points.Add(new DataPoint(i,model.PointY(i)));
            }
            oxy.InvalidatePlot(true);
        }
        private void timer_tick(object sender, EventArgs e)
        {
            count++;
            if (count == 13)
            {
                timer.Stop();
                loadUp.Visibility = Visibility.Hidden;
                loadDown.Visibility = Visibility.Hidden;
                oxy.Visibility = Visibility.Visible;
            }

            if (loadText == 0)
            {

                load.Text = "LOADING";
            }
            if (loadText == 1)
            {
                load.Text = "LOADING.";
            }
            if (loadText == 2)
            {
                load.Text = "LOADING..";
            }
            if (loadText == 3)
            {
                load.Text = "LOADING...";
            }
            if(loadText <=2)
            {
                loadText++;
            }
            else
            {
                loadText = 0;
            }
        }
        void Loading()
        {
            timer.Tick += timer_tick;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }

        
    }
    


        
}
