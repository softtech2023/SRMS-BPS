Imports MySql.Data.MySqlClient
Public Class frmSelectSubject_Masterlist
    Dim str As String
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSelectSubject_Masterlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select * from semsubjects where SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "' order by SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semsubjects")
            dg1.DataSource = ds.Tables("semsubjects")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 80
            dg1.Columns(1).HeaderText = "Code"
            dg1.Columns(2).Width = 200
            dg1.Columns(3).Visible = False
            dg1.Columns(4).Visible = False
            dg1.Columns(5).Width = 60
            dg1.Columns(6).Visible = False
            dg1.Columns(7).Visible = False
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False
            dg1.Columns(10).Visible = False
            dg1.Columns(11).Visible = False
            dg1.Columns(12).Visible = False
            dg1.Columns(13).Width = 150
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try
            Dim i As Integer
            i = dg1.CurrentRow.Index
            frmMasterList.txtsubjectcode.Text = dg1.Item(1, i).Value
            frmMasterList.txtDescription.Text = dg1.Item(2, i).Value
            frmMasterList.txtSection.Text = dg1.Item(5, i).Value
            frmMasterList.txtInstructor.Text = dg1.Item(13, i).Value
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from semsubjects where SubjectCode like '%" & txtSearch.Text & "%' and  SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "' order by SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semsubjects")
            dg1.DataSource = ds.Tables("semsubjects")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 80
            dg1.Columns(1).HeaderText = "Code"
            dg1.Columns(2).Width = 200
            dg1.Columns(3).Visible = False
            dg1.Columns(4).Visible = False
            dg1.Columns(5).Width = 60
            dg1.Columns(6).Visible = False
            dg1.Columns(7).Visible = False
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False
            dg1.Columns(10).Visible = False
            dg1.Columns(11).Visible = False
            dg1.Columns(12).Visible = False
            dg1.Columns(13).Width = 150
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class