Imports MySql.Data.MySqlClient
Public Class frmSubjects
    Dim str As String
    Private Sub frmSubjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.DataSet.courses)

        getCourseMajor()
        FormLoad()
    End Sub

    Public Sub FormLoad()
        Try
            txtSubjectCode.Clear()
            txtdescription.Clear()
            txtLecUnits.Clear()
            txtLabUnits.Clear()
            txtPreq.Clear()
            txtCurriculum.Clear()
            txtSubjectCode.Focus()

            str = "select * from subjects order by SubjectCode"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "subjects")
            dgsubjects.DataSource = ds.Tables("subjects")
            conn.Close()

            dgsubjects.Columns(0).Visible = False
            dgsubjects.Columns(1).HeaderText = "Subject Code"
            dgsubjects.Columns(2).Width = 350
            dgsubjects.Columns(2).HeaderText = "Subject Description"
            dgsubjects.Columns(3).HeaderText = "Units"
            dgsubjects.Columns(3).Width = 60
            dgsubjects.Columns(4).Visible = False

            dgsubjects.Columns(5).Visible = False
            dgsubjects.Columns(6).Visible = False
            dgsubjects.Columns(7).Visible = True
            dgsubjects.Columns(8).Visible = False
            dgsubjects.Columns(9).Visible = True
            dgsubjects.Columns(9).Width = 150
            dgsubjects.Columns(9).HeaderText = "Department"
            dgsubjects.Columns(10).Visible = False
            dgsubjects.Columns(11).Visible = False
            dgsubjects.Columns(12).Visible = False


            tsSave.Enabled = True
            tsUpdate.Enabled = False
            tsDelete.Enabled = False

            getCourseMajor()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub DataGridView1_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgsubjects.DoubleClick
        Try
            Dim dclick As Integer
            dclick = dgsubjects.CurrentRow.Index
            lblID.Text = dgsubjects.Item(0, dclick).Value
            txtSubjectCode.Text = dgsubjects.Item(1, dclick).Value
            txtdescription.Text = dgsubjects.Item(2, dclick).Value
            txtLecUnits.Text = dgsubjects.Item(3, dclick).Value
            txtLabUnits.Text = dgsubjects.Item(4, dclick).Value
            txtPreq.Text = dgsubjects.Item(5, dclick).Value
            txtCurriculum.Text = dgsubjects.Item(6, dclick).Value
            cboYearLevel.Text = dgsubjects.Item(7, dclick).Value
            cboSemester.Text = dgsubjects.Item(8, dclick).Value
            cboCourse.Text = dgsubjects.Item(9, dclick).Value
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        tsSave.Enabled = False
        tsUpdate.Enabled = True
        tsDelete.Enabled = True
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Try
            str = "select * from subjects where SubjectCode like '%" & txtsearch.Text & "%' or description like '%" & txtsearch.Text & "%' "
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "subjects")
            dgsubjects.DataSource = ds.Tables("subjects")
            conn.Close()

            dgsubjects.Columns(0).Visible = False
            dgsubjects.Columns(1).HeaderText = "Subject Code"
            dgsubjects.Columns(2).Width = 350
            dgsubjects.Columns(2).HeaderText = "Subject Description"
            dgsubjects.Columns(3).HeaderText = "Units"
            dgsubjects.Columns(3).Width = 60
            dgsubjects.Columns(4).Visible = False

            dgsubjects.Columns(5).Visible = False
            dgsubjects.Columns(6).Visible = False
            dgsubjects.Columns(7).Visible = True
            dgsubjects.Columns(8).Visible = False
            dgsubjects.Columns(9).Visible = True
            dgsubjects.Columns(9).Width = 150
            dgsubjects.Columns(9).HeaderText = "Department"
            dgsubjects.Columns(10).Visible = False
            dgsubjects.Columns(11).Visible = False
            dgsubjects.Columns(12).Visible = False


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            If cboCourse.Text = "" Then
                MsgBox("Course is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If cboYearLevel.Text = "" Then
                MsgBox("Grade Level is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If


            If txtSubjectCode.Text = "" Then
                MsgBox("Subject Code is required", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txtdescription.Text = "" Then
                MsgBox("Subject Description is required", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txtLecUnits.Text = "" Then
                MsgBox("Subject unit is required!", MsgBoxStyle.Exclamation)
                txtLecUnits.Focus()
                Exit Sub
            End If


            str = "insert into subjects values('0','" & txtSubjectCode.Text & "','" & txtdescription.Text & "','" & txtLecUnits.Text & "','0','" & txtPreq.Text & "','" & txtCurriculum.Text & "','" & cboYearLevel.Text & "','" & cboSemester.Text & "','" & cboCourse.Text & "','" & cboSemEffective.Text & "','" & txtSYEffective.Text & "','" & txtEffective.Text & "')"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            MsgBox("Data successfully added!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
            btnViewSubjects.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            str = "update subjects set subjectid='" & lblID.Text & "',SubjectCode='" & txtSubjectCode.Text & "',description='" & txtdescription.Text & "',lecunit='" & txtLecUnits.Text & "',labunit='" & txtLabUnits.Text & "',prereq='" & txtPreq.Text & "',curriculum='" & txtCurriculum.Text & "',YearLevel='" & cboYearLevel.Text & "',Semester='" & cboSemester.Text & "',Course='" & cboCourse.Text & "',SemEffective='" & cboSemEffective.Text & "',SYEffective='" & txtSYEffective.Text & "',Effectivity='" & txtEffective.Text & "' where subjectid='" & lblID.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            MsgBox("Data has been updated!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
            btnViewSubjects.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If txtSubjectCode.Text = "" Then
                MsgBox("Please select a subject you want to delete!", MsgBoxStyle.Information)
                Exit Sub
            End If

            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from subjects where subjectid='" & lblID.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                MsgBox("Data successfully deleted!", MsgBoxStyle.Information, "Prompt")
                conn.Close()
                FormLoad()
                btnViewSubjects.PerformClick()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        tsSave.PerformClick()
    End Sub

    Private Sub btnViewSubjects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewSubjects.Click
        Try
            str = "select * from subjects where Course='" & cboCourse.Text & "' and YearLevel='" & cboYearLevel.Text & "' order by SubjectCode"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "subjects")
            dgsubjects.DataSource = ds.Tables("subjects")
            conn.Close()

            dgsubjects.Columns(0).Visible = False
            dgsubjects.Columns(1).HeaderText = "Subject Code"
            dgsubjects.Columns(2).Width = 350
            dgsubjects.Columns(2).HeaderText = "Subject Description"
            dgsubjects.Columns(3).HeaderText = "Units"
            dgsubjects.Columns(3).Width = 60
            dgsubjects.Columns(4).Visible = False

            dgsubjects.Columns(5).Visible = False
            dgsubjects.Columns(6).Visible = False
            dgsubjects.Columns(7).Visible = True
            dgsubjects.Columns(8).Visible = False
            dgsubjects.Columns(9).Visible = True
            dgsubjects.Columns(9).Width = 150
            dgsubjects.Columns(9).HeaderText = "Department"
            dgsubjects.Columns(10).Visible = False
            dgsubjects.Columns(11).Visible = False
            dgsubjects.Columns(12).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
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

    Private Sub cboCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCourse.SelectedIndexChanged
        getCourseMajor()
    End Sub
End Class