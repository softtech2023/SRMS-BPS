Imports MySql.Data.MySqlClient
Public Class frmClassAtt
    Dim str As String
    Private Sub tsSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSearch.Click
        frmSearchSubjects2.ShowDialog()
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
    Public Sub atteance()
        str = "select r.StudentNumber, concat(s.LName,', ',s.FName) as Fullname from registration r join semesterstude s on s.studentnumber=r.studentnumber join studeprofile p on p.StudentNumber=s.StudentNumber where r.subjectcode='" & txtSubjectcode.Text & "' and r.Description='" & txtDescription.Text & "' and r.Sem='" & frmParent.lblSem.Text & "' and r.SY='" & frmParent.lblSY.Text & "' and r.Section='" & txtSection.Text & "' group by StudentNumber order by p.Sex, Fullname"
        conn.Open()
        Dim mysDA As New MySqlDataAdapter(str, conn)
        Dim ds1 As New DataSet
        mysDA.Fill(ds1, "studeprofile, registration, semesterstude")
        dg1.DataSource = ds1.Tables("studeprofile, registration, semesterstude")
        dg1.Columns(1).Width = 200
        dg1.Columns(1).HeaderText = "Student Name"
        dg1.Columns(0).ReadOnly = True
        dg1.Columns(0).HeaderText = "LRN"
        dg1.Columns(1).ReadOnly = True
        conn.Close()

    End Sub

    Private Sub txtSubjectcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubjectcode.TextChanged
        atteance()
        getInstructor()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            For x As Integer = 0 To dg1.Rows.Count - 1

                str = "insert into classattendance values('0','" & dg1.Item(0, x).Value & "','" & dg1.Item(1, x).Value & "','" & Convert.ToDateTime(frmParent.dtpDate.Text).ToString("yyyy-MM-dd") & "','','" & frmClassAttendanceForm.lblTerminalNo.Text & "','" & txtSubjectcode.Text & "','" & txtDescription.Text & "','" & txtSection.Text & "','" & txtInstructor.Text & "','Absent','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "')"
                conn.Open()
                Dim mysC2 As New MySqlCommand(str, conn)
                mysC2.ExecuteNonQuery()
                conn.Close()
            Next
            MsgBox("Attendance successfully saved!", MsgBoxStyle.Information)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class