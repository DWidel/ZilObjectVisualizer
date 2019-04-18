Public Class frmMain


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Using f As New frmLoader
            If f.ShowDialog() = DialogResult.Cancel Then End
            Me.Text = f.SelectedFile
        End Using


        lbRooms.DataSource = Game.Rooms
        lbObjects.DataSource = Game.Objects
        lbRoutines.DataSource = Game.Routines
        lbGlobals.DataSource = Game.Globals
        lbMacro.DataSource = Game.Macros
        lbLog.DataSource = Game.LogTextLst

        For Each S As clsSyntax In Game.Syntaxes
            Dim arr(2) As String
            arr(0) = S.Value
            arr(1) = S.Action
            dgvSyntax.Rows.Add(arr)

        Next




        For Each flag As String In Game.FlagDic.Keys
            lbFlags.Items.Add(flag)
        Next

        Dim fFind As New frmFind
        fFind.FormBorderStyle = FormBorderStyle.None
        fFind.Dock = DockStyle.Fill
        fFind.TopLevel = False
        tpFindText.Controls.Add(fFind)
        fFind.Show()



    End Sub






    Private Sub NewRoom(name As String)
        For Each R As clsRoom In lbRooms.Items
            If R.Name = name Then
                lbRooms.SelectedItem = R
                Exit For
            End If
        Next
    End Sub

    Private Sub NewObject(name As String)
        For Each R As clsObject In lbObjects.Items
            If R.Name = name Then
                lbObjects.SelectedItem = R
                Exit For
            End If
        Next
    End Sub

    Private Sub lbRooms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbRooms.SelectedIndexChanged
        Try
            If lbRooms.SelectedItem Is Nothing Then
                Exit Sub
            End If
            pnlRoom.Controls.Clear()

            Dim R As clsRoom = lbRooms.SelectedItem
            Dim f As New frmRoom(R)
            f.FormBorderStyle = FormBorderStyle.None
            f.Dock = DockStyle.Fill
            f.TopLevel = False
            pnlRoom.Controls.Add(f)
            AddHandler f.NewRoom, AddressOf NewRoom
            f.Show()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub lbObjects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbObjects.SelectedIndexChanged
        Try
            If lbObjects.SelectedItem Is Nothing Then
                Exit Sub
            End If

            ClearPanel(pnlObjects)

            Dim Obj As clsObject = lbObjects.SelectedItem
            Dim f As New frmObject(Obj)
            f.FormBorderStyle = FormBorderStyle.None
            f.Dock = DockStyle.Fill
            f.TopLevel = False
            pnlObjects.Controls.Add(f)
            AddHandler f.NewObject, AddressOf NewObject
            f.Show()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub lbRoutines_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbRoutines.SelectedIndexChanged
        Try

            If lbRoutines.SelectedItem Is Nothing Then
            Exit Sub
        End If

        ClearPanel(pnlRoutine)

        Dim Obj As clsRoutine = lbRoutines.SelectedItem
        Dim f As New frmRoutine(Obj)
        f.FormBorderStyle = FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.TopLevel = False
        pnlRoutine.Controls.Add(f)
        f.Show()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub



    Private Sub lbGlobals_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbGlobals.SelectedIndexChanged
        Try
            If lbGlobals.SelectedItem Is Nothing Then
                Exit Sub
            End If

            ClearPanel(pnlGlobals)

            Dim G As clsGlobal = lbGlobals.SelectedItem
            Dim f As New frmGlobal(G)
            f.FormBorderStyle = FormBorderStyle.None
            f.Dock = DockStyle.Fill
            f.TopLevel = False
            pnlGlobals.Controls.Add(f)
            f.Show()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub dgvSyntax_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSyntax.SelectionChanged
        Try
            Dim R As DataGridViewRow = dgvSyntax.SelectedRows(0)
        Dim Action As String = R.Cells(1).Value.ToString
        Dim txt As String = R.Cells(0).Value.ToString

        Dim Rtn As clsRoutine = Game.GetRoutine(Action)
        If Rtn IsNot Nothing Then
            pnlSyntax.Controls.Clear()

            Dim f As New frmRoutine(Rtn)
            f.FormBorderStyle = FormBorderStyle.None
            f.Dock = DockStyle.Fill
            f.TopLevel = False
            pnlSyntax.Controls.Add(f)
            f.Show()

        End If

        dgvSyns.Columns.Clear()

        Dim lst As List(Of String) = ConvertToList(txt, False)
        Dim dic As New Dictionary(Of String, clsSynonym)
        Dim collst As New List(Of String)
        For Each word As String In lst
            word = word.Trim
            If word = "OBJECT" Then Continue For
            If word.StartsWith("(") Then Exit For
            collst.Add(word)
            'If word.StartsWith("(") Then word = word.Substring(1)
            'If word.EndsWith(")") Then word = word.Substring(0, word.Length - 1)
            Dim c As New DataGridViewColumn(New DataGridViewTextBoxCell)
            c.HeaderText = word
            dgvSyns.Columns.Add(c)

            Dim syn As clsSynonym = Game.GetSyn(word)
            If syn IsNot Nothing Then
                dic.Add(word, syn)
            Else
                dic.Add(word, Nothing)
            End If


        Next

        Dim RowCnt As Integer = 0
        For i As Integer = 0 To collst.Count - 1
            Dim syn As clsSynonym = dic(collst(i))
            If syn Is Nothing Then Continue For
            If syn.Values.Count > RowCnt Then
                RowCnt = syn.Values.Count
            End If
        Next


        If RowCnt > 0 Then

            Dim RowIdx As Integer = 0
            Do

                Dim arr(collst.Count) As String

                For i As Integer = 0 To collst.Count - 1
                    Dim syn As clsSynonym = dic(collst(i))
                    If syn Is Nothing Then Continue For
                    If syn.Values.Count > RowIdx Then
                        arr(i) = syn.Values(RowIdx)
                    End If
                Next
                dgvSyns.Rows.Add(arr)
                RowIdx += 1
            Loop Until RowIdx >= RowCnt
        End If



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub txtObjectFilter_TextChanged(sender As Object, e As EventArgs) Handles txtObjectFilter.TextChanged
        Dim key As String = txtObjectFilter.Text


    End Sub

    Private Sub btnFindObject_Click(sender As Object, e As EventArgs) Handles btnFindObject.Click
        Try
            Dim key As String = txtObjectFilter.Text.ToUpper
        Dim idx As Integer = 0

        idx = lbObjects.SelectedIndex
        For i As Integer = idx + 1 To Game.Objects.Count - 1
            If Game.Objects(i).ToString.ToUpper.Contains(key) Then
                lbObjects.SelectedIndex = i
                Exit Sub
            End If
        Next

        For i As Integer = 0 To idx - 1
            If Game.Objects(i).ToString.ToUpper.Contains(key) Then
                lbObjects.SelectedIndex = i
                Exit Sub
            End If
        Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnFindFilter_Click(sender As Object, e As EventArgs) Handles btnFindFilter.Click
        Try
            Dim key As String = txtRoomFilter.Text.ToUpper
        Dim idx As Integer = 0

        idx = lbRooms.SelectedIndex
        For i As Integer = idx + 1 To Game.Rooms.Count - 1
            If Game.Rooms(i).ToString.ToUpper.Contains(key) Then
                lbRooms.SelectedIndex = i
                Exit Sub
            End If
        Next

        For i As Integer = 0 To idx - 1
            If Game.Rooms(i).ToString.ToUpper.Contains(key) Then
                lbRooms.SelectedIndex = i
                Exit Sub
            End If
        Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnRoutineFind_Click(sender As Object, e As EventArgs) Handles btnRoutineFind.Click
        Try
            Dim key As String = txtRoutineFilter.Text.ToUpper
            Dim idx As Integer = 0

            idx = lbRoutines.SelectedIndex
            For i As Integer = idx + 1 To Game.Routines.Count - 1
                If Game.Routines(i).ToString.ToUpper.Contains(key) Then
                    lbRoutines.SelectedIndex = i
                    Exit Sub
                End If
            Next

            For i As Integer = 0 To idx - 1
                If Game.Routines(i).ToString.ToUpper.Contains(key) Then
                    lbRoutines.SelectedIndex = i
                    Exit Sub
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnFlagFind_Click(sender As Object, e As EventArgs) Handles btnFlagFind.Click
        Try
            Dim key As String = txtFlagFilter.Text.ToUpper
        Dim idx As Integer = 0

        idx = lbFlags.SelectedIndex
        For i As Integer = idx + 1 To Game.FlagDic.Values.Count - 1
            If Game.FlagDic.Values(i).ToString.ToUpper.Contains(key) Then
                lbFlags.SelectedIndex = i
                Exit Sub
            End If
        Next

            For i As Integer = 0 To idx - 1
                If Game.FlagDic.Values(i).ToString.ToUpper.Contains(key) Then
                    lbFlags.SelectedIndex = i
                    Exit Sub
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub lbFlags_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbFlags.SelectedIndexChanged
        Try
            If lbFlags.SelectedItem Is Nothing Then
            Exit Sub
        End If

        ClearPanel(pnlFlag)

        Dim key As String = lbFlags.SelectedItem
        Dim f As New frmRefs(Game.FlagDic(key), key)
        f.FormBorderStyle = FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.TopLevel = False
        pnlFlag.Controls.Add(f)
            f.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    'Private Sub btnFindFilter_Click(sender As Object, e As EventArgs) Handles btnFindFilter.Click
    '    Dim key As String = txtRoomFilter.Text.ToUpper
    '    Dim idx As Integer = 0

    '    idx = lbRooms.SelectedIndex
    '    For i As Integer = idx + 1 To Game.Rooms.Count - 1
    '        If Game.Rooms(i).ToString.ToUpper.Contains(key) Then
    '            lbRooms.SelectedIndex = i
    '            Exit Sub
    '        End If
    '    Next

    '    For i As Integer = 0 To idx - 1
    '        If Game.Rooms(i).ToString.ToUpper.Contains(key) Then
    '            lbRooms.SelectedIndex = i
    '            Exit Sub
    '        End If
    '    Next

    'End Sub
    Private Sub btnMacroFind_Click(sender As Object, e As EventArgs) Handles btnMacroFind.Click
        Try
            Dim key As String = txtMacroFilter.Text.ToUpper
        Dim idx As Integer = 0

        idx = lbMacro.SelectedIndex
        For i As Integer = idx + 1 To Game.Rooms.Count - 1
            If Game.Rooms(i).ToString.ToUpper.Contains(key) Then
                lbMacro.SelectedIndex = i
                Exit Sub
            End If
        Next

        For i As Integer = 0 To idx - 1
            If Game.Rooms(i).ToString.ToUpper.Contains(key) Then
                lbMacro.SelectedIndex = i
                Exit Sub
            End If
        Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub lbMacro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbMacro.SelectedIndexChanged
        Try
            If lbMacro.SelectedItem Is Nothing Then
            Exit Sub
        End If

        ClearPanel(pnlMacro)
        Dim M As clsMacro = lbMacro.SelectedItem
        Dim f As New frmMacro(M)
        f.FormBorderStyle = FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.TopLevel = False
        pnlMacro.Controls.Add(f)
            f.Show()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class
