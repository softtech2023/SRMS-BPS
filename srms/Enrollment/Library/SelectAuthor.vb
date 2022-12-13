Imports MySql.Data.MySqlClient
Public Class frmSelectAuthor
    Dim str As String
    Private Sub frmSelectAuthor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select AuthorNum, concat(LastName,', ',FirstName,' ',MiddleName) as Name from libauthors group by Name order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libauthors")
            dg.DataSource = ds.Tables("libauthors")
            conn.Close()
            dg.Columns(1).Width = 290

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        Dim i As Integer
        i = dg.CurrentRow.Index
        frmBooksInfo.txtAuthorNum.Text = dg.Item(0, i).Value
        'frmBooksInfo.Text = dg.Item(1, i).Value
        txtSearch.Clear()
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select AuthorNum, concat(LastName,', ',FirstName,' ',MiddleName) as Name from libauthors where LastName like '%" & txtSearch.Text & "%' order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libauthors")
            dg.DataSource = ds.Tables("libauthors")
            conn.Close()
            dg.Columns(1).Width = 290

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class