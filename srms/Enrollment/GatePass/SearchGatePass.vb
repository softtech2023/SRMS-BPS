Imports MySql.Data.MySqlClient
Public Class frmSearchGatePass
    Dim str As String

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSearchGatePass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select * from gatepass order by VisitDate desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "gatepass")
            dg.DataSource = ds.Tables("gatepass")
            conn.Close()
            dg.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            conn.Close()
        End Try
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Try
            str = "select * from gatepass where VisitorNo like '%" & txtsearch.Text & "%' or VisitorsName like '%" & txtsearch.Text & "%'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "gatepass")
            dg.DataSource = ds.Tables("gatepass")
            conn.Close()
            dg.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            conn.Close()
        End Try
    End Sub

    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        Dim i As Integer
        i = dg.CurrentRow.Index
        frmGatePass.lblID.Text = dg.Item(0, i).Value
        frmGatePass.txtVisitorNo.Text = dg.Item(1, i).Value
        frmGatePass.dtpDate.Text = dg.Item(2, i).Value
        frmGatePass.dtpTime.Text = dg.Item(3, i).Value
        frmGatePass.txtName.Text = dg.Item(4, i).Value
        frmGatePass.txtAddress.Text = dg.Item(5, i).Value
        frmGatePass.txtOffice.Text = dg.Item(6, i).Value
        frmGatePass.txtOfficeAddress.Text = dg.Item(7, i).Value
        frmGatePass.txtPersonsToMeet.Text = dg.Item(8, i).Value
        frmGatePass.txtPurpose.Text = dg.Item(9, i).Value
        frmGatePass.txtFeedback.Text = dg.Item(10, i).Value
        frmGatePass.txtRemarks.Text = dg.Item(11, i).Value


        Me.Close()
        frmGatePass.tsSave.Enabled = False
        frmGatePass.tsUpdate.Enabled = True
        frmGatePass.tsDelete.Enabled = True
    End Sub
End Class