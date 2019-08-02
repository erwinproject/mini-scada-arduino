<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLog))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FirefoxSubTabControl21 = New Mini_Scada_V0._9._1.FirefoxSubTabControl2()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.panelSlideMenu = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btn_clearlogSolarCell = New System.Windows.Forms.Button()
        Me.DataGridSolarPanel = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tegangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Arus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayaSolarPanel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Relay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RStatusPanel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.expersenaki = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btn_clearlogbeban = New System.Windows.Forms.Button()
        Me.DataGridBeban = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConditionCharge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TP_Setup = New System.Windows.Forms.TabPage()
        Me.btn_savetoexcel_beban = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox_autoOpen = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.btn_savetoexcel = New System.Windows.Forms.Button()
        Me.btn_clearalllog = New System.Windows.Forms.Button()
        Me.FirefoxSubTabControl21.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.panelSlideMenu.SuspendLayout()
        CType(Me.DataGridSolarPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.DataGridBeban, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP_Setup.SuspendLayout()
        Me.SuspendLayout()
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "xlsx"
        '
        'FirefoxSubTabControl21
        '
        Me.FirefoxSubTabControl21.Controls.Add(Me.TabPage1)
        Me.FirefoxSubTabControl21.Controls.Add(Me.TabPage2)
        Me.FirefoxSubTabControl21.Controls.Add(Me.TP_Setup)
        Me.FirefoxSubTabControl21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FirefoxSubTabControl21.ItemSize = New System.Drawing.Size(250, 40)
        Me.FirefoxSubTabControl21.Location = New System.Drawing.Point(0, 0)
        Me.FirefoxSubTabControl21.Name = "FirefoxSubTabControl21"
        Me.FirefoxSubTabControl21.SelectedIndex = 0
        Me.FirefoxSubTabControl21.Size = New System.Drawing.Size(919, 639)
        Me.FirefoxSubTabControl21.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FirefoxSubTabControl21.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.panelSlideMenu)
        Me.TabPage1.Controls.Add(Me.DataGridSolarPanel)
        Me.TabPage1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(911, 591)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Log Solar Cell"
        '
        'panelSlideMenu
        '
        Me.panelSlideMenu.BackgroundImage = CType(resources.GetObject("panelSlideMenu.BackgroundImage"), System.Drawing.Image)
        Me.panelSlideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelSlideMenu.Controls.Add(Me.btn_clearlogSolarCell)
        Me.panelSlideMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelSlideMenu.GradientBottomLeft = System.Drawing.Color.Firebrick
        Me.panelSlideMenu.GradientBottomRight = System.Drawing.Color.DarkSlateBlue
        Me.panelSlideMenu.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.panelSlideMenu.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.panelSlideMenu.Location = New System.Drawing.Point(3, 517)
        Me.panelSlideMenu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panelSlideMenu.Name = "panelSlideMenu"
        Me.panelSlideMenu.Quality = 10
        Me.panelSlideMenu.Size = New System.Drawing.Size(905, 71)
        Me.panelSlideMenu.TabIndex = 5
        '
        'btn_clearlogSolarCell
        '
        Me.btn_clearlogSolarCell.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_clearlogSolarCell.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clearlogSolarCell.FlatAppearance.BorderSize = 0
        Me.btn_clearlogSolarCell.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_clearlogSolarCell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_clearlogSolarCell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clearlogSolarCell.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btn_clearlogSolarCell.ForeColor = System.Drawing.Color.White
        Me.btn_clearlogSolarCell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clearlogSolarCell.Location = New System.Drawing.Point(735, 6)
        Me.btn_clearlogSolarCell.Name = "btn_clearlogSolarCell"
        Me.btn_clearlogSolarCell.Size = New System.Drawing.Size(165, 49)
        Me.btn_clearlogSolarCell.TabIndex = 5
        Me.btn_clearlogSolarCell.Text = "Clear Log Solar Cell"
        Me.btn_clearlogSolarCell.UseVisualStyleBackColor = False
        '
        'DataGridSolarPanel
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridSolarPanel.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridSolarPanel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridSolarPanel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridSolarPanel.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridSolarPanel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridSolarPanel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridSolarPanel.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridSolarPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSolarPanel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tanggal, Me.Tegangan, Me.Arus, Me.DayaSolarPanel, Me.Relay, Me.RStatusPanel, Me.expersenaki})
        Me.DataGridSolarPanel.DoubleBuffered = True
        Me.DataGridSolarPanel.EnableHeadersVisualStyles = False
        Me.DataGridSolarPanel.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.DataGridSolarPanel.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.DataGridSolarPanel.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridSolarPanel.Location = New System.Drawing.Point(3, 3)
        Me.DataGridSolarPanel.Name = "DataGridSolarPanel"
        Me.DataGridSolarPanel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridSolarPanel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.DataGridSolarPanel.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridSolarPanel.Size = New System.Drawing.Size(905, 514)
        Me.DataGridSolarPanel.StandardTab = True
        Me.DataGridSolarPanel.TabIndex = 2
        '
        'Tanggal
        '
        Me.Tanggal.HeaderText = "Tanggal dan Jam"
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.ReadOnly = True
        '
        'Tegangan
        '
        Me.Tegangan.HeaderText = "Tegangan Aki (VDC)"
        Me.Tegangan.Name = "Tegangan"
        Me.Tegangan.ReadOnly = True
        '
        'Arus
        '
        Me.Arus.HeaderText = "Arus (mA)"
        Me.Arus.Name = "Arus"
        Me.Arus.ReadOnly = True
        '
        'DayaSolarPanel
        '
        Me.DayaSolarPanel.HeaderText = "Daya Panel (Watt)"
        Me.DayaSolarPanel.Name = "DayaSolarPanel"
        '
        'Relay
        '
        Me.Relay.HeaderText = "Status Charging"
        Me.Relay.Name = "Relay"
        Me.Relay.ReadOnly = True
        '
        'RStatusPanel
        '
        Me.RStatusPanel.HeaderText = "Status Relay"
        Me.RStatusPanel.Name = "RStatusPanel"
        '
        'expersenaki
        '
        Me.expersenaki.HeaderText = "Kapasitas Aki (%)"
        Me.expersenaki.Name = "expersenaki"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.BunifuGradientPanel1)
        Me.TabPage2.Controls.Add(Me.DataGridBeban)
        Me.TabPage2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.TabPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(911, 591)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Log Beban"
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.btn_clearlogbeban)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Firebrick
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkSlateBlue
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(3, 517)
        Me.BunifuGradientPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(905, 71)
        Me.BunifuGradientPanel1.TabIndex = 6
        '
        'btn_clearlogbeban
        '
        Me.btn_clearlogbeban.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_clearlogbeban.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clearlogbeban.FlatAppearance.BorderSize = 0
        Me.btn_clearlogbeban.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_clearlogbeban.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_clearlogbeban.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clearlogbeban.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btn_clearlogbeban.ForeColor = System.Drawing.Color.White
        Me.btn_clearlogbeban.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clearlogbeban.Location = New System.Drawing.Point(735, 6)
        Me.btn_clearlogbeban.Name = "btn_clearlogbeban"
        Me.btn_clearlogbeban.Size = New System.Drawing.Size(165, 49)
        Me.btn_clearlogbeban.TabIndex = 6
        Me.btn_clearlogbeban.Text = "Clear Log Beban"
        Me.btn_clearlogbeban.UseVisualStyleBackColor = False
        '
        'DataGridBeban
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DataGridBeban.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridBeban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridBeban.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridBeban.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridBeban.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridBeban.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridBeban.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridBeban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridBeban.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.ConditionCharge})
        Me.DataGridBeban.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridBeban.DoubleBuffered = True
        Me.DataGridBeban.EnableHeadersVisualStyles = False
        Me.DataGridBeban.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.DataGridBeban.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.DataGridBeban.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridBeban.Location = New System.Drawing.Point(3, 3)
        Me.DataGridBeban.Name = "DataGridBeban"
        Me.DataGridBeban.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridBeban.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.DataGridBeban.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridBeban.Size = New System.Drawing.Size(905, 585)
        Me.DataGridBeban.StandardTab = True
        Me.DataGridBeban.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tanggal dan Jam"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tegangan (VAC)"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Arus (A)"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Daya Beban (Watt)"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'ConditionCharge
        '
        Me.ConditionCharge.HeaderText = "Status Relay"
        Me.ConditionCharge.Name = "ConditionCharge"
        '
        'TP_Setup
        '
        Me.TP_Setup.BackColor = System.Drawing.Color.White
        Me.TP_Setup.Controls.Add(Me.btn_savetoexcel_beban)
        Me.TP_Setup.Controls.Add(Me.Label1)
        Me.TP_Setup.Controls.Add(Me.CheckBox_autoOpen)
        Me.TP_Setup.Controls.Add(Me.btn_savetoexcel)
        Me.TP_Setup.Controls.Add(Me.btn_clearalllog)
        Me.TP_Setup.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.TP_Setup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TP_Setup.Location = New System.Drawing.Point(4, 44)
        Me.TP_Setup.Name = "TP_Setup"
        Me.TP_Setup.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Setup.Size = New System.Drawing.Size(911, 591)
        Me.TP_Setup.TabIndex = 2
        Me.TP_Setup.Text = "Tools"
        '
        'btn_savetoexcel_beban
        '
        Me.btn_savetoexcel_beban.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_savetoexcel_beban.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_savetoexcel_beban.FlatAppearance.BorderSize = 0
        Me.btn_savetoexcel_beban.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_savetoexcel_beban.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_savetoexcel_beban.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_savetoexcel_beban.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btn_savetoexcel_beban.ForeColor = System.Drawing.Color.White
        Me.btn_savetoexcel_beban.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_savetoexcel_beban.Location = New System.Drawing.Point(557, 177)
        Me.btn_savetoexcel_beban.Name = "btn_savetoexcel_beban"
        Me.btn_savetoexcel_beban.Size = New System.Drawing.Size(181, 62)
        Me.btn_savetoexcel_beban.TabIndex = 7
        Me.btn_savetoexcel_beban.Text = "Save Data Beban"
        Me.btn_savetoexcel_beban.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(210, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Auto Open File Excel"
        '
        'CheckBox_autoOpen
        '
        Me.CheckBox_autoOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CheckBox_autoOpen.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CheckBox_autoOpen.Checked = False
        Me.CheckBox_autoOpen.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.CheckBox_autoOpen.ForeColor = System.Drawing.Color.White
        Me.CheckBox_autoOpen.Location = New System.Drawing.Point(183, 256)
        Me.CheckBox_autoOpen.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_autoOpen.Name = "CheckBox_autoOpen"
        Me.CheckBox_autoOpen.Size = New System.Drawing.Size(20, 20)
        Me.CheckBox_autoOpen.TabIndex = 5
        '
        'btn_savetoexcel
        '
        Me.btn_savetoexcel.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_savetoexcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_savetoexcel.FlatAppearance.BorderSize = 0
        Me.btn_savetoexcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_savetoexcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_savetoexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_savetoexcel.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btn_savetoexcel.ForeColor = System.Drawing.Color.White
        Me.btn_savetoexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_savetoexcel.Location = New System.Drawing.Point(370, 177)
        Me.btn_savetoexcel.Name = "btn_savetoexcel"
        Me.btn_savetoexcel.Size = New System.Drawing.Size(181, 62)
        Me.btn_savetoexcel.TabIndex = 4
        Me.btn_savetoexcel.Text = "Save Data Panel"
        Me.btn_savetoexcel.UseVisualStyleBackColor = False
        '
        'btn_clearalllog
        '
        Me.btn_clearalllog.BackColor = System.Drawing.Color.Maroon
        Me.btn_clearalllog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clearalllog.FlatAppearance.BorderSize = 0
        Me.btn_clearalllog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_clearalllog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_clearalllog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clearalllog.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btn_clearalllog.ForeColor = System.Drawing.Color.White
        Me.btn_clearalllog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clearalllog.Location = New System.Drawing.Point(183, 177)
        Me.btn_clearalllog.Name = "btn_clearalllog"
        Me.btn_clearalllog.Size = New System.Drawing.Size(181, 62)
        Me.btn_clearalllog.TabIndex = 3
        Me.btn_clearalllog.Text = "Clear All Log"
        Me.btn_clearalllog.UseVisualStyleBackColor = False
        '
        'frmLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 639)
        Me.Controls.Add(Me.FirefoxSubTabControl21)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmLog"
        Me.Text = "frmLog"
        Me.FirefoxSubTabControl21.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.panelSlideMenu.ResumeLayout(False)
        CType(Me.DataGridSolarPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.BunifuGradientPanel1.ResumeLayout(False)
        CType(Me.DataGridBeban, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP_Setup.ResumeLayout(False)
        Me.TP_Setup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FirefoxSubTabControl21 As Mini_Scada_V0._9._1.FirefoxSubTabControl2
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridSolarPanel As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DataGridBeban As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents TP_Setup As System.Windows.Forms.TabPage
    Friend WithEvents btn_clearalllog As System.Windows.Forms.Button
    Friend WithEvents panelSlideMenu As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btn_clearlogbeban As System.Windows.Forms.Button
    Friend WithEvents btn_clearlogSolarCell As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConditionCharge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_savetoexcel As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox_autoOpen As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents btn_savetoexcel_beban As System.Windows.Forms.Button
    Friend WithEvents Tanggal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tegangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Arus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DayaSolarPanel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Relay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RStatusPanel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents expersenaki As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
