Imports MySql.Data.MySqlClient
Public Class frmConsolidatedDashboard
    Dim str As String
    Public Sub getGradeLevel()
        Try
            If frmParent.lblSem.Text = "1st Sem." Or frmParent.lblSem.Text = "2nd Sem." Then
                Str = "select * from course_table where CourseDescription='Senior High School'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(Str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "course_table")
                conn.Close()

                cboYearLevelAccount.ValueMember = "course_table"
                cboYearLevelAccount.DisplayMember = "Major"
                cboYearLevelAccount.DataSource = ds.Tables("course_table")

            Else
                Str = "select * from course_table where CourseDescription!='Senior High School'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(Str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "course_table")
                conn.Close()

                cboYearLevelAccount.ValueMember = "course_table"
                cboYearLevelAccount.DisplayMember = "Major"
                cboYearLevelAccount.DataSource = ds.Tables("course_table")
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub getSection()
        str = "select * from sections where YearLevel='" & cboYearLevelAccount.Text & "'"
        conn.Open()
        Dim mysda As New MySqlDataAdapter(str, conn)
        Dim ds As New DataSet
        mysda.Fill(ds, "sections")
        conn.Close()

        cboSection.ValueMember = "sections"
        cboSection.DisplayMember = "Section"
        cboSection.DataSource = ds.Tables("sections")
    End Sub

    Private Sub frmConsolidatedDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getGradeLevel()
        rdoFemale.Checked = True
    End Sub

    Private Sub cboYearLevelAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYearLevelAccount.SelectedIndexChanged
        getSection()
    End Sub

    Private Sub btnStudeAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudeAccount.Click
        Try
            If cboPeriod.Text = "" Then
                MsgBox("Grading Period is required!", MsgBoxStyle.Exclamation)
                cboPeriod.Focus()
                Exit Sub
            End If

            If cboPeriod.Text = "1st Grading" Then
                If rdoMale.Checked = True Then
                    str = "select p.StudentNumber, concat(p.LastName,', ',p.Firstname) as StudentName, p.Sex, g.SubjectCode, g.PGrade, g.Sem, g.SY, st.letterHead from studeprofile p join grades g on p.StudentNumber=g.StudentNumber join srms_settings st on p.settingsID=st.settingsID where g.Section='" & cboSection.Text & "' and g.Sem='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and p.Sex='Male'"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysda.Fill(mysds, "studeprofile, grades, srms_settings")
                    Dim obj As New ConsolidatedGrades
                    obj.SetDataSource(mysds.Tables("studeprofile, grades, srms_settings"))
                    obj.SetParameterValue("gradelevel", cboYearLevelAccount.Text)
                    obj.SetParameterValue("section", cboSection.Text)
                    obj.SetParameterValue("period", cboPeriod.Text)
                    frmMainViewer.ReportViewer.ReportSource = obj
                    frmMainViewer.ReportViewer.Refresh()
                    conn.Close()
                    frmMainViewer.MdiParent = frmParent
                    frmMainViewer.Show()
                    Me.Close()

                Else
                    str = "select p.StudentNumber, concat(p.LastName,', ',p.Firstname) as StudentName, p.Sex, g.SubjectCode, g.PGrade, g.Sem, g.SY, st.letterHead from studeprofile p join grades g on p.StudentNumber=g.StudentNumber join srms_settings st on p.settingsID=st.settingsID where g.Section='" & cboSection.Text & "' and g.Sem='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and p.Sex='Female'"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysda.Fill(mysds, "studeprofile, grades, srms_settings")
                    Dim obj As New ConsolidatedGrades
                    obj.SetDataSource(mysds.Tables("studeprofile, grades, srms_settings"))
                    obj.SetParameterValue("gradelevel", cboYearLevelAccount.Text)
                    obj.SetParameterValue("section", cboSection.Text)
                    obj.SetParameterValue("period", cboPeriod.Text)
                    frmMainViewer.ReportViewer.ReportSource = obj
                    frmMainViewer.ReportViewer.Refresh()
                    conn.Close()
                    frmMainViewer.MdiParent = frmParent
                    frmMainViewer.Show()
                    Me.Close()
                End If
            ElseIf cboPeriod.Text = "2nd Grading" Then
                If rdoMale.Checked = True Then
                    str = "select p.StudentNumber, concat(p.LastName,', ',p.Firstname) as StudentName, p.Sex, g.SubjectCode, g.MGrade, g.Sem, g.SY, st.letterHead from studeprofile p join grades g on p.StudentNumber=g.StudentNumber join srms_settings st on p.settingsID=st.settingsID where g.Section='" & cboSection.Text & "' and g.Sem='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and p.Sex='Male'"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysda.Fill(mysds, "studeprofile, grades, srms_settings")
                    Dim obj As New ConsolidatedGrades2
                    obj.SetDataSource(mysds.Tables("studeprofile, grades, srms_settings"))
                    obj.SetParameterValue("gradelevel", cboYearLevelAccount.Text)
                    obj.SetParameterValue("section", cboSection.Text)
                    obj.SetParameterValue("period", cboPeriod.Text)
                    frmMainViewer.ReportViewer.ReportSource = obj
                    frmMainViewer.ReportViewer.Refresh()
                    conn.Close()
                    frmMainViewer.MdiParent = frmParent
                    frmMainViewer.Show()
                    Me.Close()
                Else
                    str = "select p.StudentNumber, concat(p.LastName,', ',p.Firstname) as StudentName, p.Sex, g.SubjectCode, g.MGrade, g.Sem, g.SY, st.letterHead from studeprofile p join grades g on p.StudentNumber=g.StudentNumber join srms_settings st on p.settingsID=st.settingsID where g.Section='" & cboSection.Text & "' and g.Sem='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and p.Sex='Female'"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysda.Fill(mysds, "studeprofile, grades, srms_settings")
                    Dim obj As New ConsolidatedGrades2
                    obj.SetDataSource(mysds.Tables("studeprofile, grades, srms_settings"))
                    obj.SetParameterValue("gradelevel", cboYearLevelAccount.Text)
                    obj.SetParameterValue("section", cboSection.Text)
                    obj.SetParameterValue("period", cboPeriod.Text)
                    frmMainViewer.ReportViewer.ReportSource = obj
                    frmMainViewer.ReportViewer.Refresh()
                    conn.Close()
                    frmMainViewer.MdiParent = frmParent
                    frmMainViewer.Show()
                    Me.Close()
                End If
            ElseIf cboPeriod.Text = "3rd Grading" Then
                If rdoMale.Checked = True Then
                    str = "select p.StudentNumber, concat(p.LastName,', ',p.Firstname) as StudentName, p.Sex, g.SubjectCode, g.PFinalGrade, g.Sem, g.SY, st.letterHead from studeprofile p join grades g on p.StudentNumber=g.StudentNumber join srms_settings st on p.settingsID=st.settingsID where g.Section='" & cboSection.Text & "' and g.Sem='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and p.Sex='Male'"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysda.Fill(mysds, "studeprofile, grades, srms_settings")
                    Dim obj As New ConsolidatedGrades3
                    obj.SetDataSource(mysds.Tables("studeprofile, grades, srms_settings"))
                    obj.SetParameterValue("gradelevel", cboYearLevelAccount.Text)
                    obj.SetParameterValue("section", cboSection.Text)
                    obj.SetParameterValue("period", cboPeriod.Text)
                    frmMainViewer.ReportViewer.ReportSource = obj
                    frmMainViewer.ReportViewer.Refresh()
                    conn.Close()
                    frmMainViewer.MdiParent = frmParent
                    frmMainViewer.Show()
                    Me.Close()
                Else
                    str = "select p.StudentNumber, concat(p.LastName,', ',p.Firstname) as StudentName, p.Sex, g.SubjectCode, g.PFinalGrade, g.Sem, g.SY, st.letterHead from studeprofile p join grades g on p.StudentNumber=g.StudentNumber join srms_settings st on p.settingsID=st.settingsID where g.Section='" & cboSection.Text & "' and g.Sem='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and p.Sex='Female'"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysda.Fill(mysds, "studeprofile, grades, srms_settings")
                    Dim obj As New ConsolidatedGrades3
                    obj.SetDataSource(mysds.Tables("studeprofile, grades, srms_settings"))
                    obj.SetParameterValue("gradelevel", cboYearLevelAccount.Text)
                    obj.SetParameterValue("section", cboSection.Text)
                    obj.SetParameterValue("period", cboPeriod.Text)
                    frmMainViewer.ReportViewer.ReportSource = obj
                    frmMainViewer.ReportViewer.Refresh()
                    conn.Close()
                    frmMainViewer.MdiParent = frmParent
                    frmMainViewer.Show()
                    Me.Close()
                End If
            Else
                If rdoMale.Checked = True Then
                    str = "select p.StudentNumber, concat(p.LastName,', ',p.Firstname) as StudentName, p.Sex, g.SubjectCode, g.FGrade, g.Sem, g.SY, st.letterHead from studeprofile p join grades g on p.StudentNumber=g.StudentNumber join srms_settings st on p.settingsID=st.settingsID where g.Section='" & cboSection.Text & "' and g.Sem='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and p.Sex='Male'"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysda.Fill(mysds, "studeprofile, grades, srms_settings")
                    Dim obj As New ConsolidatedGrades4
                    obj.SetDataSource(mysds.Tables("studeprofile, grades, srms_settings"))
                    obj.SetParameterValue("gradelevel", cboYearLevelAccount.Text)
                    obj.SetParameterValue("section", cboSection.Text)
                    obj.SetParameterValue("period", cboPeriod.Text)
                    frmMainViewer.ReportViewer.ReportSource = obj
                    frmMainViewer.ReportViewer.Refresh()
                    conn.Close()
                    frmMainViewer.MdiParent = frmParent
                    frmMainViewer.Show()
                    Me.Close()
                Else
                    str = "select p.StudentNumber, concat(p.LastName,', ',p.Firstname) as StudentName, p.Sex, g.SubjectCode, g.FGrade, g.Sem, g.SY, st.letterHead from studeprofile p join grades g on p.StudentNumber=g.StudentNumber join srms_settings st on p.settingsID=st.settingsID where g.Section='" & cboSection.Text & "' and g.Sem='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and p.Sex='Female'"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysda.Fill(mysds, "studeprofile, grades, srms_settings")
                    Dim obj As New ConsolidatedGrades4
                    obj.SetDataSource(mysds.Tables("studeprofile, grades, srms_settings"))
                    obj.SetParameterValue("gradelevel", cboYearLevelAccount.Text)
                    obj.SetParameterValue("section", cboSection.Text)
                    obj.SetParameterValue("period", cboPeriod.Text)
                    frmMainViewer.ReportViewer.ReportSource = obj
                    frmMainViewer.ReportViewer.Refresh()
                    conn.Close()
                    frmMainViewer.MdiParent = frmParent
                    frmMainViewer.Show()
                    Me.Close()
                End If
                End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub cboPeriod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
End Class