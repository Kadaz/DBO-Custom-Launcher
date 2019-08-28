Public Class Form1

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim open As New OpenFileDialog
        Dim res As String
        Dim names
        open.ShowDialog()
        open.Filter = "All Files(*.*)|*.*"
        names = open.FileName
        If IO.File.Exists(names) Then
            MsgBox("You Have select:" + names, MsgBoxStyle.Information)
            res = MsgBox("Do You Want To open It?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If res = vbYes Then
                System.Diagnostics.Process.Start(names)
            Else
                Exit Sub
            End If
        End If
        My.Computer.Audio.Stop()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("https://discord.gg/CYbbKrn")
        My.Computer.Audio.Stop()
        NotifyIcon1.Visible = True
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("http://www.dbocom.com/")
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start("http://www.dbocom.com/tools/skill-calculator/")
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Dragon_Ball_Online_Original_Soundtrack_73_Kokkara_Zona_2, AudioPlayMode.Background)
    End Sub
End Class
