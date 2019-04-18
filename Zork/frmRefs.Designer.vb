<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRefs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbRooms = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbObjects = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbRoutines = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbRooms
        '
        Me.lbRooms.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbRooms.FormattingEnabled = True
        Me.lbRooms.Location = New System.Drawing.Point(142, 47)
        Me.lbRooms.Name = "lbRooms"
        Me.lbRooms.Size = New System.Drawing.Size(115, 381)
        Me.lbRooms.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(142, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Rooms"
        '
        'lbObjects
        '
        Me.lbObjects.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbObjects.FormattingEnabled = True
        Me.lbObjects.Location = New System.Drawing.Point(21, 47)
        Me.lbObjects.Name = "lbObjects"
        Me.lbObjects.Size = New System.Drawing.Size(115, 381)
        Me.lbObjects.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Objects"
        '
        'lbRoutines
        '
        Me.lbRoutines.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbRoutines.FormattingEnabled = True
        Me.lbRoutines.Location = New System.Drawing.Point(263, 47)
        Me.lbRoutines.Name = "lbRoutines"
        Me.lbRoutines.Size = New System.Drawing.Size(115, 381)
        Me.lbRoutines.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(263, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Routines (Actions)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(188, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "This thing is referred to by these things"
        '
        'frmRefs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(394, 450)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbRoutines)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbRooms)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbObjects)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmRefs"
        Me.Text = "frmFlags"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbRooms As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbObjects As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lbRoutines As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
End Class
