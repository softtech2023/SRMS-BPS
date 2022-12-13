Imports MySql.Data.MySqlClient
Public Class frmGatePassDashboard
    Dim str As String
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "select * from gatepass where VisitDate>= '" & Format(dtpFrom.Value.Date, "yyyy-MM-dd") & "' and VisitDate <= '" & Format(dtpTo.Value.Date, "yyyy-MM-dd") & "' order by VisitDate desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "gatepass")
            Dim obj As New GatePassSummary
            obj.SetDataSource(ds.Tables("gatepass"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            conn.Close()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCansel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCansel.Click
        Me.Close()
    End Sub
End Class