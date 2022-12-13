Imports MySql.Data.MySqlClient
Public Class frmGuardianReportDashboard
    Dim str As String

    Public Sub getCourseMajor()
        Try
            Str = "select * from course_table where CourseDescription='" & cboCourse.Text & "' order by Major"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "course_table")
            conn.Close()
            cboYear.ValueMember = "course_table"
            cboYear.DisplayMember = "Major"
            cboYear.DataSource = ds.Tables("course_table")
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
    Public Sub getSection()
        Try
            str = "select * from sections where YearLevel='" & cboYear.Text & "' order by Section"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "sections")
            conn.Close()

            cboSection.ValueMember = "sections"
            cboSection.DisplayMember = "Section"
            cboSection.DataSource = ds.Tables("sections")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmGuardianReportDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getCourse()
    End Sub

    Private Sub cboCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCourse.SelectedIndexChanged
        getCourseMajor()
    End Sub

    Private Sub cboYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYear.SelectedIndexChanged
        getSection()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "select p.Guardian, p.GuardianAddress, p.GuardianContact, concat(s.LName,', ',s.FName) as StudeName, s.YearLevel, s.Section, s.SY, st.SchoolName, st.SchoolAddress, st.telNo, st.depedlogo, st.region, st.division from studeprofile p join semesterstude s on p.StudentNumber=s.StudentNumber join srms_settings st on s.settingsID=st.settingsID where s.YearLevel='" & cboYear.Text & "' and s.Section='" & cboSection.Text & "' and s.Semester='" & frmParent.lblSem.Text & "' and s.SY='" & frmParent.lblSY.Text & "' order by p.Guardian"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude, srms_settings")
            Dim obj As New GuardianList
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude, srms_settings"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click
        Try
            str = "select p.Guardian, p.GuardianAddress, p.GuardianContact, concat(s.LName,', ',s.FName) as StudeName, s.YearLevel, s.Section, s.SY, st.SchoolName, st.SchoolAddress, st.telNo, st.depedlogo, st.region, st.division from studeprofile p join semesterstude s on p.StudentNumber=s.StudentNumber join srms_settings st on s.settingsID=st.settingsID where s.Semester='" & frmParent.lblSem.Text & "' and s.SY='" & frmParent.lblSY.Text & "' order by p.Guardian"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude, srms_settings")
            Dim obj As New GuardianList
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude, srms_settings"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class