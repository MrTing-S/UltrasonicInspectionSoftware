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
    public partial class ConfigFileSaveForm : Form
    {
        public string fileName;
        public ConfigFileSaveForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            System.DateTime currDateTime = System.DateTime.Now;
            this.textBoxconfigName.Text = currDateTime.Year.ToString() + "_" + currDateTime.Month.ToString() + "_" + currDateTime.Day.ToString() + "_" + currDateTime.Hour.ToString() + "_" + currDateTime.Minute.ToString() + "_" + currDateTime.Second.ToString();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            this.fileName = this.textBoxconfigName.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
