Imports MySql.Data.MySqlClient
Public Class frmbyauthor
    Dim str As String


    Private Sub ByAuthor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getAuthor()
        btnPreview.Enabled = False
    End Sub
    Public Sub getAuthor()
        Try

            str = "select concat(LastName,', ',FirstName,' ',MiddleName) as Name from libauthors order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libauthors")
            dg1.DataSource = ds.Tables("libauthors")
            conn.Close()

            dg1.Columns(0).Width = 215
            dg1.Columns(0).HeaderText = "Author Name"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "select lb.BookNo, lb.Title, lb.Category, lb.Edition,lb.Author,lb.BookStatus, st.letterHead from libbookentry lb join srms_settings st on lb.settingsID = st.settingsID where lb.Author='" & txtAuthor.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "libbookentry")
            Dim obj As New ByAuthor
            obj.SetDataSource(mysds.Tables("libbookentry"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            conn.Close()

        End Try
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try

            str = "select concat(LastName,', ',FirstName,' ',MiddleName) as Name from libauthors where LastName like '%" & txtSearch.Text & "%' order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libauthors")
            dg1.DataSource = ds.Tables("libauthors")
            conn.Close()

            dg1.Columns(0).Width = 215
            dg1.Columns(0).HeaderText = "Author Name"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        txtAuthor.Text = dg1.Item(0, i).Value
        btnPreview.Enabled = True
    End Sub
End Class