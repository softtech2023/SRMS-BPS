Imports MySql.Data.MySqlClient
Public Class frmEducation
    Dim str As String
    Private Sub frmEducation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'FormLoad()
    End Sub
    Public Sub FormLoad()
        cboLevel.ResetText()
        txtSchoolName.Clear()
        txtCourse.Clear()
        txtFrom.Clear()
        txtTo.Clear()
        txtHigestLevel.Clear()
        txtYearGraduated.Clear()
        txtScholarship.Clear()

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            str = "insert into hris_educ values(0,'" & cboLevel.Text & "','" & txtSchoolName.Text & "','" & txtCourse.Text & "','" & txtFrom.Text & "','" & txtTo.Text & "','" & txtHigestLevel.Text & "','" & txtYearGraduated.Text & "','" & txtScholarship.Text & "','" & frmStaff.mskIDNumber.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("New record added!", MsgBoxStyle.Information)
            FormLoad()
            frmStaff.getEduc()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            str = "update hris_educ set level='" & cboLevel.Text & "',schoolName='" & txtSchoolName.Text & "',course='" & txtCourse.Text & "',yearStarted='" & txtFrom.Text & "',yearEnded='" & txtTo.Text & "',highestLevel='" & txtHigestLevel.Text & "',yearGraduated='" & txtYearGraduated.Text & "',scholarship='" & txtScholarship.Text & "' where educID='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("Updated successfully!", MsgBoxStyle.Information)
            FormLoad()
            frmStaff.getEduc()
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from hris_educ where educID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("1 record deleted successfully!", MsgBoxStyle.Information)
                FormLoad()

                Me.Close()
                frmStaff.getEduc()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class