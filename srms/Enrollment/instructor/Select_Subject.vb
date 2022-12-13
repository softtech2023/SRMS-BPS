Imports MySql.Data.MySqlClient
Public Class frmSelect_Subject
    Dim str As String


    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = " select * from semsubjects where SubjectCode like '%" & txtSearch.Text & "%' and IDNumber='" & frmParent.lblUser.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "semsubjects")
            dg1.DataSource = ds.Tables("semsubjects")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmGS_Select_Subject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            If frmInstructorInput.rdoTVE.Checked = True Then
                str = "SELECT * FROM semsubjects where SubjectCode='TVE 7' or SubjectCode='TVE 8' SubjectCode='TVE 9' SubjectCode='TVE 10' SubjectCode='TVE 11' SubjectCode='TVE 12' and IDNumber='" & frmParent.lblUser.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' order by SubjectCode"
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
                str = "SELECT * FROM semsubjects where IDNumber='" & frmParent.lblUser.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' order by SubjectCode"
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
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try
            Dim i As Integer
            i = dg1.CurrentRow.Index
            frmInstructorInput.txtSubjectcode.Text = dg1(1, i).Value
            frmInstructorInput.txtDescription.Text = dg1(2, i).Value
            frmInstructorInput.lblLec.Text = dg1.Item(3, i).Value
            frmInstructorInput.lblLab.Text = dg1.Item(4, i).Value
            frmInstructorInput.txtSection.Text = dg1(5, i).Value
            frmInstructorInput.lblInstructorID.Text = dg1(10, i).Value


            frmInstructorInput.tsSave.Enabled = True
            frmInstructorInput.tsDelete.Enabled = True
            frmInstructorInput.getInstructor()
            frmInstructorInput.getAverage()
            frmInstructorInput.getStatus()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class