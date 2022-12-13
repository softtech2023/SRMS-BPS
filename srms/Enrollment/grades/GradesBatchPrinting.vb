Imports MySql.Data.MySqlClient
Public Class frmGradesBatchPrinting
    Dim str As String
    Public Sub getSection()
        Try
            Str = "select * from sections where YearLevel='" & cboYearLevel.Text & "' order by Section"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "sections")
            conn.Close()

            cboSection.ValueMember = "sections"
            cboSection.DisplayMember = "Section"
            cboSection.DataSource = ds.Tables("sections")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getCourse()
        Try
            If frmParent.lblSem.Text = "1st Sem." Or frmParent.lblSem.Text = "2nd Sem." Then
                str = "select * from course_table where CourseDescription='Senior High School' group by CourseDescription order by CourseDescription"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "course_table")
                conn.Close()

                cboCourse.ValueMember = "course_table"
                cboCourse.DisplayMember = "CourseDescription"
                cboCourse.DataSource = ds.Tables("course_table")
                conn.Close()
            Else
                str = "select * from course_table where CourseDescription!='Senior High School' group by CourseDescription order by CourseDescription"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "course_table")
                conn.Close()

                cboCourse.ValueMember = "course_table"
                cboCourse.DisplayMember = "CourseDescription"
                cboCourse.DataSource = ds.Tables("course_table")
                conn.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getCourseMajor()
        Try
            str = "select * from course_table where CourseDescription='" & cboCourse.Text & "' order by Major"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "course_table")
            conn.Close()
            cboYearLevel.ValueMember = "course_table"
            cboYearLevel.DisplayMember = "Major"
            cboYearLevel.DataSource = ds.Tables("course_table")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmGradesBatchPrinting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getCourse()
    End Sub

    Private Sub cboCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCourse.SelectedIndexChanged
        getCourseMajor()
    End Sub

    Private Sub cboYearLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYearLevel.SelectedIndexChanged
        getSection()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "select * from semesterstude where Course='" & cboCourse.Text & "' and YearLevel='" & cboYearLevel.Text & "' and Section='" & cboSection.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' order by LName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude")
            dg1.DataSource = ds.Tables("semesterstude")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Student Number"
            dg1.Columns(2).HeaderText = "First Name"
            dg1.Columns(2).Width = 150
            dg1.Columns(3).HeaderText = "Middle Name"
            dg1.Columns(3).Width = 150
            dg1.Columns(4).HeaderText = "Last Name"
            dg1.Columns(4).Width = 150

            dg1.Columns(5).Visible = False
            dg1.Columns(6).Visible = False
            dg1.Columns(7).Visible = False
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False
            dg1.Columns(10).Visible = False
            dg1.Columns(11).Visible = False
            dg1.Columns(12).Visible = False
            dg1.Columns(13).Visible = False
            dg1.Columns(14).Visible = False
            dg1.Columns(15).Visible = False
            dg1.Columns(16).Visible = False
            dg1.Columns(17).Visible = False
            dg1.Columns(18).Visible = False
            dg1.Columns(19).Visible = False
            dg1.Columns(20).Visible = False
            dg1.Columns(21).Visible = False
            dg1.Columns(22).Visible = False
            dg1.Columns(23).Visible = False
            dg1.Columns(24).Visible = False
            dg1.Columns(25).Visible = False
            dg1.Columns(26).Visible = False
            dg1.Columns(27).Visible = False
            dg1.Columns(28).Visible = False
            dg1.Columns(30).Visible = False
            dg1.Columns(31).Visible = False
            dg1.Columns(32).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try

            If frmParent.lblSem.Text = "1st Sem." Or frmParent.lblSem.Text = "2nd Sem." Then
                For x As Integer = 0 To dg1.Rows.Count - 1
                    str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudeName, p.Sex, p.BirthDate, p.Age, p.BirthPlace, p.Guardian, ss.Course, ss.YearLevel, ss.Adviser, ss.Section, ss.Track, ss.Qualification, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.SY, sr.SchoolName, sr.SchoolAddress, sr.SchoolHead, sr.sHeadPosition,sr.Division,sr.Region, sr.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on ss.StudentNumber=g.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where p.StudentNumber='" & dg1.Item(1, x).Value & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Semester='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and g.Sem='" & frmParent.lblSem.Text & "'  group by g.SubjectCode order by g.Description"
                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysDA.Fill(mysds, "p.studeprofile, g.grades, ss.semesterstude")
                    Dim obj As New ReportofGrades
                    obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades, ss.semesterstude"))
                    frmMainViewer.ReportViewer.ReportSource = obj
                    frmMainViewer.ReportViewer.Refresh()
                    conn.Close()
                    PrintDialog1.AllowSomePages = True
                    obj.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, PrintDialog1.PrinterSettings.FromPage, PrintDialog1.PrinterSettings.ToPage)
                Next
            Else
                For x As Integer = 0 To dg1.Rows.Count - 1
                    str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudeName, p.Sex, p.BirthDate, p.Age, p.BirthPlace, p.Guardian, ss.Course, ss.YearLevel, ss.Adviser, ss.Section, ss.Track, ss.Qualification, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.SY, sr.SchoolName, sr.SchoolAddress, sr.SchoolHead, sr.sHeadPosition,sr.Division,sr.Region, sr.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on ss.StudentNumber=g.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where p.StudentNumber='" & dg1.Item(1, x).Value & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Semester='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and g.Sem='" & frmParent.lblSem.Text & "'  group by g.SubjectCode order by g.Description"
                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysDA.Fill(mysds, "p.studeprofile, g.grades, ss.semesterstude")
                    Dim obj As New ReportOfGradesJHS
                    obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades, ss.semesterstude"))
                    frmMainViewer.ReportViewer.ReportSource = obj
                    frmMainViewer.ReportViewer.Refresh()
                    conn.Close()
                    PrintDialog1.AllowSomePages = True
                    obj.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, PrintDialog1.PrinterSettings.FromPage, PrintDialog1.PrinterSettings.ToPage)
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            For x As Integer = 0 To dg1.Rows.Count - 1
                str = "SELECT * FROM studeprofile s join semesterstude ss on s.StudentNumber=ss.StudentNumber join srms_settings st on s.settingsID=st.settingsID join profimage pi on s.StudentNumber=pi.StudentNumber where ss.StudentNumber='" & dg1.Item(1, x).Value & "' and ss.SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile")
                Dim obj As New StudeProfile
                obj.SetDataSource(mysds.Tables("studeprofile"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                PrintDialog1.AllowSomePages = True
                obj.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, PrintDialog1.PrinterSettings.FromPage, PrintDialog1.PrinterSettings.ToPage)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If frmParent.lblSem.Text = "1st Sem." Or frmParent.lblSem.Text = "2nd Sem." Then
                For x As Integer = 0 To dg1.Rows.Count - 1
                    str = "select p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, pi.profImage, p.BirthPlace, p.BirthDate, p.Guardian, p.GuardianAddress, p.Sex, p.guardianOccupation, p.Elementary, p.ElemAddress, p.elemSY, p.HighSchool, p.HSAddress, p.elemAve, p.shsEligibility, p.jhsAve, p.jhsGradDate, jhsExamDate, g.YearLevel, g.SchoolName, ss.Semester, concat(g.Sem,', ',g.SY) as batch, g.Sem ,g.SY,g.track, g.strand, g.adviser, g.Section, ss.Qualification, ss.Adviser, ss.Semester as SemSem, ss.SY as SemSY, g.SubjectCode, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, st.SchoolName, st.SchoolAddress, st.Division, st.SchoolIDSHS, st.SchoolIDJHS, st.SchoolHead, st.sHeadPosition, st.RegistrarSHS, st.RegistrarJHS, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on p.StudentNumber=g.StudentNumber join srms_settings st on p.settingsID=st.settingsID join classdays cd on st.settingsID=cd.settingsID join profimage pi on p.StudentNumber=pi.StudentNumber where p.StudentNumber='" & dg1.Item(1, x).Value & "' group by g.SubjectCode, g.SY, g.Sem order by g.SY, g.Sem"
                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysDA.Fill(mysds, "studeprofile, grades, semesterstude, srms_settings")
                    Dim obj As New TOR
                    obj.SetDataSource(mysds.Tables("studeprofile, grades, semesterstude, srms_settings"))
                    frmMainViewer.ReportViewer.ReportSource = obj
                    frmMainViewer.ReportViewer.Refresh()
                    conn.Close()
                    PrintDialog1.AllowSomePages = True
                    obj.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, PrintDialog1.PrinterSettings.FromPage, PrintDialog1.PrinterSettings.ToPage)
                Next
            Else
                For x As Integer = 0 To dg1.Rows.Count - 1
                    str = "select p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, p.ImagePath, p.BirthPlace, p.BirthDate, p.Guardian, p.GuardianAddress, p.Sex, p.guardianOccupation, p.Elementary, p.ElemAddress, p.elemSY, p.HighSchool, p.HSAddress, p.elemAve, p.shsEligibility, p.jhsAve, p.jhsGradDate, jhsExamDate, g.YearLevel, g.SchoolName, ss.Semester, g.Sem ,g.SY, ss.Track, g.Section, ss.Qualification, ss.Adviser, ss.Semester as SemSem, ss.SY as SemSY, g.SubjectCode, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, st.SchoolName, st.SchoolAddress, st.Division, st.SchoolIDSHS, st.SchoolIDJHS, st.SchoolHead, st.sHeadPosition, st.RegistrarSHS, st.RegistrarJHS, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on p.StudentNumber=g.StudentNumber join srms_settings st on p.settingsID=st.settingsID join classdays cd on st.settingsID=cd.settingsID where p.StudentNumber='" & dg1.Item(1, x).Value & "' group by g.SubjectCode order by g.SY, g.Sem, g.Description"
                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysDA.Fill(mysds, "studeprofile, grades, semesterstude, srms_settings")
                    Dim obj As New TORJHS1
                    obj.SetDataSource(mysds.Tables("studeprofile, grades, semesterstude, srms_settings"))
                    frmMainViewer.ReportViewer.ReportSource = obj
                    frmMainViewer.ReportViewer.Refresh()
                    conn.Close()
                    PrintDialog1.AllowSomePages = True
                    obj.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, PrintDialog1.PrinterSettings.FromPage, PrintDialog1.PrinterSettings.ToPage)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class