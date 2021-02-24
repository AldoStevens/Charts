using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;
using Entry = Microcharts.ChartEntry;

namespace Charts
{
    public partial class MainPage : ContentPage
    {

        List<Entry> entries = new List<Entry>
        {
            new Entry(200)
            {
                Color = SKColor.Parse("#FF1493"),
                Label = "January",
                ValueLabel = "200"
            },
            new Entry(400)
            {
                Color = SKColor.Parse("#00BFFF"),
                Label = "January",
                ValueLabel = "400"
            },
            new Entry(100)
            {
                Color = SKColor.Parse("#00CED1"),
                Label = "January",
                ValueLabel = "100"
            }
        };
        public MainPage()
        {
            InitializeComponent();

            
            Chart1.Chart = new PointChart { Entries = entries };
        }
    }
}
