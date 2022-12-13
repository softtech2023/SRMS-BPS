Imports MySql.Data.MySqlClient
Public Class frmSearchSemSubjects
    Dim str As String

    Private Sub frmSearchSemSubjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkSubjectCode.Checked = True
        Try
            str = "select * from semsubjects where SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "' order by SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semsubjects")
            dgsubjects.DataSource = ds.Tables("semsubjects")
            conn.Close()


            dgsubjects.Columns(0).Visible = False
            dgsubjects.Columns(3).Visible = False
            dgsubjects.Columns(4).Visible = False
            dgsubjects.Columns(9).Visible = False
            dgsubjects.Columns(10).Visible = False
            dgsubjects.Columns(11).Visible = False
            dgsubjects.Columns(12).Visible = False
            dgsubjects.Columns(13).Visible = False


            dgsubjects.Columns(1).Width = 80
            dgsubjects.Columns(2).Width = 250
            dgsubjects.Columns(5).Width = 80
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            If chkSubjectCode.Checked = True Then
                str = "select * from semsubjects where SubjectCode like '%" & txtSearch.Text & "%' and SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "' order by Description"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "semsubjects")
                dgsubjects.DataSource = ds.Tables("semsubjects")
                conn.Close()
            End If

            If chkDescription.Checked = True Then
                str = "select * from semsubjects where description like '%" & txtSearch.Text & "%' and SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "' order by Description"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "semsubjects")
                dgsubjects.DataSource = ds.Tables("semsubjects")
                conn.Close()
            End If

            If chkSection.Checked = True Then
                str = "select * from semsubjects where Section like '%" & txtSearch.Text & "%' and SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "semsubjects")
                dgsubjects.DataSource = ds.Tables("semsubjects")
                conn.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dgsubjects_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgsubjects.DoubleClick
        Try
            Dim i As Integer
            i = dgsubjects.CurrentRow.Index

            For x As Integer = 0 To frmCOR.lvCOR.Items.Count - 1
                If dgsubjects.Item(1, i).Value = frmCOR.lvCOR.Items(x).SubItems(0).Text Then
                    MsgBox("Adding the same subject to the same student is not allowed!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            Next
            AddSemSubjects(frmCOR.lvCOR, dgsubjects.Item(1, i).Value, dgsubjects.Item(2, i).Value, dgsubjects.Item(7, i).Value, dgsubjects.Item(6, i).Value, dgsubjects.Item(8, i).Value, dgsubjects.Item(5, i).Value, dgsubjects.Item(3, i).Value, dgsubjects.Item(4, i).Value, dgsubjects.Item(13, i).Value, dgsubjects.Item(13, i).Value)

            frmCOR.tsSave.Enabled = True
            frmCOR.getTotalLecUnits()
            frmCOR.getTotalLabUnits()
            frmCOR.TotalUnits()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

End Class