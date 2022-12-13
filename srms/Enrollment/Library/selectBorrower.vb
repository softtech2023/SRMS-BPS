Imports MySql.Data.MySqlClient
Public Class frmSelectBorrower
    Dim str As String
    Private Sub frmSelectBorrower_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formload()
    End Sub
    Public Sub formload()
        Try
            str = "select p.StudentNumber, concat(p.FirstName,' ',p.LastName) as StudeName, ss.Course, ss.YearLevel from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' order by p.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            dg1.DataSource = ds.Tables("studeprofile, semesterstude")
            conn.Close()

            dg1.Columns(0).HeaderText = "Student No."
            dg1.Columns(1).Width = 200
            dg1.Columns(1).HeaderText = "Student Name"
            dg1.Columns(2).Width = 300
            dg1.Columns(2).HeaderText = "Department"
            dg1.Columns(3).HeaderText = "Year Level"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index

        frmLoanBooks.txtStudentNo.Text = dg1.Item(0, i).Value
        frmLoanBooks.txtName.Text = dg1.Item(1, i).Value
        frmLoanBooks.txtCourse.Text = dg1.Item(2, i).Value
        frmLoanBooks.txtYearLevel.Text = dg1.Item(3, i).Value
        frmLoanBooks.btnselectbook.Enabled = True
        frmLoanBooks.tsSave.Enabled = True
        Me.Close()
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Try
            str = "select p.StudentNumber, concat(p.FirstName,' ',p.LastName) as StudeName, ss.Course, ss.YearLevel from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where p.LastName like '%" & txtsearch.Text & "%' and ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' order by p.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            dg1.DataSource = ds.Tables("studeprofile, semesterstude")
            conn.Close()

            dg1.Columns(0).HeaderText = "Student No."
            dg1.Columns(1).Width = 200
            dg1.Columns(1).HeaderText = "Student Name"
            dg1.Columns(2).Width = 300
            dg1.Columns(2).HeaderText = "Department"
            dg1.Columns(3).HeaderText = "Year Level"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class