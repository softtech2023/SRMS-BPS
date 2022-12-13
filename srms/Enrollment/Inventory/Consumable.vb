Imports MySql.Data.MySqlClient
Public Class frmConsumable
    Dim str As String
    Public Sub FormLoad()
        btnSave.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSelect.Enabled = True


        txtProductCode.Clear()
        txtProductDescription.Clear()
        cboUnit.ResetText()
        txtQty.Clear()
        txtNotes.Clear()
        txtProductNAme.Clear()

        txtProductCode.Focus()
        getUnits()
        getschoolinfo()


    End Sub
    Private Sub btnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            'productstat()

            If txtProductCode.Text = "" Then
                MsgBox("Product code is missing!", MsgBoxStyle.Exclamation)
                txtProductCode.Focus()
                Exit Sub
            End If

            If txtQty.Text = "" Then
                MsgBox("Qty is required!", MsgBoxStyle.Exclamation)
                txtQty.Focus()
                Exit Sub
            End If

            str = "select * from ls_consumables where productCode='" & txtProductCode.Text & "'"
            conn.Open()
            Dim mysDAl As New MySqlDataAdapter(str, conn)
            Dim dsl As New DataSet

            mysDAl.Fill(dsl, "ls_consumables")


            If dsl.Tables("ls_consumables").Rows.Count > 0 Then

                MsgBox("Item Name already exist!", MsgBoxStyle.Critical)
                conn.Close()

                txtProductCode.Clear()
                txtProductDescription.Clear()
                cboUnit.ResetText()
                txtQty.Clear()
                txtNotes.Clear()
                txtProductNAme.Clear()

                txtProductCode.Focus()



                Exit Sub

            End If
            conn.Close()

            Dim productDesc As String
            productDesc = txtProductDescription.Text.Replace("'", "''")
            Dim Notes As String
            Notes = txtNotes.Text.Replace("'", "''")

            str = "insert into ls_consumables values (0,'" & txtProductCode.Text & "','" & txtProductNAme.Text & "','" & productDesc & "','" & txtQty.Text & "','" & cboUnit.Text & "','" & Notes & "','" & lblsettingsID.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("One(1) record saved successfully", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()

        End Try
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub txtProductCode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProductCode.Click
        frmSelectProduct.Show()

    End Sub
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        frmSelectProduct.ShowDialog()
    End Sub
    Public Sub getUnits()
        Try
            str = "select * from ls_units order by unit"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_units")

            cboUnit.ValueMember = "ls_units"
            cboUnit.DisplayMember = "unit"
            cboUnit.DataSource = ds.Tables("ls_units")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub


    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            If txtQty.Text = "" Then
                MsgBox("Quantity is required!", MsgBoxStyle.Exclamation)
                txtQty.Focus()
                Exit Sub
            End If

            Dim productDesc As String
            productDesc = txtProductDescription.Text.Replace("'", "''")
            Dim Notes As String
            Notes = txtNotes.Text.Replace("'", "''")

            str = "Update ls_consumables set productCode='" & txtProductCode.Text & "',productName='" & txtProductNAme.Text & "',productDescription='" & productDesc & "',QtyDelivered='" & lbltotal.Text & "',prodUnit='" & cboUnit.Text & "',Notes='" & Notes & "' where productCode='" & txtProductCode.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            MsgBox("One (1) record updated successfully!", MsgBoxStyle.Information)
            FormLoad()



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmDeliveryEntryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        frmSearchProduct.ShowDialog()
    End Sub
    Public Sub getTotalQty()
        Dim total As Double
        total = Val(lblqty.Text) + Val(txtQty.Text)
        lbltotal.Text = total
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged
        getTotalQty()
    End Sub

    Private Sub lblqty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblqty.Click
        getTotalQty()
    End Sub

    Private Sub btnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try

            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from ls_consumables where productCode='" & txtProductCode.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Record Deleted!", MsgBoxStyle.Information)
                conn.Close()
                FormLoad()

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()

        End Try
    End Sub
    Public Sub getschoolinfo()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from srms_settings settingsID limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblsettingsID.Text = dtReader.Item(0)

            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        btnSave.PerformClick()
        btnUpdate.PerformClick()
    End Sub

    Private Sub btnclose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        txtProductCode.Clear()
        txtProductNAme.Clear()
        txtProductDescription.Clear()
        cboUnit.ResetText()
        txtQty.Clear()
        txtNotes.Clear()
        lblqty.ResetText()
        lbltotal.ResetText()

        btnSelect.Enabled = True
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btnUpdate.Enabled = False
    End Sub

End Class

