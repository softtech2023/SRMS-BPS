Imports MySql.Data.MySqlClient
Public Class frmSearchSemesterStudent
    Dim str As String

    Private Sub frmSearchSemesterStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.semesterstudent' table. You can move, or remove it, as needed.
        ' Me.SemesterstudentTableAdapter.Fill(Me.DataSet.semesterstudent)

        str = "select * from semesterstude where Semester = '" & frmMain.lblSem.Text & "' and SY = '" & frmMain.lblSY.Text & "'"
        conn.Open()
        Dim mysDA As New MySqlDataAdapter(str, conn)
        Dim ds As New DataSet

        mysDA.Fill(ds, "semesterstude")

        dgsemstudent.DataSource = ds.Tables("semesterstude")

        conn.Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If cboSearch.SelectedIndex = 0 Then

            str = "select studentnumber, FName, MName, LName, Course, Year, Status, studentnumber from semstudent where studentnumber like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "semstudent")
            dgsemstudent.DataSource = ds.Tables("semstudent")
            conn.Close()
        End If
        If cboSearch.SelectedIndex = 1 Then

            str = "select studentnumber, FName, MName, LName, Course, Year, Status, studentnumber from semstudent where LName like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
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
        frmCOR.mskStudentNumber.Text = dgsemstudent(1, i).Value
        Me.Close()
    End Sub
End Class