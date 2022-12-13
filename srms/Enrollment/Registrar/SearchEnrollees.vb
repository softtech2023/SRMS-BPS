Imports MySql.Data.MySqlClient
Public Class frmSearchEnrollees
    Dim str As String

    Private Sub frmSearchEnrollees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select * from semesterstude where Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' order by LName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude")
            dg1.DataSource = ds.Tables("semesterstude")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).Visible = True
            dg1.Columns(1).HeaderText = "LRN"
            dg1.Columns(2).Visible = True
            dg1.Columns(2).HeaderText = "First Name"
            dg1.Columns(3).Visible = True
            dg1.Columns(3).HeaderText = "Middle Name"
            dg1.Columns(4).Visible = True
            dg1.Columns(4).HeaderText = "Last Name"
            dg1.Columns(5).Visible = True
            dg1.Columns(5).HeaderText = "Department"
            dg1.Columns(6).Visible = True
            dg1.Columns(6).HeaderText = "Grade Level"
            dg1.Columns(7).Visible = False
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False
            dg1.Columns(10).Visible = False
            dg1.Columns(11).Visible = True
            dg1.Columns(12).Visible = False
            dg1.Columns(13).Visible = False
            dg1.Columns(14).Visible = False
            dg1.Columns(15).Visible = False
            dg1.Columns(16).Visible = False
            dg1.Columns(17).Visible = False
            dg1.Columns(18).Visible = False
            dg1.Columns(19).Visible = False
            dg1.Columns(20).Visible = False
            dg1.Columns(21).Visible = False
            dg1.Columns(22).Visible = False
            dg1.Columns(23).Visible = False
            dg1.Columns(24).Visible = False
            dg1.Columns(25).Visible = False
            dg1.Columns(26).Visible = False
            dg1.Columns(27).Visible = False
            dg1.Columns(28).Visible = False
            dg1.Columns(29).Visible = False
            dg1.Columns(30).Visible = False
            dg1.Columns(31).Visible = False
            dg1.Columns(32).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from semesterstude where LName like '%" & txtSearch.Text & "%' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' order by LName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude")
            dg1.DataSource = ds.Tables("semesterstude")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).Visible = True
            dg1.Columns(1).HeaderText = "LRN"
            dg1.Columns(2).Visible = True
            dg1.Columns(2).HeaderText = "First Name"
            dg1.Columns(3).Visible = True
            dg1.Columns(3).HeaderText = "Middle Name"
            dg1.Columns(4).Visible = True
            dg1.Columns(4).HeaderText = "Last Name"
            dg1.Columns(5).Visible = True
            dg1.Columns(5).HeaderText = "Department"
            dg1.Columns(6).Visible = True
            dg1.Columns(6).HeaderText = "Grade Level"
            dg1.Columns(7).Visible = False
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False
            dg1.Columns(10).Visible = False
            dg1.Columns(11).Visible = True
            dg1.Columns(12).Visible = False
            dg1.Columns(13).Visible = False
            dg1.Columns(14).Visible = False
            dg1.Columns(15).Visible = False
            dg1.Columns(16).Visible = False
            dg1.Columns(17).Visible = False
            dg1.Columns(18).Visible = False
            dg1.Columns(19).Visible = False
            dg1.Columns(20).Visible = False
            dg1.Columns(21).Visible = False
            dg1.Columns(22).Visible = False
            dg1.Columns(23).Visible = False
            dg1.Columns(24).Visible = False
            dg1.Columns(25).Visible = False
            dg1.Columns(26).Visible = False
            dg1.Columns(27).Visible = False
            dg1.Columns(28).Visible = False
            dg1.Columns(29).Visible = False
            dg1.Columns(30).Visible = False
            dg1.Columns(31).Visible = False
            dg1.Columns(32).Visible = False
           

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try

            Dim i As Integer
            i = dg1.CurrentRow.Index
            frmSemStudent.lblID.Text = dg1(0, i).Value
            frmSemStudent.mskStudentNumber.Text = dg1(1, i).Value
            frmSemStudent.txtFname.Text = dg1(2, i).Value
            frmSemStudent.txtMName.Text = dg1(3, i).Value
            frmSemStudent.txtLastName.Text = dg1(4, i).Value
            frmSemStudent.cboCourse.Text = dg1(5, i).Value
            frmSemStudent.cboYear.Text = dg1(6, i).Value
            frmSemStudent.cboStatus.Text = dg1(7, i).Value
            frmSemStudent.cboSection.Text = dg1(11, i).Value
            frmSemStudent.cboStudeStatus.Text = dg1(12, i).Value
            frmSemStudent.cboScholarship.Text = dg1(13, i).Value
            frmSemStudent.mskFrom.Text = dg1(14, i).Value
            frmSemStudent.mskTo.Text = dg1(15, i).Value
            frmSemStudent.mskAssessmentDate.Text = dg1(16, i).Value
            frmSemStudent.cboAssessmentResult.Text = dg1(17, i).Value
            frmSemStudent.cboAccountStatus.Text = dg1(18, i).Value
            frmSemStudent.cboYearStat.Text = dg1(20, i).Value
            frmSemStudent.txtGrantAmount.Text = dg1(19, i).Value
            frmSemStudent.cboYearStat.Text = dg1(20, i).Value
            frmSemStudent.cboMajor.Text = dg1(21, i).Value
            frmSemStudent.cboTrack.Text = dg1.Item(22, i).Value
            frmSemStudent.cboQualification.Text = dg1.Item(23, i).Value
            frmSemStudent.cboBalikAral.Text = dg1.Item(24, i).Value
            frmSemStudent.cboIP.Text = dg1.Item(25, i).Value
            frmSemStudent.cbo4Ps.Text = dg1.Item(26, i).Value
            frmSemStudent.cboRepeater.Text = dg1.Item(27, i).Value
            frmSemStudent.cboTransferee.Text = dg1.Item(28, i).Value
            frmSemStudent.lblAdviser.Text = dg1.Item(30, i).Value

            frmSemStudent.loadEnrolledSubjects()
            frmSemStudent.getTotalLecUnits()
            frmSemStudent.getTotalLabUnits()
            frmSemStudent.TotalUnits()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        frmSemStudent.tsSave.Enabled = False
        frmSemStudent.tsUpdate.Enabled = True
        frmSemStudent.tsDelete.Enabled = True

        frmSemStudent.btnAccecelrated.Enabled = True
        frmSemStudent.btnDropped.Enabled = True
        frmSemStudent.btnTransferredOut.Enabled = True


        Me.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class