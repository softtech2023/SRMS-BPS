Imports MySql.Data.MySqlClient
Public Class frmBilling
    Dim str As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFees.Click
        frmAddFees.ShowDialog()
    End Sub

    Private Sub frmBilling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lvAccts.Columns.Add("Description", 400)
        lvAccts.Columns.Add("Amount", 100)
        Me.lvAccts.View = View.Details
        Me.lvAccts.GridLines = True


        tsSave.Enabled = False
        tsUpdate.Enabled = False

        Formload()

     
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFees.Click
        Try
            Dim i As Integer

            lvAccts.Select()

            If lvAccts.Items.Count = 0 Then
                MsgBox("Cannot find any date to remove", MsgBoxStyle.Information)
                Exit Sub

            Else
                i = lvAccts.FocusedItem.Index
                lvAccts.Items.RemoveAt(i)
            End If

            btnCompute.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Public Sub getSubTotals()
        Dim SubTotal As Double
        For x As Integer = 0 To lvAccts.Items.Count - 1
            SubTotal += Val(lvAccts.Items(x).SubItems(1).Text)
        Next

        txtTotalFees.Text = Format(SubTotal, "0.00")

    End Sub

    Public Sub getTotalAccount()
        Dim TotalAccount As Double
        TotalAccount = (Val(txtTuition.Text) + Val(txtLab.Text) + Val(txtTotalFees.Text) + Val(txtTotalAdditional.Text) + Val(txtRegFee.Text) + Val(txtInstallmentFee.Text))
        txtTotalAcct.Text = Format(TotalAccount, "0.00")

    End Sub

    Public Sub getBalance()
        Dim Balance As Double
        Balance = (Val(txtTotalAcct.Text) + Val(txtOldAccount.Text)) - (Val(txtPayments.Text) + Val(txtDiscount.Text))
        txtBalance.Text = Format(Balance, "0.00")
    End Sub

    Public Sub getDiscount()
        Dim total As Double
        total = Val(txtDiscAmount1.Text) + Val(txtDiscAmount2.Text) + Val(txtDiscAmount3.Text) + Val(txtDiscAmount4.Text) + Val(txtDiscAmount5.Text)
        lblDiscTotal.Text = Format(total, "0.00")
        txtDiscount.Text = lblDiscTotal.Text
    End Sub

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        getSubTotals()
        'getTuition()
        'getDiscount()
        getTotalAccount()
        getBalance()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SearchAccounts.ShowDialog()
    End Sub

    Private Sub mskStudentNumber_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        SearchAccounts.ShowDialog()
    End Sub

    Private Sub txtTotalLecUnits_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalLecUnits.TextChanged
        ComputeTuition()
    End Sub

    Private Sub txtLecRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLecRate.TextChanged
        ComputeTuition()
    End Sub

    Private Sub txtTotalLabUnits_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalLabUnits.TextChanged
        ComputeLab()
    End Sub

    Private Sub txtLabRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLabRate.TextChanged
        ComputeLab()
    End Sub

    Private Sub txtDiscountPerecentage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getDiscount()
        getBalance()
    End Sub

    Public Sub Formload()
        lvAccts.Items.Clear()
        mskStudentNumber.Clear()
        txtFname.Clear()
        txtMName.Clear()
        txtLastName.Clear()
        cboCourse.ResetText()
        cboYear.ResetText()
        cboStatus.ResetText()
        txtDesc1.Clear()
        txtDesc2.Clear()
        txtDesc3.Clear()
        txtDesc4.Clear()
        txtDesc5.Clear()
        txtAmount1.Text = 0
        txtAmount2.Text = 0
        txtAmount3.Text = 0
        txtAmount4.Text = 0
        txtAmount5.Text = 0
        txtTotalLecUnits.Text = 0
        txtTotalLabUnits.Text = 0
        cboPaymentMode.ResetText()
        txtInstallmentFee.Text = 0
        txtRegFee.Text = 0
        txtTotalAcct.Text = 0
        txtPayments.Text = 0
        txtOldAccount.Text = 0
        txtDiscAmount1.Text = 0
        txtDiscAmount2.Text = 0
        txtDiscAmount3.Text = 0
        txtDiscAmount4.Text = 0
        txtDiscAmount5.Text = 0
        txtBalance.Text = 0
        txtOldAccount.Text = 0
        txtTotalFees.Text = 0
        txtTotalAcct.Text = 0
        txtBalance.Text = 0

        txtDisc1.Clear()
        txtDisc2.Clear()
        txtDisc3.Clear()
        txtDisc4.Clear()
        txtDisc5.Clear()

        tsNew.Enabled = True
        tsSave.Enabled = False
        tsUpdate.Enabled = False
        tsDelete.Enabled = False

        schoolInfo()

        btnCompute.PerformClick()


    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPayment.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSearchBilling.ShowDialog()
    End Sub

    Private Sub NewAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SearchAccounts.ShowDialog()
    End Sub
    Private Sub txtTuition_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTuition.TextChanged
        getTotalAccount()
    End Sub

    Private Sub txtLab_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLab.TextChanged
        getTotalAccount()
    End Sub
    Public Sub ComputeTuition()
        Dim tuitionfee As Double

        tuitionfee = (Val(txtTotalLecUnits.Text) * Val(txtLecRate.Text))
        txtTuition.Text = Format(tuitionfee, "0.0")
    End Sub
    Public Sub ComputeLab()
        Dim labfee As Double
        labfee = Val(txtTotalLabUnits.Text) * Val(txtLabRate.Text)
        txtLab.Text = Format(labfee, "0.0")
    End Sub

    Private Sub txtTotalAcct_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalAcct.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtTotalAcct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalAcct.TextChanged
        getBalance()
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getBalance()
    End Sub
    Public Sub getAdditionalFees()
        Dim total As Double
        total = Val(txtAmount1.Text) + Val(txtAmount2.Text) + Val(txtAmount3.Text) + Val(txtAmount4.Text) + Val(txtAmount5.Text)
        txtTotalAdditional.Text = Format(total, "0.0")

    End Sub

    Private Sub txtAmount1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount1.TextChanged
        getAdditionalFees()
        getTotalAccount()
    End Sub

    Private Sub txtAmount2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount2.TextChanged
        getAdditionalFees()
        getTotalAccount()
    End Sub

    Private Sub txtAmount3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount3.TextChanged
        getAdditionalFees()
        getTotalAccount()
    End Sub

    Private Sub txtAmount4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount4.TextChanged
        getAdditionalFees()
        getTotalAccount()
    End Sub

    Private Sub txtAmount5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount5.TextChanged
        getAdditionalFees()
        getTotalAccount()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOldAcct.Click
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, b.LecUnits, b.LecRate, b.LabUnits, b.LabRate, b.OldAccount, TotalLec, b.TotalLab, b.FeesDesc, b.FeesAmount, b.TotalFees, b.AcctTotal, b.Discount, b.CurrentBalance, b.TotalPayments, b.DiscPercentage, b.Sem, b.SY, b.AccountID from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber where p.StudentNumber='" & mskStudentNumber.Text & "' order by b.AccountID desc limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtOldAccount.Text = Format(dtReader.Item(14), "0.0")
            End If
            conn.Close()

            btnCompute.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lvAccts.Clear()
    End Sub
    Private Sub txtRegFee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRegFee.TextChanged
        getTotalAccount()
    End Sub
    Private Sub txtNSTP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ComputeTuition()
    End Sub
    Private Sub txtNSTPRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ComputeTuition()
    End Sub
    Private Sub mskStudentNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mskStudentNumber.TextChanged
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select p.StudentNumber, sum(r.LecUnit), sum(r.LabUnit), r.SY, r.Sem from studeprofile p join registration r on p.StudentNumber=r.StudentNumber where p.StudentNumber='" & mskStudentNumber.Text & "' and r.SY='" & frmParent.lblSY.Text & "' and r.Sem='" & frmParent.lblSem.Text & "' group by r.StudentNumber"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtTotalLecUnits.Text = dtReader.Item(1)
                txtTotalLabUnits.Text = dtReader.Item(2)

            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub tsNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsNew.Click
        lvAccts.Items.Clear()
        Formload()
        SearchAccounts.ShowDialog()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try

            If mskStudentNumber.Text = "" Then
                MsgBox("Student No. is missing!", MsgBoxStyle.Information)
                mskStudentNumber.Focus()
                Exit Sub
            End If

            str = "select * from studeaccount where StudentNumber like '" & mskStudentNumber.Text & "%' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysDA1 As New MySqlDataAdapter(str, conn)
            Dim ds1 As New DataSet

            mysDA1.Fill(ds1, "studeaccount")

            If ds1.Tables("studeaccount").Rows.Count > 0 Then

                MsgBox("Cannot save this account.  Student number already exist!", MsgBoxStyle.Critical)
                conn.Close()
                Exit Sub

            End If

            conn.Close()
            'str = "delete from studeaccount where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & Me.lblSem.Text & "' and SY='" & Me.lblSY.Text & "'"
            'conn.Open()
            'Dim mysc1 As New MySqlCommand(str, conn)
            'mysc1.ExecuteNonQuery()
            'conn.Close()

            If lvAccts.Items.Count = 0 Then
                MsgBox("No Fees Added!", MsgBoxStyle.Critical)
                Exit Sub
            End If


            For i As Integer = 0 To lvAccts.Items.Count - 1
                str = "insert into studeaccount values('0','" & mskStudentNumber.Text & "','" & txtFname.Text & "','" & txtMName.Text & "','" & txtLastName.Text & "','" & cboCourse.Text & "','" & cboYear.Text & "','" & cboStatus.Text & "','" & txtTotalLecUnits.Text & "','" & txtLecRate.Text & "','" & txtTuition.Text & "','" & txtTotalLabUnits.Text & "','" & txtLabRate.Text & "','" & txtLab.Text & "','" & txtOldAccount.Text & "','" & lvAccts.Items(i).SubItems(0).Text.Replace("'", "''") & "','" & lvAccts.Items(i).SubItems(1).Text & "','" & txtTotalFees.Text & "','" & txtDiscountPercentage.Text & "','" & txtDiscount.Text & "','" & txtTotalAcct.Text & "','" & txtPayments.Text & "','" & txtBalance.Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "','" & txtDesc1.Text & "','" & txtAmount1.Text & "','" & txtDesc2.Text & "','" & txtAmount2.Text & "','" & txtDesc3.Text & "','" & txtAmount3.Text & "','" & txtDesc4.Text & "','" & txtAmount4.Text & "','" & txtDesc5.Text & "','" & txtAmount5.Text & "','" & txtRegFee.Text & "','" & txtSection.Text & "','" & cboPaymentMode.Text & "','" & txtDisc1.Text & "','" & txtDiscAmount1.Text & "','" & txtDisc2.Text & "','" & txtDiscAmount2.Text & "','" & txtDisc3.Text & "','" & txtDiscAmount3.Text & "','" & txtDisc4.Text & "','" & txtDiscAmount4.Text & "','" & txtDisc5.Text & "','" & txtDiscAmount5.Text & "','" & lblSettingsID.Text & "')"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()
            Next

            MsgBox("Record Saved!!", MsgBoxStyle.Information)

            Formload()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            str = "delete from studeaccount where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            str = "select * from studeaccount where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeaccount")

            If ds.Tables("studeaccount").Rows.Count = 1 Then
                MsgBox("Student Number already exist!", MsgBoxStyle.Information)
                conn.Close()
                mskStudentNumber.Focus()
                Exit Sub
            End If
            conn.Close()

            If mskStudentNumber.Text = "" Then
                MsgBox("Student No. is missing!", MsgBoxStyle.Information)
                mskStudentNumber.Focus()
                Exit Sub
            End If

            For i As Integer = 0 To lvAccts.Items.Count - 1
                str = "insert into studeaccount values('0','" & mskStudentNumber.Text & "','" & txtFname.Text & "','" & txtMName.Text & "','" & txtLastName.Text & "','" & cboCourse.Text & "','" & cboYear.Text & "','" & cboStatus.Text & "','" & txtTotalLecUnits.Text & "','" & txtLecRate.Text & "','" & txtTuition.Text & "','" & txtTotalLabUnits.Text & "','" & txtLabRate.Text & "','" & txtLab.Text & "','" & txtOldAccount.Text & "','" & lvAccts.Items(i).SubItems(0).Text.Replace("'", "''") & "','" & lvAccts.Items(i).SubItems(1).Text & "','" & txtTotalFees.Text & "','" & txtDiscountPercentage.Text & "','" & txtDiscount.Text & "','" & txtTotalAcct.Text & "','" & txtPayments.Text & "','" & txtBalance.Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "','" & txtDesc1.Text & "','" & txtAmount1.Text & "','" & txtDesc2.Text & "','" & txtAmount2.Text & "','" & txtDesc3.Text & "','" & txtAmount3.Text & "','" & txtDesc4.Text & "','" & txtAmount4.Text & "','" & txtDesc5.Text & "','" & txtAmount5.Text & "','" & txtRegFee.Text & "','" & txtSection.Text & "','" & cboPaymentMode.Text & "','" & txtDisc1.Text & "','" & txtDiscAmount1.Text & "','" & txtDisc2.Text & "','" & txtDiscAmount2.Text & "','" & txtDisc3.Text & "','" & txtDiscAmount3.Text & "','" & txtDisc4.Text & "','" & txtDiscAmount4.Text & "','" & txtDisc5.Text & "','" & txtDiscAmount5.Text & "','" & lblSettingsID.Text & "')"
                conn.Open()
                Dim mysC1 As New MySqlCommand(str, conn)
                mysC1.ExecuteNonQuery()
                conn.Close()
            Next
            MsgBox("Record Saved!!", MsgBoxStyle.Information)
            Formload()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsViewAccounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsViewAccounts.Click
        Try
            Formload()
            lvAccts.Items.Clear()
            frmSearchBilling.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        tsNew.PerformClick()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        tsSave.PerformClick()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        tsUpdate.PerformClick()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem.Click
        tsViewAccounts.PerformClick()
    End Sub
    Public Sub LoadFees()
        Try
            Dim dt As New DataTable
            str = "SELECT * FROM fees where Course='" & cboCourse.Text & "' and YearLevel='" & cboYear.Text & "' and Major='" & lblMajor.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            mysda.Fill(dt)
            Dim newrow As DataRow
            For Each newrow In dt.Rows
                lvAccts.Items.Add(newrow.Item(1)) '
                lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add(newrow.Item(2))
            Next
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub CourseFees()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from coursefees where Course='" & cboCourse.Text & "' and Major='" & lblMajor.Text & "' "
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtLecRate.Text = dtReader.Item(3)
                txtLabRate.Text = dtReader.Item(4)
            End If
            conn.Close()

            btnCompute.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub LoadAcct()
        Try

            Dim dt As New DataTable
            str = "SELECT * FROM studeaccount where StudentNumber='" & mskStudentNumber.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            mysda.Fill(dt)
            Dim newrow As DataRow
            For Each newrow In dt.Rows
                lvAccts.Items.Add(newrow.Item(15)) '
                lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add(newrow.Item(16))
            Next
            conn.Close()
            btnCompute.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this account?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from studeaccount where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()

                MsgBox("Selected account has been deleted!", MsgBoxStyle.Information)
                conn.Close()
                Formload()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub cboPaymentMode_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPaymentMode.SelectedIndexChanged
        Try
            'Dim plan As Double
            '  str = "select * from installmentfee where Course='" & cboCourse.Text & "' and YearLevel='" & cboYear.Text & "' and Plan='" & cboPaymentMode.Text & "'"
            ' conn.Open()
            ' Dim mysC As New MySqlCommand(str, conn)
            ' Dim mysDR As MySqlDataReader = mysC.ExecuteReader

            '  While mysDR.Read
            'totalpayment += Val(mysDR(7))
            'plan = Val(mysDR(4))
            '  End While
            '  txtInstallmentFee.Text = Format(plan, "00.00")

            ' mysDR.Close()
            ' conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub txtInstallmentFee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInstallmentFee.TextChanged
        getTotalAccount()
    End Sub

    Private Sub txtDiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscount.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtDiscount_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged
        getTotalAccount()
        getBalance()
    End Sub

    Private Sub txtDiscAmount1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscAmount1.TextChanged
        getDiscount()
    End Sub

    Private Sub txtDiscAmount2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscAmount2.TextChanged
        getDiscount()
    End Sub

    Private Sub txtDiscAmount3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscAmount3.TextChanged
        getDiscount()
    End Sub

    Private Sub txtDiscAmount4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscAmount4.TextChanged
        getDiscount()
    End Sub

    Private Sub txtDiscAmount5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscAmount5.TextChanged
        getDiscount()
    End Sub

    Private Sub lblDiscTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDiscTotal.Click
        getDiscount()
    End Sub
    Public Sub schoolInfo()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from srms_settings limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblSettingsID.Text = dtReader(0)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub txtTotalFees_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalFees.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtOldAccount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOldAccount.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

End Class