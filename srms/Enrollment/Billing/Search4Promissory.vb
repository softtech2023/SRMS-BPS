Imports MySql.Data.MySqlClient
Public Class frmSearch4Promissory
    Dim str As String
    Private Sub frmSearch4Promissory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select StudentNumber, FirstName, MiddleName, LastName from studeprofile"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")
            dgPromissory.DataSource = ds.Tables("studeprofile")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub


    Private Sub dgPromissory_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgPromissory.DoubleClick
        Dim dclick As Integer
        dclick = dgPromissory.CurrentRow.Index
        frmPromissory.txtStudentNumber.Text = dgPromissory.Item(0, dclick).Value
        frmPromissory.txtFirstName.Text = dgPromissory.Item(1, dclick).Value
        frmPromissory.txtLastName.Text = dgPromissory.Item(3, dclick).Value

        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged

        Try
            If cboSearch.SelectedIndex = 0 Then
                str = "select * from studeprofile where StudentNumber like '%" & txtSearch.Text & "%'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studeprofile")
                dgPromissory.DataSource = ds.Tables("studeprofile")
                conn.Close()
            End If
            If cboSearch.SelectedIndex = 1 Then
                str = "select * from studeprofile where LastName like '%" & txtSearch.Text & "%'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studeprofile")
                dgPromissory.DataSource = ds.Tables("studeprofile")
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class