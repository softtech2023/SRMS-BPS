Imports MySql.Data.MySqlClient
Public Class frmInputGrades
    Dim str As String
    Public ds1 As New DataSet

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg1.CellContentClick

    End Sub

    Private Sub frmInputGrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub getNames()
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

    End Sub

    Private Sub txtSubjectcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubjectcode.TextChanged
        'getNames()
        getGrades()
    End Sub

    Public Sub getGrades()
        str = "select r.studentnumber, concat(s.FName,' ',s.MName,' ',s.LName) as Fullname, g.Final, g.Complied from registration r join semesterstude s on s.studentnumber=r.studentnumber join grades g on g.studentnumber=s.studentnumber where g.subjectcode='" & txtSubjectcode.Text & "' and r.Sem='" & frmMain.lblSem.Text & "' and r.SY='" & frmMain.lblSY.Text & "' "
        conn.Open()
        Dim mysC As New MySqlDataAdapter(str, conn)
        Dim ds As New DataSet
        mysC.Fill(ds, "registration, semsubjects, grades")


        If ds.Tables("registration, semsubjects, grades").Rows.Count >= 1 Then
            'kung naa nay grades e-display sa datagrid

          
            dg1.DataSource = ds.Tables("registration, semsubjects, grades")



        Else


            str = "select r.studentnumber, concat(s.FName,' ', s.MName,' ',s.LName) as Fullname from registration r join semesterstude s on s.studentnumber=r.studentnumber where r.subjectcode='" & txtSubjectcode.Text & "' and r.Sem='" & frmMain.lblSem.Text & "' and r.SY='" & frmMain.lblSY.Text & "'"
            conn1.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn1)

            mysDA.Fill(ds1, "registration, semesterstude")
            dg1.DataSource = ds1.Tables("registration, semesterstude")
            dg1.Columns.Add("FGrade", "Final Grade")
            dg1.Columns(0).Visible = False
            conn1.Close()
        End If
        conn.Close()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmSearchSemSub_InputGrades.Show()
        'getNames()
        'getGrades()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtSubjectcode.Text = "" Then
            MsgBox("Select subject first before saving!", MsgBoxStyle.Information)
            Exit Sub
        End If

        str = "select * from grades where SubjectCode='" & txtSubjectcode.Text & "' and InstructorID='" & txtInstructor.Text & "' and SY='" & frmMain.lblSY.Text & "' and Semester='" & frmMain.lblSem.Text & "'"
        conn.Open()
        Dim mysda As New MySqlDataAdapter(str, conn)
        Dim ds As New DataSet
        mysda.Fill(ds, "grades")
        If ds.Tables("grades").Rows.Count >= 1 Then
            'code kung nag exist
            str = "delete from grades where SubjectCode='" & txtSubjectcode.Text & "' and InstructorID='" & txtInstructor.Text & "' and SY='" & frmMain.lblSY.Text & "' and Semester='" & frmMain.lblSem.Text & "'"
            conn1.Open()
            Dim mysC As New MySqlCommand(str, conn1)
            mysC.ExecuteNonQuery()
            conn1.Close()

            For x As Integer = 0 To dg1.Rows.Count - 1

                str = "insert into grades values('0','" & dg1.Item(2, x).Value & "','0','" & txtSubjectcode.Text & "','" & frmMain.lblSY.Text & "','" & frmMain.lblSem.Text & "','" & dg1.Item(0, x).Value & "','" & txtInstructor.Text & "')"
                conn1.Open()
                Dim mysC1 As New MySqlCommand(str, conn1)
                mysC1.ExecuteNonQuery()
                MsgBox("Grades successfully inserted", MsgBoxStyle.Information)
                conn1.Close()

            Next
            'kung wala nag exist
        Else
            For x As Integer = 0 To dg1.Rows.Count - 1

                str = "insert into grades values('0','" & dg1.Item(2, x).Value & "','0','" & txtSubjectcode.Text & "','" & frmMain.lblSY.Text & "','" & frmMain.lblSem.Text & "','" & dg1.Item(0, x).Value & "','" & txtInstructor.Text & "')"
                conn1.Open()
                Dim mysC2 As New MySqlCommand(str, conn1)
                mysC2.ExecuteNonQuery()
                MsgBox("Grades successfully inserted", MsgBoxStyle.Information)
                conn1.Close()

            Next
        End If
        conn.Close()
    End Sub

    Private Sub txtInstructor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInstructor.TextChanged

    End Sub
End Class
