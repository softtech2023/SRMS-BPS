Imports MySql.Data.MySqlClient
Public Class DirectoryStaff
    Dim str As String

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select IDNumber, Name, Position, Department, DateHired, ContactNumber, Address, IDNumber from staff where Name like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "staff")
            dgFacultySearch.DataSource = ds.Tables("staff")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub DirectoryStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select IDNumber, Name, Position, Department, DateHired, ContactNumber, Address from staff"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            mysda.Fill(ds, "staff")
            dgFacultySearch.DataSource = ds.Tables("staff")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class