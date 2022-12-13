Imports MySql.Data.MySqlClient
Public Class frmTravelOrder
    Dim str As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmsearchPersonnelForTravel.Show()
    End Sub

    Public Sub formLoad()
        txtEmployeeID.Clear()
        txtName.Clear()
        txtPosition.Clear()
        txtStation.Clear()
        txtPurpose.Clear()
        txtDestination.Clear()
        dtpFrom.Text = Today
        dtpTo.Text = Today
        dtpApprovedDate.Text = Today
        cboRemarks.ResetText()
        getDateSpan()
        getTravelID()

        tsSave.Enabled = False
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
        tsPrint.Enabled = False

        Try
            str = "select h.travelID, s.IDNumber, concat(s.FirstName,' ',s.MiddleName,' ',s.LastName) as Name, s.empPosition, h.officialStation, h.travelPurpose, h.Destination, h.DateFrom, h.dateTo, h.remarks, h.dateProcessed, h.dateApproved, h.areaCoverage, h.noDays  from hr_travel h join staff s on s.IDNumber=h.IDNumber order by travelID desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "hr_travel, staff")
            dg1.DataSource = ds.Tables("hr_travel, staff")
            conn.Close()

            dg1.Columns(0).HeaderText = "ATT No."
            dg1.Columns(1).HeaderText = "Emp. ID"
            dg1.Columns(2).HeaderText = "Name"
            dg1.Columns(2).Width = 200
            dg1.Columns(3).HeaderText = "Position"
            dg1.Columns(4).HeaderText = "Official Station"
            dg1.Columns(4).Width = 300
            dg1.Columns(5).HeaderText = "Purpose of Travel"
            dg1.Columns(5).Width = 300
            dg1.Columns(6).HeaderText = "Destination"
            dg1.Columns(6).Width = 300
            dg1.Columns(7).HeaderText = "From"
            dg1.Columns(8).HeaderText = "To"
            dg1.Columns(9).HeaderText = "Remarks"
            dg1.Columns(10).HeaderText = "Date Processed"
            dg1.Columns(11).Visible = False
            dg1.Columns(12).Visible = False
            dg1.Columns(13).Visible = False


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmTravelOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()
        getDateSpan()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select h.travelID, s.IDNumber, concat(s.FirstName,' ',s.MiddleName,' ',s.LastName) as Name, s.empPosition, h.officialStation, h.travelPurpose, h.Destination, h.DateFrom, h.dateTo, h.remarks, h.dateProcessed  from hr_travel h join staff s on s.IDNumber=h.IDNumber where s.IDNumber like '%" & txtSearch.Text & "%' or Name like '%" & txtSearch.Text & "%' or h.travelID like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "hr_travel, staff")
            dg1.DataSource = ds.Tables("hr_travel, staff")
            conn.Close()

            dg1.Columns(0).HeaderText = "ATT No."
            dg1.Columns(1).HeaderText = "Emp. ID"
            dg1.Columns(2).HeaderText = "Name"
            dg1.Columns(2).Width = 200
            dg1.Columns(3).HeaderText = "Position"
            dg1.Columns(4).HeaderText = "Official Station"
            dg1.Columns(4).Width = 300
            dg1.Columns(5).HeaderText = "Purpose of Travel"
            dg1.Columns(5).Width = 300
            dg1.Columns(6).HeaderText = "Destination"
            dg1.Columns(6).Width = 300
            dg1.Columns(7).HeaderText = "From"
            dg1.Columns(8).HeaderText = "To"
            dg1.Columns(9).HeaderText = "Source of Funds"
            dg1.Columns(10).HeaderText = "Date Processed"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getTravel()
        Try
            str = "select h.travelID, s.IDNumber, concat(s.FirstName,' ',s.MiddleName,' ',s.LastName) as Name, s.empPosition, h.officialStation, h.travelPurpose, h.Destination, h.DateFrom, h.dateTo, h.remarks, h.dateProcessed, h.dateApproved, h.areaCoverage, h.noDays  from hr_travel h join staff s on s.IDNumber=h.IDNumber where s.IDNumber='" & txtEmployeeID.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "hr_travel, staff")
            dg1.DataSource = ds.Tables("hr_travel, staff")
            conn.Close()

            dg1.Columns(0).Visible = True
            dg1.Columns(0).HeaderText = "ATT No."
            dg1.Columns(1).HeaderText = "Emp. ID"
            dg1.Columns(2).HeaderText = "Name"
            dg1.Columns(2).Width = 200
            dg1.Columns(3).HeaderText = "Position"
            dg1.Columns(4).HeaderText = "Official Station"
            dg1.Columns(4).Width = 300
            dg1.Columns(5).HeaderText = "Purpose of Travel"
            dg1.Columns(5).Width = 300
            dg1.Columns(6).HeaderText = "Destination"
            dg1.Columns(6).Width = 300
            dg1.Columns(7).HeaderText = "From"
            dg1.Columns(8).HeaderText = "To"
            dg1.Columns(9).HeaderText = "Source of Funds"
            dg1.Columns(10).HeaderText = "Date Processed"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        txtATTNo.Text = dg1.Item(0, i).Value
        txtEmployeeID.Text = dg1.Item(1, i).Value
        txtName.Text = dg1.Item(2, i).Value
        txtPosition.Text = dg1.Item(3, i).Value
        txtStation.Text = dg1.Item(4, i).Value
        txtPurpose.Text = dg1.Item(5, i).Value
        txtDestination.Text = dg1.Item(6, i).Value
        dtpFrom.Text = dg1.Item(7, i).Value
        dtpTo.Text = dg1.Item(8, i).Value
        cboRemarks.Text = dg1.Item(9, i).Value
        dtpApprovedDate.Text = dg1.Item(11, i).Value
        cboLocation.Text = dg1.Item(12, i).Value
        lblNoOfDays.Text = dg1.Item(13, i).Value


        tsPrint.Enabled = True
        tsUpdate.Enabled = True
        tsDelete.Enabled = True
        tsSave.Enabled = False
    End Sub
    Public Sub getTravelID()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from hr_travel order by travelID desc limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtATTNo.Text = dtReader.Item(0).ToString
                txtATTNo.Text = txtATTNo.Text + 1
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Public Sub getDateSpan()
        Dim date1 As Date = dtpFrom.Text
        Dim date2 As Date = dtpTo.Text

        Dim span = date2 - date1

        Dim days As Double = span.TotalDays '=4

        lblNoOfDays.Text = days + 1
    End Sub

    Private Sub dtpFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFrom.ValueChanged
        getDateSpan()
    End Sub

    Private Sub dtpTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTo.ValueChanged
        getDateSpan()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        getTravelID()
        Try
            str = "insert into hr_travel values ('" & txtATTNo.Text & "','" & txtEmployeeID.Text & "','" & txtName.Text & "','" & txtPosition.Text & "','" & txtStation.Text & "','" & txtPurpose.Text & "','" & txtDestination.Text & "','" & Convert.ToDateTime(dtpFrom.Text).ToString("yyyy-MM-dd") & "','" & Convert.ToDateTime(dtpTo.Text).ToString("yyyy-MM-dd") & "','" & cboRemarks.Text & "','" & Convert.ToDateTime(frmParent.dtpDate.Text).ToString("yyyy-MM-dd") & "','" & Convert.ToDateTime(dtpApprovedDate.Text).ToString("yyyy-MM-dd") & "','" & cboLocation.Text & "','" & lblNoOfDays.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("New record has been added!", MsgBoxStyle.Information)
            conn.Close()

            'Print Travel Order
            If cboLocation.Text = "Outside the Division" Then
                str = "select h.travelID, concat(s.FirstName,' ',s.MiddleName,' ',s.LastName) as Name, s.empPosition, h.officialStation, h.travelPurpose, h.Destination, h.DateFrom, h.dateto, h.remarks, h.dateProcessed, sr.SchoolHead, sr.sHeadPosition, sr.SchoolName, sr.SchoolAddress, sr.adas1, sr.adas1Position, sr.SDS, sr.sdsPosition, sr.letterHead from staff s join hr_travel h on h.IDNumber=s.IDNumber join srms_settings sr on s.settingsID=sr.settingsID where h.travelID='" & txtATTNo.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "hr_travel, staff, srms_settings")
                Dim obj As New TravelAuthority
                obj.SetDataSource(mysds.Tables("hr_travel, staff, srms_settings"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
            Else
                str = "select h.travelID, concat(s.FirstName,' ',s.MiddleName,' ',s.LastName) as Name, s.empPosition, h.officialStation, h.travelPurpose, h.Destination, h.DateFrom, h.dateto, h.remarks, h.dateProcessed, sr.SchoolHead, sr.sHeadPosition, sr.SchoolName, sr.SchoolAddress, sr.adas1, sr.adas1Position, sr.SDS, sr.sdsPosition, sr.letterHead from staff s join hr_travel h on h.IDNumber=s.IDNumber join srms_settings sr on s.settingsID=sr.settingsID where h.travelID='" & txtATTNo.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "hr_travel, staff, srms_settings")
                Dim obj As New TravelAuthority2
                obj.SetDataSource(mysds.Tables("hr_travel, staff, srms_settings"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
            End If
            formLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try

    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            str = "update hr_travel set officialStation='" & txtStation.Text & "',travelPurpose='" & txtPurpose.Text & "',Destination='" & txtDestination.Text & "',DateFrom='" & Convert.ToDateTime(dtpFrom.Text).ToString("yyyy-MM-dd") & "',dateTo='" & Convert.ToDateTime(dtpTo.Text).ToString("yyyy-MM-dd") & "',remarks='" & cboRemarks.Text & "',dateApproved='" & Convert.ToDateTime(dtpApprovedDate.Text).ToString("yyyy-MM-dd") & "',areaCoverage='" & cboLocation.Text & "',noDays='" & lblNoOfDays.Text & "' where travelID='" & txtATTNo.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("Selected record has been updated!", MsgBoxStyle.Information)
            'Print Travel Order
            If cboLocation.Text = "Outside the Division" Then
                str = "select h.travelID, concat(s.FirstName,' ',s.MiddleName,' ',s.LastName) as Name, s.empPosition, h.officialStation, h.travelPurpose, h.Destination, h.DateFrom, h.dateto, h.remarks, h.dateProcessed, sr.SchoolHead, sr.sHeadPosition, sr.SchoolName, sr.SchoolAddress, sr.adas1, sr.adas1Position, sr.SDS, sr.sdsPosition from staff s join hr_travel h on h.IDNumber=s.IDNumber join srms_settings sr on s.settingsID=sr.settingsID where h.travelID='" & txtATTNo.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "hr_travel, staff, srms_settings")
                Dim obj As New TravelAuthority
                obj.SetDataSource(mysds.Tables("hr_travel, staff, srms_settings"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
            Else
                str = "select h.travelID, concat(s.FirstName,' ',s.MiddleName,' ',s.LastName) as Name, s.empPosition, h.officialStation, h.travelPurpose, h.Destination, h.DateFrom, h.dateto, h.remarks, h.dateProcessed, sr.SchoolHead, sr.sHeadPosition, sr.SchoolName, sr.SchoolAddress, sr.adas1, sr.adas1Position, sr.SDS, sr.sdsPosition from staff s join hr_travel h on h.IDNumber=s.IDNumber join srms_settings sr on s.settingsID=sr.settingsID where h.travelID='" & txtATTNo.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "hr_travel, staff, srms_settings")
                Dim obj As New TravelAuthority2
                obj.SetDataSource(mysds.Tables("hr_travel, staff, srms_settings"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
            End If

            formLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from hr_travel where travelID='" & txtATTNo.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("Selected record has been deleted!", MsgBoxStyle.Information)
                formLoad()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
        conn.Close()
    End Sub

    Private Sub tsPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsPrint.Click
        Try
            'Print Travel Order
            If cboLocation.Text = "Outside the Division" Then
                str = "select h.travelID, concat(s.FirstName,' ',s.MiddleName,' ',s.LastName) as Name, s.empPosition, h.officialStation, h.travelPurpose, h.Destination, h.DateFrom, h.dateto, concat(h.DateFrom,' to ',h.dateTo) as dateCoverage, h.remarks, h.dateProcessed, sr.SchoolHead, sr.sHeadPosition, sr.SchoolName, sr.SchoolAddress, sr.adas1, sr.adas1Position, sr.SDS, sr.sdsPosition, sr.letterHead from staff s join hr_travel h on h.IDNumber=s.IDNumber join srms_settings sr on s.settingsID=sr.settingsID where h.travelID='" & txtATTNo.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "hr_travel, staff, srms_settings")
                Dim obj As New TravelAuthority
                obj.SetDataSource(mysds.Tables("hr_travel, staff, srms_settings"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
            Else
                str = "select h.travelID, concat(s.FirstName,' ',s.MiddleName,' ',s.LastName) as Name, s.empPosition, h.officialStation, h.travelPurpose, h.Destination, h.DateFrom, h.dateto, h.remarks, h.dateProcessed, sr.SchoolHead, sr.sHeadPosition, sr.SchoolName, sr.SchoolAddress, sr.adas1, sr.adas1Position, sr.SDS, sr.sdsPosition, sr.letterHead from staff s join hr_travel h on h.IDNumber=s.IDNumber join srms_settings sr on s.settingsID=sr.settingsID where h.travelID='" & txtATTNo.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "hr_travel, staff, srms_settings")
                Dim obj As New TravelAuthority2
                obj.SetDataSource(mysds.Tables("hr_travel, staff, srms_settings"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub tsClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsClose.Click
        formLoad()
        Me.Close()
    End Sub


End Class