Imports MySql.Data.MySqlClient
Public Class frmSearchModifyGrades
    Dim str As String
    Private Sub frmSearchModifyGrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If frmModifyGrades.txtTeacher.Text = "" Then
                str = "select * from grades where Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and StudentNumber='" & frmModifyGrades.mskStudentNumber.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "grades")
                dgsubjects.DataSource = ds.Tables("grades")
                conn.Close()

                dgsubjects.Columns(0).Visible = False
                dgsubjects.Columns(1).Visible = False
                dgsubjects.Columns(2).Visible = False
                dgsubjects.Columns(3).Visible = True
                dgsubjects.Columns(4).Visible = True
                dgsubjects.Columns(4).Width = 300
                dgsubjects.Columns(5).Visible = False
                dgsubjects.Columns(6).Visible = False
                dgsubjects.Columns(7).Visible = False
                dgsubjects.Columns(8).Visible = True
                dgsubjects.Columns(9).Visible = False
                dgsubjects.Columns(10).Visible = False
                dgsubjects.Columns(11).Visible = False
                dgsubjects.Columns(12).Visible = False
                dgsubjects.Columns(13).Visible = False
                dgsubjects.Columns(14).Visible = False
                dgsubjects.Columns(15).Visible = False
                dgsubjects.Columns(16).Visible = False
                dgsubjects.Columns(17).Visible = False
                dgsubjects.Columns(18).Visible = False
                dgsubjects.Columns(19).Visible = False

            Else
                str = "select * from grades where Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Instructor='" & frmModifyGrades.txtTeacher.Text & "' and StudentNumber='" & frmModifyGrades.mskStudentNumber.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "grades")
                dgsubjects.DataSource = ds.Tables("grades")
                conn.Close()

                dgsubjects.Columns(0).Visible = False
                dgsubjects.Columns(1).Visible = False
                dgsubjects.Columns(2).Visible = False
                dgsubjects.Columns(3).Visible = True
                dgsubjects.Columns(4).Visible = True
                dgsubjects.Columns(4).Width = 400
                dgsubjects.Columns(5).Visible = False
                dgsubjects.Columns(6).Visible = False
                dgsubjects.Columns(7).Visible = False
                dgsubjects.Columns(8).Visible = False
                dgsubjects.Columns(9).Visible = False
                dgsubjects.Columns(10).Visible = False
                dgsubjects.Columns(11).Visible = False
                dgsubjects.Columns(12).Visible = False
                dgsubjects.Columns(13).Visible = False
                dgsubjects.Columns(14).Visible = False
                dgsubjects.Columns(15).Visible = False
                dgsubjects.Columns(16).Visible = False
                dgsubjects.Columns(17).Visible = False
                dgsubjects.Columns(18).Visible = False
                dgsubjects.Columns(19).Visible = False


            End If
            
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
   
    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            If frmModifyGrades.txtTeacher.Text = "" Then
                str = "select * from grades where Description like '%" & txtSearch.Text & "%' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and StudentNumber='" & frmModifyGrades.mskStudentNumber.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "grades")
                dgsubjects.DataSource = ds.Tables("grades")
                conn.Close()

                dgsubjects.Columns(0).Visible = False
                dgsubjects.Columns(1).Visible = False
                dgsubjects.Columns(2).Visible = False
                dgsubjects.Columns(3).Visible = True
                dgsubjects.Columns(4).Visible = True
                dgsubjects.Columns(4).Width = 400
                dgsubjects.Columns(5).Visible = False
                dgsubjects.Columns(6).Visible = False
                dgsubjects.Columns(7).Visible = False
                dgsubjects.Columns(8).Visible = False
                dgsubjects.Columns(9).Visible = False
                dgsubjects.Columns(10).Visible = False
                dgsubjects.Columns(11).Visible = False
                dgsubjects.Columns(12).Visible = False
                dgsubjects.Columns(13).Visible = False
                dgsubjects.Columns(14).Visible = False
                dgsubjects.Columns(15).Visible = False
                dgsubjects.Columns(16).Visible = False
                dgsubjects.Columns(17).Visible = False
                dgsubjects.Columns(18).Visible = False
                dgsubjects.Columns(19).Visible = False
            Else
                str = "select * from grades where Description like '%" & txtSearch.Text & "%' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Instructor='" & frmModifyGrades.txtTeacher.Text & "' and StudentNumber='" & frmModifyGrades.mskStudentNumber.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "grades")
                dgsubjects.DataSource = ds.Tables("grades")
                conn.Close()

                dgsubjects.Columns(0).Visible = False
                dgsubjects.Columns(1).Visible = False
                dgsubjects.Columns(2).Visible = False
                dgsubjects.Columns(3).Visible = True
                dgsubjects.Columns(4).Visible = True
                dgsubjects.Columns(4).Width = 400
                dgsubjects.Columns(5).Visible = False
                dgsubjects.Columns(6).Visible = False
                dgsubjects.Columns(7).Visible = False
                dgsubjects.Columns(8).Visible = False
                dgsubjects.Columns(9).Visible = False
                dgsubjects.Columns(10).Visible = False
                dgsubjects.Columns(11).Visible = False
                dgsubjects.Columns(12).Visible = False
                dgsubjects.Columns(13).Visible = False
                dgsubjects.Columns(14).Visible = False
                dgsubjects.Columns(15).Visible = False
                dgsubjects.Columns(16).Visible = False
                dgsubjects.Columns(17).Visible = False
                dgsubjects.Columns(18).Visible = False
                dgsubjects.Columns(19).Visible = False
            End If

          

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dgsubjects_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgsubjects.DoubleClick
        Dim i As Integer
        i = dgsubjects.CurrentRow.Index

        frmModifyGrades.txtSubjectCode.Text = dgsubjects.Item(3, i).Value
        frmModifyGrades.txtDescription.Text = dgsubjects.Item(4, i).Value
        frmModifyGrades.txtTeacher.Text = dgsubjects.Item(7, i).Value
        frmModifyGrades.txtSection.Text = dgsubjects.Item(8, i).Value

        frmChangeTeacher.txtSubjectCode.Text = dgsubjects.Item(3, i).Value
        frmChangeTeacher.txtDescription.Text = dgsubjects.Item(4, i).Value
        frmChangeTeacher.txtOldTeacher.Text = dgsubjects.Item(7, i).Value
        frmChangeTeacher.txtSection.Text = dgsubjects.Item(8, i).Value

        Me.Close()


    End Sub
End Class