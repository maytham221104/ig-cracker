Imports System
Imports System.IO
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

' Token: 0x02000016 RID: 22
Public Class GClass0
    ' Token: 0x06000083 RID: 131 RVA: 0x0000838C File Offset: 0x0000658C
    Public Shared Function smethod_0(cookieContainer_1 As CookieContainer) As String
        Try
            Dim text As String = String.Empty
            Dim textx As String = ""
            Dim text2 As String = String.Empty
            Dim text3 As String = String.Empty
            Dim text4 As String = String.Empty
            Dim text5 As String = String.Empty
            Dim text6 As String = String.Empty
            Dim text7 As String = String.Empty
            Dim text8 As String = String.Empty
            Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create("https://i.instagram.com/api/v1/accounts/current_user/?edit=true"), HttpWebRequest)
            Dim str As String = Guid.NewGuid().ToString().ToUpper()
            httpWebRequest.Host = "i.instagram.com"
            httpWebRequest.UserAgent = "Instagram 7.10.0 Android (24/5.0; 515dpi; 1440x2416; huawei/google; Nexus 6P; angler; angler; en_US)"
            httpWebRequest.Headers.Add("Accept-Language", "ar;q=1, en;q=0.9")
            httpWebRequest.KeepAlive = True
            httpWebRequest.Proxy = Nothing
            httpWebRequest.ContentType = "multipart/form-data; boundary=" + str
            httpWebRequest.CookieContainer = cookieContainer_1
            Using streamReader As StreamReader = New StreamReader(httpWebRequest.GetResponse().GetResponseStream())
                Dim input As String = streamReader.ReadToEnd()
                text = Regex.Match(input, "pk"": (.*?),").Groups(1).Value
                If Operators.CompareString(text, Nothing, False) = 0 Then
                    text = Regex.Match(input, "pk"": (.*?)}").Groups(1).Value
                    If Operators.CompareString(text, Nothing, False) = 0 Then
                        Return "|||||||"
                    End If
                End If
                text2 = Regex.Match(input, "full_name"": ""(.*?)""").Groups(1).Value
                text3 = Regex.Match(input, "is_private"": (.*?),").Groups(1).Value
                If Operators.CompareString(text3, Nothing, False) = 0 Then
                    text3 = Regex.Match(input, "is_private"": (.*?)}").Groups(1).Value
                    If Operators.CompareString(text3, Nothing, False) = 0 Then
                        Return "|||||||"
                    End If
                End If
                text4 = Regex.Match(input, "phone_number"": ""(.*?)""").Groups(1).Value
                text5 = Regex.Match(input, "biography"": ""(.*?)""").Groups(1).Value
                text6 = Regex.Match(input, "gender"": (.*?),").Groups(1).Value
                If Operators.CompareString(text6, Nothing, False) = 0 Then
                    text6 = Regex.Match(input, "gender"": (.*?)}").Groups(1).Value
                    If Operators.CompareString(text6, Nothing, False) = 0 Then
                        Return "|||||||"
                    End If
                End If
                text7 = Regex.Match(input, "email"": ""(.*?)""").Groups(1).Value
                text8 = Regex.Match(input, "external_url"": ""(.*?)""").Groups(1).Value
                GClass0.string_0 = String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}", New Object() {text, text2, text3, text4, text5, text6, text7, text8})
            End Using
        Catch ex As WebException
            Dim httpWebResponse As HttpWebResponse = CType(ex.Response, HttpWebResponse)
            If CDbl(httpWebResponse.StatusCode) = Conversions.ToDouble("400") Then
                MessageBox.Show(String.Concat(New String() {"Sign in on browser then come back."}), "KingDom Team: Sign in Error")
            Else
                MessageBox.Show(String.Concat(New String() {"Update Required."}), "KingDom Team: Sign in Error")
            End If
        End Try
        Return GClass0.string_0
    End Function

    ' Token: 0x06000084 RID: 132 RVA: 0x0000871C File Offset: 0x0000691C
    Public Shared Function smethod_1(string_1 As String, string_2 As String, string_3 As String) As CookieContainer
        Try
            Dim str As String = Guid.NewGuid().ToString().ToUpper()
            Dim stringBuilder As StringBuilder = New StringBuilder()
            Dim stringBuilder2 As StringBuilder = stringBuilder
            Dim text As String = String.Concat(New String() {"{""_uuid"":""", string_3, """,""password"":""", string_2, """,""username"":""", string_1, """,""device_id"":""", string_3, """,""from_reg"":false,""_csrftoken"":""missing"",""login_attempt_count"":0}"})
            text = String.Format("{0}.{1}", GClass0.smethod_3(text, "fc4720e1bf9d79463f62608c86fbddd374cc71bbfb98216b52e3f75333bd130d"), text)
            stringBuilder2.AppendLine("--" + str)
            stringBuilder2.AppendLine("Content-Disposition: form-data; name=""signed_body""")
            stringBuilder2.AppendLine()
            stringBuilder2.AppendLine(text)
            stringBuilder2.AppendLine("--" + str)
            stringBuilder2.AppendLine("Content-Disposition: form-data; name=""ig_sig_key_version""")
            stringBuilder2.AppendLine()
            stringBuilder2.AppendLine("4")
            stringBuilder2.Append("--" + str + "--")
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(stringBuilder.ToString())
            Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create("https://i.instagram.com/api/v1/accounts/login/"), HttpWebRequest)
            httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip
            httpWebRequest.Method = "POST"
            httpWebRequest.Host = "i.instagram.com"
            httpWebRequest.UserAgent = "Instagram 9.4.0 Android (18/4.3; 320dpi; 720x1280; Xiaomi; HM 1SW; armani; qcom; en_US)"
            httpWebRequest.Headers.Add("Accept-Language", "ar;q=1, en;q=0.9")
            httpWebRequest.KeepAlive = True
            httpWebRequest.Proxy = Nothing
            httpWebRequest.ContentType = "multipart/form-data; boundary=" + str
            httpWebRequest.ContentLength = CLng(bytes.Length)
            httpWebRequest.CookieContainer = GClass0.cookieContainer_0
            Dim requestStream As Stream = httpWebRequest.GetRequestStream()
            requestStream.Write(bytes, 0, bytes.Length)
            requestStream.Close()
            Dim httpWebResponse As HttpWebResponse = CType(httpWebRequest.GetResponse(), HttpWebResponse)
            Using streamReader As StreamReader = New StreamReader(httpWebResponse.GetResponseStream())
                If streamReader.ReadToEnd().Contains("logged_in_user") Then
                    Return GClass0.cookieContainer_0
                End If
                streamReader.Close()
            End Using
            httpWebResponse.Close()
        Catch ex As Exception
        End Try
        Return Nothing
    End Function

    ' Token: 0x06000085 RID: 133 RVA: 0x0000897C File Offset: 0x00006B7C
    Public Shared Function smethod_2(cookieContainer_1 As CookieContainer) As CookieContainer
        Application.DoEvents()
        Try
            Dim str As String = Guid.NewGuid().ToString().ToUpper()
            Dim stringBuilder As StringBuilder = New StringBuilder()
            String.Concat(New String() {""})
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(stringBuilder.ToString())
            Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create("https://i.instagram.com/api/v1/accounts/logout/"), HttpWebRequest)
            httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip
            httpWebRequest.Method = "POST"
            httpWebRequest.Host = "i.instagram.com"
            httpWebRequest.UserAgent = "Instagram 7.10.0 Android (24/5.0; 515dpi; 1440x2416; huawei/google; Nexus 6P; angler; angler; en_US)"
            httpWebRequest.Headers.Add("Accept-Language", "ar;q=1, en;q=0.9")
            httpWebRequest.KeepAlive = True
            httpWebRequest.Proxy = Nothing
            httpWebRequest.ContentType = "multipart/form-data; boundary=" + str
            httpWebRequest.ContentLength = CLng(bytes.Length)
            httpWebRequest.CookieContainer = cookieContainer_1
            Dim requestStream As Stream = httpWebRequest.GetRequestStream()
            requestStream.Write(bytes, 0, bytes.Length)
            requestStream.Close()
            Dim httpWebResponse As HttpWebResponse = CType(httpWebRequest.GetResponse(), HttpWebResponse)
            Using streamReader As StreamReader = New StreamReader(httpWebResponse.GetResponseStream())
                If streamReader.ReadToEnd().Contains("{""status"": ""ok""}") Then
                    Return Nothing
                End If
                streamReader.Close()
            End Using
            httpWebResponse.Close()
        Catch ex As Exception
        End Try
        Return cookieContainer_1
    End Function

    ' Token: 0x06000086 RID: 134 RVA: 0x00008B14 File Offset: 0x00006D14
    Public Shared Function smethod_3(string_1 As String, string_2 As String) As String
        Dim stringBuilder As StringBuilder = New StringBuilder()
        Dim hmacsha As HMACSHA256 = New HMACSHA256(Encoding.UTF8.GetBytes(string_2))
        hmacsha.ComputeHash(Encoding.UTF8.GetBytes(string_1))
        Dim hash As Byte() = hmacsha.Hash
        Dim num As Integer = hash.Length - 1
        Dim i As Integer = 0
        Dim num2 As Integer
        While i <= num2
            stringBuilder.Append(hash(i).ToString("x2"))
            i += 1
            num2 = num
        End While
        Return stringBuilder.ToString()
    End Function

    ' Token: 0x0400003C RID: 60
    Public Shared string_0 As String

    ' Token: 0x0400003D RID: 61
    Public Shared cookieContainer_0 As CookieContainer = New CookieContainer()
    Public Shared Function smethod_4(string_0 As String) As String()
        Dim bool_ As Boolean = True
        Dim text As String = ""
    End Function


End Class
