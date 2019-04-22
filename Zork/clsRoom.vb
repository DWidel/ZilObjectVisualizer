Public Class clsRoom
    Inherits clsBase


    Public IsIn As String
    Public LDesc As String
    Public Desc As String
    Public Action As String
    Public Objects As New List(Of String)
    Public Value As String
    Public PSEUDO As String


    Public Flags As New List(Of String)
    Public Directions As New Dictionary(Of String, String)
    Public Pseudos As New Dictionary(Of String, String)
    Public Synonyms As New List(Of String)

    Public Props As New Dictionary(Of String, String)


    Public Sub New(txt As String)
        Me.OrigText = txt

        Name = GetSecondWord(txt)


        Dim Remainder As String = txt.Substring(txt.IndexOf(Name) + Name.Length).Trim
        Dim lst As List(Of String) = SplitParenths(Remainder)

        For i As Integer = 0 To lst.Count - 1

            Dim chunk As String = lst(i)
            Dim FirstWord As String = GetFirstWord(chunk)
            Dim Remainder2 As String = chunk.Substring(chunk.IndexOf(FirstWord) + FirstWord.Length).Trim
            If i = 0 And FirstWord = "IN" Then
                Me.IsIn = Remainder2
                Continue For
            End If

            Select Case FirstWord
                Case "FLAGS"
                    Me.Flags = ConvertToList(chunk, True)
                Case "DESC"
                    Desc = Remainder2
                Case "LDESC"
                    LDesc = Remainder2

                Case "ACTION"
                    Me.Action = Remainder2
                Case "GLOBAL"
                    Me.Objects = ConvertToList(chunk, True)


                Case "PSEUDO"
                    '  (PSEUDO "NAILS" NAILS-PSEUDO "NAIL" NAILS-PSEUDO)
                    'PSEUDO "CHASM" CHASM-PSEUDO
                    'PSEUDO "DOOR" DOOR-PSEUDO "PAINT" PAINT-PSEUDO
                    'TODO
                    Me.PSEUDO = Remainder2
                    Dim ss() As String = Remainder2.Split(" ")
                    For idx As Integer = 0 To ss.Count - 1 Step 2
                        Dim key As String = TrimQuotes(ss(idx))
                        Dim action As String = ss(idx + 1)
                        If key <> "" AndAlso action <> "" Then
                            'Pseudos.Add(key, action)
                            AddPropToDic(Me.Pseudos, key, action)
                        End If

                    Next


                Case "SYNONYM"
                    Me.Synonyms = ConvertToList(chunk, True)
                    'Case "ADJECTIVE"
                    '    Me.Adjectives = ConvertToList(chunk, True)

                    'Case "FDESC"
                    '    FDesc = Remainder2
                Case "VALUE"
                    Me.Value = Remainder2
                    'Case "TVALUE"
                    '    Me.TValue = Remainder2
                    'Case "SIZE"
                    '    Me.Size = Remainder2

                    'Case "CAPACITY"
                    '    Me.Capacity = Remainder2
                    'Case "DESCFCN"
                    '    Me.DESCFCN = Remainder2
                    'Case "TEXT"
                    '    Me.Text = Remainder2
                    'Case "STRENGTH"
                    '    Me.Strength = Remainder2
                    'Case "VTYPE"
                    '    Me.VType = Remainder2
                Case Else


                    If Game.Directions IsNot Nothing AndAlso Game.Directions.lst.Contains(FirstWord) Then
                        If Not Me.Directions.ContainsKey(FirstWord) Then
                            Me.Directions.Add(FirstWord, Remainder2)
                        Else
                            'contains direction already
                            Dim Version As Integer = 1
                            Do
                                Version += 1
                            Loop Until Not Me.Directions.ContainsKey(FirstWord & Version.ToString)
                            Me.Directions.Add(FirstWord & Version.ToString, Remainder2)

                        End If
                    Else
                        AddPropToDic(Props, FirstWord, Remainder2)
                        'Props.Add(FirstWord, Remainder2)


                    End If



            End Select
        Next

    End Sub


    Public Sub SetDirections(directions As clsDirections)
        Dim Removals As New List(Of String)
        For Each Key As String In Props.Keys
            If directions.lst.Contains(Key) Then
                Me.Directions.Add(Key, Props(Key))
                Removals.Add(Key)
            End If

        Next

        For Each Key As String In Removals
            Props.Remove(Key)
        Next

    End Sub



    Public Overrides Function ToString() As String
        Return Me.Name & "-" & Me.Desc
    End Function



End Class
