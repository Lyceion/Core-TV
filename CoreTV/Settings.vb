Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Savings.Default.Language = "TR" Then
            lanCombo.SelectedIndex = "0"
            themeCombo.Items.Add("Koyu")
            themeCombo.Items.Add("Açık")
        Else
            Me.Text = "Settings"
            MetroLabel1.Text = "Theme"
            MetroLabel2.Text = "Lang"
            MetroLabel3.Text = "*Settings Will Apply After Restarting Program."
            MetroButton1.Text = "Save"
            themeCombo.Items.Add("Dark")
            themeCombo.Items.Add("Light")
            lanCombo.SelectedIndex = "1"
        End If
        If Savings.Default.Theme = "Dark" Then
            Me.Theme = MetroFramework.MetroThemeStyle.Dark
            themeCombo.Theme = MetroFramework.MetroThemeStyle.Dark
            lanCombo.Theme = MetroFramework.MetroThemeStyle.Dark
            MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
            MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
            MetroButton1.Theme = MetroFramework.MetroThemeStyle.Dark
            themeCombo.SelectedIndex = 0
        Else
            Me.Theme = MetroFramework.MetroThemeStyle.Light
            themeCombo.Theme = MetroFramework.MetroThemeStyle.Light
            lanCombo.Theme = MetroFramework.MetroThemeStyle.Light
            MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Light
            MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Light
            MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Light
            MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
            themeCombo.SelectedIndex = 1
        End If
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If themeCombo.SelectedIndex = 0 Then
            Savings.Default.Theme = "Dark"
            Savings.Default.Save()
        Else
            Savings.Default.Theme = "Light"
            Savings.Default.Save()
        End If
        If lanCombo.SelectedIndex = 0 Then
            Savings.Default.Language = "TR"
            Savings.Default.Save()
            MessageBox.Show("Değişiklikler Program Yeniden Başladığında Aktif Olacaktır.", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Savings.Default.Language = "EN"
            Savings.Default.Save()
            MessageBox.Show("Settings Will Apply After Restart The Program.", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CheckIfRunning()
    End Sub
    Dim p() As Process
    Dim C() As Process

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