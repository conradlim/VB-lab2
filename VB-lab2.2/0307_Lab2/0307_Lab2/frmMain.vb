
Public Class frmMain

    Private Sub frmLab2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlAbout.Visible = True
        lblAboutB.Visible = True
        Dim r As New Rectangle(0, 0, picbCL.Width, picbCL.Height)
        Dim gp As New System.Drawing.Drawing2D.GraphicsPath()
        Dim d As Integer = 50
        gp.AddArc(r.X, r.Y, d, d, 180, 90)
        gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90)
        gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90)
        gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90)
        picbCL.Region = New Region(gp)

        Dim r2 As New Rectangle(0, 0, picBCP.Width, picBCP.Height)
        Dim gp2 As New System.Drawing.Drawing2D.GraphicsPath()
        Dim d2 As Integer = 50
        gp2.AddArc(r2.X, r2.Y, d2, d2, 180, 90)
        gp2.AddArc(r2.X + r2.Width - d2, r2.Y, d2, d2, 270, 90)
        gp2.AddArc(r2.X + r2.Width - d2, r2.Y + r2.Height - d2, d2, d2, 0, 90)
        gp2.AddArc(r2.X, r2.Y + r2.Height - d2, d2, d2, 90, 90)
        picBCP.Region = New Region(gp)

        'Dim p As New Drawing2D.GraphicsPath
        'p.StartFigure()
        'p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        'p.AddLine(40, 0, Me.Width - 40, 0)
        'p.AddArc(New Rectangle(picbCL.Width - 40, 0, 40, 40), -90, 90)
        'p.AddLine(picbCL.Width, 40, picbCL.Width, picbCL.Height - 40)
        'p.AddArc(New Rectangle(picbCL.Width - 40, picbCL.Height - 40, 40, 40), 0, 90)
        'p.AddLine(picbCL.Width - 40, picbCL.Height, 40, picbCL.Height)
        'p.AddArc(New Rectangle(0, picbCL.Height - 40, 40, 40), 90, 90)
        'p.CloseFigure()
        'picbCL.Region = New Region(p)

        'Dim c As New Drawing2D.GraphicsPath
        'c.StartFigure()
        'c.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        'c.AddLine(40, 0, picBCP.Width - 40, 0)
        'c.AddArc(New Rectangle(picBCP.Width - 40, 0, 40, 40), -90, 90)
        'c.AddLine(picBCP.Width, 40, picBCP.Width, picBCP.Height - 40)
        'c.AddArc(New Rectangle(picBCP.Width - 40, picBCP.Height - 40, 40, 40), 0, 90)
        'c.AddLine(picbCL.Width - 40, picbCL.Height, 40, picbCL.Height)
        'c.AddArc(New Rectangle(0, picBCP.Height - 40, 40, 40), 90, 90)
        'c.CloseFigure()
        'picBCP.Region = New Region(p)


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

    Private Sub lblAbout_Click(sender As Object, e As EventArgs) Handles lblAbout.Click
        ' pnlAbout.BringToFront()

        lblAboutB.Show()
        lblPostsB.Hide()
        lblContactB.Hide()
        lblPhotoB.Hide()

        Panel1.Hide()
        pnlAbout.Show()
        pnlPosts.Hide()
        pnlContact.Hide()


    End Sub
    Private Sub lblPosts_Click(sender As Object, e As EventArgs) Handles lblPosts.Click

        lblAboutB.Hide()
        lblPostsB.Show()
        lblContactB.Hide()
        lblPhotoB.Hide()

        Panel1.Hide()
        pnlPosts.Show()
        pnlContact.Hide()
        pnlAbout.Hide()


    End Sub
    Private Sub lblPhotos_Click(sender As Object, e As EventArgs) Handles lblPhotos.Click
        lblAboutB.Hide()
        lblPostsB.Hide()
        lblContactB.Hide()
        lblPhotoB.Show()
        Panel1.Show()
        pnlContact.Hide()
        pnlAbout.Hide()
        pnlPosts.Hide()

    End Sub
    Private Sub lblContact_Click(sender As Object, e As EventArgs) Handles lblContact.Click

        lblAboutB.Hide()
        lblPostsB.Hide()
        lblContactB.Show()
        lblPhotoB.Hide()
        Panel1.Hide()
        pnlContact.Show()
        pnlAbout.Hide()
        pnlPosts.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        pnlVideo.Show()
        AxWindowsMediaPlayer1.URL = "C:\Users\clim16\Desktop\0\0\My Project\Multimedia\Videos\VID_21110103_002302.mp4"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        pnlVideo.Hide()
    End Sub

    Private Sub btnSavePostOne_Click(sender As Object, e As EventArgs) Handles btnSavePostOne.Click
        lblPostOnePost.Text = rtbPostOne.Text.ToString()
        lblDateOne.Text = DateAndTime.Now.ToString()

        pnlBoxPostOne.Hide()
    End Sub

    Private Sub lblPostOne_MouseHover(sender As Object, e As EventArgs) Handles lblPostOness.MouseHover

    End Sub

    Private Sub lblPostOne_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblPostOne.LinkClicked
        pnlBoxPostOne.Show()
        rtbPostOne.Text = lblPostOnePost.Text.ToString()

    End Sub
End Class