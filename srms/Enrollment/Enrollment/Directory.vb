Imports MySql.Data.MySqlClient
Public Class frmDirectory
    Dim str As String

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from studeprofile where LastName like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "studeprofile")
            dgdirectory.DataSource = ds.Tables("studeprofile")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmDirectory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'str = "select StudentNumber, FirstName, MiddleName, LastName, TelNumber, MobileNumber from studeprofile"
            str = "select * from studeprofile"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")
            dgdirectory.DataSource = ds.Tables("studeprofile")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub
End Class