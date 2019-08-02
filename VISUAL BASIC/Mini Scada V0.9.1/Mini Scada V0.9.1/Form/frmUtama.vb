Public Class frmUtama

    Private Sub resizeautoku()

    End Sub

    Sub setFix()
        frmMonitoring.Size = New Size(ShowFormPanel.Size.Width, ShowFormPanel.Size.Height)
        frmInfo.Size = New Size(ShowFormPanel.Size.Width, ShowFormPanel.Size.Height)
        frmControling.Size = New Size(ShowFormPanel.Size.Width, ShowFormPanel.Size.Height)
        frmSetting.Size = New Size(ShowFormPanel.Size.Width, ShowFormPanel.Size.Height)
    End Sub

    Private Sub tim_jamday_Tick(sender As Object, e As EventArgs) Handles tim_jamday.Tick
        lbl_day.Text = Format(Now, "dd-MM-yyyy")
        lbl_jam.Text = TimeString
    End Sub

    Private Sub frmUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ShowFormPanel.Controls.Clear()
            frmMonitoring.TopLevel = False
            ShowFormPanel.Controls.Add(frmMonitoring)
            frmMonitoring.Show()
            'setFix()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Monitoring_Click(sender As Object, e As EventArgs) Handles btn_Monitoring.Click
        lbl_titleku.Text = btn_Monitoring.Text
        Try
            ShowFormPanel.Controls.Clear()
            frmMonitoring.TopLevel = False
            ShowFormPanel.Controls.Add(frmMonitoring)
            frmMonitoring.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Controling_Click(sender As Object, e As EventArgs) Handles btn_Controling.Click
        lbl_titleku.Text = btn_Controling.Text
        Try
            ShowFormPanel.Controls.Clear()
            frmControling.TopLevel = False
            ShowFormPanel.Controls.Add(frmControling)
            frmControling.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_info_Click(sender As Object, e As EventArgs) Handles btn_info.Click
        lbl_titleku.Text = btn_info.Text
        Try
            ShowFormPanel.Controls.Clear()
            frmInfo.TopLevel = False
            ShowFormPanel.Controls.Add(frmInfo)
            frmInfo.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_calculated_Click(sender As Object, e As EventArgs) Handles btn_calculated.Click
        lbl_titleku.Text = btn_calculated.Text
        Try
            ShowFormPanel.Controls.Clear()
            frmSimulation.TopLevel = False
            ShowFormPanel.Controls.Add(frmSimulation)
            frmSimulation.Show()
            'setFix()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_setting_Click(sender As Object, e As EventArgs) Handles btn_setting.Click
        lbl_titleku.Text = btn_setting.Text
        Try
            ShowFormPanel.Controls.Clear()
            frmSetting.TopLevel = False
            ShowFormPanel.Controls.Add(frmSetting)
            frmSetting.Show()
            'setFix()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_log_Click(sender As Object, e As EventArgs) Handles btn_log.Click
        lbl_titleku.Text = btn_log.Text
        Try
            ShowFormPanel.Controls.Clear()
            frmLog.TopLevel = False
            ShowFormPanel.Controls.Add(frmLog)
            frmLog.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub checkform_Tick(sender As Object, e As EventArgs) Handles checkform.Tick
        Try
            setFix()

        Catch ex As Exception

        End Try
    End Sub

 
End Class