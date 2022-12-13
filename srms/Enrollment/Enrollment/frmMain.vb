Imports MySql.Data.MySqlClient
Public Class frmMain
    Dim str As String

    Private Sub StudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmStudeProfile.Show()
    End Sub

    Private Sub StudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSearchStudents.Show()
    End Sub

    Private Sub StaffToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub StaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmStaff.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmStudeProfile.Show()
    End Sub

    Private Sub FacultyAndStaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmStaff.Show()
    End Sub

    Private Sub CoursesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCourses.Show()
    End Sub

    Private Sub CurriculumToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCurriculum.Show()
    End Sub

    Private Sub SubjectsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSubjects.Show()
    End Sub

    Private Sub SemSubectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSemSubjects.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSemStudent.Show()
    End Sub

    Private Sub SubjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSearchSubjects.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCOR.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmuseraccounts.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmStudeProfile.Show()
    End Sub

    Private Sub ChangeSemesterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeSemesterToolStripMenuItem.Click
        ChangeSem.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        LoginForm.Show()
        LoginForm.txtusername.Clear()
        LoginForm.txtpassword.Clear()
        LoginForm.txtusername.Focus()


    End Sub



    Private Sub SemesterSubjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSearchSemSubjects.Show()
    End Sub

    Private Sub lblSem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSem.Click

    End Sub

    Private Sub btnInputGrades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmInputGrades.Show()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub StudentsContactsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSearchSemesterStudent.Show()
    End Sub

    Private Sub SemesterStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSemStudent.Show()
    End Sub

    Private Sub NewAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmBilling.Show()
    End Sub

    Private Sub FeesDescriptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmFees.Show()
    End Sub

    Private Sub PaymentHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmReports.Show()
    End Sub

    

    Private Sub MasterListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmClassList.Show()
    End Sub

    Private Sub TranscriptOfReocrdsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmTOR.Show()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListOfStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmStudents.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoginForm.Show()
        Me.Hide()
        LoginForm.txtusername.Clear()
        LoginForm.txtpassword.Clear()
        LoginForm.txtusername.Focus()
    End Sub

    Private Sub CertificateOfRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCertofRegistration.Show()
    End Sub

    Private Sub SemesterSchedulingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SemesterSchedulingToolStripMenuItem.Click
        frmSemSubjects.Show()
    End Sub

    Private Sub NewAccountToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewAccountToolStripMenuItem1.Click
        frmBilling.Show()
    End Sub

    Private Sub FeesDescriptionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeesDescriptionToolStripMenuItem1.Click
        frmFees.Show()
    End Sub

    Private Sub PaymentHistoryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentHistoryToolStripMenuItem1.Click
        frmReports.Show()
    End Sub

    Private Sub NewStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewStudentToolStripMenuItem.Click
        frmStudeProfile.Show()
    End Sub

    Private Sub SemesterStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SemesterStudentToolStripMenuItem.Click
        frmSemStudent.Show()
    End Sub

    Private Sub CurriculumToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurriculumToolStripMenuItem1.Click
        frmCurriculum.Show()
    End Sub

    Private Sub CoursesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoursesToolStripMenuItem1.Click
        frmCourses.Show()
    End Sub

    Private Sub FacultyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultyToolStripMenuItem.Click
        frmStaff.Show()

    End Sub

    Private Sub MasterlistToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterlistToolStripMenuItem1.Click
        frmClassList.Show()
    End Sub

    Private Sub CertificateOfRegistrationToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CertificateOfRegistrationToolStripMenuItem2.Click
        frmCertofRegistration.Show()
    End Sub

    Private Sub CertificateOfRegistrationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CertificateOfRegistrationToolStripMenuItem1.Click
        frmCertofRegistration.Show()
    End Sub

    Private Sub ReportOfGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListOfStudentsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfStudentsToolStripMenuItem1.Click
        frmStudents.Show()
    End Sub

    Private Sub TranscriptOfRecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TranscriptOfRecordsToolStripMenuItem.Click
        frmTOR.Show()
    End Sub

    Private Sub InputGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputGradesToolStripMenuItem.Click
        frmInputGrades.Show()
    End Sub

    Private Sub SubjectsToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectsToolStripMenuItem2.Click
        frmSubjects.Show()
    End Sub

    Private Sub InputGradesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmInputGrades.Show()
    End Sub

    Private Sub ManageUserAcctsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageUserAcctsToolStripMenuItem.Click
        frmuseraccounts.Show()
    End Sub

    Private Sub DirectoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectoryToolStripMenuItem.Click

    End Sub

    Private Sub StudentsToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsToolStripMenuItem.Click
        frmDirectory.Show()
    End Sub

    Private Sub StaffToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffToolStripMenuItem.Click
        DirectoryStaff.Show()
    End Sub

    Private Sub ReportOfGradesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportOfGradesToolStripMenuItem1.Click
        frmReportofGrades.Show()
    End Sub

    Private Sub BackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        frmStudeProfile.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        frmSemStudent.Show()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        frmCOR.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        frmStudentAccounts.Show()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        frmInputGrades.Show()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        frmuseraccounts.Show()
    End Sub

    Private Sub ToolStripContainer1_ContentPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Dim dateM, dateD, dateY, dateAll As String

        dateM = System.DateTime.Now.Month
        dateD = System.DateTime.Now.Day
        dateY = System.DateTime.Now.Year

        Try

            dateAll = dateM + "_" + dateD + "_" + dateY


            Process.Start("C:\Program Files\MySQL\MySQL Server 5.0\bin\mysqldump.exe", "(mysqldump -u user_name -p your_password database_name > ""D:\backup\" + dateAll + "-aclcenrollment.sql")

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        frmClassList.Show()
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        frmCertofRegistration.Show()
    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        frmReportofGrades.Show()
    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        frmTOR.Show()
    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click
        frmStudents.Show()
    End Sub

    Private Sub BackupDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupDatabaseToolStripMenuItem.Click
        Dim dateM, dateD, dateY, dateAll As String

        dateM = System.DateTime.Now.Month
        dateD = System.DateTime.Now.Day
        dateY = System.DateTime.Now.Year

        Try

            dateAll = dateM + "_" + dateD + "_" + dateY


            Process.Start("C:\Program Files\MySQL\MySQL Server 5.0\bin\mysqldump.exe", "--user=root --password=  --host=localhost  --databases aclcenrollment -r ""D:\aclc_backup\" + dateAll + "-enrollment.sql")

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub lblUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUser.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub lblSY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSY.Click

    End Sub

    Private Sub Label4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub ToolStripButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DirectoryStaff.Show()
    End Sub

    Private Sub ToolStripButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmDirectory.Show()
    End Sub

    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click
        frmSubjects.Show()
    End Sub

    Private Sub ToolStripButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton15.Click
        frmSemSubjects.Show()
    End Sub

    Private Sub ToolStripStatusLabel1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub EnrollmentSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrollmentSummaryToolStripMenuItem.Click
        frmEnrollmentSummary.Show()
    End Sub

    Private Sub ToolStripButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton18.Click
        frmMDIParent.Show()
    End Sub

    Private Sub ToolStripButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton19.Click
        frmDirectory.Show()
    End Sub

    Private Sub ToolStripButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton20.Click
        DirectoryStaff.Show()
    End Sub
End Class
