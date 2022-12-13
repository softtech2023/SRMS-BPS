Imports MySql.Data.MySqlClient
Public Class frmEditSemStudent
    Dim str As String

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If cboSearch.SelectedIndex = 0 Then

            Str = "select studentnumber, FName, MName, LName, Course, Year, Status, studentnumber from semstudent where studentnumber like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim Search As New MySqlDataAdapter(Str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "semstudent")
            dgsemstudent.DataSource = ds.Tables("semstudent")
            conn.Close()
        End If
        If cboSearch.SelectedIndex = 1 Then

            Str = "select studentnumber, FName, MName, LName, Course, Year, Status, studentnumber from semstudent where LName like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim Search As New MySqlDataAdapter(Str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "semstudent")
            dgsemstudent.DataSource = ds.Tables("semstudent")
            conn.Close()
        End If
    End Sub

    Private Sub dgsemstudent_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgsemstudent.CellContentClick

    End Sub

    Private Sub dgsemstudent_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgsemstudent.DoubleClick
        Dim i As Integer
        i = dgsemstudent.CurrentRow.Index
        frmSemStudent.lblID.Text = dgsemstudent(0, i).Value
        frmSemStudent.mskStudentNumber.Text = dgsemstudent(1, i).Value
        frmSemStudent.txtFname.Text = dgsemstudent(2, i).Value
        frmSemStudent.txtMName.Text = dgsemstudent(3, i).Value
        frmSemStudent.txtLastName.Text = dgsemstudent(4, i).Value
        frmSemStudent.cboCourse.Text = dgsemstudent(5, i).Value
        frmSemStudent.cboYear.Text = dgsemstudent(7, i).Value
        frmSemStudent.cboStatus.Text = dgsemstudent(6, i).Value
        frmSemStudent.Show()
        Me.Close()
        frmSemStudent.btnSave.Enabled = False
        frmSemStudent.btnUpdate.Enabled = True
        frmSemStudent.btnClear.Enabled = True

    End Sub

    Private Sub frmEditSemStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.semesterstude1' table. You can move, or remove it, as needed.
        Me.Semesterstude1TableAdapter.Fill(Me.DataSet.semesterstude1)
        
        str = "select * from semesterstude where Semester = '" & frmMDIParent.lblSem.Text & "' and SY = '" & frmMDIParent.lblSY.Text & "'"
        conn.Open()
        Dim mysDA As New MySqlDataAdapter(str, conn)
        Dim ds As New DataSet

        mysDA.Fill(ds, "semesterstude")
        dgsemstudent.DataSource = ds.Tables("semesterstude")
        conn.Close()
    End Sub
End Class