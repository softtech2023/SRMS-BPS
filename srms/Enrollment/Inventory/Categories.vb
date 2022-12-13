Imports MySql.Data.MySqlClient
Public Class frmCategories
    Dim str As String
    Private Sub formLoad()
        btnAdd.Enabled = True
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        txtCategory.Clear()
        txtSubCategory.Clear()
        txtCategory.Focus()


        Try
            str = "select * from ls_categories order by Category"
            conn.Close()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_categories")
            dg1.DataSource = ds.Tables("ls_categories")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Categories"
            dg1.Columns(1).Width = 350
            dg1.Columns(2).HeaderText = "Sub-Categories"
            dg1.Columns(2).Width = 350

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Private Sub frmCategories_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index

        lblCatNo.Text = dg1.Item(0, i).Value
        txtCategory.Text = dg1.Item(1, i).Value
        txtSubCategory.Text = dg1.Item(2, i).Value

        btnAdd.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        btnAdd.PerformClick()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            str = "insert into ls_categories values(0,'" & txtCategory.Text & "','" & txtSubCategory.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("one (1) record successfully added!", MsgBoxStyle.Information)
            txtCategory.Clear()
            txtSubCategory.Clear()
            txtCategory.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
        formLoad()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            str = "update ls_categories set CatNo='" & lblCatNo.Text & "',Category='" & txtCategory.Text & "',Sub_category='" & txtSubCategory.Text & "' where CatNo='" & lblCatNo.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("one (1) record successfully updated!", MsgBoxStyle.Information)
            conn.Close()
            formLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from ls_categories where CatNo='" & lblCatNo.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                formLoad()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class