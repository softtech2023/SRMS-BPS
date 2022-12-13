Imports MySql.Data.MySqlClient
Public Class frmStudeReport_Accounting
    Dim str As String
    Private Sub btnStudeReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudeReport.Click
        If mskStudentNumber.Text = "" Then
            MsgBox("Please enter Student Number!", MsgBoxStyle.Information)
            Exit Sub
            mskStudentNumber.Focus()
        End If

        Try

            'Account Tracking
            If cboStudeReport.SelectedIndex = 0 Then
                str = "Select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, p.Course, s.SY, s.AcctTotal, s.TotalPayments, s.CurrentBalance, s.Discount, st.letterHead from studeprofile p join studeaccount s on p.StudentNumber=s.StudentNumber join srms_settings st on p.settingsID=st.settingsID where s.StudentNumber='" & mskStudentNumber.Text & "' and s.SY='" & frmParent.lblSY.Text & "' group by s.StudentNumber, s.SY"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(Str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studeprofile, studeaccount")
                Dim obj As New AcctTracking
                obj.SetDataSource(ds.Tables("studeprofile, studeaccount"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()

            End If


            'payment history
            If cboStudeReport.SelectedIndex = 1 Then
                'str = "SELECT p.StudentNumber, concat(s.FirstName,' ',s.LastName) as sStudentName, s.PDate, s.ORNumber, s.Amount, s.description, s.Sem, s.SY FROM paymentsaccounts s join studeprofile p on p.StudentNumber=s.StudentNumber where p.StudentNumber='" & mskStudentNumber.Text & "' and s.Sem='" & lblSem.Text & "' and s.SY='" & lblSY.Text & "' and s.ORStatus='Valid'"
                str = "select s.StudentNumber, concat(s.FirstName,' ',s.MiddleName,' ',s.LastName) as StudentName, s.AcctTotal, s.CurrentBalance, s.Discount, s.PaymentMode, s.Sem, s.SY, pa.PDate, pa.ORNumber, pa.Amount, pa.description, pa.PaymentType, pa.ORStatus, pa.Sem, pa.SY, st.letterHead from studeaccount s join paymentsaccounts pa on s.StudentNumber=pa.StudentNumber join srms_settings st on s.settingsID=st.settingsID where s.StudentNumber='" & mskStudentNumber.Text & "' and s.SY='" & frmParent.lblSY.Text & "' and pa.SY='" & frmParent.lblSY.Text & "' and pa.ORStatus='Valid' and pa.CollectionSource!='Services' group by pa.ORNumber"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(Str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, paymentsaccounts")
                Dim obj As New PaymentHistory
                obj.SetDataSource(mysds.Tables("studeprofile, paymentsaccounts"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()

            End If

            'ledger (other servicesss)
            If cboStudeReport.SelectedIndex = 2 Then
                str = "select s.StudentNumber, concat(s.FirstName,' ',s.MiddleName,' ',s.LastName) as StudentName, s.AcctTotal, s.CurrentBalance, s.PaymentMode, s.Sem, s.SY, pa.PDate, pa.ORNumber, pa.Amount, pa.description, pa.PaymentType, pa.ORStatus, pa.Sem, pa.SY, st.letterHead from studeaccount s join paymentsaccounts pa on s.StudentNumber=pa.StudentNumber join srms_settings st on s.settingsID=st.settingsID where s.StudentNumber='" & mskStudentNumber.Text & "' and s.SY='" & frmParent.lblSY.Text & "' and pa.SY='" & frmParent.lblSY.Text & "' and pa.ORStatus='Valid' and pa.CollectionSource='Services' group by pa.ORNumber"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, paymentsaccounts")
                Dim obj As New PaymentHistoryServices
                obj.SetDataSource(mysds.Tables("studeprofile, paymentsaccounts"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()

            End If


            'Statement of Account
            If cboStudeReport.SelectedIndex = 3 Then
                str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, b.OldAccount, b.FeesDesc, b.FeesAmount, b.TotalFees, b.AcctTotal, b.Discount, b.CurrentBalance, b.TotalPayments, (Amount1+Amount2+Amount3+Amount4+Amount5) as AdditionalFees, b.Sem, b.SY from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber where p.StudentNumber='" & mskStudentNumber.Text & "' and b.SY='" & frmParent.lblSY.Text & "' order by b.FeesDesc"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, studeaccount, paymentsaccounts")
                Dim obj As New SOA
                obj.SetDataSource(mysds.Tables("studeprofile, studeaccount, paymentsaccounts"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()
            End If



            'Statement of Account Version 2
            If cboStudeReport.SelectedIndex = 4 Then
                str = "SELECT * FROM studeaccount s join srms_settings st on s.settingsID=st.settingsID where StudentNumber='" & mskStudentNumber.Text & "' and SY='" & frmParent.lblSY.Text & "' order by FeesDesc"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeaccount")
                Dim obj As New DetailedAssessment
                obj.SetDataSource(mysds.Tables("studeaccount"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub mskStudentNumber_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskStudentNumber.Click
        frmQSearch.ShowDialog()
    End Sub

End Class