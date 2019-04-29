Public Class frmObject

    Public Event JumpTo(x As clsBase)
    Public Event NewObject(Name As String)
    Private Obj As clsObject


    Private PropLinkDictionary As New Dictionary(Of String, List(Of clsBase))



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

        txtParent.Text = Obj.Parent
        txtDescFcn.Text = Obj.DESCFCN
        txtFDesc.Text = Obj.FDesc
        'txtGlobal.Text = Obj.Globals
        lbObjects.DataSource = Obj.Objects


        'txtSize.Text = Obj.Size
        'txtTValue.Text = Obj.TValue
        'txtCapacity.Text = Obj.Capacity
        'txtStrength.Text = Obj.Strength
        'txtVType.Text = Obj.VType
        txtValue.Text = Obj.Value


        For Each key As String In Obj.Props.Keys
            Dim arr(2) As String
            arr(0) = key
            arr(1) = Obj.Props(key)
            dgvProps.Rows.Add(arr)
        Next

        dgvProps.ClearSelection()

        Dim lst As List(Of clsObject) = Game.GetObjectsInRoomOrObject(Obj.Name)
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

        LoadPropLinkDictionary()

    End Sub

    Private Sub LoadPropLinkDictionary()
        For Each PropName As String In Obj.Props.Keys
            Dim things As New List(Of clsBase)

            Dim splitter As New GetTokenList(Obj.Props(PropName))

            For Each word As String In splitter.WordList
                Dim x As clsBase = Game.GetThingByName(word)
                If x IsNot Nothing Then
                    things.Add(x)
                End If
            Next
            PropLinkDictionary.Add(PropName, things)
        Next

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
            Using f As New frmNameValue(R)
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
        Try
            PropertyNavigation()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub PropertyNavigation()


        Dim NavList As New List(Of clsBase)

        Dim PropName As String = dgvProps.SelectedRows(0).Cells(0).Value.ToString
        If Me.PropLinkDictionary.ContainsKey(PropName) Then
            For Each x As clsBase In PropLinkDictionary(PropName)
                NavList.Add(x)
            Next
        End If
        If NavList.Count > 0 Then
            Dim x As clsBase = NavList(0)
            RaiseEvent JumpTo(x)
        End If


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


    Private Sub btnText_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnText.LinkClicked
        ShowFormattedText(txtText.Text, True)
    End Sub

    Private Sub btnFDesc_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnFDesc.LinkClicked

        ShowFormattedText(txtFDesc.Text, True)

    End Sub

    Private Sub btnLDesc_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnLDesc.LinkClicked
        Dim txt As String = txtLDesc.Text
        If txt <> "" Then
            Using f As New frmOriginalText(txt)
                f.Text = "Formatted Text"
                f.ShowDialog()
            End Using
        End If
    End Sub

    Private Sub cmnu_Prop_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmnu_Prop.Opening
        If dgvProps.SelectedRows.Count = 0 Then Exit Sub

        cmnu_Prop.Items.Clear()

        Dim NavList As New List(Of clsBase)

        Dim PropName As String = dgvProps.SelectedRows(0).Cells(0).Value.ToString
        If Me.PropLinkDictionary.ContainsKey(PropName) Then
            For Each x As clsBase In PropLinkDictionary(PropName)
                NavList.Add(x)
            Next
        End If

        If NavList.Count > 0 Then
            For Each x As clsBase In NavList
                Dim c As New ToolStripMenuItem("Open " & x.ThingTypeDesc & ":  " & x.ToString)
                cmnu_Prop.Items.Add(c)
                c.Tag = x
                AddHandler c.Click, AddressOf cmnu_Prop_Clicked
            Next
            For Each x As clsBase In NavList
                Select Case x.ThingType
                    Case ObjTypes.Synonym, ObjTypes.Syntax
                    Case Else
                        Dim c As New ToolStripMenuItem("Go To " & x.ThingTypeDesc & ":  " & x.ToString)
                        cmnu_Prop.Items.Add(c)
                        c.Tag = x
                        AddHandler c.Click, AddressOf cmnu_Prop_Clicked

                End Select
            Next

        End If


        Dim cft As New ToolStripMenuItem("Display Text")
        cft.Tag = Obj.Props(PropName)
        AddHandler cft.Click, AddressOf cmnu_Prop_Clicked
        cmnu_Prop.Items.Add(cft)

    End Sub
    Private Sub cmnu_Prop_Clicked(sender As Object, e As EventArgs)


        If sender.text = "Display Text" Then
            ShowFormattedText(sender.tag, False)
        Else
            Dim x As clsBase = sender.tag

            If sender.text.startswith("O") Then
                Using f As Form = GetThingDialog(x)
                    f.ShowDialog()
                End Using
            Else
                RaiseEvent JumpTo(x)
            End If

        End If


    End Sub
End Class