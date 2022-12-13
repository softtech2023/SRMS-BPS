Imports MySql.Data.MySqlClient
Public Class frmCollectionSummaryDashboard
    Dim str As String
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnStudeAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudeAccount.Click
        Try
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName,pa.PDate, pa.Amount, pa.ORNumber, pa.Cashier, pa.Course, pa.description, pa.YearLevel, pa.Sem, pa.SY, st.SchoolName, st.SchoolAddress from studeprofile p join srms_settings st on p.settingsID=st.settingsID join paymentsaccounts pa on p.StudentNumber=pa.StudentNumber where pa.Cashier='" & cboCashier.Text & "' and ORStatus='Valid' and PDate>= '" & Format(dtpFrom.Value.Date, "yyyy-MM-dd") & "' and PDate <= '" & Format(dtpTo.Value.Date, "yyyy-MM-dd") & "'order by StudentName"
            conn.Open()
            Dim mysDa As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysDa.Fill(ds, "studeprofile, srms_settings, paymentsaccounts")
            Dim obj As New CashierCollectionReport
            obj.SetDataSource(ds.Tables("studeprofile, srms_settings, paymentsaccounts"))
            obj.SetParameterValue("Date Range", dtpFrom.Text & " - " & dtpTo.Text)
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
           
          
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Public Sub getCashier()
        Try
            str = "select * from paymentsaccounts group by Cashier order by Cashier"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "paymentsaccounts")

            cboCashier.ValueMember = "paymentsaccounts"
            cboCashier.DisplayMember = "Cashier"
            cboCashier.DataSource = ds.Tables("paymentsaccounts")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmCollectionSummaryDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getCashier()
    End Sub
End Class