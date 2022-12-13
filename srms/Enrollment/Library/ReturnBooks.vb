Imports MySql.Data.MySqlClient
Public Class frmReturnBooks
    Dim str As String

    Private Sub ReturnBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formload()
        txtStudentNo.Clear()
        txtName.Clear()
        txtCourse.Clear()
        txtYearLevel.Clear()

    End Sub
    Public Sub formload()
        Dim day As Double
        'day = frmParent.cbodays.Text
        txtbookno.Clear()
        txttitle.Clear()
        dtpborroweddate.Text = Today
        dtpduedate.Text = dtpborroweddate.Value.AddDays(day).ToShortDateString
        txtprocby.Text = frmParent.lblUser.Text
        txtreturndate.Text = Today
        'txtfines.Text = frmParent.cbofines.Text
        DateTimePicker1.Text = Today
        txtfines.Text = 0
        tsSave.Enabled = True
        btnselectbook.Enabled = True


    End Sub
    Public Sub subtractdate()
        Try
          
            Dim result As String
            result = DateDiff("d", dtpduedate.Text, DateTimePicker1.Text)
            txtdays.Text = result
            If txtdays.Text < 0 Then
                txtdays.Text = 0
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            conn.Close()

        End Try
    End Sub
    Public Sub getfines()
        Dim fines As String
        fines = Val(txtdays.Text) * Val(txtfines.Text)
        txtgetfines.Text = fines
        If txtgetfines.Text < 0 Then
            txtgetfines.Text = 0
            Exit Sub
        End If
    End Sub
    Private Sub btnSelectStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectStaff.Click
        frmLoanStude.ShowDialog()
    End Sub
    Private Sub btnselectbook_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselectbook.Click
        frmLoanedBooks.ShowDialog()
    End Sub
  
    Private Sub txtdays_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdays.TextChanged
        getfines()
    End Sub

    Private Sub txtfines_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfines.TextChanged
        getfines()
    End Sub


    Private Sub dtpduedate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpduedate.ValueChanged
        subtractdate()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        subtractdate()
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

            'update libloans returndate and returned into yes
            str = "update libloans set RetDate='" & txtreturndate.Text & "',Returned='" & lblYes.Text & "' where BookID='" & lblBookID.Text & "'"
            conn.Open()
            Dim com As New MySqlCommand(str, conn)
            com.ExecuteNonQuery()
            conn.Close()
            'update libbookentry BookStatus into In
            str = "update libbookentry set BookStatus='In' where BookID='" & lblBookID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            If txtfines.Text = 0 Then

            Else
                str = "insert into libfines values (0,'" & txtName.Text & "','" & Title & "','" & txtfines.Text & "','" & txtdays.Text & "','Unpaid','" & txtreturndate.Text & "',0,1,'" & txtStudentNo.Text & "')"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str, conn)
                mysc1.ExecuteNonQuery()
                conn.Close()

            End If
            'insert into libfines

            formload()
            MsgBox("Book successfully returned!", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class