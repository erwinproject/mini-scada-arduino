<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUtama))
        Me.SlideClose = New System.Windows.Forms.Timer(Me.components)
        Me.tim_jamday = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_setting = New System.Windows.Forms.Button()
        Me.btn_info = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_calculated = New System.Windows.Forms.Button()
        Me.btn_Monitoring = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_log = New System.Windows.Forms.Button()
        Me.btn_Controling = New System.Windows.Forms.Button()
        Me.panel_control = New System.Windows.Forms.Panel()
        Me.panel_monitor = New System.Windows.Forms.Panel()
        Me.Panel_title = New System.Windows.Forms.Panel()
        Me.panelSlideMenu = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_jam = New System.Windows.Forms.Label()
        Me.lbl_day = New System.Windows.Forms.Label()
        Me.checkform = New System.Windows.Forms.Timer(Me.components)
        Me.ShowFormPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_titleku = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panel_control.SuspendLayout()
        Me.panel_monitor.SuspendLayout()
        Me.Panel_title.SuspendLayout()
        Me.panelSlideMenu.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tim_jamday
        '
        Me.tim_jamday.Enabled = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(146, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "V 0.9.1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MINI SCADA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(71, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 37)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ARDUINO"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.btn_setting)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 376)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(265, 62)
        Me.Panel4.TabIndex = 10
        '
        'btn_setting
        '
        Me.btn_setting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_setting.FlatAppearance.BorderSize = 0
        Me.btn_setting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_setting.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btn_setting.ForeColor = System.Drawing.Color.White
        Me.btn_setting.Image = CType(resources.GetObject("btn_setting.Image"), System.Drawing.Image)
        Me.btn_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_setting.Location = New System.Drawing.Point(3, 0)
        Me.btn_setting.Name = "btn_setting"
        Me.btn_setting.Size = New System.Drawing.Size(262, 62)
        Me.btn_setting.TabIndex = 0
        Me.btn_setting.Text = "Setting"
        Me.btn_setting.UseVisualStyleBackColor = True
        '
        'btn_info
        '
        Me.btn_info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_info.FlatAppearance.BorderSize = 0
        Me.btn_info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_info.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btn_info.ForeColor = System.Drawing.Color.White
        Me.btn_info.Image = CType(resources.GetObject("btn_info.Image"), System.Drawing.Image)
        Me.btn_info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_info.Location = New System.Drawing.Point(3, 0)
        Me.btn_info.Name = "btn_info"
        Me.btn_info.Size = New System.Drawing.Size(262, 62)
        Me.btn_info.TabIndex = 0
        Me.btn_info.Text = "Info"
        Me.btn_info.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.btn_calculated)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 314)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(265, 62)
        Me.Panel3.TabIndex = 9
        '
        'btn_calculated
        '
        Me.btn_calculated.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_calculated.FlatAppearance.BorderSize = 0
        Me.btn_calculated.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_calculated.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_calculated.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_calculated.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btn_calculated.ForeColor = System.Drawing.Color.White
        Me.btn_calculated.Image = CType(resources.GetObject("btn_calculated.Image"), System.Drawing.Image)
        Me.btn_calculated.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_calculated.Location = New System.Drawing.Point(3, 0)
        Me.btn_calculated.Name = "btn_calculated"
        Me.btn_calculated.Size = New System.Drawing.Size(262, 62)
        Me.btn_calculated.TabIndex = 1
        Me.btn_calculated.Text = "Calculated"
        Me.btn_calculated.UseVisualStyleBackColor = True
        '
        'btn_Monitoring
        '
        Me.btn_Monitoring.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Monitoring.FlatAppearance.BorderSize = 0
        Me.btn_Monitoring.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_Monitoring.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_Monitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Monitoring.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btn_Monitoring.ForeColor = System.Drawing.Color.White
        Me.btn_Monitoring.Image = CType(resources.GetObject("btn_Monitoring.Image"), System.Drawing.Image)
        Me.btn_Monitoring.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Monitoring.Location = New System.Drawing.Point(3, 0)
        Me.btn_Monitoring.Name = "btn_Monitoring"
        Me.btn_Monitoring.Size = New System.Drawing.Size(262, 62)
        Me.btn_Monitoring.TabIndex = 0
        Me.btn_Monitoring.Text = "Monitoring"
        Me.btn_Monitoring.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btn_log)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 252)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(265, 62)
        Me.Panel2.TabIndex = 8
        '
        'btn_log
        '
        Me.btn_log.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_log.FlatAppearance.BorderSize = 0
        Me.btn_log.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_log.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_log.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btn_log.ForeColor = System.Drawing.Color.White
        Me.btn_log.Image = CType(resources.GetObject("btn_log.Image"), System.Drawing.Image)
        Me.btn_log.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_log.Location = New System.Drawing.Point(3, 0)
        Me.btn_log.Name = "btn_log"
        Me.btn_log.Size = New System.Drawing.Size(262, 62)
        Me.btn_log.TabIndex = 0
        Me.btn_log.Text = "Log"
        Me.btn_log.UseVisualStyleBackColor = True
        '
        'btn_Controling
        '
        Me.btn_Controling.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Controling.FlatAppearance.BorderSize = 0
        Me.btn_Controling.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_Controling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_Controling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Controling.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btn_Controling.ForeColor = System.Drawing.Color.White
        Me.btn_Controling.Image = CType(resources.GetObject("btn_Controling.Image"), System.Drawing.Image)
        Me.btn_Controling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Controling.Location = New System.Drawing.Point(3, 0)
        Me.btn_Controling.Name = "btn_Controling"
        Me.btn_Controling.Size = New System.Drawing.Size(262, 62)
        Me.btn_Controling.TabIndex = 0
        Me.btn_Controling.Text = "Controling"
        Me.btn_Controling.UseVisualStyleBackColor = True
        '
        'panel_control
        '
        Me.panel_control.BackColor = System.Drawing.Color.Transparent
        Me.panel_control.Controls.Add(Me.btn_Controling)
        Me.panel_control.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_control.Location = New System.Drawing.Point(0, 190)
        Me.panel_control.Name = "panel_control"
        Me.panel_control.Size = New System.Drawing.Size(265, 62)
        Me.panel_control.TabIndex = 7
        '
        'panel_monitor
        '
        Me.panel_monitor.BackColor = System.Drawing.Color.Transparent
        Me.panel_monitor.Controls.Add(Me.btn_Monitoring)
        Me.panel_monitor.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_monitor.Location = New System.Drawing.Point(0, 128)
        Me.panel_monitor.Name = "panel_monitor"
        Me.panel_monitor.Size = New System.Drawing.Size(265, 62)
        Me.panel_monitor.TabIndex = 6
        '
        'Panel_title
        '
        Me.Panel_title.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel_title.Controls.Add(Me.Label3)
        Me.Panel_title.Controls.Add(Me.Label1)
        Me.Panel_title.Controls.Add(Me.Label4)
        Me.Panel_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_title.Name = "Panel_title"
        Me.Panel_title.Size = New System.Drawing.Size(265, 128)
        Me.Panel_title.TabIndex = 5
        '
        'panelSlideMenu
        '
        Me.panelSlideMenu.BackgroundImage = CType(resources.GetObject("panelSlideMenu.BackgroundImage"), System.Drawing.Image)
        Me.panelSlideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelSlideMenu.Controls.Add(Me.Panel5)
        Me.panelSlideMenu.Controls.Add(Me.Panel4)
        Me.panelSlideMenu.Controls.Add(Me.Panel3)
        Me.panelSlideMenu.Controls.Add(Me.Panel2)
        Me.panelSlideMenu.Controls.Add(Me.panel_control)
        Me.panelSlideMenu.Controls.Add(Me.panel_monitor)
        Me.panelSlideMenu.Controls.Add(Me.Panel_title)
        Me.panelSlideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelSlideMenu.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.panelSlideMenu.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.panelSlideMenu.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.panelSlideMenu.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.panelSlideMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelSlideMenu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panelSlideMenu.Name = "panelSlideMenu"
        Me.panelSlideMenu.Quality = 10
        Me.panelSlideMenu.Size = New System.Drawing.Size(265, 681)
        Me.panelSlideMenu.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.btn_info)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 438)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(265, 62)
        Me.Panel5.TabIndex = 11
        '
        'lbl_jam
        '
        Me.lbl_jam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_jam.AutoSize = True
        Me.lbl_jam.BackColor = System.Drawing.Color.Transparent
        Me.lbl_jam.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.lbl_jam.ForeColor = System.Drawing.Color.White
        Me.lbl_jam.Location = New System.Drawing.Point(728, 11)
        Me.lbl_jam.Name = "lbl_jam"
        Me.lbl_jam.Size = New System.Drawing.Size(65, 19)
        Me.lbl_jam.TabIndex = 4
        Me.lbl_jam.Text = "00:00:00"
        '
        'lbl_day
        '
        Me.lbl_day.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_day.AutoSize = True
        Me.lbl_day.BackColor = System.Drawing.Color.Transparent
        Me.lbl_day.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.lbl_day.ForeColor = System.Drawing.Color.White
        Me.lbl_day.Location = New System.Drawing.Point(832, 11)
        Me.lbl_day.Name = "lbl_day"
        Me.lbl_day.Size = New System.Drawing.Size(75, 19)
        Me.lbl_day.TabIndex = 5
        Me.lbl_day.Text = "00-00-000"
        '
        'checkform
        '
        Me.checkform.Enabled = True
        '
        'ShowFormPanel
        '
        Me.ShowFormPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShowFormPanel.Location = New System.Drawing.Point(265, 42)
        Me.ShowFormPanel.Name = "ShowFormPanel"
        Me.ShowFormPanel.Size = New System.Drawing.Size(919, 639)
        Me.ShowFormPanel.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_titleku)
        Me.Panel1.Controls.Add(Me.lbl_jam)
        Me.Panel1.Controls.Add(Me.lbl_day)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(265, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(919, 42)
        Me.Panel1.TabIndex = 11
        '
        'lbl_titleku
        '
        Me.lbl_titleku.AutoSize = True
        Me.lbl_titleku.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titleku.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.lbl_titleku.ForeColor = System.Drawing.Color.White
        Me.lbl_titleku.Location = New System.Drawing.Point(19, 5)
        Me.lbl_titleku.Name = "lbl_titleku"
        Me.lbl_titleku.Size = New System.Drawing.Size(141, 30)
        Me.lbl_titleku.TabIndex = 6
        Me.lbl_titleku.Text = "Monitoring"
        Me.lbl_titleku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 681)
        Me.Controls.Add(Me.ShowFormPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelSlideMenu)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmUtama"
        Me.Text = "Interface Mini Scada"
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.panel_control.ResumeLayout(False)
        Me.panel_monitor.ResumeLayout(False)
        Me.Panel_title.ResumeLayout(False)
        Me.Panel_title.PerformLayout()
        Me.panelSlideMenu.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SlideClose As System.Windows.Forms.Timer
    Friend WithEvents tim_jamday As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btn_info As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_setting As System.Windows.Forms.Button
    Friend WithEvents btn_Monitoring As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_log As System.Windows.Forms.Button
    Friend WithEvents btn_Controling As System.Windows.Forms.Button
    Friend WithEvents panel_control As System.Windows.Forms.Panel
    Friend WithEvents panel_monitor As System.Windows.Forms.Panel
    Friend WithEvents Panel_title As System.Windows.Forms.Panel
    Friend WithEvents panelSlideMenu As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lbl_jam As System.Windows.Forms.Label
    Friend WithEvents lbl_day As System.Windows.Forms.Label
    Friend WithEvents checkform As System.Windows.Forms.Timer
    Friend WithEvents ShowFormPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_titleku As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btn_calculated As System.Windows.Forms.Button

End Class
