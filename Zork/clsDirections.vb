Public Class clsDirections

    Public OrigText As String
    Public lst As New List(Of String)

    Public Sub New(txt As String)
        Me.OrigText = txt


        Dim ss() As String = RemoveComments(txt).Split(" ")

        For i As Integer = 1 To ss.Length - 1
            Dim dir As String = ss(i).Trim
            If dir = "" Then Continue For
            lst.Add(dir)
        Next







    End Sub

    Private Function RemoveComments(txt As String) As String

        Dim RetVal As String = ""

        Dim InComment As Boolean = False
        For i As Integer = 0 To txt.Length - 1
            Dim C As String = txt.Substring(i, 1)
            If InComment Then
                If C = vbCr OrElse C = vbLf Then
                    InComment = False
                End If
            Else
                If C = ";" Then
                    InComment = True
                Else
                    RetVal &= C
                End If
            End If

        Next
        Return RetVal
    End Function

End Class
