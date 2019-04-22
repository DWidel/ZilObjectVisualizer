Public Class frmRefs

    'This was intended to show where a routine was referenced by looking in known places
    'that contain routines in objects and rooms, then just a text search in routines.


    Private Refs As List(Of String)


    Public Sub New(lst As List(Of String), Name As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Refs = lst
        Me.Text = Name
    End Sub
    Private Sub frmFlags_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        For Each ref As String In Refs
            If ref.StartsWith("O-") Then
                lbObjects.Items.Add(ref.Substring(2))

            ElseIf ref.StartsWith("R-") Then
                lbRooms.Items.Add(ref.Substring(2))

            ElseIf ref.StartsWith("A-") Then
                lbRoutines.Items.Add(ref.Substring(2))

            End If

        Next


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


    Private Sub lbRooms_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lbRooms.MouseDoubleClick
        If lbRooms.SelectedItem Is Nothing Then Exit Sub

        Dim key As String = lbRooms.SelectedItem

        Dim R As clsRoom = Game.GetRoom(key)

        If R IsNot Nothing Then
            Using f As New frmRoom(R)
                f.ShowDialog()
            End Using
        End If

    End Sub


    Private Sub lbRoutines_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lbRoutines.MouseDoubleClick
        If lbRoutines.SelectedItem Is Nothing Then Exit Sub

        Dim key As String = lbRoutines.SelectedItem

        Dim R As clsRoutine = Game.GetRoutine(key)

        If R IsNot Nothing Then
            Using f As New frmNameValue(R)
                f.ShowDialog()
            End Using
        End If

    End Sub
End Class