Imports System
Imports System.Net
Imports System.IO
Imports System.Net.NetworkInformation
'Imports System.Windows.Forms.DataVisualization.Charting
Public Class frmMonitoring
    'Dim engChart As New Series
    Dim testdata As Double = 0

    ' CONVERTING DATA SEL SURYA
    Dim coma_aki As Double
    Dim coma_aselsurya As Double

    ' CONVERTING DATA LOAD
    Dim coma_vinverter As Double
    Dim coma_ainverter As Double

    ' SERIES
    Dim c_vaki As String = "Tegangan Aki"
    Dim c_vinverter As String = "Tegangan Inverter"
    Dim default_s As String = "Series1"

    ' MAX Y CHART
    Dim maxaki As String = 15
    Dim max_arus_selsurya As String = 5000
    Dim max_vinverter As String = 250
    Dim max_arus_inverter As String = 1000

    ' BLINK SIGNAL
    Dim blink_cloud As Boolean = False

    Private Sub btn_resetall_Click(sender As Object, e As EventArgs) Handles btn_resetall.Click
        lbl_capasity_aki.Text = "0"
        lbl_beban_arus.Text = "0"
        lbl_beban_daya.Text = "0"
        lbl_beban_teg.Text = "0"
        lbl_panel_arus.Text = "0"
        lbl_Panel_Daya.Text = "0"
        lbl_StatusCharging.Text = "Not Charging"
        lbl_solarcell_tegangan.Text = "0"
        lbl_VPPanel.Text = "00,00"
        lbl_VPBeban.Text = "00,00"
        lbl_APBeban.Text = "00,00"
        lbl_APPanel.Text = "00,00"
        lbl_SPPanel.Text = "Idle"
        lbl_SPLoad.Text = "Idle"
        lbl_statusalat_panel.Text = "Off"
        lbl_statusalat_beban.Text = "Off"
    End Sub

    Private Sub TimerScadaTab_Tick(sender As Object, e As EventArgs) Handles TimerScadaTab.Tick
        'tp_gauge.BackColor = Color.Black
        lbl_scada_serveraddress.Text = "IP: " & frmSetting.tbox_server.Text

        ' DATA PANEL
        lbl_scada_arus_panel.Text = lbl_panel_arus.Text & " mA"
        lbl_scada_teganganaki_panel.Text = lbl_solarcell_tegangan.Text & " VDC"
        lbl_scada_daya_panel.Text = lbl_Panel_Daya.Text & " Watt"
        lbl_scada_charging_panel.Text = lbl_StatusCharging.Text
        lbl_scada_relay_panel.Text = lbl_SPPanel.Text
        lbl_scada_mode_panel.Text = lbl_statusalat_panel.Text
        lbl_scada_jama_panel.Text = frmControling.lbl_timerA.Text
        lbl_scada_jamb_panel.Text = frmControling.lbl_timerB.Text
        lbl_scada_kapasitasaki.Text = lbl_capasity_aki.Text & " %"

        ' DATA LOAD
        lbl_scada_arus_beban.Text = lbl_beban_arus.Text & " mA"
        lbl_scada_tegangan_beban.Text = lbl_beban_teg.Text & " VAC"
        lbl_scada_daya_beban.Text = lbl_beban_daya.Text & " Watt"
        lbl_scada_mode_beban.Text = lbl_statusalat_beban.Text
        lbl_scada_relay_beban.Text = lbl_SPLoad.Text


        ' KALKULASI TEGANGAN SEL SURYA


        ' INTERFACE ANIMATION
        ' > PANEL
        If lbl_scada_mode_panel.Text = "On" Or lbl_scada_mode_panel.Text = "Auto" Then
            'pic_aki_blue.Visible = True
        Else
            'pic_aki_blue.Visible = False
        End If

        ' > LOAD
        If lbl_scada_mode_beban.Text = "On" Or lbl_scada_mode_beban.Text = "Auto" Then
            'pict_load_blue.Visible = True
        Else
            'pict_load_blue.Visible = False
        End If
    End Sub

    Private Sub frmMonitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Chart1.Series.Clear()
        'Chart1.Titles.Add("Real time Tegangan Aki")
        'engChart.Name = "Tegangan Aki"
        'engChart.ChartType = SeriesChartType.Line


        'Chart1.Series.Add(engChart)
        'Chart1.ForeColor = Color.Red
        tp_gauge.BackColor = Color.Black
        ' CHART SEL SURYA
        Chart_TeganganAki.Series(c_vaki).Points.AddY(maxaki) ' TEGANGAN AKI
        Chart_TeganganAki.Series(c_vaki).IsValueShownAsLabel = False
        Chart_TeganganAki.ChartAreas("ChartArea1").AxisX.Enabled = DataVisualization.Charting.AxisEnabled.False

        Chart_ArusSC.Series(default_s).Points.AddY(max_arus_selsurya) ' ARUS SEL SURYA
        Chart_ArusSC.Series(default_s).IsValueShownAsLabel = False
        Chart_ArusSC.ChartAreas("ChartArea1").AxisX.Enabled = DataVisualization.Charting.AxisEnabled.False

        ' CHART BEBAN
        Chart_Tegangan_Inverter.Series(c_vinverter).Points.AddY(max_vinverter) ' TEGANGAN INVERTER
        Chart_Tegangan_Inverter.Series(c_vinverter).IsValueShownAsLabel = False
        Chart_Tegangan_Inverter.ChartAreas("ChartArea1").AxisX.Enabled = DataVisualization.Charting.AxisEnabled.False

        Chart_Arus_Inverter.Series(default_s).Points.AddY(max_arus_inverter) ' ARUS INVERTER
        Chart_Arus_Inverter.Series(default_s).IsValueShownAsLabel = False
        Chart_Arus_Inverter.ChartAreas("ChartArea1").AxisX.Enabled = DataVisualization.Charting.AxisEnabled.False
    End Sub

    Private Sub Tim_RealTime_Tick(sender As Object, e As EventArgs) Handles Tim_RealTime.Tick
        
        'If testdata < 15 Then
        '    testdata += 0.4
        'Else
        '    testdata = 0
        'End If

        'default_s

        ' >> PROCESS CONVERTING
        ' SEL SURYA
        Double.TryParse(lbl_solarcell_tegangan.Text, coma_aki)
        Double.TryParse(lbl_panel_arus.Text, coma_aselsurya)

        ' LOAD
        Double.TryParse(lbl_beban_teg.Text, coma_vinverter)
        Double.TryParse(lbl_beban_arus.Text, coma_ainverter)

        ' LABELING
        g_lbl_teganganaki.Text = coma_aki.ToString
        g_lbl_arussc.Text = coma_aselsurya.ToString

        g_lbl_teganganinverter.Text = coma_vinverter.ToString
        g_lbl_arusinverter.Text = coma_ainverter.ToString
        ' >> PRINT DATA CHART
        Try
            ' SEL SURYA
            Chart_TeganganAki.Series(c_vaki).Points.AddY(coma_aki) ' TEGANGAN AKI
            If Chart_TeganganAki.Series(0).Points.Count = 20 Then
                Chart_TeganganAki.Series(0).Points.RemoveAt(0)
            End If
            Chart_TeganganAki.ChartAreas(0).AxisY.Maximum = maxaki

            Chart_ArusSC.Series(default_s).Points.AddY(coma_aselsurya) ' ARUS SEL SURYA
            If Chart_ArusSC.Series(0).Points.Count = 20 Then
                Chart_ArusSC.Series(0).Points.RemoveAt(0)
            End If
            Chart_ArusSC.ChartAreas(0).AxisY.Maximum = max_arus_selsurya

            ' BEBAN
            Chart_Tegangan_Inverter.Series(c_vinverter).Points.AddY(coma_vinverter) ' TEGANGAN INVERTER
            If Chart_Tegangan_Inverter.Series(0).Points.Count = 20 Then
                Chart_Tegangan_Inverter.Series(0).Points.RemoveAt(0)
            End If
            Chart_Tegangan_Inverter.ChartAreas(0).AxisY.Maximum = max_vinverter

            Chart_Arus_Inverter.Series(default_s).Points.AddY(coma_ainverter) ' ARUS INVERTER
            If Chart_Arus_Inverter.Series(0).Points.Count = 20 Then
                Chart_Arus_Inverter.Series(0).Points.RemoveAt(0)
            End If
            Chart_Arus_Inverter.ChartAreas(0).AxisY.Maximum = max_arus_inverter
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tim_signal_cloud_timer_Tick(sender As Object, e As EventArgs) Handles animation_cloud_timer.Tick
        If blink_cloud = False Then
            pic_s_cloud_green.Visible = True
            blink_cloud = True
        Else
            pic_s_cloud_green.Visible = False
            blink_cloud = False
        End If
    End Sub
End Class