Imports MySql.Data.MySqlClient
Public Class frmCOR
    Dim str As String

    Private Sub frmAddStudent_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStudent.Click
        lvCOR.Items.Clear()
        frmSearchSemesterStudent.ShowDialog()
    End Sub

    Private Sub btnAddSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSubject.Click
        frmSearchSemSubjects.ShowDialog()
    End Sub

    Private Sub btnRemoveSubjects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveSubjects.Click
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
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmCOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub
    Public Sub FormLoad()
        Try
            ' lvCOR.Items.Clear()
            Me.lvCOR.Columns.Add("Subject Code", 90)
            Me.lvCOR.Columns.Add("Description", 200)
            Me.lvCOR.Columns.Add("Lec Time", 90)
            Me.lvCOR.Columns.Add("Lab Time", 90)
            Me.lvCOR.Columns.Add("Room", 90)
            Me.lvCOR.Columns.Add("Section", 50)
            Me.lvCOR.Columns.Add("Lec Unit", 80)
            Me.lvCOR.Columns.Add("Lab Unit", 80)

            Me.lvCOR.View = View.Details
            Me.lvCOR.GridLines = True

            mskStudentNumber.Clear()
            txtFirstName.Clear()
            txtMiddleName.Clear()
            txtLastName.Clear()
            txtCourse.Clear()
            txtYearLevel.Clear()

            btnAddSubject.Enabled = False
            btnRemoveSubjects.Enabled = False

            tsSave.Enabled = False
            tsUpdate.Enabled = False
            tsDelete.Enabled = False

            schoolInfo()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub LoadSubjects()
        Try
            If txtCourse.Text = "Senior High School" Then

                Dim dt As New DataTable
                str = "SELECT * FROM semsubjects where Course='" & txtCourse.Text & "' and YearLevel='" & txtYearLevel.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Section='" & lblSection.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                mysda.Fill(dt)
                Dim newrow As DataRow
                For Each newrow In dt.Rows
                    lvCOR.Items.Add(newrow.Item(1))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(2))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(7))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(6))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(8))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(5))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(3))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(4))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(13))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(13))
                Next
                conn.Close()
            Else
                Dim dt As New DataTable
                str = "SELECT * FROM semsubjects where Course='" & txtCourse.Text & "' and YearLevel='" & txtYearLevel.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Section='" & lblSection.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                mysda.Fill(dt)
                Dim newrow As DataRow
                For Each newrow In dt.Rows
                    lvCOR.Items.Add(newrow.Item(1))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(2))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(7))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(6))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(8))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(5))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(3))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(4))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(13))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(13))
                Next
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub mskStudentNumber_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskStudentNumber.Click
        frmSearchSemesterStudent.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsFind.Click
        lvCOR.Items.Clear()
        frmSearchCOR.ShowDialog()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            If mskStudentNumber.Text = "" Or lvCOR.Items.Count = 0 Then
                MsgBox("Cannot save data! Add Student and subject first before saving!", MsgBoxStyle.Exclamation)
                mskStudentNumber.Focus()
                Exit Sub
            End If

            str = "select * from registration where StudentNumber='" & mskStudentNumber.Text & "' and SY='" & frmParent.lblSY.Text & "' and Sem='" & frmParent.lblSem.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet

            mysda.Fill(ds, "registration")

            If ds.Tables("registration").Rows.Count >= 1 Then
                MsgBox("Student already advised!", MsgBoxStyle.Information)
                conn.Close()
                Exit Sub
            End If
            conn.Close()

            For i As Integer = 0 To lvCOR.Items.Count - 1

                str = "insert into registration values('0','" & lvCOR.Items(i).SubItems(0).Text & "','" & lvCOR.Items(i).SubItems(1).Text & "','" & lvCOR.Items(i).SubItems(6).Text & "','" & lvCOR.Items(i).SubItems(7).Text & "','" & lvCOR.Items(i).SubItems(5).Text & "','" & lvCOR.Items(i).SubItems(3).Text & "','" & lvCOR.Items(i).SubItems(2).Text & "','" & lvCOR.Items(i).SubItems(4).Text & "','" & lvCOR.Items(i).SubItems(8).Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "','" & mskStudentNumber.Text & "','" & frmParent.lblTerm.Text & "','" & txtFirstName.Text & "','" & txtMiddleName.Text & "','" & txtLastName.Text & "','" & txtCourse.Text & "','" & txtYearLevel.Text & "','" & lblSettingsID.Text & "')"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()

                conn.Close()
            Next
            MsgBox("Registration has been processed successfully!", MsgBoxStyle.Information)
            lvCOR.Items.Clear()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            str = "delete from registration where StudentNumber='" & mskStudentNumber.Text & "' and SY='" & frmParent.lblSY.Text & "' and Sem='" & frmParent.lblSem.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            conn.Close()
            tsSave.PerformClick()
            lvCOR.Items.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsClear.Click
        lvCOR.Items.Clear()
        mskStudentNumber.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        tsSave.PerformClick()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        tsUpdate.PerformClick()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        tsFind.PerformClick()
    End Sub

    Private Sub AddStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStudentToolStripMenuItem.Click
        btnAddStudent.PerformClick()
    End Sub

    Private Sub AddSubjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSubjectsToolStripMenuItem.Click
        btnAddSubject.PerformClick()
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

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record from the Certificate of Registration?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from registration where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Selected record has been deleted", MsgBoxStyle.Information)
                conn.Close()
                FormLoad()
                lvCOR.Items.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub loadEnrolledSubjects()
        Try
            Dim dt As New DataTable
            str = "SELECT * FROM registration where Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            mysda.Fill(dt)
            Dim newrow As DataRow
            For Each newrow In dt.Rows
                lvCOR.Items.Add(newrow.Item(1))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(2))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(7))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(6))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(8))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(5))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(3))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(4))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(9))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(10))
            Next

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub schoolInfo()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from srms_settings limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblSettingsID.Text = dtReader(0)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub mskStudentNumber_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mskStudentNumber.MaskInputRejected

    End Sub
End Class