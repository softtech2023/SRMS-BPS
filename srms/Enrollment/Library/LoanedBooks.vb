Imports MySql.Data.MySqlClient
Public Class frmLoanedBooks
    Dim str As String
    Dim i As Integer

    Private Sub LoanedBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            str = "select BookID,BookNo,Title,BorDate,DueDate,ProcBy from libloans where Returned='No' and StudentNumber='" & frmReturnBooks.txtStudentNo.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libloans")
            dg1.DataSource = ds.Tables("libloans")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(3).HeaderText = "Borrowed Date"
            dg1.Columns(4).HeaderText = "Due Date"
            dg1.Columns(5).HeaderText = "Proccessed By"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try

    End Sub
    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try
            i = dg1.CurrentRow.Index
            frmReturnBooks.lblBookID.Text = dg1.Item(0, i).Value
            frmReturnBooks.txtbookno.Text = dg1.Item(1, i).Value
            frmReturnBooks.txttitle.Text = dg1.Item(2, i).Value
            frmReturnBooks.dtpborroweddate.Text = dg1.Item(3, i).Value
            frmReturnBooks.dtpduedate.Text = dg1.Item(4, i).Value
            frmReturnBooks.txtprocby.Text = frmParent.lblUser.Text
            frmReturnBooks.txtreturndate.Text = Today

            frmReturnBooks.tsSave.Enabled = True
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Try

            str = "select BookID,BookNo,Title,BorDate,DueDate,ProcBy from libloans where Title like '%" & txtsearch.Text & "%' where Returned='No' order by Name"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libloans")
            dg1.DataSource = ds.Tables("libloans")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(3).HeaderText = "Borrowed Date"
            dg1.Columns(4).HeaderText = "Due Date"
            dg1.Columns(5).HeaderText = "Proccessed By"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try

    End Sub

End Class