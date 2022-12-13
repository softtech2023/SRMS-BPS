Imports MySql.Data.MySqlClient
Public Class frmuseraccounts
    Dim str As String
    Public Sub FormLoad()
        Try
            str = "select * from users where position!='Super Admin'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "users")
            dgUser.DataSource = ds.Tables("users")
            conn.Close()

            dgUser.Columns(0).HeaderText = "Username"
            dgUser.Columns(1).HeaderText = "Password"
            dgUser.Columns(1).Width = 200
            dgUser.Columns(2).HeaderText = "System Access"
            dgUser.Columns(3).HeaderText = "First Name"
            dgUser.Columns(3).Width = 100
            dgUser.Columns(4).HeaderText = "Middle Name"
            dgUser.Columns(4).Width = 100
            dgUser.Columns(5).HeaderText = "Last Name"
            dgUser.Columns(5).Width = 100
            dgUser.Columns(6).HeaderText = "Email"
            dgUser.Columns(7).Visible = False
            dgUser.Columns(8).HeaderText = "Acct. Status"
            dgUser.Columns(9).HeaderText = "Date Created"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
        tsResetPassword.Enabled = False

        txtFName.Clear()
        txtMName.Clear()
        txtLName.Clear()
        txtUsername.Clear()
        txtpassword1.Clear()
        txtConfirm.Clear()
        cboposition.ResetText()
        txtEmail.Clear()

        txtFName.Focus()

    End Sub
    Private Sub frmuseraccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub

    Private Sub dgUser_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgUser.DoubleClick
        Try
            Dim dclick As Integer
            dclick = dgUser.CurrentRow.Index

            txtUsername.Text = dgUser.Item(0, dclick).Value
            lblOldUsername.Text = dgUser.Item(0, dclick).Value
            cboposition.Text = dgUser.Item(2, dclick).Value
            txtFName.Text = dgUser.Item(3, dclick).Value
            txtMName.Text = dgUser.Item(4, dclick).Value
            txtLName.Text = dgUser.Item(5, dclick).Value
            'txtpassword1.Text = getSHA1Hash(dgUser.Item(1, dclick).Value)
            'txtConfirm.Text = getSHA1Hash(dgUser.Item(1, dclick).Value)

            txtEmail.Text = dgUser.Item(6, dclick).Value

            txtFName.ReadOnly = True
            txtpassword1.ReadOnly = True
            txtConfirm.ReadOnly = True

            txtpassword1.Enabled = False
            txtConfirm.Enabled = False

            tsSave.Enabled = False
            tsResetPassword.Enabled = True
            tsUpdate.Enabled = True
            tsDelete.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from users where username like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "users")
            dgUser.DataSource = ds.Tables("users")
            conn.Close()

            dgUser.Columns(0).HeaderText = "Username"
            dgUser.Columns(1).HeaderText = "Password"
            dgUser.Columns(1).Width = 200
            dgUser.Columns(2).HeaderText = "System Access"
            dgUser.Columns(3).HeaderText = "First Name"
            dgUser.Columns(3).Width = 100
            dgUser.Columns(4).HeaderText = "Middle Name"
            dgUser.Columns(4).Width = 100
            dgUser.Columns(5).HeaderText = "Last Name"
            dgUser.Columns(5).Width = 100
            dgUser.Columns(6).HeaderText = "Email"
            dgUser.Columns(7).Visible = False
            dgUser.Columns(8).HeaderText = "Acct. Status"
            dgUser.Columns(9).HeaderText = "Date Created"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            If txtFName.Text = "" Then
                MsgBox("Username is required!", MsgBoxStyle.Exclamation)
                txtFName.Focus()
                Exit Sub
            End If

            If txtpassword1.Text = "" Then
                MsgBox("Please enter your password!", MsgBoxStyle.Information)
                txtpassword1.Focus()
                Exit Sub
            End If
            Dim pass As String

            If txtpassword1.Text <> txtConfirm.Text Then
                MsgBox("Password not matched!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            pass = getSHA1Hash(txtConfirm.Text)


            str = "select * from users where username='" & txtFName.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "users")
            conn.Close()
            If ds.Tables("users").Rows.Count = 1 Then
                MsgBox("username already in used! please try again.", MsgBoxStyle.Information)
                conn.Close()
                txtFName.Focus()
                Exit Sub
            End If
            Dim Name As String
            Name = txtFName.Text + txtMName.Text + txtLName.Text

            str = "insert into users values('" & txtUsername.Text & "','" & pass & "','" & cboposition.Text & "','" & txtFName.Text & "','" & txtMName.Text & "','" & txtLName.Text & "','" & txtEmail.Text & "','avatar.png','active','" & Convert.ToDateTime(frmParent.dtpDate.Text).ToString("yyyy-MM-dd") & "','" & Name & "')"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            MsgBox("One (1) record added successfully!", MsgBoxStyle.Information)
            'Save()
            conn.Close()
            FormLoad()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from users where username='" & lblOldUsername.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                'Delete()
                conn.Close()
                FormLoad()

                tsSave.Enabled = True
                tsUpdate.Enabled = False
                tsDelete.Enabled = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try


    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try

            str = "update users set username='" & txtUsername.Text & "',position='" & cboposition.Text & "',email='" & txtEmail.Text & "' where username='" & lblOldUsername.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("The selected account has been updated!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()

            txtFName.ReadOnly = False
            txtpassword1.ReadOnly = False
            txtConfirm.ReadOnly = False

            txtFName.Enabled = True
            txtpassword1.Enabled = True
            txtConfirm.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
    End Sub

    Private Sub tsResetPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsResetPassword.Click
        frmResetPass.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddstude.Click
        frmCompleteList.ShowDialog()
    End Sub

    Private Sub btnaddemployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddemployee.Click
        frmSearchPersonnel.ShowDialog()

    End Sub
End Class