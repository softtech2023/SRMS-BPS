Imports MySql.Data.MySqlClient
Public Class frmSemStudent
    Dim str As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmStudeProfile.Show()
    End Sub

    Private Sub frmSemStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Reload()
        getCourse()
        getCourseMajor()
        getSection()
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
            'cboSection.ResetText()
            'cboCourse.ResetText()
            'cboMajor.ResetText()
            cboScholarship.ResetText()
            mskFrom.Clear()
            mskTo.Clear()
            mskAssessmentDate.Clear()
            cboAssessmentResult.ResetText()
            cboAccountStatus.ResetText()
            cboStudeStatus.ResetText()
            cboYearStat.ResetText()
            cboTrack.ResetText()
            cboBalikAral.ResetText()
            cboIP.ResetText()
            cbo4Ps.ResetText()
            cboRepeater.ResetText()
            cboTransferee.ResetText()

            mskStudentNumber.Focus()
            lblAdviser.Text = ""
            'getCourse()
            'getCourseMajor()
            schoolInfo()


            'COR
            lvCOR.Items.Clear()
            Me.lvCOR.Columns.Add("Subject Code", 90)
            Me.lvCOR.Columns.Add("Description", 200)
            Me.lvCOR.Columns.Add("Lec Time", 150)
            Me.lvCOR.Columns.Add("Lab Time", 150)
            Me.lvCOR.Columns.Add("Room", 100)
            Me.lvCOR.Columns.Add("Section", 80)
            Me.lvCOR.Columns.Add("Lec Unit", 0)
            Me.lvCOR.Columns.Add("Lab Unit", 0)

            Me.lvCOR.View = View.Details
            Me.lvCOR.GridLines = True


            btnAccecelrated.Enabled = False
            btnDropped.Enabled = False
            btnTransferredOut.Enabled = False



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

            str = "insert into semesterstude values('0','" & mskStudentNumber.Text & "','" & txtFname.Text & "','" & txtMName.Text & "','" & txtLastName.Text & "','" & cboCourse.Text & "','" & cboYear.Text & "','" & cboStatus.Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "','" & frmParent.lblTerm.Text & "','" & cboSection.Text & "','" & cboStudeStatus.Text & "','" & cboScholarship.Text & "','" & mskFrom.Text & "','" & mskTo.Text & "','" & mskAssessmentDate.Text & "','" & cboAssessmentResult.Text & "','" & cboAccountStatus.Text & "','" & txtGrantAmount.Text & "','" & cboYearStat.Text & "','" & cboMajor.Text & "','" & cboTrack.Text & "','" & cboQualification.Text & "','" & cboBalikAral.Text & "','" & cboIP.Text & "','" & cbo4Ps.Text & "','" & cboRepeater.Text & "','" & cboTransferee.Text & "','" & Convert.ToDateTime(frmParent.dtpDate.Text).ToString("yyyy-MM-dd") & "','" & lblAdviser.Text & "','" & lblSettingsID.Text & "','" & lblAdviserID.Text & "')"
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
            'MsgBox("Data successfully saved!", MsgBoxStyle.Information)
            conn.Close()

            'delete from COR
            str = "delete from registration where StudentNumber='" & mskStudentNumber.Text & "' and SY='" & frmParent.lblSY.Text & "' and Sem='" & frmParent.lblSem.Text & "'"
            conn.Open()
            Dim mysC3 As New MySqlCommand(str, conn)
            mysC3.ExecuteNonQuery()
            conn.Close()


            'Save COR
            For i As Integer = 0 To lvCOR.Items.Count - 1

                str = "insert into registration values('0','" & lvCOR.Items(i).SubItems(0).Text & "','" & lvCOR.Items(i).SubItems(1).Text & "','" & lvCOR.Items(i).SubItems(6).Text & "','" & lvCOR.Items(i).SubItems(7).Text & "','" & lvCOR.Items(i).SubItems(5).Text & "','" & lvCOR.Items(i).SubItems(3).Text & "','" & lvCOR.Items(i).SubItems(2).Text & "','" & lvCOR.Items(i).SubItems(4).Text & "','" & lvCOR.Items(i).SubItems(8).Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "','" & mskStudentNumber.Text & "','" & frmParent.lblTerm.Text & "','" & txtFname.Text & "','" & txtMName.Text & "','" & txtLastName.Text & "','" & cboCourse.Text & "','" & cboYear.Text & "','" & lblSettingsID.Text & "')"
                conn.Open()
                Dim mysC4 As New MySqlCommand(str, conn)
                mysC4.ExecuteNonQuery()

                conn.Close()
            Next
            MsgBox("Data successfully saved!", MsgBoxStyle.Information)
            lvCOR.Items.Clear()


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

            str = "update semesterstude set StudentNumber='" & mskStudentNumber.Text & "',FName='" & txtFname.Text & "',MName='" & txtMName.Text & "',LName='" & txtLastName.Text & "',Course='" & cboCourse.Text & "',YearLevel='" & cboYear.Text & "',Status='" & cboStatus.Text & "',Semester='" & frmParent.lblSem.Text & "',SY='" & frmParent.lblSY.Text & "',Term='" & frmParent.lblTerm.Text & "',Section='" & cboSection.Text & "',StudeStatus='" & cboStudeStatus.Text & "',Scholarship='" & cboScholarship.Text & "',DurationFrom='" & mskFrom.Text & "',DurationTo='" & mskTo.Text & "',AssessmentDate='" & mskAssessmentDate.Text & "',AssessmentResult='" & cboAssessmentResult.Text & "',PayingStatus='" & cboAccountStatus.Text & "',GrantAmount='" & txtGrantAmount.Text & "',YearLevelStat='" & cboYearStat.Text & "',semstudentid='" & lblID.Text & "',Major='" & cboMajor.Text & "',Track='" & cboTrack.Text & "',Qualification='" & cboQualification.Text & "',BalikAral='" & cboBalikAral.Text & "',IP='" & cboIP.Text & "',FourPs='" & cbo4Ps.Text & "',Repeater='" & cboRepeater.Text & "',Transferee='" & cboTransferee.Text & "',Adviser='" & lblAdviser.Text & "',sectionID='" & lblAdviserID.Text & "' where semstudentid='" & lblID.Text & "'"
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
            'MsgBox("Data successfully updated", MsgBoxStyle.Information)
            conn.Close()

            'update grades
            str = "update grades set YearLevel='" & cboYear.Text & "',track='" & cboTrack.Text & "',strand='" & cboQualification.Text & "',adviser='" & lblAdviser.Text & "' where StudentNumber='" & mskStudentNumber.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysC6 As New MySqlCommand(str, conn)
            mysC6.ExecuteNonQuery()
            'MsgBox("Data successfully updated", MsgBoxStyle.Information)
            conn.Close()

            'update registration
            str = "delete from registration where StudentNumber='" & mskStudentNumber.Text & "' and SY='" & frmParent.lblSY.Text & "' and Sem='" & frmParent.lblSem.Text & "'"
            conn.Open()
            Dim mysC4 As New MySqlCommand(str, conn)
            mysC4.ExecuteNonQuery()
            conn.Close()

            'Save COR
            For i As Integer = 0 To lvCOR.Items.Count - 1

                str = "insert into registration values('0','" & lvCOR.Items(i).SubItems(0).Text & "','" & lvCOR.Items(i).SubItems(1).Text & "','" & lvCOR.Items(i).SubItems(6).Text & "','" & lvCOR.Items(i).SubItems(7).Text & "','" & lvCOR.Items(i).SubItems(5).Text & "','" & lvCOR.Items(i).SubItems(3).Text & "','" & lvCOR.Items(i).SubItems(2).Text & "','" & lvCOR.Items(i).SubItems(4).Text & "','" & lvCOR.Items(i).SubItems(8).Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "','" & mskStudentNumber.Text & "','" & frmParent.lblTerm.Text & "','" & txtFname.Text & "','" & txtMName.Text & "','" & txtLastName.Text & "','" & cboCourse.Text & "','" & cboYear.Text & "','" & lblSettingsID.Text & "')"
                conn.Open()
                Dim mysC5 As New MySqlCommand(str, conn)
                mysC5.ExecuteNonQuery()

                conn.Close()
            Next
            MsgBox("Data successfully saved!", MsgBoxStyle.Information)
            lvCOR.Items.Clear()

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
                'delete from enrollment
                str = "delete from semesterstude where semstudentid='" & lblID.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                'MsgBox("Data successfully deleted!", MsgBoxStyle.Information)
                conn.Close()

                'delete from registration
                str = "delete from registration where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysC1 As New MySqlCommand(str, conn)
                mysC1.ExecuteNonQuery()
                'MsgBox("Data successfully deleted!", MsgBoxStyle.Information)
                conn.Close()

                'delete from stude account
                str = "delete from studeaccount where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysC2 As New MySqlCommand(str, conn)
                mysC2.ExecuteNonQuery()
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
        'lvCOR.Clear()
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

    Private Sub cboCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCourse.SelectedIndexChanged
        getCourseMajor()
        getTrack()
        getAdviser()

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
            str = "select * from qualifications group by Track order by Track"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "qualifications")
            conn.Close()

            cboTrack.ValueMember = "Track"
            cboTrack.DisplayMember = "Track"
            cboTrack.DataSource = ds.Tables("qualifications")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboTrack_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrack.SelectedIndexChanged
        getQualification()
    End Sub

    Private Sub cboYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYear.SelectedIndexChanged
        getSection()
        sectionID()
        getAdviser()
    End Sub
    Public Sub sectionID()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select sectionID, Adviser from sections where YearLevel='" & cboYear.Text & "' and Section='" & cboSection.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblAdviserID.Text = dtReader.Item(0)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getAdviser()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select sectionID, Adviser from sections where sectionID='" & lblAdviserID.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblAdviser.Text = dtReader.Item(1)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
 
    Private Sub cboSection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSection.SelectedIndexChanged
        sectionID()
        getAdviser()

    End Sub

    Public Sub schoolInfo()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from srms_settings limit 1"
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
    Public Sub LoadSubjects()
        Try
            If cboCourse.Text = "Senior High School" Then

                Dim dt As New DataTable
                str = "SELECT * FROM semsubjects where Course='" & cboCourse.Text & "' and YearLevel='" & cboYear.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Section='" & cboSection.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                mysda.Fill(dt)
                Dim newrow As DataRow
                For Each newrow In dt.Rows
                    lvCOR.Items.Add(newrow.Item(1))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(2))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(7))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(6))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(8))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(5))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(3))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(4))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(13))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(13))
                Next
                conn.Close()
            Else
                Dim dt As New DataTable
                str = "SELECT * FROM semsubjects where Course='" & cboCourse.Text & "' and YearLevel='" & cboYear.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Section='" & cboSection.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                mysda.Fill(dt)
                Dim newrow As DataRow
                For Each newrow In dt.Rows
                    lvCOR.Items.Add(newrow.Item(1))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(2))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(7))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(6))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(8))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(5))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(3))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(4))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(13))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(13))
                Next
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadSubjects.Click
        LoadSubjects()
    End Sub
    Private Sub btnRemoveSubjects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveSubjects.Click
        Try
            Dim i As Integer

            lvCOR.Select()

            If lvCOR.Items.Count = 0 Then
                MsgBox("Cannot find subject(s) to remove", MsgBoxStyle.Exclamation, "Prompt")
                Exit Sub
            Else
                i = lvCOR.FocusedItem.Index
                lvCOR.Items.RemoveAt(i)
            End If

            getTotalLecUnits()
            getTotalLabUnits()
            TotalUnits()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub getTotalLecUnits()
        Dim LecUnits As Double
        For x As Integer = 0 To lvCOR.Items.Count - 1
            LecUnits += Val(lvCOR.Items(x).SubItems(6).Text)
        Next
        txtTotalLecUnits.Text = Format(LecUnits, "0.00")
    End Sub
    Public Sub getTotalLabUnits()
        Dim LabUnits As Double
        For x As Integer = 0 To lvCOR.Items.Count - 1
            LabUnits += Val(lvCOR.Items(x).SubItems(7).Text)
        Next
        txtTotalLab.Text = Format(LabUnits, "0.00")
    End Sub
    Public Sub TotalUnits()
        Dim totalUnits As Double
        totalUnits = Val(txtTotalLecUnits.Text) + Val(txtTotalLab.Text)
        txtTotalUnits.Text = Format(totalUnits, "0.00")
    End Sub

    Private Sub btnAddSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSubject.Click
        frmAddSubjects.ShowDialog()
    End Sub

    Public Sub loadEnrolledSubjects()
        Try
            Dim dt As New DataTable
            str = "SELECT * FROM registration where Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            mysda.Fill(dt)
            Dim newrow As DataRow
            For Each newrow In dt.Rows
                lvCOR.Items.Add(newrow.Item(1))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(2))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(7))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(6))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(8))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(5))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(3))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(4))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(9))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(10))
            Next

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmNutStatForm.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransferredOut.Click
        frmTransferredOut.ShowDialog()
    End Sub

    Private Sub btnDropped_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDropped.Click
        frmDroppingFOrm.ShowDialog()
    End Sub

    Private Sub btnAccecelrated_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccecelrated.Click
        frmAccelerated.ShowDialog()
    End Sub
End Class