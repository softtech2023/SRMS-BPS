Imports MySql.Data.MySqlClient
Public Class frmContacts
    Dim str As String

    Private Sub frmContacts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        str = "select StudentNumber, FirstName, MiddleName, LastName, ContactNumber from studeprofile"
        conn.Open()
        Dim mysDA As New MySqlDataAdapter(str, conn)
        Dim ds As New DataSet

        mysDA.Fill(ds, "studeprofile")

        dgcontacts.DataSource = ds.Tables("studeprofile")

        conn.Close()
    End Sub
End Class