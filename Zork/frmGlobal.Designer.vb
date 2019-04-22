<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGlobal

    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblConstant = New System.Windows.Forms.Label()
        Me.lblGlobal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtValue
        '
        Me.txtValue.AcceptsReturn = True
        Me.txtValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValue.Location = New System.Drawing.Point(55, 31)
        Me.txtValue.Multiline = True
        Me.txtValue.Name = "txtValue"
        Me.txtValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtValue.Size = New System.Drawing.Size(733, 407)
        Me.txtValue.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Value"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(55, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(192, 20)
        Me.txtName.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name"
        '
        'lblConstant
        '
        Me.lblConstant.AutoSize = True
        Me.lblConstant.Location = New System.Drawing.Point(283, 9)
        Me.lblConstant.Name = "lblConstant"
        Me.lblConstant.Size = New System.Drawing.Size(66, 13)
        Me.lblConstant.TabIndex = 10
        Me.lblConstant.Text = "CONSTANT"
        '
        'lblGlobal
        '
        Me.lblGlobal.AutoSize = True
        Me.lblGlobal.Location = New System.Drawing.Point(364, 9)
        Me.lblGlobal.Name = "lblGlobal"
        Me.lblGlobal.Size = New System.Drawing.Size(49, 13)
        Me.lblGlobal.TabIndex = 11
        Me.lblGlobal.Text = "GLOBAL"
        '
        'frmGlobal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblGlobal)
        Me.Controls.Add(Me.lblConstant)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmGlobal"
        Me.Text = "Globals & Constants"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtValue As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblConstant As Label
    Friend WithEvents lblGlobal As Label
End Class
