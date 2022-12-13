Imports MySql.Data.MySqlClient
Public Class frmScholarshipDashboard
    Dim str As String
    Private Sub btnStudeAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudeAccount.Click
        Try
            If cboCourseAccount.Text = "" Then
                str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, ss.YearLevel, ss.Course, ss.Semester, ss.SY, ss.Scholarship, ss.PayingStatus, ss.GrantAmount from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.PayingStatus='" & cboStatus.Text & "' and ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' order by StudentName"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude")
                Dim obj As New ScholarsListing
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                Me.Hide()
            Else
                str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, ss.YearLevel, ss.Course, ss.Semester, ss.SY, ss.Scholarship, ss.PayingStatus, ss.GrantAmount from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.PayingStatus='" & cboStatus.Text & "' and ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "'  and ss.Course='" & cboCourseAccount.Text & "' order by StudentName"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude")
                Dim obj As New ScholarsListing
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmScholarshipDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.DataSet.courses)
       
        cboCourseAccount.ResetText()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class