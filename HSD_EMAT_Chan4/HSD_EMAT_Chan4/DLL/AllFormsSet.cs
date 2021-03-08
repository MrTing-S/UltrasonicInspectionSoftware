using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSD_EMAT_Chan4.Forms;
using HSD_EMAT_Chan4.Models;
using System.Windows.Forms;

namespace HSD_EMAT_Chan4.DLL
{
    public static  class AllFormsSet
    {
        #region 初始化视图
        public static void InitAllForms(MainForm mainForm)
        {
            AllForms.m_MainForm = mainForm;
            for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
            {
                AllForms.m_WaveForms[i] = new WaveForm();
                AllForms.m_WaveForms[i].Text = "通道" + (i+1).ToString();
                AllForms.m_WaveForms[i].MdiParent = AllForms.m_MainForm;
            }
            SetChartFormLayout();
            AllForms.m_ParamSetForm = new ParamSetForm();
            AllForms.m_ParamSetForm.MdiParent = AllForms.m_MainForm;
            SetParamFormLayout();
            AllForms.m_GageForm = new GageForm();
            AllForms.m_GageForm.MdiParent = AllForms.m_MainForm;
            SetGageFormLayout();
            AllForms.m_MutiScanForm = new MutiScanForm();
            AllForms.m_MutiScanForm.MdiParent = AllForms.m_MainForm;
            SetMutiScanFormLayout();
        }
        #endregion

        #region 子窗体布局
        private static void SetParamFormLayout()
        {
            if (AllForms.m_ParamSetForm == null || AllForms.m_MainForm == null)
            {
                return;
            }
            AllForms.m_ParamSetForm.Size = new Size(FormView.paramSetFormWidth, AllForms.m_MainForm.GetMainFormWorkingSpace().Height);
            AllForms.m_ParamSetForm.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            AllForms.m_ParamSetForm.Location = new Point(AllForms.m_MainForm.GetMainFormWorkingSpace().Width - FormView.paramSetFormWidth, 0);
        }

        private static void SetChartFormLayout()
        {
            if (AllForms.m_WaveForms == null)
            {
                return;
            }
            for (int i = 0; i < 4; i++)
            {
                AllForms.m_WaveForms[i].Size = new Size((AllForms.m_MainForm.GetMainFormWorkingSpace().Width - FormView.paramSetFormWidth) / 2, (AllForms.m_MainForm.GetMainFormWorkingSpace().Height) / 2);
                AllForms.m_WaveForms[i].StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            }
            AllForms.m_WaveForms[0].Location = new Point(0, 0);
            AllForms.m_WaveForms[1].Location = new Point(AllForms.m_WaveForms[0].Width, 0);
            AllForms.m_WaveForms[2].Location = new Point(0, AllForms.m_WaveForms[0].Height);
            AllForms.m_WaveForms[3].Location = new Point(AllForms.m_WaveForms[0].Width, AllForms.m_WaveForms[0].Height);
        }

        private static void SetGageFormLayout()
        {
            if (AllForms.m_ParamSetForm == null || AllForms.m_MainForm == null)
            {
                return;
            }
            AllForms.m_GageForm.Size = new Size(FormView.gageSetFormWidth, AllForms.m_MainForm.GetMainFormWorkingSpace().Height);
            AllForms.m_GageForm.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            AllForms.m_GageForm.Location = new Point(AllForms.m_MainForm.GetMainFormWorkingSpace().Width - FormView.paramSetFormWidth - FormView.gageSetFormWidth, 0);
        }

        private static void SetMutiScanFormLayout()
        {
            if (AllForms.m_MutiScanForm == null || AllForms.m_MainForm == null)
            {
                return;
            }
            AllForms.m_MutiScanForm.Size = new Size(AllForms.m_MainForm.GetMainFormWorkingSpace().Width-FormView.paramSetFormWidth, AllForms.m_MainForm.GetMainFormWorkingSpace().Height);
            AllForms.m_MutiScanForm.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            AllForms.m_MutiScanForm.Location = new Point(0, 0);
        }
        #endregion

        #region 视图模式

        public static void UpDateFormLayOut()
        {
            switch (FormView.m_aveFromViewType.ToString())
            {
                case "type1":
                    {
                        SetWaveFromLayoutType1();
                        AllForms.m_MainForm.Invalidate();
                        break;
                    }
                case "type2":
                    {
                        SetWaveFromLayoutType2(0);
                        AllForms.m_MainForm.Invalidate();
                        break;
                    }
                case "type3":
                    {
                        SetWaveFromLayoutType3();
                        AllForms.m_MainForm.Invalidate();
                        break;
                    }
                case "type4":
                    {
                        SetWaveFromLayoutType4(0);
                        AllForms.m_MainForm.Invalidate();
                        break;
                    }
                case "type5":
                    {
                        SetWaveFromLayoutType5();
                        AllForms.m_MainForm.Invalidate();
                        break;
                    }
            }
        }


        public static void UpDateFormLayOut(int channelNum)
        {
            if (FormView.m_aveFromViewType == FromViewType.type2)
            {
                SetWaveFromLayoutType2(channelNum);
            }
            else if (FormView.m_aveFromViewType == FromViewType.type4)
            {
                SetWaveFromLayoutType4(channelNum);
            }
            else
            {
                UpDateFormLayOut();
            }
        }

        //2*2波形视图
        private static void SetWaveFromLayoutType1()
        {
            if (AllForms.m_MainForm == null)
            {
                return;
            }
            foreach (WaveForm item in AllForms.m_WaveForms)
            {
                if (item == null)
                {
                    return;
                }
            }
            foreach (Form item in AllForms.m_MainForm.MdiChildren)
            {
                item.Hide();//关闭所有子窗体
            }
            for (int i = 0; i < 4; i++)
            {
                AllForms.m_WaveForms[i].Show();
            }
            foreach (WaveForm item in AllForms.m_WaveForms)
            {
                item.UpdateChartView();
            }
            FormView.chartViewType = ChartViewType.waveChart;
            SetChartFormLayout();
            SetParamFormLayout();
            AllForms.m_ParamSetForm.Show();
        }

        //单通道视图
        private static void SetWaveFromLayoutType2(int channelNum)
        {
            if (channelNum > HSD_EMAT.totalChannelNum)
            {
                return;
            }
            if (AllForms.m_MainForm == null)
            {
                return;
            }
            foreach (WaveForm item in AllForms.m_WaveForms)
            {
                if (item == null)
                {
                    return;
                }
            }
            foreach (Form item in AllForms.m_MainForm.MdiChildren)
            {
                item.Hide();//关闭所有子窗体
            }
            SetParamFormLayout();
            FormView.chartViewType = ChartViewType.scanChart;
            AllForms.m_WaveForms[channelNum].UpdateChartView();
            AllForms.m_WaveForms[channelNum].Location = new Point(0, 0);
            AllForms.m_WaveForms[channelNum].Size =new Size(AllForms.m_MainForm.GetMainFormWorkingSpace().Width-AllForms.m_ParamSetForm.Size.Width, AllForms.m_ParamSetForm.Height);
            AllForms.m_WaveForms[channelNum].Show();
            AllForms.m_ParamSetForm.Show();
        }

        //2*2扫描视图
        private static void SetWaveFromLayoutType3()
        {
            if (AllForms.m_MainForm == null)
            {
                return;
            }
            foreach (WaveForm item in AllForms.m_WaveForms)
            {
                if (item == null)
                {
                    return;
                }
            }
            foreach (Form item in AllForms.m_MainForm.MdiChildren)
            {
                item.Hide();//关闭所有子窗体
            }
            SetChartFormLayout();
            SetParamFormLayout();
            FormView.chartViewType = ChartViewType.scanChart;
            foreach (WaveForm item in AllForms.m_WaveForms)
            {
                item.UpdateChartView();
                item.Show();
            }
            AllForms.m_ParamSetForm.Show();
        }

        private static void SetWaveFromLayoutType4(int channelNum)
        {
            if (channelNum > HSD_EMAT.totalChannelNum)
            {
                return;
            }
            if (AllForms.m_MainForm == null)
            {
                return;
            }
            foreach (WaveForm item in AllForms.m_WaveForms)
            {
                if (item == null)
                {
                    return;
                }
            }
            foreach (Form item in AllForms.m_MainForm.MdiChildren)
            {
                item.Hide();//关闭所有子窗体
            }
            SetParamFormLayout();
            SetGageFormLayout();
            FormView.chartViewType = ChartViewType.waveChart;
            AllForms.m_WaveForms[channelNum].UpdateChartView();
            AllForms.m_WaveForms[channelNum].Location = new Point(0, 0);
            AllForms.m_WaveForms[channelNum].Size = new Size(AllForms.m_MainForm.GetMainFormWorkingSpace().Width - AllForms.m_ParamSetForm.Size.Width-AllForms.m_ParamSetForm.Width, AllForms.m_ParamSetForm.Height);
            AllForms.m_WaveForms[channelNum].Show();
            AllForms.m_GageForm.Show();
            AllForms.m_ParamSetForm.Show();
        }

        private static  void SetWaveFromLayoutType5()
        {
            foreach (Form item in AllForms.m_MainForm.MdiChildren)
            {
                item.Hide();//关闭所有子窗体
            }
            SetParamFormLayout();
            SetMutiScanFormLayout();
            AllForms.m_ParamSetForm.Show();
            AllForms.m_MutiScanForm.Show();
        }
        #endregion
    }
}
