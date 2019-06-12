using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataChart = Microcharts.Entry;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenFinalDM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Gráfico : ContentPage
    {
        public Gráfico()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            List<DataChart> dataChart = new List<DataChart>
            {
                new DataChart(3.4f)
                {
                    Color = SkiaSharp.SKColor.Parse("#FF112233"),
                    Label = "point 1"            
                },
                new DataChart(7.4f)
                {
                    Color = SkiaSharp.SKColor.Parse("#BF112233"),
                    Label = "point 2"
                },
            };

            Grafica1.Chart = new Microcharts.LineChart {
                Entries = dataChart
            };
        }
    }
}