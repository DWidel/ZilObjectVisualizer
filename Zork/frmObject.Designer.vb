<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmObject
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtLDesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAdj = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAction = New System.Windows.Forms.TextBox()
        Me.txtGlobal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIsIn = New System.Windows.Forms.TextBox()
        Me.lblIN = New System.Windows.Forms.LinkLabel()
        Me.txtSyn = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFDesc = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblDescFcn = New System.Windows.Forms.LinkLabel()
        Me.txtDescFcn = New System.Windows.Forms.TextBox()
        Me.lblAction = New System.Windows.Forms.LinkLabel()
        Me.lbFlags = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvProps = New System.Windows.Forms.DataGridView()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbObjectsHere = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.LinkLabel()
        Me.lbObjects = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlObjRefs = New System.Windows.Forms.Panel()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.lblLoc = New System.Windows.Forms.LinkLabel()
        CType(Me.dgvProps, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtLDesc.Location = New System.Drawing.Point(52, 29)
        Me.txtLDesc.Multiline = True
        Me.txtLDesc.Name = "txtLDesc"
        Me.txtLDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLDesc.Size = New System.Drawing.Size(654, 62)
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
        'txtAdj
        '
        Me.txtAdj.Location = New System.Drawing.Point(52, 318)
        Me.txtAdj.Multiline = True
        Me.txtAdj.Name = "txtAdj"
        Me.txtAdj.Size = New System.Drawing.Size(654, 18)
        Me.txtAdj.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-2, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Adjectives"
        '
        'txtAction
        '
        Me.txtAction.Location = New System.Drawing.Point(52, 97)
        Me.txtAction.Name = "txtAction"
        Me.txtAction.Size = New System.Drawing.Size(146, 20)
        Me.txtAction.TabIndex = 9
        '
        'txtGlobal
        '
        Me.txtGlobal.Location = New System.Drawing.Point(52, 444)
        Me.txtGlobal.Name = "txtGlobal"
        Me.txtGlobal.Size = New System.Drawing.Size(220, 20)
        Me.txtGlobal.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 447)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Global"
        '
        'txtIsIn
        '
        Me.txtIsIn.Location = New System.Drawing.Point(344, 3)
        Me.txtIsIn.Name = "txtIsIn"
        Me.txtIsIn.Size = New System.Drawing.Size(121, 20)
        Me.txtIsIn.TabIndex = 15
        '
        'lblIN
        '
        Me.lblIN.AutoSize = True
        Me.lblIN.Location = New System.Drawing.Point(320, 6)
        Me.lblIN.Name = "lblIN"
        Me.lblIN.Size = New System.Drawing.Size(18, 13)
        Me.lblIN.TabIndex = 14
        Me.lblIN.TabStop = True
        Me.lblIN.Text = "IN"
        '
        'txtSyn
        '
        Me.txtSyn.Location = New System.Drawing.Point(52, 294)
        Me.txtSyn.Multiline = True
        Me.txtSyn.Name = "txtSyn"
        Me.txtSyn.Size = New System.Drawing.Size(654, 18)
        Me.txtSyn.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(-2, 294)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Synonyms"
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(52, 341)
        Me.txtText.Multiline = True
        Me.txtText.Name = "txtText"
        Me.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtText.Size = New System.Drawing.Size(654, 72)
        Me.txtText.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 344)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Text"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(118, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Properties"
        '
        'txtFDesc
        '
        Me.txtFDesc.Location = New System.Drawing.Point(52, 419)
        Me.txtFDesc.Name = "txtFDesc"
        Me.txtFDesc.Size = New System.Drawing.Size(654, 20)
        Me.txtFDesc.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 422)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "FDesc"
        '
        'lblDescFcn
        '
        Me.lblDescFcn.AutoSize = True
        Me.lblDescFcn.Location = New System.Drawing.Point(220, 100)
        Me.lblDescFcn.Name = "lblDescFcn"
        Me.lblDescFcn.Size = New System.Drawing.Size(50, 13)
        Me.lblDescFcn.TabIndex = 37
        Me.lblDescFcn.TabStop = True
        Me.lblDescFcn.Text = "DescFcn"
        '
        'txtDescFcn
        '
        Me.txtDescFcn.Location = New System.Drawing.Point(270, 97)
        Me.txtDescFcn.Name = "txtDescFcn"
        Me.txtDescFcn.Size = New System.Drawing.Size(146, 20)
        Me.txtDescFcn.TabIndex = 32
        '
        'lblAction
        '
        Me.lblAction.AutoSize = True
        Me.lblAction.Location = New System.Drawing.Point(7, 100)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(37, 13)
        Me.lblAction.TabIndex = 38
        Me.lblAction.TabStop = True
        Me.lblAction.Text = "Action"
        '
        'lbFlags
        '
        Me.lbFlags.FormattingEnabled = True
        Me.lbFlags.Location = New System.Drawing.Point(367, 131)
        Me.lbFlags.Name = "lbFlags"
        Me.lbFlags.Size = New System.Drawing.Size(110, 160)
        Me.lbFlags.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(364, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Flags"
        '
        'dgvProps
        '
        Me.dgvProps.AllowUserToAddRows = False
        Me.dgvProps.AllowUserToDeleteRows = False
        Me.dgvProps.AllowUserToOrderColumns = True
        Me.dgvProps.AllowUserToResizeRows = False
        Me.dgvProps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProps.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colName, Me.colVal})
        Me.dgvProps.Location = New System.Drawing.Point(10, 131)
        Me.dgvProps.Name = "dgvProps"
        Me.dgvProps.ReadOnly = True
        Me.dgvProps.RowHeadersVisible = False
        Me.dgvProps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProps.Size = New System.Drawing.Size(351, 157)
        Me.dgvProps.TabIndex = 41
        '
        'colName
        '
        Me.colName.HeaderText = "Name"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        '
        'colVal
        '
        Me.colVal.HeaderText = "Value"
        Me.colVal.Name = "colVal"
        Me.colVal.ReadOnly = True
        Me.colVal.Width = 300
        '
        'lbObjectsHere
        '
        Me.lbObjectsHere.FormattingEnabled = True
        Me.lbObjectsHere.Location = New System.Drawing.Point(596, 131)
        Me.lbObjectsHere.Name = "lbObjectsHere"
        Me.lbObjectsHere.Size = New System.Drawing.Size(110, 160)
        Me.lbObjectsHere.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(594, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Objects Here (IN)"
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(678, 3)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(28, 13)
        Me.lblText.TabIndex = 44
        Me.lblText.TabStop = True
        Me.lblText.Text = "Text"
        '
        'lbObjects
        '
        Me.lbObjects.FormattingEnabled = True
        Me.lbObjects.Location = New System.Drawing.Point(481, 131)
        Me.lbObjects.Name = "lbObjects"
        Me.lbObjects.Size = New System.Drawing.Size(110, 160)
        Me.lbObjects.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(482, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "GLOBAL (Objects)"
        '
        'pnlObjRefs
        '
        Me.pnlObjRefs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlObjRefs.Location = New System.Drawing.Point(712, 6)
        Me.pnlObjRefs.Name = "pnlObjRefs"
        Me.pnlObjRefs.Size = New System.Drawing.Size(379, 470)
        Me.pnlObjRefs.TabIndex = 47
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(542, 3)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(130, 20)
        Me.txtLoc.TabIndex = 48
        '
        'lblLoc
        '
        Me.lblLoc.AutoSize = True
        Me.lblLoc.Location = New System.Drawing.Point(511, 6)
        Me.lblLoc.Name = "lblLoc"
        Me.lblLoc.Size = New System.Drawing.Size(25, 13)
        Me.lblLoc.TabIndex = 49
        Me.lblLoc.TabStop = True
        Me.lblLoc.Text = "Loc"
        '
        'frmObject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 483)
        Me.Controls.Add(Me.lblLoc)
        Me.Controls.Add(Me.txtLoc)
        Me.Controls.Add(Me.pnlObjRefs)
        Me.Controls.Add(Me.lbObjects)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.lbObjectsHere)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvProps)
        Me.Controls.Add(Me.txtSyn)
        Me.Controls.Add(Me.txtAdj)
        Me.Controls.Add(Me.lbFlags)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblAction)
        Me.Controls.Add(Me.lblDescFcn)
        Me.Controls.Add(Me.txtDescFcn)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtFDesc)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtIsIn)
        Me.Controls.Add(Me.lblIN)
        Me.Controls.Add(Me.txtGlobal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAction)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLDesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmObject"
        Me.Text = "Object"
        CType(Me.dgvProps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtLDesc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAdj As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAction As TextBox
    Friend WithEvents txtGlobal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIsIn As TextBox
    Friend WithEvents lblIN As LinkLabel
    Friend WithEvents txtSyn As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtText As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtFDesc As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lblDescFcn As LinkLabel
    Friend WithEvents txtDescFcn As TextBox
    Friend WithEvents lblAction As LinkLabel
    Friend WithEvents lbFlags As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvProps As DataGridView
    Friend WithEvents lbObjectsHere As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colVal As DataGridViewTextBoxColumn
    Friend WithEvents lblText As LinkLabel
    Friend WithEvents lbObjects As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents pnlObjRefs As Panel
    Friend WithEvents txtLoc As TextBox
    Friend WithEvents lblLoc As LinkLabel
End Class
