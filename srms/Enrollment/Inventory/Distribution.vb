Imports MySql.Data.MySqlClient
Public Class frmDistribution
    Dim str As String

    Private Sub btnItemlookup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItemlookup.Click
        frmItemSearch.ShowDialog()
    End Sub

    Private Sub btnSelectEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectEmployee.Click
        frmSearchEmployee.Show()

    End Sub

    Private Sub ItemLookupToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemLookupToolStripMenuItem1.Click
        btnItemlookup.PerformClick()
    End Sub

    Private Sub SelectEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectEmployeeToolStripMenuItem.Click
        btnSelectEmployee.PerformClick()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Try

            If txtempNo.Text = "" Then
                MsgBox("Employee information is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txtTransactionNo.Text = "" Then
                MsgBox("Transaction number is required!", MsgBoxStyle.Exclamation)
                txtTransactionNo.Focus()
                Exit Sub
            End If


            For i As Integer = 0 To lvPOS.Items.Count - 1
                Dim productDesc As String
                productDesc = lvPOS.Items(i).SubItems(2).Text.Replace("'", "''")

                str = "insert into ls_distribution values ('0','" & txtTransactionNo.Text & "','" & Convert.ToDateTime(frmParent.dtpDate.Text).ToString("yyyy-MM-dd") & "','" & frmParent.tsTime.Text & "','" & lvPOS.Items(i).SubItems(0).Text & "','" & lvPOS.Items(i).SubItems(1).Text & "','" & productDesc & "','" & lvPOS.Items(i).SubItems(3).Text & "','" & txtempNo.Text & "','" & txtFirstName.Text & "','" & txtLastName.Text & "','" & frmParent.lblUser.Text & "','" & lblsettingsID.Text & "')"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()

                'for delivery updating
                str = "update ls_consumables set QtyDelivered='" & lvPOS.Items(i).SubItems(4).Text & "' where productCode='" & lvPOS.Items(i).SubItems(0).Text & "'"
                conn.Open()
                Dim mysC1 As New MySqlCommand(str, conn)
                mysC1.ExecuteNonQuery()
                conn.Close()
            Next

            str = "select d.distID, d.transactionNo, d.transactionDate, d.productCode, d.description, d.qty, d.itemName, concat (d.FirstName,' ',d.LastName) as EmployeeName, d.IDNumber, st.letterHead from ls_distribution d join srms_settings st on d.settingsID = st.settingsID where transactionNo = '" & txtTransactionNo.Text & "'"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "ls_distribution, srms_settings")
            Dim obj As New acknowledgementreceipt
            obj.SetDataSource(mysds.Tables("ls_distribution, srms_settings"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            MsgBox("Record successfully saved!", MsgBoxStyle.Information)
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()



            'If (MsgBox("Record successfully saved!  Do you want to print the Acknowledgement Receipt?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            'PrintDialog1.AllowSomePages = True
            'obj.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, PrintDialog1.PrinterSettings.FromPage, PrintDialog1.PrinterSettings.ToPage)

            'If MsgBoxResult.No Then

            'End If

            'End If

            formLoad()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

            conn.Close()
        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        btnSave.PerformClick()
    End Sub
    Public Sub formLoad()
        lvPOS.Clear()

        Me.lvPOS.Columns.Add("Product Code", 120)
        Me.lvPOS.Columns.Add("Item Name", 150)
        Me.lvPOS.Columns.Add("Description", 250)
        Me.lvPOS.Columns.Add("Qty", 100)
        Me.lvPOS.Columns.Add("Remaining Qty", 0)

        Me.lvPOS.View = View.Details
        Me.lvPOS.GridLines = True

        txtempNo.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtProductCode.Clear()
        txtQTY.Text = 1

        getTransactionNo()

    End Sub

    Private Sub frmDistribution_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()
        getschoolinfo()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        'If txtProductCode.Text = "" Then
        'MsgBox("product code is missing!", MsgBoxStyle.Critical)
        'txtProductCode.Focus()
        'Exit Sub
        ' End If

        'LoadItems()
        'txtQTY.Text = 1
        'txtProductCode.Clear()
    End Sub
    Public Sub LoadItems()
        Dim totalqty As Double
        Dim currentqty As Integer
        Try

            Dim dt As New DataTable
            Dim remainItem As Double

            str = "select d.ProductCode, d.productName, d.productDescription, d.QtyDelivered from ls_consumables d where d.ProductCode='" & txtProductCode.Text & "' and QtyDelivered !=0"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            mysda.Fill(dt)
            Dim newrow As DataRow

            For Each newrow In dt.Rows

                Dim mysC1 As New MySqlCommand(str, conn)
                Dim mysDR1 As MySqlDataReader = mysC1.ExecuteReader

                While mysDR1.Read
                    remainItem = Val(mysDR1(3)) - Val(txtQTY.Text)
                End While
                txtremainQTY.Text = remainItem
                mysDR1.Close()

                'check available items
                For x As Integer = 0 To lvPOS.Items.Count - 1
                    If txtProductCode.Text = lvPOS.Items(x).SubItems(0).Text Then
                        currentqty = Val(totalqty) + Val(lvPOS.Items(x).SubItems(3).Text)

                        'If lvPOS.Items(1, ).Value = lvPOS.Items(x).SubItems(0).Text Then
                        'MsgBox("Items already added!", MsgBoxStyle.Exclamation)
                        'Exit Sub
                        'End If
                    End If

                Next

                lvPOS.Items.Add(newrow.Item(0)) 'Product Code
                lvPOS.Items(lvPOS.Items.Count - 1).SubItems.Add(newrow.Item(1)) 'Item Name
                lvPOS.Items(lvPOS.Items.Count - 1).SubItems.Add(newrow.Item(2)) ' Description
                lvPOS.Items(lvPOS.Items.Count - 1).SubItems.Add(txtQTY.Text) ' QTY
                lvPOS.Items(lvPOS.Items.Count - 1).SubItems.Add(txtremainQTY.Text) ' Remaining No.

            Next
            txtProductCode.Focus()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub RemoveAllItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveAllItemsToolStripMenuItem.Click
        If lvPOS.Items.Count = 0 Then
            MsgBox("Cannot find any items to remove", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If (MsgBox("Are you sure you want to remove all of the items in the list box?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            formLoad()
            lvPOS.Enabled = True


            txtProductCode.Focus()

        End If
    End Sub

    Private Sub RemoveSelectedItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveSelectedItemToolStripMenuItem.Click
        Try

            Dim i As Integer
            lvPOS.Select()
            If lvPOS.Items.Count = 0 Then
                MsgBox("Cannot find any items to remove", MsgBoxStyle.Critical)
                txtProductCode.Focus()
                Exit Sub
            Else
                i = lvPOS.FocusedItem.Index
                lvPOS.Items.RemoveAt(i)
            End If
            txtProductCode.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub getTransactionNo()
        Try
            Dim transNo As Integer

            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from ls_distribution order by transactionNo desc limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                transNo = dtReader.Item(1) + 1
                txtTransactionNo.Text = transNo
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
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

    Private Sub txtProductCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProductCode.TextChanged

        For x As Integer = 0 To lvPOS.Items.Count - 1
            If txtProductCode.Text = lvPOS.Items(x).SubItems(0).Text Then
                MsgBox("Item already exist", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Next
        LoadItems()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtProductCode.Clear()
    End Sub

    Private Sub txtQTY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQTY.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class