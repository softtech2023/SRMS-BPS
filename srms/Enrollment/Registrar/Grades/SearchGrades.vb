Imports MySql.Data.MySqlClient
Public Class frmSearchGrades
    Dim str As String
    Private Sub frmSearchGrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select * from grades where SY='" & frmParent.lblSY.Text & "' order by StudentName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "grades")
            dg1.DataSource = ds.Tables("grades")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Student No."
            dg1.Columns(2).HeaderText = "Student Name"
            dg1.Columns(2).Width = 120
            dg1.Columns(3).HeaderText = "Subject Code"
            dg1.Columns(3).Width = 80
            dg1.Columns(4).Width = 200

            dg1.Columns(5).Visible = False
            dg1.Columns(6).Visible = False
            dg1.Columns(7).Visible = False
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False
            dg1.Columns(10).Visible = False
            dg1.Columns(11).Visible = False
            dg1.Columns(12).Visible = True
            dg1.Columns(12).HeaderText = "Final Grade"
            dg1.Columns(13).Visible = False
            dg1.Columns(14).Visible = False
            dg1.Columns(15).Visible = False
            dg1.Columns(16).Visible = False
            dg1.Columns(17).Visible = False


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select StudentNumber, StudentName, SubjectCode, Description from grades where StudentName like '%" & txtSearch.Text & "%' or StudentName like '%" & txtSearch.Text & "%' or Description like '%" & txtSearch.Text & "%' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' order by StudentName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "grades")
            dg1.DataSource = ds.Tables("grades")
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        frmGrades.lblID.Text = dg1.Item(0, i).Value
        frmGrades.txtStudentNumber.Text = dg1.Item(1, i).Value
        frmGrades.txtName.Text = dg1.Item(2, i).Value
        frmGrades.txtSubjectCode.Text = dg1.Item(3, i).Value
        frmGrades.txtDescription.Text = dg1.Item(4, i).Value
        frmGrades.txtLecUnit.Text = dg1.Item(5, i).Value
        frmGrades.txtInstructor.Text = dg1.Item(6, i).Value
        frmGrades.txtSection.Text = dg1.Item(7, i).Value
        frmGrades.txt1Grading.Text = dg1.Item(8, i).Value
        frmGrades.txt2Grading.Text = dg1.Item(9, i).Value
        frmGrades.txt3Grading.Text = dg1.Item(10, i).Value
        frmGrades.txt4Grading.Text = dg1.Item(11, i).Value
        frmGrades.txtAverage.Text = dg1.Item(12, i).Value
        frmGrades.txtRemarks.Text = dg1.Item(13, i).Value

        frmGrades.tsSave.Enabled = False
        frmGrades.tsUpdate.Enabled = True
        frmGrades.tsDelete.Enabled = True

        Me.Close()
    End Sub
End Class