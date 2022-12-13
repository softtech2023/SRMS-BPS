Imports MySql.Data.MySqlClient
Public Class frmClassReplacement
    Dim str As String
    Public Sub formLoad()
        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False

        txtTime.Clear()
        txtSubject.Clear()
        txtGradeLevel.Clear()
        txtReplacement.Clear()

        txtTime.Focus()
        schoolInfo()
        classID()

        Try
            str = "select * from hr_classreplacement"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "hr_classreplacement")
            dg1.DataSource = ds.Tables("hr_classreplacement")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Emp. No."
            dg1.Columns(2).HeaderText = "Emp. Name"
            dg1.Columns(2).Width = 150
            dg1.Columns(3).HeaderText = "Position"
            dg1.Columns(4).HeaderText = "Time"
            dg1.Columns(5).HeaderText = "Subject"
            dg1.Columns(5).Width = 150
            dg1.Columns(6).HeaderText = "Grade Level"
            dg1.Columns(7).HeaderText = "Replacement"
            dg1.Columns(8).HeaderText = "From"
            dg1.Columns(9).HeaderText = "To"
            dg1.Columns(10).Visible = True


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try

    End Sub
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmsearchPersonnelForTravel.Show()
    End Sub

    Private Sub frmClassReplacement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            str = "insert into hr_classreplacement values(0,'" & txtEmployeeID.Text & "','" & txtName.Text & "','" & txtPosition.Text & "','" & txtTime.Text & "','" & txtSubject.Text & "','" & txtGradeLevel.Text & "','" & txtReplacement.Text & "','" & Convert.ToDateTime(dtpFrom.Text).ToString("yyyy-MM-dd") & "','" & Convert.ToDateTime(dtpTo.Text).ToString("yyyy-MM-dd") & "','" & lblSettingsID.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("One record has been added successfully!", MsgBoxStyle.Information)

            formLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub schoolInfo()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from srms_settings limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(Str, conn)
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
    Public Sub classID()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from hr_classreplacement order by replaceID desc limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblClassID.Text = dtReader.Item(0).ToString
                lblClassID.Text = lblClassID.Text + 1
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        lblClassID.Text = dg1.Item(0, i).Value
        txtEmployeeID.Text = dg1.Item(1, i).Value
        txtName.Text = dg1.Item(2, i).Value
        txtPosition.Text = dg1.Item(3, i).Value
        txtTime.Text = dg1.Item(4, i).Value
        txtSubject.Text = dg1.Item(5, i).Value
        txtGradeLevel.Text = dg1.Item(6, i).Value
        txtReplacement.Text = dg1.Item(7, i).Value
        dtpFrom.Text = dg1.Item(8, i).Value
        dtpTo.Text = dg1.Item(9, i).Value

        tsSave.Enabled = False
        tsUpdate.Enabled = True
        tsDelete.Enabled = True
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If ((MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes)) Then
                str = "delete from hr_classreplacement where replaceID='" & lblClassID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("1 record has been deleted!", MsgBoxStyle.Information)
                conn.Close()
                formLoad()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            str = "update hr_classreplacement set schedTime='" & txtTime.Text & "',subject='" & txtSubject.Text & "',gradeLevel='" & txtGradeLevel.Text & "',replacement='" & txtReplacement.Text & "',dateFrom='" & Convert.ToDateTime(dtpFrom.Text).ToString("yyyy-MM-dd") & "',dateTo='" & Convert.ToDateTime(dtpTo.Text).ToString("yyyy-MM-dd") & "' where replaceID='" & lblClassID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("One record has been added successfully!", MsgBoxStyle.Information)
            formLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Try
            str = "SELECT s.IDNumber, s.FirstName, s.MiddleName, s.LastName, s.empPosition, cp.schedTime, cp.subject, cp.gradeLevel, cp.replacement, cp.dateFrom, cp.dateTo, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition, st.Division, st.Region, st.letterHead FROM staff s join hr_classreplacement cp on s.IDNumber=cp.IDNumber join srms_settings st on cp.settingsID=st.settingsID where s.IDNumber='" & txtEmployeeID.Text & "' and dateFrom='" & Convert.ToDateTime(dtpFrom.Text).ToString("yyyy-MM-dd") & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "hr_classreplacement, staff, srms_settings")
            Dim obj As New Class_Replacement
            obj.SetDataSource(mysds.Tables("hr_classreplacement, staff, srms_settings"))
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
End Class