Imports MySql.Data.MySqlClient
Public Class frmVoidOR
    Dim str As String
    Private Sub frmVoidOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub
    Public Sub FormLoad()
        tsSave.Enabled = False
        tsSearch.Enabled = True

        txtORNumber.Clear()
        txtAmount.Text = "0.00"
        dtpDatePaid.Text = Today
        txtParticulars.Clear()
        txtCashier.Clear()
        dtpVoidDate.Text = Today
        txtReasons.Clear()
        txtORNumber.Focus()
        txtTotalAccts.Text = "0.00"
        txtDiscount.Text = "0.00"
        txtCurrentPayments.Text = "0.00"
        txtTotalPayments.Text = "0.00"
    End Sub

    Private Sub tsSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSearch.Click
        frmSearchORforVoid.ShowDialog()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            If txtReasons.Text = "" Then
                MsgBox("Reason is required!", MsgBoxStyle.Exclamation)
                txtReasons.Focus()
                Exit Sub
            End If
            str = "insert into voidreceipts values('0','" & lblID.Text & "','" & txtORNumber.Text & "','" & txtAmount.Text & "','" & Convert.ToDateTime(dtpDatePaid.Text).ToString("yyyy-MM-dd") & "','" & txtParticulars.Text & "','" & txtCashier.Text & "','" & Convert.ToDateTime(dtpVoidDate.Text).ToString("yyyy-MM-dd") & "','" & frmParent.lblUser.Text & "','" & txtReasons.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            'update paymentsaccounts
            str = "update paymentsaccounts set ORStatus='Void' where ORNumber='" & txtORNumber.Text & "'"
            conn.Open()
            Dim mysc2 As New MySqlCommand(str, conn)
            mysc2.ExecuteNonQuery()
            conn.Close()

            'update billing
            str = "update studeaccount set StudentNumber='" & lblStudentNumber.Text & "',AcctTotal='" & txtTotalAccts.Text & "',TotalPayments='" & txtTotalPayments.Text & "',CurrentBalance='" & txtBalance.Text & "' where StudentNumber='" & lblStudentNumber.Text & "' and SY='" & frmParent.lblSY.Text & "' and Sem='" & frmParent.lblSem.Text & "'"
            conn.Open()
            Dim mysC3 As New MySqlCommand(str, conn)
            mysC3.ExecuteNonQuery()
            MsgBox("Record saved!", MsgBoxStyle.Information)
            conn.Close()

            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub CurrentBalance()
        Dim balance As Double
        balance = Val(txtTotalAccts.Text) - ((Val(txtTotalPayments.Text) + Val(txtDiscount.Text)))
        txtBalance.Text = Format(balance, "00.00")
    End Sub
    Public Sub getTotalPayments()
        Dim totalpayments As Double
        totalpayments = Val(txtCurrentPayments.Text) - Val(txtAmount.Text)
        txtTotalPayments.Text = Format(totalpayments, "00.00")
    End Sub

    Private Sub txtTotalAccts_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalAccts.TextChanged
        CurrentBalance()
        getTotalPayments()
    End Sub

    Private Sub txtCurrentPayments_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCurrentPayments.TextChanged
        CurrentBalance()
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged
        CurrentBalance()
    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged
        getTotalPayments()
        CurrentBalance()
    End Sub
End Class