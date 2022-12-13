Imports MySql.Data.MySqlClient
Public Class frmByDepartment
    Dim str As String
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "SELECT * FROM staff s join srms_settings st on s.settingsID=st.settingsID where Department='" & cboDepartment.Text & "' order by s.LastName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(Str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "staff, srms_settings")
            Dim obj As New PersonnelList
            obj.SetDataSource(mysds.Tables("staff, srms_settings"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub getDepartment()
        Try
            str = "select * from staff group by Department"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "staff")
            conn.Close()

            cboDepartment.ValueMember = "Department"
            cboDepartment.DisplayMember = "Department"
            cboDepartment.DataSource = ds.Tables("staff")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmByDepartment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getDepartment()
    End Sub
End Class