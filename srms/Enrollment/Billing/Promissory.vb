Imports MySql.Data.MySqlClient
Public Class frmPromissory
    Dim str As String
   
    Private Sub frmPromissory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub
    Public Sub FormLoad()
        Try
            str = "select * from promissory where Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "promissory")
            dgPromissory.DataSource = ds.Tables("promissory")
            conn.Close()

            dgPromissory.Columns(0).Visible = False
            dgPromissory.Columns(5).Width = 200
            dgPromissory.Columns(9).Visible = False
            dgPromissory.Columns(10).Visible = False


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False

        mskDateApplied.Text = Today
        txtStudentNumber.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtGuardian.Clear()
        txtAmount.Clear()
        mskPromisedDate.Text = Today
        cboStatus.ResetText()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        frmSearch4Promissory.ShowDialog()
    End Sub

    Private Sub dgPromissory_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgPromissory.DoubleClick
        Try
            Dim dclick As Integer
            dclick = dgPromissory.CurrentRow.Index
            lblID.Text = dgPromissory.Item(0, dclick).Value
            mskDateApplied.Text = dgPromissory.Item(1, dclick).Value
            txtStudentNumber.Text = dgPromissory.Item(2, dclick).Value
            txtFirstName.Text = dgPromissory.Item(3, dclick).Value
            txtLastName.Text = dgPromissory.Item(4, dclick).Value
            txtGuardian.Text = dgPromissory.Item(5, dclick).Value
            txtAmount.Text = dgPromissory.Item(6, dclick).Value
            mskPromisedDate.Text = dgPromissory.Item(7, dclick).Value
            cboStatus.Text = dgPromissory.Item(8, dclick).Value

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        btnSave.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtStudentNumber.Text = "" And txtGuardian.Text = "" And txtAmount.Text = "" Then
                MsgBox("Please fill-up the form completely!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            str = "insert into promissory values('0','" & Convert.ToDateTime(mskDateApplied.Text).ToString("yyyy-MM-dd") & "','" & txtStudentNumber.Text & "','" & txtFirstName.Text & "','" & txtLastName.Text & "','" & txtGuardian.Text & "','" & txtAmount.Text & "','" & Convert.ToDateTime(mskPromisedDate.Text).ToString("yyyy-MM-dd") & "','" & cboStatus.Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("New Promissory Note added!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            str = "update promissory set promissoryID='" & lblID.Text & "',DateApplied='" & Convert.ToDateTime(mskDateApplied.Text).ToString("yyyy-MM-dd") & "',StudentNumber='" & txtStudentNumber.Text & "',FirstName='" & txtFirstName.Text & "',LastName='" & txtLastName.Text & "',Guardian='" & txtGuardian.Text & "',Amount='" & txtAmount.Text & "',PromisedDate='" & Convert.ToDateTime(mskPromisedDate.Text).ToString("yyyy-MM-dd") & "',Status='" & cboStatus.Text & "',Sem='" & frmParent.lblSem.Text & "',SY='" & frmParent.lblSY.Text & "' where promissoryID='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Selected has been updated!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from promissory where promissoryID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Selected record has been deleted!", MsgBoxStyle.Information)
                conn.Close()
                FormLoad()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

   
    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from promissory where LastName like '%" & txtSearch.Text & "%' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "promissory")
            dgPromissory.DataSource = ds.Tables("promissory")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class