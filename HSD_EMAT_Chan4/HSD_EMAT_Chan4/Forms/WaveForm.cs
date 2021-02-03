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
    public partial class WaveForm : Form
    {
        public WaveForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void  m_ChangeFormSize(int width, int height)
        {
            this.Size = new Size(width,height);
            chartControl1.Size = this.Size;
        }
    }
}
