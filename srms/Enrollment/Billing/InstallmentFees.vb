Imports MySql.Data.MySqlClient
Public Class frmInstallmentFees
    Dim str As String
    Private Sub frmInstallmentFees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.DataSet.courses)
        FormLoad()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            str = "insert into installmentfee values('0','" & cboCourse.Text & "','" & cboYearLevel.Text & "','" & txtPlan.Text & "','" & txtAmount.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(Str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("New record added!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub FormLoad()
        txtPlan.Clear()
        txtAmount.Text = "0.00"

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False

        txtPlan.Focus()

        Try
            str = "select * from installmentfee order by Course"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "installmentfee")
            dg1.DataSource = ds.Tables("installmentfee")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 150
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        lblID.Text = dg1.Item(0, i).Value
        cboCourse.Text = dg1.Item(1, i).Value
        cboYearLevel.Text = dg1.Item(2, i).Value
        txtPlan.Text = dg1.Item(3, i).Value
        txtAmount.Text = dg1.Item(4, i).Value

        btnSave.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            str = "update installmentfee set installmentID='" & lblID.Text & "',Course='" & cboCourse.Text & "',YearLevel='" & cboYearLevel.Text & "',Plan='" & txtPlan.Text & "',InstallmentFee='" & txtAmount.Text & "' where installmentID='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record updated!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from installmentfee where installmentID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Record deleted!", MsgBoxStyle.Information)
                conn.Close()
                FormLoad()

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class