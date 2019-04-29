Public Class clsFlag
    Inherits clsBase


    Public Refs As New List(Of String)

    Public Sub New(name As String, RefLst As List(Of String))
        Me.Name = name
        Refs = RefLst

    End Sub


    Public Overrides ReadOnly Property ThingTypeDesc As String
        Get
            Return "Flag"
        End Get
    End Property

    Public Overrides ReadOnly Property ThingType As ObjTypes
        Get
            Return ObjTypes.Flag
        End Get
    End Property
End Class
