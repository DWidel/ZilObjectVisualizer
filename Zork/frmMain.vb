Public Class frmMain


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Using f As New frmLoader
            If f.ShowDialog() = DialogResult.Cancel Then End
            Me.Text = f.SelectedFile
        End Using


        Nav = New Navigation(btnNavBack, btnNavForward)


        Dim qRooms =
                From row In Game.Rooms Order By row.ToString Ascending
                Select row
        lbRooms.DataSource = qRooms.ToList


        Dim qObjects =
                From row In Game.Objects Order By row.ToString Ascending
                Select row
        lbObjects.DataSource = qObjects.ToList ' Me.Objects



        Dim qRoutines =
                From row In Game.Routines Order By row.ToString Ascending
                Select row
        lbRoutines.DataSource = qRoutines.ToList ' Me.Objects


        Dim qGlobals =
                From row In Game.Globals Order By row.ToString Ascending
                Select row
        lbGlobals.DataSource = qGlobals.ToList


        Dim qMacros =
                From row In Game.Macros Order By row.ToString Ascending
                Select row
        lbMacro.DataSource = qMacros.ToList

        lbLog.DataSource = Game.LogTextLst

        For Each S As clsSyntax In Game.Syntaxes
            Dim arr(2) As String
            arr(0) = S.Value
            arr(1) = S.Action
            dgvSyntax.Rows.Add(arr)

        Next



        Dim qFlags =
                From key In Game.FlagDic.Keys Order By key Ascending
                Select key

        lbFlags.DataSource = qFlags.ToList

        'For Each flag As String In Game.FlagDic.Keys
        '    lbFlags.Items.Add(flag)
        'Next

        Dim fFind As New frmFind
        fFind.FormBorderStyle = FormBorderStyle.None
        fFind.Dock = DockStyle.Fill
        fFind.TopLevel = False
        tpFindText.Controls.Add(fFind)
        fFind.Show()

        fndRoom.Init(lbRooms, ObjTypes.Room)
        fndObject.Init(lbObjects, ObjTypes.Object)
        fndRoutine.Init(lbRoutines, ObjTypes.Routine)
        fndMacro.Init(lbMacro, ObjTypes.Macro)
        fndGlobals.Init(lbGlobals, ObjTypes.Global)

    End Sub






    Private Sub NewRoom(name As String)

        For Each R As clsRoom In lbRooms.Items
            If R.Name = name Then
                lbRooms.SelectedItem = R
                TabControl1.SelectedTab = tpRooms
                Exit For
            End If
        Next
    End Sub

    Private Sub NewObject(name As String)
        For Each R As clsObject In lbObjects.Items
            If R.Name = name Then
                lbObjects.SelectedItem = R
                TabControl1.SelectedTab = tpObjects
                Exit For
            End If
        Next
    End Sub

    Private Sub NewRoutine(name As String)
        For Each R As clsRoutine In lbRoutines.Items
            If R.Name = name Then
                lbRoutines.SelectedItem = R
                TabControl1.SelectedTab = tpRoutines
                Exit For
            End If
        Next
    End Sub
    Private Sub NewMacro(name As String)
        For Each R As clsMacro In lbMacro.Items
            If R.Name = name Then
                lbMacro.SelectedItem = R
                TabControl1.SelectedTab = tpMacros
                Exit For
            End If
        Next
    End Sub
    Private Sub NewFlag(name As String)
        For Each R As String In lbFlags.Items
            If R = name Then
                lbFlags.SelectedItem = R
                TabControl1.SelectedTab = tpFlags
                Exit For
            End If
        Next
    End Sub
    Private Sub NewGlobal(name As String)
        For Each R As clsGlobal In lbGlobals.Items
            If R.Name = name Then
                lbGlobals.SelectedItem = R
                Exit For
            End If
        Next
    End Sub


    Private Sub lbRooms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbRooms.SelectedIndexChanged
        Try
            If lbRooms.SelectedItem Is Nothing Then
                Exit Sub
            End If




            Dim R As clsRoom = lbRooms.SelectedItem
            NavToRoom(R)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub


    Private Sub NavToRoom(name As String)
        Dim R As clsRoom = Game.GetRoom(name)
        If R IsNot Nothing Then
            NavToRoom(R)
        End If
    End Sub


    Private Sub NavToRoom(R As clsRoom)

        'Dim f As New frmRoom(R)
        'f.FormBorderStyle = FormBorderStyle.None
        'f.Dock = DockStyle.Fill
        'f.TopLevel = False
        'pnlRoom.Controls.Add(f)
        'AddHandler f.NewRoom, AddressOf NewRoom
        'f.Show()
        'Nav.AddLink(ObjTypes.Room, R.Name)





        Dim fOld As Form = Nothing
        If pnlRoom.Controls.Count = 1 Then
            fOld = pnlRoom.Controls(0)
            fOld.BringToFront()
        End If

        Dim f As New frmRoom(R)
        f.FormBorderStyle = FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.TopLevel = False
        f.SendToBack()
        pnlRoom.Controls.Add(f)
        AddHandler f.NewRoom, AddressOf NewRoom


        f.Show()
        Nav.AddLink(ObjTypes.Room, R.Name)


        If fOld IsNot Nothing Then
            pnlRoom.Controls.RemoveAt(0)
            fOld.Dispose()
        End If

    End Sub


    Private Sub lbObjects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbObjects.SelectedIndexChanged
        Try
            If lbObjects.SelectedItem Is Nothing Then
                Exit Sub
            End If



            Dim fOld As Form = Nothing
            If pnlObjects.Controls.Count = 1 Then
                fOld = pnlObjects.Controls(0)
                fOld.BringToFront()
            End If

            Dim Obj As clsObject = lbObjects.SelectedItem
            Dim f As New frmObject(Obj)
            f.FormBorderStyle = FormBorderStyle.None
            f.Dock = DockStyle.Fill
            f.TopLevel = False
            f.SendToBack()
            pnlObjects.Controls.Add(f)
            AddHandler f.NewObject, AddressOf NewObject


            f.Show()
            Nav.AddLink(ObjTypes.Object, Obj.Name)

            If fOld IsNot Nothing Then
                pnlObjects.Controls.RemoveAt(0)
                fOld.Dispose()
            End If

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
            Dim f As New frmNameValue(Obj)
            f.FormBorderStyle = FormBorderStyle.None
            f.Dock = DockStyle.Fill
            f.TopLevel = False
            pnlRoutine.Controls.Add(f)
            f.Show()
            Nav.AddLink(ObjTypes.Routine, Obj.Name)


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
            Dim f As New frmNameValue(G)
            f.FormBorderStyle = FormBorderStyle.None
            f.Dock = DockStyle.Fill
            f.TopLevel = False
            pnlGlobals.Controls.Add(f)
            f.Show()

            Nav.AddLink(ObjTypes.Global, G.Name)
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

                Dim f As New frmNameValue(Rtn)
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

            Nav.AddLink(ObjTypes.Flag, key)

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
            Dim f As New frmNameValue(M)
            f.FormBorderStyle = FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.TopLevel = False
        pnlMacro.Controls.Add(f)
            f.Show()

            Nav.AddLink(ObjTypes.Macro, M.Name)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnNavBack_Click(sender As Object, e As EventArgs) Handles btnNavBack.Click
        Try

            Dim L As Navigation.Lnk = Nav.Back
        NavigateToLnk(L)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNavForward_Click(sender As Object, e As EventArgs) Handles btnNavForward.Click
        Try
            Dim L As Navigation.Lnk = Nav.Forward
            NavigateToLnk(L)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub NavigateToLnk(L As Navigation.Lnk)
        Select Case L.Type
            Case ObjTypes.Room
                NewRoom(L.Name)
            Case ObjTypes.Object
                NewObject(L.Name)
            Case ObjTypes.Routine
                NewRoutine(L.Name)
            Case ObjTypes.Flag
                NewFlag(L.Name)
            Case ObjTypes.Macro
                NewMacro(L.Name)
            Case ObjTypes.Global
                NewGlobal(L.Name)


        End Select

    End Sub


End Class
