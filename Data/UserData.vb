Public Class UserData
    Private userId As String
    Private userName As String
    Private age As String
    Private job As String

    Public Sub New(ByVal userId As String,
                   ByVal userName As String,
                   ByVal age As String,
                   ByVal job As String)

        Me.userId = userId
        Me.userName = userName
        Me.age = age
        Me.job = job
    End Sub

End Class
