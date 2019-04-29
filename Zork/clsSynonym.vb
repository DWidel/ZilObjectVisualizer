Public Class clsSynonym
    Inherits clsNameValue


    Public Values As New List(Of String)

    Public Type As String = "" 'Verb,Adj, Prep,



    Public Sub New(txt As String)
        Me.OrigText = txt


        Dim cmd As String = GetFirstWord(txt)


        Dim Remainder As String = txt.Substring(txt.IndexOf(cmd) + cmd.Length).Trim

        Values = ConvertToList(Remainder, False)
        Name = Values(0)
        Value = String.Join(",", Values)




    End Sub


    Public Overrides Function ToString() As String
        Return Me.Name
    End Function

    Public Overrides ReadOnly Property ThingTypeDesc As String
        Get
            Return "Synonym"
        End Get
    End Property
    Public Overrides ReadOnly Property ThingType As ObjTypes
        Get
            Return ObjTypes.Synonym
        End Get
    End Property
End Class
