Public Class frmNameValue

    Private Thing As clsNameValue
    Private IsRoutine As Boolean = False
    Private IsGlobal As Boolean = False
    Private IsConstant As Boolean = False


    Public Sub New(thing As clsNameValue)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Thing = thing

    End Sub

    Private Sub frmRoutine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = Thing.Name
        txtValue.Text = FixLineEndings(Thing.Value)

        Select Case Thing.GetType.Name
            Case GetType(clsRoutine).Name
                Me.Text = "Routine"
                lblType.Text = Me.Text
                IsRoutine = True
            Case GetType(clsSyntax).Name
                Me.Text = "Syntax"
                lblType.Text = Me.Text
            Case GetType(clsMacro).Name
                Me.Text = "Macro"
                lblType.Text = Me.Text
            Case GetType(clsGlobal).Name
                Select Case DirectCast(Thing, clsGlobal).Type
                    Case clsGlobal.VarType.Constant
                        Me.Text = "Constant"
                        lblType.Text = Me.Text
                        IsConstant = True
                    Case clsGlobal.VarType.Global
                        Me.Text = "Global"
                        lblType.Text = Me.Text
                        IsGlobal = True
                End Select
        End Select

        If IsRoutine Then
            Dim key As String = Thing.Name

            If key IsNot Nothing AndAlso Game.RoutineRefDic.ContainsKey(key) Then
                Dim f2 As New frmRefs(Game.RoutineRefDic(key), key)
                f2.FormBorderStyle = FormBorderStyle.None
                f2.Dock = DockStyle.Fill
                f2.TopLevel = False
                pnlRoutineRefs.Controls.Add(f2)
                f2.Show()
            End If
        End If

    End Sub

    Private Sub lblText_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblText.LinkClicked
        Try

            Using f As New frmOriginalText(Me.Thing.OrigText)
                f.ShowDialog()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class