Imports MySql.Data.MySqlClient
Public Class frmBooksInfo
    Dim str As String
    Private Sub tsClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Formload()
        Me.Close()
    End Sub

    Private Sub tsSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSearchBooks.ShowDialog()
    End Sub

    Public Sub Formload()
        tsSave.Enabled = True
        tsDuplicate.Enabled = False
        tsUpdate.Enabled = False
        tsDelete.Enabled = False

        txtBookNum.Clear()
        txtTitle.Clear()
        txtAuthorNum.Clear()
        cboAuthor.ResetText()
        txtCoAuthors.Clear()
        cboPublisher.ResetText()
        txtYPublished.Clear()
        txtSubject.Clear()
        txtISBN.Clear()
        txtEdition.Clear()
        txtCallNum.Clear()
        cboCategory.ResetText()
        cboLocation.ResetText()
        txtDeweyNum.Clear()
        txtAccNo.Clear()
        txtPrice.Text = "00.00"
        dtpDate.Text = Today
        txtBookNum.Focus()

        Label3.Visible = False
        lblCopies.Visible = False
        getCategory()
        getLocation()
        getPublisher()
    End Sub

    Private Sub frmBooksInfo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Formload()
    End Sub

    Private Sub frmBooksInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Formload()
    End Sub

    Private Sub txtAuthorNum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAuthorNum.TextChanged
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "Select AuthorNum, concat(FirstName,' ',MiddleName,' ',LastName) as Name from libauthors where AuthorNum='" & txtAuthorNum.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then

                cboAuthor.Text = dtReader.Item(1)
                conn.Close()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        frmSelectAuthor.ShowDialog()
    End Sub
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        tsSave.PerformClick()
    End Sub
    Public Sub getCategory()
        Try
            str = "select * from libcategory"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libcategory")
            cboCategory.ValueMember = "libcategory"
            cboCategory.DisplayMember = "Category"
            cboCategory.DataSource = ds.Tables("libcategory")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub
    Public Sub getLocation()
        Try
            str = "select * from liblocation"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "liblocation")
            cboLocation.ValueMember = "liblocation"
            cboLocation.DisplayMember = "location"
            cboLocation.DataSource = ds.Tables("liblocation")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub
    Public Sub getPublisher()
        Try
            str = "select * from libpublisher"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libpublisher")
            cboPublisher.ValueMember = "libpublisher"
            cboPublisher.DisplayMember = "publisher"
            cboPublisher.DataSource = ds.Tables("libpublisher")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub

    Private Sub txtPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            Dim Title As String
            Title = txtTitle.Text.Replace("'", "''")



            If txtBookNum.Text = "" Then
                MsgBox("Book Number is Required!", MsgBoxStyle.Information)
                txtBookNum.Focus()
                Exit Sub
                If txtStatus.Text = "Out" Then
                    MsgBox("The book has been borrowed!", MsgBoxStyle.Information)

                End If
            End If
            str = "insert into libbookentry values('0','" & txtBookNum.Text & "','" & Title & "','" & txtAuthorNum.Text & "','" & cboAuthor.Text & "','" & txtCoAuthors.Text & "','" & cboPublisher.Text & "','" & txtYPublished.Text & "','" & txtSubject.Text & "','" & txtISBN.Text & "','" & txtEdition.Text & "','" & txtCallNum.Text & "','" & cboCategory.Text & "','" & cboLocation.Text & "','" & txtDeweyNum.Text & "','" & txtAccNo.Text & "','" & txtPrice.Text & "','" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") & "','" & txtStatus.Text & "',1)"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Books Info Saved!", MsgBoxStyle.Information)
            conn.Close()
            Formload()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub tsDuplicate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDuplicate.Click
        Try

            If txtStatus.Text = "Out" Then
                MsgBox("Cannot make duplicate! This book is currently borrowed!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            str = "select * from libbookentry where BookNo='" & txtBookNum.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libbookentry")

            If ds.Tables("libbookentry").Rows.Count = 1 Then
                MsgBox("Duplicate Book No. is not allowed!", MsgBoxStyle.Information)
                conn.Close()
                txtBookNum.Focus()
                Exit Sub
            End If
            conn.Close()

            If txtBookNum.Text = "" Then
                MsgBox("Book Number is Required!", MsgBoxStyle.Information)
                txtBookNum.Focus()
                Exit Sub
            End If

            tsSave.Enabled = True

            txtStatus.Text = "In"

            tsSave.PerformClick()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            Dim Title As String
            Title = txtTitle.Text.Replace("'", "''")


            str = "update libbookentry set BookID='" & lblID.Text & "',BookNo='" & txtBookNum.Text & "',Title='" & Title & "',AuthorNum='" & txtAuthorNum.Text & "',Author='" & cboAuthor.Text & "',coAuthors='" & txtCoAuthors.Text & "',Publisher='" & cboPublisher.Text & "',YPublished='" & txtYPublished.Text & "',Subject='" & txtSubject.Text & "',ISBN='" & txtISBN.Text & "',Edition='" & txtEdition.Text & "',CallNum='" & txtCallNum.Text & "',Category='" & cboCategory.Text & "',Location='" & cboLocation.Text & "',DeweyNum='" & txtDeweyNum.Text & "',AccNo='" & txtAccNo.Text & "',Price='" & txtPrice.Text & "',EntryDate='" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") & "',BookStatus='" & txtStatus.Text & "' where BookID='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record Updated!", MsgBoxStyle.Information)
            conn.Close()
            Formload()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If txtStatus.Text = "Out" Then
                MsgBox("Cannot delete this record! This book is currently borrowed!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from libbookentry where BookID='" & lblID.Text & "' and BookStatus='In'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Record deleted!", MsgBoxStyle.Information)
                conn.Close()
                Formload()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSearch.Click
        frmSearchBooks.Show()
    End Sub

    Private Sub tsClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsClose.Click
        Formload()
        Me.Close()
    End Sub
End Class