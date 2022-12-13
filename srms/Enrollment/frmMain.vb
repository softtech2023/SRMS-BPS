Public Class frmMain

    Private Sub StudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmStudeProfile.Show()
    End Sub

    Private Sub StudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsToolStripMenuItem.Click
        frmSearchStudents.Show()
    End Sub

    Private Sub StaffToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffToolStripMenuItem1.Click
        frmSearchStaff.Show()
    End Sub

    Private Sub StaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmStaff.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        frmStudeProfile.Show()
    End Sub

    Private Sub FacultyAndStaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultyAndStaffToolStripMenuItem.Click
        frmStaff.Show()
    End Sub

    Private Sub CoursesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoursesToolStripMenuItem.Click
        frmCourses.Show()
    End Sub

    Private Sub CurriculumToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurriculumToolStripMenuItem.Click
        frmCurriculum.Show()
    End Sub

    Private Sub SubjectsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectsToolStripMenuItem1.Click
        frmSubjects.Show()
    End Sub

    Private Sub SemSubectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SemSubjectsToolStripMenuItem.Click
        frmSemSubjects.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSemStudent.Click
        frmSemStudent.Show()
    End Sub

    Private Sub SubjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectsToolStripMenuItem.Click
        frmSearchSubjects.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnrollStudent.Click
        frmCOR.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManageUsers.Click
        frmuseraccounts.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewStudent.Click
        frmStudeProfile.Show()
    End Sub

    Private Sub ChangeSemesterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeSemesterToolStripMenuItem.Click
        ChangeSem.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginForm.Show()
        LoginForm.txtusername.Clear()
        LoginForm.txtpassword.Clear()
        LoginForm.txtusername.Focus()


    End Sub

    

    Private Sub SemesterSubjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SemesterSubjectsToolStripMenuItem.Click
        frmSearchSemSubjects.Show()
    End Sub

    Private Sub lblSem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSem.Click

    End Sub

    Private Sub btnInputGrades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInputGrades.Click
        frmInputGrades.Show()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
