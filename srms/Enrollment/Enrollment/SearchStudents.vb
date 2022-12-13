Imports MySql.Data.MySqlClient
Public Class frmSearchStudents
    Dim str As String

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try

            If rdoOnline.Checked = True Then
                str = "select * from online_enrollment where LastName like '%" & txtSearch.Text & "%' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "online_enrollment")
                dgstudentsearch.DataSource = ds.Tables("online_enrollment")
                conn.Close()
                dgstudentsearch.Columns(0).Visible = False
                dgstudentsearch.Columns(1).HeaderText = "LRN"
                dgstudentsearch.Columns(2).HeaderText = "First Name"
                dgstudentsearch.Columns(3).HeaderText = "Middle Name"
                dgstudentsearch.Columns(4).HeaderText = "Last Name"
                dgstudentsearch.Columns(5).HeaderText = "Course"
                dgstudentsearch.Columns(6).HeaderText = "Year Level"
                dgstudentsearch.Columns(7).Visible = False
                dgstudentsearch.Columns(8).Visible = False
                dgstudentsearch.Columns(9).Visible = False
                dgstudentsearch.Columns(10).Visible = False
            Else
                str = "select * from studeprofile where LastName like '%" & txtSearch.Text & "%'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studeprofile")
                dgstudentsearch.DataSource = ds.Tables("studeprofile")
                conn.Close()
                dgstudentsearch.Columns(0).Visible = True
                dgstudentsearch.Columns(0).Width = 110
                dgstudentsearch.Columns(0).HeaderText = "LRN"
                dgstudentsearch.Columns(1).Visible = True
                dgstudentsearch.Columns(1).Width = 110
                dgstudentsearch.Columns(1).HeaderText = "First Name"
                dgstudentsearch.Columns(2).Visible = True
                dgstudentsearch.Columns(2).Width = 110
                dgstudentsearch.Columns(2).HeaderText = "Midde Name"
                dgstudentsearch.Columns(3).Visible = True
                dgstudentsearch.Columns(3).Width = 110
                dgstudentsearch.Columns(3).HeaderText = "Last Name"
                dgstudentsearch.Columns(4).Visible = True
                dgstudentsearch.Columns(4).Width = 110
                dgstudentsearch.Columns(4).HeaderText = "Sex"
                dgstudentsearch.Columns(5).Visible = False
                dgstudentsearch.Columns(6).Visible = False
                dgstudentsearch.Columns(7).Visible = False
                dgstudentsearch.Columns(8).Visible = False
                dgstudentsearch.Columns(9).Visible = False
                dgstudentsearch.Columns(10).Visible = False
                dgstudentsearch.Columns(11).Visible = False
                dgstudentsearch.Columns(12).Visible = False
                dgstudentsearch.Columns(13).Visible = False
                dgstudentsearch.Columns(14).Visible = False
                dgstudentsearch.Columns(15).Visible = False
                dgstudentsearch.Columns(16).Visible = False
                dgstudentsearch.Columns(17).Visible = False
                dgstudentsearch.Columns(18).Visible = False
                dgstudentsearch.Columns(19).Visible = False
                dgstudentsearch.Columns(20).Visible = False
                dgstudentsearch.Columns(21).Visible = False
                dgstudentsearch.Columns(22).Visible = False
                dgstudentsearch.Columns(23).Visible = False
                dgstudentsearch.Columns(24).Visible = False
                dgstudentsearch.Columns(25).Visible = False
                dgstudentsearch.Columns(26).Visible = False
                dgstudentsearch.Columns(27).Visible = False
                dgstudentsearch.Columns(28).Visible = False
                dgstudentsearch.Columns(29).Visible = False
                dgstudentsearch.Columns(30).Visible = False
                dgstudentsearch.Columns(31).Visible = False
                dgstudentsearch.Columns(32).Visible = False
                dgstudentsearch.Columns(33).Visible = False
                dgstudentsearch.Columns(34).Visible = False
                dgstudentsearch.Columns(35).Visible = False
                dgstudentsearch.Columns(36).Visible = False
                dgstudentsearch.Columns(37).Visible = False
                dgstudentsearch.Columns(38).Visible = False
                dgstudentsearch.Columns(39).Visible = False
                dgstudentsearch.Columns(40).Visible = False
                dgstudentsearch.Columns(41).Visible = False
                dgstudentsearch.Columns(42).Visible = False
                dgstudentsearch.Columns(43).Visible = False
                dgstudentsearch.Columns(44).Visible = False
                dgstudentsearch.Columns(45).Visible = False
                dgstudentsearch.Columns(46).Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dgstudentsearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgstudentsearch.DoubleClick
        Try
            If rdoOnline.Checked = True Then
                Dim dclick As Integer
                dclick = dgstudentsearch.CurrentRow.Index
                frmSemStudent.Reload()
                frmSemStudent.mskStudentNumber.Text = dgstudentsearch.Item(1, dclick).Value
                frmSemStudent.txtFname.Text = dgstudentsearch.Item(2, dclick).Value
                frmSemStudent.txtMName.Text = dgstudentsearch.Item(3, dclick).Value
                frmSemStudent.txtLastName.Text = dgstudentsearch.Item(4, dclick).Value
                frmSemStudent.cboCourse.Text = dgstudentsearch.Item(5, dclick).Value
                frmSemStudent.cboYear.Text = dgstudentsearch.Item(6, dclick).Value
                Me.Close()
                frmSemStudent.Show()
                frmSemStudent.tsSave.Enabled = True
                frmSemStudent.tsUpdate.Enabled = False
                frmSemStudent.tsDelete.Enabled = False
                frmSemStudent.btnLoadSubjects.Enabled = True

            Else
                Dim dclick As Integer
                dclick = dgstudentsearch.CurrentRow.Index
                frmSemStudent.Reload()
                frmSemStudent.mskStudentNumber.Text = dgstudentsearch.Item(0, dclick).Value
                frmSemStudent.txtFname.Text = dgstudentsearch.Item(1, dclick).Value
                frmSemStudent.txtMName.Text = dgstudentsearch.Item(2, dclick).Value
                frmSemStudent.txtLastName.Text = dgstudentsearch.Item(3, dclick).Value
                Me.Close()
                frmSemStudent.Show()
                frmSemStudent.tsSave.Enabled = True
                frmSemStudent.tsUpdate.Enabled = False
                frmSemStudent.tsDelete.Enabled = False
                frmSemStudent.btnLoadSubjects.Enabled = True
            End If

            

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmSearchStudents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdoOffline.Checked = True
        txtSearch.Clear()
        txtSearch.Focus()
       
        rdoEvent()

    End Sub
    Public Sub rdoEvent()
        Try

            If rdoOnline.Checked = True Then
                str = "select * from online_enrollment where Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and enrolStatus='For Validation' and downPaymentStat='Paid'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "online_enrollment")
                dgstudentsearch.DataSource = ds.Tables("online_enrollment")
                conn.Close()
                dgstudentsearch.Columns(0).Visible = False
                dgstudentsearch.Columns(1).HeaderText = "LRN"
                dgstudentsearch.Columns(2).HeaderText = "First Name"
                dgstudentsearch.Columns(3).HeaderText = "Middle Name"
                dgstudentsearch.Columns(4).HeaderText = "Last Name"
                dgstudentsearch.Columns(5).HeaderText = "Course"
                dgstudentsearch.Columns(6).HeaderText = "Year Level"
                dgstudentsearch.Columns(7).Visible = False
                dgstudentsearch.Columns(8).Visible = False
                dgstudentsearch.Columns(9).Visible = False
                dgstudentsearch.Columns(10).Visible = False
            Else
                str = "select * from studeprofile"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studeprofile")
                dgstudentsearch.DataSource = ds.Tables("studeprofile")
                conn.Close()

                dgstudentsearch.Columns(0).Visible = True
                dgstudentsearch.Columns(0).Width = 110
                dgstudentsearch.Columns(0).HeaderText = "LRN"
                dgstudentsearch.Columns(1).Visible = True
                dgstudentsearch.Columns(1).Width = 110
                dgstudentsearch.Columns(1).HeaderText = "First Name"
                dgstudentsearch.Columns(2).Visible = True
                dgstudentsearch.Columns(2).Width = 110
                dgstudentsearch.Columns(2).HeaderText = "Midde Name"
                dgstudentsearch.Columns(3).Visible = True
                dgstudentsearch.Columns(3).Width = 110
                dgstudentsearch.Columns(3).HeaderText = "Last Name"
                dgstudentsearch.Columns(4).Visible = True
                dgstudentsearch.Columns(4).Width = 110
                dgstudentsearch.Columns(4).HeaderText = "Sex"
                dgstudentsearch.Columns(5).Visible = False
                dgstudentsearch.Columns(6).Visible = False
                dgstudentsearch.Columns(7).Visible = False
                dgstudentsearch.Columns(8).Visible = False
                dgstudentsearch.Columns(9).Visible = False
                dgstudentsearch.Columns(10).Visible = False
                dgstudentsearch.Columns(11).Visible = False
                dgstudentsearch.Columns(12).Visible = False
                dgstudentsearch.Columns(13).Visible = False
                dgstudentsearch.Columns(14).Visible = False
                dgstudentsearch.Columns(15).Visible = False
                dgstudentsearch.Columns(16).Visible = False
                dgstudentsearch.Columns(17).Visible = False
                dgstudentsearch.Columns(18).Visible = False
                dgstudentsearch.Columns(19).Visible = False
                dgstudentsearch.Columns(20).Visible = False
                dgstudentsearch.Columns(21).Visible = False
                dgstudentsearch.Columns(22).Visible = False
                dgstudentsearch.Columns(23).Visible = False
                dgstudentsearch.Columns(24).Visible = False
                dgstudentsearch.Columns(25).Visible = False
                dgstudentsearch.Columns(26).Visible = False
                dgstudentsearch.Columns(27).Visible = False
                dgstudentsearch.Columns(28).Visible = False
                dgstudentsearch.Columns(29).Visible = False
                dgstudentsearch.Columns(30).Visible = False
                dgstudentsearch.Columns(31).Visible = False
                dgstudentsearch.Columns(32).Visible = False
                dgstudentsearch.Columns(33).Visible = False
                dgstudentsearch.Columns(34).Visible = False
                dgstudentsearch.Columns(35).Visible = False
                dgstudentsearch.Columns(36).Visible = False
                dgstudentsearch.Columns(37).Visible = False
                dgstudentsearch.Columns(38).Visible = False
                dgstudentsearch.Columns(39).Visible = False
                dgstudentsearch.Columns(40).Visible = False
                dgstudentsearch.Columns(41).Visible = False
                dgstudentsearch.Columns(42).Visible = False
                dgstudentsearch.Columns(43).Visible = False
                dgstudentsearch.Columns(44).Visible = False
                dgstudentsearch.Columns(45).Visible = False
                dgstudentsearch.Columns(46).Visible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub rdoOffline_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoOffline.CheckedChanged
        rdoEvent()
    End Sub

    Private Sub rdoOnline_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoOnline.CheckedChanged
        rdoEvent()
    End Sub
End Class