Imports MySql.Data.MySqlClient
Public Class frmTeacherMasterList
    Dim str As String
    Private Sub btnMasterlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasterlist.Click
        Try
            If txtsubjectcode.Text = "" Or txtSection.Text = "" Or txtInstructor.Text = "'" Then
                MsgBox("All fields are required.  Please fill it up completely!", MsgBoxStyle.Information)
                txtsubjectcode.Focus()
                Exit Sub
            End If

            'str = "select r.StudentNumber, r.LastName, r.FirstName, r.MiddleName, r.Course, r.YearLevel, r.SubjectCode, r.Description, r.SchedTime, r.LabTime, r.Instructor, r.SY, r.Sem, r.Section, r.Room, sr.SchoolName, sr.SchoolAddress from registration r join srms_settings sr on r.settingsID=sr.settingsID where SubjectCode='" & txtsubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Instructor='" & txtInstructor.Text & "' and Section='" & txtSection.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' order by LastName"
            str = "select p.StudentNumber, p.LastName, p.FirstName, p.MiddleName, p.Sex, r.Course, r.YearLevel, r.SubjectCode, r.Description, r.SchedTime, r.LabTime, r.Instructor, r.SY, r.Sem, r.Section, r.Room, sr.SchoolName, sr.SchoolAddress, sr.letterHead from studeprofile p join registration r on p.StudentNumber=r.StudentNumber join srms_settings sr on r.settingsID=sr.settingsID where SubjectCode='" & txtsubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Instructor='" & txtInstructor.Text & "' and Section='" & txtSection.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "registration, srms_settings")
            Dim obj As New Class_List
            obj.SetDataSource(mysds.Tables("registration, srms_settings"))
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

    Private Sub btnSelectSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectSubject.Click
        frmSelectTeacherMasterList.Show()
    End Sub
End Class