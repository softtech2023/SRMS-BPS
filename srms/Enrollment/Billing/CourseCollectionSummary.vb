Imports MySql.Data.MySqlClient
Public Class frmCourseCollectionSummary
    Dim str As String
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "select p.StudentNumber, pa.Course, sum(pa.Amount), pa.PDate, pa.YearLevel from studeprofile p join paymentsaccounts pa on p.StudentNumber=pa.StudentNumber join srms_settings st on p.settingsID=st.settingsID where pa.PDate>= '" & Format(dtpFrom.Value.Date, "yyyy-MM-dd") & "' and pa.PDate <= '" & Format(dtpTo.Value.Date, "yyyy-MM-dd") & "' group by pa.Course, pa.PDate, pa.YearLevel"
            conn.Open()
            Dim mysDa As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDa.Fill(mysds, "studeprofile, paymentsaccounts")
            Dim obj As New CourseCollection
            obj.SetDataSource(mysds.Tables("studeprofile, paymentsaccounts"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            'obj.SetParameterValue("transDate", dtpFrom.Text)
            obj.SetParameterValue("transTo", dtpTo.Text)
            Me.Hide()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class