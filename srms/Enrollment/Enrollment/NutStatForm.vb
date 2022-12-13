Imports MySql.Data.MySqlClient
Public Class frmNutStatForm
    Dim str As String

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            str = "insert into nutstatus values(0,'" & frmSemStudent.mskStudentNumber.Text & "','" & txtWeight.Text & "','" & txtHeight.Text & "','" & txtHeightSquared.Text & "','" & txtBMI.Text & "','" & txtNutStatus.Text & "','" & txtHFA.Text & "','" & frmParent.lblSY.Text & "','Baseline','" & Convert.ToDateTime(dtpWeighingDate.Text).ToString("yyyy-MM-dd") & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            str = "insert into nutstatus values(0,'" & frmSemStudent.mskStudentNumber.Text & "','" & txtWeight.Text & "','" & txtHeight.Text & "','" & txtHeightSquared.Text & "','" & txtBMI.Text & "','" & txtNutStatus.Text & "','" & txtHFA.Text & "','" & frmParent.lblSY.Text & "','Endline','" & Convert.ToDateTime(dtpWeighingDate.Text).ToString("yyyy-MM-dd") & "')"
            conn.Open()
            Dim mysc1 As New MySqlCommand(str, conn)
            mysc1.ExecuteNonQuery()
            conn.Close()

            MsgBox("New record added!", MsgBoxStyle.Information)




            txtWeight.Text = 0
            txtHeight.Text = 0
            txtHeightSquared.Text = 0
            txtBMI.Text = 0
            txtNutStatus.Clear()
            txtHFA.Clear()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

End Class