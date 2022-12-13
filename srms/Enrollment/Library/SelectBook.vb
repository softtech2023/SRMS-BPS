Imports MySql.Data.MySqlClient
Public Class frmSelectBook
    Dim str As String
    Dim i As Integer
    Public Sub formLoad()
        Try
            str = "select BookID, BookNo,Title from libbookentry where BookStatus='In' order by Title"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libbookentry")
            dg1.DataSource = ds.Tables("libbookentry")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 150
            dg1.Columns(2).Width = 350
            txtsearch.Focus()
            txtsearch.Clear()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try

            i = dg1.CurrentRow.Index
            frmLoanBooks.lblBookID.Text = dg1.Item(0, i).Value
            frmLoanBooks.txtbookno.Text = dg1.Item(1, i).Value
            frmLoanBooks.txttitle.Text = dg1.Item(2, i).Value
            frmStaffLoan.lblBookID.Text = dg1.Item(0, i).Value
            frmStaffLoan.txtbookno.Text = dg1.Item(1, i).Value
            frmStaffLoan.txttitle.Text = dg1.Item(2, i).Value
            frmLoanBooks.tsSave.Enabled = True
            frmStaffLoan.tsSave.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            conn.Close()
        End Try
        Me.Close()
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Try
            str = "select BookID, BookNo,Title from libbookentry where Title like '%" & txtsearch.Text & "%' and BookStatus='In' order by Title"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libbookentry")
            dg1.DataSource = ds.Tables("libbookentry")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 150
            dg1.Columns(1).HeaderText = "Book No."
            dg1.Columns(2).Width = 370

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Private Sub frmSelectBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()
    End Sub
End Class