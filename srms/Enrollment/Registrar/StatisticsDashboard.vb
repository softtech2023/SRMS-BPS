Imports MySql.Data.MySqlClient
Public Class frmStatisticsDashboard
    Dim str As String

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            'str = "SELECT s.Course, count(s.Status) as StatusCount, s.Status, s.YearLevel, count(s.Course) as EnrolledCount, s.Semester, s.SY, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition, st.Registrar, st.registrarPosition  FROM semesterstude s join srms_settings st on s.settingsID=st.settingsID where s.Semester='" & lblSem.Text & "' and s.SY='" & lblSY.Text & "' group by s.Course, s.YearLevel order by s.Course"
            str = "SELECT mid(p.Sex,1,1) as Sex, s.Course, s.Major, count(s.Status) as StatusCount, s.Status, s.YearLevel, count(s.Course) as EnrolledCount, s.Semester, s.SY, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition, st.letterHead FROM studeprofile p join semesterstude s on p.StudentNumber=s.StudentNumber join srms_settings st on s.settingsID=st.settingsID where s.Semester!='2nd Sem.' and s.Status='Enrolled' and s.EnrolledDate>='" & Convert.ToDateTime(dtpFrom.Text).ToString("yyyy-MM-dd") & "' and s.EnrolledDate<='" & Convert.ToDateTime(dtpTo.Text).ToString("yyyy-MM-dd") & "' group by s.YearLevel, p.Sex order by s.YearLevel"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(Str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude")
            'Dim obj As New EnrollmentSummaryReport
            Dim obj As New StatisticsReportDate
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
            obj.SetParameterValue("dateFrom", dtpFrom.Text)
            obj.SetParameterValue("dateTo", dtpTo.Text)
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