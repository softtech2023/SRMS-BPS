Imports MySql.Data.MySqlClient
Public Class frmStaff
    Dim str As String

    Private Sub frmStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
       
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            str = "select * from staff where Name like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "staff")
            dgProfile.DataSource = ds.Tables("staff")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            str = "update staff set IDNUmber='" & mskIDNumber.Text & "',Name='" & txtFirstName.Text & "',Position='" & txtPosition.Text & "',Department='" & txtDepartment.Text & "',DateHired='" & dtpHiredDate.Text & "',ContactNumber='" & txtContact.Text & "',Address='" & txtAddress.Text & "' where IDNumber='" & mskIDNumber.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Selected Record has been updated!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from staff where IDNumber='" & mskIDNumber.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Selected record has been deleted!", MsgBoxStyle.Information)
                conn.Close()
                FormLoad()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            str = "insert into staff values('" & mskIDNumber.Text & "','" & txtFirstName.Text & "','" & txtPosition.Text & "','" & txtDepartment.Text & "','" & txtRPay.Text & "','" & cboMStatus.Text & "','" & txtContact.Text & "','" & cboEmpStatus.Text & "','" & txtAddress.Text & "','" & txtPositionHistory.Text & "','" & txtEducationAndTrainings.Text & "','" & txtCertificatesAndLicenses.Text & "','" & txtName.Text & "','" & mskPhoneNumber.Text & "','" & txtMobile.Text & "','" & txtAddress2.Text & "','" & txtRelationship.Text & "','" & txtEmail.Text & "','" & txtNotes.Text & "','" & Convert.ToDateTime(dtpBirthDate.Text).ToString("yyyy-MM-dd") & "','" & Convert.ToDateTime(dtpHiredDate.Text).ToString("yyyy-MM-dd") & "','" & txtPagibig.Text & "','" & txtPhilHealth.Text & "','" & txtSSS.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("New Record has been added!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False

    End Sub

    Private Sub btnUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            str = "update staff set IDNumber='" & mskIDNumber.Text & "',Name='" & txtFirstName.Text & "',Position='" & txtPosition.Text & "',Department='" & txtDepartment.Text & "',RegularPay='" & txtRPay.Text & "',MaritalStatus='" & cboMStatus.Text & "',ContactNum='" & txtContact.Text & "',Status='" & cboEmpStatus.Text & "',Address='" & txtAddress.Text & "',PositionHistory='" & txtPositionHistory.Text & "',EducationAndTrainings='" & txtEducationAndTrainings.Text & "',CertificatesAndLicenses='" & txtCertificatesAndLicenses.Text & "',ContactName='" & txtName.Text & "',PhoneNumber='" & mskPhoneNumber.Text & "',Mobile='" & txtMobile.Text & "',Address2='" & txtAddress2.Text & "',Relationship='" & txtRelationship.Text & "',Email='" & txtEmail.Text & "',Notes='" & txtNotes.Text & "',BirthDate='" & Convert.ToDateTime(dtpBirthDate.Text).ToString("yyyy-MM-dd") & "',DateHired='" & Convert.ToDateTime(dtpHiredDate.Text).ToString("yyyy-MM-dd") & "',Pagibig='" & txtPagibig.Text & "',PhilHealth='" & txtPhilHealth.Text & "',SSS='" & txtSSS.Text & "' where IDNumber='" & mskIDNumber.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Selected Record has been updated!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            str = "delete from staff where IDNumber='" & mskIDNumber.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            MsgBox("Data successfully deleted!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub dgProfile_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgProfile.DoubleClick
        Dim i As Integer
        i = dgProfile.CurrentRow.Index
        mskIDNumber.Text = dgProfile.Item(0, i).Value
        txtFirstName.Text = dgProfile.Item(1, i).Value
        txtPosition.Text = dgProfile.Item(2, i).Value
        txtDepartment.Text = dgProfile.Item(3, i).Value
        txtRPay.Text = dgProfile.Item(4, i).Value
        cboMStatus.Text = dgProfile.Item(5, i).Value
        txtContact.Text = dgProfile.Item(6, i).Value
        cboEmpStatus.Text = dgProfile.Item(7, i).Value
        txtAddress.Text = dgProfile.Item(8, i).Value
        txtPositionHistory.Text = dgProfile.Item(9, i).Value
        txtEducationAndTrainings.Text = dgProfile.Item(10, i).Value
        txtCertificatesAndLicenses.Text = dgProfile.Item(11, i).Value
        txtName.Text = dgProfile.Item(12, i).Value
        mskPhoneNumber.Text = dgProfile.Item(13, i).Value
        txtMobile.Text = dgProfile.Item(14, i).Value
        txtAddress2.Text = dgProfile.Item(15, i).Value
        txtRelationship.Text = dgProfile.Item(16, i).Value
        txtEmail.Text = dgProfile.Item(17, i).Value
        txtNotes.Text = dgProfile.Item(18, i).Value
        dtpBirthDate.Text = dgProfile.Item(19, i).Value
        dtpHiredDate.Text = dgProfile.Item(20, i).Value
        txtPagibig.Text = dgProfile.Item(21, i).Value
        txtPhilHealth.Text = dgProfile.Item(22, i).Value
        txtSSS.Text = dgProfile.Item(23, i).Value

        btnSave.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub txtSearch_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from staff where Name like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "staff")
            dgProfile.DataSource = ds.Tables("staff")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Public Sub FormLoad()
        Try
            str = "select * from staff"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "staff")
            dgProfile.DataSource = ds.Tables("staff")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        dgProfile.Columns(1).Width = 200
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False

        mskIDNumber.Clear()
        txtFirstName.Clear()
        txtPosition.Clear()
        txtDepartment.Clear()
        txtContact.Clear()
        txtAddress.Clear()
        cboMStatus.ResetText()
        txtAddress.Clear()
        txtRPay.Text = "0.00"
        txtPagibig.Text = "0.00"
        txtPhilHealth.Text = "0.00"
        txtSSS.Text = "0.00"
        txtPositionHistory.Clear()
        txtCertificatesAndLicenses.Clear()
        txtName.Clear()
        mskPhoneNumber.Clear()
        txtMobile.Clear()
        txtAddress2.Clear()
        txtRelationship.Clear()
        txtEmail.Clear()
        txtNotes.Clear()
        dtpBirthDate.Text = Now
        dtpHiredDate.Text = Now
    End Sub
End Class