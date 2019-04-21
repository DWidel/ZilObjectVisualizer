<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucFind
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucFind))
        Me.chkMatchCase = New System.Windows.Forms.CheckBox()
        Me.btnFindFilter = New System.Windows.Forms.Button()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'chkMatchCase
        '
        Me.chkMatchCase.AutoSize = True
        Me.chkMatchCase.Location = New System.Drawing.Point(174, 6)
        Me.chkMatchCase.Name = "chkMatchCase"
        Me.chkMatchCase.Size = New System.Drawing.Size(15, 14)
        Me.chkMatchCase.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.chkMatchCase, "Match Case")
        Me.chkMatchCase.UseVisualStyleBackColor = True
        '
        'btnFindFilter
        '
        Me.btnFindFilter.BackgroundImage = CType(resources.GetObject("btnFindFilter.BackgroundImage"), System.Drawing.Image)
        Me.btnFindFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFindFilter.Location = New System.Drawing.Point(146, 1)
        Me.btnFindFilter.Name = "btnFindFilter"
        Me.btnFindFilter.Size = New System.Drawing.Size(22, 22)
        Me.btnFindFilter.TabIndex = 12
        Me.btnFindFilter.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(3, 3)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(140, 20)
        Me.txtFilter.TabIndex = 11
        '
        'ucFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnFindFilter)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.chkMatchCase)
        Me.Name = "ucFind"
        Me.Size = New System.Drawing.Size(194, 27)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkMatchCase As CheckBox
    Friend WithEvents btnFindFilter As Button
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
