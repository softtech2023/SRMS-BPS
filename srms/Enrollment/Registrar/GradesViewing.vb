Imports MySql.Data.MySqlClient
Public Class frmGradesViewing
    Dim str As String
    Private Sub btnStudeReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStudeReport.Click
        Try
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudeName, p.Sex, p.BirthDate, p.Age, p.BirthPlace, p.Guardian, ss.Course, ss.YearLevel, ss.Adviser, ss.Section, ss.Track, ss.Qualification, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.SY, sr.SchoolName, sr.SchoolAddress, sr.SchoolHead, sr.sHeadPosition,sr.Division,sr.Region, sr.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on ss.StudentNumber=g.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Semester='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and g.Sem='" & frmParent.lblSem.Text & "'  group by g.SubjectCode order by g.Description"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "p.studeprofile, g.grades, ss.semesterstude")
            Dim obj As New ReportofGrades
            obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades, ss.semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            specialReportViewer.ReportSource = obj
            specialReportViewer.Refresh()
            conn.Close()

            mskStudentNumber.Clear()
            mskStudentNumber.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        specialReportViewer.ReportSource = Nothing
        specialReportViewer.Refresh()
        mskStudentNumber.Focus()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        btnReset.PerformClick()
    End Sub

    Private Sub frmGradesViewing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class