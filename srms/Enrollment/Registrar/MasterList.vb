Imports MySql.Data.MySqlClient
Public Class frmMasterList
    Dim str As String
    Private Sub btnMasterlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasterlist.Click
        Try
            If txtsubjectcode.Text = "" Or txtSection.Text = "" Or txtInstructor.Text = "'" Then
                MsgBox("All fields are required.  Please fill it up completely!", MsgBoxStyle.Information)
                txtsubjectcode.Focus()
                Exit Sub
            End If

            str = "select p.StudentNumber, p.LastName, p.FirstName, p.MiddleName, p.Sex, r.Course, r.YearLevel, r.SubjectCode, r.Description, r.SchedTime, r.LabTime, r.Instructor, r.SY, r.Sem, r.Section, r.Room, sr.SchoolName, sr.SchoolAddress, sr.letterHead from studeprofile p join registration r on p.StudentNumber=r.StudentNumber join srms_settings sr on r.settingsID=sr.settingsID where r.SubjectCode='" & txtsubjectcode.Text & "' and r.Description='" & txtDescription.Text & "' and r.Instructor='" & txtInstructor.Text & "' and r.Section='" & txtSection.Text & "' and r.Sem='" & frmParent.lblSem.Text & "' and r.SY='" & frmParent.lblSY.Text & "' order by r.LastName"
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


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSelectSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectSubject.Click
        frmSelectSubject_Masterlist.ShowDialog()
    End Sub

    Private Sub txtsubjectcode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsubjectcode.Click
        frmSelectSubject_Masterlist.ShowDialog()
    End Sub
End Class