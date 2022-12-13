Imports MySql.Data.MySqlClient
Public Class frmFileUploader
    Dim str As String

    Private Sub btnAttach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAttach.Click
        'ofdAttach.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|Document Files(*.PDF;*.DOCX;*.DOC)|*.PDF;*.DOCX;*.DOC|All files (*.*)|*.*"
        ofdAttach.Filter = "All files (*.*)|*.*"
        ofdAttach.FilterIndex = 1

        ofdAttach.ShowDialog()
        txtFileName.Text = System.IO.Path.GetFileName(ofdAttach.FileName)

        Dim path As String
        path = "d:/deped-forms/"
        lblPath.Text = path + txtFileName.Text
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Try
            If txtFileName.Text = "" Then
                MsgBox("Cannot find any files to view", MsgBoxStyle.Information)
                Exit Sub
            End If
            Dim path As String
            path = "d:/deped-forms/"
            lblPath.Text = path + txtFileName.Text
            Process.Start(lblPath.Text)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsNew.Click
        frmSearchStudeUpload.ShowDialog()
    End Sub

    Public Sub formLoad()
        tsSave.Enabled = True
        tsDelete.Enabled = False

        mskStudentNumber.Clear()
        txtFname.Clear()
        txtMName.Clear()
        txtLastName.Clear()
        cboFileType.ResetText()
        txtFileName.Clear()

        Dim str As String
        str = "select * from docs order by LName"
        conn.Open()
        Dim mysda As New MySqlDataAdapter(str, conn)
        Dim ds As New DataSet
        mysda.Fill(ds, "docs")
        dg1.DataSource = ds.Tables("docs")
        conn.Close()
        dg1.Columns(0).Visible = False
        dg1.Columns(1).HeaderText = "Student No."
        dg1.Columns(1).Width = 120
        dg1.Columns(2).HeaderText = "First Name"
        dg1.Columns(2).Width = 120
        dg1.Columns(3).HeaderText = "Middle Name"
        dg1.Columns(3).Width = 120
        dg1.Columns(4).HeaderText = "Last Name"
        dg1.Columns(4).Width = 120
        dg1.Columns(5).HeaderText = "File Type"
        dg1.Columns(6).HeaderText = "Filename"
        dg1.Columns(6).Width = 200
        dg1.Columns(7).HeaderText = "File Path"
        dg1.Columns(7).Width = 250



    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            If mskStudentNumber.Text = "" Then
                MsgBox("Student's info is required", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If cboFileType.Text = "" Then
                MsgBox("File type is required", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If txtFileName.Text = "" Then
                MsgBox("Attachement is required!", MsgBoxStyle.Exclamation)
                Exit Sub
                txtFileName.Focus()
            End If

            str = "insert into docs values(0,'" & mskStudentNumber.Text & "','" & txtFname.Text & "','" & txtMName.Text & "','" & txtLastName.Text & "','" & cboFileType.Text & "','" & txtFileName.Text & "','" & lblPath.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Successfully saved!", MsgBoxStyle.Information)
            conn.Close()
            formLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmFileUploader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        lblID.Text = dg1.Item(0, i).Value
        mskStudentNumber.Text = dg1.Item(1, i).Value
        txtFname.Text = dg1.Item(2, i).Value
        txtMName.Text = dg1.Item(3, i).Value
        txtLastName.Text = dg1.Item(4, i).Value
        cboFileType.Text = dg1.Item(5, i).Value
        txtFileName.Text = dg1.Item(6, i).Value
        lblPath.Text = dg1.Item(7, i).Value

        tsSave.Enabled = False
        tsDelete.Enabled = True
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from docs where id='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Deleted successfully!", MsgBoxStyle.Information)
                conn.Close()
                formLoad()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            Dim str As String
            str = "select * from docs where LName like '%" & txtSearch.Text & "%' order by LName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "docs")
            dg1.DataSource = ds.Tables("docs")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Student No."
            dg1.Columns(1).Width = 120
            dg1.Columns(2).HeaderText = "First Name"
            dg1.Columns(2).Width = 120
            dg1.Columns(3).HeaderText = "Middle Name"
            dg1.Columns(3).Width = 120
            dg1.Columns(4).HeaderText = "Last Name"
            dg1.Columns(4).Width = 120
            dg1.Columns(5).HeaderText = "File Type"
            dg1.Columns(6).HeaderText = "Filename"
            dg1.Columns(6).Width = 200
            dg1.Columns(7).HeaderText = "File Path"
            dg1.Columns(7).Width = 250


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class