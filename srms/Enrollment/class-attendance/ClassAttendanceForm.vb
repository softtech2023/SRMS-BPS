Imports MySql.Data.MySqlClient
Public Class frmClassAttendanceForm

    Dim str As String

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()
    End Sub
    Public Sub formLoad()
        PictureBox1.Image = My.Resources.default1

        Dim TerminalNo As String
        TerminalNo = System.Net.Dns.GetHostName()
        lblTerminalNo.Text = TerminalNo.ToString

    End Sub

    Public Sub getProfile()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from studeprofile where StudentNumber='" & txtStudentNumber.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtFirstName.Text = dtReader(1)
                txtMiddleName.Text = dtReader(2)
                txtLastName.Text = dtReader(3)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub getPhoto()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select profImage from profimage where StudentNumber='" & txtStudentNumber.Text & "'"

            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                Dim arrImage() As Byte
                arrImage = dtReader.Item(0)
                Dim mstream As New System.IO.MemoryStream(arrImage)
                PictureBox1.Image = Image.FromStream(mstream)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub txtStudentNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudentNumber.TextChanged
        getProfile()
        getPhoto()
        'saveLogs()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        txtStudentNumber.Clear()
        formLoad()
    End Sub
    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        btnLogin.PerformClick()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            str = "select * from classattendance where StudentNumber='" & txtStudentNumber.Text & "' and sem='" & frmParent.lblSem.Text & "' and sy='" & frmParent.lblSY.Text & "' and subjectCode='" & lblSubjectCode.Text & "' and logDate='" & Convert.ToDateTime(frmParent.dtpDate.Text).ToString("yyyy-MM-dd") & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "classattendance")
            conn.Close()

            If ds.Tables("classattendance").Rows.Count >= 1 Then
                str = "update classattendance set logStat='Present', logTime='" & frmParent.tsTime.Text & "' where StudentNumber='" & txtStudentNumber.Text & "' and sem='" & frmParent.lblSem.Text & "' and sy='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("Login successfully!", MsgBoxStyle.Information)

                txtFirstName.Clear()
                txtMiddleName.Clear()
                txtLastName.Clear()
                txtStudentNumber.Clear()
                formLoad()
            Else
                MsgBox("Invalid login", MsgBoxStyle.Exclamation)
                txtStudentNumber.Clear()
                txtStudentNumber.Focus()
                Exit Sub

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub


    Private Sub ClassAttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassAttendanceToolStripMenuItem.Click
        frmClassAtt.Show()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem.Click
        frmReportsDashboard.Show()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        frmClassAtt.ShowDialog()
    End Sub

    Private Sub DailyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyToolStripMenuItem.Click
        If lblSubjectCode.Text = "" Then
            MsgBox("Select a subject first before generating a report!", MsgBoxStyle.Exclamation)
            Exit Sub

        Else
            frmDailyReport.Show()
        End If

    End Sub
End Class
