Imports MySql.Data.MySqlClient
Public Class frmSelectStudetoDropped
    Dim str As String
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSelectStudetoDropped_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select StudentNumber, LastName, FirstName, MiddleName, Course, YearLevel, Section, Sem, SY from registration where Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' group by StudentNumber order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "registration")
            dgsemstudent.DataSource = ds.Tables("registration")
            conn.Close()

            dgsemstudent.Columns(0).HeaderText = "Student No."
            dgsemstudent.Columns(1).HeaderText = "Last Name"
            dgsemstudent.Columns(2).HeaderText = "First Name"
            dgsemstudent.Columns(3).HeaderText = "Middle Name"
            dgsemstudent.Columns(4).HeaderText = "Course"
            dgsemstudent.Columns(4).Width = 250
            dgsemstudent.Columns(5).HeaderText = "Yr. Level"
            dgsemstudent.Columns(5).Width = 50
            dgsemstudent.Columns(6).Visible = False
            dgsemstudent.Columns(7).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select StudentNumber, LastName, FirstName, MiddleName, Course, YearLevel, Section, Sem, SY from registration where LastName like '%" & txtSearch.Text & "%' or StudentNumber like '%" & txtSearch.Text & "%' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' group by StudentNumber order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "registration")
            dgsemstudent.DataSource = ds.Tables("registration")
            conn.Close()

            dgsemstudent.Columns(0).HeaderText = "Student No."
            dgsemstudent.Columns(1).HeaderText = "Last Name"
            dgsemstudent.Columns(2).HeaderText = "First Name"
            dgsemstudent.Columns(3).HeaderText = "Middle Name"
            dgsemstudent.Columns(4).HeaderText = "Course"
            dgsemstudent.Columns(4).Width = 250
            dgsemstudent.Columns(5).HeaderText = "Yr. Level"
            dgsemstudent.Columns(5).Width = 50
            dgsemstudent.Columns(6).Visible = False
            dgsemstudent.Columns(7).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dgsemstudent_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgsemstudent.DoubleClick
        Try
            Dim i As Integer
            i = dgsemstudent.CurrentRow.Index

            frmAdding.mskStudentNumber.Text = dgsemstudent(0, i).Value
            frmAdding.txtLastName.Text = dgsemstudent(1, i).Value
            frmAdding.txtFirstName.Text = dgsemstudent(2, i).Value
            frmAdding.txtMiddleName.Text = dgsemstudent(3, i).Value
            frmAdding.txtCourse.Text = dgsemstudent(4, i).Value
            frmAdding.txtYearLevel.Text = dgsemstudent(5, i).Value
            frmAdding.lblSection.Text = dgsemstudent(6, i).Value

            frmAdding.btnAddSubject.Enabled = True
            frmAdding.tsSave.Enabled = True
            frmAdding.tsUpdate.Enabled = True
            frmAdding.btnAddSubject.Enabled = True


            'frmAdding.LoadSubjects()
            'frmAdding.getTotalLecUnits()
            'frmAdding.getTotalLabUnits()
            'frmAdding.TotalUnits()
            txtSearch.Clear()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class