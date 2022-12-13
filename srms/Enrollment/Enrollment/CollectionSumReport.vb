Imports MySql.Data.MySqlClient
Public Class frmCollectionSumReport
    Dim str As String
    Private Sub frmCollectionSumReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Str = "select sum(Amount), PDate FROM payments p group by Amount"

            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "payments")
            Dim obj As New SummaryRep
            obj.SetDataSource(mysds.Tables("payments"))
            Me.summary.ReportSource = obj
            Me.summary.Refresh()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class