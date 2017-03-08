Public Class frmSplash
    Private Sub tmrClose_Tick(sender As Object, e As EventArgs) Handles tmrClose.Tick
        frmMain.Show()
        Me.Close()
    End Sub
End Class