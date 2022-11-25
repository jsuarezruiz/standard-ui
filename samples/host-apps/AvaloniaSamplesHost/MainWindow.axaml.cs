using Avalonia.Controls;
using Microcharts;
using Microsoft.StandardUI;
using Microsoft.StandardUI.Avalonia;
using Microsoft.StandardUI.Avalonia.NativeVisualFramework;

namespace AvaloniaSamplesHost
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            AvaloniaHostFramework.Init(new AvaloniaNativeVisualFramework());
            InitializeComponent();

            MyBarChart.Entries = CreateChartEntries();
            MyPointChart.Entries = CreateChartEntries();
        }

        public static ChartEntry[] CreateChartEntries()
        {
            return new[]
            {
                new ChartEntry(200)
                {
                        Label = "January",
                        ValueLabel = "200",
                        Color = Color.FromHex("#266489")
                },
                new ChartEntry(400)
                {
                        Label = "February",
                        ValueLabel = "400",
                        Color = Color.FromHex("#68B9C0"),
                },
                new ChartEntry(100)
                {
                        Label = "March",
                        ValueLabel = "100",
                        Color = Color.FromHex("#90D585"),
                },
            };
        }
    }
}