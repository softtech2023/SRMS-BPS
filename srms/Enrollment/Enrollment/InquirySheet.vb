Imports MySql.Data.MySqlClient
Public Class frmInquirySheet
    Dim str As String

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If txtfname.Text = "" Then
                MsgBox("Please enter the First Name", MsgBoxStyle.Information)
                txtfname.Focus()
                Exit Sub
            End If
            If txtlname.Text = "" Then
                MsgBox("Please enter the Last Name", MsgBoxStyle.Information)
                txtlname.Focus()
                Exit Sub
            End If


            str = "insert into inquiry values('0','" & txtlname.Text & "','" & txtfname.Text & "','" & txtMname.Text & "','" & txtContactNumber.Text & "','" & txtAddress.Text & "','" & cboCourse.Text & "','" & txtlastschool.Text & "','" & cbohowdiyou.Text & "')"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            MsgBox("Data successfully added!", MsgBoxStyle.Information)
            conn.Close()

            ClearFields()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub ClearFields()
        txtlname.Clear()
        txtfname.Clear()
        txtMname.Clear()
        txtContactNumber.Clear()
        txtAddress.Clear()
        cboCourse.ResetText()
        txtlastschool.Clear()
        cbohowdiyou.ResetText()

    End Sub

    


    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim dclick As Integer
        dclick = dg.CurrentRow.Index
        lblID.Text = dg.Item(0, dclick).Value
        txtfname.Text = dg.Item(2, dclick).Value
        txtMname.Text = dg.Item(3, dclick).Value
        txtlname.Text = dg.Item(1, dclick).Value
        txtContactNumber.Text = dg.Item(4, dclick).Value
        txtAddress.Text = dg.Item(5, dclick).Value
        cboCourse.Text = dg.Item(6, dclick).Value
        txtlastschool.Text = dg.Item(7, dclick).Value
        cbohowdiyou.Text = dg.Item(8, dclick).Value


      
    End Sub

    Private Sub dg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            str = "update inquiry set inquiryid='" & lblID.Text & "',LastName='" & txtlname.Text & "',FirstName='" & txtfname.Text & "',MiddleName='" & txtMname.Text & "',ContactNumber='" & txtContactNumber.Text & "',Address='" & txtAddress.Text & "',Course='" & cboCourse.Text & "',LastSchoolAttended='" & txtlastschool.Text & "',How='" & cbohowdiyou.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Data has been updated!", MsgBoxStyle.Information)
            conn.Close()

            ClearFields()
          
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                str = "delete from inquiry where inquiryid='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()

                ClearFields()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select LastName, FirstName, MiddleName, ContactNumber, Address, Course, LastSchoolAttended, How, inquiryid from inquiry where LastName like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "inquiry")
            dg.DataSource = ds.Tables("inquiry")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dg_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        Dim dclick As Integer
        dclick = dg.CurrentRow.Index
        lblID.Text = dg.Item(0, dclick).Value
        txtfname.Text = dg.Item(2, dclick).Value
        txtMname.Text = dg.Item(3, dclick).Value
        txtlname.Text = dg.Item(1, dclick).Value
        txtContactNumber.Text = dg.Item(4, dclick).Value
        txtAddress.Text = dg.Item(5, dclick).Value
        cboCourse.Text = dg.Item(6, dclick).Value
        txtlastschool.Text = dg.Item(7, dclick).Value
        cbohowdiyou.Text = dg.Item(8, dclick).Value


       

    End Sub

    
   
    Private Sub dg_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub frmInquirySheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class