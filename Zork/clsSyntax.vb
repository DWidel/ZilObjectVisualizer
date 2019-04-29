Public Class clsSyntax
    Inherits clsNameValue


    Public Action As String




    Public Sub New(txt As String)
        Me.OrigText = txt



        Dim cmd As String = GetFirstWord(txt)
        Dim Remainder As String = txt.Substring(txt.IndexOf(cmd) + cmd.Length).Trim

        Dim i As Integer = Remainder.IndexOf("=")
        If i < 0 Then
            Throw New Exception("Invalid Syntax: " & txt)
        End If




        Value = Remainder.Substring(0, i).Trim
        Action = Remainder.Substring(i + 1).Trim



    End Sub


    Public Overrides Function ToString() As String
        Return Me.Value
    End Function


    Public Overrides ReadOnly Property ThingTypeDesc As String
        Get
            Return "Syntax"
        End Get
    End Property
    Public Overrides ReadOnly Property ThingType As ObjTypes
        Get
            Return ObjTypes.Syntax
        End Get
    End Property
End Class
