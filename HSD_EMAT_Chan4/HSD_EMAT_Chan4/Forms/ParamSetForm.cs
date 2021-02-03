namespace HSD_EMAT_Chan4.Forms
{
    using System.Drawing;
    using System.Windows.Forms;
    using HSD_EMAT_Chan4.Models;

    public partial class ParamSetForm : Form
    {
        private Channel currentChannel;

        public ParamSetForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void trackBarDigitalGian_Scroll(object sender, System.EventArgs e)
        {

        }
    }
}
