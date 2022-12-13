Imports MySql.Data.MySqlClient
Public Class frmThirdGradingSearch
    Dim str As String
    Private Sub frmThirdGradingSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            If frmThirdGrading.txtInstructor.Text = "" Then
                str = "SELECT SubjectCode, Description, LecUnit, LabUnit, Instructor, Section, thirdStat FROM grades where Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' group by SubjectCode, Section order by SubjectCode"
                conn.Open()
                Dim mysC As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet

                mysC.Fill(ds, "grades")
                dg1.DataSource = ds.Tables("grades")
                dg1.Columns(4).Visible = False

                conn.Close()
            Else
                str = "SELECT SubjectCode, Description, LecUnit, LabUnit, Instructor, Section, thirdStat FROM grades where Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Instructor='" & frmThirdGrading.txtInstructor.Text & "' group by SubjectCode, Section order by SubjectCode"
                conn.Open()
                Dim mysC As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet

                mysC.Fill(ds, "grades")
                dg1.DataSource = ds.Tables("grades")
                dg1.Columns(4).Visible = False

                conn.Close()
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
            frmThirdGrading.txtSubjectcode.Text = dg1(0, i).Value
            frmThirdGrading.txtDescription.Text = dg1(1, i).Value
            frmThirdGrading.lblLec.Text = dg1.Item(2, i).Value
            frmThirdGrading.lblLab.Text = dg1.Item(3, i).Value
            frmThirdGrading.txtInstructor.Text = dg1.Item(4, i).Value
            frmThirdGrading.txtSection.Text = dg1(5, i).Value
            frmThirdGrading.cboStatus.Text = dg1(6, i).Value

            frmThirdGrading.tsSave.Enabled = True
            frmThirdGrading.tsDelete.Enabled = True


            'frmThirdGrading.getInstructor()
            'frmThirdGrading.getStatus()
            'frmThirdGrading.disableSave()


            If frmThirdGrading.cboStatus.Text = "Closed" Then
                frmThirdGrading.tsSave.Enabled = False
                frmThirdGrading.dg1.Columns(2).ReadOnly = True
                frmThirdGrading.dg1.Columns(3).ReadOnly = True
                frmThirdGrading.dg1.Columns(4).ReadOnly = True
            Else
                frmThirdGrading.tsSave.Enabled = True
                frmThirdGrading.dg1.Columns(2).ReadOnly = True
                frmThirdGrading.dg1.Columns(3).ReadOnly = True
                frmThirdGrading.dg1.Columns(4).ReadOnly = False
            End If
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged

        Try
            If frmThirdGrading.txtInstructor.Text = "" Then
                str = " select SubjectCode, Description, LecUnit, LabUnit, Instructor, Section, thirdStat from grades where SubjectCode like '%" & txtSearch.Text & "%' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' group by description, section order by Section"
                conn.Open()
                Dim Search As New MySqlDataAdapter(str, conn)
                Dim ds As DataSet = New DataSet
                Search.Fill(ds, "grades")
                dg1.DataSource = ds.Tables("grades")
                dg1.Columns(4).Visible = False
                dg1.Columns(0).Width = 120
                dg1.Columns(1).Width = 280
                dg1.Columns(4).Visible = False
                dg1.Columns(2).Visible = False
                dg1.Columns(3).Visible = False
                conn.Close()
            Else
                str = " select SubjectCode, Description, LecUnit, LabUnit, Instructor, Section, thirdStat from grades where SubjectCode like '%" & txtSearch.Text & "%' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Instructor='" & frmThirdGrading.txtInstructor.Text & "' group by description, section order by Section"
                conn.Open()
                Dim Search As New MySqlDataAdapter(str, conn)
                Dim ds As DataSet = New DataSet
                Search.Fill(ds, "grades")
                dg1.DataSource = ds.Tables("grades")
                dg1.Columns(0).Width = 120
                dg1.Columns(1).Width = 280
                dg1.Columns(4).Visible = False
                dg1.Columns(2).Visible = False
                dg1.Columns(3).Visible = False

                conn.Close()
            End If
            


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class