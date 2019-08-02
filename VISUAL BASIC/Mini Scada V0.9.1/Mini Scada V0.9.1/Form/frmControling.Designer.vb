<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControling
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
        Me.components = New System.ComponentModel.Container()
        Me.btn_realtime = New System.Windows.Forms.Button()
        Me.btn_cekdata1 = New System.Windows.Forms.Button()
        Me.Tim_Realtime = New System.Windows.Forms.Timer(Me.components)
        Me.BW_RealTime = New System.ComponentModel.BackgroundWorker()
        Me.BW_Datagrid_Solar = New System.ComponentModel.BackgroundWorker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_apply = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbox_speeddata = New Mini_Scada_V0._9._1.FirefoxTextbox()
        Me.chkbox_recordlog = New Mini_Scada_V0._9._1.FirefoxCheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_timerB = New System.Windows.Forms.Label()
        Me.Cbox_ModeAlat_Panel = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbox_settimeb = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lbl_timerA = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_setPPANEL = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbox_settimea = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbox_setPArusPanel = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbox_setPTegPanel = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Cbox_ModeAlat_Load = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btn_setPBEBAN = New System.Windows.Forms.Button()
        Me.tbox_setPTegBeban = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbox_setPArusBeban = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btn_clearLogDB = New System.Windows.Forms.Button()
        Me.btn_dbtozero = New System.Windows.Forms.Button()
        Me.btn_dbresetPdefault = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btn_downloaddb_panel = New System.Windows.Forms.Button()
        Me.btn_downloaddb_beban = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_realtime
        '
        Me.btn_realtime.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_realtime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_realtime.FlatAppearance.BorderSize = 0
        Me.btn_realtime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_realtime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_realtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_realtime.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btn_realtime.ForeColor = System.Drawing.Color.White
        Me.btn_realtime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_realtime.Location = New System.Drawing.Point(16, 21)
        Me.btn_realtime.Name = "btn_realtime"
        Me.btn_realtime.Size = New System.Drawing.Size(181, 62)
        Me.btn_realtime.TabIndex = 1
        Me.btn_realtime.Text = "Mode Real Time"
        Me.btn_realtime.UseVisualStyleBackColor = False
        '
        'btn_cekdata1
        '
        Me.btn_cekdata1.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_cekdata1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cekdata1.FlatAppearance.BorderSize = 0
        Me.btn_cekdata1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_cekdata1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_cekdata1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cekdata1.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btn_cekdata1.ForeColor = System.Drawing.Color.White
        Me.btn_cekdata1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cekdata1.Location = New System.Drawing.Point(229, 21)
        Me.btn_cekdata1.Name = "btn_cekdata1"
        Me.btn_cekdata1.Size = New System.Drawing.Size(181, 62)
        Me.btn_cekdata1.TabIndex = 2
        Me.btn_cekdata1.Text = "Check Data"
        Me.btn_cekdata1.UseVisualStyleBackColor = False
        '
        'Tim_Realtime
        '
        '
        'BW_RealTime
        '
        Me.BW_RealTime.WorkerReportsProgress = True
        Me.BW_RealTime.WorkerSupportsCancellation = True
        '
        'BW_Datagrid_Solar
        '
        Me.BW_Datagrid_Solar.WorkerReportsProgress = True
        Me.BW_Datagrid_Solar.WorkerSupportsCancellation = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(492, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(192, 34)
        Me.Panel2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Control Panel"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_apply)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.tbox_speeddata)
        Me.Panel1.Controls.Add(Me.btn_realtime)
        Me.Panel1.Controls.Add(Me.chkbox_recordlog)
        Me.Panel1.Controls.Add(Me.btn_cekdata1)
        Me.Panel1.Location = New System.Drawing.Point(475, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 216)
        Me.Panel1.TabIndex = 4
        '
        'btn_apply
        '
        Me.btn_apply.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_apply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_apply.FlatAppearance.BorderSize = 0
        Me.btn_apply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_apply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_apply.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btn_apply.ForeColor = System.Drawing.Color.White
        Me.btn_apply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_apply.Location = New System.Drawing.Point(307, 128)
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(103, 45)
        Me.btn_apply.TabIndex = 7
        Me.btn_apply.Text = "Apply"
        Me.btn_apply.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(15, 144)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(99, 16)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Speed Get Data"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(255, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(22, 16)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "ms"
        '
        'tbox_speeddata
        '
        Me.tbox_speeddata.EnabledCalc = True
        Me.tbox_speeddata.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.tbox_speeddata.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.tbox_speeddata.Location = New System.Drawing.Point(120, 136)
        Me.tbox_speeddata.MaxLength = 32767
        Me.tbox_speeddata.MultiLine = False
        Me.tbox_speeddata.Name = "tbox_speeddata"
        Me.tbox_speeddata.ReadOnly = False
        Me.tbox_speeddata.Size = New System.Drawing.Size(129, 29)
        Me.tbox_speeddata.TabIndex = 4
        Me.tbox_speeddata.Text = "3000"
        Me.tbox_speeddata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbox_speeddata.UseSystemPasswordChar = False
        '
        'chkbox_recordlog
        '
        Me.chkbox_recordlog.Bold = False
        Me.chkbox_recordlog.Checked = True
        Me.chkbox_recordlog.EnabledCalc = True
        Me.chkbox_recordlog.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.chkbox_recordlog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.chkbox_recordlog.Location = New System.Drawing.Point(16, 98)
        Me.chkbox_recordlog.Name = "chkbox_recordlog"
        Me.chkbox_recordlog.Size = New System.Drawing.Size(160, 27)
        Me.chkbox_recordlog.TabIndex = 3
        Me.chkbox_recordlog.Text = "Log Excel"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(30, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(192, 34)
        Me.Panel3.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Setting Configurasi Panel"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lbl_timerB)
        Me.Panel4.Controls.Add(Me.Cbox_ModeAlat_Panel)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.tbox_settimeb)
        Me.Panel4.Controls.Add(Me.lbl_timerA)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.btn_setPPANEL)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.tbox_settimea)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.tbox_setPArusPanel)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.tbox_setPTegPanel)
        Me.Panel4.Location = New System.Drawing.Point(13, 30)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(448, 322)
        Me.Panel4.TabIndex = 6
        '
        'lbl_timerB
        '
        Me.lbl_timerB.AutoSize = True
        Me.lbl_timerB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_timerB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_timerB.Location = New System.Drawing.Point(193, 253)
        Me.lbl_timerB.Name = "lbl_timerB"
        Me.lbl_timerB.Size = New System.Drawing.Size(15, 21)
        Me.lbl_timerB.TabIndex = 17
        Me.lbl_timerB.Text = "-"
        '
        'Cbox_ModeAlat_Panel
        '
        Me.Cbox_ModeAlat_Panel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbox_ModeAlat_Panel.FormattingEnabled = True
        Me.Cbox_ModeAlat_Panel.Items.AddRange(New Object() {"Auto", "On", "Off"})
        Me.Cbox_ModeAlat_Panel.Location = New System.Drawing.Point(121, 144)
        Me.Cbox_ModeAlat_Panel.Name = "Cbox_ModeAlat_Panel"
        Me.Cbox_ModeAlat_Panel.Size = New System.Drawing.Size(113, 24)
        Me.Cbox_ModeAlat_Panel.TabIndex = 24
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(12, 253)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(132, 21)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Timer Jam Akhir"
        '
        'tbox_settimeb
        '
        Me.tbox_settimeb.BorderColorFocused = System.Drawing.Color.DarkGreen
        Me.tbox_settimeb.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_settimeb.BorderColorMouseHover = System.Drawing.Color.DarkGreen
        Me.tbox_settimeb.BorderThickness = 3
        Me.tbox_settimeb.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbox_settimeb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_settimeb.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tbox_settimeb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_settimeb.isPassword = False
        Me.tbox_settimeb.Location = New System.Drawing.Point(267, 241)
        Me.tbox_settimeb.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_settimeb.MaxLength = 32767
        Me.tbox_settimeb.Name = "tbox_settimeb"
        Me.tbox_settimeb.Size = New System.Drawing.Size(163, 44)
        Me.tbox_settimeb.TabIndex = 12
        Me.tbox_settimeb.Text = "15"
        Me.tbox_settimeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_timerA
        '
        Me.lbl_timerA.AutoSize = True
        Me.lbl_timerA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_timerA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_timerA.Location = New System.Drawing.Point(193, 194)
        Me.lbl_timerA.Name = "lbl_timerA"
        Me.lbl_timerA.Size = New System.Drawing.Size(15, 21)
        Me.lbl_timerA.TabIndex = 16
        Me.lbl_timerA.Text = "-"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(12, 142)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 21)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Mode Alat"
        '
        'btn_setPPANEL
        '
        Me.btn_setPPANEL.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_setPPANEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_setPPANEL.FlatAppearance.BorderSize = 0
        Me.btn_setPPANEL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_setPPANEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_setPPANEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_setPPANEL.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btn_setPPANEL.ForeColor = System.Drawing.Color.White
        Me.btn_setPPANEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_setPPANEL.Location = New System.Drawing.Point(301, 33)
        Me.btn_setPPANEL.Name = "btn_setPPANEL"
        Me.btn_setPPANEL.Size = New System.Drawing.Size(129, 132)
        Me.btn_setPPANEL.TabIndex = 10
        Me.btn_setPPANEL.Text = "Set Config Panel"
        Me.btn_setPPANEL.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(12, 194)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(135, 21)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Timer Jam Mulai"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(241, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 21)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "mA"
        '
        'tbox_settimea
        '
        Me.tbox_settimea.BorderColorFocused = System.Drawing.Color.DarkGreen
        Me.tbox_settimea.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_settimea.BorderColorMouseHover = System.Drawing.Color.DarkGreen
        Me.tbox_settimea.BorderThickness = 3
        Me.tbox_settimea.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbox_settimea.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_settimea.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tbox_settimea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_settimea.isPassword = False
        Me.tbox_settimea.Location = New System.Drawing.Point(267, 184)
        Me.tbox_settimea.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_settimea.MaxLength = 32767
        Me.tbox_settimea.Name = "tbox_settimea"
        Me.tbox_settimea.Size = New System.Drawing.Size(163, 44)
        Me.tbox_settimea.TabIndex = 11
        Me.tbox_settimea.Text = "10"
        Me.tbox_settimea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(241, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 21)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "VDC"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(12, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Arus"
        '
        'tbox_setPArusPanel
        '
        Me.tbox_setPArusPanel.BorderColorFocused = System.Drawing.Color.DarkGreen
        Me.tbox_setPArusPanel.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_setPArusPanel.BorderColorMouseHover = System.Drawing.Color.DarkGreen
        Me.tbox_setPArusPanel.BorderThickness = 3
        Me.tbox_setPArusPanel.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbox_setPArusPanel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_setPArusPanel.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tbox_setPArusPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_setPArusPanel.isPassword = False
        Me.tbox_setPArusPanel.Location = New System.Drawing.Point(121, 82)
        Me.tbox_setPArusPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_setPArusPanel.MaxLength = 32767
        Me.tbox_setPArusPanel.Name = "tbox_setPArusPanel"
        Me.tbox_setPArusPanel.Size = New System.Drawing.Size(113, 44)
        Me.tbox_setPArusPanel.TabIndex = 13
        Me.tbox_setPArusPanel.Text = "5000"
        Me.tbox_setPArusPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(12, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tegangan"
        '
        'tbox_setPTegPanel
        '
        Me.tbox_setPTegPanel.BorderColorFocused = System.Drawing.Color.DarkGreen
        Me.tbox_setPTegPanel.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_setPTegPanel.BorderColorMouseHover = System.Drawing.Color.DarkGreen
        Me.tbox_setPTegPanel.BorderThickness = 3
        Me.tbox_setPTegPanel.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbox_setPTegPanel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_setPTegPanel.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tbox_setPTegPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_setPTegPanel.isPassword = False
        Me.tbox_setPTegPanel.Location = New System.Drawing.Point(121, 32)
        Me.tbox_setPTegPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_setPTegPanel.MaxLength = 32767
        Me.tbox_setPTegPanel.Name = "tbox_setPTegPanel"
        Me.tbox_setPTegPanel.Size = New System.Drawing.Size(113, 44)
        Me.tbox_setPTegPanel.TabIndex = 10
        Me.tbox_setPTegPanel.Text = "14.5"
        Me.tbox_setPTegPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Maroon
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Location = New System.Drawing.Point(30, 368)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(192, 34)
        Me.Panel5.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Setting Configurasi Beban"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Cbox_ModeAlat_Load)
        Me.Panel6.Controls.Add(Me.Label18)
        Me.Panel6.Controls.Add(Me.btn_setPBEBAN)
        Me.Panel6.Controls.Add(Me.tbox_setPTegBeban)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.tbox_setPArusBeban)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Location = New System.Drawing.Point(13, 386)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(448, 188)
        Me.Panel6.TabIndex = 8
        '
        'Cbox_ModeAlat_Load
        '
        Me.Cbox_ModeAlat_Load.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbox_ModeAlat_Load.FormattingEnabled = True
        Me.Cbox_ModeAlat_Load.Items.AddRange(New Object() {"On", "Off"})
        Me.Cbox_ModeAlat_Load.Location = New System.Drawing.Point(121, 142)
        Me.Cbox_ModeAlat_Load.Name = "Cbox_ModeAlat_Load"
        Me.Cbox_ModeAlat_Load.Size = New System.Drawing.Size(121, 24)
        Me.Cbox_ModeAlat_Load.TabIndex = 23
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(12, 143)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 21)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Mode Alat"
        '
        'btn_setPBEBAN
        '
        Me.btn_setPBEBAN.BackColor = System.Drawing.Color.Maroon
        Me.btn_setPBEBAN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_setPBEBAN.FlatAppearance.BorderSize = 0
        Me.btn_setPBEBAN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_setPBEBAN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_setPBEBAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_setPBEBAN.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btn_setPBEBAN.ForeColor = System.Drawing.Color.White
        Me.btn_setPBEBAN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_setPBEBAN.Location = New System.Drawing.Point(301, 34)
        Me.btn_setPBEBAN.Name = "btn_setPBEBAN"
        Me.btn_setPBEBAN.Size = New System.Drawing.Size(129, 132)
        Me.btn_setPBEBAN.TabIndex = 15
        Me.btn_setPBEBAN.Text = "Set Config Beban"
        Me.btn_setPBEBAN.UseVisualStyleBackColor = False
        '
        'tbox_setPTegBeban
        '
        Me.tbox_setPTegBeban.BorderColorFocused = System.Drawing.Color.Maroon
        Me.tbox_setPTegBeban.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_setPTegBeban.BorderColorMouseHover = System.Drawing.Color.Maroon
        Me.tbox_setPTegBeban.BorderThickness = 3
        Me.tbox_setPTegBeban.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbox_setPTegBeban.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_setPTegBeban.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tbox_setPTegBeban.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_setPTegBeban.isPassword = False
        Me.tbox_setPTegBeban.Location = New System.Drawing.Point(121, 32)
        Me.tbox_setPTegBeban.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_setPTegBeban.MaxLength = 32767
        Me.tbox_setPTegBeban.Name = "tbox_setPTegBeban"
        Me.tbox_setPTegBeban.Size = New System.Drawing.Size(113, 44)
        Me.tbox_setPTegBeban.TabIndex = 17
        Me.tbox_setPTegBeban.Text = "240"
        Me.tbox_setPTegBeban.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(241, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 21)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "mA"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(12, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 21)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Tegangan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(241, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 21)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "VAC"
        '
        'tbox_setPArusBeban
        '
        Me.tbox_setPArusBeban.BorderColorFocused = System.Drawing.Color.Maroon
        Me.tbox_setPArusBeban.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_setPArusBeban.BorderColorMouseHover = System.Drawing.Color.Maroon
        Me.tbox_setPArusBeban.BorderThickness = 3
        Me.tbox_setPArusBeban.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbox_setPArusBeban.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_setPArusBeban.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tbox_setPArusBeban.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_setPArusBeban.isPassword = False
        Me.tbox_setPArusBeban.Location = New System.Drawing.Point(121, 82)
        Me.tbox_setPArusBeban.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_setPArusBeban.MaxLength = 32767
        Me.tbox_setPArusBeban.Name = "tbox_setPArusBeban"
        Me.tbox_setPArusBeban.Size = New System.Drawing.Size(113, 44)
        Me.tbox_setPArusBeban.TabIndex = 20
        Me.tbox_setPArusBeban.Text = "650"
        Me.tbox_setPArusBeban.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(12, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 21)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Arus"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkRed
        Me.Panel7.Controls.Add(Me.Label12)
        Me.Panel7.Location = New System.Drawing.Point(493, 431)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(182, 34)
        Me.Panel7.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(39, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Reset Database"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.btn_clearLogDB)
        Me.Panel8.Controls.Add(Me.btn_dbtozero)
        Me.Panel8.Controls.Add(Me.btn_dbresetPdefault)
        Me.Panel8.Location = New System.Drawing.Point(476, 448)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(434, 189)
        Me.Panel8.TabIndex = 10
        '
        'btn_clearLogDB
        '
        Me.btn_clearLogDB.BackColor = System.Drawing.Color.DarkRed
        Me.btn_clearLogDB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clearLogDB.FlatAppearance.BorderSize = 0
        Me.btn_clearLogDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_clearLogDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_clearLogDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clearLogDB.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btn_clearLogDB.ForeColor = System.Drawing.Color.White
        Me.btn_clearLogDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clearLogDB.Location = New System.Drawing.Point(229, 113)
        Me.btn_clearLogDB.Name = "btn_clearLogDB"
        Me.btn_clearLogDB.Size = New System.Drawing.Size(182, 50)
        Me.btn_clearLogDB.TabIndex = 6
        Me.btn_clearLogDB.Text = "Clear Log Database Server"
        Me.btn_clearLogDB.UseVisualStyleBackColor = False
        '
        'btn_dbtozero
        '
        Me.btn_dbtozero.BackColor = System.Drawing.Color.DarkRed
        Me.btn_dbtozero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_dbtozero.FlatAppearance.BorderSize = 0
        Me.btn_dbtozero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_dbtozero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_dbtozero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dbtozero.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btn_dbtozero.ForeColor = System.Drawing.Color.White
        Me.btn_dbtozero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dbtozero.Location = New System.Drawing.Point(17, 113)
        Me.btn_dbtozero.Name = "btn_dbtozero"
        Me.btn_dbtozero.Size = New System.Drawing.Size(182, 50)
        Me.btn_dbtozero.TabIndex = 5
        Me.btn_dbtozero.Text = "Reset Database"
        Me.btn_dbtozero.UseVisualStyleBackColor = False
        '
        'btn_dbresetPdefault
        '
        Me.btn_dbresetPdefault.BackColor = System.Drawing.Color.DarkRed
        Me.btn_dbresetPdefault.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_dbresetPdefault.FlatAppearance.BorderSize = 0
        Me.btn_dbresetPdefault.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_dbresetPdefault.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_dbresetPdefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dbresetPdefault.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btn_dbresetPdefault.ForeColor = System.Drawing.Color.White
        Me.btn_dbresetPdefault.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dbresetPdefault.Location = New System.Drawing.Point(16, 44)
        Me.btn_dbresetPdefault.Name = "btn_dbresetPdefault"
        Me.btn_dbresetPdefault.Size = New System.Drawing.Size(394, 50)
        Me.btn_dbresetPdefault.TabIndex = 4
        Me.btn_dbresetPdefault.Text = "Reset Proteksi to Default"
        Me.btn_dbresetPdefault.UseVisualStyleBackColor = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.btn_downloaddb_panel)
        Me.Panel9.Controls.Add(Me.btn_downloaddb_beban)
        Me.Panel9.Location = New System.Drawing.Point(475, 277)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(430, 144)
        Me.Panel9.TabIndex = 12
        '
        'btn_downloaddb_panel
        '
        Me.btn_downloaddb_panel.BackColor = System.Drawing.Color.Indigo
        Me.btn_downloaddb_panel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_downloaddb_panel.FlatAppearance.BorderSize = 0
        Me.btn_downloaddb_panel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_downloaddb_panel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_downloaddb_panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_downloaddb_panel.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btn_downloaddb_panel.ForeColor = System.Drawing.Color.White
        Me.btn_downloaddb_panel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_downloaddb_panel.Location = New System.Drawing.Point(16, 43)
        Me.btn_downloaddb_panel.Name = "btn_downloaddb_panel"
        Me.btn_downloaddb_panel.Size = New System.Drawing.Size(182, 62)
        Me.btn_downloaddb_panel.TabIndex = 1
        Me.btn_downloaddb_panel.Text = "Log DB Panel"
        Me.btn_downloaddb_panel.UseVisualStyleBackColor = False
        '
        'btn_downloaddb_beban
        '
        Me.btn_downloaddb_beban.BackColor = System.Drawing.Color.Indigo
        Me.btn_downloaddb_beban.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_downloaddb_beban.FlatAppearance.BorderSize = 0
        Me.btn_downloaddb_beban.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_downloaddb_beban.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_downloaddb_beban.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_downloaddb_beban.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btn_downloaddb_beban.ForeColor = System.Drawing.Color.White
        Me.btn_downloaddb_beban.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_downloaddb_beban.Location = New System.Drawing.Point(228, 43)
        Me.btn_downloaddb_beban.Name = "btn_downloaddb_beban"
        Me.btn_downloaddb_beban.Size = New System.Drawing.Size(182, 62)
        Me.btn_downloaddb_beban.TabIndex = 2
        Me.btn_downloaddb_beban.Text = "Log DB Beban"
        Me.btn_downloaddb_beban.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Indigo
        Me.Panel10.Controls.Add(Me.Label13)
        Me.Panel10.Location = New System.Drawing.Point(492, 259)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(192, 34)
        Me.Panel10.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(35, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 17)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Download Log DB"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "xls"
        '
        'frmControling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(919, 639)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmControling"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_realtime As System.Windows.Forms.Button
    Friend WithEvents btn_cekdata1 As System.Windows.Forms.Button
    Friend WithEvents Tim_Realtime As System.Windows.Forms.Timer
    Friend WithEvents BW_RealTime As System.ComponentModel.BackgroundWorker
    Friend WithEvents chkbox_recordlog As Mini_Scada_V0._9._1.FirefoxCheckBox
    Friend WithEvents BW_Datagrid_Solar As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents tbox_setPTegPanel As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbox_setPArusPanel As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btn_setPPANEL As System.Windows.Forms.Button
    Friend WithEvents btn_setPBEBAN As System.Windows.Forms.Button
    Friend WithEvents tbox_setPTegBeban As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbox_setPArusBeban As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents btn_dbresetPdefault As System.Windows.Forms.Button
    Friend WithEvents btn_dbtozero As System.Windows.Forms.Button
    Friend WithEvents btn_clearLogDB As System.Windows.Forms.Button
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents btn_downloaddb_panel As System.Windows.Forms.Button
    Friend WithEvents btn_downloaddb_beban As System.Windows.Forms.Button
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbox_settimeb As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tbox_settimea As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbl_timerB As System.Windows.Forms.Label
    Friend WithEvents lbl_timerA As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Cbox_ModeAlat_Load As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Cbox_ModeAlat_Panel As System.Windows.Forms.ComboBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbox_speeddata As Mini_Scada_V0._9._1.FirefoxTextbox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btn_apply As System.Windows.Forms.Button
End Class
