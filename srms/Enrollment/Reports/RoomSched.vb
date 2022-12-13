Imports MySql.Data.MySqlClient
Public Class frmRoomSched
    Dim str As String
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            'str = "select SubjectCode, Description, Room, concat(SchedTime, ' ', LabTime) as SchedTime, Instructor, Sem, SY from registration where Room='" & cboRoom.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' group by SchedTime, Section"
            str = "select * from semsubjects where Room='" & cboRoom.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' order by SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semsubjects")
            Dim obj As New RoomsSched
            obj.SetDataSource(ds.Tables("semsubjects"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmRoomSched_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.rooms' table. You can move, or remove it, as needed.
        Me.RoomsTableAdapter.Fill(Me.DataSet2.rooms)

    End Sub
End Class