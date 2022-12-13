Imports MySql.Data.MySqlClient
Public Class frmSearchStaff
    Dim str As String

    Private Sub frmSearchStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.DataSet.staff)
       

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        str = "select IDNumber, Name, Position, Department, DateHired, ContactNumber, Address, IDNumber from staff where Name like '%" & txtSearch.Text & "%'"
        conn.Open()
        Dim Search As New MySqlDataAdapter(str, conn)
        Dim ds As DataSet = New DataSet
        Search.Fill(ds, "staff")
        dgFacultySearch.DataSource = ds.Tables("staff")
        conn.Close()
    End Sub

    Private Sub dgFacultySearch_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgFacultySearch.CellContentClick
        
    End Sub

    Private Sub dgFacultySearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacultySearch.DoubleClick
        Dim i As Integer
        i = dgFacultySearch.CurrentRow.Index
        frmSemSubjects.txtInstructor.Text = dgFacultySearch.Item(0, i).Value
        Me.Close()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        i = dgFacultySearch.CurrentRow.Index
        frmSemSubjects.txtInstructor.Text = dgFacultySearch.Item(0, i).Value
        Me.Close()
    End Sub
End Class