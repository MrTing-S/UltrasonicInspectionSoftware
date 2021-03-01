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
        Point formPoint;
        public WaveForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.chartControl1.ChartXSizeZoomChange(300);
            this.chartControl1.ChartYSizeZoomChange(260, 0);
        }

        public void ChangeXScale(int value)
        {
            this.chartControl1.ChartXSizeZoomChange(value);
        }

        public void  m_ChangeFormSize(int width, int height)
        {
            this.Size = new Size(width,height);
            chartControl1.Size = this.Size;
        }
    }
}
