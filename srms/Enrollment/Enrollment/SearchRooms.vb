Imports MySql.Data.MySqlClient
Public Class frmSearchRooms
    Dim str As String
    Private Sub frmSearchRooms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select * from classrooms"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "classrooms")
            dg1.DataSource = ds.Tables("classrooms")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        frmSemSubjects.txtRoom.Text = dg1.Item(1, i).Value
        Me.Close()
    End Sub

    Private Sub txtRoom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRoom.TextChanged
        Try
            str = "select * from classrooms where ClassRoom like '%" & txtRoom.Text & "%'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "classrooms")
            dg1.DataSource = ds.Tables("classrooms")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class