using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSD_EMAT_Chan4.Forms
{
    public partial class MutiScanForm : Form
    {
        public MutiScanForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.mutiScanChart.ChartXSizeZoomChange(300);
            this.mutiScanChart.ChartYSizeZoomChange(260, 0);
        }

        #region 公开函数

        public void DrawPoint(double[] data, int channel)
        {
            this.mutiScanChart.DrawPointOfSingleChannel(data, channel);
        }

        public void SetAxielXLabele(string[] texts)
        {
            this.mutiScanChart.SetAxisXValue(texts);
        }

        public void SetAxielYLabele(string[] texts)
        {
            this.mutiScanChart.SetAxisYValue(texts);
        }
        #endregion

        #region 窗体布局
        private void UpdateView()
        {
            int windowBorderWidth = (this.Width - this.ClientRectangle.Width);//获取边框的宽度
            int windowBorderHeight = (this.Height - this.ClientRectangle.Height);//获取边框的宽度
            mutiScanChart.Location = new Point(0, 0);
            mutiScanChart.Size = new Size(this.Size.Width - windowBorderWidth, this.Size.Height - windowBorderHeight);
        }

        private void MutiScanForm_SizeChanged(object sender, EventArgs e)
        {
            UpdateView();
        }
        #endregion
    }
}
