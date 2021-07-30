<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TeranexSchedulerForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeranexSchedulerForm))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Version: 1.3")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PROTOCOL PREAMBLE:", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Model name: Teranex 2D")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("TERANEX DEVICE:", New System.Windows.Forms.TreeNode() {TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CC enabled: OFF")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node11")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ANCILLARY DATA:", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("AudioOut0: hello")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node13")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node4", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node14")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node15")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node5", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12})
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Teranex", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode4, TreeNode7, TreeNode10, TreeNode13})
        Me.btnSend = New System.Windows.Forms.Button()
        Me.tbLog = New System.Windows.Forms.TextBox()
        Me.tbIpAddress = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripDateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabelOnline = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabelDevice = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnAddRecording = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerPing = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelHelpText = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbValue = New System.Windows.Forms.TextBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.groupbox1 = New System.Windows.Forms.GroupBox()
        Me.LabelWarning = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ScheduleEventClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.groupbox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ScheduleEventClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSend
        '
        Me.btnSend.Enabled = False
        Me.btnSend.Location = New System.Drawing.Point(308, 425)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 0
        Me.btnSend.Text = "Update"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'tbLog
        '
        Me.tbLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbLog.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLog.Location = New System.Drawing.Point(6, 19)
        Me.tbLog.Multiline = True
        Me.tbLog.Name = "tbLog"
        Me.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbLog.Size = New System.Drawing.Size(652, 116)
        Me.tbLog.TabIndex = 1
        '
        'tbIpAddress
        '
        Me.tbIpAddress.Location = New System.Drawing.Point(12, 19)
        Me.tbIpAddress.Name = "tbIpAddress"
        Me.tbIpAddress.Size = New System.Drawing.Size(155, 20)
        Me.tbIpAddress.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.tbIpAddress, "Enter IP address configured in Teranex")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDateTime, Me.StatusLabelOnline, Me.StatusLabelDevice, Me.ToolStripSplitButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 537)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1092, 24)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripDateTime
        '
        Me.ToolStripDateTime.Name = "ToolStripDateTime"
        Me.ToolStripDateTime.Size = New System.Drawing.Size(57, 19)
        Me.ToolStripDateTime.Text = "date time"
        '
        'StatusLabelOnline
        '
        Me.StatusLabelOnline.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.StatusLabelOnline.Name = "StatusLabelOnline"
        Me.StatusLabelOnline.Size = New System.Drawing.Size(90, 19)
        Me.StatusLabelOnline.Text = "Not connected"
        '
        'StatusLabelDevice
        '
        Me.StatusLabelDevice.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.StatusLabelDevice.Name = "StatusLabelDevice"
        Me.StatusLabelDevice.Size = New System.Drawing.Size(16, 19)
        Me.StatusLabelDevice.Text = "-"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(56, 19)
        Me.ToolStripSplitButton1.Text = "About ..."
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CheckBox1)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.btnDisconnect)
        Me.GroupBox4.Controls.Add(Me.tbIpAddress)
        Me.GroupBox4.Controls.Add(Me.btnConnect)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(664, 56)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Device"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(479, 21)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(58, 17)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Debug"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(335, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Check"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(254, 17)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.btnDisconnect.TabIndex = 29
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(173, 17)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 28
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnAddRecording
        '
        Me.btnAddRecording.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddRecording.Enabled = False
        Me.btnAddRecording.Location = New System.Drawing.Point(583, 276)
        Me.btnAddRecording.Name = "btnAddRecording"
        Me.btnAddRecording.Size = New System.Drawing.Size(75, 23)
        Me.btnAddRecording.TabIndex = 28
        Me.btnAddRecording.Text = "Add"
        Me.btnAddRecording.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(652, 248)
        Me.DataGridView1.TabIndex = 29
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.RemoveToolStripMenuItem, Me.RemoveAllToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(133, 70)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'RemoveAllToolStripMenuItem
        '
        Me.RemoveAllToolStripMenuItem.Name = "RemoveAllToolStripMenuItem"
        Me.RemoveAllToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.RemoveAllToolStripMenuItem.Text = "Remove all"
        '
        'TimerPing
        '
        Me.TimerPing.Interval = 60000
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.LabelHelpText)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.tbValue)
        Me.GroupBox2.Controls.Add(Me.TreeView1)
        Me.GroupBox2.Controls.Add(Me.btnSend)
        Me.GroupBox2.Location = New System.Drawing.Point(687, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(389, 514)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Device Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Select a parameter to edit"
        '
        'LabelHelpText
        '
        Me.LabelHelpText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelHelpText.Location = New System.Drawing.Point(6, 451)
        Me.LabelHelpText.Name = "LabelHelpText"
        Me.LabelHelpText.Size = New System.Drawing.Size(377, 57)
        Me.LabelHelpText.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 411)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "New value"
        '
        'tbValue
        '
        Me.tbValue.Enabled = False
        Me.tbValue.Location = New System.Drawing.Point(6, 427)
        Me.tbValue.Name = "tbValue"
        Me.tbValue.Size = New System.Drawing.Size(293, 20)
        Me.tbValue.TabIndex = 12
        '
        'TreeView1
        '
        Me.TreeView1.HideSelection = False
        Me.TreeView1.Location = New System.Drawing.Point(6, 37)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node6"
        TreeNode1.Text = "Version: 1.3"
        TreeNode2.Name = "Node1"
        TreeNode2.Text = "PROTOCOL PREAMBLE:"
        TreeNode3.Name = "Node8"
        TreeNode3.Text = "Model name: Teranex 2D"
        TreeNode4.Name = "Node2"
        TreeNode4.Text = "TERANEX DEVICE:"
        TreeNode5.Name = "Node10"
        TreeNode5.Text = "CC enabled: OFF"
        TreeNode6.Name = "Node11"
        TreeNode6.Text = "Node11"
        TreeNode7.Name = "Node3"
        TreeNode7.Text = "ANCILLARY DATA:"
        TreeNode8.Name = "Node12"
        TreeNode8.Text = "AudioOut0: hello"
        TreeNode9.Name = "Node13"
        TreeNode9.Text = "Node13"
        TreeNode10.Name = "Node4"
        TreeNode10.Text = "Node4"
        TreeNode11.Name = "Node14"
        TreeNode11.Text = "Node14"
        TreeNode12.Name = "Node15"
        TreeNode12.Text = "Node15"
        TreeNode13.Name = "Node5"
        TreeNode13.Text = "Node5"
        TreeNode14.Name = "Node0"
        TreeNode14.Text = "Teranex"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode14})
        Me.TreeView1.Size = New System.Drawing.Size(377, 371)
        Me.TreeView1.TabIndex = 10
        '
        'groupbox1
        '
        Me.groupbox1.Controls.Add(Me.LabelWarning)
        Me.groupbox1.Controls.Add(Me.btnSave)
        Me.groupbox1.Controls.Add(Me.btnLoad)
        Me.groupbox1.Controls.Add(Me.DataGridView1)
        Me.groupbox1.Controls.Add(Me.btnAddRecording)
        Me.groupbox1.Location = New System.Drawing.Point(12, 74)
        Me.groupbox1.Name = "groupbox1"
        Me.groupbox1.Size = New System.Drawing.Size(664, 305)
        Me.groupbox1.TabIndex = 34
        Me.groupbox1.TabStop = False
        Me.groupbox1.Text = "Schedule"
        '
        'LabelWarning
        '
        Me.LabelWarning.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelWarning.AutoSize = True
        Me.LabelWarning.Location = New System.Drawing.Point(168, 281)
        Me.LabelWarning.Name = "LabelWarning"
        Me.LabelWarning.Size = New System.Drawing.Size(282, 13)
        Me.LabelWarning.TabIndex = 36
        Me.LabelWarning.Text = "Warning - Events will only run while Teranex is connected!"
        Me.LabelWarning.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(87, 276)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 35
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLoad.Location = New System.Drawing.Point(6, 276)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 34
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbLog)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 385)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(664, 141)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Log"
        '
        'ScheduleEventClassBindingSource
        '
        Me.ScheduleEventClassBindingSource.DataSource = GetType(TeranexScheduler.ScheduleEventClass)
        '
        'TeranexSchedulerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 561)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.groupbox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1108, 613)
        Me.Name = "TeranexSchedulerForm"
        Me.Text = "Teranex Scheduler"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.groupbox1.ResumeLayout(False)
        Me.groupbox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ScheduleEventClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents tbLog As System.Windows.Forms.TextBox
    Friend WithEvents tbIpAddress As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripDateTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents btnAddRecording As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LineDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimerPing As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents groupbox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents StatusLabelDevice As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelWarning As System.Windows.Forms.Label
    Friend WithEvents StatusLabelOnline As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Label1 As Label
    Friend WithEvents tbValue As TextBox
    Friend WithEvents LabelHelpText As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStripSplitButton1 As ToolStripStatusLabel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ScheduleEventClassBindingSource As BindingSource
    Friend WithEvents SummaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
