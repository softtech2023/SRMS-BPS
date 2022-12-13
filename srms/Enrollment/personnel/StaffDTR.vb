Imports MySql.Data.MySqlClient
Public Class frmStaffDTR
    Dim str As String
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "select s.FirstName, mid(s.MiddleName,1,1) as MiddleName, s.LastName, a.logDate, a.logTime, monthname(a.logDate) as MonthName, Year(a.logDate) as YearName, st.schoolHead, st.sHeadPosition from staff s join hris_attendance a on s.IDNumber=a.IDNumber join srms_settings st on s.settingsID=st.settingsID where a.IDNumber='" & frmParent.lblUser.Text & "'  and a.logDate>='" & Convert.ToDateTime(dtpFrom.Text).ToString("yyyy-MM-dd") & "' and a.logDate<='" & Convert.ToDateTime(dtpTo.Text).ToString("yyyy-MM-dd") & "' order by a.logDate"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(Str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "staff, hris_attendance")
            Dim obj As New DTRPrinting
            obj.SetDataSource(mysds.Tables("staff, hris_attendance"))
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