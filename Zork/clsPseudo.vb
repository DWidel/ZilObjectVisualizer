Public Class clsPseudo
    Inherits clsBase


    Public Routine As String

    Public Sub New(name As String, routine As String)
        Me.Name = name
        Me.Routine = routine
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Name
    End Function

End Class
