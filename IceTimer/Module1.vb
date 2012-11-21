Imports System.Windows, Microsoft.VisualBasic, Microsoft.VisualBasic.FileIO

Module Module1
    Public _cycleTimeNominal, _skillLevelExh, _skillLevelMinBarge, _skillLevelIceHarvesting, _turretHardpointNo As Integer
    Public _roleBonus, _skillBonusEhx, _skillBonusMinBar, _rigBonus, _implBonus, _oreHoldCap, _skillLevelIceHBonus, _cycleTimeReal _
        , _totalMiningTime As Decimal
    Public _shipIndex, _iceHarvesterIndex, _skillExhumerIndex, _skillMinBargeIndex, _skillIceHarvIndex, _selUpgrNameIndex _
        , _numOfSelIndex, _rigIndex, _implIndex As Integer
    
    Public _shipName As String
    Public _numOfUpgrades() As Integer = ({0, 0, 0})
    Public _MinUpgradesBonus() As Decimal = ({0D, 0D, 0D})
    Public _configLocation As String = FileIO.FileSystem.CurrentDirectory & "\config.txt"
    
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

    Function TotalMiningTime(ByVal OreHoldNominal As Integer, ByVal MinBarBonusToOrehold As Decimal _
                             , ByVal MiningBargeSkillLevel As Integer, ByVal CycleTimeReal As Decimal _
                             , ByVal NoOfTurretHardpoints As Integer) As Decimal

        Return ((OreHoldNominal * (1 + MinBarBonusToOrehold * MiningBargeSkillLevel)) * CycleTimeReal) / NoOfTurretHardpoints
    End Function

    Function TimeToMineDisplay(ByVal TotalMiningTimeinSec As Decimal) As String
        Dim _min As Integer = 0
        Dim _rest As Integer = 0
        Dim _timeToMine As String
        _min = TotalMiningTimeinSec \ 60
        _rest = Math.Round(TotalMiningTimeinSec Mod 60, 2)
        _timeToMine = Convert.ToString(_min) & " minutes " & Convert.ToString(_rest) & " seconds"
        Return _timeToMine
    End Function
End Module
