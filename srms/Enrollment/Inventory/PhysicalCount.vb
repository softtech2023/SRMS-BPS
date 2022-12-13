Imports MySql.Data.MySqlClient
Public Class frmPhysicalCount
    Dim str As String
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        frmSearchPersonnel.ShowDialog()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "SELECT i.ctrlNo, i.itemName, i.description, i.unit, i.purchasePrice, i.qty, i.qtyShortage, i.shortageValue, i.notes, i.itemCategory, i.acquiredDate, i.processDate, s.SchoolHead, s.sHeadPosition, s.SchoolName, s.member1Prop, s.member2Prop, s.PropertyCustodian, s.letterHead  FROM ls_items i join srms_settings s on i.settingsID=s.settingsID join staff ss on ss.IDNumber=i.IDNumber where i.acquiredDate<='" & Convert.ToDateTime(dtpAcquireDate.Text).ToString("yyyy-MM-dd") & "' and i.itemCategory='" & cboCategory.Text & "' order by i.itemName, i.description"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(Str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "ls_items, srms_settings")
            Dim obj As New ReportPhysicalCount
            obj.SetDataSource(mysds.Tables("ls_items, srms_settings"))
            obj.SetParameterValue("asofdate", dtpAcquireDate.Text)
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class