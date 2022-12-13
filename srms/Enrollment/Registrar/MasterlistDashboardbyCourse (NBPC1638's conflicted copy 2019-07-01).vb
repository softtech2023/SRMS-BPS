Imports MySql.Data.MySqlClient
Public Class frmMasterlistDashboardbyCourse
    Dim str As String
    Private Sub btnStudentList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudentList.Click
        Try
            If cboCourse.Text = "" Then
                MsgBox("Department is required", MsgBoxStyle.Exclamation)
                cboCourse.Focus()
                Exit Sub
            End If

            If cboCourse.Text = "Senior High School" Then

                str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as Fullname, p.Sex, ss.Course, ss.YearLevel, ss.Status, ss.SY, YearLevelStat, ss.Section, ss.semstudentid, ss.Adviser, ss.Track, ss.Qualification, sr.SchoolName, sr.SchoolAddress, sr.letterHead from semesterstude ss join studeprofile p on p.StudentNumber=ss.StudentNumber join srms_settings sr on sr.settingsID=ss.settingsID where ss.Course='" & cboCourse.Text & "' and ss.Semester='" & frmParent.lblSem.Text & "'  and ss.SY='" & frmParent.lblSY.Text & "' and ss.Status='Enrolled' order by p.Sex, Fullname"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "semesterstude")
                Dim obj As New StudentList
                obj.SetDataSource(mysds.Tables("semesterstude"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                conn.Close()
                Me.Hide()
            Else
                'str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as Fullname, p.Sex, ss.Course, ss.YearLevel, ss.Status, ss.SY, YearLevelStat, ss.Section, ss.semstudentid from semesterstude ss join studeprofile p on p.StudentNumber=ss.StudentNumber where ss.Course='" & cboCourse.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' order by p.Sex, Fullname"
                str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as Fullname, p.Sex, ss.Course, ss.YearLevel, ss.Status, ss.SY, YearLevelStat, ss.Section, ss.semstudentid, ss.Adviser, ss.Track, ss.Qualification, sr.SchoolName, sr.SchoolAddress, sr.letterHead from semesterstude ss join studeprofile p on p.StudentNumber=ss.StudentNumber join srms_settings sr on sr.settingsID=ss.settingsID where ss.Course='" & cboCourse.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Semester='" & frmParent.lblSem.Text & "' and ss.Status='Enrolled' order by p.Sex, Fullname"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude")
                Dim obj As New StudentList
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                conn.Close()
                Me.Hide()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmMasterlistDashboardbyCourse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getCourse()
    End Sub
    Public Sub getCourse()
        Try
            If frmParent.lblSem.Text = "1st Sem." Or frmParent.lblSem.Text = "2nd Sem." Then
                str = "select * from course_table where CourseDescription='Senior High School' group by CourseDescription order by CourseDescription"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "course_table")
                conn.Close()

                cboCourse.ValueMember = "course_table"
                cboCourse.DisplayMember = "CourseDescription"
                cboCourse.DataSource = ds.Tables("course_table")
            Else
                str = "select * from course_table where CourseDescription!='Senior High School' group by CourseDescription order by CourseDescription"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "course_table")
                conn.Close()

                cboCourse.ValueMember = "course_table"
                cboCourse.DisplayMember = "CourseDescription"
                cboCourse.DataSource = ds.Tables("course_table")
            End If

            

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class