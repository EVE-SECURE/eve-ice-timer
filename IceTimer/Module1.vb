Imports System.Windows, Microsoft.VisualBasic, Microsoft.VisualBasic.FileIO

Module Module1
    '---------sets various public variables needed for functions in app
    Public _cycleTimeNominal, _skillLevelExh, _skillLevelMinBarge, _skillLevelIceHarvesting, _turretHardpointNo As Integer
    Public _roleBonus, _skillBonusEhx, _skillBonusMinBar, _rigBonus, _implBonus, _oreHoldCap, _skillLevelIceHBonus, _cycleTimeReal _
        , _totalMiningTime As Decimal
    Public _shipIndex, _iceHarvesterIndex, _skillExhumerIndex, _skillMinBargeIndex, _skillIceHarvIndex, _selUpgrNameIndex _
        , _numOfSelIndex, _rigIndex, _implIndex As Integer

    Public _shipName As String = ""
    Public _numOfUpgrades() As Integer = ({0, 0, 0})
    Public _MinUpgradesBonus() As Decimal = ({0D, 0D, 0D})
    Public _ident As String = ""
    Public _value As String = ""
    Public _configLocation As String = FileIO.FileSystem.CurrentDirectory & "\config.txt"
    '--------------function to compute real harvesting cycle time
    Function HarvestCycleTime(ByVal CycleTimeNominal As Integer, ByVal ShipRoleBonus As Decimal _
                              , ByVal ExhSkillShipBonus As Decimal _
                              , ByVal RigBonus As Decimal, ByVal ImplantBonus As Decimal, ByVal IceHarvestSkillBonus As Decimal _
                              , ByVal MinUpgradeBonus() As Decimal, ByVal NumberOfMiningUpgrades() As Integer _
                              , ByVal ExhumerSkillLevel As Integer, ByVal MiningBargeSkillLevel As Integer) As Decimal

        Return CycleTimeNominal * (1 - ShipRoleBonus) * (1 - ExhSkillShipBonus * ExhumerSkillLevel) _
            * (1 - RigBonus) * (1 - ImplantBonus) * (1 - IceHarvestSkillBonus) _
            * ((1 - MinUpgradeBonus(0)) ^ NumberOfMiningUpgrades(0)) * ((1 - MinUpgradeBonus(1)) ^ NumberOfMiningUpgrades(1)) _
            * ((1 - MinUpgradeBonus(2)) ^ NumberOfMiningUpgrades(2))
    End Function
    '-------------function to compute real total mining time
    Function TotalMiningTime(ByVal OreHoldNominal As Integer, ByVal MinBarBonusToOrehold As Decimal _
                             , ByVal MiningBargeSkillLevel As Integer, ByVal CycleTimeReal As Decimal _
                             , ByVal NoOfTurretHardpoints As Integer) As Decimal

        Return ((OreHoldNominal * (1 + MinBarBonusToOrehold * MiningBargeSkillLevel)) * CycleTimeReal) / NoOfTurretHardpoints
    End Function
    '-------------function to display total mining time as string (text) information in mm:ss format in Main form
    Function TimeToMineDisplay(ByVal TotalMiningTimeinSec As Decimal) As String
        Dim _min As Integer = 0
        Dim _rest As Integer = 0
        Dim _timeToMine As String
        _min = TotalMiningTimeinSec \ 60
        _rest = Math.Round(TotalMiningTimeinSec Mod 60, 2)
        _timeToMine = Convert.ToString(_min) & " minutes " & Convert.ToString(_rest) & " seconds"
        Return _timeToMine
    End Function
    '-------------function to assign values to appropriate variables after config file is loaded
    Function AssignValue(ByVal NameOfVariable As String, ByVal ValueOfVariable As String)
        If NameOfVariable = "_shipName" Then
            _shipName = ValueOfVariable
        ElseIf NameOfVariable = "_roleBonus" Then
            _roleBonus = Convert.ToDecimal(ValueOfVariable)
        ElseIf NameOfVariable = "_skillBonusExh" Then
            _skillBonusEhx = Convert.ToDecimal(ValueOfVariable)
        ElseIf NameOfVariable = "_oreHoldCap" Then
            _oreHoldCap = Convert.ToDecimal(ValueOfVariable)
        ElseIf NameOfVariable = "_skillBonusMinBar" Then
            _skillBonusMinBar = Convert.ToDecimal(ValueOfVariable)
        ElseIf NameOfVariable = "_turretHardpointNo" Then
            _turretHardpointNo = Convert.ToInt16(ValueOfVariable)
        ElseIf NameOfVariable = "_shipIndex" Then
            _shipIndex = Convert.ToInt16(ValueOfVariable)
        ElseIf NameOfVariable = "_cycleTimeNominal" Then
            _cycleTimeNominal = Convert.ToInt16(ValueOfVariable)
        ElseIf NameOfVariable = "_iceHarvesterIndex" Then
            _iceHarvesterIndex = Convert.ToInt16(ValueOfVariable)
        ElseIf NameOfVariable = "_skillLevelExh" Then
            _skillLevelExh = Convert.ToInt16(ValueOfVariable)
        ElseIf NameOfVariable = "_skillExhumerIndex" Then
            _skillExhumerIndex = Convert.ToInt16(ValueOfVariable)
        ElseIf NameOfVariable = "_skillLevelMinBarge" Then
            _skillLevelMinBarge = Convert.ToInt16(ValueOfVariable)
        ElseIf NameOfVariable = "_skillMinBargeIndex" Then
            _skillMinBargeIndex = Convert.ToInt16(ValueOfVariable)
        ElseIf NameOfVariable = "_rigBonus" Then
            _rigBonus = Convert.ToDecimal(ValueOfVariable)
        ElseIf NameOfVariable = "_rigIndex" Then
            _rigIndex = Convert.ToInt16(ValueOfVariable)
        ElseIf NameOfVariable = "_implBonus" Then
            _implBonus = Convert.ToDecimal(ValueOfVariable)
        ElseIf NameOfVariable = "_implIndex" Then
            _implIndex = Convert.ToInt16(ValueOfVariable)
        ElseIf NameOfVariable = "_skillLevelIceHBonus" Then
            _skillLevelIceHBonus = Convert.ToDecimal(ValueOfVariable)
        ElseIf NameOfVariable = "_skillIceHarvIndex" Then
            _skillIceHarvIndex = Convert.ToInt16(ValueOfVariable)
        ElseIf NameOfVariable = "_MinUpgradesBonus(0)" Then
            _MinUpgradesBonus(0) = Convert.ToDecimal(ValueOfVariable)
        ElseIf NameOfVariable = "_selUpgrNameIndex" Then
            _selUpgrNameIndex = Convert.ToInt16(ValueOfVariable)
        ElseIf NameOfVariable = "_MinUpgradesBonus(1)" Then
            _MinUpgradesBonus(1) = Convert.ToDecimal(ValueOfVariable)
        ElseIf NameOfVariable = "_MinUpgradesBonus(2)" Then
            _MinUpgradesBonus(2) = Convert.ToDecimal(ValueOfVariable)
        ElseIf NameOfVariable = "_numOfUpgrades(0)" Then
            _numOfUpgrades(0) = Convert.ToInt16(ValueOfVariable)
        ElseIf NameOfVariable = "_numOfSelIndex" Then
            _numOfSelIndex = Convert.ToInt16(ValueOfVariable)
        ElseIf NameOfVariable = "_numOfUpgrades(1)" Then
            _numOfUpgrades(1) = Convert.ToInt16(ValueOfVariable)
        ElseIf NameOfVariable = "_numOfUpgrades(2)" Then
            _numOfUpgrades(2) = Convert.ToInt16(ValueOfVariable)

        End If

    End Function

End Module
