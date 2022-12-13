Imports MySql.Data.MySqlClient
Public Class frmSettingsForm
    Dim str As String
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try

            str = "select * from ls_brands where brand='" & txtBrand.Text & "'"
            conn.Open()
            Dim mysDAl As New MySqlDataAdapter(str, conn)
            Dim dsl As New DataSet

            mysDAl.Fill(dsl, "ls_brands")

            If dsl.Tables("ls_brands").Rows.Count > 0 Then

                MsgBox("Brand Name already exist!", MsgBoxStyle.Critical)
                conn.Close()

                txtBrand.Clear()

                txtBrand.Focus()
                Exit Sub

            End If
            conn.Close()

            str = "insert into ls_brands values(0,'" & txtBrand.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            MsgBox("Brand name successfully added!", MsgBoxStyle.Information)
            txtBrand.Clear()
            txtBrand.Focus()




        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
        formLoad()

    End Sub

    Private Sub formLoad()
        btnAdd.Enabled = True
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        txtBrand.Clear()
        txtBrand.Focus()


        Try
            str = "select * from ls_brands order by brand"
            conn.Close()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_brands")
            dg1.DataSource = ds.Tables("ls_brands")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Brands"
            dg1.Columns(1).Width = 420

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmSettingsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()
        formLoadU()

    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index

        lblBrandID.Text = dg1.Item(0, i).Value
        txtBrand.Text = dg1.Item(1, i).Value

        btnAdd.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            If txtBrand.Text = "" Then
                MsgBox("Brand Name is required!", MsgBoxStyle.Exclamation)
                txtBrand.Focus()
                Exit Sub
            End If

            str = "update ls_brands set brand='" & txtBrand.Text & "' where brandID='" & lblBrandID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Brand name successfully updated!", MsgBoxStyle.Information)
            conn.Close()
            formLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this brand name?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from ls_brands where brandID='" & lblBrandID.Text & "'"
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



    Private Sub btnAddU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddU.Click
        Try

            str = "select * from ls_units where unit='" & txtUnit.Text & "'"
            conn.Open()
            Dim mysDAl As New MySqlDataAdapter(str, conn)
            Dim dsl As New DataSet
            mysDAl.Fill(dsl, "ls_units")
            If dsl.Tables("ls_units").Rows.Count > 0 Then
                MsgBox("Unit already exist!", MsgBoxStyle.Critical)

                txtUnit.Clear()
                txtUnit.Focus()
                conn.Close()
                Exit Sub

            End If
            conn.Close()
            str = "insert into ls_units values (0, '" & txtUnit.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("Unit successfully added!", MsgBoxStyle.Information)
            txtUnit.Clear()
            txtUnit.Focus()
            formLoadU()



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub formLoadU()
        btnAddU.Enabled = True
        btnUpdateU.Enabled = False
        btnDeleteU.Enabled = False
        txtUnit.Clear()
        txtUnit.Focus()


        Try
            str = "select * from ls_units order by unit"
            conn.Close()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_units")
            dg2.DataSource = ds.Tables("ls_units")
            conn.Close()

            dg2.Columns(0).Visible = False
            dg2.Columns(1).HeaderText = "Units"
            dg2.Columns(1).Width = 420

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dg2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg2.DoubleClick
        Dim i As Integer
        i = dg2.CurrentRow.Index

        lblUnitID.Text = dg2.Item(0, i).Value
        txtUnit.Text = dg2.Item(1, i).Value

        btnAddU.Enabled = False
        btnUpdateU.Enabled = True
        btnDeleteU.Enabled = True
    End Sub

    Private Sub btnUpdateU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateU.Click
        Try
            If txtUnit.Text = "" Then
                MsgBox("Unit is required!", MsgBoxStyle.Exclamation)
                txtUnit.Focus()
                Exit Sub
            End If

            str = "update ls_units set unit='" & txtUnit.Text & "' where unitID='" & lblUnitID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Unit name successfully updated!", MsgBoxStyle.Information)
            conn.Close()
            formLoadU()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnDeleteU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteU.Click
        Try
            If (MsgBox("Are you sure you want to delete this unit type?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from ls_units where unitID='" & lblUnitID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                formLoadU()

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class

 