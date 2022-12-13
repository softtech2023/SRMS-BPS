Imports MySql.Data.MySqlClient
Public Class frmEditDTR
    Dim str As String
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        frmSearchInstructors_Scheduling.Show()
    End Sub


    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Try
            If txtEmployeeNo.Text = "" Then
                str = "select * from hris_attendance where logDate>='" & Convert.ToDateTime(dtpFrom.Text).ToString("yyyy-MM-dd") & "' and logDate<='" & Convert.ToDateTime(dtpTo.Text).ToString("yyyy-MM-dd") & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "hris_attendance")
                dg1.DataSource = ds.Tables("hris_attendance")
                conn.Close()

                dg1.Columns(0).Visible = False
                dg1.Columns(1).Visible = False
                dg1.Columns(2).Visible = False
                dg1.Columns(3).Visible = False
                dg1.Columns(4).Width = 250
                dg1.Columns(4).HeaderText = "Log Date"
                dg1.Columns(5).Width = 410
                dg1.Columns(5).HeaderText = "Log Time"

            Else
                str = "select * from hris_attendance where IDNumber='" & txtEmployeeNo.Text & "'  and logDate>='" & Convert.ToDateTime(dtpFrom.Text).ToString("yyyy-MM-dd") & "' and logDate<='" & Convert.ToDateTime(dtpTo.Text).ToString("yyyy-MM-dd") & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "hris_attendance")
                dg1.DataSource = ds.Tables("hris_attendance")
                conn.Close()

                dg1.Columns(0).Visible = False
                dg1.Columns(1).Visible = False
                dg1.Columns(2).Visible = False
                dg1.Columns(3).Visible = False
                dg1.Columns(4).Width = 250
                dg1.Columns(4).HeaderText = "Log Date"
                dg1.Columns(5).Width = 410
                dg1.Columns(5).HeaderText = "Log Time"

            End If
            
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        For x As Integer = 0 To dg1.Rows.Count - 1
            str = "update hris_attendance set logTime='" & dg1.Item(5, x).Value & "' where logID='" & dg1.Item(0, x).Value & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

        Next
        MsgBox("Selected records has been updated successfully", MsgBoxStyle.Information)

        formLoad()
    End Sub
    Public Sub formLoad()
        txtEmployeeNo.Clear()
        txtEmployeeName.Clear()

        Try
            str = "select * from hris_attendance where IDNumber='" & txtEmployeeNo.Text & "'  and logDate>='" & Convert.ToDateTime(dtpFrom.Text).ToString("yyyy-MM-dd") & "' and logDate<='" & Convert.ToDateTime(dtpTo.Text).ToString("yyyy-MM-dd") & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "hris_attendance")
            dg1.DataSource = ds.Tables("hris_attendance")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).Visible = False
            dg1.Columns(2).Visible = False
            dg1.Columns(3).Visible = False
            dg1.Columns(4).Width = 250
            dg1.Columns(4).HeaderText = "Log Date"
            dg1.Columns(5).Width = 410
            dg1.Columns(5).HeaderText = "Log Time"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try

            str = "select s.FirstName, mid(s.MiddleName,1,1) as MiddleName, s.LastName, a.logDate, a.logTime, monthname(a.logDate) as MonthName, Year(a.logDate) as YearName, st.schoolHead, st.sHeadPosition from staff s join hris_attendance a on s.IDNumber=a.IDNumber join srms_settings st on s.settingsID=st.settingsID where a.IDNumber='" & txtEmployeeNo.Text & "'  and a.logDate>='" & Convert.ToDateTime(dtpFrom.Text).ToString("yyyy-MM-dd") & "' and a.logDate<='" & Convert.ToDateTime(dtpTo.Text).ToString("yyyy-MM-dd") & "' group by a.logDate order by a.logDate"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "staff, hris_attendance")
            Dim obj As New DTRPrinting
            obj.SetDataSource(mysds.Tables("staff, hris_attendance"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnBatchPrinting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatchPrinting.Click
        Try
            For x As Integer = 0 To dg1.Rows.Count - 1
                str = "select s.FirstName, mid(s.MiddleName,1,1) as MiddleName, s.LastName, a.logDate, a.logTime, monthname(a.logDate) as MonthName, Year(a.logDate) as YearName, st.schoolHead, st.sHeadPosition from staff s join hris_attendance a on s.IDNumber=a.IDNumber join srms_settings st on s.settingsID=st.settingsID where a.logDate>='" & Convert.ToDateTime(dtpFrom.Text).ToString("yyyy-MM-dd") & "' and a.logDate<='" & Convert.ToDateTime(dtpTo.Text).ToString("yyyy-MM-dd") & "' group by a.logDate order by a.logDate"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "staff, hris_attendance")
                Dim obj As New DTRPrinting
                obj.SetDataSource(mysds.Tables("staff, hris_attendance"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class