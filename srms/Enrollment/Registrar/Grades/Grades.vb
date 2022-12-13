Imports MySql.Data.MySqlClient
Public Class frmGrades
    Dim str As String

    Public Sub getAverage()
        Dim ave As Double
        ave = (Val(txt1Grading.Text) + Val(txt2Grading.Text) + Val(txt3Grading.Text) + Val(txt4Grading.Text)) / 4
        txtAverage.Text = Format(ave, "0.00")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmselect_input_grades.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtSubjectCode.Text = "" Then
            MsgBox("Select Subject first!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        frmselect_input_stude.ShowDialog()
    End Sub

    Private Sub tsSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            If txtSubjectCode.Text = "" Then
                MsgBox("Subject details is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txtStudentNumber.Text = "" Then
                MsgBox("Student details is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            str = "select * from grades where StudentNumber='" & txtStudentNumber.Text & "' and SY='" & frmParent.lblSY.Text & "' and SubjectCode='" & txtSubjectCode.Text & "' and Description='" & txtDescription.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "grades")
            conn.Close()

            If ds.Tables("grades").Rows.Count = 1 Then
                MsgBox("Record exist!", MsgBoxStyle.Exclamation)
                conn.Close()
                Exit Sub
            End If

            str = "insert into grades values (0,'" & txtStudentNumber.Text & "','" & txtName.Text & "','" & txtSubjectCode.Text & "','" & txtDescription.Text & "','" & txtLecUnit.Text & "','" & txtInstructor.Text & "','" & txtSection.Text & "','" & txt1Grading.Text & "','" & txt2Grading.Text & "','" & txt3Grading.Text & "','" & txt4Grading.Text & "','" & txtAverage.Text & "','" & txtRemarks.Text & "','" & frmParent.lblSY.Text & "','Open','" & lblCourse.Text & "','" & lblGradeLevel.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record added successfully!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub FormLoad()
        txtStudentNumber.Clear()
        txtName.Clear()
        txt1Grading.Clear()
        txt2Grading.Clear()
        txt3Grading.Clear()
        txt4Grading.Clear()
        txtAverage.Clear()
        txtRemarks.Clear()

        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
    End Sub

    Private Sub frmGrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtSubjectCode.Clear()
        txtDescription.Clear()
        txtLecUnit.Clear()
        txtInstructor.Clear()
        txtSection.Clear()
    End Sub
    Public Sub getRemarks()
        Try
            If txtAverage.Text <= 74.4 Then
                txtRemarks.Text = "Failed"
            Else
                txtRemarks.Text = "Passed"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        getAverage()
        getRemarks()
    End Sub

    Private Sub tsSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSearch.Click
        frmSearchGrades.ShowDialog()
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
                str = "delete from grades where gradeID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Record deleted!", MsgBoxStyle.Information)
                conn.Close()

                FormLoad()
                btnReset.PerformClick()
                tsSave.Enabled = True
                tsUpdate.Enabled = False
                tsDelete.Enabled = False

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            If txtSubjectCode.Text = "" Then
                MsgBox("Subject details is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txtStudentNumber.Text = "" Then
                MsgBox("Student details is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            str = "update grades set StudentNumber='" & txtStudentNumber.Text & "',StudentName='" & txtName.Text & "',SubjectCode='" & txtSubjectCode.Text & "',Description='" & txtDescription.Text & "',Units='" & txtLecUnit.Text & "',Instructor='" & txtInstructor.Text & "',Section='" & txtSection.Text & "',FirstGrading='" & txt1Grading.Text & "',SecondGrading='" & txt2Grading.Text & "',ThirdGrading='" & txt3Grading.Text & "',FourthGrading='" & txt4Grading.Text & "',Average='" & txtAverage.Text & "',Remarks='" & txtRemarks.Text & "' where gradeID='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record updated successfully!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
            btnReset.PerformClick()
            tsSave.Enabled = True
            tsUpdate.Enabled = False
            tsDelete.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txt1Grading.Clear()
        txt2Grading.Clear()
        txt3Grading.Clear()
        txt4Grading.Clear()
        txtAverage.Clear()
        txtRemarks.Clear()
    End Sub

End Class
