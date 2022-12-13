Imports System.Threading
Imports System.IO.Ports
Imports MySql.Data.MySqlClient
Public Class frmTimeIn
    Dim str As String
    Public Sub load_port_to_combobox_SMS()
        Try
            Dim Ports As String() = SerialPort.GetPortNames
            Dim port As String
            port = "COM100"
            cboPorts.Text = port
            'For Each port In Ports
            'cboPorts.Items.Add(port)
            'Next port
            'cboPorts.SelectedIndex = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Open_port_SMS()
        Try
            With SerialPort1
                .PortName = cboPorts.Text
                .BaudRate = 9600
                .Parity = Parity.None
                .StopBits = StopBits.One
                .DataBits = 8
                .Handshake = Handshake.RequestToSend
                .DtrEnable = True
                .RtsEnable = True
                .NewLine = vbCrLf
                'MsgBox("Port Successfully Open!")
                .Open()
            End With
            'MsgBox("Port Successfully Open!")
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Send_SMS()
        Try
            If SerialPort1.IsOpen Then
                With SerialPort1
                    .Write("AT" & vbCrLf)
                    .Write("AT+CMGF=1" & vbCrLf)
                    .Write("AT+CMGS=" & Chr(34) & txtContactNum.Text & Chr(34) & vbCrLf)
                    .Write(txtMessage.Text & txttimeout.Text & Chr(26))
                    'MsgBox("Message Sent")
                End With
            Else
                MsgBox("Error on the port")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub formLoad()
        'schoolInfo()
        frmParent.dtpDate.Text = Today
        PictureBox1.Image = My.Resources.default1
        ' Timer1.Enabled = True
        'Timer1.Start()
        'Me.Text = lblSchoolName.Text

        Dim TerminalNo As String
        TerminalNo = System.Net.Dns.GetHostName()
        lblTerminalNo.Text = TerminalNo.ToString

        txtRFID.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        txtRFID.Focus()

        load_port_to_combobox_SMS()
    End Sub
    Private Sub frmStudeGrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()
        load_port_to_combobox_SMS()
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Public Sub getProfile()
        Try
            If txtRFID.Text = "" Then

            Else
                Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
                str = "select * from studeprofile where rfid='" & txtRFID.Text & "'"
                conn.Open()
                Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
                objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
                dtReader = objCmd.ExecuteReader()
                If dtReader.Read Then
                    txtStudentNo.Text = dtReader(0)
                    txtFirstName.Text = dtReader(1)
                    txtMiddleName.Text = dtReader(2)
                    txtLastName.Text = dtReader(3)
                    txtContactNum.Text = dtReader(22)
                End If
                
                conn.Close()
                conn.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub getPhoto()
        Try
            If txtRFID.Text = "" Then

            Else
                Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
                str = "select profImage from profimage where StudentNumber='" & txtStudentNo.Text & "'"
                conn.Open()
                Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
                objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
                dtReader = objCmd.ExecuteReader()

                If dtReader.Read Then
                    Dim arrImage() As Byte
                    arrImage = dtReader.Item(0)
                    Dim mstream As New System.IO.MemoryStream(arrImage)
                    PictureBox1.Image = Image.FromStream(mstream)
                End If
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Private Sub txtStudentNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRFID.TextChanged
        getProfile()
        getPhoto()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        formLoad()
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtRFID.Text = "" Then

            Else
                str = "select * from studelogs where StudentNumber='" & txtStudentNo.Text & "' and logStat='Open' and logDate='" & Convert.ToDateTime(frmParent.dtpDate.Text).ToString("yyyy-MM-dd") & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studelogs")
                conn.Close()

                If ds.Tables("studelogs").Rows.Count = 1 Then
                    str = "update studelogs set logOutTime='" & frmParent.tsTime.Text & "',logpc='" & lblTerminalNo.Text & "',logstat='Closed' where logDate='" & Convert.ToDateTime(frmParent.dtpDate.Text).ToString("yyyy-MM-dd") & "' and logStat='Open' and StudentNumber='" & txtStudentNo.Text & "'"
                    conn.Open()
                    Dim mysc As New MySqlCommand(str, conn)
                    mysc.ExecuteNonQuery()
                    conn.Close()

                    Dim message As String
                    message = txtFirstName.Text & " " & " " & txtLastName.Text & " " & " successfully logout.. This is a system generated SMS.  Please do not reply. " & frmParent.dtpDate.Text & " " & frmParent.tsTime.Text & "'"
                    txtMessage.Text = message

                    btnSend.PerformClick()
                Else
                    str = "insert into studelogs values (0,'" & txtStudentNo.Text & "','" & Convert.ToDateTime(frmParent.dtpDate.Text).ToString("yyyy-MM-dd") & "','" & frmParent.tsTime.Text & "','','" & lblTerminalNo.Text & "','Open')"
                    conn.Open()
                    Dim mysc As New MySqlCommand(str, conn)
                    mysc.ExecuteNonQuery()
                    conn.Close()


                    Dim message As String
                    message = txtFirstName.Text & " " & " " & txtLastName.Text & " " & " successfully login. This is a system generated SMS.  Please do not reply. " & frmParent.dtpDate.Text & " " & frmParent.tsTime.Text & "'"
                    txtMessage.Text = message

                    btnSend.PerformClick()
                    'MsgBox("Login successfully!", MsgBoxStyle.Information)
                    'formLoad()
                End If

            End If
            
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        'Open_port_SMS()
        'Send_SMS()
    End Sub


End Class