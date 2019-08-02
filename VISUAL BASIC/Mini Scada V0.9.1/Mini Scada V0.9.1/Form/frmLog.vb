Imports System.Data
Imports System
Imports System.IO
Imports System.IO.Ports
Imports System.Diagnostics
Imports System.ComponentModel
Imports System.Threading
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
'Imports System.ServiceProcess
Imports System.Runtime.InteropServices
Public Class frmLog
    Dim xlApp As New Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkBook1 As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Dim xlWorkSheet1 As Excel.Worksheet
    Dim misValue As Object = System.Reflection.Missing.Value
    Private Sub btn_clearalllog_Click(sender As Object, e As EventArgs) Handles btn_clearalllog.Click
        Me.DataGridBeban.Rows.Clear()
        Me.DataGridSolarPanel.Rows.Clear()
    End Sub
    Private Sub btn_clearlogSolarCell_Click_1(sender As Object, e As EventArgs) Handles btn_clearlogSolarCell.Click
        Me.DataGridSolarPanel.Rows.Clear()
    End Sub

    Private Sub btn_clearlogbeban_Click_1(sender As Object, e As EventArgs) Handles btn_clearlogbeban.Click
        Me.DataGridBeban.Rows.Clear()
    End Sub

    ' >>>>>>>>>>>>>>> SAVE EXCEL DATA PANEL
    Private Sub btn_savetoexcel_Click(sender As Object, e As EventArgs) Handles btn_savetoexcel.Click
        Dim xlApp As New Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        btn_savetoexcel.Text = "Please Wait .."

        btn_savetoexcel.Enabled = False

        Dim logday As String = frmUtama.lbl_day.Text.Replace(":", "-")
        Dim logjam As String = frmUtama.lbl_jam.Text.Replace(":", "-")
        Dim savelog As New SaveFileDialog()
        savelog.Filter = "Excel File (*.xlsx)|*.xlsx|All Files|*.*"
        savelog.Title = "Save File As"
        savelog.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString()
        savelog.FileName = "LOG DATA PANEL " & logday & " " & logjam

        If savelog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Dim filesaving As String = ("D:\DataLog " & tanggalreplace & " " & jamreplace & ".xlsx")
            'Dim filesaving As String = tbox_namesavedata.Text & tbox_namefileexcel.Text & ".xlsx"
            Dim filesaving As String = savelog.FileName.ToString

            ' EXPORT DATAGRID TO EXCEL
            Try
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                xlWorkSheet = xlWorkBook.Sheets("Sheet1")
                'xlWorkSheet1 = xlWorkBook.Sheets("Data Beban")
                ' --- define worksheet format
                xlApp.StandardFontSize = "12"
                xlWorkSheet.Columns.HorizontalAlignment = Excel.Constants.xlLeft
                'xlWorkSheet1.Columns.HorizontalAlignment = Excel.Constants.xlLeft
                ' --- define columns header
                ' SHEET DATA PANEL
                xlWorkSheet.Cells(1, 1) = "Tanggal / Jam"
                xlWorkSheet.Cells(1, 2) = "Tegangan Aki (VDC)"
                xlWorkSheet.Cells(1, 3) = "Arus (mA)"
                xlWorkSheet.Cells(1, 4) = "Daya (Watt)"
                xlWorkSheet.Cells(1, 5) = "Status Charging"
                xlWorkSheet.Cells(1, 6) = "Status Relay"
                xlWorkSheet.Select()
                xlWorkSheet.Range("A1:F1").Select()
                xlWorkSheet.Range("A1:F1").HorizontalAlignment = Excel.Constants.xlCenter
                xlWorkSheet.Range("A1:F1").Font.Bold = True
                xlWorkSheet.Range("A1:F1").Font.Size = "11"
                xlWorkSheet.Range("A1:F1").Font.Name = "Open Sans"

                xlWorkSheet.Range("A:F").EntireColumn.ColumnWidth = "30"

                Dim i As Integer = 2
                Dim j As Integer = 0
                Do While i <= DataGridSolarPanel.Rows.Count And j <= DataGridSolarPanel.Rows.Count - 1
                    xlWorkSheet.Cells(i, 1) = DataGridSolarPanel.Rows(j).Cells(0).Value.ToString
                    xlWorkSheet.Cells(i, 2) = DataGridSolarPanel.Rows(j).Cells(1).Value.ToString
                    xlWorkSheet.Cells(i, 3) = DataGridSolarPanel.Rows(j).Cells(2).Value.ToString
                    xlWorkSheet.Cells(i, 4) = DataGridSolarPanel.Rows(j).Cells(3).Value.ToString
                    xlWorkSheet.Cells(i, 5) = DataGridSolarPanel.Rows(j).Cells(4).Value.ToString
                    xlWorkSheet.Cells(i, 6) = DataGridSolarPanel.Rows(j).Cells(5).Value.ToString
                    i = i + 1
                    j = j + 1
                Loop

                xlWorkBook.SaveAs(filesaving)
                xlWorkBook.Close()
                xlApp.Quit()

                Marshal.ReleaseComObject(xlWorkSheet)
                Marshal.ReleaseComObject(xlWorkBook)
                Marshal.ReleaseComObject(xlApp)
                GC.Collect()
                GC.WaitForPendingFinalizers()
                GC.Collect()
                GC.WaitForPendingFinalizers()


                btn_savetoexcel.Text = "Save Data Panel"
                btn_savetoexcel.Enabled = True
                MsgBox("Success saved to : " + filesaving, MsgBoxStyle.Information, Title:=Me.Text)

            Catch ex As Exception
                btn_savetoexcel.Text = "Save Data Panel"
                btn_savetoexcel.Enabled = True
                MsgBox("Failed to saved to : " & filesaving, MsgBoxStyle.Information, Title:=Me.Text)
                'xlApp.Quit()
                Marshal.ReleaseComObject(xlWorkSheet)
                Marshal.ReleaseComObject(xlWorkBook)
                Marshal.ReleaseComObject(xlApp)
                GC.Collect()
                GC.WaitForPendingFinalizers()
                GC.Collect()
                GC.WaitForPendingFinalizers()
            Finally

            End Try

            If CheckBox_autoOpen.Checked = True Then
                Try
                    Process.Start(filesaving)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    ' >>>>>>>>>>>>>>> SAVE EXCEL DATA BEBAN
    Private Sub btn_savetoexcel_beban_Click(sender As Object, e As EventArgs) Handles btn_savetoexcel_beban.Click
        Dim xlApp As New Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        btn_savetoexcel_beban.Text = "Please Wait .."

        btn_savetoexcel_beban.Enabled = False

        Dim logday As String = frmUtama.lbl_day.Text.Replace(":", "-")
        Dim logjam As String = frmUtama.lbl_jam.Text.Replace(":", "-")
        Dim savelog As New SaveFileDialog()
        savelog.Filter = "Excel File (*.xlsx)|*.xlsx|All Files|*.*"
        savelog.Title = "Save File As"
        savelog.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString()
        savelog.FileName = "LOG DATA BEBAN " & logday & " " & logjam

        If savelog.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Dim filesaving As String = savelog.FileName.ToString

            ' EXPORT DATAGRID TO EXCEL
            Try
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                xlWorkSheet = xlWorkBook.Sheets("Sheet1")
                'xlWorkSheet1 = xlWorkBook.Sheets("Data Beban")
                ' --- define worksheet format
                xlApp.StandardFontSize = "12"
                xlWorkSheet.Columns.HorizontalAlignment = Excel.Constants.xlLeft
                'xlWorkSheet1.Columns.HorizontalAlignment = Excel.Constants.xlLeft
                ' --- define columns header
                xlWorkSheet.Cells(1, 1) = "Tanggal / Jam"
                xlWorkSheet.Cells(1, 2) = "Tegangan (VAC)"
                xlWorkSheet.Cells(1, 3) = "Arus (mA)"
                xlWorkSheet.Cells(1, 4) = "Daya (Watt)"
                xlWorkSheet.Cells(1, 5) = "Status Relay"
                xlWorkSheet.Select()
                xlWorkSheet.Range("A1:E1").Select()
                xlWorkSheet.Range("A1:E1").HorizontalAlignment = Excel.Constants.xlCenter
                xlWorkSheet.Range("A1:E1").Font.Bold = True
                xlWorkSheet.Range("A1:E1").Font.Size = "11"
                xlWorkSheet.Range("A1:E1").Font.Name = "Open Sans"

                xlWorkSheet.Range("A:E").EntireColumn.ColumnWidth = "30"

                Dim x As Integer = 2
                Dim y As Integer = 0
                Do While x <= DataGridBeban.Rows.Count And y <= DataGridBeban.Rows.Count - 1
                    xlWorkSheet.Cells(x, 1) = DataGridBeban.Rows(y).Cells(0).Value.ToString
                    xlWorkSheet.Cells(x, 2) = DataGridBeban.Rows(y).Cells(1).Value.ToString
                    xlWorkSheet.Cells(x, 3) = DataGridBeban.Rows(y).Cells(2).Value.ToString
                    xlWorkSheet.Cells(x, 4) = DataGridBeban.Rows(y).Cells(3).Value.ToString
                    xlWorkSheet.Cells(x, 5) = DataGridBeban.Rows(y).Cells(4).Value.ToString
                    x = x + 1
                    y = y + 1
                Loop

                xlWorkBook.SaveAs(filesaving)
                xlWorkBook.Close()
                xlApp.Quit()

                Marshal.ReleaseComObject(xlWorkSheet)
                Marshal.ReleaseComObject(xlWorkBook)
                Marshal.ReleaseComObject(xlApp)
                GC.Collect()
                GC.WaitForPendingFinalizers()
                GC.Collect()
                GC.WaitForPendingFinalizers()


                btn_savetoexcel_beban.Text = "Save Data Beban"
                btn_savetoexcel_beban.Enabled = True
                MsgBox("Success saved to : " + filesaving, MsgBoxStyle.Information, Title:=Me.Text)

            Catch ex As Exception
                btn_savetoexcel_beban.Text = "Save Data Beban"
                btn_savetoexcel_beban.Enabled = True
                MsgBox("Failed to saved to : " & filesaving, MsgBoxStyle.Information, Title:=Me.Text)
                'xlApp.Quit()
                Marshal.ReleaseComObject(xlWorkSheet)
                Marshal.ReleaseComObject(xlWorkBook)
                Marshal.ReleaseComObject(xlApp)
                GC.Collect()
                GC.WaitForPendingFinalizers()
                GC.Collect()
                GC.WaitForPendingFinalizers()
            Finally
                'releaseObject(xlApp)
                'releaseObject(xlWorkBook)
                'releaseObject(xlWorkSheet)
                'releaseObject(misValue)
                'GC.Collect()
            End Try

            If CheckBox_autoOpen.Checked = True Then
                Try
                    Process.Start(filesaving)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub
End Class