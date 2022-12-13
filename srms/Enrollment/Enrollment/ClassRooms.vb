Imports MySql.Data.MySqlClient
Public Class frmClassRooms
    Dim str As String
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            str = "insert into classrooms values('0','" & txtRoom.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("New Class Room Added!", MsgBoxStyle.Information)
            conn.Close()
            txtRoom.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub frmClassRooms_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick

    End Sub

    Private Sub frmClassRooms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select * from classrooms"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "classrooms")
            dg1.DataSource = ds.Tables("classrooms")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (MsgBox("Are you sure you want to remove this class room?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            str = "delete from classrooms where id='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Selecred class room has been deleted", MsgBoxStyle.Information)
            conn.Close()
            txtRoom.Clear()
        End If

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            str = "update classrooms set id='" & lblID.Text & "',ClassRoom='" & txtRoom.Text & "' where id='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Updated!", MsgBoxStyle.Information)
            conn.Close()
            txtRoom.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        lblID.Text = dg1.Item(0, i).Value
        txtRoom.Text = dg1.Item(1, i).Value

        btnSave.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub
End Class