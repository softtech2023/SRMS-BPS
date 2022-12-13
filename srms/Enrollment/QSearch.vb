Imports MySql.Data.MySqlClient
Public Class frmQSearch
    Dim str As String
    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select StudentNumber, FirstName, MiddleName, LastName, concat(Brgy,' ',City,' ',Province) as Address from studeprofile where LastName like '%" & txtSearch.Text & "%' order by StudentNumber desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")
            dgstudentsearch.DataSource = ds.Tables("studeprofile")
            dgstudentsearch.Columns(4).Width = 300
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmQSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select StudentNumber, FirstName, MiddleName, LastName, concat(Brgy,' ',City,' ',Province) as Address from studeprofile order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")
            dgstudentsearch.DataSource = ds.Tables("studeprofile")
            conn.Close()
            dgstudentsearch.Columns(4).Width = 300
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dgstudentsearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgstudentsearch.DoubleClick
        Dim i As Integer
        i = dgstudentsearch.CurrentRow.Index
        frmCertification.mskStudentNumber.Text = dgstudentsearch.Item(0, i).Value
        frmCertification.getDepartment()

        frmStudeReport_Accounting.mskStudentNumber.Text = dgstudentsearch.Item(0, i).Value

        Me.Close()
    End Sub
End Class