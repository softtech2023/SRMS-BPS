Imports MySql.Data.MySqlClient
Public Class frmCourses
    Dim str As String

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCourse.TextChanged

    End Sub

    Private Sub frmCourses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.DataSet.courses)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtCourse.Text = "" Then
            MsgBox("Type the course you want to add!", MsgBoxStyle.Information)
            Exit Sub
        End If
        str = "insert into courses values('0','" & txtCourse.Text & "')"
        conn.Open()
        Dim mysC As New MySqlCommand(str, conn)
        mysC.ExecuteNonQuery()
        MsgBox("Data successfully added!", MsgBoxStyle.Information)
        conn.Close()
        Me.CoursesTableAdapter.Fill(Me.DataSet.courses)
        txtCourse.Clear()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        str = "SELECT coursedescription, courseid FROM courses where coursedescription like '%" & txtSearch.Text & "&'"
        conn.Open()
        Dim Search As New MySqlDataAdapter(str, conn)
        Dim ds As DataSet = New DataSet
        Search.Fill(ds, "courses")
        dgcourse.DataSource = ds.Tables("courses")
        conn.Close()
        Me.CoursesTableAdapter.Fill(Me.DataSet.courses)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtCourse.Text = "" Then
            MsgBox("Please select a COURSE you want to delete!", MsgBoxStyle.Information)
            Exit Sub
        End If
        If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            str = "delete from courses where courseid='" & lblID.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            MsgBox("Data successfully deleted!", MsgBoxStyle.Information, "Prompt")
            conn.Close()
            Me.CoursesTableAdapter.Fill(Me.DataSet.courses)
            txtCourse.Clear()
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtCourse.Text = "" Then
            MsgBox("Please select a COURSE you want to update!", MsgBoxStyle.Information)
            Exit Sub
        End If
        str = "update courses set coursedescription='" & txtCourse.Text & "' where courseid='" & lblID.Text & "'"
        conn.Open()
        Dim mysC As New MySqlCommand(str, conn)
        mysC.ExecuteNonQuery()
        MsgBox("Data successfully updated!", MsgBoxStyle.Information)
        conn.Close()
        Me.CoursesTableAdapter.Fill(Me.DataSet.courses)

        txtCourse.Clear()
    End Sub

    Private Sub dgcourse_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgcourse.CellContentClick

    End Sub

    Private Sub dgcourse_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgcourse.DoubleClick
        Dim dclick As Integer
        dclick = dgcourse.CurrentRow.Index
        txtCourse.Text = dgcourse.Item(1, dclick).Value

        
    End Sub
End Class