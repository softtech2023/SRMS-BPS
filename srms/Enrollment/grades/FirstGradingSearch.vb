Imports MySql.Data.MySqlClient
Public Class frmFirstGradingSearch
    Dim str As String
    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            If frmFirstGrading.txtInstructor.Text = "" Then
                str = " select * from semsubjects where SubjectCode like '%" & txtSearch.Text & "%' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' order by SubjectCode"
                conn.Open()
                Dim Search As New MySqlDataAdapter(str, conn)
                Dim ds As DataSet = New DataSet
                Search.Fill(ds, "semsubjects")
                dg1.DataSource = ds.Tables("semsubjects")
                conn.Close()
                dg1.Columns(0).Visible = False
                dg1.Columns(3).Visible = False
                dg1.Columns(4).Visible = False
                dg1.Columns(9).Visible = False
                dg1.Columns(10).Visible = False
                dg1.Columns(11).Visible = False
                dg1.Columns(12).Visible = False
                dg1.Columns(13).Visible = False


                dg1.Columns(1).Width = 80
                dg1.Columns(2).Width = 250
                dg1.Columns(5).Width = 80

            Else
                str = " select * from semsubjects where SubjectCode like '%" & txtSearch.Text & "%' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Instructor='" & frmFirstGrading.txtInstructor.Text & "' order by SubjectCode"
                conn.Open()
                Dim Search As New MySqlDataAdapter(str, conn)
                Dim ds As DataSet = New DataSet
                Search.Fill(ds, "semsubjects")
                dg1.DataSource = ds.Tables("semsubjects")
                conn.Close()
                dg1.Columns(0).Visible = False
                dg1.Columns(3).Visible = False
                dg1.Columns(4).Visible = False
                dg1.Columns(9).Visible = False
                dg1.Columns(10).Visible = False
                dg1.Columns(11).Visible = False
                dg1.Columns(12).Visible = False
                dg1.Columns(13).Visible = False


                dg1.Columns(1).Width = 80
                dg1.Columns(2).Width = 250
                dg1.Columns(5).Width = 80

            End If
            
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmGPrelimSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If frmFirstGrading.txtInstructor.Text = "" Then
                str = "SELECT * FROM semsubjects where Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' order by SubjectCode"
                conn.Open()
                Dim mysC As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet

                mysC.Fill(ds, "semsubjects")
                dg1.DataSource = ds.Tables("semsubjects")
                conn.Close()

                dg1.Columns(0).Visible = False
                dg1.Columns(3).Visible = False
                dg1.Columns(4).Visible = False
                dg1.Columns(9).Visible = False
                dg1.Columns(10).Visible = False
                dg1.Columns(11).Visible = False
                dg1.Columns(12).Visible = False
                dg1.Columns(13).Visible = False


                dg1.Columns(1).Width = 80
                dg1.Columns(2).Width = 250
                dg1.Columns(5).Width = 80

            Else
                str = "SELECT * FROM semsubjects where Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Instructor='" & frmFirstGrading.txtInstructor.Text & "' order by SubjectCode"
                conn.Open()
                Dim mysC As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet

                mysC.Fill(ds, "semsubjects")
                dg1.DataSource = ds.Tables("semsubjects")
                conn.Close()

                dg1.Columns(0).Visible = False
                dg1.Columns(3).Visible = False
                dg1.Columns(4).Visible = False
                dg1.Columns(9).Visible = False
                dg1.Columns(10).Visible = False
                dg1.Columns(11).Visible = False
                dg1.Columns(12).Visible = False
                dg1.Columns(13).Visible = False


                dg1.Columns(1).Width = 80
                dg1.Columns(2).Width = 250
                dg1.Columns(5).Width = 80
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try
            Dim i As Integer
            i = dg1.CurrentRow.Index
            frmFirstGrading.txtSubjectcode.Text = dg1(1, i).Value
            frmFirstGrading.txtDescription.Text = dg1(2, i).Value
            frmFirstGrading.lblLec.Text = dg1.Item(3, i).Value
            frmFirstGrading.lblLab.Text = dg1.Item(4, i).Value
            frmFirstGrading.txtSection.Text = dg1(5, i).Value
            frmFirstGrading.lblInstructorID.Text = dg1(10, i).Value
            frmFirstGrading.txtInstructor.Text = dg1(13, i).Value
            'frmFirstGrading.lblSubjectStatus.Text = dg1(16, i).Value

            'frmFirstGrading.tsSave.Enabled = True
            frmFirstGrading.tsDelete.Enabled = True
            frmFirstGrading.getInstructor()
            frmFirstGrading.getStatus()
            'frmFirstGrading.disableSave()

      

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class