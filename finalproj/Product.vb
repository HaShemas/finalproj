﻿

Imports MySql.Data.MySqlClient

Public Class Product

    Public Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Create_Prod.btnupd.Visible = False
        Create_Prod.Show()
        Ret_ID()
        Me.Close()

        'Me.Refresh()
        'dgvRecords.AllowUserToAddRows = True
        dgvRecords.AllowUserToAddRows = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        MySQL_Open_Connection()
        Create_Prod.btncreate.Visible = False
        Create_Prod.txtsku.ReadOnly = True
        Create_Prod.Show()
        Create_Prod.btnupd.Visible = True
        Me.Close()
        'Me.Refresh()

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySQL_Open_Connection()
        Display_Data()

    End Sub

    Private Sub dgvRecords_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecords.CellClick
        Dim rowIndex As Integer
        rowIndex = dgvRecords.CurrentRow.Index
        Create_Prod.txtpID.Text = dgvRecords.Rows(rowIndex).Cells(0).Value
        Create_Prod.txtpname.Text = dgvRecords.Rows(rowIndex).Cells(1).Value
        Create_Prod.txtdes.Text = dgvRecords.Rows(rowIndex).Cells(2).Value
        Create_Prod.txtsku.Text = dgvRecords.Rows(rowIndex).Cells(3).Value
        Create_Prod.txtsprice.Text = dgvRecords.Rows(rowIndex).Cells(4).Value
        Create_Prod.txtcost.Text = dgvRecords.Rows(rowIndex).Cells(5).Value
        Create_Prod.cmbcat.SelectedItem = dgvRecords.Rows(rowIndex).Cells(6).Value
        Create_Prod.cmbintype.SelectedItem = dgvRecords.Rows(rowIndex).Cells(7).Value
        Create_Prod.cmbstat.SelectedItem = dgvRecords.Rows(rowIndex).Cells(8).Value
        'Create_Prod.txtusID.Text = dgvRecords.Rows(rowIndex).Cells(9).Value



    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id As Integer
        id = Create_Prod.txtpID.Text
        Delete_Data(id)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim id As Integer
        id = txtsID.Text
        Display_Search(id)

    End Sub

    Private Sub dgvRecords_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecords.CellContentClick

    End Sub

    Private Sub btnvall_Click(sender As Object, e As EventArgs) Handles btnvall.Click
        AllData.Show()
        AllData.dgvRecords2.ReadOnly = True
        AllData.dgvRecords2.AllowUserToAddRows = False
        Me.Close()
    End Sub

    Private Sub BtnLog_Click(sender As Object, e As EventArgs) Handles BtnLog.Click
        Login.txtuser.Clear()
        Login.txtpass.Clear()
        Login.Show()
        Me.Close()
        MessageBox.Show("Logged Out Successfully!")

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Display_Data()
        txtsID.Clear()

    End Sub
End Class