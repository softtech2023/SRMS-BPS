
Imports MySql.Data.MySqlClient
Public Class frmEnrollmentSummaryDashboard
    Dim str As String
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            If cboSem.Text = "" Then
                MsgBox("Semester is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If txtSY.Text = "" Then
                MsgBox("SY is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If cboStatus.Text = "" Then
                MsgBox("Status is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            str = "SELECT s.Course, count(s.Status) as StatusCount, s.Status, s.YearLevel, count(s.Course) as EnrolledCount, s.Semester, s.SY  FROM semesterstude s where s.Semester='" & cboSem.Text & "' and s.SY='" & txtSY.Text & "' and s.Status='" & cboStatus.Text & "' group by s.Course, s.YearLevel, s.Status order by s.Course"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude")
            Dim obj As New EnrollmentSummaryReport
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class