<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonitoring
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonitoring))
        Me.Tim_RealTime = New System.Windows.Forms.Timer()
        Me.TimerScadaTab = New System.Windows.Forms.Timer()
        Me.animation_cloud_timer = New System.Windows.Forms.Timer()
        Me.FirefoxSubTabControl1 = New Mini_Scada_V0._9._1.FirefoxSubTabControl()
        Me.tp_interface = New System.Windows.Forms.TabPage()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lbl_capasity_aki = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btn_resetall = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_APBeban = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_VPBeban = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_APPanel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_VPPanel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.lbl_statusalat_beban = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_SPLoad = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.lbl_statusalat_panel = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbl_SPPanel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.lbl_beban_daya = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.lbl_beban_arus = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.lbl_beban_teg = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl_StatusCharging = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_Panel_Daya = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_panel_arus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_solarcell_tegangan = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tp_chart_teganganaki = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.g_lbl_arusinverter = New System.Windows.Forms.Label()
        Me.Chart_Arus_Inverter = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.g_lbl_arussc = New System.Windows.Forms.Label()
        Me.Chart_ArusSC = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.g_lbl_teganganinverter = New System.Windows.Forms.Label()
        Me.Chart_Tegangan_Inverter = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.g_lbl_teganganaki = New System.Windows.Forms.Label()
        Me.Chart_TeganganAki = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tp_gauge = New System.Windows.Forms.TabPage()
        Me.pic_s_cloud_green = New System.Windows.Forms.PictureBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbl_scada_ipaddress = New System.Windows.Forms.Label()
        Me.lbl_scada_ping = New System.Windows.Forms.Label()
        Me.lbl_scada_serveraddress = New System.Windows.Forms.Label()
        Me.lbl_scada_daya_beban = New System.Windows.Forms.Label()
        Me.lbl_scada_arus_beban = New System.Windows.Forms.Label()
        Me.lbl_scada_tegangan_beban = New System.Windows.Forms.Label()
        Me.lbl_scada_daya_panel = New System.Windows.Forms.Label()
        Me.lbl_scada_arus_panel = New System.Windows.Forms.Label()
        Me.lbl_scada_kapasitasaki = New System.Windows.Forms.Label()
        Me.lbl_scada_teganganaki_panel = New System.Windows.Forms.Label()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.pic_s_cloud_blue = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.lbl_scada_relay_beban = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.lbl_scada_mode_beban = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.lbl_scada_jamb_panel = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.lbl_scada_jama_panel = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.lbl_scada_relay_panel = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.lbl_scada_mode_panel = New System.Windows.Forms.Label()
        Me.lbl_scada_charging_panel = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape14 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape13 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape12 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape11 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape10 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.FirefoxSubTabControl1.SuspendLayout()
        Me.tp_interface.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tp_chart_teganganaki.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Chart_Arus_Inverter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Chart_ArusSC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Chart_Tegangan_Inverter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Chart_TeganganAki, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_gauge.SuspendLayout()
        CType(Me.pic_s_cloud_green, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_s_cloud_blue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel18.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tim_RealTime
        '
        '
        'TimerScadaTab
        '
        Me.TimerScadaTab.Enabled = True
        '
        'animation_cloud_timer
        '
        Me.animation_cloud_timer.Interval = 500
        '
        'FirefoxSubTabControl1
        '
        Me.FirefoxSubTabControl1.Controls.Add(Me.tp_interface)
        Me.FirefoxSubTabControl1.Controls.Add(Me.tp_chart_teganganaki)
        Me.FirefoxSubTabControl1.Controls.Add(Me.tp_gauge)
        Me.FirefoxSubTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FirefoxSubTabControl1.ItemSize = New System.Drawing.Size(100, 40)
        Me.FirefoxSubTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.FirefoxSubTabControl1.Name = "FirefoxSubTabControl1"
        Me.FirefoxSubTabControl1.SelectedIndex = 0
        Me.FirefoxSubTabControl1.Size = New System.Drawing.Size(919, 639)
        Me.FirefoxSubTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FirefoxSubTabControl1.TabIndex = 0
        '
        'tp_interface
        '
        Me.tp_interface.BackColor = System.Drawing.Color.White
        Me.tp_interface.Controls.Add(Me.Panel20)
        Me.tp_interface.Controls.Add(Me.btn_resetall)
        Me.tp_interface.Controls.Add(Me.Panel9)
        Me.tp_interface.Controls.Add(Me.Panel13)
        Me.tp_interface.Controls.Add(Me.Panel7)
        Me.tp_interface.Controls.Add(Me.Panel8)
        Me.tp_interface.Controls.Add(Me.Panel2)
        Me.tp_interface.Controls.Add(Me.Panel1)
        Me.tp_interface.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.tp_interface.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.tp_interface.Location = New System.Drawing.Point(4, 44)
        Me.tp_interface.Name = "tp_interface"
        Me.tp_interface.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_interface.Size = New System.Drawing.Size(911, 591)
        Me.tp_interface.TabIndex = 0
        Me.tp_interface.Text = "Interface"
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.Teal
        Me.Panel20.Controls.Add(Me.Label31)
        Me.Panel20.Controls.Add(Me.lbl_capasity_aki)
        Me.Panel20.Controls.Add(Me.Label29)
        Me.Panel20.Location = New System.Drawing.Point(699, 10)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(192, 34)
        Me.Panel20.TabIndex = 7
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(167, 7)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(20, 17)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "%"
        '
        'lbl_capasity_aki
        '
        Me.lbl_capasity_aki.AutoSize = True
        Me.lbl_capasity_aki.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_capasity_aki.ForeColor = System.Drawing.Color.White
        Me.lbl_capasity_aki.Location = New System.Drawing.Point(128, 7)
        Me.lbl_capasity_aki.Name = "lbl_capasity_aki"
        Me.lbl_capasity_aki.Size = New System.Drawing.Size(16, 17)
        Me.lbl_capasity_aki.TabIndex = 1
        Me.lbl_capasity_aki.Text = "0"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(14, 7)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(93, 17)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Capasity Aki"
        '
        'btn_resetall
        '
        Me.btn_resetall.BackColor = System.Drawing.Color.Indigo
        Me.btn_resetall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_resetall.ForeColor = System.Drawing.Color.Snow
        Me.btn_resetall.Location = New System.Drawing.Point(659, 537)
        Me.btn_resetall.Name = "btn_resetall"
        Me.btn_resetall.Size = New System.Drawing.Size(232, 46)
        Me.btn_resetall.TabIndex = 6
        Me.btn_resetall.Text = "Reset Semua"
        Me.btn_resetall.UseVisualStyleBackColor = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel9.Controls.Add(Me.Label7)
        Me.Panel9.Location = New System.Drawing.Point(25, 347)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(192, 34)
        Me.Panel9.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(66, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Info Alat"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.White
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.Panel17)
        Me.Panel13.Controls.Add(Me.Panel15)
        Me.Panel13.Controls.Add(Me.Panel14)
        Me.Panel13.Controls.Add(Me.Panel16)
        Me.Panel13.Location = New System.Drawing.Point(8, 367)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(895, 164)
        Me.Panel13.TabIndex = 4
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel17.Controls.Add(Me.BunifuCustomLabel7)
        Me.Panel17.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel17.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel17.Controls.Add(Me.lbl_APBeban)
        Me.Panel17.Controls.Add(Me.BunifuCustomLabel9)
        Me.Panel17.Controls.Add(Me.lbl_VPBeban)
        Me.Panel17.Controls.Add(Me.Label14)
        Me.Panel17.Location = New System.Drawing.Point(650, 19)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(232, 128)
        Me.Panel17.TabIndex = 8
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(171, 42)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(56, 23)
        Me.BunifuCustomLabel7.TabIndex = 13
        Me.BunifuCustomLabel7.Text = "VAC"
        Me.BunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(179, 80)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(44, 23)
        Me.BunifuCustomLabel2.TabIndex = 12
        Me.BunifuCustomLabel2.Text = "mA"
        Me.BunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(22, 80)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(36, 23)
        Me.BunifuCustomLabel3.TabIndex = 11
        Me.BunifuCustomLabel3.Text = ": A"
        Me.BunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_APBeban
        '
        Me.lbl_APBeban.AutoSize = True
        Me.lbl_APBeban.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.lbl_APBeban.ForeColor = System.Drawing.Color.White
        Me.lbl_APBeban.Location = New System.Drawing.Point(92, 80)
        Me.lbl_APBeban.Name = "lbl_APBeban"
        Me.lbl_APBeban.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_APBeban.Size = New System.Drawing.Size(59, 23)
        Me.lbl_APBeban.TabIndex = 10
        Me.lbl_APBeban.Text = "00,00"
        Me.lbl_APBeban.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(19, 42)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(36, 23)
        Me.BunifuCustomLabel9.TabIndex = 9
        Me.BunifuCustomLabel9.Text = ": V"
        Me.BunifuCustomLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_VPBeban
        '
        Me.lbl_VPBeban.AutoSize = True
        Me.lbl_VPBeban.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.lbl_VPBeban.ForeColor = System.Drawing.Color.White
        Me.lbl_VPBeban.Location = New System.Drawing.Point(92, 42)
        Me.lbl_VPBeban.Name = "lbl_VPBeban"
        Me.lbl_VPBeban.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_VPBeban.Size = New System.Drawing.Size(59, 23)
        Me.lbl_VPBeban.TabIndex = 8
        Me.lbl_VPBeban.Text = "00,00"
        Me.lbl_VPBeban.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(19, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(184, 19)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Nilai Proteksi Pada Beban"
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel15.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel15.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel15.Controls.Add(Me.BunifuCustomLabel6)
        Me.Panel15.Controls.Add(Me.lbl_APPanel)
        Me.Panel15.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel15.Controls.Add(Me.Label11)
        Me.Panel15.Controls.Add(Me.lbl_VPPanel)
        Me.Panel15.Location = New System.Drawing.Point(416, 19)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(228, 128)
        Me.Panel15.TabIndex = 8
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(172, 42)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(56, 23)
        Me.BunifuCustomLabel4.TabIndex = 9
        Me.BunifuCustomLabel4.Text = "VDC"
        Me.BunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(178, 80)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(44, 23)
        Me.BunifuCustomLabel1.TabIndex = 8
        Me.BunifuCustomLabel1.Text = "mA"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(18, 80)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(36, 23)
        Me.BunifuCustomLabel6.TabIndex = 7
        Me.BunifuCustomLabel6.Text = ": A"
        Me.BunifuCustomLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_APPanel
        '
        Me.lbl_APPanel.AutoSize = True
        Me.lbl_APPanel.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.lbl_APPanel.ForeColor = System.Drawing.Color.White
        Me.lbl_APPanel.Location = New System.Drawing.Point(88, 80)
        Me.lbl_APPanel.Name = "lbl_APPanel"
        Me.lbl_APPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_APPanel.Size = New System.Drawing.Size(59, 23)
        Me.lbl_APPanel.TabIndex = 6
        Me.lbl_APPanel.Text = "00,00"
        Me.lbl_APPanel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(15, 42)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(36, 23)
        Me.BunifuCustomLabel5.TabIndex = 5
        Me.BunifuCustomLabel5.Text = ": V"
        Me.BunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(14, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(177, 19)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Nilai Proteksi Pada Panel"
        '
        'lbl_VPPanel
        '
        Me.lbl_VPPanel.AutoSize = True
        Me.lbl_VPPanel.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.lbl_VPPanel.ForeColor = System.Drawing.Color.White
        Me.lbl_VPPanel.Location = New System.Drawing.Point(88, 42)
        Me.lbl_VPPanel.Name = "lbl_VPPanel"
        Me.lbl_VPPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_VPPanel.Size = New System.Drawing.Size(59, 23)
        Me.lbl_VPPanel.TabIndex = 2
        Me.lbl_VPPanel.Text = "00,00"
        Me.lbl_VPPanel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel14.Controls.Add(Me.lbl_statusalat_beban)
        Me.Panel14.Controls.Add(Me.Label18)
        Me.Panel14.Controls.Add(Me.Label12)
        Me.Panel14.Controls.Add(Me.lbl_SPLoad)
        Me.Panel14.Location = New System.Drawing.Point(212, 19)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(198, 128)
        Me.Panel14.TabIndex = 7
        '
        'lbl_statusalat_beban
        '
        Me.lbl_statusalat_beban.AutoSize = True
        Me.lbl_statusalat_beban.ForeColor = System.Drawing.Color.White
        Me.lbl_statusalat_beban.Location = New System.Drawing.Point(137, 95)
        Me.lbl_statusalat_beban.Name = "lbl_statusalat_beban"
        Me.lbl_statusalat_beban.Size = New System.Drawing.Size(29, 19)
        Me.lbl_statusalat_beban.TabIndex = 8
        Me.lbl_statusalat_beban.Text = "Off"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(19, 95)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(93, 19)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Status Alat : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(19, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 19)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Relay Proteksi Beban"
        '
        'lbl_SPLoad
        '
        Me.lbl_SPLoad.AutoSize = True
        Me.lbl_SPLoad.Font = New System.Drawing.Font("Century Gothic", 30.0!)
        Me.lbl_SPLoad.ForeColor = System.Drawing.Color.White
        Me.lbl_SPLoad.Location = New System.Drawing.Point(19, 32)
        Me.lbl_SPLoad.Name = "lbl_SPLoad"
        Me.lbl_SPLoad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_SPLoad.Size = New System.Drawing.Size(95, 49)
        Me.lbl_SPLoad.TabIndex = 2
        Me.lbl_SPLoad.Text = "Idle"
        Me.lbl_SPLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel16.Controls.Add(Me.lbl_statusalat_panel)
        Me.Panel16.Controls.Add(Me.Label16)
        Me.Panel16.Controls.Add(Me.lbl_SPPanel)
        Me.Panel16.Controls.Add(Me.Label13)
        Me.Panel16.Location = New System.Drawing.Point(8, 19)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(198, 128)
        Me.Panel16.TabIndex = 2
        '
        'lbl_statusalat_panel
        '
        Me.lbl_statusalat_panel.AutoSize = True
        Me.lbl_statusalat_panel.ForeColor = System.Drawing.Color.White
        Me.lbl_statusalat_panel.Location = New System.Drawing.Point(130, 95)
        Me.lbl_statusalat_panel.Name = "lbl_statusalat_panel"
        Me.lbl_statusalat_panel.Size = New System.Drawing.Size(29, 19)
        Me.lbl_statusalat_panel.TabIndex = 10
        Me.lbl_statusalat_panel.Text = "Off"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(12, 95)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 19)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Status Alat : "
        '
        'lbl_SPPanel
        '
        Me.lbl_SPPanel.AutoSize = True
        Me.lbl_SPPanel.Font = New System.Drawing.Font("Century Gothic", 30.0!)
        Me.lbl_SPPanel.ForeColor = System.Drawing.Color.White
        Me.lbl_SPPanel.Location = New System.Drawing.Point(23, 32)
        Me.lbl_SPPanel.Name = "lbl_SPPanel"
        Me.lbl_SPPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_SPPanel.Size = New System.Drawing.Size(95, 49)
        Me.lbl_SPPanel.TabIndex = 2
        Me.lbl_SPPanel.Text = "Idle"
        Me.lbl_SPPanel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(19, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 19)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Relay Solar Panel"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Firebrick
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Location = New System.Drawing.Point(690, 178)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(192, 34)
        Me.Panel7.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(36, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Monitoring Beban"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Panel10)
        Me.Panel8.Controls.Add(Me.Panel11)
        Me.Panel8.Controls.Add(Me.Panel12)
        Me.Panel8.Location = New System.Drawing.Point(8, 195)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(895, 132)
        Me.Panel8.TabIndex = 2
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Firebrick
        Me.Panel10.Controls.Add(Me.lbl_beban_daya)
        Me.Panel10.Controls.Add(Me.Label8)
        Me.Panel10.Location = New System.Drawing.Point(594, 19)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(288, 101)
        Me.Panel10.TabIndex = 4
        '
        'lbl_beban_daya
        '
        Me.lbl_beban_daya.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_beban_daya.AutoSize = True
        Me.lbl_beban_daya.Font = New System.Drawing.Font("Century Gothic", 30.0!)
        Me.lbl_beban_daya.ForeColor = System.Drawing.Color.White
        Me.lbl_beban_daya.Location = New System.Drawing.Point(47, 31)
        Me.lbl_beban_daya.Name = "lbl_beban_daya"
        Me.lbl_beban_daya.Size = New System.Drawing.Size(44, 49)
        Me.lbl_beban_daya.TabIndex = 3
        Me.lbl_beban_daya.Text = "0"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Daya (Watt)"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Firebrick
        Me.Panel11.Controls.Add(Me.lbl_beban_arus)
        Me.Panel11.Controls.Add(Me.Label9)
        Me.Panel11.Location = New System.Drawing.Point(301, 19)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(288, 101)
        Me.Panel11.TabIndex = 3
        '
        'lbl_beban_arus
        '
        Me.lbl_beban_arus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_beban_arus.AutoSize = True
        Me.lbl_beban_arus.Font = New System.Drawing.Font("Century Gothic", 30.0!)
        Me.lbl_beban_arus.ForeColor = System.Drawing.Color.White
        Me.lbl_beban_arus.Location = New System.Drawing.Point(44, 31)
        Me.lbl_beban_arus.Name = "lbl_beban_arus"
        Me.lbl_beban_arus.Size = New System.Drawing.Size(44, 49)
        Me.lbl_beban_arus.TabIndex = 3
        Me.lbl_beban_arus.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Arus (mA)"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Firebrick
        Me.Panel12.Controls.Add(Me.lbl_beban_teg)
        Me.Panel12.Controls.Add(Me.Label10)
        Me.Panel12.Location = New System.Drawing.Point(8, 19)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(288, 101)
        Me.Panel12.TabIndex = 2
        '
        'lbl_beban_teg
        '
        Me.lbl_beban_teg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_beban_teg.AutoSize = True
        Me.lbl_beban_teg.Font = New System.Drawing.Font("Century Gothic", 30.0!)
        Me.lbl_beban_teg.ForeColor = System.Drawing.Color.White
        Me.lbl_beban_teg.Location = New System.Drawing.Point(33, 31)
        Me.lbl_beban_teg.Name = "lbl_beban_teg"
        Me.lbl_beban_teg.Size = New System.Drawing.Size(44, 49)
        Me.lbl_beban_teg.TabIndex = 2
        Me.lbl_beban_teg.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(4, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 19)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Tegangan (VAC)"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(25, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(192, 34)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monitoring Panel"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(8, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(895, 132)
        Me.Panel1.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Teal
        Me.Panel6.Controls.Add(Me.lbl_StatusCharging)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Location = New System.Drawing.Point(669, 18)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(213, 101)
        Me.Panel6.TabIndex = 5
        '
        'lbl_StatusCharging
        '
        Me.lbl_StatusCharging.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_StatusCharging.AutoSize = True
        Me.lbl_StatusCharging.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.lbl_StatusCharging.ForeColor = System.Drawing.Color.White
        Me.lbl_StatusCharging.Location = New System.Drawing.Point(4, 37)
        Me.lbl_StatusCharging.Name = "lbl_StatusCharging"
        Me.lbl_StatusCharging.Size = New System.Drawing.Size(192, 33)
        Me.lbl_StatusCharging.TabIndex = 3
        Me.lbl_StatusCharging.Text = "Not Charging"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(7, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Status Charging"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Teal
        Me.Panel5.Controls.Add(Me.lbl_Panel_Daya)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Location = New System.Drawing.Point(450, 18)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(213, 101)
        Me.Panel5.TabIndex = 4
        '
        'lbl_Panel_Daya
        '
        Me.lbl_Panel_Daya.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Panel_Daya.AutoSize = True
        Me.lbl_Panel_Daya.Font = New System.Drawing.Font("Century Gothic", 30.0!)
        Me.lbl_Panel_Daya.ForeColor = System.Drawing.Color.White
        Me.lbl_Panel_Daya.Location = New System.Drawing.Point(3, 37)
        Me.lbl_Panel_Daya.Name = "lbl_Panel_Daya"
        Me.lbl_Panel_Daya.Size = New System.Drawing.Size(44, 49)
        Me.lbl_Panel_Daya.TabIndex = 3
        Me.lbl_Panel_Daya.Text = "0"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Daya (Watt)"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Teal
        Me.Panel4.Controls.Add(Me.lbl_panel_arus)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(231, 18)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(213, 101)
        Me.Panel4.TabIndex = 3
        '
        'lbl_panel_arus
        '
        Me.lbl_panel_arus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_panel_arus.AutoSize = True
        Me.lbl_panel_arus.Font = New System.Drawing.Font("Century Gothic", 30.0!)
        Me.lbl_panel_arus.ForeColor = System.Drawing.Color.White
        Me.lbl_panel_arus.Location = New System.Drawing.Point(2, 37)
        Me.lbl_panel_arus.Name = "lbl_panel_arus"
        Me.lbl_panel_arus.Size = New System.Drawing.Size(44, 49)
        Me.lbl_panel_arus.TabIndex = 2
        Me.lbl_panel_arus.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Arus Solar Cell (mA)"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.lbl_solarcell_tegangan)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(12, 18)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(213, 101)
        Me.Panel3.TabIndex = 2
        '
        'lbl_solarcell_tegangan
        '
        Me.lbl_solarcell_tegangan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_solarcell_tegangan.AutoSize = True
        Me.lbl_solarcell_tegangan.Font = New System.Drawing.Font("Century Gothic", 30.0!)
        Me.lbl_solarcell_tegangan.ForeColor = System.Drawing.Color.White
        Me.lbl_solarcell_tegangan.Location = New System.Drawing.Point(3, 37)
        Me.lbl_solarcell_tegangan.Name = "lbl_solarcell_tegangan"
        Me.lbl_solarcell_tegangan.Size = New System.Drawing.Size(44, 49)
        Me.lbl_solarcell_tegangan.TabIndex = 1
        Me.lbl_solarcell_tegangan.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(4, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tegangan Aki (VDC)"
        '
        'tp_chart_teganganaki
        '
        Me.tp_chart_teganganaki.AutoScroll = True
        Me.tp_chart_teganganaki.BackColor = System.Drawing.Color.White
        Me.tp_chart_teganganaki.Controls.Add(Me.GroupBox4)
        Me.tp_chart_teganganaki.Controls.Add(Me.GroupBox3)
        Me.tp_chart_teganganaki.Controls.Add(Me.GroupBox2)
        Me.tp_chart_teganganaki.Controls.Add(Me.GroupBox1)
        Me.tp_chart_teganganaki.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.tp_chart_teganganaki.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.tp_chart_teganganaki.Location = New System.Drawing.Point(4, 44)
        Me.tp_chart_teganganaki.Name = "tp_chart_teganganaki"
        Me.tp_chart_teganganaki.Size = New System.Drawing.Size(911, 591)
        Me.tp_chart_teganganaki.TabIndex = 2
        Me.tp_chart_teganganaki.Text = "Grafik"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.g_lbl_arusinverter)
        Me.GroupBox4.Controls.Add(Me.Chart_Arus_Inverter)
        Me.GroupBox4.Location = New System.Drawing.Point(459, 308)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(444, 299)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Arus Inverter"
        '
        'g_lbl_arusinverter
        '
        Me.g_lbl_arusinverter.AutoSize = True
        Me.g_lbl_arusinverter.Location = New System.Drawing.Point(372, 20)
        Me.g_lbl_arusinverter.Name = "g_lbl_arusinverter"
        Me.g_lbl_arusinverter.Size = New System.Drawing.Size(17, 19)
        Me.g_lbl_arusinverter.TabIndex = 1
        Me.g_lbl_arusinverter.Text = "0"
        '
        'Chart_Arus_Inverter
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart_Arus_Inverter.ChartAreas.Add(ChartArea1)
        Me.Chart_Arus_Inverter.Location = New System.Drawing.Point(6, 23)
        Me.Chart_Arus_Inverter.Name = "Chart_Arus_Inverter"
        Me.Chart_Arus_Inverter.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.Color.Navy
        Series1.Name = "Series1"
        Me.Chart_Arus_Inverter.Series.Add(Series1)
        Me.Chart_Arus_Inverter.Size = New System.Drawing.Size(417, 270)
        Me.Chart_Arus_Inverter.TabIndex = 0
        Me.Chart_Arus_Inverter.Text = "Chart1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.g_lbl_arussc)
        Me.GroupBox3.Controls.Add(Me.Chart_ArusSC)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 308)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(445, 299)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Arus Sel Surya"
        '
        'g_lbl_arussc
        '
        Me.g_lbl_arussc.AutoSize = True
        Me.g_lbl_arussc.Location = New System.Drawing.Point(376, 20)
        Me.g_lbl_arussc.Name = "g_lbl_arussc"
        Me.g_lbl_arussc.Size = New System.Drawing.Size(17, 19)
        Me.g_lbl_arussc.TabIndex = 1
        Me.g_lbl_arussc.Text = "0"
        '
        'Chart_ArusSC
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart_ArusSC.ChartAreas.Add(ChartArea2)
        Me.Chart_ArusSC.Location = New System.Drawing.Point(6, 23)
        Me.Chart_ArusSC.Name = "Chart_ArusSC"
        Me.Chart_ArusSC.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Color = System.Drawing.Color.Green
        Series2.Name = "Series1"
        Me.Chart_ArusSC.Series.Add(Series2)
        Me.Chart_ArusSC.Size = New System.Drawing.Size(417, 270)
        Me.Chart_ArusSC.TabIndex = 0
        Me.Chart_ArusSC.Text = "Chart1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.g_lbl_teganganinverter)
        Me.GroupBox2.Controls.Add(Me.Chart_Tegangan_Inverter)
        Me.GroupBox2.Location = New System.Drawing.Point(459, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(444, 299)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tegangan Inverter"
        '
        'g_lbl_teganganinverter
        '
        Me.g_lbl_teganganinverter.AutoSize = True
        Me.g_lbl_teganganinverter.Location = New System.Drawing.Point(372, 20)
        Me.g_lbl_teganganinverter.Name = "g_lbl_teganganinverter"
        Me.g_lbl_teganganinverter.Size = New System.Drawing.Size(17, 19)
        Me.g_lbl_teganganinverter.TabIndex = 1
        Me.g_lbl_teganganinverter.Text = "0"
        '
        'Chart_Tegangan_Inverter
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart_Tegangan_Inverter.ChartAreas.Add(ChartArea3)
        Me.Chart_Tegangan_Inverter.Location = New System.Drawing.Point(6, 23)
        Me.Chart_Tegangan_Inverter.Name = "Chart_Tegangan_Inverter"
        Me.Chart_Tegangan_Inverter.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Color = System.Drawing.Color.OrangeRed
        Series3.Name = "Tegangan Inverter"
        Me.Chart_Tegangan_Inverter.Series.Add(Series3)
        Me.Chart_Tegangan_Inverter.Size = New System.Drawing.Size(417, 270)
        Me.Chart_Tegangan_Inverter.TabIndex = 0
        Me.Chart_Tegangan_Inverter.Text = "Chart1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.g_lbl_teganganaki)
        Me.GroupBox1.Controls.Add(Me.Chart_TeganganAki)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 299)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tegangan Aki"
        '
        'g_lbl_teganganaki
        '
        Me.g_lbl_teganganaki.AutoSize = True
        Me.g_lbl_teganganaki.Location = New System.Drawing.Point(376, 20)
        Me.g_lbl_teganganaki.Name = "g_lbl_teganganaki"
        Me.g_lbl_teganganaki.Size = New System.Drawing.Size(17, 19)
        Me.g_lbl_teganganaki.TabIndex = 1
        Me.g_lbl_teganganaki.Text = "0"
        '
        'Chart_TeganganAki
        '
        ChartArea4.Name = "ChartArea1"
        Me.Chart_TeganganAki.ChartAreas.Add(ChartArea4)
        Me.Chart_TeganganAki.Location = New System.Drawing.Point(6, 23)
        Me.Chart_TeganganAki.Name = "Chart_TeganganAki"
        Me.Chart_TeganganAki.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series4.Color = System.Drawing.Color.Red
        Series4.Name = "Tegangan Aki"
        Me.Chart_TeganganAki.Series.Add(Series4)
        Me.Chart_TeganganAki.Size = New System.Drawing.Size(417, 270)
        Me.Chart_TeganganAki.TabIndex = 0
        Me.Chart_TeganganAki.Text = "Chart1"
        '
        'tp_gauge
        '
        Me.tp_gauge.BackColor = System.Drawing.Color.Black
        Me.tp_gauge.Controls.Add(Me.pic_s_cloud_green)
        Me.tp_gauge.Controls.Add(Me.Label22)
        Me.tp_gauge.Controls.Add(Me.lbl_scada_ipaddress)
        Me.tp_gauge.Controls.Add(Me.lbl_scada_ping)
        Me.tp_gauge.Controls.Add(Me.lbl_scada_serveraddress)
        Me.tp_gauge.Controls.Add(Me.lbl_scada_daya_beban)
        Me.tp_gauge.Controls.Add(Me.lbl_scada_arus_beban)
        Me.tp_gauge.Controls.Add(Me.lbl_scada_tegangan_beban)
        Me.tp_gauge.Controls.Add(Me.lbl_scada_daya_panel)
        Me.tp_gauge.Controls.Add(Me.lbl_scada_arus_panel)
        Me.tp_gauge.Controls.Add(Me.lbl_scada_kapasitasaki)
        Me.tp_gauge.Controls.Add(Me.lbl_scada_teganganaki_panel)
        Me.tp_gauge.Controls.Add(Me.PictureBox13)
        Me.tp_gauge.Controls.Add(Me.PictureBox11)
        Me.tp_gauge.Controls.Add(Me.PictureBox12)
        Me.tp_gauge.Controls.Add(Me.Label17)
        Me.tp_gauge.Controls.Add(Me.Label15)
        Me.tp_gauge.Controls.Add(Me.PictureBox10)
        Me.tp_gauge.Controls.Add(Me.PictureBox9)
        Me.tp_gauge.Controls.Add(Me.PictureBox8)
        Me.tp_gauge.Controls.Add(Me.pic_s_cloud_blue)
        Me.tp_gauge.Controls.Add(Me.PictureBox6)
        Me.tp_gauge.Controls.Add(Me.PictureBox5)
        Me.tp_gauge.Controls.Add(Me.PictureBox4)
        Me.tp_gauge.Controls.Add(Me.PictureBox3)
        Me.tp_gauge.Controls.Add(Me.PictureBox2)
        Me.tp_gauge.Controls.Add(Me.PictureBox1)
        Me.tp_gauge.Controls.Add(Me.Panel18)
        Me.tp_gauge.Controls.Add(Me.ShapeContainer1)
        Me.tp_gauge.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.tp_gauge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.tp_gauge.Location = New System.Drawing.Point(4, 44)
        Me.tp_gauge.Name = "tp_gauge"
        Me.tp_gauge.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_gauge.Size = New System.Drawing.Size(911, 591)
        Me.tp_gauge.TabIndex = 1
        Me.tp_gauge.Text = "Scada"
        '
        'pic_s_cloud_green
        '
        Me.pic_s_cloud_green.BackgroundImage = CType(resources.GetObject("pic_s_cloud_green.BackgroundImage"), System.Drawing.Image)
        Me.pic_s_cloud_green.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_s_cloud_green.Location = New System.Drawing.Point(437, 205)
        Me.pic_s_cloud_green.Name = "pic_s_cloud_green"
        Me.pic_s_cloud_green.Size = New System.Drawing.Size(51, 41)
        Me.pic_s_cloud_green.TabIndex = 51
        Me.pic_s_cloud_green.TabStop = False
        Me.pic_s_cloud_green.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(394, 381)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(54, 25)
        Me.Label22.TabIndex = 50
        Me.Label22.Text = "Ping  :"
        Me.Label22.UseCompatibleTextRendering = True
        '
        'lbl_scada_ipaddress
        '
        Me.lbl_scada_ipaddress.AutoSize = True
        Me.lbl_scada_ipaddress.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lbl_scada_ipaddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lbl_scada_ipaddress.Location = New System.Drawing.Point(133, 58)
        Me.lbl_scada_ipaddress.Name = "lbl_scada_ipaddress"
        Me.lbl_scada_ipaddress.Size = New System.Drawing.Size(83, 25)
        Me.lbl_scada_ipaddress.TabIndex = 49
        Me.lbl_scada_ipaddress.Text = "IP : 0.0.0.0"
        Me.lbl_scada_ipaddress.UseCompatibleTextRendering = True
        '
        'lbl_scada_ping
        '
        Me.lbl_scada_ping.AutoSize = True
        Me.lbl_scada_ping.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lbl_scada_ping.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lbl_scada_ping.Location = New System.Drawing.Point(457, 381)
        Me.lbl_scada_ping.Name = "lbl_scada_ping"
        Me.lbl_scada_ping.Size = New System.Drawing.Size(41, 25)
        Me.lbl_scada_ping.TabIndex = 48
        Me.lbl_scada_ping.Text = "0 ms"
        Me.lbl_scada_ping.UseCompatibleTextRendering = True
        '
        'lbl_scada_serveraddress
        '
        Me.lbl_scada_serveraddress.AutoSize = True
        Me.lbl_scada_serveraddress.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lbl_scada_serveraddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lbl_scada_serveraddress.Location = New System.Drawing.Point(394, 356)
        Me.lbl_scada_serveraddress.Name = "lbl_scada_serveraddress"
        Me.lbl_scada_serveraddress.Size = New System.Drawing.Size(83, 25)
        Me.lbl_scada_serveraddress.TabIndex = 47
        Me.lbl_scada_serveraddress.Text = "IP : 0.0.0.0"
        Me.lbl_scada_serveraddress.UseCompatibleTextRendering = True
        '
        'lbl_scada_daya_beban
        '
        Me.lbl_scada_daya_beban.AutoSize = True
        Me.lbl_scada_daya_beban.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lbl_scada_daya_beban.Location = New System.Drawing.Point(759, 490)
        Me.lbl_scada_daya_beban.Name = "lbl_scada_daya_beban"
        Me.lbl_scada_daya_beban.Size = New System.Drawing.Size(48, 21)
        Me.lbl_scada_daya_beban.TabIndex = 46
        Me.lbl_scada_daya_beban.Text = "0 Watt"
        Me.lbl_scada_daya_beban.UseCompatibleTextRendering = True
        '
        'lbl_scada_arus_beban
        '
        Me.lbl_scada_arus_beban.AutoSize = True
        Me.lbl_scada_arus_beban.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lbl_scada_arus_beban.Location = New System.Drawing.Point(628, 511)
        Me.lbl_scada_arus_beban.Name = "lbl_scada_arus_beban"
        Me.lbl_scada_arus_beban.Size = New System.Drawing.Size(39, 21)
        Me.lbl_scada_arus_beban.TabIndex = 45
        Me.lbl_scada_arus_beban.Text = "0 mA"
        Me.lbl_scada_arus_beban.UseCompatibleTextRendering = True
        '
        'lbl_scada_tegangan_beban
        '
        Me.lbl_scada_tegangan_beban.AutoSize = True
        Me.lbl_scada_tegangan_beban.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lbl_scada_tegangan_beban.Location = New System.Drawing.Point(628, 490)
        Me.lbl_scada_tegangan_beban.Name = "lbl_scada_tegangan_beban"
        Me.lbl_scada_tegangan_beban.Size = New System.Drawing.Size(47, 21)
        Me.lbl_scada_tegangan_beban.TabIndex = 44
        Me.lbl_scada_tegangan_beban.Text = "0 VAC"
        Me.lbl_scada_tegangan_beban.UseCompatibleTextRendering = True
        '
        'lbl_scada_daya_panel
        '
        Me.lbl_scada_daya_panel.AutoSize = True
        Me.lbl_scada_daya_panel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lbl_scada_daya_panel.Location = New System.Drawing.Point(126, 511)
        Me.lbl_scada_daya_panel.Name = "lbl_scada_daya_panel"
        Me.lbl_scada_daya_panel.Size = New System.Drawing.Size(48, 21)
        Me.lbl_scada_daya_panel.TabIndex = 43
        Me.lbl_scada_daya_panel.Text = "0 Watt"
        Me.lbl_scada_daya_panel.UseCompatibleTextRendering = True
        '
        'lbl_scada_arus_panel
        '
        Me.lbl_scada_arus_panel.AutoSize = True
        Me.lbl_scada_arus_panel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lbl_scada_arus_panel.Location = New System.Drawing.Point(126, 490)
        Me.lbl_scada_arus_panel.Name = "lbl_scada_arus_panel"
        Me.lbl_scada_arus_panel.Size = New System.Drawing.Size(39, 21)
        Me.lbl_scada_arus_panel.TabIndex = 42
        Me.lbl_scada_arus_panel.Text = "0 mA"
        Me.lbl_scada_arus_panel.UseCompatibleTextRendering = True
        '
        'lbl_scada_kapasitasaki
        '
        Me.lbl_scada_kapasitasaki.AutoSize = True
        Me.lbl_scada_kapasitasaki.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lbl_scada_kapasitasaki.Location = New System.Drawing.Point(239, 511)
        Me.lbl_scada_kapasitasaki.Name = "lbl_scada_kapasitasaki"
        Me.lbl_scada_kapasitasaki.Size = New System.Drawing.Size(27, 21)
        Me.lbl_scada_kapasitasaki.TabIndex = 40
        Me.lbl_scada_kapasitasaki.Text = "0 %"
        Me.lbl_scada_kapasitasaki.UseCompatibleTextRendering = True
        '
        'lbl_scada_teganganaki_panel
        '
        Me.lbl_scada_teganganaki_panel.AutoSize = True
        Me.lbl_scada_teganganaki_panel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lbl_scada_teganganaki_panel.Location = New System.Drawing.Point(239, 490)
        Me.lbl_scada_teganganaki_panel.Name = "lbl_scada_teganganaki_panel"
        Me.lbl_scada_teganganaki_panel.Size = New System.Drawing.Size(47, 21)
        Me.lbl_scada_teganganaki_panel.TabIndex = 39
        Me.lbl_scada_teganganaki_panel.Text = "0 VDC"
        Me.lbl_scada_teganganaki_panel.UseCompatibleTextRendering = True
        '
        'PictureBox13
        '
        Me.PictureBox13.BackgroundImage = CType(resources.GetObject("PictureBox13.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox13.Location = New System.Drawing.Point(759, 221)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(51, 41)
        Me.PictureBox13.TabIndex = 28
        Me.PictureBox13.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackgroundImage = CType(resources.GetObject("PictureBox11.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox11.Location = New System.Drawing.Point(736, 268)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(87, 65)
        Me.PictureBox11.TabIndex = 27
        Me.PictureBox11.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackgroundImage = CType(resources.GetObject("PictureBox12.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox12.Location = New System.Drawing.Point(633, 268)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(87, 65)
        Me.PictureBox12.TabIndex = 26
        Me.PictureBox12.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(634, 444)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 22)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Inverter"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(779, 444)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 22)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Load"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackgroundImage = CType(resources.GetObject("PictureBox10.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox10.Location = New System.Drawing.Point(239, 411)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(100, 76)
        Me.PictureBox10.TabIndex = 22
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox9.Location = New System.Drawing.Point(126, 411)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(100, 76)
        Me.PictureBox9.TabIndex = 21
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.Location = New System.Drawing.Point(51, 11)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(51, 41)
        Me.PictureBox8.TabIndex = 20
        Me.PictureBox8.TabStop = False
        '
        'pic_s_cloud_blue
        '
        Me.pic_s_cloud_blue.BackgroundImage = CType(resources.GetObject("pic_s_cloud_blue.BackgroundImage"), System.Drawing.Image)
        Me.pic_s_cloud_blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_s_cloud_blue.Location = New System.Drawing.Point(437, 205)
        Me.pic_s_cloud_blue.Name = "pic_s_cloud_blue"
        Me.pic_s_cloud_blue.Size = New System.Drawing.Size(51, 41)
        Me.pic_s_cloud_blue.TabIndex = 19
        Me.pic_s_cloud_blue.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(394, 252)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(132, 95)
        Me.PictureBox6.TabIndex = 18
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(27, 58)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 71)
        Me.PictureBox5.TabIndex = 17
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(146, 229)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(51, 34)
        Me.PictureBox4.TabIndex = 16
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(126, 276)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(87, 58)
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(23, 276)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(87, 58)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(14, 411)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 76)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel18.Controls.Add(Me.lbl_scada_relay_beban)
        Me.Panel18.Controls.Add(Me.Label20)
        Me.Panel18.Controls.Add(Me.Label38)
        Me.Panel18.Controls.Add(Me.Label19)
        Me.Panel18.Controls.Add(Me.Label39)
        Me.Panel18.Controls.Add(Me.lbl_scada_mode_beban)
        Me.Panel18.Controls.Add(Me.Label56)
        Me.Panel18.Controls.Add(Me.Label45)
        Me.Panel18.Controls.Add(Me.Label55)
        Me.Panel18.Controls.Add(Me.lbl_scada_jamb_panel)
        Me.Panel18.Controls.Add(Me.Label46)
        Me.Panel18.Controls.Add(Me.lbl_scada_jama_panel)
        Me.Panel18.Controls.Add(Me.Label50)
        Me.Panel18.Controls.Add(Me.lbl_scada_relay_panel)
        Me.Panel18.Controls.Add(Me.Label35)
        Me.Panel18.Controls.Add(Me.Label36)
        Me.Panel18.Controls.Add(Me.lbl_scada_mode_panel)
        Me.Panel18.Controls.Add(Me.lbl_scada_charging_panel)
        Me.Panel18.Controls.Add(Me.Label28)
        Me.Panel18.Controls.Add(Me.Label27)
        Me.Panel18.Controls.Add(Me.Label23)
        Me.Panel18.Controls.Add(Me.Label21)
        Me.Panel18.Location = New System.Drawing.Point(437, 0)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(474, 117)
        Me.Panel18.TabIndex = 11
        '
        'lbl_scada_relay_beban
        '
        Me.lbl_scada_relay_beban.AutoSize = True
        Me.lbl_scada_relay_beban.ForeColor = System.Drawing.Color.White
        Me.lbl_scada_relay_beban.Location = New System.Drawing.Point(425, 48)
        Me.lbl_scada_relay_beban.Name = "lbl_scada_relay_beban"
        Me.lbl_scada_relay_beban.Size = New System.Drawing.Size(34, 19)
        Me.lbl_scada_relay_beban.TabIndex = 29
        Me.lbl_scada_relay_beban.Text = "Idle"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(286, 7)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(46, 17)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "LOAD"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(406, 48)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(13, 19)
        Me.Label38.TabIndex = 28
        Me.Label38.Text = ":"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(21, 7)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 17)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "PLTS"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(281, 48)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(93, 19)
        Me.Label39.TabIndex = 27
        Me.Label39.Text = "Status Relay"
        '
        'lbl_scada_mode_beban
        '
        Me.lbl_scada_mode_beban.AutoSize = True
        Me.lbl_scada_mode_beban.ForeColor = System.Drawing.Color.White
        Me.lbl_scada_mode_beban.Location = New System.Drawing.Point(425, 29)
        Me.lbl_scada_mode_beban.Name = "lbl_scada_mode_beban"
        Me.lbl_scada_mode_beban.Size = New System.Drawing.Size(41, 19)
        Me.lbl_scada_mode_beban.TabIndex = 23
        Me.lbl_scada_mode_beban.Text = "Auto"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.ForeColor = System.Drawing.Color.White
        Me.Label56.Location = New System.Drawing.Point(140, 88)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(13, 19)
        Me.Label56.TabIndex = 31
        Me.Label56.Text = ":"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.ForeColor = System.Drawing.Color.White
        Me.Label45.Location = New System.Drawing.Point(406, 29)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(13, 19)
        Me.Label45.TabIndex = 18
        Me.Label45.Text = ":"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.ForeColor = System.Drawing.Color.White
        Me.Label55.Location = New System.Drawing.Point(16, 88)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(107, 19)
        Me.Label55.TabIndex = 30
        Me.Label55.Text = "Jam Charging"
        '
        'lbl_scada_jamb_panel
        '
        Me.lbl_scada_jamb_panel.AutoSize = True
        Me.lbl_scada_jamb_panel.ForeColor = System.Drawing.Color.White
        Me.lbl_scada_jamb_panel.Location = New System.Drawing.Point(210, 88)
        Me.lbl_scada_jamb_panel.Name = "lbl_scada_jamb_panel"
        Me.lbl_scada_jamb_panel.Size = New System.Drawing.Size(25, 19)
        Me.lbl_scada_jamb_panel.TabIndex = 29
        Me.lbl_scada_jamb_panel.Text = "24"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.ForeColor = System.Drawing.Color.White
        Me.Label46.Location = New System.Drawing.Point(190, 88)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(14, 19)
        Me.Label46.TabIndex = 28
        Me.Label46.Text = "-"
        '
        'lbl_scada_jama_panel
        '
        Me.lbl_scada_jama_panel.AutoSize = True
        Me.lbl_scada_jama_panel.ForeColor = System.Drawing.Color.White
        Me.lbl_scada_jama_panel.Location = New System.Drawing.Point(160, 88)
        Me.lbl_scada_jama_panel.Name = "lbl_scada_jama_panel"
        Me.lbl_scada_jama_panel.Size = New System.Drawing.Size(25, 19)
        Me.lbl_scada_jama_panel.TabIndex = 27
        Me.lbl_scada_jama_panel.Text = "00"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.ForeColor = System.Drawing.Color.White
        Me.Label50.Location = New System.Drawing.Point(281, 29)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(81, 19)
        Me.Label50.TabIndex = 13
        Me.Label50.Text = "Mode Alat"
        '
        'lbl_scada_relay_panel
        '
        Me.lbl_scada_relay_panel.AutoSize = True
        Me.lbl_scada_relay_panel.ForeColor = System.Drawing.Color.White
        Me.lbl_scada_relay_panel.Location = New System.Drawing.Point(159, 46)
        Me.lbl_scada_relay_panel.Name = "lbl_scada_relay_panel"
        Me.lbl_scada_relay_panel.Size = New System.Drawing.Size(34, 19)
        Me.lbl_scada_relay_panel.TabIndex = 26
        Me.lbl_scada_relay_panel.Text = "Idle"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(140, 46)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(13, 19)
        Me.Label35.TabIndex = 25
        Me.Label35.Text = ":"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(16, 46)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(93, 19)
        Me.Label36.TabIndex = 24
        Me.Label36.Text = "Status Relay"
        '
        'lbl_scada_mode_panel
        '
        Me.lbl_scada_mode_panel.AutoSize = True
        Me.lbl_scada_mode_panel.ForeColor = System.Drawing.Color.White
        Me.lbl_scada_mode_panel.Location = New System.Drawing.Point(159, 67)
        Me.lbl_scada_mode_panel.Name = "lbl_scada_mode_panel"
        Me.lbl_scada_mode_panel.Size = New System.Drawing.Size(41, 19)
        Me.lbl_scada_mode_panel.TabIndex = 23
        Me.lbl_scada_mode_panel.Text = "Auto"
        '
        'lbl_scada_charging_panel
        '
        Me.lbl_scada_charging_panel.AutoSize = True
        Me.lbl_scada_charging_panel.ForeColor = System.Drawing.Color.White
        Me.lbl_scada_charging_panel.Location = New System.Drawing.Point(159, 27)
        Me.lbl_scada_charging_panel.Name = "lbl_scada_charging_panel"
        Me.lbl_scada_charging_panel.Size = New System.Drawing.Size(101, 19)
        Me.lbl_scada_charging_panel.TabIndex = 22
        Me.lbl_scada_charging_panel.Text = "Not Charging"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(140, 67)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(13, 19)
        Me.Label28.TabIndex = 18
        Me.Label28.Text = ":"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(141, 27)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(13, 19)
        Me.Label27.TabIndex = 17
        Me.Label27.Text = ":"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(16, 67)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(81, 19)
        Me.Label23.TabIndex = 13
        Me.Label23.Text = "Mode Alat"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(16, 27)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(118, 19)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "Status Charging"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape14, Me.RectangleShape13, Me.RectangleShape12, Me.RectangleShape11, Me.RectangleShape10, Me.RectangleShape9, Me.RectangleShape8, Me.RectangleShape7, Me.RectangleShape6, Me.RectangleShape5, Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(905, 585)
        Me.ShapeContainer1.TabIndex = 23
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape14
        '
        Me.RectangleShape14.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape14.FillColor = System.Drawing.Color.Gray
        Me.RectangleShape14.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape14.Location = New System.Drawing.Point(798, 379)
        Me.RectangleShape14.Name = "RectangleShape14"
        Me.RectangleShape14.Size = New System.Drawing.Size(10, 39)
        '
        'RectangleShape13
        '
        Me.RectangleShape13.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape13.FillColor = System.Drawing.Color.Gray
        Me.RectangleShape13.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape13.Location = New System.Drawing.Point(668, 339)
        Me.RectangleShape13.Name = "RectangleShape13"
        Me.RectangleShape13.Size = New System.Drawing.Size(10, 77)
        '
        'RectangleShape12
        '
        Me.RectangleShape12.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape12.FillColor = System.Drawing.Color.Gray
        Me.RectangleShape12.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape12.Location = New System.Drawing.Point(675, 379)
        Me.RectangleShape12.Name = "RectangleShape12"
        Me.RectangleShape12.Size = New System.Drawing.Size(132, 10)
        '
        'RectangleShape11
        '
        Me.RectangleShape11.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape11.FillColor = System.Drawing.Color.Gray
        Me.RectangleShape11.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape11.Location = New System.Drawing.Point(714, 295)
        Me.RectangleShape11.Name = "RectangleShape11"
        Me.RectangleShape11.Size = New System.Drawing.Size(19, 10)
        '
        'RectangleShape10
        '
        Me.RectangleShape10.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape10.FillColor = System.Drawing.Color.Gray
        Me.RectangleShape10.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape10.Location = New System.Drawing.Point(726, 451)
        Me.RectangleShape10.Name = "RectangleShape10"
        Me.RectangleShape10.Size = New System.Drawing.Size(19, 10)
        '
        'RectangleShape9
        '
        Me.RectangleShape9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.RectangleShape9.BorderWidth = 3
        Me.RectangleShape9.Location = New System.Drawing.Point(625, 428)
        Me.RectangleShape9.Name = "RectangleShape9"
        Me.RectangleShape9.Size = New System.Drawing.Size(93, 52)
        '
        'RectangleShape8
        '
        Me.RectangleShape8.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.RectangleShape8.BorderWidth = 3
        Me.RectangleShape8.Location = New System.Drawing.Point(756, 427)
        Me.RectangleShape8.Name = "RectangleShape8"
        Me.RectangleShape8.Size = New System.Drawing.Size(93, 52)
        '
        'RectangleShape7
        '
        Me.RectangleShape7.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape7.FillColor = System.Drawing.Color.Gray
        Me.RectangleShape7.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape7.Location = New System.Drawing.Point(104, 296)
        Me.RectangleShape7.Name = "RectangleShape7"
        Me.RectangleShape7.Size = New System.Drawing.Size(19, 10)
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape6.FillColor = System.Drawing.Color.Gray
        Me.RectangleShape6.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape6.Location = New System.Drawing.Point(108, 443)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(19, 10)
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape5.FillColor = System.Drawing.Color.Gray
        Me.RectangleShape5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape5.Location = New System.Drawing.Point(220, 442)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(19, 10)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape4.FillColor = System.Drawing.Color.Gray
        Me.RectangleShape4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape4.Location = New System.Drawing.Point(173, 374)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(10, 30)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape3.FillColor = System.Drawing.Color.Gray
        Me.RectangleShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape3.Location = New System.Drawing.Point(67, 337)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(10, 36)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape2.FillColor = System.Drawing.Color.Gray
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(287, 366)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(10, 38)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape1.FillColor = System.Drawing.Color.Gray
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(67, 366)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(224, 10)
        '
        'frmMonitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(919, 639)
        Me.Controls.Add(Me.FirefoxSubTabControl1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMonitoring"
        Me.Text = "frmMonitoring"
        Me.FirefoxSubTabControl1.ResumeLayout(False)
        Me.tp_interface.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.tp_chart_teganganaki.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Chart_Arus_Inverter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Chart_ArusSC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Chart_Tegangan_Inverter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Chart_TeganganAki, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_gauge.ResumeLayout(False)
        Me.tp_gauge.PerformLayout()
        CType(Me.pic_s_cloud_green, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_s_cloud_blue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FirefoxSubTabControl1 As Mini_Scada_V0._9._1.FirefoxSubTabControl
    Friend WithEvents tp_interface As System.Windows.Forms.TabPage
    Friend WithEvents tp_gauge As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbl_solarcell_tegangan As System.Windows.Forms.Label
    Friend WithEvents lbl_panel_arus As System.Windows.Forms.Label
    Friend WithEvents lbl_StatusCharging As System.Windows.Forms.Label
    Friend WithEvents lbl_Panel_Daya As System.Windows.Forms.Label
    Friend WithEvents lbl_beban_teg As System.Windows.Forms.Label
    Friend WithEvents lbl_beban_daya As System.Windows.Forms.Label
    Friend WithEvents lbl_beban_arus As System.Windows.Forms.Label
    Friend WithEvents lbl_SPPanel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Tim_RealTime As System.Windows.Forms.Timer
    Friend WithEvents btn_resetall As System.Windows.Forms.Button
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbl_SPLoad As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_VPPanel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_APPanel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_APBeban As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_VPBeban As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_statusalat_beban As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbl_statusalat_panel As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TimerScadaTab As System.Windows.Forms.Timer
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lbl_scada_charging_panel As System.Windows.Forms.Label
    Friend WithEvents lbl_scada_mode_panel As System.Windows.Forms.Label
    Friend WithEvents lbl_scada_relay_panel As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents lbl_scada_mode_beban As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents lbl_scada_relay_beban As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents lbl_scada_jamb_panel As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents lbl_scada_jama_panel As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents lbl_capasity_aki As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents tp_chart_teganganaki As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Chart_TeganganAki As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Chart_Tegangan_Inverter As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents g_lbl_teganganinverter As System.Windows.Forms.Label
    Friend WithEvents g_lbl_teganganaki As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents g_lbl_arussc As System.Windows.Forms.Label
    Friend WithEvents Chart_ArusSC As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents g_lbl_arusinverter As System.Windows.Forms.Label
    Friend WithEvents Chart_Arus_Inverter As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_s_cloud_blue As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape7 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape8 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape9 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape10 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents RectangleShape11 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape14 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape13 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape12 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lbl_scada_teganganaki_panel As System.Windows.Forms.Label
    Friend WithEvents lbl_scada_kapasitasaki As System.Windows.Forms.Label
    Friend WithEvents lbl_scada_arus_panel As System.Windows.Forms.Label
    Friend WithEvents lbl_scada_daya_panel As System.Windows.Forms.Label
    Friend WithEvents lbl_scada_tegangan_beban As System.Windows.Forms.Label
    Friend WithEvents lbl_scada_arus_beban As System.Windows.Forms.Label
    Friend WithEvents lbl_scada_daya_beban As System.Windows.Forms.Label
    Friend WithEvents lbl_scada_serveraddress As System.Windows.Forms.Label
    Friend WithEvents lbl_scada_ping As System.Windows.Forms.Label
    Friend WithEvents lbl_scada_ipaddress As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents animation_cloud_timer As System.Windows.Forms.Timer
    Friend WithEvents pic_s_cloud_green As System.Windows.Forms.PictureBox
End Class
