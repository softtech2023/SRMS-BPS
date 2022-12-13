Imports MySql.Data.MySqlClient
Public Class frmSemStudent
    Dim str As String

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
    Private Sub txtFname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFname.TextChanged

    End Sub
    Private Sub txtMName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMName.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmSearchStudents.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmStudeProfile.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        mskStudentNumber.Clear()
        txtFname.Clear()
        txtMName.Clear()
        txtLastName.Clear()
        cboCourse.ResetText()
        cboYear.ResetText()
        cboStatus.ResetText()
    End Sub

    Private Sub frmSemStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.DataSet.courses)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If mskStudentNumber.Text = "" Then
            MsgBox("Select student first before saving", MsgBoxStyle.Information)
            mskStudentNumber.Focus()
            Exit Sub
        End If

        str = "select * from semesterstude where StudentNumber='" & mskStudentNumber.Text & "'"
        conn.Open()
        Dim mysda As New MySqlDataAdapter(str, conn)
        Dim ds As New DataSet
        mysda.Fill(ds, "semesterstude")

        If ds.Tables("semesterstude").Rows.Count = 1 Then
            MsgBox("Student Number already exist for the current semester!", MsgBoxStyle.Information)
            conn.Close()
            mskStudentNumber.Focus()
            Exit Sub
        End If
        conn.Close()

        str = "insert into semesterstude values('0','" & mskStudentNumber.Text & "','" & txtFname.Text & "','" & txtMName.Text & "','" & txtLastName.Text & "','" & cboCourse.Text & "','" & cboYear.Text & "','" & cboStatus.Text & "','" & frmMain.lblSem.Text & "','" & frmMain.lblSY.Text & "')"
        conn.Open()
        Dim mysC As New MySqlCommand(str, conn)
        mysC.ExecuteNonQuery()

        MsgBox("Data successfully saved!", MsgBoxStyle.Information, "Prompt")

        conn.Close()
    End Sub
End Class