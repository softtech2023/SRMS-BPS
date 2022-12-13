Imports MySql.Data.MySqlClient
Public Class frmCavReqSearch
    Dim str As String

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, ss.SY,concat(p.Sitio,', ',p.Brgy,', ',p.City,', ',p.Province) as PresentAddress, p.MobileNumber from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where p.LastName like '%" & txtSearch.Text & "%' order by ss.semstudentid desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            dg1.DataSource = ds.Tables("studeprofile, semesterstude")
            conn.Close()
            dg1.Columns(0).Visible = False

            dg1.Columns(1).Width = 150
            dg1.Columns(1).HeaderText = "Student Name"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index

       
        Me.Close()
    End Sub
End Class