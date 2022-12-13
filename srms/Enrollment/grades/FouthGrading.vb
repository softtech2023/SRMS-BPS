Imports MySql.Data.MySqlClient
Public Class frmFouthGrading
    Dim str As String
    Private Sub frmFouthGrading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getInstructor()
        tsSave.Enabled = False
        tsDelete.Enabled = False
    End Sub

    Private Sub txtSubjectcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubjectcode.TextChanged
        formLoad()
    End Sub
    Public Sub formLoad()
        getInstructor()
        tsSave.Enabled = False
        tsDelete.Enabled = False
    End Sub
    Private Sub txtSection_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSection.TextChanged
        Grades()
    End Sub
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        tsSave.PerformClick()
    End Sub
    Private Sub SelectSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectSubjectToolStripMenuItem.Click
        tsSearch.PerformClick()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        Clear()
    End Sub

    Private Sub tsSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSearch.Click
        frmFourthGradingSearch.show()
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
            cboStatus.DisplayMember = "fourthStat"
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
            dg1.Columns(2).ReadOnly = True
            dg1.Columns(3).ReadOnly = True
            dg1.Columns(4).ReadOnly = True
            dg1.Columns(5).ReadOnly = True
        Else
            tsSave.Enabled = True
            dg1.Columns(2).ReadOnly = False
            dg1.Columns(3).ReadOnly = False
            dg1.Columns(4).ReadOnly = False
            dg1.Columns(5).ReadOnly = False
        End If
    End Sub
    Public Sub Grades()
        Try
            'kung naa nay grades e-display sa datagrid
            'str = "select r.StudentNumber, concat(s.LName,', ',s.FName) as Fullname, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.Section, p.sex from registration r left outer join semesterstude s on s.studentnumber=r.studentnumber left outer join grades g on g.studentnumber=s.studentnumber join studeprofile p on p.StudentNumber=s.StudentNumber where g.subjectcode='" & txtSubjectcode.Text & "' and g.Description='" & txtDescription.Text & "' and g.Sem ='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and g.Section='" & txtSection.Text & "' group by p.Sex, p.LastName"
            str = "select p.StudentNumber, g.StudentName, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.Section, p.Sex from studeprofile p join grades g on p.StudentNumber=g.StudentNumber where g.subjectcode='" & txtSubjectcode.Text & "' and g.Description='" & txtDescription.Text & "' and g.Sem ='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and g.Section='" & txtSection.Text & "' group by p.Sex, p.StudentNumber order by p.Sex, g.StudentName"
            conn.Open()
            Dim mysC As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysC.Fill(ds, "registration, semsubjects, grades")

            dg1.Columns.Clear()
            If ds.Tables("registration, semsubjects, grades").Rows.Count >= 1 Then


                'dg1.Columns(0).Visible = False
                dg1.DataSource = ds.Tables("registration, semsubjects, grades")

                conn.Close()
                dg1.Columns(0).HeaderText = "Student No."
                dg1.Columns(0).ReadOnly = True
                dg1.Columns(1).HeaderText = "Student Name"
                dg1.Columns(1).ReadOnly = True
                dg1.Columns(1).Width = 200
                dg1.Columns(2).HeaderText = "1st Grading"
                dg1.Columns(2).Width = 80
                dg1.Columns(2).ReadOnly = True
                dg1.Columns(3).HeaderText = "2nd Grading"
                dg1.Columns(3).Width = 80
                dg1.Columns(4).HeaderText = "3rd Grading"
                dg1.Columns(4).Width = 80
                dg1.Columns(4).Visible = True
                dg1.Columns(5).HeaderText = "4th Grading"
                dg1.Columns(5).Width = 80
                dg1.Columns(5).Visible = True

                dg1.Columns(6).HeaderText = "Ave."
                dg1.Columns(6).ReadOnly = True
                dg1.Columns(6).Visible = False

                dg1.Columns(7).Visible = False
                dg1.Columns(8).Visible = False
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

    Public Sub Clear()
        txtSubjectcode.Clear()
        txtDescription.Clear()
        txtSection.Clear()
        'dg1.DataSource = Nothing
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
                    str = "update grades set StudentNumber='" & dg1.Item(0, x).Value & "',StudentName='" & dg1.Item(1, x).Value & "',SubjectCode='" & txtSubjectcode.Text & "',Description='" & txtDescription.Text & "',LecUnit='" & lblLec.Text & "',LabUnit='" & lblLab.Text & "',Instructor='" & txtInstructor.Text & "',Section='" & txtSection.Text & "',PGrade='" & dg1.Item(2, x).Value & "',MGrade='" & dg1.Item(3, x).Value & "',PFinalGrade='" & dg1.Item(4, x).Value & "',FGrade='" & dg1.Item(5, x).Value & "',Average='" & dg1.Item(6, x).Value & "',fourthStat='Closed' where StudentNumber='" & dg1.Item(0, x).Value & "' and SubjectCode='" & txtSubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Section='" & txtSection.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                    conn1.Open()
                    Dim mysC1 As New MySqlCommand(str, conn1)
                    mysC1.ExecuteNonQuery()
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
    Public Sub getAverage()
        Try
            Dim iCell1 As Double
            Dim icell2 As Double
            Dim icell3 As Double
            Dim icell4 As Double
            Dim icellResult As Double

            iCell1 = dg1.CurrentRow.Cells(2).Value
            icell2 = dg1.CurrentRow.Cells(3).Value
            icell3 = dg1.CurrentRow.Cells(4).Value
            icell4 = dg1.CurrentRow.Cells(5).Value


            icellResult = Math.Round((Val(iCell1) + Val(icell2) + Val(icell3) + Val(icell4)) / 4)
            dg1.CurrentRow.Cells(6).Value = Math.Round(icellResult, 2, MidpointRounding.AwayFromZero)
            dg1.Columns.Item(6).ValueType = GetType(Double)


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub dg1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg1.CellEndEdit
        getAverage()
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("You are about to delete 4th grading grades.  Do you want to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "update grades set FGrade=0 where SubjectCode='" & txtSubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Instructor='" & txtInstructor.Text & "' and Section='" & txtSection.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("4th Grading grades successfully deleted!", MsgBoxStyle.Information)
                Clear()
                formLoad()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class