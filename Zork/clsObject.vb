Public Class clsObject
    Inherits clsBase


    'Public IsIn As String
    'Public Location As String
    Public Parent As String
    Public Text As String
    Public Synonyms As New List(Of String)
    Public Adjectives As New List(Of String)
    Public Flags As New List(Of String)
    Public Action As String
    Public Desc As String
    Public LDesc As String
    'Public Size As String
    'Public Value As String
    'Public TValue As String
    Public FDesc As String
    'Public Capacity As String
    Public DESCFCN As String
    'Public Strength As String
    'Public VType As String
    'Public Globals As String
    '   Object BOARD
    '(IN LOCAL-GLOBALS)
    '(SYNONYM BOARDS BOARD)
    '(DESC "board")
    '(FLAGS NDESCBIT)
    '(ACTION BOARD-F)

    Public Props As New Dictionary(Of String, String)
    Public Objects As New List(Of String)


    Public Sub New(txt As String)
        Me.OrigText = txt

        Name = GetSecondWord(txt)

        Dim Remainder As String = txt.Substring(txt.IndexOf(Name) + Name.Length).Trim
        Dim lst As List(Of String) = SplitParenths(Remainder)

        Dim ctr As Integer = 0
        For Each chunk As String In lst
            Dim FirstWord As String = GetFirstWord(chunk)
            Dim Remainder2 As String = chunk.Substring(chunk.IndexOf(FirstWord) + FirstWord.Length).Trim
            Select Case FirstWord
                Case "SYNONYM"
                    Me.Synonyms = ConvertToList(chunk, True)
                Case "ADJECTIVE"
                    Me.Adjectives = ConvertToList(chunk, True)
                Case "DESC"
                    Desc = Remainder2
                Case "FLAGS"
                    Me.Flags = ConvertToList(chunk, True)

                Case "LDESC"
                    LDesc = Remainder2
                Case "FDESC"
                    FDesc = Remainder2
                Case "DESCFCN"
                    Me.DESCFCN = Remainder2
                Case "TEXT"
                    Me.Text = Remainder2
                'Case "VALUE"
                '    Me.Value = Remainder2
                'Case "TVALUE"
                '    Me.TValue = Remainder2
                'Case "SIZE"
                '    Me.Size = Remainder2
                Case ";IN"
                    If ctr = 0 Then
                        ctr -= 1
                        'if the first in is commented out, then don't inc ctr.
                    End If
                    AddPropToDic(Props, FirstWord, Remainder2)
                Case "IN"
                    'If it's first it seems to mean samething as location.
                    'E.G. Hitch
                    'Otherwise it's a direction. 
                    If ctr = 0 Then
                        Me.Parent = Remainder2
                    Else
                        AddPropToDic(Props, FirstWord, Remainder2)
                    End If
                Case "ACTION"
                    Me.Action = Remainder2
                Case "GLOBAL"

                    Me.Objects = ConvertToList(chunk, True)

                    'Case "CAPACITY"
                    '    Me.Capacity = Remainder2
                    'Case "STRENGTH"
                    '    Me.Strength = Remainder2
                    'Case "VTYPE"
                    '    Me.VType = Remainder2
                Case "LOC"
                    If Me.Parent <> "" Then
                        Throw New Exception("Multiple Parents")
                    End If
                    Me.Parent = Remainder2
                Case Else

                    AddPropToDic(Props, FirstWord, Remainder2)

            End Select

            ctr += 1
        Next





    End Sub


    Public Overrides Function ToString() As String
        Return Me.Name & "-" & Me.Desc
    End Function


End Class
