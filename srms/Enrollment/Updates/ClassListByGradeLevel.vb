Imports MySql.Data.MySqlClient
Public Class frmClassListByGradeLevel
    Dim str As String

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as Fullname, p.Sex, p.classification, ss.Course, ss.YearLevel, ss.Status, ss.SY, YearLevelStat, ss.Section, ss.semstudentid, ss.Adviser, sr.RegistrarJHS, sr.RegistrarSHS, sr.principalJHS, sr.letterHead from semesterstude ss join studeprofile p on p.StudentNumber=ss.StudentNumber join srms_settings sr on sr.settingsID=ss.settingsID where ss.YearLevel='" & cboGradeLevel.Text & "' and ss.Section='" & cboSection.Text & "' and ss.Semester='" & frmParent.lblSem.Text & "'  and ss.SY='" & frmParent.lblSY.Text & "' and ss.Status='Enrolled' order by Fullname"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "semesterstude")
            Dim obj As New ClassListGradeLevel
            obj.SetDataSource(mysds.Tables("semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            conn.Close()
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub getGradeLevel()
        Try
            str = "select * from sections group by YearLevel order by YearLevel"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "sections")
            conn.Close()

            cboGradeLevel.ValueMember = "sections"
            cboGradeLevel.DisplayMember = "YearLevel"
            cboGradeLevel.DataSource = ds.Tables("sections")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getSection()
        Try
            str = "select * from sections where YearLevel='" & cboGradeLevel.Text & "' order by Section"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "sections")
            conn.Close()

            cboSection.ValueMember = "sections"
            cboSection.DisplayMember = "Section"
            cboSection.DataSource = ds.Tables("sections")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmClassListByGradeLevel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getGradeLevel()
    End Sub

    Private Sub cboGradeLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGradeLevel.SelectedIndexChanged
        getSection()
    End Sub
End Class