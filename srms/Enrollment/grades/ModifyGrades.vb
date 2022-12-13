Imports MySql.Data.MySqlClient
Public Class frmModifyGrades
    Dim str As String
    Private Sub tsNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsNew.Click
        frmSearchStudeEncodeGrades.ShowDialog()
    End Sub

    Public Sub formLoad()
        'mskStudentNumber.Clear()
        'txtStudeName.Clear()
        btnAdd.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False

        txtFirst.Text = 0
        txtSecond.Text = 0
        txtThird.Text = 0
        txtFourth.Text = 0
        txtAverage.Text = 0

        txtSubjectCode.Clear()
        txtDescription.Clear()
        txtSection.Clear()
        txtTeacher.Clear()

        getGrades()

    End Sub

    Public Sub getGrades()
        Try
            str = "select SubjectCode, Description, PGrade, MGrade, PFinalGrade, FGrade, Average, Section, Instructor, gradeID from grades where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "grades")
            dg1.DataSource = ds.Tables("grades")
            conn.Close()

            dg1.Columns(1).Width = 250
            dg1.Columns(2).Width = 70
            dg1.Columns(2).HeaderText = 1
            dg1.Columns(3).Width = 70
            dg1.Columns(3).HeaderText = 2
            dg1.Columns(4).Width = 70
            dg1.Columns(4).HeaderText = 3
            dg1.Columns(5).Width = 70
            dg1.Columns(5).HeaderText = 4
            dg1.Columns(6).Width = 80

            dg1.Columns(7).Visible = False
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getAverage()
        Dim average As Double

        If frmParent.lblSem.Text = "1st Sem." Or frmParent.lblSem.Text = "2nd Sem." Then
            average = (Val(txtFirst.Text) + Val(txtSecond.Text)) / 2
            txtAverage.Text = average
            txtThird.Enabled = False
            txtFourth.Enabled = False
        Else
            average = (Val(txtFirst.Text) + Val(txtSecond.Text) + Val(txtThird.Text) + Val(txtFourth.Text)) / 4
            txtAverage.Text = average
            txtThird.Enabled = True
            txtFourth.Enabled = True
        End If

    End Sub

    Private Sub txtFirst_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirst.TextChanged
        getAverage()
    End Sub

    Private Sub txtSecond_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSecond.TextChanged
        getAverage()
    End Sub

    Private Sub txtThird_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtThird.TextChanged
        getAverage()
    End Sub

    Private Sub txtFourth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFourth.TextChanged
        getAverage()
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        txtSubjectCode.Text = dg1.Item(0, i).Value
        txtDescription.Text = dg1.Item(1, i).Value
        txtFirst.Text = dg1.Item(2, i).Value
        txtSecond.Text = dg1.Item(3, i).Value
        txtThird.Text = dg1.Item(4, i).Value
        txtFourth.Text = dg1.Item(5, i).Value

        txtSection.Text = dg1.Item(7, i).Value
        txtTeacher.Text = dg1.Item(8, i).Value
        lblID.Text = dg1.Item(9, i).Value

        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnAdd.Enabled = True
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            str = "delete from grades where gradeid='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("1 record deleted successfully!", MsgBoxStyle.Information)
            conn.Close()
            formLoad()
            btnAdd.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub

    Private Sub frmModifyGrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            str = "update grades set PGrade='" & txtFirst.Text & "',MGrade='" & txtSecond.Text & "',PFinalGrade='" & txtThird.Text & "',FGrade='" & txtFourth.Text & "',Average='" & txtAverage.Text & "' where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and SubjectCode='" & txtSubjectCode.Text & "' and Description='" & txtDescription.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("1 record successfuly updated!", MsgBoxStyle.Information)
            formLoad()

            btnAdd.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmEncodeGrades.Show()
        frmEncodeGrades.mskStudentNumber.Text = mskStudentNumber.Text
        frmEncodeGrades.txtStudeName.Text = txtStudeName.Text

    End Sub

    Private Sub btnDeleteAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteAll.Click
        Try
            str = "delete from grades where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("1 record deleted successfully!", MsgBoxStyle.Information)
            conn.Close()
            formLoad()
            btnAdd.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub
End Class