Imports MySql.Data.MySqlClient
Public Class frmbycat
    Dim str As String

    Private Sub ByAuthor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getAuthor()
    End Sub
    Public Sub getAuthor()
        Try
            str = "select Category from libcategory order by Category"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libcategory")
            cboAuthor.ValueMember = "libcategory"
            cboAuthor.DisplayMember = "Category"
            cboAuthor.DataSource = ds.Tables("libcategory")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "select lb.BookNo, lb.Title, lb.Category, lb.Edition,lb.Author,lb.BookStatus, st.letterHead from libbookentry lb join srms_settings st on lb.settingsID = st.settingsID where lb.Category='" & cboAuthor.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "libbookentry")
            Dim obj As New ByCategory
            obj.SetDataSource(mysds.Tables("libbookentry"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            conn.Close()

        End Try
    End Sub

 
End Class