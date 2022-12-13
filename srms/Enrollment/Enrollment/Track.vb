Imports MySql.Data.MySqlClient
Public Class frmTrackandStrand
    Dim str As String
    Private Sub frmTrack_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub

    Public Sub FormLoad()
        Try
            btnSave.Enabled = True
            btnUpdate.Enabled = False
            btnDelete.Enabled = False

            txtTrack.Clear()
            txtStrand.Clear()

            str = "select * from qualifications order by Track"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "qualifications")
            dg1.DataSource = ds.Tables("qualifications")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 180
            dg1.Columns(2).HeaderText = "Strand"
            dg1.Columns(2).Width = 300
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            str = "insert into qualifications values (0,'" & txtTrack.Text & "','" & txtStrand.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("1 record added!", MsgBoxStyle.Information)
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        lblID.Text = dg1.Item(0, i).Value
        txtTrack.Text = dg1.Item(1, i).Value
        txtStrand.Text = dg1.Item(2, i).Value

        btnSave.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            str = "update qualifications set Track='" & txtTrack.Text & "',Qualification='" & txtStrand.Text & "' where qualID='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("1 record updated successfully!", MsgBoxStyle.Information)
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from qualifications where qualID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("1 record deleted!", MsgBoxStyle.Information)
                FormLoad()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class