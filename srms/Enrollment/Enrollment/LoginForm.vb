Imports MySql.Data.MySqlClient
Public Class LoginForm
    Dim str As String
    Dim str2 As String

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim level As String

        str = "select * from users where username='" & txtUserName.Text & "' and password='" & txtpassword.Text & "'"
        conn.Open()
        Dim mysda As New MySqlDataAdapter(str, conn)
        Dim ds As New DataSet
        mysda.Fill(ds, "users")

        ' MsgBox(level, MsgBoxStyle.Information)

        If ds.Tables("users").Rows.Count = 1 Then
            level = ds.Tables("users").Rows(0).Item(3)
            If level.Equals("Admin") Then
                frmParent.tsAdmin.Enabled = True
                frmParent.tsAdmission.Enabled = True

            End If
            If level.Equals("Registrar") Then
                frmParent.tsAdmin.Enabled = False
                frmParent.tsAdmission.Enabled = False


            End If

            If level.Equals("Cashier") Then

                frmParent.tsAdmin.Enabled = False
                frmParent.tsAdmission.Enabled = False
                frmBilling.txtDiscount.Enabled = False
                frmBilling.tsNew.Enabled = False
                frmBilling.tsSave.Enabled = False

            End If

            If level.Equals("Admission") Then
                frmParent.tsAdmin.Enabled = False
                frmParent.tsAdmission.Enabled = True


            End If
            If level.Equals("Student") Then
                frmParent.tsAdmin.Enabled = False

                frmParent.tsAdmission.Enabled = False

                frmParent.tsmMaintenance.Enabled = False

            End If

            frmParent.lblUser.Text = txtUserName.Text
            ChangeSem.ShowDialog()
            Me.Hide()

        Else
            MsgBox("Access Denied", MsgBoxStyle.Information)
            txtUserName.Clear()
            txtpassword.Clear()
            conn.Close()
            Exit Sub
        End If
        conn.Close()
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub LoginForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtUserName.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            Dim level As String
            Dim pass As String

            pass = getSHA1Hash(txtpassword.Text)

            'str = "select * from users where username='" & txtUserName.Text & "' and password='" & pass & "'"
            str = "select * from users where username='" & txtUserName.Text & "' and password='" & pass & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "users")

            ' MsgBox(level, MsgBoxStyle.Information)

            If ds.Tables("users").Rows.Count = 1 Then
                level = ds.Tables("users").Rows(0).Item(2)
                If level.Equals("Super Admin") Then
                    frmPayment.tsView.Visible = False
                    frmPayment.tsUpdate.Visible = False
                    frmPayment.tsView.Visible = False
                    frmParent.SystemSettingsToolStripMenuItem.Enabled = True
                End If

                If level.Equals("Security Guard") Then
                    frmParent.msMain.Hide()
                    frmParent.mnuGuard.Show()
                    frmParent.tsAbout.Visible = False
                    frmParent.SystemSettingsToolStripMenuItem.Enabled = False
                End If

                If level.Equals("Admin") Then
                    frmPayment.tsView.Visible = False
                    frmPayment.tsUpdate.Visible = False
                    frmPayment.tsView.Visible = False
                    frmParent.SystemSettingsToolStripMenuItem.Enabled = False

                End If

                If level.Equals("Registrar") Then
                    frmParent.tsAdmin.Enabled = False
                    frmParent.tsAdmission.Enabled = True
                    frmParent.tsCashier.Enabled = False
                    frmParent.tsRegistrar.Enabled = True
                    frmParent.tsReports.Enabled = True
                    frmParent.tsmMaintenance.Enabled = False
                    frmParent.tsmFinancialReports.Enabled = False
                    frmParent.tsAbout.Visible = False
                    frmParent.SystemSettingsToolStripMenuItem.Enabled = False
                End If

                If level.Equals("Student") Then
                    frmParent.msMain.Hide()
                    frmParent.mnuStudent.Show()
                    frmParent.tsAbout.Visible = False
                    frmParent.SystemSettingsToolStripMenuItem.Enabled = False
                End If

                If level.Equals("Teacher") Then
                    frmParent.msMain.Hide()
                    frmParent.mnuSpecialLogin.Show()
                    frmParent.tsAdmissionToolStrip.Visible = False
                    frmParent.tsAdvisoryClass.Visible = False
                    frmParent.DiplomaToolStripMenuItem.Visible = False
                    frmParent.tsAbout.Visible = False
                    frmParent.SystemSettingsToolStripMenuItem.Enabled = False
                End If

                If level.Equals("Teacher/Adviser") Then
                    frmParent.msMain.Hide()
                    frmParent.mnuSpecialLogin.Show()
                    frmParent.SystemSettingsToolStripMenuItem.Enabled = False
                End If

                If level.Equals("Accounting") Then
                    frmParent.tsAdmin.Enabled = False
                    frmParent.tsAdmission.Enabled = False
                    frmParent.tsCashier.Enabled = True
                    frmParent.tsRegistrar.Enabled = False
                    frmParent.tsReports.Enabled = True
                    frmParent.EnrollmentSummaryToolStripMenuItem.Enabled = False
                    frmParent.FacultyLoadingToolStripMenuItem1.Enabled = False
                    frmParent.MasterlistToolStripMenuItem.Enabled = False
                    frmParent.tsmMaintenance.Enabled = False
                    frmParent.tsmFinancialReports.Enabled = True
                    frmParent.ExpensesToolStripMenuItem1.Enabled = True
                    frmParent.StudentsAccountsToolStripMenu.Enabled = True
                    frmParent.AccountPaymentsToolStripMenuItem.Enabled = True
                    frmParent.PaymentsOtherServicesToolStripMenuItem1.Enabled = True
                    frmParent.PromissoryNoteToolStripMenuItem1.Enabled = True
                    frmParent.SearchOfficialReceiptToolStripMenuItem.Enabled = True
                    frmPayment.tsUpdate.Visible = False
                    frmPayment.tsView.Visible = False
                    frmParent.tsAbout.Visible = False
                    frmParent.SystemSettingsToolStripMenuItem.Enabled = False
                End If

                frmParent.lblUser.Text = txtUserName.Text
                ChangeSem.ShowDialog()
                Me.Hide()

            Else
                MsgBox("Access Denied", MsgBoxStyle.Exclamation)
                txtUserName.Clear()
                txtpassword.Clear()
                conn.Close()
                Exit Sub

            End If
            conn.Close()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        End
    End Sub
End Class
