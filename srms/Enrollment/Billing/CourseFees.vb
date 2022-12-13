Imports MySql.Data.MySqlClient
Public Class frmCourseFees
    Dim str As String
    Private Sub frmCourseFees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.get_major' table. You can move, or remove it, as needed.
        Me.Get_majorTableAdapter.Fill(Me.DataSet2.get_major)
        'TODO: This line of code loads data into the 'DataSet.courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.DataSet.courses)
        FormLoad()
    End Sub
    Public Sub FormLoad()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False

        txtLabRate.Text = "0.00"
        txtLecRate.Text = "0.00"
        cboCourse.ResetText()
        cboMajor.ResetText()

        Try
            str = "select * from coursefees order by Course"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "coursefees")
            dg1.DataSource = ds.Tables("coursefees")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 250
            dg1.Columns(2).Width = 150
            dg1.Columns(3).HeaderText = "Lec Rate"
            dg1.Columns(4).HeaderText = "Lab Rate"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            str = "insert into coursefees values('0','" & cboCourse.Text & "','" & cboMajor.Text & "','" & txtLecRate.Text & "','" & txtLabRate.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record saved!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
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
        cboMajor.Text = dg1.Item(2, i).Value
        txtLecRate.Text = dg1.Item(3, i).Value
        txtLabRate.Text = dg1.Item(4, i).Value

        btnSave.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            str = "update coursefees set Course='" & cboCourse.Text & "',Major='" & cboMajor.Text & "',LecRate='" & txtLecRate.Text & "',LabRate='" & txtLabRate.Text & "' where coursefeesID='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record updated!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from coursefees where coursefeesID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Record deleted!", MsgBoxStyle.Information)
                conn.Close()
                FormLoad()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class