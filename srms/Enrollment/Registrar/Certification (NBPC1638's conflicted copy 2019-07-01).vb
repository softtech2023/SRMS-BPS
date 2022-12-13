Imports MySql.Data.MySqlClient
Public Class frmCertification
    Dim str As String

    Private Sub btnStudeReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudeReport.Click
        If mskStudentNumber.Text = "" Then
            MsgBox("Please enter Student Number!", MsgBoxStyle.Information)
            Exit Sub
            mskStudentNumber.Focus()
        End If

        Try
            'COR
            If cboStudeReport.SelectedIndex = 0 Then
                'str = "select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as Fullname, p.Sex, p.MobileNumber, p.BirthPlace, p.BirthDate, r.Course, r.YearLevel, r.SubjectCode, r.Description, (r.LecUnit+r.LabUnit) as Units, r.Section, ss.SchedTime, ss.Room, r.Sem, r.SY, r.Term, r.Instructor from registration r join semsubjects ss on ss.SubjectCode = r.SubjectCode join semesterstude s on s.StudentNumber = r.StudentNumber join studeprofile p on p.StudentNumber = r.StudentNumber join staff sf on sf.IDNumber=ss.IDNumber where p.StudentNumber = '" & mskStudentNumber.Text & "' and r.Sem = '" & frmParent.lblSem.Text & "' and r.SY = '" & frmParent.lblSY.Text & "' and ss.Semester = '" & frmParent.lblSem.Text & "' and ss.SY = '" & frmParent.lblSY.Text & "' group by r.SubjectCode, r.Description order by r.SubjectCode"
                str = "select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, r.Sem, r.SY, r.Course, r.YearLevel, r.SubjectCode, r.Description, r.Section, (r.LecUnit+r.LabUnit) as Units, r.LabTime, r.SchedTime, r.Room, r.Instructor, sr.SchoolName, sr.SchoolAddress, sr.letterHead from studeprofile p join registration r on p.StudentNumber=r.StudentNumber join srms_settings sr on r.settingsID=sr.settingsID join semsubjects ss on ss.Instructor=r.Instructor where p.StudentNumber = '" & mskStudentNumber.Text & "' and r.Sem = '" & frmParent.lblSem.Text & "' and r.SY = '" & frmParent.lblSY.Text & "' and ss.Semester = '" & frmParent.lblSem.Text & "' and ss.SY = '" & frmParent.lblSY.Text & "' group by r.SubjectCode, r.Description order by r.SubjectCode"
                conn.Open()
                Dim mysDa As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDa.Fill(mysds, "registration, studeprofile, semsubjects, semesterstude, staff")
                Dim obj As New COR
                obj.SetDataSource(mysds.Tables("registration, studeprofile, semsubjects, semesterstude, staff"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()
            End If

            'Cert. of Good Moral Character
            If cboStudeReport.SelectedIndex = 1 Then
                str = "select ss.semstudentid, ss.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, p.LastName, p.Title, p.Pronoun, p.Pronoun2, p.Pronoun3, ss.Course, ss.YearLevel, ss.Semester, ss.SY, sr.SchoolName, sr.SchoolAddress, sr.GuidanceJHS, sr.SchoolHead, sr.sHeadPosition, sr.letterHead from semesterstude ss join studeprofile p on ss.StudentNumber=p.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where ss.StudentNumber='" & mskStudentNumber.Text & "' order by ss.semstudentid desc limit 1"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude")
                Dim obj As New GoodMoral
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()


            End If

            'Clearance
            If cboStudeReport.SelectedIndex = 2 Then
                str = "select r.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as Fullname, s.Course, s.YearLevel, r.SubjectCode, r.Description, r.LecUnit, r.LabUnit, r.Section, ss.SchedTime, ss.LabTime, ss.Room, ss.Semester, ss.SY, s.Semester, s.SY, concat(sf.FirstName,' ',sf.LastName) as Instructor, sr.SchoolName, sr.SchoolAddress, sr.letterHead from registration r join semsubjects ss on ss.SubjectCode = r.SubjectCode join semesterstude s on s.StudentNumber = r.StudentNumber join studeprofile p on p.StudentNumber = r.StudentNumber join staff sf on sf.IDNumber=ss.IDNumber join srms_settings sr on p.settingsID=sr.settingsID where r.StudentNumber = '" & mskStudentNumber.Text & "' and r.Sem = '" & frmParent.lblSem.Text & "' and r.SY = '" & frmParent.lblSY.Text & "' and ss.Semester = '" & frmParent.lblSem.Text & "' and ss.SY = '" & frmParent.lblSY.Text & "' and s.Semester = '" & frmParent.lblSem.Text & "' and s.SY = '" & frmParent.lblSY.Text & "' group by r.SubjectCode order by r.SubjectCode"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "registration, studeprofile, semsubjects, semesterstude, staff")
                Dim obj As New Clearance
                obj.SetDataSource(ds.Tables("registration, studeprofile, semsubjects, semesterstude, staff"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()

            End If

            'Report of Grades
            If cboStudeReport.SelectedIndex = 3 Then
                If frmParent.lblSem.Text = "1st Sem." Or frmParent.lblSem.Text = "2nd Sem." Then
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
                Else
                    str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudeName, p.Sex, p.BirthDate, p.Age, p.BirthPlace, p.Guardian, ss.Course, ss.YearLevel, ss.Adviser, ss.Section, ss.Track, ss.Qualification, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.SY, sr.SchoolName, sr.SchoolAddress, sr.SchoolHead, sr.sHeadPosition,sr.Division,sr.Region, sr.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on ss.StudentNumber=g.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Semester='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and g.Sem='" & frmParent.lblSem.Text & "'  group by g.SubjectCode order by g.Description"
                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysDA.Fill(mysds, "p.studeprofile, g.grades, ss.semesterstude")
                    Dim obj As New ReportOfGradesJHS
                    obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades, ss.semesterstude"))
                    frmMainViewer.ReportViewer.ReportSource = obj
                    specialReportViewer.ReportSource = obj
                    specialReportViewer.Refresh()
                    conn.Close()
                End If

            End If


                'Student's Profile
                If cboStudeReport.SelectedIndex = 4 Then
                str = "SELECT * FROM studeprofile s join semesterstude ss on s.StudentNumber=ss.StudentNumber join srms_settings st on s.settingsID=st.settingsID join profimage pi on s.StudentNumber=pi.StudentNumber where ss.StudentNumber='" & mskStudentNumber.Text & "' and ss.SY='" & frmParent.lblSY.Text & "'"
                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysDA.Fill(mysds, "studeprofile")
                    Dim obj As New StudeProfile
                    obj.SetDataSource(mysds.Tables("studeprofile"))
                    specialReportViewer.ReportSource = obj
                    specialReportViewer.Refresh()
                    conn.Close()
                End If

                'Report Card
            If cboStudeReport.SelectedIndex = 5 Then
                If frmParent.lblSem.Text = "1st Sem." Or frmParent.lblSem.Text = "2nd Sem." Then
                    str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudeName, p.Sex, p.BirthDate, p.Age, p.BirthPlace, p.Guardian, ss.Course, ss.YearLevel, ss.Adviser, ss.Section, ss.Track, ss.Qualification, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.SY, sr.SchoolName, sr.SchoolAddress, sr.SchoolHead, sr.sHeadPosition,sr.Division,sr.Region, sr.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on ss.StudentNumber=g.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Semester='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and g.Sem='" & frmParent.lblSem.Text & "'  group by g.SubjectCode order by g.Description"
                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysDA.Fill(mysds, "p.studeprofile, g.grades, ss.semesterstude")
                    Dim obj As New ReportCardSHS
                    obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades, ss.semesterstude"))
                    frmMainViewer.ReportViewer.ReportSource = obj
                    specialReportViewer.ReportSource = obj
                    specialReportViewer.Refresh()
                    conn.Close()
                Else
                    str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudeName, p.Sex, p.BirthDate, p.Age, p.BirthPlace, p.Guardian, ss.Course, ss.YearLevel, ss.Adviser, ss.Section, ss.Track, ss.Qualification, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.SY, sr.SchoolName, sr.SchoolAddress, sr.SchoolHead, sr.sHeadPosition,sr.Division,sr.Region, sr.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on ss.StudentNumber=g.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Semester='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and g.Sem='" & frmParent.lblSem.Text & "'  group by g.SubjectCode order by g.Description"
                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysDA.Fill(mysds, "p.studeprofile, g.grades, ss.semesterstude")
                    Dim obj As New ReportCard
                    obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades, ss.semesterstude"))
                    frmMainViewer.ReportViewer.ReportSource = obj
                    specialReportViewer.ReportSource = obj
                    specialReportViewer.Refresh()
                    conn.Close()
                End If
            End If

            'Scholastic Record
            If cboStudeReport.SelectedIndex = 6 Then
                If frmParent.lblSem.Text = "1st Sem." Or frmParent.lblSem.Text = "2nd Sem." Then
                    str = "select p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, pi.profImage, p.BirthPlace, p.BirthDate, p.Guardian, p.GuardianAddress, p.Sex, p.guardianOccupation, p.Elementary, p.ElemAddress, p.elemSY, p.HighSchool, p.HSAddress, p.elemAve, p.shsEligibility, p.jhsAve, p.jhsGradDate, jhsExamDate, g.YearLevel, g.SchoolName, ss.Semester, concat(g.Sem,', ',g.SY) as batch, g.Sem ,g.SY,g.track, g.strand, g.adviser, g.Section, ss.Qualification, ss.Adviser, ss.Semester as SemSem, ss.SY as SemSY, g.SubjectCode, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, st.SchoolName, st.SchoolAddress, st.Division, st.SchoolIDSHS, st.SchoolIDJHS, st.SchoolHead, st.sHeadPosition, st.RegistrarSHS, st.RegistrarJHS, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on p.StudentNumber=g.StudentNumber join srms_settings st on p.settingsID=st.settingsID join classdays cd on st.settingsID=cd.settingsID join profimage pi on p.StudentNumber=pi.StudentNumber where p.StudentNumber='" & mskStudentNumber.Text & "' group by g.SubjectCode, g.SY, g.Sem order by g.SY, g.Sem"
                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysDA.Fill(mysds, "studeprofile, grades, semesterstude, srms_settings")
                    Dim obj As New TOR
                    obj.SetDataSource(mysds.Tables("studeprofile, grades, semesterstude, srms_settings"))
                    specialReportViewer.ReportSource = obj
                    specialReportViewer.Refresh()
                    conn.Close()
                Else
                    'str = "select p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, p.ImagePath, p.BirthPlace, p.BirthDate, p.Guardian, p.GuardianAddress, p.Sex, g.YearLevel, g.SchoolName, ss.Semester, g.Sem ,g.SY, ss.Track, ss.Section, ss.Qualification, ss.Adviser, ss.Semester as SemSem, ss.SY as SemSY, g.SubjectCode, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, st.SchoolName, st.SchoolAddress, st.Division, st.SchoolIDSHS, st.SchoolIDJHS, st.SchoolHead, st.sHeadPosition, st.RegistrarSHS, st.RegistrarJHS, cd.jun from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on p.StudentNumber=g.StudentNumber join srms_settings st on p.settingsID=st.settingsID join classdays cd on st.settingsID=cd.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "' group by g.SubjectCode order by g.SY, g.Sem, g.Description"
                    str = "select p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, p.ImagePath, p.BirthPlace, p.BirthDate, p.Guardian, p.GuardianAddress, p.Sex, p.guardianOccupation, p.Elementary, p.ElemAddress, p.elemSY, p.HighSchool, p.HSAddress, p.elemAve, p.shsEligibility, p.jhsAve, p.jhsGradDate, jhsExamDate, g.YearLevel, g.SchoolName, ss.Semester, g.Sem ,g.SY, ss.Track, g.Section, ss.Qualification, ss.Adviser, ss.Semester as SemSem, ss.SY as SemSY, g.SubjectCode, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, st.SchoolName, st.SchoolAddress, st.Division, st.SchoolIDSHS, st.SchoolIDJHS, st.SchoolHead, st.sHeadPosition, st.RegistrarSHS, st.RegistrarJHS, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on p.StudentNumber=g.StudentNumber join srms_settings st on p.settingsID=st.settingsID join classdays cd on st.settingsID=cd.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "' group by g.SubjectCode order by g.SY, g.Sem, g.Description"
                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysDA.Fill(mysds, "studeprofile, grades, semesterstude, srms_settings")
                    Dim obj As New TORJHS1
                    obj.SetDataSource(mysds.Tables("studeprofile, grades, semesterstude, srms_settings"))
                    specialReportViewer.ReportSource = obj
                    specialReportViewer.Refresh()
                    conn.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub mskStudentNumber_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskStudentNumber.Click
        frmQSearch.ShowDialog()
    End Sub
    Public Sub getStudeName()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select concat(FirstName,' ',MiddleName,' ',LastName) as StudeName from studeprofile where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtName.Text = dtReader(0)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub mskStudentNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskStudentNumber.TextChanged
        getStudeName()
    End Sub

End Class