Imports MySql.Data.MySqlClient
Public Class frmLoanBooks
    Dim str As String
    Private Sub btnSelectStude_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSelectStudes.ShowDialog()

    End Sub

    Private Sub frmLoanBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formload()

    End Sub
    Public Sub formload()
        txtbookno.Clear()
        txttitle.Clear()
        dtpborroweddate.Text = Today
        dtpduedate.Text = dtpborroweddate.Value.AddDays(5).ToShortDateString
        txtprocby.Text = frmParent.lblUser.Text
        txtreturndate.Clear()
        tsSave.Enabled = True
        btnselectbook.Enabled = True

    End Sub

    Private Sub btnselectbook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btnSelectStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectStaff.Click
        'frmSelectStudes.ShowDialog()
        frmSelectBorrower.Show()
    End Sub

    Private Sub btnselectbook_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselectbook.Click
        frmSelectBook.ShowDialog()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tsSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            Dim Title As String
            'to save in libloans
            Title = txttitle.Text.Replace("'", "''")

            If txtStudentNo.Text = "" Then
                MsgBox("Student's details is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txtbookno.Text = "" Then
                MsgBox("Book's details is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            str = "insert into libloans values (0,'" & txtStudentNo.Text & "','" & txtName.Text & "','" & txtCourse.Text & "','" & txtYearLevel.Text & "','" & lblBookID.Text & "','" & txtbookno.Text & "','" & Title & "','" & Convert.ToDateTime(dtpborroweddate.Text).ToString("yyyy-MM-dd") & "','" & Convert.ToDateTime(dtpduedate.Text).ToString("yyyy-MM-dd") & "','" & txtprocby.Text & "','" & txtreturndate.Text & "','" & lblNo.Text & "',1,'Student')"
            conn.Open()
            Dim command As New MySqlCommand(str, conn)
            command.ExecuteNonQuery()
            conn.Close()

            'to update libbookentry status=in into status=out
            str = "update libbookentry set BookStatus='Out' where bookID='" & lblBookID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()

            conn.Close()

            MsgBox("Saved Successfully!", MsgBoxStyle.Information)
            formload()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub
End Class