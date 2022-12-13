Imports MySql.Data.MySqlClient
Public Class frmLoanStude
    Dim str As String
    Dim i As Integer

    Private Sub frmLoanStude_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = " select loanID, StudentNumber, Name, Course, YearLevel from libloans where Returned='No' and borrowerCat='Student' group by StudentNumber order by Name"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libloans")
            dg1.DataSource = ds.Tables("libloans")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 150
            dg1.Columns(2).Width = 250
            dg1.Columns(3).Width = 150
            dg1.Columns(4).Width = 150
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub
    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        i = dg1.CurrentRow.Index
        'frmReturnBooks.lblloanID.Text = dg1.Item(0, i).Value
        frmReturnBooks.txtStudentNo.Text = dg1.Item(1, i).Value
        frmReturnBooks.txtName.Text = dg1.Item(2, i).Value
        frmReturnBooks.txtCourse.Text = dg1.Item(3, i).Value
        frmReturnBooks.txtYearLevel.Text = dg1.Item(4, i).Value

        frmReturnBooks.btnselectbook.Enabled = True
        frmReturnBooks.tsSave.Enabled = True
        Me.Close()

    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Try
            str = " select semstudentID, StudentNumber, Name, Course, YearLevel from libloans where borrower='Student' or Name like '%" & txtsearch.Text & "%' or StudentNumber like '%" & txtsearch.Text & "%' and Returned='No' and borrowerCat='Student' group by StudentNumber order by Name"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libloans")
            dg1.DataSource = ds.Tables("libloans")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 150
            dg1.Columns(2).Width = 250
            dg1.Columns(3).Width = 150
            dg1.Columns(4).Width = 150
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub
End Class