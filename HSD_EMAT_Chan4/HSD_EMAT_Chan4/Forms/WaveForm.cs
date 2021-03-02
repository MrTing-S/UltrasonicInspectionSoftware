﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HSD_EMAT_Chan4.Models;

namespace HSD_EMAT_Chan4.Forms
{
    public partial class WaveForm : Form
    {
        public WaveForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.waveChart.ChartXSizeZoomChange(300);
            this.waveChart.ChartYSizeZoomChange(260, 0);
            this.waveChart.SetGageVisible(MyChartControl.WaveChart.GageTpye.GageA, true );
            this.waveChart.SetGageVisible(MyChartControl.WaveChart.GageTpye.GageB, true );

            this.ScanChart.ChartXSizeZoomChange(300);
            this.ScanChart.ChartYSizeZoomChange(260, 0);
            this.ScanChart.SetGageVisible(MyChartControl.WaveChart.GageTpye.GageA, false);
            this.ScanChart.SetGageVisible(MyChartControl.WaveChart.GageTpye.GageB, false);
        }

        public void UpdateChartView()
        {
            if (FormView.chartViewType == ChartViewType.scanChart)
            {
                ShowScanView();
            }
            else
            {
                ShowWaveView();
            }
        }

        private  void ShowScanView()
        {
            int windowBorderWidth = (this.Width - this.ClientRectangle.Width);//获取边框的宽度
            int windowBorderHeight = (this.Height - this.ClientRectangle.Height);//获取边框的宽度
            this.ScanChart.Visible = true;
            ScanChart.Location = new Point(0, 0);
            ScanChart.Width = this.Width - windowBorderWidth;
            ScanChart.Height = this.Height * 4 / 7;
            waveChart.Location = new Point(0, ScanChart.Height);
            waveChart.Width = this.Width - windowBorderWidth;
            waveChart.Height = this.Height - ScanChart.Height- windowBorderHeight;
        }

        private  void ShowWaveView()
        {
            int windowBorderWidth = (this.Width - this.ClientRectangle.Width);//获取边框的宽度
            int windowBorderHeight = (this.Height - this.ClientRectangle.Height);//获取边框的宽度
            this.ScanChart.Visible=false;
            waveChart.Location = new Point(0, 0);
            waveChart.Size = new Size(this.Size.Width- windowBorderWidth, this.Size.Height- windowBorderHeight);
        }

        private void WaveForm_SizeChanged(object sender, EventArgs e)
        {
            UpdateChartView();
        }
    }
}
