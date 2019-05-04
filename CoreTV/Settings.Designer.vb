<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits MetroFramework.Forms.MetroForm

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.themeCombo = New MetroFramework.Controls.MetroComboBox()
        Me.lanCombo = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(39, 45)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(55, 25)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Tema:"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseStyleColors = True
        '
        'themeCombo
        '
        Me.themeCombo.FormattingEnabled = True
        Me.themeCombo.ItemHeight = 23
        Me.themeCombo.Location = New System.Drawing.Point(32, 73)
        Me.themeCombo.Name = "themeCombo"
        Me.themeCombo.Size = New System.Drawing.Size(74, 29)
        Me.themeCombo.Style = MetroFramework.MetroColorStyle.Orange
        Me.themeCombo.TabIndex = 1
        Me.themeCombo.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.themeCombo.UseSelectable = True
        Me.themeCombo.UseStyleColors = True
        '
        'lanCombo
        '
        Me.lanCombo.FormattingEnabled = True
        Me.lanCombo.ItemHeight = 23
        Me.lanCombo.Items.AddRange(New Object() {"Türkçe", "English"})
        Me.lanCombo.Location = New System.Drawing.Point(224, 73)
        Me.lanCombo.Name = "lanCombo"
        Me.lanCombo.Size = New System.Drawing.Size(74, 29)
        Me.lanCombo.Style = MetroFramework.MetroColorStyle.Orange
        Me.lanCombo.TabIndex = 3
        Me.lanCombo.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lanCombo.UseSelectable = True
        Me.lanCombo.UseStyleColors = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(241, 45)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(36, 25)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Dil:"
        Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel2.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(127, 73)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 29)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton1.TabIndex = 4
        Me.MetroButton1.Text = "KAYDET"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.ForeColor = System.Drawing.Color.Red
        Me.MetroLabel3.Location = New System.Drawing.Point(32, 110)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(243, 15)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroLabel3.TabIndex = 5
        Me.MetroLabel3.Text = "*Ayarlar Program Tekrar Açılınca Uygulanacaktır!"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel3.UseCustomForeColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 134)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.lanCombo)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.themeCombo)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Ayarlar"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents themeCombo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lanCombo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Timer1 As Timer
End Class
