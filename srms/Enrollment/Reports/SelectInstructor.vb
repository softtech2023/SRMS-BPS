Imports MySql.Data.MySqlClient
Public Class frmSelectInstructor
    Dim str As String
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select IDNumber, concat(FirstName,' ',LastName) as Name, empPosition, Department from staff where LastName like '%" & txtSearch.Text & "%' order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "staff")
            dg1.DataSource = ds.Tables("staff")
            conn.Close()

            dg1.Columns(0).HeaderText = "ID No."
            dg1.Columns(1).Width = 230
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmSelectInstructor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select IDNumber, concat(FirstName,' ',LastName) as Name, empPosition, Department from staff order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "staff")
            dg1.DataSource = ds.Tables("staff")
            conn.Close()
            dg1.Columns(0).HeaderText = "ID No."
            dg1.Columns(1).Width = 230

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        frmLoading.lblInstructorID.Text = dg1.Item(0, i).Value
        frmLoading.cboInstructor.Text = dg1.Item(1, i).Value
        Me.Close()
    End Sub
End Class