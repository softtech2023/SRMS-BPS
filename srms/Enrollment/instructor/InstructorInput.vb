Imports MySql.Data.MySqlClient
Public Class frmInstructorInput
    Dim str As String
    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete the selected grades?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                Str = "delete from grades where SubjectCode='" & txtSubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Section='" & txtSection.Text & "' and Instructor='" & txtInstructor.Text & "' and SY='" & frmParent.lblSY.Text & "' and Sem='" & frmParent.lblSem.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(Str, conn)
                mysC.ExecuteNonQuery()
                MsgBox("Grades successfully deleted!", MsgBoxStyle.Information)
                conn.Close()
                FormLoad()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub FormLoad()
        tsSave.Enabled = False
        Clear()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            If txtSubjectcode.Text = "" Then
                MsgBox("Select subject first before saving!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            str = "select * from grades where SubjectCode='" & txtSubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Instructor='" & txtInstructor.Text & "' and SY='" & frmParent.lblSY.Text & "' and Sem='" & frmParent.lblSem.Text & "' and Section='" & txtSection.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "grades")
            If ds.Tables("grades").Rows.Count >= 1 Then
                'code kung nag exist
                str = "delete from grades where SubjectCode='" & txtSubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Section='" & txtSection.Text & "' and Instructor='" & txtInstructor.Text & "' and SY='" & frmParent.lblSY.Text & "' and Sem='" & frmParent.lblSem.Text & "'"
                conn1.Open()
                Dim mysC As New MySqlCommand(str, conn1)
                mysC.ExecuteNonQuery()
                conn1.Close()

                For x As Integer = 0 To dg1.Rows.Count - 1

                    str = "insert into grades values('0','" & dg1.Item(0, x).Value & "','" & dg1.Item(1, x).Value & "','" & txtSubjectcode.Text & "','" & txtDescription.Text & "','" & lblLec.Text & "','" & lblLab.Text & "','" & txtInstructor.Text & "','" & txtSection.Text & "','" & dg1.Item(2, x).Value & "','" & dg1.Item(3, x).Value & "','" & dg1.Item(4, x).Value & "','" & dg1.Item(5, x).Value & "','" & dg1.Item(6, x).Value & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "','Open')"
                    conn1.Open()
                    Dim mysC1 As New MySqlCommand(str, conn1)
                    mysC1.ExecuteNonQuery()

                    conn1.Close()

                Next
                MsgBox("Grades successfully saved!", MsgBoxStyle.Information)
                'kung wala nag exist
            Else
                For x As Integer = 0 To dg1.Rows.Count - 1

                    str = "insert into grades values('0','" & dg1.Item(0, x).Value & "','" & dg1.Item(1, x).Value & "','" & txtSubjectcode.Text & "','" & txtDescription.Text & "','" & lblLec.Text & "','" & lblLab.Text & "','" & txtInstructor.Text & "','" & txtSection.Text & "','" & dg1.Item(2, x).Value & "','" & dg1.Item(3, x).Value & "','" & dg1.Item(4, x).Value & "','" & dg1.Item(5, x).Value & "','" & dg1.Item(6, x).Value & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "','Open')"
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
    End Sub
    Public Sub Clear()
        txtSubjectcode.Clear()
        txtDescription.Clear()
        txtInstructor.Clear()
        txtSection.Clear()
        'dg1.DataSource = Nothing
    End Sub

    Private Sub tsSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSearch.Click
        frmSelect_Subject.Show()
    End Sub

    Public Sub getNames()
        Try
            str = "select s.SubjectCode, f.IDNumber from semsubjects as s, staff as f where s.SubjectCode = '" & txtSubjectcode.Text & "' and s.Class = 'Lec'"
            conn.Open()
            Dim mysC As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet

            mysC.Fill(ds, "semsubjects, staff")

            If ds.Tables("semsubjects, staff").Rows.Count >= 1 Then
                txtInstructor.Text = ds.Tables("semsubjects, staff").Rows(0).Item(0)
                txtInstructor.Text = ds.Tables("semsubjects, staff").Rows(0).Item(1)
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmInstructorInput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub

    Private Sub txtSubjectcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubjectcode.TextChanged
        Grades()
        getInstructor()
        getStatus()
    End Sub
    Public Sub getInstructor()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select concat(FirstName,' ',LastName) as Name from staff where IDNumber='" & lblInstructorID.Text & "'"
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
    Public Sub Grades()
        Try
            'kung naa nay grades e-display sa datagrid
            'str = "select r.StudentNumber, concat(s.LName,', ',s.FName) as Fullname, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.Section from registration r left outer join semesterstude s on s.studentnumber=r.studentnumber left outer join grades g on g.studentnumber=s.studentnumber where g.subjectcode='" & txtSubjectcode.Text & "' and g.Description='" & txtDescription.Text & "' and g.Sem ='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and g.Section='" & txtSection.Text & "' group by StudentNumber order by Fullname"
            str = "select r.StudentNumber, concat(s.LName,', ',s.FName) as Fullname, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.Section, p.sex from registration r left outer join semesterstude s on s.studentnumber=r.studentnumber left outer join grades g on g.studentnumber=s.studentnumber join studeprofile p on p.StudentNumber=s.StudentNumber where g.subjectcode='" & txtSubjectcode.Text & "' and g.Description='" & txtDescription.Text & "' and g.Sem ='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and g.Section='" & txtSection.Text & "' group by p.Sex, p.LastName"
            conn.Open()
            Dim mysC As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysC.Fill(ds, "studeprofile, registration, semsubjects, grades")

            dg1.Columns.Clear()
            If ds.Tables("studeprofile, registration, semsubjects, grades").Rows.Count >= 1 Then


                'dg1.Columns(0).Visible = False
                dg1.DataSource = ds.Tables("studeprofile, registration, semsubjects, grades")

                conn.Close()
                dg1.Columns(0).HeaderText = "Student No."
                dg1.Columns(0).ReadOnly = True
                dg1.Columns(1).HeaderText = "Student Name"
                dg1.Columns(1).ReadOnly = True
                dg1.Columns(1).Width = 200
                dg1.Columns(2).HeaderText = "1st Qtr."
                dg1.Columns(2).Width = 80
                dg1.Columns(3).HeaderText = "2nd Qtr."
                dg1.Columns(3).Width = 80
                dg1.Columns(4).HeaderText = "3rd Qtr."
                dg1.Columns(4).Width = 80
                'dg1.Columns(4).ReadOnly = True
                dg1.Columns(5).HeaderText = "4th Qtr."
                'dg1.Columns(5).ReadOnly = True
                dg1.Columns(6).HeaderText = "Ave"
                dg1.Columns(7).Visible = False
                dg1.Columns(8).Visible = False
                conn.Close()

            Else
                ' kung wala pay grades
                str = "select r.StudentNumber, concat(s.LName,', ',s.FName) as Fullname from registration r join semesterstude s on s.studentnumber=r.studentnumber join studeprofile p on p.StudentNumber=s.StudentNumber where r.subjectcode='" & txtSubjectcode.Text & "' and r.Description='" & txtDescription.Text & "' and r.Sem='" & frmParent.lblSem.Text & "' and r.SY='" & frmParent.lblSY.Text & "' and r.Section='" & txtSection.Text & "' group by StudentNumber order by p.Sex, Fullname"
                conn1.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn1)
                Dim ds1 As New DataSet
                mysDA.Fill(ds1, "studeprofile, registration, semesterstude")
                dg1.DataSource = ds1.Tables("studeprofile, registration, semesterstude")
                dg1.Columns(1).Width = 200
                dg1.Columns(1).HeaderText = "Student Name"
                dg1.Columns(0).ReadOnly = True
                dg1.Columns(1).ReadOnly = True
                dg1.Columns.Add("PGrade", "1st Qtr.")
                dg1.Columns.Add("MGrade", "2nd Qtr.")
                dg1.Columns.Add("PFinalGrade", "3rd Qtr.")
                dg1.Columns.Add("FGrade", "4th Qtr.")
                dg1.Columns.Add("Average", "Average")
                'dg1.Columns.Add("Equivalent", "EQV")
                ' dg1.Columns(0).Visible = False
                dg1.Columns(3).ReadOnly = False
                dg1.Columns(4).ReadOnly = False
                dg1.Columns(5).ReadOnly = False
                dg1.Columns(6).ReadOnly = False
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
    Private Sub txtSection_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSection.TextChanged
        Grades()
    End Sub
    Public Sub getAverage()
        Try

            Dim iCell1 As String
            Dim icell2 As String
            Dim icell3 As String
            Dim icell4 As String
            Dim icellResult As Double

            iCell1 = dg1.CurrentRow.Cells(2).Value
            icell2 = dg1.CurrentRow.Cells(3).Value
            icell3 = dg1.CurrentRow.Cells(4).Value
            icell4 = dg1.CurrentRow.Cells(5).Value

            'If iCell1 = 0 Or icell2 = 0 Or iCell1 = "" Or icell2 = "" Then
            'dg1.CurrentRow.Cells(6).Value = 0

            If iCell1 > 0 And icell2 = "" Then
                icellResult = Math.Round((Val(iCell1)) / 1)
                dg1.CurrentRow.Cells(6).Value = icellResult
                dg1.Columns.Item(6).ValueType = GetType(Double)

            ElseIf iCell1 > 0 And icell2 > 0 And icell3 = "" Then
                icellResult = Math.Round((Val(iCell1) + Val(icell2)) / 2)
                dg1.CurrentRow.Cells(6).Value = icellResult
                dg1.Columns.Item(6).ValueType = GetType(Double)

            ElseIf iCell1 > 0 And icell2 > 0 And icell3 >= 0 And icell4 = "" Then
                icellResult = Math.Round((Val(iCell1) + Val(icell2) + Val(icell3)) / 3)
                dg1.CurrentRow.Cells(6).Value = icellResult
                dg1.Columns.Item(6).ValueType = GetType(Double)

            Else
                icellResult = Math.Round((Val(iCell1) + Val(icell2) + Val(icell3) + Val(icell4)) / 4)
                dg1.CurrentRow.Cells(6).Value = icellResult
                dg1.Columns.Item(6).ValueType = GetType(Double)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
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
            cboStatus.DisplayMember = "Status"
            cboStatus.DataSource = ds.Tables("grades")
            conn.Close()

            If cboStatus.Text = "Closed" Then
                tsSave.Enabled = False
                tsDelete.Enabled = False
                dg1.Columns(2).ReadOnly = True
                dg1.Columns(3).ReadOnly = True
                dg1.Columns(4).ReadOnly = True
                dg1.Columns(5).ReadOnly = True
                dg1.Columns(6).ReadOnly = True
            Else
                tsSave.Enabled = True
                tsDelete.Enabled = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class