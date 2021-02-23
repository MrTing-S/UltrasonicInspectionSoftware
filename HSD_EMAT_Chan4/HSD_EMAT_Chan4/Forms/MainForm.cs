namespace HSD_EMAT_Chan4.Forms
{
    using Sunisoft.IrisSkin;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;
    using HSD_EMAT_Chan4.DLL;
    using HSD_EMAT_Chan4.Models;

    public class MainForm : Form
    {
        #region 新建控件
        private ToolStripMenuItem aboutAToolStripMenuItem;
        private IContainer components;
        private ToolStripMenuItem DefaultToolStripMenuItem;
        private OpenFileDialog fFileOpenDlg;
        private SaveFileDialog fFileSaveAsDlg;
        private SaveFileDialog fFileSaveScanDlg;
        private System.Windows.Forms.Timer FormTimer;
        private ToolStripMenuItem HelpToolStripMenuItem;
        private ToolStripMenuItem MeasureMBToolStripMenuItem;
        private ToolStripMenuItem MenuItemAlarmAnalog;
        private ToolStripMenuItem MenuItemAlarmOutput;
        private ToolStripMenuItem MenuItemAlarmSound;
        private ToolStripMenuItem menuItemAutoDetectionSettings;
        private ToolStripMenuItem menuItemChannelGroupSettings;
        private ToolStripMenuItem menuItemChannelParameter;
        private ToolStripMenuItem menuItemChannelPositionSettings;
        private ToolStripMenuItem menuItemChannelWork;
        private ToolStripMenuItem menuItemChannelWorkDisable;
        private ToolStripMenuItem menuItemChannelWorkEnable;
        private ToolStripMenuItem menuItemCheckInfo;
        private ToolStripMenuItem menuItemCheckPlanList;
        private ToolStripMenuItem MenuItemCN;
        private ToolStripMenuItem menuItemConnectToServer;
        private ToolStripMenuItem MenuItemCustomTemplate;
        private ToolStripMenuItem MenuItemDefaultTemplate;
        private ToolStripMenuItem menuItemDGateAlarm;
        private ToolStripMenuItem MenuItemEN;
        private ToolStripMenuItem menuItemEncoder;
        private ToolStripMenuItem menuItemFreezeAllChannel;
        private ToolStripMenuItem menuItemFrequencyDetect;
        private ToolStripMenuItem MenuItemGenReport;
        private ToolStripMenuItem menuItemHeightMeasure;
        private ToolStripMenuItem menuItemImageCapture;
        private ToolStripMenuItem menuItemImageChannel;
        private ToolStripMenuItem menuItemImportCheckPlanList;
        private ToolStripMenuItem MenuItemLanguage;
        private ToolStripMenuItem menuItemLengthMeasure;
        private ToolStripMenuItem MenuItemLoadSetting;
        private ToolStripMenuItem menuItemMaxWaveDataSave;
        private ToolStripMenuItem menuItemMeasThicknessSettings;
        private ToolStripMenuItem menuItemMeasureLine;
        private ToolStripMenuItem menuItemMeasureResultList;
        private ToolStripMenuItem MenuItemOpenFile;
        private ToolStripMenuItem menuItemPeakTrackSettings;
        private ToolStripMenuItem menuItemPrintScreen;
        private ToolStripMenuItem menuItemRealMeasureValue;
        private ToolStripMenuItem menuItemRealMeasureValueHide;
        private ToolStripMenuItem menuItemRealMeasureValueVisible;
        private ToolStripMenuItem menuItemRectMeasure;
        private ToolStripMenuItem menuItemSeverStop;
        private ToolStripMenuItem menuItemFireWallSetting;
        private ToolStripMenuItem MenuItemSave;
        private ToolStripMenuItem menuItemSaveAsPicture;
        private ToolStripMenuItem menuItemScanForm;
        private ToolStripMenuItem menuItemScanImageZoom;
        private ToolStripMenuItem menuItemScanStart;
        private ToolStripMenuItem menuItemScanStop;
        private ToolStripMenuItem menuItemScanView;
        private ToolStripMenuItem menuItemScanViewType1;
        private ToolStripMenuItem menuItemScanViewType2;
        private ToolStripMenuItem menuItemScanViewType3;
        private ToolStripMenuItem menuItemScanViewType4;
        private ToolStripMenuItem menuItemScanViewType5;
        private ToolStripMenuItem menuItemScanZoomNormal;
        private ToolStripMenuItem menuItemScanZoomUserDefined;
        private ToolStripMenuItem MenuItemSensor;
        private ToolStripMenuItem menuItemSensorCtrlChannelLSettings;
        private ToolStripMenuItem MenuItemSpray;
        private ToolStripMenuItem menuItemToolsOptions;
        private ToolStripMenuItem MenuItemTU;
        private ToolStripMenuItem menuItemWaveformForm;
        public  MenuStrip menuStrip1;
        public int[] nBaseline;
        public int[] nRectifyReject;
       /// private File3201.FileType OpenFileType;
        public Thread oSerialSendThread;
        private ToolStripMenuItem PrintToolStripMenuItem;
        private ToolStripMenuItem ProbeIconMenuItem;
        private ToolStripMenuItem QuitToolStripMenuItem;
        private ToolStripMenuItem SaveScanningToolStripMenuItem;
        public int SensorStartFlag;
        private SkinEngine skinEngine1;
        private ToolStripMenuItem TemperatureVelToolStripMenuItem;
        private int tmp;
        public  ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButtonAlarmSoundSwitch;
        private ToolStripButton toolStripButtonCalc;
        private ToolStripButton toolStripButtonCapture;
        private ToolStripButton toolStripButtonChannelWork;
        private ToolStripButton toolStripButtonDepth;
        private ToolStripButton toolStripButtonEncoderAdjust;
        private ToolStripButton toolStripButtonExportMeasure;
        private ToolStripButton toolStripButtonStart;
        private ToolStripButton toolStripButtonImportCheckList;
        private ToolStripButton toolStripButtonLength;
        private ToolStripButton toolStripButtonLengthDepth;
        private ToolStripButton toolStripButtonMaxDataS;
        private ToolStripButton toolStripButtonMsPaint;
        private ToolStripButton toolStripButtonReport;
        public  ToolStripButton toolStripButtonRun;
        private ToolStripButton toolStripButtonSerialSendSwitch;
        private ToolStripButton toolStripButtonStop;
        private ToolStripButton toolStripButtonSaveWaveData;
        private ToolStripButton toolStripButtonWaveOrScan;
        private ToolStripButton toolStripButtonZoomIn;
        private ToolStripButton toolStripButtonZoomOut;
        private ToolStripComboBox toolStripComboBoxChannel;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripSeparator toolStripSeparator15;
        private ToolStripSeparator toolStripSeparator16;
        private ToolStripSeparator toolStripSeparator17;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem 工具TToolStripMenuItem;
        private ToolStripMenuItem 连接ToolStripMenuItem;
        private ToolStripMenuItem 扫描SToolStripMenuItem;
        private ToolStripMenuItem 设置ToolStripMenuItem;
        private ToolStripMenuItem 通道ToolStripMenuItem;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelVision;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusConnectStatus;
        private ToolStripMenuItem 显示DToolStripMenuItem;
        #endregion

        //数据保存
        private WaveDataFile m_WaveDataFile;
        public  double[] readDataBuf;




        public MainForm()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";//读取皮肤文件路径
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FormTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveScanningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSaveAsPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPrintScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.QuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConnectToServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFireWallSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSeverStop = new System.Windows.Forms.ToolStripMenuItem();
            this.通道ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemChannelParameter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFreezeAllChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemChannelWork = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemChannelWorkEnable = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemChannelWorkDisable = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMaxWaveDataSave = new System.Windows.Forms.ToolStripMenuItem();
            this.显示DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemWaveformForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemScanForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemScanView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemScanViewType1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemScanViewType2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemScanViewType3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemScanViewType4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemScanViewType5 = new System.Windows.Forms.ToolStripMenuItem();
            this.扫描SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCheckPlanList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemScanStart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemScanStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemImageChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemScanImageZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemScanZoomNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemScanZoomUserDefined = new System.Windows.Forms.ToolStripMenuItem();
            this.MeasureMBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLengthMeasure = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHeightMeasure = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRectMeasure = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemMeasureLine = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemMeasureResultList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRealMeasureValue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRealMeasureValueVisible = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRealMeasureValueHide = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPeakTrackSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEncoder = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSensor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSpray = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAlarmOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAlarmAnalog = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAlarmSound = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCheckInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemChannelPositionSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemChannelGroupSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSensorCtrlChannelLSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMeasThicknessSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAutoDetectionSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.DefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemImportCheckPlanList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemImageCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.TemperatureVelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProbeIconMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFrequencyDetect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDGateAlarm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemLoadSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemToolsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDefaultTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCustomTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemGenReport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCN = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEN = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTU = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonWaveOrScan = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveWaveData = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRun = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEncoderAdjust = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonImportCheckList = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLength = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxChannel = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonCapture = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDepth = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLengthDepth = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExportMeasure = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCalc = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMsPaint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonChannelWork = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMaxDataS = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSerialSendSwitch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAlarmSoundSwitch = new System.Windows.Forms.ToolStripButton();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelVision = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusConnectStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormTimer
            // 
            this.FormTimer.Interval = 30;
            this.FormTimer.Tick += new System.EventHandler(this.FormTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.连接ToolStripMenuItem,
            this.通道ToolStripMenuItem,
            this.显示DToolStripMenuItem,
            this.扫描SToolStripMenuItem,
            this.MeasureMBToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.PrintToolStripMenuItem,
            this.MenuItemLanguage,
            this.HelpToolStripMenuItem,
            this.aboutAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1323, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemOpenFile,
            this.toolStripSeparator11,
            this.MenuItemSave,
            this.SaveScanningToolStripMenuItem,
            this.toolStripSeparator2,
            this.menuItemSaveAsPicture,
            this.menuItemPrintScreen,
            this.toolStripSeparator12,
            this.QuitToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.文件ToolStripMenuItem.Tag = "File(&F)";
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            this.文件ToolStripMenuItem.Click += new System.EventHandler(this.文件ToolStripMenuItem_Click);
            // 
            // MenuItemOpenFile
            // 
            this.MenuItemOpenFile.Name = "MenuItemOpenFile";
            this.MenuItemOpenFile.Size = new System.Drawing.Size(224, 26);
            this.MenuItemOpenFile.Tag = "Open File(&O)";
            this.MenuItemOpenFile.Text = "打开文件(&O)...";
            this.MenuItemOpenFile.Click += new System.EventHandler(this.MenuItemOpenFile_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(221, 6);
            // 
            // MenuItemSave
            // 
            this.MenuItemSave.Name = "MenuItemSave";
            this.MenuItemSave.Size = new System.Drawing.Size(224, 26);
            this.MenuItemSave.Tag = "Save Demarcate File(&S)";
            this.MenuItemSave.Text = "保存标定文件(&S)";
            this.MenuItemSave.Click += new System.EventHandler(this.MenuItemSave_Click);
            // 
            // SaveScanningToolStripMenuItem
            // 
            this.SaveScanningToolStripMenuItem.Name = "SaveScanningToolStripMenuItem";
            this.SaveScanningToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SaveScanningToolStripMenuItem.Tag = "Save Scan File(&X)";
            this.SaveScanningToolStripMenuItem.Text = "保存扫查文件(&I)";
            this.SaveScanningToolStripMenuItem.Click += new System.EventHandler(this.SaveScanningToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // menuItemSaveAsPicture
            // 
            this.menuItemSaveAsPicture.Name = "menuItemSaveAsPicture";
            this.menuItemSaveAsPicture.Size = new System.Drawing.Size(224, 26);
            this.menuItemSaveAsPicture.Tag = "Save as picture...";
            this.menuItemSaveAsPicture.Text = "另存为图片(&P)...";
            this.menuItemSaveAsPicture.Click += new System.EventHandler(this.menuItemSaveAsPicture_Click);
            // 
            // menuItemPrintScreen
            // 
            this.menuItemPrintScreen.Name = "menuItemPrintScreen";
            this.menuItemPrintScreen.Size = new System.Drawing.Size(224, 26);
            this.menuItemPrintScreen.Tag = "menuItemPrintScreen";
            this.menuItemPrintScreen.Text = "打印屏幕(&R)...";
            this.menuItemPrintScreen.Click += new System.EventHandler(this.menuItemPrintScreen_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(221, 6);
            // 
            // QuitToolStripMenuItem
            // 
            this.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
            this.QuitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.QuitToolStripMenuItem.Tag = "Quit(&Q)";
            this.QuitToolStripMenuItem.Text = "退出(&X)";
            this.QuitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // 连接ToolStripMenuItem
            // 
            this.连接ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemConnectToServer,
            this.menuItemFireWallSetting,
            this.menuItemSeverStop});
            this.连接ToolStripMenuItem.Name = "连接ToolStripMenuItem";
            this.连接ToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.连接ToolStripMenuItem.Tag = "Connection(&C)";
            this.连接ToolStripMenuItem.Text = "连接(&C)";
            this.连接ToolStripMenuItem.Click += new System.EventHandler(this.连接ToolStripMenuItem_Click);
            // 
            // menuItemConnectToServer
            // 
            this.menuItemConnectToServer.Name = "menuItemConnectToServer";
            this.menuItemConnectToServer.Size = new System.Drawing.Size(185, 26);
            this.menuItemConnectToServer.Tag = "Connect to local host(&C)";
            this.menuItemConnectToServer.Text = "连接主机(&C)";
            this.menuItemConnectToServer.Click += new System.EventHandler(this.menuItemConnectToServer_Click);
            // 
            // menuItemFireWallSetting
            // 
            this.menuItemFireWallSetting.Name = "menuItemFireWallSetting";
            this.menuItemFireWallSetting.Size = new System.Drawing.Size(185, 26);
            this.menuItemFireWallSetting.Tag = "Run as server(&S)";
            this.menuItemFireWallSetting.Text = "网络设置(&S)";
            this.menuItemFireWallSetting.Click += new System.EventHandler(this.menuItemFireWallSetting_Click);
            // 
            // menuItemSeverStop
            // 
            this.menuItemSeverStop.Name = "menuItemSeverStop";
            this.menuItemSeverStop.Size = new System.Drawing.Size(185, 26);
            this.menuItemSeverStop.Tag = "SeverStoop(&L)";
            this.menuItemSeverStop.Text = "关闭服务器(&L)";
            this.menuItemSeverStop.Click += new System.EventHandler(this.menuItemSeverStop_Click);
            // 
            // 通道ToolStripMenuItem
            // 
            this.通道ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemChannelParameter,
            this.menuItemFreezeAllChannel,
            this.menuItemChannelWork,
            this.menuItemMaxWaveDataSave});
            this.通道ToolStripMenuItem.Name = "通道ToolStripMenuItem";
            this.通道ToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.通道ToolStripMenuItem.Tag = "Channel(&H)";
            this.通道ToolStripMenuItem.Text = "通道(&H)";
            this.通道ToolStripMenuItem.Click += new System.EventHandler(this.通道ToolStripMenuItem_Click);
            // 
            // menuItemChannelParameter
            // 
            this.menuItemChannelParameter.Name = "menuItemChannelParameter";
            this.menuItemChannelParameter.Size = new System.Drawing.Size(205, 26);
            this.menuItemChannelParameter.Tag = "Parameter(&P)";
            this.menuItemChannelParameter.Text = "数据保存设置(&P).";
            this.menuItemChannelParameter.Click += new System.EventHandler(this.menuItemChannelParameter_Click);
            // 
            // menuItemFreezeAllChannel
            // 
            this.menuItemFreezeAllChannel.Name = "menuItemFreezeAllChannel";
            this.menuItemFreezeAllChannel.Size = new System.Drawing.Size(205, 26);
            this.menuItemFreezeAllChannel.Tag = "Freeze";
            this.menuItemFreezeAllChannel.Text = "冻结";
            this.menuItemFreezeAllChannel.Click += new System.EventHandler(this.menuItemFreezeAllChannel_Click);
            // 
            // menuItemChannelWork
            // 
            this.menuItemChannelWork.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemChannelWorkEnable,
            this.menuItemChannelWorkDisable});
            this.menuItemChannelWork.Name = "menuItemChannelWork";
            this.menuItemChannelWork.Size = new System.Drawing.Size(205, 26);
            this.menuItemChannelWork.Tag = "MenuItemChannelWork";
            this.menuItemChannelWork.Text = "通道工作";
            // 
            // menuItemChannelWorkEnable
            // 
            this.menuItemChannelWorkEnable.Checked = true;
            this.menuItemChannelWorkEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItemChannelWorkEnable.Name = "menuItemChannelWorkEnable";
            this.menuItemChannelWorkEnable.Size = new System.Drawing.Size(122, 26);
            this.menuItemChannelWorkEnable.Tag = "MenuItemChannelWorkEnable";
            this.menuItemChannelWorkEnable.Text = "开启";
            this.menuItemChannelWorkEnable.Click += new System.EventHandler(this.menuItemChannelWorkEnable_Click);
            // 
            // menuItemChannelWorkDisable
            // 
            this.menuItemChannelWorkDisable.Name = "menuItemChannelWorkDisable";
            this.menuItemChannelWorkDisable.Size = new System.Drawing.Size(122, 26);
            this.menuItemChannelWorkDisable.Tag = "MenuItemChannelWorkDisable";
            this.menuItemChannelWorkDisable.Text = "关闭";
            this.menuItemChannelWorkDisable.Click += new System.EventHandler(this.menuItemChannelWorkDisable_Click);
            // 
            // menuItemMaxWaveDataSave
            // 
            this.menuItemMaxWaveDataSave.Name = "menuItemMaxWaveDataSave";
            this.menuItemMaxWaveDataSave.Size = new System.Drawing.Size(205, 26);
            this.menuItemMaxWaveDataSave.Tag = "MenuItemMaxDataMemory";
            this.menuItemMaxWaveDataSave.Text = "峰值记忆";
            this.menuItemMaxWaveDataSave.Click += new System.EventHandler(this.menuItemMaxWaveAllChannel_Click);
            // 
            // 显示DToolStripMenuItem
            // 
            this.显示DToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemWaveformForm,
            this.menuItemScanForm,
            this.menuItemScanView});
            this.显示DToolStripMenuItem.Name = "显示DToolStripMenuItem";
            this.显示DToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.显示DToolStripMenuItem.Tag = "Display(&D)";
            this.显示DToolStripMenuItem.Text = "显示(&D)";
            this.显示DToolStripMenuItem.Click += new System.EventHandler(this.显示DToolStripMenuItem_Click);
            // 
            // menuItemWaveformForm
            // 
            this.menuItemWaveformForm.Checked = true;
            this.menuItemWaveformForm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItemWaveformForm.Name = "menuItemWaveformForm";
            this.menuItemWaveformForm.Size = new System.Drawing.Size(143, 26);
            this.menuItemWaveformForm.Tag = "Debug(&D)";
            this.menuItemWaveformForm.Text = "调试(&D)";
            this.menuItemWaveformForm.Click += new System.EventHandler(this.menuItemWaveformForm_Click);
            // 
            // menuItemScanForm
            // 
            this.menuItemScanForm.Name = "menuItemScanForm";
            this.menuItemScanForm.Size = new System.Drawing.Size(143, 26);
            this.menuItemScanForm.Tag = "Scan(&S)";
            this.menuItemScanForm.Text = "扫描(&S)";
            this.menuItemScanForm.Click += new System.EventHandler(this.menuItemScanForm_Click);
            // 
            // menuItemScanView
            // 
            this.menuItemScanView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemScanViewType1,
            this.menuItemScanViewType2,
            this.menuItemScanViewType3,
            this.menuItemScanViewType4,
            this.menuItemScanViewType5});
            this.menuItemScanView.Name = "menuItemScanView";
            this.menuItemScanView.Size = new System.Drawing.Size(143, 26);
            this.menuItemScanView.Tag = "menuItemScanView";
            this.menuItemScanView.Text = "视图(&V)";
            // 
            // menuItemScanViewType1
            // 
            this.menuItemScanViewType1.Name = "menuItemScanViewType1";
            this.menuItemScanViewType1.Size = new System.Drawing.Size(135, 26);
            this.menuItemScanViewType1.Tag = "menuItemScanViewType1";
            this.menuItemScanViewType1.Text = "类型 1";
            this.menuItemScanViewType1.Click += new System.EventHandler(this.menuItemScanViewType1_Click);
            // 
            // menuItemScanViewType2
            // 
            this.menuItemScanViewType2.Name = "menuItemScanViewType2";
            this.menuItemScanViewType2.Size = new System.Drawing.Size(135, 26);
            this.menuItemScanViewType2.Tag = "menuItemScanViewType2";
            this.menuItemScanViewType2.Text = "类型 2";
            this.menuItemScanViewType2.Click += new System.EventHandler(this.menuItemScanViewType2_Click);
            // 
            // menuItemScanViewType3
            // 
            this.menuItemScanViewType3.Name = "menuItemScanViewType3";
            this.menuItemScanViewType3.Size = new System.Drawing.Size(135, 26);
            this.menuItemScanViewType3.Tag = "menuItemScanViewType3";
            this.menuItemScanViewType3.Text = "类型 3";
            this.menuItemScanViewType3.Click += new System.EventHandler(this.menuItemScanViewType3_Click);
            // 
            // menuItemScanViewType4
            // 
            this.menuItemScanViewType4.Name = "menuItemScanViewType4";
            this.menuItemScanViewType4.Size = new System.Drawing.Size(135, 26);
            this.menuItemScanViewType4.Tag = "menuItemScanViewType4";
            this.menuItemScanViewType4.Text = "类型 4";
            this.menuItemScanViewType4.Click += new System.EventHandler(this.menuItemScanViewType4_Click);
            // 
            // menuItemScanViewType5
            // 
            this.menuItemScanViewType5.Name = "menuItemScanViewType5";
            this.menuItemScanViewType5.Size = new System.Drawing.Size(135, 26);
            this.menuItemScanViewType5.Tag = "menuItemScanViewType5";
            this.menuItemScanViewType5.Text = "类型 5";
            this.menuItemScanViewType5.Click += new System.EventHandler(this.menuItemScanViewType5_Click_1);
            // 
            // 扫描SToolStripMenuItem
            // 
            this.扫描SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCheckPlanList,
            this.toolStripSeparator4,
            this.menuItemScanStart,
            this.menuItemScanStop,
            this.toolStripSeparator1,
            this.menuItemImageChannel,
            this.menuItemScanImageZoom});
            this.扫描SToolStripMenuItem.Name = "扫描SToolStripMenuItem";
            this.扫描SToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.扫描SToolStripMenuItem.Tag = "Scan(&S)";
            this.扫描SToolStripMenuItem.Text = "扫描(&S)";
            this.扫描SToolStripMenuItem.Click += new System.EventHandler(this.扫描SToolStripMenuItem_Click);
            // 
            // menuItemCheckPlanList
            // 
            this.menuItemCheckPlanList.Name = "menuItemCheckPlanList";
            this.menuItemCheckPlanList.Size = new System.Drawing.Size(212, 26);
            this.menuItemCheckPlanList.Tag = "Check List(&L)...";
            this.menuItemCheckPlanList.Text = "检测计划清单(&L)...";
            this.menuItemCheckPlanList.Click += new System.EventHandler(this.menuItemCheckPlanList_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(209, 6);
            // 
            // menuItemScanStart
            // 
            this.menuItemScanStart.Name = "menuItemScanStart";
            this.menuItemScanStart.Size = new System.Drawing.Size(212, 26);
            this.menuItemScanStart.Tag = "Run(&T)";
            this.menuItemScanStart.Text = "启动(&T)";
            this.menuItemScanStart.Click += new System.EventHandler(this.menuItemScanStart_Click);
            // 
            // menuItemScanStop
            // 
            this.menuItemScanStop.Name = "menuItemScanStop";
            this.menuItemScanStop.Size = new System.Drawing.Size(212, 26);
            this.menuItemScanStop.Tag = "Stop(&O)";
            this.menuItemScanStop.Text = "停止(&O)";
            this.menuItemScanStop.Click += new System.EventHandler(this.menuItemScanStop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // menuItemImageChannel
            // 
            this.menuItemImageChannel.Name = "menuItemImageChannel";
            this.menuItemImageChannel.Size = new System.Drawing.Size(212, 26);
            this.menuItemImageChannel.Tag = "Image Channel(&C)...";
            this.menuItemImageChannel.Text = "图像通道(&C)...";
            this.menuItemImageChannel.Click += new System.EventHandler(this.menuItemImageChannel_Click);
            // 
            // menuItemScanImageZoom
            // 
            this.menuItemScanImageZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemScanZoomNormal,
            this.menuItemScanZoomUserDefined});
            this.menuItemScanImageZoom.Name = "menuItemScanImageZoom";
            this.menuItemScanImageZoom.Size = new System.Drawing.Size(212, 26);
            this.menuItemScanImageZoom.Tag = "Zoom(&Z)...";
            this.menuItemScanImageZoom.Text = "显示比例(&Z)...";
            this.menuItemScanImageZoom.Click += new System.EventHandler(this.menuItemScanImageZoom_Click);
            // 
            // menuItemScanZoomNormal
            // 
            this.menuItemScanZoomNormal.Name = "menuItemScanZoomNormal";
            this.menuItemScanZoomNormal.Size = new System.Drawing.Size(174, 26);
            this.menuItemScanZoomNormal.Tag = "Normal Size(&N)";
            this.menuItemScanZoomNormal.Text = "常规尺寸(&N)";
            this.menuItemScanZoomNormal.Click += new System.EventHandler(this.menuItemScanZoomNormal_Click);
            // 
            // menuItemScanZoomUserDefined
            // 
            this.menuItemScanZoomUserDefined.Name = "menuItemScanZoomUserDefined";
            this.menuItemScanZoomUserDefined.Size = new System.Drawing.Size(174, 26);
            this.menuItemScanZoomUserDefined.Tag = "Custom(&U)...";
            this.menuItemScanZoomUserDefined.Text = "自定义(&U)...";
            this.menuItemScanZoomUserDefined.Click += new System.EventHandler(this.menuItemScanZoomUserDefined_Click);
            // 
            // MeasureMBToolStripMenuItem
            // 
            this.MeasureMBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLengthMeasure,
            this.menuItemHeightMeasure,
            this.menuItemRectMeasure,
            this.toolStripSeparator7,
            this.menuItemMeasureLine,
            this.toolStripSeparator3,
            this.menuItemMeasureResultList,
            this.menuItemRealMeasureValue,
            this.menuItemPeakTrackSettings});
            this.MeasureMBToolStripMenuItem.Name = "MeasureMBToolStripMenuItem";
            this.MeasureMBToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.MeasureMBToolStripMenuItem.Tag = "Measurement(&M)";
            this.MeasureMBToolStripMenuItem.Text = "测量(&M)";
            this.MeasureMBToolStripMenuItem.Click += new System.EventHandler(this.MeasureMBToolStripMenuItem_Click);
            // 
            // menuItemLengthMeasure
            // 
            this.menuItemLengthMeasure.Name = "menuItemLengthMeasure";
            this.menuItemLengthMeasure.Size = new System.Drawing.Size(228, 26);
            this.menuItemLengthMeasure.Tag = "Length(&L)";
            this.menuItemLengthMeasure.Text = "长度(&L)";
            this.menuItemLengthMeasure.Visible = false;
            this.menuItemLengthMeasure.Click += new System.EventHandler(this.menuItemLengthMeasure_Click);
            // 
            // menuItemHeightMeasure
            // 
            this.menuItemHeightMeasure.Name = "menuItemHeightMeasure";
            this.menuItemHeightMeasure.Size = new System.Drawing.Size(228, 26);
            this.menuItemHeightMeasure.Tag = "Depth(&H)";
            this.menuItemHeightMeasure.Text = "深度(&H)";
            this.menuItemHeightMeasure.Visible = false;
            this.menuItemHeightMeasure.Click += new System.EventHandler(this.menuItemHeightMeasure_Click);
            // 
            // menuItemRectMeasure
            // 
            this.menuItemRectMeasure.Name = "menuItemRectMeasure";
            this.menuItemRectMeasure.Size = new System.Drawing.Size(228, 26);
            this.menuItemRectMeasure.Tag = "Length+Depth(&R)";
            this.menuItemRectMeasure.Text = "长度+深度(&R)";
            this.menuItemRectMeasure.Visible = false;
            this.menuItemRectMeasure.Click += new System.EventHandler(this.menuItemRectMeasure_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(225, 6);
            this.toolStripSeparator7.Visible = false;
            // 
            // menuItemMeasureLine
            // 
            this.menuItemMeasureLine.Name = "menuItemMeasureLine";
            this.menuItemMeasureLine.Size = new System.Drawing.Size(228, 26);
            this.menuItemMeasureLine.Tag = "Measure Line(&C)...";
            this.menuItemMeasureLine.Text = "测量线(&C)...";
            this.menuItemMeasureLine.Click += new System.EventHandler(this.menuItemMeasureLine_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(225, 6);
            // 
            // menuItemMeasureResultList
            // 
            this.menuItemMeasureResultList.Name = "menuItemMeasureResultList";
            this.menuItemMeasureResultList.Size = new System.Drawing.Size(228, 26);
            this.menuItemMeasureResultList.Tag = "Measure Result List(&E)";
            this.menuItemMeasureResultList.Text = "测量结果列表(&E)";
            this.menuItemMeasureResultList.Visible = false;
            this.menuItemMeasureResultList.Click += new System.EventHandler(this.menuItemMeasureResultList_Click);
            // 
            // menuItemRealMeasureValue
            // 
            this.menuItemRealMeasureValue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRealMeasureValueVisible,
            this.menuItemRealMeasureValueHide});
            this.menuItemRealMeasureValue.Name = "menuItemRealMeasureValue";
            this.menuItemRealMeasureValue.Size = new System.Drawing.Size(228, 26);
            this.menuItemRealMeasureValue.Tag = "Real time measure result(&V)";
            this.menuItemRealMeasureValue.Text = "实时测量值(&V)";
            this.menuItemRealMeasureValue.Click += new System.EventHandler(this.menuItemRealMeasureValue_Click);
            // 
            // menuItemRealMeasureValueVisible
            // 
            this.menuItemRealMeasureValueVisible.Name = "menuItemRealMeasureValueVisible";
            this.menuItemRealMeasureValueVisible.Size = new System.Drawing.Size(144, 26);
            this.menuItemRealMeasureValueVisible.Tag = "Display(&D)";
            this.menuItemRealMeasureValueVisible.Text = "显示(&D)";
            this.menuItemRealMeasureValueVisible.Click += new System.EventHandler(this.menuItemRealMeasureValueVisible_Click);
            // 
            // menuItemRealMeasureValueHide
            // 
            this.menuItemRealMeasureValueHide.Name = "menuItemRealMeasureValueHide";
            this.menuItemRealMeasureValueHide.Size = new System.Drawing.Size(144, 26);
            this.menuItemRealMeasureValueHide.Tag = "Hide(&H)";
            this.menuItemRealMeasureValueHide.Text = "隐藏(&H)";
            this.menuItemRealMeasureValueHide.Click += new System.EventHandler(this.menuItemRealMeasureValueHide_Click);
            // 
            // menuItemPeakTrackSettings
            // 
            this.menuItemPeakTrackSettings.Name = "menuItemPeakTrackSettings";
            this.menuItemPeakTrackSettings.Size = new System.Drawing.Size(228, 26);
            this.menuItemPeakTrackSettings.Tag = "Measure line track setting(&P)...";
            this.menuItemPeakTrackSettings.Text = "测量线跟踪设置(&P)...";
            this.menuItemPeakTrackSettings.Click += new System.EventHandler(this.menuItemPeakTrackSettings_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemEncoder,
            this.MenuItemSensor,
            this.toolStripSeparator8,
            this.MenuItemSpray,
            this.MenuItemAlarmOutput,
            this.MenuItemAlarmAnalog,
            this.MenuItemAlarmSound,
            this.toolStripSeparator9,
            this.menuItemCheckInfo,
            this.menuItemChannelPositionSettings,
            this.menuItemChannelGroupSettings,
            this.menuItemSensorCtrlChannelLSettings,
            this.menuItemMeasThicknessSettings,
            this.menuItemAutoDetectionSettings,
            this.toolStripSeparator17,
            this.DefaultToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.设置ToolStripMenuItem.Tag = "Setting(&E)";
            this.设置ToolStripMenuItem.Text = "设置(&E)";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // menuItemEncoder
            // 
            this.menuItemEncoder.Name = "menuItemEncoder";
            this.menuItemEncoder.Size = new System.Drawing.Size(245, 26);
            this.menuItemEncoder.Tag = "Encoder(&E)...";
            this.menuItemEncoder.Text = "编码器(&E)...";
            this.menuItemEncoder.Click += new System.EventHandler(this.menuItemEncoder_Click);
            // 
            // MenuItemSensor
            // 
            this.MenuItemSensor.Name = "MenuItemSensor";
            this.MenuItemSensor.Size = new System.Drawing.Size(245, 26);
            this.MenuItemSensor.Tag = "menuItemSensor";
            this.MenuItemSensor.Text = "传感器(&N)...";
            this.MenuItemSensor.Click += new System.EventHandler(this.MenuItemSensor_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(242, 6);
            // 
            // MenuItemSpray
            // 
            this.MenuItemSpray.Name = "MenuItemSpray";
            this.MenuItemSpray.Size = new System.Drawing.Size(245, 26);
            this.MenuItemSpray.Tag = "Spray(&S)";
            this.MenuItemSpray.Text = "喷枪设置(&S)";
            this.MenuItemSpray.Click += new System.EventHandler(this.MenuItemSpray_Click);
            // 
            // MenuItemAlarmOutput
            // 
            this.MenuItemAlarmOutput.Name = "MenuItemAlarmOutput";
            this.MenuItemAlarmOutput.Size = new System.Drawing.Size(245, 26);
            this.MenuItemAlarmOutput.Tag = "Digital Alarm Output(&D)";
            this.MenuItemAlarmOutput.Text = "数字报警输出设置(&D)";
            this.MenuItemAlarmOutput.Click += new System.EventHandler(this.MenuItemAlarm_Click);
            // 
            // MenuItemAlarmAnalog
            // 
            this.MenuItemAlarmAnalog.Name = "MenuItemAlarmAnalog";
            this.MenuItemAlarmAnalog.Size = new System.Drawing.Size(245, 26);
            this.MenuItemAlarmAnalog.Tag = "Analog Alarm Output(&A)";
            this.MenuItemAlarmAnalog.Text = "模拟输出设置(&A)";
            this.MenuItemAlarmAnalog.Click += new System.EventHandler(this.MenuItemAlarmAnalog_Click);
            // 
            // MenuItemAlarmSound
            // 
            this.MenuItemAlarmSound.Name = "MenuItemAlarmSound";
            this.MenuItemAlarmSound.Size = new System.Drawing.Size(245, 26);
            this.MenuItemAlarmSound.Tag = "Alarm Sound(&B)";
            this.MenuItemAlarmSound.Text = "报警声设置(&B)";
            this.MenuItemAlarmSound.Click += new System.EventHandler(this.MenuItemAlarmSound_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(242, 6);
            // 
            // menuItemCheckInfo
            // 
            this.menuItemCheckInfo.Name = "menuItemCheckInfo";
            this.menuItemCheckInfo.Size = new System.Drawing.Size(245, 26);
            this.menuItemCheckInfo.Tag = "menuItemCheckInfo";
            this.menuItemCheckInfo.Text = "检测信息(&C)";
            this.menuItemCheckInfo.Click += new System.EventHandler(this.menuItemCheckInfo_Click);
            // 
            // menuItemChannelPositionSettings
            // 
            this.menuItemChannelPositionSettings.Name = "menuItemChannelPositionSettings";
            this.menuItemChannelPositionSettings.Size = new System.Drawing.Size(245, 26);
            this.menuItemChannelPositionSettings.Tag = "menuItemChannelPositionSettings";
            this.menuItemChannelPositionSettings.Text = "通道位置设置(&P)";
            this.menuItemChannelPositionSettings.Click += new System.EventHandler(this.menuItemChannelPositionSettings_Click);
            // 
            // menuItemChannelGroupSettings
            // 
            this.menuItemChannelGroupSettings.Name = "menuItemChannelGroupSettings";
            this.menuItemChannelGroupSettings.Size = new System.Drawing.Size(245, 26);
            this.menuItemChannelGroupSettings.Tag = "menuItemChannelGroupSettings";
            this.menuItemChannelGroupSettings.Text = "通道分组设置(&G)";
            this.menuItemChannelGroupSettings.Click += new System.EventHandler(this.menuItemChannelGroupSettings_Click);
            // 
            // menuItemSensorCtrlChannelLSettings
            // 
            this.menuItemSensorCtrlChannelLSettings.Name = "menuItemSensorCtrlChannelLSettings";
            this.menuItemSensorCtrlChannelLSettings.Size = new System.Drawing.Size(245, 26);
            this.menuItemSensorCtrlChannelLSettings.Tag = "menuItemSensorCtrlChannelLSettings";
            this.menuItemSensorCtrlChannelLSettings.Text = "传感器控制通道设置(&F)";
            this.menuItemSensorCtrlChannelLSettings.Click += new System.EventHandler(this.menuItemSensorCtrlChannelLSettings_Click);
            // 
            // menuItemMeasThicknessSettings
            // 
            this.menuItemMeasThicknessSettings.Name = "menuItemMeasThicknessSettings";
            this.menuItemMeasThicknessSettings.Size = new System.Drawing.Size(245, 26);
            this.menuItemMeasThicknessSettings.Tag = "measItemMeasThicknessSettings";
            this.menuItemMeasThicknessSettings.Text = "测厚参数设置(&T)...";
            this.menuItemMeasThicknessSettings.Click += new System.EventHandler(this.menuItemMeasThicknessSettings_Click);
            // 
            // menuItemAutoDetectionSettings
            // 
            this.menuItemAutoDetectionSettings.Name = "menuItemAutoDetectionSettings";
            this.menuItemAutoDetectionSettings.Size = new System.Drawing.Size(245, 26);
            this.menuItemAutoDetectionSettings.Tag = "menuItemAutoDetectionSettings";
            this.menuItemAutoDetectionSettings.Text = "自动检测设置(&U)...";
            this.menuItemAutoDetectionSettings.Click += new System.EventHandler(this.menuItemAutoDetectionSettings_Click);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(242, 6);
            // 
            // DefaultToolStripMenuItem
            // 
            this.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem";
            this.DefaultToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.DefaultToolStripMenuItem.Tag = "Default Setting(&R)";
            this.DefaultToolStripMenuItem.Text = "默认设置(&R)";
            this.DefaultToolStripMenuItem.Click += new System.EventHandler(this.DefaultToolStripMenuItem_Click);
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemImportCheckPlanList,
            this.toolStripSeparator5,
            this.menuItemImageCapture,
            this.TemperatureVelToolStripMenuItem,
            this.ProbeIconMenuItem,
            this.menuItemFrequencyDetect,
            this.menuItemDGateAlarm,
            this.toolStripSeparator6,
            this.MenuItemLoadSetting,
            this.menuItemToolsOptions});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.工具TToolStripMenuItem.Tag = "Tools(&T)";
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            this.工具TToolStripMenuItem.Click += new System.EventHandler(this.工具TToolStripMenuItem_Click);
            // 
            // menuItemImportCheckPlanList
            // 
            this.menuItemImportCheckPlanList.Name = "menuItemImportCheckPlanList";
            this.menuItemImportCheckPlanList.Size = new System.Drawing.Size(272, 26);
            this.menuItemImportCheckPlanList.Tag = "Import Check List(&L)...";
            this.menuItemImportCheckPlanList.Text = "导入检测计划清单文件(&L)...";
            this.menuItemImportCheckPlanList.Click += new System.EventHandler(this.menuItemImportCheckPlanList_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(269, 6);
            // 
            // menuItemImageCapture
            // 
            this.menuItemImageCapture.Name = "menuItemImageCapture";
            this.menuItemImageCapture.Size = new System.Drawing.Size(272, 26);
            this.menuItemImageCapture.Tag = "Image Capture(&C)...";
            this.menuItemImageCapture.Text = "图像捕获(&C)...";
            this.menuItemImageCapture.Click += new System.EventHandler(this.menuItemImageCapture_Click);
            // 
            // TemperatureVelToolStripMenuItem
            // 
            this.TemperatureVelToolStripMenuItem.Name = "TemperatureVelToolStripMenuItem";
            this.TemperatureVelToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.TemperatureVelToolStripMenuItem.Tag = "Temperature Velocity Curve(&T)";
            this.TemperatureVelToolStripMenuItem.Text = "温度声速曲线(&T)...";
            this.TemperatureVelToolStripMenuItem.Click += new System.EventHandler(this.TemperatureVelToolStripMenuItem_Click);
            // 
            // ProbeIconMenuItem
            // 
            this.ProbeIconMenuItem.Name = "ProbeIconMenuItem";
            this.ProbeIconMenuItem.Size = new System.Drawing.Size(272, 26);
            this.ProbeIconMenuItem.Tag = "Probe Position Sketch Map(&P)";
            this.ProbeIconMenuItem.Text = "探头位置示意图(&P)...";
            this.ProbeIconMenuItem.Click += new System.EventHandler(this.ProbeIconMenuItem_Click);
            // 
            // menuItemFrequencyDetect
            // 
            this.menuItemFrequencyDetect.Name = "menuItemFrequencyDetect";
            this.menuItemFrequencyDetect.Size = new System.Drawing.Size(272, 26);
            this.menuItemFrequencyDetect.Tag = "Frequency Detect";
            this.menuItemFrequencyDetect.Text = "频率检测(&F)...";
            this.menuItemFrequencyDetect.Click += new System.EventHandler(this.menuItemFrequencyDetect_Click);
            // 
            // menuItemDGateAlarm
            // 
            this.menuItemDGateAlarm.Name = "menuItemDGateAlarm";
            this.menuItemDGateAlarm.Size = new System.Drawing.Size(272, 26);
            this.menuItemDGateAlarm.Tag = "menuItemDGateAlarm";
            this.menuItemDGateAlarm.Text = "D闸门报警提示(&D)...";
            this.menuItemDGateAlarm.Click += new System.EventHandler(this.menuItemDGateAlarmTip_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(269, 6);
            // 
            // MenuItemLoadSetting
            // 
            this.MenuItemLoadSetting.Name = "MenuItemLoadSetting";
            this.MenuItemLoadSetting.Size = new System.Drawing.Size(272, 26);
            this.MenuItemLoadSetting.Tag = "LoadSetting(&K)…";
            this.MenuItemLoadSetting.Text = "登陆设置(&K)...";
            this.MenuItemLoadSetting.Click += new System.EventHandler(this.MenuItemLoadSetting_Click);
            // 
            // menuItemToolsOptions
            // 
            this.menuItemToolsOptions.Name = "menuItemToolsOptions";
            this.menuItemToolsOptions.Size = new System.Drawing.Size(272, 26);
            this.menuItemToolsOptions.Tag = "Option(&O)...";
            this.menuItemToolsOptions.Text = "选项(&O)...";
            this.menuItemToolsOptions.Click += new System.EventHandler(this.menuItemToolsOptions_Click);
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemDefaultTemplate,
            this.MenuItemCustomTemplate,
            this.toolStripSeparator10,
            this.MenuItemGenReport});
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.PrintToolStripMenuItem.Tag = "Report(&R)";
            this.PrintToolStripMenuItem.Text = "报告(&R)";
            this.PrintToolStripMenuItem.Visible = false;
            // 
            // MenuItemDefaultTemplate
            // 
            this.MenuItemDefaultTemplate.Name = "MenuItemDefaultTemplate";
            this.MenuItemDefaultTemplate.Size = new System.Drawing.Size(181, 26);
            this.MenuItemDefaultTemplate.Tag = "Template - Default";
            this.MenuItemDefaultTemplate.Text = "模版 - 默认";
            this.MenuItemDefaultTemplate.Visible = false;
            this.MenuItemDefaultTemplate.Click += new System.EventHandler(this.MenuItemDefaultTemplate_Click);
            // 
            // MenuItemCustomTemplate
            // 
            this.MenuItemCustomTemplate.Name = "MenuItemCustomTemplate";
            this.MenuItemCustomTemplate.Size = new System.Drawing.Size(181, 26);
            this.MenuItemCustomTemplate.Tag = "Template - Custom";
            this.MenuItemCustomTemplate.Text = "模版 - 自定义";
            this.MenuItemCustomTemplate.Visible = false;
            this.MenuItemCustomTemplate.Click += new System.EventHandler(this.MenuItemCustomTemplate_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(178, 6);
            this.toolStripSeparator10.Visible = false;
            // 
            // MenuItemGenReport
            // 
            this.MenuItemGenReport.Name = "MenuItemGenReport";
            this.MenuItemGenReport.Size = new System.Drawing.Size(181, 26);
            this.MenuItemGenReport.Tag = "Generate report(&G)";
            this.MenuItemGenReport.Text = "生成报告(&G)";
            this.MenuItemGenReport.Click += new System.EventHandler(this.MenuItemGenReport_Click);
            // 
            // MenuItemLanguage
            // 
            this.MenuItemLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCN,
            this.MenuItemEN,
            this.MenuItemTU});
            this.MenuItemLanguage.Name = "MenuItemLanguage";
            this.MenuItemLanguage.Size = new System.Drawing.Size(148, 24);
            this.MenuItemLanguage.Text = "Language/语言(&L)";
            this.MenuItemLanguage.Click += new System.EventHandler(this.MenuItemLanguage_Click);
            // 
            // MenuItemCN
            // 
            this.MenuItemCN.Name = "MenuItemCN";
            this.MenuItemCN.Size = new System.Drawing.Size(182, 26);
            this.MenuItemCN.Text = "CN/中文(&C)";
            this.MenuItemCN.Click += new System.EventHandler(this.OnLanguageChange);
            // 
            // MenuItemEN
            // 
            this.MenuItemEN.Name = "MenuItemEN";
            this.MenuItemEN.Size = new System.Drawing.Size(182, 26);
            this.MenuItemEN.Text = "EN/英文(&E)";
            this.MenuItemEN.Click += new System.EventHandler(this.OnLanguageChange);
            // 
            // MenuItemTU
            // 
            this.MenuItemTU.Name = "MenuItemTU";
            this.MenuItemTU.Size = new System.Drawing.Size(182, 26);
            this.MenuItemTU.Text = "TU/土耳其(&T)";
            this.MenuItemTU.Click += new System.EventHandler(this.OnLanguageChange);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.HelpToolStripMenuItem.Tag = "Help(&B)";
            this.HelpToolStripMenuItem.Text = "帮助(&B)";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // aboutAToolStripMenuItem
            // 
            this.aboutAToolStripMenuItem.Name = "aboutAToolStripMenuItem";
            this.aboutAToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.aboutAToolStripMenuItem.Tag = "About(&A)";
            this.aboutAToolStripMenuItem.Text = "关于(&A)";
            this.aboutAToolStripMenuItem.Click += new System.EventHandler(this.aboutAToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonStart,
            this.toolStripButtonWaveOrScan,
            this.toolStripButtonSaveWaveData,
            this.toolStripButtonRun,
            this.toolStripButtonStop,
            this.toolStripButtonEncoderAdjust,
            this.toolStripButtonImportCheckList,
            this.toolStripButtonLength,
            this.toolStripComboBoxChannel,
            this.toolStripButtonCapture,
            this.toolStripButtonReport,
            this.toolStripSeparator13,
            this.toolStripSeparator14,
            this.toolStripButtonDepth,
            this.toolStripButtonLengthDepth,
            this.toolStripButtonExportMeasure,
            this.toolStripSeparator16,
            this.toolStripButtonZoomIn,
            this.toolStripButtonZoomOut,
            this.toolStripSeparator15,
            this.toolStripButtonCalc,
            this.toolStripButtonMsPaint,
            this.toolStripButtonChannelWork,
            this.toolStripButtonMaxDataS,
            this.toolStripButtonSerialSendSwitch,
            this.toolStripButton1,
            this.toolStripButtonAlarmSoundSwitch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1323, 28);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButtonStart
            // 
            this.toolStripButtonStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonStart.Tag = "Freeze";
            this.toolStripButtonStart.ToolTipText = "开始采集";
            this.toolStripButtonStart.Click += new System.EventHandler(this.toolStripButtonStart_Click);
            // 
            // toolStripButtonWaveOrScan
            // 
            this.toolStripButtonWaveOrScan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonWaveOrScan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonWaveOrScan.Name = "toolStripButtonWaveOrScan";
            this.toolStripButtonWaveOrScan.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonWaveOrScan.Tag = "Scan";
            this.toolStripButtonWaveOrScan.Text = "扫描";
            this.toolStripButtonWaveOrScan.Click += new System.EventHandler(this.toolStripButtonWaveOrScan_Click);
            // 
            // toolStripButtonSaveWaveData
            // 
            this.toolStripButtonSaveWaveData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveWaveData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveWaveData.Name = "toolStripButtonSaveWaveData";
            this.toolStripButtonSaveWaveData.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonSaveWaveData.Tag = "Temperature";
            this.toolStripButtonSaveWaveData.Text = "保存波形数据";
            this.toolStripButtonSaveWaveData.Click += new System.EventHandler(this.toolStripButtonSaveWaveData_Click);
            // 
            // toolStripButtonRun
            // 
            this.toolStripButtonRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRun.Name = "toolStripButtonRun";
            this.toolStripButtonRun.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonRun.Tag = "Run";
            this.toolStripButtonRun.Text = "启动";
            this.toolStripButtonRun.Visible = false;
            this.toolStripButtonRun.Click += new System.EventHandler(this.toolStripButtonRun_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonStop.Tag = "Stop";
            this.toolStripButtonStop.Text = "停止";
            this.toolStripButtonStop.Visible = false;
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            this.toolStripButtonStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseDown);
            this.toolStripButtonStop.MouseLeave += new System.EventHandler(this.toolStripButton_MouseLeave);
            this.toolStripButtonStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseUp);
            // 
            // toolStripButtonEncoderAdjust
            // 
            this.toolStripButtonEncoderAdjust.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEncoderAdjust.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEncoderAdjust.Name = "toolStripButtonEncoderAdjust";
            this.toolStripButtonEncoderAdjust.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonEncoderAdjust.Tag = "Encoder Adjust";
            this.toolStripButtonEncoderAdjust.Text = "编码器校准";
            this.toolStripButtonEncoderAdjust.Click += new System.EventHandler(this.toolStripButtonEncoderAdjust_Click);
            this.toolStripButtonEncoderAdjust.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseDown);
            this.toolStripButtonEncoderAdjust.MouseLeave += new System.EventHandler(this.toolStripButton_MouseLeave);
            this.toolStripButtonEncoderAdjust.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseUp);
            // 
            // toolStripButtonImportCheckList
            // 
            this.toolStripButtonImportCheckList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonImportCheckList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImportCheckList.Name = "toolStripButtonImportCheckList";
            this.toolStripButtonImportCheckList.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonImportCheckList.Tag = "Import Check List";
            this.toolStripButtonImportCheckList.Text = "导入检测计划清单文件";
            this.toolStripButtonImportCheckList.Click += new System.EventHandler(this.toolStripButtonImportCheckList_Click);
            this.toolStripButtonImportCheckList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseDown);
            this.toolStripButtonImportCheckList.MouseLeave += new System.EventHandler(this.toolStripButton_MouseLeave);
            this.toolStripButtonImportCheckList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseUp);
            // 
            // toolStripButtonLength
            // 
            this.toolStripButtonLength.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLength.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLength.Name = "toolStripButtonLength";
            this.toolStripButtonLength.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonLength.Tag = "Length";
            this.toolStripButtonLength.Text = "Length";
            this.toolStripButtonLength.Click += new System.EventHandler(this.toolStripButtonLength_Click);
            this.toolStripButtonLength.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseDown);
            this.toolStripButtonLength.MouseLeave += new System.EventHandler(this.toolStripButton_MouseLeave);
            this.toolStripButtonLength.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseUp);
            // 
            // toolStripComboBoxChannel
            // 
            this.toolStripComboBoxChannel.AutoSize = false;
            this.toolStripComboBoxChannel.DropDownHeight = 120;
            this.toolStripComboBoxChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxChannel.DropDownWidth = 75;
            this.toolStripComboBoxChannel.IntegralHeight = false;
            this.toolStripComboBoxChannel.Name = "toolStripComboBoxChannel";
            this.toolStripComboBoxChannel.Size = new System.Drawing.Size(79, 28);
            this.toolStripComboBoxChannel.Tag = "Channel";
            this.toolStripComboBoxChannel.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxChannel_SelectedIndexChanged);
            this.toolStripComboBoxChannel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripComboBoxChannel_KeyDown);
            this.toolStripComboBoxChannel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripComboBoxChannel_KeyUp);
            // 
            // toolStripButtonCapture
            // 
            this.toolStripButtonCapture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCapture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCapture.Name = "toolStripButtonCapture";
            this.toolStripButtonCapture.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonCapture.Tag = "Capture";
            this.toolStripButtonCapture.Text = "截图";
            this.toolStripButtonCapture.Visible = false;
            this.toolStripButtonCapture.Click += new System.EventHandler(this.toolStripButtonCapture_Click);
            this.toolStripButtonCapture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseDown);
            this.toolStripButtonCapture.MouseLeave += new System.EventHandler(this.toolStripButton_MouseLeave);
            this.toolStripButtonCapture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseUp);
            // 
            // toolStripButtonReport
            // 
            this.toolStripButtonReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReport.Name = "toolStripButtonReport";
            this.toolStripButtonReport.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonReport.Tag = "Report";
            this.toolStripButtonReport.Text = "报告";
            this.toolStripButtonReport.Visible = false;
            this.toolStripButtonReport.Click += new System.EventHandler(this.toolStripButtonReport_Click);
            this.toolStripButtonReport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseDown);
            this.toolStripButtonReport.MouseLeave += new System.EventHandler(this.toolStripButton_MouseLeave);
            this.toolStripButtonReport.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseUp);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButtonDepth
            // 
            this.toolStripButtonDepth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDepth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDepth.Name = "toolStripButtonDepth";
            this.toolStripButtonDepth.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonDepth.Tag = "Depth";
            this.toolStripButtonDepth.Text = "Depth";
            this.toolStripButtonDepth.Click += new System.EventHandler(this.toolStripButtonDepth_Click);
            this.toolStripButtonDepth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseDown);
            this.toolStripButtonDepth.MouseLeave += new System.EventHandler(this.toolStripButton_MouseLeave);
            this.toolStripButtonDepth.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseUp);
            // 
            // toolStripButtonLengthDepth
            // 
            this.toolStripButtonLengthDepth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLengthDepth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLengthDepth.Name = "toolStripButtonLengthDepth";
            this.toolStripButtonLengthDepth.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonLengthDepth.Tag = "Length+Depth";
            this.toolStripButtonLengthDepth.Text = "Length+Depth";
            this.toolStripButtonLengthDepth.Click += new System.EventHandler(this.toolStripButtonLengthDepth_Click);
            this.toolStripButtonLengthDepth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseDown);
            this.toolStripButtonLengthDepth.MouseLeave += new System.EventHandler(this.toolStripButton_MouseLeave);
            this.toolStripButtonLengthDepth.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseUp);
            // 
            // toolStripButtonExportMeasure
            // 
            this.toolStripButtonExportMeasure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExportMeasure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExportMeasure.Name = "toolStripButtonExportMeasure";
            this.toolStripButtonExportMeasure.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonExportMeasure.Tag = "ExportResult";
            this.toolStripButtonExportMeasure.Text = "ExportResult";
            this.toolStripButtonExportMeasure.Click += new System.EventHandler(this.toolStripButtonExportMeasure_Click);
            this.toolStripButtonExportMeasure.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseDown);
            this.toolStripButtonExportMeasure.MouseLeave += new System.EventHandler(this.toolStripButton_MouseLeave);
            this.toolStripButtonExportMeasure.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseUp);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButtonZoomIn
            // 
            this.toolStripButtonZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonZoomIn.Name = "toolStripButtonZoomIn";
            this.toolStripButtonZoomIn.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonZoomIn.Tag = "Zoom In";
            this.toolStripButtonZoomIn.Text = "c";
            this.toolStripButtonZoomIn.Click += new System.EventHandler(this.toolStripButtonZoomIn_Click);
            this.toolStripButtonZoomIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseDown);
            this.toolStripButtonZoomIn.MouseLeave += new System.EventHandler(this.toolStripButton_MouseLeave);
            this.toolStripButtonZoomIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseUp);
            // 
            // toolStripButtonZoomOut
            // 
            this.toolStripButtonZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonZoomOut.Name = "toolStripButtonZoomOut";
            this.toolStripButtonZoomOut.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonZoomOut.Tag = "Zoom Out";
            this.toolStripButtonZoomOut.Text = "Zoom Out";
            this.toolStripButtonZoomOut.Click += new System.EventHandler(this.toolStripButtonZoomOut_Click);
            this.toolStripButtonZoomOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseDown);
            this.toolStripButtonZoomOut.MouseLeave += new System.EventHandler(this.toolStripButton_MouseLeave);
            this.toolStripButtonZoomOut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseUp);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButtonCalc
            // 
            this.toolStripButtonCalc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCalc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCalc.Name = "toolStripButtonCalc";
            this.toolStripButtonCalc.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonCalc.Tag = "Calculator";
            this.toolStripButtonCalc.Text = "Calculator";
            this.toolStripButtonCalc.Click += new System.EventHandler(this.toolStripButtonCalc_Click);
            this.toolStripButtonCalc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseDown);
            this.toolStripButtonCalc.MouseLeave += new System.EventHandler(this.toolStripButton_MouseLeave);
            this.toolStripButtonCalc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseUp);
            // 
            // toolStripButtonMsPaint
            // 
            this.toolStripButtonMsPaint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMsPaint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMsPaint.Name = "toolStripButtonMsPaint";
            this.toolStripButtonMsPaint.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonMsPaint.Tag = "Paint";
            this.toolStripButtonMsPaint.Text = "Paint";
            this.toolStripButtonMsPaint.Click += new System.EventHandler(this.toolStripButtonMsPaint_Click);
            this.toolStripButtonMsPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseDown);
            this.toolStripButtonMsPaint.MouseLeave += new System.EventHandler(this.toolStripButton_MouseLeave);
            this.toolStripButtonMsPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MouseUp);
            // 
            // toolStripButtonChannelWork
            // 
            this.toolStripButtonChannelWork.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonChannelWork.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonChannelWork.Name = "toolStripButtonChannelWork";
            this.toolStripButtonChannelWork.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonChannelWork.Tag = "MenuItemChannelWork";
            this.toolStripButtonChannelWork.Text = "Channel Work";
            this.toolStripButtonChannelWork.Click += new System.EventHandler(this.toolStripButtonChannelWork_Click);
            // 
            // toolStripButtonMaxDataS
            // 
            this.toolStripButtonMaxDataS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMaxDataS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMaxDataS.Name = "toolStripButtonMaxDataS";
            this.toolStripButtonMaxDataS.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonMaxDataS.Tag = "MenuItemMaxDataMemory";
            this.toolStripButtonMaxDataS.Text = "MaxDataMemory";
            this.toolStripButtonMaxDataS.Click += new System.EventHandler(this.toolStripButtonMaxWaveDataSave_Click);
            // 
            // toolStripButtonSerialSendSwitch
            // 
            this.toolStripButtonSerialSendSwitch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSerialSendSwitch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSerialSendSwitch.Name = "toolStripButtonSerialSendSwitch";
            this.toolStripButtonSerialSendSwitch.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonSerialSendSwitch.Tag = "SerialSendSwitch";
            this.toolStripButtonSerialSendSwitch.Text = "SerialSendSwitch";
            this.toolStripButtonSerialSendSwitch.Click += new System.EventHandler(this.toolStripButtonSerialSendSwitch_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 25);
            // 
            // toolStripButtonAlarmSoundSwitch
            // 
            this.toolStripButtonAlarmSoundSwitch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAlarmSoundSwitch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAlarmSoundSwitch.Name = "toolStripButtonAlarmSoundSwitch";
            this.toolStripButtonAlarmSoundSwitch.Size = new System.Drawing.Size(29, 25);
            this.toolStripButtonAlarmSoundSwitch.Tag = "AlarmSoundSwitch";
            this.toolStripButtonAlarmSoundSwitch.Text = "AlarmSoundSwitch";
            this.toolStripButtonAlarmSoundSwitch.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelVision,
            this.toolStripStatusLabel1,
            this.toolStripStatusConnectStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 806);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1323, 26);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelVision
            // 
            this.toolStripStatusLabelVision.Name = "toolStripStatusLabelVision";
            this.toolStripStatusLabelVision.Size = new System.Drawing.Size(105, 20);
            this.toolStripStatusLabelVision.Text = "版本号： V1.0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel1.Text = "连接状态：";
            // 
            // toolStripStatusConnectStatus
            // 
            this.toolStripStatusConnectStatus.Name = "toolStripStatusConnectStatus";
            this.toolStripStatusConnectStatus.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusConnectStatus.Text = "未连接";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 832);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing_1);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDoubleClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void MenuItemSave_Click(object sender, EventArgs e)
        {
             
        }

        private void SaveScanningToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemSaveAsPicture_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemPrintScreen_Click(object sender, EventArgs e)
        {
             
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void 连接ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemConnectToServer_Click(object sender, EventArgs e)
        {

            this.toolStripStatusConnectStatus.Text = "已连接";
        }

        private void 通道ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemChannelParameter_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemFreezeAllChannel_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemChannelWorkEnable_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemChannelWorkDisable_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemMaxWaveAllChannel_Click(object sender, EventArgs e)
        {
             
        }

        private void 显示DToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemWaveformForm_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemScanForm_Click(object sender, EventArgs e)
        {

        }

        private void menuItemScanViewType1_Click(object sender, EventArgs e)
        {

        }

        private void menuItemScanViewType2_Click(object sender, EventArgs e)
        {
            FormView.m_aveFromViewType = FormView.WaveFromViewType.type1;
            AllFormsSet.UpDateFormLayOut();
        }

        private void menuItemScanViewType3_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemScanViewType4_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemScanViewType5_Click_1(object sender, EventArgs e)
        {
             
        }

        private void 扫描SToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemCheckPlanList_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemScanStart_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemScanStop_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemImageChannel_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemScanImageZoom_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemScanZoomNormal_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemScanZoomUserDefined_Click(object sender, EventArgs e)
        {
             
        }

        private void MeasureMBToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemLengthMeasure_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemHeightMeasure_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemRectMeasure_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemMeasureLine_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemMeasureResultList_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemRealMeasureValue_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemRealMeasureValueVisible_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemRealMeasureValueHide_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemPeakTrackSettings_Click(object sender, EventArgs e)
        {
             
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemEncoder_Click(object sender, EventArgs e)
        {
             
        }

        private void MenuItemSensor_Click(object sender, EventArgs e)
        {
             
        }

        private void MenuItemSpray_Click(object sender, EventArgs e)
        {
             
        }

        private void MenuItemAlarm_Click(object sender, EventArgs e)
        {
             
        }

        private void MenuItemAlarmAnalog_Click(object sender, EventArgs e)
        {
             
        }

        private void MenuItemAlarmSound_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemCheckInfo_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemChannelPositionSettings_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemChannelGroupSettings_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemSensorCtrlChannelLSettings_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemMeasThicknessSettings_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemAutoDetectionSettings_Click(object sender, EventArgs e)
        {
             
        }

        private void DefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void 工具TToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemImportCheckPlanList_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemImageCapture_Click(object sender, EventArgs e)
        {
             
        }

        private void TemperatureVelToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void ProbeIconMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemFrequencyDetect_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemDGateAlarmTip_Click(object sender, EventArgs e)
        {
             
        }

        private void MenuItemLoadSetting_Click(object sender, EventArgs e)
        {
             
        }

        private void menuItemToolsOptions_Click(object sender, EventArgs e)
        {
             
        }

        private void MenuItemDefaultTemplate_Click(object sender, EventArgs e)
        {
             
        }

        private void MenuItemCustomTemplate_Click(object sender, EventArgs e)
        {
             
        }

        private void MenuItemGenReport_Click(object sender, EventArgs e)
        {
             
        }

        private void MenuItemLanguage_Click(object sender, EventArgs e)
        {
             
        }

        private void OnLanguageChange(object sender, EventArgs e)
        {
             
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void aboutAToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
             
        }


        private void toolStripButtonRun_Click(object sender, EventArgs e)
        {
             
        }

        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
             
        }

        private void toolStripButtonImportCheckList_Click(object sender, EventArgs e)
        {
             
        }

        private void toolStripButtonEncoderAdjust_Click(object sender, EventArgs e)
        {
             
        }

        private void toolStripButtonLength_Click(object sender, EventArgs e)
        {
             
        }

        private void toolStripComboBoxChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void toolStripComboBoxChannel_KeyDown(object sender, KeyEventArgs e)
        {
             
        }

        private void toolStripComboBoxChannel_KeyUp(object sender, KeyEventArgs e)
        {
             
        }

        private void toolStripButtonCapture_Click(object sender, EventArgs e)
        {
             
        }

        private void toolStripButtonReport_Click(object sender, EventArgs e)
        {
             
        }

        private void toolStripButtonDepth_Click(object sender, EventArgs e)
        {
             
        }

        private void toolStripButtonLengthDepth_Click(object sender, EventArgs e)
        {
             
        }

        private void toolStripButtonExportMeasure_Click(object sender, EventArgs e)
        {
             
        }

        private void toolStripButtonZoomOut_Click(object sender, EventArgs e)
        {
             
        }

        private void toolStripButtonZoomIn_Click(object sender, EventArgs e)
        {
             
        }

        private void toolStripButtonCalc_Click(object sender, EventArgs e)
        {
             
        }

        private void toolStripButton_MouseDown(object sender, MouseEventArgs e)
        {
             
        }

        private void toolStripButtonMsPaint_Click(object sender, EventArgs e)
        {
             
        }

        private void toolStripButton_MouseLeave(object sender, EventArgs e)
        {
             
        }

        private void toolStripButton_MouseUp(object sender, MouseEventArgs e)
        {
             
        }

        private void toolStripButtonChannelWork_Click(object sender, EventArgs e)
        {
             
        }

        private void toolStripButtonMaxWaveDataSave_Click(object sender, EventArgs e)
        {
             
        }

        private void toolStripButtonSerialSendSwitch_Click(object sender, EventArgs e)
        {
             
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
             
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
             
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
             
        }

        private void MainForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetAllStatus.SetIsDataSampling(false);//数据采集标志位
            InitToolStripStatus();
            AllFormsSet.InitAllForms(this);
            AllChannelsSet.BadingParams();//绑定通道对应参数
            FormView.m_aveFromViewType = FormView.WaveFromViewType.type1;
            AllFormsSet.UpDateFormLayOut();
            NetModuleHelper.SystemInit();//绑定数据
            ConnectionForm connectionForm = new ConnectionForm();//开启连接窗口
            if (connectionForm.ShowDialog() == DialogResult.OK)
            {
                this.toolStripStatusConnectStatus.Text = "已连接";
            }
        }

        private void InitToolStripStatus()
        {
            this.toolStripButtonStart.Image = Image.FromFile(Application.StartupPath + @"\Resources\Run.bmp");
            this.toolStripButtonWaveOrScan.Image = Image.FromFile(Application.StartupPath + @"\Resources\Scan.bmp");
            this.toolStripButtonRun.Image = Image.FromFile(Application.StartupPath + @"\Resources\Run.bmp");
            this.toolStripButtonStop.Image = Image.FromFile(Application.StartupPath + @"\Resources\Stop1.bmp");
            this.toolStripButtonEncoderAdjust.Image = Image.FromFile(Application.StartupPath + @"\Resources\EncoderAdjust1.bmp");
            this.toolStripButtonSaveWaveData.Image = Image.FromFile(Application.StartupPath + @"\Resources\SaveDataFile.bmp");
            this.toolStripButtonImportCheckList.Image = Image.FromFile(Application.StartupPath + @"\Resources\CheckList1.bmp");
            this.toolStripButtonReport.Image = Image.FromFile(Application.StartupPath + @"\Resources\Report1.bmp");
            this.toolStripButtonCapture.Image = Image.FromFile(Application.StartupPath + @"\Resources\Capture1.bmp");
            this.toolStripButtonLength.Image = Image.FromFile(Application.StartupPath + @"\Resources\Length1.bmp");
            this.toolStripButtonDepth.Image = Image.FromFile(Application.StartupPath + @"\Resources\Depth1.bmp");
            this.toolStripButtonLengthDepth.Image = Image.FromFile(Application.StartupPath + @"\Resources\Length+Depth1.bmp");
            this.toolStripButtonExportMeasure.Image = Image.FromFile(Application.StartupPath + @"\Resources\Export1.bmp");
            this.toolStripButtonCalc.Image = Image.FromFile(Application.StartupPath + @"\Resources\Calc1.bmp");
            this.toolStripButtonMsPaint.Image = Image.FromFile(Application.StartupPath + @"\Resources\Paint1.bmp");
            this.toolStripButtonZoomIn.Image = Image.FromFile(Application.StartupPath + @"\Resources\ZoomIn1.bmp");
            this.toolStripButtonZoomOut.Image = Image.FromFile(Application.StartupPath + @"\Resources\ZoomOut1.bmp");
            this.toolStripButtonChannelWork.Image = Image.FromFile(Application.StartupPath + @"\Resources\ChannelWorkEnable.bmp");
            this.toolStripButtonRun.Visible = false;
            this.toolStripComboBoxChannel.Items.Clear();
            //for (int i = 0; i < Model.m_OptionsData.TotalChannelNum; i++)
            //{
            //    this.toolStripComboBoxChannel.Items.Add(i + 1);
            //}
            //this.toolStripComboBoxChannel.SelectedIndex = 0;
        }


        private void menuItemSeverStop_Click(object sender, EventArgs e)
        {
            NetModuleHelper.SeverStop();
            MessageBox.Show("服务器关闭成功");
        }

        private void FormTimer_Tick(object sender, EventArgs e)
        {
            this.ChangeControlEnable();
           for (int i = 0; i < 4; i++)
           {
                NetModuleHelper.ReadData(AlllChannels.m_Channels[i]);
                AllForms.m_WaveForms[i].chartControl1.ChartData = Funcations.ArrayUshortToDouble(AlllChannels.m_Channels[i].wavaData);
                AllForms.m_WaveForms[i].chartControl1.DrawLine();
           }
           if (GetAllStatus.GetIsWaveDataRecording())
           {
                AlllChannels.m_Channels[0].wavaData[1] = 1;
                WaveDataFileSet.WriteByteArray(Funcations.ArrayUshortToByte(AlllChannels.m_Channels[0].wavaData));
           }

        }

        private void ChangeControlEnable()
        {
            if (GetAllStatus.GetIsWaveDataRecording()||GetAllStatus.GetIsDataSampling())
            {
                this.MenuItemOpenFile.Enabled = false;
            }
            else
            {
                this.MenuItemOpenFile.Enabled = true;
            }
        }

        private void toolStripButtonStart_Click(object sender, EventArgs e)
        {
            if (!this.FormTimer.Enabled)
            {
                this.FormTimer.Start();
            }
            if (!GetAllStatus.GetIsDataSampling())
            {
                this.toolStripButtonStart.Image = Image.FromFile(Application.StartupPath + @"\Resources\Running.bmp");
                this.toolStripButtonStart.ToolTipText = "停止采集";
                this.FormTimer.Start();
                NetModuleHelper.StartSampling();
                GetAllStatus.SetIsDataSampling(true); ;//数据采集标志开启
            }
            else
            {
                this.toolStripButtonStart.Image = Image.FromFile(Application.StartupPath + @"\Resources\Run.bmp");
                this.toolStripButtonStart.ToolTipText = "开始采集";
                this.FormTimer.Stop();
                NetModuleHelper.StopSampling();
                GetAllStatus.SetIsDataSampling(false); ;//数据采集标志开启
                this.ChangeControlEnable();
            }

        }

        private void menuItemFireWallSetting_Click(object sender, EventArgs e)
        {
            FirewallSetForm m_FirewallSetForm = new FirewallSetForm();
            m_FirewallSetForm.ShowDialog();
        }

        private void toolStripButtonSaveWaveData_Click(object sender, EventArgs e)
        {
            //if (!GetAllStatus.GetIsSeverConnecting())
            //{
            //    MessageBox.Show("未连接到服务器", "错误");
            //    return;
            //}
            if (!GetAllStatus.GetIsDataSampling())
            {
                MessageBox.Show("未采集数据，请先开始采集","错误");
                return;
            }
            if (!GetAllStatus.GetIsWaveDataRecording())
            {
                this.m_WaveDataFile = new WaveDataFile();
                WaveDataSaveSetFrom waveDataSaveSetFrom = new WaveDataSaveSetFrom();
                waveDataSaveSetFrom.delGetSaveFileInfo = this.GetWaveDataFileInfo;
                if (waveDataSaveSetFrom.ShowDialog() == DialogResult.OK)
                {
                    this.toolStripButtonSaveWaveData.Image = Image.FromFile(Application.StartupPath + @"\Resources\StopSaveDataFile.bmp");
                    GetAllStatus.SetIsWaveDataRecording(true);
                    WaveDataFileSet.SetFileStreamWrite(m_WaveDataFile.filePath);
                }
            }
            else
            {
                WaveDataFileSet.CloseFileStream();
                GetAllStatus.SetIsWaveDataRecording(false);
                this.toolStripButtonSaveWaveData.Image = Image.FromFile(Application.StartupPath + @"\Resources\SaveDataFile.bmp");
            }
        }

        private void GetWaveDataFileInfo(WaveDataFile waveDataFile)
        {
            this.m_WaveDataFile.fileName = waveDataFile.fileName;
            this.m_WaveDataFile.filePath = waveDataFile.filePath;
        }

        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            WaveDataFileSet.CloseFileStream();//关闭文件流
        }

        private void MenuItemOpenFile_Click(object sender, EventArgs e)
        {
            string waveDataDefaultPath = Application.StartupPath + "\\WaveDataFile\\";//数据文件的地址
            if (!File.Exists(waveDataDefaultPath))//创建配置文件夹
            {
                Directory.CreateDirectory(waveDataDefaultPath);
            }
            OpenFileDialog objOpenFileDialog = new OpenFileDialog();
            objOpenFileDialog.Title = "请选择打开的文件";
            objOpenFileDialog.Filter= "文本文档(*.txt)|*.txt";
            objOpenFileDialog.InitialDirectory = waveDataDefaultPath;
            if (objOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                WaveDataFileSet.SetFileStreamRead(objOpenFileDialog.FileName);
                this.readDataBuf = Funcations.ArrayByteToDouble( WaveDataFileSet.ReadAllByteArray());
                if (this.readDataBuf == null)
                {
                    MessageBox.Show("读取文件错误");
                    return;
                }
                FormView.m_aveFromViewType = FormView.WaveFromViewType.type2;
                AllFormsSet.UpDateFormLayOut();

                AllForms.m_ParamSetForm.trackBarDataProcess.Minimum = 1;
                AllForms.m_ParamSetForm.trackBarDataProcess.Maximum = readDataBuf.Length/(AlllChannels.m_Channels[0].wavaData.Length);
                AllForms.m_ParamSetForm.trackBarDataProcess.Value = 1;
            }
        }

        private void toolStripButtonWaveOrScan_Click(object sender, EventArgs e)
        {
            FormView.m_aveFromViewType = FormView.WaveFromViewType.type2;
            AllFormsSet.UpDateFormLayOut();
        }
    }
}

