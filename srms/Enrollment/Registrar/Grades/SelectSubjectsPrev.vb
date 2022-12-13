Imports MySql.Data.MySqlClient
Public Class frmSelectSubjectsPrev
    Dim str As String

    Private Sub dgsubjects_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgsubjects.DoubleClick
        Try
            Dim dclick As Integer
            dclick = dgsubjects.CurrentRow.Index
            frmPrevGrades.txtSubjectCode.Text = dgsubjects.Item(1, dclick).Value
            frmPrevGrades.txtDescription.Text = dgsubjects.Item(2, dclick).Value
            Me.Close()
            frmPrevGrades.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub frmSelectSubjectsPrev_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select * from subjects order by SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "subjects")
            dgsubjects.DataSource = ds.Tables("subjects")
            conn.Close()
            dgsubjects.Columns(0).Visible = False
            dgsubjects.Columns(1).HeaderText = "Subject Code"
            dgsubjects.Columns(2).Width = 250
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Try
            str = "select * from subjects where SubjectCode like '%" & txtsearch.Text & "%' or description like '%" & txtsearch.Text & "%' order by SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "subjects")
            dgsubjects.DataSource = ds.Tables("subjects")
            conn.Close()
            dgsubjects.Columns(0).Visible = False
            dgsubjects.Columns(1).HeaderText = "Subject Code"
            dgsubjects.Columns(2).Width = 250
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class