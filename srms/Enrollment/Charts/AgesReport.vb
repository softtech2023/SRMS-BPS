Imports MySql.Data.MySqlClient
Public Class frmAgesReport
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

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Try
            If frmParent.lblSem.Text = "" Then
                str = "select p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, p.Sex, p.BirthDate, p.Age, p.MobileNumber, p.College, ss.Course, ss.YearLevel, ss.Semester, ss.SY, ss.Section, ss.Track, ss.Qualification, ss.BalikAral, ss.IP, ss.FourPs from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.SY='" & frmParent.lblSY.Text & "' and ss.YearLevel='" & cboGradeLevel.Text & "' and ss.Section='" & cboSection.Text & "' and p.Age='" & txtAge.Text & "' and ss.Status='Enrolled' order by p.Sex, p.LastName"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "semesterstude,studeprofile")
                Dim obj As New AgesReport
                obj.SetDataSource(ds.Tables("semesterstude,studeprofile"))
                ReportViewer.ReportSource = obj
                ReportViewer.Refresh()
                conn.Close()
            Else
                str = "select p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, p.Sex, p.BirthDate, p.Age, p.MobileNumber, p.College, ss.Course, ss.YearLevel, ss.Semester, ss.SY, ss.Section, ss.Track, ss.Qualification, ss.BalikAral, ss.IP, ss.FourPs from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.SY='" & frmParent.lblSY.Text & "' and ss.Semester='" & frmParent.lblSem.Text & "' and ss.YearLevel='" & cboGradeLevel.Text & "' and ss.Section='" & cboSection.Text & "' and p.Age='" & txtAge.Text & "' and ss.Status='Enrolled' order by p.Sex, p.LastName"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "semesterstude,studeprofile")
                Dim obj As New AgesReport
                obj.SetDataSource(ds.Tables("semesterstude,studeprofile"))
                ReportViewer.ReportSource = obj
                ReportViewer.Refresh()
                conn.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getYearLevel()
        Try
            If frmParent.lblSem.Text = "" Then
                str = "select * from course_table where CourseCode='JHS'"
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
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmAgesReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getYearLevel()
    End Sub

    Private Sub cboGradeLevel_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGradeLevel.SelectedIndexChanged
        getSection()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class