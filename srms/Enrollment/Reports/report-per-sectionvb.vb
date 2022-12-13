Imports MySql.Data.MySqlClient
Public Class frmReportPerSection
    Dim str As String
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            If cboCourse.Text = "" Then
                MsgBox("Course is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If cboYearLevel.Text = "" Then
                MsgBox("Year level is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If cboSection.Text = "" Then
                str = "Select s.StudentNumber, concat(s.LName,', ',s.FName,' ',s.MName) as Fullname, s.Course, s.YearLevel, s.Status, s.Scholarship, s.Semester, s.SY, s.Term, s.Section, s.semstudentid, p.Sex, s.Adviser, s.Track, s.Qualification, sr.SchoolName, sr.SchoolAddress, sr.letterHead from semesterstude s join studeprofile p on s.StudentNumber=p.StudentNumber join srms_settings sr on s.settingsID=sr.settingsID and s.Status='Enrolled' where s.Semester='" & frmParent.lblSem.Text & "' and s.SY='" & frmParent.lblSY.Text & "' and s.Course='" & cboCourse.Text & "' and s.YearLevel='" & cboYearLevel.Text & "' order by p.Sex, Fullname"
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
                'Me.Hide()

            Else
                str = "Select s.StudentNumber, concat(s.LName,', ',s.FName,' ',s.MName) as Fullname, s.Course, s.YearLevel, s.Status, s.Scholarship, s.Semester, s.SY, s.Term, s.Section, s.semstudentid, p.Sex, p.classification, s.Adviser, s.Track, s.Qualification, sr.SchoolName, sr.SchoolAddress, sr.letterHead from semesterstude s join studeprofile p on s.StudentNumber=p.StudentNumber join srms_settings sr on s.settingsID=sr.settingsID where s.Semester='" & frmParent.lblSem.Text & "' and s.SY='" & frmParent.lblSY.Text & "' and s.Course='" & cboCourse.Text & "' and s.YearLevel='" & cboYearLevel.Text & "' and s.Section='" & cboSection.Text & "' and s.Status='Enrolled' order by p.Sex, Fullname"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "semesterstude")
                Dim obj As New ListPerSection
                obj.SetDataSource(mysds.Tables("semesterstude"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                conn.Close()
                'Me.Hide()
            End If
           
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Public Sub getCourseMajor()
        Try
            str = "select * from course_table where CourseDescription='" & cboCourse.Text & "' order by Major"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
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
                conn.Close()
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
                conn.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmReportPerSection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getCourse()
    End Sub

    Private Sub cboCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCourse.SelectedIndexChanged
        getCourseMajor()

    End Sub
    Public Sub getSection()
        Try
            str = "select * from sections where YearLevel='" & cboYearLevel.Text & "' order by Section"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "sections")
            conn.Close()

            cboSection.ValueMember = "sections"
            cboSection.DisplayMember = "Section"
            cboSection.DataSource = ds.Tables("sections")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboYearLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYearLevel.SelectedIndexChanged
        getSection()
    End Sub

End Class