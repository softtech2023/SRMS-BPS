Imports MySql.Data.MySqlClient
Public Class frmSemSubjects
    Dim str As String

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        frmSearchStaff.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSearchSubjects.Show()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        str = "insert into semsubjects values('0','" & txtSubjectCode.Text & "','" & txtSubjectDescription.Text & "','" & txtLecUnits.Text & "','" & txtLabUnits.Text & "','" & txtSection.Text & "','" & txtDay.Text & "','" & txtTime.Text & "','" & txtRoom.Text & "','" & txtSlot.Text & "','" & cboClass.Text & "','" & txtInstructor.Text & "')"
        conn.Open()
        Dim mysC As New MySqlCommand(str, conn)
        mysC.ExecuteNonQuery()

        MsgBox("Data successfully saved!", MsgBoxStyle.Information, "Prompt")

        conn.Close()
        frmSearchStudents.StudeprofileTableAdapter.Fill(frmSearchStudents.DataSet.studeprofile)
        ClearFields()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmSubjects.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmSearchSubjects.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If txtSubjectCode.Text = "" Or txtSubjectDescription.Text = "" Or txtLecUnits.Text = "" Or txtLabUnits.Text = "" Or txtDay.Text = "" Or txtInstructor.Text = "" Or txtSlot.Text = "" Or txtTime.Text = "" Or cboClass.Text = "" Then
            MsgBox("All fields are required", MsgBoxStyle.Information)
            Exit Sub
        End If

        str = "insert into semsubjects values('0','" & txtSubjectCode.Text & "','" & txtSubjectDescription.Text & "','" & txtLecUnits.Text & "','" & txtLabUnits.Text & "','" & txtSection.Text & "','" & txtDay.Text & "','" & txtTime.Text & "','" & txtRoom.Text & "','" & txtSlot.Text & "','" & cboClass.Text & "','" & txtInstructor.Text & "','" & frmMain.lblSY.Text & "','" & frmMain.lblSem.Text & "')"
        conn.Open()
        Dim mysC As New MySqlCommand(str, conn)
        mysC.ExecuteNonQuery()
        MsgBox("Data successfully added!", MsgBoxStyle.Information)
        conn.Close()
        ClearFields()
    End Sub
    Public Sub ClearFields()
        txtSubjectCode.Clear()
        txtSubjectDescription.Clear()
        txtLecUnits.Clear()
        txtLabUnits.Clear()
        txtSection.Clear()
        txtDay.Clear()
        txtTime.Clear()
        txtRoom.Clear()
        txtSlot.Clear()
        cboClass.ResetText()
        txtInstructor.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

    End Sub

    Private Sub frmSemSubjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtSubjectCode.Enabled = True
    End Sub
End Class