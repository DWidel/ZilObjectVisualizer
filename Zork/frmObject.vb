Public Class frmObject


    Public Event NewObject(Name As String)
    Private Obj As clsObject





    Public Sub New(O As clsObject)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Obj = O

    End Sub
    Private Sub frmRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = Obj.Name
        txtDesc.Text = FixLineEndings(Obj.Desc)
        txtLDesc.Text = FixLineEndings(Obj.LDesc)

        txtAction.Text = Obj.Action


        For Each flag As String In Obj.Flags
            lbFlags.Items.Add(flag)
        Next
        txtAdj.Text = String.Join(",", Obj.Adjectives.ToArray)
        txtSyn.Text = String.Join(",", Obj.Synonyms.ToArray)
        txtText.Text = Obj.Text

        txtIsIn.Text = Obj.IsIn
        txtDescFcn.Text = Obj.DESCFCN
        txtFDesc.Text = Obj.FDesc
        'txtGlobal.Text = Obj.Globals
        lbObjects.DataSource = Obj.Objects
        txtLoc.Text = Obj.Location

        'txtSize.Text = Obj.Size
        'txtTValue.Text = Obj.TValue
        'txtCapacity.Text = Obj.Capacity
        'txtStrength.Text = Obj.Strength
        'txtVType.Text = Obj.VType
        'txtValue.Text = Obj.Value


        For Each key As String In Obj.Props.Keys
            Dim arr(2) As String
            arr(0) = key
            arr(1) = Obj.Props(key)
            dgvProps.Rows.Add(arr)
        Next

        Dim lst As List(Of clsObject) = Game.GetObjectsInRoom(Obj.Name)
        For Each Obj As clsObject In lst
            lbObjectsHere.Items.Add(Obj.Name)

        Next

        If Game.ObjRefDic.ContainsKey(Obj.Name) Then
            Dim f As New frmRefs(Game.ObjRefDic(Obj.Name), Obj.Name)
            f.FormBorderStyle = FormBorderStyle.None
            f.Dock = DockStyle.Fill
            f.TopLevel = False
            pnlObjRefs.Controls.Add(f)
            f.Show()
        End If

    End Sub

    Private Sub lblAction_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblAction.LinkClicked
        Dim Key As String = txtAction.Text

        Dim R As clsRoutine = Game.GetRoutine(Key)

        If R IsNot Nothing Then
            Using f As New frmRoutine(R)
                f.ShowDialog()
            End Using
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


    Private Sub lblDescFcn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblDescFcn.LinkClicked
        Dim Key As String = txtDescFcn.Text

        Dim R As clsRoutine = Game.GetRoutine(Key)

        If R IsNot Nothing Then
            Using f As New frmRoutine(R)
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

    Private Sub lblText_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblText.LinkClicked
        Using f As New frmOriginalText(Me.Obj.OrigText)
            f.ShowDialog()
        End Using
    End Sub



    Private Sub dgvProps_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvProps.MouseDoubleClick
        If dgvProps.SelectedRows.Count = 0 Then Exit Sub

        Dim key As String = dgvProps.SelectedRows(0).Cells(1).Value.ToString
        If key.StartsWith("TO ") Then
            Dim Room As String = GetSecondWord(key)
            RaiseEvent NewObject(Room)
        ElseIf key.StartsWith("PER ") Then
            Dim action As String = key.Substring(4).Trim
            Dim A As clsRoutine = Game.GetRoutine(action)
            Using f As New frmRoutine(A)
                f.ShowDialog()
            End Using
        Else
            MsgBox(key)
        End If


    End Sub

    Private Sub lblLoc_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblLoc.LinkClicked

        Try
            HandleNav(txtLoc.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub lblIN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblIN.LinkClicked
        Try

            HandleNav(txtIsIn.Text)
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
End Class