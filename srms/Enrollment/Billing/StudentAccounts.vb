Imports MySql.Data.MySqlClient
Public Class frmStudentAccounts
    Dim str As String

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmSearchBilling.Show()
    End Sub
    Public Sub gettotalpayments()
        Dim totalpayment As Double

        str = "select * from payments where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmMDIParent.lblSem.Text & "' and SY='" & frmMDIParent.lblSY.Text & "'"
        conn.Open()
        Dim mysC As New MySqlCommand(str, conn)
        Dim mysDR As MySqlDataReader = mysC.ExecuteReader

        While mysDR.Read
            totalpayment += Val(mysDR(7))
        End While

        txtPayments.Text = totalpayment
        mysDR.Close()
        conn.Close()
        gettotalpayments()

    End Sub

    Public Sub ClearFields()
        mskStudentNumber.Clear()
        txtFname.Clear()
        txtMName.Clear()
        txtLastName.Clear()
        cboCourse.ResetText()
        cboYear.ResetText()
        cboStatus.ResetText()
        txtPBalance.Clear()
        txtTuition.Clear()
        txtLab.Clear()
        txtMisc.Clear()
        txtTotalAcct.Clear()
        txtDiscount.Clear()
        txtCurrentBalance.Clear()
        txtPayments.Clear()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        str = "select * from billing"
        'where billingID='" & lblID.Text & "'"
        conn.Open()
        Dim mysda As New MySqlDataAdapter(str, conn)
        Dim ds As New DataSet
        mysda.Fill(ds, "billing")

        If ds.Tables("billing").Rows.Count = 1 Then
            MsgBox("Student Number already exist!", MsgBoxStyle.Information)
            conn.Close()
            mskStudentNumber.Focus()
            Exit Sub
        End If
        If mskStudentNumber.Text = "" Or txtFname.Text = "" Or txtLastName.Text = "" Or cboCourse.Text = "" Then
            MsgBox("Please fill-up the form completely!", MsgBoxStyle.Information)

            conn.Close()
            Exit Sub
        End If
        conn.Close()

        str = "insert into billing values('0','" & mskStudentNumber.Text & "','" & txtFname.Text & "','" & txtMName.Text & "','" & txtLastName.Text & "','" & cboCourse.Text & "','" & cboYear.Text & "','" & cboStatus.Text & "','" & txtPBalance.Text & "','" & txtTuition.Text & "','" & txtLab.Text & "','" & txtMisc.Text & "','" & txtTotalAcct.Text & "','" & txtDiscount.Text & "','" & txtCurrentBalance.Text & "','" & txtPayments.Text & "')"
        conn.Open()
        Dim mysC As New MySqlCommand(str, conn)
        mysC.ExecuteNonQuery()
        MsgBox("New Student Account has been added!", MsgBoxStyle.Information)


        ClearFields()
        conn.Close()
        'gettotalpayments()

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchAccounts.Show()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If mskStudentNumber.Text = "" Then
            MsgBox("Cannot find any data to update!", MsgBoxStyle.Information, "Prompt")
            mskStudentNumber.Focus()
            Exit Sub
        End If
        str = "update billing set StudentNumber='" & mskStudentNumber.Text & "',FirstName='" & txtFname.Text & "',MiddleName='" & txtMName.Text & "',LastName='" & txtLastName.Text & "',Course='" & cboCourse.Text & "',Year='" & cboYear.Text & "',Status='" & cboStatus.Text & "',PreviousBalance='" & txtPBalance.Text & "',TuitionFee='" & txtTuition.Text & "',LabFee='" & txtLab.Text & "',MiscFee='" & txtMisc.Text & "',TotalAccount='" & txtTotalAcct.Text & "',Discount='" & txtDiscount.Text & "',CurrentAccount='" & txtCurrentBalance.Text & "',TotalPayments='" & txtPayments.Text & "',billingid='" & lblID.Text & "' where billingID='" & lblID.Text & "'"
        conn.Open()
        Dim mysC As New MySqlCommand(str, conn)
        mysC.ExecuteNonQuery()
        MsgBox("Student Account has been updated!", MsgBoxStyle.Information, "Prompt")

        ClearFields()
        conn.Close()
        'gettotalpayments()

    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        If mskStudentNumber.Text = "" Then
            MsgBox("Input Student Number first!", MsgBoxStyle.Critical)
            mskStudentNumber.Focus()
            Exit Sub
        End If
        frmPayment.Show()
    End Sub

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Dim TotalAcct1, currentbal As Double
        TotalAcct1 = Val((txtPBalance.Text) + Val(txtTuition.Text) + Val(txtLab.Text) + Val(txtMisc.Text)) - Val(txtDiscount.Text)
        txtTotalAcct.Text = TotalAcct1
        currentbal = Val(txtTotalAcct.Text) - Val(txtPayments.Text)
        txtCurrentBalance.Text = currentbal
    End Sub
End Class