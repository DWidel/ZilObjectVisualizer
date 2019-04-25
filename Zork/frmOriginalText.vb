Public Class frmOriginalText

    Public Sub New(txt As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TextBox1.Text = FixLineEndings(txt)
    End Sub

    Private Sub frmOriginalText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.SelectionLength = 0
    End Sub
End Class