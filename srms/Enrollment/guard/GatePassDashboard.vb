Imports MySql.Data.MySqlClient
Public Class frmGatePassDashboard1
    Dim str As String
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "select p.StudentNumber, p.LastName, p.FirstName, mid(p.MiddleName,1,1) as middleName, sl.logDate, sl.logTime, sl.logOutTime, sl.logpc, sl.logStat, st.letterHead from studeprofile p join studelogs sl on p.StudentNumber=sl.StudentNumber join srms_settings st on p.settingsID=st.settingsID where sl.logDate='" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") & "' order by p.LastName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studelogs, studeprofile, srms_settings")
            Dim obj As New dailyLogs
            obj.SetDataSource(mysds.Tables("studelogs, studeprofile, srms_settings"))
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