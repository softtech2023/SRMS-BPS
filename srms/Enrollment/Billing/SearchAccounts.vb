Imports MySql.Data.MySqlClient
Public Class SearchAccounts
    Dim str As String

    Private Sub SearchAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Try
            str = "select * from semesterstude where Semester = '" & frmParent.lblSem.Text & "' and SY = '" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysDA.Fill(ds, "semesterstude")
            dgstudentsearch.DataSource = ds.Tables("semesterstude")
            conn.Close()
            dgstudentsearch.Columns(0).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        frmBilling.btnOldAcct.Enabled = True
        frmBilling.tsSave.Enabled = True

    End Sub


    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgstudentsearch.DoubleClick
        Try
            Dim dclick As Integer
            dclick = dgstudentsearch.CurrentRow.Index
            frmBilling.mskStudentNumber.Text = dgstudentsearch.Item(1, dclick).Value
            frmBilling.txtFname.Text = dgstudentsearch.Item(2, dclick).Value
            frmBilling.txtMName.Text = dgstudentsearch.Item(3, dclick).Value
            frmBilling.txtLastName.Text = dgstudentsearch.Item(4, dclick).Value
            frmBilling.cboCourse.Text = dgstudentsearch.Item(5, dclick).Value
            frmBilling.cboYear.Text = dgstudentsearch.Item(6, dclick).Value
            frmBilling.txtSection.Text = dgstudentsearch.Item(11, dclick).Value
            frmBilling.cboStatus.Text = dgstudentsearch.Item(18, dclick).Value
            frmBilling.lblMajor.Text = dgstudentsearch.Item(21, dclick).Value

            frmBilling.Show()
            frmBilling.LoadFees()


            Dim totalpayment As Double

            str = "select * from paymentsaccounts where StudentNumber='" & frmBilling.mskStudentNumber.Text & "' and SY='" & frmParent.lblSY.Text & "' and ORStatus='Valid' and CollectionSource!='Services'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            Dim mysDR As MySqlDataReader = mysC.ExecuteReader

            While mysDR.Read
                totalpayment += Val(mysDR(8))
            End While

            frmBilling.txtPayments.Text = Format(totalpayment, "00.00")
            mysDR.Close()
            conn.Close()



            frmBilling.tsSave.Enabled = True
            frmBilling.tsUpdate.Enabled = False
            frmBilling.btnOldAcct.Enabled = True

            frmBilling.CourseFees()

            frmBilling.btnCompute.PerformClick()
            frmBilling.btnOldAcct.PerformClick()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try


            str = "SELECT * from semesterstude where LName like '%" & txtSearch.Text & "%' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "semesterstude")
            dgstudentsearch.DataSource = ds.Tables("semesterstude")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class