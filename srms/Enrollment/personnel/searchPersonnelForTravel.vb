Imports MySql.Data.MySqlClient
Public Class frmsearchPersonnelForTravel
    Dim str As String
    Private Sub frmsearchPersonnelForTravel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select IDNumber, concat(FirstName,' ',MiddleName,' ',LastName) as Name, empPosition from staff"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "staff")
            dgProfile.DataSource = ds.Tables("staff")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        dgProfile.Columns(1).Width = 400
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select IDNumber, concat(FirstName,' ',MiddleName,' ',LastName) as Name, empPosition from staff where LastName like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "staff")
            dgProfile.DataSource = ds.Tables("staff")
            conn.Close()

            dgProfile.Columns(1).Width = 400
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dgProfile_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgProfile.DoubleClick
        Dim i As Integer
        i = dgProfile.CurrentRow.Index
        frmTravelOrder.txtEmployeeID.Text = dgProfile.Item(0, i).Value
        frmTravelOrder.txtName.Text = dgProfile.Item(1, i).Value
        frmTravelOrder.txtPosition.Text = dgProfile.Item(2, i).Value
        frmTravelOrder.getTravel()
        frmTravelOrder.txtStation.Focus()
        frmTravelOrder.tsSave.Enabled = True

        frmClassReplacement.txtEmployeeID.Text = dgProfile.Item(0, i).Value
        frmClassReplacement.txtName.Text = dgProfile.Item(1, i).Value
        frmClassReplacement.txtPosition.Text = dgProfile.Item(2, i).Value

        Me.Close()
    End Sub
End Class