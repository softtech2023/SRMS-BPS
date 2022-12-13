Imports MySql.Data.MySqlClient
Public Class frmSearchORforVoid
    Dim str As String
    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select ID, ORNUmber, Amount, PDate, concat(FirstName,' ',MiddleName,' ',LastName) as Payor, Description, Cashier, StudentNumber from paymentsaccounts where ORNumber like '%" & txtSearch.Text & "%' and ORStatus='Valid'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "paymentaccounts")
            dg1.DataSource = ds.Tables("paymentaccounts")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 90
            dg1.Columns(1).HeaderText = "O.R. No."
            dg1.Columns(2).HeaderText = "Date"

            dg1.Columns(4).Width = 200
            dg1.Columns(5).Visible = False
            dg1.Columns(6).Visible = False
            dg1.Columns(7).Visible = False


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        frmVoidOR.lblID.Text = dg1.Item(0, i).Value
        frmVoidOR.txtORNumber.Text = dg1.Item(1, i).Value
        frmVoidOR.txtAmount.Text = dg1.Item(2, i).Value
        frmVoidOR.dtpDatePaid.Text = dg1.Item(3, i).Value
        frmVoidOR.txtParticulars.Text = dg1.Item(4, i).Value
        frmVoidOR.txtCashier.Text = dg1.Item(6, i).Value
        frmVoidOR.lblStudentNumber.Text = dg1.Item(7, i).Value
        frmVoidOR.tsSave.Enabled = True

        Dim totalpayment, totalAccount, discount As Double
        'Get Total Payments
        str = "select * from paymentsaccounts where StudentNumber='" & frmVoidOR.lblStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and ORStatus='Valid'"
        conn.Open()
        Dim mysC As New MySqlCommand(str, conn)
        Dim mysDR As MySqlDataReader = mysC.ExecuteReader

        While mysDR.Read
            totalpayment += Val(mysDR(7))
        End While

        frmVoidOR.txtCurrentPayments.Text = Format(totalpayment, "00.00")

        mysDR.Close()
        conn.Close()

        ' Get the Total Account
        str = "select * from studeaccount where StudentNumber='" & frmVoidOR.lblStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' group by AcctTotal"
        conn.Open()
        Dim mysC2 As New MySqlCommand(str, conn)
        Dim mysDR2 As MySqlDataReader = mysC2.ExecuteReader

        While mysDR2.Read
            totalAccount = Val(mysDR2(13))
            discount = Val(mysDR2(12))
        End While

        frmVoidOR.txtTotalAccts.Text = Format(totalAccount, "00.00")
        frmVoidOR.txtDiscount.Text = Format(discount, "00.00")
        mysDR2.Close()
        conn.Close()

        txtSearch.Clear()

        Me.Close()
    End Sub

    Private Sub frmSearchORforVoid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select ID, ORNUmber, Amount, PDate, concat(FirstName,' ',MiddleName,' ',LastName) as Payor, Description, Cashier, StudentNumber from paymentsaccounts where ORStatus='Valid'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "paymentaccounts")
            dg1.DataSource = ds.Tables("paymentaccounts")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 90
            dg1.Columns(1).HeaderText = "O.R. No."
            dg1.Columns(2).HeaderText = "Date"

            dg1.Columns(4).Width = 200
            dg1.Columns(5).Visible = False
            dg1.Columns(6).Visible = False
            dg1.Columns(7).Visible = False


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class