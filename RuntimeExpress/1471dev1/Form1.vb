﻿'开发手记
'1.完善筛选器（Java,XML,Game Runtime）
'2.添加文件夹校验
Imports System.Net
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Form1

    Private Sub InstNow1_Click(sender As Object, e As EventArgs) Handles InstNow1.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub XNA2_CheckedChanged(sender As Object, e As EventArgs) Handles XNA2.CheckedChanged
        If XNA2.Checked Then
            DX9.Checked = True
            MsgBox("已经自动勾选了所须的DX 9.0c！", MsgBoxStyle.Exclamation, "提示")
        Else : DX9.Enabled = True
        End If
    End Sub

    Private Sub XNA31_CheckedChanged(sender As Object, e As EventArgs) Handles XNA31.CheckedChanged
        If XNA31.Checked Then net35.Checked = True
        If net35.Enabled = False Then
            net35.Checked = False
        Else : MsgBox("已经自动勾选了所需的.net Framework 3.5！", MsgBoxStyle.Exclamation, "提示")
        End If
    End Sub

    Private Sub XNA4_CheckedChanged(sender As Object, e As EventArgs) Handles XNA4.CheckedChanged
        If XNA4.Checked Then net451.Checked = True
        If net451.Enabled = False Then
            net451.Checked = False
        Else : MsgBox("已经自动勾选了所需的.net Framework 4.5.1！", MsgBoxStyle.Exclamation, "提示")
        End If
    End Sub

    Private Sub AutoCheck2_Click(sender As Object, e As EventArgs) Handles AutoCheck2.Click
        Dim OSver As String
        OSver = ScreenRE1.SelectedItem.ToString.Trim

        '重置复选框状态
        VC20051.Checked = False
        VC20052.Checked = False
        VC20081.Checked = False
        VC20082.Checked = False
        VC20101.Checked = False
        VC20102.Checked = False
        VC20121.Checked = False
        VC20122.Checked = False
        VC20131.Checked = False
        VC20132.Checked = False
        net35.Checked = False
        net451.Checked = False
        Java71.Checked = False
        Java72.Checked = False
        XNA2.Checked = False
        XNA31.Checked = False
        XNA4.Checked = False
        DX9.Checked = False
        oal203.Checked = False
        mgfw.Checked = False
        mwse.Checked = False
        physx912.Checked = False
        '重置所有复选框选择状态
        VC20051.Enabled = False
        VC20052.Enabled = False
        VC20081.Enabled = False
        VC20082.Enabled = False
        VC20101.Enabled = False
        VC20102.Enabled = False
        VC20121.Enabled = False
        VC20122.Enabled = False
        VC20131.Enabled = False
        VC20132.Enabled = False
        net35.Enabled = False
        net451.Enabled = False
        Java71.Enabled = False
        Java72.Enabled = False
        XNA2.Enabled = False
        XNA31.Enabled = False
        XNA4.Enabled = False
        DX9.Enabled = False
        oal203.Enabled = False
        mgfw.Enabled = False
        mwse.Enabled = False
        physx912.Enabled = False
        '重置所有复选框可用状态

        '判断语句块：这个系统支持哪些运行库？
        If OSver = "Windows XP x86" Then
            VC20051.Enabled = True
            VC20052.Enabled = False
            VC20081.Enabled = True
            VC20082.Enabled = False
            VC20101.Enabled = True
            VC20102.Enabled = False
            VC20121.Enabled = True
            VC20122.Enabled = False
            VC20131.Enabled = True
            VC20132.Enabled = False
            net35.Enabled = True
            net451.Enabled = False
            '禁用不适合的选项
        ElseIf OSver = "Windows Vista x86" Then
            VC20051.Enabled = True
            VC20052.Enabled = False
            VC20081.Enabled = True
            VC20082.Enabled = False
            VC20101.Enabled = True
            VC20102.Enabled = False
            VC20121.Enabled = True
            VC20122.Enabled = False
            VC20131.Enabled = True
            VC20132.Enabled = False
            net35.Enabled = True
            net451.Enabled = True
            '禁用不适合的选项
        ElseIf OSver = "Windows Vista x64" Then
            VC20051.Enabled = True
            VC20052.Enabled = True
            VC20081.Enabled = True
            VC20082.Enabled = True
            VC20101.Enabled = True
            VC20102.Enabled = True
            VC20121.Enabled = True
            VC20122.Enabled = True
            VC20131.Enabled = True
            VC20132.Enabled = True
            net35.Enabled = True
            net451.Enabled = True
            '禁用不适合的选项
        ElseIf OSver = "Windows 7 x86" Then
            VC20051.Enabled = True
            VC20052.Enabled = False
            VC20081.Enabled = True
            VC20082.Enabled = False
            VC20101.Enabled = True
            VC20102.Enabled = False
            VC20121.Enabled = True
            VC20122.Enabled = False
            VC20131.Enabled = True
            VC20132.Enabled = False
            net35.Enabled = False
            net451.Enabled = True
            '禁用不适合的选项
        ElseIf OSver = "Windows 7 x64" Then
            VC20051.Enabled = True
            VC20052.Enabled = True
            VC20081.Enabled = True
            VC20082.Enabled = True
            VC20101.Enabled = True
            VC20102.Enabled = True
            VC20121.Enabled = True
            VC20122.Enabled = True
            VC20131.Enabled = True
            VC20132.Enabled = True
            net35.Enabled = False
            net451.Enabled = True
            '禁用不适合的选项
        ElseIf OSver = "Windows 8/8.1 x86" Then
            VC20051.Enabled = True
            VC20052.Enabled = False
            VC20081.Enabled = True
            VC20082.Enabled = False
            VC20101.Enabled = True
            VC20102.Enabled = False
            VC20121.Enabled = True
            VC20122.Enabled = False
            VC20131.Enabled = True
            VC20132.Enabled = False
            net35.Enabled = True
            net451.Enabled = True
            '禁用不适合的选项
        ElseIf OSver = "Windows 8/8.1 x64" Then
            VC20051.Enabled = True
            VC20052.Enabled = True
            VC20081.Enabled = True
            VC20082.Enabled = True
            VC20101.Enabled = True
            VC20102.Enabled = True
            VC20121.Enabled = True
            VC20122.Enabled = True
            VC20131.Enabled = True
            VC20132.Enabled = True
            net35.Enabled = True
            net451.Enabled = True
            '禁用不适合的选项
        End If

        '判断语句块：需要勾选吗？要勾选哪些运行库？
        If AutoChk1.Checked Then
            If OSver = "Windows Vista x86" Then
                VC20051.Checked = True
                VC20052.Checked = False
                VC20081.Checked = True
                VC20082.Checked = False
                VC20101.Checked = True
                VC20102.Checked = False
                VC20121.Checked = True
                VC20122.Checked = False
                VC20131.Checked = False
                VC20132.Checked = False
                net35.Checked = True
                net451.Checked = True
                '自动勾选
            ElseIf OSver = "Windows Vista x64" Then
                VC20051.Checked = True
                VC20052.Checked = True
                VC20081.Checked = True
                VC20082.Checked = True
                VC20101.Checked = True
                VC20102.Checked = True
                VC20121.Checked = True
                VC20122.Checked = True
                VC20131.Checked = False
                VC20132.Checked = False
                net35.Checked = True
                net451.Checked = True
                '自动勾选
            ElseIf OSver = "Windows 7 x86" Then
                VC20051.Checked = True
                VC20052.Checked = False
                VC20081.Checked = True
                VC20082.Checked = False
                VC20101.Checked = True
                VC20102.Checked = False
                VC20121.Checked = True
                VC20122.Checked = False
                VC20131.Checked = False
                VC20132.Checked = False
                net35.Checked = False
                net451.Checked = True
                '自动勾选
            ElseIf OSver = "Windows 7 x64" Then
                VC20051.Checked = True
                VC20052.Checked = True
                VC20081.Checked = True
                VC20082.Checked = True
                VC20101.Checked = True
                VC20102.Checked = True
                VC20121.Checked = True
                VC20122.Checked = True
                VC20131.Checked = False
                VC20132.Checked = False
                net35.Checked = False
                net451.Checked = True
                '自动勾选
            ElseIf OSver = "Windows 8/8.1 x86" Then
                VC20051.Checked = True
                VC20052.Checked = False
                VC20081.Checked = True
                VC20082.Checked = False
                VC20101.Checked = True
                VC20102.Checked = False
                VC20121.Checked = True
                VC20122.Checked = False
                VC20131.Checked = False
                VC20132.Checked = False
                net35.Checked = True
                net451.Checked = True
                '自动勾选
            ElseIf OSver = "Windows 8/8.1 x64" Then
                VC20051.Checked = True
                VC20052.Checked = True
                VC20081.Checked = True
                VC20082.Checked = True
                VC20101.Checked = True
                VC20102.Checked = True
                VC20121.Checked = True
                VC20122.Checked = True
                VC20131.Checked = False
                VC20132.Checked = False
                net35.Checked = True
                net451.Checked = True
                '自动勾选
            Else
                MsgBox("请选择一个选项")
            End If
        End If
    End Sub

    Private Sub DllHelper3_Click(sender As Object, e As EventArgs) Handles DllHelper3.Click
        Dim DllBox As String
        DllBox = DllHelper1.SelectedItem.ToString.Trim
        If DllBox = "d3dx9_**.dll" Then
            MsgBox("看起来需要安装或修复DirectX 9c~", MsgBoxStyle.Information, "分析结果")
        ElseIf DllBox = "MSVC**.dll" Then
            MsgBox("看起来需要安装或修复VC++运行库~", MsgBoxStyle.Information, "分析结果")
        ElseIf DllBox = "xinput**.dll" Then
            MsgBox("看起来需要安装或修复DirectX 9c~", MsgBoxStyle.Information, "分析结果")
        ElseIf DllBox = "openal32.dll" Then
            MsgBox("看起来需要安装或修复OpenAL~", MsgBoxStyle.Information, "分析结果")
        ElseIf DllBox = "PhysXLoader.dll" Then
            MsgBox("看起来需要安装或修复PhysX驱动~", MsgBoxStyle.Information, "分析结果")
        ElseIf DllBox = "xlive.dll" Then
            MsgBox("看起来需要安装或修复MGFW~", MsgBoxStyle.Information, "分析结果")
        End If
    End Sub

    Private Sub DllHelper2_Click(sender As Object, e As EventArgs) Handles DllHelper2.Click
        Shell("explorer.exe " & " https://www.google.com.hk")
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        If VC20051.Checked Then System.Diagnostics.Process.Start("uruntime\vc2005_x86.exe").WaitForExit()
        If VC20052.Checked Then System.Diagnostics.Process.Start("uruntime\vc2005_x64.exe").WaitForExit()
        If VC20081.Checked Then System.Diagnostics.Process.Start("uruntime\vc2008_x86.exe").WaitForExit()
        If VC20082.Checked Then System.Diagnostics.Process.Start("uruntime\vc2008_x64.exe").WaitForExit()
        If VC20101.Checked Then System.Diagnostics.Process.Start("uruntime\vc2010_x86.exe").WaitForExit()
        If VC20102.Checked Then System.Diagnostics.Process.Start("uruntime\vc2010_x64.exe").WaitForExit()
        If net35.Checked Then System.Diagnostics.Process.Start("uruntime\dotnet35.exe").WaitForExit()
        If net451.Checked Then System.Diagnostics.Process.Start("uruntime\dotnet451.exe").WaitForExit()
        If Java71.Checked Then System.Diagnostics.Process.Start("uruntime\jre7_x86.exe").WaitForExit()
        If Java72.Checked Then System.Diagnostics.Process.Start("uruntime\jre7_x64.exe").WaitForExit()
        If Java72.Checked Then System.Diagnostics.Process.Start("uruntime\jre7_x64.exe").WaitForExit()
        If jsharp1.Checked Then System.Diagnostics.Process.Start("uruntime\jredist.exe").WaitForExit()
        If fsharp1.Checked Then System.Diagnostics.Process.Start("uruntime\fredist.exe").WaitForExit()
        If DX9.Checked Then System.Diagnostics.Process.Start("gruntime\DX\DXSETUP.exe").WaitForExit()
        If XNA2.Checked Then System.Diagnostics.Process.Start("gruntime\xna20.msi").WaitForExit()
        If XNA31.Checked Then System.Diagnostics.Process.Start("gruntime\xna31.msi").WaitForExit()
        If XNA4.Checked Then System.Diagnostics.Process.Start("gruntime\xna40.msi").WaitForExit()
        If oal203.Checked Then System.Diagnostics.Process.Start("gruntime\openal203.exe").WaitForExit()
        If mgfw.Checked Then System.Diagnostics.Process.Start("gruntime\gfwlive.exe").WaitForExit()
        If physx912.Checked Then System.Diagnostics.Process.Start("gruntime\PhysX-9.13.1220.msi").WaitForExit()
        If mwse.Checked Then System.Diagnostics.Process.Start("gruntime\mwse3.msi").WaitForExit()
        If msxml1.Checked Then System.Diagnostics.Process.Start("gruntime\msxml6.msi").WaitForExit()
        If msxml2.Checked Then System.Diagnostics.Process.Start("gruntime\msxml6_x64.msi").WaitForExit()
        MsgBox("已经完成指定的操作！可能需要重新启动计算机更改才会生效。", MsgBoxStyle.Exclamation, "提示")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        About.Show()
    End Sub
End Class
