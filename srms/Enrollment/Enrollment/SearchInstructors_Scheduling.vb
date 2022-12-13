Imports MySql.Data.MySqlClient
Public Class frmSearchInstructors_Scheduling
    Dim str As String
    Private Sub frmSearchInstructors_Scheduling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select IDNumber, concat(FirstName,' ',LastName) as Name, empPosition, Department from staff order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "staff")
            dg.DataSource = ds.Tables("staff")
            conn.Close()
            dg.Columns(0).HeaderText = "ID No."
            dg.Columns(1).Width = 230

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Try
            str = "select IDNumber, concat(FirstName,' ',LastName) as Name, empPosition, Department from staff where LastName like '%" & txtsearch.Text & "%' order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "staff")
            dg.DataSource = ds.Tables("staff")
            conn.Close()

            dg.Columns(0).HeaderText = "ID No."
            dg.Columns(1).Width = 230
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        Dim i As Integer
        i = dg.CurrentRow.Index
        frmSemSubjects.txtInstructor.Text = dg.Item(0, i).Value
        frmSemSubjects.txtInstructorName.Text = dg.Item(1, i).Value

        frmEditDTR.txtEmployeeNo.Text = dg.Item(0, i).Value
        frmEditDTR.txtEmployeeName.Text = dg.Item(1, i).Value

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class