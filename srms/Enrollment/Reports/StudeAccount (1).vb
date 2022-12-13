Imports MySql.Data.MySqlClient
Public Class frmStudeAccount
    Dim str As String
    
    Private Sub frmStudeAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        getCourse()

        cboCourseAccount.ResetText()
        cboYearLevelAccount.ResetText()
    End Sub

    Private Sub btnStudeAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudeAccount.Click
        Try
            
            If cboCourseAccount.Text = "" And cboYearLevelAccount.Text = "" Then
                str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.AcctTotal, b.TotalPayments, b.Discount, b.CurrentBalance, b.PaymentMode, b.Course, b.YearLevel, b.SY, (b.Amount1+b.Amount2+b.Amount3+b.Amount4+b.Amount5) as OtherFees  from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber where b.Sem='" & frmParent.lblSem.Text & "' and b.SY='" & frmParent.lblSY.Text & "' group by p.StudentNumber order by Fullname"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "b.studeaccount, p.studeprofile")
                Dim obj As New StudeAccounts_All
                obj.SetDataSource(mysds.Tables("b.studeaccount, p.studeprofile"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                Me.Hide()

            Else

                str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.AcctTotal, b.TotalPayments, b.Discount, b.CurrentBalance, b.PaymentMode, b.Course, b.YearLevel, b.SY, (b.Amount1+b.Amount2+b.Amount3+b.Amount4+b.Amount5) as OtherFees  from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber where b.Course='" & cboCourseAccount.Text & "' and b.YearLevel='" & cboYearLevelAccount.Text & "' and b.Sem='" & frmParent.lblSem.Text & "' and b.SY='" & frmParent.lblSY.Text & "' group by p.StudentNumber order by Fullname"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "b.studeaccount, p.studeprofile")
                Dim obj As New StudeAccounts
                obj.SetDataSource(mysds.Tables("b.studeaccount, p.studeprofile"))
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Public Sub getCourse()
        Try
            str = "select * from course_table group by CourseDescription order by CourseDescription"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "course_table")
            conn.Close()

            cboCourseAccount.ValueMember = "course_table"
            cboCourseAccount.DisplayMember = "CourseDescription"
            cboCourseAccount.DataSource = ds.Tables("course_table")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getGradeLevel()
        Try
            str = "select * from course_table where CourseDescription='" & cboCourseAccount.Text & "' order by CourseDescription"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "course_table")
            conn.Close()

            cboYearLevelAccount.ValueMember = "course_table"
            cboYearLevelAccount.DisplayMember = "Major"
            cboYearLevelAccount.DataSource = ds.Tables("course_table")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboCourseAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCourseAccount.SelectedIndexChanged
        getGradeLevel()
    End Sub
End Class