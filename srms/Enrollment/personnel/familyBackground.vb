Imports MySql.Data.MySqlClient
Public Class frmFamilyBackground
    Dim str As String
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            str = "insert into hris_family values(0,'" & txtFullname.Text & "','" & txtRelationship.Text & "','" & Convert.ToDateTime(dtpBirthDate.Text).ToString("yyyy-MM-dd") & "','" & frmStaff.mskIDNumber.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(Str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("New record added!", MsgBoxStyle.Information)
            FormLoad()

            frmStaff.getFamily()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub FormLoad()
        txtFullname.Clear()
        txtRelationship.Clear()
        dtpBirthDate.Text = Today

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from hris_family where famID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("1 record deleted successfully!", MsgBoxStyle.Information)
                FormLoad()

                Me.Close()
                frmStaff.getFamily()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            'str = "update hris_cs set licenseTitle='" & txtTitle.Text & "',rating='" & txtRating.Text & "',examDate='" & Convert.ToDateTime(dtpExamDate.Text).ToString("yyyy-MM-dd") & "',examPlace='" & txtExamPlace.Text & "',licenseNo='" & txtLicenseNo.Text & "',validity='" & txtValidity.Text & "' where csID='" & lblID.Text & "'"
            str = "update hris_family set fullName='" & txtFullname.Text & "',relationship='" & txtRelationship.Text & "',bDate='" & Convert.ToDateTime(dtpBirthDate.Text).ToString("yyyy-MM-dd") & "' where famID='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("Updated successfully!", MsgBoxStyle.Information)
            FormLoad()
            frmStaff.getFamily()
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmFamilyBackground_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'FormLoad()
    End Sub
End Class