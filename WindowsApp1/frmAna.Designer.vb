<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAna
    Inherits System.Windows.Forms.Form

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
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(198, 155)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(129, 35)
        Me.Button8.TabIndex = 3
        Me.Button8.Text = "Ürün" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Listeleme"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(198, 73)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(129, 35)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "Ürün Ekle"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(60, 73)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(129, 115)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "Müşteri " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ekleme ve Listeleme" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(60, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(267, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Satış Yap"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Metehan ARSLAN"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(271, 114)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 35)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Marka"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(198, 113)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(55, 35)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Kategori"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmAna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(383, 222)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Name = "frmAna"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ana Sayfa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
End Class
