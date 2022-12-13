Imports MySql.Data.MySqlClient
Public Class frmSelectStaff
    Dim str As String
    Private Sub SelectStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            str = "select IDNumber, concat (LastName,',',FirstName,' ',MiddleName) as Name from staff group by IDNumber order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "staff")
            dg1.DataSource = ds.Tables("staff")
            conn.Close()
            dg1.Columns(0).HeaderText = "Staff No."
            dg1.Columns(1).HeaderText = "Staff Name"
            dg1.Columns(0).Width = 100
            dg1.Columns(1).Width = 370
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            conn.Close()

        End Try
    End Sub
    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer

        Try
            i = dg1.CurrentRow.Index
            frmStaffLoan.txtStudentNo.Text = dg1.Item(0, i).Value
            frmStaffLoan.txtName.Text = dg1.Item(1, i).Value

            frmStaffLoan.btnselectbook.Enabled = True
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            conn.Close()

        End Try
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Try

            str = "select IDNumber, concat (LastName,',',FirstName,' ',MiddleName) as Name from staff where LastName like '%" & txtsearch.Text & "%' order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "staff")
            dg1.DataSource = ds.Tables("staff")
            conn.Close()
            dg1.Columns(0).HeaderText = "Staff No."
            dg1.Columns(1).HeaderText = "Staff Name"
            dg1.Columns(0).Width = 100
            dg1.Columns(1).Width = 370
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            conn.Close()

        End Try
    End Sub
End Class