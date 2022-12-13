Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmMDIParent
    Dim str As String


    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub StudentsProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmStudeProfile.MdiParent = Me
        frmStudeProfile.Show()
    End Sub

    Private Sub SemesterStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSemStudent.MdiParent = Me
        frmSemStudent.Show()
    End Sub

    Private Sub StudentsDirectoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmDirectory.MdiParent = Me
        frmDirectory.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginForm.ShowDialog()
        LoginForm.txtusername.Clear()
        LoginForm.txtpassword.Clear()
        LoginForm.txtusername.Focus()

    End Sub

    Private Sub ChangeSemesterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeSemesterToolStripMenuItem.Click
        ChangeSem.ShowDialog()
    End Sub

    Private Sub BackupDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub ToolStripButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsProfile.Click
        frmStudeProfile.MdiParent = Me
        frmStudeProfile.Show()
    End Sub

    Private Sub ToolStripButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSemesterStude.Click
        frmSemStudent.MdiParent = Me
        frmSemStudent.Show()
    End Sub

    Private Sub ToolStripButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsStudeAccounts.Click
        frmBilling.MdiParent = Me
        frmBilling.Show()
    End Sub

    Private Sub ToolStripButton23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUserAccounts.Click
        frmuseraccounts.ShowDialog()
    End Sub

    Private Sub ToolStripButton24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsMasterList.Click
        frmClassList.MdiParent = Me
        frmClassList.Show()
    End Sub

    Private Sub ToolStripButton25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsCOR.Click
        frmCertofRegistration.MdiParent = Me
        frmCertofRegistration.Show()
    End Sub

    Private Sub ToolStripButton32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSubjects.Click
        frmSubjects.MdiParent = Me
        frmSubjects.Show()
    End Sub

    Private Sub ToolStripButton33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsScheduling.Click
        frmSemSubjects.MdiParent = Me
        frmSemSubjects.Show()
    End Sub

    Private Sub ToolStripButton26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsInputGrades.Click
        frmInputGrades.MdiParent = Me
        frmInputGrades.Show()
    End Sub

    Private Sub FacultyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultyToolStripMenuItem.Click
        frmStaff.MdiParent = Me
        frmStaff.Show()
    End Sub

    Private Sub CoursesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoursesToolStripMenuItem1.Click
        frmCourses.MdiParent = Me
        frmCourses.Show()
    End Sub

    Private Sub SubjectsToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectsToolStripMenuItem2.Click
        frmSubjects.MdiParent = Me
        frmSubjects.Show()
    End Sub

    Private Sub SemesterSchedulingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SemesterSchedulingToolStripMenuItem.Click
        frmSemSubjects.MdiParent = Me
        frmSemSubjects.Show()
    End Sub

    Private Sub CurriculumToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurriculumToolStripMenuItem1.Click
        frmCurriculum.MdiParent = Me
        frmCurriculum.Show()
    End Sub

    Private Sub MasterlistToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterlistToolStripMenuItem1.Click
        frmClassList.MdiParent = Me
        frmClassList.Show()
    End Sub

    Private Sub ManageUserAcctsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageUserAcctsToolStripMenuItem.Click
        frmuseraccounts.ShowDialog()
    End Sub

    Private Sub NewStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewStudentToolStripMenuItem.Click
        frmStudeProfile.MdiParent = Me
        frmStudeProfile.Show()
    End Sub

    Private Sub SemesterStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SemesterStudentToolStripMenuItem.Click
        frmSemStudent.MdiParent = Me
        frmSemStudent.Show()
    End Sub

    Private Sub CertificateOfRegistrationToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CertificateOfRegistrationToolStripMenuItem2.Click
        frmCOR.MdiParent = Me
        frmCOR.Show()

    End Sub

    Private Sub ListOfStudentsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfStudentsToolStripMenuItem1.Click
        frmStudents.MdiParent = Me
        frmStudents.Show()
    End Sub

    Private Sub EnrollmentSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrollmentSummaryToolStripMenuItem.Click
        frmEnrollmentSummary.MdiParent = Me
        frmEnrollmentSummary.Show()
    End Sub

    Private Sub NewAccountToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewAccountToolStripMenuItem1.Click
        frmBilling.MdiParent = Me
        frmBilling.Show()
    End Sub

    Private Sub PaymentHistoryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentHistoryToolStripMenuItem1.Click
        frmpaymenthistory.MdiParent = Me
        frmpaymenthistory.Show()
    End Sub

    Private Sub FeesDescriptionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeesDescriptionToolStripMenuItem1.Click
        frmFees.MdiParent = Me
        frmFees.Show()
    End Sub

    Private Sub CertificateOfRegistrationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CertificateOfRegistrationToolStripMenuItem1.Click
        frmCertofRegistration.MdiParent = Me
        frmCertofRegistration.Show()
    End Sub

    Private Sub InputGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputGradesToolStripMenuItem.Click
        frmInputGrades.MdiParent = Me
        frmInputGrades.Show()
    End Sub

    Private Sub ReportOfGradesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportOfGradesToolStripMenuItem1.Click
        frmReportofGrades.MdiParent = Me
        frmReportofGrades.Show()
    End Sub

    Private Sub TranscriptOfRecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TranscriptOfRecordsToolStripMenuItem.Click
        frmTOR.MdiParent = Me
        frmTOR.Show()
    End Sub

    Private Sub StudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsToolStripMenuItem.Click
        frmDirectory.MdiParent = Me
        frmDirectory.Show()
    End Sub

    Private Sub StaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffToolStripMenuItem.Click
        DirectoryStaff.MdiParent = Me
        DirectoryStaff.Show()
    End Sub

    Private Sub ToolStripButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCOR.MdiParent = Me
        frmCOR.Show()
    End Sub

    Private Sub frmMDIParent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoginForm.ShowDialog()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub ToolStripButton30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbackup.Click
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

    Private Sub ToolStripButton29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsListofStudents.Click
        frmStudents.MdiParent = Me
        frmStudents.Show()
    End Sub

    Private Sub ToolStripButton28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsTranscript.Click
        frmTOR.MdiParent = Me
        frmTOR.Show()
    End Sub

    Private Sub ToolStripButton27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsReportGrades.Click
        frmReportofGrades.MdiParent = Me
        frmReportofGrades.Show()
    End Sub

    Private Sub BackupDatabaseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub NewWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()


    End Sub
    Private m_ChildFormNumber As Integer

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next

    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub DailyCollectionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyCollectionsToolStripMenuItem.Click
        frmDailyCollectionReport.MdiParent = Me
        frmDailyCollectionReport.Show()
    End Sub

    Private Sub ListOfStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfStudentsToolStripMenuItem.Click
        frmStudents.MdiParent = Me
        frmStudents.Show()
    End Sub

    Private Sub EnrollmentSummaryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrollmentSummaryToolStripMenuItem1.Click
        frmEnrollmentSummary.MdiParent = Me
        frmEnrollmentSummary.Show()
    End Sub

    Private Sub PaymentHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentHistoryToolStripMenuItem.Click
        frmpaymenthistory.MdiParent = Me
        frmpaymenthistory.Show()
    End Sub

    Private Sub DailyCollectionReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyCollectionReportToolStripMenuItem.Click
        frmDailyCollectionReport.MdiParent = Me
        frmDailyCollectionReport.Show()
    End Sub

    Private Sub CertificateOfRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CertificateOfRegistrationToolStripMenuItem.Click
        frmCertofRegistration.MdiParent = Me
        frmCertofRegistration.Show()
    End Sub

    Private Sub ReportOfGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportOfGradesToolStripMenuItem.Click
        frmReportofGrades.MdiParent = Me
        frmReportofGrades.Show()
    End Sub

    Private Sub TranscriptOfRecordsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TranscriptOfRecordsToolStripMenuItem1.Click
        frmTOR.MdiParent = Me
        frmTOR.Show()
    End Sub

    Private Sub MasterlistToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterlistToolStripMenuItem.Click
        frmClassList.MdiParent = Me
        frmClassList.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AboutBox1.ShowDialog()
    End Sub

    Private Sub MyGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyGradesToolStripMenuItem.Click
        frmStudeReport.MdiParent = Me
        frmStudeReport.Show()


    End Sub

    Private Sub MyAccountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyAccountsToolStripMenuItem.Click
        StudePayment.MdiParent = Me
        StudePayment.Show()
    End Sub

    Private Sub MaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaintenanceToolStripMenuItem.Click
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

    Private Sub InquiryFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InquiryFormToolStripMenuItem.Click
        frmInquirySheet.MdiParent = Me
        frmInquirySheet.Show()
    End Sub

    Private Sub ShortcutKeysToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShortcutKeysToolStripMenuItem.Click




    End Sub

    
End Class