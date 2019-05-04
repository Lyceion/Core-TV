Public Class Message
    Dim TheCYL As New System.Net.WebClient
    Private Sub Message_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Savings.Default.Language = "TR" Then
        Else
            Me.Text = "Report"
            MetroButton1.Text = "REPORT US!"
            MetroLabel1.Text = "Statuts:"
            MetroLabel2.Text = "Channel:"
            MetroComboBox1.Items.Clear()
            MetroComboBox1.Items.Add("Stream Not Working")
            MetroComboBox1.Items.Add("Stream Is Freezing")
            MetroComboBox1.Items.Add("Stream Quality Is Very Bad")
        End If
        If Savings.Default.Theme = "Dark" Then

        Else
            Me.Theme = MetroFramework.MetroThemeStyle.Light
            MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
            MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Light
            MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Light
            MetroComboBox1.Theme = MetroFramework.MetroThemeStyle.Light
            MetroComboBox2.Theme = MetroFramework.MetroThemeStyle.Light
        End If
        RichTextBox1.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/Bildirimler.txt"))
        MetroComboBox1.SelectedIndex = 0
    End Sub

    Private Sub repActive_Tick(sender As Object, e As EventArgs) Handles repActive.Tick
        If MetroComboBox2.Text = "" Then
            MetroButton1.Enabled = False
        Else
            MetroButton1.Enabled = True
        End If
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        RichTextBox2.Text = "[" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "] |CH=> " + MetroComboBox2.Text + "| PRB=> " + MetroComboBox1.Text + " |" + vbNewLine + RichTextBox1.Text
        'GO FUCK YOURSELF!
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CheckIfRunning()
    End Sub
    Dim p() As Process
    Dim c() As Process

    Private Sub CheckIfRunning()
        p = Process.GetProcessesByName("Wireshark.exe")
        If p.Count > 0 Then
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName = "Wireshark.exe" Then
                    prog.Kill()
                End If
            Next
        Else
            ' Process is not running
        End If
        c = Process.GetProcessesByName("NLClientApp")
        If c.Count > 0 Then
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName = "NLClientApp" Then
                    prog.Kill()
                End If
            Next
        Else
            ' Process is not running
        End If
    End Sub
End Class