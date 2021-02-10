using System;
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

            this.chartControl1.ChartInit();
            this.chartControl1.ChartXSizeZoomIn(300);
            this.chartControl1.ChartYSizeZoomIn(260, 0);
        }

        public void  m_ChangeFormSize(int width, int height)
        {
            this.Size = new Size(width,height);
            chartControl1.Size = this.Size;
        }

        private void WaveForm_Move(object sender, EventArgs e)
        {
           //this.Location = formPoint;
        }

        private void WaveForm_Load(object sender, EventArgs e)
        {
            //formPoint = this.Location;
        }
    }
}
