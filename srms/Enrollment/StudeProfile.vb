Imports MySql.Data.MySqlClient
Public Class frmStudeProfile
    Dim str As String


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        str = "select * from studeprofile where StudentNumber='" & mskStudentNumber.Text & "'"
        conn.Open()
        Dim mysda As New MySqlDataAdapter(str, conn)
        Dim ds As New DataSet
        mysda.Fill(ds, "studeprofile")

        If ds.Tables("studeprofile").Rows.Count = 1 Then
            MsgBox("Student Number already exist!", MsgBoxStyle.Information)
            conn.Close()
            mskStudentNumber.Focus()
            Exit Sub
        End If
        If mskStudentNumber.Text = "" Or txtFname.Text = "" Or txtMName.Text = "" Or txtLastName.Text = "" Or cboCourse.Text = "" Then
            MsgBox("Please fill-up the form completely!", MsgBoxStyle.Information)

            conn.Close()
            Exit Sub
        End If
        conn.Close()

        str = "insert into studeprofile values('" & mskStudentNumber.Text & "','" & txtFname.Text & "','" & txtMName.Text & "','" & txtLastName.Text & "','" & txtAddress.Text & "','" & mskDateofBirth.Text & "','" & txtBPlace.Text & "','" & cboSex.Text & "','" & cboCivilStatus.Text & "','" & txtContactNumber.Text & "','" & txtGuardian.Text & "','" & txtRelationship.Text & "','" & txtGuardianContact.Text & "','" & cboCourse.Text & "','" & txtRemarks.Text & "')"
        conn.Open()
        Dim mysC As New MySqlCommand(str, conn)
        mysC.ExecuteNonQuery()

        MsgBox("Data successfully saved!", MsgBoxStyle.Information, "Prompt")

        conn.Close()
        frmSearchStudents.StudeprofileTableAdapter.Fill(frmSearchStudents.DataSet.studeprofile)
        Me.StudeprofileTableAdapter.Fill(Me.DataSet.studeprofile)

        ClearFields()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If mskStudentNumber.Text = "" Then
            MsgBox("Cannot find any data to update!", MsgBoxStyle.Information)
            mskStudentNumber.Focus()
            Exit Sub
        End If
        str = "update studeprofile set StudentNumber='" & mskStudentNumber.Text & " ',FirstName='" & txtFname.Text & "',MiddleName='" & txtMName.Text & "',LastName='" & txtLastName.Text & "',Address='" & txtAddress.Text & "',BDate='" & mskDateofBirth.Text & "',BPlace='" & txtBPlace.Text & "',Sex='" & cboSex.Text & "',CivilStatus='" & cboCivilStatus.Text & "',ContactNumber='" & txtContactNumber.Text & "',Guardian='" & txtGuardian.Text & "',Relationship='" & txtRelationship.Text & "',GuardianContact='" & txtGuardianContact.Text & "',Course='" & cboCourse.Text & "',Remarks='" & txtRemarks.Text & "' where StudentNumber='" & mskStudentNumber.Text & "'"

        conn.Open()
        Dim mysC As New MySqlCommand(str, conn)
        mysC.ExecuteNonQuery()
        MsgBox("Data successfully updated!", MsgBoxStyle.Information, "Prompt")
        conn.Close()
        Me.StudeprofileTableAdapter.Fill(Me.DataSet.studeprofile)
        ClearFields()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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
            MsgBox("Data successfully deleted!", MsgBoxStyle.Information, "Prompt")
            conn.Close()
            frmSearchStudents.StudeprofileTableAdapter.Fill(frmSearchStudents.DataSet.studeprofile)
            Me.StudeprofileTableAdapter.Fill(Me.DataSet.studeprofile)

            ClearFields()
        End If
    End Sub
    Public Sub ClearFields()
        mskStudentNumber.Clear()
        txtFname.Clear()
        txtMName.Clear()
        txtLastName.Clear()
        txtAddress.Clear()
        mskDateofBirth.Clear()
        txtBPlace.Clear()
        cboSex.ResetText()
        cboCivilStatus.ResetText()
        txtContactNumber.Clear()
        txtGuardian.Clear()
        txtRelationship.Clear()
        txtGuardianContact.Clear()
        cboCourse.ResetText()
        txtRemarks.Clear()
    End Sub

    Private Sub frmStudeProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.DataSet.courses)
        'TODO: This line of code loads data into the 'DataSet.studeprofile' table. You can move, or remove it, as needed.
        Me.StudeprofileTableAdapter.Fill(Me.DataSet.studeprofile)
        cboCourse.ResetText()

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

    Private Sub dgstudentsearch_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgstudentsearch.CellContentClick

    End Sub

    Private Sub dgstudentsearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgstudentsearch.DoubleClick
        Dim dclick As Integer
        dclick = dgstudentsearch.CurrentRow.Index
        mskStudentNumber.Text = dgstudentsearch.Item(0, dclick).Value
        txtFname.Text = dgstudentsearch.Item(1, dclick).Value
        txtMName.Text = dgstudentsearch.Item(2, dclick).Value
        txtLastName.Text = dgstudentsearch.Item(3, dclick).Value
        txtAddress.Text = dgstudentsearch.Item(4, dclick).Value
        mskDateofBirth.Text = dgstudentsearch.Item(5, dclick).Value
        txtBPlace.Text = dgstudentsearch.Item(6, dclick).Value
        cboSex.Text = dgstudentsearch.Item(7, dclick).Value
        cboCivilStatus.Text = dgstudentsearch.Item(8, dclick).Value
        txtContactNumber.Text = dgstudentsearch.Item(9, dclick).Value
        txtGuardian.Text = dgstudentsearch.Item(10, dclick).Value
        txtRelationship.Text = dgstudentsearch.Item(11, dclick).Value
        txtGuardianContact.Text = dgstudentsearch.Item(12, dclick).Value
        cboCourse.Text = dgstudentsearch.Item(13, dclick).Value
        txtRemarks.Text = dgstudentsearch.Item(14, dclick).Value

    End Sub
End Class