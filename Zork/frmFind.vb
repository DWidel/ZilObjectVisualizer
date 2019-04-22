Public Class frmFind
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click

        dgv.Rows.Clear()

        Dim key As String = txtFilter.Text

        For Each R As clsRoom In Game.Rooms
            If R.OrigText.Contains(key) Then
                Dim Arr(3) As Object
                Arr(0) = "Room"
                Arr(1) = R.Name
                Arr(2) = GetSample(key, R.OrigText)
                Arr(3) = R
                dgv.Rows.Add(Arr)

            End If
        Next

        For Each R As clsObject In Game.Objects
            If R.OrigText.Contains(key) Then
                Dim Arr(3) As Object
                Arr(0) = "Object"
                Arr(1) = R.Name
                Arr(2) = GetSample(key, R.OrigText)
                Arr(3) = R
                dgv.Rows.Add(Arr)

            End If
        Next


        For Each R As clsRoutine In Game.Routines
            If R.OrigText.Contains(key) Then
                Dim Arr(3) As Object
                Arr(0) = "Routine"
                Arr(1) = R.Name
                Arr(2) = GetSample(key, R.OrigText)
                Arr(3) = R
                dgv.Rows.Add(Arr)

            End If
        Next

        For Each x As clsGlobal In Game.Globals
            If x.OrigText.Contains(key) Then
                Dim Arr(3) As Object
                If x.Type = clsGlobal.VarType.Constant Then
                    Arr(0) = "Constant"
                Else
                    Arr(0) = "Global"
                End If
                Arr(1) = x.Name
                Arr(2) = GetSample(key, x.OrigText)
                Arr(3) = x
                dgv.Rows.Add(Arr)

            End If
        Next

        For Each x As clsMacro In Game.Macros
            If x.OrigText.Contains(key) Then
                Dim Arr(3) As Object
                Arr(0) = "Macro"
                Arr(1) = x.Name
                Arr(2) = GetSample(key, x.OrigText)
                Arr(3) = x
                dgv.Rows.Add(Arr)

            End If
        Next

        For Each x As clsBase In Game.Syntaxes
            If x.OrigText.Contains(key) Then
                Dim Arr(3) As Object
                Arr(0) = "Syntax"
                Arr(1) = x.Name
                Arr(2) = GetSample(key, x.OrigText)
                Arr(3) = x
                dgv.Rows.Add(Arr)

            End If
        Next

        For Each x As clsBase In Game.Synonyms
            If x.OrigText.Contains(key) Then
                Dim Arr(3) As Object
                Arr(0) = "Synonym"
                Arr(1) = x.Name
                Arr(2) = GetSample(key, x.OrigText)
                Arr(3) = x
                dgv.Rows.Add(Arr)

            End If
        Next



    End Sub

    Private Function GetSample(key, txt)
        Dim i As Integer = txt.indexof(key)
        If i > 0 Then
            Dim Start As Integer = Math.Max(i - 10, 1)
            Return Microsoft.VisualBasic.Mid(txt, Start, key.length + 20)

        End If
        Return ""
    End Function

    Private Sub dgv_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgv.MouseDoubleClick
        Try

            If dgv.SelectedRows.Count = 0 Then Exit Sub

            Dim Thing As clsBase = dgv.SelectedRows(0).Cells(3).Value
            ShowThingDialog(Thing)

            'Dim type As String = dgv.SelectedRows(0).Cells(0).Value.ToString
            '    Dim key As String = dgv.SelectedRows(0).Cells(1).Value
            '    

            'Select Case type
            '    Case "Routine"
            '        Using f As New frmRoutine(obj)
            '            f.ShowDialog()
            '        End Using
            '    Case "Room"
            '        Using f As New frmRoom(obj)
            '            f.ShowDialog()
            '        End Using
            '    Case "Object"
            '        Using f As New frmObject(obj)
            '            f.ShowDialog()
            '        End Using

            '    Case Else
            '        Dim ii As Integer = 0
            'End Select



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            e.SuppressKeyPress = True
            btnFind.PerformClick()
        End If
    End Sub


    Private Sub dgv_SelectionChanged(sender As Object, e As EventArgs) Handles dgv.SelectionChanged
        Try

            If dgv.SelectedRows.Count = 0 Then Exit Sub

            Dim Thing As clsBase = dgv.SelectedRows(0).Cells(3).Value

            ClearPanel(pnl)

            Dim f As Form = GetThingDialog(Thing)
            f.FormBorderStyle = FormBorderStyle.None
            f.Dock = DockStyle.Fill
            f.TopLevel = False
            pnl.Controls.Add(f)
            f.Show()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class