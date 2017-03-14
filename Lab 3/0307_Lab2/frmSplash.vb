'   *******************************************
'      Lab 3 -  Multimedia // 03.14.17
'      Conrad Lim and Charlie Pierce
'      Advanced Visual Basic - Prof.Flores
'   *******************************************

Public Class frmSplash
    Private Sub tmrClose_Tick(sender As Object, e As EventArgs) Handles tmrClose.Tick
        frmMain.Show()
        Me.Close()
    End Sub
End Class