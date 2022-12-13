Imports MySql.Data.MySqlClient
Public Class frmSearchSemesterStudent
    Dim str As String

    Private Sub frmSearchSemesterStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Reports2.sections' table. You can move, or remove it, as needed.
        Me.SectionsTableAdapter.Fill(Me.Reports2.sections)
        Try
            str = "select * from semesterstude where Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysDA.Fill(ds, "semesterstude")
            dgsemstudent.DataSource = ds.Tables("semesterstude")
            conn.Close()

            dgsemstudent.Columns(0).Visible = False
            dgsemstudent.Columns(1).Visible = True
            dgsemstudent.Columns(1).HeaderText = "LRN"
            dgsemstudent.Columns(2).Visible = True
            dgsemstudent.Columns(2).HeaderText = "First Name"
            dgsemstudent.Columns(3).Visible = True
            dgsemstudent.Columns(3).HeaderText = "Middle Name"
            dgsemstudent.Columns(4).Visible = True
            dgsemstudent.Columns(4).HeaderText = "Last Name"
            dgsemstudent.Columns(5).Visible = True
            dgsemstudent.Columns(5).HeaderText = "Department"
            dgsemstudent.Columns(6).Visible = True
            dgsemstudent.Columns(6).HeaderText = "Grade Level"
            dgsemstudent.Columns(7).Visible = False
            dgsemstudent.Columns(8).Visible = False
            dgsemstudent.Columns(9).Visible = False
            dgsemstudent.Columns(10).Visible = False
            dgsemstudent.Columns(11).Visible = False
            dgsemstudent.Columns(12).Visible = False
            dgsemstudent.Columns(13).Visible = False
            dgsemstudent.Columns(14).Visible = False
            dgsemstudent.Columns(15).Visible = False
            dgsemstudent.Columns(16).Visible = False
            dgsemstudent.Columns(17).Visible = False
            dgsemstudent.Columns(18).Visible = False
            dgsemstudent.Columns(19).Visible = False
            dgsemstudent.Columns(20).Visible = False
            dgsemstudent.Columns(21).Visible = False
            dgsemstudent.Columns(22).Visible = False
            dgsemstudent.Columns(23).Visible = False
            dgsemstudent.Columns(24).Visible = False
            dgsemstudent.Columns(25).Visible = False
            dgsemstudent.Columns(26).Visible = False
            dgsemstudent.Columns(27).Visible = False
            dgsemstudent.Columns(28).Visible = False
            dgsemstudent.Columns(29).Visible = False
            dgsemstudent.Columns(30).Visible = False
            dgsemstudent.Columns(31).Visible = False
            dgsemstudent.Columns(32).Visible = False
           
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from semesterstude where LName like '%" & txtSearch.Text & "%' and Semester like '%" & frmParent.lblSem.Text & "%' and SY like '%" & frmParent.lblSY.Text & "%'"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "semesterstude")
            dgsemstudent.DataSource = ds.Tables("semesterstude")
            conn.Close()
            dgsemstudent.Columns(0).Visible = False
            dgsemstudent.Columns(1).Visible = True
            dgsemstudent.Columns(1).HeaderText = "LRN"
            dgsemstudent.Columns(2).Visible = True
            dgsemstudent.Columns(2).HeaderText = "First Name"
            dgsemstudent.Columns(3).Visible = True
            dgsemstudent.Columns(3).HeaderText = "Middle Name"
            dgsemstudent.Columns(4).Visible = True
            dgsemstudent.Columns(4).HeaderText = "Last Name"
            dgsemstudent.Columns(5).Visible = True
            dgsemstudent.Columns(5).HeaderText = "Department"
            dgsemstudent.Columns(6).Visible = True
            dgsemstudent.Columns(6).HeaderText = "Grade Level"
            dgsemstudent.Columns(7).Visible = False
            dgsemstudent.Columns(8).Visible = False
            dgsemstudent.Columns(9).Visible = False
            dgsemstudent.Columns(10).Visible = False
            dgsemstudent.Columns(11).Visible = False
            dgsemstudent.Columns(12).Visible = False
            dgsemstudent.Columns(13).Visible = False
            dgsemstudent.Columns(14).Visible = False
            dgsemstudent.Columns(15).Visible = False
            dgsemstudent.Columns(16).Visible = False
            dgsemstudent.Columns(17).Visible = False
            dgsemstudent.Columns(18).Visible = False
            dgsemstudent.Columns(19).Visible = False
            dgsemstudent.Columns(20).Visible = False
            dgsemstudent.Columns(21).Visible = False
            dgsemstudent.Columns(22).Visible = False
            dgsemstudent.Columns(23).Visible = False
            dgsemstudent.Columns(24).Visible = False
            dgsemstudent.Columns(25).Visible = False
            dgsemstudent.Columns(26).Visible = False
            dgsemstudent.Columns(27).Visible = False
            dgsemstudent.Columns(28).Visible = False
            dgsemstudent.Columns(29).Visible = False
            dgsemstudent.Columns(30).Visible = False
            dgsemstudent.Columns(31).Visible = False
            dgsemstudent.Columns(32).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dgsemstudent_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgsemstudent.DoubleClick
        Try
            Dim i As Integer
            i = dgsemstudent.CurrentRow.Index
            frmCOR.mskStudentNumber.Text = dgsemstudent(1, i).Value
            frmCOR.txtFirstName.Text = dgsemstudent(2, i).Value
            frmCOR.txtMiddleName.Text = dgsemstudent(3, i).Value
            frmCOR.txtLastName.Text = dgsemstudent(4, i).Value
            frmCOR.txtCourse.Text = dgsemstudent(5, i).Value
            frmCOR.txtYearLevel.Text = dgsemstudent(6, i).Value
            frmCOR.lblSection.Text = dgsemstudent(11, i).Value

            frmCOR.btnAddSubject.Enabled = True
            frmCOR.tsSave.Enabled = True
            frmCOR.tsUpdate.Enabled = True
            frmCOR.btnAddSubject.Enabled = True
            frmCOR.btnRemoveSubjects.Enabled = True

            frmCOR.LoadSubjects()
            frmCOR.getTotalLecUnits()
            frmCOR.getTotalLabUnits()
            frmCOR.TotalUnits()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

   
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class