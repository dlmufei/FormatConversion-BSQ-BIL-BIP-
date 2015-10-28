using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FormatConversion
{
    class ChartData
    {
        //获得制作图表的数据
        public int[] GetChartData(byte[] ImageData)
        {

            int[] chartData = new int[255];
            for (int i = 0; i < ImageData.Length; i++)
            {
                chartData[ImageData[i]]++;
            }
            return chartData;
        }

        public void MadeChart(Chart chart, int[] chartData)
        {
            Series series = new Series();
            series.ChartType = SeriesChartType.Bar;
            for (int i = 0; i < chartData.Length; i++)
            {                
                series.Points.AddXY(chartData[i],i);
            }                
            chart.Series.Add(series);
            
        }

    }
}
