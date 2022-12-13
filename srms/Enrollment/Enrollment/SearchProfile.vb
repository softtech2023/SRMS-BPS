Imports MySql.Data.MySqlClient
Public Class frmSearchProfile
    Dim str As String

    Private Sub dgstudentsearch_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgstudentsearch.CellContentClick

    End Sub

    Private Sub dgstudentsearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgstudentsearch.DoubleClick
        Dim dclick As Integer
        dclick = dgstudentsearch.CurrentRow.Index
        frmStudeProfile.mskStudentNumber.Text = dgstudentsearch.Item(0, dclick).Value
        frmStudeProfile.txtFname.Text = dgstudentsearch.Item(1, dclick).Value
        frmStudeProfile.txtMName.Text = dgstudentsearch.Item(2, dclick).Value
        frmStudeProfile.txtLastName.Text = dgstudentsearch.Item(3, dclick).Value
        frmStudeProfile.txtAddress.Text = dgstudentsearch.Item(4, dclick).Value
        frmStudeProfile.mskDateofBirth.Text = dgstudentsearch.Item(5, dclick).Value
        frmStudeProfile.txtBPlace.Text = dgstudentsearch.Item(6, dclick).Value
        frmStudeProfile.cboSex.Text = dgstudentsearch.Item(7, dclick).Value
        frmStudeProfile.cboCivilStatus.Text = dgstudentsearch.Item(8, dclick).Value
        frmStudeProfile.txtContactNumber.Text = dgstudentsearch.Item(9, dclick).Value
        frmStudeProfile.txtGuardian.Text = dgstudentsearch.Item(10, dclick).Value
        frmStudeProfile.txtRelationship.Text = dgstudentsearch.Item(11, dclick).Value
        frmStudeProfile.txtGuardianContact.Text = dgstudentsearch.Item(12, dclick).Value
        frmStudeProfile.cboCourse.Text = dgstudentsearch.Item(13, dclick).Value
        frmStudeProfile.txtRemarks.Text = dgstudentsearch.Item(14, dclick).Value
        frmStudeProfile.txtnationality.Text = dgstudentsearch.Item(15, dclick).Value
        frmStudeProfile.txtElementary.Text = dgstudentsearch.Item(16, dclick).Value
        frmStudeProfile.mskElementaryDate.Text = dgstudentsearch.Item(17, dclick).Value
        frmStudeProfile.txtSecondary.Text = dgstudentsearch.Item(18, dclick).Value
        frmStudeProfile.mskSecondaryDate.Text = dgstudentsearch.Item(19, dclick).Value
        frmStudeProfile.txtLastSchool.Text = dgstudentsearch.Item(20, dclick).Value
        frmStudeProfile.mskAdmissionDate.Text = dgstudentsearch.Item(21, dclick).Value
        frmStudeProfile.txtCredentials.Text = dgstudentsearch.Item(22, dclick).Value
        frmStudeProfile.mskGraduation.Text = dgstudentsearch.Item(23, dclick).Value
        frmStudeProfile.txtSo.Text = dgstudentsearch.Item(24, dclick).Value





        frmStudeProfile.Show()
        Me.Close()
        frmStudeProfile.btnSave.Enabled = False
        frmStudeProfile.btnUpdate.Enabled = True
        frmStudeProfile.btnDelete.Enabled = True

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If cboSearch.SelectedIndex = 0 Then

            str = "select StudentNumber, FirstName, MiddleName, LastName, Address, BDate, BPlace, Sex, CivilStatus, ContactNumber, Guardian, Relationship, GuardianContact, Course, Remarks, StudentNumber from studeprofile where StudentNumber like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "studeprofile")
            dgstudentsearch.DataSource = ds.Tables("studeprofile")
            conn.Close()
        End If
        If cboSearch.SelectedIndex = 1 Then

            str = "select StudentNumber, FirstName, MiddleName, LastName, Address, BDate, BPlace, Sex, CivilStatus, ContactNumber, Guardian, Relationship, GuardianContact, Course, Remarks, StudentNumber from studeprofile where LastName like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "studeprofile")
            dgstudentsearch.DataSource = ds.Tables("studeprofile")
            conn.Close()
        End If
        If cboSearch.SelectedIndex = 2 Then

            str = "select StudentNumber, FirstName, MiddleName, LastName, Address, BDate, BPlace, Sex, CivilStatus, ContactNumber, Guardian, Relationship, GuardianContact, Course, Remarks, StudentNumber from studeprofile where Course like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "studeprofile")
            dgstudentsearch.DataSource = ds.Tables("studeprofile")
            conn.Close()
        End If
    End Sub

    Private Sub frmSearchProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.studeprofile' table. You can move, or remove it, as needed.
        Me.StudeprofileTableAdapter.Fill(Me.DataSet.studeprofile)
        'TODO: This line of code loads data into the 'DataSet.studeprofile' table. You can move, or remove it, as needed.
        Me.StudeprofileTableAdapter.Fill(Me.DataSet.studeprofile)

    End Sub
End Class