Public Module modPublic




    Public Nav As Navigation
    Public Game As Parser

    Public MaxRecentFiles As Integer = 30

    Public Sub LoadSettings()
        Try
            If My.Settings.MaxRecentFiles <> "" Then
                Integer.TryParse(My.Settings.MaxRecentFiles, MaxRecentFiles)
            End If

        Catch ex As Exception
            MsgBox("Error in LoadSettings.")
        End Try
    End Sub



    Public Function TrimTxt(txt As String) As String
        txt = txt.Trim
        If txt.StartsWith("<") And txt.EndsWith(">") Then
            Return txt.Substring(1, txt.Length - 2)
        End If
        Throw New Exception("Invalid Txt: " & txt)


    End Function

    Public Function GetFirstWord(txt As String) As String
        txt = txt.Trim

        For i As Integer = 0 To txt.Length - 1
            Dim C As String = txt.Substring(i, 1)

            If C = " " OrElse C = vbTab OrElse C = vbCr OrElse C = vbLf Then
                Return txt.Substring(0, i).Trim
            End If

        Next
        Return txt.Trim
        'Throw New Exception("Invalid GetFirstWord: " & txt)


    End Function


    Public Function GetSecondWord(txt As String, Optional Safe As Boolean = False) As String


        txt = txt.Trim

        Dim txt2 As String = ""
        For i As Integer = 0 To txt.Length - 1
            Dim C As String = txt.Substring(i, 1)

            If C = " " OrElse C = vbTab OrElse C = vbCr OrElse C = vbLf Then
                txt2 = txt.Substring(i).Trim
                Exit For
            End If

        Next



        If txt2 = "" Then
            If Safe Then
                Return ""
            Else
                Throw New Exception("Invalid GetSecondWord: " & txt)
            End If
        End If

        For i As Integer = 0 To txt2.Length - 1
            Dim C As String = txt2.Substring(i, 1)

            If C = " " OrElse C = vbTab OrElse C = vbCr OrElse C = vbLf Then
                Return txt2.Substring(0, i).Trim
            End If

        Next
        Return txt2.Trim

        'Throw New Exception("Invalid GetSecondWord: " & txt)






    End Function

    ''This is a hack, you shouldn't really split on (), but it seems to work most of the time.
    'Public Function SplitParenths(txt As String) As List(Of String)
    '    Dim lst As New List(Of String)
    '    Dim Chunk As String = ""

    '    Dim IsChunk As Boolean = False

    '    Dim PrevC As String = ""
    '    For i As Integer = 0 To txt.Length - 1
    '        Dim C As String = txt.Substring(i, 1)

    '        If Not IsChunk Then
    '            If C = "(" AndAlso PrevC <> ";" Then
    '                IsChunk = True
    '            End If

    '        Else
    '            If C = ")" Then
    '                IsChunk = False
    '                lst.Add(Chunk)
    '                Chunk = ""
    '            Else
    '                Chunk &= C
    '            End If

    '        End If

    '        PrevC = C
    '    Next

    '    Return lst

    'End Function

    Public Function SplitParenths(txt As String) As List(Of String)

        Dim chunks As New List(Of String)
        Dim temp As String = ""
        Dim CommentedOut As Boolean = False


        Dim idx As Integer = 0


        While idx < txt.Count

            Dim C As String = txt.Substring(idx, 1)

            'skip until not whitespace
            Do Until Not IsWhiteSpace(C)
                idx += 1
                If idx >= txt.Count Then Exit While
                C = txt.Substring(idx, 1)
            Loop

            'check for a comment mark; if it is keep chunk but mark chunk.
            If C = ";" Then
                CommentedOut = True
                temp = ";"
                Do
                    idx += 1
                    If idx >= txt.Count Then Exit While
                    C = txt.Substring(idx, 1)
                Loop Until Not IsWhiteSpace(C)
            End If



            Select Case C
                Case """" 'text mode ' Is Comment, was expecting a (
                    Do
                        idx += 1
                        C = txt.Substring(idx, 1)
                        If C = "\" Then
                            'next character is escaped
                            idx += 1
                            C = txt.Substring(idx, 1)
                            temp &= C
                            idx += 1
                            C = txt.Substring(idx, 1)
                        Else
                            temp &= C
                        End If

                    Loop Until C = """"
                    temp = "" 'Throw away comment


                Case "("
                    'START OF CHUNK.  Look for end paren
                    Dim Paren = 1
                    Do
                        idx += 1
                        C = txt.Substring(idx, 1)
                        Select Case C
                            Case "("
                                Paren += 1
                            Case ")"
                                Paren -= 1
                                If Paren = 0 Then
                                    Exit Do
                                End If
                            Case "\"
                                'next character is escaped
                                idx += 1
                                C = txt.Substring(idx, 1)

                            Case """"
                                'loop until find next unescaped quote
                                Do
                                    idx += 1
                                    If idx >= txt.Count Then Exit While
                                    C = txt.Substring(idx, 1)
                                    If C = "\" Then
                                        'next character is escaped
                                        idx += 1
                                        C = txt.Substring(idx, 1)
                                        temp &= C
                                        C = ""
                                        'idx += 1
                                        'C = txt.Substring(idx, 1)
                                    ElseIf C = """" Then

                                    Else
                                        temp &= C
                                    End If

                                Loop Until C = """"
                                C = ""
                        End Select
                        temp &= C
                    Loop Until False


                    chunks.Add(temp)
                    temp = ""
            End Select



            idx += 1

        End While 'look for next chunk

        Return chunks

    End Function

    Private Function IsWhiteSpace(c As String) As Boolean
        Select Case c
            Case " ", vbTab, vbCr, vbLf
                Return True
            Case Else
                Return False
        End Select
    End Function


    Public Function ConvertToList(txt As String, SkipFirstWord As Boolean) As List(Of String)

        Dim lst As New List(Of String)


        Dim idx As Integer = 0

        While True

            Dim C As String = txt.Substring(idx, 1)

            Do Until Not IsWhiteSpace(C)
                idx += 1
                If idx >= txt.Count Then
                    Exit While
                End If
                C = txt.Substring(idx, 1)
            Loop


            Dim word As String = ""
            Do
                word &= C
                idx += 1
                If idx >= txt.Count Then
                    lst.Add(word)
                    Exit While
                End If
                C = txt.Substring(idx, 1)

            Loop Until IsWhiteSpace(C)

            lst.Add(word)



        End While


        If SkipFirstWord And lst.Count > 0 Then
            lst.RemoveAt(0)
        End If

        Return lst

    End Function


    Public Function FixLineEndings(txt As String) As String
        If txt Is Nothing Then Return ""
        Return txt.Replace(vbLf, vbCrLf)


    End Function

    Public Function TrimQuotes(txt As String) As String
        If txt.StartsWith("""") Then txt = txt.Substring(1)
        If txt.EndsWith("""") Then txt = txt.Substring(0, txt.Length - 1)
        Return txt
    End Function


    Public Sub AddPropToDic(ByRef dic As Dictionary(Of String, String), Name As String, Value As String)
        If Not dic.ContainsKey(Name) Then
            dic.Add(Name, Value)
        Else
            'contains direction already
            Dim Version As Integer = 1
            Do
                Version += 1
            Loop Until Not dic.ContainsKey(Name & Version.ToString)
            dic.Add(Name & Version.ToString, Value)

        End If
    End Sub


    Public Sub ClearPanel(pnl As Panel)
        Do Until pnl.Controls.Count = 0
            Dim f As Form = pnl.Controls(0)
            pnl.Controls.RemoveAt(0)
            f.Dispose()
        Loop


    End Sub


    Public Enum ObjTypes
        Unknown = 0
        Room
        [Object]
        Routine
        Flag
        Macro
        [Global]
        Synonym
        Syntax
        Pseudo
    End Enum



    Public Sub ShowThingDialog(Thing As clsBase)

        Using f As Form = GetThingDialog(Thing)
            f.ShowDialog()
        End Using


    End Sub



    Public Function GetThingDialog(Thing As clsBase) As Windows.Forms.Form
        Select Case Thing.GetType.Name
            Case GetType(clsRoom).Name
                Return New frmRoom(Thing)
            Case GetType(clsObject).Name
                Return New frmObject(Thing)
            Case GetType(clsRoutine).Name
                Return New frmNameValue(Thing)
            Case GetType(clsMacro).Name
                Return New frmNameValue(Thing)
            Case GetType(clsGlobal).Name
                Return New frmNameValue(Thing)
            Case GetType(clsSyntax).Name
                Return New frmNameValue(Thing)
            Case GetType(clsSynonym).Name
                Return New frmNameValue(Thing)

            Case Else
                Throw New Exception("Get Thing Dialog unhandled")

        End Select


    End Function


    Public Sub ShowFormattedText(txt As String, SuppressLF As Boolean)
        If txt.Trim = "" Then Exit Sub


        If SuppressLF Then
            txt = txt.Replace(vbLf, "").Replace(vbCr, "")
        End If
        txt = txt.Replace("|", vbCrLf)
        Using f As New frmOriginalText(txt)
            f.Text = "Formatted Text"
            f.ShowDialog()
        End Using

    End Sub

End Module
