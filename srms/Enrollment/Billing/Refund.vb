Imports MySql.Data.MySqlClient
Public Class frmStudeRefund
    Dim str As String
    Private Sub frmRefund_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select ORNumber, PDate, Amount, FirstName, LastName, ID from paymentsaccounts order by PDate desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "paymentsaccounts")
            dg.DataSource = ds.Tables("paymentsaccounts")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select ORNumber, PDate, Amount, FirstName, LastName, ID from paymentsaccounts where ORNumber like '%" & txtSearch.Text & "%' order by PDate desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "paymentsaccounts")
            dg.DataSource = ds.Tables("paymentsaccounts")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        Dim i As Integer
        i = dg.CurrentRow.Index
        lblID.Text = dg.Item(5, i).Value
        txtOR.Text = dg.Item(0, i).Value
        txtAmount.Text = dg.Item(2, i).Value
    End Sub

    Private Sub btnRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefund.Click
        Try
            str = "insert into refund values('0','" & lblID.Text & "','" & txtOR.Text & "','" & txtAmount.Text & "','" & Convert.ToDateTime(dtpDateIssued.Text).ToString("yyyy-MM-dd") & "','" & txtPercentage.Text & "','" & txtAmountRefunded.Text & "','" & txtReasons.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Refund information has been saved!", MsgBoxStyle.Information)
            conn.Close()
            ClearFields()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub ClearFields()
        txtOR.Clear()
        txtAmount.Clear()
        dtpDateIssued.Text = Today
        txtPercentage.Clear()
        txtAmountRefunded.Clear()
        txtReasons.Clear()
    End Sub
End Class