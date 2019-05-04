<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFrm
    Inherits MetroFramework.Forms.MetroForm 'System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
        Me.sideMenu = New MetroFramework.Controls.MetroPanel()
        Me.bottomSide = New MetroFramework.Controls.MetroPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.helpBox = New System.Windows.Forms.PictureBox()
        Me.infoBox = New System.Windows.Forms.PictureBox()
        Me.iletBox = New System.Windows.Forms.PictureBox()
        Me.ayarBox = New System.Windows.Forms.PictureBox()
        Me.channelsTab = New MetroFramework.Controls.MetroTabControl()
        Me.sporPage = New System.Windows.Forms.TabPage()
        Me.unknown2 = New MetroFramework.Controls.MetroLabel()
        Me.unknown1 = New MetroFramework.Controls.MetroLabel()
        Me.aSpor = New MetroFramework.Controls.MetroLabel()
        Me.ArenaSport = New MetroFramework.Controls.MetroLabel()
        Me.trtSpor = New MetroFramework.Controls.MetroLabel()
        Me.Tivibuspor = New MetroFramework.Controls.MetroLabel()
        Me.SporTV4 = New MetroFramework.Controls.MetroLabel()
        Me.SporTV3 = New MetroFramework.Controls.MetroLabel()
        Me.SporTV2 = New MetroFramework.Controls.MetroLabel()
        Me.SporTV1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton11 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton12 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton13 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton14 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton15 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton16 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton17 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton18 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton19 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton20 = New MetroFramework.Controls.MetroButton()
        Me.ulsPage = New System.Windows.Forms.TabPage()
        Me.pwrTRK = New MetroFramework.Controls.MetroLabel()
        Me.PowerTRK = New MetroFramework.Controls.MetroButton()
        Me.haberTRKLabel = New MetroFramework.Controls.MetroLabel()
        Me.cnnLabel = New MetroFramework.Controls.MetroLabel()
        Me.tv8Label = New MetroFramework.Controls.MetroLabel()
        Me.starLabel = New MetroFramework.Controls.MetroLabel()
        Me.halkLabel = New MetroFramework.Controls.MetroLabel()
        Me.beyazLabel = New MetroFramework.Controls.MetroLabel()
        Me.trt1Label = New MetroFramework.Controls.MetroLabel()
        Me.trtHLabel = New MetroFramework.Controls.MetroLabel()
        Me.NTVLabel = New MetroFramework.Controls.MetroLabel()
        Me.kanalDLabel = New MetroFramework.Controls.MetroLabel()
        Me.haberTRK = New MetroFramework.Controls.MetroButton()
        Me.cnn = New MetroFramework.Controls.MetroButton()
        Me.tv8 = New MetroFramework.Controls.MetroButton()
        Me.star = New MetroFramework.Controls.MetroButton()
        Me.halk = New MetroFramework.Controls.MetroButton()
        Me.beyaz = New MetroFramework.Controls.MetroButton()
        Me.trt1 = New MetroFramework.Controls.MetroButton()
        Me.trtH = New MetroFramework.Controls.MetroButton()
        Me.ntv = New MetroFramework.Controls.MetroButton()
        Me.kanalD = New MetroFramework.Controls.MetroButton()
        Me.sinePage = New System.Windows.Forms.TabPage()
        Me.SonyCH = New MetroFramework.Controls.MetroLabel()
        Me.FilTV = New MetroFramework.Controls.MetroLabel()
        Me.Dizi2 = New MetroFramework.Controls.MetroLabel()
        Me.Dizi1 = New MetroFramework.Controls.MetroLabel()
        Me.Sinema6 = New MetroFramework.Controls.MetroLabel()
        Me.Sinema5 = New MetroFramework.Controls.MetroLabel()
        Me.Sinema4 = New MetroFramework.Controls.MetroLabel()
        Me.Sinema3 = New MetroFramework.Controls.MetroLabel()
        Me.Sinema2 = New MetroFramework.Controls.MetroLabel()
        Me.Sinema1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton31 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton32 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton33 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton34 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton35 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton36 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton37 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton38 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton39 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton40 = New MetroFramework.Controls.MetroButton()
        Me.belgPage = New System.Windows.Forms.TabPage()
        Me.Unknown4 = New MetroFramework.Controls.MetroLabel()
        Me.Unknown3 = New MetroFramework.Controls.MetroLabel()
        Me.CiftciTV = New MetroFramework.Controls.MetroLabel()
        Me.NASATV = New MetroFramework.Controls.MetroLabel()
        Me.AvTV = New MetroFramework.Controls.MetroLabel()
        Me.TGRTBelgesel = New MetroFramework.Controls.MetroLabel()
        Me.YabanTV = New MetroFramework.Controls.MetroLabel()
        Me.TRTBelgesel = New MetroFramework.Controls.MetroLabel()
        Me.TLC = New MetroFramework.Controls.MetroLabel()
        Me.D_Max = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton21 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton22 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton23 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton24 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton25 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton26 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton27 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton28 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton29 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton30 = New MetroFramework.Controls.MetroButton()
        Me.yabPage = New System.Windows.Forms.TabPage()
        Me.yabanKoru = New MetroFramework.Controls.MetroPanel()
        Me.yabanInfo = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton41 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton42 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton43 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton44 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton45 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton46 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton47 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton48 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton49 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton50 = New MetroFramework.Controls.MetroButton()
        Me.mainMenu = New MetroFramework.Controls.MetroPanel()
        Me.infoPanel = New MetroFramework.Controls.MetroPanel()
        Me.infoLabel = New MetroFramework.Controls.MetroLabel()
        Me.player = New AxAXVLC.AxVLCPlugin2()
        Me.homePage = New MetroFramework.Controls.MetroPanel()
        Me.DuyuruResim = New System.Windows.Forms.PictureBox()
        Me.duyuruBar = New MetroFramework.Controls.MetroPanel()
        Me.Duyuru = New System.Windows.Forms.RichTextBox()
        Me.programDurum = New MetroFramework.Controls.MetroLabel()
        Me.versTXT = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ShowTV = New MetroFramework.Controls.MetroButton()
        Me.shwTV = New MetroFramework.Controls.MetroLabel()
        Me.sideMenu.SuspendLayout()
        Me.bottomSide.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.helpBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.infoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iletBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ayarBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.channelsTab.SuspendLayout()
        Me.sporPage.SuspendLayout()
        Me.ulsPage.SuspendLayout()
        Me.sinePage.SuspendLayout()
        Me.belgPage.SuspendLayout()
        Me.yabPage.SuspendLayout()
        Me.yabanKoru.SuspendLayout()
        Me.mainMenu.SuspendLayout()
        Me.infoPanel.SuspendLayout()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.homePage.SuspendLayout()
        CType(Me.DuyuruResim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.duyuruBar.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sideMenu
        '
        Me.sideMenu.Controls.Add(Me.bottomSide)
        Me.sideMenu.Controls.Add(Me.channelsTab)
        Me.sideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.sideMenu.HorizontalScrollbarBarColor = True
        Me.sideMenu.HorizontalScrollbarHighlightOnWheel = False
        Me.sideMenu.HorizontalScrollbarSize = 10
        Me.sideMenu.Location = New System.Drawing.Point(20, 60)
        Me.sideMenu.Name = "sideMenu"
        Me.sideMenu.Size = New System.Drawing.Size(249, 598)
        Me.sideMenu.Style = MetroFramework.MetroColorStyle.Orange
        Me.sideMenu.TabIndex = 0
        Me.sideMenu.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.sideMenu.UseStyleColors = True
        Me.sideMenu.VerticalScrollbarBarColor = True
        Me.sideMenu.VerticalScrollbarHighlightOnWheel = False
        Me.sideMenu.VerticalScrollbarSize = 10
        '
        'bottomSide
        '
        Me.bottomSide.Controls.Add(Me.PictureBox1)
        Me.bottomSide.Controls.Add(Me.helpBox)
        Me.bottomSide.Controls.Add(Me.infoBox)
        Me.bottomSide.Controls.Add(Me.iletBox)
        Me.bottomSide.Controls.Add(Me.ayarBox)
        Me.bottomSide.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottomSide.HorizontalScrollbarBarColor = True
        Me.bottomSide.HorizontalScrollbarHighlightOnWheel = False
        Me.bottomSide.HorizontalScrollbarSize = 10
        Me.bottomSide.Location = New System.Drawing.Point(0, 554)
        Me.bottomSide.Name = "bottomSide"
        Me.bottomSide.Size = New System.Drawing.Size(249, 44)
        Me.bottomSide.Style = MetroFramework.MetroColorStyle.Orange
        Me.bottomSide.TabIndex = 3
        Me.bottomSide.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.bottomSide.VerticalScrollbarBarColor = True
        Me.bottomSide.VerticalScrollbarHighlightOnWheel = False
        Me.bottomSide.VerticalScrollbarSize = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.PictureBox1.Image = Global.CoreTV.My.Resources.Resources.home
        Me.PictureBox1.Location = New System.Drawing.Point(9, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'helpBox
        '
        Me.helpBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.helpBox.Image = Global.CoreTV.My.Resources.Resources.soru
        Me.helpBox.Location = New System.Drawing.Point(212, 4)
        Me.helpBox.Name = "helpBox"
        Me.helpBox.Size = New System.Drawing.Size(31, 32)
        Me.helpBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.helpBox.TabIndex = 11
        Me.helpBox.TabStop = False
        '
        'infoBox
        '
        Me.infoBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.infoBox.Image = Global.CoreTV.My.Resources.Resources.bilgi
        Me.infoBox.Location = New System.Drawing.Point(181, 4)
        Me.infoBox.Name = "infoBox"
        Me.infoBox.Size = New System.Drawing.Size(31, 32)
        Me.infoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.infoBox.TabIndex = 10
        Me.infoBox.TabStop = False
        '
        'iletBox
        '
        Me.iletBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.iletBox.Image = Global.CoreTV.My.Resources.Resources.iletisim
        Me.iletBox.Location = New System.Drawing.Point(150, 4)
        Me.iletBox.Name = "iletBox"
        Me.iletBox.Size = New System.Drawing.Size(31, 32)
        Me.iletBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iletBox.TabIndex = 9
        Me.iletBox.TabStop = False
        '
        'ayarBox
        '
        Me.ayarBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ayarBox.Image = Global.CoreTV.My.Resources.Resources.ayarlar
        Me.ayarBox.Location = New System.Drawing.Point(119, 4)
        Me.ayarBox.Name = "ayarBox"
        Me.ayarBox.Size = New System.Drawing.Size(31, 32)
        Me.ayarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ayarBox.TabIndex = 8
        Me.ayarBox.TabStop = False
        '
        'channelsTab
        '
        Me.channelsTab.Controls.Add(Me.ulsPage)
        Me.channelsTab.Controls.Add(Me.sporPage)
        Me.channelsTab.Controls.Add(Me.sinePage)
        Me.channelsTab.Controls.Add(Me.belgPage)
        Me.channelsTab.Controls.Add(Me.yabPage)
        Me.channelsTab.Dock = System.Windows.Forms.DockStyle.Top
        Me.channelsTab.Location = New System.Drawing.Point(0, 0)
        Me.channelsTab.Name = "channelsTab"
        Me.channelsTab.SelectedIndex = 0
        Me.channelsTab.Size = New System.Drawing.Size(249, 552)
        Me.channelsTab.Style = MetroFramework.MetroColorStyle.Orange
        Me.channelsTab.TabIndex = 0
        Me.channelsTab.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.channelsTab.UseSelectable = True
        '
        'sporPage
        '
        Me.sporPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.sporPage.Controls.Add(Me.unknown2)
        Me.sporPage.Controls.Add(Me.unknown1)
        Me.sporPage.Controls.Add(Me.aSpor)
        Me.sporPage.Controls.Add(Me.ArenaSport)
        Me.sporPage.Controls.Add(Me.trtSpor)
        Me.sporPage.Controls.Add(Me.Tivibuspor)
        Me.sporPage.Controls.Add(Me.SporTV4)
        Me.sporPage.Controls.Add(Me.SporTV3)
        Me.sporPage.Controls.Add(Me.SporTV2)
        Me.sporPage.Controls.Add(Me.SporTV1)
        Me.sporPage.Controls.Add(Me.MetroButton11)
        Me.sporPage.Controls.Add(Me.MetroButton12)
        Me.sporPage.Controls.Add(Me.MetroButton13)
        Me.sporPage.Controls.Add(Me.MetroButton14)
        Me.sporPage.Controls.Add(Me.MetroButton15)
        Me.sporPage.Controls.Add(Me.MetroButton16)
        Me.sporPage.Controls.Add(Me.MetroButton17)
        Me.sporPage.Controls.Add(Me.MetroButton18)
        Me.sporPage.Controls.Add(Me.MetroButton19)
        Me.sporPage.Controls.Add(Me.MetroButton20)
        Me.sporPage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.sporPage.Location = New System.Drawing.Point(4, 38)
        Me.sporPage.Name = "sporPage"
        Me.sporPage.Size = New System.Drawing.Size(241, 510)
        Me.sporPage.TabIndex = 1
        Me.sporPage.Text = "  Spor"
        '
        'unknown2
        '
        Me.unknown2.AutoSize = True
        Me.unknown2.Location = New System.Drawing.Point(6, 475)
        Me.unknown2.Name = "unknown2"
        Me.unknown2.Size = New System.Drawing.Size(88, 19)
        Me.unknown2.Style = MetroFramework.MetroColorStyle.Orange
        Me.unknown2.TabIndex = 29
        Me.unknown2.Text = "MetroLabel10"
        Me.unknown2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.unknown2.UseStyleColors = True
        Me.unknown2.Visible = False
        '
        'unknown1
        '
        Me.unknown1.AutoSize = True
        Me.unknown1.Location = New System.Drawing.Point(6, 451)
        Me.unknown1.Name = "unknown1"
        Me.unknown1.Size = New System.Drawing.Size(83, 19)
        Me.unknown1.Style = MetroFramework.MetroColorStyle.Orange
        Me.unknown1.TabIndex = 28
        Me.unknown1.Text = "MetroLabel9"
        Me.unknown1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.unknown1.UseStyleColors = True
        Me.unknown1.Visible = False
        '
        'aSpor
        '
        Me.aSpor.AutoSize = True
        Me.aSpor.Location = New System.Drawing.Point(6, 427)
        Me.aSpor.Name = "aSpor"
        Me.aSpor.Size = New System.Drawing.Size(83, 19)
        Me.aSpor.Style = MetroFramework.MetroColorStyle.Orange
        Me.aSpor.TabIndex = 27
        Me.aSpor.Text = "MetroLabel8"
        Me.aSpor.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.aSpor.UseStyleColors = True
        Me.aSpor.Visible = False
        '
        'ArenaSport
        '
        Me.ArenaSport.AutoSize = True
        Me.ArenaSport.Location = New System.Drawing.Point(6, 404)
        Me.ArenaSport.Name = "ArenaSport"
        Me.ArenaSport.Size = New System.Drawing.Size(83, 19)
        Me.ArenaSport.Style = MetroFramework.MetroColorStyle.Orange
        Me.ArenaSport.TabIndex = 26
        Me.ArenaSport.Text = "MetroLabel7"
        Me.ArenaSport.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ArenaSport.UseStyleColors = True
        Me.ArenaSport.Visible = False
        '
        'trtSpor
        '
        Me.trtSpor.AutoSize = True
        Me.trtSpor.Location = New System.Drawing.Point(6, 380)
        Me.trtSpor.Name = "trtSpor"
        Me.trtSpor.Size = New System.Drawing.Size(83, 19)
        Me.trtSpor.Style = MetroFramework.MetroColorStyle.Orange
        Me.trtSpor.TabIndex = 25
        Me.trtSpor.Text = "MetroLabel6"
        Me.trtSpor.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.trtSpor.UseStyleColors = True
        Me.trtSpor.Visible = False
        '
        'Tivibuspor
        '
        Me.Tivibuspor.AutoSize = True
        Me.Tivibuspor.Location = New System.Drawing.Point(6, 357)
        Me.Tivibuspor.Name = "Tivibuspor"
        Me.Tivibuspor.Size = New System.Drawing.Size(83, 19)
        Me.Tivibuspor.Style = MetroFramework.MetroColorStyle.Orange
        Me.Tivibuspor.TabIndex = 24
        Me.Tivibuspor.Text = "MetroLabel5"
        Me.Tivibuspor.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Tivibuspor.UseStyleColors = True
        Me.Tivibuspor.Visible = False
        '
        'SporTV4
        '
        Me.SporTV4.AutoSize = True
        Me.SporTV4.Location = New System.Drawing.Point(147, 357)
        Me.SporTV4.Name = "SporTV4"
        Me.SporTV4.Size = New System.Drawing.Size(83, 19)
        Me.SporTV4.Style = MetroFramework.MetroColorStyle.Orange
        Me.SporTV4.TabIndex = 23
        Me.SporTV4.Text = "MetroLabel4"
        Me.SporTV4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.SporTV4.UseStyleColors = True
        Me.SporTV4.Visible = False
        '
        'SporTV3
        '
        Me.SporTV3.AutoSize = True
        Me.SporTV3.Location = New System.Drawing.Point(147, 379)
        Me.SporTV3.Name = "SporTV3"
        Me.SporTV3.Size = New System.Drawing.Size(83, 19)
        Me.SporTV3.Style = MetroFramework.MetroColorStyle.Orange
        Me.SporTV3.TabIndex = 22
        Me.SporTV3.Text = "MetroLabel3"
        Me.SporTV3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.SporTV3.UseStyleColors = True
        Me.SporTV3.Visible = False
        '
        'SporTV2
        '
        Me.SporTV2.AutoSize = True
        Me.SporTV2.Location = New System.Drawing.Point(147, 402)
        Me.SporTV2.Name = "SporTV2"
        Me.SporTV2.Size = New System.Drawing.Size(83, 19)
        Me.SporTV2.Style = MetroFramework.MetroColorStyle.Orange
        Me.SporTV2.TabIndex = 21
        Me.SporTV2.Text = "MetroLabel2"
        Me.SporTV2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.SporTV2.UseStyleColors = True
        Me.SporTV2.Visible = False
        '
        'SporTV1
        '
        Me.SporTV1.AutoSize = True
        Me.SporTV1.Location = New System.Drawing.Point(147, 425)
        Me.SporTV1.Name = "SporTV1"
        Me.SporTV1.Size = New System.Drawing.Size(81, 19)
        Me.SporTV1.Style = MetroFramework.MetroColorStyle.Orange
        Me.SporTV1.TabIndex = 20
        Me.SporTV1.Text = "MetroLabel1"
        Me.SporTV1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.SporTV1.UseStyleColors = True
        Me.SporTV1.Visible = False
        '
        'MetroButton11
        '
        Me.MetroButton11.Location = New System.Drawing.Point(1, 293)
        Me.MetroButton11.Name = "MetroButton11"
        Me.MetroButton11.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton11.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton11.TabIndex = 19
        Me.MetroButton11.Text = "Unkown"
        Me.MetroButton11.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton11.UseSelectable = True
        Me.MetroButton11.UseStyleColors = True
        Me.MetroButton11.Visible = False
        '
        'MetroButton12
        '
        Me.MetroButton12.Location = New System.Drawing.Point(1, 264)
        Me.MetroButton12.Name = "MetroButton12"
        Me.MetroButton12.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton12.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton12.TabIndex = 18
        Me.MetroButton12.Text = "Unkown"
        Me.MetroButton12.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton12.UseSelectable = True
        Me.MetroButton12.UseStyleColors = True
        Me.MetroButton12.Visible = False
        '
        'MetroButton13
        '
        Me.MetroButton13.Location = New System.Drawing.Point(1, 235)
        Me.MetroButton13.Name = "MetroButton13"
        Me.MetroButton13.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton13.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton13.TabIndex = 17
        Me.MetroButton13.Text = "Sports TV"
        Me.MetroButton13.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton13.UseSelectable = True
        Me.MetroButton13.UseStyleColors = True
        '
        'MetroButton14
        '
        Me.MetroButton14.Location = New System.Drawing.Point(1, 206)
        Me.MetroButton14.Name = "MetroButton14"
        Me.MetroButton14.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton14.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton14.TabIndex = 16
        Me.MetroButton14.Text = "Arena Sport"
        Me.MetroButton14.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton14.UseSelectable = True
        Me.MetroButton14.UseStyleColors = True
        '
        'MetroButton15
        '
        Me.MetroButton15.Location = New System.Drawing.Point(1, 177)
        Me.MetroButton15.Name = "MetroButton15"
        Me.MetroButton15.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton15.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton15.TabIndex = 15
        Me.MetroButton15.Text = "TRT Spor"
        Me.MetroButton15.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton15.UseSelectable = True
        Me.MetroButton15.UseStyleColors = True
        '
        'MetroButton16
        '
        Me.MetroButton16.Location = New System.Drawing.Point(1, 148)
        Me.MetroButton16.Name = "MetroButton16"
        Me.MetroButton16.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton16.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton16.TabIndex = 14
        Me.MetroButton16.Text = "Tivibu Spor"
        Me.MetroButton16.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton16.UseSelectable = True
        Me.MetroButton16.UseStyleColors = True
        '
        'MetroButton17
        '
        Me.MetroButton17.Location = New System.Drawing.Point(1, 119)
        Me.MetroButton17.Name = "MetroButton17"
        Me.MetroButton17.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton17.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton17.TabIndex = 13
        Me.MetroButton17.Text = "Core Spor TV 4"
        Me.MetroButton17.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton17.UseSelectable = True
        Me.MetroButton17.UseStyleColors = True
        '
        'MetroButton18
        '
        Me.MetroButton18.Location = New System.Drawing.Point(1, 90)
        Me.MetroButton18.Name = "MetroButton18"
        Me.MetroButton18.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton18.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton18.TabIndex = 12
        Me.MetroButton18.Text = "Core Spor TV 3"
        Me.MetroButton18.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton18.UseSelectable = True
        Me.MetroButton18.UseStyleColors = True
        '
        'MetroButton19
        '
        Me.MetroButton19.Location = New System.Drawing.Point(1, 61)
        Me.MetroButton19.Name = "MetroButton19"
        Me.MetroButton19.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton19.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton19.TabIndex = 11
        Me.MetroButton19.Text = "Core Spor TV 2"
        Me.MetroButton19.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton19.UseSelectable = True
        Me.MetroButton19.UseStyleColors = True
        '
        'MetroButton20
        '
        Me.MetroButton20.Location = New System.Drawing.Point(0, 32)
        Me.MetroButton20.Name = "MetroButton20"
        Me.MetroButton20.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton20.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton20.TabIndex = 10
        Me.MetroButton20.Text = "Core Spor TV 1"
        Me.MetroButton20.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton20.UseSelectable = True
        Me.MetroButton20.UseStyleColors = True
        '
        'ulsPage
        '
        Me.ulsPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ulsPage.Controls.Add(Me.shwTV)
        Me.ulsPage.Controls.Add(Me.ShowTV)
        Me.ulsPage.Controls.Add(Me.pwrTRK)
        Me.ulsPage.Controls.Add(Me.PowerTRK)
        Me.ulsPage.Controls.Add(Me.haberTRKLabel)
        Me.ulsPage.Controls.Add(Me.cnnLabel)
        Me.ulsPage.Controls.Add(Me.tv8Label)
        Me.ulsPage.Controls.Add(Me.starLabel)
        Me.ulsPage.Controls.Add(Me.halkLabel)
        Me.ulsPage.Controls.Add(Me.beyazLabel)
        Me.ulsPage.Controls.Add(Me.trt1Label)
        Me.ulsPage.Controls.Add(Me.trtHLabel)
        Me.ulsPage.Controls.Add(Me.NTVLabel)
        Me.ulsPage.Controls.Add(Me.kanalDLabel)
        Me.ulsPage.Controls.Add(Me.haberTRK)
        Me.ulsPage.Controls.Add(Me.cnn)
        Me.ulsPage.Controls.Add(Me.tv8)
        Me.ulsPage.Controls.Add(Me.star)
        Me.ulsPage.Controls.Add(Me.halk)
        Me.ulsPage.Controls.Add(Me.beyaz)
        Me.ulsPage.Controls.Add(Me.trt1)
        Me.ulsPage.Controls.Add(Me.trtH)
        Me.ulsPage.Controls.Add(Me.ntv)
        Me.ulsPage.Controls.Add(Me.kanalD)
        Me.ulsPage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ulsPage.Location = New System.Drawing.Point(4, 38)
        Me.ulsPage.Name = "ulsPage"
        Me.ulsPage.Size = New System.Drawing.Size(241, 510)
        Me.ulsPage.TabIndex = 0
        Me.ulsPage.Text = " Ulusal"
        '
        'pwrTRK
        '
        Me.pwrTRK.AutoSize = True
        Me.pwrTRK.Location = New System.Drawing.Point(145, 464)
        Me.pwrTRK.Name = "pwrTRK"
        Me.pwrTRK.Size = New System.Drawing.Size(88, 19)
        Me.pwrTRK.Style = MetroFramework.MetroColorStyle.Orange
        Me.pwrTRK.TabIndex = 21
        Me.pwrTRK.Text = "MetroLabel10"
        Me.pwrTRK.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.pwrTRK.UseStyleColors = True
        Me.pwrTRK.Visible = False
        '
        'PowerTRK
        '
        Me.PowerTRK.Location = New System.Drawing.Point(1, 322)
        Me.PowerTRK.Name = "PowerTRK"
        Me.PowerTRK.Size = New System.Drawing.Size(234, 23)
        Me.PowerTRK.Style = MetroFramework.MetroColorStyle.Orange
        Me.PowerTRK.TabIndex = 20
        Me.PowerTRK.Text = "Power Türk [4K]"
        Me.PowerTRK.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.PowerTRK.UseSelectable = True
        Me.PowerTRK.UseStyleColors = True
        '
        'haberTRKLabel
        '
        Me.haberTRKLabel.AutoSize = True
        Me.haberTRKLabel.Location = New System.Drawing.Point(5, 490)
        Me.haberTRKLabel.Name = "haberTRKLabel"
        Me.haberTRKLabel.Size = New System.Drawing.Size(88, 19)
        Me.haberTRKLabel.Style = MetroFramework.MetroColorStyle.Orange
        Me.haberTRKLabel.TabIndex = 19
        Me.haberTRKLabel.Text = "MetroLabel10"
        Me.haberTRKLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.haberTRKLabel.UseStyleColors = True
        Me.haberTRKLabel.Visible = False
        '
        'cnnLabel
        '
        Me.cnnLabel.AutoSize = True
        Me.cnnLabel.Location = New System.Drawing.Point(5, 466)
        Me.cnnLabel.Name = "cnnLabel"
        Me.cnnLabel.Size = New System.Drawing.Size(83, 19)
        Me.cnnLabel.Style = MetroFramework.MetroColorStyle.Orange
        Me.cnnLabel.TabIndex = 18
        Me.cnnLabel.Text = "MetroLabel9"
        Me.cnnLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cnnLabel.UseStyleColors = True
        Me.cnnLabel.Visible = False
        '
        'tv8Label
        '
        Me.tv8Label.AutoSize = True
        Me.tv8Label.Location = New System.Drawing.Point(5, 442)
        Me.tv8Label.Name = "tv8Label"
        Me.tv8Label.Size = New System.Drawing.Size(83, 19)
        Me.tv8Label.Style = MetroFramework.MetroColorStyle.Orange
        Me.tv8Label.TabIndex = 17
        Me.tv8Label.Text = "MetroLabel8"
        Me.tv8Label.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tv8Label.UseStyleColors = True
        Me.tv8Label.Visible = False
        '
        'starLabel
        '
        Me.starLabel.AutoSize = True
        Me.starLabel.Location = New System.Drawing.Point(5, 419)
        Me.starLabel.Name = "starLabel"
        Me.starLabel.Size = New System.Drawing.Size(83, 19)
        Me.starLabel.Style = MetroFramework.MetroColorStyle.Orange
        Me.starLabel.TabIndex = 16
        Me.starLabel.Text = "MetroLabel7"
        Me.starLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.starLabel.UseStyleColors = True
        Me.starLabel.Visible = False
        '
        'halkLabel
        '
        Me.halkLabel.AutoSize = True
        Me.halkLabel.Location = New System.Drawing.Point(5, 395)
        Me.halkLabel.Name = "halkLabel"
        Me.halkLabel.Size = New System.Drawing.Size(83, 19)
        Me.halkLabel.Style = MetroFramework.MetroColorStyle.Orange
        Me.halkLabel.TabIndex = 15
        Me.halkLabel.Text = "MetroLabel6"
        Me.halkLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.halkLabel.UseStyleColors = True
        Me.halkLabel.Visible = False
        '
        'beyazLabel
        '
        Me.beyazLabel.AutoSize = True
        Me.beyazLabel.Location = New System.Drawing.Point(5, 372)
        Me.beyazLabel.Name = "beyazLabel"
        Me.beyazLabel.Size = New System.Drawing.Size(83, 19)
        Me.beyazLabel.Style = MetroFramework.MetroColorStyle.Orange
        Me.beyazLabel.TabIndex = 14
        Me.beyazLabel.Text = "MetroLabel5"
        Me.beyazLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.beyazLabel.UseStyleColors = True
        Me.beyazLabel.Visible = False
        '
        'trt1Label
        '
        Me.trt1Label.AutoSize = True
        Me.trt1Label.Location = New System.Drawing.Point(146, 372)
        Me.trt1Label.Name = "trt1Label"
        Me.trt1Label.Size = New System.Drawing.Size(83, 19)
        Me.trt1Label.Style = MetroFramework.MetroColorStyle.Orange
        Me.trt1Label.TabIndex = 13
        Me.trt1Label.Text = "MetroLabel4"
        Me.trt1Label.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.trt1Label.UseStyleColors = True
        Me.trt1Label.Visible = False
        '
        'trtHLabel
        '
        Me.trtHLabel.AutoSize = True
        Me.trtHLabel.Location = New System.Drawing.Point(146, 394)
        Me.trtHLabel.Name = "trtHLabel"
        Me.trtHLabel.Size = New System.Drawing.Size(83, 19)
        Me.trtHLabel.Style = MetroFramework.MetroColorStyle.Orange
        Me.trtHLabel.TabIndex = 12
        Me.trtHLabel.Text = "MetroLabel3"
        Me.trtHLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.trtHLabel.UseStyleColors = True
        Me.trtHLabel.Visible = False
        '
        'NTVLabel
        '
        Me.NTVLabel.AutoSize = True
        Me.NTVLabel.Location = New System.Drawing.Point(146, 417)
        Me.NTVLabel.Name = "NTVLabel"
        Me.NTVLabel.Size = New System.Drawing.Size(83, 19)
        Me.NTVLabel.Style = MetroFramework.MetroColorStyle.Orange
        Me.NTVLabel.TabIndex = 11
        Me.NTVLabel.Text = "MetroLabel2"
        Me.NTVLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.NTVLabel.UseStyleColors = True
        Me.NTVLabel.Visible = False
        '
        'kanalDLabel
        '
        Me.kanalDLabel.AutoSize = True
        Me.kanalDLabel.Location = New System.Drawing.Point(146, 440)
        Me.kanalDLabel.Name = "kanalDLabel"
        Me.kanalDLabel.Size = New System.Drawing.Size(81, 19)
        Me.kanalDLabel.Style = MetroFramework.MetroColorStyle.Orange
        Me.kanalDLabel.TabIndex = 10
        Me.kanalDLabel.Text = "MetroLabel1"
        Me.kanalDLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.kanalDLabel.UseStyleColors = True
        Me.kanalDLabel.Visible = False
        '
        'haberTRK
        '
        Me.haberTRK.Location = New System.Drawing.Point(1, 292)
        Me.haberTRK.Name = "haberTRK"
        Me.haberTRK.Size = New System.Drawing.Size(234, 23)
        Me.haberTRK.Style = MetroFramework.MetroColorStyle.Orange
        Me.haberTRK.TabIndex = 9
        Me.haberTRK.Text = "Haber Türk"
        Me.haberTRK.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.haberTRK.UseSelectable = True
        Me.haberTRK.UseStyleColors = True
        '
        'cnn
        '
        Me.cnn.Location = New System.Drawing.Point(1, 263)
        Me.cnn.Name = "cnn"
        Me.cnn.Size = New System.Drawing.Size(234, 23)
        Me.cnn.Style = MetroFramework.MetroColorStyle.Orange
        Me.cnn.TabIndex = 8
        Me.cnn.Text = "CNN Türk"
        Me.cnn.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cnn.UseSelectable = True
        Me.cnn.UseStyleColors = True
        '
        'tv8
        '
        Me.tv8.Location = New System.Drawing.Point(1, 234)
        Me.tv8.Name = "tv8"
        Me.tv8.Size = New System.Drawing.Size(234, 23)
        Me.tv8.Style = MetroFramework.MetroColorStyle.Orange
        Me.tv8.TabIndex = 7
        Me.tv8.Text = "TV 8"
        Me.tv8.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tv8.UseSelectable = True
        Me.tv8.UseStyleColors = True
        '
        'star
        '
        Me.star.Location = New System.Drawing.Point(1, 205)
        Me.star.Name = "star"
        Me.star.Size = New System.Drawing.Size(234, 23)
        Me.star.Style = MetroFramework.MetroColorStyle.Orange
        Me.star.TabIndex = 6
        Me.star.Text = "Star TV"
        Me.star.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.star.UseSelectable = True
        Me.star.UseStyleColors = True
        '
        'halk
        '
        Me.halk.Location = New System.Drawing.Point(1, 176)
        Me.halk.Name = "halk"
        Me.halk.Size = New System.Drawing.Size(234, 23)
        Me.halk.Style = MetroFramework.MetroColorStyle.Orange
        Me.halk.TabIndex = 5
        Me.halk.Text = "Halk TV"
        Me.halk.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.halk.UseSelectable = True
        Me.halk.UseStyleColors = True
        '
        'beyaz
        '
        Me.beyaz.Location = New System.Drawing.Point(1, 147)
        Me.beyaz.Name = "beyaz"
        Me.beyaz.Size = New System.Drawing.Size(234, 23)
        Me.beyaz.Style = MetroFramework.MetroColorStyle.Orange
        Me.beyaz.TabIndex = 4
        Me.beyaz.Text = "Beyaz TV"
        Me.beyaz.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.beyaz.UseSelectable = True
        Me.beyaz.UseStyleColors = True
        '
        'trt1
        '
        Me.trt1.Location = New System.Drawing.Point(1, 118)
        Me.trt1.Name = "trt1"
        Me.trt1.Size = New System.Drawing.Size(234, 23)
        Me.trt1.Style = MetroFramework.MetroColorStyle.Orange
        Me.trt1.TabIndex = 3
        Me.trt1.Text = "TRT 1"
        Me.trt1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.trt1.UseSelectable = True
        Me.trt1.UseStyleColors = True
        '
        'trtH
        '
        Me.trtH.Location = New System.Drawing.Point(1, 89)
        Me.trtH.Name = "trtH"
        Me.trtH.Size = New System.Drawing.Size(234, 23)
        Me.trtH.Style = MetroFramework.MetroColorStyle.Orange
        Me.trtH.TabIndex = 2
        Me.trtH.Text = "TRT Haber"
        Me.trtH.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.trtH.UseSelectable = True
        Me.trtH.UseStyleColors = True
        '
        'ntv
        '
        Me.ntv.Location = New System.Drawing.Point(1, 60)
        Me.ntv.Name = "ntv"
        Me.ntv.Size = New System.Drawing.Size(234, 23)
        Me.ntv.Style = MetroFramework.MetroColorStyle.Orange
        Me.ntv.TabIndex = 1
        Me.ntv.Text = "NTV"
        Me.ntv.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ntv.UseSelectable = True
        Me.ntv.UseStyleColors = True
        '
        'kanalD
        '
        Me.kanalD.Location = New System.Drawing.Point(0, 31)
        Me.kanalD.Name = "kanalD"
        Me.kanalD.Size = New System.Drawing.Size(234, 23)
        Me.kanalD.Style = MetroFramework.MetroColorStyle.Orange
        Me.kanalD.TabIndex = 0
        Me.kanalD.Text = "Kanal D"
        Me.kanalD.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.kanalD.UseSelectable = True
        Me.kanalD.UseStyleColors = True
        '
        'sinePage
        '
        Me.sinePage.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.sinePage.Controls.Add(Me.SonyCH)
        Me.sinePage.Controls.Add(Me.FilTV)
        Me.sinePage.Controls.Add(Me.Dizi2)
        Me.sinePage.Controls.Add(Me.Dizi1)
        Me.sinePage.Controls.Add(Me.Sinema6)
        Me.sinePage.Controls.Add(Me.Sinema5)
        Me.sinePage.Controls.Add(Me.Sinema4)
        Me.sinePage.Controls.Add(Me.Sinema3)
        Me.sinePage.Controls.Add(Me.Sinema2)
        Me.sinePage.Controls.Add(Me.Sinema1)
        Me.sinePage.Controls.Add(Me.MetroButton31)
        Me.sinePage.Controls.Add(Me.MetroButton32)
        Me.sinePage.Controls.Add(Me.MetroButton33)
        Me.sinePage.Controls.Add(Me.MetroButton34)
        Me.sinePage.Controls.Add(Me.MetroButton35)
        Me.sinePage.Controls.Add(Me.MetroButton36)
        Me.sinePage.Controls.Add(Me.MetroButton37)
        Me.sinePage.Controls.Add(Me.MetroButton38)
        Me.sinePage.Controls.Add(Me.MetroButton39)
        Me.sinePage.Controls.Add(Me.MetroButton40)
        Me.sinePage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.sinePage.Location = New System.Drawing.Point(4, 38)
        Me.sinePage.Name = "sinePage"
        Me.sinePage.Size = New System.Drawing.Size(241, 510)
        Me.sinePage.TabIndex = 3
        Me.sinePage.Text = " Sinema"
        '
        'SonyCH
        '
        Me.SonyCH.AutoSize = True
        Me.SonyCH.Location = New System.Drawing.Point(6, 449)
        Me.SonyCH.Name = "SonyCH"
        Me.SonyCH.Size = New System.Drawing.Size(88, 19)
        Me.SonyCH.Style = MetroFramework.MetroColorStyle.Orange
        Me.SonyCH.TabIndex = 39
        Me.SonyCH.Text = "MetroLabel10"
        Me.SonyCH.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.SonyCH.UseStyleColors = True
        Me.SonyCH.Visible = False
        '
        'FilTV
        '
        Me.FilTV.AutoSize = True
        Me.FilTV.Location = New System.Drawing.Point(6, 425)
        Me.FilTV.Name = "FilTV"
        Me.FilTV.Size = New System.Drawing.Size(83, 19)
        Me.FilTV.Style = MetroFramework.MetroColorStyle.Orange
        Me.FilTV.TabIndex = 38
        Me.FilTV.Text = "MetroLabel9"
        Me.FilTV.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.FilTV.UseStyleColors = True
        Me.FilTV.Visible = False
        '
        'Dizi2
        '
        Me.Dizi2.AutoSize = True
        Me.Dizi2.Location = New System.Drawing.Point(6, 401)
        Me.Dizi2.Name = "Dizi2"
        Me.Dizi2.Size = New System.Drawing.Size(83, 19)
        Me.Dizi2.Style = MetroFramework.MetroColorStyle.Orange
        Me.Dizi2.TabIndex = 37
        Me.Dizi2.Text = "MetroLabel8"
        Me.Dizi2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Dizi2.UseStyleColors = True
        Me.Dizi2.Visible = False
        '
        'Dizi1
        '
        Me.Dizi1.AutoSize = True
        Me.Dizi1.Location = New System.Drawing.Point(6, 378)
        Me.Dizi1.Name = "Dizi1"
        Me.Dizi1.Size = New System.Drawing.Size(83, 19)
        Me.Dizi1.Style = MetroFramework.MetroColorStyle.Orange
        Me.Dizi1.TabIndex = 36
        Me.Dizi1.Text = "MetroLabel7"
        Me.Dizi1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Dizi1.UseStyleColors = True
        Me.Dizi1.Visible = False
        '
        'Sinema6
        '
        Me.Sinema6.AutoSize = True
        Me.Sinema6.Location = New System.Drawing.Point(6, 354)
        Me.Sinema6.Name = "Sinema6"
        Me.Sinema6.Size = New System.Drawing.Size(83, 19)
        Me.Sinema6.Style = MetroFramework.MetroColorStyle.Orange
        Me.Sinema6.TabIndex = 35
        Me.Sinema6.Text = "MetroLabel6"
        Me.Sinema6.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Sinema6.UseStyleColors = True
        Me.Sinema6.Visible = False
        '
        'Sinema5
        '
        Me.Sinema5.AutoSize = True
        Me.Sinema5.Location = New System.Drawing.Point(6, 331)
        Me.Sinema5.Name = "Sinema5"
        Me.Sinema5.Size = New System.Drawing.Size(83, 19)
        Me.Sinema5.Style = MetroFramework.MetroColorStyle.Orange
        Me.Sinema5.TabIndex = 34
        Me.Sinema5.Text = "MetroLabel5"
        Me.Sinema5.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Sinema5.UseStyleColors = True
        Me.Sinema5.Visible = False
        '
        'Sinema4
        '
        Me.Sinema4.AutoSize = True
        Me.Sinema4.Location = New System.Drawing.Point(147, 331)
        Me.Sinema4.Name = "Sinema4"
        Me.Sinema4.Size = New System.Drawing.Size(83, 19)
        Me.Sinema4.Style = MetroFramework.MetroColorStyle.Orange
        Me.Sinema4.TabIndex = 33
        Me.Sinema4.Text = "MetroLabel4"
        Me.Sinema4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Sinema4.UseStyleColors = True
        Me.Sinema4.Visible = False
        '
        'Sinema3
        '
        Me.Sinema3.AutoSize = True
        Me.Sinema3.Location = New System.Drawing.Point(147, 353)
        Me.Sinema3.Name = "Sinema3"
        Me.Sinema3.Size = New System.Drawing.Size(83, 19)
        Me.Sinema3.Style = MetroFramework.MetroColorStyle.Orange
        Me.Sinema3.TabIndex = 32
        Me.Sinema3.Text = "MetroLabel3"
        Me.Sinema3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Sinema3.UseStyleColors = True
        Me.Sinema3.Visible = False
        '
        'Sinema2
        '
        Me.Sinema2.AutoSize = True
        Me.Sinema2.Location = New System.Drawing.Point(147, 376)
        Me.Sinema2.Name = "Sinema2"
        Me.Sinema2.Size = New System.Drawing.Size(83, 19)
        Me.Sinema2.Style = MetroFramework.MetroColorStyle.Orange
        Me.Sinema2.TabIndex = 31
        Me.Sinema2.Text = "MetroLabel2"
        Me.Sinema2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Sinema2.UseStyleColors = True
        Me.Sinema2.Visible = False
        '
        'Sinema1
        '
        Me.Sinema1.AutoSize = True
        Me.Sinema1.Location = New System.Drawing.Point(147, 399)
        Me.Sinema1.Name = "Sinema1"
        Me.Sinema1.Size = New System.Drawing.Size(81, 19)
        Me.Sinema1.Style = MetroFramework.MetroColorStyle.Orange
        Me.Sinema1.TabIndex = 30
        Me.Sinema1.Text = "MetroLabel1"
        Me.Sinema1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Sinema1.UseStyleColors = True
        Me.Sinema1.Visible = False
        '
        'MetroButton31
        '
        Me.MetroButton31.Location = New System.Drawing.Point(1, 293)
        Me.MetroButton31.Name = "MetroButton31"
        Me.MetroButton31.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton31.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton31.TabIndex = 19
        Me.MetroButton31.Text = "Sony Channel"
        Me.MetroButton31.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton31.UseSelectable = True
        Me.MetroButton31.UseStyleColors = True
        '
        'MetroButton32
        '
        Me.MetroButton32.Location = New System.Drawing.Point(1, 264)
        Me.MetroButton32.Name = "MetroButton32"
        Me.MetroButton32.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton32.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton32.TabIndex = 18
        Me.MetroButton32.Text = "Fil TV"
        Me.MetroButton32.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton32.UseSelectable = True
        Me.MetroButton32.UseStyleColors = True
        '
        'MetroButton33
        '
        Me.MetroButton33.Location = New System.Drawing.Point(1, 235)
        Me.MetroButton33.Name = "MetroButton33"
        Me.MetroButton33.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton33.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton33.TabIndex = 17
        Me.MetroButton33.Text = "Core Dizi 2"
        Me.MetroButton33.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton33.UseSelectable = True
        Me.MetroButton33.UseStyleColors = True
        '
        'MetroButton34
        '
        Me.MetroButton34.Location = New System.Drawing.Point(1, 206)
        Me.MetroButton34.Name = "MetroButton34"
        Me.MetroButton34.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton34.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton34.TabIndex = 16
        Me.MetroButton34.Text = "Core Dizi 1"
        Me.MetroButton34.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton34.UseSelectable = True
        Me.MetroButton34.UseStyleColors = True
        '
        'MetroButton35
        '
        Me.MetroButton35.Location = New System.Drawing.Point(1, 177)
        Me.MetroButton35.Name = "MetroButton35"
        Me.MetroButton35.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton35.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton35.TabIndex = 15
        Me.MetroButton35.Text = "Core Sinema 6"
        Me.MetroButton35.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton35.UseSelectable = True
        Me.MetroButton35.UseStyleColors = True
        '
        'MetroButton36
        '
        Me.MetroButton36.Location = New System.Drawing.Point(1, 148)
        Me.MetroButton36.Name = "MetroButton36"
        Me.MetroButton36.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton36.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton36.TabIndex = 14
        Me.MetroButton36.Text = "Core Sinema 5"
        Me.MetroButton36.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton36.UseSelectable = True
        Me.MetroButton36.UseStyleColors = True
        '
        'MetroButton37
        '
        Me.MetroButton37.Location = New System.Drawing.Point(1, 119)
        Me.MetroButton37.Name = "MetroButton37"
        Me.MetroButton37.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton37.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton37.TabIndex = 13
        Me.MetroButton37.Text = "Core Sinema 4"
        Me.MetroButton37.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton37.UseSelectable = True
        Me.MetroButton37.UseStyleColors = True
        '
        'MetroButton38
        '
        Me.MetroButton38.Location = New System.Drawing.Point(1, 90)
        Me.MetroButton38.Name = "MetroButton38"
        Me.MetroButton38.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton38.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton38.TabIndex = 12
        Me.MetroButton38.Text = "Core Sinema 3"
        Me.MetroButton38.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton38.UseSelectable = True
        Me.MetroButton38.UseStyleColors = True
        '
        'MetroButton39
        '
        Me.MetroButton39.Location = New System.Drawing.Point(1, 61)
        Me.MetroButton39.Name = "MetroButton39"
        Me.MetroButton39.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton39.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton39.TabIndex = 11
        Me.MetroButton39.Text = "Core Sinema 2"
        Me.MetroButton39.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton39.UseSelectable = True
        Me.MetroButton39.UseStyleColors = True
        '
        'MetroButton40
        '
        Me.MetroButton40.Location = New System.Drawing.Point(0, 32)
        Me.MetroButton40.Name = "MetroButton40"
        Me.MetroButton40.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton40.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton40.TabIndex = 10
        Me.MetroButton40.Text = "Core Sinema 1"
        Me.MetroButton40.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton40.UseSelectable = True
        Me.MetroButton40.UseStyleColors = True
        '
        'belgPage
        '
        Me.belgPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.belgPage.Controls.Add(Me.Unknown4)
        Me.belgPage.Controls.Add(Me.Unknown3)
        Me.belgPage.Controls.Add(Me.CiftciTV)
        Me.belgPage.Controls.Add(Me.NASATV)
        Me.belgPage.Controls.Add(Me.AvTV)
        Me.belgPage.Controls.Add(Me.TGRTBelgesel)
        Me.belgPage.Controls.Add(Me.YabanTV)
        Me.belgPage.Controls.Add(Me.TRTBelgesel)
        Me.belgPage.Controls.Add(Me.TLC)
        Me.belgPage.Controls.Add(Me.D_Max)
        Me.belgPage.Controls.Add(Me.MetroButton21)
        Me.belgPage.Controls.Add(Me.MetroButton22)
        Me.belgPage.Controls.Add(Me.MetroButton23)
        Me.belgPage.Controls.Add(Me.MetroButton24)
        Me.belgPage.Controls.Add(Me.MetroButton25)
        Me.belgPage.Controls.Add(Me.MetroButton26)
        Me.belgPage.Controls.Add(Me.MetroButton27)
        Me.belgPage.Controls.Add(Me.MetroButton28)
        Me.belgPage.Controls.Add(Me.MetroButton29)
        Me.belgPage.Controls.Add(Me.MetroButton30)
        Me.belgPage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.belgPage.Location = New System.Drawing.Point(4, 38)
        Me.belgPage.Name = "belgPage"
        Me.belgPage.Size = New System.Drawing.Size(241, 510)
        Me.belgPage.TabIndex = 2
        Me.belgPage.Text = " Belgesel"
        '
        'Unknown4
        '
        Me.Unknown4.AutoSize = True
        Me.Unknown4.Location = New System.Drawing.Point(6, 442)
        Me.Unknown4.Name = "Unknown4"
        Me.Unknown4.Size = New System.Drawing.Size(88, 19)
        Me.Unknown4.Style = MetroFramework.MetroColorStyle.Orange
        Me.Unknown4.TabIndex = 49
        Me.Unknown4.Text = "MetroLabel10"
        Me.Unknown4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Unknown4.UseStyleColors = True
        Me.Unknown4.Visible = False
        '
        'Unknown3
        '
        Me.Unknown3.AutoSize = True
        Me.Unknown3.Location = New System.Drawing.Point(6, 418)
        Me.Unknown3.Name = "Unknown3"
        Me.Unknown3.Size = New System.Drawing.Size(83, 19)
        Me.Unknown3.Style = MetroFramework.MetroColorStyle.Orange
        Me.Unknown3.TabIndex = 48
        Me.Unknown3.Text = "MetroLabel9"
        Me.Unknown3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Unknown3.UseStyleColors = True
        Me.Unknown3.Visible = False
        '
        'CiftciTV
        '
        Me.CiftciTV.AutoSize = True
        Me.CiftciTV.Location = New System.Drawing.Point(6, 394)
        Me.CiftciTV.Name = "CiftciTV"
        Me.CiftciTV.Size = New System.Drawing.Size(83, 19)
        Me.CiftciTV.Style = MetroFramework.MetroColorStyle.Orange
        Me.CiftciTV.TabIndex = 47
        Me.CiftciTV.Text = "MetroLabel8"
        Me.CiftciTV.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.CiftciTV.UseStyleColors = True
        Me.CiftciTV.Visible = False
        '
        'NASATV
        '
        Me.NASATV.AutoSize = True
        Me.NASATV.Location = New System.Drawing.Point(6, 371)
        Me.NASATV.Name = "NASATV"
        Me.NASATV.Size = New System.Drawing.Size(83, 19)
        Me.NASATV.Style = MetroFramework.MetroColorStyle.Orange
        Me.NASATV.TabIndex = 46
        Me.NASATV.Text = "MetroLabel7"
        Me.NASATV.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.NASATV.UseStyleColors = True
        Me.NASATV.Visible = False
        '
        'AvTV
        '
        Me.AvTV.AutoSize = True
        Me.AvTV.Location = New System.Drawing.Point(6, 347)
        Me.AvTV.Name = "AvTV"
        Me.AvTV.Size = New System.Drawing.Size(83, 19)
        Me.AvTV.Style = MetroFramework.MetroColorStyle.Orange
        Me.AvTV.TabIndex = 45
        Me.AvTV.Text = "MetroLabel6"
        Me.AvTV.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.AvTV.UseStyleColors = True
        Me.AvTV.Visible = False
        '
        'TGRTBelgesel
        '
        Me.TGRTBelgesel.AutoSize = True
        Me.TGRTBelgesel.Location = New System.Drawing.Point(6, 324)
        Me.TGRTBelgesel.Name = "TGRTBelgesel"
        Me.TGRTBelgesel.Size = New System.Drawing.Size(83, 19)
        Me.TGRTBelgesel.Style = MetroFramework.MetroColorStyle.Orange
        Me.TGRTBelgesel.TabIndex = 44
        Me.TGRTBelgesel.Text = "MetroLabel5"
        Me.TGRTBelgesel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TGRTBelgesel.UseStyleColors = True
        Me.TGRTBelgesel.Visible = False
        '
        'YabanTV
        '
        Me.YabanTV.AutoSize = True
        Me.YabanTV.Location = New System.Drawing.Point(147, 324)
        Me.YabanTV.Name = "YabanTV"
        Me.YabanTV.Size = New System.Drawing.Size(83, 19)
        Me.YabanTV.Style = MetroFramework.MetroColorStyle.Orange
        Me.YabanTV.TabIndex = 43
        Me.YabanTV.Text = "MetroLabel4"
        Me.YabanTV.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.YabanTV.UseStyleColors = True
        Me.YabanTV.Visible = False
        '
        'TRTBelgesel
        '
        Me.TRTBelgesel.AutoSize = True
        Me.TRTBelgesel.Location = New System.Drawing.Point(147, 346)
        Me.TRTBelgesel.Name = "TRTBelgesel"
        Me.TRTBelgesel.Size = New System.Drawing.Size(83, 19)
        Me.TRTBelgesel.Style = MetroFramework.MetroColorStyle.Orange
        Me.TRTBelgesel.TabIndex = 42
        Me.TRTBelgesel.Text = "MetroLabel3"
        Me.TRTBelgesel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TRTBelgesel.UseStyleColors = True
        Me.TRTBelgesel.Visible = False
        '
        'TLC
        '
        Me.TLC.AutoSize = True
        Me.TLC.Location = New System.Drawing.Point(147, 369)
        Me.TLC.Name = "TLC"
        Me.TLC.Size = New System.Drawing.Size(83, 19)
        Me.TLC.Style = MetroFramework.MetroColorStyle.Orange
        Me.TLC.TabIndex = 41
        Me.TLC.Text = "MetroLabel2"
        Me.TLC.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TLC.UseStyleColors = True
        Me.TLC.Visible = False
        '
        'D_Max
        '
        Me.D_Max.AutoSize = True
        Me.D_Max.Location = New System.Drawing.Point(147, 392)
        Me.D_Max.Name = "D_Max"
        Me.D_Max.Size = New System.Drawing.Size(81, 19)
        Me.D_Max.Style = MetroFramework.MetroColorStyle.Orange
        Me.D_Max.TabIndex = 40
        Me.D_Max.Text = "MetroLabel1"
        Me.D_Max.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.D_Max.UseStyleColors = True
        Me.D_Max.Visible = False
        '
        'MetroButton21
        '
        Me.MetroButton21.Location = New System.Drawing.Point(2, 292)
        Me.MetroButton21.Name = "MetroButton21"
        Me.MetroButton21.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton21.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton21.TabIndex = 19
        Me.MetroButton21.Text = "Unknown 4"
        Me.MetroButton21.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton21.UseSelectable = True
        Me.MetroButton21.UseStyleColors = True
        Me.MetroButton21.Visible = False
        '
        'MetroButton22
        '
        Me.MetroButton22.Location = New System.Drawing.Point(2, 263)
        Me.MetroButton22.Name = "MetroButton22"
        Me.MetroButton22.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton22.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton22.TabIndex = 18
        Me.MetroButton22.Text = "Unknown 3"
        Me.MetroButton22.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton22.UseSelectable = True
        Me.MetroButton22.UseStyleColors = True
        Me.MetroButton22.Visible = False
        '
        'MetroButton23
        '
        Me.MetroButton23.Location = New System.Drawing.Point(2, 234)
        Me.MetroButton23.Name = "MetroButton23"
        Me.MetroButton23.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton23.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton23.TabIndex = 17
        Me.MetroButton23.Text = "Çiftçi TV"
        Me.MetroButton23.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton23.UseSelectable = True
        Me.MetroButton23.UseStyleColors = True
        '
        'MetroButton24
        '
        Me.MetroButton24.Location = New System.Drawing.Point(2, 205)
        Me.MetroButton24.Name = "MetroButton24"
        Me.MetroButton24.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton24.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton24.TabIndex = 16
        Me.MetroButton24.Text = "NASA TV"
        Me.MetroButton24.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton24.UseSelectable = True
        Me.MetroButton24.UseStyleColors = True
        '
        'MetroButton25
        '
        Me.MetroButton25.Location = New System.Drawing.Point(2, 176)
        Me.MetroButton25.Name = "MetroButton25"
        Me.MetroButton25.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton25.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton25.TabIndex = 15
        Me.MetroButton25.Text = "Av TV"
        Me.MetroButton25.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton25.UseSelectable = True
        Me.MetroButton25.UseStyleColors = True
        '
        'MetroButton26
        '
        Me.MetroButton26.Location = New System.Drawing.Point(2, 147)
        Me.MetroButton26.Name = "MetroButton26"
        Me.MetroButton26.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton26.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton26.TabIndex = 14
        Me.MetroButton26.Text = "Yaban TV"
        Me.MetroButton26.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton26.UseSelectable = True
        Me.MetroButton26.UseStyleColors = True
        '
        'MetroButton27
        '
        Me.MetroButton27.Location = New System.Drawing.Point(2, 118)
        Me.MetroButton27.Name = "MetroButton27"
        Me.MetroButton27.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton27.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton27.TabIndex = 13
        Me.MetroButton27.Text = "TGRT Belgesel"
        Me.MetroButton27.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton27.UseSelectable = True
        Me.MetroButton27.UseStyleColors = True
        '
        'MetroButton28
        '
        Me.MetroButton28.Location = New System.Drawing.Point(2, 89)
        Me.MetroButton28.Name = "MetroButton28"
        Me.MetroButton28.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton28.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton28.TabIndex = 12
        Me.MetroButton28.Text = "TRT Belgesel"
        Me.MetroButton28.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton28.UseSelectable = True
        Me.MetroButton28.UseStyleColors = True
        '
        'MetroButton29
        '
        Me.MetroButton29.Location = New System.Drawing.Point(2, 60)
        Me.MetroButton29.Name = "MetroButton29"
        Me.MetroButton29.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton29.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton29.TabIndex = 11
        Me.MetroButton29.Text = "TLC"
        Me.MetroButton29.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton29.UseSelectable = True
        Me.MetroButton29.UseStyleColors = True
        '
        'MetroButton30
        '
        Me.MetroButton30.Location = New System.Drawing.Point(1, 31)
        Me.MetroButton30.Name = "MetroButton30"
        Me.MetroButton30.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton30.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton30.TabIndex = 10
        Me.MetroButton30.Text = "D- Max"
        Me.MetroButton30.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton30.UseSelectable = True
        Me.MetroButton30.UseStyleColors = True
        '
        'yabPage
        '
        Me.yabPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.yabPage.Controls.Add(Me.yabanKoru)
        Me.yabPage.Controls.Add(Me.MetroButton41)
        Me.yabPage.Controls.Add(Me.MetroButton42)
        Me.yabPage.Controls.Add(Me.MetroButton43)
        Me.yabPage.Controls.Add(Me.MetroButton44)
        Me.yabPage.Controls.Add(Me.MetroButton45)
        Me.yabPage.Controls.Add(Me.MetroButton46)
        Me.yabPage.Controls.Add(Me.MetroButton47)
        Me.yabPage.Controls.Add(Me.MetroButton48)
        Me.yabPage.Controls.Add(Me.MetroButton49)
        Me.yabPage.Controls.Add(Me.MetroButton50)
        Me.yabPage.Location = New System.Drawing.Point(4, 38)
        Me.yabPage.Name = "yabPage"
        Me.yabPage.Size = New System.Drawing.Size(241, 510)
        Me.yabPage.TabIndex = 4
        Me.yabPage.Text = " Yabancı"
        '
        'yabanKoru
        '
        Me.yabanKoru.Controls.Add(Me.yabanInfo)
        Me.yabanKoru.Dock = System.Windows.Forms.DockStyle.Fill
        Me.yabanKoru.HorizontalScrollbarBarColor = True
        Me.yabanKoru.HorizontalScrollbarHighlightOnWheel = False
        Me.yabanKoru.HorizontalScrollbarSize = 10
        Me.yabanKoru.Location = New System.Drawing.Point(0, 0)
        Me.yabanKoru.Name = "yabanKoru"
        Me.yabanKoru.Size = New System.Drawing.Size(241, 510)
        Me.yabanKoru.Style = MetroFramework.MetroColorStyle.Orange
        Me.yabanKoru.TabIndex = 20
        Me.yabanKoru.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.yabanKoru.UseStyleColors = True
        Me.yabanKoru.VerticalScrollbarBarColor = True
        Me.yabanKoru.VerticalScrollbarHighlightOnWheel = False
        Me.yabanKoru.VerticalScrollbarSize = 10
        '
        'yabanInfo
        '
        Me.yabanInfo.AutoSize = True
        Me.yabanInfo.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.yabanInfo.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.yabanInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.yabanInfo.Location = New System.Drawing.Point(31, 56)
        Me.yabanInfo.Name = "yabanInfo"
        Me.yabanInfo.Size = New System.Drawing.Size(170, 75)
        Me.yabanInfo.Style = MetroFramework.MetroColorStyle.Orange
        Me.yabanInfo.TabIndex = 2
        Me.yabanInfo.Text = "Yabancı İçerikler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "İçin Çalışmalarımız" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sürmektedir..."
        Me.yabanInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.yabanInfo.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.yabanInfo.UseCustomForeColor = True
        '
        'MetroButton41
        '
        Me.MetroButton41.Location = New System.Drawing.Point(2, 369)
        Me.MetroButton41.Name = "MetroButton41"
        Me.MetroButton41.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton41.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton41.TabIndex = 19
        Me.MetroButton41.Text = "MetroButton41"
        Me.MetroButton41.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton41.UseSelectable = True
        Me.MetroButton41.UseStyleColors = True
        '
        'MetroButton42
        '
        Me.MetroButton42.Location = New System.Drawing.Point(2, 340)
        Me.MetroButton42.Name = "MetroButton42"
        Me.MetroButton42.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton42.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton42.TabIndex = 18
        Me.MetroButton42.Text = "MetroButton42"
        Me.MetroButton42.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton42.UseSelectable = True
        Me.MetroButton42.UseStyleColors = True
        '
        'MetroButton43
        '
        Me.MetroButton43.Location = New System.Drawing.Point(2, 311)
        Me.MetroButton43.Name = "MetroButton43"
        Me.MetroButton43.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton43.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton43.TabIndex = 17
        Me.MetroButton43.Text = "MetroButton43"
        Me.MetroButton43.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton43.UseSelectable = True
        Me.MetroButton43.UseStyleColors = True
        '
        'MetroButton44
        '
        Me.MetroButton44.Location = New System.Drawing.Point(2, 282)
        Me.MetroButton44.Name = "MetroButton44"
        Me.MetroButton44.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton44.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton44.TabIndex = 16
        Me.MetroButton44.Text = "MetroButton44"
        Me.MetroButton44.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton44.UseSelectable = True
        Me.MetroButton44.UseStyleColors = True
        '
        'MetroButton45
        '
        Me.MetroButton45.Location = New System.Drawing.Point(2, 253)
        Me.MetroButton45.Name = "MetroButton45"
        Me.MetroButton45.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton45.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton45.TabIndex = 15
        Me.MetroButton45.Text = "MetroButton45"
        Me.MetroButton45.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton45.UseSelectable = True
        Me.MetroButton45.UseStyleColors = True
        '
        'MetroButton46
        '
        Me.MetroButton46.Location = New System.Drawing.Point(2, 224)
        Me.MetroButton46.Name = "MetroButton46"
        Me.MetroButton46.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton46.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton46.TabIndex = 14
        Me.MetroButton46.Text = "MetroButton46"
        Me.MetroButton46.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton46.UseSelectable = True
        Me.MetroButton46.UseStyleColors = True
        '
        'MetroButton47
        '
        Me.MetroButton47.Location = New System.Drawing.Point(2, 195)
        Me.MetroButton47.Name = "MetroButton47"
        Me.MetroButton47.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton47.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton47.TabIndex = 13
        Me.MetroButton47.Text = "MetroButton47"
        Me.MetroButton47.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton47.UseSelectable = True
        Me.MetroButton47.UseStyleColors = True
        '
        'MetroButton48
        '
        Me.MetroButton48.Location = New System.Drawing.Point(2, 166)
        Me.MetroButton48.Name = "MetroButton48"
        Me.MetroButton48.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton48.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton48.TabIndex = 12
        Me.MetroButton48.Text = "MetroButton48"
        Me.MetroButton48.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton48.UseSelectable = True
        Me.MetroButton48.UseStyleColors = True
        '
        'MetroButton49
        '
        Me.MetroButton49.Location = New System.Drawing.Point(2, 137)
        Me.MetroButton49.Name = "MetroButton49"
        Me.MetroButton49.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton49.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton49.TabIndex = 11
        Me.MetroButton49.Text = "MetroButton49"
        Me.MetroButton49.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton49.UseSelectable = True
        Me.MetroButton49.UseStyleColors = True
        '
        'MetroButton50
        '
        Me.MetroButton50.Location = New System.Drawing.Point(1, 108)
        Me.MetroButton50.Name = "MetroButton50"
        Me.MetroButton50.Size = New System.Drawing.Size(234, 23)
        Me.MetroButton50.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton50.TabIndex = 10
        Me.MetroButton50.Text = "MetroButton50"
        Me.MetroButton50.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton50.UseSelectable = True
        Me.MetroButton50.UseStyleColors = True
        '
        'mainMenu
        '
        Me.mainMenu.Controls.Add(Me.infoPanel)
        Me.mainMenu.Controls.Add(Me.player)
        Me.mainMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainMenu.HorizontalScrollbarBarColor = True
        Me.mainMenu.HorizontalScrollbarHighlightOnWheel = False
        Me.mainMenu.HorizontalScrollbarSize = 10
        Me.mainMenu.Location = New System.Drawing.Point(269, 60)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Size = New System.Drawing.Size(970, 598)
        Me.mainMenu.Style = MetroFramework.MetroColorStyle.Orange
        Me.mainMenu.TabIndex = 1
        Me.mainMenu.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mainMenu.UseStyleColors = True
        Me.mainMenu.VerticalScrollbarBarColor = True
        Me.mainMenu.VerticalScrollbarHighlightOnWheel = False
        Me.mainMenu.VerticalScrollbarSize = 10
        '
        'infoPanel
        '
        Me.infoPanel.Controls.Add(Me.infoLabel)
        Me.infoPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.infoPanel.HorizontalScrollbarBarColor = True
        Me.infoPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.infoPanel.HorizontalScrollbarSize = 10
        Me.infoPanel.Location = New System.Drawing.Point(0, 0)
        Me.infoPanel.Name = "infoPanel"
        Me.infoPanel.Size = New System.Drawing.Size(970, 40)
        Me.infoPanel.Style = MetroFramework.MetroColorStyle.Orange
        Me.infoPanel.TabIndex = 2
        Me.infoPanel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.infoPanel.UseStyleColors = True
        Me.infoPanel.VerticalScrollbarBarColor = True
        Me.infoPanel.VerticalScrollbarHighlightOnWheel = False
        Me.infoPanel.VerticalScrollbarSize = 10
        '
        'infoLabel
        '
        Me.infoLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.infoLabel.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.infoLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.infoLabel.Location = New System.Drawing.Point(0, 0)
        Me.infoLabel.Name = "infoLabel"
        Me.infoLabel.Size = New System.Drawing.Size(970, 40)
        Me.infoLabel.Style = MetroFramework.MetroColorStyle.Orange
        Me.infoLabel.TabIndex = 2
        Me.infoLabel.Text = "Yayınlar, Internet Hızınızdan Kaynaklı Biraz Geç Yüklenebilir. Eğer Yüklenmiyorsa" &
    " veya Hata Veriyorsa Lütfen Bildirin!"
        Me.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.infoLabel.UseStyleColors = True
        '
        'player
        '
        Me.player.Dock = System.Windows.Forms.DockStyle.Fill
        Me.player.Enabled = True
        Me.player.Location = New System.Drawing.Point(0, 0)
        Me.player.Name = "player"
        Me.player.OcxState = CType(resources.GetObject("player.OcxState"), System.Windows.Forms.AxHost.State)
        Me.player.Size = New System.Drawing.Size(970, 598)
        Me.player.TabIndex = 3
        '
        'homePage
        '
        Me.homePage.Controls.Add(Me.DuyuruResim)
        Me.homePage.Controls.Add(Me.duyuruBar)
        Me.homePage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.homePage.HorizontalScrollbarBarColor = True
        Me.homePage.HorizontalScrollbarHighlightOnWheel = False
        Me.homePage.HorizontalScrollbarSize = 10
        Me.homePage.Location = New System.Drawing.Point(269, 60)
        Me.homePage.Name = "homePage"
        Me.homePage.Size = New System.Drawing.Size(970, 598)
        Me.homePage.Style = MetroFramework.MetroColorStyle.Orange
        Me.homePage.TabIndex = 9
        Me.homePage.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.homePage.UseStyleColors = True
        Me.homePage.VerticalScrollbarBarColor = True
        Me.homePage.VerticalScrollbarHighlightOnWheel = False
        Me.homePage.VerticalScrollbarSize = 10
        '
        'DuyuruResim
        '
        Me.DuyuruResim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DuyuruResim.ErrorImage = Global.CoreTV.My.Resources.Resources.noimg
        Me.DuyuruResim.ImageLocation = ""
        Me.DuyuruResim.InitialImage = Global.CoreTV.My.Resources.Resources.ayarlar
        Me.DuyuruResim.Location = New System.Drawing.Point(0, 208)
        Me.DuyuruResim.Name = "DuyuruResim"
        Me.DuyuruResim.Size = New System.Drawing.Size(970, 390)
        Me.DuyuruResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DuyuruResim.TabIndex = 3
        Me.DuyuruResim.TabStop = False
        '
        'duyuruBar
        '
        Me.duyuruBar.Controls.Add(Me.Duyuru)
        Me.duyuruBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.duyuruBar.HorizontalScrollbarBarColor = True
        Me.duyuruBar.HorizontalScrollbarHighlightOnWheel = False
        Me.duyuruBar.HorizontalScrollbarSize = 10
        Me.duyuruBar.Location = New System.Drawing.Point(0, 0)
        Me.duyuruBar.Name = "duyuruBar"
        Me.duyuruBar.Size = New System.Drawing.Size(970, 208)
        Me.duyuruBar.Style = MetroFramework.MetroColorStyle.Orange
        Me.duyuruBar.TabIndex = 2
        Me.duyuruBar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.duyuruBar.UseStyleColors = True
        Me.duyuruBar.VerticalScrollbarBarColor = True
        Me.duyuruBar.VerticalScrollbarHighlightOnWheel = False
        Me.duyuruBar.VerticalScrollbarSize = 10
        '
        'Duyuru
        '
        Me.Duyuru.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Duyuru.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Duyuru.Dock = System.Windows.Forms.DockStyle.Top
        Me.Duyuru.Font = New System.Drawing.Font("Calibri", 14.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Duyuru.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Duyuru.Location = New System.Drawing.Point(0, 0)
        Me.Duyuru.Name = "Duyuru"
        Me.Duyuru.ReadOnly = True
        Me.Duyuru.Size = New System.Drawing.Size(970, 208)
        Me.Duyuru.TabIndex = 4
        Me.Duyuru.Text = ""
        '
        'programDurum
        '
        Me.programDurum.AutoSize = True
        Me.programDurum.Location = New System.Drawing.Point(60, 8)
        Me.programDurum.Name = "programDurum"
        Me.programDurum.Size = New System.Drawing.Size(31, 19)
        Me.programDurum.Style = MetroFramework.MetroColorStyle.Orange
        Me.programDurum.TabIndex = 50
        Me.programDurum.Text = "acik"
        Me.programDurum.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.programDurum.UseStyleColors = True
        Me.programDurum.Visible = False
        '
        'versTXT
        '
        Me.versTXT.AutoSize = True
        Me.versTXT.Location = New System.Drawing.Point(60, 35)
        Me.versTXT.Name = "versTXT"
        Me.versTXT.Size = New System.Drawing.Size(16, 19)
        Me.versTXT.Style = MetroFramework.MetroColorStyle.Orange
        Me.versTXT.TabIndex = 51
        Me.versTXT.Text = "a"
        Me.versTXT.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.versTXT.UseStyleColors = True
        Me.versTXT.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.CoreTV.My.Resources.Resources.CORETV
        Me.PictureBox5.Location = New System.Drawing.Point(5, 8)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(46, 46)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ShowTV
        '
        Me.ShowTV.Location = New System.Drawing.Point(1, 352)
        Me.ShowTV.Name = "ShowTV"
        Me.ShowTV.Size = New System.Drawing.Size(234, 23)
        Me.ShowTV.Style = MetroFramework.MetroColorStyle.Orange
        Me.ShowTV.TabIndex = 22
        Me.ShowTV.Text = "Show TV"
        Me.ShowTV.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ShowTV.UseSelectable = True
        Me.ShowTV.UseStyleColors = True
        '
        'shwTV
        '
        Me.shwTV.AutoSize = True
        Me.shwTV.Location = New System.Drawing.Point(145, 490)
        Me.shwTV.Name = "shwTV"
        Me.shwTV.Size = New System.Drawing.Size(88, 19)
        Me.shwTV.Style = MetroFramework.MetroColorStyle.Orange
        Me.shwTV.TabIndex = 23
        Me.shwTV.Text = "MetroLabel10"
        Me.shwTV.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.shwTV.UseStyleColors = True
        Me.shwTV.Visible = False
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 678)
        Me.Controls.Add(Me.versTXT)
        Me.Controls.Add(Me.programDurum)
        Me.Controls.Add(Me.homePage)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.mainMenu)
        Me.Controls.Add(Me.sideMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(578, 450)
        Me.Name = "MainFrm"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Core TV"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.sideMenu.ResumeLayout(False)
        Me.bottomSide.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.helpBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.infoBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iletBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ayarBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.channelsTab.ResumeLayout(False)
        Me.sporPage.ResumeLayout(False)
        Me.sporPage.PerformLayout()
        Me.ulsPage.ResumeLayout(False)
        Me.ulsPage.PerformLayout()
        Me.sinePage.ResumeLayout(False)
        Me.sinePage.PerformLayout()
        Me.belgPage.ResumeLayout(False)
        Me.belgPage.PerformLayout()
        Me.yabPage.ResumeLayout(False)
        Me.yabanKoru.ResumeLayout(False)
        Me.yabanKoru.PerformLayout()
        Me.mainMenu.ResumeLayout(False)
        Me.infoPanel.ResumeLayout(False)
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.homePage.ResumeLayout(False)
        CType(Me.DuyuruResim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.duyuruBar.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sideMenu As MetroFramework.Controls.MetroPanel
    Friend WithEvents mainMenu As MetroFramework.Controls.MetroPanel
    Friend WithEvents infoPanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents player As AxAXVLC.AxVLCPlugin2
    Friend WithEvents infoLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents channelsTab As MetroFramework.Controls.MetroTabControl
    Friend WithEvents ulsPage As TabPage
    Friend WithEvents sporPage As TabPage
    Friend WithEvents belgPage As TabPage
    Friend WithEvents sinePage As TabPage
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents bottomSide As MetroFramework.Controls.MetroPanel
    Friend WithEvents helpBox As PictureBox
    Friend WithEvents infoBox As PictureBox
    Friend WithEvents iletBox As PictureBox
    Friend WithEvents ayarBox As PictureBox
    Friend WithEvents yabPage As TabPage
    Friend WithEvents haberTRK As MetroFramework.Controls.MetroButton
    Friend WithEvents cnn As MetroFramework.Controls.MetroButton
    Friend WithEvents tv8 As MetroFramework.Controls.MetroButton
    Friend WithEvents star As MetroFramework.Controls.MetroButton
    Friend WithEvents halk As MetroFramework.Controls.MetroButton
    Friend WithEvents beyaz As MetroFramework.Controls.MetroButton
    Friend WithEvents trt1 As MetroFramework.Controls.MetroButton
    Friend WithEvents trtH As MetroFramework.Controls.MetroButton
    Friend WithEvents ntv As MetroFramework.Controls.MetroButton
    Friend WithEvents kanalD As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton11 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton12 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton13 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton14 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton15 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton16 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton17 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton18 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton19 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton20 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton21 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton22 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton23 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton24 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton25 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton26 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton27 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton28 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton29 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton30 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton31 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton32 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton33 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton34 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton35 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton36 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton37 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton38 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton39 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton40 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton41 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton42 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton43 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton44 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton45 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton46 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton47 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton48 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton49 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton50 As MetroFramework.Controls.MetroButton
    Friend WithEvents haberTRKLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents cnnLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents tv8Label As MetroFramework.Controls.MetroLabel
    Friend WithEvents starLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents halkLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents beyazLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents trt1Label As MetroFramework.Controls.MetroLabel
    Friend WithEvents trtHLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents NTVLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents kanalDLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents unknown2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents unknown1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents aSpor As MetroFramework.Controls.MetroLabel
    Friend WithEvents ArenaSport As MetroFramework.Controls.MetroLabel
    Friend WithEvents trtSpor As MetroFramework.Controls.MetroLabel
    Friend WithEvents Tivibuspor As MetroFramework.Controls.MetroLabel
    Friend WithEvents SporTV4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents SporTV3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents SporTV2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents SporTV1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents SonyCH As MetroFramework.Controls.MetroLabel
    Friend WithEvents FilTV As MetroFramework.Controls.MetroLabel
    Friend WithEvents Dizi2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Dizi1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Sinema6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Sinema5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Sinema4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Sinema3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Sinema2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Sinema1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents pwrTRK As MetroFramework.Controls.MetroLabel
    Friend WithEvents PowerTRK As MetroFramework.Controls.MetroButton
    Friend WithEvents yabanKoru As MetroFramework.Controls.MetroPanel
    Friend WithEvents yabanInfo As MetroFramework.Controls.MetroLabel
    Friend WithEvents Unknown4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Unknown3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents CiftciTV As MetroFramework.Controls.MetroLabel
    Friend WithEvents NASATV As MetroFramework.Controls.MetroLabel
    Friend WithEvents AvTV As MetroFramework.Controls.MetroLabel
    Friend WithEvents TGRTBelgesel As MetroFramework.Controls.MetroLabel
    Friend WithEvents YabanTV As MetroFramework.Controls.MetroLabel
    Friend WithEvents TRTBelgesel As MetroFramework.Controls.MetroLabel
    Friend WithEvents TLC As MetroFramework.Controls.MetroLabel
    Friend WithEvents D_Max As MetroFramework.Controls.MetroLabel
    Friend WithEvents homePage As MetroFramework.Controls.MetroPanel
    Friend WithEvents duyuruBar As MetroFramework.Controls.MetroPanel
    Friend WithEvents Duyuru As RichTextBox
    Friend WithEvents DuyuruResim As PictureBox
    Friend WithEvents programDurum As MetroFramework.Controls.MetroLabel
    Friend WithEvents versTXT As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ShowTV As MetroFramework.Controls.MetroButton
    Friend WithEvents shwTV As MetroFramework.Controls.MetroLabel
End Class
