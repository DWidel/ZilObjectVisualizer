Public Class ucFind

    Private LB As ListBox
    Private OType As ObjTypes

    Public Sub Init(lb As ListBox, oType As ObjTypes)
        Me.LB = lb
        Me.OType = oType

    End Sub



    Private Function GetProperThingList() As List(Of clsBase)
        Dim lst As New List(Of clsBase)
        Select Case Me.OType
            Case ObjTypes.Room
                lst = Game.Rooms.Cast(Of clsBase).ToList
            Case ObjTypes.Object
                lst = Game.Objects.Cast(Of clsBase).ToList
            Case ObjTypes.Routine
                lst = Game.Routines.Cast(Of clsBase).ToList
            Case ObjTypes.Macro
                lst = Game.Macros.Cast(Of clsBase).ToList
            Case ObjTypes.Global
                lst = Game.Globals.Cast(Of clsBase).ToList
        End Select
        Return lst

    End Function

    Private Sub btnFindFilter_Click(sender As Object, e As EventArgs) Handles btnFindFilter.Click
        Try
            Dim key As String = txtFilter.Text
            If txtFilter.Text = "" Then Exit Sub

            Dim idx As Integer = 0


            Dim lst As List(Of clsBase) = GetProperThingList()


            idx = LB.SelectedIndex
            For i As Integer = idx + 1 To lst.Count - 1
                Dim Contains As Boolean
                If chkMatchCase.Checked Then
                    Contains = lst(i).ToString.IndexOf(key, StringComparison.Ordinal) >= 0
                Else
                    Contains = lst(i).ToString.IndexOf(key, StringComparison.OrdinalIgnoreCase) >= 0
                End If

                If Contains Then
                    LB.SelectedIndex = i
                    Exit Sub
                End If
            Next

            For i As Integer = 0 To idx - 1
                Dim Contains As Boolean
                If chkMatchCase.Checked Then
                    Contains = lst(i).ToString.IndexOf(key, StringComparison.Ordinal) >= 0
                Else
                    Contains = lst(i).ToString.IndexOf(key, StringComparison.OrdinalIgnoreCase) >= 0
                End If
                If Contains Then
                    LB.SelectedIndex = i
                    Exit Sub
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            e.SuppressKeyPress = True
            btnFindFilter.PerformClick()
        End If
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged

    End Sub
End Class
