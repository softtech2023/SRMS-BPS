Imports MySql.Data.MySqlClient
Public Class frmSearchBooksMain
    Dim str As String
    Private Sub frmSearchBooksMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            chkBookTitle.Checked = True
            str = "select * from libbookentry order by Title"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libbookentry")
            dg1.DataSource = ds.Tables("libbookentry")
            conn.Close()
            ModifyDataGrid()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub ModifyDataGrid()
        dg1.Columns(0).Visible = False
        dg1.Columns(1).HeaderText = "Book No."
        dg1.Columns(2).Width = 250
        dg1.Columns(3).HeaderText = "Author No."
        dg1.Columns(4).Width = 200
        dg1.Columns(5).HeaderText = "Co-Author"
        dg1.Columns(5).Width = 200
        dg1.Columns(6).Width = 250
        dg1.Columns(7).HeaderText = "Year Pub."
        dg1.Columns(8).Width = 150
        dg1.Columns(9).Width = 130
        dg1.Columns(11).HeaderText = "Call Num."
        dg1.Columns(14).HeaderText = "Dewey Num."
        dg1.Columns(16).HeaderText = "Purchase Price"
        dg1.Columns(17).HeaderText = "Entry Date"
        dg1.Columns(18).HeaderText = "Book Status"

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            If chkBookTitle.Checked = True Then
                str = "select * from libbookentry where Title like '%" & txtSearch.Text & "%'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "libbookentry")
                dg1.DataSource = ds.Tables("libbookentry")
                conn.Close()
                ModifyDataGrid()
            End If

            If chkAuthor.Checked = True Then
                str = "select * from libbookentry where Author like '%" & txtSearch.Text & "%'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "libbookentry")
                dg1.DataSource = ds.Tables("libbookentry")
                conn.Close()
                ModifyDataGrid()
            End If

            If chkSubject.Checked = True Then
                str = "select * from libbookentry where Subject like '%" & txtSearch.Text & "%'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "libbookentry")
                dg1.DataSource = ds.Tables("libbookentry")
                conn.Close()
                ModifyDataGrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        txtSearch.Clear()
        Me.Close()
    End Sub
End Class