Imports MySql.Data.MySqlClient
Public Class frmselectStudent
    Dim str As String
    Private Sub frmselectStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select StudentNumber, FirstName, MiddleName, LastName from studeprofile"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")
            dg1.DataSource = ds.Tables("studeprofile")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        frmPrevGrades.txtStudeNumber.Text = dg1.Item(0, i).Value
        Me.Close()
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Try
            str = "select StudentNumber, FirstName, MiddleName, LastName from studeprofile where StudentNumber like '%" & txtsearch.Text & "%' or LastName like '%" & txtsearch.Text & "%'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")
            dg1.DataSource = ds.Tables("studeprofile")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class