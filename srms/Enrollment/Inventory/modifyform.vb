Imports MySql.Data.MySqlClient
Public Class frmmodifyform
    Dim str As String
    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        frmSearchStaff.ShowDialog()
    End Sub

    Private Sub ClearInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearInformationToolStripMenuItem.Click
        txtEmpName.Clear()
        txtLName.Clear()
        txtIDNo.Clear()
        txtDesc.Clear()
        txtProdCode.Clear()
        txtItemName.Clear()
        txtQty.Clear()
        txtTransNo.Clear()
        lblqty.Text = 0
        lbltotalqty.Text = 0

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.Close()
    End Sub

    Private Sub btnSearhItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearhItem.Click
        frmItemSearch.ShowDialog()
    End Sub

    Public Sub formload()

        btnsearch.Enabled = True
        btnSearhItem.Enabled = False
        btnSave.Enabled = False

        btnsearch.Focus()

    End Sub

    Private Sub frmmodifyform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formload()
    End Sub
    Public Sub getTotalQty()
        Dim total As Double
        total = Val(lblqty.Text) + Val(txtQty.Text)
        lbltotalqty.Text = total
    End Sub

    Private Sub lblqty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblqty.Click
        getTotalQty()
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged
        getTotalQty()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Try
            If txtTransNo.Text = "" Then
                MsgBox("Transaction Number is required!", MsgBoxStyle.Exclamation)
                txtQty.Focus()
                Exit Sub
            End If

            'Dim productDesc As String
            'productDesc = txtProductDescription.Text.Replace("'", "''")

            'Code to delete records from distribution table (where=distID)


            str = "delete from ls_distribution where distID='" & lbldistID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            'MsgBox("Record Deleted From !", MsgBoxStyle.Information)
            conn.Close()
            'formload()


            str = "Update ls_consumables set QtyDelivered='" & lbltotalqty.Text & "' where ProductCode = '" & txtProdCode.Text & "'"
            conn.Open()
            Dim mysc1 As New MySqlCommand(str, conn)
            mysc1.ExecuteNonQuery()
            conn.Close()

            MsgBox("Record Updated Successfully", MsgBoxStyle.Information)
            formload()

            
            txtDesc.Clear()
            txtProdCode.Clear()
            txtItemName.Clear()
            txtQty.Clear()
            txtTransNo.Clear()
            lblqty.Text = 0
            lbltotalqty.Text = 0



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub getQTY()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from ls_consumables where ProductCode='" & txtProdCode.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblqty.Text = dtReader.Item(4)
            End If
            conn.Close()

            Dim newQTY As Integer
            newQTY = Val(lblqty.Text) + Val(txtQty.Text)
            lbltotalqty.Text = newQTY

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub txtTransNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTransNo.TextChanged
        getQTY()
    End Sub
End Class