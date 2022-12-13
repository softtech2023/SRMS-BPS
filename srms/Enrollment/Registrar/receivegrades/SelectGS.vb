Imports MySql.Data.MySqlClient
Public Class frmSelectGS
    Dim str As String
    Private Sub frmSelectGS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select SubjectCode, Description, Section, Instructor, Status from grades where Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Status='Open' group by SubjectCode, Section"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "grades")
            dg1.DataSource = ds.Tables("grades")
            conn.Close()

            dg1.Columns(0).HeaderText = "Subject Code"
            dg1.Columns(1).Width = 160
            dg1.Columns(3).Width = 160
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select SubjectCode, Description, Section, Instructor, Status from grades where SubjectCode like '%" & txtSearch.Text & "%' or Description like '%" & txtSearch.Text & "%' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Status='Open' group by SubjectCode, Section"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "grades")
            dg1.DataSource = ds.Tables("grades")
            conn.Close()

            dg1.Columns(0).HeaderText = "Subject Code"
            dg1.Columns(1).Width = 160
            dg1.Columns(3).Width = 160
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        frmReceiveGradeSheets.txtsubjectcode.Text = dg1.Item(0, i).Value
        frmReceiveGradeSheets.txtDescription.Text = dg1.Item(1, i).Value
        frmReceiveGradeSheets.txtSection.Text = dg1.Item(2, i).Value
        frmReceiveGradeSheets.txtInstructor.Text = dg1.Item(3, i).Value

        frmReceiveGradeSheets.tsReceive.Enabled = True
        frmReceiveGradeSheets.tsPreview.Enabled = True
        frmReceiveGradeSheets.tsPreview.PerformClick()
        txtSearch.Clear()
        Me.Close()
    End Sub
End Class