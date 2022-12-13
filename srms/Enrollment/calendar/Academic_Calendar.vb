Imports MySql.Data.MySqlClient
Public Class frmAcademic_Calendar
    Dim str As String
    Private Sub frmAcademic_Calendar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub
    Public Sub FormLoad()
        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False

        dtpFrom.Text = Today
        dtpTo.Text = Today
        txtTime.Clear()
        txtEvent.Clear()
        txtVenue.Clear()
        txtInCharge.Clear()

        Try
            str = "select * from calendar where SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "calendar")
            dg.DataSource = ds.Tables("calendar")
            conn.Close()
            dg.Columns(0).Visible = False
            dg.Columns(7).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            str = "insert into calendar values (0,'" & Convert.ToDateTime(dtpFrom.Text).ToString("yyyy-MM-dd") & "','" & Convert.ToDateTime(dtpTo.Text).ToString("yyyy-MM-dd") & "','" & txtTime.Text & "','" & txtEvent.Text & "','" & txtVenue.Text & "','" & txtInCharge.Text & "','" & frmParent.lblSY.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record saved!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        Dim i As Integer
        i = dg.CurrentRow.Index
        lblID.Text = dg.Item(0, i).Value
        dtpFrom.Text = dg.Item(1, i).Value
        dtpTo.Text = dg.Item(2, i).Value
        txtTime.Text = dg.Item(3, i).Value
        txtEvent.Text = dg.Item(4, i).Value
        txtVenue.Text = dg.Item(5, i).Value
        txtInCharge.Text = dg.Item(6, i).Value

        tsSave.Enabled = False
        tsUpdate.Enabled = True
        tsDelete.Enabled = True
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
                str = "delete from calendar where calendarID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Record deleted!", MsgBoxStyle.Information)
                conn.Close()
                FormLoad()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            str = "update calendar set DateFrom='" & Convert.ToDateTime(dtpFrom.Text).ToString("yyyy-MM-dd") & "',DateTo='" & Convert.ToDateTime(dtpTo.Text).ToString("yyyy-MM-dd") & "',Time='" & txtTime.Text & "',Event='" & txtEvent.Text & "',Venue='" & txtVenue.Text & "',InCharge='" & txtInCharge.Text & "' where calendarID='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record saved!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class