<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits Common.FormBase

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NextButton = New System.Windows.Forms.Button()
        Me.PrevButton = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(161, 129)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(267, 19)
        Me.TextBox1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(600, 330)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(181, 63)
        Me.NextButton.TabIndex = 2
        Me.NextButton.Text = "次へ"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'PrevButton
        '
        Me.PrevButton.Location = New System.Drawing.Point(31, 594)
        Me.PrevButton.Name = "PrevButton"
        Me.PrevButton.Size = New System.Drawing.Size(115, 57)
        Me.PrevButton.TabIndex = 3
        Me.PrevButton.Text = "戻る"
        Me.PrevButton.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(434, 129)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(42, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(213, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 58)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Progress"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.ClientSize = New System.Drawing.Size(1005, 675)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PrevButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.TextBox1)
        Me.FormId = "001"
        Me.FormName = "画面"
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As Windows.Forms.ContextMenuStrip
    Friend WithEvents NextButton As Windows.Forms.Button
    Friend WithEvents PrevButton As Windows.Forms.Button
    Friend WithEvents Button3 As Windows.Forms.Button
    Friend WithEvents Button1 As Windows.Forms.Button
End Class
