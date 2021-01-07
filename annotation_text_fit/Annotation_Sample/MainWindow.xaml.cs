using Syncfusion.UI.Xaml.Charts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Annotation_Sample
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

       

        private Size MeasuringString(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return new Size(0, 0);
            }

            var TextBlock = new TextBlock()
            {
                Text = text,
                FontWeight = FontWeights.Bold,
            };

            TextBlock.Measure(new Size(Double.PositiveInfinity, Double.PositiveInfinity));
            return new Size(TextBlock.DesiredSize.Width, TextBlock.DesiredSize.Height);
        }

        private void UpdateAnnotation()
        {
            //Measured size from updated text of Textblock
            Size desireSize = MeasuringString(txtBlock.Text);
            var point1 = chart.ValueToPoint(xAxis, Convert.ToDouble(annotation.X1));
            var point2 = chart.ValueToPoint(yAxis, Convert.ToDouble(annotation.Y1));
            var point3 = point1 + desireSize.Width;
            var point4 = point2 + desireSize.Height;
            Point x2Points = new Point(point3, point4);
            var x2 = chart.PointToValue(chart.PrimaryAxis, x2Points);
            var y2 = chart.PointToValue(chart.SecondaryAxis, x2Points);
            annotation.X2 = x2;
            annotation.Y2 = y2;
        }


        private void txtBlock_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateAnnotation();
        }

    }
}
