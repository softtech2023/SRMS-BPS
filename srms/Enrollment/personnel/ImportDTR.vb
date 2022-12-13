Imports System.Data.OleDb
'Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Public Class frmImportDTR
    Dim str As String
    Dim conn1 As OleDbConnection
    Dim dtr As OleDbDataReader
    Dim dta As OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dts As DataSet
    Dim excel As String
    Dim OpenFileDialog As New OpenFileDialog

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        Try
            OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            OpenFileDialog.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"

            If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then

                Dim fi As New IO.FileInfo(OpenFileDialog.FileName)
                Dim FileName As String = OpenFileDialog.FileName

                excel = fi.FullName
                conn1 = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
                dta = New OleDbDataAdapter("Select * From [Sheet1$]", conn1)
                dts = New DataSet
                dta.Fill(dts, "[Sheet1$]")
                DGV1.DataSource = dts
                DGV1.DataMember = "[Sheet1$]"
                conn.Close()
                DGV1.Columns(0).ReadOnly = True
                DGV1.Columns(1).Width = 180
                DGV1.Columns(1).ReadOnly = True
                DGV1.Columns(2).Width = 150
                DGV1.Columns(2).ReadOnly = True
                DGV1.Columns(3).Width = 150
                DGV1.Columns(3).ReadOnly = True
                DGV1.Columns(4).Width = 150
                DGV1.Columns(4).ReadOnly = False

                btnSave.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            For x As Integer = 0 To DGV1.Rows.Count - 1
                str = "insert into hris_attendance values(0,'" & DGV1.Item(0, x).Value & "','" & DGV1.Item(1, x).Value & "','" & DGV1.Item(2, x).Value & "','" & Convert.ToDateTime(DGV1.Item(3, x).Value).ToString("yyyy-MM-dd") & "','" & DGV1.Item(4, x).Value & "')"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()

            Next
            MsgBox("Selected records has been imported successfully", MsgBoxStyle.Information)

            formLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmImportDTR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()
    End Sub
    Public Sub formLoad()
        btnImport.Enabled = True
        btnSave.Enabled = False

        Try
            str = "select * from hris_attendance where IDNumber=''"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "hris_attendance")
            DGV1.DataSource = ds.Tables("hris_attendance")
            conn.Close()

            DGV1.Columns(0).Visible = False
            DGV1.Columns(1).HeaderText = "Employee No."
            DGV1.Columns(1).Width = 200
            DGV1.Columns(2).HeaderText = "Employee Name"
            DGV1.Columns(2).Width = 200
            DGV1.Columns(3).HeaderText = "Department"
            DGV1.Columns(3).Width = 200
            DGV1.Columns(4).Visible = False
            DGV1.Columns(5).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class