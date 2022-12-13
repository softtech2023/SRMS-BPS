Imports MySql.Data.MySqlClient
Public Class frmSemStudent
    Dim str As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmStudeProfile.Show()
    End Sub

    Private Sub frmSemStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Reload()
        cboScholarship.ResetText()
        cboCourse.ResetText()
        cboYear.ResetText()
        cboSection.ResetText()

        tsSave.Enabled = False
        tsUpdate.Enabled = False
        tsDelete.Enabled = False


    End Sub

    Private Sub btnCOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCOR.MdiParent = Me
        frmCOR.Show()
        frmCOR.mskStudentNumber.Text = mskStudentNumber.Text
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Reload()
    End Sub

    Public Sub PayingStatus()
        If cboAccountStatus.SelectedIndex = 0 Then
            txtGrantAmount.Enabled = False
            cboScholarship.Enabled = False
            cboScholarship.ResetText()
        End If
        If cboAccountStatus.SelectedIndex = 1 Then
            txtGrantAmount.Enabled = True
            cboScholarship.Enabled = True
        End If
    End Sub

    Private Sub txtGrantAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGrantAmount.TextChanged
        PayingStatus()
    End Sub

    Private Sub cboScholarship_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboScholarship.SelectedIndexChanged
        PayingStatus()
    End Sub

    Private Sub cboAccountStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAccountStatus.SelectedIndexChanged
        PayingStatus()
    End Sub
    Public Sub Reload()
        Try

            mskStudentNumber.Clear()
            txtFname.Clear()
            txtMName.Clear()
            txtLastName.Clear()
            cboYear.ResetText()
            cboSection.ResetText()
            cboCourse.ResetText()
            cboMajor.ResetText()
            cboScholarship.ResetText()
            mskFrom.Clear()
            mskTo.Clear()
            mskAssessmentDate.Clear()
            cboAssessmentResult.ResetText()
            cboAccountStatus.ResetText()
            cboStudeStatus.ResetText()
            cboYearStat.ResetText()
            cboTrack.ResetText()
            cboQualification.ResetText()
            cboTrack.Enabled = False
            cboQualification.Enabled = False
            mskStudentNumber.Focus()

            getSection()
            getCourse()
            getCourseMajor()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try

            If cboCourse.Text = "" Then
                MsgBox("Course is required!", MsgBoxStyle.Exclamation)
                cboCourse.Focus()
                Exit Sub
            End If

            If cboSection.Text = "" Then
                MsgBox("Section is required!", MsgBoxStyle.Exclamation)
                cboSection.Focus()
                Exit Sub
            End If

            If cboStudeStatus.Text = "" Then
                MsgBox("Student Status is required!", MsgBoxStyle.Exclamation)
                cboStudeStatus.Focus()
                Exit Sub
            End If

            str = "select * from semesterstude where StudentNumber='" & mskStudentNumber.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude")
            conn.Close()

            If ds.Tables("semesterstude").Rows.Count = 1 Then
                MsgBox("Student Number already exist!", MsgBoxStyle.Exclamation)
                conn.Close()
                mskStudentNumber.Focus()
                Exit Sub
            End If

            str = "insert into semesterstude values('0','" & mskStudentNumber.Text & "','" & txtFname.Text & "','" & txtMName.Text & "','" & txtLastName.Text & "','" & cboCourse.Text & "','" & cboYear.Text & "','" & cboStatus.Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "','" & frmParent.lblTerm.Text & "','" & cboSection.Text & "','" & cboStudeStatus.Text & "','" & cboScholarship.Text & "','" & mskFrom.Text & "','" & mskTo.Text & "','" & mskAssessmentDate.Text & "','" & cboAssessmentResult.Text & "','" & cboAccountStatus.Text & "','" & txtGrantAmount.Text & "','" & cboYearStat.Text & "','" & cboMajor.Text & "','" & cboTrack.Text & "','" & cboQualification.Text & "')"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            'MsgBox("Data successfully saved!", MsgBoxStyle.Information, "Prompt")
            conn.Close()

            'update profile
            str = "update studeprofile set Course='" & cboCourse.Text & "' where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysC2 As New MySqlCommand(str, conn)
            mysC2.ExecuteNonQuery()
            MsgBox("Data successfully saved!", MsgBoxStyle.Information)
            conn.Close()
            Reload()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
        tsSave.Enabled = False
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try

            str = "update semesterstude set StudentNumber='" & mskStudentNumber.Text & "',FName='" & txtFname.Text & "',MName='" & txtMName.Text & "',LName='" & txtLastName.Text & "',Course='" & cboCourse.Text & "',YearLevel='" & cboYear.Text & "',Status='" & cboStatus.Text & "',Semester='" & frmParent.lblSem.Text & "',SY='" & frmParent.lblSY.Text & "',Term='" & frmParent.lblTerm.Text & "',Section='" & cboSection.Text & "',StudeStatus='" & cboStudeStatus.Text & "',Scholarship='" & cboScholarship.Text & "',DurationFrom='" & mskFrom.Text & "',DurationTo='" & mskTo.Text & "',AssessmentDate='" & mskAssessmentDate.Text & "',AssessmentResult='" & cboAssessmentResult.Text & "',PayingStatus='" & cboAccountStatus.Text & "',GrantAmount='" & txtGrantAmount.Text & "',YearLevelStat='" & cboYearStat.Text & "',semstudentid='" & lblID.Text & "',Major='" & cboMajor.Text & "',Track='" & cboTrack.Text & "',Qualification='" & cboQualification.Text & "' where semstudentid='" & lblID.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            '  MsgBox("Data successfully updated!", MsgBoxStyle.Information)
            conn.Close()

            'update profile
            str = "update studeprofile set Course='" & cboCourse.Text & "' where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysC2 As New MySqlCommand(str, conn)
            mysC2.ExecuteNonQuery()
            'MsgBox("Data successfully updated", MsgBoxStyle.Information)
            conn.Close()

            'update course in student's account
            str = "update studeaccount set Course='" & cboCourse.Text & "',YearLevel='" & cboYear.Text & "' where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysC3 As New MySqlCommand(str, conn)
            mysC3.ExecuteNonQuery()
            MsgBox("Data successfully updated", MsgBoxStyle.Information)
            conn.Close()
            Reload()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        tsSave.Enabled = False
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from semesterstude where semstudentid='" & lblID.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                MsgBox("Data successfully deleted!", MsgBoxStyle.Information)
                conn.Close()
                Reload()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        tsSave.Enabled = False
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Reload()
        Me.Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        tsNew.PerformClick()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        tsSave.PerformClick()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        tsUpdate.PerformClick()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        tsDelete.PerformClick()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSearchEnrollees.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        frmSearchEnrollees.ShowDialog()
    End Sub

    Private Sub tsNew_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsNew.Click
        Reload()
        frmSearchStudents.ShowDialog()
        frmSearchStudents.txtSearch.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        tsSave.PerformClick()
    End Sub
    Public Sub getCourseMajor()
        Try
            str = "select * from course_table where CourseDescription='" & cboCourse.Text & "' order by Major"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "course_table")

            cboYear.ValueMember = "course_table"
            cboYear.DisplayMember = "Major"
            cboYear.DataSource = ds.Tables("course_table")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCourse.SelectedIndexChanged
        getCourseMajor()
        getTrack()
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
    Public Sub getSection()
        Try
            str = "select * from sections order by Section"
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

    Public Sub getQualification()
        Try

            str = "select * from qualifications where Track='" & cboTrack.Text & "' order by Qualification"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "qualifications")
            conn.Close()

            cboQualification.ValueMember = "Qualification"
            cboQualification.DisplayMember = "Qualification"
            cboQualification.DataSource = ds.Tables("qualifications")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try

    End Sub
    Public Sub getTrack()
        Try

            If cboCourse.Text = "Senior High School" Then
                cboTrack.Enabled = True

                str = "select * from qualifications group by Track order by Track"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "qualifications")
                conn.Close()

                cboTrack.ValueMember = "Track"
                cboTrack.DisplayMember = "Track"
                cboTrack.DataSource = ds.Tables("qualifications")
                cboQualification.Enabled = True
            Else
                cboTrack.ResetText()
                cboQualification.Enabled = False
                cboQualification.ResetText()
                cboTrack.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboTrack_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrack.SelectedIndexChanged
        getQualification()
    End Sub
End Class