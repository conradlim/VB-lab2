'   *******************************************
'      Lab 3 -  Multimedia // 03.14.17
'      Conrad Lim and Charlie Pierce
'      Advanced Visual Basic - Prof.Flores

'                   PANEL LOCATION: 25, 245
'                   WINDOW SIZE :  960, 817
'   *******************************************

Imports System.Media

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ' resize form on load
        Me.Size = New Size(960, 817)

        ' resize panel location on load
        pnlMultimedia.Location = New Point(25, 245)
        pnlAbout.Location = New Point(25, 245)
        pnlContact.Location = New Point(25, 245)
        pnlPosts.Location = New Point(25, 245)

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

        pnlAbout.Show()
        pnlAbout.BringToFront()
        pnlPosts.Hide()
        pnlMultimedia.Hide()
        pnlContact.Hide()
    End Sub
    Private Sub lblTextA_Click(sender As Object, e As EventArgs) Handles lblTextA.Click
        lblAboutB.Hide()
        lblTextB.Show()
        lblContactB.Hide()
        lblMultiMediaB.Hide()

        pnlPosts.Show()
        pnlPosts.BringToFront()
        pnlAbout.Hide()
        pnlMultimedia.Hide()
        pnlContact.Hide()
    End Sub
    Private Sub lblMultimedia_Click(sender As Object, e As EventArgs) Handles lblMultimedia.Click
        lblAboutB.Hide()
        lblTextB.Hide()
        lblContactB.Hide()
        lblMultiMediaB.Show()

        pnlMultimedia.Show()
        pnlMultimedia.BringToFront()
        pnlAbout.Hide()
        pnlPosts.Hide()
        pnlContact.Hide()
    End Sub
    Private Sub lblContact_Click(sender As Object, e As EventArgs) Handles lblContact.Click
        lblAboutB.Hide()
        lblTextB.Hide()
        lblContactB.Show()
        lblMultiMediaB.Hide()

        pnlContact.Show()
        pnlContact.BringToFront()
        pnlAbout.Hide()
        pnlPosts.Hide()
        pnlMultimedia.Hide()
    End Sub

    Private Sub lblPostOne_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblPostOne.LinkClicked
        pnlBoxPostOne.Show()
        rtbPostOne.Text = lblPostOnePost.Text
        rtbPostOne.Focus()
        rtbPostOne.SelectAll()
    End Sub

    Private Sub btnSavePostOne_Click(sender As Object, e As EventArgs) Handles btnSavePostOne.Click
        lblPostOnePost.Text = rtbPostOne.Text.ToString()
        lblDateOne.Text = DateAndTime.Now.ToString()
        pnlBoxPostOne.Hide()
    End Sub

    Private Sub lnkPostTwo_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkPostTwo.LinkClicked
        pnlBoxTwo.Show()
        rtbPostTwo.Text = lblPostTwoPost.Text
        rtbPostTwo.Focus()
        rtbPostTwo.SelectAll()
    End Sub

    Private Sub btnSaveTwo_Click(sender As Object, e As EventArgs) Handles btnSaveTwo.Click
        lblPostTwoPost.Text = rtbPostTwo.Text.ToString()
        lblDateTwo.Text = DateAndTime.Now.ToString()
        pnlBoxTwo.Hide()
    End Sub

    Private Sub lnkPostThree_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkPostThree.LinkClicked
        pnlSaveToFile.Show()
        rtbSaveToFile.Text = lblPostThreePost.Text
        rtbSaveToFile.Focus()
        rtbSaveToFile.SelectAll()
    End Sub

    Private Sub btnSaveToFile_Click_2(sender As Object, e As EventArgs) Handles btnSaveToFile.Click
        With SaveFileDialog1
            .Title = "Save File"
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

    Private Sub btnOpenVid_Click_1(sender As Object, e As EventArgs) Handles btnOpenVid.Click
        With OpenFileDialog1
            .Title = "Video Player"
            .Filter = "Video files (*.wmv;*.mp4) | *.wmv; *.mp4"
            .CheckFileExists = True
        End With

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            AxWindowsMediaPlayer1.Visible = True
            OpenFileDialog1.ShowDialog()
            AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName

        Else
            MessageBox.Show("File does not exist. Please try a new file", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnCloseMedia_Click(sender As Object, e As EventArgs) Handles btnCloseMedia.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        AxWindowsMediaPlayer1.URL = ""
    End Sub

    Private Sub btnAudioWelcome_Click(sender As Object, e As EventArgs) Handles btnAudioWelcome.Click
        Dim BackToTheFuture As New Media.SoundPlayer(My.Resources.welcome)
        BackToTheFuture.Play()

    End Sub

    Private Sub btnAudioOffer_Click(sender As Object, e As EventArgs) Handles btnAudioOffer.Click
        Dim MarlonBrando As New Media.SoundPlayer(My.Resources.goodOffer)
        MarlonBrando.Play()
    End Sub

    Private Sub btnAudioPacino_Click(sender As Object, e As EventArgs) Handles btnAudioPacino.Click
        Dim AlPacino As New Media.SoundPlayer(My.Resources.godfather2)
        AlPacino.Play()
    End Sub

    Private Sub btnAudioTerminaotr_Click(sender As Object, e As EventArgs) Handles btnAudioTerminator.Click
        Dim theTerminator As New Media.SoundPlayer(My.Resources.terminator)
        theTerminator.Play()
    End Sub
End Class