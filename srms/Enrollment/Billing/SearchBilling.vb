Imports MySql.Data.MySqlClient
Public Class frmSearchBilling
    Dim str As String

    Private Sub frmSearchBilling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub
    Public Sub FormLoad()
        Try
            str = "select * from studeaccount where SY='" & frmParent.lblSY.Text & "' and Sem='" & frmParent.lblSem.Text & "' group by StudentNumber"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeaccount")
            dg1.DataSource = ds.Tables("studeaccount")
            conn.Close()
            dg1.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from studeaccount where StudentNumber like '%" & txtSearch.Text & "%' or LastName like '%" & txtSearch.Text & "%' and SY='" & frmParent.lblSY.Text & "' and Sem='" & frmParent.lblSem.Text & "' group by StudentNumber"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "studeaccount")
            dg1.DataSource = ds.Tables("studeaccount")
            conn.Close()
            dg1.Columns(0).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        txtSearch.Clear()
        Me.Close()
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try
           
            Dim n As Integer
            n = dg1.CurrentRow.Index

            frmBilling.lblID.Text = dg1.Item(0, n).Value
            frmBilling.mskStudentNumber.Text = dg1.Item(1, n).Value
            frmBilling.txtFname.Text = dg1.Item(2, n).Value
            frmBilling.txtMName.Text = dg1.Item(3, n).Value
            frmBilling.txtLastName.Text = dg1.Item(4, n).Value
            frmBilling.cboCourse.Text = dg1.Item(5, n).Value
            frmBilling.cboYear.Text = dg1.Item(6, n).Value
            frmBilling.cboStatus.Text = dg1.Item(7, n).Value
            frmBilling.txtTotalLecUnits.Text = dg1.Item(8, n).Value
            frmBilling.txtLecRate.Text = dg1.Item(9, n).Value
            frmBilling.txtTuition.Text = dg1.Item(10, n).Value
            frmBilling.txtTotalLabUnits.Text = dg1.Item(11, n).Value
            frmBilling.txtLabRate.Text = dg1.Item(12, n).Value
            frmBilling.txtLab.Text = dg1.Item(13, n).Value
            frmBilling.txtOldAccount.Text = dg1.Item(14, n).Value
            frmBilling.txtTotalFees.Text = dg1.Item(17, n).Value
            frmBilling.txtDiscountPercentage.Text = dg1.Item(18, n).Value
            frmBilling.txtDiscount.Text = dg1.Item(19, n).Value
            frmBilling.txtTotalAcct.Text = dg1.Item(20, n).Value
            frmBilling.txtPayments.Text = dg1.Item(21, n).Value
            frmBilling.txtBalance.Text = dg1.Item(22, n).Value

            frmBilling.txtDesc1.Text = dg1.Item(25, n).Value
            frmBilling.txtAmount1.Text = dg1.Item(26, n).Value
            frmBilling.txtDesc2.Text = dg1.Item(27, n).Value
            frmBilling.txtAmount2.Text = dg1.Item(28, n).Value
            frmBilling.txtDesc3.Text = dg1.Item(29, n).Value
            frmBilling.txtAmount3.Text = dg1.Item(30, n).Value
            frmBilling.txtDesc4.Text = dg1.Item(31, n).Value
            frmBilling.txtAmount4.Text = dg1.Item(32, n).Value
            frmBilling.txtDesc5.Text = dg1.Item(33, n).Value
            frmBilling.txtAmount5.Text = dg1.Item(34, n).Value
            frmBilling.txtRegFee.Text = dg1.Item(35, n).Value
            frmBilling.txtSection.Text = dg1.Item(36, n).Value
            frmBilling.cboPaymentMode.Text = dg1.Item(37, n).Value
            frmBilling.txtDisc1.Text = dg1.Item(38, n).Value
            frmBilling.txtDiscAmount1.Text = dg1.Item(39, n).Value
            frmBilling.txtDisc2.Text = dg1.Item(40, n).Value
            frmBilling.txtDiscAmount2.Text = dg1.Item(41, n).Value
            frmBilling.txtDisc3.Text = dg1.Item(42, n).Value
            frmBilling.txtDiscAmount3.Text = dg1.Item(43, n).Value
            frmBilling.txtDisc4.Text = dg1.Item(44, n).Value
            frmBilling.txtDiscAmount4.Text = dg1.Item(45, n).Value
            frmBilling.txtDisc5.Text = dg1.Item(46, n).Value
            frmBilling.txtDiscAmount5.Text = dg1.Item(47, n).Value

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

            frmBilling.btnCompute.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        frmBilling.tsSave.Enabled = False
        frmBilling.tsUpdate.Enabled = True
        frmBilling.tsDelete.Enabled = True
        frmBilling.tsNew.Enabled = True
        frmBilling.btnOldAcct.Enabled = True
        frmBilling.LoadAcct()
        txtSearch.Clear()

        frmBilling.btnOldAcct.Enabled = False

        Me.Close()
    End Sub

End Class