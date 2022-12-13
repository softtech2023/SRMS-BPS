Imports MySql.Data.MySqlClient
Public Class frmPerSpecialization
    Dim str As String
  
    Public Sub getQualification()
        Try

            str = "select * from qualifications group by Qualification order by Qualification"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "qualifications")
            conn.Close()

            cboQualification.ValueMember = "Qualification"
            cboQualification.DisplayMember = "Qualification"
            cboQualification.DataSource = ds.Tables("qualifications")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub FormLoad()
        getSection()
        getQualification()
    End Sub

    Private Sub frmPerSpecialization_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Try
            If frmParent.lblSem.Text = "" Then
                If cboSection.Text = "" Then
                    str = "select p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, p.Sex, p.BirthDate, p.Age, p.MobileNumber, ss.Course, ss.YearLevel, ss.Semester, ss.SY, ss.Section, ss.Track, ss.Qualification, ss.BalikAral, ss.IP, ss.FourPs, st.Division, st.Region, st.SchoolName, st.SchoolAddress, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.SY='" & frmParent.lblSY.Text & "' and ss.Track='" & cboQualification.Text & "' and ss.YearLevel='" & cboYearLevel.Text & "' and ss.Status='Enrolled' order by p.LastName"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim ds As New DataSet
                    mysda.Fill(ds, "semesterstude,studeprofile")
                    Dim obj As New PerSpecializationReport
                    obj.SetDataSource(ds.Tables("semesterstude,studeprofile"))
                    frmMainViewer.ReportViewer.ReportSource = obj
                    frmMainViewer.ReportViewer.Refresh()
                    conn.Close()
                    frmMainViewer.MdiParent = frmParent
                    frmMainViewer.Show()
                    Me.Hide()
                Else
                    str = "select p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, p.Sex, p.BirthDate, p.Age, p.MobileNumber, ss.Course, ss.YearLevel, ss.Semester, ss.SY, ss.Section, ss.Track, ss.Qualification, ss.BalikAral, ss.IP, ss.FourPs, st.Division, st.Region, st.SchoolName, st.SchoolAddress,st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.SY='" & frmParent.lblSY.Text & "' and ss.Qualification='" & cboQualification.Text & "' and ss.YearLevel='" & cboYearLevel.Text & "' and ss.Section='" & cboSection.Text & "' and ss.Status='Enrolled' order by p.LastName"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim ds As New DataSet
                    mysda.Fill(ds, "semesterstude, studeprofile")
                    Dim obj As New PerSpecializationReport
                    obj.SetDataSource(ds.Tables("semesterstude, studeprofile"))
                    frmMainViewer.ReportViewer.ReportSource = obj
                    frmMainViewer.ReportViewer.Refresh()
                    conn.Close()
                    frmMainViewer.MdiParent = frmParent
                    frmMainViewer.Show()
                    Me.Hide()
                End If
            Else
                If cboSection.Text = "" Then
                    str = "select p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, p.Sex, p.BirthDate, p.Age, p.MobileNumber, ss.Course, ss.YearLevel, ss.Semester, ss.SY, ss.Section, ss.Track, ss.Qualification, ss.BalikAral, ss.IP, ss.FourPs, st.Division, st.Region, st.SchoolName, st.SchoolAddress, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.SY='" & frmParent.lblSY.Text & "' and ss.Semester='" & frmParent.lblSem.Text & "' and ss.Track='" & cboQualification.Text & "' and ss.YearLevel='" & cboYearLevel.Text & "' order by p.LastName"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim ds As New DataSet
                    mysda.Fill(ds, "semesterstude,studeprofile")
                    Dim obj As New PerSpecializationReport
                    obj.SetDataSource(ds.Tables("semesterstude,studeprofile"))
                    frmMainViewer.ReportViewer.ReportSource = obj
                    frmMainViewer.ReportViewer.Refresh()
                    conn.Close()
                    frmMainViewer.MdiParent = frmParent
                    frmMainViewer.Show()
                    Me.Hide()
                Else
                    str = "select p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, p.Sex, p.BirthDate, p.Age, p.MobileNumber, ss.Course, ss.YearLevel, ss.Semester, ss.SY, ss.Section, ss.Track, ss.Qualification, ss.BalikAral, ss.IP, ss.FourPs, st.Division, st.Region, st.SchoolName, st.SchoolAddress, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.SY='" & frmParent.lblSY.Text & "' and ss.Semester='" & frmParent.lblSem.Text & "' and ss.Qualification='" & cboQualification.Text & "' and ss.YearLevel='" & cboYearLevel.Text & "' and ss.Section='" & cboSection.Text & "' order by p.LastName"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim ds As New DataSet
                    mysda.Fill(ds, "semesterstude, studeprofile")
                    Dim obj As New PerSpecializationReport
                    obj.SetDataSource(ds.Tables("semesterstude, studeprofile"))
                    frmMainViewer.ReportViewer.ReportSource = obj
                    frmMainViewer.ReportViewer.Refresh()
                    conn.Close()
                    frmMainViewer.MdiParent = frmParent
                    frmMainViewer.Show()
                    Me.Hide()
                End If
            End If
            

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub getSection()
        Try
            str = "select * from semesterstude where YearLevel='" & cboYearLevel.Text & "' group by Section order by Section"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude")
            conn.Close()

            cboSection.ValueMember = "semesterstude"
            cboSection.DisplayMember = "Section"
            cboSection.DataSource = ds.Tables("semesterstude")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboYearLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYearLevel.SelectedIndexChanged
        getSection()
    End Sub

End Class