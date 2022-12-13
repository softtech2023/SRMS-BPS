﻿Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging
Imports System.IO
Public Class frmStudeProfile
    Dim str As String

    Public Sub FormLoad()
        Try
            mskStudentNumber.Clear()
            txtFName.Clear()
            txtMName.Clear()
            txtLName.Clear()
            txtNameExt.Clear()
            cboSex.ResetText()
            cboCivilStatus.ResetText()
            txtReligion.ResetText()
            txtBloodType.Clear()
            mskTelNumber.Clear()
            mskMobileNumber.Clear()
            txtHighSchool.Clear()
            txtJHSAddress.Clear()
            txtCollege.Clear()
            txtCollegeAddress.Clear()
            txtElementary.Clear()
            txtElemAddress.Clear()
            txtRequirements.Clear()
            dtpBirthDate.Text = Today
            dtpAdmission.Text = Today
            dtpGraduation.Text = Today
            txtGuardian.ResetText()
            btnSet.Clear()
            txtGuardianContact.Clear()
            cboCourse.ResetText()
            cboEthnicity.ResetText()
            txtMonthlyIncome.Text = 0
            txtGuardianRelationship.Clear()
            txtFather.Clear()
            txtFatherOccupation.Clear()
            txtMother.Clear()
            txtMotherOccupation.Clear()
            txtRFID.Clear()
            cboMuncipality.ResetText()
            cboBrgy.ResetText()
            txtSubdivision.Clear()
            txtStudeId.Clear()

            lblGuardianOccupation.Text = ""
            txtElementary.Clear()
            txtElemGenAve.Clear()
            cboEligibility.ResetText()
            txtJHSGenAve.Clear()
            txtHighSchool.Clear()
            txtJHSAddress.Clear()
            txtelemSchoolYear.Clear()
            cboEligibility.ResetText()

            txtBirthPlace.Clear()
            PictureBox1.Image = My.Resources._default
            cboCitizenship.ResetText()
            cboEligibility.ResetText()
            mskElemGradDate.Clear()
            txtJHSGenAve.Clear()
            mskJHSGradDate.Clear()
            txtElemSchoolID.Clear()
            txtJHSSchoolID.Clear()
            txtPEPTRating.Clear()
            mskPEPTExamDate.Clear()
            txtALSRating.Clear()
            txtAlsTestingCenter.Clear()
            txtNameExt.Clear()
            cboClassification.ResetText()
            txtFatherContactNo.Clear()
            txtMotherContactNo.Clear()

            mskStudentNumber.Focus()
            mskStudentNumber.ReadOnly = False


            getProvince()
            getCity()
            getBrgy()
            getReligion()
            getEthnicity()
            schoolInfo()
            getGuardian()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
        tsLRN.Enabled = False
        tsPrint.Enabled = False
        tsCAV.Enabled = False

        chk1.Checked = False
        chk2.Checked = False
        chk3.Checked = False
        chk4.Checked = False
        chk5.Checked = False
        chk6.Checked = False
        chk7.Checked = False
        chk8.Checked = False
        chk9.Checked = False
        req1.Checked = False
        req2.Checked = False
        req3.Checked = False

        txtESCIDNo.Clear()
       
    End Sub

    Private Sub frmStudeProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CoursesTableAdapter.Fill(Me.DataSet.courses)
        'TODO: This line of code loads data into the 'DataSet.courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.DataSet.courses)
        FormLoad()

    End Sub
    Public Sub checkBox()
        If chk1.Checked = True Then
            lbl1.Text = "Submitted"
        Else
            lbl1.Text = "Not Yet Submitted"
        End If

        If chk2.Checked = True Then
            lbl2.Text = "Submitted"
        Else
            lbl2.Text = "Not Yet Submitted"

        End If
        If chk3.Checked = True Then
            lbl3.Text = "Submitted"
        Else
            lbl3.Text = "Not Yet Submitted"
        End If

        If chk4.Checked = True Then
            lbl4.Text = "Submitted"
        Else
            lbl4.Text = "Not Yet Submitted"
        End If

        If chk5.Checked = True Then
            lbl5.Text = "Submitted"

        Else
            lbl5.Text = "Not Yet Submitted"

        End If

        If chk6.Checked = True Then
            lbl6.Text = "Submitted"

        Else
            lbl6.Text = "Not Yet Submitted"

        End If

        If chk7.Checked = True Then
            lbl7.Text = "Submitted"

        Else
            lbl7.Text = "Not Yet Submitted"

        End If

        If chk8.Checked = True Then
            lbl8.Text = "Submitted"

        Else
            lbl8.Text = "Not Yet Submitted"

        End If
        If chk9.Checked = True Then
            lbl9.Text = "Submitted"

        Else
            lbl9.Text = "Not Yet Submitted"

        End If
    End Sub
    Public Sub checkBoxESC()
        If req1.Checked = True Then
            lblReq1.Text = "Submitted"

        Else
            lblReq1.Text = "Not Yet Submitted"

        End If

        If req2.Checked = True Then
            lblReq2.Text = "Submitted"

        Else
            lblReq2.Text = "Not Yet Submitted"

        End If

        If req3.Checked = True Then
            lblReq3.Text = "Submitted"

        Else
            lblReq3.Text = "Not Yet Submitted"

        End If
    End Sub
    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSelectSchool1.ShowDialog()
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSelectSchool2.ShowDialog()
    End Sub
    Private Sub tsSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSearch.Click
        frmCompleteList.ShowDialog()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            'check duplicate student number
            str = "select * from studeprofile where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")

            If ds.Tables("studeprofile").Rows.Count = 1 Then
                MsgBox("Student Number already exist!", MsgBoxStyle.Exclamation)
                conn.Close()
                mskStudentNumber.Focus()
                Exit Sub
            End If
            If mskStudentNumber.Text = "" Then
                MsgBox("Student number is required. Please fill-up the form completely!", MsgBoxStyle.Exclamation)
                mskStudentNumber.Focus()
                Exit Sub
            End If

            conn.Close()
            'end

            'check duplicate names
            str = "select * from studeprofile where FirstName='" & txtFName.Text & "' and LastName='" & txtLName.Text & "'"
            conn.Open()
            Dim mysda1 As New MySqlDataAdapter(str, conn)
            Dim ds1 As New DataSet
            mysda1.Fill(ds1, "studeprofile")

            If ds1.Tables("studeprofile").Rows.Count = 1 Then
                MsgBox("Record already exist!", MsgBoxStyle.Exclamation)
                conn.Close()
                Exit Sub
            End If
            'end

            If mskStudentNumber.Text = "" Then
                MsgBox("Student number is required. Please fill-up the form completely!", MsgBoxStyle.Exclamation)
                mskStudentNumber.Focus()
                Exit Sub
            End If
            conn.Close()
            'end

            If txtFName.Text = "" Then
                MsgBox("First name is required!", MsgBoxStyle.Exclamation)
                txtFName.Focus()
                Exit Sub
            End If
            If txtLName.Text = "" Then
                MsgBox("Last name is required!", MsgBoxStyle.Exclamation)
                txtLName.Focus()
                Exit Sub
            End If

            If cboProvince.Text = "" Then
                MsgBox("Provincial address is required!", MsgBoxStyle.Exclamation)
                cboProvince.Focus()
                Exit Sub
            End If

            If cboMuncipality.Text = "" Then
                MsgBox("City or Municipality is required!", MsgBoxStyle.Exclamation)
                cboMuncipality.Focus()
                Exit Sub
            End If

            If cboSex.Text = "" Then
                MsgBox("Sex/Gender is required!", MsgBoxStyle.Exclamation)
                cboSex.Focus()
                Exit Sub
            End If

            Dim ImagePath, name As String
            ImagePath = txtImagePath.Text.Replace("\", "\\")
            name = txtFName.Text.Replace("'", "''")

            'convert image to byte
            Dim mstream As New System.IO.MemoryStream()
            PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            'declare arrImage as Byte to read buffer
            Dim arrImage() As Byte = mstream.GetBuffer()
            mstream.Close()

            str = "insert into studeprofile (StudentNumber, FirstName, MiddleName, LastName, Sex, CivilStatus, BirthPlace, Citizenship, Religion, BloodType, TelNumber, MobileNumber, HighSchool, HSAddress, College, CAddress, Requirements, Encoder, BirthDate, AdmissionDate, GraduationDate, Guardian, GuardianContact, GuardianAddress, ImagePath, Course, Elementary, ElemAddress, GuardianRelationship, GuardianTelNo, EmailAddress, Father, FOccupation, Mother, MOccupation, Age, Title, Pronoun, Pronoun2, Pronoun3, Ethnicity, ParentsMonthly, Province, City, Brgy, Sitio, settingsID, guardianOccupation, elemSY, elemAve, elemGradDate, eligibility, jhsAve, jhsGradDate, elemSchoolID, jhsSchoolID, peptRating, peptExamDate, alsRating, alsTestingCenter, nameExt, rfid, StudeID, classification, fContactNo, mContactNo) values('" & mskStudentNumber.Text & "','" & name & "','" & txtMName.Text & "','" & txtLName.Text & "','" & cboSex.Text & "','" & cboCivilStatus.Text & "','" & txtBirthPlace.Text & "','" & cboCitizenship.Text & "','" & txtReligion.Text & "','" & txtBloodType.Text & "','" & mskTelNumber.Text & "','" & mskMobileNumber.Text & "','" & txtHighSchool.Text & "','" & txtJHSAddress.Text & "','" & txtCollege.Text & "','" & txtCollegeAddress.Text & "','" & txtRequirements.Text & "','" & frmParent.lblUser.Text & "','" & Convert.ToDateTime(dtpBirthDate.Text).ToString("yyyy-MM-dd") & "','" & Convert.ToDateTime(dtpAdmission.Text).ToString("yyyy-MM-dd") & "','" & Convert.ToDateTime(dtpGraduation.Text).ToString("yyyy-MM-dd") & "','" & txtGuardian.Text & "','" & txtGuardianContact.Text & "','" & btnSet.Text & "','','" & cboCourse.Text & "','" & txtElementary.Text & "','" & txtElemAddress.Text & "','" & txtGuardianRelationship.Text & "','" & mskGuardianTel.Text & "','" & txtEmail.Text & "','" & txtFather.Text & "','" & txtFatherOccupation.Text & "','" & txtMother.Text & "','" & txtMotherOccupation.Text & "','" & txtAge.Text & "','" & lblTitle.Text & "','" & lblPronoun.Text & "','" & lblPronoun2.Text & "','" & lblPronoun3.Text & "','" & cboEthnicity.Text & "','" & txtMonthlyIncome.Text & "','" & cboProvince.Text & "','" & cboMuncipality.Text & "','" & cboBrgy.Text & "','" & txtSubdivision.Text & "','" & lblSettingsID.Text & "','" & lblGuardianOccupation.Text & "','" & txtelemSchoolYear.Text & "','" & txtElemGenAve.Text & "','" & mskElemGradDate.Text & "','" & cboEligibility.Text & "','" & txtJHSGenAve.Text & "','" & mskJHSGradDate.Text & "','" & txtElemSchoolID.Text & "','" & txtJHSSchoolID.Text & "','" & txtPEPTRating.Text & "','" & mskPEPTExamDate.Text & "','" & txtALSRating.Text & "','" & txtAlsTestingCenter.Text & "','" & txtNameExt.Text & "','" & txtRFID.Text & "','" & txtStudeId.Text & "','" & cboClassification.Text & "','" & txtFatherContactNo.Text & "','" & txtMotherContactNo.Text & "')"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.Parameters.AddWithValue("@Sub_Image", arrImage)
            mysC.ExecuteNonQuery()
            conn.Close()

            'profile image
            saveImage()

            'create user account
            Dim pass As String

            pass = getSHA1Hash(Convert.ToDateTime(dtpBirthDate.Text).ToString("yyyy-MM-dd"))

            'save requirements
            str = "insert into stude_requirements values(0,'" & mskStudentNumber.Text & "','" & chk1.Text & "','" & lbl1.Text & "','" & chk2.Text & "','" & lbl2.Text & "','" & chk3.Text & "','" & lbl3.Text & "','" & chk4.Text & "','" & lbl4.Text & "','" & chk5.Text & "','" & lbl5.Text & "','" & chk6.Text & "','" & lbl6.Text & "','" & chk7.Text & "','" & lbl7.Text & "','" & chk8.Text & "','" & lbl8.Text & "','" & chk9.Text & "','" & lbl9.Text & "')"
            conn.Open()
            Dim mysC2 As New MySqlCommand(str, conn)
            mysC2.ExecuteNonQuery()
            conn.Close()

            'save escrequirements
            str = "insert into stude_esc_requirements values(0,'" & mskStudentNumber.Text & "','" & req1.Text & "','" & lblReq1.Text & "','" & req2.Text & "','" & lblReq2.Text & "','" & req3.Text & "','" & lblReq3.Text & "','" & txtESCIDNo.Text & "')"
            conn.Open()
            Dim mysC4 As New MySqlCommand(str, conn)
            mysC4.ExecuteNonQuery()
            conn.Close()


            'insert into user accounts
            str = "insert into users values('" & mskStudentNumber.Text & "','" & pass & "','Student','" & txtFName.Text & "','" & txtMName.Text & "','" & txtLName.Text & "','" & txtEmail.Text & "','avatar.png','active','" & Convert.ToDateTime(dtpAdmission.Text).ToString("yyyy-MM-dd") & "','" & mskStudentNumber.Text & "')"
            conn.Open()
            Dim mysC3 As New MySqlCommand(str, conn)
            mysC3.ExecuteNonQuery()
            conn.Close()
            If (MsgBox("Record successfully saved.  Would you like to save another record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                mskStudentNumber.Focus()
            Else
                Me.Close()
            End If

            mskStudentNumber.Focus()
            conn.Close()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click

        Try

            'create user account
            Dim pass As String

            pass = getSHA1Hash(Convert.ToDateTime(dtpBirthDate.Text).ToString("yyyy-MM-dd"))

            'convert image to byte
            Dim mstream As New System.IO.MemoryStream()
            PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            'declare arrImage as Byte to read buffer
            Dim arrImage() As Byte = mstream.GetBuffer()
            mstream.Close()

            str = "update studeprofile set StudentNumber='" & mskStudentNumber.Text & "',FirstName='" & txtFName.Text & "',MiddleName='" & txtMName.Text & "',LastName='" & txtLName.Text & "',Sex='" & cboSex.Text & "',CivilStatus='" & cboCivilStatus.Text & "',BirthPlace='" & txtBirthPlace.Text & "',Citizenship='" & cboCitizenship.Text & "',Religion='" & txtReligion.Text & "',BloodType='" & txtBloodType.Text & "',TelNumber='" & mskTelNumber.Text & "',MobileNumber='" & mskMobileNumber.Text & "',HighSchool='" & txtHighSchool.Text & "',HSAddress='" & txtJHSAddress.Text & "',College='" & txtCollege.Text & "',CAddress='" & txtCollegeAddress.Text & "',Requirements='" & txtRequirements.Text & "',Encoder='" & frmParent.lblUser.Text & "',BirthDate='" & Convert.ToDateTime(dtpBirthDate.Text).ToString("yyyy-MM-dd") & "',AdmissionDate='" & Convert.ToDateTime(dtpAdmission.Text).ToString("yyyy-MM-dd") & "',GraduationDate='" & Convert.ToDateTime(dtpGraduation.Text).ToString("yyyy-MM-dd") & "',Guardian='" & txtGuardian.Text & "',GuardianContact='" & txtGuardianContact.Text & "',GuardianAddress='" & btnSet.Text & "',Course='" & cboCourse.Text & "',Elementary='" & txtElementary.Text & "',ElemAddress='" & txtElemAddress.Text & "',GuardianRelationship='" & txtGuardianRelationship.Text & "',GuardianTelNo='" & mskGuardianTel.Text & "',EmailAddress='" & txtEmail.Text & "',Father='" & txtFather.Text & "',FOccupation='" & txtFatherOccupation.Text & "',Mother='" & txtMother.Text & "',MOccupation='" & txtMotherOccupation.Text & "',Age='" & txtAge.Text & "',Title='" & lblTitle.Text & "',Pronoun='" & lblPronoun.Text & "',Pronoun2='" & lblPronoun2.Text & "',Pronoun3='" & lblPronoun3.Text & "',Ethnicity='" & cboEthnicity.Text & "',ParentsMonthly='" & txtMonthlyIncome.Text & "',Province='" & cboProvince.Text & "',City='" & cboMuncipality.Text & "',Brgy='" & cboBrgy.Text & "',Sitio='" & txtSubdivision.Text & "',guardianOccupation='" & lblGuardianOccupation.Text & "',elemSY='" & txtelemSchoolYear.Text & "',elemAve='" & txtElemGenAve.Text & "',elemGradDate='" & mskElemGradDate.Text & "',eligibility='" & cboEligibility.Text & "',jhsAve='" & txtJHSGenAve.Text & "',jhsGradDate='" & mskJHSGradDate.Text & "',elemSchoolID='" & txtElemSchoolID.Text & "',jhsSchoolID='" & txtJHSSchoolID.Text & "',peptRating='" & txtPEPTRating.Text & "',peptExamDate='" & mskPEPTExamDate.Text & "',alsRating='" & txtALSRating.Text & "',alsTestingCenter='" & txtAlsTestingCenter.Text & "',nameExt='" & txtNameExt.Text & "',rfid='" & txtRFID.Text & "',StudeID='" & txtStudeId.Text & "',classification='" & cboClassification.Text & "',fContactNo='" & txtFatherContactNo.Text & "',mContactNo='" & txtMotherContactNo.Text & "' where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.Parameters.AddWithValue("@Sub_Image", arrImage)
            mysC.ExecuteNonQuery()
            conn.Close()

            'update user accounts
            str = "update users set password='" & pass & "', fName='" & txtFName.Text & "',mName='" & txtMName.Text & "',lName='" & txtLName.Text & "', email='" & txtEmail.Text & "' where username='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysc1 As New MySqlCommand(str, conn)
            mysc1.ExecuteNonQuery()
            conn.Close()

            'update semesterstude
            str = "update semesterstude set FName='" & txtFName.Text & "',MName='" & txtMName.Text & "',LName='" & txtLName.Text & "' where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysc2 As New MySqlCommand(str, conn)
            mysc2.ExecuteNonQuery()
            conn.Close()

            'update studeaccount
            str = "update studeaccount set FirstName='" & txtFName.Text & "',MiddleName='" & txtMName.Text & "',LastName='" & txtLName.Text & "' where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysc3 As New MySqlCommand(str, conn)
            mysc3.ExecuteNonQuery()
            conn.Close()

            str = "update registration set StudentNumber='" & mskStudentNumber.Text & "',FirstName='" & txtFName.Text & "',MiddleName='" & txtMName.Text & "',LastName='" & txtLName.Text & "' where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysC4 As New MySqlCommand(str, conn)
            mysC4.ExecuteNonQuery()
            conn.Close()

            str = "update docs set StudentNumber='" & mskStudentNumber.Text & "',FName='" & txtFName.Text & "',MName='" & txtMName.Text & "',LName='" & txtLName.Text & "' where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysC5 As New MySqlCommand(str, conn)
            mysC5.ExecuteNonQuery()
            conn.Close()

            'update profile image
            str = "delete from profimage where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysc6 As New MySqlCommand(str, conn)
            mysc6.ExecuteNonQuery()
            conn.Close()

            saveImage()

            'save requirements
            str = "update stude_requirements set req1='" & chk1.Text & "',req2='" & chk2.Text & "',req3='" & chk3.Text & "',req4='" & chk4.Text & "',req5='" & chk5.Text & "',req6='" & chk6.Text & "',req7='" & chk7.Text & "',req8='" & chk8.Text & "',req9='" & chk9.Text & "',req1Stat='" & lbl1.Text & "',req2Stat='" & lbl2.Text & "',req3Stat='" & lbl3.Text & "',req4Stat='" & lbl4.Text & "',req5Stat='" & lbl5.Text & "',req6Stat='" & lbl6.Text & "',req7Stat='" & lbl7.Text & "',req8Stat='" & lbl8.Text & "',req9Stat='" & lbl9.Text & "' where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysC7 As New MySqlCommand(str, conn)
            mysC7.ExecuteNonQuery()
            conn.Close()

            'save escrequirements
            str = "update stude_esc_requirements set escIDNumber='" & txtESCIDNo.Text & "',req1='" & req1.Text & "',req2='" & req2.Text & "',req3='" & req3.Text & "',req1Stat='" & lblReq1.Text & "',req2Stat='" & lblReq2.Text & "',req3Stat='" & lblReq3.Text & "' where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysC8 As New MySqlCommand(str, conn)
            mysC8.ExecuteNonQuery()
            conn.Close()

            MsgBox("Data successfully updated!", MsgBoxStyle.Information, "Prompt")
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If mskStudentNumber.Text = "" Then
                MsgBox("Please select records to delete!", MsgBoxStyle.Information)
                mskStudentNumber.Focus()
                Exit Sub
            End If
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from studeprofile where StudentNumber='" & mskStudentNumber.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()

                'delete from useraccounts
                str = "delete from users where username='" & mskStudentNumber.Text & "'"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str, conn)
                mysc1.ExecuteNonQuery()
                MsgBox("Data successfully deleted!", MsgBoxStyle.Information, "Prompt")
                conn.Close()
                FormLoad()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If txtImagePath.Text = "" Then
                MsgBox("Cannot find any image to view", MsgBoxStyle.Information)
                Exit Sub
            End If
            Process.Start(txtImagePath.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        FormLoad()
        Me.Close()
    End Sub

    Private Sub tsCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsCapture.Click
        frmCapture.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSelectSchool0.ShowDialog()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        tsSave.PerformClick()
    End Sub

    Public Sub getTitle()
        Dim i As String
        If cboSex.Text = "Male" Then
            i = "MR."
            lblTitle.Text = i
        Else
            i = "MS."
            lblTitle.Text = i
        End If
    End Sub
    Public Sub getPronoun()
        Dim i As String
        If cboSex.Text = "Male" Then
            i = "him"
            lblPronoun.Text = i
        Else
            i = "her"
            lblPronoun.Text = i
        End If
    End Sub
    Public Sub getPronoun2()
        Dim i As String
        If cboSex.Text = "Male" Then
            i = "He"
            lblPronoun2.Text = i
        Else
            i = "She"
            lblPronoun2.Text = i
        End If
    End Sub
    Public Sub getPronoun3()
        Dim i As String
        If cboSex.Text = "Male" Then
            i = "his"
            lblPronoun3.Text = i
        Else
            i = "her"
            lblPronoun3.Text = i
        End If
    End Sub

    Private Sub cboSex_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSex.SelectedIndexChanged
        getTitle()
        getPronoun()
        getPronoun2()
        getPronoun3()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSelectSchool0.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSelectSchool1.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSelectSchool2.ShowDialog()
    End Sub
    Public Sub getAge()
        Try
            Dim strBirth As String
            Dim intAge As Integer
            strBirth = dtpBirthDate.Text
            intAge = Math.Floor(DateDiff(DateInterval.Month, DateValue(strBirth), Now()) / 12)
            txtAge.Text = intAge
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub getProvince()
        Try
            str = "select Province from studeprofile group by Province order by Province"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")
            conn.Close()
            cboProvince.ValueMember = "studeprofile"
            cboProvince.DisplayMember = "Province"
            cboProvince.DataSource = ds.Tables("studeprofile")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getCity()
        Try
            str = "select City from studeprofile group by City order by City"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")
            conn.Close()
            cboMuncipality.ValueMember = "studeprofile"
            cboMuncipality.DisplayMember = "City"
            cboMuncipality.DataSource = ds.Tables("studeprofile")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getBrgy()
        Try
            str = "select Brgy from studeprofile group by Brgy order by Brgy"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")
            conn.Close()
            cboBrgy.ValueMember = "studeprofile"
            cboBrgy.DisplayMember = "Brgy"
            cboBrgy.DataSource = ds.Tables("studeprofile")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getReligion()
        Try
            str = "select Religion from studeprofile group by Religion order by Religion"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")
            conn.Close()
            txtReligion.ValueMember = "studeprofile"
            txtReligion.DisplayMember = "Religion"
            txtReligion.DataSource = ds.Tables("studeprofile")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getEthnicity()
        Try
            str = "select Ethnicity from studeprofile group by Ethnicity order by Ethnicity"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")
            conn.Close()
            cboEthnicity.ValueMember = "studeprofile"
            cboEthnicity.DisplayMember = "Ethnicity"
            cboEthnicity.DataSource = ds.Tables("studeprofile")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
       
    End Sub
    Public Sub getStudeNumber()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select StudentNumber from studeprofile order by StudentNumber desc limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                mskStudentNumber.Text = dtReader.Item(0).ToString
                mskStudentNumber.Text = mskStudentNumber.Text + 1
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub tsLRN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsLRN.Click
        frmChangeLRN.ShowDialog()
    End Sub

    Private Sub dtpBirthDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpBirthDate.ValueChanged
        getAge()
    End Sub

    Public Sub schoolInfo()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from srms_settings limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmSelectSchool0.ShowDialog()
    End Sub

    Private Sub txtCollege_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCollege.Click
        frmSelectSchool0.ShowDialog()
    End Sub

    Private Sub txtCollegeAddress_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCollegeAddress.Click
        frmSelectSchool0.ShowDialog()
    End Sub

    Public Sub getPhoto()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select profImage from profimage where StudentNumber='" & mskStudentNumber.Text & "'"

            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                Dim arrImage() As Byte
                arrImage = dtReader.Item(0)
                Dim mstream As New System.IO.MemoryStream(arrImage)
                PictureBox1.Image = Image.FromStream(mstream)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try
            Dim imgpath As String
            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.png;*.bmp;*.gif)|*.jpg;*.png;*.bmp;*.gif"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                PictureBox1.ImageLocation = imgpath

            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub tsPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsPrint.Click
        Try
            'str = "select * from studeprofile where StudentNumber='" & mskStudentNumber.Text & "'"
            str = "SELECT * FROM studeprofile s join semesterstude ss on s.StudentNumber=ss.StudentNumber join srms_settings st on s.settingsID=st.settingsID join profimage pi on s.StudentNumber=pi.StudentNumber where ss.StudentNumber='" & mskStudentNumber.Text & "' and ss.SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile")
            Dim obj As New StudeProfile
            obj.SetDataSource(mysds.Tables("studeprofile"))
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

    Private Sub brnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnBrowse.Click
        Try
            Dim imgpath As String
            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.png;*.bmp;*.gif)|*.jpg;*.png;*.bmp;*.gif"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                PictureBox1.ImageLocation = imgpath

            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub RequestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequestToolStripMenuItem.Click
        frmCAVReq.ShowDialog()
    End Sub

    Private Sub PrintCAVForm1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintCAVForm1ToolStripMenuItem.Click
        Try
            str = "Select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, p.BirthDate, p.BirthPlace, concat(p.Sitio,' ',p.Brgy,' ',p.City,' ',p.Province) as presentAddress, p.MobileNumber, ss.SY, st.SchoolName, st.SchoolAddress, st.SchoolIDJHS, st.Region, st.Division, st.SchoolHead, st.sHeadPosition, st.Region, cr.ctrlNo, cr.applicationDate, cr.purpose, cr.releasedDate from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID join cavreq cr on p.StudentNumber=cr.StudentNumber where ss.StudentNumber='" & mskStudentNumber.Text & "' order by semstudentid desc"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, srms_settings, semesterstude, cavreq")
            Dim obj As New CAVForm1
            obj.SetDataSource(mysds.Tables("studeprofile, srms_settings, semesterstude, cavreq"))
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

    Private Sub CAVForm4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CAVForm4ToolStripMenuItem.Click
        Try
            str = "Select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, p.BirthDate, p.BirthPlace, concat(p.Sitio,' ',p.Brgy,' ',p.City,' ',p.Province) as presentAddress, p.MobileNumber, ss.SY, st.SchoolName, st.SchoolAddress, st.SchoolIDJHS, st.Region, st.Division, st.SchoolHead, st.sHeadPosition, st.Region, cr.ctrlNo, cr.applicationDate, cr.purpose, cr.releasedDate, p.Pronoun3 from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID join cavreq cr on p.StudentNumber=cr.StudentNumber where ss.StudentNumber='" & mskStudentNumber.Text & "' order by semstudentid desc"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, srms_settings, semesterstude, cavreq")
            Dim obj As New CAVForm4
            obj.SetDataSource(mysds.Tables("studeprofile, srms_settings, semesterstude, cavreq"))
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

    Private Sub CAVForm5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CAVForm5ToolStripMenuItem.Click
        Try
            str = "Select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, p.BirthDate, p.BirthPlace, concat(p.Sitio,' ',p.Brgy,' ',p.City,' ',p.Province) as presentAddress, p.MobileNumber, ss.SY, st.SchoolName, st.SchoolAddress, st.SchoolIDJHS, st.Region, st.regionAddress, st.Division, st.SchoolHead, st.sHeadPosition, st.Region, cr.ctrlNo, cr.applicationDate, cr.purpose, cr.releasedDate, p.Pronoun3 from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID join cavreq cr on p.StudentNumber=cr.StudentNumber where ss.StudentNumber='" & mskStudentNumber.Text & "' order by semstudentid desc"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, srms_settings, semesterstude, cavreq")
            Dim obj As New CAVForm5
            obj.SetDataSource(mysds.Tables("studeprofile, srms_settings, semesterstude, cavreq"))
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

    Public Sub saveImage()
        'convert image to byte
        Dim mstream As New System.IO.MemoryStream()
        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        'declare arrImage as Byte to read buffer
        Dim arrImage() As Byte = mstream.GetBuffer()
        mstream.Close()

        str = "INSERT INTO profimage (profID, profImage, StudentNumber) values(0,@Sub_Image,'" & mskStudentNumber.Text & "')"
        conn.Open()
        Dim mysc5 As New MySqlCommand(str, conn)
        'parameters for image
        mysc5.Parameters.AddWithValue("@Sub_Image", arrImage)
        mysc5.ExecuteNonQuery()
        'MessageBox.Show("Done!", "DialogBox", MessageBoxButtons.OK, MessageBoxIcon.Information)
        conn.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        txtGuardian.Text = txtFather.Text
        txtGuardianRelationship.Text = lblFather.Text
        lblGuardianOccupation.Text = txtFatherOccupation.Text
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        txtGuardian.Text = txtMother.Text
        txtGuardianRelationship.Text = labelMother.Text
        lblGuardianOccupation.Text = txtMotherOccupation.Text
    End Sub

    Public Sub getGuardian()
        Try
            str = "select * from studeprofile group by Guardian order by Guardian "
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "qualifications")
            conn.Close()

            txtGuardian.ValueMember = "Guardian"
            txtGuardian.DisplayMember = "Guardian"
            txtGuardian.DataSource = ds.Tables("qualifications")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub chk1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk1.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk2.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk3.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk4.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk5.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk6.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk7.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk8.CheckedChanged
        checkBox()

    End Sub

    Private Sub req1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles req1.CheckedChanged
        checkBoxESC()
    End Sub

    Private Sub req2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles req2.CheckedChanged
        checkBoxESC()
    End Sub

    Private Sub req3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles req3.CheckedChanged
        checkBoxESC()
    End Sub

    Public Sub getESCReq()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from stude_esc_requirements where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblReq1.Text = dtReader.Item(3)
                lblReq2.Text = dtReader.Item(5)
                lblReq3.Text = dtReader.Item(7)
                txtESCIDNo.Text = dtReader.Item(8)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Public Sub CheckTheBox()
        If lblReq1.Text = "Submitted" Then
            req1.Checked = True
        Else
            req1.Checked = False
        End If

        If lblReq2.Text = "Submitted" Then
            req2.Checked = True
        Else
            req2.Checked = False
        End If

        If lblReq3.Text = "Submitted" Then
            req3.Checked = True
        Else
            req3.Checked = False
        End If
    End Sub

    Private Sub lblReq1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'CheckTheBox()
    End Sub

    Private Sub lblReq2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'CheckTheBox()
    End Sub

    Private Sub lblReq3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'CheckTheBox()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CheckTheBox()
    End Sub

    Private Sub lblReq1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblReq1.TextChanged
        CheckTheBox()
    End Sub

    Private Sub lblReq2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblReq2.TextChanged
        CheckTheBox()
    End Sub

    Private Sub lblReq3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblReq3.TextChanged
        CheckTheBox()
    End Sub

    Public Sub getRequirements()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from stude_requirements where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lbl1.Text = dtReader.Item(3)
                lbl2.Text = dtReader.Item(5)
                lbl3.Text = dtReader.Item(7)
                lbl4.Text = dtReader.Item(9)
                lbl5.Text = dtReader.Item(11)
                lbl6.Text = dtReader.Item(13)
                lbl7.Text = dtReader.Item(15)
                lbl8.Text = dtReader.Item(17)
                lbl9.Text = dtReader.Item(19)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Public Sub CheckTheBoxRequirements()
        If lbl1.Text = "Submitted" Then
            chk1.Checked = True
        Else
            chk1.Checked = False
        End If

        If lbl2.Text = "Submitted" Then
            chk2.Checked = True
        Else
            chk2.Checked = False
        End If

        If lbl3.Text = "Submitted" Then
            chk3.Checked = True
        Else
            chk3.Checked = False
        End If

        If lbl4.Text = "Submitted" Then
            chk4.Checked = True
        Else
            chk4.Checked = False
        End If

        If lbl5.Text = "Submitted" Then
            chk5.Checked = True
        Else
            chk5.Checked = False
        End If

        If lbl6.Text = "Submitted" Then
            chk6.Checked = True
        Else
            chk6.Checked = False
        End If

        If lbl7.Text = "Submitted" Then
            chk7.Checked = True
        Else
            chk7.Checked = False
        End If

        If lbl8.Text = "Submitted" Then
            chk8.Checked = True
        Else
            chk8.Checked = False
        End If

        If lbl9.Text = "Submitted" Then
            chk9.Checked = True
        Else
            chk9.Checked = False
        End If
    End Sub

    Private Sub lbl1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl1.TextChanged
        CheckTheBoxRequirements()
    End Sub

    Private Sub lbl2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl2.TextChanged
        CheckTheBoxRequirements()
    End Sub

    Private Sub lbl3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl3.TextChanged
        CheckTheBoxRequirements()
    End Sub

    Private Sub lbl4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl4.TextChanged
        CheckTheBoxRequirements()
    End Sub

    Private Sub lbl5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl5.TextChanged
        CheckTheBoxRequirements()
    End Sub

    Private Sub lbl6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl6.TextChanged
        CheckTheBoxRequirements()
    End Sub

    Private Sub lbl7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl7.TextChanged
        CheckTheBoxRequirements()
    End Sub

    Private Sub lbl8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl8.TextChanged
        CheckTheBoxRequirements()
    End Sub

    Private Sub lbl9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl9.TextChanged
        CheckTheBoxRequirements()
    End Sub

    Private Sub chk9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk9.CheckedChanged
        checkBox()
    End Sub
End Class