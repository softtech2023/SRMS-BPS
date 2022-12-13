Imports MySql.Data.MySqlClient
Public Class frmselect_input_grades
    Dim str As String
    Private Sub frmselect_input_grades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select SubjectCode, Description, LecUnit, LabUnit, Section, Instructor, Sem, SY from registration where Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' group by SubjectCode, Description, Instructor"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "registration")
            dgSubjects.DataSource = ds.Tables("registration")
            conn.Close()

            dgSubjects.Columns(0).HeaderText = "Subject Code"
            dgSubjects.Columns(0).Width = 80
            dgSubjects.Columns(1).Width = 150
            dgSubjects.Columns(2).Visible = False
            dgSubjects.Columns(2).Width = 70
            dgSubjects.Columns(3).Visible = False
            dgSubjects.Columns(3).Width = 70
            dgSubjects.Columns(5).Width = 150
            dgSubjects.Columns(6).Visible = False
            dgSubjects.Columns(7).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select SubjectCode, Description, LecUnit, LabUnit, Section, Instructor, Sem, SY from registration where SubjectCode like '%" & txtSearch.Text & "%' or Description like '%" & txtSearch.Text & "%' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' group by SubjectCode, Description, Instructor"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "registration")
            dgSubjects.DataSource = ds.Tables("registration")
            conn.Close()

            dgSubjects.Columns(0).HeaderText = "Subject Code"
            dgSubjects.Columns(0).Width = 80
            dgSubjects.Columns(1).Width = 150
            dgSubjects.Columns(2).Visible = False
            dgSubjects.Columns(2).Width = 70
            dgSubjects.Columns(3).Visible = False
            dgSubjects.Columns(3).Width = 70
            dgSubjects.Columns(5).Width = 150
            dgSubjects.Columns(6).Visible = False
            dgSubjects.Columns(7).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub dgSubjects_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgSubjects.DoubleClick
        Dim i As Integer
        i = dgSubjects.CurrentRow.Index
        frmGrades.txtSubjectCode.Text = dgSubjects.Item(0, i).Value
        frmGrades.txtDescription.Text = dgSubjects.Item(1, i).Value
        frmGrades.txtLecUnit.Text = dgSubjects.Item(2, i).Value
        frmGrades.txtSection.Text = dgSubjects.Item(4, i).Value
        frmGrades.txtInstructor.Text = dgSubjects.Item(5, i).Value

        txtSearch.Clear()
        Me.Close()
    End Sub
End Class