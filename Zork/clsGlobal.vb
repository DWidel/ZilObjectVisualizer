Public Class clsGlobal
    Inherits clsNameValue



    Public Type As VarType = VarType.Global

    Public Enum VarType
        [Global]
        Constant
    End Enum

    Public Sub New(txt As String, vt As VarType)
        Me.OrigText = txt
        Me.Type = vt
        Me.Name = GetSecondWord(txt)
        Me.Value = txt.Substring(txt.IndexOf(Name) + Name.Length).Trim



        'Dim ss() As String = txt.Split(" ")

        'If ss.Count = 3 Then
        '    Name = ss(1).Trim
        '    Value = ss(2).Trim
        'Else
        '    'Throw New Exception("Invalid Global: " & txt)
        '    '          Global HOUSE-AROUND
        '    '<LTABLE (PURE) WEST-Of-HOUSE NORTH-Of-HOUSE EAST-Of-HOUSE SOUTH-Of-HOUSE
        '    ' WEST-OF-HOUSE>

        '    '          Global FOREST-AROUND
        '    '<LTABLE (PURE) FOREST-1 FOREST-2 FOREST-3 PATH CLEARING FOREST-1>

        '    Dim ii As Integer = 0
        'End If




    End Sub

    Public Overrides Function ToString() As String
        Return Me.Name
    End Function

End Class
