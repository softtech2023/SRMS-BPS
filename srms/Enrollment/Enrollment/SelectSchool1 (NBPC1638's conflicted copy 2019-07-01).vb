Imports MySql.Data.MySqlClient
Public Class frmSelectSchool1
    Dim str As String
    Private Sub frmSelectSchool1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Str = "select * from prevschool order by School"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "prevschool")
            dg1.DataSource = ds.Tables("prevschool")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 250
            dg1.Columns(2).Width = 250
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from prevschool where School like '%" & txtSearch.Text & "%' order by School"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "prevschool")
            dg1.DataSource = ds.Tables("prevschool")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 250
            dg1.Columns(2).Width = 250
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        frmStudeProfile.txtHighSchool.Text = dg1.Item(1, i).Value
        frmStudeProfile.txtHSAddress.Text = dg1.Item(2, i).Value
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class