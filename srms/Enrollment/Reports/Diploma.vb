Imports MySql.Data.MySqlClient
Public Class frmDiploma
    Dim str As String
    Private Sub frmDiploma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If frmParent.lblSem.Text = "" Then
                str = "SELECT *  FROM semesterstude where YearLevel='Grade 10' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "semesterstude")
                dg1.DataSource = ds.tables("semesterstude")
                conn.Close()

                dg1.Columns(0).Visible = False
                dg1.Columns(1).HeaderText = "LRN"
                dg1.Columns(2).Width = 150
                dg1.Columns(2).HeaderText = "First Name"
                dg1.Columns(3).Width = 150
                dg1.Columns(3).HeaderText = "Middle Name"
                dg1.Columns(4).Width = 150
                dg1.Columns(4).HeaderText = "Last Name"
                dg1.Columns(5).Visible = False
                dg1.Columns(6).HeaderText = "Grade Level"
                dg1.Columns(7).Visible = False
                dg1.Columns(8).Visible = False
                dg1.Columns(9).Visible = False
                dg1.Columns(10).Visible = False
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
                dg1.Columns(30).Width = 200
            Else
                str = "SELECT *  FROM semesterstude where YearLevel='Grade 12' and SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "semesterstude")
                dg1.DataSource = ds.Tables("semesterstude")
                conn.Close()

                dg1.Columns(0).Visible = False
                dg1.Columns(1).HeaderText = "LRN"
                dg1.Columns(2).Width = 150
                dg1.Columns(2).HeaderText = "First Name"
                dg1.Columns(3).Width = 150
                dg1.Columns(3).HeaderText = "Middle Name"
                dg1.Columns(4).Width = 150
                dg1.Columns(4).HeaderText = "Last Name"
                dg1.Columns(5).Visible = False
                dg1.Columns(6).HeaderText = "Grade Level"
                dg1.Columns(7).Visible = False
                dg1.Columns(8).Visible = False
                dg1.Columns(9).Visible = False
                dg1.Columns(10).Visible = False
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
                dg1.Columns(30).Width = 200
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnPrintAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintAll.Click
        Try
            If frmParent.lblSem.Text = "" Then
                str = "select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as Fullname, p.Sex, ss.Course, ss.YearLevel, ss.Status, ss.SY, YearLevelStat, ss.Section, ss.semstudentid, ss.Adviser, ss.Track, ss.Qualification from semesterstude ss join studeprofile p on p.StudentNumber=ss.StudentNumber where ss.StudentNumber='" & txtStudentNumber.Text & "'"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "semesterstude")
                Dim obj As New DiplomaJHS
                obj.SetDataSource(mysds.Tables("semesterstude"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                Me.Hide()
            Else
                str = "select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as Fullname, p.Sex, ss.Course, ss.YearLevel, ss.Status, ss.SY, YearLevelStat, ss.Section, ss.semstudentid, ss.Adviser, ss.Track, ss.Qualification from semesterstude ss join studeprofile p on p.StudentNumber=ss.StudentNumber where ss.StudentNumber='" & txtStudentNumber.Text & "'"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "semesterstude")
                Dim obj As New DiplomaPrinting
                obj.SetDataSource(mysds.Tables("semesterstude"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                Me.Hide()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        txtStudentNumber.Text = dg1.Item(1, i).Value
        txtFName.Text = dg1.Item(2, i).Value
        txtMName.Text = dg1.Item(3, i).Value
        txtLName.Text = dg1.Item(4, i).Value
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            If frmParent.lblSem.Text = "" Then
                str = "SELECT *  FROM semesterstude where LName like '%" & txtSearch.Text & "%' and YearLevel='Grade 10' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "semesterstude")
                dg1.DataSource = ds.Tables("semesterstude")
                conn.Close()

                dg1.Columns(0).Visible = False
                dg1.Columns(1).HeaderText = "LRN"
                dg1.Columns(2).Width = 150
                dg1.Columns(2).HeaderText = "First Name"
                dg1.Columns(3).Width = 150
                dg1.Columns(3).HeaderText = "Middle Name"
                dg1.Columns(4).Width = 150
                dg1.Columns(4).HeaderText = "Last Name"
                dg1.Columns(5).Visible = False
                dg1.Columns(6).HeaderText = "Grade Level"
                dg1.Columns(7).Visible = False
                dg1.Columns(8).Visible = False
                dg1.Columns(9).Visible = False
                dg1.Columns(10).Visible = False
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
                dg1.Columns(30).Width = 200
            Else
                str = "SELECT *  FROM semesterstude where LName like '%" & txtSearch.Text & "%' and YearLevel='Grade 12' and SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "semesterstude")
                dg1.DataSource = ds.Tables("semesterstude")
                conn.Close()

                dg1.Columns(0).Visible = False
                dg1.Columns(1).HeaderText = "LRN"
                dg1.Columns(2).Width = 150
                dg1.Columns(2).HeaderText = "First Name"
                dg1.Columns(3).Width = 150
                dg1.Columns(3).HeaderText = "Middle Name"
                dg1.Columns(4).Width = 150
                dg1.Columns(4).HeaderText = "Last Name"
                dg1.Columns(5).Visible = False
                dg1.Columns(6).HeaderText = "Grade Level"
                dg1.Columns(7).Visible = False
                dg1.Columns(8).Visible = False
                dg1.Columns(9).Visible = False
                dg1.Columns(10).Visible = False
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
                dg1.Columns(30).Width = 200
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class