<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoom
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtLDesc = New System.Windows.Forms.TextBox()
        Me.txtAction = New System.Windows.Forms.TextBox()
        Me.lblAction = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvDirections = New System.Windows.Forms.DataGridView()
        Me.colDir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbObjects = New System.Windows.Forms.ListBox()
        Me.lbObjectsHere = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbFlags = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.LinkLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbPseudos = New System.Windows.Forms.ListBox()
        Me.txtParent = New System.Windows.Forms.TextBox()
        Me.lblIN = New System.Windows.Forms.LinkLabel()
        Me.btnLDesc = New System.Windows.Forms.LinkLabel()
        CType(Me.dgvDirections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Desc"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(52, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 2
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(204, 3)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(100, 20)
        Me.txtDesc.TabIndex = 3
        '
        'txtLDesc
        '
        Me.txtLDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLDesc.Location = New System.Drawing.Point(52, 29)
        Me.txtLDesc.Multiline = True
        Me.txtLDesc.Name = "txtLDesc"
        Me.txtLDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLDesc.Size = New System.Drawing.Size(628, 84)
        Me.txtLDesc.TabIndex = 5
        '
        'txtAction
        '
        Me.txtAction.Location = New System.Drawing.Point(52, 117)
        Me.txtAction.Name = "txtAction"
        Me.txtAction.Size = New System.Drawing.Size(173, 20)
        Me.txtAction.TabIndex = 9
        '
        'lblAction
        '
        Me.lblAction.AutoSize = True
        Me.lblAction.Location = New System.Drawing.Point(7, 120)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(37, 13)
        Me.lblAction.TabIndex = 8
        Me.lblAction.TabStop = True
        Me.lblAction.Text = "Action"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(450, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Global (Objects)"
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(291, 117)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(100, 20)
        Me.txtValue.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(246, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Value"
        '
        'dgvDirections
        '
        Me.dgvDirections.AllowUserToAddRows = False
        Me.dgvDirections.AllowUserToDeleteRows = False
        Me.dgvDirections.AllowUserToResizeRows = False
        Me.dgvDirections.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDirections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDirections.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDir, Me.colValue})
        Me.dgvDirections.Location = New System.Drawing.Point(10, 149)
        Me.dgvDirections.MultiSelect = False
        Me.dgvDirections.Name = "dgvDirections"
        Me.dgvDirections.ReadOnly = True
        Me.dgvDirections.RowHeadersVisible = False
        Me.dgvDirections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDirections.Size = New System.Drawing.Size(434, 284)
        Me.dgvDirections.TabIndex = 20
        '
        'colDir
        '
        Me.colDir.HeaderText = "Dir"
        Me.colDir.Name = "colDir"
        Me.colDir.ReadOnly = True
        Me.colDir.Width = 60
        '
        'colValue
        '
        Me.colValue.HeaderText = "Value"
        Me.colValue.Name = "colValue"
        Me.colValue.ReadOnly = True
        Me.colValue.Width = 350
        '
        'lbObjects
        '
        Me.lbObjects.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbObjects.FormattingEnabled = True
        Me.lbObjects.Location = New System.Drawing.Point(450, 178)
        Me.lbObjects.Name = "lbObjects"
        Me.lbObjects.Size = New System.Drawing.Size(115, 121)
        Me.lbObjects.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.lbObjects, "Objects listed in this room.")
        '
        'lbObjectsHere
        '
        Me.lbObjectsHere.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbObjectsHere.FormattingEnabled = True
        Me.lbObjectsHere.Location = New System.Drawing.Point(571, 178)
        Me.lbObjectsHere.Name = "lbObjectsHere"
        Me.lbObjectsHere.Size = New System.Drawing.Size(115, 121)
        Me.lbObjectsHere.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.lbObjectsHere, "Objects that have this room as their IN or LOC.")
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(571, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Objects Here (IN,Loc)"
        '
        'lbFlags
        '
        Me.lbFlags.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbFlags.FormattingEnabled = True
        Me.lbFlags.Location = New System.Drawing.Point(453, 313)
        Me.lbFlags.Name = "lbFlags"
        Me.lbFlags.Size = New System.Drawing.Size(115, 121)
        Me.lbFlags.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(450, 299)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Flags"
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(558, 6)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(28, 13)
        Me.lblText.TabIndex = 27
        Me.lblText.TabStop = True
        Me.lblText.Text = "Text"
        Me.ToolTip1.SetToolTip(Me.lblText, "Parsed text of this Room.")
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(571, 299)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Pseudo-Objects"
        '
        'lbPseudos
        '
        Me.lbPseudos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbPseudos.FormattingEnabled = True
        Me.lbPseudos.Location = New System.Drawing.Point(574, 313)
        Me.lbPseudos.Name = "lbPseudos"
        Me.lbPseudos.Size = New System.Drawing.Size(110, 121)
        Me.lbPseudos.TabIndex = 55
        '
        'txtParent
        '
        Me.txtParent.Location = New System.Drawing.Point(402, 3)
        Me.txtParent.Name = "txtParent"
        Me.txtParent.Size = New System.Drawing.Size(121, 20)
        Me.txtParent.TabIndex = 58
        '
        'lblIN
        '
        Me.lblIN.AutoSize = True
        Me.lblIN.Location = New System.Drawing.Point(317, 6)
        Me.lblIN.Name = "lblIN"
        Me.lblIN.Size = New System.Drawing.Size(77, 13)
        Me.lblIN.TabIndex = 57
        Me.lblIN.TabStop = True
        Me.lblIN.Text = "Parent (In,Loc)"
        '
        'btnLDesc
        '
        Me.btnLDesc.AutoSize = True
        Me.btnLDesc.Location = New System.Drawing.Point(9, 32)
        Me.btnLDesc.Name = "btnLDesc"
        Me.btnLDesc.Size = New System.Drawing.Size(38, 13)
        Me.btnLDesc.TabIndex = 59
        Me.btnLDesc.TabStop = True
        Me.btnLDesc.Text = "LDesc"
        '
        'frmRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 497)
        Me.Controls.Add(Me.btnLDesc)
        Me.Controls.Add(Me.txtParent)
        Me.Controls.Add(Me.lblIN)
        Me.Controls.Add(Me.lbPseudos)
        Me.Controls.Add(Me.lbObjectsHere)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.lbFlags)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbObjects)
        Me.Controls.Add(Me.dgvDirections)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAction)
        Me.Controls.Add(Me.lblAction)
        Me.Controls.Add(Me.txtLDesc)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRoom"
        Me.Text = "Room"
        CType(Me.dgvDirections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtLDesc As TextBox
    Friend WithEvents txtAction As TextBox
    Friend WithEvents lblAction As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents txtValue As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvDirections As DataGridView
    Friend WithEvents colDir As DataGridViewTextBoxColumn
    Friend WithEvents colValue As DataGridViewTextBoxColumn
    Friend WithEvents lbObjects As ListBox
    Friend WithEvents lbObjectsHere As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbFlags As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblText As LinkLabel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label11 As Label
    Friend WithEvents lbPseudos As ListBox
    Friend WithEvents txtParent As TextBox
    Friend WithEvents lblIN As LinkLabel
    Friend WithEvents btnLDesc As LinkLabel
End Class
