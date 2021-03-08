using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HSD_EMAT_Chan4.Models;

namespace HSD_EMAT_Chan4.Forms
{
    public partial class DetectionSetForm : Form
    {
        Regex inputChecker;
        bool isDatalegal;
        public DetectionSetForm()
        {
            InitializeComponent();
            initView();
            inputChecker = new Regex(@"^[1-9]*[0-9]?(\.[0-9]{1,2})?$");//最高精度小数点后两位，正数，空
            isDatalegal = false;
        }
        private void initView()
        {
            this.pictureBoxDectionSet.Location = new Point(0, 0);
            this.pictureBoxDectionSet.Image = Image.FromFile(Application.StartupPath + @"\Resources\DetectionProcess.bmp");
            this.pictureBoxDectionSet.Height = Convert.ToInt32((double)this.pictureBoxDectionSet.Width * ((double)FormView.DetectionSetPicHeigh / (double)FormView.DetectionSetPicWidth));
            this.Width= this.pictureBoxDectionSet.Width+ (this.Width-ClientRectangle.Width);
            label.Parent = this.pictureBoxDectionSet;
            labelUnitInnerDefectLimit.Parent = this.pictureBoxDectionSet;
        }
        private void initDetectionSet()
        {
            
        }

        #region 输入数据检测
        private void textBoxthick_TextChanged(object sender, EventArgs e)
        {
            CheckDataLegal(textBoxthick, labelThicUnit);
        }

        private void textBoxthickLimit_TextChanged(object sender, EventArgs e)
        {
            CheckDataLegal(textBoxthickLimit, labelThickLimitUnit);
        }

        private void textBoxOuterDefectLimit_TextChanged(object sender, EventArgs e)
        {
            CheckDataLegal(textBoxOuterDefectLimit, label1OuterDefectLimit);
        }

        private void textBoxInnerDefectLimit_TextChanged(object sender, EventArgs e)
        {
            CheckDataLegal(textBoxInnerDefectLimit, labelUnitInnerDefectLimit);
        }

        private void textBoxSensorLeaveDelayTime_TextChanged(object sender, EventArgs e)
        {
            CheckDataLegal(textBoxSensorLeaveDelayTime, labelSenorLeaveDelayTimeUnit);
        }

        private void textBoxSensorEnterDelayTime_TextChanged(object sender, EventArgs e)
        {
            CheckDataLegal(textBoxSensorEnterDelayTime, labelSenorEnterDelayTimeUnit);
        }

        private void textBoxPipeLength_TextChanged(object sender, EventArgs e)
        {
            CheckDataLegal(textBoxPipeLength, labelPipeLengthUnit);
        }

        private void textBoxDiameter_TextChanged(object sender, EventArgs e)
        {
            CheckDataLegal(textBoxDiameter, labelDiameterUnit);
        }

        /// <summary>
        /// 判断输入数据是否合法
        /// </summary>
        /// <param name="textBox">输入数据的文本框</param>
        /// <param name="label">显示结果的字符</param>
        private void CheckDataLegal(TextBox textBox, Label label)
        {
            if ((!inputChecker.IsMatch(textBox.Text)) || textBox.Text == null || textBox.Text == "")
            {
                label.ForeColor = System.Drawing.Color.Red;
                this.isDatalegal = false;
            }
            else if (Convert.ToDouble(textBox.Text) == 0)
            {
                label.ForeColor = System.Drawing.Color.Red;
                this.isDatalegal = false;
            }
            else
            {
                label.ForeColor = System.Drawing.Color.Black;
                this.isDatalegal = true;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
