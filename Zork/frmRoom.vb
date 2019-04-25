Public Class frmRoom

    Public Event NewRoom(Name As String)

    Private Room As clsRoom


    Public Sub New(R As clsRoom)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Room = R

    End Sub
    Private Sub frmRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = Room.Name
        txtDesc.Text = Room.Desc
        txtLDesc.Text = FixLineEndings(Room.LDesc)



        txtAction.Text = Room.Action

        txtValue.Text = Room.Value

        txtParent.Text = Room.parent


        For Each dir As String In Room.Directions.Keys
            Dim Arr(2) As String
            Arr(0) = dir
            Arr(1) = Room.Directions(dir)
            dgvDirections.Rows.Add(Arr)


        Next
        'txtPseudo.Text = Room.PSEUDO
        'For Each txt As String In Room.Pseudos.Keys
        '    Dim Arr(2) As String
        '    Arr(0) = txt
        '    Arr(1) = Room.Pseudos(txt)
        '    dgvPseudos.Rows.Add(Arr)
        'Next



        For Each ps As clsPseudo In Room.Pseudos
            lbPseudos.Items.Add(ps)
        Next

        For Each Obj As String In Room.Objects
            lbObjects.Items.Add(Obj)
        Next

        Dim lst As List(Of clsObject) = Game.GetObjectsInRoomOrObject(Room.Name)
        For Each Obj As clsObject In lst
            lbObjectsHere.Items.Add(Obj.Name)

        Next


        For Each flag As String In Room.Flags
            lbFlags.Items.Add(flag)

        Next



    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblAction.Click

    End Sub

    Private Sub lblAction_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblAction.LinkClicked
        Dim Key As String = txtAction.Text

        Dim R As clsRoutine = Game.GetRoutine(Key)

        If R IsNot Nothing Then
            Using f As New frmNameValue(R)
                f.ShowDialog()
            End Using
        End If


    End Sub


    Private Sub lbObjects_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lbObjects.MouseDoubleClick
        If lbObjects.SelectedItem Is Nothing Then Exit Sub

        Dim key As String = lbObjects.SelectedItem

        Dim R As clsObject = Game.GetObject(key)

        If R IsNot Nothing Then
            Using f As New frmObject(R)
                f.ShowDialog()
            End Using
        End If

    End Sub
    Private Sub lbObjectsHere_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lbObjectsHere.MouseDoubleClick
        If lbObjectsHere.SelectedItem Is Nothing Then Exit Sub

        Dim key As String = lbObjectsHere.SelectedItem

        Dim R As clsObject = Game.GetObject(key)

        If R IsNot Nothing Then
            Using f As New frmObject(R)
                f.ShowDialog()
            End Using
        End If

    End Sub


    Private Sub dgvDirections_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvDirections.MouseDoubleClick
        If dgvDirections.SelectedRows.Count = 0 Then Exit Sub

        Dim key As String = dgvDirections.SelectedRows(0).Cells(1).Value.ToString
        If key.StartsWith("TO ") Then
            Dim Room As String = GetSecondWord(key)
            RaiseEvent NewRoom(Room)
        ElseIf key.StartsWith("PER ") Then
            Dim action As String = key.Substring(4).Trim
            Dim A As clsRoutine = Game.GetRoutine(action)
            Using f As New frmNameValue(A)
                f.ShowDialog()
            End Using
        Else
            MsgBox(key)
        End If


    End Sub


    Private Sub lbFlags_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lbFlags.MouseDoubleClick
        If lbFlags.SelectedItem Is Nothing Then Exit Sub

        Dim key As String = lbFlags.SelectedItem

        Dim R As List(Of String) = Game.FlagDic(key)

        If R IsNot Nothing Then
            Using f As New frmRefs(R, key)
                f.ShowDialog()
            End Using
        End If

    End Sub




    Private Sub lbPseudos_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lbPseudos.MouseDoubleClick
        If lbPseudos.SelectedItem Is Nothing Then Exit Sub

        Dim ps As clsPseudo = lbPseudos.SelectedItem
        Dim A As clsRoutine = Game.GetRoutine(ps.Routine)
        Using f As New frmNameValue(A)
            f.ShowDialog()
        End Using

    End Sub


    Private Sub lbObjectsHere_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbObjectsHere.SelectedIndexChanged

    End Sub

    Private Sub lblText_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblText.LinkClicked
        Using f As New frmOriginalText(Me.Room.OrigText)
            f.ShowDialog()
        End Using
    End Sub

    Private Sub lbObjects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbObjects.SelectedIndexChanged

    End Sub

    Private Sub lblIN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblIN.LinkClicked
        Try

            HandleNav(txtParent.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub HandleNav(key As String)
        Dim Obj As clsObject = Game.GetObject(key)
        If Obj IsNot Nothing Then
            Using f As New frmObject(Obj)
                f.ShowDialog()
            End Using
        Else
            Dim Rm As clsRoom = Game.GetRoom(key)
            If Rm IsNot Nothing Then
                Using f As New frmRoom(Rm)
                    f.ShowDialog()
                End Using
            End If
        End If


    End Sub

    Private Sub btnLDesc_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnLDesc.LinkClicked
        Dim txt As String = txtLDesc.Text
        If txt <> "" Then
            'txt = txt.Replace(vbLf, " ").Replace(vbCr, " ")
            'txt = txt.Replace("|", vbCrLf)
            Using f As New frmOriginalText(txt)
                f.Text = "Formatted Text"
                f.ShowDialog()
            End Using
        End If
    End Sub
End Class