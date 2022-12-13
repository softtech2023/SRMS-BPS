Imports MySql.Data.MySqlClient
Public Class frmOtherIncomDesc
    Dim str As String
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtdesc.Text = "" Then
                MsgBox("Payment description is required!", MsgBoxStyle.Information)
                txtdesc.Focus()
                Exit Sub
            End If

            If cboFeesType.Text = "" Then
                MsgBox("Fees type is required!", MsgBoxStyle.Exclamation)
                cboFeesType.Focus()
                Exit Sub
            End If

            str = "insert into otherfees_desc values (0,'" & txtdesc.Text.Replace("'", "''") & "','" & cboFeesType.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("New Record Added!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub FormLoad()
        txtdesc.Clear()
        cboFeesType.ResetText()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False

        Try
            str = "select * from otherfees_desc order by feesDesc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "otherfees_desc")
            dg1.DataSource = ds.Tables("otherfees_desc")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Fees Description"
            dg1.Columns(1).Width = 210
            dg1.Columns(2).HeaderText = "Fees Type"
            dg1.Columns(2).Width = 210
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmOtherIncomDesc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        lblID.Text = dg1.Item(0, i).Value
        txtdesc.Text = dg1.Item(1, i).Value
        cboFeesType.Text = dg1.Item(2, i).Value

        btnSave.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from otherfees_desc where otherfeesID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Selected record has been deleted!", MsgBoxStyle.Information)
                conn.Close()
                FormLoad()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            str = "update otherfees_desc set feesDesc='" & txtdesc.Text & "',feesType='" & cboFeesType.Text & "' where otherfeesID='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("New Record Added!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class