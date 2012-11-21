Imports Microsoft.VisualBasic.FileIO, System.Data, System.Math, System.IO
Public Class fSettings
    Dim _checkedItemsCntr As Integer = 0
    Dim _firstRun As Boolean = True
    Dim btnClickCntr As Integer = 0
    Dim _turretCheck As Boolean = True
    Dim _harvesterCheck As Boolean = True



    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        '---------------------------------------------------
        'TODO: This line of code loads data into the 'DtbDataSet.IceHarvesterSkill' table. You can move, or remove it, as needed.
        Me.IceHarvesterSkillTableAdapter.Fill(Me.DtbDataSet.IceHarvesterSkill)
        'TODO: This line of code loads data into the 'DtbDataSet.MiningUpgrades' table. You can move, or remove it, as needed.
        Me.MiningUpgradesTableAdapter.Fill(Me.DtbDataSet.MiningUpgrades)
        'TODO: This line of code loads data into the 'DtbDataSet.MiningBargeSkill' table. You can move, or remove it, as needed.
        Me.MiningBargeSkillTableAdapter.Fill(Me.DtbDataSet.MiningBargeSkill)
        'TODO: This line of code loads data into the 'DtbDataSet.NoOfLowSlots' table. You can move, or remove it, as needed.
        Me.NoOfLowSlotsTableAdapter.Fill(Me.DtbDataSet.NoOfLowSlots)
        'TODO: This line of code loads data into the 'DtbDataSet.Implants' table. You can move, or remove it, as needed.
        Me.ImplantsTableAdapter.Fill(Me.DtbDataSet.Implants)
        'TODO: This line of code loads data into the 'DtbDataSet.Rigs' table. You can move, or remove it, as needed.
        Me.RigsTableAdapter.Fill(Me.DtbDataSet.Rigs)
        'TODO: This line of code loads data into the 'DtbDataSet.Skills' table. You can move, or remove it, as needed.
        Me.SkillsTableAdapter.Fill(Me.DtbDataSet.Skills)
        'TODO: This line of code loads data into the 'DtbDataSet.Harvesters' table. You can move, or remove it, as needed.
        Me.HarvestersTableAdapter.Fill(Me.DtbDataSet.Harvesters)
        'TODO: This line of code loads data into the 'DtbDataSet.Ships' table. You can move, or remove it, as needed.
        Me.ShipsTableAdapter.Fill(Me.DtbDataSet.Ships)
        '---------------------------------------------------
        btnPlusUpgr.Visible = False
        cboxSelMinUpg02.Visible = False
        cboxSelMinUpg02.SelectedIndex = 0
        cboxSelMinUpg03.Visible = False
        cboxSelMinUpg03.SelectedIndex = 0
        cboxSelUpgrNo02.Visible = False
        cboxSelUpgrNo02.SelectedIndex = 0
        cboxSelUpgrNo03.Visible = False
        cboxSelUpgrNo03.SelectedIndex = 0
        '---------------------------------------------------



    End Sub
    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If _turretHardpointNo >= 1 Then
            If _cycleTimeNominal > 0 Then
                If (_numOfUpgrades(0) + _numOfUpgrades(1) + _numOfUpgrades(2)) <= 3 Then
                    _cycleTimeReal = Math.Round(HarvestCycleTime(_cycleTimeNominal, _roleBonus, _skillBonusEhx _
                                                      , _rigBonus, _implBonus, _skillLevelIceHBonus _
                                                      , _MinUpgradesBonus, _numOfUpgrades, _skillLevelExh _
                                                      , _skillLevelMinBarge), 0)
                    _totalMiningTime = Math.Round(TotalMiningTime(_oreHoldCap, _skillBonusMinBar, _skillLevelMinBarge, _cycleTimeReal _
                                                                  , _turretHardpointNo), 0)

                    My.Forms.fMain.lblSelShipNameDisp.Text = _shipName
                    My.Forms.fMain.lblHarvCycleTimeDisp.Text = Convert.ToString(_cycleTimeReal) & " seconds"
                    My.Forms.fMain.lblTimeToMineDisp.Text = TimeToMineDisplay(_totalMiningTime)
                    My.Forms.fMain.prgrBar01.Maximum = _totalMiningTime

                    Dim SettingsToWrite As StreamWriter
                    SettingsToWrite = New StreamWriter(_configLocation, False)

                    Dim _dataFill As String = "_shipName=" & _shipName & vbCrLf _
                                 & "_roleBonus=" & Convert.ToString(_roleBonus) & vbCrLf _
                                 & "_skillBonusEhx=" & Convert.ToString(_skillBonusEhx) & vbCrLf _
                                 & "_oreHoldCap=" & Convert.ToString(_oreHoldCap) & vbCrLf _
                                 & "_skillBonusMinBar=" & Convert.ToString(_skillBonusMinBar) & vbCrLf _
                                 & "_turretHardpointNo=" & Convert.ToString(_turretHardpointNo) & vbCrLf _
                                 & "_shipIndex=" & Convert.ToString(_shipIndex) & vbCrLf _
                                 & "_cycleTimeNominal=" & Convert.ToString(_cycleTimeNominal) & vbCrLf _
                                 & "_iceHarvesterIndex=" & Convert.ToString(_iceHarvesterIndex) & vbCrLf _
                                 & "_skillLevelExh=" & Convert.ToString(_skillLevelExh) & vbCrLf _
                                 & "_skillExhumerIndex=" & Convert.ToString(_skillExhumerIndex) & vbCrLf _
                                 & "_skillLevelMinBarge=" & Convert.ToString(_skillLevelMinBarge) & vbCrLf _
                                 & "_skillMinBargeIndex=" & Convert.ToString(_skillMinBargeIndex) & vbCrLf _
                                 & "_rigBonus=" & Convert.ToString(_rigBonus) & vbCrLf _
                                 & "_rigIndex=" & Convert.ToString(_rigIndex) & vbCrLf _
                                 & "_implBonus=" & Convert.ToString(_implBonus) & vbCrLf _
                                 & "_implIndex=" & Convert.ToString(_implIndex) & vbCrLf _
                                 & "_skillLevelIceHBonus=" & Convert.ToString(_skillLevelIceHBonus) & vbCrLf _
                                 & "_skillIceHarvIndex=" & Convert.ToString(_skillIceHarvIndex) & vbCrLf _
                                 & "_MinUpgradesBonus(0)=" & Convert.ToString(_MinUpgradesBonus(0)) & vbCrLf _
                                 & "_selUpgrNameIndex=" & Convert.ToString(_selUpgrNameIndex) & vbCrLf _
                                 & "_MinUpgradesBonus(1)=" & Convert.ToString(_MinUpgradesBonus(1)) & vbCrLf _
                                 & "_MinUpgradesBonus(2)=" & Convert.ToString(_MinUpgradesBonus(2)) & vbCrLf _
                                 & "_numOfUpgrades(0)=" & Convert.ToString(_numOfUpgrades(0)) & vbCrLf _
                                 & "_numOfSelIndex=" & Convert.ToString(_numOfSelIndex) & vbCrLf _
                                 & "_numOfUpgrades(1)=" & Convert.ToString(_numOfUpgrades(1)) & vbCrLf _
                                 & "_numOfUpgrades(2)=" & Convert.ToString(_numOfUpgrades(2)) & vbCrLf

                    SettingsToWrite.Write(_dataFill)
                    SettingsToWrite.Close()

                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MsgBox("Cannot have more then 3 mining upgrades selected!" & vbCrLf _
                           & "Please, select number of upgrades accordingly.", MsgBoxStyle.Critical, "Error Warning!")
                End If
            Else
                MsgBox("Ice harvester must be selected!", MsgBoxStyle.Critical, "Error Warning!")
            End If
        Else
            MsgBox("Ship must be selected!", MsgBoxStyle.Critical, "Error Warning!")
        End If
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cboxSelectShip_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboxSelectShip.SelectedIndexChanged

        Select Case cboxSelectShip.SelectedIndex

            Case 1
                _shipName = Me.DtbDataSet.Ships.Rows.Item(1).Item(1)
                _roleBonus = Me.DtbDataSet.Ships.Rows.Item(1).Item(2)
                _skillBonusEhx = Me.DtbDataSet.Ships.Rows.Item(1).Item(3)
                _oreHoldCap = Me.DtbDataSet.Ships.Rows.Item(1).Item(4)
                _skillBonusMinBar = Me.DtbDataSet.Ships.Rows.Item(1).Item(5)
                _turretHardpointNo = Me.DtbDataSet.Ships.Rows.Item(1).Item(6)
                _shipIndex = 1
            Case 2
                _shipName = Me.DtbDataSet.Ships.Rows.Item(2).Item(1)
                _roleBonus = Me.DtbDataSet.Ships.Rows.Item(2).Item(2)
                _skillBonusEhx = Me.DtbDataSet.Ships.Rows.Item(2).Item(3)
                _oreHoldCap = Me.DtbDataSet.Ships.Rows.Item(2).Item(4)
                _skillBonusMinBar = Me.DtbDataSet.Ships.Rows.Item(2).Item(5)
                _turretHardpointNo = Me.DtbDataSet.Ships.Rows.Item(2).Item(6)
                _shipIndex = 2
            Case 3
                _shipName = Me.DtbDataSet.Ships.Rows.Item(3).Item(1)
                _roleBonus = Me.DtbDataSet.Ships.Rows.Item(3).Item(2)
                _skillBonusEhx = Me.DtbDataSet.Ships.Rows.Item(3).Item(3)
                _oreHoldCap = Me.DtbDataSet.Ships.Rows.Item(3).Item(4)
                _skillBonusMinBar = Me.DtbDataSet.Ships.Rows.Item(3).Item(5)
                _turretHardpointNo = Me.DtbDataSet.Ships.Rows.Item(3).Item(6)
                _shipIndex = 3
            Case 4
                _shipName = Me.DtbDataSet.Ships.Rows.Item(4).Item(1)
                _roleBonus = Me.DtbDataSet.Ships.Rows.Item(4).Item(2)
                _skillBonusEhx = Me.DtbDataSet.Ships.Rows.Item(4).Item(3)
                _oreHoldCap = Me.DtbDataSet.Ships.Rows.Item(4).Item(4)
                _skillBonusMinBar = Me.DtbDataSet.Ships.Rows.Item(4).Item(5)
                _turretHardpointNo = Me.DtbDataSet.Ships.Rows.Item(4).Item(6)
                _shipIndex = 4
            Case 5
                _shipName = Me.DtbDataSet.Ships.Rows.Item(5).Item(1)
                _roleBonus = Me.DtbDataSet.Ships.Rows.Item(5).Item(2)
                _skillBonusEhx = Me.DtbDataSet.Ships.Rows.Item(5).Item(3)
                _oreHoldCap = Me.DtbDataSet.Ships.Rows.Item(5).Item(4)
                _skillBonusMinBar = Me.DtbDataSet.Ships.Rows.Item(5).Item(5)
                _turretHardpointNo = Me.DtbDataSet.Ships.Rows.Item(5).Item(6)
                _shipIndex = 5
            Case 6
                _shipName = Me.DtbDataSet.Ships.Rows.Item(6).Item(1)
                _roleBonus = Me.DtbDataSet.Ships.Rows.Item(6).Item(2)
                _skillBonusEhx = Me.DtbDataSet.Ships.Rows.Item(6).Item(3)
                _oreHoldCap = Me.DtbDataSet.Ships.Rows.Item(6).Item(4)
                _skillBonusMinBar = Me.DtbDataSet.Ships.Rows.Item(6).Item(5)
                _turretHardpointNo = Me.DtbDataSet.Ships.Rows.Item(6).Item(6)
                _shipIndex = 6
            Case Else
                _shipName = vbNullString
                _roleBonus = 0
                _skillBonusEhx = 0
                _oreHoldCap = 0
                _skillBonusMinBar = 0
                _turretHardpointNo = 0
                _shipIndex = _shipIndex

        End Select

    End Sub

    Private Sub cboxSelectHarvester_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboxSelectHarvester.SelectedIndexChanged
        Select Case cboxSelectHarvester.SelectedIndex

            Case 1
                _cycleTimeNominal = Me.DtbDataSet.Harvesters.Rows.Item(1).Item(2)
                _iceHarvesterIndex = 1
            Case 2
                _cycleTimeNominal = Me.DtbDataSet.Harvesters.Rows.Item(2).Item(2)
                _iceHarvesterIndex = 2
            Case 3
                _cycleTimeNominal = Me.DtbDataSet.Harvesters.Rows.Item(3).Item(2)
            Case Else
                _cycleTimeNominal = 0
                _iceHarvesterIndex = _iceHarvesterIndex
        End Select
    End Sub

    Private Sub cboxExhSkillSelect_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboxExhSkillSelect.SelectedIndexChanged
        Select Case cboxExhSkillSelect.SelectedIndex
            Case 0
                _skillLevelExh = 0
                _skillExhumerIndex = 0
            Case 1
                _skillLevelExh = Me.DtbDataSet.Skills.Rows.Item(1).Item(2)
                _skillExhumerIndex = 1
            Case 2
                _skillLevelExh = Me.DtbDataSet.Skills.Rows.Item(2).Item(2)
                _skillExhumerIndex = 2
            Case 3
                _skillLevelExh = Me.DtbDataSet.Skills.Rows.Item(3).Item(2)
                _skillExhumerIndex = 3
            Case 4
                _skillLevelExh = Me.DtbDataSet.Skills.Rows.Item(4).Item(2)
                _skillExhumerIndex = 4
            Case 5
                _skillLevelExh = Me.DtbDataSet.Skills.Rows.Item(5).Item(2)
                _skillExhumerIndex = 5
            Case Else
                _skillLevelExh = 0
                _skillExhumerIndex = _skillExhumerIndex
        End Select
    End Sub

    Private Sub cboxMinBargeSkillSelect_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboxMinBargeSkillSelect.SelectedIndexChanged
        Select Case cboxMinBargeSkillSelect.SelectedIndex
            Case 0
                _skillLevelMinBarge = 0
                _skillMinBargeIndex = 0
            Case 1
                _skillLevelMinBarge = Me.DtbDataSet.MiningBargeSkill.Rows.Item(1).Item(2)
                _skillMinBargeIndex = 1
            Case 2
                _skillLevelMinBarge = Me.DtbDataSet.MiningBargeSkill.Rows.Item(2).Item(2)
                _skillMinBargeIndex = 2
            Case 3
                _skillLevelMinBarge = Me.DtbDataSet.MiningBargeSkill.Rows.Item(3).Item(2)
                _skillMinBargeIndex = 3
            Case 4
                _skillLevelMinBarge = Me.DtbDataSet.MiningBargeSkill.Rows.Item(4).Item(2)
                _skillMinBargeIndex = 4
            Case 5
                _skillLevelMinBarge = Me.DtbDataSet.MiningBargeSkill.Rows.Item(5).Item(2)
                _skillMinBargeIndex = 5
            Case Else
                _skillLevelMinBarge = 0
                _skillMinBargeIndex = _skillMinBargeIndex
        End Select
    End Sub


    Private Sub cboxSelectRig_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboxSelectRig.SelectedIndexChanged
        Select Case cboxSelectRig.SelectedIndex
            Case 0
                _rigBonus = 0
                _rigIndex = 0
            Case 1
                _rigBonus = Me.DtbDataSet.Rigs.Rows.Item(1).Item(2)
                _rigIndex = 1
            Case Else
                _rigBonus = 0
                _rigIndex = _rigIndex
        End Select
    End Sub

    Private Sub cboxSelectImplant_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboxSelectImplant.SelectedIndexChanged
        Select Case cboxSelectImplant.SelectedIndex
            Case 0
                _implBonus = 0
                _implIndex = 0
            Case 1
                _implBonus = Me.DtbDataSet.Implants.Rows.Item(1).Item(2)
                _implIndex = 1
            Case 2
                _implBonus = Me.DtbDataSet.Implants.Rows.Item(2).Item(2)
                _implIndex = 2
            Case 3
                _implBonus = Me.DtbDataSet.Implants.Rows.Item(3).Item(2)
                _implIndex = 3
            Case Else
                _implBonus = 0
                _implIndex = _implIndex
        End Select
    End Sub


    Private Sub cboxIceHLevelSel_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboxIceHLevelSel.SelectedIndexChanged
        Select Case cboxIceHLevelSel.SelectedIndex
            Case 0
                _skillLevelIceHBonus = 0
                _skillIceHarvIndex = 0
            Case 1
                _skillLevelIceHBonus = Me.DtbDataSet.IceHarvesterSkill.Rows.Item(1).Item(3)
                _skillIceHarvIndex = 1
            Case 2
                _skillLevelIceHBonus = Me.DtbDataSet.IceHarvesterSkill.Rows.Item(2).Item(3)
                _skillIceHarvIndex = 2
            Case 3
                _skillLevelIceHBonus = Me.DtbDataSet.IceHarvesterSkill.Rows.Item(3).Item(3)
                _skillIceHarvIndex = 3
            Case 4
                _skillLevelIceHBonus = Me.DtbDataSet.IceHarvesterSkill.Rows.Item(4).Item(3)
                _skillIceHarvIndex = 4
            Case 5
                _skillLevelIceHBonus = Me.DtbDataSet.IceHarvesterSkill.Rows.Item(5).Item(3)
                _skillIceHarvIndex = 5
            Case Else
                _skillLevelIceHBonus = 0
                _skillIceHarvIndex = _skillIceHarvIndex
        End Select
    End Sub

    Private Sub cboxSelMinUpg01_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboxSelMinUpg01.SelectedIndexChanged
        _MinUpgradesBonus(0) = Me.DtbDataSet.MiningUpgrades.Rows.Item(cboxSelMinUpg01.SelectedIndex).Item(2)
        _selUpgrNameIndex = cboxSelMinUpg01.SelectedIndex

        If cboxSelMinUpg01.SelectedIndex <> 0 Then
            btnPlusUpgr.Visible = True

        End If
    End Sub

    Private Sub btnPlusUpgr_Click(sender As System.Object, e As System.EventArgs) Handles btnPlusUpgr.Click
        btnClickCntr += 1
        Select Case btnClickCntr
            Case 1

                cboxSelMinUpg02.Visible = True
                cboxSelUpgrNo02.Visible = True
            Case 2

                cboxSelMinUpg03.Visible = True
                cboxSelUpgrNo03.Visible = True
        End Select

    End Sub

    Private Sub cboxSelMinUpg02_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cboxSelMinUpg02.SelectedIndexChanged
        _MinUpgradesBonus(1) = Me.DtbDataSet.MiningUpgrades.Rows.Item(cboxSelMinUpg02.SelectedIndex).Item(2)
    End Sub

    Private Sub cboxSelMinUpg03_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cboxSelMinUpg03.SelectedIndexChanged
        _MinUpgradesBonus(2) = Me.DtbDataSet.MiningUpgrades.Rows.Item(cboxSelMinUpg03.SelectedIndex).Item(2)
    End Sub

    Private Sub cboxSelUpgrNo01_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboxSelUpgrNo01.SelectedIndexChanged
        _numOfUpgrades(0) = Convert.ToInt16(cboxSelUpgrNo01.SelectedIndex)
        _numOfSelIndex = cboxSelUpgrNo01.SelectedIndex
    End Sub

    Private Sub cboxSelUpgrNo02_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboxSelUpgrNo02.SelectedIndexChanged
        _numOfUpgrades(1) = Convert.ToInt16(cboxSelUpgrNo02.SelectedIndex)
    End Sub

    Private Sub cboxSelUpgrNo03_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboxSelUpgrNo03.SelectedIndexChanged
        _numOfUpgrades(2) = Convert.ToInt16(cboxSelUpgrNo03.SelectedIndex)
    End Sub

End Class