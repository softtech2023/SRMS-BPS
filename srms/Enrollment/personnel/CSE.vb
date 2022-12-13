Imports MySql.Data.MySqlClient
Public Class frmCSE
    Dim str As String
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            str = "insert into hris_cs values(0,'" & txtTitle.Text & "','" & txtRating.Text & "','" & Convert.ToDateTime(dtpExamDate.Text).ToString("yyyy-MM-dd") & "','" & txtExamPlace.Text & "','" & txtLicenseNo.Text & "','" & txtValidity.Text & "','" & frmStaff.mskIDNumber.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("New record added!", MsgBoxStyle.Information)
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub FormLoad()
        txtTitle.Clear()
        txtRating.Clear()
        dtpExamDate.Text = Today
        txtExamPlace.Clear()
        txtLicenseNo.Clear()
        txtValidity.Clear()


        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False

        txtTitle.Focus()

        frmStaff.getCSE()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from hris_cs where csID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("1 record deleted successfully!", MsgBoxStyle.Information)
                FormLoad()

                Me.Close()
                frmStaff.getCSE()

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            str = "update hris_cs set licenseTitle='" & txtTitle.Text & "',rating='" & txtRating.Text & "',examDate='" & Convert.ToDateTime(dtpExamDate.Text).ToString("yyyy-MM-dd") & "',examPlace='" & txtExamPlace.Text & "',licenseNo='" & txtLicenseNo.Text & "',validity='" & txtValidity.Text & "' where csID='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("Updated successfully!", MsgBoxStyle.Information)
            FormLoad()
            frmStaff.getCSE()
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmCSE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'FormLoad()
    End Sub
End Class