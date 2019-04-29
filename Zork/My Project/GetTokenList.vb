Public Class GetTokenList

    Private Txt As String
    Public WordList As New List(Of String)
    Public StringList As New List(Of String)

    Public Sub New(txt As String)
        Me.Txt = txt

        Start()
    End Sub

    'this is to find the word list, ignores parenths and brackets etc.
    Public Sub Start()

        Dim idx As Integer = 0
        Dim temp As String = ""

        While True
            Dim C As String = Txt.Substring(idx, 1)

            Do Until IsValidTokenChar(C)
                idx += 1
                If idx >= Txt.Length Then
                    Exit While
                End If
                C = Txt.Substring(idx, 1)
            Loop


            If C = """" Then
                'quote start
                temp = C
                Do
                    idx += 1
                    C = Txt.Substring(idx, 1)
                    If C = "\" Then
                        'next character is escaped
                        idx += 1
                        C = Txt.Substring(idx, 1)
                        temp &= C
                        idx += 1
                        C = Txt.Substring(idx, 1)
                    Else
                        temp &= C
                    End If

                Loop Until C = """"
                StringList.Add(temp)
                idx += 1
                If idx >= Txt.Length Then
                    Exit While
                End If

            Else
                'token start
                temp = ""
                Do
                    temp &= C
                    idx += 1
                    If idx >= Txt.Length Then
                        WordList.Add(temp)
                        Exit While
                    End If
                    C = Txt.Substring(idx, 1)
                Loop Until Not IsValidTokenChar(C)

                WordList.Add(temp)
                idx += 1
                If idx >= Txt.Length Then
                    Exit While
                End If
                temp = ""
            End If


        End While



    End Sub

    Private Function IsValidTokenChar(C As Char)
        Select Case Asc(C)
            Case Asc("a") To Asc("z")
                Return True
            Case Asc("A") To Asc("Z")
                Return True
            Case Asc("""")
                Return True
            Case Asc("-")
                Return True
            Case Else
                Return False
        End Select

    End Function

End Class
