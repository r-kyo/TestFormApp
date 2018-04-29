Imports System.Windows.Forms

Public Class SwitchingPanel
    Private _color As Color

    Private _panels As Dictionary(Of Color, Panel)

    Public Enum Color
        Red
        Orange
        Yellow
    End Enum

    Public Property VisibleColor As Color
        Set(value As Color)
            ' すべての要素を非表示にする
            For Each kvp In _panels
                kvp.Value.Visible = False
            Next
            ' 指定した色のみ表示
            _panels(value).Visible = True
        End Set
        Get
            Return _color
        End Get
    End Property

    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        _panels = New Dictionary(Of Color, Panel) From {
            {Color.Red, PanelRed},
            {Color.Orange, PanelOrange},
            {Color.Yellow, PanelYellow}
        }
        VisibleColor = Color.Red

    End Sub

End Class
