<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fMain))
        Me.lblTimeShow = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelevantSkillsAndEquipmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblSelShipName = New System.Windows.Forms.Label()
        Me.lblCycleTime = New System.Windows.Forms.Label()
        Me.lblTotMineTime = New System.Windows.Forms.Label()
        Me.lblSelShipNameDisp = New System.Windows.Forms.Label()
        Me.lblHarvCycleTimeDisp = New System.Windows.Forms.Label()
        Me.lblTimeToMineDisp = New System.Windows.Forms.Label()
        Me.prgrBar01 = New System.Windows.Forms.ProgressBar()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTimeShow
        '
        Me.lblTimeShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTimeShow.Font = New System.Drawing.Font("Segoe UI Symbol", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeShow.Location = New System.Drawing.Point(81, 44)
        Me.lblTimeShow.Name = "lblTimeShow"
        Me.lblTimeShow.Size = New System.Drawing.Size(215, 95)
        Me.lblTimeShow.TabIndex = 0
        Me.lblTimeShow.Text = "--:--:--"
        Me.lblTimeShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(383, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EndToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "F&ile"
        '
        'EndToolStripMenuItem
        '
        Me.EndToolStripMenuItem.Name = "EndToolStripMenuItem"
        Me.EndToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EndToolStripMenuItem.Text = "En&d"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelevantSkillsAndEquipmentToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'RelevantSkillsAndEquipmentToolStripMenuItem
        '
        Me.RelevantSkillsAndEquipmentToolStripMenuItem.Name = "RelevantSkillsAndEquipmentToolStripMenuItem"
        Me.RelevantSkillsAndEquipmentToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.RelevantSkillsAndEquipmentToolStripMenuItem.Text = "&Relevant skills and equipment"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(13, 369)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(112, 45)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(131, 369)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(112, 45)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(249, 369)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(112, 45)
        Me.btnStop.TabIndex = 4
        Me.btnStop.Text = "STOP"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblSelShipName
        '
        Me.lblSelShipName.AutoSize = True
        Me.lblSelShipName.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelShipName.Location = New System.Drawing.Point(10, 204)
        Me.lblSelShipName.Name = "lblSelShipName"
        Me.lblSelShipName.Size = New System.Drawing.Size(103, 17)
        Me.lblSelShipName.TabIndex = 5
        Me.lblSelShipName.Text = "Selected Ship:"
        '
        'lblCycleTime
        '
        Me.lblCycleTime.AutoSize = True
        Me.lblCycleTime.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCycleTime.Location = New System.Drawing.Point(10, 230)
        Me.lblCycleTime.Name = "lblCycleTime"
        Me.lblCycleTime.Size = New System.Drawing.Size(165, 17)
        Me.lblCycleTime.TabIndex = 6
        Me.lblCycleTime.Text = "Harvester's Cycle Time:"
        '
        'lblTotMineTime
        '
        Me.lblTotMineTime.AutoSize = True
        Me.lblTotMineTime.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotMineTime.Location = New System.Drawing.Point(10, 258)
        Me.lblTotMineTime.Name = "lblTotMineTime"
        Me.lblTotMineTime.Size = New System.Drawing.Size(134, 17)
        Me.lblTotMineTime.TabIndex = 7
        Me.lblTotMineTime.Text = "Total Mining Time:"
        '
        'lblSelShipNameDisp
        '
        Me.lblSelShipNameDisp.AutoSize = True
        Me.lblSelShipNameDisp.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelShipNameDisp.Location = New System.Drawing.Point(180, 204)
        Me.lblSelShipNameDisp.Name = "lblSelShipNameDisp"
        Me.lblSelShipNameDisp.Size = New System.Drawing.Size(0, 17)
        Me.lblSelShipNameDisp.TabIndex = 8
        '
        'lblHarvCycleTimeDisp
        '
        Me.lblHarvCycleTimeDisp.AutoSize = True
        Me.lblHarvCycleTimeDisp.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHarvCycleTimeDisp.Location = New System.Drawing.Point(180, 228)
        Me.lblHarvCycleTimeDisp.Name = "lblHarvCycleTimeDisp"
        Me.lblHarvCycleTimeDisp.Size = New System.Drawing.Size(0, 17)
        Me.lblHarvCycleTimeDisp.TabIndex = 9
        '
        'lblTimeToMineDisp
        '
        Me.lblTimeToMineDisp.AutoSize = True
        Me.lblTimeToMineDisp.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeToMineDisp.Location = New System.Drawing.Point(180, 256)
        Me.lblTimeToMineDisp.Name = "lblTimeToMineDisp"
        Me.lblTimeToMineDisp.Size = New System.Drawing.Size(0, 17)
        Me.lblTimeToMineDisp.TabIndex = 10
        '
        'prgrBar01
        '
        Me.prgrBar01.Location = New System.Drawing.Point(81, 142)
        Me.prgrBar01.Name = "prgrBar01"
        Me.prgrBar01.Size = New System.Drawing.Size(214, 23)
        Me.prgrBar01.TabIndex = 11
        Me.prgrBar01.Visible = False
        '
        'fMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(383, 423)
        Me.Controls.Add(Me.prgrBar01)
        Me.Controls.Add(Me.lblTimeToMineDisp)
        Me.Controls.Add(Me.lblHarvCycleTimeDisp)
        Me.Controls.Add(Me.lblSelShipNameDisp)
        Me.Controls.Add(Me.lblTotMineTime)
        Me.Controls.Add(Me.lblCycleTime)
        Me.Controls.Add(Me.lblSelShipName)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblTimeShow)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "fMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ice Timer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTimeShow As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EndToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelevantSkillsAndEquipmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblSelShipName As System.Windows.Forms.Label
    Friend WithEvents lblCycleTime As System.Windows.Forms.Label
    Friend WithEvents lblTotMineTime As System.Windows.Forms.Label
    Friend WithEvents lblSelShipNameDisp As System.Windows.Forms.Label
    Friend WithEvents lblHarvCycleTimeDisp As System.Windows.Forms.Label
    Friend WithEvents lblTimeToMineDisp As System.Windows.Forms.Label
    Friend WithEvents prgrBar01 As System.Windows.Forms.ProgressBar

End Class
