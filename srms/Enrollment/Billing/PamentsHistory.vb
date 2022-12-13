Imports MySql.Data.MySqlClient
Public Class frmReports
    Dim str As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        str = "SELECT p.PDate, p.ORNumber, p.Amount, p.PaymentType, p.Sem, p.SY, b.TotalAccount, b.TotalPayments, b.CurrentAccount, b.Year, b.Course, f.StudentNumber, concat(f.FirstName,' ',f.MiddleName,' ',f.LastName) as StudentName from payments p join studeprofile f on f.StudentNumber=p.StudentNumber join billing b on f.StudentNumber=b.StudentNumber where f.StudentNumber='" & txtStudentNumber.Text & "'"
        conn.Open()
        Dim mysDA As New MySqlDataAdapter(str, conn)
        Dim mysds As New DataSet
        mysDA.Fill(mysds, "studeprofile, billing, payments")
        Dim obj As New CrystalReport1
        obj.SetDataSource(mysds.Tables("studeprofile, billing, payments"))
        Me.CrystalReportViewer1.ReportSource = obj
        Me.CrystalReportViewer1.Refresh()
        conn.Close()
    End Sub

    Private Sub frmReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtStudentNumber.Focus()
    End Sub
End Class