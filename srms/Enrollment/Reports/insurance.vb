Imports MySql.Data.MySqlClient
Public Class frmInsurance
    Dim str As String
    Private Sub frmInsurance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.DataSet.courses)

    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "select concat(s.LName,', ',s.FName,' ',s.MName) as StudentName, p.Address, p.Guardian, p.GuardianAddress, p.GuardianContact, s.Course, s.Semester, s.Term, s.SY from semesterstude s join studeprofile p on s.StudentNumber=p.StudentNumber where s.Course='" & cboCourse.Text & "' and s.Semester='" & frmParent.lblSem.Text & "' and s.SY='" & frmParent.lblSY.Text & "' order by StudentName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(Str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude")
            Dim obj As New SemesterStudeList
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class