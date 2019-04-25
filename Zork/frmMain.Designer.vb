<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lbRooms = New System.Windows.Forms.ListBox()
        Me.lbObjects = New System.Windows.Forms.ListBox()
        Me.pnlRoom = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpRooms = New System.Windows.Forms.TabPage()
        Me.tpObjects = New System.Windows.Forms.TabPage()
        Me.pnlObjects = New System.Windows.Forms.Panel()
        Me.tpRoutines = New System.Windows.Forms.TabPage()
        Me.pnlRoutine = New System.Windows.Forms.Panel()
        Me.lbRoutines = New System.Windows.Forms.ListBox()
        Me.tpGlobals = New System.Windows.Forms.TabPage()
        Me.pnlGlobals = New System.Windows.Forms.Panel()
        Me.lbGlobals = New System.Windows.Forms.ListBox()
        Me.tpSyntax = New System.Windows.Forms.TabPage()
        Me.dgvSyns = New System.Windows.Forms.DataGridView()
        Me.pnlSyntax = New System.Windows.Forms.Panel()
        Me.dgvSyntax = New System.Windows.Forms.DataGridView()
        Me.colValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVerb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpFlags = New System.Windows.Forms.TabPage()
        Me.btnFlagFind = New System.Windows.Forms.Button()
        Me.txtFlagFilter = New System.Windows.Forms.TextBox()
        Me.pnlFlag = New System.Windows.Forms.Panel()
        Me.lbFlags = New System.Windows.Forms.ListBox()
        Me.tpMacros = New System.Windows.Forms.TabPage()
        Me.pnlMacro = New System.Windows.Forms.Panel()
        Me.lbMacro = New System.Windows.Forms.ListBox()
        Me.tpFindText = New System.Windows.Forms.TabPage()
        Me.tpParseLog = New System.Windows.Forms.TabPage()
        Me.lbLog = New System.Windows.Forms.ListBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNavBack = New System.Windows.Forms.ToolStripButton()
        Me.btnNavForward = New System.Windows.Forms.ToolStripButton()
        Me.fndRoom = New Zork.ucFind()
        Me.fndObject = New Zork.ucFind()
        Me.fndRoutine = New Zork.ucFind()
        Me.fndGlobals = New Zork.ucFind()
        Me.fndMacro = New Zork.ucFind()
        Me.TabControl1.SuspendLayout()
        Me.tpRooms.SuspendLayout()
        Me.tpObjects.SuspendLayout()
        Me.tpRoutines.SuspendLayout()
        Me.tpGlobals.SuspendLayout()
        Me.tpSyntax.SuspendLayout()
        CType(Me.dgvSyns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSyntax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpFlags.SuspendLayout()
        Me.tpMacros.SuspendLayout()
        Me.tpParseLog.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbRooms
        '
        Me.lbRooms.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbRooms.FormattingEnabled = True
        Me.lbRooms.Location = New System.Drawing.Point(6, 32)
        Me.lbRooms.Name = "lbRooms"
        Me.lbRooms.Size = New System.Drawing.Size(195, 563)
        Me.lbRooms.TabIndex = 0
        '
        'lbObjects
        '
        Me.lbObjects.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbObjects.FormattingEnabled = True
        Me.lbObjects.Location = New System.Drawing.Point(6, 31)
        Me.lbObjects.Name = "lbObjects"
        Me.lbObjects.Size = New System.Drawing.Size(194, 563)
        Me.lbObjects.TabIndex = 3
        '
        'pnlRoom
        '
        Me.pnlRoom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlRoom.Location = New System.Drawing.Point(207, 19)
        Me.pnlRoom.Name = "pnlRoom"
        Me.pnlRoom.Size = New System.Drawing.Size(692, 587)
        Me.pnlRoom.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tpRooms)
        Me.TabControl1.Controls.Add(Me.tpObjects)
        Me.TabControl1.Controls.Add(Me.tpRoutines)
        Me.TabControl1.Controls.Add(Me.tpGlobals)
        Me.TabControl1.Controls.Add(Me.tpSyntax)
        Me.TabControl1.Controls.Add(Me.tpFlags)
        Me.TabControl1.Controls.Add(Me.tpMacros)
        Me.TabControl1.Controls.Add(Me.tpFindText)
        Me.TabControl1.Controls.Add(Me.tpParseLog)
        Me.TabControl1.Location = New System.Drawing.Point(12, 33)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1304, 636)
        Me.TabControl1.TabIndex = 6
        '
        'tpRooms
        '
        Me.tpRooms.Controls.Add(Me.fndRoom)
        Me.tpRooms.Controls.Add(Me.pnlRoom)
        Me.tpRooms.Controls.Add(Me.lbRooms)
        Me.tpRooms.Location = New System.Drawing.Point(4, 22)
        Me.tpRooms.Name = "tpRooms"
        Me.tpRooms.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRooms.Size = New System.Drawing.Size(1296, 610)
        Me.tpRooms.TabIndex = 0
        Me.tpRooms.Text = "Rooms"
        Me.tpRooms.UseVisualStyleBackColor = True
        '
        'tpObjects
        '
        Me.tpObjects.Controls.Add(Me.fndObject)
        Me.tpObjects.Controls.Add(Me.pnlObjects)
        Me.tpObjects.Controls.Add(Me.lbObjects)
        Me.tpObjects.Location = New System.Drawing.Point(4, 22)
        Me.tpObjects.Name = "tpObjects"
        Me.tpObjects.Padding = New System.Windows.Forms.Padding(3)
        Me.tpObjects.Size = New System.Drawing.Size(1296, 610)
        Me.tpObjects.TabIndex = 1
        Me.tpObjects.Text = "Objects"
        Me.tpObjects.UseVisualStyleBackColor = True
        '
        'pnlObjects
        '
        Me.pnlObjects.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlObjects.Location = New System.Drawing.Point(206, 19)
        Me.pnlObjects.Name = "pnlObjects"
        Me.pnlObjects.Size = New System.Drawing.Size(1084, 588)
        Me.pnlObjects.TabIndex = 6
        '
        'tpRoutines
        '
        Me.tpRoutines.Controls.Add(Me.fndRoutine)
        Me.tpRoutines.Controls.Add(Me.pnlRoutine)
        Me.tpRoutines.Controls.Add(Me.lbRoutines)
        Me.tpRoutines.Location = New System.Drawing.Point(4, 22)
        Me.tpRoutines.Name = "tpRoutines"
        Me.tpRoutines.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRoutines.Size = New System.Drawing.Size(1296, 610)
        Me.tpRoutines.TabIndex = 3
        Me.tpRoutines.Text = "Routines"
        Me.tpRoutines.UseVisualStyleBackColor = True
        '
        'pnlRoutine
        '
        Me.pnlRoutine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlRoutine.Location = New System.Drawing.Point(195, 19)
        Me.pnlRoutine.Name = "pnlRoutine"
        Me.pnlRoutine.Size = New System.Drawing.Size(1027, 588)
        Me.pnlRoutine.TabIndex = 8
        '
        'lbRoutines
        '
        Me.lbRoutines.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbRoutines.FormattingEnabled = True
        Me.lbRoutines.Location = New System.Drawing.Point(6, 32)
        Me.lbRoutines.Name = "lbRoutines"
        Me.lbRoutines.Size = New System.Drawing.Size(183, 563)
        Me.lbRoutines.TabIndex = 6
        '
        'tpGlobals
        '
        Me.tpGlobals.Controls.Add(Me.fndGlobals)
        Me.tpGlobals.Controls.Add(Me.pnlGlobals)
        Me.tpGlobals.Controls.Add(Me.lbGlobals)
        Me.tpGlobals.Location = New System.Drawing.Point(4, 22)
        Me.tpGlobals.Name = "tpGlobals"
        Me.tpGlobals.Size = New System.Drawing.Size(1296, 610)
        Me.tpGlobals.TabIndex = 4
        Me.tpGlobals.Text = "Globals/Constants"
        Me.tpGlobals.UseVisualStyleBackColor = True
        '
        'pnlGlobals
        '
        Me.pnlGlobals.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlGlobals.Location = New System.Drawing.Point(195, 19)
        Me.pnlGlobals.Name = "pnlGlobals"
        Me.pnlGlobals.Size = New System.Drawing.Size(522, 587)
        Me.pnlGlobals.TabIndex = 8
        '
        'lbGlobals
        '
        Me.lbGlobals.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbGlobals.FormattingEnabled = True
        Me.lbGlobals.Location = New System.Drawing.Point(6, 32)
        Me.lbGlobals.Name = "lbGlobals"
        Me.lbGlobals.Size = New System.Drawing.Size(183, 563)
        Me.lbGlobals.TabIndex = 6
        '
        'tpSyntax
        '
        Me.tpSyntax.Controls.Add(Me.dgvSyns)
        Me.tpSyntax.Controls.Add(Me.pnlSyntax)
        Me.tpSyntax.Controls.Add(Me.dgvSyntax)
        Me.tpSyntax.Location = New System.Drawing.Point(4, 22)
        Me.tpSyntax.Name = "tpSyntax"
        Me.tpSyntax.Size = New System.Drawing.Size(1296, 610)
        Me.tpSyntax.TabIndex = 5
        Me.tpSyntax.Text = "Syntax"
        Me.tpSyntax.UseVisualStyleBackColor = True
        '
        'dgvSyns
        '
        Me.dgvSyns.AllowUserToAddRows = False
        Me.dgvSyns.AllowUserToDeleteRows = False
        Me.dgvSyns.AllowUserToResizeRows = False
        Me.dgvSyns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSyns.Location = New System.Drawing.Point(703, 319)
        Me.dgvSyns.MultiSelect = False
        Me.dgvSyns.Name = "dgvSyns"
        Me.dgvSyns.ReadOnly = True
        Me.dgvSyns.RowHeadersVisible = False
        Me.dgvSyns.Size = New System.Drawing.Size(590, 188)
        Me.dgvSyns.TabIndex = 23
        '
        'pnlSyntax
        '
        Me.pnlSyntax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlSyntax.Location = New System.Drawing.Point(703, 22)
        Me.pnlSyntax.Name = "pnlSyntax"
        Me.pnlSyntax.Size = New System.Drawing.Size(590, 380)
        Me.pnlSyntax.TabIndex = 22
        '
        'dgvSyntax
        '
        Me.dgvSyntax.AllowUserToAddRows = False
        Me.dgvSyntax.AllowUserToDeleteRows = False
        Me.dgvSyntax.AllowUserToResizeRows = False
        Me.dgvSyntax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvSyntax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSyntax.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colValue, Me.colVerb})
        Me.dgvSyntax.Location = New System.Drawing.Point(18, 16)
        Me.dgvSyntax.MultiSelect = False
        Me.dgvSyntax.Name = "dgvSyntax"
        Me.dgvSyntax.ReadOnly = True
        Me.dgvSyntax.RowHeadersVisible = False
        Me.dgvSyntax.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSyntax.Size = New System.Drawing.Size(679, 591)
        Me.dgvSyntax.TabIndex = 21
        '
        'colValue
        '
        Me.colValue.HeaderText = "Value"
        Me.colValue.Name = "colValue"
        Me.colValue.ReadOnly = True
        Me.colValue.Width = 550
        '
        'colVerb
        '
        Me.colVerb.HeaderText = "Verb"
        Me.colVerb.Name = "colVerb"
        Me.colVerb.ReadOnly = True
        Me.colVerb.Width = 120
        '
        'tpFlags
        '
        Me.tpFlags.Controls.Add(Me.btnFlagFind)
        Me.tpFlags.Controls.Add(Me.txtFlagFilter)
        Me.tpFlags.Controls.Add(Me.pnlFlag)
        Me.tpFlags.Controls.Add(Me.lbFlags)
        Me.tpFlags.Location = New System.Drawing.Point(4, 22)
        Me.tpFlags.Name = "tpFlags"
        Me.tpFlags.Size = New System.Drawing.Size(1296, 610)
        Me.tpFlags.TabIndex = 6
        Me.tpFlags.Text = "Flags"
        Me.tpFlags.UseVisualStyleBackColor = True
        '
        'btnFlagFind
        '
        Me.btnFlagFind.BackgroundImage = CType(resources.GetObject("btnFlagFind.BackgroundImage"), System.Drawing.Image)
        Me.btnFlagFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFlagFind.Location = New System.Drawing.Point(150, 5)
        Me.btnFlagFind.Name = "btnFlagFind"
        Me.btnFlagFind.Size = New System.Drawing.Size(22, 22)
        Me.btnFlagFind.TabIndex = 14
        Me.btnFlagFind.UseVisualStyleBackColor = True
        '
        'txtFlagFilter
        '
        Me.txtFlagFilter.Location = New System.Drawing.Point(7, 7)
        Me.txtFlagFilter.Name = "txtFlagFilter"
        Me.txtFlagFilter.Size = New System.Drawing.Size(140, 20)
        Me.txtFlagFilter.TabIndex = 13
        '
        'pnlFlag
        '
        Me.pnlFlag.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlFlag.Location = New System.Drawing.Point(204, 20)
        Me.pnlFlag.Name = "pnlFlag"
        Me.pnlFlag.Size = New System.Drawing.Size(692, 587)
        Me.pnlFlag.TabIndex = 12
        '
        'lbFlags
        '
        Me.lbFlags.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbFlags.FormattingEnabled = True
        Me.lbFlags.Location = New System.Drawing.Point(3, 33)
        Me.lbFlags.Name = "lbFlags"
        Me.lbFlags.Size = New System.Drawing.Size(195, 563)
        Me.lbFlags.TabIndex = 11
        '
        'tpMacros
        '
        Me.tpMacros.Controls.Add(Me.fndMacro)
        Me.tpMacros.Controls.Add(Me.pnlMacro)
        Me.tpMacros.Controls.Add(Me.lbMacro)
        Me.tpMacros.Location = New System.Drawing.Point(4, 22)
        Me.tpMacros.Name = "tpMacros"
        Me.tpMacros.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMacros.Size = New System.Drawing.Size(1296, 610)
        Me.tpMacros.TabIndex = 7
        Me.tpMacros.Text = "Macros"
        Me.tpMacros.UseVisualStyleBackColor = True
        '
        'pnlMacro
        '
        Me.pnlMacro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlMacro.Location = New System.Drawing.Point(193, 19)
        Me.pnlMacro.Name = "pnlMacro"
        Me.pnlMacro.Size = New System.Drawing.Size(1025, 588)
        Me.pnlMacro.TabIndex = 14
        '
        'lbMacro
        '
        Me.lbMacro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbMacro.FormattingEnabled = True
        Me.lbMacro.Location = New System.Drawing.Point(2, 32)
        Me.lbMacro.Name = "lbMacro"
        Me.lbMacro.Size = New System.Drawing.Size(185, 563)
        Me.lbMacro.TabIndex = 13
        '
        'tpFindText
        '
        Me.tpFindText.Location = New System.Drawing.Point(4, 22)
        Me.tpFindText.Name = "tpFindText"
        Me.tpFindText.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFindText.Size = New System.Drawing.Size(1296, 610)
        Me.tpFindText.TabIndex = 8
        Me.tpFindText.Text = "Find Text"
        Me.tpFindText.UseVisualStyleBackColor = True
        '
        'tpParseLog
        '
        Me.tpParseLog.Controls.Add(Me.lbLog)
        Me.tpParseLog.Location = New System.Drawing.Point(4, 22)
        Me.tpParseLog.Name = "tpParseLog"
        Me.tpParseLog.Padding = New System.Windows.Forms.Padding(3)
        Me.tpParseLog.Size = New System.Drawing.Size(1296, 610)
        Me.tpParseLog.TabIndex = 2
        Me.tpParseLog.Text = "Parse Log"
        Me.tpParseLog.UseVisualStyleBackColor = True
        '
        'lbLog
        '
        Me.lbLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbLog.FormattingEnabled = True
        Me.lbLog.Location = New System.Drawing.Point(6, 15)
        Me.lbLog.Name = "lbLog"
        Me.lbLog.Size = New System.Drawing.Size(1255, 550)
        Me.lbLog.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNavBack, Me.btnNavForward})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1328, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNavBack
        '
        Me.btnNavBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNavBack.Image = CType(resources.GetObject("btnNavBack.Image"), System.Drawing.Image)
        Me.btnNavBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNavBack.Name = "btnNavBack"
        Me.btnNavBack.Size = New System.Drawing.Size(23, 22)
        Me.btnNavBack.Text = "Nav Back"
        '
        'btnNavForward
        '
        Me.btnNavForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNavForward.Image = CType(resources.GetObject("btnNavForward.Image"), System.Drawing.Image)
        Me.btnNavForward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNavForward.Name = "btnNavForward"
        Me.btnNavForward.Size = New System.Drawing.Size(23, 22)
        Me.btnNavForward.Text = "Nav Forward"
        '
        'fndRoom
        '
        Me.fndRoom.Location = New System.Drawing.Point(2, 2)
        Me.fndRoom.Name = "fndRoom"
        Me.fndRoom.Size = New System.Drawing.Size(194, 27)
        Me.fndRoom.TabIndex = 12
        '
        'fndObject
        '
        Me.fndObject.Location = New System.Drawing.Point(2, 2)
        Me.fndObject.Name = "fndObject"
        Me.fndObject.Size = New System.Drawing.Size(194, 27)
        Me.fndObject.TabIndex = 13
        '
        'fndRoutine
        '
        Me.fndRoutine.Location = New System.Drawing.Point(2, 2)
        Me.fndRoutine.Name = "fndRoutine"
        Me.fndRoutine.Size = New System.Drawing.Size(194, 27)
        Me.fndRoutine.TabIndex = 14
        '
        'fndGlobals
        '
        Me.fndGlobals.Location = New System.Drawing.Point(2, 2)
        Me.fndGlobals.Name = "fndGlobals"
        Me.fndGlobals.Size = New System.Drawing.Size(194, 27)
        Me.fndGlobals.TabIndex = 15
        '
        'fndMacro
        '
        Me.fndMacro.Location = New System.Drawing.Point(2, 2)
        Me.fndMacro.Name = "fndMacro"
        Me.fndMacro.Size = New System.Drawing.Size(194, 27)
        Me.fndMacro.TabIndex = 15
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1328, 670)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.tpRooms.ResumeLayout(False)
        Me.tpObjects.ResumeLayout(False)
        Me.tpRoutines.ResumeLayout(False)
        Me.tpGlobals.ResumeLayout(False)
        Me.tpSyntax.ResumeLayout(False)
        CType(Me.dgvSyns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSyntax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpFlags.ResumeLayout(False)
        Me.tpFlags.PerformLayout()
        Me.tpMacros.ResumeLayout(False)
        Me.tpParseLog.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbRooms As ListBox
    Friend WithEvents lbObjects As ListBox
    Friend WithEvents pnlRoom As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpRooms As TabPage
    Friend WithEvents tpObjects As TabPage
    Friend WithEvents pnlObjects As Panel
    Friend WithEvents tpParseLog As TabPage
    Friend WithEvents tpRoutines As TabPage
    Friend WithEvents pnlRoutine As Panel
    Friend WithEvents lbRoutines As ListBox
    Friend WithEvents tpGlobals As TabPage
    Friend WithEvents pnlGlobals As Panel
    Friend WithEvents lbGlobals As ListBox
    Friend WithEvents tpSyntax As TabPage
    Friend WithEvents dgvSyntax As DataGridView
    Friend WithEvents colValue As DataGridViewTextBoxColumn
    Friend WithEvents colVerb As DataGridViewTextBoxColumn
    Friend WithEvents pnlSyntax As Panel
    Friend WithEvents dgvSyns As DataGridView
    Friend WithEvents tpFlags As TabPage
    Friend WithEvents btnFlagFind As Button
    Friend WithEvents txtFlagFilter As TextBox
    Friend WithEvents pnlFlag As Panel
    Friend WithEvents lbFlags As ListBox
    Friend WithEvents tpMacros As TabPage
    Friend WithEvents pnlMacro As Panel
    Friend WithEvents lbMacro As ListBox
    Friend WithEvents tpFindText As TabPage
    Friend WithEvents lbLog As ListBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnNavBack As ToolStripButton
    Friend WithEvents btnNavForward As ToolStripButton
    Friend WithEvents fndRoom As ucFind
    Friend WithEvents fndObject As ucFind
    Friend WithEvents fndRoutine As ucFind
    Friend WithEvents fndMacro As ucFind
    Friend WithEvents fndGlobals As ucFind
End Class
