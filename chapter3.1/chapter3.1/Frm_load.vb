﻿Public Class Frm_load
    Private Sub Btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_new.Click
        If Creo_New() <> True Then
            MsgBox("无法新建CREO对话！")
        Else
            Btn_addParam.Enabled = True
            Btn_delParam.Enabled = True
            Btn_modParam.Enabled = True
        End If
    End Sub

    Private Sub Btn_Connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Connect.Click
        If Creo_Connect() <> True Then
            MsgBox("无法连接到CREO对话！")
        Else
            Btn_addParam.Enabled = True
            Btn_delParam.Enabled = True
            Btn_modParam.Enabled = True
        End If
    End Sub

    Private Sub Btn_addParam_Click(sender As Object, e As EventArgs) Handles Btn_addParam.Click
        AddParam(Tb_paramNameAdd.Text, Tb_paramValueAdd.Text, Cmb_paramTypeAdd.Text)
    End Sub

    Private Sub Btn_delParam_Click(sender As Object, e As EventArgs) Handles Btn_delParam.Click
        DelParam(Tb_paramNameDel.Text)
    End Sub

    Private Sub Btn_modParam_Click(sender As Object, e As EventArgs) Handles Btn_modParam.Click
        ModParam(Tb_paramNameMod.Text, Tb_paramValueMod.Text, Cmb_paramTypeMod.Text)
    End Sub
End Class
