Imports System.Windows.Forms
Imports System.IO

Public Class Form1Logic
    ''' <summary>ファイルチェックエラーメッセージ</summary>
    Public Property ErrorMessage As String

    Public Structure CheckResult
        Dim IsValid As Boolean
        Dim ErrorMsg As String

        Public Sub New(isValid As Boolean, errorMsg As String)
            Me.IsValid = isValid
            Me.ErrorMsg = errorMsg
        End Sub
    End Structure

    ''' <summary>
    ''' CSVファイル選択ダイアログの表示
    ''' </summary>
    ''' <returns>選択されたファイルパス</returns>
    Public Function ShowFileDialog() As String
        Dim fileDialog As New OpenFileDialog()
        fileDialog.Filter = "CSVファイル(*.csv)|*.csv|すべてのファイル(*.*)|*.*"

        If fileDialog.ShowDialog() = DialogResult.OK Then
            Return fileDialog.FileName
        End If

        Return ""
    End Function

    ''' <summary>
    ''' ファイル有効チェック
    ''' </summary>
    ''' <param name="filePath"></param>
    ''' <returns></returns>
    Public Function CheckFileValid(ByVal filePath As String) As CheckResult
        ' バイト数チェック
        Dim fi As New FileInfo(filePath)
        If fi.Length = 0 Then
            Return New CheckResult(False, "ファイルが0バイトです。")
        End If

        ' 拡張子チェック
        If Not Path.GetExtension(filePath).Equals(".csv") Then
            Return New CheckResult(False, "CSVファイルではありません。")
        End If

        Return New CheckResult(True, Nothing)
    End Function
End Class
