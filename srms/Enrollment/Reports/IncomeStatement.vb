Imports MySql.Data.MySqlClient
Public Class frmIncomeStatement
    Dim str As String
    Public Sub getTotalStudeAccts()
        Try
            Dim totalpayment As Double
            str = "select * from paymentsaccounts where PDate>= '" & Format(dtpFrom.Value.Date, "yyyy-MM-dd") & "' and PDate <= '" & Format(dtpTo.Value.Date, "yyyy-MM-dd") & "' and ORStatus='Valid'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            Dim mysDR As MySqlDataReader = mysC.ExecuteReader

            While mysDR.Read
                totalpayment += Val(mysDR(8))
            End While

            txtStudeAccts.Text = Format(totalpayment, "00.00")

            mysDR.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    
    Public Sub getTotalExpenses()
        Try
            Dim totalexpense As Double
            str = "select * from expenses where ExpenseDate>= '" & Format(dtpFrom.Value.Date, "yyyy-MM-dd") & "' and ExpenseDate <= '" & Format(dtpTo.Value.Date, "yyyy-MM-dd") & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            Dim mysDR As MySqlDataReader = mysC.ExecuteReader

            While mysDR.Read
                totalexpense += Val(mysDR(2))
            End While

            txtExpenses.Text = Format(totalexpense, "00.00")
            mysDR.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        getTotalStudeAccts()
        getTotalExpenses()
        getTotal()
    End Sub
    Public Sub getTotal()
        Dim totalIncome As Double
        totalIncome = Val(txtStudeAccts.Text) - Val(txtExpenses.Text)
        txtIncome.Text = Format(totalIncome, "0.00")

        lblIncome.Text = totalIncome.ToString("C", New System.Globalization.CultureInfo("fil-PH"))
    End Sub

    
    Private Sub btnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPreview.Click
        Try
            'delete existing records
            str = "delete from incomestatement"
            conn.Open()
            Dim mysc1 As New MySqlCommand(str, conn)
            mysc1.ExecuteNonQuery()
            conn.Close()

            'save record to database
            str = "insert into incomestatement values ('0','" & Convert.ToDateTime(dtpFrom.Text).ToString("yyyy-MM-dd") & "','" & Convert.ToDateTime(dtpTo.Text).ToString("yyyy-MM-dd") & "','" & txtStudeAccts.Text & "','" & txtExpenses.Text & "','" & txtIncome.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            'PrintRecord
            str = "SELECT * from incomestatement where DateFrom='" & Convert.ToDateTime(dtpFrom.Text).ToString("yyyy-MM-dd") & "' and DateTo='" & Convert.ToDateTime(dtpTo.Text).ToString("yyyy-MM-dd") & "'"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "incomestatement")
            Dim obj As New IncomeStatementReport
            obj.SetDataSource(mysds.Tables("incomestatement"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmIncomeStatement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class