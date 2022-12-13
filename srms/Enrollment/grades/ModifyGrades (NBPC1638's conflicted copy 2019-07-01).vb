Imports MySql.Data.MySqlClient
Public Class frmModifyGrades
    Dim str As String
    Private Sub tsNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsNew.Click
        frmSearchStudeEncodeGrades.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmSearchModifyGrades.ShowDialog()
    End Sub

    Public Sub getInstructor()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            Str = "select concat(FirstName,' ',LastName) as Name from staff where IDNumber='" & frmParent.lblUser.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(Str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtTeacher.Text = dtReader.Item(0)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub frmModifyGrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'getInstructor()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            str = "delete from grades where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and SubjectCode='" & txtSubjectCode.Text & "' and Section='" & txtSection.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("1 record deleted successfully!", MsgBoxStyle.Information)
            conn.Close()
            formLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub
    Public Sub formLoad()
        mskStudentNumber.Clear()
        txtStudeName.Clear()
        txtSubjectCode.Clear()
        txtDescription.Clear()
        txtSection.Clear()
        txtTeacher.Clear()
    End Sub
End Class