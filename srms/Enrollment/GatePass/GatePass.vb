Imports MySql.Data.MySqlClient
Public Class frmGatePass
    Dim str As String
    Public Sub FormLoad()
        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
        tsSearch.Enabled = True
        tsClose.Enabled = True

        dtpDate.Text = Today
        txtName.Clear()
        txtAddress.Clear()
        txtOffice.Clear()
        txtOfficeAddress.Clear()
        txtPersonsToMeet.Clear()
        txtFeedback.Clear()
        txtPurpose.Clear()
        txtRemarks.Clear()

        txtVisitorNo.Focus()

        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select max(VisitorNo) from gatepass"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtVisitorNo.Text = dtReader.Item(0).ToString
                txtVisitorNo.Text = txtVisitorNo.Text + 1
                txtVisitorNo.Focus()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub frmGatePass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try

            str = "select * from gatepass where VisitorNo='" & txtVisitorNo.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "gatepass")

            If ds.Tables("gatepass").Rows.Count = 1 Then
                MsgBox("Visitor's Number already exist!", MsgBoxStyle.Information)
                conn.Close()
                txtVisitorNo.Focus()
                Exit Sub
            End If
            conn.Close()

            If txtVisitorNo.Text = "" Then
                MsgBox("Visitor's No. is required!", MsgBoxStyle.Critical)
                Exit Sub
                txtVisitorNo.Focus()
            End If



            str = "insert into gatepass values('0','" & txtVisitorNo.Text & "','" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") & "','" & dtpTime.Text & "','" & txtName.Text & "','" & txtAddress.Text & "','" & txtOffice.Text & "','" & txtOfficeAddress.Text & "','" & txtPersonsToMeet.Text & "','" & txtPurpose.Text & "','" & txtFeedback.Text & "','" & txtRemarks.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record saved!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            conn.Close()
        End Try
    End Sub

    Private Sub tsSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSearch.Click
        frmSearchGatePass.ShowDialog()
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            str = "update gatepass set VisitorNo='" & txtVisitorNo.Text & "',VisitDate='" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") & "',VisitTime='" & dtpTime.Text & "',VisitorsName='" & txtName.Text & "',Address='" & txtAddress.Text & "',Office='" & txtOffice.Text & "',OfficeAddress='" & txtOfficeAddress.Text & "',InCharge='" & txtPersonsToMeet.Text & "',Purpose='" & txtPurpose.Text & "',Feedback='" & txtFeedback.Text & "',Remarks='" & txtRemarks.Text & "' where visitID='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record updated!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            conn.Close()
        End Try
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from gatepass where visitID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Record deleted!", MsgBoxStyle.Information)
                conn.Close()
                FormLoad()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            conn.Close()
        End Try
    End Sub

    Private Sub tsClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsClose.Click
        Me.Close()
    End Sub
End Class