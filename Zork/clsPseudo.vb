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
    Public Overrides ReadOnly Property ThingTypeDesc As String
        Get
            Return "Pseudo"
        End Get
    End Property
    Public Overrides ReadOnly Property ThingType As ObjTypes
        Get
            Return ObjTypes.Pseudo
        End Get
    End Property
End Class
