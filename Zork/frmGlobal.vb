Public Class frmGlobal


    Private Glob As clsGlobal

    Private WriteOnly Property Type As clsGlobal.VarType
        Set(value As clsGlobal.VarType)
            Select Case value
                Case clsGlobal.VarType.Global
                    lblConstant.Visible = False
                    lblGlobal.Visible = True
                Case clsGlobal.VarType.Constant
                    lblConstant.Visible = True
                    lblGlobal.Visible = False
            End Select
        End Set
    End Property

    Public Sub New(G As clsGlobal)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Glob = G
        Me.Type = G.Type

    End Sub

    Private Sub frmRoutine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = Glob.Name
        txtValue.Text = FixLineEndings(Glob.Value)

    End Sub
End Class