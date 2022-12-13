Imports MySql.Data.MySqlClient
Public Class frmSchoolRegisterForm
    Dim str As String
    Public Sub getCourse()
        Try
            str = "select * from course_table group by CourseDescription order by CourseDescription"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "course_table")
            conn.Close()

            cboDepartment.ValueMember = "course_table"
            cboDepartment.DisplayMember = "CourseDescription"
            cboDepartment.DataSource = ds.Tables("course_table")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmSchoolRegisterForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getCourse()
    End Sub
    Public Sub getCourseMajor()
        Try
            str = "select * from course_table where CourseDescription='" & cboDepartment.Text & "' order by Major"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "course_table")
            conn.Close()
            cboGradeLevel.ValueMember = "course_table"
            cboGradeLevel.DisplayMember = "Major"
            cboGradeLevel.DataSource = ds.Tables("course_table")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepartment.SelectedIndexChanged
        getCourseMajor()
    End Sub

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

    Private Sub cboGradeLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGradeLevel.SelectedIndexChanged
        getSection()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            str = "select p.StudentNumber, p.LastName, p.FirstName, p.MiddleName, p.Sex, p.BirthDate, p.Age, p.Ethnicity, p.Religion, p.Sitio, p.Brgy, p.City, p.Province, p.Father, p.Mother, p.Guardian, p.GuardianRelationship, p.GuardianContact, ss.SY, ss.Semester, ss.YearLevel, ss.Section from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.SY='" & frmParent.lblSY.Text & "' and ss.Semester='" & frmParent.lblSem.Text & "' and ss.YearLevel='" & cboGradeLevel.Text & "' and ss.Section='" & cboSection.Text & "' order by p.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude,studeprofile")
            Dim obj As New SchoolRegisterReport
            obj.SetDataSource(ds.Tables("semesterstude,studeprofile"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class