Imports MySql.Data.MySqlClient
Public Class frmStudeGrades
    Dim str As String
    Private Sub frmStudeGrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "SELECT Description, PGrade, MGrade, PFinalGrade, FGrade, Average FROM grades where StudentNumber='" & frmParent.lblUser.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "grades")
            dg1.DataSource = ds.Tables("grades")
            conn.Close()

            dg1.Columns(0).HeaderText = "Subject"
            dg1.Columns(0).Width = 350
            dg1.Columns(1).HeaderText = "1st"
            dg1.Columns(1).Width = 50
            dg1.Columns(2).HeaderText = "2nd"
            dg1.Columns(2).Width = 50
            dg1.Columns(3).HeaderText = "3rd"
            dg1.Columns(3).Width = 50
            dg1.Columns(4).HeaderText = "4th"
            dg1.Columns(4).Width = 50
            dg1.Columns(5).HeaderText = "Average"


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class