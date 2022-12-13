Imports MySql.Data.MySqlClient
Public Class frmStudeAccount
    Dim str As String
    
    Private Sub frmStudeAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getGradeLevel()

    End Sub

    Private Sub btnStudeAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudeAccount.Click
        Try
            If cboSection.Text = "" Then
                str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.AcctTotal, b.TotalPayments, b.Discount, b.CurrentBalance, b.PaymentMode, b.Course, b.YearLevel, b.Section, b.SY, (b.Amount1+b.Amount2+b.Amount3+b.Amount4+b.Amount5) as OtherFees  from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber where b.YearLevel='" & cboYearLevelAccount.Text & "' and b.Sem='" & frmParent.lblSem.Text & "' and b.SY='" & frmParent.lblSY.Text & "' group by p.StudentNumber order by Fullname"
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
            Else
                str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.AcctTotal, b.TotalPayments, b.Discount, b.CurrentBalance, b.PaymentMode, b.Course, b.YearLevel, b.Section, b.SY, (b.Amount1+b.Amount2+b.Amount3+b.Amount4+b.Amount5) as OtherFees  from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber where b.Section='" & cboSection.Text & "' and b.YearLevel='" & cboYearLevelAccount.Text & "' and b.Sem='" & frmParent.lblSem.Text & "' and b.SY='" & frmParent.lblSY.Text & "' group by p.StudentNumber order by Fullname"
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
            End If
            

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Public Sub getGradeLevel()
        Try
            If frmParent.lblSem.Text = "1st Sem." Or frmParent.lblSem.Text = "2nd Sem." Then
                str = "select * from course_table where CourseDescription='Senior High School'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "course_table")
                conn.Close()

                cboYearLevelAccount.ValueMember = "course_table"
                cboYearLevelAccount.DisplayMember = "Major"
                cboYearLevelAccount.DataSource = ds.Tables("course_table")

            Else
                str = "select * from course_table where CourseDescription!='Senior High School'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "course_table")
                conn.Close()

                cboYearLevelAccount.ValueMember = "course_table"
                cboYearLevelAccount.DisplayMember = "Major"
                cboYearLevelAccount.DataSource = ds.Tables("course_table")
            End If
           

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboCourseAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getGradeLevel()
    End Sub
    Public Sub getSection()
        str = "select * from sections where YearLevel='" & cboYearLevelAccount.Text & "'"
        conn.Open()
        Dim mysda As New MySqlDataAdapter(str, conn)
        Dim ds As New DataSet
        mysda.Fill(ds, "sections")
        conn.Close()

        cboSection.ValueMember = "sections"
        cboSection.DisplayMember = "Section"
        cboSection.DataSource = ds.Tables("sections")

    End Sub

    Private Sub cboYearLevelAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYearLevelAccount.SelectedIndexChanged
        getSection()
    End Sub
End Class