<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
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
        Me.FirefoxSubTabControl21 = New Mini_Scada_V0._9._1.FirefoxSubTabControl2()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PanelSetupServer = New System.Windows.Forms.Panel()
        Me.btn_resetToDefaultConf = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.check_box_token = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCustomLabel12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tbox_token = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tbox_downloaddb_beban = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tbox_crud_updateproteksi = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tbox_downloaddb_panel = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tbox_updatePBeban = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tbox_updatePPanel = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tbox_show_datapanel = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tbox_show_databeban = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_ServerAddress = New System.Windows.Forms.Panel()
        Me.lbl_server = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tbox_server = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tbox_portserver = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.FirefoxSubTabControl21.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.PanelSetupServer.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel_ServerAddress.SuspendLayout()
        Me.SuspendLayout()
        '
        'FirefoxSubTabControl21
        '
        Me.FirefoxSubTabControl21.Controls.Add(Me.TabPage1)
        Me.FirefoxSubTabControl21.Controls.Add(Me.TabPage2)
        Me.FirefoxSubTabControl21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FirefoxSubTabControl21.ItemSize = New System.Drawing.Size(250, 40)
        Me.FirefoxSubTabControl21.Location = New System.Drawing.Point(0, 0)
        Me.FirefoxSubTabControl21.Name = "FirefoxSubTabControl21"
        Me.FirefoxSubTabControl21.SelectedIndex = 0
        Me.FirefoxSubTabControl21.Size = New System.Drawing.Size(919, 639)
        Me.FirefoxSubTabControl21.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FirefoxSubTabControl21.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.PanelSetupServer)
        Me.TabPage1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(911, 591)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Setup Server"
        '
        'PanelSetupServer
        '
        Me.PanelSetupServer.AutoScroll = True
        Me.PanelSetupServer.Controls.Add(Me.btn_resetToDefaultConf)
        Me.PanelSetupServer.Controls.Add(Me.Panel6)
        Me.PanelSetupServer.Controls.Add(Me.Panel7)
        Me.PanelSetupServer.Controls.Add(Me.Panel4)
        Me.PanelSetupServer.Controls.Add(Me.Panel5)
        Me.PanelSetupServer.Controls.Add(Me.Panel2)
        Me.PanelSetupServer.Controls.Add(Me.Panel_ServerAddress)
        Me.PanelSetupServer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSetupServer.Location = New System.Drawing.Point(3, 3)
        Me.PanelSetupServer.Name = "PanelSetupServer"
        Me.PanelSetupServer.Size = New System.Drawing.Size(905, 585)
        Me.PanelSetupServer.TabIndex = 0
        '
        'btn_resetToDefaultConf
        '
        Me.btn_resetToDefaultConf.BackColor = System.Drawing.Color.Teal
        Me.btn_resetToDefaultConf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_resetToDefaultConf.FlatAppearance.BorderSize = 0
        Me.btn_resetToDefaultConf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_resetToDefaultConf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_resetToDefaultConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_resetToDefaultConf.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btn_resetToDefaultConf.ForeColor = System.Drawing.Color.White
        Me.btn_resetToDefaultConf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_resetToDefaultConf.Location = New System.Drawing.Point(720, 14)
        Me.btn_resetToDefaultConf.Name = "btn_resetToDefaultConf"
        Me.btn_resetToDefaultConf.Size = New System.Drawing.Size(167, 43)
        Me.btn_resetToDefaultConf.TabIndex = 20
        Me.btn_resetToDefaultConf.Text = "Reset to Default"
        Me.btn_resetToDefaultConf.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Teal
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Location = New System.Drawing.Point(389, 14)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(217, 34)
        Me.Panel6.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(46, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "User Authentication"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel7.Controls.Add(Me.check_box_token)
        Me.Panel7.Controls.Add(Me.BunifuCustomLabel12)
        Me.Panel7.Controls.Add(Me.tbox_token)
        Me.Panel7.Location = New System.Drawing.Point(372, 32)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(338, 168)
        Me.Panel7.TabIndex = 18
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(43, 107)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(89, 19)
        Me.BunifuCustomLabel5.TabIndex = 13
        Me.BunifuCustomLabel5.Text = "Show Token"
        '
        'check_box_token
        '
        Me.check_box_token.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.check_box_token.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.check_box_token.Checked = True
        Me.check_box_token.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.check_box_token.ForeColor = System.Drawing.Color.White
        Me.check_box_token.Location = New System.Drawing.Point(16, 107)
        Me.check_box_token.Margin = New System.Windows.Forms.Padding(4)
        Me.check_box_token.Name = "check_box_token"
        Me.check_box_token.Size = New System.Drawing.Size(20, 20)
        Me.check_box_token.TabIndex = 12
        '
        'BunifuCustomLabel12
        '
        Me.BunifuCustomLabel12.AutoSize = True
        Me.BunifuCustomLabel12.Location = New System.Drawing.Point(12, 23)
        Me.BunifuCustomLabel12.Name = "BunifuCustomLabel12"
        Me.BunifuCustomLabel12.Size = New System.Drawing.Size(48, 19)
        Me.BunifuCustomLabel12.TabIndex = 10
        Me.BunifuCustomLabel12.Text = "Token"
        '
        'tbox_token
        '
        Me.tbox_token.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbox_token.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbox_token.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbox_token.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbox_token.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_token.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tbox_token.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_token.HintForeColor = System.Drawing.Color.Empty
        Me.tbox_token.HintText = ""
        Me.tbox_token.isPassword = False
        Me.tbox_token.LineFocusedColor = System.Drawing.Color.Teal
        Me.tbox_token.LineIdleColor = System.Drawing.Color.Gray
        Me.tbox_token.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.tbox_token.LineThickness = 3
        Me.tbox_token.Location = New System.Drawing.Point(16, 46)
        Me.tbox_token.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_token.MaxLength = 32767
        Me.tbox_token.Name = "tbox_token"
        Me.tbox_token.Size = New System.Drawing.Size(298, 33)
        Me.tbox_token.TabIndex = 11
        Me.tbox_token.Text = "07d95caa0305eef83b47ec1fb6ccf69a"
        Me.tbox_token.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Teal
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(34, 206)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(217, 34)
        Me.Panel4.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(42, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Config Data SCADA"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.BunifuCustomLabel11)
        Me.Panel5.Controls.Add(Me.tbox_downloaddb_beban)
        Me.Panel5.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel5.Controls.Add(Me.BunifuCustomLabel10)
        Me.Panel5.Controls.Add(Me.tbox_crud_updateproteksi)
        Me.Panel5.Controls.Add(Me.tbox_downloaddb_panel)
        Me.Panel5.Controls.Add(Me.BunifuCustomLabel9)
        Me.Panel5.Controls.Add(Me.tbox_updatePBeban)
        Me.Panel5.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel5.Controls.Add(Me.tbox_updatePPanel)
        Me.Panel5.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel5.Controls.Add(Me.tbox_show_datapanel)
        Me.Panel5.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel5.Controls.Add(Me.tbox_show_databeban)
        Me.Panel5.Location = New System.Drawing.Point(17, 224)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(870, 345)
        Me.Panel5.TabIndex = 16
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(600, 97)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(247, 19)
        Me.BunifuCustomLabel11.TabIndex = 20
        Me.BunifuCustomLabel11.Text = "Download Log Database [ BEBAN ]"
        '
        'tbox_downloaddb_beban
        '
        Me.tbox_downloaddb_beban.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbox_downloaddb_beban.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbox_downloaddb_beban.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbox_downloaddb_beban.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_downloaddb_beban.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tbox_downloaddb_beban.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_downloaddb_beban.HintForeColor = System.Drawing.Color.Empty
        Me.tbox_downloaddb_beban.HintText = ""
        Me.tbox_downloaddb_beban.isPassword = False
        Me.tbox_downloaddb_beban.LineFocusedColor = System.Drawing.Color.Teal
        Me.tbox_downloaddb_beban.LineIdleColor = System.Drawing.Color.Gray
        Me.tbox_downloaddb_beban.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.tbox_downloaddb_beban.LineThickness = 3
        Me.tbox_downloaddb_beban.Location = New System.Drawing.Point(604, 120)
        Me.tbox_downloaddb_beban.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_downloaddb_beban.MaxLength = 32767
        Me.tbox_downloaddb_beban.Name = "tbox_downloaddb_beban"
        Me.tbox_downloaddb_beban.Size = New System.Drawing.Size(255, 33)
        Me.tbox_downloaddb_beban.TabIndex = 21
        Me.tbox_downloaddb_beban.Text = "/api/excel/export_databeban.php"
        Me.tbox_downloaddb_beban.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(12, 200)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(154, 19)
        Me.BunifuCustomLabel4.TabIndex = 8
        Me.BunifuCustomLabel4.Text = "Delete Log [ SERVER ]"
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(600, 20)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(245, 19)
        Me.BunifuCustomLabel10.TabIndex = 18
        Me.BunifuCustomLabel10.Text = "Download Log Database [ PANEL ]"
        '
        'tbox_crud_updateproteksi
        '
        Me.tbox_crud_updateproteksi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbox_crud_updateproteksi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbox_crud_updateproteksi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbox_crud_updateproteksi.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbox_crud_updateproteksi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_crud_updateproteksi.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tbox_crud_updateproteksi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_crud_updateproteksi.HintForeColor = System.Drawing.Color.Empty
        Me.tbox_crud_updateproteksi.HintText = ""
        Me.tbox_crud_updateproteksi.isPassword = False
        Me.tbox_crud_updateproteksi.LineFocusedColor = System.Drawing.Color.Teal
        Me.tbox_crud_updateproteksi.LineIdleColor = System.Drawing.Color.Gray
        Me.tbox_crud_updateproteksi.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.tbox_crud_updateproteksi.LineThickness = 3
        Me.tbox_crud_updateproteksi.Location = New System.Drawing.Point(16, 223)
        Me.tbox_crud_updateproteksi.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_crud_updateproteksi.MaxLength = 32767
        Me.tbox_crud_updateproteksi.Name = "tbox_crud_updateproteksi"
        Me.tbox_crud_updateproteksi.Size = New System.Drawing.Size(251, 33)
        Me.tbox_crud_updateproteksi.TabIndex = 9
        Me.tbox_crud_updateproteksi.Text = "/api/update/reset_record.php"
        Me.tbox_crud_updateproteksi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbox_downloaddb_panel
        '
        Me.tbox_downloaddb_panel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbox_downloaddb_panel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbox_downloaddb_panel.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbox_downloaddb_panel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_downloaddb_panel.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tbox_downloaddb_panel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_downloaddb_panel.HintForeColor = System.Drawing.Color.Empty
        Me.tbox_downloaddb_panel.HintText = ""
        Me.tbox_downloaddb_panel.isPassword = False
        Me.tbox_downloaddb_panel.LineFocusedColor = System.Drawing.Color.Teal
        Me.tbox_downloaddb_panel.LineIdleColor = System.Drawing.Color.Gray
        Me.tbox_downloaddb_panel.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.tbox_downloaddb_panel.LineThickness = 3
        Me.tbox_downloaddb_panel.Location = New System.Drawing.Point(604, 43)
        Me.tbox_downloaddb_panel.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_downloaddb_panel.MaxLength = 32767
        Me.tbox_downloaddb_panel.Name = "tbox_downloaddb_panel"
        Me.tbox_downloaddb_panel.Size = New System.Drawing.Size(255, 33)
        Me.tbox_downloaddb_panel.TabIndex = 19
        Me.tbox_downloaddb_panel.Text = "/api/excel/export_datapanel.php"
        Me.tbox_downloaddb_panel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(302, 97)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(193, 19)
        Me.BunifuCustomLabel9.TabIndex = 16
        Me.BunifuCustomLabel9.Text = "Edit Data Proteksi [ BEBAN ]"
        '
        'tbox_updatePBeban
        '
        Me.tbox_updatePBeban.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbox_updatePBeban.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbox_updatePBeban.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbox_updatePBeban.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_updatePBeban.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tbox_updatePBeban.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_updatePBeban.HintForeColor = System.Drawing.Color.Empty
        Me.tbox_updatePBeban.HintText = ""
        Me.tbox_updatePBeban.isPassword = False
        Me.tbox_updatePBeban.LineFocusedColor = System.Drawing.Color.Teal
        Me.tbox_updatePBeban.LineIdleColor = System.Drawing.Color.Gray
        Me.tbox_updatePBeban.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.tbox_updatePBeban.LineThickness = 3
        Me.tbox_updatePBeban.Location = New System.Drawing.Point(306, 120)
        Me.tbox_updatePBeban.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_updatePBeban.MaxLength = 32767
        Me.tbox_updatePBeban.Name = "tbox_updatePBeban"
        Me.tbox_updatePBeban.Size = New System.Drawing.Size(255, 33)
        Me.tbox_updatePBeban.TabIndex = 17
        Me.tbox_updatePBeban.Text = "/api/update/uconf_load.php"
        Me.tbox_updatePBeban.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(302, 20)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(191, 19)
        Me.BunifuCustomLabel8.TabIndex = 14
        Me.BunifuCustomLabel8.Text = "Edit Data Proteksi [ PANEL ]"
        '
        'tbox_updatePPanel
        '
        Me.tbox_updatePPanel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbox_updatePPanel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbox_updatePPanel.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbox_updatePPanel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_updatePPanel.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tbox_updatePPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_updatePPanel.HintForeColor = System.Drawing.Color.Empty
        Me.tbox_updatePPanel.HintText = ""
        Me.tbox_updatePPanel.isPassword = False
        Me.tbox_updatePPanel.LineFocusedColor = System.Drawing.Color.Teal
        Me.tbox_updatePPanel.LineIdleColor = System.Drawing.Color.Gray
        Me.tbox_updatePPanel.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.tbox_updatePPanel.LineThickness = 3
        Me.tbox_updatePPanel.Location = New System.Drawing.Point(306, 43)
        Me.tbox_updatePPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_updatePPanel.MaxLength = 32767
        Me.tbox_updatePPanel.Name = "tbox_updatePPanel"
        Me.tbox_updatePPanel.Size = New System.Drawing.Size(255, 33)
        Me.tbox_updatePPanel.TabIndex = 15
        Me.tbox_updatePPanel.Text = "/api/update/uconf_panel.php"
        Me.tbox_updatePPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(12, 20)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(187, 19)
        Me.BunifuCustomLabel2.TabIndex = 4
        Me.BunifuCustomLabel2.Text = "File Data Record [ PANEL ]"
        '
        'tbox_show_datapanel
        '
        Me.tbox_show_datapanel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbox_show_datapanel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbox_show_datapanel.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbox_show_datapanel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_show_datapanel.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tbox_show_datapanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_show_datapanel.HintForeColor = System.Drawing.Color.Empty
        Me.tbox_show_datapanel.HintText = ""
        Me.tbox_show_datapanel.isPassword = False
        Me.tbox_show_datapanel.LineFocusedColor = System.Drawing.Color.Teal
        Me.tbox_show_datapanel.LineIdleColor = System.Drawing.Color.Gray
        Me.tbox_show_datapanel.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.tbox_show_datapanel.LineThickness = 3
        Me.tbox_show_datapanel.Location = New System.Drawing.Point(16, 43)
        Me.tbox_show_datapanel.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_show_datapanel.MaxLength = 32767
        Me.tbox_show_datapanel.Name = "tbox_show_datapanel"
        Me.tbox_show_datapanel.Size = New System.Drawing.Size(255, 33)
        Me.tbox_show_datapanel.TabIndex = 5
        Me.tbox_show_datapanel.Text = "/api/vb/datapanel.php"
        Me.tbox_show_datapanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(8, 97)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(189, 19)
        Me.BunifuCustomLabel3.TabIndex = 6
        Me.BunifuCustomLabel3.Text = "File Data Record [ BEBAN ]"
        '
        'tbox_show_databeban
        '
        Me.tbox_show_databeban.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbox_show_databeban.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbox_show_databeban.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbox_show_databeban.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_show_databeban.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tbox_show_databeban.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_show_databeban.HintForeColor = System.Drawing.Color.Empty
        Me.tbox_show_databeban.HintText = ""
        Me.tbox_show_databeban.isPassword = False
        Me.tbox_show_databeban.LineFocusedColor = System.Drawing.Color.Teal
        Me.tbox_show_databeban.LineIdleColor = System.Drawing.Color.Gray
        Me.tbox_show_databeban.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.tbox_show_databeban.LineThickness = 3
        Me.tbox_show_databeban.Location = New System.Drawing.Point(12, 120)
        Me.tbox_show_databeban.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_show_databeban.MaxLength = 32767
        Me.tbox_show_databeban.Name = "tbox_show_databeban"
        Me.tbox_show_databeban.Size = New System.Drawing.Size(255, 33)
        Me.tbox_show_databeban.TabIndex = 7
        Me.tbox_show_databeban.Text = "/api/vb/dataload.php"
        Me.tbox_show_databeban.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(34, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(192, 34)
        Me.Panel2.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(49, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server Address"
        '
        'Panel_ServerAddress
        '
        Me.Panel_ServerAddress.BackColor = System.Drawing.Color.White
        Me.Panel_ServerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_ServerAddress.Controls.Add(Me.lbl_server)
        Me.Panel_ServerAddress.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel_ServerAddress.Controls.Add(Me.tbox_server)
        Me.Panel_ServerAddress.Controls.Add(Me.tbox_portserver)
        Me.Panel_ServerAddress.Location = New System.Drawing.Point(17, 32)
        Me.Panel_ServerAddress.Name = "Panel_ServerAddress"
        Me.Panel_ServerAddress.Size = New System.Drawing.Size(338, 168)
        Me.Panel_ServerAddress.TabIndex = 14
        '
        'lbl_server
        '
        Me.lbl_server.AutoSize = True
        Me.lbl_server.BackColor = System.Drawing.Color.Transparent
        Me.lbl_server.Location = New System.Drawing.Point(12, 23)
        Me.lbl_server.Name = "lbl_server"
        Me.lbl_server.Size = New System.Drawing.Size(104, 19)
        Me.lbl_server.TabIndex = 1
        Me.lbl_server.Text = "Alamat Server"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(12, 93)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(80, 19)
        Me.BunifuCustomLabel1.TabIndex = 2
        Me.BunifuCustomLabel1.Text = "Port Server"
        '
        'tbox_server
        '
        Me.tbox_server.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbox_server.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbox_server.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbox_server.BackColor = System.Drawing.Color.White
        Me.tbox_server.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbox_server.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_server.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tbox_server.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_server.HintForeColor = System.Drawing.Color.Empty
        Me.tbox_server.HintText = ""
        Me.tbox_server.isPassword = False
        Me.tbox_server.LineFocusedColor = System.Drawing.Color.Teal
        Me.tbox_server.LineIdleColor = System.Drawing.Color.Gray
        Me.tbox_server.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.tbox_server.LineThickness = 3
        Me.tbox_server.Location = New System.Drawing.Point(16, 46)
        Me.tbox_server.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_server.MaxLength = 32767
        Me.tbox_server.Name = "tbox_server"
        Me.tbox_server.Size = New System.Drawing.Size(306, 33)
        Me.tbox_server.TabIndex = 0
        Me.tbox_server.Text = "167.71.214.209"
        Me.tbox_server.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbox_portserver
        '
        Me.tbox_portserver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbox_portserver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbox_portserver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbox_portserver.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbox_portserver.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_portserver.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tbox_portserver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_portserver.HintForeColor = System.Drawing.Color.Empty
        Me.tbox_portserver.HintText = ""
        Me.tbox_portserver.isPassword = False
        Me.tbox_portserver.LineFocusedColor = System.Drawing.Color.Teal
        Me.tbox_portserver.LineIdleColor = System.Drawing.Color.Gray
        Me.tbox_portserver.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.tbox_portserver.LineThickness = 3
        Me.tbox_portserver.Location = New System.Drawing.Point(16, 116)
        Me.tbox_portserver.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_portserver.MaxLength = 32767
        Me.tbox_portserver.Name = "tbox_portserver"
        Me.tbox_portserver.Size = New System.Drawing.Size(306, 33)
        Me.tbox_portserver.TabIndex = 3
        Me.tbox_portserver.Text = "80"
        Me.tbox_portserver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.TabPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(911, 591)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Setup Application"
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(919, 639)
        Me.Controls.Add(Me.FirefoxSubTabControl21)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmSetting"
        Me.Text = "frmSettingvb"
        Me.FirefoxSubTabControl21.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.PanelSetupServer.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel_ServerAddress.ResumeLayout(False)
        Me.Panel_ServerAddress.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FirefoxSubTabControl21 As Mini_Scada_V0._9._1.FirefoxSubTabControl2
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents PanelSetupServer As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbox_crud_updateproteksi As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbox_show_datapanel As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbox_show_databeban As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel_ServerAddress As System.Windows.Forms.Panel
    Friend WithEvents lbl_server As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbox_server As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tbox_portserver As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbox_updatePPanel As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbox_updatePBeban As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbox_downloaddb_panel As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbox_downloaddb_beban As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btn_resetToDefaultConf As System.Windows.Forms.Button
    Friend WithEvents BunifuCustomLabel12 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbox_token As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents check_box_token As Bunifu.Framework.UI.BunifuCheckbox
End Class
