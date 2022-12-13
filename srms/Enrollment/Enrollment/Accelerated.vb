Imports MySql.Data.MySqlClient
Public Class frmAccelerated
    Dim str As String
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            str = "insert into studestat values(0,'" & frmSemStudent.lblID.Text & "','" & frmSemStudent.mskStudentNumber.Text & "','Accelerated','" & txtPT.Text & "','" & txtS.Text & "','" & Convert.ToDateTime(dtpDP.Text).ToString("yyyy-MM-dd") & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(Str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            'update semesterstude status
            str = "update semesterstude set Status='Accelerated' where semstudentid='" & frmSemStudent.lblID.Text & "'"
            conn.Open()
            Dim mysc1 As New MySqlCommand(Str, conn)
            mysc1.ExecuteNonQuery()
            conn.Close()

            MsgBox("Record saved!", MsgBoxStyle.Information)
            txtPT.Clear()
            txtS.Clear()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class