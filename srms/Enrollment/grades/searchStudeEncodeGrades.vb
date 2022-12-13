Imports MySql.Data.MySqlClient
Public Class frmSearchStudeEncodeGrades
    Dim str As String

    Private Sub frmSearchStudeEncodeGrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select p.StudentNumber, concat(ss.LName,', ',ss.FName) as StudeName, ss.YearLevel, ss.Track, ss.Qualification, ss.Adviser from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' group by p.StudentNumber order by ss.LName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            dgstudentsearch.DataSource = ds.Tables("studeprofile, semesterstude")
            conn.Close()

            dgstudentsearch.Columns(0).HeaderText = "LRN"
            dgstudentsearch.Columns(1).Width = 400

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dgstudentsearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgstudentsearch.DoubleClick
        Dim i As Integer
        i = dgstudentsearch.CurrentRow.Index

        frmEncodeGrades.mskStudentNumber.Text = dgstudentsearch.Item(0, i).Value
        frmEncodeGrades.txtStudeName.Text = dgstudentsearch.Item(1, i).Value

        frmModifyGrades.mskStudentNumber.Text = dgstudentsearch.Item(0, i).Value
        frmModifyGrades.txtStudeName.Text = dgstudentsearch.Item(1, i).Value
        frmModifyGrades.lblYearLevel.Text = dgstudentsearch.Item(2, i).Value
        frmModifyGrades.lblTrack.Text = dgstudentsearch.Item(3, i).Value
        frmModifyGrades.lblQualification.Text = dgstudentsearch.Item(4, i).Value
        frmModifyGrades.lblAdviser.Text = dgstudentsearch.Item(5, i).Value

        frmModifyGrades.getGrades()
        frmModifyGrades.btnAdd.Enabled = True

        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select p.StudentNumber, concat(ss.LName,', ',ss.FName) as StudeName, ss.YearLevel, ss.Track, ss.Qualification, ss.Adviser from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.LName like '%" & txtSearch.Text & "%' and ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' group by p.StudentNumber order by ss.LName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            dgstudentsearch.DataSource = ds.Tables("studeprofile, semesterstude")
            conn.Close()

            dgstudentsearch.Columns(0).HeaderText = "LRN"
            dgstudentsearch.Columns(1).Width = 400

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class