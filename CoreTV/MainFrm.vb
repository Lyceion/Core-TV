Imports System.Net
Imports System.Reflection
Imports System.Threading
Public Class MainFrm
    Dim TheCYL As New System.Net.WebClient
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        programDurum.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/ackapa.txt"))
        Dim progSebep As String
        progSebep = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/ackapaMsg.txt"))
        versTXT.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/Versiyon.txt"))
        If versTXT.Text = Application.ProductVersion Then
            If programDurum.Text = "kapali" Then
                If Savings.Default.Language = "TR" Then
                Else
                    ulsPage.Text = " Turkish"
                    sporPage.Text = " Sport"
                    belgPage.Text = " Documentary"
                    sinePage.Text = " Cinema"
                    yabPage.Text = " Foreign"
                    cnn.Text = " CNN Turkish"
                    haberTRK.Text = "Haber Turk"
                    PowerTRK.Text = "Power Turkish [4K]"
                    trtH.Text = "TRT News"
                    MetroButton20.Text = "Core Sport TV 1"
                    MetroButton19.Text = "Core Sport TV 2"
                    MetroButton18.Text = "Core Sport TV 3"
                    MetroButton17.Text = "Core Sport TV 4"
                    MetroButton16.Text = "Tivibu Sport"
                    MetroButton15.Text = "TRT Sport"
                    MetroButton13.Text = "Sports TV"
                    MetroButton27.Text = "TRT Documentary"
                    MetroButton28.Text = "TGRT Documentary"
                    MetroButton26.Text = "Wild TV"
                    MetroButton25.Text = "Hunt TV"
                    MetroButton23.Text = "Farmer TV"
                    MetroButton40.Text = "Core Cinema 1"
                    MetroButton39.Text = "Core Cinema 2"
                    MetroButton38.Text = "Core Cinema 3"
                    MetroButton37.Text = "Core Cinema 4"
                    MetroButton36.Text = "Core Cinema 5"
                    MetroButton35.Text = "Core Cinema 6"
                    MetroButton34.Text = "Core TV Series 1"
                    MetroButton33.Text = "Core Tv Series 2"
                    infoLabel.Text = "Streams Maybe Load Slowly Because Your Internet Speed. If Channels Are Not Working, Please Report To Us!"
                    yabanInfo.Text = "We Are Working" + vbNewLine + "For This." + vbNewLine + "Just Wait :)!"
                End If
                If Savings.Default.Theme = "Dark" Then
                Else
                    Me.Theme = MetroFramework.MetroThemeStyle.Light
                    homePage.Theme = MetroFramework.MetroThemeStyle.Light
                    Duyuru.BackColor = Color.White
                    DuyuruResim.BackColor = Color.White
                    PictureBox5.BackColor = Color.White
                    infoLabel.Theme = MetroFramework.MetroThemeStyle.Light
                    infoPanel.Theme = MetroFramework.MetroThemeStyle.Light
                    channelsTab.Theme = MetroFramework.MetroThemeStyle.Light
                    sideMenu.Theme = MetroFramework.MetroThemeStyle.Light
                    bottomSide.Theme = MetroFramework.MetroThemeStyle.Light
                    PictureBox1.BackColor = Color.White
                    ulsPage.BackColor = Color.White
                    sporPage.BackColor = Color.White
                    belgPage.BackColor = Color.White
                    sinePage.BackColor = Color.White
                    ayarBox.BackColor = Color.White
                    iletBox.BackColor = Color.White
                    infoBox.BackColor = Color.White
                    helpBox.BackColor = Color.White
                    yabanKoru.Theme = MetroFramework.MetroThemeStyle.Light
                    yabanInfo.Theme = MetroFramework.MetroThemeStyle.Light
                    haberTRK.Theme = MetroFramework.MetroThemeStyle.Light
                    cnn.Theme = MetroFramework.MetroThemeStyle.Light
                    tv8.Theme = MetroFramework.MetroThemeStyle.Light
                    star.Theme = MetroFramework.MetroThemeStyle.Light
                    halk.Theme = MetroFramework.MetroThemeStyle.Light
                    beyaz.Theme = MetroFramework.MetroThemeStyle.Light
                    trt1.Theme = MetroFramework.MetroThemeStyle.Light
                    trtH.Theme = MetroFramework.MetroThemeStyle.Light
                    ntv.Theme = MetroFramework.MetroThemeStyle.Light
                    kanalD.Theme = MetroFramework.MetroThemeStyle.Light
                    PowerTRK.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton11.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton12.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton13.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton14.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton15.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton16.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton17.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton18.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton19.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton20.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton21.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton22.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton23.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton24.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton25.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton26.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton27.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton28.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton29.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton30.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton31.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton32.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton33.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton34.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton35.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton36.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton37.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton38.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton39.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton40.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton41.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton42.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton43.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton44.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton45.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton46.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton47.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton48.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton49.Theme = MetroFramework.MetroThemeStyle.Light
                    MetroButton50.Theme = MetroFramework.MetroThemeStyle.Light
                    PowerTRK.Theme = MetroFramework.MetroThemeStyle.Light
                End If
                SporTV1.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/SporTV1.txt"))
                SporTV2.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/SporTV2.txt"))
                SporTV3.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/SporTV3.txt"))
                SporTV4.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/SporTV4.txt"))
                Tivibuspor.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/Tivibuspor.txt"))
                trtSpor.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/TRTSpor.txt"))
                ArenaSport.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/Arenasport.txt"))
                aSpor.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/A_Spor.txt"))
                unknown1.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/unknown1.txt"))
                unknown2.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/unknown2.txt"))

                kanalDLabel.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/KanalD.txt"))
                NTVLabel.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/NTV.txt"))
                beyazLabel.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/Beyaz.txt"))
                trt1Label.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/TRT1.txt"))
                trtHLabel.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/TRTHaber.txt"))
                tv8Label.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/TV8.txt"))
                halkLabel.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/HalkTV.txt"))
                starLabel.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/StarTV.txt"))
                cnnLabel.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/CNN.txt"))
                haberTRKLabel.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/HaberTrk.txt"))
                pwrTRK.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/PowerTRK.txt"))

                Sinema1.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/Sinema1.txt"))
                Sinema2.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/Sinema2.txt"))
                Sinema3.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/Sinema3.txt"))
                Sinema4.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/Sinema4.txt"))
                Sinema5.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/Sinema5.txt"))
                Sinema6.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/Sinema6.txt"))
                Dizi1.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/Dizi1.txt"))
                Dizi2.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/Dizi2.txt"))
                FilTV.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/FilTV.txt"))
                SonyCH.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/SonyCH.txt"))

                D_Max.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/D_MAX.txt"))
                TLC.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/TLC.txt"))
                TRTBelgesel.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/TRT_B.txt"))
                TGRTBelgesel.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/TGRT_B.txt"))
                YabanTV.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/YabanTV.txt"))
                AvTV.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/AvTV.txt"))
                NASATV.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/NASATV.txt"))
                CiftciTV.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/CiftciTV.txt"))

                Duyuru.Text = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/Duyuru.txt"))
                DuyuruResim.ImageLocation = System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/ResLink.txt"))
            Else
                If Savings.Default.Language = "TR" Then

                    MessageBox.Show("Programimiz Su Anlik Kapalidir. Sebep:" + vbNewLine + vbNewLine + progSebep, "Sistem Mesajı!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End
                Else
                    MessageBox.Show("Our Program Is Closed Now. Reason:" + vbNewLine + vbNewLine + progSebep, "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End
                End If
            End If
        Else
            If Savings.Default.Language = "TR" Then

                MessageBox.Show("Program Versiyonunuz Eski! Yeni versiyonun linkine sizi yönlendiriyoruz.", "Sistem Mesajı!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Process.Start(System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/Redir.txt")))
                End
            Else
                MessageBox.Show("Your Program Version Is Old. We are redirecting you to new program's internet adress.", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Process.Start(System.Text.Encoding.ASCII.GetString(TheCYL.DownloadData("http://cylpic.pe.hu/coretv/Redir.txt")))
                End
            End If
        End If
    End Sub
    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
    Private Sub kanalD_Click(sender As Object, e As EventArgs) Handles kanalD.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(kanalDLabel.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False

        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton20_Click(sender As Object, e As EventArgs) Handles MetroButton20.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(SporTV1.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton19_Click(sender As Object, e As EventArgs) Handles MetroButton19.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(SporTV2.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton18_Click(sender As Object, e As EventArgs) Handles MetroButton18.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(SporTV3.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton17_Click(sender As Object, e As EventArgs) Handles MetroButton17.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(SporTV4.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton16_Click(sender As Object, e As EventArgs) Handles MetroButton16.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(Tivibuspor.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton15_Click(sender As Object, e As EventArgs) Handles MetroButton15.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(trtSpor.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton14_Click(sender As Object, e As EventArgs) Handles MetroButton14.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(ArenaSport.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton13_Click(sender As Object, e As EventArgs) Handles MetroButton13.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(aSpor.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles PowerTRK.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(pwrTRK.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton40_Click(sender As Object, e As EventArgs) Handles MetroButton40.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(Sinema1.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton39_Click(sender As Object, e As EventArgs) Handles MetroButton39.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(Sinema2.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton38_Click(sender As Object, e As EventArgs) Handles MetroButton38.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(Sinema3.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton37_Click(sender As Object, e As EventArgs) Handles MetroButton37.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(Sinema4.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton36_Click(sender As Object, e As EventArgs) Handles MetroButton36.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(Sinema5.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton35_Click(sender As Object, e As EventArgs) Handles MetroButton35.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(Sinema6.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton34_Click(sender As Object, e As EventArgs) Handles MetroButton34.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(Dizi1.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton33_Click(sender As Object, e As EventArgs) Handles MetroButton33.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(Dizi2.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton32_Click(sender As Object, e As EventArgs) Handles MetroButton32.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(FilTV.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton31_Click(sender As Object, e As EventArgs) Handles MetroButton31.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(SonyCH.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton30_Click(sender As Object, e As EventArgs) Handles MetroButton30.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(D_Max.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton29_Click(sender As Object, e As EventArgs) Handles MetroButton29.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(TLC.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton28_Click(sender As Object, e As EventArgs) Handles MetroButton28.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(TRTBelgesel.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton27_Click(sender As Object, e As EventArgs) Handles MetroButton27.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(TGRTBelgesel.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton26_Click(sender As Object, e As EventArgs) Handles MetroButton26.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(YabanTV.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton25_Click(sender As Object, e As EventArgs) Handles MetroButton25.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(AvTV.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton24_Click(sender As Object, e As EventArgs) Handles MetroButton24.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(NASATV.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton23_Click(sender As Object, e As EventArgs) Handles MetroButton23.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(CiftciTV.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles ayarBox.Click
        Settings.Show()
    End Sub

    Private Sub iletBox_Click(sender As Object, e As EventArgs) Handles iletBox.Click
        'Message.Show()
        If Savings.Default.Language = "TR" Then
            MessageBox.Show("Forumlardaki konularımıza veya bizlere özel mesaj atarak bildirim yapabilirsiniz...", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("You can report with sending us to private message on forums or you can send comment bellow our forum posts...", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub infoBox_Click(sender As Object, e As EventArgs) Handles infoBox.Click
        MessageBox.Show("CoreTV V2.0.1.7" + vbNewLine + "Programmed By Cylops" + vbNewLine + "Channels By MeliL", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub helpBox_Click(sender As Object, e As EventArgs) Handles helpBox.Click
        If Savings.Default.Language = "TR" Then
            MessageBox.Show("Forumlardaki konularımıza veya bizlere özel mesaj atarak yardım alabilirsiniz...", "Yardım", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Else
            MessageBox.Show("You can get help with sending us to private message on forums or you can send comment bellow our forum posts...", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
    End Sub

    Private Sub haberTRK_Click(sender As Object, e As EventArgs) Handles haberTRK.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(haberTRKLabel.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cnn_Click(sender As Object, e As EventArgs) Handles cnn.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(cnnLabel.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub star_Click(sender As Object, e As EventArgs) Handles star.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(starLabel.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub halk_Click(sender As Object, e As EventArgs) Handles halk.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(halkLabel.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub trt1_Click(sender As Object, e As EventArgs) Handles trt1.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(trt1Label.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub trtH_Click(sender As Object, e As EventArgs) Handles trtH.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(trtH.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ntv_Click(sender As Object, e As EventArgs) Handles ntv.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(NTVLabel.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub tv8_Click(sender As Object, e As EventArgs) Handles tv8.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(tv8Label.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub beyaz_Click(sender As Object, e As EventArgs) Handles beyaz.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(beyazLabel.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        player.playlist.stop()
        homePage.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CheckIfRunning()
    End Sub
    Dim p() As Process
    Dim c() As Process

    Private Sub CheckIfRunning()
        p = Process.GetProcessesByName("Wireshark")
        If p.Count > 0 Then
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName = "Wireshark" Then
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

    Private Sub ShowTV_Click(sender As Object, e As EventArgs) Handles ShowTV.Click
        Try
            homePage.Visible = False
            player.Visible = True
            player.playlist.add(shwTV.Text)
            player.playlist.next()
            'WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox("Kod Hatalı veya Yok!", "HATA", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
