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
    public static class AllFormsSet
    {
        
        public static  void InitAllForms(MainForm mainForm)
        {
            AllForms.m_MainForm = mainForm;
            for (int i = 0; i < HSD_EMAT.totalChannelNum; i++)
            {
                AllForms.m_WaveForms[i] = new WaveForm();
                AllForms.m_WaveForms[i].Text = "通道" + (i+1).ToString();
            }
            AllForms.m_ParamSetForm = new ParamSetForm();
            for (int i = 0; i < 4; i++)
            {
                AllForms.m_WaveForms[i].MdiParent = AllForms.m_MainForm;
                AllForms.m_WaveForms[i].m_ChangeFormSize((AllForms.m_MainForm.Width - FormView.paramSetFormWidth) / 2, (AllForms.m_MainForm.Height - AllForms.m_MainForm.toolStrip1.Bottom - AllForms.m_MainForm.menuStrip1.Bottom) / 2);
                AllForms.m_WaveForms[i].StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            }
            AllForms.m_WaveForms[0].Location = new Point(0, 0);
            AllForms.m_WaveForms[1].Location = new Point(AllForms.m_WaveForms[0].Width, 0);
            AllForms.m_WaveForms[2].Location = new Point(0, AllForms.m_WaveForms[0].Height);
            AllForms.m_WaveForms[3].Location = new Point(AllForms.m_WaveForms[0].Width, AllForms.m_WaveForms[0].Height);
            SetParamFormLayout();
        }

        static public  void UpDateFormLayOut()
        {
            switch (FormView.m_aveFromViewType.ToString())
            {
                case "type1":
                {
                        SetWaveFromLayoutType1();
                        break;
                }
                case "type2":
                {
                        SetWaveFromLayoutType2();
                        break;
                }
                case "type3":
                {
                        SetWaveFromLayoutType3();
                        break;
                }
            }
        }

        /// <summary>
        /// 改视图为2*2个波形窗口的布局
        /// </summary>
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
            AllForms.m_ParamSetForm.Show();
        }

        private static void SetWaveFromLayoutType2()
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
            AllForms.m_WaveForms[0].Show();
            
            AllForms.m_ParamSetForm.Show();

        }

        private static void SetWaveFromLayoutType3()
        {

        }


        /// <summary>
        /// 布局参数设置窗口
        /// </summary>
        private static void SetParamFormLayout()
        {
            if (AllForms.m_ParamSetForm == null||AllForms.m_MainForm==null)
            {
                return;
            }
            AllForms.m_ParamSetForm.Size = new Size(FormView.paramSetFormWidth, AllForms.m_MainForm.Height - AllForms.m_MainForm.toolStrip1.Bottom - AllForms.m_MainForm.menuStrip1.Bottom);
            AllForms.m_ParamSetForm.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            AllForms.m_ParamSetForm.MdiParent = AllForms.m_MainForm;
            AllForms.m_ParamSetForm.Location = new Point(AllForms.m_WaveForms[0].Width * 2, 0);
        }
    }
}
