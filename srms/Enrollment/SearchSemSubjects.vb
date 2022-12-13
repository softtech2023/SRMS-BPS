Imports MySql.Data.MySqlClient
Public Class frmSearchSemSubjects
    Dim str As String

    Private Sub frmSearchSemSubjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.semsubjects' table. You can move, or remove it, as needed.
        Me.SemsubjectsTableAdapter.Fill(Me.DataSet.semsubjects)


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        str = "select SubjectCode, Description, LecUnit, LabUnit, Section, Day, Time, Room, Slot, Class, IDNumber, SemSubjectsID from semsubjects where Description like '%" & txtSearch.Text & "%'"
        conn.Open()
        Dim Search As New MySqlDataAdapter(str, conn)
        Dim ds As DataSet = New DataSet
        Search.Fill(ds, "semsubjects")
        dgsubjects.DataSource = ds.Tables("semsubjects")
        conn.Close()
    End Sub

    Private Sub dgsubjects_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgsubjects.CellContentClick

    End Sub

    Private Sub dgsubjects_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgsubjects.DoubleClick
        Dim i As Integer
        i = dgsubjects.CurrentRow.Index
        AddSemSubjects(frmCOR.lvCOR, dgsubjects.Item(1, i).Value, dgsubjects.Item(2, i).Value, dgsubjects.Item(7, i).Value, dgsubjects.Item(6, i).Value, dgsubjects.Item(8, i).Value, dgsubjects.Item(5, i).Value, dgsubjects.Item(3, i).Value, dgsubjects.Item(4, i).Value, dgsubjects.Item(10, i).Value)

    End Sub
End Class