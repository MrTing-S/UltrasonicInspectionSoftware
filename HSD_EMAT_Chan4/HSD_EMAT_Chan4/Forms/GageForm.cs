using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HSD_EMAT_Chan4.DLL;
using HSD_EMAT_Chan4.Models;

namespace HSD_EMAT_Chan4.Forms
{
    public partial class GageForm : Form
    {
        private int gageIndex;
        public GageForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            gageIndex = 0;
        }

        #region 闸门调整事件
        private void comboBoxGageTpye_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.gageIndex = this.comboBoxGageTpye.SelectedIndex;
            UpdateGageForm(AllForms.m_ParamSetForm.CurrChanNum);
        }

        private void trackBarGagePosX_Scroll(object sender, EventArgs e)
        {
            int index = AllForms.m_ParamSetForm.CurrChanNum;
            AllChannels.m_Channels[index].channelGage[gageIndex].InitIndexX = this.trackBarGagePosX.Value;
            AllForms.m_WaveForms[index].DrawGage(AllChannels.m_Channels[index].channelGage[gageIndex]);
        }

        private void trackBarGagePosY_Scroll(object sender, EventArgs e)
        {
            int index = AllForms.m_ParamSetForm.CurrChanNum;
            AllChannels.m_Channels[index].channelGage[gageIndex].InitIndexY = this.trackBarGagePosY.Value;
            AllForms.m_WaveForms[index].DrawGage(AllChannels.m_Channels[index].channelGage[gageIndex]);
        }

        private void trackBarGageLength_Scroll(object sender, EventArgs e)
        {
            int index = AllForms.m_ParamSetForm.CurrChanNum;
            AllChannels.m_Channels[index].channelGage[gageIndex].IndexLength = this.trackBarGageLength.Value;
            AllForms.m_WaveForms[index].DrawGage(AllChannels.m_Channels[index].channelGage[gageIndex]);
        }
        private void trackBar_Enter(object sender, EventArgs e)
        {
            AllForms.m_WaveForms[AllForms.m_ParamSetForm.CurrChanNum].Focus();
        }
        #endregion

        #region 公开函数
        //刷新闸门显示
        public void UpdateGageForm(int channel)
        {
            this.trackBarGagePosX.Value = AllChannels.m_Channels[channel].channelGage[gageIndex].InitIndexX;
            this.trackBarGagePosY.Value = AllChannels.m_Channels[channel].channelGage[gageIndex].InitIndexY;
            this.trackBarGageLength.Value = AllChannels.m_Channels[channel].channelGage[gageIndex].IndexLength;
            for (int i = 0; i < HSD_EMAT.totalGageNum; i++)
            {
                AllForms.m_WaveForms[channel].DrawGage(AllChannels.m_Channels[channel].channelGage[i]);
            }
        }

        public void UpdateGageInfoFormForm(int channel)
        {
            for (int i = 0; i < HSD_EMAT.totalGageNum; i++)
            {
                AllChannels.m_Channels[channel].channelGage[i].InitIndexX = this.trackBarGagePosX.Value;
                AllChannels.m_Channels[channel].channelGage[i].InitIndexY = this.trackBarGagePosY.Value;
                AllChannels.m_Channels[channel].channelGage[i].IndexLength = this.trackBarGageLength.Value;
            }
        }
        #endregion
    }
}
