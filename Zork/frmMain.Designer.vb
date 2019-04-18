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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnFindFilter = New System.Windows.Forms.Button()
        Me.txtRoomFilter = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnFindObject = New System.Windows.Forms.Button()
        Me.txtObjectFilter = New System.Windows.Forms.TextBox()
        Me.pnlObjects = New System.Windows.Forms.Panel()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnRoutineFind = New System.Windows.Forms.Button()
        Me.txtRoutineFilter = New System.Windows.Forms.TextBox()
        Me.pnlRoutine = New System.Windows.Forms.Panel()
        Me.lbRoutines = New System.Windows.Forms.ListBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlGlobals = New System.Windows.Forms.Panel()
        Me.lbGlobals = New System.Windows.Forms.ListBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.dgvSyns = New System.Windows.Forms.DataGridView()
        Me.pnlSyntax = New System.Windows.Forms.Panel()
        Me.dgvSyntax = New System.Windows.Forms.DataGridView()
        Me.colValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVerb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.btnFlagFind = New System.Windows.Forms.Button()
        Me.txtFlagFilter = New System.Windows.Forms.TextBox()
        Me.pnlFlag = New System.Windows.Forms.Panel()
        Me.lbFlags = New System.Windows.Forms.ListBox()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.btnMacroFind = New System.Windows.Forms.Button()
        Me.txtMacroFilter = New System.Windows.Forms.TextBox()
        Me.pnlMacro = New System.Windows.Forms.Panel()
        Me.lbMacro = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.tpFindText = New System.Windows.Forms.TabPage()
        Me.lbLog = New System.Windows.Forms.ListBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.dgvSyns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSyntax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbRooms
        '
        Me.lbRooms.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbRooms.FormattingEnabled = True
        Me.lbRooms.Location = New System.Drawing.Point(6, 32)
        Me.lbRooms.Name = "lbRooms"
        Me.lbRooms.Size = New System.Drawing.Size(195, 485)
        Me.lbRooms.TabIndex = 0
        '
        'lbObjects
        '
        Me.lbObjects.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbObjects.FormattingEnabled = True
        Me.lbObjects.Location = New System.Drawing.Point(6, 31)
        Me.lbObjects.Name = "lbObjects"
        Me.lbObjects.Size = New System.Drawing.Size(169, 485)
        Me.lbObjects.TabIndex = 3
        '
        'pnlRoom
        '
        Me.pnlRoom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlRoom.Location = New System.Drawing.Point(207, 19)
        Me.pnlRoom.Name = "pnlRoom"
        Me.pnlRoom.Size = New System.Drawing.Size(692, 498)
        Me.pnlRoom.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.tpFindText)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1304, 547)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnFindFilter)
        Me.TabPage1.Controls.Add(Me.txtRoomFilter)
        Me.TabPage1.Controls.Add(Me.pnlRoom)
        Me.TabPage1.Controls.Add(Me.lbRooms)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1296, 521)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Rooms"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnFindFilter
        '
        Me.btnFindFilter.BackgroundImage = CType(resources.GetObject("btnFindFilter.BackgroundImage"), System.Drawing.Image)
        Me.btnFindFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFindFilter.Location = New System.Drawing.Point(153, 4)
        Me.btnFindFilter.Name = "btnFindFilter"
        Me.btnFindFilter.Size = New System.Drawing.Size(22, 22)
        Me.btnFindFilter.TabIndex = 10
        Me.btnFindFilter.UseVisualStyleBackColor = True
        '
        'txtRoomFilter
        '
        Me.txtRoomFilter.Location = New System.Drawing.Point(10, 6)
        Me.txtRoomFilter.Name = "txtRoomFilter"
        Me.txtRoomFilter.Size = New System.Drawing.Size(140, 20)
        Me.txtRoomFilter.TabIndex = 9
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnFindObject)
        Me.TabPage2.Controls.Add(Me.txtObjectFilter)
        Me.TabPage2.Controls.Add(Me.pnlObjects)
        Me.TabPage2.Controls.Add(Me.lbObjects)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1296, 521)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Objects"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnFindObject
        '
        Me.btnFindObject.BackgroundImage = CType(resources.GetObject("btnFindObject.BackgroundImage"), System.Drawing.Image)
        Me.btnFindObject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFindObject.Location = New System.Drawing.Point(149, 4)
        Me.btnFindObject.Name = "btnFindObject"
        Me.btnFindObject.Size = New System.Drawing.Size(22, 22)
        Me.btnFindObject.TabIndex = 8
        Me.btnFindObject.UseVisualStyleBackColor = True
        '
        'txtObjectFilter
        '
        Me.txtObjectFilter.Location = New System.Drawing.Point(6, 6)
        Me.txtObjectFilter.Name = "txtObjectFilter"
        Me.txtObjectFilter.Size = New System.Drawing.Size(140, 20)
        Me.txtObjectFilter.TabIndex = 7
        '
        'pnlObjects
        '
        Me.pnlObjects.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlObjects.Location = New System.Drawing.Point(181, 19)
        Me.pnlObjects.Name = "pnlObjects"
        Me.pnlObjects.Size = New System.Drawing.Size(1109, 499)
        Me.pnlObjects.TabIndex = 6
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnRoutineFind)
        Me.TabPage4.Controls.Add(Me.txtRoutineFilter)
        Me.TabPage4.Controls.Add(Me.pnlRoutine)
        Me.TabPage4.Controls.Add(Me.lbRoutines)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1296, 521)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Routines"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnRoutineFind
        '
        Me.btnRoutineFind.BackgroundImage = CType(resources.GetObject("btnRoutineFind.BackgroundImage"), System.Drawing.Image)
        Me.btnRoutineFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRoutineFind.Location = New System.Drawing.Point(153, 4)
        Me.btnRoutineFind.Name = "btnRoutineFind"
        Me.btnRoutineFind.Size = New System.Drawing.Size(22, 22)
        Me.btnRoutineFind.TabIndex = 12
        Me.btnRoutineFind.UseVisualStyleBackColor = True
        '
        'txtRoutineFilter
        '
        Me.txtRoutineFilter.Location = New System.Drawing.Point(10, 6)
        Me.txtRoutineFilter.Name = "txtRoutineFilter"
        Me.txtRoutineFilter.Size = New System.Drawing.Size(140, 20)
        Me.txtRoutineFilter.TabIndex = 11
        '
        'pnlRoutine
        '
        Me.pnlRoutine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlRoutine.Location = New System.Drawing.Point(172, 19)
        Me.pnlRoutine.Name = "pnlRoutine"
        Me.pnlRoutine.Size = New System.Drawing.Size(1050, 499)
        Me.pnlRoutine.TabIndex = 8
        '
        'lbRoutines
        '
        Me.lbRoutines.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbRoutines.FormattingEnabled = True
        Me.lbRoutines.Location = New System.Drawing.Point(6, 32)
        Me.lbRoutines.Name = "lbRoutines"
        Me.lbRoutines.Size = New System.Drawing.Size(160, 485)
        Me.lbRoutines.TabIndex = 6
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label4)
        Me.TabPage5.Controls.Add(Me.pnlGlobals)
        Me.TabPage5.Controls.Add(Me.lbGlobals)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1296, 521)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Globals"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Globals"
        '
        'pnlGlobals
        '
        Me.pnlGlobals.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlGlobals.Location = New System.Drawing.Point(156, 19)
        Me.pnlGlobals.Name = "pnlGlobals"
        Me.pnlGlobals.Size = New System.Drawing.Size(561, 498)
        Me.pnlGlobals.TabIndex = 8
        '
        'lbGlobals
        '
        Me.lbGlobals.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbGlobals.FormattingEnabled = True
        Me.lbGlobals.Location = New System.Drawing.Point(6, 19)
        Me.lbGlobals.Name = "lbGlobals"
        Me.lbGlobals.Size = New System.Drawing.Size(143, 498)
        Me.lbGlobals.TabIndex = 6
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.dgvSyns)
        Me.TabPage6.Controls.Add(Me.pnlSyntax)
        Me.TabPage6.Controls.Add(Me.dgvSyntax)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1296, 521)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Syntax"
        Me.TabPage6.UseVisualStyleBackColor = True
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
        Me.pnlSyntax.Size = New System.Drawing.Size(590, 291)
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
        Me.dgvSyntax.Size = New System.Drawing.Size(679, 502)
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
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.btnFlagFind)
        Me.TabPage7.Controls.Add(Me.txtFlagFilter)
        Me.TabPage7.Controls.Add(Me.pnlFlag)
        Me.TabPage7.Controls.Add(Me.lbFlags)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(1296, 521)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Flags"
        Me.TabPage7.UseVisualStyleBackColor = True
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
        Me.pnlFlag.Size = New System.Drawing.Size(692, 498)
        Me.pnlFlag.TabIndex = 12
        '
        'lbFlags
        '
        Me.lbFlags.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbFlags.FormattingEnabled = True
        Me.lbFlags.Location = New System.Drawing.Point(3, 33)
        Me.lbFlags.Name = "lbFlags"
        Me.lbFlags.Size = New System.Drawing.Size(195, 485)
        Me.lbFlags.TabIndex = 11
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.btnMacroFind)
        Me.TabPage8.Controls.Add(Me.txtMacroFilter)
        Me.TabPage8.Controls.Add(Me.pnlMacro)
        Me.TabPage8.Controls.Add(Me.lbMacro)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(1296, 521)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "Macros"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'btnMacroFind
        '
        Me.btnMacroFind.BackgroundImage = CType(resources.GetObject("btnMacroFind.BackgroundImage"), System.Drawing.Image)
        Me.btnMacroFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMacroFind.Location = New System.Drawing.Point(149, 4)
        Me.btnMacroFind.Name = "btnMacroFind"
        Me.btnMacroFind.Size = New System.Drawing.Size(22, 22)
        Me.btnMacroFind.TabIndex = 16
        Me.btnMacroFind.UseVisualStyleBackColor = True
        '
        'txtMacroFilter
        '
        Me.txtMacroFilter.Location = New System.Drawing.Point(6, 6)
        Me.txtMacroFilter.Name = "txtMacroFilter"
        Me.txtMacroFilter.Size = New System.Drawing.Size(140, 20)
        Me.txtMacroFilter.TabIndex = 15
        '
        'pnlMacro
        '
        Me.pnlMacro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlMacro.Location = New System.Drawing.Point(168, 19)
        Me.pnlMacro.Name = "pnlMacro"
        Me.pnlMacro.Size = New System.Drawing.Size(1050, 499)
        Me.pnlMacro.TabIndex = 14
        '
        'lbMacro
        '
        Me.lbMacro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbMacro.FormattingEnabled = True
        Me.lbMacro.Location = New System.Drawing.Point(2, 32)
        Me.lbMacro.Name = "lbMacro"
        Me.lbMacro.Size = New System.Drawing.Size(160, 485)
        Me.lbMacro.TabIndex = 13
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lbLog)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1296, 521)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Parse Log"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'tpFindText
        '
        Me.tpFindText.Location = New System.Drawing.Point(4, 22)
        Me.tpFindText.Name = "tpFindText"
        Me.tpFindText.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFindText.Size = New System.Drawing.Size(1296, 521)
        Me.tpFindText.TabIndex = 8
        Me.tpFindText.Text = "Find Text"
        Me.tpFindText.UseVisualStyleBackColor = True
        '
        'lbLog
        '
        Me.lbLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbLog.FormattingEnabled = True
        Me.lbLog.Location = New System.Drawing.Point(6, 15)
        Me.lbLog.Name = "lbLog"
        Me.lbLog.Size = New System.Drawing.Size(1255, 472)
        Me.lbLog.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1328, 583)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.dgvSyns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSyntax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbRooms As ListBox
    Friend WithEvents lbObjects As ListBox
    Friend WithEvents pnlRoom As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents pnlObjects As Panel
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents pnlRoutine As Panel
    Friend WithEvents lbRoutines As ListBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlGlobals As Panel
    Friend WithEvents lbGlobals As ListBox
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents dgvSyntax As DataGridView
    Friend WithEvents colValue As DataGridViewTextBoxColumn
    Friend WithEvents colVerb As DataGridViewTextBoxColumn
    Friend WithEvents pnlSyntax As Panel
    Friend WithEvents dgvSyns As DataGridView
    Friend WithEvents txtObjectFilter As TextBox
    Friend WithEvents btnFindObject As Button
    Friend WithEvents btnFindFilter As Button
    Friend WithEvents txtRoomFilter As TextBox
    Friend WithEvents btnRoutineFind As Button
    Friend WithEvents txtRoutineFilter As TextBox
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents btnFlagFind As Button
    Friend WithEvents txtFlagFilter As TextBox
    Friend WithEvents pnlFlag As Panel
    Friend WithEvents lbFlags As ListBox
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents btnMacroFind As Button
    Friend WithEvents txtMacroFilter As TextBox
    Friend WithEvents pnlMacro As Panel
    Friend WithEvents lbMacro As ListBox
    Friend WithEvents tpFindText As TabPage
    Friend WithEvents lbLog As ListBox
End Class
