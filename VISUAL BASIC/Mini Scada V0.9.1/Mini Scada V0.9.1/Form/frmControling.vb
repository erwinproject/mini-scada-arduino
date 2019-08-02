Imports System.Net
Imports System.IO
Imports System.Net.NetworkInformation

Public Class frmControling
    ' INISIALISASI DATA
#Region "SETUP DATA"
    Dim statusrecordku As Boolean = False

    ' MONITORING PANEL
    Dim dataTegSolarCell As String = ""
    Dim dataPanelArus As String = ""
    Dim dataPanelDaya As String = ""
    Dim dataBattraiAki As String = ""
    Dim StatusAlatPanel As String = ""
    Dim PersenAki As String = ""
    Dim ControlPanel As String = ""
    Dim PanelSet_timea As String = ""
    Dim PanelSet_timeb As String = ""

    ' MONITORING BEBAN
    Dim dataTegBeban As String = ""
    Dim dataArusBeban As String = ""
    Dim dataDayaBeban As String = ""
    Dim dataStatusRelayLoad As String = ""
    Dim dataPStatusalatLoad As String = ""


    ' MONITORING PROTEKSI PANEL
    Dim dataPTegSolarCell As String = ""
    Dim dataPArusSolarCell As String = ""

    ' MONITORING PROTEKSI BEBAN
    Dim dataPTegBeban As String = ""
    Dim dataPArusBeban As String = ""

    ' MONITORING STATUS RELAY
    Dim dataSRelayPanel As String = ""
    Dim dataSRelayBeban As String = ""

    ' RECORDING TIMER
    Dim recordtimerlog As Integer = 4000

    Dim dateku As String

    Dim Result_Panel As String = ""
    Dim Result_Load As String = ""
    Dim Result_Proteksi As String = ""
    Dim Result_ResetDb As String = ""
    Dim resultdatano1 As String = "0|0"
    Dim counting As Integer = 0
    Dim result_ipadrress As String = ""
#End Region

    ' AWALAN OPEN FORM
    Private Sub frmControling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BW_Datagrid_Solar.RunWorkerAsync()
    End Sub

    ' GET HTML >> MONITROING
    Function getHTML(ByVal Address As String) As String
        Try
            Dim rt As String = ""
            Dim wRequest As WebRequest
            Dim wResponse As WebResponse

            Dim SR As StreamReader

            wRequest = WebRequest.Create(Address)
            wResponse = wRequest.GetResponse

            SR = New StreamReader(wResponse.GetResponseStream)

            rt = SR.ReadToEnd
            SR.Close()
            Return rt
        Catch ex As Exception
            BW_RealTime.CancelAsync()
            btn_realtime.BackColor = Color.Black
            MsgBox(ex.Message)
        End Try
    End Function

    ' GET HTML 1 >> GET DATA CONFIG
    Private Function getHTML1(ByVal Address As String) As String
        Try
            Dim rt1 As String = ""
            Dim wRequest1 As WebRequest
            Dim wResponse1 As WebResponse

            Dim SR1 As StreamReader

            wRequest1 = WebRequest.Create(Address)
            wResponse1 = wRequest1.GetResponse

            SR1 = New StreamReader(wResponse1.GetResponseStream)

            rt1 = SR1.ReadToEnd
            SR1.Close()
            Return rt1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    ' GET HTML 2
    Private Function getHTML2(ByVal Address As String) As String
        Try
            Dim rt1 As String = ""
            Dim wRequest1 As WebRequest
            Dim wResponse1 As WebResponse

            Dim SR1 As StreamReader

            wRequest1 = WebRequest.Create(Address)
            wResponse1 = wRequest1.GetResponse

            SR1 = New StreamReader(wResponse1.GetResponseStream)

            rt1 = SR1.ReadToEnd
            SR1.Close()
            Return rt1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    ' GET HTML 2
    Private Function getIP(ByVal Address As String) As String
        Try
            Dim rtip As String = ""
            Dim wRequestip As WebRequest
            Dim wResponseip As WebResponse

            Dim SRip As StreamReader

            wRequestip = WebRequest.Create(Address)
            wResponseip = wRequestip.GetResponse

            SRip = New StreamReader(wResponseip.GetResponseStream)

            rtip = SRip.ReadToEnd
            SRip.Close()
            Return rtip
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    ' FUNCTION PINGER SERVER
    Private Async Sub pinger()
        Dim ipaddress As String = frmSetting.tbox_server.Text
        Dim MyPing As New Ping
        Dim MyReply As PingReply = Await MyPing.SendPingAsync(ipaddress, 250)

        If MyReply.RoundtripTime > 0 Then
            frmMonitoring.lbl_scada_ping.Text = MyReply.RoundtripTime.ToString & " ms"
        End If

        If btn_realtime.BackColor = Color.DarkGreen Then
            BW_RealTime.ReportProgress(frmMonitoring.lbl_scada_ping.Text = MyReply.RoundtripTime.ToString & " ms")
        End If

    End Sub

    ' GET DOWNLOAD LOG DB
    Private Function getDownloadLogDB(ByVal Address As String) As String
        Try
            Dim rt2 As String = ""
            Dim wRequest2 As WebRequest
            Dim wResponse2 As WebResponse

            Dim SR2 As StreamReader

            wRequest2 = WebRequest.Create(Address)
            wResponse2 = wRequest2.GetResponse

            SR2 = New StreamReader(wResponse2.GetResponseStream)

            rt2 = SR2.ReadToEnd
            SR2.Close()
            Return rt2
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Function speeddata()
        Dim speedcatch As Integer = Val(tbox_speeddata.Text)
    End Function

    ' >>>> DATA PANEL <<<<
    Sub getDataPanel()
        Dim getfromset As String = "http://" & frmSetting.tbox_server.Text & frmSetting.tbox_show_datapanel.Text & "?token=" & frmSetting.tbox_token.Text
        Result_Panel = getHTML(getfromset)
        'Result_Panel = "110|220"
        Try
            Dim arraystring = Result_Panel.Split("|")
            If arraystring.Count = 11 Then
                dataTegSolarCell = arraystring(0).Replace(".", ",")     ' DATA TEGANGAN
                dataPanelArus = arraystring(1).Replace(".", ",")        ' DATA ARUS
                dataPanelDaya = arraystring(2).Replace(".", ",")        ' DATA DAYA
                dataBattraiAki = arraystring(3).Replace(".", ",")       ' DATA STATUS CHARGING, NOT CHARGING
                dataSRelayPanel = arraystring(4).Replace(".", ",")      ' DATA STATUS RELAY
                PersenAki = arraystring(5).Replace(".", ",")            ' DATA STATUS PERSEN AKI
                dataPTegSolarCell = arraystring(6).Replace(".", ",")    ' DATA PROTEKSI TEGANGAN SOLAR CELL
                dataPArusSolarCell = arraystring(7).Replace(".", ",")   ' DATA PROTEKSI ARUS SOLAR CELL
                ControlPanel = arraystring(8).Replace(".", ",")         ' DATA CONFIG KONTROL
                PanelSet_timea = arraystring(9).Replace(".", ",")       ' DATA CONFIG TIMER CHARGE AWAL
                PanelSet_timeb = arraystring(10).Replace(".", ",")      ' DATA CONFIG TIMER CHARGE AKHIR
            End If
            frmMonitoring.lbl_solarcell_tegangan.Text = dataTegSolarCell.ToString
            frmMonitoring.lbl_panel_arus.Text = dataPanelArus.ToString
            frmMonitoring.lbl_Panel_Daya.Text = dataPanelDaya.ToString
            frmMonitoring.lbl_StatusCharging.Text = dataBattraiAki.ToString
            frmMonitoring.lbl_SPPanel.Text = dataSRelayPanel.ToString
            frmMonitoring.lbl_capasity_aki.Text = PersenAki.ToString
            frmMonitoring.lbl_VPPanel.Text = dataPTegSolarCell.ToString
            frmMonitoring.lbl_APPanel.Text = dataPArusSolarCell.ToString
            frmMonitoring.lbl_statusalat_panel.Text = ControlPanel.ToString
            lbl_timerA.Text = PanelSet_timea.ToString
            lbl_timerB.Text = PanelSet_timeb.ToString

            BW_RealTime.ReportProgress(frmMonitoring.lbl_solarcell_tegangan.Text = dataTegSolarCell.ToString)
            BW_RealTime.ReportProgress(frmMonitoring.lbl_panel_arus.Text = dataPanelArus.ToString)
            BW_RealTime.ReportProgress(frmMonitoring.lbl_Panel_Daya.Text = dataPanelDaya.ToString)
            BW_RealTime.ReportProgress(frmMonitoring.lbl_StatusCharging.Text = dataBattraiAki.ToString)
            BW_RealTime.ReportProgress(frmMonitoring.lbl_SPPanel.Text = dataSRelayPanel.ToString)
            BW_RealTime.ReportProgress(frmMonitoring.lbl_capasity_aki.Text = PersenAki.ToString)
            BW_RealTime.ReportProgress(frmMonitoring.lbl_VPPanel.Text = dataPTegSolarCell.ToString)
            BW_RealTime.ReportProgress(frmMonitoring.lbl_APPanel.Text = dataPArusSolarCell.ToString)
            BW_RealTime.ReportProgress(frmMonitoring.lbl_statusalat_panel.Text = ControlPanel.ToString)
            BW_RealTime.ReportProgress(lbl_timerA.Text = PanelSet_timea.ToString)
            BW_RealTime.ReportProgress(lbl_timerB.Text = PanelSet_timeb.ToString)
        Catch ex As Exception
            'BW_RealTime.CancelAsync()
            'btn_realtime.BackColor = Color.Black
            'MsgBox("Data error !", MsgBoxStyle.Information, Title:="Error")
        End Try
    End Sub

    ' >>>> DATA BEBAN <<<<
    Sub getDataBeban()
        Dim getfromsetLoad As String = "http://" & frmSetting.tbox_server.Text & frmSetting.tbox_show_databeban.Text & "?token=" & frmSetting.tbox_token.Text
        Result_Load = getHTML1(getfromsetLoad)
        'Result_Panel = "110|220"
        Try
            Dim arraystring_load = Result_Load.Split("|")
            If arraystring_load.Count = 7 Then
                dataTegBeban = arraystring_load(0).Replace(".", ",")
                dataArusBeban = arraystring_load(1).Replace(".", ",")
                dataDayaBeban = arraystring_load(2).Replace(".", ",")
                dataStatusRelayLoad = arraystring_load(3).Replace(".", ",")
                dataPTegBeban = arraystring_load(4).Replace(".", ",")
                dataPArusBeban = arraystring_load(5).Replace(".", ",")
                dataPStatusalatLoad = arraystring_load(6).Replace(".", ",")

            End If
            frmMonitoring.lbl_beban_teg.Text = dataTegBeban.ToString
            frmMonitoring.lbl_beban_arus.Text = dataArusBeban.ToString
            frmMonitoring.lbl_beban_daya.Text = dataDayaBeban.ToString
            frmMonitoring.lbl_SPLoad.Text = dataStatusRelayLoad
            frmMonitoring.lbl_VPBeban.Text = dataPTegBeban.ToString
            frmMonitoring.lbl_APBeban.Text = dataPArusBeban.ToString
            frmMonitoring.lbl_statusalat_beban.Text = dataPStatusalatLoad.ToString

            BW_RealTime.ReportProgress(frmMonitoring.lbl_beban_teg.Text = dataTegBeban.ToString)
            BW_RealTime.ReportProgress(frmMonitoring.lbl_beban_arus.Text = dataArusBeban.ToString)
            BW_RealTime.ReportProgress(frmMonitoring.lbl_beban_daya.Text = dataDayaBeban.ToString)
            BW_RealTime.ReportProgress(frmMonitoring.lbl_SPLoad.Text = dataStatusRelayLoad)
            BW_RealTime.ReportProgress(frmMonitoring.lbl_VPBeban.Text = dataPTegBeban.ToString)
            BW_RealTime.ReportProgress(frmMonitoring.lbl_APBeban.Text = dataPArusBeban.ToString)
            BW_RealTime.ReportProgress(frmMonitoring.lbl_statusalat_beban.Text = dataPStatusalatLoad.ToString)

        Catch ex As Exception
            'MsgBox("Data error !", MsgBoxStyle.Information, Title:="Error")
        End Try
    End Sub

    Sub getipaddress()
        Dim getfromserverip As String = "http://" & frmSetting.tbox_server.Text
        result_ipadrress = getIP(getfromserverip)
        frmMonitoring.lbl_scada_ipaddress.Text = frmMonitoring.lbl_scada_ipaddress.Text = "IP4 : " & result_ipadrress.ToString
        BW_RealTime.ReportProgress(frmMonitoring.lbl_scada_ipaddress.Text = "IP4 : " & result_ipadrress.ToString)
    End Sub

    ' >>>> PROGRAM KOMPONEN ITEMS
#Region "COMPONENET PROGRAM"
    Private Sub btn_cekdata1_Click(sender As Object, e As EventArgs) Handles btn_cekdata1.Click
        If My.Computer.Network.IsAvailable = True Then
            getDataPanel()
            getDataBeban()
            pinger()
            getipaddress()

        End If
    End Sub

    ' BUTTON REALTIME ON OF
    Private Sub btn_realtime_Click(sender As Object, e As EventArgs) Handles btn_realtime.Click
        If My.Computer.Network.IsAvailable = True Then
            Try
                If btn_realtime.BackColor = Color.MidnightBlue Then
                    frmSetting.PanelSetupServer.Enabled = False
                    statusrecordku = True
                    BW_RealTime.WorkerReportsProgress = True
                    BW_RealTime.WorkerSupportsCancellation = True
                    BW_RealTime.RunWorkerAsync()
                    btn_realtime.BackColor = Color.DarkGreen

                    Tim_Realtime.Interval = Val(tbox_speeddata.Text)
                    Tim_Realtime.Enabled = True

                    frmMonitoring.animation_cloud_timer.Enabled = True

                    'frmMonitoring.Tim_RealTime.Interval = Val(tbox_speeddata.Text)
                    frmMonitoring.Tim_RealTime.Enabled = True
                ElseIf btn_realtime.BackColor = Color.DarkGreen Then
                    statusrecordku = False
                    BW_RealTime.CancelAsync()
                    btn_realtime.BackColor = Color.MidnightBlue
                    frmSetting.PanelSetupServer.Enabled = True

                    Tim_Realtime.Enabled = False
                    frmMonitoring.Tim_RealTime.Enabled = False
                    frmMonitoring.animation_cloud_timer.Enabled = False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                statusrecordku = False
                Tim_Realtime.Enabled = False
                BW_RealTime.CancelAsync()
                btn_realtime.BackColor = Color.MidnightBlue

                frmSetting.PanelSetupServer.Enabled = True
                frmMonitoring.Tim_RealTime.Enabled = False
                frmMonitoring.animation_cloud_timer.Enabled = False
            End Try
        End If
    End Sub

    Private Sub chkbox_recordlog_CheckedChanged(sender As Object, e As EventArgs) Handles chkbox_recordlog.CheckedChanged
        If chkbox_recordlog.Checked = True Then
            BW_Datagrid_Solar.RunWorkerAsync()
            BW_RealTime.WorkerReportsProgress = True
            BW_RealTime.WorkerSupportsCancellation = True
        ElseIf chkbox_recordlog.Checked = False Then
            BW_Datagrid_Solar.CancelAsync()
        End If
    End Sub
#End Region

    ' >>>> BACKGROUND WORKER
#Region "BACKGROUND WORKER PROGRAM"
    ' RUN IN BACKGROUND REALTIME DATA
    Private Sub BW_RealTime_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_RealTime.DoWork
        Do
            Call getDataPanel()
            Call getDataBeban()
            Call pinger()
            Call getipaddress()

            Threading.Thread.Sleep(Val(tbox_speeddata.Text))
            If BW_RealTime.CancellationPending = True Then Exit Do
        Loop
    End Sub

    Private Sub BW_RealTime_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_RealTime.RunWorkerCompleted
        MsgBox("Real Time Disable", MsgBoxStyle.Information, Title:="INFORMASI !")
    End Sub

    Private Sub BW_RealTime_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_RealTime.ProgressChanged
        ' FORM DATA REAL
        frmMonitoring.lbl_solarcell_tegangan.Text = dataTegSolarCell.ToString
        frmMonitoring.lbl_panel_arus.Text = dataPanelArus.ToString
        frmMonitoring.lbl_Panel_Daya.Text = dataPanelDaya.ToString
        frmMonitoring.lbl_StatusCharging.Text = dataBattraiAki.ToString
        frmMonitoring.lbl_SPPanel.Text = dataSRelayPanel.ToString
        frmMonitoring.lbl_capasity_aki.Text = PersenAki.ToString
        frmMonitoring.lbl_VPPanel.Text = dataPTegSolarCell.ToString
        frmMonitoring.lbl_APPanel.Text = dataPArusSolarCell.ToString
        frmMonitoring.lbl_statusalat_panel.Text = ControlPanel.ToString
        lbl_timerA.Text = PanelSet_timea.ToString
        lbl_timerB.Text = PanelSet_timeb.ToString

        frmMonitoring.lbl_beban_teg.Text = dataTegBeban.ToString
        frmMonitoring.lbl_beban_arus.Text = dataArusBeban.ToString
        frmMonitoring.lbl_beban_daya.Text = dataDayaBeban.ToString
        frmMonitoring.lbl_SPLoad.Text = dataStatusRelayLoad
        frmMonitoring.lbl_VPBeban.Text = dataPTegBeban.ToString
        frmMonitoring.lbl_APBeban.Text = dataPArusBeban.ToString
        frmMonitoring.lbl_statusalat_beban.Text = dataPStatusalatLoad.ToString

        frmMonitoring.lbl_scada_ipaddress.Text = "IP4 : " & result_ipadrress.ToString

        pinger()
    End Sub

    ' DATA RECORD TO EXCEL 
    Private Sub BW_Datagrid_Solar_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Datagrid_Solar.DoWork
        Do
            If statusrecordku = True Then
                dateku = frmUtama.lbl_day.Text & " " & frmUtama.lbl_jam.Text
                ' DATA PANEL
                Dim tegangansc As String = frmMonitoring.lbl_solarcell_tegangan.Text
                Dim arus As String = frmMonitoring.lbl_panel_arus.Text
                Dim dayapanel As String = frmMonitoring.lbl_Panel_Daya.Text
                Dim teganganaki As String = frmMonitoring.lbl_StatusCharging.Text
                Dim SRelayPanels As String = frmMonitoring.lbl_SPPanel.Text
                Dim SKapasitasAki As String = frmMonitoring.lbl_capasity_aki.Text


                ' DATA BEBAN
                Dim teganganbeban As String = frmMonitoring.lbl_beban_teg.Text
                Dim arusbeban As String = frmMonitoring.lbl_beban_arus.Text
                Dim dayabeban As String = frmMonitoring.lbl_beban_daya.Text
                Dim SRelayBebans As String = frmMonitoring.lbl_SPLoad.Text

                'frmLog.DataGridSolarPanel.Rows.Add(dateku, tegangansc, arus, dayapanel, teganganaki, SRelayPanels, SKapasitasAki)
                'frmLog.DataGridBeban.Rows.Add(dateku, teganganbeban, arusbeban, dayabeban, SRelayBebans)
                'BW_Datagrid_Solar.ReportProgress(frmLog.DataGridSolarPanel.Rows.Add(dateku, tegangansc, arus, dayapanel, teganganaki, SRelayPanels, SKapasitasAki))
                'BW_Datagrid_Solar.ReportProgress(frmLog.DataGridBeban.Rows.Add(dateku, teganganbeban, arusbeban, dayabeban, SRelayBebans))

                'Threading.Thread.Sleep(recordtimerlog)
                Threading.Thread.Sleep(Val(tbox_speeddata.Text))
                If BW_Datagrid_Solar.CancellationPending = True Then Exit Do
            End If
        Loop
    End Sub

    Private Sub BW_Datagrid_Solar_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Datagrid_Solar.ProgressChanged
        If statusrecordku = True Then
            dateku = frmUtama.lbl_day.Text & " " & frmUtama.lbl_jam.Text
            ' DATA PANEL
            Dim tegangansc As String = frmMonitoring.lbl_solarcell_tegangan.Text
            Dim arus As String = frmMonitoring.lbl_panel_arus.Text
            Dim dayapanel As String = frmMonitoring.lbl_Panel_Daya.Text
            Dim teganganaki As String = frmMonitoring.lbl_StatusCharging.Text
            Dim SRelayPanels As String = frmMonitoring.lbl_SPPanel.Text
            Dim SKapasitasAki As String = frmMonitoring.lbl_capasity_aki.Text

            ' DATA BEBAN
            Dim teganganbeban As String = frmMonitoring.lbl_beban_teg.Text
            Dim arusbeban As String = frmMonitoring.lbl_beban_arus.Text
            Dim dayabeban As String = frmMonitoring.lbl_beban_daya.Text
            Dim SRelayBebans As String = frmMonitoring.lbl_SPLoad.Text

            'frmLog.DataGridSolarPanel.Rows.Add(dateku, tegangansc, arus, dayapanel, teganganaki, SRelayPanels, SKapasitasAki)
            'frmLog.DataGridBeban.Rows.Add(dateku, teganganbeban, arusbeban, dayabeban, SRelayBebans)
        End If

    End Sub

    Private Sub BW_Datagrid_Solar_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Datagrid_Solar.RunWorkerCompleted
        MsgBox("Log Data Panel Disable", MsgBoxStyle.Information, Title:="INFORMASI !")
    End Sub
#End Region

    ' SET PROTEKSI PANEL
    Private Sub btn_setPPANEL_Click(sender As Object, e As EventArgs) Handles btn_setPPANEL.Click
        Dim setproteksi As String = "http://" & frmSetting.tbox_server.Text & frmSetting.tbox_updatePPanel.Text & "?token=" & frmSetting.tbox_token.Text & "&tegangan=" & tbox_setPTegPanel.Text + "&arus=" & tbox_setPArusPanel.Text & "&control=" & Cbox_ModeAlat_Panel.Text & "&timea=" & tbox_settimea.Text & "&timeb=" & tbox_settimeb.Text
        'MsgBox(setproteksi)
        Try
            Result_Proteksi = getHTML1(setproteksi)
            MsgBox(Result_Proteksi.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_setPBEBAN_Click(sender As Object, e As EventArgs) Handles btn_setPBEBAN.Click
        Dim setproteksi As String = "http://" & frmSetting.tbox_server.Text & frmSetting.tbox_updatePBeban.Text & "?token=" & frmSetting.tbox_token.Text & "&tegangan=" & tbox_setPTegBeban.Text & "&arus=" & tbox_setPArusBeban.Text & "&status=" & Cbox_ModeAlat_Load.Text
        'MsgBox(setproteksi)
        Try
            Result_Proteksi = getHTML1(setproteksi)
            MsgBox(Result_Proteksi.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_dbresetPdefault_Click(sender As Object, e As EventArgs) Handles btn_dbresetPdefault.Click
        btn_dbresetPdefault.Text = "Please Wait"
        btn_dbresetPdefault.Enabled = False

        tbox_setPTegPanel.Text = "14.9"
        tbox_setPArusPanel.Text = "650"
        tbox_setPTegBeban.Text = "230"
        tbox_setPArusBeban.Text = "650"

        Dim setdefproteksiPanel As String = "http://" & frmSetting.tbox_server.Text + frmSetting.tbox_updatePPanel.Text + "&tegangan=" + tbox_setPTegPanel.Text + "&arus=" + tbox_setPArusPanel.Text
        Dim setdefproteksiBeban As String = "http://" & frmSetting.tbox_server.Text + frmSetting.tbox_updatePBeban.Text + "&tegangan=" + tbox_setPTegBeban.Text + "&arus=" + tbox_setPArusBeban.Text

        Try
            Result_Proteksi = getHTML1(setdefproteksiPanel)
            Result_Proteksi = getHTML1(setdefproteksiBeban)
            MsgBox("Setup Done", MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox(ex.Message)
            btn_dbresetPdefault.Text = "Reset Proteksi to Default"
            btn_dbresetPdefault.Enabled = True
        End Try

        btn_dbresetPdefault.Text = "Reset Proteksi to Default"
        btn_dbresetPdefault.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_dbtozero.Click
        Dim result As DialogResult = MessageBox.Show("Apakah akan mereset database ?", _
                              "Reset database", _
                              MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                btn_dbtozero.Text = "Please Wait"
                btn_dbtozero.Enabled = False

                Dim insertPanelDb As String = "http://" & frmSetting.tbox_server.Text + "/api/update/solarpanel.php?token=" + frmSetting.tbox_token.Text + "&date=-&tegangan=0&arus=0&daya=0&status=Auto&relay=Idle"
                Dim insertBebanDb As String = "http://" & frmSetting.tbox_server.Text + "/api/update/load.php?token=" + frmSetting.tbox_token.Text + "&tegangan=0&arus=0&daya=0&relay=Idle"
                Result_ResetDb = getHTML2(insertPanelDb)
                Result_ResetDb = getHTML2(insertBebanDb)
                MsgBox("Setup Done", MsgBoxStyle.OkOnly)
            Catch ex As Exception
                MsgBox(ex.Message)
                btn_dbtozero.Text = "Reset Database"
                btn_dbtozero.Enabled = True
            End Try
        Else

        End If
        btn_dbtozero.Text = "Reset Database"
        btn_dbtozero.Enabled = True
    End Sub

    Private Sub btn_clearLogDB_Click(sender As Object, e As EventArgs) Handles btn_clearLogDB.Click
        Dim result As DialogResult = MessageBox.Show("Apakah akan ingin menghapus log database ?", _
                              "Hapus Log Database", _
                              MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                btn_clearLogDB.Text = "Please Wait"
                btn_clearLogDB.Enabled = False

                Dim logDBpanel As String = "http://" & frmSetting.tbox_server.Text + frmSetting.tbox_crud_updateproteksi.Text + "?token=" + frmSetting.tbox_token.Text + "&tabel=record_panel"
                Dim logDBbeban As String = "http://" & frmSetting.tbox_server.Text + frmSetting.tbox_crud_updateproteksi.Text + "?token=" + frmSetting.tbox_token.Text + "&tabel=record_beban"

                Result_ResetDb = getHTML2(logDBpanel)
                Result_ResetDb = getHTML2(logDBbeban)
                MsgBox(Result_ResetDb.ToString, MsgBoxStyle.OkOnly)
            Catch ex As Exception
                MsgBox(ex.Message)
                btn_clearLogDB.Text = "Clear Log Database Server"
                btn_clearLogDB.Enabled = True
            End Try
        Else

        End If
        btn_clearLogDB.Text = "Reset Database"
        btn_clearLogDB.Enabled = True
    End Sub
    ' NOT TESTED
    Private Sub btn_downloaddb_panel_Click(sender As Object, e As EventArgs) Handles btn_downloaddb_panel.Click
        Dim downloaddblog_panel As String = "http://" & frmSetting.tbox_server.Text + frmSetting.tbox_downloaddb_panel.Text + "?token=" + frmSetting.tbox_token.Text
        Try
            btn_downloaddb_panel.Text = "Please Wait"
            btn_downloaddb_panel.Enabled = False
            Dim mydokumen As String = Environment.SpecialFolder.MyDocuments.ToString()
            Dim logday As String = frmUtama.lbl_day.Text.Replace(":", "-")
            Dim logjam As String = frmUtama.lbl_jam.Text.Replace(":", "-")
            Dim downloadlog_db As New SaveFileDialog()
            downloadlog_db.Filter = "Excel File (*.xls)|*.xls|All Files|*.*"
            downloadlog_db.Title = "SAVE FILE"
            downloadlog_db.InitialDirectory = mydokumen
            downloadlog_db.FileName = "Database Log Panel " & logday & " " & logjam

            If downloadlog_db.ShowDialog() = Windows.Forms.DialogResult.OK Then
                My.Computer.Network.DownloadFile(downloaddblog_panel, downloadlog_db.FileName.ToString)
                MsgBox("Success saved to : " & downloadlog_db.FileName.ToString, MsgBoxStyle.Information, Title:="DOWNLOAD SUCCESS")
            End If

            'Dim getLogPanel As String = getDownloadLogDB(downloaddblog_panel)
            btn_downloaddb_panel.Text = "Log DB Panel"
            btn_downloaddb_panel.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
            btn_downloaddb_panel.Text = "Log DB Panel"
            btn_downloaddb_panel.Enabled = True
        End Try

        btn_downloaddb_panel.Text = "Log DB Panel"
        btn_downloaddb_panel.Enabled = True

    End Sub
    ' NOT TESTED
    Private Sub btn_downloaddb_beban_Click(sender As Object, e As EventArgs) Handles btn_downloaddb_beban.Click
        Dim downloaddblog_beban As String = "http://" & frmSetting.tbox_server.Text + frmSetting.tbox_downloaddb_beban.Text + "?token=" + frmSetting.tbox_token.Text
        Try
            btn_downloaddb_beban.Text = "Please Wait"
            btn_downloaddb_beban.Enabled = False
            Dim mydokumen As String = Environment.SpecialFolder.MyDocuments.ToString()
            Dim logday As String = frmUtama.lbl_day.Text.Replace(":", "-")
            Dim logjam As String = frmUtama.lbl_jam.Text.Replace(":", "-")
            Dim downloadlog_db As New SaveFileDialog()
            downloadlog_db.Filter = "Excel File (*.xls)|*.xls|All Files|*.*"
            downloadlog_db.Title = "SAVE FILE"
            downloadlog_db.InitialDirectory = mydokumen
            downloadlog_db.FileName = "Database Log Beban " & logday & " " & logjam

            If downloadlog_db.ShowDialog() = Windows.Forms.DialogResult.OK Then
                My.Computer.Network.DownloadFile(downloaddblog_beban, downloadlog_db.FileName.ToString)
                MsgBox("Success saved to : " & downloadlog_db.FileName.ToString, MsgBoxStyle.Information, Title:="DOWNLOAD SUCCESS")
            End If
            btn_downloaddb_beban.Text = "Log DB Beban"
            btn_downloaddb_beban.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
            btn_downloaddb_beban.Text = "Log DB Beban"
            btn_downloaddb_beban.Enabled = True
        End Try

        btn_downloaddb_beban.Text = "Log DB Beban"
        btn_downloaddb_beban.Enabled = True
    End Sub

    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click
        If Val(tbox_speeddata.Text) < 1000 Then
            tbox_speeddata.Text = 1000
        End If

    End Sub

    Private Sub Tim_Realtime_Tick(sender As Object, e As EventArgs) Handles Tim_Realtime.Tick
        dateku = frmUtama.lbl_day.Text & " " & frmUtama.lbl_jam.Text
        frmLog.DataGridSolarPanel.Rows.Add(dateku, frmMonitoring.lbl_solarcell_tegangan.Text, frmMonitoring.lbl_panel_arus.Text, frmMonitoring.lbl_Panel_Daya.Text, frmMonitoring.lbl_StatusCharging.Text, frmMonitoring.lbl_SPPanel.Text, frmMonitoring.lbl_capasity_aki.Text)
        frmLog.DataGridBeban.Rows.Add(dateku, frmMonitoring.lbl_beban_teg.Text, frmMonitoring.lbl_beban_arus.Text, frmMonitoring.lbl_beban_daya.Text, frmMonitoring.lbl_SPLoad.Text)
    End Sub
End Class