Public Class frmChangeTeacher

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmSearchModifyGrades.ShowDialog()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        frmSearchTeacher.ShowDialog()
    End Sub
End Class