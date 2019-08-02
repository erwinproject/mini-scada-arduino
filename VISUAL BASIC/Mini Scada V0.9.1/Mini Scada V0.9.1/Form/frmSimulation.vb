Imports System.Math

Public Class frmSimulation

    Private Sub btn_result_voc_Click(sender As Object, e As EventArgs) Handles btn_result_voc.Click
        Dim value_n As Double = Val(tbox_idealyFactor.Text)
        Dim kelvin As Double = Val(tbox_kelvin.Text)
        Dim Io As Double = Val(tbox_I0.Text)
        Dim IL As Double = Val(tbox_IL.Text)
        Dim ktperq As Double = (1.3806488 / 16020) * kelvin
        Dim ln_process As Double = (IL / Io) + 1
        Dim voc As Double = (value_n * ktperq) * (Math.Log(ln_process))
        Dim result_voc As Double = Round(voc, 5)

        'result_voc = Replace(result_voc, ",", ".")

        tbox_result_VOC.Text = result_voc
    End Sub

    Private Sub btn_result_ff_Click(sender As Object, e As EventArgs) Handles btn_result_ff.Click
        Dim data_voc As Double = Val(tbox_ff_voc.Text)
        Dim data_isc As Double = Val(tbox_ff_isc.Text)
        Dim data_vmp As Double = Val(tbox_ff_vmp.Text)
        Dim data_imp As Double = Val(tbox_ff_imp.Text)

        Dim data_ff As Double = (data_vmp * data_imp) / (data_voc * data_isc)
        Dim result_ff As Double = Round(data_ff, 5)

        tbox_result_FF.Text = result_ff.ToString
    End Sub

    Private Sub btn_TempConvert_Click(sender As Object, e As EventArgs) Handles btn_TempConvert.Click
        Dim data_C As Double = Val(tbox_TC_C.Text)
        Dim data_K As Double = Val(tbox_TC_K.Text)

        If cbox_TC.Text = "C to K" Then
            data_K = data_C + 273.15
            tbox_TC_K.Text = data_K.ToString
        ElseIf cbox_TC.Text = "K to C" Then
            data_C = data_K - 273.15
            tbox_TC_C.Text = data_C.ToString
        End If

    End Sub

    Private Sub btn_InputPower_Click(sender As Object, e As EventArgs) Handles btn_InputPower.Click
        Dim length As Double = Val(tbox_InputPower_length.Text)
        Dim width As Double = Val(tbox_InputPower_width.Text)
        Dim powersolar As Double = Val(tbox_InputPower_powerm2.Text)
        Dim inputpower As Double = ((length * width) * powersolar)

        'inputpower = Replace(inputpower, ",", ".")
        tbox_Result_InputPower.Text = inputpower.ToString
    End Sub

    Private Sub btn_efficiency_maximumpower_Click(sender As Object, e As EventArgs) Handles btn_efficiency_maximumpower.Click
        Dim data_voc As Double = Val(tbox_efficiency_voc.Text)
        Dim data_isc As Double = Val(tbox_efficiency_isc.Text)
        Dim data_FF As Double = Val(tbox_efficiency_ff.Text)
        Dim maximumpower As Double = data_voc * data_isc * data_FF

        tbox_result_efficiency_pmax.Text = maximumpower.ToString
    End Sub

    Private Sub btn_efficiency_Click(sender As Object, e As EventArgs) Handles btn_efficiency.Click
        Dim data_voc As Double = Val(tbox_efficiency_voc.Text)
        Dim data_isc As Double = Val(tbox_efficiency_isc.Text)
        Dim data_FF As Double = Val(tbox_efficiency_ff.Text)
        Dim data_Pin As Double = Val(tbox_efficiency_pin.Text)

        Dim result_efficiency As Double = ((data_voc * data_isc * data_FF) / data_Pin) * 100

        tbox_result_efficiency.Text = result_efficiency.ToString
    End Sub
End Class