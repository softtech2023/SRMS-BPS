Imports MySql.Data.MySqlClient
Public Class frmWE
    Dim str As String
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            str = "insert into hris_we values(0,'" & txtFrom.Text & "','" & txtTo.Text & "','" & txtPosition.Text & "','" & txtOffice.Text & "','" & txtSalary.Text & "','" & txtSalaryGrade.Text & "','" & txtAppointStatus.Text & "','" & cboGovService.Text & "','" & frmStaff.mskIDNumber.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("New record added!", MsgBoxStyle.Information)
            FormLoad()


            frmStaff.getWE()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub FormLoad()
        txtFrom.Clear()
        txtTo.Clear()
        txtPosition.Clear()
        txtOffice.Clear()
        txtSalary.Text = 0
        txtSalaryGrade.Clear()
        txtAppointStatus.Clear()
        cboGovService.ResetText()

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from hris_we where weID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("1 record deleted successfully!", MsgBoxStyle.Information)
                FormLoad()

                Me.Close()
                frmStaff.getWE()

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            str = "update hris_we set dateFrom='" & txtFrom.Text & "',dateTo='" & txtTo.Text & "',positionTitle='" & txtPosition.Text & "',office='" & txtOffice.Text & "',monthlySalary='" & txtSalary.Text & "',salaryGrade='" & txtSalaryGrade.Text & "',appointStatus='" & txtAppointStatus.Text & "',govtservice='" & cboGovService.Text & "' where weID='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("Updated successfully!", MsgBoxStyle.Information)
            FormLoad()
            Me.Close()
            frmStaff.getWE()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class