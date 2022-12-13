Public Class frmSearchSemSub_InputGrades

    Private Sub SearchSemSub_InputGrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.semsubjects' table. You can move, or remove it, as needed.
        Me.SemsubjectsTableAdapter.Fill(Me.DataSet.semsubjects)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg1.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        frmInputGrades.txtSubjectcode.Text = dg1(1, i).Value
        frmInputGrades.txtInstructor.Text = dg1(11, i).Value
       
        Me.Close()
    End Sub
End Class