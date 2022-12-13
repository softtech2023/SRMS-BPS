Imports MySql.Data.MySqlClient
Public Class frmAuthors
    Dim str As String
    Dim i As Integer

    Private Sub Authors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formload()

    End Sub
    Public Sub formload()
        Try
            str = "select * from libauthors order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libauthors")
            dg1.DataSource = ds.Tables("libauthors")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 75
            dg1.Columns(2).Width = 100
            dg1.Columns(3).Width = 100
            dg1.Columns(4).Width = 100

            txtauthorno.Clear()
            txtfName.Clear()
            txtmName.Clear()
            txtlName.Clear()
            txtauthorno.Focus()
            tsSave.Enabled = True
            tsUpdate.Enabled = False
            tsDelete.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub

   
    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        i = dg1.CurrentRow.Index
        lblauthorID.Text = dg1.Item(0, i).Value
        txtauthorno.Text = dg1.Item(1, i).Value
        txtfName.Text = dg1.Item(2, i).Value
        txtmName.Text = dg1.Item(3, i).Value
        txtlName.Text = dg1.Item(4, i).Value

        tsSave.Enabled = False
        tsUpdate.Enabled = True
        tsDelete.Enabled = True
    End Sub

   

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Try
            str = " select * from libauthors where AuthorNum like '%" & txtsearch.Text & "%' or FirstName like '%" & txtsearch.Text & "%' or MiddleName like '%" & txtsearch.Text & "%' or LastName like '%" & txtsearch.Text & "%'"
            conn.Close()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libauthors")
            dg1.DataSource = ds.Tables("libauthors")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 75
            dg1.Columns(2).Width = 100
            dg1.Columns(3).Width = 100
            dg1.Columns(4).Width = 100

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tsSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            If txtauthorno.Text = "" Or txtfName.Text = "" Or txtlName.Text = "" Then
                MsgBox("Fill-up data required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            str = "insert into libauthors values (0,'" & txtauthorno.Text & "','" & txtfName.Text & "','" & txtmName.Text & "','" & txtlName.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("Saved Successfully", MsgBoxStyle.Information)

            formload()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub

    Private Sub tsUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            str = "update libauthors set AuthorNum='" & txtauthorno.Text & "', FirstName='" & txtfName.Text & "', MiddleName='" & txtmName.Text & "', LastName= '" & txtlName.Text & "' where authorID='" & lblauthorID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("Updated Successfully", MsgBoxStyle.Information)

            formload()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub

    Private Sub tsDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from libauthors where authorID='" & lblauthorID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("Deleted Successfully!", MsgBoxStyle.Information)
                formload()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class