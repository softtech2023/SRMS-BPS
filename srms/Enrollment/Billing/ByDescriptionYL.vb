Imports MySql.Data.MySqlClient
Public Class frmByDescriptionYL
    Dim str As String
    Public Sub getYearLevel()
        Try
            str = "SELECT * FROM course_table group by Major order by Major"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "course_table")
            conn.Close()
            cboYearLevel.ValueMember = "course_table"
            cboYearLevel.DisplayMember = "Major"
            cboYearLevel.DataSource = ds.Tables("course_table")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getDescription()
        Try
            Str = "select * from fees group by Description order by Description"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "fees")

            cboDescription.ValueMember = "fees"
            cboDescription.DisplayMember = "Description"
            cboDescription.DataSource = ds.Tables("fees")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmByDescriptionYL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getDescription()
        getYearLevel()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName,pa.PDate, pa.Amount, pa.ORNumber, pa.Cashier, pa.Course, pa.description, pa.YearLevel, pa.Sem, pa.SY, st.SchoolName, st.SchoolAddress from studeprofile p join srms_settings st on p.settingsID=st.settingsID join paymentsaccounts pa on p.StudentNumber=pa.StudentNumber where pa.YearLevel='" & cboYearLevel.Text & "' and pa.description='" & cboDescription.Text & "' and pa.ORStatus='Valid' and pa.PDate>= '" & Format(dtpFrom.Value.Date, "yyyy-MM-dd") & "' and pa.PDate <= '" & Format(dtpTo.Value.Date, "yyyy-MM-dd") & "'order by StudentName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, srms_settings, paymentsaccounts")
            Dim obj As New CollectionReport_DescriptionYL
            obj.SetDataSource(ds.Tables("studeprofile, srms_settings, paymentsaccounts"))
            obj.SetParameterValue("Date Range", dtpFrom.Text & " - " & dtpTo.Text)
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class