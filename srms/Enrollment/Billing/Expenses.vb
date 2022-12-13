Imports MySql.Data.MySqlClient
Public Class frmExpenses
    Dim str As String

    Public Sub Clear()
        txtDescription.Clear()
        txtAmount.Clear()
        cboResponsible.ResetText()
        cboCategory.ResetText()
    End Sub

    Private Sub frmExpenses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub dgExpenses_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgExpenses.DoubleClick
        Dim i As Integer
        i = dgExpenses.CurrentRow.Index
        lblID.Text = dgExpenses.Item(0, i).Value
        txtDescription.Text = dgExpenses.Item(1, i).Value
        txtAmount.Text = dgExpenses.Item(2, i).Value
        cboResponsible.Text = dgExpenses.Item(3, i).Value
        dtpDate.Text = dgExpenses.Item(4, i).Value
        cboCategory.Text = dgExpenses.Item(5, i).Value

        btnSave.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtDescription.Text = "" Then
                MsgBox("Please input description!", MsgBoxStyle.Information)
                txtDescription.Focus()
                Exit Sub
            End If
            str = "insert into expenses values('0','" & txtDescription.Text & "','" & txtAmount.Text & "','" & cboResponsible.Text & "','" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd H:mm:ss") & "','" & cboCategory.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record added!", MsgBoxStyle.Information)
            conn.Close()
            Clear()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try

            str = "update expenses set Description='" & txtDescription.Text & "',Amount='" & txtAmount.Text & "',Responsible='" & cboResponsible.Text & "',ExpenseDate='" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") & "',Category='" & cboCategory.Text & "' where expensesid='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Selected data successfully updated!", MsgBoxStyle.Information)
            conn.Close()
            Clear()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from expenses where expensesid='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Selected record has been deleted!", MsgBoxStyle.Information)
                conn.Close()
                Clear()
                FormLoad()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Public Sub FormLoad()
        dtpDate.Text = Today

        Try
            str = "select * from expenses order by ExpenseDate Desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "expenses")
            dgExpenses.DataSource = ds.Tables("expenses")
            conn.Close()

            dgExpenses.Columns(0).Visible = False
            dgExpenses.Columns(1).Width = 200
            dgExpenses.Columns(2).Width = 75
            dgExpenses.Columns(3).Width = 150



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub
End Class