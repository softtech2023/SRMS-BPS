Imports MySql.Data.MySqlClient
Public Class frmEditPayments
    Dim str As String

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmEditPayments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select * from paymentsaccounts where CollectionSource='Student\'s Account' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "paymentsaccounts")
            dgStudeAccounts.DataSource = ds.Tables("paymentsaccounts")
            conn.Close()
            dgStudeAccounts.Columns(0).Visible = False
            dgStudeAccounts.Columns(11).Visible = False
            dgStudeAccounts.Columns(12).Visible = False
            dgStudeAccounts.Columns(14).Visible = False


        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from paymentsaccounts where LastName like '%" & txtSearch.Text & "%' or ORNumber like '%" & txtSearch.Text & "%' and CollectionSource='Student\'s Account' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "paymentsaccounts")
            dgStudeAccounts.DataSource = ds.Tables("paymentsaccounts")
            conn.Close()
            dgStudeAccounts.Columns(0).Visible = False
            dgStudeAccounts.Columns(11).Visible = False
            dgStudeAccounts.Columns(12).Visible = False
            dgStudeAccounts.Columns(14).Visible = False


        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub dgStudeAccounts_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgStudeAccounts.DoubleClick
        Dim i As Integer
        i = dgStudeAccounts.CurrentRow.Index
        frmPayment.lblPaymentID.Text = dgStudeAccounts.Item(0, i).Value
        frmPayment.mskStudentNumber.Text = dgStudeAccounts.Item(1, i).Value
        frmPayment.txtFname.Text = dgStudeAccounts.Item(2, i).Value
        frmPayment.txtMName.Text = dgStudeAccounts.Item(3, i).Value
        frmPayment.txtLastName.Text = dgStudeAccounts.Item(4, i).Value
        'frmPayment.dtpPaymentDate.Text = dgStudeAccounts.Item(5, i).Value
        frmPayment.txtOR.Text = dgStudeAccounts.Item(6, i).Value
        frmPayment.txtAmount.Text = dgStudeAccounts.Item(7, i).Value
        frmPayment.txtDescription.Text = dgStudeAccounts.Item(8, i).Value


        Dim totalpayment, totalAccount As Double
        'Get Total Payments
        str = "select * from paymentsaccounts where StudentNumber='" & frmPayment.mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and ORStatus='Valid'"
        conn.Open()
        Dim mysC As New MySqlCommand(str, conn)
        Dim mysDR As MySqlDataReader = mysC.ExecuteReader

        While mysDR.Read
            totalpayment += Val(mysDR(7))
        End While

        frmPayment.txtCurrentPayments.Text = Format(totalpayment, "00.00")

        mysDR.Close()
        conn.Close()

        ' Get the Total Account
        str = "select * from studeaccount where StudentNumber='" & frmPayment.mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' group by AcctTotal"
        conn.Open()
        Dim mysC2 As New MySqlCommand(str, conn)
        Dim mysDR2 As MySqlDataReader = mysC2.ExecuteReader

        While mysDR2.Read
            totalAccount = Val(mysDR2(13))
            'discount = Val(mysDR2(12))
        End While

        frmPayment.txtTotalAccts.Text = Format(totalAccount, "00.00")
        'frmPayment.txtDiscount.Text = Format(discount, "00.00")
        mysDR2.Close()
        conn.Close()

        frmPayment.GroupBox1.Visible = False
        frmPayment.tsSave.Enabled = False
        frmPayment.tsUpdate.Enabled = True
        txtSearch.Clear()
        Me.Close()

    End Sub
End Class