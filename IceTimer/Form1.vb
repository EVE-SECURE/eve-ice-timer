﻿Public Class fMain
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


    Private Sub RelevantSkillsAndEquipmentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RelevantSkillsAndEquipmentToolStripMenuItem.Click
        My.Forms.fSettings.ShowDialog()
    End Sub

    Private Sub EndToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EndToolStripMenuItem.Click
        End
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If cntrSec < 60 And cntrSec < 9 Then
            cntrSec += 1
            sec = cntrSec
            strSec = "0" & CStr(sec)
        ElseIf cntrSec < 60 And cntrSec >= 9 Then
            cntrSec += 1
            sec = cntrSec
            strSec = CStr(sec)

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
        prgrBarCntr += 1
        lblTimeShow.Text = strHour & ":" & strMin & ":" & strSec
        prgrBar01.Value = prgrBarCntr

    End Sub

    Private Sub fMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        strMin = "00"
        strHour = "00"
        lblTimeShow.Text = "--:--:--"
        prgrBar01.Visible = False
        prgrBar01.Minimum = 0



    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        Timer1.Enabled = True
        prgrBar01.Visible = True
        btnStart.Enabled = False

    End Sub

    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        Timer1.Enabled = False
        btnStart.Enabled = True

    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        Timer1.Enabled = False
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

End Class
