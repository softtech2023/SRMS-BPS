﻿Imports MySql.Data.MySqlClient
Public Class frmCurriculum
    Dim str As String

    

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtCurriculumName.Text = "" Then
                MsgBox("Curriculum name is required!", MsgBoxStyle.Information)
                Exit Sub
            End If

            str = "insert into curriculum values('0','" & txtCurriculumName.Text & "','" & dtpEffectivity.Text & "')"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            MsgBox("Data successfully added!", MsgBoxStyle.Information)
            Me.CurriculumTableAdapter.Fill(Me.DataSet.curriculum)
            conn.Close()
            txtCurriculumName.Clear()
            dtpEffectivity.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgcurr.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgcurr.DoubleClick
        Try
            Dim dclick As Integer
            dclick = dgcurr.CurrentRow.Index
            lblID.Text = dgcurr.Item(0, dclick).Value
            txtCurriculumName.Text = dgcurr.Item(1, dclick).Value
            dtpEffectivity.Text = dgcurr.Item(2, dclick).Value
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If txtCurriculumName.Text = "" Then
                MsgBox("Please select a Curriculum to update!", MsgBoxStyle.Information)
                Exit Sub
            End If

            str = "update curriculum set CurriculumName='" & txtCurriculumName.Text & "',Effectivity='" & dtpEffectivity.Text & "' where curriculumID='" & lblID.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            MsgBox("Data has been updated!", MsgBoxStyle.Information)
            Me.CurriculumTableAdapter.Fill(Me.DataSet.curriculum)
            conn.Close()
            txtCurriculumName.Clear()
            dtpEffectivity.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If txtCurriculumName.Text = "" Then
                MsgBox("Please select a Curriculum to delete!", MsgBoxStyle.Information)
                Exit Sub

            End If
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from curriculum where curriculumID='" & lblID.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                MsgBox("Data successfully deleted!", MsgBoxStyle.Information, "Prompt")
                Me.CurriculumTableAdapter.Fill(Me.DataSet.curriculum)
                conn.Close()
                txtCurriculumName.Clear()
                dtpEffectivity.Refresh()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmCurriculum_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.CurriculumTableAdapter.Fill(Me.DataSet.curriculum)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class