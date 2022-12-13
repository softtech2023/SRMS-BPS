Imports System.Threading
Imports System.IO.Ports
Imports MySql.Data.MySqlClient
Public Class frmSMS
    Dim str As String
    Private Sub frmSMS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select IDNumber, concat(FirstName,' ',MiddleName,' ',LastName) as Name, empMobile from staff where empMobile!='' order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "staff")
            dg1.DataSource = ds.Tables("staff")
            conn.Close()
            dg1.Columns(1).Width = 200

            formLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Public Sub load_port_to_combobox_SMS()
        Try
            Dim Ports As String() = SerialPort.GetPortNames
            Dim port As String
            port = "COM100"
            cboPort.Text = port
            'For Each port In Ports
            'cboPort.Items.Add(port)
            'Next port
            'cboPort.SelectedIndex = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Open_port_SMS()
        Try
            With SerialPort1
                .PortName = cboPort.Text
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

                    For x As Integer = 0 To dg1.Rows.Count - 1
                        .Write("AT+CMGS=" & Chr(34) & dg1.Item(1, x).Value & Chr(34) & vbCrLf)
                    Next
                    .Write(txtMessage.Text & txttimeout.Text & Chr(26))
                End With
                MsgBox("Message Sent", MsgBoxStyle.Information)
            Else
                MsgBox("Error on the port")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub formLoad()
        load_port_to_combobox_SMS()
    End Sub
  
    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Open_port_SMS()
        Send_SMS()
    End Sub

End Class