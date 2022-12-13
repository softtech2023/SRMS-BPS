Imports MySql.Data.MySqlClient
Public Class frmSemSubjectsCopy
    Dim str As String
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim subject As String

        If frmParent.lblSem.Text = "1st Sem." Or frmParent.lblSem.Text = "2nd Sem." Or frmParent.lblSem.Text = "Summer" Then
            If cboSemester.Text = "" Then
                MsgBox("Semester is required!", MsgBoxStyle.Exclamation)
                cboSemester.Focus()
                Exit Sub
            End If

            For x As Integer = 0 To frmSemSubjects.dgsubjects.Rows.Count - 1
                subject = frmSemSubjects.dgsubjects.Item(2, x).Value.Replace("'", "''")

                str = "insert into semsubjects values('0','" & frmSemSubjects.dgsubjects.Item(1, x).Value & "','" & subject & "','" & frmSemSubjects.dgsubjects.Item(3, x).Value & "','" & frmSemSubjects.dgsubjects.Item(4, x).Value & "','" & frmSemSubjects.dgsubjects.Item(5, x).Value & "','" & frmSemSubjects.dgsubjects.Item(6, x).Value & "','" & frmSemSubjects.dgsubjects.Item(7, x).Value & "','" & frmSemSubjects.dgsubjects.Item(8, x).Value & "','" & frmSemSubjects.dgsubjects.Item(9, x).Value & "','" & frmSemSubjects.dgsubjects.Item(10, x).Value & "','" & txtSchoolYear.Text & "','" & cboSemester.Text & "','" & frmSemSubjects.dgsubjects.Item(13, x).Value & "','" & frmSemSubjects.dgsubjects.Item(14, x).Value & "','" & frmSemSubjects.dgsubjects.Item(15, x).Value & "','" & frmSemSubjects.dgsubjects.Item(16, x).Value & "','" & frmSemSubjects.dgsubjects.Item(17, x).Value & "','" & frmSemSubjects.dgsubjects.Item(18, x).Value & "','" & frmSemSubjects.dgsubjects.Item(19, x).Value & "','" & frmSemSubjects.dgsubjects.Item(20, x).Value & "','" & frmSemSubjects.dgsubjects.Item(21, x).Value & "','" & frmSemSubjects.dgsubjects.Item(22, x).Value & "','" & frmSemSubjects.dgsubjects.Item(23, x).Value & "','" & frmSemSubjects.dgsubjects.Item(24, x).Value & "','" & frmSemSubjects.dgsubjects.Item(25, x).Value & "','" & frmSemSubjects.dgsubjects.Item(26, x).Value & "','" & frmSemSubjects.dgsubjects.Item(27, x).Value & "')"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()
            Next

        Else
            For x As Integer = 0 To frmSemSubjects.dgsubjects.Rows.Count - 1
                subject = frmSemSubjects.dgsubjects.Item(2, x).Value.Replace("'", "''")

                str = "insert into semsubjects values('0','" & frmSemSubjects.dgsubjects.Item(1, x).Value & "','" & subject & "','" & frmSemSubjects.dgsubjects.Item(3, x).Value & "','" & frmSemSubjects.dgsubjects.Item(4, x).Value & "','" & frmSemSubjects.dgsubjects.Item(5, x).Value & "','" & frmSemSubjects.dgsubjects.Item(6, x).Value & "','" & frmSemSubjects.dgsubjects.Item(7, x).Value & "','" & frmSemSubjects.dgsubjects.Item(8, x).Value & "','" & frmSemSubjects.dgsubjects.Item(9, x).Value & "','" & frmSemSubjects.dgsubjects.Item(10, x).Value & "','" & txtSchoolYear.Text & "','','" & frmSemSubjects.dgsubjects.Item(13, x).Value & "','" & frmSemSubjects.dgsubjects.Item(14, x).Value & "','" & frmSemSubjects.dgsubjects.Item(15, x).Value & "','" & frmSemSubjects.dgsubjects.Item(16, x).Value & "','" & frmSemSubjects.dgsubjects.Item(17, x).Value & "','" & frmSemSubjects.dgsubjects.Item(18, x).Value & "','" & frmSemSubjects.dgsubjects.Item(19, x).Value & "','" & frmSemSubjects.dgsubjects.Item(20, x).Value & "','" & frmSemSubjects.dgsubjects.Item(21, x).Value & "','" & frmSemSubjects.dgsubjects.Item(22, x).Value & "','" & frmSemSubjects.dgsubjects.Item(23, x).Value & "','" & frmSemSubjects.dgsubjects.Item(24, x).Value & "','" & frmSemSubjects.dgsubjects.Item(25, x).Value & "','" & frmSemSubjects.dgsubjects.Item(26, x).Value & "','" & frmSemSubjects.dgsubjects.Item(27, x).Value & "')"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()
            Next
        End If

        MsgBox("Data successfully copied!", MsgBoxStyle.Information)
        Me.Close()
    End Sub
End Class