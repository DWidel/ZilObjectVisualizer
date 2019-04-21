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
        If dgv.SelectedRows.Count = 0 Then Exit Sub

        Dim type As String = dgv.SelectedRows(0).Cells(0).Value.ToString
        Dim key As String = dgv.SelectedRows(0).Cells(1).Value.ToString
        Dim obj As Object = dgv.SelectedRows(0).Cells(3).Value

        Select Case type
            Case "Routine"
                Using f As New frmRoutine(obj)
                    f.ShowDialog()
                End Using
            Case "Room"
                Using f As New frmRoom(obj)
                    f.ShowDialog()
                End Using
            Case "Object"
                Using f As New frmObject(obj)
                    f.ShowDialog()
                End Using

            Case Else
                Dim ii As Integer = 0
        End Select




    End Sub


    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            e.SuppressKeyPress = True
            btnFind.PerformClick()
        End If
    End Sub
End Class