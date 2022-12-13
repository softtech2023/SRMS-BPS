Imports MySql.Data.MySqlClient
Public Class frmReportsMain
    Dim str As String
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudeReport.Click
        If mskStudentNumber.Text = "" Then
            MsgBox("Please enter Student Number!", MsgBoxStyle.Information)
            Exit Sub
            mskStudentNumber.Focus()
        End If

        Try
            If cboStudeReport.SelectedIndex = 0 Then
                str = "select b.TotalAccount, b.CurrentAccount, b.TotalPayments, p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as Fullname, p.Sex, p.MobileNumber, p.Address, p.BirthPlace, p.BirthDate, s.Course, s.YearLevel, r.Class, r.SubjectCode, r.Description, r.LecUnit, r.LabUnit, r.Section, ss.SchedDay, ss.SchedTime, ss.Room, r.Sem, r.SY, r.Term, sf.Name from registration r join semsubjects ss on ss.SubjectCode = r.SubjectCode join semesterstude s on s.StudentNumber = r.StudentNumber join studeprofile p on p.StudentNumber = r.StudentNumber join billing b on p.StudentNumber=b.StudentNumber join staff sf on sf.IDNumber=ss.IDNumber where r.StudentNumber = '" & mskStudentNumber.Text & "' and r.Sem = '" & frmMDIParent.lblSem.Text & "' and r.SY = '" & frmMDIParent.lblSY.Text & "' group by r.SubjectCode, r.Class order by r.SubjectCode, r.Class"
                conn.Open()
                Dim mysDa As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDa.Fill(mysds, "b.billing, registration, studeprofile, semsubjects, semesterstude, staff")
                Dim obj As New COR
                obj.SetDataSource(mysds.Tables("b.billing, registration, studeprofile, semsubjects, semesterstude, staff"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
            End If
            frmMainViewer.Show()

            If cboStudeReport.SelectedIndex = 1 Then
                str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, b.TotalLecUnit, b.TotalLabUnit, b.PreviousBalance, b.TuitionFee, b.LabFee, b.MiscFee, b.TotalAccount, b.Discount, b.CurrentAccount, b.TotalPayments, b.LateReg, b.Reg, b.DiscPercentage, b.Sem, b.SY, b.Term, pp.Sem, pp.SY, pp.Term, pp.PDate, pp.ORNumber, pp.Amount, pp.PaymentType, pp.paymentsid from studeprofile p join billing b on p.StudentNumber=b.StudentNumber join payments pp on p.StudentNumber=pp.StudentNumber where p.StudentNumber='" & mskStudentNumber.Text & "' and b.Sem='" & frmMDIParent.lblSem.Text & "' and b.SY='" & frmMDIParent.lblSY.Text & "' and pp.Sem='" & frmMDIParent.lblSem.Text & "' and pp.SY='" & frmMDIParent.lblSY.Text & "'"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, billing, payments")
                Dim obj As New PaymentHistory
                obj.SetDataSource(mysds.Tables("studeprofile, billing, payments"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
            End If
            frmMainViewer.Show()

            If cboStudeReport.SelectedIndex = 2 Then
                str = "select (s.lecunit+s.labunit) as TotalUnits, g.SY, g.Semester, g.Term, p.StudentNumber, concat(LastName,', ',FirstName,' ',MiddleName) as StudentName, p.BirthDate, p.BirthPlace, p.Address, p.Course, p.GraduationDate, p.AdmissionDate, p.HighSchool, p.HSAddress, p.College, p.CAddress, p.EC1, p.EC2, p.EC3, p.EC4, s.SubjectCode, s.Description, g.Final, g.Complied from studeprofile p join grades g on g.StudentNumber=p.StudentNumber join subjects s on s.SubjectCode=g.SubjectCode where p.StudentNumber='" & mskStudentNumber.Text & "' and g.SY='" & frmMDIParent.lblSY.Text & "' and g.Semester='" & frmMDIParent.lblSem.Text & "'"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "p.studeprofile, r.registration, g.grades")
                Dim obj As New ReportofGrades
                obj.SetDataSource(mysds.Tables("p.studeprofile, r.registration, g.grades"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
            End If
            frmMainViewer.Show()

            If cboStudeReport.SelectedIndex = 3 Then
                str = "select StudentNumber, concat(FirstName,' ',MiddleName,' ',LastName) as Fullname, SubjectCode, Description, Class, Sem, SY, Term from registration where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmMDIParent.lblSem.Text & "' and SY='" & frmMDIParent.lblSY.Text & "' order by SubjectCode"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "registration")
                Dim obj As New Clearance
                obj.SetDataSource(ds.Tables("registration"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
            End If
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnPreviewFinancial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviewFinancial.Click
        Try
            If cboFinancialReport.SelectedIndex = 0 Then
                str = "SELECT p.StudentNumber, concat(p.LastName,', ',p.FirstName) as StudentName,  s.PDate, s.ORNumber, s.Amount FROM payments s join studeprofile p on s.StudentNumber=p.StudentNumber where s.PDate='" & dtpDate.Text & "' group by p.StudentNumber order by s.ORNumber"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "p.studeprofile, s.payments")
                Dim obj As New DailyCollections
                obj.SetDataSource(mysds.Tables("p.studeprofile, s.payments"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
            End If
            frmMainViewer.Show()

            If cboFinancialReport.SelectedIndex = 1 Then
                str = "select * from otherpayments where PDate='" & dtpDate.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "otherpayments")
                Dim obj As New OtherPayments
                obj.SetDataSource(ds.Tables("otherpayments"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
            End If
            frmMainViewer.Show()

            If cboFinancialReport.SelectedIndex = 2 Then
                str = "SELECT ExpenseDate, Description, Sum(Amount), Responsible FROM expenses where ExpenseDate='" & dtpDate.Text & "' group by Description"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "expenses")
                Dim obj As New ReportofExpenses
                obj.SetDataSource(mysds.Tables("expenses"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
            End If
            frmMainViewer.Show()

            If cboFinancialReport.SelectedIndex = 3 Then
                str = "select y.DateApplied, p.StudentNumber, concat(p.LastName,', ',p.FirstName) as StudentName, y.DateApplied, y.Guardian, y.Amount, y.PromisedDate, y.Status from promissory y join studeprofile p on y.StudentNumber=p.StudentNumber where Status=""Complied"" order by StudentName"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "promissory, studeprofile")
                Dim obj As New PromissoryReport
                obj.SetDataSource(ds.Tables("promissory, studeprofile"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
            End If
            frmMainViewer.Show()

            If cboFinancialReport.SelectedIndex = 4 Then
                str = "select y.DateApplied, p.StudentNumber, concat(p.LastName,', ',p.FirstName) as StudentName, y.DateApplied, y.Guardian, y.Amount, y.PromisedDate, y.Status from promissory y join studeprofile p on y.StudentNumber=p.StudentNumber where Status=""For Compliance"" order by StudentName"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "promissory, studeprofile")
                Dim obj As New PromissoryReport
                obj.SetDataSource(ds.Tables("promissory, studeprofile"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
            End If

            If cboFinancialReport.SelectedIndex = 5 Then
                str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.TotalAccount, b.TotalPayments, b.CurrentAccount, (b.CurrentAccount/3) as PerExam, b.Course, b.YearLevel, b.Sem, b.SY, b.Term  from studeprofile p join billing b on p.StudentNumber=b.StudentNumber where  b.Course='" & cboCourse.Text & "' and b.YearLevel='" & cboYearLevel.Text & "' and b.Sem='" & frmMDIParent.lblSem.Text & "' and b.SY='" & frmMDIParent.lblSY.Text & "' order by Fullname"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "b.billing, p.studeprofile")
                Dim obj As New CurrentBalance
                obj.SetDataSource(mysds.Tables("b.billing, p.studeprofile"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
            End If
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmReportsMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.DataSet.staff)
        'TODO: This line of code loads data into the 'DataSet.courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.DataSet.courses)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudentList.Click
        Try
            str = "select StudentNumber, concat(LName,', ',FName,' ',MName) as Fullname, Course, YearLevel, Status, Semester, SY, Term, semstudentid from semesterstude where Course='" & cboCourse.Text & "' and Semester='" & frmMDIParent.lblSem.Text & "' and SY='" & frmMDIParent.lblSY.Text & "' and YearLevel='" & cboYearLevel.Text & "' and Status='" & cboStatus.Text & "' order by Fullname"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "semesterstude")
            Dim obj As New StudentList
            obj.SetDataSource(mysds.Tables("semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        frmMainViewer.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudeAccount.Click
        Try
            If cboCourseAccount.SelectedIndex = 4 Then
                str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.TotalAccount, b.TotalPayments, b.CurrentAccount, (b.CurrentAccount/4) as PerExam, b.Course, b.YearLevel, b.Sem, b.SY, b.Term  from studeprofile p join billing b on p.StudentNumber=b.StudentNumber where b.Course='" & cboCourseAccount.Text & "' and b.YearLevel='" & cboYearLevelAccount.Text & "' and  b.Sem='" & frmMDIParent.lblSem.Text & "' and b.SY='" & frmMDIParent.lblSY.Text & "' order by Fullname"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "b.billing, p.studeprofile")
                Dim obj As New StudeAccounts
                obj.SetDataSource(mysds.Tables("b.billing, p.studeprofile"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
            Else

                str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.TotalAccount, b.TotalPayments, b.CurrentAccount, (b.CurrentAccount/6) as PerExam, b.Course, b.YearLevel, b.Sem, b.SY, b.Term  from studeprofile p join billing b on p.StudentNumber=b.StudentNumber where b.Course='" & cboCourseAccount.Text & "' and b.YearLevel='" & cboYearLevelAccount.Text & "' and  b.Sem='" & frmMDIParent.lblSem.Text & "' and b.SY='" & frmMDIParent.lblSY.Text & "' order by Fullname"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "b.billing, p.studeprofile")
                Dim obj As New StudeAccounts
                obj.SetDataSource(mysds.Tables("b.billing, p.studeprofile"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
            End If
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacultyLoading.Click
        Try
            str = "select s.SubjectCode, s.Description, s.SchedTime, s.SchedDay, s.Class, s.SY, s.Semester, s.Term, i.IDNumber, i.Name from semsubjects s join staff i on s.IDNumber=i.IDNumber where i.Name='" & cboInstructor.Text & "' and s.Semester='" & frmMDIParent.lblSem.Text & "' and s.SY='" & frmMDIParent.lblSY.Text & "' order by s.SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "i.staff, s.semsubjects")
            Dim obj As New WorkLoad
            obj.SetDataSource(ds.Tables("i.staff, s.semsubjects"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasterlist.Click
        Try
            If txtsubjectcode.Text = "" Or txtSection.Text = "" Or cboInstructorMasterlist.Text = "'" Then
                MsgBox("All fields are required.  Please fill it up completely!", MsgBoxStyle.Information)
                txtsubjectcode.Focus()
                Exit Sub
            End If

            str = "SELECT r.StudentNumber, concat(r.LastName,', ',r.FirstName,' ',r.MiddleName) as Fullname, s.SubjectCode, s.Description, s.Class, r.SY, r.Sem, r.Term, r.Class, s.Section, s.SchedTime, s.Room, s.SchedDay, f.Name from registration r join semsubjects s on r.SubjectCode=s.SubjectCode join staff f on s.IDNumber=f.IDNumber where s.SubjectCode='" & txtsubjectcode.Text & "' and r.SY='" & frmMDIParent.lblSY.Text & "' and r.Sem='" & frmMDIParent.lblSem.Text & "' and s.Section='" & txtSection.Text & "' and f.Name='" & cboInstructorMasterlist.Text & "' and r.Class='" & cboClass.Text & "' and s.Class='" & cboClass.Text & "' ORDER by Fullname"
            'str = "SELECT ss.StudentNumber, concat(ss.LName,', ',ss.FName,' ',ss.MName) as name, ss.Course, s.SubjectCode, s.Description, s.SY, s.Semester, s.Term, s.Section, s.SchedTime, s.Room, s.SchedDay, f.Name from registration r join semesterstude ss on ss.StudentNumber = r.StudentNumber join semsubjects s on r.SubjectCode=s.SubjectCode join staff f on s.IDNumber=f.IDNumber where s.SubjectCode='" & txtsubjectcode.Text & "' ORDER by name"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "semsubjects, registration, staff")
            Dim obj As New Class_List
            obj.SetDataSource(mysds.Tables("semsubjects, registration, staff"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompleteList.Click
        Try
            str = "select concat(s.LName,', ',s.FName,' ',s.MName) as StudentName, p.Address, p.MobileNumber, s.Course, s.Semester, s.Term, s.SY from semesterstude s join studeprofile p on s.StudentNumber=p.StudentNumber where s.Semester='" & frmMDIParent.lblSem.Text & "' and s.SY='" & frmMDIParent.lblSY.Text & "' order by StudentName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "s.semesterstude, p.studeprofile")
            Dim obj As New SemesterStudeList
            obj.SetDataSource(ds.Tables("s.semesterstude, p.studeprofile"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class