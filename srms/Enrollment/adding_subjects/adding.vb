Imports MySql.Data.MySqlClient
Public Class frmAdding
    Dim str As String
    Dim str2 As String

    Private Sub btnAddStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStudent.Click
        frmSelectStudetoDropped.ShowDialog()
    End Sub

    Private Sub btnRemoveSubjects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub FormLoad()
        Try
            lvCOR.Items.Clear()
            Me.lvCOR.Columns.Add("Subject Code", 90)
            Me.lvCOR.Columns.Add("Description", 200)
            Me.lvCOR.Columns.Add("Lec Time", 90)
            Me.lvCOR.Columns.Add("Lab Time", 90)
            Me.lvCOR.Columns.Add("Room", 90)
            Me.lvCOR.Columns.Add("Section", 50)
            Me.lvCOR.Columns.Add("Lec Unit", 80)
            Me.lvCOR.Columns.Add("Lab Unit", 80)
            Me.lvCOR.Columns.Add("Instructor", 0)
            Me.lvCOR.Columns.Add("Slot", 0)
            Me.lvCOR.View = View.Details
            Me.lvCOR.GridLines = True

            mskStudentNumber.Clear()
            txtFirstName.Clear()
            txtMiddleName.Clear()
            txtLastName.Clear()
            txtCourse.Clear()
            txtYearLevel.Clear()
            txtTotalLecUnits.Clear()
            txtTotalLab.Clear()
            txtTotalUnits.Clear()

            btnAddSubject.Enabled = False
            btnRemoveSubjects.Enabled = False

            tsSave.Enabled = False
            tsUpdate.Enabled = False
            tsDelete.Enabled = False


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmAdding_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub

    Private Sub btnAddSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSubject.Click
        frmSelectSubtoAdd.ShowDialog()
    End Sub
    Public Sub getFinalSlot()
        Dim finalslot As Integer
        finalslot = lblSlot.Text - 1
        lblFinalSlot.Text = finalslot
    End Sub
    Public Sub getTotalLecUnits()
        Dim LecUnits As Double
        For x As Integer = 0 To lvCOR.Items.Count - 1
            LecUnits += Val(lvCOR.Items(x).SubItems(6).Text)
        Next
        txtTotalLecUnits.Text = Format(LecUnits, "0.00")
    End Sub
    Public Sub getTotalLabUnits()
        Dim LabUnits As Double
        For x As Integer = 0 To lvCOR.Items.Count - 1
            LabUnits += Val(lvCOR.Items(x).SubItems(7).Text)
        Next
        txtTotalLab.Text = Format(LabUnits, "0.00")
    End Sub
    Public Sub TotalUnits()
        Dim totalUnits As Double
        totalUnits = Val(txtTotalLecUnits.Text) + Val(txtTotalLab.Text)
        txtTotalUnits.Text = Format(totalUnits, "0.00")
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            If mskStudentNumber.Text = "" Or lvCOR.Items.Count = 0 Then
                MsgBox("Cannot save data! Add Student and subject first before saving!", MsgBoxStyle.Exclamation)
                mskStudentNumber.Focus()
                Exit Sub
            End If


            For i As Integer = 0 To lvCOR.Items.Count - 1

                'check if subject exist for the current semester
                str = "select * from registration where StudentNumber='" & mskStudentNumber.Text & "' and SubjectCode='" & lvCOR.Items(i).SubItems(0).Text & "' and Description='" & lvCOR.Items(i).SubItems(1).Text & "' and SY='" & frmParent.lblSY.Text & "' and Sem='" & frmParent.lblSem.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet

                mysda.Fill(ds, "registration")

                If ds.Tables("registration").Rows.Count >= 1 Then
                    MsgBox("One or more subjects is already enrolled by this student.  Record cannot be saved!", MsgBoxStyle.Exclamation)
                    conn.Close()
                    Exit Sub
                End If
                conn.Close()

                'insert records to registration table
                str = "insert into registration values('0','" & lvCOR.Items(i).SubItems(0).Text & "','" & lvCOR.Items(i).SubItems(1).Text & "','" & lvCOR.Items(i).SubItems(6).Text & "','" & lvCOR.Items(i).SubItems(7).Text & "','" & lvCOR.Items(i).SubItems(5).Text & "','" & lvCOR.Items(i).SubItems(3).Text & "','" & lvCOR.Items(i).SubItems(2).Text & "','" & lvCOR.Items(i).SubItems(4).Text & "','" & lvCOR.Items(i).SubItems(8).Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "','" & mskStudentNumber.Text & "','" & frmParent.lblTerm.Text & "','" & txtFirstName.Text & "','" & txtMiddleName.Text & "','" & txtLastName.Text & "','" & txtCourse.Text & "','" & txtYearLevel.Text & "','" & txtTotalUnits.Text & "')"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()

                'update slots
                str2 = "update semsubjects set Slot='" & lvCOR.Items(i).SubItems(9).Text & "' where SubjectCode='" & lvCOR.Items(i).SubItems(0).Text & "' and Description='" & lvCOR.Items(i).SubItems(1).Text & "' and Section='" & lvCOR.Items(i).SubItems(5).Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str2, conn)
                mysc1.ExecuteNonQuery()
                conn.Close()
            Next

            ' MsgBox("Registration has been processed successfully!", MsgBoxStyle.Information)
            If (MsgBox("Registration has been processed successfully! Do you want to print COR?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, r.Sem, r.SY, r.Course, r.YearLevel, r.SubjectCode, r.Description, r.Section, (r.LecUnit+r.LabUnit) as Units, r.LabTime, r.SchedTime, r.Room, r.Instructor from studeprofile p join registration r on p.StudentNumber=r.StudentNumber join semsubjects ss on ss.Instructor=r.Instructor where p.StudentNumber = '" & mskStudentNumber.Text & "' and r.Sem = '" & frmParent.lblSem.Text & "' and r.SY = '" & frmParent.lblSY.Text & "' and ss.Semester = '" & frmParent.lblSem.Text & "' and ss.SY = '" & frmParent.lblSY.Text & "' group by r.SubjectCode, r.Description order by r.SubjectCode"
                conn.Open()
                Dim mysDa1 As New MySqlDataAdapter(str, conn)
                Dim mysds1 As New DataSet
                mysDa1.Fill(mysds1, "registration, studeprofile, semsubjects, semesterstude, staff")
                Dim obj As New COR
                obj.SetDataSource(mysds1.Tables("registration, studeprofile, semsubjects, semesterstude, staff"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                Me.Close()
                conn.Close()
            End If

            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnRemoveSubjects_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveSubjects.Click
        Try
            Dim i As Integer

            lvCOR.Select()

            If lvCOR.Items.Count = 0 Then
                MsgBox("Cannot find subject(s) to remove", MsgBoxStyle.Exclamation, "Prompt")
                Exit Sub
            Else
                i = lvCOR.FocusedItem.Index
                lvCOR.Items.RemoveAt(i)
            End If

            getTotalLecUnits()
            getTotalLabUnits()
            TotalUnits()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class