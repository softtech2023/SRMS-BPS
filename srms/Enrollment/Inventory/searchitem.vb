Imports MySql.Data.MySqlClient
Public Class frmItemSearch
    Dim str As String

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "SELECT * from ls_distribution where productCode like '%" & txtSearch.Text & "%' itemName like '%" & txtSearch.Text & "%' "
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_distribution")
            dgProfile.DataSource = ds.Tables("ls_distribution")
            conn.Close()

            dgProfile.Columns(0).Visible = False
            dgProfile.Columns(1).HeaderText = "Transaction Number"
            dgProfile.Columns(1).Width = 150
            dgProfile.Columns(2).Visible = False
            dgProfile.Columns(3).Visible = False
            dgProfile.Columns(4).HeaderText = "Product Code"
            dgProfile.Columns(4).Width = 150
            dgProfile.Columns(5).HeaderText = "Item Name"
            dgProfile.Columns(6).HeaderText = "Description"
            dgProfile.Columns(7).HeaderText = "Qty"
            dgProfile.Columns(8).Visible = False
            dgProfile.Columns(9).Visible = False
            dgProfile.Columns(10).Visible = False
            dgProfile.Columns(11).Visible = False
            dgProfile.Columns(12).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub SearchItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "SELECT * from ls_distribution where IDNumber = '" & frmmodifyform.txtIDNo.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_distribution")
            dgProfile.DataSource = ds.Tables("ls_distribution")
            conn.Close()

            dgProfile.Columns(0).Visible = False
            dgProfile.Columns(1).HeaderText = "Transaction Number"
            dgProfile.Columns(1).Width = 150
            dgProfile.Columns(2).Visible = False
            dgProfile.Columns(3).Visible = False
            dgProfile.Columns(4).HeaderText = "Product Code"
            dgProfile.Columns(4).Width = 150
            dgProfile.Columns(5).HeaderText = "Item Name"
            dgProfile.Columns(6).HeaderText = "Description"
            dgProfile.Columns(7).HeaderText = "Qty"
            dgProfile.Columns(8).Visible = False
            dgProfile.Columns(9).Visible = False
            dgProfile.Columns(10).Visible = False
            dgProfile.Columns(11).Visible = False
            dgProfile.Columns(12).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dgProfile_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgProfile.DoubleClick
        Dim i As Integer
        i = dgProfile.CurrentRow.Index
        frmmodifyform.lbldistID.Text = dgProfile.Item(0, i).Value
        frmmodifyform.txtTransNo.Text = dgProfile.Item(1, i).Value
        frmmodifyform.txtProdCode.Text = dgProfile.Item(4, i).Value
        frmmodifyform.txtItemName.Text = dgProfile.Item(5, i).Value
        frmmodifyform.txtDesc.Text = dgProfile.Item(6, i).Value
        frmmodifyform.txtQty.Text = dgProfile.Item(7, i).Value

        frmmodifyform.getQTY()

        Me.Close()

        frmmodifyform.btnSave.Enabled = True
    End Sub
End Class