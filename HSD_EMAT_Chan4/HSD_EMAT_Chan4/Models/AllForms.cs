namespace HSD_EMAT_Chan4.Models
{
    using HSD_EMAT_Chan4.Forms;
    public static class AllForms
    {
        public static MainForm m_MainForm;
        public static ParamSetForm m_ParamSetForm;
        public static WaveForm[] m_WaveForms = new WaveForm[HSD_EMAT.totalChannelNum];
        public static GageForm m_GageForm;
        public static MutiScanForm m_MutiScanForm;
    }
}
