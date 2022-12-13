Imports MySql.Data.MySqlClient
Public Class frmGradForm
    Dim str As String
    Public Sub getSection()
        Try
            Str = "select * from sections where YearLevel='" & cboYearLevel.Text & "' order by Section"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
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
    Public Sub getCourse()
        Try
            If frmParent.lblSem.Text = "1st Sem." Or frmParent.lblSem.Text = "2nd Sem." Then
                Str = "select * from course_table where CourseDescription='Senior High School' group by CourseDescription order by CourseDescription"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(Str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "course_table")
                conn.Close()

                cboCourse.ValueMember = "course_table"
                cboCourse.DisplayMember = "CourseDescription"
                cboCourse.DataSource = ds.Tables("course_table")
                conn.Close()
            Else
                Str = "select * from course_table where CourseDescription!='Senior High School' group by CourseDescription order by CourseDescription"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(Str, conn)
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
    Public Sub getCourseMajor()
        Try
            Str = "select * from course_table where CourseDescription='" & cboCourse.Text & "' order by Major"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
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

    Private Sub frmGradForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getCourse()
    End Sub

    Private Sub cboCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCourse.SelectedIndexChanged
        getCourseMajor()
    End Sub

    Private Sub cboYearLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYearLevel.SelectedIndexChanged
        getSection()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "select * from semesterstude where Course='" & cboCourse.Text & "' and YearLevel='" & cboYearLevel.Text & "' and Section='" & cboSection.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' order by LName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude")
            dg1.DataSource = ds.Tables("semesterstude")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Student Number"
            dg1.Columns(2).HeaderText = "First Name"
            dg1.Columns(2).Width = 150
            dg1.Columns(3).HeaderText = "Middle Name"
            dg1.Columns(3).Width = 150
            dg1.Columns(4).HeaderText = "Last Name"
            dg1.Columns(4).Width = 150

            dg1.Columns(5).Visible = False
            dg1.Columns(6).Visible = False
            dg1.Columns(7).Visible = False
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False
            dg1.Columns(10).Visible = False
            dg1.Columns(11).Visible = False
            dg1.Columns(12).Visible = False
            dg1.Columns(13).Visible = False
            dg1.Columns(14).Visible = False
            dg1.Columns(15).Visible = False
            dg1.Columns(16).Visible = False
            dg1.Columns(17).Visible = False
            dg1.Columns(18).Visible = False
            dg1.Columns(19).Visible = False
            dg1.Columns(20).Visible = False
            dg1.Columns(21).Visible = False
            dg1.Columns(22).Visible = False
            dg1.Columns(23).Visible = False
            dg1.Columns(24).Visible = False
            dg1.Columns(25).Visible = False
            dg1.Columns(26).Visible = False
            dg1.Columns(27).Visible = False
            dg1.Columns(28).Visible = False
            dg1.Columns(29).Visible = False
            dg1.Columns(30).Visible = False
            dg1.Columns(31).Visible = False
            dg1.Columns(32).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class