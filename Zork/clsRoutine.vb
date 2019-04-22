Public Class clsRoutine
    Inherits clsNameValue





    Public Sub New(txt As String)
        Me.OrigText = txt
        Name = GetSecondWord(txt)

        Value = txt.Substring(txt.IndexOf(Name) + Name.Length).Trim



    End Sub


    Public Overrides Function ToString() As String
        Return Me.Name
    End Function
End Class
