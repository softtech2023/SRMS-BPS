Imports MySql.Data.MySqlClient
Public Class frmSearchPrintGS
    Dim str As String
    Private Sub frmSearchPrintGS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If frmPrintGradingSheet.lblUserLevel.Text = "Teacher" Then
                str = "select SubjectCode, Description, Section, Instructor from grades where Instructor='" & frmPrintGradingSheet.txtInstructor.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' group by SubjectCode, Section"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "grades")
                dg1.DataSource = ds.Tables("grades")
                conn.Close()

                dg1.Columns(0).HeaderText = "Subject Code"
                dg1.Columns(1).Width = 160
                dg1.Columns(3).Width = 160

            Else
                str = "select SubjectCode, Description, Section, Instructor from grades where Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' group by SubjectCode, Section"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "grades")
                dg1.DataSource = ds.Tables("grades")
                conn.Close()

                dg1.Columns(0).HeaderText = "Subject Code"
                dg1.Columns(1).Width = 160
                dg1.Columns(3).Width = 160

            End If

            
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            If frmPrintGradingSheet.lblUserLevel.Text = "Teacher" Then
                str = "select SubjectCode, Description, Section, Instructor from grades where SubjectCode like '%" & txtSearch.Text & "%' and Instructor='" & frmPrintGradingSheet.txtInstructor.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' group by SubjectCode, Section"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "grades")
                dg1.DataSource = ds.Tables("grades")
                conn.Close()
            Else
                str = "select SubjectCode, Description, Section, Instructor from grades where SubjectCode like '%" & txtSearch.Text & "%' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' group by SubjectCode, Section"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "grades")
                dg1.DataSource = ds.Tables("grades")
                conn.Close()

            End If
            

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
        frmPrintGradingSheet.txtsubjectcode.Text = dg1.Item(0, i).Value
        frmPrintGradingSheet.txtDescription.Text = dg1.Item(1, i).Value
        frmPrintGradingSheet.txtSection.Text = dg1.Item(2, i).Value
        frmPrintGradingSheet.txtInstructor.Text = dg1.Item(3, i).Value

        txtSearch.Clear()

        Me.Close()
    End Sub
End Class