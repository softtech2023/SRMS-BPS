Imports MySql.Data.MySqlClient
Public Class frmPublisher
    Dim str As String
    Dim i As Integer
    Private Sub frmPublisher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formload()

    End Sub
    Public Sub formload()
        Try
            str = " select * from libpublisher order by publisher"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libpublisher")
            dg1.DataSource = ds.Tables("libpublisher")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 348

            txtPublisher.Focus()
            txtPublisher.Clear()
            tsSave.Enabled = True
            tsUpdate.Enabled = False
            tsDelete.Enabled = False


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try

            If txtPublisher.Text = "" Then
                MsgBox("Input a publisher!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            str = "insert into libpublisher values (0,'" & txtPublisher.Text & "')"
            conn.Open()
            Dim mysc1 As New MySqlCommand(str, conn)
            mysc1.ExecuteNonQuery()
            conn.Close()
            formload()
            MsgBox("Saved Successfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Try
            str = "select * from libpublisher where  publisher like '%" & txtsearch.Text & "'"
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libpublisher")
            dg1.DataSource = ds.Tables("libpublisher")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 348
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            str = "update libpublisher set publisher='" & txtPublisher.Text & "' where pubID= '" & lblID.Text & "'"
            conn.Open()
            Dim mysc2 As New MySqlCommand(str, conn)
            mysc2.ExecuteNonQuery()
            conn.Close()
            formload()
            MsgBox("Updated Successfully!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Do you want to delete this Publisher?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from libpublisher where pubID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc3 As New MySqlCommand(str, conn)
                mysc3.ExecuteNonQuery()
                conn.Close()
                formload()
                MsgBox("Deleted Successfully!", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        i = dg1.CurrentRow.Index
        lblID.Text = dg1.Item(0, i).Value
        txtPublisher.Text = dg1.Item(1, i).Value

        tsSave.Enabled = False
        tsUpdate.Enabled = True
        tsDelete.Enabled = True
        txtsearch.Clear()
        txtPublisher.Focus()
    End Sub
End Class