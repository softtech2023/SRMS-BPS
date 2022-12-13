Imports MySql.Data.MySqlClient
Public Class frmSearchStudents
    Dim str As String

   

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

    Private Sub frmSearchStudents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.studeprofile' table. You can move, or remove it, as needed.
        Me.StudeprofileTableAdapter.Fill(Me.DataSet.studeprofile)

    End Sub

    Private Sub dgstudentsearch_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgstudentsearch.CellContentClick
        

    End Sub

    Private Sub dgstudentsearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgstudentsearch.DoubleClick
        Dim dclick As Integer
        dclick = dgstudentsearch.CurrentRow.Index
        frmSemStudent.mskStudentNumber.Text = dgstudentsearch.Item(0, dclick).Value
        frmSemStudent.txtFname.Text = dgstudentsearch.Item(1, dclick).Value
        frmSemStudent.txtMName.Text = dgstudentsearch.Item(2, dclick).Value
        frmSemStudent.txtLastName.Text = dgstudentsearch.Item(3, dclick).Value
        frmSemStudent.cboCourse.Text = dgstudentsearch.Item(13, dclick).Value
        frmSemStudent.Show()
        Me.Close()
    End Sub
End Class