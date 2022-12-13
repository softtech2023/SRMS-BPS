Imports MySql.Data.MySqlClient
Public Class frmLoading
    Dim str As String

    Private Sub btnStudeAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudeAccount.Click
        Try
            'str = "select s.SubjectCode, s.Description, s.Section, s.SchedTime, s.LabTime, s.Room, s.SY, (s.LecUnit + s.LabUnit) as Units, s.Semester, i.IDNumber, concat(i.FirstName,' ',i.LastName) as Name from semsubjects s join staff i on s.IDNumber=i.IDNumber where i.IDNumber='" & lblInstructorID.Text & "' and s.Semester='" & frmParent.lblSem.Text & "' and s.SY='" & frmParent.lblSY.Text & "' group by s.SubjectCode, s.SchedTime, s.Room order by s.SubjectCode"
            str = "select s.SubjectCode, s.Description, s.Section, s.SchedTime, s.LabTime, s.Room, s.SY, (s.LecUnit + s.LabUnit) as Units, s.Semester, i.IDNumber, concat(i.FirstName,' ',i.LastName) as Name, sr.SchoolName, sr.SchoolAddress from semsubjects s join staff i on s.IDNumber=i.IDNumber join srms_settings sr on s.settingsID=sr.settingsID where i.IDNumber='" & lblInstructorID.Text & "' and s.Semester='" & frmParent.lblSem.Text & "' and s.SY='" & frmParent.lblSY.Text & "' group by s.SubjectCode, s.SchedTime, s.Room order by s.SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "i.staff, s.semsubjects")
            Dim obj As New WorkLoad
            obj.SetDataSource(ds.Tables("i.staff, s.semsubjects"))
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmSelectInstructor.ShowDialog()
    End Sub
End Class