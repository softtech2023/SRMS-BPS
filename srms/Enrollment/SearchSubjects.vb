Imports MySql.Data.MySqlClient
Public Class frmSearchSubjects
    Dim str As String

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        If cbosearch.SelectedIndex = 0 Then
            Str = "select subjectcode, description, lecunit, labunit, prereq, curriculum, subjectid from subjects where subjectcode like '%" & txtsearch.Text & "%'"
            conn.Open()
            Dim Search As New MySqlDataAdapter(Str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "subjects")
            dgsubjects.DataSource = ds.Tables("subjects")
            conn.Close()

        End If
        If cbosearch.SelectedIndex = 1 Then
            Str = "select subjectcode, description, lecunit, labunit, prereq, curriculum, subjectid from subjects where description like '%" & txtsearch.Text & "%'"
            conn.Open()
            Dim Search As New MySqlDataAdapter(Str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "subjects")
            dgsubjects.DataSource = ds.Tables("subjects")
            conn.Close()
        End If

    End Sub

    Private Sub frmSearchSubjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.subjects' table. You can move, or remove it, as needed.
        Me.SubjectsTableAdapter.Fill(Me.DataSet.subjects)
        

    End Sub

    Private Sub dgsubjects_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgsubjects.CellContentClick

    End Sub

    Private Sub dgsubjects_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgsubjects.DoubleClick
        Dim dclick As Integer
        dclick = dgsubjects.CurrentRow.Index
        frmSemSubjects.lblID.Text = dgsubjects.Item(0, dclick).Value
        frmSemSubjects.txtSubjectCode.Text = dgsubjects.Item(1, dclick).Value
        frmSemSubjects.txtSubjectDescription.Text = dgsubjects.Item(2, dclick).Value
        frmSemSubjects.txtLecUnits.Text = dgsubjects.Item(3, dclick).Value
        frmSemSubjects.txtLabUnits.Text = dgsubjects.Item(4, dclick).Value
        Me.Close()
        frmSemSubjects.Show()

       
    End Sub
End Class