Imports MySql.Data.MySqlClient
Public Class frmStudeAttendance
    Dim str As String
    Private Sub btnStudeReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStudeReport.Click
        Try
            str = "select p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, st.logDate, st.logTime, st.logOutTime, st.logpc, st.logpc, st.logStat, s.letterHead from studeprofile p join studelogs st on p.StudentNumber=st.StudentNumber join srms_settings s on p.settingsID=s.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "' order by st.logDate desc "
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(Str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, studelogs, srms_settings")
            Dim obj As New IndividualGatePass
            obj.SetDataSource(mysds.Tables("studeprofile, studelogs, srms_settings"))
            frmMainViewer.ReportViewer.ReportSource = obj
            specialReportViewer.ReportSource = obj
            specialReportViewer.Refresh()
            conn.Close()

            mskStudentNumber.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        specialReportViewer.ReportSource = Nothing
        specialReportViewer.Refresh()
        mskStudentNumber.Focus()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        btnReset.PerformClick()
    End Sub


    Private Sub frmStudeAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class