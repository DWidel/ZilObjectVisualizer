Public Class frmRoutine

    Private Routine As clsRoutine


    Public Sub New(R As clsRoutine)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Routine = R

    End Sub

    Private Sub frmRoutine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = Routine.Name
        txtValue.Text = FixLineEndings(Routine.Value)


        Dim key As String = Routine.Name


        If Game.RoutineDic.ContainsKey(key) Then
            Dim f2 As New frmRefs(Game.RoutineDic(key), key)
            f2.FormBorderStyle = FormBorderStyle.None
            f2.Dock = DockStyle.Fill
            f2.TopLevel = False
            pnlRoutineRefs.Controls.Add(f2)
            f2.Show()

        End If

    End Sub

    Private Sub lblText_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblText.LinkClicked
        Using f As New frmOriginalText(Me.Routine.OrigText)
            f.ShowDialog()
        End Using
    End Sub
End Class