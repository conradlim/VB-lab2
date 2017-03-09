'   *******************************************
'      Lab 2.2 Animate and Layering // 03.09.17
'      Conrad Lim and Charlie Pierce
'      Advanced Visual Basic - Prof.Flores
'   *******************************************
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

        lblAboutB.Show()
        lblTextB.Hide()
        lblContactB.Hide()
        lblMultiMediaB.Hide()

        pnlMultimedia.Hide()
        pnlAbout.Show()
        pnlPosts.Hide()
        pnlContact.Hide()


    End Sub
    Private Sub lblTextA_Click(sender As Object, e As EventArgs) Handles lblTextA.Click

        lblAboutB.Hide()
        lblTextB.Show()
        lblContactB.Hide()
        lblMultiMediaB.Hide()

        pnlPosts.Show()
        pnlPosts.BringToFront()
        'pnlMultimedia.SendToBack()
        pnlContact.Hide()
        pnlAbout.Hide()



    End Sub
    Private Sub lblMultimedia_Click(sender As Object, e As EventArgs) Handles lblMultimedia.Click
        lblAboutB.Hide()
        lblTextB.Hide()
        lblContactB.Hide()
        lblMultiMediaB.Show()
        pnlMultimedia.Show()
        pnlContact.Hide()
        pnlAbout.Hide()
        pnlPosts.Hide()

    End Sub
    Private Sub lblContact_Click(sender As Object, e As EventArgs) Handles lblContact.Click

        lblAboutB.Hide()
        lblTextB.Hide()
        lblContactB.Show()
        lblMultiMediaB.Hide()
        pnlMultimedia.Hide()
        pnlContact.Show()
        pnlAbout.Hide()
        pnlPosts.Hide()
    End Sub


    Private Sub lblPostOne_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        pnlBoxPostOne.Show()
        rtbPostOne.Text = lblPostOnePost.Text.ToString()

    End Sub

    Private Sub lnkPostTwo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        pnlBoxTwo.Show()
        rtbPostTwo.Text = lblPostTwoPost.Text.ToString()
    End Sub


    Private Sub lnkPostThree_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        pnlSaveToFile.Show()
        rtbSaveToFile.Text = lblPostThreePost.Text.ToString()
    End Sub


    Private Sub btnOpenVid_Click(sender As Object, e As EventArgs)
        AxWindowsMediaPlayer1.URL = ""
    End Sub


    Private Sub btnSavePostOne_Click(sender As Object, e As EventArgs) Handles btnSavePostOne.Click
        lblPostOnePost.Text = rtbPostOne.Text.ToString()
        lblDateOne.Text = DateAndTime.Now.ToString()

        pnlBoxPostOne.Hide()
    End Sub

    Private Sub btnSaveTwo_Click(sender As Object, e As EventArgs) Handles btnSaveTwo.Click
        lblPostTwoPost.Text = rtbPostTwo.Text.ToString()
        lblDateTwo.Text = DateAndTime.Now.ToString()
        pnlBoxTwo.Hide()
    End Sub

    Private Sub btnSaveToFile_Click(sender As Object, e As EventArgs)
        With SaveFileDialog1
            .Title = "Open File"
            .Filter = "Rich Text Files | *.rtf"
            .DefaultExt = ".rtf"
            .OverwritePrompt = True
        End With

        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            rtbSaveToFile.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
        End If

        lblPostThreePost.Text = rtbSaveToFile.ToString()
        pnlSaveToFile.Hide()
        lblDateThree.Text = DateAndTime.Now().ToString()
    End Sub


    Private Sub btnSavePostOne_Click_1(sender As Object, e As EventArgs)
        lblPostOnePost.Text = rtbPostOne.Text.ToString()
        lblDateOne.Text = DateAndTime.Now.ToString()

        pnlBoxPostOne.Hide()
    End Sub
    Private Sub btnSaveToFile_Click_1(sender As Object, e As EventArgs)
        With SaveFileDialog1
            .Title = "Open File"
            .Filter = "Rich Text Files | *.rtf"
            .DefaultExt = ".rtf"
            .OverwritePrompt = True
        End With

        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            rtbSaveToFile.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
        End If

        lblPostThreePost.Text = rtbSaveToFile.ToString()
        pnlSaveToFile.Hide()
        lblDateThree.Text = DateAndTime.Now().ToString()
    End Sub

    Private Sub btnSaveTwo_Click_1(sender As Object, e As EventArgs)
        lblPostTwoPost.Text = rtbPostTwo.Text.ToString()
        lblDateTwo.Text = DateAndTime.Now.ToString()
        pnlBoxTwo.Hide()
    End Sub

    Private Sub lblPostOne_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblPostOne.LinkClicked
        pnlBoxPostOne.Show()
        rtbPostOne.Text = lblPostOnePost.Text.ToString()
    End Sub

    Private Sub lnkPostTwo_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkPostTwo.LinkClicked
        pnlBoxTwo.Show()
        rtbPostTwo.Text = lblPostTwoPost.Text.ToString()
    End Sub

    Private Sub lnkPostThree_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkPostThree.LinkClicked
        pnlSaveToFile.Show()
        rtbSaveToFile.Text = lblPostThreePost.Text.ToString()
    End Sub

    Private Sub btnOpenVid_Click_1(sender As Object, e As EventArgs) Handles btnOpenVid.Click
        AxWindowsMediaPlayer1.Visible = True
        OpenFileDialog1.ShowDialog()
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
    End Sub

    Private Sub btnSaveToFile_Click_2(sender As Object, e As EventArgs) Handles btnSaveToFile.Click
        With SaveFileDialog1
            .Title = "Open File"
            .Filter = "Rich Text Files | *.rtf"
            .DefaultExt = ".rtf"
            .OverwritePrompt = True
        End With

        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            rtbSaveToFile.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
        End If

        lblPostThreePost.Text = rtbSaveToFile.Text.ToString()
        pnlSaveToFile.Hide()
        lblDateThree.Text = DateAndTime.Now().ToString()
    End Sub

    Private Sub btnCloseMedia_Click(sender As Object, e As EventArgs) Handles btnCloseMedia.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        AxWindowsMediaPlayer1.URL = ""
    End Sub
End Class