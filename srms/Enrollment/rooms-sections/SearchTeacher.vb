Imports MySql.Data.MySqlClient
Public Class frmSearchTeacher
    Dim str As String
    Private Sub frmSearchTeacher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "SELECT IDNumber,  concat(FirstName,' ',MiddleName,' ',LastName) as Adviser  FROM staff order by LastName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysDA.Fill(ds, "staff")
            dg1.DataSource = ds.Tables("staff")
            conn.Close()
            dg1.Columns(1).Width = 350
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "SELECT IDNumber, concat(FirstName,' ',MiddleName,' ',LastName) as Adviser FROM staff where LastName like '%" & txtSearch.Text & "%' order by LastName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysDA.Fill(ds, "staff")
            dg1.DataSource = ds.Tables("staff")
            conn.Close()

            dg1.Columns(1).Width = 350

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        frmRooms.txtAdviser.Text = dg1.Item(1, i).Value
        frmChangeAdvisers.txtNewAdviser.Text = dg1.Item(1, i).Value
        frmChangeTeacher.txtNewTeacher.Text = dg1.Item(1, i).Value
        Me.Close()
    End Sub
End Class