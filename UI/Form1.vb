Imports Common

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

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New ProgressForm(10)
        frm.Show()

        For i = 0 To 9
            Await Task.Run(
                Sub()
                    RunHeavyTask()
                End Sub
            )

            frm.UpdateProgress(i + 1)

            If frm.IsCancel Then
                MsgBox("キャンセルされました。")
                frm.Close()
                Exit Sub
            End If
        Next

        MsgBox("処理完了")
        frm.Close()
    End Sub

    Private Sub RunHeavyTask()
        System.Threading.Thread.Sleep(500)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TestPanel.VisibleColor = SwitchingPanel.Color.Red
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TestPanel.VisibleColor = SwitchingPanel.Color.Orange
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TestPanel.VisibleColor = SwitchingPanel.Color.Yellow
    End Sub
End Class
