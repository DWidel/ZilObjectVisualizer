Public Class frmGlobal


    Private Glob As clsGlobal


    Public Sub New(G As clsGlobal)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Glob = G

    End Sub

    Private Sub frmRoutine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = Glob.Name
        txtValue.Text = FixLineEndings(Glob.Value)

    End Sub
End Class