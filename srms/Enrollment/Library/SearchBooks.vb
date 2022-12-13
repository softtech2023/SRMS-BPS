Imports MySql.Data.MySqlClient
Public Class frmSearchBooks
    Dim str As String
    Private Sub frmSearchBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select * from libbookentry"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libbookentry")
            dg1.DataSource = ds.Tables("libbookentry")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(2).Width = 250
           

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from libbookentry where Title like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libbookentry")
            dg1.DataSource = ds.Tables("libbookentry")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(2).Width = 250
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        frmBooksInfo.lblID.Text = dg1.Item(0, i).Value
        frmBooksInfo.txtBookNum.Text = dg1.Item(1, i).Value
        frmBooksInfo.txtTitle.Text = dg1.Item(2, i).Value
        frmBooksInfo.txtAuthorNum.Text = dg1.Item(3, i).Value
        frmBooksInfo.cboAuthor.Text = dg1.Item(4, i).Value
        frmBooksInfo.txtCoAuthors.Text = dg1.Item(5, i).Value
        frmBooksInfo.cboPublisher.Text = dg1.Item(6, i).Value
        frmBooksInfo.txtYPublished.Text = dg1.Item(7, i).Value
        frmBooksInfo.txtSubject.Text = dg1.Item(8, i).Value
        frmBooksInfo.txtISBN.Text = dg1.Item(9, i).Value
        frmBooksInfo.txtEdition.Text = dg1.Item(10, i).Value
        frmBooksInfo.txtCallNum.Text = dg1.Item(11, i).Value
        frmBooksInfo.cboCategory.Text = dg1.Item(12, i).Value
        frmBooksInfo.cboLocation.Text = dg1.Item(13, i).Value
        frmBooksInfo.txtDeweyNum.Text = dg1.Item(14, i).Value
        frmBooksInfo.txtAccNo.Text = dg1.Item(15, i).Value
        frmBooksInfo.txtPrice.Text = dg1.Item(16, i).Value
        frmBooksInfo.dtpDate.Text = dg1.Item(17, i).Value
        frmBooksInfo.txtStatus.Text = dg1.Item(18, i).Value

        txtSearch.Clear()

        Try
            Dim title As String
            title = frmBooksInfo.txtTitle.Text.Replace("'", "''")
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "SELECT Title, count(Title) FROM libbookentry where Title='" & title & "' group by Title"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then

                frmBooksInfo.lblCopies.Text = dtReader.Item(1)
                frmBooksInfo.lblCopies.Visible = True
                frmBooksInfo.Label3.Visible = True

            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

        txtSearch.Clear()
        Me.Close()

        frmBooksInfo.tsSave.Enabled = False
        frmBooksInfo.tsDuplicate.Enabled = True
        frmBooksInfo.tsUpdate.Enabled = True
        frmBooksInfo.tsDelete.Enabled = True



    End Sub
End Class