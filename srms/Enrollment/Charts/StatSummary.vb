Imports MySql.Data.MySqlClient
Public Class frmStatSummary
    Dim str As String

    Public Sub getSection()
        Try
            str = "select * from semesterstude where YearLevel='" & cboGradeLevel.Text & "' group by Section order by Section"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude")
            conn.Close()

            cboSection.ValueMember = "semesterstude"
            cboSection.DisplayMember = "Section"
            cboSection.DataSource = ds.Tables("semesterstude")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboGradeLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getSection()
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cboOptions.Text = "" Then
            MsgBox("Please select from the option box!", MsgBoxStyle.Exclamation)
            cboOptions.Focus()
            Exit Sub
        End If
        If cboOptions.SelectedIndex = 0 Then '4Ps

            str = "select p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, p.Sex, p.BirthDate, p.Age, p.MobileNumber, p.College, ss.Course, ss.YearLevel, ss.Semester, ss.SY, ss.Section, ss.Track, ss.Qualification, ss.BalikAral, ss.IP, ss.FourPs from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.FourPs='Yes' and ss.YearLevel='" & cboGradeLevel.Text & "' and ss.Section='" & cboSection.Text & "' and ss.Status='Enrolled' order by p.Sex, p.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude,studeprofile")
            Dim obj As New FourPs
            obj.SetDataSource(ds.Tables("semesterstude,studeprofile"))
            ReportViewer.ReportSource = obj
            ReportViewer.Refresh()
            conn.Close()
        End If

        If cboOptions.SelectedIndex = 1 Then 'Balik Aral

            str = "select p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, p.Sex, p.BirthDate, p.Age, p.MobileNumber, p.College, ss.Course, ss.YearLevel, ss.Semester, ss.SY, ss.Section, ss.Track, ss.Qualification, ss.BalikAral, ss.IP, ss.FourPs from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.BalikAral='Yes' and ss.YearLevel='" & cboGradeLevel.Text & "' and ss.Section='" & cboSection.Text & "' and ss.Status='Enrolled' order by p.Sex, p.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude,studeprofile")
            Dim obj As New BalikAral
            obj.SetDataSource(ds.Tables("semesterstude,studeprofile"))
            ReportViewer.ReportSource = obj
            ReportViewer.Refresh()
            conn.Close()
        End If

        If cboOptions.SelectedIndex = 2 Then 'IPs

            str = "select p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, p.Sex, p.BirthDate, p.Age, p.MobileNumber, p.College, ss.Course, ss.YearLevel, ss.Semester, ss.SY, ss.Section, ss.Track, ss.Qualification, ss.BalikAral, ss.IP, ss.FourPs from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.IP='Yes' and ss.YearLevel='" & cboGradeLevel.Text & "' and ss.Section='" & cboSection.Text & "' and ss.Status='Enrolled' order by p.Sex, p.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude,studeprofile")
            Dim obj As New IPs
            obj.SetDataSource(ds.Tables("semesterstude,studeprofile"))
            ReportViewer.ReportSource = obj
            ReportViewer.Refresh()
            conn.Close()
        End If


        If cboOptions.SelectedIndex = 3 Then 'Repeater

            str = "select p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, p.Sex, p.BirthDate, p.Age, p.MobileNumber, ss.Course, ss.YearLevel, ss.Semester, ss.SY, ss.Section, ss.Track, ss.Qualification, ss.BalikAral, ss.IP, ss.FourPs from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Repeater='Yes' and ss.YearLevel='" & cboGradeLevel.Text & "' and ss.Section='" & cboSection.Text & "' and ss.Status='Enrolled' order by p.Sex, p.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude,studeprofile")
            Dim obj As New Repeater
            obj.SetDataSource(ds.Tables("semesterstude,studeprofile"))
            ReportViewer.ReportSource = obj
            ReportViewer.Refresh()
            conn.Close()
        End If

        If cboOptions.SelectedIndex = 4 Then ' Transferee
            If cboGradeLevel.Text = "" And cboSection.Text = "" Then
                str = "select p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, p.Sex, p.BirthDate, p.Age, p.MobileNumber, ss.Course, ss.YearLevel, ss.Semester, ss.SY, ss.Section, ss.Track, ss.Qualification, ss.BalikAral, ss.IP, ss.FourPs from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Transferee='Yes' and ss.Status='Enrolled' order by p.Sex, p.LastName"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "semesterstude,studeprofile")
                Dim obj As New Transferee
                obj.SetDataSource(ds.Tables("semesterstude,studeprofile"))
                ReportViewer.ReportSource = obj
                ReportViewer.Refresh()
                conn.Close()

            Else
                str = "select p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, p.Sex, p.BirthDate, p.Age, p.MobileNumber, ss.Course, ss.YearLevel, ss.Semester, ss.SY, ss.Section, ss.Track, ss.Qualification, ss.BalikAral, ss.IP, ss.FourPs from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Transferee='Yes' and ss.YearLevel='" & cboGradeLevel.Text & "' and ss.Section='" & cboSection.Text & "' and ss.Status='Enrolled' order by p.Sex, p.LastName"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "semesterstude,studeprofile")
                Dim obj As New Transferee
                obj.SetDataSource(ds.Tables("semesterstude,studeprofile"))
                ReportViewer.ReportSource = obj
                ReportViewer.Refresh()
                conn.Close()

            End If
        End If
    End Sub

    Public Sub getYearLevel()
        Try
            If frmParent.lblSem.Text = "1st Sem." Or frmParent.lblSem.Text = "2nd Sem." Then

                str = "select * from course_table where CourseCode='SHS'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "course_table")
                conn.Close()
                cboGradeLevel.ValueMember = "course_table"
                cboGradeLevel.DisplayMember = "Major"
                cboGradeLevel.DataSource = ds.Tables("course_table")
                conn.Close()

            Else
                str = "select * from course_table where CourseCode!='SHS'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "course_table")
                conn.Close()
                cboGradeLevel.ValueMember = "course_table"
                cboGradeLevel.DisplayMember = "Major"
                cboGradeLevel.DataSource = ds.Tables("course_table")
                conn.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmStatSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getYearLevel()
    End Sub

    Private Sub cboGradeLevel_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGradeLevel.SelectedIndexChanged
        getSection()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class