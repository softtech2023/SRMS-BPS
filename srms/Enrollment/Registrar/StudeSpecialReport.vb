Imports MySql.Data.MySqlClient
Public Class frmStudeSpecialReport
    Dim str As String
    Private Sub frmStudeSpecialReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.Religion' table. You can move, or remove it, as needed.
        Me.ReligionTableAdapter.Fill(Me.DataSet2.Religion)
        'TODO: This line of code loads data into the 'DataSet2.ethnicity' table. You can move, or remove it, as needed.
        Me.EthnicityTableAdapter.Fill(Me.DataSet2.ethnicity)
        'TODO: This line of code loads data into the 'DataSet2.ethnicity' table. You can move, or remove it, as needed.
        Me.EthnicityTableAdapter.Fill(Me.DataSet2.ethnicity)
        'TODO: This line of code loads data into the 'DataSet2.City' table. You can move, or remove it, as needed.
        Me.CityTableAdapter.Fill(Me.DataSet2.City)
        'TODO: This line of code loads data into the 'DataSet2.province' table. You can move, or remove it, as needed.
        Me.ProvinceTableAdapter.Fill(Me.DataSet2.province)

    End Sub

    Private Sub btnPreviewProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviewProv.Click
        Try
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as StudeName, p.Sex, p.Ethnicity, p.Province, p.City, p.Brgy, ss.Course, ss.YearLevel, ss.Semester, ss.SY, sr.SchoolName, sr.SchoolAddress from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and p.Province='" & cboProvince.Text & "' order by StudeName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            Dim obj As New ListbyProvince
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
            specialReportViewer.ReportSource = obj
            specialReportViewer.Refresh()

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnPreviewCity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviewCity.Click
        Try
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as StudeName, p.Sex, p.Ethnicity, p.Province, p.City, p.Brgy, ss.Course, ss.YearLevel, ss.Semester, ss.SY, sr.SchoolName, sr.SchoolAddress from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and p.City='" & cboCity.Text & "' order by StudeName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            Dim obj As New ListByCity
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
            specialReportViewer.ReportSource = obj
            specialReportViewer.Refresh()

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnPreviewEthnicity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviewEthnicity.Click
        Try
            'str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as StudeName, p.Sex, p.Ethnicity, p.Province, p.City, p.Brgy, ss.Course, ss.YearLevel, ss.Semester, ss.SY from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and p.Ethnicity='" & cboEthnicity.Text & "' order by StudeName"
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as StudeName, p.Sex, p.Ethnicity, p.Province, p.City, p.Brgy, ss.Course, ss.YearLevel, ss.Semester, ss.SY, sr.SchoolName, sr.SchoolAddress from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and p.Ethnicity='" & cboEthnicity.Text & "' order by StudeName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            Dim obj As New ListByEthnicity
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
            specialReportViewer.ReportSource = obj
            specialReportViewer.Refresh()

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub


    Private Sub btnPreviewReligion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviewReligion.Click
        Try
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as StudeName, p.Sex, p.Ethnicity, p.Province, p.City, p.Brgy, ss.Course, ss.YearLevel, ss.Semester, ss.SY, sr.SchoolName, sr.SchoolAddress from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and p.Religion='" & cboReligion.Text & "' order by StudeName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            Dim obj As New ListByReligion
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
            specialReportViewer.ReportSource = obj
            specialReportViewer.Refresh()

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class