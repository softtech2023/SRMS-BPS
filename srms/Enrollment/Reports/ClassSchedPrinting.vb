Imports MySql.Data.MySqlClient
Public Class frmClassSchedPrinting
    Dim str As String
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "select * from semsubjects where Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Course='" & cboCourse.Text & "' and YearLevel='" & cboYearLevel.Text & "' and Section='" & cboSection.Text & "' order by Description"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semsubjects")
            Dim obj As New Schedules
            obj.SetDataSource(ds.Tables("semsubjects"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            conn.Close()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
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

    Private Sub frmClassSchedPrinting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getSection()
        getCourse()
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
            str = "select * from course_table group by CourseDescription order by CourseDescription"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "course_table")
            conn.Close()

            cboCourse.ValueMember = "course_table"
            cboCourse.DisplayMember = "CourseDescription"
            cboCourse.DataSource = ds.Tables("course_table")

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
End Class