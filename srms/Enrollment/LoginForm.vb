Imports MySql.Data.MySqlClient
Public Class LoginForm
    Dim str As String

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim level As String
        str = "select * from users where username='" & txtusername.Text & "' and password='" & txtPassword.Text & "'"
        conn.Open()
        Dim mysda As New MySqlDataAdapter(Str, conn)
        Dim ds As New DataSet
        mysda.Fill(ds, "users")

        ' MsgBox(level, MsgBoxStyle.Information)

        If ds.Tables("users").Rows.Count = 1 Then
            level = ds.Tables("users").Rows(0).Item(3)
            If level.Equals("Admin") Then
                frmMain.btnManageUsers.Enabled = True
                frmMain.CoursesToolStripMenuItem.Enabled = True
                frmMain.FacultyAndStaffToolStripMenuItem.Enabled = True
                frmMain.CurriculumToolStripMenuItem.Enabled = True
                frmMain.btnEnrollStudent.Enabled = True
                frmMain.btnAddSemStudent.Enabled = True
                frmMain.btnAddNewStudent.Enabled = True
                frmMain.StaffToolStripMenuItem1.Enabled = True
                frmMain.SubjectsToolStripMenuItem.Enabled = True
                frmMain.SemesterSubjectsToolStripMenuItem.Enabled = True
                frmMain.NewToolStripMenuItem.Enabled = True
                frmMain.SubjectsToolStripMenuItem1.Enabled = True
                frmMain.SemSubjectsToolStripMenuItem.Enabled = True
                frmMain.StudentsToolStripMenuItem.Enabled = True

            End If
            If level.Equals("Registrar") Then
                frmMain.btnManageUsers.Enabled = False
                frmMain.CoursesToolStripMenuItem.Enabled = False
                frmMain.FacultyAndStaffToolStripMenuItem.Enabled = False
            End If
            If level.Equals("Admission") Then
                frmMain.btnManageUsers.Enabled = False
                frmMain.CoursesToolStripMenuItem.Enabled = False
                frmMain.FacultyAndStaffToolStripMenuItem.Enabled = False
                frmMain.CurriculumToolStripMenuItem.Enabled = False
            End If
            If level.Equals("Instructor") Then
                frmMain.btnManageUsers.Enabled = False
                frmMain.CoursesToolStripMenuItem.Enabled = False
                frmMain.FacultyAndStaffToolStripMenuItem.Enabled = False
                frmMain.CurriculumToolStripMenuItem.Enabled = False
                frmMain.btnEnrollStudent.Enabled = False
                frmMain.btnAddSemStudent.Enabled = False
                frmMain.btnAddNewStudent.Enabled = False
                frmMain.StaffToolStripMenuItem1.Enabled = False
                frmMain.SubjectsToolStripMenuItem.Enabled = False
                frmMain.SemesterSubjectsToolStripMenuItem.Enabled = False
                frmMain.NewToolStripMenuItem.Enabled = False
                frmMain.SubjectsToolStripMenuItem1.Enabled = False
                frmMain.SemSubjectsToolStripMenuItem.Enabled = False
                frmMain.StudentsToolStripMenuItem.Enabled = False

            End If
            frmMain.lblUser.Text = txtusername.Text
            ChangeSem.ShowDialog()
            Me.Hide()

        Else
            MsgBox("Access Denied", MsgBoxStyle.Information)
            txtusername.Clear()
            txtpassword.Clear()
            conn.Close()
            Exit Sub

        End If
        conn.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        
    End Sub
End Class
