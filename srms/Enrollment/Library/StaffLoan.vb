Imports MySql.Data.MySqlClient
Public Class frmStaffLoan
    Dim str As String

    Private Sub btnSelectStude_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectStaff.Click
        frmSelectStaff.Show()
    End Sub
    Public Sub formload()
        txtbookno.Clear()
        txttitle.Clear()
        dtpborroweddate.Text = Today
        dtpduedate.Text = dtpborroweddate.Value.AddDays(5).ToShortDateString
        txtprocby.Text = frmParent.lblUser.Text
        txtreturndate.Clear()
        tsSave.Enabled = False
        btnselectbook.Enabled = False

    End Sub
    Private Sub frmStaffLoan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formload()
    End Sub

    Private Sub btnselectbook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselectbook.Click

        frmSelectBook.Show()
    End Sub


    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Try
            Dim Title As String
            'to save in libloans
            Title = txttitle.Text.Replace("'", "''")

            str = "insert into libloans values (0,0,'" & txtStudentNo.Text & "','" & txtName.Text & "',0,0,'" & lblBookID.Text & "','" & txtbookno.Text & "','" & Title & "','" & Convert.ToDateTime(dtpborroweddate.Text).ToString("yyyy-MM-dd") & "','" & Convert.ToDateTime(dtpduedate.Text).ToString("yyyy-MM-dd") & "','" & txtprocby.Text & "',0,'" & lblNo.Text & "',1,'" & lblTeacher.Text & "')"
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