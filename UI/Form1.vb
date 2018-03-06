
Public Class Form1

    Private logic As New Logic.Form1Logic

    ''' <summary>
    ''' 画面Loadイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    ''' <summary>
    ''' 戻るボタン押下
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PrevButton_Click(sender As Object, e As EventArgs) Handles PrevButton.Click
        Dim form As New Menu
        Me.ParentForm.ShowChild(form)
    End Sub

    ''' <summary>
    ''' ファイル選択ボタン押下
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = logic.ShowFileDialog()
    End Sub

    ''' <summary>
    ''' 次へボタン押下
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        ' ファイルが有効か
        Dim result = logic.CheckFileValid(TextBox1.Text)
        If Not result.IsValid Then
            MsgBox(result.ErrorMsg)
            Exit Sub
        End If
    End Sub
End Class
