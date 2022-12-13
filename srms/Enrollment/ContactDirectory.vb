Imports MySql.Data.MySqlClient
Public Class frmContactDirectory
    Dim str As String
    Private Sub frmContactDirectory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdoStudent.Checked = True

        Try
            str = "select concat(LastName,', ',FirstName,'  ',MiddleName) as StudentName, TelNumber, MobileNumber from studeprofile order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")
            dg1.DataSource = ds.Tables("studeprofile")
            conn.Close()
            dg1.Columns(0).Width = 260
            dg1.Columns(0).HeaderText = "Student Name"
            dg1.Columns(1).HeaderText = "Tel. No."
            dg1.Columns(1).Width = 150
            dg1.Columns(2).HeaderText = "Mobile No."
            dg1.Columns(2).Width = 150
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            If rdoStudent.Checked = True Then

                str = "select concat(LastName,', ',FirstName,'  ',MiddleName) as StudentName, TelNumber, MobileNumber from studeprofile where LastName like '%" & txtSearch.Text & "%' order by LastName"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studeprofile")
                dg1.DataSource = ds.Tables("studeprofile")
                conn.Close()
                dg1.Columns(0).Width = 260
                dg1.Columns(0).HeaderText = "Student Name"
                dg1.Columns(1).HeaderText = "Tel. No."
                dg1.Columns(1).Width = 150
                dg1.Columns(2).HeaderText = "Mobile No."
                dg1.Columns(2).Width = 150
            Else
                str = "select concat(LastName,', ',FirstName,'  ',MiddleName) as Name, empTelNo, empMobile from staff where LastName like '%" & txtSearch.Text & "%' order by LastName"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "staff")
                dg1.DataSource = ds.Tables("staff")
                conn.Close()
                dg1.Columns(0).Width = 260
                dg1.Columns(0).HeaderText = "Name"
                dg1.Columns(1).HeaderText = "Tel. No."
                dg1.Columns(1).Width = 150
                dg1.Columns(2).HeaderText = "Mobile No."
                dg1.Columns(2).Width = 150
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class