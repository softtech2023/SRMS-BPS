Imports MySql.Data.MySqlClient
Public Class frmSearchSubjects2
    Dim str As String
    Private Sub frmSearchSubjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "SELECT * FROM semsubjects where Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and IDNumber='" & frmParent.lblUser.Text & "' order by SubjectCode"
            conn.Open()
            Dim mysC As New MySqlDataAdapter(Str, conn)
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
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try

            str = " select * from semsubjects where SubjectCode like '%" & txtSearch.Text & "%' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
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

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try
            Dim i As Integer
            i = dg1.CurrentRow.Index
            frmClassAtt.txtSubjectcode.Text = dg1.Item(1, i).Value
            frmClassAtt.txtDescription.Text = dg1.Item(2, i).Value
            'frmClassAtt.lblLec.Text = dg1.Item(3, i).Value
            'frmClassAtt.lblLab.Text = dg1.Item(4, i).Value
            frmClassAtt.txtSection.Text = dg1.Item(5, i).Value
            frmClassAtt.lblInstructorID.Text = dg1.Item(10, i).Value

            frmClassAttendanceForm.lblSubjectCode.Text = dg1.Item(1, i).Value
            frmClassAttendanceForm.lblDescription.Text = dg1.Item(2, i).Value
            frmClassAttendanceForm.lblSection.Text = dg1.Item(5, i).Value
            frmClassAttendanceForm.lblTeacher.Text = dg1.Item(13, i).Value


            frmClassAtt.tsSave.Enabled = True
            frmClassAtt.tsDelete.Enabled = True
            frmClassAtt.getInstructor()
            frmClassAtt.atteance()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class