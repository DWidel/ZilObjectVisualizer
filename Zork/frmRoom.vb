Public Class frmRoom


    Public Event JumpTo(x As clsBase)
    Public Event NewRoom(Name As String)

    Private Room As clsRoom

    Private PropLinkDictionary As New Dictionary(Of String, List(Of clsBase))


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

        txtParent.Text = Room.Parent


        For Each key As String In Room.Props.Keys
            Dim arr(2) As String
            arr(0) = key
            arr(1) = Room.Props(key)
            dgvProps.Rows.Add(arr)
        Next

        dgvProps.ClearSelection()

        'For Each dir As String In Room.Directions.Keys
        '    Dim Arr(2) As String
        '    Arr(0) = dir
        '    Arr(1) = Room.Directions(dir)
        '    dgvDirections.Rows.Add(Arr) 
        'Next


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

        txtAdjective.Text = String.Join(",", Room.Adjectives.ToArray)


        LoadPropLinkDictionary()


    End Sub
    Private Sub LoadPropLinkDictionary()
        For Each PropName As String In Room.Props.Keys
            Dim things As New List(Of clsBase)

            Dim splitter As New GetTokenList(Room.Props(PropName))

            For Each word As String In splitter.WordList
                Dim x As clsBase = Game.GetThingByName(word)
                If x IsNot Nothing Then
                    things.Add(x)
                End If
            Next
            PropLinkDictionary.Add(PropName, things)
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
        Else
            Dim Rm As clsRoom = Game.GetRoom(key)
            If Rm IsNot Nothing Then
                Using f As New frmRoom(Rm)
                    f.ShowDialog()
                End Using
            End If

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

            cmnu_Prop.Items.Add(New ToolStripSeparator)
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
        cft.Tag = Room.Props(PropName)
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


    Private Sub dgvProps_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProps.SelectionChanged

        lblGridPreview.Text = ""

        If dgvProps.SelectedRows Is Nothing OrElse dgvProps.SelectedRows.Count = 0 Then Exit Sub

        Dim NavList As New List(Of clsBase)
        Dim PropName As String = dgvProps.SelectedRows(0).Cells(0).Value.ToString
        If Me.PropLinkDictionary.ContainsKey(PropName) Then
            For Each x As clsBase In PropLinkDictionary(PropName)
                NavList.Add(x)
            Next
        End If
        If NavList.Count > 0 Then
            For Each x As clsBase In NavList
                If x.ThingType = ObjTypes.Global Then
                    Dim G As clsGlobal = x
                    lblGridPreview.Text = G.Name & "=" & G.Value.ToString

                End If
            Next
        End If

    End Sub


End Class