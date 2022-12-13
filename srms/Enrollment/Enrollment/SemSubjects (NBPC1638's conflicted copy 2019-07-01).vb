Imports MySql.Data.MySqlClient
Public Class frmSemSubjects
    Dim str As String

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchInstructor.Click
        frmSearchInstructors_Scheduling.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSearchSubjects.Show()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            str = "insert into semsubjects values('0','" & txtSubjectCode.Text & "','" & txtSubjectDescription.Text & "','" & txtLecUnits.Text & "','" & txtLabUnits.Text & "','" & cboSection.Text & "','" & txtLab.Text & "','" & txtTime.Text & "','" & txtRoom.Text & "','" & txtSlot.Text & "','" & txtInstructor.Text & "')"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            MsgBox("Data successfully saved!", MsgBoxStyle.Information, "Prompt")
            conn.Close()
            Formload()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSubjects.Show()
    End Sub

    Private Sub frmSemSubjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Formload()
        getCourse()
        getSection()
        getRooms()
        'cboCourse.ResetText()
        'cboYearLevel.ResetText()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtSubjectCode.Enabled = True
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Try
            If chkSubjectCode.Checked = True Then

                str = "select * from semsubjects where SubjectCode like '%" & txtsearch.Text & "%' and SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "'"
                conn.Open()
                Dim Search As New MySqlDataAdapter(str, conn)
                Dim ds As DataSet = New DataSet
                Search.Fill(ds, "semsubjects")
                dgsubjects.DataSource = ds.Tables("semsubjects")
                conn.Close()
                dgsubjects.Columns(0).Visible = False
                dgsubjects.Columns(1).Width = 100
                dgsubjects.Columns(1).HeaderText = "Subject Code"
                dgsubjects.Columns(2).Width = 200
                dgsubjects.Columns(3).Visible = False
                dgsubjects.Columns(4).Visible = False
                dgsubjects.Columns(5).Width = 100
                dgsubjects.Columns(6).Visible = False
                dgsubjects.Columns(7).Width = 180
                dgsubjects.Columns(7).HeaderText = "Schedule"
                dgsubjects.Columns(9).Visible = False
                dgsubjects.Columns(10).Visible = False
                dgsubjects.Columns(11).Visible = False
                dgsubjects.Columns(12).Visible = False
                dgsubjects.Columns(13).Width = 150
                dgsubjects.Columns(13).HeaderText = "Teacher"
                dgsubjects.Columns(14).Visible = False
                dgsubjects.Columns(15).Visible = False
                dgsubjects.Columns(16).Visible = False
                dgsubjects.Columns(17).Visible = False
                dgsubjects.Columns(18).Visible = False
                dgsubjects.Columns(19).Visible = False
                dgsubjects.Columns(20).Visible = False
                dgsubjects.Columns(21).Visible = False
                dgsubjects.Columns(22).Visible = False
                dgsubjects.Columns(23).Visible = False
                dgsubjects.Columns(24).Visible = False
                dgsubjects.Columns(25).Visible = False
                dgsubjects.Columns(26).Visible = False
            Else

                str = "select * from semsubjects where Description like '%" & txtsearch.Text & "%' and SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "'"
                conn.Open()
                Dim Search As New MySqlDataAdapter(str, conn)
                Dim ds As DataSet = New DataSet
                Search.Fill(ds, "semsubjects")
                dgsubjects.DataSource = ds.Tables("semsubjects")
                conn.Close()
            End If
            dgsubjects.Columns(0).Visible = False
            dgsubjects.Columns(1).Width = 100
            dgsubjects.Columns(1).HeaderText = "Subject Code"
            dgsubjects.Columns(2).Width = 200
            dgsubjects.Columns(3).Visible = False
            dgsubjects.Columns(4).Visible = False
            dgsubjects.Columns(5).Width = 100
            dgsubjects.Columns(6).Visible = False
            dgsubjects.Columns(7).Width = 180
            dgsubjects.Columns(7).HeaderText = "Schedule"
            dgsubjects.Columns(9).Visible = False
            dgsubjects.Columns(10).Visible = False
            dgsubjects.Columns(11).Visible = False
            dgsubjects.Columns(12).Visible = False
            dgsubjects.Columns(13).Width = 150
            dgsubjects.Columns(13).HeaderText = "Teacher"
            dgsubjects.Columns(14).Visible = False
            dgsubjects.Columns(15).Visible = False
            dgsubjects.Columns(16).Visible = False
            dgsubjects.Columns(17).Visible = False
            dgsubjects.Columns(18).Visible = False
            dgsubjects.Columns(19).Visible = False
            dgsubjects.Columns(20).Visible = False
            dgsubjects.Columns(21).Visible = False
            dgsubjects.Columns(22).Visible = False
            dgsubjects.Columns(23).Visible = False
            dgsubjects.Columns(24).Visible = False
            dgsubjects.Columns(25).Visible = False
            dgsubjects.Columns(26).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dgsubjects_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgsubjects.DoubleClick
        Try
            Dim dclick As Integer
            dclick = dgsubjects.CurrentRow.Index
            lblID.Text = dgsubjects.Item(0, dclick).Value
            txtSubjectCode.Text = dgsubjects.Item(1, dclick).Value
            txtSubjectDescription.Text = dgsubjects.Item(2, dclick).Value
            txtLecUnits.Text = dgsubjects.Item(3, dclick).Value
            txtLabUnits.Text = dgsubjects.Item(4, dclick).Value
            cboSection.Text = dgsubjects.Item(5, dclick).Value
            txtLab.Text = dgsubjects.Item(6, dclick).Value
            txtTime.Text = dgsubjects.Item(7, dclick).Value
            txtRoom.Text = dgsubjects.Item(8, dclick).Value
            txtSlot.Text = dgsubjects.Item(9, dclick).Value
            txtInstructor.Text = dgsubjects.Item(10, dclick).Value
            'cboSem.Text = dgsubjects.Item(12, dclick).Value
            txtInstructorName.Text = dgsubjects.Item(13, dclick).Value
            cboTime1.Text = dgsubjects.Item(14, dclick).Value
            cboAM1.Text = dgsubjects.Item(15, dclick).Value
            cboTime2.Text = dgsubjects.Item(16, dclick).Value
            cboAM2.Text = dgsubjects.Item(17, dclick).Value
            cboTime3.Text = dgsubjects.Item(18, dclick).Value
            cboAM3.Text = dgsubjects.Item(19, dclick).Value
            cboTime4.Text = dgsubjects.Item(20, dclick).Value
            cboAM4.Text = dgsubjects.Item(21, dclick).Value
            txtDaysLec.Text = dgsubjects.Item(22, dclick).Value
            txtDaysLab.Text = dgsubjects.Item(23, dclick).Value
            cboCourse.Text = dgsubjects.Item(24, dclick).Value
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        tsSave.Enabled = False
        tsUpdate.Enabled = True
        tsDelete.Enabled = True
    End Sub

    Public Sub Formload()
        Try
            str = "select * from semsubjects where Semester ='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' order by SubjectCode"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysDA.Fill(ds, "semsubjects")
            dgsubjects.DataSource = ds.Tables("semsubjects")
            conn.Close()

            dgsubjects.Columns(0).Visible = False
            dgsubjects.Columns(1).Width = 100
            dgsubjects.Columns(1).HeaderText = "Subject Code"
            dgsubjects.Columns(2).Width = 200
            dgsubjects.Columns(3).Visible = False
            dgsubjects.Columns(4).Visible = False
            dgsubjects.Columns(5).Width = 100
            dgsubjects.Columns(6).Visible = False
            dgsubjects.Columns(7).Width = 180
            dgsubjects.Columns(7).HeaderText = "Schedule"
            dgsubjects.Columns(9).Visible = False
            dgsubjects.Columns(10).Visible = False
            dgsubjects.Columns(11).Visible = False
            dgsubjects.Columns(12).Visible = False
            dgsubjects.Columns(13).Width = 150
            dgsubjects.Columns(13).HeaderText = "Teacher"
            dgsubjects.Columns(14).Visible = False
            dgsubjects.Columns(15).Visible = False
            dgsubjects.Columns(16).Visible = False
            dgsubjects.Columns(17).Visible = False
            dgsubjects.Columns(18).Visible = False
            dgsubjects.Columns(19).Visible = False
            dgsubjects.Columns(20).Visible = False
            dgsubjects.Columns(21).Visible = False
            dgsubjects.Columns(22).Visible = False
            dgsubjects.Columns(23).Visible = False
            dgsubjects.Columns(24).Visible = False
            dgsubjects.Columns(25).Visible = False
            dgsubjects.Columns(26).Visible = False
            dgsubjects.Columns(27).Visible = False


            tsSave.Enabled = False
            tsUpdate.Enabled = False
            tsDelete.Enabled = False

            txtSubjectCode.Clear()
            txtSubjectDescription.Clear()
            txtLecUnits.Clear()
            txtLabUnits.Clear()
            'cboSection.ResetText()
            txtLab.Clear()
            txtTime.Clear()
            'txtRoom.ResetText()
            txtSlot.Clear()
            txtInstructor.Clear()
            txtInstructorName.Clear()
            cboTime1.ResetText()
            cboAM1.ResetText()
            cboTime2.ResetText()
            cboAM2.ResetText()
            cboTime3.ResetText()
            cboAM3.ResetText()
            cboTime4.ResetText()
            cboAM4.ResetText()
            'txtDaysLec.Clear()
            'txtDaysLab.Clear()

            'getCourse()
            'getRooms()
            schoolInfo()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Formload()
        Me.Close()
    End Sub
    Public Sub GetSchedule()
        txtTime.Text = cboTime1.Text + cboAM1.Text + "-" + cboTime2.Text + cboAM2.Text + " " + txtDaysLec.Text
        txtLab.Text = cboTime3.Text + cboAM3.Text + "-" + cboTime4.Text + cboAM4.Text + " " + txtDaysLab.Text
    End Sub

  
    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            GetSchedule()

            If cboCourse.Text = "" Then
                MsgBox("Course is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If cboYearLevel.Text = "" Then
                MsgBox("Grade level is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txtSubjectCode.Text = "" Then
                MsgBox("Subject Code is required!", MsgBoxStyle.Exclamation)
                txtSubjectCode.Focus()
                Exit Sub
            End If

            If cboSection.Text = "" Then
                MsgBox("Section is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txtInstructor.Text = "" Then
                MsgBox("Teacher's ID is required!", MsgBoxStyle.Exclamation)
                txtInstructor.Focus()
                Exit Sub
            End If

            'check existing subjects
            str = "select * from semsubjects where SubjectCode='" & txtSubjectCode.Text & "' and Description='" & txtSubjectDescription.Text & "' and Section='" & cboSection.Text & "' and Course='" & cboCourse.Text & "' and YearLevel='" & cboYearLevel.Text & "' and SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semsubjects")
            conn.Close()
            If ds.Tables("semsubjects").Rows.Count = 1 Then
                MsgBox("Selected subject already exist for the current semester!", MsgBoxStyle.Exclamation)
                conn.Close()
                Exit Sub
                conn.Close()
            End If

            'check class room
            str = "select * from semsubjects where Room='" & txtRoom.Text & "' and SchedTime='" & txtTime.Text & "' and SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "'"
            conn.Open()
            Dim mysda1 As New MySqlDataAdapter(str, conn)
            Dim ds1 As New DataSet
            mysda1.Fill(ds1, "semsubjects")
            conn.Close()
            If ds1.Tables("semsubjects").Rows.Count = 1 Then
                MsgBox("Class room is in used!", MsgBoxStyle.Exclamation)
                conn.Close()
                Exit Sub
                conn.Close()
            End If

            'check instructor conflict
            str = "select * from semsubjects where IDNumber='" & txtInstructor.Text & "' and SchedTime='" & txtTime.Text & "' and SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "'"
            conn.Open()
            Dim mysda2 As New MySqlDataAdapter(str, conn)
            Dim ds2 As New DataSet
            mysda2.Fill(ds2, "semsubjects")
            conn.Close()
            If ds2.Tables("semsubjects").Rows.Count = 1 Then
                MsgBox("There is a conflict with the Teacher's schedule!", MsgBoxStyle.Exclamation)
                conn.Close()
                Exit Sub
                conn.Close()
            End If

            Dim subject As String
            subject = txtSubjectDescription.Text.Replace("'", "''")

            str = "insert into semsubjects values('0','" & txtSubjectCode.Text & "','" & subject & "','" & txtLecUnits.Text & "','" & txtLabUnits.Text & "','" & cboSection.Text & "','" & txtLab.Text & "','" & txtTime.Text & "','" & txtRoom.Text & "','" & txtSlot.Text & "','" & txtInstructor.Text & "','" & frmParent.lblSY.Text & "','" & frmParent.lblSem.Text & "','" & txtInstructorName.Text & "','" & cboTime1.Text & "','" & cboAM1.Text & "','" & cboTime2.Text & "','" & cboAM2.Text & "','" & cboTime3.Text & "','" & cboAM3.Text & "','" & cboTime4.Text & "','" & cboAM4.Text & "','" & txtDaysLec.Text & "','" & txtDaysLab.Text & "','" & cboCourse.Text & "','" & cboYearLevel.Text & "','Open','" & lblSettingsID.Text & "')"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            MsgBox("Data successfully added!", MsgBoxStyle.Information)
            conn.Close()

            Formload()
            loadSubjects()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            GetSchedule()
            If txtSubjectCode.Text = "" Then
                MsgBox("Cannot find any data to update!", MsgBoxStyle.Information)
                Exit Sub
            End If
           
            str = "update semsubjects set SubjectCode='" & txtSubjectCode.Text & "',Description='" & txtSubjectDescription.Text & "',LecUnit='" & txtLecUnits.Text & "',LabUnit='" & txtLabUnits.Text & "',Section='" & cboSection.Text & "',LabTime='" & txtLab.Text & "',SchedTime='" & txtTime.Text & "',Room='" & txtRoom.Text & "',Slot='" & txtSlot.Text & "',IDNumber='" & txtInstructor.Text & "',SY='" & frmParent.lblSY.Text & "',Semester='" & frmParent.lblSem.Text & "',Instructor='" & txtInstructorName.Text & "',Time1='" & cboTime1.Text & "',AM1='" & cboAM1.Text & "',Time2='" & cboTime2.Text & "',AM2='" & cboAM2.Text & "',Time3='" & cboTime3.Text & "',AM3='" & cboAM3.Text & "',Time4='" & cboTime4.Text & "',AM4='" & cboAM4.Text & "',Days1='" & txtDaysLec.Text & "',Days2='" & txtDaysLab.Text & "',Course='" & cboCourse.Text & "',YearLevel='" & cboYearLevel.Text & "' where subjectid='" & lblID.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            conn.Close()

            'update CoR
            str = "update registration set Section='" & cboSection.Text & "',LabTime='" & txtLab.Text & "',SchedTime='" & txtTime.Text & "',Room='" & txtRoom.Text & "',Instructor='" & txtInstructorName.Text & "' where SubjectCode='" & txtSubjectCode.Text & "' and Description='" & txtSubjectDescription.Text & "' and Section='" & cboSection.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysC1 As New MySqlCommand(str, conn)
            mysC1.ExecuteNonQuery()
            conn.Close()

            'update CoR
            str = "update grades set Instructor='" & txtInstructorName.Text & "' where SubjectCode='" & txtSubjectCode.Text & "' and Description='" & txtSubjectDescription.Text & "' and Section='" & cboSection.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysC2 As New MySqlCommand(str, conn)
            mysC2.ExecuteNonQuery()
            conn.Close()

            MsgBox("Data successfully updated!", MsgBoxStyle.Information)
            Formload()
            loadSubjects()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If txtSubjectCode.Text = "" Then
                MsgBox("Please select subject to delete!", MsgBoxStyle.Information)
                Exit Sub
            End If
            If (MsgBox("Are you sure you want to delete this subject?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from semsubjects where SubjectCode='" & txtSubjectCode.Text & "' and Description='" & txtSubjectDescription.Text & "' and Section='" & cboSection.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Selected subject has been deleted!", MsgBoxStyle.Information)
                conn.Close()
                Formload()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If cboCourse.Text = "" Then
            MsgBox("Department is required before selecting subjects!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If cboYearLevel.Text = "" Then
            MsgBox("Year level is required before selecting subjects!|", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'Formload()
        frmSearchSubjects.ShowDialog()
        frmSearchSubjects.txtsearch.Focus()
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
    Public Sub getRooms()
        Try
            str = "select * from rooms order by Room"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "rooms")

            txtRoom.ValueMember = "rooms"
            txtRoom.DisplayMember = "Room"
            txtRoom.DataSource = ds.Tables("rooms")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCourse.SelectedIndexChanged
        getCourseMajor()
        'loadSubjects()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If cboCourse.Text = "" Then
                MsgBox("Department is required!", MsgBoxStyle.Exclamation)
                cboCourse.Focus()
                Exit Sub
            End If

            If cboYearLevel.Text = "" Then
                MsgBox("Grade level is required!", MsgBoxStyle.Exclamation)
                cboYearLevel.Focus()
                Exit Sub
            End If

            str = "select * from semsubjects where Semester ='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Course='" & cboCourse.Text & "' and YearLevel='" & cboYearLevel.Text & "'  order by SubjectCode"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysDA.Fill(ds, "semsubjects")
            dgsubjects.DataSource = ds.Tables("semsubjects")
            conn.Close()

            dgsubjects.Columns(0).Visible = False
            dgsubjects.Columns(1).Width = 80
            dgsubjects.Columns(2).Width = 200
            dgsubjects.Columns(3).Width = 60
            dgsubjects.Columns(4).Visible = False
            dgsubjects.Columns(5).Width = 140
            dgsubjects.Columns(6).Visible = False
            dgsubjects.Columns(9).Width = 60
            dgsubjects.Columns(10).Visible = False
            dgsubjects.Columns(11).Visible = False
            dgsubjects.Columns(12).Visible = False
            dgsubjects.Columns(13).Width = 200
            dgsubjects.Columns(13).HeaderText = "Teacher"
            dgsubjects.Columns(14).Visible = False
            dgsubjects.Columns(15).Visible = False
            dgsubjects.Columns(16).Visible = False
            dgsubjects.Columns(17).Visible = False
            dgsubjects.Columns(18).Visible = False
            dgsubjects.Columns(19).Visible = False
            dgsubjects.Columns(20).Visible = False
            dgsubjects.Columns(21).Visible = False
            dgsubjects.Columns(22).Visible = False
            dgsubjects.Columns(23).Visible = False
            dgsubjects.Columns(24).Visible = False
            dgsubjects.Columns(25).Visible = False
            dgsubjects.Columns(26).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub cboYearLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYearLevel.SelectedIndexChanged
        getSection()
    End Sub

    Private Sub txtSubjectCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubjectCode.TextChanged
        'getSection()
    End Sub
    Public Sub loadSubjects()
        Try
            str = "select * from semsubjects where Semester ='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Course='" & cboCourse.Text & "' and YearLevel='" & cboYearLevel.Text & "' and Section='" & cboSection.Text & "'  order by SubjectCode"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysDA.Fill(ds, "semsubjects")
            dgsubjects.DataSource = ds.Tables("semsubjects")
            conn.Close()

            dgsubjects.Columns(0).Visible = False
            dgsubjects.Columns(1).Width = 80
            dgsubjects.Columns(2).Width = 200
            dgsubjects.Columns(3).Width = 60
            dgsubjects.Columns(4).Visible = False
            dgsubjects.Columns(5).Width = 140
            dgsubjects.Columns(6).Visible = False
            dgsubjects.Columns(9).Width = 60
            dgsubjects.Columns(10).Visible = False
            dgsubjects.Columns(11).Visible = False
            dgsubjects.Columns(12).Visible = False
            dgsubjects.Columns(13).Width = 200
            dgsubjects.Columns(13).HeaderText = "Teacher"
            dgsubjects.Columns(14).Visible = False
            dgsubjects.Columns(15).Visible = False
            dgsubjects.Columns(16).Visible = False
            dgsubjects.Columns(17).Visible = False
            dgsubjects.Columns(18).Visible = False
            dgsubjects.Columns(19).Visible = False
            dgsubjects.Columns(20).Visible = False
            dgsubjects.Columns(21).Visible = False
            dgsubjects.Columns(22).Visible = False
            dgsubjects.Columns(23).Visible = False
            dgsubjects.Columns(24).Visible = False
            dgsubjects.Columns(25).Visible = False
            dgsubjects.Columns(26).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboSection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSection.SelectedIndexChanged
        loadSubjects()
    End Sub
    Public Sub schoolInfo()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            Str = "select * from srms_settings limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(Str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblSettingsID.Text = dtReader(0)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class