Public MustInherit Class clsBase

    Public OrigText As String
    Public Name As String
    MustOverride ReadOnly Property ThingTypeDesc As String

    MustOverride ReadOnly Property ThingType As ObjTypes


End Class
