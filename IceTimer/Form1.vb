Public Class fMain
    '----------------------------sets variables for future use
    Dim cntrSec As Integer = 0
    Dim sec As Integer = 0
    Dim strSec As String = ""
    Dim cntrMin As Integer = 0
    Dim Min As Integer = 0
    Dim strMin As String = ""
    Dim cntrHour As Integer = 0
    Dim Hour As Integer = 0
    Dim strHour As String = ""
    Dim prgrBarCntr As Integer = 0
    Dim _iconSwitch As Boolean = True

    Private Sub RelevantSkillsAndEquipmentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RelevantSkillsAndEquipmentToolStripMenuItem.Click
        My.Forms.fSettings.ShowDialog() 'opens settings window
    End Sub

    Private Sub EndToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EndToolStripMenuItem.Click
        End 'ends application
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        '-------------------------------------beginning of stopwatch algorithm
        '----------handles seconds
        If cntrSec < 60 And cntrSec < 9 Then
            cntrSec += 1
            sec = cntrSec
            strSec = "0" & CStr(sec)
        ElseIf cntrSec < 60 And cntrSec >= 9 Then
            cntrSec += 1
            sec = cntrSec
            strSec = CStr(sec)
            '--------------handles minutes
            If cntrSec = 60 And cntrMin < 9 Then
                cntrMin += 1
                Min = cntrMin
                strMin = "0" & CStr(Min)
                strSec = "00"
                cntrSec = 0
            ElseIf cntrSec = 60 And cntrMin >= 9 Then
                cntrMin += 1
                Min = cntrMin
                strMin = CStr(Min)
                strSec = "00"
                cntrSec = 0
                '------------handles hours
                If cntrMin = 60 And cntrHour < 9 Then
                    cntrHour += 1
                    Hour = cntrHour
                    strHour = "0" & CStr(Hour)
                    strMin = "00"
                    cntrMin = 0
                ElseIf cntrMin = 60 And cntrHour >= 9 Then
                    cntrHour += 1
                    Hour = cntrHour
                    strHour = CStr(Hour)
                    strMin = "00"
                    cntrMin = 0
                End If
            End If
        End If
        '-----------------------------------------end of stopwatch algorithm

        prgrBarCntr += 1
        lblTimeShow.Text = strHour & ":" & strMin & ":" & strSec
        prgrBar01.Value = prgrBarCntr

        '----------------------------------------shows visual and beep-sound notification, when time is up
        If prgrBarCntr = _totalMiningTime Then
            Timer1.Enabled = False
            MsgBox("Orehold of your " & _shipName & " is probably full!", MsgBoxStyle.Exclamation _
                   , "Orehold overload warning!")
        End If

    End Sub

    Private Sub fMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        strMin = "00"
        strHour = "00"
        lblTimeShow.Text = "--:--:--"
        prgrBar01.Visible = False
        prgrBar01.Minimum = 0
        '-------------------------------loads config file content into variables
        If FileIO.FileSystem.FileExists(_configLocation) = True Then
            Dim configLoad As IO.StreamReader
            Dim configContent As String = ""
            configLoad = New IO.StreamReader(_configLocation)
            configContent = configLoad.ReadToEnd()
            configLoad.Close()

            Dim configContentArray() As String = Split(configContent, vbCrLf)
            Dim _var As String = ""

            For i As Integer = 0 To configContentArray.Count() - 1
                For j As Integer = 0 To configContentArray(i).Length - 1
                    Dim ch As String = configContentArray(i).Substring(j, 1)
                    If ch = "=" Then
                        _ident = Trim(_var) '_ident variable is public (module1)
                        _var = ""
                    ElseIf ch = ";" Then
                        _value = Trim(_var) '_value variable is public (module1)
                        _var = ""
                        Try
                            AssignValue(_ident, _value)
                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error in inner function")
                        End Try
                    Else
                        _var = _var & ch
                    End If
                Next j
            Next i
            '----------------------------end of config load
            '----------------------------computes real cycle time and then total mining time
            _cycleTimeReal = Math.Round(HarvestCycleTime(_cycleTimeNominal, _roleBonus, _skillBonusEhx _
                                                     , _rigBonus, _implBonus, _skillLevelIceHBonus _
                                                     , _MinUpgradesBonus, _numOfUpgrades, _skillLevelExh _
                                                     , _skillLevelMinBarge), 0)
            _totalMiningTime = Math.Round(TotalMiningTime(_oreHoldCap, _skillBonusMinBar, _skillLevelMinBarge, _cycleTimeReal _
                                                          , _turretHardpointNo), 0)
            '-----------------------------displays various informations in Main form
            Me.lblSelShipNameDisp.Text = _shipName
            Me.lblHarvCycleTimeDisp.Text = Convert.ToString(_cycleTimeReal) & " seconds"
            Me.lblTimeToMineDisp.Text = TimeToMineDisplay(_totalMiningTime)
            Me.prgrBar01.Maximum = _totalMiningTime
        End If
    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        Timer1.Enabled = True
        prgrBar01.Visible = True
        btnStart.Enabled = False
        btnStart.Enabled = False

    End Sub

    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        Timer1.Enabled = False
        btnStart.Enabled = True

    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        Timer1.Enabled = False
        btnStart.Enabled = True
        cntrSec = 0
        cntrMin = 0
        cntrHour = 0
        strMin = "00"
        strHour = "00"
        strSec = "00"
        lblTimeShow.Text = "--:--:--"
        prgrBar01.Value = 0
        prgrBarCntr = 0


    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        My.Forms.AboutBox1.Show()
    End Sub
End Class
