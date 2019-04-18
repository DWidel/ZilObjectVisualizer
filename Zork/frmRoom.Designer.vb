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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtLDesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAction = New System.Windows.Forms.TextBox()
        Me.lblAction = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIsIn = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.dgvPseudos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblText = New System.Windows.Forms.LinkLabel()
        CType(Me.dgvDirections, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPseudos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtLDesc.Size = New System.Drawing.Size(628, 62)
        Me.txtLDesc.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "LDesc"
        '
        'txtAction
        '
        Me.txtAction.Location = New System.Drawing.Point(52, 97)
        Me.txtAction.Name = "txtAction"
        Me.txtAction.Size = New System.Drawing.Size(173, 20)
        Me.txtAction.TabIndex = 9
        '
        'lblAction
        '
        Me.lblAction.AutoSize = True
        Me.lblAction.Location = New System.Drawing.Point(7, 100)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(37, 13)
        Me.lblAction.TabIndex = 8
        Me.lblAction.TabStop = True
        Me.lblAction.Text = "Action"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(450, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Global (Objects)"
        '
        'txtIsIn
        '
        Me.txtIsIn.Location = New System.Drawing.Point(344, 3)
        Me.txtIsIn.Name = "txtIsIn"
        Me.txtIsIn.Size = New System.Drawing.Size(100, 20)
        Me.txtIsIn.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(320, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "IN"
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(291, 97)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(100, 20)
        Me.txtValue.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(246, 100)
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
        Me.dgvDirections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDirections.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDir, Me.colValue})
        Me.dgvDirections.Location = New System.Drawing.Point(10, 121)
        Me.dgvDirections.MultiSelect = False
        Me.dgvDirections.Name = "dgvDirections"
        Me.dgvDirections.ReadOnly = True
        Me.dgvDirections.RowHeadersVisible = False
        Me.dgvDirections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDirections.Size = New System.Drawing.Size(434, 266)
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
        Me.lbObjects.FormattingEnabled = True
        Me.lbObjects.Location = New System.Drawing.Point(450, 158)
        Me.lbObjects.Name = "lbObjects"
        Me.lbObjects.Size = New System.Drawing.Size(115, 121)
        Me.lbObjects.TabIndex = 21
        '
        'lbObjectsHere
        '
        Me.lbObjectsHere.FormattingEnabled = True
        Me.lbObjectsHere.Location = New System.Drawing.Point(571, 158)
        Me.lbObjectsHere.Name = "lbObjectsHere"
        Me.lbObjectsHere.Size = New System.Drawing.Size(115, 121)
        Me.lbObjectsHere.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(571, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Objects Here (IN)"
        '
        'lbFlags
        '
        Me.lbFlags.FormattingEnabled = True
        Me.lbFlags.Location = New System.Drawing.Point(453, 293)
        Me.lbFlags.Name = "lbFlags"
        Me.lbFlags.Size = New System.Drawing.Size(115, 121)
        Me.lbFlags.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(450, 279)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Flags"
        '
        'dgvPseudos
        '
        Me.dgvPseudos.AllowUserToAddRows = False
        Me.dgvPseudos.AllowUserToDeleteRows = False
        Me.dgvPseudos.AllowUserToResizeRows = False
        Me.dgvPseudos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPseudos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgvPseudos.Location = New System.Drawing.Point(10, 393)
        Me.dgvPseudos.MultiSelect = False
        Me.dgvPseudos.Name = "dgvPseudos"
        Me.dgvPseudos.ReadOnly = True
        Me.dgvPseudos.RowHeadersVisible = False
        Me.dgvPseudos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPseudos.Size = New System.Drawing.Size(215, 103)
        Me.dgvPseudos.TabIndex = 26
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Pseudo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Action"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
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
        '
        'frmRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 497)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.dgvPseudos)
        Me.Controls.Add(Me.lbFlags)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbObjectsHere)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbObjects)
        Me.Controls.Add(Me.dgvDirections)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtIsIn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAction)
        Me.Controls.Add(Me.lblAction)
        Me.Controls.Add(Me.txtLDesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRoom"
        Me.Text = "Room"
        CType(Me.dgvDirections, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPseudos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtLDesc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAction As TextBox
    Friend WithEvents lblAction As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIsIn As TextBox
    Friend WithEvents Label8 As Label
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
    Friend WithEvents dgvPseudos As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents lblText As LinkLabel
End Class
