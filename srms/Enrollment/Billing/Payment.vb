Imports MySql.Data.MySqlClient
Public Class frmPayment
    Dim str As String
    Private Sub frmPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub

    Public Sub FormLoad()
        getDescription()
        mskStudentNumber.Text = frmBilling.mskStudentNumber.Text
        txtFname.Text = frmBilling.txtFname.Text
        txtMName.Text = frmBilling.txtMName.Text
        txtLastName.Text = frmBilling.txtLastName.Text

        tsSave.Enabled = True
        tsUpdate.Enabled = False

        mskStudentNumber.Clear()
        txtFname.Clear()
        txtMName.Clear()
        txtLastName.Clear()
        txtAmount.Text = 0.0
        txtAddress.Clear()
        txtcheck.Clear()
        txtOR.Clear()
        txtTotalAccts.Text = 0.0
        txtCurrentPayments.Text = 0.0
        txtTotalPayments.Text = 0.0
        txtBalance.Text = 0.0

        'txtDiscount.Text = 0.0
        txtDescription.ResetText()
        mskStudentNumber.Focus()

        RadioButtonCash.Checked = True
        txtBalance.Enabled = False
        Try
            'Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            'str = "select ORNumber from paymentsaccounts order by ORNumber desc limit 1"
            'conn.Open()
            'Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            'objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            'dtReader = objCmd.ExecuteReader()
            'If dtReader.Read Then
            'txtOR.Text = dtReader.Item(0).ToString
            ' txtOR.Text = txtOR.Text + 1
            ' End If
            'conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Public Sub getDescription()
        Try
            str = "select * from fees group by Description order by Description"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "fees")

            txtDescription.ValueMember = "fees"
            txtDescription.DisplayMember = "Description"
            txtDescription.DataSource = ds.Tables("fees")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub rdoCheck_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButtonCheck.Click
        txtcheck.Enabled = True
        txtcheck.Focus()
        txtBank.Enabled = True
    End Sub
    Private Sub rdocash_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButtonCash.Click
        txtcheck.Enabled = False
        txtcheck.Clear()
        txtBank.Clear()
        txtBalance.Enabled = False
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim radiobutton As String
        radiobutton = ""
        If RadioButtonCash.Checked = True Then
            radiobutton = "Cash"
        End If
        If RadioButtonCheck.Checked = True Then
            radiobutton = "Check"
        End If

        If txtOR.Text = "" Then
            MsgBox("Please enter OR Number!", MsgBoxStyle.Information)
            txtOR.Focus()
            Exit Sub
        End If
        If txtAmount.Text = "" Then
            MsgBox("Please enter correct amount!", MsgBoxStyle.Information)
            txtAmount.Focus()
            Exit Sub
        End If

        Try
            str = "insert into payments values('0','" & mskStudentNumber.Text & "','" & txtFname.Text & "','" & txtMName.Text & "','" & txtLastName.Text & "','" & dtpPaymentDate.Text & "','" & txtOR.Text & "','" & txtAmount.Text & "','" & radiobutton & "','" & txtcheck.Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "','" & txtAddress.Text & "','" & frmParent.lblTerm.Text & "')"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            MsgBox("Payment has been acknowledged!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
        frmBilling.getTotalAccount()
        frmBilling.getBalance()
        frmBilling.tsUpdate.PerformClick()
    End Sub

    Private Sub ViewPaymentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmEditPayments.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskStudentNumber.Click
        frmSearchAccountforPayments.ShowDialog()
    End Sub
    Public Sub CurrentBalance()
        Dim balance As Double
        balance = Val(txtTotalAccts.Text) - (Val(txtAmount.Text) + Val(txtCurrentPayments.Text) + Val(txtDiscount.Text))
        txtBalance.Text = Format(balance, "00.00")
    End Sub
    Public Sub getTotalPayments()
        Dim totalpayments As Double
        totalpayments = Val(txtAmount.Text) + Val(txtCurrentPayments.Text)
        txtTotalPayments.Text = Format(totalpayments, "00.00")
    End Sub

    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged
        getTotalPayments()
        CurrentBalance()
    End Sub

    Private Sub txtTotalAccts_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalAccts.TextChanged
        CurrentBalance()
    End Sub

    Private Sub txtTotalPayments_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCurrentPayments.TextChanged
        CurrentBalance()
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Source As String
        Source = lblSource.Text.Replace("'", "''")

        Dim radiobutton As String
        radiobutton = ""
        If RadioButtonCash.Checked = True Then
            radiobutton = "Cash"
        End If
        If RadioButtonCheck.Checked = True Then
            radiobutton = "Check"
        End If

        If mskStudentNumber.Text = "" Then
            MsgBox("Student Number is missing!", MsgBoxStyle.Critical)
            mskStudentNumber.Focus()
            Exit Sub
        End If

        If txtOR.Text = "" Then
            MsgBox("Please enter O.R. Number!", MsgBoxStyle.Critical)
            txtOR.Focus()
            Exit Sub
        End If
        If txtAmount.Text = "" Or txtAmount.Text = 0 Then
            MsgBox("Please enter the correct amount!", MsgBoxStyle.Critical)
            txtAmount.Focus()
            Exit Sub
        End If

        If txtDescription.Text = "" Then
            MsgBox("Payment description is required!", MsgBoxStyle.Critical)
            txtDescription.Focus()
            Exit Sub
        End If

        Try
            str = "select * from paymentsaccounts where ORNumber='" & txtOR.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "paymentsaccounts")
            conn.Close()

            If ds.Tables("paymentsaccounts").Rows.Count = 1 Then
                MsgBox("O.R. Number already in used!", MsgBoxStyle.Exclamation)
                conn.Close()
                txtOR.Focus()
                Exit Sub
            End If

            str = "insert into paymentsaccounts values('0','" & mskStudentNumber.Text & "','" & txtFname.Text & "','" & txtMName.Text & "','" & txtLastName.Text & "','" & lblCourseCode.Text & "','" & Convert.ToDateTime(dtpPaymentDate.Text).ToString("yyyy-MM-dd") & "','" & txtOR.Text & "','" & txtAmount.Text & "','" & txtDescription.Text & "','" & radiobutton & "','" & txtcheck.Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "','" & txtAddress.Text & "','" & Source & "','" & txtBank.Text & "','" & lblORStatus.Text & "','" & frmParent.lblUser.Text & "','" & lblYearLevel.Text & "')"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            conn.Close()


            'confirm enrollment
            str = "update semesterstude set StudentNumber='" & mskStudentNumber.Text & "',Status='" & lblEnrolled.Text & "' where StudentNumber='" & mskStudentNumber.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysc3 As New MySqlCommand(str, conn)
            mysc3.ExecuteNonQuery()
            conn.Close()


            'update billing
            str = "update studeaccount set StudentNumber='" & mskStudentNumber.Text & "',AcctTotal='" & txtTotalAccts.Text & "',TotalPayments='" & txtTotalPayments.Text & "',CurrentBalance='" & txtBalance.Text & "' where StudentNumber='" & mskStudentNumber.Text & "' and SY='" & frmParent.lblSY.Text & "' and Sem='" & frmParent.lblSem.Text & "'"
            conn.Open()
            Dim mysC2 As New MySqlCommand(str, conn)
            mysC2.ExecuteNonQuery()
            'MsgBox("Payment has been acknowledged!", MsgBoxStyle.Information)
            conn.Close()


            If (MsgBox("Payment has been acknowledged! Do you want to print the Official Receipt?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                'str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, ss.Course, ss.YearLevel, pa.PDate, pa.ORNumber, pa.Amount, pa.description, pa.PaymentType, pa.CheckNumber, pa.Sem, pa.SY, pa.Address, sa.CurrentBalance from studeprofile p join paymentsaccounts pa on p.StudentNumber=pa.StudentNumber join semesterstude ss on p.StudentNumber=ss.StudentNumber join studeaccount sa on pa.StudentNumber=sa.StudentNumber where pa.StudentNumber='" & mskStudentNumber.Text & "' and pa.ORNumber='" & txtOR.Text & "' and pa.Sem='" & frmParent.lblSem.Text & "' and pa.SY='" & frmParent.lblSY.Text & "'"
                str = "select pa.StudentNumber, concat(pa.FirstName,' ',pa.MiddleName,' ',pa.LastName) as StudentName, concat(pa.Course,'/ ',sa.YearLevel) as Course, pa.PaymentType, pa.description, pa.Amount, pa.ORNumber, pa.PDate, sa.CurrentBalance, sa.YearLevel, sa.Sem, sa.SY from paymentsaccounts pa join studeaccount sa on pa.StudentNumber=sa.StudentNumber where sa.StudentNumber='" & mskStudentNumber.Text & "' and sa.Sem='" & frmParent.lblSem.Text & "' and sa.SY='" & frmParent.lblSY.Text & "' and pa.ORNumber='" & txtOR.Text & "' group by sa.StudentNumber"
                conn.Open()
                Dim mysda2 As New MySqlDataAdapter(str, conn)
                Dim ds2 As New DataSet
                mysda2.Fill(ds2, "studeprofile, semesterstude, paymentsaccounts")
                Dim obj As New OfficialReceipt
                obj.SetDataSource(ds2.Tables("studeprofile, semesterstude, paymentsaccounts"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                conn.Close()
            End If

            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            If txtOR.Text = "" Then
                MsgBox("Please enter O.R. Number!", MsgBoxStyle.Critical)
                txtOR.Focus()
                Exit Sub
            End If
            'str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, ss.Course, ss.YearLevel, pa.PDate, pa.ORNumber, pa.Amount, pa.description, pa.PaymentType, pa.CheckNumber, pa.Sem, pa.SY, pa.Address, sa.CurrentBalance from studeprofile p join paymentsaccounts pa on p.StudentNumber=pa.StudentNumber join semesterstude ss on p.StudentNumber=ss.StudentNumber join studeaccount sa on pa.StudentNumber=sa.StudentNumber where pa.ORNumber='" & txtOR.Text & "' and pa.Sem='" & frmParent.lblSem.Text & "' and pa.SY='" & frmParent.lblSY.Text & "'"
            str = "select pa.StudentNumber, concat(pa.FirstName,' ',pa.MiddleName,' ',pa.LastName) as StudentName, concat(pa.Course,'/ ',sa.YearLevel) as Course, pa.PaymentType, pa.description, pa.Amount, pa.ORNumber, pa.PDate, sa.CurrentBalance, sa.YearLevel, sa.Sem, sa.SY from paymentsaccounts pa join studeaccount sa on pa.StudentNumber=sa.StudentNumber where ORNumber='" & txtOR.Text & "' group by sa.StudentNumber"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude, paymentsaccounts")
            Dim obj As New OfficialReceipt
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude, paymentsaccounts"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub tsPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsPrint.Click
        btnPrint.PerformClick()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        btnSave.PerformClick()
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            str = "update paymentsaccounts set PDate='" & Convert.ToDateTime(dtpPaymentDate.Text).ToString("yyyy-MM-dd") & "',ORNumber='" & txtOR.Text & "',Amount='" & txtAmount.Text & "',description='" & txtDescription.Text & "' where ID='" & lblPaymentID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record has been updated!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub tsView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsView.Click
        frmEditPayments.ShowDialog()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        frmSearchAccountforPayments.ShowDialog()
    End Sub
    Public Sub CourseCode()
        Try
            str = "select * from course_table where CourseDescription='" & lblCourse.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            Dim mysDR As MySqlDataReader = mysC.ExecuteReader

            While mysDR.Read
                lblCourseCode.Text = mysDR(1)
            End While


            mysDR.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub mskStudentNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mskStudentNumber.TextChanged
        CourseCode()
        PaymentHistory()
        getPaymentMode()
    End Sub
    Public Sub PaymentHistory()
        Try
            str = "select description, Amount,  PDate, ORNumber from paymentsaccounts where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and ORStatus='Valid' and CollectionSource!='Services'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "paymentsaccounts")
            dg1.DataSource = ds.Tables("paymentsaccounts")
            conn.Close()

            dg1.Columns(0).HeaderText = "Description"
            dg1.Columns(1).Width = "70"
            dg1.Columns(2).HeaderText = "Date"
            dg1.Columns(3).HeaderText = "O.R. No"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub getPaymentMode()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select PaymentMode from studeaccount where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblPaymentMode.Text = dtReader.Item(0)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged
        CurrentBalance()

    End Sub
End Class