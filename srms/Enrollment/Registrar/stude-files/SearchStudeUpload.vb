Imports MySql.Data.MySqlClient
Public Class frmSearchStudeUpload
    Dim str As String
    Private Sub frmSearchStudeUpload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSearch.Clear()
        txtSearch.Focus()
        Try
            Str = "select * from studeprofile"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")
            dgstudentsearch.DataSource = ds.Tables("studeprofile")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from studeprofile where LastName like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")
            dgstudentsearch.DataSource = ds.Tables("studeprofile")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dgstudentsearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgstudentsearch.DoubleClick
        Try

            Dim dclick As Integer

            dclick = dgstudentsearch.CurrentRow.Index
            frmSemStudent.Reload()
            frmFileUploader.mskStudentNumber.Text = dgstudentsearch.Item(0, dclick).Value
            frmFileUploader.txtFname.Text = dgstudentsearch.Item(1, dclick).Value
            frmFileUploader.txtMName.Text = dgstudentsearch.Item(2, dclick).Value
            frmFileUploader.txtLastName.Text = dgstudentsearch.Item(3, dclick).Value
            Me.Close()
            frmFileUploader.tsSave.Enabled = True

            'frmSemStudent.getCourse()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class