Imports MySql.Data.MySqlClient
Public Class frmExpReportDashobard
    Dim str As String
    Private Sub btnStudeAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "SELECT Description, Amount, Responsible, ExpenseDate, Category FROM expenses where ExpenseDate>= '" & Format(dtpFrom.Value.Date, "yyyy-MM-dd") & "' and ExpenseDate <= '" & Format(dtpTo.Value.Date, "yyyy-MM-dd") & "' order by ExpenseDate Desc"
            conn.Open()
            Dim mysDa As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDa.Fill(mysds, "expenses")
            Dim obj As New ReportDetailedExp
            obj.SetDataSource(mysds.Tables("expenses"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            Me.Hide()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class