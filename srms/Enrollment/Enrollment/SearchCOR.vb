Imports MySql.Data.MySqlClient
Public Class frmSearchCOR
    Dim str As String


    Private Sub frmSearchCOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "SELECT * FROM registration where Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' group by StudentNumber"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysDA.Fill(ds, "registration")
            dg1.DataSource = ds.Tables("registration")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).Visible = False
            dg1.Columns(2).Visible = False
            dg1.Columns(3).Visible = False
            dg1.Columns(4).Visible = False
            dg1.Columns(5).Visible = False
            dg1.Columns(6).Visible = False
            dg1.Columns(7).Visible = False
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False
            dg1.Columns(10).Visible = False
            dg1.Columns(11).Visible = False
            dg1.Columns(12).Visible = True
            dg1.Columns(13).Visible = False
            dg1.Columns(14).Visible = True
            dg1.Columns(15).Visible = True
            dg1.Columns(16).Visible = True
            dg1.Columns(17).Visible = True
            dg1.Columns(17).Width = 200
            dg1.Columns(18).Visible = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "SELECT * FROM registration where StudentNumber like '%" & txtSearch.Text & "%' or LastName like '%" & txtSearch.Text & "%' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' group by StudentNumber"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysDA.Fill(ds, "registration")
            dg1.DataSource = ds.Tables("registration")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).Visible = False
            dg1.Columns(2).Visible = False
            dg1.Columns(3).Visible = False
            dg1.Columns(4).Visible = False
            dg1.Columns(5).Visible = False
            dg1.Columns(6).Visible = False
            dg1.Columns(7).Visible = False
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False
            dg1.Columns(10).Visible = False
            dg1.Columns(11).Visible = False
            dg1.Columns(12).Visible = True
            dg1.Columns(13).Visible = False
            dg1.Columns(14).Visible = True
            dg1.Columns(15).Visible = True
            dg1.Columns(16).Visible = True
            dg1.Columns(17).Visible = True
            dg1.Columns(17).Width = 200
            dg1.Columns(18).Visible = True
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub
    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick

        Dim currentrow As Integer
        currentrow = dg1.CurrentRow.Index
        frmCOR.mskStudentNumber.Text = dg1.Item(12, currentrow).Value
        frmCOR.txtFirstName.Text = dg1.Item(14, currentrow).Value
        frmCOR.txtMiddleName.Text = dg1.Item(15, currentrow).Value
        frmCOR.txtLastName.Text = dg1.Item(16, currentrow).Value
        frmCOR.txtCourse.Text = dg1.Item(17, currentrow).Value
        frmCOR.txtYearLevel.Text = dg1.Item(18, currentrow).Value


        frmCOR.tsSave.Enabled = True
        frmCOR.tsUpdate.Enabled = True
        frmCOR.tsDelete.Enabled = True
        frmCOR.btnAddSubject.Enabled = True
        frmCOR.btnRemoveSubjects.Enabled = True

        frmCOR.loadEnrolledSubjects()
        frmCOR.getTotalLecUnits()
        frmCOR.getTotalLabUnits()
        frmCOR.TotalUnits()
        txtSearch.Clear()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class