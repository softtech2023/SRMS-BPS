Imports MySql.Data.MySqlClient
Public Class frmOtherIncome
    Dim str As String
    
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim radiobutton As String
        radiobutton = ""
        If RadioButtonCash.Checked = True Then
            radiobutton = "Cash"
        End If
        If RadioButtonCheck.Checked = True Then
            radiobutton = "Check"
        End If
        If rdoCreditCard.Checked = True Then
            radiobutton = "Credit Card"
        End If

        If txtFname.Text = "" Then
            MsgBox("Firstname is required!", MsgBoxStyle.Exclamation)
            txtFname.Focus()
            Exit Sub
        End If

        If txtLastName.Text = "" Then
            MsgBox("Lastname is required!", MsgBoxStyle.Exclamation)
            txtLastName.Focus()
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

            str = "insert into paymentsaccounts values('0','" & mskStudentNumber.Text & "','" & txtFname.Text & "','" & txtMName.Text & "','" & txtLastName.Text & "','" & lblSource.Text & "','" & Convert.ToDateTime(frmParent.dtpDate.Text).ToString("yyyy-MM-dd") & "','" & txtOR.Text & "','" & txtAmount.Text & "','" & txtDescription.Text.Replace("'", "''") & "','" & radiobutton & "','" & txtcheck.Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "','" & txtAddress.Text & "','" & lblSource.Text & "','" & txtBank.Text & "','Valid','" & frmParent.lblUser.Text & "','')"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            conn.Close()

            If (MsgBox("Payment has been acknowledged! Do you want to print the Official Receipt?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "select StudentNumber, concat(FirstName,' ',MiddleName,' ',LastName) as StudentName, PaymentType, description, Amount, ORNumber, PDate from paymentsaccounts where ORNumber='" & txtOR.Text & "'"
                conn.Open()
                Dim mysda2 As New MySqlDataAdapter(str, conn)
                Dim ds2 As New DataSet
                mysda2.Fill(ds2, "paymentsaccounts")
                Dim obj As New ORServices
                obj.SetDataSource(ds2.Tables("paymentsaccounts"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                frmMainViewer.MdiParent = frmParent
                Me.WindowState = FormWindowState.Minimized
                frmMainViewer.Show()
                conn.Close()
            End If

            'FormLoad()

            mskStudentNumber.Clear()
            txtFname.Clear()
            txtMName.Clear()
            txtLastName.Clear()
            txtAddress.Clear()
            txtAmount.Text = 0
            txtDescription.ResetText()
            txtcheck.Clear()
            txtBank.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Public Sub FormLoad()

        getDescription()
        mskStudentNumber.Clear()
        txtFname.Clear()
        txtMName.Clear()
        txtLastName.Clear()
        txtAmount.Text = 0.0
        txtAddress.Clear()
        txtcheck.Clear()
        txtDescription.ResetText()
        mskStudentNumber.Focus()

        RadioButtonCash.Checked = True

        'Try
        'Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
        'str = "select max(ORNumber) from paymentsaccounts"
        'conn.Open()
        'Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
        'objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
        'dtReader = objCmd.ExecuteReader()
        'If dtReader.Read Then
        'txtOR.Text = dtReader.Item(0).ToString
        'txtOR.Text = txtOR.Text + 1
        ' End If
        ' conn.Close()
        ' Catch ex As Exception
        'MsgBox(ex.Message)
        'conn.Close()
        'End Try
    End Sub
    Public Sub getDescription()
        Try
            str = "select * from otherfees_desc where feesType='Services' order by feesDesc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "otherfees_desc")

            txtDescription.ValueMember = "otherfees_desc"
            txtDescription.DisplayMember = "feesDesc"
            txtDescription.DataSource = ds.Tables("otherfees_desc")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmOtherIncome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If txtOR.Text = "" Then
                MsgBox("Please enter O.R. Number!", MsgBoxStyle.Critical)
                txtOR.Focus()
                Exit Sub
            End If
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, ss.Course, ss.YearLevel, pa.PDate, pa.ORNumber, pa.Amount, pa.description, pa.PaymentType, pa.CheckNumber, pa.Sem, pa.SY, pa.Address from studeprofile p join paymentsaccounts pa on p.StudentNumber=pa.StudentNumber join semesterstude ss on p.StudentNumber=ss.StudentNumber where pa.ORNumber='" & txtOR.Text & "'"
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

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        FormLoad()
        frmSelectStude.ShowDialog()
    End Sub

    Private Sub RadioButtonCash_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButtonCash.Click
        txtcheck.Enabled = False
        txtcheck.Clear()
        txtBank.Clear()
    End Sub

    Private Sub RadioButtonCheck_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButtonCheck.Click
        txtcheck.Enabled = True
        txtcheck.Focus()
        txtBank.Enabled = True
    End Sub

    Private Sub rdoCreditCard_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoCreditCard.Click
        txtcheck.Enabled = True
        txtcheck.Focus()
        txtBank.Enabled = True
    End Sub
End Class