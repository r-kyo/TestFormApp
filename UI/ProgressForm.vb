Public Class ProgressForm
    Private i As Integer = 0

    Public Property IsCancel As Boolean

    Public Sub New(ByVal max As Integer)
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = max
        ProgressBar1.Value = 0
    End Sub

    Public Sub UpdateProgress(ByVal value As Integer)
        ProgressBar1.Value = value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        IsCancel = True
    End Sub
End Class