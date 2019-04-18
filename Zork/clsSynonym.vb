Public Class clsSynonym


    Public Name As String
    Public OrigText As String
    Public Values As New List(Of String)

    Public Type As String = "" 'Verb,Adj, Prep,



    Public Sub New(txt As String)
        Me.OrigText = txt


        Dim cmd As String = GetFirstWord(txt)


        Dim Remainder As String = txt.Substring(txt.IndexOf(cmd) + cmd.Length).Trim

        Values = ConvertToList(Remainder, False)
        Name = Values(0)





    End Sub


    Public Overrides Function ToString() As String
        Return Me.Name
    End Function
End Class
