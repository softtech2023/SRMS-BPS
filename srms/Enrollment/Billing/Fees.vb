Imports MySql.Data.MySqlClient
Public Class frmFees
    Dim str As String
    Private Sub frmFees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getCourse()
        getCourseMajor()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnViewFees.PerformClick()
    End Sub

    Public Sub ClearFields()
        txtDescription.Clear()
        txtAmount.Text = "00.00"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewFees.Click
        
        Try
            str = "select * from fees where Course='" & cboCourse.Text & "' and YearLevel='" & cboYearLevel.Text & "' and SY='" & txtSY.Text & "' and Major='" & cboMajor.Text & "' order by Description"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "fees")
            dg1.DataSource = ds.Tables("fees")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 340
            dg1.Columns(2).Width = 100
            dg1.Columns(3).Visible = False
            dg1.Columns(4).Visible = False
            dg1.Columns(5).Visible = False


            getTotal()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtDescription.Text = "" Then
                MsgBox("Description is required!", MsgBoxStyle.Exclamation)
                txtDescription.Focus()
                Exit Sub
            End If

            str = "insert into fees values('0','" & txtDescription.Text & "','" & txtAmount.Text & "','" & cboCourse.Text & "','" & cboMajor.Text & "','" & cboYearLevel.Text & "','" & txtSY.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("New record added!", MsgBoxStyle.Information)
            conn.Close()
            ClearFields()
            txtDescription.Focus()
            btnViewFees.PerformClick()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            str = "update fees set feesid='" & lblID.Text & "',Description='" & txtDescription.Text & "',Amount='" & txtAmount.Text & "',Course='" & cboCourse.Text & "',Major='" & cboMajor.Text & "',YearLevel='" & cboYearLevel.Text & "',SY='" & txtSY.Text & "' where feesid='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Selected record has been updated!", MsgBoxStyle.Information)
            conn.Close()
            ClearFields()
            btnViewFees.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            str = "delete from fees where feesid='" & lblID.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            MsgBox("Data successfully deleted!", MsgBoxStyle.Information)
            conn.Close()
            ClearFields()
            btnViewFees.PerformClick()
        End If

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        lblID.Text = dg1.Item(0, i).Value
        txtDescription.Text = dg1.Item(1, i).Value
        txtAmount.Text = dg1.Item(2, i).Value
        cboCourse.Text = dg1.Item(3, i).Value
        cboMajor.Text = dg1.Item(4, i).Value
        cboYearLevel.Text = dg1.Item(5, i).Value
        txtSY.Text = dg1.Item(6, i).Value

        btnSave.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub
    Public Sub getCourse()
        Try
            str = "select * from course_table group by CourseDescription order by CourseDescription"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "course_table")
            conn.Close()
            cboCourse.ValueMember = "course_table"
            cboCourse.DisplayMember = "CourseDescription"
            cboCourse.DataSource = ds.Tables("course_table")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
   
    Public Sub getTotal()
        Try
            Dim max As Integer = dg1.Rows.Count - 1
            Dim tot As Integer = 0
            'getting the values of a specific rows


            For Each row As DataGridViewRow In dg1.Rows
                'formula for adding the values in the rows
                tot += row.Cells(2).Value
            Next

            lblTotal.Text = tot.ToString("C", New System.Globalization.CultureInfo("fil-PH"))

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub getCourseMajor()
        Try
            str = "select * from course_table where CourseDescription='" & cboCourse.Text & "' order by Major"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "course_table")

            cboYearLevel.ValueMember = "course_table"
            cboYearLevel.DisplayMember = "Major"
            cboYearLevel.DataSource = ds.Tables("course_table")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCourse.SelectedIndexChanged
        getCourseMajor()
    End Sub
End Class