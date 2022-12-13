Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.IO
Public Class frmParent
    Dim str As String

    Private Sub frmParent_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If (MsgBox("Are you sure you want to quit SRMS?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Parent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        schoolInfo()
        Me.Text = stSchool.Text
        dtpDate.Text = Convert.ToDateTime(Today).ToString("yyyy-MM-dd")
        LoginForm.ShowDialog()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAbout.Click
        About.Show()
    End Sub

    Private Sub BySubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BySubjectToolStripMenuItem.Click
        frmMasterList.Show()
    End Sub

    Private Sub ByCourseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByCourseToolStripMenuItem1.Click
        frmMasterlistDashboardbyCourse.ShowDialog()
    End Sub

    Private Sub StudentsAccountsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsAccountsToolStripMenuItem1.Click
        frmStudeAccount.Show()
    End Sub

    Private Sub DailyCollectionReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ExpensesReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpensesReportsToolStripMenuItem.Click
        frmExpReportDashobard.ShowDialog()
    End Sub

    Private Sub ScholarsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            str = "select concat(s.LName,', ',s.FName,' ',s.MName) as StudentName, p.Address, p.Guardian, p.GuardianAddress, p.GuardianContact, s.Course, s.Semester, s.Term, s.SY from semesterstude s join studeprofile p on s.StudentNumber=p.StudentNumber where s.Semester='" & lblSem.Text & "' and s.SY='" & lblSY.Text & "' order by StudentName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude")
            Dim obj As New SemesterStudeList
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub ByCourseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmInsurance.ShowDialog()
    End Sub

    Private Sub InputGradesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmInputGrades.Show()
    End Sub
    Private Sub StudentsAccountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsAccountsToolStripMenu.Click
        frmBilling.Show()
    End Sub

    Private Sub AccountPaymentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountPaymentsToolStripMenuItem.Click
        frmPayment.Show()
    End Sub

    Private Sub PaymentsOtherServicesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentsOtherServicesToolStripMenuItem1.Click
        frmOtherIncome.ShowDialog()
    End Sub

    Private Sub EditPaymentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmEditPayments.ShowDialog()
    End Sub

    Private Sub CourseFeesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseFeesToolStripMenuItem.Click
        frmFees.ShowDialog()
    End Sub

    Private Sub PromissoryNoteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromissoryNoteToolStripMenuItem1.Click
        frmPromissory.ShowDialog()
    End Sub

    Private Sub ExpensesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpensesToolStripMenuItem1.Click
        frmExpenses.ShowDialog()
    End Sub

    Private Sub SearchOfficialReceiptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchOfficialReceiptToolStripMenuItem.Click
        frmSearchOR.ShowDialog()
    End Sub

    Private Sub NewStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewStudentToolStripMenuItem.Click
        frmStudeProfile.Show()
    End Sub

    Private Sub SemesterStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SemesterStudentToolStripMenuItem.Click
        frmSemStudent.Show()
    End Sub

    Private Sub CertificateOfRegistrationToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CertificateOfRegistrationToolStripMenuItem2.Click
        frmCOR.Show()
    End Sub

    Private Sub PreviousSchoolFormToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPrevSchool.Show()
    End Sub

    Private Sub CoursesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoursesToolStripMenuItem1.Click
        frmCourses.Show()
    End Sub

    Private Sub SubjectsToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectsToolStripMenuItem2.Click
        frmSubjects.ShowDialog()
    End Sub

    Private Sub SemesterSchedulingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SemesterSchedulingToolStripMenuItem.Click
        frmSemSubjects.Show()
    End Sub

    Private Sub ScholarshipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScholarshipToolStripMenuItem.Click
        frmScholarship.Show()
    End Sub

    Private Sub ManageUserAcctsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageUserAcctsToolStripMenuItem.Click
        frmuseraccounts.ShowDialog()
    End Sub


    Private Sub ChangeSemesterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmChangeSemester.Click
        ChangeSem.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginForm.txtUserName.Clear()
        LoginForm.txtpassword.Clear()
        LoginForm.ShowDialog()
        LoginForm.txtUserName.Focus()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If (MsgBox("Are you sure you want to quit SRMS?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            End
        Else

        End If
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        frmuseraccounts.Show()
        frmuseraccounts.txtusername.Text = lblUser.Text
        frmuseraccounts.cboposition.Text = "Student"
        frmuseraccounts.cboposition.Enabled = False
        frmuseraccounts.txtusername.Enabled = False
        frmuseraccounts.btnSave.Enabled = False
        frmuseraccounts.btnDelete.Enabled = False
        frmuseraccounts.btnUpdate.Enabled = True
        frmuseraccounts.txtSearch.Enabled = False
        frmuseraccounts.dgUser.Enabled = False
    End Sub

    Private Sub StatementOfAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatementOfAccountToolStripMenuItem.Click
        Try
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, b.LecUnits, b.LecRate, b.LabUnits, b.LabRate, b.OldAccount, TotalLec, b.TotalLab, b.FeesDesc, b.FeesAmount, b.TotalFees, b.AcctTotal, b.Discount, b.CurrentBalance, b.TotalPayments, b.DiscPercentage, b.Sem, b.SY from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber where p.StudentNumber='" & lblUser.Text & "' and b.Sem='" & lblSem.Text & "' and b.SY='" & lblSY.Text & "'"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, studeaccount, payments")
            Dim obj As New SOA
            obj.SetDataSource(mysds.Tables("studeprofile, studeaccount, payments"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub PaymentHistoryToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentHistoryToolStripMenuItem2.Click
        Try
            str = "SELECT p.StudentNumber, concat(s.FirstName,' ',s.LastName) as sStudentName, s.PDate, s.ORNumber, s.Amount, s.Sem, s.SY FROM paymentsaccounts s join studeprofile p on p.StudentNumber=s.StudentNumber where p.StudentNumber='" & lblUser.Text & "' and s.Sem='" & lblSem.Text & "' and s.SY='" & lblSY.Text & "'"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, payments")
            Dim obj As New PaymentHistory
            obj.SetDataSource(mysds.Tables("studeprofile, payments"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub ReportOfGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportOfGradesToolStripMenuItem.Click
        Try
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudeName, p.BirthDate, p.BirthPlace, p.Guardian, ss.Course, ss.YearLevel, ss.Adviser, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.SY from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on ss.StudentNumber=g.StudentNumber where p.StudentNumber='" & lblUser.Text & "' and g.SY='" & lblSY.Text & "' and g.Sem='" & lblSem.Text & "' group by g.SubjectCode order by g.Description"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "p.studeprofile, r.registration, g.grades")
            Dim obj As New ReportofGrades
            obj.SetDataSource(mysds.Tables("p.studeprofile, r.registration, g.grades"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub CertificateOfRegistrationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CertificateOfRegistrationToolStripMenuItem1.Click
        Try
            str = "select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as Fullname, p.Sex, p.MobileNumber, p.BirthPlace, p.BirthDate, s.Course, s.YearLevel, r.SubjectCode, r.Description, (r.LecUnit+r.LabUnit) as Units, r.Section, ss.SchedTime, ss.Room, r.Sem, r.SY, r.Term, r.Instructor from registration r join semsubjects ss on ss.SubjectCode = r.SubjectCode join semesterstude s on s.StudentNumber = r.StudentNumber join studeprofile p on p.StudentNumber = r.StudentNumber join staff sf on sf.IDNumber=ss.IDNumber where p.StudentNumber = '" & lblUser.Text & "' and r.Sem = '" & lblSem.Text & "' and r.SY = '" & lblSY.Text & "' and ss.Semester = '" & lblSem.Text & "' and ss.SY = '" & lblSY.Text & "' group by r.SubjectCode, r.Description order by r.SubjectCode"
            conn.Open()
            Dim mysDa As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDa.Fill(mysds, "registration, studeprofile, semsubjects, semesterstude, staff")
            Dim obj As New COR
            obj.SetDataSource(mysds.Tables("registration, studeprofile, semsubjects, semesterstude, staff"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub ClearanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearanceToolStripMenuItem.Click
        Try
            str = "select r.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as Fullname, s.Course, s.YearLevel, r.Class, r.SubjectCode, r.Description, r.LecUnit, r.LabUnit, r.Section, ss.SchedTime, ss.LabTime, ss.Room, ss.Semester, ss.SY, s.Semester, s.SY, sf.Name from registration r join semsubjects ss on ss.SubjectCode = r.SubjectCode join semesterstude s on s.StudentNumber = r.StudentNumber join studeprofile p on p.StudentNumber = r.StudentNumber join staff sf on sf.IDNumber=ss.IDNumber where r.StudentNumber = '" & lblUser.Text & "' and r.Sem = '" & lblSem.Text & "' and r.SY = '" & lblSY.Text & "' and ss.Semester = '" & lblSem.Text & "' and ss.SY = '" & lblSY.Text & "' and s.Semester = '" & lblSem.Text & "' and s.SY = '" & lblSY.Text & "' group by r.SubjectCode order by r.SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "registration, studeprofile, semsubjects, semesterstude, staff")
            Dim obj As New Clearance
            obj.SetDataSource(ds.Tables("registration, studeprofile, semsubjects, semesterstude, staff"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem2.Click
        End
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoginForm.txtUserName.Clear()
        LoginForm.txtpassword.Clear()
        LoginForm.ShowDialog()
        LoginForm.txtUserName.Focus()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub


    Private Sub StudentsProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmStudeProfile.Show()
    End Sub

    Private Sub SemesterStudentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSemStudent.ShowDialog()
    End Sub

    Private Sub CertificateOfRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCOR.Show()
    End Sub

    Private Sub PreviousSchoolToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPrevSchool.Show()
    End Sub

    Private Sub SubjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSubjects.ShowDialog()
    End Sub

    Private Sub SemesterSubjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSemSubjects.ShowDialog()
    End Sub

    Private Sub StudentsAccountToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmBilling.Show()
    End Sub

    Private Sub FacultyLoadingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultyLoadingToolStripMenuItem1.Click
        frmLoading.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem2.Click
        LoginForm.txtUserName.Clear()
        LoginForm.txtpassword.Clear()
        LoginForm.ShowDialog()
        LoginForm.txtUserName.Focus()
    End Sub

    Private Sub IncomeStatementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncomeStatementToolStripMenuItem.Click
        frmIncomeStatement.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem3.Click
        End
    End Sub
    Private Sub ExitToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub tsFacultyLoading_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsFacultyLoading.Click
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select concat(FirstName,' ',MiddleName,' ',LastName) as Name from staff where IDNumber='" & lblUser.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblInstructor.Text = dtReader.Item(0)
            End If
            conn.Close()


            'str = "select s.SubjectCode, s.Description, s.SchedTime, s.LabTime, s.Room, s.SY, (s.LecUnit + s.LabUnit) as Units, s.Semester, i.IDNumber, concat(i.FirstName,' ',i.MiddleName,' ',i.LastName) from semsubjects s join staff i on s.IDNumber=i.IDNumber where i.Name='" & lblInstructor.Text & "' and s.Semester='" & lblSem.Text & "' and s.SY='" & lblSY.Text & "' group by s.SubjectCode, s.SchedTime, s.Room order by s.SubjectCode"
            str = "select s.SubjectCode, s.Description, s.Section, s.SchedTime, s.LabTime, s.Room, s.SY, (s.LecUnit + s.LabUnit) as Units, s.Semester, i.IDNumber, concat(i.FirstName,' ',i.LastName) as Name from semsubjects s join staff i on s.IDNumber=i.IDNumber where i.IDNumber='" & lblUser.Text & "' and s.Semester='" & lblSem.Text & "' and s.SY='" & lblSY.Text & "' group by s.SubjectCode, s.SchedTime, s.Room order by s.SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "i.staff, s.semsubjects")
            Dim obj As New WorkLoad
            obj.SetDataSource(ds.Tables("i.staff, s.semsubjects"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        frmPrintGradingSheet.Show()
    End Sub

    Private Sub tsSwitch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSwitch.Click
        ChangeSem.Show()
    End Sub

    Private Sub PrevGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPrevGrades.ShowDialog()
    End Sub

    Private Sub VoidOfficialReceiptsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoidOfficialReceiptsToolStripMenuItem.Click
        frmVoidOR.ShowDialog()
    End Sub

    Private Sub ORTrackingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ORTrackingToolStripMenuItem.Click
        frmCollectionSummaryDashboard.Show()
    End Sub

    Private Sub ScholarsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmScholarshipDashboard.Show()
    End Sub

    Private Sub ListOfVoidReceiptsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfVoidReceiptsToolStripMenuItem.Click
        frmVoidReport.ShowDialog()
    End Sub

    Private Sub SlotsMonitoringToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            str = "select r.SubjectCode, r.Description, count(*) as Enrolled, r.Section, r.Sem, r.SY, sr.SchoolName, sr.SchoolAddress from registration r join srms_settings sr on r.settingsID=sr.settingsID where r.Sem='" & lblSem.Text & "' and r.SY='" & lblSY.Text & "' group by r.SubjectCode, r.Section order by r.SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "registration")
            Dim obj As New SlotsMonitoring
            obj.SetDataSource(ds.Tables("registration"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub TuitionFeesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCourseFees.ShowDialog()
    End Sub

    Private Sub StudentsWithBalanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsWithBalanceToolStripMenuItem.Click
        Try
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.AcctTotal, b.TotalPayments, b.Discount, b.CurrentBalance, b.PaymentMode, b.Course, b.DateUpdated, b.YearLevel, b.Sem, b.SY from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber where b.Sem='" & lblSem.Text & "' and b.SY='" & lblSY.Text & "' and b.CurrentBalance>'0' group by p.StudentNumber order by Fullname"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "b.studeaccount, p.studeprofile")
            Dim obj As New StudeAccounts_All
            obj.SetDataSource(mysds.Tables("b.studeaccount, p.studeprofile"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub StudentsWithoutBalanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsWithoutBalanceToolStripMenuItem.Click
        Try
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.AcctTotal, b.TotalPayments, b.Discount, b.CurrentBalance, b.PaymentMode, b.Course, b.DateUpdated, b.YearLevel, b.Sem, b.SY from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber where b.Sem='" & lblSem.Text & "' and b.SY='" & lblSY.Text & "' and b.CurrentBalance<='0' group by p.StudentNumber order by Fullname"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "b.studeaccount, p.studeprofile")
            Dim obj As New StudeAccounts_All
            obj.SetDataSource(mysds.Tables("b.studeaccount, p.studeprofile"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub StudeSubjectsSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  frmstudeSubSummary.ShowDialog()
    End Sub

    Private Sub BySubjectToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BySubjectToolStripMenuItem1.Click
        frmMasterList.Show()
    End Sub

    Private Sub ByCourseToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByCourseToolStripMenuItem.Click
        frmMasterlistDashboardbyCourse.ShowDialog()
    End Sub

    Private Sub BySectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BySectionToolStripMenuItem.Click
        frmReportPerSection.ShowDialog()
    End Sub

    Private Sub BySectionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BySectionToolStripMenuItem1.Click
        frmReportPerSection.ShowDialog()
    End Sub


    Private Sub CollectionSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GradingSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradingSheetToolStripMenuItem.Click
        frmGradingSheets.Show()
    End Sub

    Private Sub tsInputGrades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsInputGrades.Click
        'frmInstructorInput.Show()
    End Sub

    Private Sub AcademicCalendarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            str = "select * from calendar where SY='" & lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "calendar")
            Dim obj As New ACalendar
            obj.SetDataSource(ds.Tables("calendar"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub RoomsAndSectionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomsAndSectionsToolStripMenuItem.Click
        frmRooms.Show()
    End Sub

    Private Sub CertificationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CertificationToolStripMenuItem.Click
        frmCertification.MdiParent = Me
        frmCertification.Show()
    End Sub
    Private Sub ClassRoomSchedulesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassRoomSchedulesToolStripMenuItem.Click
        frmRoomSched.ShowDialog()
    End Sub

    Private Sub OtherReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub OtherReportsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ByMunicipalityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByMunicipalityToolStripMenuItem.Click
        Try
            str = "select p.City, count(City), ss.Semester, ss.SY from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.Semester='" & lblSem.Text & "' and ss.SY='" & lblSY.Text & "' group by p.City order by p.City "
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            Dim obj As New PerMunChart
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ByReligionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByReligionToolStripMenuItem.Click
        Try
            str = "select p.Religion, count(Religion), ss.Semester, ss.SY from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.Semester='" & lblSem.Text & "' and ss.SY='" & lblSY.Text & "' group by p.Religion order by p.Religion"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            Dim obj As New ReligionChart
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ByEthnicityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByEthnicityToolStripMenuItem.Click
        Try
            str = "select p.Ethnicity, count(Ethnicity), ss.Semester, ss.SY from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.Semester='" & lblSem.Text & "' and ss.SY='" & lblSY.Text & "' group by p.Religion order by p.Ethnicity"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            Dim obj As New EthnicityChart
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ByEthnicityToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByEthnicityToolStripMenuItem1.Click
        Try
            frmSummary.Show()
            frmSummary.lblTitle.Text = "By Ethnicity"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub BySexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BySexToolStripMenuItem.Click
        Try
            frmSummary.Show()
            frmSummary.lblTitle.Text = "By Gender"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ByMunicipalityToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByMunicipalityToolStripMenuItem1.Click
        Try
            Try
                frmSummary.Show()
                frmSummary.lblTitle.Text = "By Municipality"
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                conn.Close()
            End Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ByReligionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByReligionToolStripMenuItem1.Click
        Try
            frmSummary.Show()
            frmSummary.lblTitle.Text = "By Religion"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub StudentsFinancialReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsFinancialReportToolStripMenuItem.Click
        frmStudeReport_Accounting.Show()
    End Sub

    Private Sub StudentsFinancialReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsFinancialReportsToolStripMenuItem.Click
        frmStudeReport_Accounting.Show()
    End Sub

    Private Sub ServicesDescriptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub OtherServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmOtherIncomDesc.ShowDialog()
    End Sub

    Private Sub PaymentDescriptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentDescriptionToolStripMenuItem.Click
        frmOtherIncomDesc.ShowDialog()
    End Sub

    Private Sub ReceiveGradingSheetsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiveGradingSheetsToolStripMenuItem.Click
        frmReceiveGradeSheets.Show()
    End Sub

    Private Sub JHSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JHSToolStripMenuItem.Click
        Try
            str = "select p.Sex, count(Sex), ss.Semester, ss.SY from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.SY='" & lblSY.Text & "' and ss.Course='Junior High School' group by p.Sex order by p.Sex"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            Dim obj As New Sex
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub SHSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHSToolStripMenuItem.Click
        Try
            str = "select p.Sex, count(Sex), ss.Semester, ss.SY from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.Semester='" & lblSem.Text & "' and ss.SY='" & lblSY.Text & "' and ss.Course='Senior High School' group by p.Sex order by p.Sex"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            Dim obj As New Sex
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub UploadForm137ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UploadForm137ToolStripMenuItem.Click
        'frmFileUploader.MdiParent = Me
        frmFileUploader.Show()
    End Sub



    Private Sub PerQualificationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerQualificationsToolStripMenuItem.Click
        frmPerSpecialization.Show()
    End Sub


    Private Sub CountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountsToolStripMenuItem.Click
        frmStatSummary.Show()
    End Sub

    Private Sub StudentsAgesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsAgesToolStripMenuItem.Click
        frmAgesReport.Show()
    End Sub

    Private Sub TestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSummary.Show()
        frmSummary.lblTitle.Text = "Test"
    End Sub

    Private Sub SchoolRegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchoolRegisterToolStripMenuItem.Click
        frmSchoolRegisterForm.Show()
    End Sub

    Private Sub ChangeSemesterToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeSemesterToolStripMenuItem.Click
        ChangeSem.ShowDialog()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        End
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        ChangeSem.ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        frmChangePassword.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        frmStudeGrades.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try

            'str = "select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, r.Sem, r.SY, r.Course, r.YearLevel, r.SubjectCode, r.Description, r.Section, (r.LecUnit+r.LabUnit) as Units, r.LabTime, r.SchedTime, r.Room, r.Instructor, sr.SchoolName, sr.SchoolAddress from studeprofile p join registration r on p.StudentNumber=r.StudentNumber join srms_settings sr on r.settingsID=sr.settingsID join semsubjects ss on ss.Instructor=r.Instructor where p.StudentNumber = '" & lblUser.Text & "' and r.Sem = '" & lblSem.Text & "' and r.SY = '" & lblSY.Text & "' and ss.Semester = '" & lblSem.Text & "' and ss.SY = '" & lblSY.Text & "' group by r.SubjectCode, r.Description order by r.SubjectCode"
            str = "select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, r.Sem, r.SY, r.Course, r.YearLevel, r.SubjectCode, r.Description, r.Section, (r.LecUnit+r.LabUnit) as Units, r.LabTime, r.SchedTime, r.Room, r.Instructor, sr.SchoolName, sr.SchoolAddress from studeprofile p join registration r on p.StudentNumber=r.StudentNumber join srms_settings sr on r.settingsID=sr.settingsID join semsubjects ss on ss.Instructor=r.Instructor where p.StudentNumber = '" & lblUser.Text & "' and r.Sem = '" & lblSem.Text & "' and r.SY = '" & lblSY.Text & "' and ss.Semester = '" & lblSem.Text & "' and ss.SY = '" & lblSY.Text & "' group by r.SubjectCode, r.Description order by r.SubjectCode"
            conn.Open()
            Dim mysDa As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDa.Fill(mysds, "registration, studeprofile, semsubjects, semesterstude, staff, srms_settings")
            Dim obj As New COR
            obj.SetDataSource(mysds.Tables("registration, studeprofile, semsubjects, semesterstude, staff, srms_settings"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        frmTeacherMasterList.Show()
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAdvisoryClass.Click
      
    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        If (MsgBox("Are you sure you want to quit SRMS?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            End
        Else

        End If
    End Sub

    Private Sub SchoolRegisterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchoolRegisterToolStripMenuItem1.Click
        frmSchoolRegisterForm.Show()
    End Sub

    Private Sub ByEthnicityToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByEthnicityToolStripMenuItem2.Click
        Try
            frmSummary.Show()
            frmSummary.lblTitle.Text = "By Ethnicity"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ByGenderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByGenderToolStripMenuItem.Click
        Try
            frmSummary.Show()
            frmSummary.lblTitle.Text = "By Gender"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ByMunicipalityToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByMunicipalityToolStripMenuItem2.Click
        Try
            Try
                frmSummary.Show()
                frmSummary.lblTitle.Text = "By Municipality"
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                conn.Close()
            End Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ByReligionToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByReligionToolStripMenuItem2.Click
        Try
            frmSummary.Show()
            frmSummary.lblTitle.Text = "By Religion"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub CountsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountsToolStripMenuItem1.Click
        frmStatSummary.Show()
    End Sub

    Private Sub StudentsAgesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsAgesToolStripMenuItem1.Click
        frmAgesReport.Show()
    End Sub

    Private Sub StudentsProfileToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsProfileToolStripMenuItem1.Click
        frmStudeProfile.Show()
    End Sub

    Private Sub StudentsEnrollmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsEnrollmentToolStripMenuItem.Click
        frmSemStudent.Show()
    End Sub

    Private Sub StudentsSubjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsSubjectsToolStripMenuItem.Click
        frmCOR.Show()
    End Sub

    Private Sub ByDepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByDepartmentToolStripMenuItem.Click
        Try
            str = "select ss.YearLevel, p.sex, count(p.sex) as sexCount, ss.Course, ss.Semester, ss.SY, st.SchoolName, st.SchoolAddress, st.letterHead from semesterstude ss join srms_settings st on ss.settingsID=st.settingsID join studeprofile p on p.StudentNumber=ss.StudentNumber where ss.SY='" & lblSY.Text & "' and ss.Semester!='2nd Sem.' and ss.Status='Enrolled' group by ss.YearLevel, p.Sex"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude")
            Dim obj As New EnrollmentSummaryReport
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub EntryFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryFormToolStripMenuItem.Click
        frmGatePass.Show()
    End Sub

    Private Sub ReportsToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem3.Click
        frmGatePassDashboard.Show()
    End Sub

    Private Sub ReportsToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem4.Click
        Try
            str = "select * from calendar where SY='" & lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "calendar")
            Dim obj As New ACalendar
            obj.SetDataSource(ds.Tables("calendar"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub EntryFormToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryFormToolStripMenuItem1.Click
        frmAcademic_Calendar.Show()
    End Sub

    Private Sub LockUnlockGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LockUnlockGradesToolStripMenuItem.Click
        frmLockUnlockGrades.Show()
    End Sub

    Private Sub BySubjectToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BySubjectToolStripMenuItem2.Click
        frmMasterList.Show()
    End Sub

    Private Sub ByDepartmentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByDepartmentToolStripMenuItem1.Click
        frmMasterlistDashboardbyCourse.ShowDialog()
    End Sub

    Private Sub BySectionToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BySectionToolStripMenuItem2.Click
        frmReportPerSection.ShowDialog()
    End Sub

    Private Sub BySpeicalizationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BySpeicalizationToolStripMenuItem.Click
        frmPerSpecialization.Show()
    End Sub

    Private Sub OtherReportsToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherReportsToolStripMenuItem2.Click
        frmStudeSpecialReport.ShowDialog()
    End Sub

    Private Sub AuthorityToTravelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuthorityToTravelToolStripMenuItem.Click
        'frmTravelOrder.MdiParent = Me
        frmTravelOrder.Show()
    End Sub

    Private Sub PersonnelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonnelToolStripMenuItem.Click
        frmStaff.Show()
    End Sub

    Private Sub StudentsReportToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsReportToolStripMenuItem.Click
        frmCertification.Show()
    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click


    End Sub
    Public Sub getFacultyName()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select concat(FirstName,' ',MiddleName,' ',LastName) as Name, empPosition from staff where IDNumber='" & lblUser.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                frmTravelOrder.txtName.Text = dtReader.Item(0)
                frmClassReplacement.txtName.Text = dtReader.Item(0)
                frmTravelOrder.txtPosition.Text = dtReader.Item(1)
                frmClassReplacement.txtPosition.Text = dtReader.Item(1)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub PrintDiplomaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintDiplomaToolStripMenuItem.Click
        frmDiploma.Show()
    End Sub

    Private Sub PrintDiplomaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintDiplomaToolStripMenuItem1.Click
        frmDiploma.Show()
    End Sub

    Private Sub DiplomaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiplomaToolStripMenuItem.Click
        frmDiploma.Show()
    End Sub


    Private Sub ApplicationFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplicationFormToolStripMenuItem.Click
        frmLeaveForm.Show()
    End Sub

    Private Sub TravelOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TravelOrderToolStripMenuItem.Click
        frmTravelOrder.Show()
        frmTravelOrder.txtEmployeeID.Text = lblUser.Text
        frmTravelOrder.Button1.Enabled = False
        getFacultyName()
        frmTravelOrder.getTravel()

        frmTravelOrder.tsSave.Enabled = True
        frmTravelOrder.tsUpdate.Enabled = False
        frmTravelOrder.tsDelete.Enabled = False
        frmTravelOrder.tsPrint.Enabled = False
    End Sub

    Private Sub LeaveFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeaveFormToolStripMenuItem.Click
        frmLeaveForm.Show()
    End Sub

    Public Sub schoolInfo()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from srms_settings limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(Str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                stSchool.Text = dtReader(5)
                stSchoolAddress.Text = dtReader(6)
                stSchool.TextAlign = ContentAlignment.MiddleCenter
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub SystemSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemSettingsToolStripMenuItem.Click
        frmSystemSettings.ShowDialog()
    End Sub

    Private Sub MyProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyProfileToolStripMenuItem.Click
        frmStaff.Show()

        frmStaff.mskIDNumber.Text = lblUser.Text
        frmStaff.lblIDNumber.Text = lblUser.Text
        frmStaff.tsSearch.Visible = False
        frmStaff.tsDelete.Visible = False
        frmStaff.tsSave.Visible = False
        frmStaff.tsUpdate.Enabled = True
        frmStaff.btnFamily.Enabled = True
        frmStaff.btnEduc.Enabled = True
        frmStaff.btnCSE.Enabled = True
        frmStaff.btnWe.Enabled = True
        frmStaff.btnVW.Enabled = True
        frmStaff.btnTrainings.Enabled = True
        frmStaff.btnOtherInfo.Enabled = True
        frmStaff.mskIDNumber.Enabled = False
        frmStaff.txtFirstName.Enabled = False
        frmStaff.txtLastName.Enabled = False

        frmStaff.getProfile()

    End Sub

    Private Sub TrackAndStrandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackAndStrandToolStripMenuItem.Click
        frmTrackandStrand.Show()
    End Sub

    Private Sub Backup1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Backup1ToolStripMenuItem.Click
        Try
            If Not Directory.Exists("d:\db_backup") Then
                Directory.CreateDirectory("d:\db_backup")
            End If

            Dim dateM, dateD, dateY, dateAll As String

            dateM = System.DateTime.Now.Month
            dateD = System.DateTime.Now.Day
            dateY = System.DateTime.Now.Year

            dateAll = dateM + "-" + dateD + "-" + dateY
            'Process.Start("C:\Program Files\MySQL\MySQL Server 5.0\bin\mysqldump.exe", "--user=deped_srms --password=compu7er  --host=localhost  --databases deped_srms -r ""D:\db_backup\" + dateAll + "-deped_srms.sql")
            Process.Start("C:\Program Files (x86)\MySQL\MySQL Server 5.4\bin\mysqldump.exe", "--user=root --password=compu7er  --host=localhost  --databases deped_srms -r ""D:\db_backup\" + dateAll + "-deped_srms.sql")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub Backup2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Backup2ToolStripMenuItem.Click
        Try
            If Not Directory.Exists("d:\db_backup") Then
                Directory.CreateDirectory("d:\db_backup")
            End If

            Dim dateM, dateD, dateY, dateAll As String

            dateM = System.DateTime.Now.Month
            dateD = System.DateTime.Now.Day
            dateY = System.DateTime.Now.Year

            dateAll = dateM + "-" + dateD + "-" + dateY
            Process.Start("C:\Program Files\MySQL\MySQL Server 5.0\bin\mysqldump.exe", "--user=deped_srms --password=compu7er  --host=localhost  --databases deped_srms -r ""D:\db_backup\" + dateAll + "-deped_srms.sql")
            'Process.Start("C:\Program Files (x86)\MySQL\MySQL Server 5.4\bin\mysqldump.exe", "--user=root --password=compu7er  --host=localhost  --databases deped_srms -r ""D:\db_backup\" + dateAll + "-deped_srms.sql")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub


    Private Sub OtherReportsToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherReportsToolStripMenuItem3.Click
        frmStudeSpecialReport.Show()
    End Sub

    Private Sub OtherReportsToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherReportsToolStripMenuItem.Click
        frmStudeSpecialReport.ShowDialog()
    End Sub


    Private Sub DeparmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCourses.ShowDialog()
    End Sub

    Private Sub PreviousSchoolsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousSchoolsToolStripMenuItem.Click
        frmPrevSchool.Show()
    End Sub

    Private Sub ToolStripButton8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        frmChangePassword.ShowDialog()
    End Sub

    Private Sub ChangeAdviserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeAdviserToolStripMenuItem.Click
        frmChangeAdvisers.Show()
    End Sub

    Private Sub BySpecializationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BySpecializationToolStripMenuItem.Click
        Try

            str = "select ss.YearLevel, mid(p.sex,1,1) as Sex, count(p.sex) as sexCount, ss.Course, ss.Track, ss.Qualification, ss.Semester, ss.SY, st.SchoolName, st.SchoolAddress, st.letterHead from semesterstude ss join srms_settings st on ss.settingsID=st.settingsID join studeprofile p on p.StudentNumber=ss.StudentNumber where ss.SY='" & lblSY.Text & "' and ss.Semester!='2nd Sem.' and ss.Status='Enrolled' group by ss.YearLevel, ss.Track, ss.Qualification, p.Sex"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude")
                Dim obj As New countPerTrack
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                frmMainViewer.MdiParent = Me
                frmMainViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ByNutritionalStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByNutritionalStatusToolStripMenuItem.Click
        frmReportNutStatus.ShowDialog()
    End Sub

    Private Sub ParentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParentsToolStripMenuItem.Click
        Try
            If lblSem.Text = "" Then
                str = "select p.Guardian, p.GuardianAddress, p.GuardianContact, concat(s.LName,', ',s.FName) as StudeName, s.YearLevel, s.Section, s.SY, st.SchoolName, st.SchoolAddress from studeprofile p join semesterstude s on p.StudentNumber=s.StudentNumber join srms_settings st on s.settingsID=st.settingsID where s.SY='" & lblSY.Text & "' order by p.Guardian"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude, srms_settings")
                Dim obj As New GuardianList
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude, srms_settings"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                frmMainViewer.MdiParent = Me
                frmMainViewer.Show()

            Else
                str = "select p.Guardian, p.GuardianAddress, p.GuardianContact, concat(s.LName,', ',s.FName) as StudeName, s.YearLevel, s.Section, s.SY, st.SchoolName, st.SchoolAddress from studeprofile p join semesterstude s on p.StudentNumber=s.StudentNumber join srms_settings st on s.settingsID=st.settingsID where s.SY='" & lblSY.Text & "' and s.Semester='" & lblSem.Text & "' order by p.Guardian"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude, srms_settings")
                Dim obj As New GuardianList
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude, srms_settings"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                frmMainViewer.MdiParent = Me
                frmMainViewer.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub PerYearLevelAndSectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerYearLevelAndSectionToolStripMenuItem.Click
        frmPerSpecialization.Show()
    End Sub

    Private Sub ClassReplacementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassReplacementToolStripMenuItem.Click
        frmClassReplacement.Show()
    End Sub

    Private Sub StGradingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StGradingToolStripMenuItem.Click
        frmFirstGrading.Show()
    End Sub

    Private Sub NdGradingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NdGradingToolStripMenuItem.Click
        frmSecondGrading.Show()
    End Sub

    Private Sub RdGradingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdGradingToolStripMenuItem.Click
        frmThirdGrading.Show()
    End Sub

    Private Sub ThGradingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThGradingToolStripMenuItem.Click
        frmFouthGrading.Show()
    End Sub

    Private Sub PerYearLevelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerYearLevelToolStripMenuItem.Click
        frmPerSpecializationYL.Show()
    End Sub

    Private Sub ByDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByDateToolStripMenuItem.Click
        frmCollectionDashboard.ShowDialog()
    End Sub

    Private Sub CollectionSummaryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollectionSummaryToolStripMenuItem1.Click
        frmCourseCollectionSummary.ShowDialog()
    End Sub

    Private Sub DirectoryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectoryToolStripMenuItem1.Click
        frmContactDirectory.ShowDialog()
    End Sub

    Private Sub ByPaymentDescriptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByPaymentDescriptionToolStripMenuItem.Click
        frmByDescription.Show()
    End Sub

    Private Sub ByCollectingOfficerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByCollectingOfficerToolStripMenuItem.Click
        frmCollectionSummaryDashboard.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        frmByDescriptionYL.Show()
    End Sub

    Private Sub CAVRequestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCAVReq.Show()
    End Sub

    Private Sub EncodeIndividualGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub InputGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmInputGrades.Show()
    End Sub

    Private Sub PaymentsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentsToolStripMenuItem1.Click
        frmPayment.Show()
    End Sub

    Private Sub CollectionReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollectionReportToolStripMenuItem.Click
        Try
            str = "SELECT StudentNumber, concat(LastName,', ',FirstName) as Payor,  Course, PDate, ORNumber, Amount, description, CheckNumber, Bank, ORStatus, Cashier, CollectionSource, PaymentType FROM paymentsaccounts where PDate='" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") & "' and ORStatus='Valid' and Cashier='" & lblUser.Text & "' order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "paymentsaccounts")
            Dim obj As New DailyCollections
            obj.SetDataSource(ds.Tables("paymentsaccounts"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ClassReplacementToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassReplacementToolStripMenuItem1.Click
        frmClassReplacement.Show()

        frmClassReplacement.txtEmployeeID.Text = lblUser.Text
        frmClassReplacement.Button1.Enabled = False
        getFacultyName()


        frmClassReplacement.tsSave.Enabled = True
        frmClassReplacement.tsUpdate.Enabled = False
        frmClassReplacement.tsDelete.Enabled = False
        'frmClassReplacement.tsPrint.Enabled = False
    End Sub

    Private Sub AdvisoryClassToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvisoryClassToolStripMenuItem.Click
        Try

            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select concat(FirstName,' ',MiddleName,' ',LastName) as Name from staff where IDNumber='" & lblUser.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()

            If dtReader.Read Then
                lblInstructor.Text = dtReader.Item(0)
            End If
            conn.Close()


            'str = "Select s.StudentNumber, concat(s.LName,', ',s.FName,' ',s.MName) as Fullname, s.Course, s.YearLevel, s.Status, s.Scholarship, s.Semester, s.SY, s.Term, s.Section, s.semstudentid, p.Sex, s.Adviser, s.Track, s.Qualification from semesterstude s join studeprofile p on s.StudentNumber=p.StudentNumber where s.Semester='" & lblSem.Text & "' and s.SY='" & lblSY.Text & "' and s.Adviser='" & lblInstructor.Text & "' order by p.Sex, Fullname"
            str = "Select s.StudentNumber, concat(s.LName,', ',s.FName,' ',s.MName) as Fullname, s.Course, s.YearLevel, s.Status, s.Scholarship, s.Semester, s.SY, s.Term, s.Section, s.semstudentid, p.Sex, s.Adviser, s.Track, s.Qualification, sr.SchoolName, sr.SchoolAddress, sr.letterHead from semesterstude s join studeprofile p on s.StudentNumber=p.StudentNumber join srms_settings sr on s.settingsID=sr.settingsID where s.Semester='" & lblSem.Text & "' and s.SY='" & lblSY.Text & "' and s.Adviser='" & lblInstructor.Text & "' order by p.Sex, Fullname"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "semesterstude")
            Dim obj As New ListPerSection
            obj.SetDataSource(mysds.Tables("semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub ConsolidatedGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsolidatedGradesToolStripMenuItem.Click
        frmConsolidatedDashboard.Show()
    End Sub

    Private Sub ItemsProductEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemsProductEntryToolStripMenuItem.Click
        frmProducts.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Try
            str = "SELECT i.ctrlNo, i.itemName, i.description, i.itemCondition, i.accountable, i.acquiredDate, ss.Division, ss.SchoolName, ss.SchoolAddress, ss.SchoolHead, ss.sHeadPosition, ss.PropertyCustodian, ss.letterHead FROM ls_items i join srms_settings ss on i.settingsID=ss.settingsID order by i.itemName, i.description"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "ls_items")
            Dim obj As New itemsList2
            obj.SetDataSource(mysds.Tables("ls_items"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub PhysicalCountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhysicalCountsToolStripMenuItem.Click
        frmPhysicalCount.Show()
    End Sub

    Private Sub PARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PARToolStripMenuItem.Click
        frmMRDashboard.Show()
    End Sub

    Private Sub ConsolidatedGradesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsolidatedGradesToolStripMenuItem1.Click
        frmConsolidatedDashboard.Show()
    End Sub

    Private Sub GoodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoodToolStripMenuItem.Click
        Try
            str = "SELECT i.ctrlNo, i.itemName, i.description, i.itemCondition, i.accountable, i.acquiredDate, ss.Division, ss.SchoolName, ss.SchoolAddress, ss.SchoolHead, ss.sHeadPosition, ss.PropertyCustodian, ss.letterHead FROM ls_items i join srms_settings ss on i.settingsID=ss.settingsID where i.itemCondition='Good' order by i.itemName, i.description"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "ls_items")
            Dim obj As New itemsList2
            obj.SetDataSource(mysds.Tables("ls_items"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub DefectiveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefectiveToolStripMenuItem.Click
        Try
            str = "SELECT i.ctrlNo, i.itemName, i.description, i.itemCondition, i.accountable, i.acquiredDate, ss.Division, ss.SchoolName, ss.SchoolAddress, ss.SchoolHead, ss.sHeadPosition, ss.PropertyCustodian, ss.letterHead FROM ls_items i join srms_settings ss on i.settingsID=ss.settingsID where i.itemCondition='Defective' order by i.itemName, i.description"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "ls_items")
            Dim obj As New itemsList2
            obj.SetDataSource(mysds.Tables("ls_items"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub BooksEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BooksEntryToolStripMenuItem.Click
        frmBooksInfo.Show()
    End Sub

    Private Sub SearchBooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBooksToolStripMenuItem.Click
        frmSearchBooksMain.Show()
    End Sub

    Private Sub CompleteListOfBooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompleteListOfBooksToolStripMenuItem.Click
        Try
            str = "select BookID, Title, Author, CallNum, count(Title) as Copies from libbookentry group by Title, Author order by Title"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libbookentry")
            Dim obj As New CompleteList
            obj.SetDataSource(ds.Tables("libbookentry"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsLogOut.Click
        LoginForm.txtUserName.Clear()
        LoginForm.txtpassword.Clear()
        LoginForm.ShowDialog()
        LoginForm.txtUserName.Focus()
    End Sub

    Private Sub tsTeacherLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsTeacherLogout.Click
        LoginForm.txtUserName.Clear()
        LoginForm.txtpassword.Clear()
        LoginForm.ShowDialog()
        LoginForm.txtUserName.Focus()
    End Sub

    Private Sub EncodeGradesSpecialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncodeGradesSpecialToolStripMenuItem.Click
        frmEncodeGrades.Show()
    End Sub

    Private Sub StGradingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StGradingToolStripMenuItem1.Click
        frmFirstGrading.Show()
    End Sub

    Private Sub NdGradingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NdGradingToolStripMenuItem1.Click
        frmSecondGrading.Show()
    End Sub

    Private Sub RdGradingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdGradingToolStripMenuItem1.Click
        frmThirdGrading.Show()
    End Sub

    Private Sub ThGradingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThGradingToolStripMenuItem1.Click
        frmFouthGrading.Show()
    End Sub

    Private Sub ModifyGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmModifyGrades.Show()
    End Sub

    Private Sub ModifyGradesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmModifyGrades.ShowDialog()
    End Sub

    Private Sub BrandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrandToolStripMenuItem.Click
        Brand.Show()
    End Sub


    Private Sub BatchPrintingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatchPrintingToolStripMenuItem.Click
        frmGradesBatchPrinting.Show()
    End Sub

    Private Sub RemoveStudentFromGradingSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveStudentFromGradingSheetToolStripMenuItem.Click
        frmModifyGrades.Show()
    End Sub

    Private Sub BatchPrintingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatchPrintingToolStripMenuItem1.Click
        frmGradesBatchPrinting.Show()
    End Sub

    Private Sub ChangeSubjectTeacherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmChangeTeacher.Show()
    End Sub
End Class