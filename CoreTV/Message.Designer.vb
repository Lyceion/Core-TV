<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Message
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Message))
        Me.MetroComboBox2 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.repActive = New System.Windows.Forms.Timer(Me.components)
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'MetroComboBox2
        '
        Me.MetroComboBox2.FormattingEnabled = True
        Me.MetroComboBox2.ItemHeight = 23
        Me.MetroComboBox2.Items.AddRange(New Object() {"Kanal D", "NTV", "TRT Haber", "TRT 1", "Beyaz TV", "Halk TV", "Star TV", "TV 8", "CNN ", "Haber Türk", "Power Türk", "Core Spor TV 1", "Core Spor TV 2", "Core Spor TV 3", "D- Max", "TLC", "TRT Belgesel", "TGRT Belgesel", "Yaban TV", "Av TV", "NASA TV", "Ciftci TV", "Core Sinema 1", "Core Sinema 2", "Core Sinema 3", "Core Sinema 4", "Core Sinema 5", "Core Sinema 6", "Core Dizi 1", "Core Dizi 2", "Fil TV", "Sony Channel", "TRT Spor", "Arena Spor", "A - Spor", "Core Spor TV 4", "Tivibu Spor"})
        Me.MetroComboBox2.Location = New System.Drawing.Point(81, 63)
        Me.MetroComboBox2.Name = "MetroComboBox2"
        Me.MetroComboBox2.Size = New System.Drawing.Size(174, 29)
        Me.MetroComboBox2.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroComboBox2.TabIndex = 5
        Me.MetroComboBox2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroComboBox2.UseSelectable = True
        Me.MetroComboBox2.UseStyleColors = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(27, 68)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Kanal:"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel2.UseStyleColors = True
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Items.AddRange(New Object() {"Yayin Calismiyor", "Yayin Donuyor", "Kalite Cok Dusuk"})
        Me.MetroComboBox1.Location = New System.Drawing.Point(81, 112)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(174, 29)
        Me.MetroComboBox1.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroComboBox1.TabIndex = 7
        Me.MetroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroComboBox1.UseSelectable = True
        Me.MetroComboBox1.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(27, 118)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroLabel1.TabIndex = 6
        Me.MetroLabel1.Text = "Durum:"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Enabled = False
        Me.MetroButton1.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton1.Location = New System.Drawing.Point(261, 63)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(121, 78)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroButton1.TabIndex = 8
        Me.MetroButton1.Text = "BİLDİR!"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(23, 183)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(100, 96)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'repActive
        '
        Me.repActive.Enabled = True
        Me.repActive.Interval = 10
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(282, 183)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(100, 96)
        Me.RichTextBox2.TabIndex = 10
        Me.RichTextBox2.Text = ""
        Me.RichTextBox2.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Message
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 180)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroComboBox2)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Message"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Bildir"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroComboBox2 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents repActive As Timer
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Timer1 As Timer
End Class
