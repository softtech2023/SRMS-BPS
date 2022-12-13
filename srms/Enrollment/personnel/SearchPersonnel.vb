Imports MySql.Data.MySqlClient
Public Class frmSearchPersonnel
    Dim str As String
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from staff where LastName like '%" & txtSearch.Text & "%' or IDNumber like '%" & txtSearch.Text & "%'"
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

    Private Sub frmSearchPersonnel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    End Sub

    Private Sub dgProfile_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgProfile.DoubleClick
        Dim i As Integer
        i = dgProfile.CurrentRow.Index
        frmStaff.mskIDNumber.Text = dgProfile.Item(0, i).Value
        frmStaff.lblIDNumber.Text = dgProfile.Item(0, i).Value
        frmStaff.txtFirstName.Text = dgProfile.Item(1, i).Value
        frmStaff.txtMiddleName.Text = dgProfile.Item(2, i).Value
        frmStaff.txtLastName.Text = dgProfile.Item(3, i).Value
        frmStaff.txtNameExtn.Text = dgProfile.Item(4, i).Value
        frmStaff.cboPrefix.Text = dgProfile.Item(5, i).Value
        frmStaff.txtJobTitle.Text = dgProfile.Item(6, i).Value
        frmStaff.txtPosition.Text = dgProfile.Item(7, i).Value
        frmStaff.txtDepartment.Text = dgProfile.Item(8, i).Value
        frmStaff.cboMStatus.Text = dgProfile.Item(9, i).Value
        frmStaff.cboEmpStatus.Text = dgProfile.Item(10, i).Value
        frmStaff.dtpBirthDate.Text = dgProfile.Item(11, i).Value
        frmStaff.txtBirthPlace.Text = dgProfile.Item(12, i).Value
        frmStaff.cboSex.Text = dgProfile.Item(13, i).Value
        frmStaff.txtHeight.Text = dgProfile.Item(14, i).Value
        frmStaff.txtWeight.Text = dgProfile.Item(15, i).Value
        frmStaff.txtBloodType.Text = dgProfile.Item(16, i).Value
        frmStaff.txtGSIS.Text = dgProfile.Item(17, i).Value
        frmStaff.txtPagibig.Text = dgProfile.Item(18, i).Value
        frmStaff.txtPhilHealth.Text = dgProfile.Item(19, i).Value
        frmStaff.txtSSS.Text = dgProfile.Item(20, i).Value
        frmStaff.txtTIN.Text = dgProfile.Item(21, i).Value
        frmStaff.dtpHiredDate.Text = dgProfile.Item(22, i).Value
        frmStaff.txtResHouseNo.Text = dgProfile.Item(23, i).Value
        frmStaff.txtResStreet.Text = dgProfile.Item(24, i).Value
        frmStaff.txtResVillage.Text = dgProfile.Item(25, i).Value
        frmStaff.txtResBrgy.Text = dgProfile.Item(26, i).Value
        frmStaff.txtResCity.Text = dgProfile.Item(27, i).Value
        frmStaff.txtResProvince.Text = dgProfile.Item(28, i).Value
        frmStaff.txtResZip.Text = dgProfile.Item(29, i).Value
        frmStaff.txtPerHouseNo.Text = dgProfile.Item(30, i).Value
        frmStaff.txtPerStreet.Text = dgProfile.Item(31, i).Value
        frmStaff.txtPerVillage.Text = dgProfile.Item(32, i).Value
        frmStaff.txtPerBrgy.Text = dgProfile.Item(33, i).Value
        frmStaff.txtPerCity.Text = dgProfile.Item(34, i).Value
        frmStaff.txtPerProvince.Text = dgProfile.Item(35, i).Value
        frmStaff.txtPerZip.Text = dgProfile.Item(36, i).Value
        frmStaff.txtTelNo.Text = dgProfile.Item(37, i).Value
        frmStaff.txtMobile.Text = dgProfile.Item(38, i).Value
        frmStaff.txtEmailAd.Text = dgProfile.Item(39, i).Value

        frmuseraccounts.txtUsername.Text = dgProfile.Item(0, i).Value
        frmuseraccounts.txtFName.Text = dgProfile.Item(1, i).Value
        frmuseraccounts.txtMName.Text = dgProfile.Item(2, i).Value
        frmuseraccounts.txtLName.Text = dgProfile.Item(3, i).Value
        frmuseraccounts.txtEmail.Text = dgProfile.Item(39, i).Value

        frmStaff.tsSave.Enabled = False
        frmStaff.tsUpdate.Enabled = True
        frmStaff.tsDelete.Enabled = True
        frmStaff.tsPrint.Enabled = True

        frmStaff.btnFamily.Enabled = True
        frmStaff.btnEduc.Enabled = True
        frmStaff.btnCSE.Enabled = True
        frmStaff.btnWe.Enabled = True
        frmStaff.btnVW.Enabled = True
        frmStaff.btnTrainings.Enabled = True
        frmStaff.btnOtherInfo.Enabled = True

        Me.Close()

    End Sub
End Class