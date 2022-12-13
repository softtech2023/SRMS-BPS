Imports MySql.Data.MySqlClient
Public Class frmSubjects
    Dim str As String
    Private Sub frmSubjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.subjects' table. You can move, or remove it, as needed.
        Me.SubjectsTableAdapter.Fill(Me.DataSet1.subjects)
        'TODO: This line of code loads data into the 'DataSet.curriculum' table. You can move, or remove it, as needed.
        Me.CurriculumTableAdapter.Fill(Me.DataSet.curriculum)

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtSubjectCode.Text = "" Then
            MsgBox("Subject code is required", MsgBoxStyle.Information)
            Exit Sub
        End If
        str = "insert into subjects values('0','" & txtSubjectCode.Text & "','" & txtdescription.Text & "','" & txtLecUnits.Text & "','" & txtLabUnits.Text & "','" & txtPreq.Text & "','" & cboCurriculum.Text & "')"
        conn.Open()
        Dim mysC As New MySqlCommand(Str, conn)
        mysC.ExecuteNonQuery()
        MsgBox("Data successfully added!", MsgBoxStyle.Information)
        conn.Close()
        Me.SubjectsTableAdapter.Fill(Me.DataSet1.subjects)
        ClearFields()
    End Sub
    Public Sub ClearFields()
        txtSubjectCode.Clear()
        txtdescription.Clear()
        txtLecUnits.Clear()
        txtLabUnits.Clear()
        txtPreq.Clear()
        cboCurriculum.ResetText()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtSubjectCode.Text = "" Then
            MsgBox("Please select a subject you want to update!", MsgBoxStyle.Information)
            Exit Sub
        End If
        str = "update subjects set subjectcode='" & txtSubjectCode.Text & "',description='" & txtdescription.Text & "',lecunit='" & txtLecUnits.Text & "',labunit='" & txtLabUnits.Text & "',prereq='" & txtPreq.Text & "',curriculum='" & cboCurriculum.Text & "' where subjectid='" & lblID.Text & "'"
        conn.Open()
        Dim mysC As New MySqlCommand(str, conn)
        mysC.ExecuteNonQuery()

        MsgBox("Data has been updated!", MsgBoxStyle.Information)
        Me.SubjectsTableAdapter.Fill(Me.DataSet1.subjects)
        conn.Close()
        ClearFields()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtSubjectCode.Text = "" Then
            MsgBox("Please select a subject you want to delete!", MsgBoxStyle.Information)
            Exit Sub
        End If

        If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            str = "delete from subjects where subjectID='" & lblID.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            MsgBox("Data successfully deleted!", MsgBoxStyle.Information, "Prompt")
            conn.Close()
            Me.SubjectsTableAdapter.Fill(Me.DataSet1.subjects)
        End If
        ClearFields()
    End Sub

    Private Sub dgsubjects_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgsubjects.DoubleClick
        Dim dclick As Integer
        dclick = dgsubjects.CurrentRow.Index
        lblID.Text = dgsubjects.Item(0, dclick).Value
        txtSubjectCode.Text = dgsubjects.Item(1, dclick).Value
        txtdescription.Text = dgsubjects.Item(2, dclick).Value
        txtLecUnits.Text = dgsubjects.Item(3, dclick).Value
        txtLabUnits.Text = dgsubjects.Item(4, dclick).Value
        txtPreq.Text = dgsubjects.Item(5, dclick).Value
        cboCurriculum.Text = dgsubjects.Item(6, dclick).Value
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        If cbosearch.SelectedIndex = 0 Then
            str = "select subjectcode, description, lecunit, labunit, prereq, curriculum, subjectid from subjects where subjectcode like '%" & txtsearch.Text & "%'"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "subjects")
            dgsubjects.DataSource = ds.Tables("subjects")
            conn.Close()
            ClearFields()
        End If
        If cbosearch.SelectedIndex = 1 Then
            str = "select subjectcode, description, lecunit, labunit, prereq, curriculum, subjectid from subjects where description like '%" & txtsearch.Text & "%'"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "subjects")
            dgsubjects.DataSource = ds.Tables("subjects")
            conn.Close()
            ClearFields()
        End If
    End Sub

    Private Sub dgsubjects_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgsubjects.CellContentClick

    End Sub
End Class