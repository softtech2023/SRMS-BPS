Imports MySql.Data.MySqlClient
Module Connection
    Public conn As New MySqlConnection("Database=bpsedu_srms;" & _
                                           "Server =Server1;" & _
                                           "User ID = root; Password = moth34board;")
    Public conn1 As New MySqlConnection("Database=bpsedu_srms;" & _
                                   "Server =Server1;" & _
                                   "User ID = root; Password = moth34board;")

    'Server Name:IHMA_SERVER
    'IHMA IP:  192.168.1.53, bpsedu_srms
    'Public IP : 27.110.168.250


    Public Sub AddSemSubjects(ByVal ls As ListView, ByVal subjectcode As String, ByVal Description As String, ByVal LecTime As String, ByVal LabTime As String, ByVal Room As String, ByVal Section As String, ByVal LecUnits As String, ByVal LabUnits As String, ByVal Instructor As String, ByVal Slot As String)
        Dim lv As New ListViewItem
        ls.Items.Add(lv)
        lv.Text = subjectcode
        lv.SubItems.Add(Description)
        lv.SubItems.Add(LecTime)
        lv.SubItems.Add(LabTime)
        lv.SubItems.Add(Room)
        lv.SubItems.Add(Section)
        lv.SubItems.Add(LecUnits)
        lv.SubItems.Add(LabUnits)
        lv.SubItems.Add(Instructor)
        lv.SubItems.Add(Slot)

    End Sub

    Public Sub AddFees(ByVal lv As ListView, ByVal Description As String, ByVal Amount As Double)
        Dim n As New ListViewItem
        lv.Items.Add(n)
        n.Text = Description
        n.SubItems.Add(Amount)

    End Sub
    Public Sub ListView(ByVal lv As ListView, ByVal BookNo As String, ByVal BookTitle As String, ByVal Author As String, ByVal DueDate As Date, ByVal BookStatus As String, ByVal BookID As Integer)
        Dim i As New ListViewItem
        lv.Items.Add(i)
        i.Text = BookNo
        i.SubItems.Add(BookTitle)
        i.SubItems.Add(Author)
        i.SubItems.Add(DueDate)
        i.SubItems.Add(BookStatus)
        i.SubItems.Add(BookID)

    End Sub
    Public Function Encrypt(ByVal icText As String) As String
        Dim icLen As Integer
        Dim icNewText, icChar As String
        icChar = ""
        icNewText = ""
        icLen = Len(icText)
        For i = 1 To icLen
            icChar = Mid(icText, i, 1)
            Select Case Asc(icChar)
                Case 65 To 90
                    icChar = Chr(Asc(icChar) + 127)
                Case 97 To 122
                    icChar = Chr(Asc(icChar) + 121)
                Case 48 To 57
                    icChar = Chr(Asc(icChar) + 196)
                Case 32
                    icChar = Chr(32)
            End Select
            icNewText = icNewText + icChar
        Next
        Encrypt = icNewText
    End Function
    Function getSHA1Hash(ByVal strToHash As String) As String
        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = sha1Obj.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function

    Public Sub Save()
        MsgBox("New Record has been added!", MsgBoxStyle.Information)
    End Sub
    Public Sub Update()
        MsgBox("Selected Record has been updated!", MsgBoxStyle.Information)
    End Sub
    Public Sub Delete()
        MsgBox("Selected Record has been deleted!", MsgBoxStyle.Information)
    End Sub
    Public Sub ClearTextBox(ByVal bpsedu_srms As Control)
        For Each ctrl As Control In bpsedu_srms.Controls
            ClearTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next
    End Sub
End Module
