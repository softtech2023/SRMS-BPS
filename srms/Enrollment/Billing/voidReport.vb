Imports MySql.Data.MySqlClient
Public Class frmVoidReport
    Dim str As String
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "select pa.ID, p.StudentNumber, concat(pa.LastName,', ',pa.FirstName,' ',pa.MiddleName) as Payor,  pa.PDate, pa.ORNumber, pa.Amount, pa.description, pa.Cashier, pa.description, v.VoidDate, v.Reasons, v.VoidedBy, st.letterHead from studeprofile p join paymentsaccounts pa on p.StudentNumber=pa.StudentNumber join voidreceipts v on pa.ID=v.ID join srms_settings st on p.settingsID=st.settingsID where VoidDate>= '" & Format(dtpFrom.Value.Date, "yyyy-MM-dd") & "' and VoidDate <= '" & Format(dtpTo.Value.Date, "yyyy-MM-dd") & "' order by VoidDate desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "paymentsaccounts, voidreceipts")
            Dim obj As New VoidORs
            obj.SetDataSource(ds.Tables("paymentsaccounts, voidreceipts"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            conn.Close()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class