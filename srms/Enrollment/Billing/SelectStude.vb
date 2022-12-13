Imports MySql.Data.MySqlClient
Public Class frmSelectStude
    Dim str As String
    Private Sub frmSelectStude_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select StudentNumber, LastName, FirstName, MiddleName from studeprofile order by LastName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysDA.Fill(ds, "studeprofile")
            dgstudentsearch.DataSource = ds.Tables("studeprofile")
            conn.Close()

            dgstudentsearch.Columns(0).HeaderText = "Student No."
            dgstudentsearch.Columns(1).HeaderText = "Last Name"
            dgstudentsearch.Columns(2).HeaderText = "First Name"
            dgstudentsearch.Columns(3).HeaderText = "Middle Name"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dgstudentsearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgstudentsearch.DoubleClick
        Dim i As Integer
        i = dgstudentsearch.CurrentRow.Index

        frmOtherIncome.mskStudentNumber.Text = dgstudentsearch.Item(0, i).Value
        frmOtherIncome.txtLastName.Text = dgstudentsearch.Item(1, i).Value
        frmOtherIncome.txtFname.Text = dgstudentsearch.Item(2, i).Value
        frmOtherIncome.txtMName.Text = dgstudentsearch.Item(3, i).Value

        txtSearch.Clear()
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select StudentNumber, LastName, FirstName, MiddleName from studeprofile where LastName like '%" & txtSearch.Text & "%' order by LastName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysDA.Fill(ds, "studeprofile")
            dgstudentsearch.DataSource = ds.Tables("studeprofile")
            conn.Close()

            dgstudentsearch.Columns(0).HeaderText = "Student No."
            dgstudentsearch.Columns(1).HeaderText = "Last Name"
            dgstudentsearch.Columns(2).HeaderText = "First Name"
            dgstudentsearch.Columns(3).HeaderText = "Middle Name"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class