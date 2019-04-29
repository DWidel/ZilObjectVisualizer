﻿Public Class clsMacro
    Inherits clsNameValue





    Public Sub New(txt As String)
        Me.OrigText = txt
        Name = GetSecondWord(txt)

        Value = txt.Substring(txt.IndexOf(Name) + Name.Length).Trim



    End Sub


    Public Overrides Function ToString() As String
        Return Me.Name
    End Function


    Public Overrides ReadOnly Property ThingTypeDesc As String
        Get
            Return "Macro"
        End Get
    End Property
    Public Overrides ReadOnly Property ThingType As ObjTypes
        Get
            Return ObjTypes.Macro
        End Get
    End Property
End Class
