Imports MySql.Data.MySqlClient
Public Class frmPrevGrades
    Dim str As String
    Private Sub tsClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsClose.Click
        Me.Close()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            If txtStudeNumber.Text = "" Then
                MsgBox("Student number is required!", MsgBoxStyle.Exclamation)
                txtStudeNumber.Focus()
                Exit Sub
            End If

            If txtSubjectCode.Text = "" Then
                MsgBox("Subject code is required!", MsgBoxStyle.Exclamation)
                txtSubjectCode.Focus()
                Exit Sub
            End If

            If cboSemester.Text = "" Then
                MsgBox("Semester is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txtSY.Text = "" Then
                MsgBox("School Year is required!", MsgBoxStyle.Exclamation)
                txtSY.Focus()
                Exit Sub
            End If

            str = "insert into grades values('0','" & txtFinal.Text & "','" & txtComplied.Text & "','" & txtSubjectCode.Text & "','" & txtSY.Text & "','" & cboSemester.Text & "','" & frmParent.lblTerm.Text & "','" & txtStudeNumber.Text & "','" & lblInstructorID.Text & "','" & lblSection.Text & "','" & txtDescription.Text & "','" & txtSchool.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record saved!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub FormLoad()
        txtSubjectCode.Clear()
        txtDescription.Clear()
        txtFinal.Clear()
        txtComplied.Clear()

        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmSelectSubjectsPrev.ShowDialog()
    End Sub

    Private Sub frmPrevGrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmselectStudent.ShowDialog()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Try
            str = "select StudentNumber, SubjectCode, Description, Final, Complied, Semester, SY, TakenAt from grades where StudentNumber='" & txtSearchStude.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "grades")
            dg1.DataSource = ds.Tables("grades")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Subject Code"
            dg1.Columns(1).Width = 80
            dg1.Columns(2).HeaderText = "Subject Description"
            dg1.Columns(2).Width = 250
            dg1.Columns(3).Width = 50
            dg1.Columns(4).HeaderText = "Comp."
            dg1.Columns(4).Width = 50
            dg1.Columns(5).Width = 80
            dg1.Columns(6).Width = 80
            dg1.Columns(7).HeaderText = "Taken At"
            dg1.Columns(7).Width = 250
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        txtStudeNumber.Text = dg1.Item(0, i).Value
        txtSubjectCode.Text = dg1.Item(1, i).Value
        txtDescription.Text = dg1.Item(2, i).Value
        txtFinal.Text = dg1.Item(3, i).Value
        txtComplied.Text = dg1.Item(4, i).Value
        cboSemester.Text = dg1.Item(5, i).Value
        txtSY.Text = dg1.Item(6, i).Value
        txtSchool.Text = dg1.Item(7, i).Value

        tsSave.Enabled = False
        tsUpdate.Enabled = True
        tsDelete.Enabled = True
        Button1.Enabled = False
        Button2.Enabled = False
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from grades where SubjectCode='" & txtSubjectCode.Text & "' and StudentNumber='" & txtStudeNumber.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Record deleted!", MsgBoxStyle.Information)
                conn.Close()
                FormLoad()
                btnView.PerformClick()
                Button1.Enabled = True
                Button2.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            str = "update grades set Final='" & txtFinal.Text & "',Complied='" & txtComplied.Text & "',SY='" & txtSY.Text & "',Semester='" & cboSemester.Text & "',TakenAt='" & txtSchool.Text & "' where StudentNumber='" & txtStudeNumber.Text & "' and SubjectCode='" & txtSubjectCode.Text & "' and Description='" & txtDescription.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record updated!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
            btnView.PerformClick()
            Button1.Enabled = True
            Button2.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class