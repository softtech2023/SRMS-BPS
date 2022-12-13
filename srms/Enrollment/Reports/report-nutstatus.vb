Imports MySql.Data.MySqlClient
Public Class frmReportNutStatus
    Dim str As String
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            'str = "select p.StudentNumber, p.LastName, p.FirstName, p.BirthDate, p.Age, p.Sex, s.weight, s.height, s.heightSqr, s.bmi, s.nutStatus, s.hfa, s.weighingDate, s.YearLevel, s.Section, s.Semester, s.SY, st.SchoolName, st.SchoolAddress from studeprofile p join semesterstude s on p.StudentNumber=s.StudentNumber join srms_settings st on s.settingsID=st.settingsID where s.Semester='" & frmParent.lblSem.Text & "' and s.SY='" & frmParent.lblSY.Text & "' and s.Course='" & cboCourse.Text & "' and s.YearLevel='" & cboYearLevel.Text & "' and s.Section='" & cboSection.Text & "' order by p.LastName"
            str = "select p.StudentNumber, p.LastName, p.FirstName, p.BirthDate, p.Age, p.Sex, s.YearLevel, s.Section, s.Adviser, s.Semester, s.SY, st.SchoolName, st.SchoolAddress, nt.weight, nt.height, nt.heightSqr, nt.bmi, nt.nutStatus, nt.hfa, nt.sy, nt.nutType, nt.weighingDate from studeprofile p join nutstatus nt on p.StudentNumber=nt.StudentNumber join semesterstude s on p.StudentNumber=s.StudentNumber join srms_settings st on s.settingsID=st.settingsID where s.Semester='" & frmParent.lblSem.Text & "' and s.SY='" & frmParent.lblSY.Text & "' and s.Course='" & cboCourse.Text & "' and s.YearLevel='" & cboYearLevel.Text & "' and s.Section='" & cboSection.Text & "' and nt.nutType='" & cboType.Text & "' and nt.sy='" & frmParent.lblSY.Text & "' and s.Status='Enrolled' order by p.LastName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(Str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude, srms_settings")
            Dim obj As New NutStatus
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude, srms_settings"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            conn.Close()
            Me.Hide()
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

    Private Sub cboCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCourse.SelectedIndexChanged
        getCourseMajor()

    End Sub

    Private Sub cboYearLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYearLevel.SelectedIndexChanged
        getSection()
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

    Private Sub frmReportNutStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getCourse()
    End Sub
End Class