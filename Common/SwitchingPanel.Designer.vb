<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SwitchingPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl はコンポーネント一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PanelRed = New System.Windows.Forms.Panel()
        Me.PanelOrange = New System.Windows.Forms.Panel()
        Me.PanelYellow = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.PanelRed.SuspendLayout()
        Me.PanelOrange.SuspendLayout()
        Me.PanelYellow.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(67, 30)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(130, 48)
        Me.TextBox1.TabIndex = 0
        '
        'PanelRed
        '
        Me.PanelRed.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelRed.Controls.Add(Me.TextBox2)
        Me.PanelRed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRed.Location = New System.Drawing.Point(0, 0)
        Me.PanelRed.Name = "PanelRed"
        Me.PanelRed.Size = New System.Drawing.Size(497, 107)
        Me.PanelRed.TabIndex = 0
        '
        'PanelOrange
        '
        Me.PanelOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelOrange.Controls.Add(Me.TextBox4)
        Me.PanelOrange.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelOrange.Location = New System.Drawing.Point(0, 0)
        Me.PanelOrange.Name = "PanelOrange"
        Me.PanelOrange.Size = New System.Drawing.Size(497, 107)
        Me.PanelOrange.TabIndex = 0
        '
        'PanelYellow
        '
        Me.PanelYellow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelYellow.Controls.Add(Me.TextBox3)
        Me.PanelYellow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelYellow.Location = New System.Drawing.Point(0, 0)
        Me.PanelYellow.Name = "PanelYellow"
        Me.PanelYellow.Size = New System.Drawing.Size(497, 107)
        Me.PanelYellow.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(33, 41)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 19)
        Me.TextBox2.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(121, 41)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 19)
        Me.TextBox3.TabIndex = 1
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(227, 41)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 19)
        Me.TextBox4.TabIndex = 1
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelOrange)
        Me.Controls.Add(Me.PanelRed)
        Me.Controls.Add(Me.PanelYellow)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(497, 107)
        Me.PanelRed.ResumeLayout(False)
        Me.PanelRed.PerformLayout()
        Me.PanelOrange.ResumeLayout(False)
        Me.PanelOrange.PerformLayout()
        Me.PanelYellow.ResumeLayout(False)
        Me.PanelYellow.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    'Friend WithEvents PanelRed As Windows.Forms.Panel
    'Friend WithEvents PanelYellow As Windows.Forms.Panel
    'Friend WithEvents PanelOrange As Windows.Forms.Panel
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents PanelRed As Windows.Forms.Panel
    Friend WithEvents PanelOrange As Windows.Forms.Panel
    Friend WithEvents PanelYellow As Windows.Forms.Panel
    Friend WithEvents TextBox2 As Windows.Forms.TextBox
    Friend WithEvents TextBox4 As Windows.Forms.TextBox
    Friend WithEvents TextBox3 As Windows.Forms.TextBox
End Class
