Imports Common
Imports UI

Public Class Parent
    Implements IParentForm

    ''' <summary>表示中のフォーム</summary>
    Private showingForm As FormBase

    ''' <summary>
    ''' Loadイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Parent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim initForm As New UI.Menu
        Me.ShowChild(initForm)
    End Sub

    ''' <summary>
    ''' 子フォームの表示
    ''' </summary>
    ''' <param name="form">子フォーム</param>
    Public Sub ShowChild(ByVal form As FormBase) Implements IParentForm.ShowChild
        ' 表示中のフォームを削除する
        If Not ChildFormPanel.Controls Is Nothing Then
            ChildFormPanel.Controls.Remove(showingForm)
        End If

        ' 事前準備
        form.ParentForm = Me
        form.TopLevel = False
        Me.showingForm = form

        ' 子フォーム表示
        ChildFormPanel.Controls.Add(form)
        form.Show()

    End Sub
End Class
