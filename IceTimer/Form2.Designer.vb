<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fSettings))
        Me.lblSelShip = New System.Windows.Forms.Label()
        Me.cboxSelectShip = New System.Windows.Forms.ComboBox()
        Me.ShipsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtbDataSet = New IceTimer.dtbDataSet()
        Me.lblExhSkillLbl = New System.Windows.Forms.Label()
        Me.cboxExhSkillSelect = New System.Windows.Forms.ComboBox()
        Me.SkillsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NoOfLowSlotsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblSelHarvester = New System.Windows.Forms.Label()
        Me.cboxSelectHarvester = New System.Windows.Forms.ComboBox()
        Me.HarvestersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MiningUpgradesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblSelRigsLbl = New System.Windows.Forms.Label()
        Me.cboxSelectRig = New System.Windows.Forms.ComboBox()
        Me.RigsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblUsedImplLbl = New System.Windows.Forms.Label()
        Me.cboxSelectImplant = New System.Windows.Forms.ComboBox()
        Me.ImplantsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ShipsTableAdapter = New IceTimer.dtbDataSetTableAdapters.ShipsTableAdapter()
        Me.HarvestersTableAdapter = New IceTimer.dtbDataSetTableAdapters.HarvestersTableAdapter()
        Me.SkillsTableAdapter = New IceTimer.dtbDataSetTableAdapters.SkillsTableAdapter()
        Me.RigsTableAdapter = New IceTimer.dtbDataSetTableAdapters.RigsTableAdapter()
        Me.ImplantsTableAdapter = New IceTimer.dtbDataSetTableAdapters.ImplantsTableAdapter()
        Me.NoOfLowSlotsTableAdapter = New IceTimer.dtbDataSetTableAdapters.NoOfLowSlotsTableAdapter()
        Me.lblMinBargeLbl = New System.Windows.Forms.Label()
        Me.cboxMinBargeSkillSelect = New System.Windows.Forms.ComboBox()
        Me.MiningBargeSkillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MiningBargeSkillTableAdapter = New IceTimer.dtbDataSetTableAdapters.MiningBargeSkillTableAdapter()
        Me.MiningUpgradesTableAdapter = New IceTimer.dtbDataSetTableAdapters.MiningUpgradesTableAdapter()
        Me.cboxIceHLevelSel = New System.Windows.Forms.ComboBox()
        Me.IceHarvesterSkillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblIceHSKillSelLbl = New System.Windows.Forms.Label()
        Me.IceHarvesterSkillTableAdapter = New IceTimer.dtbDataSetTableAdapters.IceHarvesterSkillTableAdapter()
        Me.lblSelUsedUpgrLbl = New System.Windows.Forms.Label()
        Me.cboxSelUpgrNo01 = New System.Windows.Forms.ComboBox()
        Me.cboxSelUpgrNo03 = New System.Windows.Forms.ComboBox()
        Me.cboxSelUpgrNo02 = New System.Windows.Forms.ComboBox()
        Me.cboxSelMinUpg01 = New System.Windows.Forms.ComboBox()
        Me.btnPlusUpgr = New System.Windows.Forms.Button()
        Me.cboxSelMinUpg02 = New System.Windows.Forms.ComboBox()
        Me.cboxSelMinUpg03 = New System.Windows.Forms.ComboBox()
        CType(Me.ShipsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkillsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoOfLowSlotsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HarvestersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiningUpgradesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RigsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImplantsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiningBargeSkillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IceHarvesterSkillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelShip
        '
        Me.lblSelShip.AutoSize = True
        Me.lblSelShip.Location = New System.Drawing.Point(15, 13)
        Me.lblSelShip.Name = "lblSelShip"
        Me.lblSelShip.Size = New System.Drawing.Size(105, 17)
        Me.lblSelShip.TabIndex = 0
        Me.lblSelShip.Text = "Select Your Ship:"
        '
        'cboxSelectShip
        '
        Me.cboxSelectShip.DataSource = Me.ShipsBindingSource
        Me.cboxSelectShip.DisplayMember = "ShipName"
        Me.cboxSelectShip.FormattingEnabled = True
        Me.cboxSelectShip.Location = New System.Drawing.Point(165, 13)
        Me.cboxSelectShip.Name = "cboxSelectShip"
        Me.cboxSelectShip.Size = New System.Drawing.Size(135, 25)
        Me.cboxSelectShip.TabIndex = 1
        Me.cboxSelectShip.ValueMember = "ShipName"
        '
        'ShipsBindingSource
        '
        Me.ShipsBindingSource.DataMember = "Ships"
        Me.ShipsBindingSource.DataSource = Me.DtbDataSet
        '
        'DtbDataSet
        '
        Me.DtbDataSet.DataSetName = "dtbDataSet"
        Me.DtbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblExhSkillLbl
        '
        Me.lblExhSkillLbl.AutoSize = True
        Me.lblExhSkillLbl.Location = New System.Drawing.Point(315, 13)
        Me.lblExhSkillLbl.Name = "lblExhSkillLbl"
        Me.lblExhSkillLbl.Size = New System.Drawing.Size(120, 17)
        Me.lblExhSkillLbl.TabIndex = 10
        Me.lblExhSkillLbl.Text = "Exhumer Skill Level:"
        '
        'cboxExhSkillSelect
        '
        Me.cboxExhSkillSelect.DataSource = Me.SkillsBindingSource
        Me.cboxExhSkillSelect.DisplayMember = "SkillName"
        Me.cboxExhSkillSelect.FormattingEnabled = True
        Me.cboxExhSkillSelect.Location = New System.Drawing.Point(473, 13)
        Me.cboxExhSkillSelect.Name = "cboxExhSkillSelect"
        Me.cboxExhSkillSelect.Size = New System.Drawing.Size(101, 25)
        Me.cboxExhSkillSelect.TabIndex = 11
        Me.cboxExhSkillSelect.ValueMember = "SkillLevel"
        '
        'SkillsBindingSource
        '
        Me.SkillsBindingSource.DataMember = "Skills"
        Me.SkillsBindingSource.DataSource = Me.DtbDataSet
        '
        'NoOfLowSlotsBindingSource
        '
        Me.NoOfLowSlotsBindingSource.DataMember = "NoOfLowSlots"
        Me.NoOfLowSlotsBindingSource.DataSource = Me.DtbDataSet
        '
        'lblSelHarvester
        '
        Me.lblSelHarvester.AutoSize = True
        Me.lblSelHarvester.Location = New System.Drawing.Point(15, 48)
        Me.lblSelHarvester.Name = "lblSelHarvester"
        Me.lblSelHarvester.Size = New System.Drawing.Size(125, 17)
        Me.lblSelHarvester.TabIndex = 14
        Me.lblSelHarvester.Text = "Select Ice Harvester:"
        '
        'cboxSelectHarvester
        '
        Me.cboxSelectHarvester.DataSource = Me.HarvestersBindingSource
        Me.cboxSelectHarvester.DisplayMember = "NameOfHarvester"
        Me.cboxSelectHarvester.FormattingEnabled = True
        Me.cboxSelectHarvester.Location = New System.Drawing.Point(165, 53)
        Me.cboxSelectHarvester.Name = "cboxSelectHarvester"
        Me.cboxSelectHarvester.Size = New System.Drawing.Size(135, 25)
        Me.cboxSelectHarvester.TabIndex = 15
        Me.cboxSelectHarvester.ValueMember = "CycleTime"
        '
        'HarvestersBindingSource
        '
        Me.HarvestersBindingSource.DataMember = "Harvesters"
        Me.HarvestersBindingSource.DataSource = Me.DtbDataSet
        '
        'MiningUpgradesBindingSource
        '
        Me.MiningUpgradesBindingSource.DataMember = "MiningUpgrades"
        Me.MiningUpgradesBindingSource.DataSource = Me.DtbDataSet
        '
        'lblSelRigsLbl
        '
        Me.lblSelRigsLbl.AutoSize = True
        Me.lblSelRigsLbl.Location = New System.Drawing.Point(13, 277)
        Me.lblSelRigsLbl.Name = "lblSelRigsLbl"
        Me.lblSelRigsLbl.Size = New System.Drawing.Size(36, 17)
        Me.lblSelRigsLbl.TabIndex = 18
        Me.lblSelRigsLbl.Text = "Rigs:"
        '
        'cboxSelectRig
        '
        Me.cboxSelectRig.DataSource = Me.RigsBindingSource
        Me.cboxSelectRig.DisplayMember = "RigName"
        Me.cboxSelectRig.FormattingEnabled = True
        Me.cboxSelectRig.Location = New System.Drawing.Point(165, 277)
        Me.cboxSelectRig.Name = "cboxSelectRig"
        Me.cboxSelectRig.Size = New System.Drawing.Size(332, 25)
        Me.cboxSelectRig.TabIndex = 19
        Me.cboxSelectRig.ValueMember = "RigBonus"
        '
        'RigsBindingSource
        '
        Me.RigsBindingSource.DataMember = "Rigs"
        Me.RigsBindingSource.DataSource = Me.DtbDataSet
        '
        'lblUsedImplLbl
        '
        Me.lblUsedImplLbl.AutoSize = True
        Me.lblUsedImplLbl.Location = New System.Drawing.Point(13, 328)
        Me.lblUsedImplLbl.Name = "lblUsedImplLbl"
        Me.lblUsedImplLbl.Size = New System.Drawing.Size(60, 17)
        Me.lblUsedImplLbl.TabIndex = 20
        Me.lblUsedImplLbl.Text = "Implants:"
        '
        'cboxSelectImplant
        '
        Me.cboxSelectImplant.DataSource = Me.ImplantsBindingSource
        Me.cboxSelectImplant.DisplayMember = "NameOfImplant"
        Me.cboxSelectImplant.FormattingEnabled = True
        Me.cboxSelectImplant.Location = New System.Drawing.Point(165, 328)
        Me.cboxSelectImplant.Name = "cboxSelectImplant"
        Me.cboxSelectImplant.Size = New System.Drawing.Size(332, 25)
        Me.cboxSelectImplant.TabIndex = 21
        Me.cboxSelectImplant.ValueMember = "ImplantBonus"
        '
        'ImplantsBindingSource
        '
        Me.ImplantsBindingSource.DataMember = "Implants"
        Me.ImplantsBindingSource.DataSource = Me.DtbDataSet
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(160, 387)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(94, 41)
        Me.btnOK.TabIndex = 22
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(281, 387)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(94, 41)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(398, 387)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 41)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ShipsTableAdapter
        '
        Me.ShipsTableAdapter.ClearBeforeFill = True
        '
        'HarvestersTableAdapter
        '
        Me.HarvestersTableAdapter.ClearBeforeFill = True
        '
        'SkillsTableAdapter
        '
        Me.SkillsTableAdapter.ClearBeforeFill = True
        '
        'RigsTableAdapter
        '
        Me.RigsTableAdapter.ClearBeforeFill = True
        '
        'ImplantsTableAdapter
        '
        Me.ImplantsTableAdapter.ClearBeforeFill = True
        '
        'NoOfLowSlotsTableAdapter
        '
        Me.NoOfLowSlotsTableAdapter.ClearBeforeFill = True
        '
        'lblMinBargeLbl
        '
        Me.lblMinBargeLbl.AutoSize = True
        Me.lblMinBargeLbl.Location = New System.Drawing.Point(315, 56)
        Me.lblMinBargeLbl.Name = "lblMinBargeLbl"
        Me.lblMinBargeLbl.Size = New System.Drawing.Size(148, 17)
        Me.lblMinBargeLbl.TabIndex = 29
        Me.lblMinBargeLbl.Text = "Mining Barge Skill Level:"
        '
        'cboxMinBargeSkillSelect
        '
        Me.cboxMinBargeSkillSelect.DataSource = Me.MiningBargeSkillBindingSource
        Me.cboxMinBargeSkillSelect.DisplayMember = "SkillName"
        Me.cboxMinBargeSkillSelect.FormattingEnabled = True
        Me.cboxMinBargeSkillSelect.Location = New System.Drawing.Point(473, 53)
        Me.cboxMinBargeSkillSelect.Name = "cboxMinBargeSkillSelect"
        Me.cboxMinBargeSkillSelect.Size = New System.Drawing.Size(101, 25)
        Me.cboxMinBargeSkillSelect.TabIndex = 30
        Me.cboxMinBargeSkillSelect.ValueMember = "SkillLevel"
        '
        'MiningBargeSkillBindingSource
        '
        Me.MiningBargeSkillBindingSource.DataMember = "MiningBargeSkill"
        Me.MiningBargeSkillBindingSource.DataSource = Me.DtbDataSet
        '
        'MiningBargeSkillTableAdapter
        '
        Me.MiningBargeSkillTableAdapter.ClearBeforeFill = True
        '
        'MiningUpgradesTableAdapter
        '
        Me.MiningUpgradesTableAdapter.ClearBeforeFill = True
        '
        'cboxIceHLevelSel
        '
        Me.cboxIceHLevelSel.DataSource = Me.IceHarvesterSkillBindingSource
        Me.cboxIceHLevelSel.DisplayMember = "SkillName"
        Me.cboxIceHLevelSel.FormattingEnabled = True
        Me.cboxIceHLevelSel.Location = New System.Drawing.Point(474, 87)
        Me.cboxIceHLevelSel.Name = "cboxIceHLevelSel"
        Me.cboxIceHLevelSel.Size = New System.Drawing.Size(100, 25)
        Me.cboxIceHLevelSel.TabIndex = 32
        '
        'IceHarvesterSkillBindingSource
        '
        Me.IceHarvesterSkillBindingSource.DataMember = "IceHarvesterSkill"
        Me.IceHarvesterSkillBindingSource.DataSource = Me.DtbDataSet
        '
        'lblIceHSKillSelLbl
        '
        Me.lblIceHSKillSelLbl.AutoSize = True
        Me.lblIceHSKillSelLbl.Location = New System.Drawing.Point(315, 93)
        Me.lblIceHSKillSelLbl.Name = "lblIceHSKillSelLbl"
        Me.lblIceHSKillSelLbl.Size = New System.Drawing.Size(146, 17)
        Me.lblIceHSKillSelLbl.TabIndex = 33
        Me.lblIceHSKillSelLbl.Text = "Ice Harvester Skill Level:"
        '
        'IceHarvesterSkillTableAdapter
        '
        Me.IceHarvesterSkillTableAdapter.ClearBeforeFill = True
        '
        'lblSelUsedUpgrLbl
        '
        Me.lblSelUsedUpgrLbl.AutoSize = True
        Me.lblSelUsedUpgrLbl.Location = New System.Drawing.Point(15, 135)
        Me.lblSelUsedUpgrLbl.Name = "lblSelUsedUpgrLbl"
        Me.lblSelUsedUpgrLbl.Size = New System.Drawing.Size(141, 17)
        Me.lblSelUsedUpgrLbl.TabIndex = 16
        Me.lblSelUsedUpgrLbl.Text = "Select Used Upgrades:"
        '
        'cboxSelUpgrNo01
        '
        Me.cboxSelUpgrNo01.FormattingEnabled = True
        Me.cboxSelUpgrNo01.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.cboxSelUpgrNo01.Location = New System.Drawing.Point(473, 135)
        Me.cboxSelUpgrNo01.Name = "cboxSelUpgrNo01"
        Me.cboxSelUpgrNo01.Size = New System.Drawing.Size(101, 25)
        Me.cboxSelUpgrNo01.TabIndex = 38
        '
        'cboxSelUpgrNo03
        '
        Me.cboxSelUpgrNo03.FormattingEnabled = True
        Me.cboxSelUpgrNo03.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.cboxSelUpgrNo03.Location = New System.Drawing.Point(473, 231)
        Me.cboxSelUpgrNo03.Name = "cboxSelUpgrNo03"
        Me.cboxSelUpgrNo03.Size = New System.Drawing.Size(101, 25)
        Me.cboxSelUpgrNo03.TabIndex = 39
        Me.cboxSelUpgrNo03.Visible = False
        '
        'cboxSelUpgrNo02
        '
        Me.cboxSelUpgrNo02.FormattingEnabled = True
        Me.cboxSelUpgrNo02.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.cboxSelUpgrNo02.Location = New System.Drawing.Point(473, 177)
        Me.cboxSelUpgrNo02.Name = "cboxSelUpgrNo02"
        Me.cboxSelUpgrNo02.Size = New System.Drawing.Size(101, 25)
        Me.cboxSelUpgrNo02.TabIndex = 40
        Me.cboxSelUpgrNo02.Visible = False
        '
        'cboxSelMinUpg01
        '
        Me.cboxSelMinUpg01.FormattingEnabled = True
        Me.cboxSelMinUpg01.Items.AddRange(New Object() {"", "Anguis Ice Harvester Upgrade", "Crisium Ice Harvester Upgrade", "Frigoris Ice Harvester Upgrade", "Ice Harvester Upgrade I", "Ingenii Ice Harvester Upgrade", "Ice Harvester Upgrade II"})
        Me.cboxSelMinUpg01.Location = New System.Drawing.Point(165, 135)
        Me.cboxSelMinUpg01.Name = "cboxSelMinUpg01"
        Me.cboxSelMinUpg01.Size = New System.Drawing.Size(227, 25)
        Me.cboxSelMinUpg01.TabIndex = 41
        '
        'btnPlusUpgr
        '
        Me.btnPlusUpgr.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnPlusUpgr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPlusUpgr.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnPlusUpgr.ForeColor = System.Drawing.Color.Red
        Me.btnPlusUpgr.Location = New System.Drawing.Point(18, 166)
        Me.btnPlusUpgr.Name = "btnPlusUpgr"
        Me.btnPlusUpgr.Size = New System.Drawing.Size(40, 41)
        Me.btnPlusUpgr.TabIndex = 42
        Me.btnPlusUpgr.Text = "+"
        Me.btnPlusUpgr.UseVisualStyleBackColor = True
        Me.btnPlusUpgr.Visible = False
        '
        'cboxSelMinUpg02
        '
        Me.cboxSelMinUpg02.FormattingEnabled = True
        Me.cboxSelMinUpg02.Items.AddRange(New Object() {"", "Anguis Ice Harvester Upgrade", "Crisium Ice Harvester Upgrade", "Frigoris Ice Harvester Upgrade", "Ice Harvester Upgrade I", "Ingenii Ice Harvester Upgrade", "Ice Harvester Upgrade II"})
        Me.cboxSelMinUpg02.Location = New System.Drawing.Point(165, 182)
        Me.cboxSelMinUpg02.Name = "cboxSelMinUpg02"
        Me.cboxSelMinUpg02.Size = New System.Drawing.Size(227, 25)
        Me.cboxSelMinUpg02.TabIndex = 43
        '
        'cboxSelMinUpg03
        '
        Me.cboxSelMinUpg03.FormattingEnabled = True
        Me.cboxSelMinUpg03.Items.AddRange(New Object() {"", "Anguis Ice Harvester Upgrade", "Crisium Ice Harvester Upgrade", "Frigoris Ice Harvester Upgrade", "Ice Harvester Upgrade I", "Ingenii Ice Harvester Upgrade", "Ice Harvester Upgrade II"})
        Me.cboxSelMinUpg03.Location = New System.Drawing.Point(165, 231)
        Me.cboxSelMinUpg03.Name = "cboxSelMinUpg03"
        Me.cboxSelMinUpg03.Size = New System.Drawing.Size(226, 25)
        Me.cboxSelMinUpg03.TabIndex = 44
        '
        'fSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(782, 453)
        Me.Controls.Add(Me.cboxSelMinUpg03)
        Me.Controls.Add(Me.cboxSelMinUpg02)
        Me.Controls.Add(Me.btnPlusUpgr)
        Me.Controls.Add(Me.cboxSelMinUpg01)
        Me.Controls.Add(Me.cboxSelUpgrNo02)
        Me.Controls.Add(Me.cboxSelUpgrNo03)
        Me.Controls.Add(Me.cboxSelUpgrNo01)
        Me.Controls.Add(Me.lblIceHSKillSelLbl)
        Me.Controls.Add(Me.cboxIceHLevelSel)
        Me.Controls.Add(Me.cboxMinBargeSkillSelect)
        Me.Controls.Add(Me.lblMinBargeLbl)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.cboxSelectImplant)
        Me.Controls.Add(Me.lblUsedImplLbl)
        Me.Controls.Add(Me.cboxSelectRig)
        Me.Controls.Add(Me.lblSelRigsLbl)
        Me.Controls.Add(Me.lblSelUsedUpgrLbl)
        Me.Controls.Add(Me.cboxSelectHarvester)
        Me.Controls.Add(Me.lblSelHarvester)
        Me.Controls.Add(Me.cboxExhSkillSelect)
        Me.Controls.Add(Me.lblExhSkillLbl)
        Me.Controls.Add(Me.cboxSelectShip)
        Me.Controls.Add(Me.lblSelShip)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MiningUpgradesBindingSource, "UpgradeName", True))
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "fSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Choose your equipment and skills "
        CType(Me.ShipsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkillsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoOfLowSlotsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HarvestersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiningUpgradesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RigsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImplantsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiningBargeSkillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IceHarvesterSkillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSelShip As System.Windows.Forms.Label
    Friend WithEvents cboxSelectShip As System.Windows.Forms.ComboBox
    Friend WithEvents lblExhSkillLbl As System.Windows.Forms.Label
    Friend WithEvents cboxExhSkillSelect As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelHarvester As System.Windows.Forms.Label
    Friend WithEvents cboxSelectHarvester As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelRigsLbl As System.Windows.Forms.Label
    Friend WithEvents cboxSelectRig As System.Windows.Forms.ComboBox
    Friend WithEvents lblUsedImplLbl As System.Windows.Forms.Label
    Friend WithEvents cboxSelectImplant As System.Windows.Forms.ComboBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents DtbDataSet As IceTimer.dtbDataSet
    Friend WithEvents ShipsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ShipsTableAdapter As IceTimer.dtbDataSetTableAdapters.ShipsTableAdapter
    Friend WithEvents HarvestersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HarvestersTableAdapter As IceTimer.dtbDataSetTableAdapters.HarvestersTableAdapter
    Friend WithEvents SkillsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SkillsTableAdapter As IceTimer.dtbDataSetTableAdapters.SkillsTableAdapter
    Friend WithEvents RigsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RigsTableAdapter As IceTimer.dtbDataSetTableAdapters.RigsTableAdapter
    Friend WithEvents ImplantsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ImplantsTableAdapter As IceTimer.dtbDataSetTableAdapters.ImplantsTableAdapter
    Friend WithEvents NoOfLowSlotsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NoOfLowSlotsTableAdapter As IceTimer.dtbDataSetTableAdapters.NoOfLowSlotsTableAdapter
    Friend WithEvents lblMinBargeLbl As System.Windows.Forms.Label
    Friend WithEvents cboxMinBargeSkillSelect As System.Windows.Forms.ComboBox
    Friend WithEvents MiningBargeSkillBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MiningBargeSkillTableAdapter As IceTimer.dtbDataSetTableAdapters.MiningBargeSkillTableAdapter
    Friend WithEvents MiningUpgradesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MiningUpgradesTableAdapter As IceTimer.dtbDataSetTableAdapters.MiningUpgradesTableAdapter
    Friend WithEvents cboxIceHLevelSel As System.Windows.Forms.ComboBox
    Friend WithEvents lblIceHSKillSelLbl As System.Windows.Forms.Label
    Friend WithEvents IceHarvesterSkillBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IceHarvesterSkillTableAdapter As IceTimer.dtbDataSetTableAdapters.IceHarvesterSkillTableAdapter
    Friend WithEvents lblSelUsedUpgrLbl As System.Windows.Forms.Label
    Friend WithEvents cboxSelUpgrNo01 As System.Windows.Forms.ComboBox
    Friend WithEvents cboxSelUpgrNo03 As System.Windows.Forms.ComboBox
    Friend WithEvents cboxSelUpgrNo02 As System.Windows.Forms.ComboBox
    Friend WithEvents btnPlusUpgr As System.Windows.Forms.Button
    Private WithEvents cboxSelMinUpg01 As System.Windows.Forms.ComboBox
    Private WithEvents cboxSelMinUpg02 As System.Windows.Forms.ComboBox
    Private WithEvents cboxSelMinUpg03 As System.Windows.Forms.ComboBox
End Class
