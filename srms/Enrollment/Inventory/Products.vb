Imports MySql.Data.MySqlClient
Public Class frmProducts
    Dim str As String
    Private Sub frmProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()
    End Sub
    Public Sub formLoad()
        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
        tsPrintMR.Enabled = False

        txtCtrlNo.Clear()
        txtItemName.Clear()
        txtDescription.Clear()
        txtQty.Text = 1
        cboUnit.ResetText()
        cboBrand.ResetText()
        txtModel.Clear()
        txtSerialNo.Clear()
        txtCapacity.Clear()
        cboCondition.ResetText()
        cboCategory.ResetText()
        cboSub_category.ResetText()
        dtpProcessDate.Text = Today
        txtShortage.Text = 0
        txtShortageValue.Text = 0
        'txtAccountable.Clear()
        'lblIDNumber.Text = ""

        dtpAcquireDate.Text = Today
        txtPPrice.Text = "0.00"
        txtRemarks.Clear()

        txtCtrlNo.Focus()


        schoolInfo()
        getMR()
        getBrand()
        getUnits()
        getcategory()
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        frmSearchPersonnel.ShowDialog()
    End Sub
    Public Sub schoolInfo()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            Str = "select * from srms_settings limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(Str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblSettingsID.Text = dtReader(0)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            If cboCondition.Text = "" Then
                MsgBox("Condition is required!", MsgBoxStyle.Exclamation)
                cboCondition.Focus()
                Exit Sub
            End If

            If cboCategory.Text = "" Then
                MsgBox("Category is required!", MsgBoxStyle.Exclamation)
                cboCategory.Focus()
                Exit Sub
            End If

            If txtAccountable.Text = "" Then
                MsgBox("Accountable is required!", MsgBoxStyle.Exclamation)
                txtAccountable.Focus()
                Exit Sub
            End If

            Dim Description As String
            Description = txtDescription.Text.Replace("'", "''")


            str = "insert into ls_items values(0,'" & txtCtrlNo.Text & "','" & txtItemName.Text & "','" & Description & "','" & txtQty.Text & "','" & cboUnit.Text & "','" & cboBrand.Text & "','" & txtModel.Text & "','" & txtSerialNo.Text & "','" & txtCapacity.Text & "','" & cboCondition.Text & "','" & txtAccountable.Text & "','" & lblIDNumber.Text & "','" & Convert.ToDateTime(dtpAcquireDate.Text).ToString("yyyy-MM-dd") & "','" & txtPPrice.Text & "','" & txtRemarks.Text & "','" & lblSettingsID.Text & "','" & cboCategory.Text & "','" & cboSub_category.Text & "','" & Convert.ToDateTime(dtpProcessDate.Text).ToString("yyyy-MM-dd") & "','" & txtShortage.Text & "','" & txtShortageValue.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("Record saved!", MsgBoxStyle.Information)
            formLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getMR()
        Try
            str = "select * from ls_items order by itemID desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_items")
            dg1.DataSource = ds.Tables("ls_items")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Property No."
            dg1.Columns(2).HeaderText = "Item Name"
            dg1.Columns(3).HeaderText = "Item Description"
            dg1.Columns(3).Width = 200
            dg1.Columns(4).HeaderText = "Qty"
            dg1.Columns(4).Width = 60
            dg1.Columns(5).HeaderText = "Unit"
            dg1.Columns(5).Width = 60
            dg1.Columns(6).HeaderText = "Brand"
            dg1.Columns(7).HeaderText = "Model"
            dg1.Columns(8).HeaderText = "Serial No."
            dg1.Columns(9).HeaderText = "Capacity"
            dg1.Columns(10).HeaderText = "Condition"
            dg1.Columns(11).HeaderText = "Accountable"
            dg1.Columns(11).Width = 200
            dg1.Columns(12).Visible = False
            dg1.Columns(13).HeaderText = "Acquired Date"
            dg1.Columns(14).HeaderText = "Purchase Price"
            dg1.Columns(15).Visible = False
            dg1.Columns(16).Visible = False


            tsPrintMR.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub getMRPerStaff()
        Try
            str = "select * from ls_items where IDNumber='" & lblIDNumber.Text & "' order by itemID desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_items")
            dg1.DataSource = ds.Tables("ls_items")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Property No."
            dg1.Columns(2).HeaderText = "Item Name"
            dg1.Columns(3).HeaderText = "Item Description"
            dg1.Columns(3).Width = 200
            dg1.Columns(4).HeaderText = "Qty"
            dg1.Columns(4).Width = 60
            dg1.Columns(5).HeaderText = "Unit"
            dg1.Columns(5).Width = 60
            dg1.Columns(6).HeaderText = "Brand"
            dg1.Columns(7).HeaderText = "Model"
            dg1.Columns(8).HeaderText = "Serial No."
            dg1.Columns(9).HeaderText = "Capacity"
            dg1.Columns(10).HeaderText = "Condition"
            dg1.Columns(11).HeaderText = "Accountable"
            dg1.Columns(11).Width = 200
            dg1.Columns(12).Visible = False
            dg1.Columns(13).HeaderText = "Acquired Date"
            dg1.Columns(14).HeaderText = "Purchase Price"
            dg1.Columns(15).Visible = False
            dg1.Columns(16).Visible = False



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from ls_items where itemName like '%" & txtSearch.Text & "%' or serialNo like '%" & txtSearch.Text & "%' or model like '%" & txtSearch.Text & "%' or accountable like '%" & txtSearch.Text & "%' order by itemID desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_items")
            dg1.DataSource = ds.Tables("ls_items")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Property No."
            dg1.Columns(2).HeaderText = "Item Name"
            dg1.Columns(3).HeaderText = "Item Description"
            dg1.Columns(3).Width = 200
            dg1.Columns(4).HeaderText = "Qty"
            dg1.Columns(4).Width = 60
            dg1.Columns(5).HeaderText = "Unit"
            dg1.Columns(5).Width = 60
            dg1.Columns(6).HeaderText = "Brand"
            dg1.Columns(7).HeaderText = "Model"
            dg1.Columns(8).HeaderText = "Serial No."
            dg1.Columns(9).HeaderText = "Capacity"
            dg1.Columns(10).HeaderText = "Condition"
            dg1.Columns(11).HeaderText = "Accountable"
            dg1.Columns(11).Width = 200
            dg1.Columns(12).Visible = False
            dg1.Columns(13).HeaderText = "Acquired Date"
            dg1.Columns(14).HeaderText = "Purchase Price"
            dg1.Columns(15).Visible = False
            dg1.Columns(16).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index

        lblItemID.Text = dg1.Item(0, i).Value
        txtCtrlNo.Text = dg1.Item(1, i).Value
        txtItemName.Text = dg1.Item(2, i).Value
        txtDescription.Text = dg1.Item(3, i).Value
        txtQty.Text = dg1.Item(4, i).Value
        cboUnit.Text = dg1.Item(5, i).Value
        cboBrand.Text = dg1.Item(6, i).Value
        txtModel.Text = dg1.Item(7, i).Value
        txtSerialNo.Text = dg1.Item(8, i).Value
        txtCapacity.Text = dg1.Item(9, i).Value
        cboCondition.Text = dg1.Item(10, i).Value
        txtAccountable.Text = dg1.Item(11, i).Value
        lblIDNumber.Text = dg1.Item(12, i).Value
        dtpAcquireDate.Text = dg1.Item(13, i).Value
        txtPPrice.Text = dg1.Item(14, i).Value
        txtRemarks.Text = dg1.Item(15, i).Value
        lblSettingsID.Text = dg1.Item(16, i).Value
        cboCategory.Text = dg1.Item(17, i).Value
        cboSub_category.Text = dg1.Item(18, i).Value
        dtpProcessDate.Text = dg1.Item(19, i).Value
        txtShortage.Text = dg1.Item(20, i).Value
        txtShortageValue.Text = dg1.Item(21, i).Value


        tsSave.Enabled = False
        tsUpdate.Enabled = True
        tsDelete.Enabled = True
        tsPrintMR.Enabled = True


    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            Dim Description As String
            Description = txtDescription.Text.Replace("'", "''")
            str = "update ls_items set ctrlNo='" & txtCtrlNo.Text & "',itemName='" & txtItemName.Text & "',description='" & Description & "',qty='" & txtQty.Text & "',unit='" & cboUnit.Text & "',brand='" & cboBrand.Text & "',model='" & txtModel.Text & "',serialNo='" & txtSerialNo.Text & "',capacity='" & txtCapacity.Text & "',itemCondition='" & cboCondition.Text & "',accountable='" & txtAccountable.Text & "',IDNumber='" & lblIDNumber.Text & "',acquiredDate='" & Convert.ToDateTime(dtpAcquireDate.Text).ToString("yyyy-MM-dd") & "',purchasePrice='" & txtPPrice.Text & "',notes='" & txtRemarks.Text & "',settingsID='" & lblSettingsID.Text & "',itemCategory='" & cboCategory.Text & "',itemSubCategory='" & cboSub_category.Text & "',processDate='" & Convert.ToDateTime(dtpProcessDate.Text).ToString("yyyy-MM-dd") & "',qtyShortage='" & txtShortage.Text & "',shortageValue='" & txtShortageValue.Text & "' where itemID='" & lblItemID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record updated!", MsgBoxStyle.Information)
            conn.Close()
            formLoad()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from ls_items where itemID='" & lblItemID.Text & "'"
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

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtPPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPPrice.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
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

    Private Sub tsPrintMR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsPrintMR.Click
        Try

            str = "SELECT i.ctrlNo, i.itemName, i.description, i.itemCondition, i.serialNo, i.model, i.notes, i.qty, i.unit, i.acquiredDate, concat(s.FirstName,' ',s.MiddleName,' ',s.LastName) as Accountable, s.empPosition, s.Department, st.SchoolName, st.SchoolAddress, st.Division, st.PropertyCustodian from ls_items i join staff s on i.IDNumber=s.IDNumber join srms_settings st on i.settingsID=st.settingsID where s.IDNumber='" & lblIDNumber.Text & "' and i.acquiredDate='" & Convert.ToDateTime(dtpAcquireDate.Text).ToString("yyyy-MM-dd") & "' order by i.itemName, i.description"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "ls_items, staff, srms_settings")
            Dim obj As New MR
            obj.SetDataSource(mysds.Tables("ls_items, staff, srms_settings"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getcategory()
        Try
            str = "select * from ls_categories group by Category order by Category"
            'conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_categories")

            cboCategory.ValueMember = "ls_categories"
            cboCategory.DisplayMember = "Category"
            cboCategory.DataSource = ds.Tables("ls_categories")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getsub_category()
        Try
            str = "select * from ls_categories where Category='" & cboCategory.Text & "' order by Sub_category "
            'conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_categories")

            cboSub_category.ValueMember = "ls_categories"
            cboSub_category.DisplayMember = "Sub_category"
            cboSub_category.DataSource = ds.Tables("ls_categories")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.SelectedIndexChanged
        getsub_category()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class