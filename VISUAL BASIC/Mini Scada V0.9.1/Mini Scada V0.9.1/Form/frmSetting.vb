Public Class frmSetting

    Private Sub check_box_token_OnChange(sender As Object, e As EventArgs) Handles check_box_token.OnChange
        If check_box_token.Checked = True Then
            tbox_token.isPassword = False
        Else
            tbox_token.isPassword = True
        End If
    End Sub
End Class