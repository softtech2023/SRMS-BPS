Imports MySql.Data.MySqlClient
Public Class frmLockUnlockGrades
    Dim str As String
    Private Sub btnSelectSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectSubject.Click
        frmselectGradeStat.ShowDialog()
    End Sub

    Private Sub tsReceive_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsReceive.Click
        If txtsubjectcode.Text = "" Then
            MsgBox("Please select subject to unlock/lock", MsgBoxStyle.Exclamation)
            txtsubjectcode.Focus()
            Exit Sub
        End If

        Try
            If txtGradeStatus.Text = "Open" Then
                str = "update grades set firstStat='Closed',secondStat='Closed',thirdStat='Closed',fourthStat='Closed' where SubjectCode='" & txtsubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Instructor='" & txtInstructor.Text & "' and Section='" & txtSection.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Grades status successfully changed!", MsgBoxStyle.Information)
                conn.Close()
                FormLoad()

            Else
                str = "update grades set firstStat='Open',secondStat='Open',thirdStat='Open',fourthStat='Open' where SubjectCode='" & txtsubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Instructor='" & txtInstructor.Text & "' and Section='" & txtSection.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Grades status successfully changed!", MsgBoxStyle.Information)
                conn.Close()
                FormLoad()

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try

    End Sub
    Public Sub FormLoad()
        txtsubjectcode.Clear()
        txtDescription.Clear()
        txtInstructor.Clear()
        txtSection.Clear()
        txtGradeStatus.Clear()
        'cboFirst.ResetText()
        'cbo2nd.ResetText()
        'cbo3rd.ResetText()
        'cbo4th.ResetText()

    End Sub

    Private Sub tsPreview_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsPreview.Click
        Try
            If txtsubjectcode.Text = "" Or txtSection.Text = "" Or txtInstructor.Text = "'" Then
                MsgBox("All fields are required.  Please fill it up completely!", MsgBoxStyle.Information)
                txtsubjectcode.Focus()
                Exit Sub
            End If

            If frmParent.lblSem.Text = "1st Sem." Or frmParent.lblSem.Text = "2nd Sem." Then
                str = "select g.Instructor, sp.StudentNumber, sp.Sex, concat(sp.LastName,', ',sp.FirstName,' ',sp.MiddleName) as StudentName, g.SubjectCode, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.SY, g.Sem, sr.SchoolName, sr.SchoolAddress from grades g join studeprofile sp on sp.StudentNumber=g.StudentNumber join srms_settings sr on sp.settingsID=sr.settingsID where g.SubjectCode='" & txtsubjectcode.Text & "' and g.Instructor='" & txtInstructor.Text & "' and g.Section='" & txtSection.Text & "' and g.Description='" & txtDescription.Text & "' and g.SY='" & frmParent.lblSY.Text & "' order by StudentName"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "studeprofile, grades")
                Dim obj As New GradingSheet
                obj.SetDataSource(mysds.Tables("studeprofile, grades"))
                CrystalReportViewer1.ReportSource = obj
                CrystalReportViewer1.Refresh()
                conn.Close()
            Else
                str = "select g.Instructor, sp.StudentNumber, sp.Sex, concat(sp.LastName,', ',sp.FirstName,' ',sp.MiddleName) as StudentName, g.SubjectCode, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.SY, g.Sem, sr.SchoolName, sr.SchoolAddress from grades g join studeprofile sp on sp.StudentNumber=g.StudentNumber join srms_settings sr on sp.settingsID=sr.settingsID where g.SubjectCode='" & txtsubjectcode.Text & "' and g.Instructor='" & txtInstructor.Text & "' and g.Section='" & txtSection.Text & "' and g.Description='" & txtDescription.Text & "' and g.SY='" & frmParent.lblSY.Text & "' order by StudentName"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "studeprofile, grades")
                Dim obj As New GradingSheetJHS
                obj.SetDataSource(mysds.Tables("studeprofile, grades"))
                CrystalReportViewer1.ReportSource = obj
                CrystalReportViewer1.Refresh()
                conn.Close()
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

   
    Private Sub frmLockUnlockGrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub

    Public Sub buttonState()
        If txtGradeStatus.Text = "Open" Then
            tsReceive.Text = "Lock"
        Else
            tsReceive.Text = "Unlock"
        End If
    End Sub

    Private Sub txtGradeStatus_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        buttonState()
    End Sub

    Private Sub txtGradeStatus_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGradeStatus.TextChanged
        buttonState()
    End Sub
End Class