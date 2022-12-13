Imports MySql.Data.MySqlClient
Public Class frmSummary
    Dim str As String
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If lblTitle.Text = "By Department" Then
                str = "SELECT s.Course, count(s.Status) as StatusCount, s.Status, s.YearLevel, count(s.Course) as EnrolledCount, s.Semester, s.SY  FROM semesterstude s where s.Semester='" & frmParent.lblSem.Text & "' and s.SY='" & frmParent.lblSY.Text & "' group by s.Course, s.YearLevel"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysDA.Fill(ds, "studeprofile, semesterstude")
                '.DataSource = ds.Tables("studeprofile, semesterstude")
                conn.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getCourse()
        Try

            If frmParent.lblSem.Text = "1st Sem." Or frmParent.lblSem.Text = "2nd Sem" Then
                cboDepartment.Text = "Senior High School"

            Else

                str = "select * from course_table where CourseDescription!='Senior High School' group by CourseDescription order by CourseDescription"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "course_table")
                conn.Close()

                cboDepartment.ValueMember = "course_table"
                cboDepartment.DisplayMember = "CourseDescription"
                cboDepartment.DataSource = ds.Tables("course_table")
                conn.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getCourse()
        getCourseMajor()
        getSection()
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
            'By Religion
            If lblTitle.Text = "By Religion" Then
                If cboGradeLevel.Text = "" And cboSection.Text = "" Then
                    str = "select p.Religion, count(Religion), p.Sex, ss.YearLevel, ss.Section, ss.Semester, ss.SY, sr.SchoolName, sr.SchoolAddress, sr.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Status='Enrolled' group by p.Religion order by p.Religion"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim ds As New DataSet
                    mysda.Fill(ds, "studeprofile, semesterstude")
                    Dim obj As New ReligionCounts
                    obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
                    frmMainViewer.ReportViewer.ReportSource = obj
                    frmMainViewer.ReportViewer.Refresh()
                    frmMainViewer.MdiParent = frmParent
                    frmMainViewer.Show()
                    conn.Close()
                    Me.Close()
                Else
                    str = "select p.Religion, count(Religion), p.Sex, ss.YearLevel, ss.Section, ss.Semester, ss.SY, sr.SchoolName, sr.SchoolAddress, sr.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where ss.YearLevel='" & cboGradeLevel.Text & "' and ss.Section='" & cboSection.Text & "' and Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Status='Enrolled' group by p.Religion order by p.Religion"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim ds As New DataSet
                    mysda.Fill(ds, "studeprofile, semesterstude")
                    Dim obj As New ReligionCounts
                    obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
                    frmMainViewer.ReportViewer.ReportSource = obj
                    frmMainViewer.ReportViewer.Refresh()
                    frmMainViewer.MdiParent = frmParent
                    frmMainViewer.Show()
                    conn.Close()
                    Me.Close()
                End If
            ElseIf lblTitle.Text = "By Municipality" Then
                'By Municipality
                If lblTitle.Text = "By Municipality" Then
                    str = "select p.City, count(City), p.Sex, ss.YearLevel, ss.Section, ss.Semester, ss.SY, sr.SchoolName, sr.SchoolAddress, sr.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.YearLevel='" & cboGradeLevel.Text & "' and ss.Section='" & cboSection.Text & "' and ss.Status='Enrolled' group by p.City order by p.City "
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim ds As New DataSet
                    mysda.Fill(ds, "studeprofile, semesterstude")
                    Dim obj As New EnrolledPerMunicipality
                    obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
                    frmMainViewer.ReportViewer.ReportSource = obj
                    frmMainViewer.ReportViewer.Refresh()
                    frmMainViewer.MdiParent = frmParent
                    frmMainViewer.Show()
                    conn.Close()
                    Me.Close()
                End If
            ElseIf lblTitle.Text = "By Gender" Then
                'By Gender
                If cboGradeLevel.Text = "" And cboSection.Text = "" Then
                    str = "select p.Sex, count(Sex), ss.YearLevel, ss.Section, ss.Semester, ss.SY, sr.SchoolName, sr.SchoolAddress, sr.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Status='Enrolled' group by p.Sex order by p.Sex"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim ds As New DataSet
                    mysda.Fill(ds, "studeprofile, semesterstude")
                    Dim obj As New Sex
                    obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
                    frmMainViewer.ReportViewer.ReportSource = obj
                    frmMainViewer.ReportViewer.Refresh()
                    frmMainViewer.MdiParent = frmParent
                    frmMainViewer.Show()
                    conn.Close()
                    Me.Close()
                Else
                    str = "select p.Sex, count(Sex), ss.YearLevel, ss.Section, ss.Semester, ss.SY, sr.SchoolName, sr.SchoolAddress, sr.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.YearLevel='" & cboGradeLevel.Text & "' and ss.Section='" & cboSection.Text & "' and ss.Status='Enrolled' group by p.Sex order by p.Sex"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim ds As New DataSet
                    mysda.Fill(ds, "studeprofile, semesterstude")
                    Dim obj As New Sex
                    obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
                    frmMainViewer.ReportViewer.ReportSource = obj
                    frmMainViewer.ReportViewer.Refresh()
                    frmMainViewer.MdiParent = frmParent
                    frmMainViewer.Show()
                    conn.Close()
                    Me.Close()
                End If
            Else
                'Ethnicity
                str = "select p.Ethnicity, count(Ethnicity), p.Sex, ss.YearLevel, ss.Section, ss.Semester, ss.SY, ss.Course, ss.YearLevel, ss.Section, sr.SchoolName, sr.SchoolAddress, sr.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.YearLevel='" & cboGradeLevel.Text & "' and ss.Section='" & cboSection.Text & "' and ss.Status='Enrolled' group by p.Ethnicity order by p.Ethnicity"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studeprofile, semesterstude")
                Dim obj As New EthnicityChart
                obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                conn.Close()
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class