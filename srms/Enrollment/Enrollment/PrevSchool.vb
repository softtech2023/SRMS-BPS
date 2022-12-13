Imports MySql.Data.MySqlClient
Public Class frmPrevSchool
    Dim str As String
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmPrevSchool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False

        txtSchool.Focus()

        loadPrevSchool()
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        lblID.Text = dg1.Item(0, i).Value
        txtSchool.Text = dg1.Item(1, i).Value
        txtAddress.Text = dg1.Item(2, i).Value

        tsSave.Enabled = False
        tsUpdate.Enabled = True
        tsDelete.Enabled = True

    End Sub


    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            str = "insert into prevschool values('0','" & txtSchool.Text & "','" & txtAddress.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("New data added successfully!", MsgBoxStyle.Information)
            conn.Close()

            txtSchool.Clear()
            txtAddress.Clear()
            txtSchool.Focus()

            loadPrevSchool()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            str = "update prevschool set schoolID='" & lblID.Text & "',School='" & txtSchool.Text & "',Address='" & txtAddress.Text & "' where schoolID='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Selected data has been updated successfully!", MsgBoxStyle.Information)
            conn.Close()

            txtSchool.Clear()
            txtAddress.Clear()
            txtSchool.Focus()

            loadPrevSchool()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes) Then
                str = "delete from prevschool where schoolID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Selected record has been deleted!", MsgBoxStyle.Information)
                conn.Close()
                txtSchool.Clear()
                txtAddress.Clear()
                txtSchool.Focus()

                loadPrevSchool()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
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

    Public Sub loadPrevSchool()
        Try
            str = "select * from prevschool order by School"
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
End Class