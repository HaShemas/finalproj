﻿
Public Class Login
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim user, pass As String
        user = txtuser.Text
        pass = txtpass.Text
        User_Mod.Login_User(user, pass)
        If user = "" Then
            MessageBox.Show("Please enter username")
            txtuser.Focus()
            Exit Sub
        ElseIf pass = "" Then
            MessageBox.Show("Please enter password")
            txtpass.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub Createlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Createlink.LinkClicked
        Create_Acc.Show()
        Create_Acc.btnupd.Visible = False
        Me.Hide()
        txtuser.Clear()
        txtpass.Clear()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySQL_Open_Connection()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtpass.PasswordChar = ""
        Else
            txtpass.PasswordChar = "*"
        End If
    End Sub
End Class
