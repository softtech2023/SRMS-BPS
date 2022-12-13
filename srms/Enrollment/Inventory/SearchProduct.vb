Imports MySql.Data.MySqlClient
Public Class frmSearchProduct
    Dim str As String
    Public Sub formload()

        Try
            str = "select * from ls_consumables order by ProductName"
            'conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_consumables")
            dg1.DataSource = ds.Tables("ls_consumables")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Product Code"
            dg1.Columns(2).HeaderText = "Product Name"
            dg1.Columns(3).HeaderText = "Product Description"
            dg1.Columns(3).Width = 200
            dg1.Columns(4).HeaderText = "Quantity Delivery"
            dg1.Columns(5).HeaderText = "Product Unit"
            dg1.Columns(6).HeaderText = "Notes"





        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Private Sub frmSearchProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formload()
    End Sub
    Private Sub txtsearch_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Try
            str = "select * from ls_consumables where productCode like '%" & txtsearch.Text & "%' or productName like '%" & txtsearch.Text & "%' or QtyDelivered like '%" & txtsearch.Text & "%' or prodUnit like '%" & txtsearch.Text & "%' order by productCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_consumables")
            dg1.DataSource = ds.Tables("ls_consumables")
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dg1_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        frmConsumable.lblconsumableID.Text = dg1.Item(0, i).Value
        frmConsumable.txtProductCode.Text = dg1.Item(1, i).Value
        frmConsumable.txtProductNAme.Text = dg1.Item(2, i).Value
        frmConsumable.txtProductDescription.Text = dg1.Item(3, i).Value
        frmConsumable.lblqty.Text = dg1.Item(4, i).Value
        frmConsumable.cboUnit.Text = dg1.Item(5, i).Value
        frmConsumable.txtNotes.Text = dg1.Item(6, i).Value


        frmConsumable.btnSave.Enabled = False
        frmConsumable.btnUpdate.Enabled = True
        frmConsumable.btnDelete.Enabled = True
        frmConsumable.btnSelect.Enabled = False

        frmSelectProduct.Close()
        Me.Close()
        formload()
        txtsearch.Clear()
    End Sub
End Class