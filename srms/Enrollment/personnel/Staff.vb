Imports MySql.Data.MySqlClient
Public Class frmStaff
    Dim str As String

    Private Sub frmStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            str = "update staff set IDNUmber='" & mskIDNumber.Text & "',Name='" & txtFirstName.Text & "',Position='" & txtJobTitle.Text & "',Department='" & txtDepartment.Text & "',DateHired='" & dtpHiredDate.Text & "',ContactNumber='" & txtMobile.Text & "',Address='" & txtBirthPlace.Text & "' where IDNumber='" & mskIDNumber.Text & "'"
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

        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
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
    Public Sub FormLoad()

        schoolInfo()

        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
        tsPrint.Enabled = False

        btnFamily.Enabled = False
        btnEduc.Enabled = False
        btnCSE.Enabled = False
        btnWe.Enabled = False
        btnVW.Enabled = False
        btnTrainings.Enabled = False
        btnOtherInfo.Enabled = False

        mskIDNumber.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        txtNameExtn.Clear()
        cboPrefix.ResetText()
        txtJobTitle.Clear()
        txtPosition.Clear()
        txtDepartment.Clear()
        cboMStatus.ResetText()
        cboEmpStatus.ResetText()
        dtpBirthDate.Text = Now
        txtBirthPlace.Clear()
        cboSex.ResetText()
        txtHeight.Clear()
        txtWeight.Clear()
        txtBloodType.Clear()
        txtGSIS.Clear()
        txtPagibig.Clear()
        txtPhilHealth.Clear()
        txtSSS.Clear()
        txtTIN.Clear()
        dtpHiredDate.Text = Now
        txtResHouseNo.Clear()
        txtResStreet.Clear()
        txtResVillage.Clear()
        txtResBrgy.Clear()
        txtResCity.Clear()
        txtResProvince.Clear()
        txtResZip.Clear()
        txtPerHouseNo.Clear()
        txtPerStreet.Clear()
        txtPerVillage.Clear()
        txtPerBrgy.Clear()
        txtPerCity.Clear()
        txtPerProvince.Clear()
        txtPerZip.Clear()
        txtTelNo.Clear()
        txtMobile.Clear()
        txtEmailAd.Clear()

        mskIDNumber.Focus()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            If txtFirstName.Text = "" Then
                MsgBox("First Name is required!", MsgBoxStyle.Exclamation)
                txtFirstName.Focus()
                Exit Sub
            End If

            If txtLastName.Text = "" Then
                MsgBox("Last Name is required!", MsgBoxStyle.Exclamation)
                txtLastName.Focus()
                Exit Sub
            End If

            str = "insert into staff values('" & mskIDNumber.Text & "','" & txtFirstName.Text & "','" & txtMiddleName.Text & "','" & txtLastName.Text & "','" & txtNameExtn.Text & "','" & cboPrefix.Text & "','" & txtJobTitle.Text & "','" & txtPosition.Text & "','" & txtDepartment.Text & "','" & cboMStatus.Text & "','" & cboEmpStatus.Text & "','" & Convert.ToDateTime(dtpBirthDate.Text).ToString("yyyy-MM-dd") & "','" & txtBirthPlace.Text & "','" & cboSex.Text & "','" & txtHeight.Text & "','" & txtWeight.Text & "','" & txtBloodType.Text & "','" & txtGSIS.Text & "','" & txtPagibig.Text & "','" & txtPhilHealth.Text & "','" & txtSSS.Text & "','" & txtTIN.Text & "','" & Convert.ToDateTime(dtpHiredDate.Text).ToString("yyyy-MM-dd") & "','" & txtResHouseNo.Text & "','" & txtResStreet.Text & "','" & txtResVillage.Text & "','" & txtResBrgy.Text & "','" & txtResCity.Text & "','" & txtResProvince.Text & "','" & txtResZip.Text & "','" & txtPerHouseNo.Text & "','" & txtResStreet.Text & "','" & txtPerVillage.Text & "','" & txtPerBrgy.Text & "','" & txtPerCity.Text & "','" & txtPerProvince.Text & "','" & txtPerZip.Text & "','" & txtTelNo.Text & "','" & txtMobile.Text & "','" & txtEmailAd.Text & "','" & lblSettingsID.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            'insert into user accounts table
            Dim pass As String

            pass = getSHA1Hash(Convert.ToDateTime(dtpBirthDate.Text).ToString("yyyy-MM-dd"))

            'str = "insert into users values('" & mskIDNumber.Text & "','" & pass & "','Teacher','" & txtEmail.Text & "')"
            'conn.Open()
            'Dim mysC2 As New MySqlCommand(str, conn)
            'mysC2.ExecuteNonQuery()
            'conn.Close()

            MsgBox("New Record has been added!", MsgBoxStyle.Information)
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            'update staff profile
            str = "update staff set IDNumber='" & mskIDNumber.Text & "',FirstName='" & txtFirstName.Text & "',MiddleName='" & txtMiddleName.Text & "',LastName='" & txtLastName.Text & "',NameExtn='" & txtNameExtn.Text & "',prefix='" & cboPrefix.Text & "',jobTitle='" & txtJobTitle.Text & "',empPosition='" & txtPosition.Text & "',Department='" & txtDepartment.Text & "',MaritalStatus='" & cboMStatus.Text & "',empStatus='" & cboEmpStatus.Text & "',BirthDate='" & Convert.ToDateTime(dtpBirthDate.Text).ToString("yyyy-MM-dd") & "',BirthPlace='" & txtBirthPlace.Text & "',Sex='" & cboSex.Text & "',height='" & txtHeight.Text & "',weight='" & txtWeight.Text & "',bloodType='" & txtBloodType.Text & "',gsis='" & txtGSIS.Text & "',pagibig='" & txtPagibig.Text & "',philHealth='" & txtPhilHealth.Text & "',sssNo='" & txtSSS.Text & "',tinNo='" & txtTIN.Text & "',dateHired='" & Convert.ToDateTime(dtpHiredDate.Text).ToString("yyyy-MM-dd") & "',resHouseNo='" & txtResHouseNo.Text & "',resStreet='" & txtResStreet.Text & "',resVillage='" & txtResVillage.Text & "',resBarangay='" & txtResBrgy.Text & "',resCity='" & txtResCity.Text & "',resProvince='" & txtResProvince.Text & "',resZipCode='" & txtResZip.Text & "',perHouseNo='" & txtPerHouseNo.Text & "',perStreet='" & txtResStreet.Text & "',perVillage='" & txtPerVillage.Text & "',perBarangay='" & txtPerBrgy.Text & "',perCity='" & txtPerCity.Text & "',perProvince='" & txtPerProvince.Text & "',perZipCode='" & txtPerZip.Text & "',empTelNo='" & txtTelNo.Text & "',empMobile='" & txtMobile.Text & "',empEmail='" & txtEmailAd.Text & "' where IDNumber='" & lblIDNumber.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            'update semsubjects
            str = "update semsubjects set IDNumber='" & mskIDNumber.Text & "',Instructor='" & txtFirstName.Text & " " & txtLastName.Text & "'  where IDNumber='" & lblIDNumber.Text & "'"
            conn.Open()
            Dim mysc1 As New MySqlCommand(str, conn)
            mysc1.ExecuteNonQuery()
            conn.Close()

            MsgBox("Selected Record has been updated!", MsgBoxStyle.Information)
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
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

        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSearch.Click
        frmSearchPersonnel.ShowDialog()
    End Sub

    Public Sub getCSE()
        Try
            str = "select * from hris_cs where IDNumber='" & mskIDNumber.Text & "' order by csID desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "hris_cs")
            dgCSE.DataSource = ds.Tables("hris_cs")
            conn.Close()

            dgCSE.Columns(0).Visible = False
            dgCSE.Columns(1).HeaderText = "Civil Service Exam"
            dgCSE.Columns(1).Width = 240
            dgCSE.Columns(2).HeaderText = "Rating"
            dgCSE.Columns(3).HeaderText = "Exam Date"
            dgCSE.Columns(4).HeaderText = "Place of Exam"
            dgCSE.Columns(4).Width = 240
            dgCSE.Columns(5).HeaderText = "License No."
            dgCSE.Columns(6).HeaderText = "Validity"
            dgCSE.Columns(7).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub


    Private Sub mskIDNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskIDNumber.TextChanged
        getFamily()
        getEduc()
        getCSE()
        getWE()
        getVW()
        getTrainings()
        getOtherInfo()
    End Sub


    Private Sub chkPermanent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPermanent.CheckedChanged
        If chkPermanent.Checked = True Then
            txtPerHouseNo.Text = txtResHouseNo.Text
            txtPerStreet.Text = txtResStreet.Text
            txtPerVillage.Text = txtResVillage.Text
            txtPerBrgy.Text = txtResBrgy.Text
            txtPerCity.Text = txtResCity.Text
            txtPerProvince.Text = txtResProvince.Text
            txtPerZip.Text = txtResZip.Text
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCSE.Click
        frmCSE.ShowDialog()
    End Sub

    Private Sub dgCSE_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCSE.DoubleClick
        Dim i As Integer
        i = dgCSE.CurrentRow.Index
        frmCSE.lblID.Text = dgCSE.Item(0, i).Value
        frmCSE.txtTitle.Text = dgCSE.Item(1, i).Value
        frmCSE.txtRating.Text = dgCSE.Item(2, i).Value
        frmCSE.dtpExamDate.Text = dgCSE.Item(3, i).Value
        frmCSE.txtExamPlace.Text = dgCSE.Item(4, i).Value
        frmCSE.txtLicenseNo.Text = dgCSE.Item(5, i).Value
        frmCSE.txtValidity.Text = dgCSE.Item(6, i).Value

        frmCSE.ShowDialog()
        frmCSE.btnSave.Enabled = False
        frmCSE.btnUpdate.Enabled = True
        frmCSE.btnDelete.Enabled = True

    End Sub
    Public Sub getWE()
        Try
            str = "select * from hris_we where IDNumber='" & mskIDNumber.Text & "' order by weID desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "hris_we")
            dgWE.DataSource = ds.Tables("hris_we")
            conn.Close()
            dgWE.Columns(0).Visible = False
            dgWE.Columns(1).HeaderText = "From"
            dgWE.Columns(2).HeaderText = "To"
            dgWE.Columns(3).HeaderText = "Position Title"
            dgWE.Columns(3).Width = 250
            dgWE.Columns(4).HeaderText = "Office"
            dgWE.Columns(4).Width = 250
            dgWE.Columns(5).HeaderText = "Monthly Salary"
            dgWE.Columns(6).HeaderText = "Salary Grade"
            dgWE.Columns(7).HeaderText = "Appointment Status"
            dgWE.Columns(8).HeaderText = "Gov't. Service?"
            dgWE.Columns(9).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub btnWe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWe.Click
        frmWE.ShowDialog()
    End Sub
    Public Sub getVW()
        Try
            str = "select * from hris_vw where IDNumber='" & mskIDNumber.Text & "' order by vwID desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "hris_vw")
            dgVW.DataSource = ds.Tables("hris_vw")
            conn.Close()
            dgVW.Columns(0).Visible = False
            dgVW.Columns(1).HeaderText = "Organization Name"
            dgVW.Columns(1).Width = 200
            dgVW.Columns(2).HeaderText = "Organization Address"
            dgVW.Columns(2).Width = 200
            dgVW.Columns(3).HeaderText = "From"
            dgVW.Columns(4).HeaderText = "To"
            dgVW.Columns(5).HeaderText = "No. of Hours"
            dgVW.Columns(6).HeaderText = "Position/Nature of Work"
            dgVW.Columns(6).Width = 150
            dgWE.Columns(7).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub
    Public Sub getTrainings()
        Try
            str = "select * from hris_trainings where IDNumber='" & mskIDNumber.Text & "' order by trainingID desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "hris_trainings")
            dgTrainings.DataSource = ds.Tables("hris_trainings")
            conn.Close()
            dgTrainings.Columns(0).Visible = False
            dgTrainings.Columns(1).HeaderText = "Training Title/Programs"
            dgTrainings.Columns(1).Width = 260
            dgTrainings.Columns(2).HeaderText = "From"
            dgTrainings.Columns(3).HeaderText = "To"
            dgTrainings.Columns(4).HeaderText = "No. of Hours"
            dgTrainings.Columns(5).HeaderText = "Training Type"
            dgTrainings.Columns(6).HeaderText = "Conducted by/Sponsored by"
            dgTrainings.Columns(6).Width = 220
            dgTrainings.Columns(7).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub getEduc()
        Try
            str = "select * from hris_educ where IDNumber='" & mskIDNumber.Text & "' order by educID desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "hris_educ")
            dgEducational.DataSource = ds.Tables("hris_educ")
            conn.Close()
            dgEducational.Columns(0).Visible = False
            dgEducational.Columns(1).HeaderText = "Level"
            dgEducational.Columns(2).HeaderText = "School Name"
            dgEducational.Columns(2).Width = 150
            dgEducational.Columns(3).HeaderText = "Basic Education/Degree/Course"
            dgEducational.Columns(3).Width = 150
            dgEducational.Columns(4).HeaderText = "From"
            dgEducational.Columns(5).HeaderText = "To"
            dgEducational.Columns(6).HeaderText = "Highest Level/Units Eearned"
            dgEducational.Columns(6).Width = 150
            dgEducational.Columns(7).HeaderText = "Year Graduated"
            dgEducational.Columns(8).HeaderText = "Scholarship"
            dgEducational.Columns(8).Width = 150
            dgEducational.Columns(9).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub getFamily()
        Try
            str = "select * from hris_family where IDNumber='" & mskIDNumber.Text & "' order by famID desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "hris_family")
            dgFamily.DataSource = ds.Tables("hris_family")
            conn.Close()
            dgFamily.Columns(0).Visible = False
            dgFamily.Columns(1).HeaderText = "Full Name"
            dgFamily.Columns(1).Width = 420
            dgFamily.Columns(2).HeaderText = "Relationship"
            dgFamily.Columns(2).Width = 230
            dgFamily.Columns(3).HeaderText = "Birth Date"
            dgFamily.Columns(3).Width = 220
            dgFamily.Columns(4).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub getOtherInfo()
        Try
            str = "select * from hris_oi where IDNumber='" & mskIDNumber.Text & "' order by oiID desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "hris_oi")
            dgOI.DataSource = ds.Tables("hris_oi")
            conn.Close()
            dgOI.Columns(0).Visible = False
            dgOI.Columns(1).HeaderText = "Info Type"
            dgOI.Columns(1).Width = 430
            dgOI.Columns(2).HeaderText = "Info Details"
            dgOI.Columns(2).Width = 430
            dgOI.Columns(3).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub cboOption_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOption.SelectedIndexChanged
        Try
            If cboOption.SelectedIndex = 0 Then

                str = "select * from hris_oi where IDNumber='" & mskIDNumber.Text & "' and infoType='MEMBERSHIP IN ASSOCIATION/ORGANIZATION' order by oiID desc"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "hris_oi")
                dgOI.DataSource = ds.Tables("hris_oi")
                conn.Close()
                dgOI.Columns(0).Visible = False
                dgOI.Columns(1).HeaderText = "Info Type"
                dgOI.Columns(1).Width = 430
                dgOI.Columns(2).HeaderText = "Info Details"
                dgOI.Columns(2).Width = 430
                dgOI.Columns(3).Visible = False
            ElseIf cboOption.SelectedIndex = 1 Then
                str = "select * from hris_oi where IDNumber='" & mskIDNumber.Text & "' and infoType='NON-ACADEMIC DISTINCTIONS / RECOGNITION' order by oiID desc"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "hris_oi")
                dgOI.DataSource = ds.Tables("hris_oi")
                conn.Close()
                dgOI.Columns(0).Visible = False
                dgOI.Columns(1).HeaderText = "Info Type"
                dgOI.Columns(1).Width = 430
                dgOI.Columns(2).HeaderText = "Info Details"
                dgOI.Columns(2).Width = 430
                dgOI.Columns(3).Visible = False
            Else
                str = "select * from hris_oi where IDNumber='" & mskIDNumber.Text & "' and infoType='SPECIAL SKILLS and HOBBIES' order by oiID desc"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "hris_oi")
                dgOI.DataSource = ds.Tables("hris_oi")
                conn.Close()
                dgOI.Columns(0).Visible = False
                dgOI.Columns(1).HeaderText = "Info Type"
                dgOI.Columns(1).Width = 430
                dgOI.Columns(2).HeaderText = "Info Details"
                dgOI.Columns(2).Width = 430
                dgOI.Columns(3).Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnFamily_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFamily.Click
        frmFamilyBackground.ShowDialog()
    End Sub

    Private Sub dgFamily_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFamily.DoubleClick
        Dim i As Integer
        i = dgFamily.CurrentRow.Index

        frmFamilyBackground.lblID.Text = dgFamily.Item(0, i).Value
        frmFamilyBackground.txtFullname.Text = dgFamily.Item(1, i).Value
        frmFamilyBackground.txtRelationship.Text = dgFamily.Item(2, i).Value
        frmFamilyBackground.dtpBirthDate.Text = dgFamily.Item(3, i).Value

        frmFamilyBackground.ShowDialog()
        frmFamilyBackground.btnSave.Enabled = False
        frmFamilyBackground.btnUpdate.Enabled = True
        frmFamilyBackground.btnDelete.Enabled = True

    End Sub

    Private Sub btnEduc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEduc.Click
        frmEducation.ShowDialog()
    End Sub

    Private Sub dgEducational_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgEducational.DoubleClick
        Dim i As Integer
        i = dgEducational.CurrentRow.Index

        frmEducation.lblID.Text = dgEducational.Item(0, i).Value
        frmEducation.cboLevel.Text = dgEducational.Item(1, i).Value
        frmEducation.txtSchoolName.Text = dgEducational.Item(2, i).Value
        frmEducation.txtCourse.Text = dgEducational.Item(3, i).Value
        frmEducation.txtFrom.Text = dgEducational.Item(4, i).Value
        frmEducation.txtTo.Text = dgEducational.Item(5, i).Value
        frmEducation.txtHigestLevel.Text = dgEducational.Item(6, i).Value
        frmEducation.txtYearGraduated.Text = dgEducational.Item(7, i).Value
        frmEducation.txtScholarship.Text = dgEducational.Item(8, i).Value

        frmEducation.ShowDialog()

        frmEducation.btnSave.Enabled = False
        frmEducation.btnUpdate.Enabled = True
        frmEducation.btnDelete.Enabled = True
    End Sub

    Private Sub dgWE_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgWE.DoubleClick
        Dim i As Integer
        i = dgWE.CurrentRow.Index
        frmWE.lblID.Text = dgWE.Item(0, i).Value
        frmWE.txtFrom.Text = dgWE.Item(1, i).Value
        frmWE.txtTo.Text = dgWE.Item(2, i).Value
        frmWE.txtPosition.Text = dgWE.Item(3, i).Value
        frmWE.txtOffice.Text = dgWE.Item(4, i).Value
        frmWE.txtSalary.Text = dgWE.Item(5, i).Value
        frmWE.txtSalaryGrade.Text = dgWE.Item(6, i).Value
        frmWE.txtAppointStatus.Text = dgWE.Item(7, i).Value
        frmWE.cboGovService.Text = dgWE.Item(8, i).Value

        frmWE.ShowDialog()
        frmWE.btnSave.Enabled = False
        frmWE.btnUpdate.Enabled = True
        frmWE.btnDelete.Enabled = True
    End Sub

    Private Sub btnVW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVW.Click
        frmVW.ShowDialog()
    End Sub

    Private Sub dgVW_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgVW.DoubleClick
        Dim i As Integer
        i = dgVW.CurrentRow.Index

        frmVW.lblID.Text = dgVW.Item(0, i).Value
        frmVW.txtOrgName.Text = dgVW.Item(1, i).Value
        frmVW.txtAddress.Text = dgVW.Item(2, i).Value
        frmVW.dtpStarted.Text = dgVW.Item(3, i).Value
        frmVW.dtpEnded.Text = dgVW.Item(4, i).Value
        frmVW.txtHours.Text = dgVW.Item(5, i).Value
        frmVW.txtPosition.Text = dgVW.Item(6, i).Value

        frmVW.ShowDialog()
        frmVW.btnSave.Enabled = False
        frmVW.btnUpdate.Enabled = True
        frmVW.btnDelete.Enabled = True

    End Sub

    Private Sub btnTrainings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrainings.Click
        frmTrainings.ShowDialog()
    End Sub

    Private Sub btnOtherInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtherInfo.Click
        frmOtherInfo.ShowDialog()
    End Sub

    Private Sub dgTrainings_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTrainings.DoubleClick
        Dim i As Integer
        i = dgTrainings.CurrentRow.Index

        frmTrainings.lblID.Text = dgTrainings.Item(0, i).Value
        frmTrainings.txtTrainingTitle.Text = dgTrainings.Item(1, i).Value
        frmTrainings.dtpStarted.Text = dgTrainings.Item(2, i).Value
        frmTrainings.dtpEnded.Text = dgTrainings.Item(3, i).Value
        frmTrainings.txtHours.Text = dgTrainings.Item(4, i).Value
        frmTrainings.cboType.Text = dgTrainings.Item(5, i).Value
        frmTrainings.txtSponsor.Text = dgTrainings.Item(6, i).Value

        frmTrainings.Show()
        frmTrainings.btnSave.Enabled = False
        frmTrainings.btnUpdate.Enabled = True
        frmTrainings.btnDelete.Enabled = True
    End Sub


    Private Sub dgOI_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgOI.DoubleClick
        Dim i As Integer
        i = dgOI.CurrentRow.Index

        frmOtherInfo.lblID.Text = dgOI.Item(0, i).Value
        frmOtherInfo.cboType.Text = dgOI.Item(1, i).Value
        frmOtherInfo.txtTitle.Text = dgOI.Item(2, i).Value

        frmOtherInfo.ShowDialog()
        frmOtherInfo.btnSave.Enabled = False
        frmOtherInfo.btnUpdate.Enabled = True
        frmOtherInfo.btnDelete.Enabled = True
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

    Public Sub getProfile()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from staff where IDNumber='" & mskIDNumber.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()

            If dtReader.Read Then
                txtFirstName.Text = dtReader(1)
                txtMiddleName.Text = dtReader(2)
                txtLastName.Text = dtReader(3)
                txtNameExtn.Text = dtReader(4)
                cboPrefix.Text = dtReader(5)
                txtJobTitle.Text = dtReader(6)
                txtPosition.Text = dtReader(7)
                txtDepartment.Text = dtReader(8)
                cboMStatus.Text = dtReader(9)
                cboEmpStatus.Text = dtReader(10)
                dtpBirthDate.Text = dtReader(11)
                txtBirthPlace.Text = dtReader(12)
                cboSex.Text = dtReader(13)
                txtHeight.Text = dtReader(14)
                txtWeight.Text = dtReader(15)
                txtBloodType.Text = dtReader(16)
                txtGSIS.Text = dtReader(17)
                txtPagibig.Text = dtReader(18)
                txtPhilHealth.Text = dtReader(19)
                txtSSS.Text = dtReader(20)
                txtTIN.Text = dtReader(21)
                dtpHiredDate.Text = dtReader(22)
                txtResHouseNo.Text = dtReader(23)
                txtResStreet.Text = dtReader(24)
                txtResVillage.Text = dtReader(25)
                txtResBrgy.Text = dtReader(26)
                txtResCity.Text = dtReader(27)
                txtResProvince.Text = dtReader(28)
                txtResZip.Text = dtReader(29)
                txtPerHouseNo.Text = dtReader(30)
                txtPerStreet.Text = dtReader(31)
                txtPerVillage.Text = dtReader(32)
                txtPerBrgy.Text = dtReader(33)
                txtPerCity.Text = dtReader(34)
                txtPerProvince.Text = dtReader(35)
                txtPerZip.Text = dtReader(36)
                txtTelNo.Text = dtReader(37)
                txtMobile.Text = dtReader(38)
                txtEmailAd.Text = dtReader(39)


            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class