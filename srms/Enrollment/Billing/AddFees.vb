Imports MySql.Data.MySqlClient
Public Class frmAddFees
    Dim str As String
    Private Sub frmAddFees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select * from fees where Course='" & frmBilling.cboCourse.Text & "' and YearLevel='" & frmBilling.cboYear.Text & "' order by Description"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "fees")
            dg1.DataSource = ds.Tables("fees")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 150
            dg1.Columns(3).Width = 250
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
       
        Dim i As Integer
        i = dg1.CurrentRow.Index

        For x As Integer = 0 To frmBilling.lvAccts.Items.Count - 1
            If dg1.Item(1, i).Value = frmBilling.lvAccts.Items(x).SubItems(0).Text Then
                MsgBox("Fees description already added!", MsgBoxStyle.Exclamation, "Prompt")
                Exit Sub
            End If
        Next

        AddFees(frmBilling.lvAccts, dg1.Item(1, i).Value, dg1.Item(2, i).Value)

        frmBilling.getTotalAccount()
        frmBilling.getBalance()
    End Sub
End Class