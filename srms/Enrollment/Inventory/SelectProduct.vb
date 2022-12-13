Imports MySql.Data.MySqlClient
Public Class frmSelectProduct
    Dim str As String

    Public Sub formload()

        Try
            str = "select * from ls_productentry order by ProductName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_productentry")
            dg1.DataSource = ds.Tables("ls_productentry")
            conn.Close()


            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Product Code"
            dg1.Columns(1).Width = 150
            dg1.Columns(2).HeaderText = "Product Name"
            dg1.Columns(2).Width = 150
            dg1.Columns(3).HeaderText = "Product Description"
            dg1.Columns(3).Width = 200




        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmSelectProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formload()
    End Sub

    Private Sub txtSearch_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try

            str = "select * from ls_productentry where ProductCode like '%" & txtSearch.Text & "%' or ProductName like '%" & txtSearch.Text & "%' or ProductDescription like '%" & txtSearch.Text & "%' order by ProductName "
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_productentry")
            dg1.DataSource = ds.Tables("ls_productentry")
            conn.Close()



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Private Sub dg1_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        frmConsumable.txtProductCode.Text = dg1.Item(0, i).Value
        frmConsumable.txtProductNAme.Text = dg1.Item(1, i).Value
        frmConsumable.txtProductDescription.Text = dg1.Item(2, i).Value


        frmConsumable.btnSave.Enabled = True
        frmConsumable.btnUpdate.Enabled = False
        frmConsumable.btnDelete.Enabled = False

        Me.Close()
        txtSearch.Clear()
    End Sub
End Class