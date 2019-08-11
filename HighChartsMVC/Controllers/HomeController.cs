using DotNet.Highcharts;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HighChartsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Highcharts columnChart = new Highcharts("columnchart");

            columnChart.InitChart(new Chart()
            {
                Type = DotNet.Highcharts.Enums.ChartTypes.Column,
                Style = "fontWeight: 'bold', fontSize: '17px'",
                Width=900,
                BackgroundColor = new BackColorOrGradient(System.Drawing.Color.AliceBlue),
                BorderColor = System.Drawing.Color.LightBlue,
                BorderRadius = 0,
                BorderWidth = 2

            });
            columnChart.SetTitle(new Title()
            {
                Text = "Best batting average in successful ODI run-chases"
            });
            columnChart.SetXAxis(new XAxis()
            {
                Type = AxisTypes.Category,
                Title = new XAxisTitle() { Text = "Batsman", Style = "fontWeight: 'bold', fontSize: '17px'" },
                Categories = new[] { "MS Dhoni", "Virat Kohli", "Michael Bevan", "Dinesh Chandimal", "AB DE Villiers", "Joe Root", "Mike Hussy", "Michael Clarke", "Angelo Mathews", "Graham Thorpe" },
            });
            columnChart.SetYAxis(new YAxis()
            {
                Title = new YAxisTitle()
                {
                    Text = "Average Wining Runs",
                },
                    ShowFirstLabel = true,
                    ShowLastLabel = true,
                    Min = 0
            });
            columnChart.SetLegend(new Legend
            {
                Enabled = false,
            });
            columnChart.SetPlotOptions(new PlotOptions
            {
                Series = new PlotOptionsSeries
                {
                    DataLabels = new PlotOptionsSeriesDataLabels
                    {
                        Enabled = true,
                        Format = "{point.y:.1f}"
                    }
                }
            });
            columnChart.SetSeries(new Series[]
            {
                new Series{

                    Name = "Wining average",

                    Data = new Data(new object[] { 99.85,99.04,86.25,85.30,82.77,77.80,74.10,73.86,70.75,70.75   })
                },
            }
            );

            return View(columnChart);
        }
    }
}