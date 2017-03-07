
Public Class frmLab2

    Private Sub frmLab2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlAbout.Visible = True
        'pnlContact.Visible = True


        Dim p As New Drawing2D.GraphicsPath
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        p.AddLine(40, 0, Me.Width - 40, 0)
        p.AddArc(New Rectangle(picbCL.Width - 40, 0, 40, 40), -90, 90)
        p.AddLine(picbCL.Width, 40, picbCL.Width, picbCL.Height - 40)
        p.AddArc(New Rectangle(picbCL.Width - 40, picbCL.Height - 40, 40, 40), 0, 90)
        p.AddLine(picbCL.Width - 40, picbCL.Height, 40, picbCL.Height)
        p.AddArc(New Rectangle(0, picbCL.Height - 40, 40, 40), 90, 90)
        p.CloseFigure()
        picbCL.Region = New Region(p)

        Dim c As New Drawing2D.GraphicsPath
        c.StartFigure()
        c.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        c.AddLine(40, 0, picBCP.Width - 40, 0)
        c.AddArc(New Rectangle(picBCP.Width - 40, 0, 40, 40), -90, 90)
        c.AddLine(picBCP.Width, 40, picBCP.Width, picBCP.Height - 40)
        c.AddArc(New Rectangle(picBCP.Width - 40, picBCP.Height - 40, 40, 40), 0, 90)
        c.AddLine(picbCL.Width - 40, picbCL.Height, 40, picbCL.Height)
        c.AddArc(New Rectangle(0, picBCP.Height - 40, 40, 40), 90, 90)
        c.CloseFigure()
        picBCP.Region = New Region(p)


        Me.Opacity = 0.99


    End Sub

    Private Sub FadingForm()

        Dim iCount As Integer

        For iCount = 90 To 10 Step -10

            Me.Opacity = iCount / 100

            Me.Refresh()

            Threading.Thread.Sleep(50)

        Next

        Me.Close()

    End Sub
    Private Sub label_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAbout.Click, lblContact.Click,
            lblName.Click, lblPhotos.Click, lblPosts.Click
        Dim lblClicked = TryCast(sender, Label)
        If lblClicked.Text = lblAbout.Text Then
            pnlAbout.Show()
        ElseIf lblClicked.Text = lblPosts.Text Then
            pnlPosts.Show()
        ElseIf lblClicked.Text = lblContact.Text Then
            pnlContact.Show()
        End If
    End Sub

    'Private Sub lblAbout_Click(sender As Object, e As EventArgs) Handles lblAbout.Click
    '    pnlAbout.BringToFront()
    '    pnlAbout.Show()
    '    pnlPosts.Hide()

    'End Sub
    'Private Sub lblPosts_Click(sender As Object, e As EventArgs) Handles lblPosts.Click

    '    pnlPosts.Show()
    '    pnlContact.Hide()
    '    pnlAbout.Hide()


    'End Sub

    'Private Sub lblContact_Click(sender As Object, e As EventArgs) Handles lblContact.Click

    '    pnlContact.Show()
    '    pnlAbout.Hide()
    '    pnlPosts.Hide()
    'End Sub


End Class