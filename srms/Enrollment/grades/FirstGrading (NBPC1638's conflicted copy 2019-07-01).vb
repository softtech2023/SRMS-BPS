Imports MySql.Data.MySqlClient
Public Class frmFirstGrading
    Dim str As String
    Private Sub tsSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSearch.Click
        frmFirstGradingSearch.ShowDialog()
    End Sub
    Public Sub getInstructor()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select concat(FirstName,' ',LastName) as Name from staff where IDNumber='" & frmParent.lblUser.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtInstructor.Text = dtReader.Item(0)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub getStatus()
        Try
            str = "select * from grades where SubjectCode='" & txtSubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Section='" & txtSection.Text & "' and Instructor='" & txtInstructor.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "grades")

            cboStatus.ValueMember = "grades"
            cboStatus.DisplayMember = "firstStat"
            cboStatus.DataSource = ds.Tables("grades")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub disableSave()
        If cboStatus.Text = "Closed" Then
            tsSave.Enabled = False
            tsDelete.Enabled = False
            dg1.Columns(2).ReadOnly = True
        Else
            tsSave.Enabled = True
            tsDelete.Enabled = True
        End If
    End Sub

    Private Sub frmGPrelim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()
    End Sub
    Public Sub formLoad()
        getInstructor()
        tsSave.Enabled = False
        tsDelete.Enabled = False

        schoolInfo()
    End Sub
    Public Sub Grades()
        Try
            'kung naa nay grades e-display sa datagrid
            'str = "select r.StudentNumber, concat(s.LName,', ',s.FName) as Fullname, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.Section, p.sex from registration r left outer join semesterstude s on s.studentnumber=r.studentnumber left outer join grades g on g.studentnumber=s.studentnumber join studeprofile p on p.StudentNumber=s.StudentNumber where g.subjectcode='" & txtSubjectcode.Text & "' and g.Description='" & txtDescription.Text & "' and g.Sem ='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and g.Section='" & txtSection.Text & "' group by p.Sex, p.LastName"
            str = "select p.StudentNumber, g.StudentName, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.Section, p.Sex, g.YearLevel, g.track, g.strand, g.adviser from studeprofile p join grades g on p.StudentNumber=g.StudentNumber where g.subjectcode='" & txtSubjectcode.Text & "' and g.Description='" & txtDescription.Text & "' and g.Sem ='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and g.Section='" & txtSection.Text & "' group by p.Sex, p.StudentNumber order by p.Sex, g.StudentName"
            conn.Open()
            Dim mysC As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysC.Fill(ds, "registration, semsubjects, grades")

            dg1.Columns.Clear()
            If ds.Tables("registration, semsubjects, grades").Rows.Count >= 1 Then


                'dg1.Columns(0).Visible = False
                dg1.DataSource = ds.Tables("registration, semsubjects, grades")

                conn.Close()
                dg1.Columns(0).HeaderText = "LRN"
                dg1.Columns(0).ReadOnly = True
                dg1.Columns(0).Width = 150
                dg1.Columns(1).HeaderText = "Student Name"
                dg1.Columns(1).ReadOnly = True
                dg1.Columns(1).Width = 250
                dg1.Columns(2).HeaderText = "1st Grading"
                dg1.Columns(2).Width = 110
                'dg1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                dg1.Columns(3).HeaderText = "2nd Grading"
                dg1.Columns(3).Width = 90
                dg1.Columns(3).Visible = False
                dg1.Columns(4).HeaderText = "3rd Grading"
                dg1.Columns(4).Width = 90
                dg1.Columns(4).Visible = False
                dg1.Columns(5).HeaderText = "4th Grading"
                dg1.Columns(5).Width = 90
                dg1.Columns(5).Visible = False

                dg1.Columns(6).HeaderText = "Ave."
                dg1.Columns(6).ReadOnly = True
                dg1.Columns(6).Visible = False
                dg1.Columns(7).Visible = False
                dg1.Columns(8).Visible = False
                dg1.Columns(9).Visible = False
                dg1.Columns(10).Visible = False
                dg1.Columns(11).Visible = False
                dg1.Columns(12).Visible = False
                conn.Close()

            Else
                ' kung wala pay grades
                'str = "select r.StudentNumber, concat(s.LName,', ',s.FName) as Fullname from registration r join semesterstude s on s.studentnumber=r.studentnumber where r.subjectcode='" & txtSubjectcode.Text & "' and r.Description='" & txtDescription.Text & "' and r.Sem='" & frmParent.lblSem.Text & "' and r.SY='" & frmParent.lblSY.Text & "' and r.Section='" & txtSection.Text & "' group by StudentNumber order by Fullname"
                str = "select r.StudentNumber, concat(s.LName,', ',s.FName) as Fullname, s.YearLevel, s.Track, s.Qualification, s.Adviser from registration r join semesterstude s on s.studentnumber=r.studentnumber join studeprofile p on p.StudentNumber=s.StudentNumber where r.subjectcode='" & txtSubjectcode.Text & "' and r.Description='" & txtDescription.Text & "' and r.Sem='" & frmParent.lblSem.Text & "' and s.Semester='" & frmParent.lblSem.Text & "' and r.SY='" & frmParent.lblSY.Text & "' and s.SY='" & frmParent.lblSY.Text & "' and r.Section='" & txtSection.Text & "' group by StudentNumber order by p.Sex, Fullname"
                conn1.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn1)
                Dim ds1 As New DataSet
                mysDA.Fill(ds1, "registration, semesterstude")
                dg1.DataSource = ds1.Tables("registration, semesterstude")
                dg1.Columns(1).Width = 200
                dg1.Columns(1).HeaderText = "Student Name"
                dg1.Columns(0).ReadOnly = True
                dg1.Columns(1).ReadOnly = True
                dg1.Columns(2).Visible = False
                dg1.Columns(3).Visible = False
                dg1.Columns(4).Visible = False
                dg1.Columns(5).Visible = False

                dg1.Columns.Add("PGrade", "1st Grading")
                dg1.Columns.Add("MGrade", "2nd Grading")
                dg1.Columns(7).Visible = False
                dg1.Columns.Add("PFinalGrade", "3rd Grading")
                dg1.Columns(8).Visible = False
                dg1.Columns.Add("FGrade", "4th Grading")
                dg1.Columns(9).Visible = False
                dg1.Columns.Add("Average", "Average")
                dg1.Columns(10).Visible = False

                conn1.Close()
                conn.Close()

            End If
            conn.Close()

            'getNames()
            'getGrades()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSubjectcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubjectcode.TextChanged
        Grades()
        getInstructor()
        getStatus()
    End Sub

    Private Sub txtSection_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSection.TextChanged
        Grades()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            If txtSubjectcode.Text = "" Then
                MsgBox("Select subject first before saving!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            For i As Integer = 0 To dg1.RowCount - 1

                If dg1.Rows(i).Cells.Item(2).Value Is Nothing Then
                    MsgBox("Grades cannot be saved because some cells are empty!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            Next


            str = "select * from grades where SubjectCode='" & txtSubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Instructor='" & txtInstructor.Text & "' and SY='" & frmParent.lblSY.Text & "' and Sem='" & frmParent.lblSem.Text & "' and Section='" & txtSection.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "grades")
            If ds.Tables("grades").Rows.Count >= 1 Then
                'code kung nag exist
                For x As Integer = 0 To dg1.Rows.Count - 1

                    str = "update grades set StudentNumber='" & dg1.Item(0, x).Value & "',StudentName='" & dg1.Item(1, x).Value & "',SubjectCode='" & txtSubjectcode.Text & "',Description='" & txtDescription.Text & "',LecUnit='" & lblLec.Text & "',LabUnit='" & lblLab.Text & "',Instructor='" & txtInstructor.Text & "',Section='" & txtSection.Text & "',PGrade='" & dg1.Item(2, x).Value & "',Average='" & dg1.Item(7, x).Value & "',firstStat='Open',secondStat='Open',thirdStat='Open',fourthStat='Open' where StudentNumber='" & dg1.Item(0, x).Value & "' and SubjectCode='" & txtSubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Section='" & txtSection.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                    conn1.Open()
                    Dim mysC1 As New MySqlCommand(str, conn1)
                    mysC1.ExecuteNonQuery()
                    conn1.Close()
                Next
                MsgBox("Grades successfully saved!", MsgBoxStyle.Information)
                'kung wala nag exist
            Else
                For x As Integer = 0 To dg1.Rows.Count - 1

                    str = "insert into grades values('0','" & dg1.Item(0, x).Value & "','" & dg1.Item(1, x).Value & "','" & txtSubjectcode.Text & "','" & txtDescription.Text & "','" & lblLec.Text & "','" & lblLab.Text & "','" & txtInstructor.Text & "','" & txtSection.Text & "','" & dg1.Item(6, x).Value & "','0','0','0','0','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "','Open','Open','Open','Open','" & dg1.Item(2, x).Value & "','" & lblSchoolName.Text & "','" & dg1.Item(3, x).Value & "','" & dg1.Item(4, x).Value & "','" & dg1.Item(5, x).Value & "')"
                    conn1.Open()
                    Dim mysC2 As New MySqlCommand(str, conn1)
                    mysC2.ExecuteNonQuery()
                    conn1.Close()
                Next
                MsgBox("Grades successfully saved!", MsgBoxStyle.Information)
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
        conn.Close()
        Clear()
        formLoad()
    End Sub
    Public Sub Clear()
        txtSubjectcode.Clear()
        txtDescription.Clear()
        txtSection.Clear()
        'dg1.DataSource = Nothing
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        Clear()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        tsSave.PerformClick()
    End Sub

    Private Sub SelectSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectSubjectToolStripMenuItem.Click
        tsSearch.PerformClick()
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("You are about to delete grades for this subject.  Do you want to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from grades where SubjectCode='" & txtSubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Instructor='" & txtInstructor.Text & "' and Section='" & txtSection.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("Grades successfully deleted", MsgBoxStyle.Information)
                Clear()
                formLoad()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub schoolInfo()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from srms_settings limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblSchoolName.Text = dtReader(5)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class