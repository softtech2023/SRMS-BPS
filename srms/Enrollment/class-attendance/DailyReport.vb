Imports MySql.Data.MySqlClient
Public Class frmDailyReport
    Dim str As String
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "SELECT s.StudentNumber, s.FirstName, s.MiddleName, s.LastName, s.Sex, st.letterHead, ca.logDate, ca.logTime, ca.logpc, ca.subjectCode, ca.description, ca.section, ca.teacher, ca.logStat FROM studeprofile s join srms_settings st on s.settingsID=st.settingsID join classattendance ca on s.StudentNumber=ca.StudentNumber where logDate='" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") & "' and ca.subjectCode='" & frmClassAttendanceForm.lblSubjectCode.Text & "' and ca.section='" & frmClassAttendanceForm.lblSection.Text & "' and ca.teacher='" & frmClassAttendanceForm.lblTeacher.Text & "' and ca.sem='" & frmParent.lblSem.Text & "' and ca.sy='" & frmParent.lblSY.Text & "' order by s.LastName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(Str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, srms_settings, classattendance")
            Dim obj As New dailyAttendance
            obj.SetDataSource(mysds.Tables("studeprofile, srms_settings, classattendance"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class