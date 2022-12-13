Imports MySql.Data.MySqlClient
Public Class frmSearchOR
    Dim str As String
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        txtSearch.Clear()
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select ORNUmber, Amount, PDate, concat(FirstName,' ',MiddleName,' ',LastName) as Payor, ORStatus, Cashier from paymentsaccounts where ORNumber like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "paymentaccounts")
            dg1.DataSource = ds.Tables("paymentaccounts")
            conn.Close()

            dg1.Columns(0).Width = 90
            dg1.Columns(0).HeaderText = "O.R. No."
            dg1.Columns(2).HeaderText = "Date"
            dg1.Columns(3).Width = 200
            dg1.Columns(4).HeaderText = "O.R. Status"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmSearchOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select ORNUmber, Amount, PDate, concat(FirstName,' ',MiddleName,' ',LastName) as Payor, ORStatus, Cashier from paymentsaccounts"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "paymentaccounts")
            dg1.DataSource = ds.Tables("paymentaccounts")
            conn.Close()

            dg1.Columns(0).Width = 90
            dg1.Columns(0).HeaderText = "O.R. No."
            dg1.Columns(2).HeaderText = "Date"
            dg1.Columns(3).Width = 200
            dg1.Columns(4).HeaderText = "O.R. Status"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class