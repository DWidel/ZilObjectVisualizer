Public Module modPublic


    Public Game As Parser



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

    'This is a hack, you shouldn't really split on (), but it seems to work most of the time.
    Public Function SplitParenths(txt As String) As List(Of String)
        Dim lst As New List(Of String)
        Dim Chunk As String = ""

        Dim IsChunk As Boolean = False

        Dim PrevC As String = ""
        For i As Integer = 0 To txt.Length - 1
            Dim C As String = txt.Substring(i, 1)

            If Not IsChunk Then
                If C = "(" AndAlso PrevC <> ";" Then
                    IsChunk = True
                End If

            Else
                If C = ")" Then
                    IsChunk = False
                    lst.Add(Chunk)
                    Chunk = ""
                Else
                    Chunk &= C
                End If

            End If

            PrevC = C
        Next

        Return lst

    End Function


    Public Function ConvertToList(txt As String, SkipFirstWord As Boolean) As List(Of String)

        Dim lst As New List(Of String)

        Dim word As String = ""
        For i As Integer = 0 To txt.Length - 1
            Dim C As String = txt.Substring(i, 1)

            If C = " " OrElse C = vbTab OrElse C = vbCr OrElse C = vbLf Then
                lst.Add(word.Trim)
                word = ""
            Else
                word &= C
            End If

        Next

        If word <> "" Then lst.Add(word)

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
End Module
