Imports MySql.Data.MySqlClient
Public Class frmReceiveGradeSheets
    Dim str As String
    Private Sub btnSelectSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectSubject.Click
        frmSelectGS.Show()
    End Sub

    Private Sub btnReceive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Sub FormLoad()
        txtsubjectcode.Clear()
        txtDescription.Clear()
        txtSection.Clear()
        txtInstructor.Clear()
        lblStatus.Text = "Open"
        dtpDate.Text = Today

        tsReceive.Enabled = False
        tsPreview.Enabled = False
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tsReceive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsReceive.Click
        Try
            If txtsubjectcode.Text = "" Then
                MsgBox("Required fields must be filled up properly!", MsgBoxStyle.Exclamation)
                txtsubjectcode.Focus()
                Exit Sub
            End If

            If chkLock.Checked = True Then
                lblStatus.Text = "Closed"
            Else
                lblStatus.Text = "Open"
            End If

            str = "insert into gsreceiver values (0,'" & txtsubjectcode.Text & "','" & txtDescription.Text & "','" & txtSection.Text & "','" & txtInstructor.Text & "','" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") & "','" & frmParent.lblUser.Text & "','" & lblStatus.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            If lblStatus.Text = "Closed" Then
                str = "update grades set Status='Closed' where SubjectCode='" & txtsubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Section='" & txtSection.Text & "' and Instructor='" & txtInstructor.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str, conn)
                mysc1.ExecuteNonQuery()
                conn.Close()
            Else
                str = "update grades set Status='Open' where SubjectCode='" & txtsubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Section='" & txtSection.Text & "' and Instructor='" & txtInstructor.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str, conn)
                mysc1.ExecuteNonQuery()
                conn.Close()
            End If

            MsgBox("Grading Sheet accepted!", MsgBoxStyle.Information)

            FormLoad()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub tsPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsPreview.Click
        Try
            If txtsubjectcode.Text = "" Or txtSection.Text = "" Or txtInstructor.Text = "'" Then
                MsgBox("All fields are required.  Please fill it up completely!", MsgBoxStyle.Information)
                txtsubjectcode.Focus()
                Exit Sub
            End If

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
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
   
    Private Sub frmReceiveGradeSheets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub
End Class