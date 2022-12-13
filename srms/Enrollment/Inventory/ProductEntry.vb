Imports MySql.Data.MySqlClient
Public Class frmProductEntry
    Dim str As String
    Private Sub frmProductEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Formload()
    End Sub
    Private Sub btnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try

            If txtProductCode.Text = "" Then
                MsgBox("Product Code is Required!", MsgBoxStyle.Exclamation)
                txtProductCode.Focus()
                Exit Sub
            End If

            If txtProductName.Text = "" Then
                MsgBox("Product Name is Required!", MsgBoxStyle.Exclamation)
                txtProductCode.Focus()
                Exit Sub
            End If

            If txtProductDescription.Text = "" Then
                MsgBox("Product Description is Required!", MsgBoxStyle.Exclamation)
                txtProductCode.Focus()
                Exit Sub
            End If
            Dim Description As String
            Description = txtProductDescription.Text.Replace("'", "''")


            str = "insert into ls_productentry values ('" & txtProductCode.Text & "','" & txtProductName.Text & "','" & Description & "','" & cboBrand.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("One(1) record added successfully", MsgBoxStyle.Information)
            Formload()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub
    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        lblProductCode.Text = dg1.Item(0, i).Value
        txtProductCode.Text = dg1.Item(0, i).Value
        txtProductName.Text = dg1.Item(1, i).Value
        txtProductDescription.Text = dg1.Item(2, i).Value
        cbobrand.Text = dg1.Item(3, i).Value

        btnSave.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from ls_productentry where ProductCode like '%" & txtSearch.Text & "%' or ProductName like '%" & txtSearch.Text & "%' or ProductDescription like '%" & txtSearch.Text & "%' or Brand like '%" & txtSearch.Text & "%' order by ProductName "
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

    Public Sub Formload()
        Try
            str = "Select * from ls_productentry order by ProductName"
            'conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_productentry")
            dg1.DataSource = ds.Tables("ls_productentry")
            conn.Close()

            btnSave.Enabled = True
            btnUpdate.Enabled = False
            btnDelete.Enabled = False

            txtProductCode.Clear()
            txtProductName.Clear()
            txtProductDescription.Clear()
            cbobrand.ResetText()

            dg1.Columns(0).HeaderText = "Product Code"
            dg1.Columns(1).HeaderText = "Product Name"
            dg1.Columns(2).HeaderText = "Description"
            dg1.Columns(2).Width = 200
            dg1.Columns(3).HeaderText = "Brand"

            txtProductCode.Focus()

            getBrand()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Private Sub btnUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            Dim Description As String
            Description = txtProductDescription.Text.Replace("'", "''")
            str = "Update ls_productentry set ProductCode='" & txtProductCode.Text & "',ProductName='" & txtProductName.Text & "',ProductDescription='" & Description & "',Brand='" & cboBrand.Text & "' where ProductCode='" & lblProductCode.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            MsgBox("One (1) record updated successfully!", MsgBoxStyle.Information)
            Formload()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try

            If (MsgBox("Are you sure do want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from ls_productentry where ProductCode ='" & txtProductCode.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("Record deleted successfully!", MsgBoxStyle.Information)
                Formload()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub txtProductCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProductCode.TextChanged

    End Sub

    Public Sub getBrand()
        Try
            str = "select * from ls_brands order by brand"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_brands")

            cboBrand.ValueMember = "ls_brands"
            cboBrand.DisplayMember = "brand"
            cboBrand.DataSource = ds.Tables("ls_brands")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        btnSave.PerformClick()
        btnUpdate.PerformClick()
    End Sub
    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class
