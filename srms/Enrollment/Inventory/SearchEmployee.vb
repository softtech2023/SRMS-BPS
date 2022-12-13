Imports MySql.Data.MySqlClient
Public Class frmSearchEmployee
    Dim str As String

    Private Sub frmSearchEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select IDNumber, FirstName, LastName, empPosition, Department from staff"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "staff")
            dgProfile.DataSource = ds.Tables("staff")
            conn.Close()

            dgProfile.Columns(1).HeaderText = "First Name"
            dgProfile.Columns(2).HeaderText = "Last Name"



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select IDNumber, FirstName, LastName, empPosition, Department from staff where LastName like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "staff")
            dgProfile.DataSource = ds.Tables("staff")
            conn.Close()
            dgProfile.Columns(1).HeaderText = "First Name"
            dgProfile.Columns(2).HeaderText = "Last Name"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Private Sub dgProfile_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgProfile.DoubleClick
        Dim i As Integer
        i = dgProfile.CurrentRow.Index
        frmDistribution.txtempNo.Text = dgProfile.Item(0, i).Value
        frmDistribution.txtFirstName.Text = dgProfile.Item(1, i).Value
        frmDistribution.txtLastName.Text = dgProfile.Item(2, i).Value

 

        frmProducts.getMRPerStaff()

        Me.Close()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class