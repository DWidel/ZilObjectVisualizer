Public Class frmMacro

    Private Macro As clsMacro


    Public Sub New(R As clsMacro)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Macro = R

    End Sub

    Private Sub frmRoutine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = Macro.Name
        txtValue.Text = FixLineEndings(Macro.Value)


        Dim key As String = Macro.Name


        If Game.RoutineDic.ContainsKey(key) Then
            Dim f2 As New frmRefs(Game.RoutineDic(key), key)
            f2.FormBorderStyle = FormBorderStyle.None
            f2.Dock = DockStyle.Fill
            f2.TopLevel = False
            pnlRoutineRefs.Controls.Add(f2)
            f2.Show()

        End If

    End Sub
End Class