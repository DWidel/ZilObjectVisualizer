Public Class Navigation


    Private lst As New List(Of Lnk)

    Private Idx As Integer = -1

    Private btnBack As ToolStripButton
    Private btnForward As ToolStripButton



    Public Sub New(btnBack As ToolStripButton, btnForward As ToolStripButton)
        Me.btnBack = btnBack
        Me.btnForward = btnForward

    End Sub

    Public Sub SetButtonState()
        btnBack.Enabled = Idx > 0
        btnForward.Enabled = Idx < lst.Count - 1
    End Sub



    Public Sub AddLink(type As ObjTypes, name As String)


        Dim L As New Lnk(type, name)
        If Idx >= 0 Then
            'Don't add a new link if this is the same link.
            If lst(Idx).Key = L.Key Then Exit Sub
        End If

        If Idx <> lst.Count - 1 Then
            lst.RemoveRange(Idx + 1, lst.Count - (Idx + 1))
        End If

        lst.Add(L)
        Idx = lst.Count - 1

        SetButtonState()
    End Sub


    Public Function Back() As Lnk
        Idx -= 1
        If Idx < 0 Then Idx = 0
        SetButtonState()
        Return lst(Idx)
    End Function
    Public Function Forward() As Lnk
        Idx += 1
        If Idx > lst.Count - 1 Then Idx = lst.Count - 1
        SetButtonState()
        Return lst(Idx)
    End Function



    Public Class Lnk
        Public Sub New(type As ObjTypes, name As String)
            Me.Type = type
            Me.Name = name
        End Sub
        Public Type As ObjTypes
        Public Name As String
        Public ReadOnly Property Key
            Get
                Return Type.ToString & "|" & Name
            End Get
        End Property

    End Class

End Class
