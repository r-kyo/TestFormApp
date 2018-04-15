Imports System.ComponentModel

Public Class FormBase
    <Category("テスト")>
    Public Property FormId As String
    <Category("テスト")>
    Public Property FormName As String

    ''' <summary>親フォーム</summary>
    Public Property ParentForm As IParentForm

End Class