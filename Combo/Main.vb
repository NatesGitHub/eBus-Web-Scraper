Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.CompilerServices
Imports OpenQA.Selenium.Chrome

Module StringExtensions

    <Extension()>
    Public Sub InvokeIfRequired(ByVal control As Control, action As MethodInvoker)
        If control.InvokeRequired Then
            control.Invoke(action)
        Else
            action()
        End If
    End Sub

End Module

Public Class Main
    Dim Cycle1 As Boolean
    Dim Cycle2 As Boolean
    Dim Charger
    Dim VehicleHlth
    Dim VehicleSoc
    Dim VehicleStat
    Dim VehicleRange

    'arrow
    Dim Arrow_1
    Dim Arrow_2
    Dim Arrow_3
    Dim Arrow_4
    Dim Arrow_5
    Dim Arrow_6
    Dim Arrow_7
    Dim Arrow_8
    Dim Arrow_9
    Dim Arrow_10
    Dim Arrow_11
    Dim Arrow_12
    Dim Arrow_13

    Dim Arrow1_stat
    Dim Arrow2_stat
    Dim Arrow3_stat
    Dim Arrow4_stat
    Dim Arrow5_stat
    Dim Arrow6_stat
    Dim Arrow7_stat
    Dim Arrow8_stat
    Dim Arrow9_stat
    Dim Arrow10_stat
    Dim Arrow11_stat
    Dim Arrow12_stat
    Dim Arrow13_stat

    'mt_dennis
    Dim MtDennis_1
    Dim MtDennis_2
    Dim MtDennis_3
    Dim MtDennis_4
    Dim MtDennis_5
    Dim MtDennis_6
    Dim MtDennis_7
    Dim MtDennis_8
    Dim MtDennis_9
    Dim MtDennis_10
    Dim MtDennis_11
    Dim MtDennis_12
    Dim MtDennis_13

    Dim MtDennis1_stat
    Dim MtDennis2_stat
    Dim MtDennis3_stat
    Dim MtDennis4_stat
    Dim MtDennis5_stat
    Dim MtDennis6_stat
    Dim MtDennis7_stat
    Dim MtDennis8_stat
    Dim MtDennis9_stat
    Dim MtDennis10_stat
    Dim MtDennis11_stat
    Dim MtDennis12_stat
    Dim MtDennis13_stat

    'NEW FLYER
    'new_flyer_soc
    Dim NF_3700_soc As String
    Dim NF_3701_soc As String
    Dim NF_3702_soc As String
    Dim NF_3703_soc As String
    Dim NF_3704_soc As String
    Dim NF_3705_soc As String
    Dim NF_3706_soc As String
    Dim NF_3707_soc As String
    Dim NF_3708_soc As String
    Dim NF_3709_soc As String
    Dim NF_3710_soc As String

    'new_flyer_stat     
    Dim NF_3700_stat As String
    Dim NF_3701_stat As String
    Dim NF_3702_stat As String
    Dim NF_3703_stat As String
    Dim NF_3704_stat As String
    Dim NF_3705_stat As String
    Dim NF_3706_stat As String
    Dim NF_3707_stat As String
    Dim NF_3708_stat As String
    Dim NF_3709_stat As String
    Dim NF_3710_stat As String

    'new_flyer_range
    Dim NF_3700_range As String
    Dim NF_3701_range As String
    Dim NF_3702_range As String
    Dim NF_3703_range As String
    Dim NF_3704_range As String
    Dim NF_3705_range As String
    Dim NF_3706_range As String
    Dim NF_3707_range As String
    Dim NF_3708_range As String
    Dim NF_3709_range As String
    Dim NF_3710_range As String

    'new_flyer_time_remaining
    Dim NF_3700_time As String
    Dim NF_3701_time As String
    Dim NF_3702_time As String
    Dim NF_3703_time As String
    Dim NF_3704_time As String
    Dim NF_3705_time As String
    Dim NF_3706_time As String
    Dim NF_3707_time As String
    Dim NF_3708_time As String
    Dim NF_3709_time As String
    Dim NF_3710_time As String

    'new_flyer_power
    Dim NF_3700_power As String
    Dim NF_3701_power As String
    Dim NF_3702_power As String
    Dim NF_3703_power As String
    Dim NF_3704_power As String
    Dim NF_3705_power As String
    Dim NF_3706_power As String
    Dim NF_3707_power As String
    Dim NF_3708_power As String
    Dim NF_3709_power As String
    Dim NF_3710_power As String

    'new_flyer_VI
    Dim NF_3700_V As String
    Dim NF_3700_I As String
    Dim NF_3701_V As String
    Dim NF_3701_I As String
    Dim NF_3702_V As String
    Dim NF_3702_I As String
    Dim NF_3703_V As String
    Dim NF_3703_I As String
    Dim NF_3704_V As String
    Dim NF_3704_I As String
    Dim NF_3705_V As String
    Dim NF_3705_I As String
    Dim NF_3706_V As String
    Dim NF_3706_I As String
    Dim NF_3707_V As String
    Dim NF_3707_I As String
    Dim NF_3708_V As String
    Dim NF_3708_I As String
    Dim NF_3709_V As String
    Dim NF_3709_I As String
    Dim NF_3710_V As String
    Dim NF_3710_I As String

    'PROTERRA
    'proterra_soc
    Dim P_3725_soc As String
    Dim P_3726_soc As String
    Dim P_3727_soc As String
    Dim P_3728_soc As String
    Dim P_3729_soc As String
    Dim P_3730_soc As String
    Dim P_3731_soc As String
    Dim P_3732_soc As String
    Dim P_3733_soc As String
    Dim P_3734_soc As String

    'proterra_stat
    Dim P_3725_stat As String
    Dim P_3726_stat As String
    Dim P_3727_stat As String
    Dim P_3728_stat As String
    Dim P_3729_stat As String
    Dim P_3730_stat As String
    Dim P_3731_stat As String
    Dim P_3732_stat As String
    Dim P_3733_stat As String
    Dim P_3734_stat As String

    'proterra_range
    Dim P_3725_range As String
    Dim P_3726_range As String
    Dim P_3727_range As String
    Dim P_3728_range As String
    Dim P_3729_range As String
    Dim P_3730_range As String
    Dim P_3731_range As String
    Dim P_3732_range As String
    Dim P_3733_range As String
    Dim P_3734_range As String

    'proterra_time_remaining
    Dim P_3725_time As String
    Dim P_3726_time As String
    Dim P_3727_time As String
    Dim P_3728_time As String
    Dim P_3729_time As String
    Dim P_3730_time As String
    Dim P_3731_time As String
    Dim P_3732_time As String
    Dim P_3733_time As String
    Dim P_3734_time As String

    'proterra_power
    Dim P_3725_power As String
    Dim P_3726_power As String
    Dim P_3727_power As String
    Dim P_3728_power As String
    Dim P_3729_power As String
    Dim P_3730_power As String
    Dim P_3731_power As String
    Dim P_3732_power As String
    Dim P_3733_power As String
    Dim P_3734_power As String

    'proterra_VI
    Dim P_3725_V As String
    Dim P_3725_I As String
    Dim P_3726_V As String
    Dim P_3726_I As String
    Dim P_3727_V As String
    Dim P_3727_I As String
    Dim P_3728_V As String
    Dim P_3728_I As String
    Dim P_3729_V As String
    Dim P_3729_I As String
    Dim P_3730_V As String
    Dim P_3730_I As String
    Dim P_3731_V As String
    Dim P_3731_I As String
    Dim P_3732_V As String
    Dim P_3732_I As String
    Dim P_3733_V As String
    Dim P_3733_I As String
    Dim P_3734_V As String
    Dim P_3734_I As String

    Private NotFirstShow As Boolean

    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        '* Do not start comms on first show in case it was set to disable in design mode
        If NotFirstShow Then
            Close()
        Else
            NotFirstShow = True
        End If
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim index As Integer
        While index < My.Application.OpenForms.Count
            If My.Application.OpenForms(index) IsNot Me Then
                My.Application.OpenForms(index).Close()
            End If

            index += 1

        End While
    End Sub

    Private Sub BtnExtract_Click(sender As Object, e As EventArgs) Handles BtnExtract.Click
        Label4.ForeColor = Color.Maroon
        Label4.InvokeIfRequired(Sub() Label4.Text = "Logging in, please wait...")

        If BackgroundWorker1.IsBusy = False Then
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub BtnExtract2_Click(sender As Object, e As EventArgs) Handles BtnExtract2.Click
        Label29.ForeColor = Color.Maroon
        Label29.InvokeIfRequired(Sub() Label29.Text = "Logging in, please wait...")

        If BackgroundWorker2.IsBusy = False Then
            BackgroundWorker2.RunWorkerAsync()
        End If
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        Cycle1 = True
        Label4.ForeColor = Color.Maroon
        Label4.InvokeIfRequired(Sub() Label4.Text = "Stopping, please wait...")

        If BackgroundWorker1.IsBusy = True Then
            BackgroundWorker1.CancelAsync()
        End If
    End Sub

    Private Sub BtnStop2_Click(sender As Object, e As EventArgs) Handles BtnStop2.Click
        Cycle2 = True
        Label29.ForeColor = Color.Maroon
        Label29.InvokeIfRequired(Sub() Label29.Text = "Stopping, please wait...")

        If BackgroundWorker2.IsBusy = True Then
            BackgroundWorker2.CancelAsync()
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Dim Options As New ChromeOptions
        Options.AddArgument("--headless")
        Options.AddArgument("--disable-gpu")
        Dim Service As ChromeDriverService = ChromeDriverService.CreateDefaultService
        Service.HideCommandPromptWindow = True

        Using driver1 = New ChromeDriver(Service, Options)

            driver1.Navigate().GoToUrl("https://evci.secure.force.com/")
            Dim userNameField = driver1.FindElementById("loginPage:SiteTemplate:siteLogin:loginComponent:loginForm:username")
            Dim userPasswordField = driver1.FindElementById("loginPage:SiteTemplate:siteLogin:loginComponent:loginForm:password")
            Dim loginButton = driver1.FindElementById("loginPage:SiteTemplate:siteLogin:loginComponent:loginForm:loginButton")

            userNameField.SendKeys("xxx")
            userPasswordField.SendKeys("xxx")
            loginButton.Click()

            Label4.ForeColor = Color.Maroon
            Label4.InvokeIfRequired(Sub() Label4.Text = "Extracting...")

            While (Cycle1 = False)
                driver1.Manage.Timeouts.ImplicitWait = TimeSpan.FromSeconds(30)

                Label4.ForeColor = Color.Maroon
                Label4.InvokeIfRequired(Sub() Label4.Text = "Refreshing...")

                Date_Time.ForeColor = Color.Maroon
                Date_Time.InvokeIfRequired(Sub() Date_Time.Text = (DateTime.Now.DayOfWeek.ToString() & ", " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")))

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000SSHKL") 'arrow_1
                    Arrow_1 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 0 To 10
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 1")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000STJrv") 'arrow_2
                    Arrow_2 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 11 To 20
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 2")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000STJw9") 'arrow_3
                    Arrow_3 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 20 To 30
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 3")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000STL6v") 'arrow_4 
                    Arrow_4 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 30 To 40
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 4")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000Tlh4U") 'arrow_5
                    Arrow_5 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 40 To 50
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 5")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000STLC0") 'arrow_6
                    Arrow_6 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 50 To 60
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 6")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000Tlknq")  'arrow_7
                    Arrow_7 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 60 To 70
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 7")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000Tlbo1") 'arrow_8
                    Arrow_8 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 70 To 80
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 8")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000Tlrcy") 'arrow_9
                    Arrow_9 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 80 To 90
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 9")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000TlmhI") 'arrow_10
                    Arrow_10 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 90 To 100
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 10")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000TlscI") 'arrow_11
                    Arrow_11 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 100 To 110
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 11")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000TluIn") 'arrow_12
                    Arrow_12 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 110 To 120
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 12")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000TlrV7") 'arrow_13
                    Arrow_13 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 120 To 130
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 13")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000Tlrni") 'MtDennis_1
                    MtDennis_1 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 130 To 140
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 14")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000Tlrtr") 'MtDennis_2
                    MtDennis_2 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 140 To 150
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 15")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000Tlrr7") 'MtDennis_3
                    MtDennis_3 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 150 To 160
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 16")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000Tlrwl") 'MtDennis_4
                    MtDennis_4 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 160 To 170
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 17")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000Tlrkt") 'MtDennis_5
                    MtDennis_5 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 170 To 180
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 18")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000Tlg9p") 'MtDennis_6
                    MtDennis_6 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 180 To 190
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 19")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000TlgAT") 'MtDennis_7
                    MtDennis_7 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 190 To 200
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 20")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000Tltb7") 'MtDennis_8
                    MtDennis_8 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 200 To 210
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 21")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000Tltp1") 'MtDennis_9
                    MtDennis_9 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 210 To 220
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 22")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000Tlt4T") 'MtDennis_10
                    MtDennis_10 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 220 To 230
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 23")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000Tls9P") 'MtDennis_11
                    MtDennis_11 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 230 To 240
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 24")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000TlsNf") 'MtDennis_12
                    MtDennis_12 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 240 To 250
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 25")
                    End Using
                End Try

                Try
                    driver1.Navigate().GoToUrl("https://evci.secure.force.com/a0M2p00000TlruL") 'MtDennis_13
                    MtDennis_13 = driver1.FindElementByXPath("//*[@id='ep_j_id0_j_id30']/div[2]/div[3]/table/tbody/tr[3]/td[4]").Text

                    For i = 250 To ProgressBar2.Maximum
                        BackgroundWorker1.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 26")
                    End Using
                End Try

                AR1.InvokeIfRequired(Sub() AR1.Text = Arrow_1)
                Charger = AR1
                Call Sub() CheckColor()
                AR2.InvokeIfRequired(Sub() AR2.Text = Arrow_2)
                Charger = AR2
                Call Sub() CheckColor()
                AR3.InvokeIfRequired(Sub() AR3.Text = Arrow_3)
                Charger = AR3
                Call Sub() CheckColor()
                AR4.InvokeIfRequired(Sub() AR4.Text = Arrow_4)
                Charger = AR4
                Call Sub() CheckColor()
                AR5.InvokeIfRequired(Sub() AR5.Text = Arrow_5)
                Charger = AR5
                Call Sub() CheckColor()
                AR6.InvokeIfRequired(Sub() AR6.Text = Arrow_6)
                Charger = AR6
                Call Sub() CheckColor()
                AR7.InvokeIfRequired(Sub() AR7.Text = Arrow_7)
                Charger = AR7
                Call Sub() CheckColor()
                AR8.InvokeIfRequired(Sub() AR8.Text = Arrow_8)
                Charger = AR8
                Call Sub() CheckColor()
                AR9.InvokeIfRequired(Sub() AR9.Text = Arrow_9)
                Charger = AR9
                Call Sub() CheckColor()
                AR10.InvokeIfRequired(Sub() AR10.Text = Arrow_10)
                Charger = AR10
                Call Sub() CheckColor()
                AR11.InvokeIfRequired(Sub() AR11.Text = Arrow_11)
                Charger = AR11
                Call Sub() CheckColor()
                AR12.InvokeIfRequired(Sub() AR12.Text = Arrow_12)
                Charger = AR12
                Call Sub() CheckColor()
                AR13.InvokeIfRequired(Sub() AR13.Text = Arrow_13)
                Charger = AR13
                Call Sub() CheckColor()

                MD1.InvokeIfRequired(Sub() MD1.Text = MtDennis_1)
                Charger = MD1
                Call Sub() CheckColor()
                MD2.InvokeIfRequired(Sub() MD2.Text = MtDennis_2)
                Charger = MD2
                Call Sub() CheckColor()
                MD3.InvokeIfRequired(Sub() MD3.Text = MtDennis_3)
                Charger = MD3
                Call Sub() CheckColor()
                MD4.InvokeIfRequired(Sub() MD4.Text = MtDennis_4)
                Charger = MD4
                Call Sub() CheckColor()
                MD5.InvokeIfRequired(Sub() MD5.Text = MtDennis_5)
                Charger = MD5
                Call Sub() CheckColor()
                MD6.InvokeIfRequired(Sub() MD6.Text = MtDennis_6)
                Charger = MD6
                Call Sub() CheckColor()
                MD7.InvokeIfRequired(Sub() MD7.Text = MtDennis_7)
                Charger = MD7
                Call Sub() CheckColor()
                MD8.InvokeIfRequired(Sub() MD8.Text = MtDennis_8)
                Charger = MD8
                Call Sub() CheckColor()
                MD9.InvokeIfRequired(Sub() MD9.Text = MtDennis_9)
                Charger = MD9
                Call Sub() CheckColor()
                MD10.InvokeIfRequired(Sub() MD10.Text = MtDennis_10)
                Charger = MD10
                Call Sub() CheckColor()
                MD11.InvokeIfRequired(Sub() MD11.Text = MtDennis_11)
                Charger = MD11
                Call Sub() CheckColor()
                MD12.InvokeIfRequired(Sub() MD12.Text = MtDennis_12)
                Charger = MD12
                Call Sub() CheckColor()
                MD13.InvokeIfRequired(Sub() MD13.Text = MtDennis_13)
                Charger = MD13
                Call Sub() CheckColor()

                'Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\AR_Chargerlog.txt", False)
                Using writer As New StreamWriter("AR_Chargerlog.txt", False)
                    writer.WriteLine(Arrow_1 + Environment.NewLine + Arrow_2 + Environment.NewLine + Arrow_3 + Environment.NewLine + Arrow_4 + Environment.NewLine + Arrow_5 + Environment.NewLine + Arrow_6 + Environment.NewLine + Arrow_7 + Environment.NewLine + Arrow_8 + Environment.NewLine + Arrow_9 + Environment.NewLine + Arrow_10 + Environment.NewLine + Arrow_11 + Environment.NewLine + Arrow_12 + Environment.NewLine + Arrow_13)
                End Using
                'Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\MD_Chargerlog.txt", False)
                Using writer As New StreamWriter("MD_Chargerlog.txt", False)
                    writer.WriteLine(MtDennis_1 + Environment.NewLine + MtDennis_2 + Environment.NewLine + MtDennis_3 + Environment.NewLine + MtDennis_4 + Environment.NewLine + MtDennis_5 + Environment.NewLine + MtDennis_6 + Environment.NewLine + MtDennis_7 + Environment.NewLine + MtDennis_8 + Environment.NewLine + MtDennis_9 + Environment.NewLine + MtDennis_10 + Environment.NewLine + MtDennis_11 + Environment.NewLine + MtDennis_12 + Environment.NewLine + MtDennis_13)
                End Using
            End While

            'Threading.Thread.Sleep(1000)
            driver1.Close()
            driver1.Quit()
            Cycle1 = False

            Label4.ForeColor = Color.Maroon
            Label4.InvokeIfRequired(Sub() Label4.Text = "Stopped, removing drivers...")

        End Using
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Cancelled = True Then
            MsgBox("Cancelled")
        ElseIf e.Error IsNot Nothing Then
            MsgBox("Error")
        Else
            Label4.ForeColor = Color.Maroon
            Label4.InvokeIfRequired(Sub() Label4.Text = "Drivers removed!")
        End If
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork

        Dim Options As New ChromeOptions
        Options.AddArgument("--headless")
        Options.AddArgument("--disable-gpu")
        Dim Service As ChromeDriverService = ChromeDriverService.CreateDefaultService
        Service.HideCommandPromptWindow = True

        Using driver2 = New ChromeDriver(Service, Options)

            driver2.Manage.Timeouts.ImplicitWait = TimeSpan.FromSeconds(50)

            driver2.Navigate().GoToUrl("https://accounts.viriciti.com/login?referer=https://login.viriciti.com/")
            Dim userNameField = driver2.FindElementByXPath("//*[@id='login']/form/fieldset[1]/label[1]/input")
            Dim userPasswordField = driver2.FindElementByXPath("//*[@id='login']/form/fieldset[1]/label[2]/input")
            Dim loginButton = driver2.FindElementByXPath("//*[@id='login']/form/button")

            userNameField.SendKeys("xxx")
            userPasswordField.SendKeys("xxx")
            loginButton.Click()

            Label29.ForeColor = Color.Maroon
            Label29.InvokeIfRequired(Sub() Label29.Text = "Extracting...")

            While (Cycle2 = False)
                Label29.ForeColor = Color.Maroon
                Label29.InvokeIfRequired(Sub() Label29.Text = "Refreshing...")

                Date_Time2.ForeColor = Color.Maroon
                Date_Time2.InvokeIfRequired(Sub() Date_Time2.Text = (DateTime.Now.DayOfWeek.ToString() & ", " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")))

                Try
                    driver2.Navigate().GoToUrl("https://login.viriciti.com/#vio/newflyer_008/dashboard") '3700
                    NF_3700_stat = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[2]/ul/li[1]/div/div/h6").Text
                    NF_3700_soc = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[1]/div/div/span[2]").Text
                    NF_3700_range = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[2]/div/div/span[2]").Text
                    NF_3700_time = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[3]/div/div/span[2]").Text
                    NF_3700_V = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[2]/span/div").Text
                    NF_3700_I = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[3]/span/div").Text

                    If (NF_3700_V = "n/a") Or (NF_3700_I = "n/a") Then
                        NF_3700_power = "n/a"
                    Else
                        NF_3700_power = Math.Round(((NF_3700_V * NF_3700_I) / 1000), 1)
                    End If

                    For i = 0 To 10
                        BackgroundWorker2.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 27")
                    End Using
                End Try

                Try
                    driver2.Navigate().GoToUrl("https://login.viriciti.com/#vio/newflyer_009/dashboard") '3701
                    NF_3701_stat = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[2]/ul/li[1]/div/div/h6").Text
                    NF_3701_soc = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[1]/div/div/span[2]").Text
                    NF_3701_range = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[2]/div/div/span[2]").Text
                    NF_3701_time = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[3]/div/div/span[2]").Text
                    NF_3701_V = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[2]/span/div").Text
                    NF_3701_I = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[3]/span/div").Text

                    If (NF_3701_V = "n/a") Or (NF_3701_I = "n/a") Then
                        NF_3701_power = "n/a"
                    Else
                        NF_3701_power = Math.Round(((NF_3701_V * NF_3701_I) / 1000), 1)
                    End If

                    For i = 10 To 20
                        BackgroundWorker2.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 28")
                    End Using
                End Try

                Try
                    driver2.Navigate().GoToUrl("https://login.viriciti.com/#vio/newflyer_010/dashboard") '3702
                    NF_3702_stat = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[2]/ul/li[1]/div/div/h6").Text
                    NF_3702_soc = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[1]/div/div/span[2]").Text
                    NF_3702_range = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[2]/div/div/span[2]").Text
                    NF_3702_time = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[3]/div/div/span[2]").Text
                    NF_3702_V = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[2]/span/div").Text
                    NF_3702_I = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[3]/span/div").Text

                    If (NF_3702_V = "n/a") Or (NF_3702_I = "n/a") Then
                        NF_3702_power = "n/a"
                    Else
                        NF_3702_power = Math.Round(((NF_3702_V * NF_3702_I) / 1000), 1)
                    End If

                    For i = 20 To 30
                        BackgroundWorker2.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 29")
                    End Using
                End Try

                Try
                    driver2.Navigate().GoToUrl("https://login.viriciti.com/#vio/newflyer_014/dashboard") '3703 
                    NF_3703_stat = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[2]/ul/li[1]/div/div/h6").Text
                    NF_3703_soc = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[1]/div/div/span[2]").Text
                    NF_3703_range = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[2]/div/div/span[2]").Text
                    NF_3703_time = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[3]/div/div/span[2]").Text
                    NF_3703_V = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[2]/span/div").Text
                    NF_3703_I = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[3]/span/div").Text

                    If (NF_3703_V = "n/a") Or (NF_3703_I = "n/a") Then
                        NF_3703_power = "n/a"
                    Else
                        NF_3703_power = Math.Round(((NF_3703_V * NF_3703_I) / 1000), 1)
                    End If

                    For i = 30 To 40
                        BackgroundWorker2.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 30")
                    End Using
                End Try

                Try
                    driver2.Navigate().GoToUrl("https://login.viriciti.com/#vio/newflyer_011/dashboard") '3704
                    NF_3704_stat = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[2]/ul/li[1]/div/div/h6").Text
                    NF_3704_soc = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[1]/div/div/span[2]").Text
                    NF_3704_range = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[2]/div/div/span[2]").Text
                    NF_3704_time = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[3]/div/div/span[2]").Text
                    NF_3704_V = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[2]/span/div").Text
                    NF_3704_I = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[3]/span/div").Text

                    If (NF_3704_V = "n/a") Or (NF_3704_I = "n/a") Then
                        NF_3704_power = "n/a"
                    Else
                        NF_3704_power = Math.Round(((NF_3704_V * NF_3704_I) / 1000), 1)
                    End If

                    For i = 40 To 50
                        BackgroundWorker2.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 31")
                    End Using
                End Try

                Try
                    driver2.Navigate().GoToUrl("https://login.viriciti.com/#vio/newflyer_012/dashboard") '3705
                    NF_3705_stat = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[2]/ul/li[1]/div/div/h6").Text
                    NF_3705_soc = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[1]/div/div/span[2]").Text
                    NF_3705_range = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[2]/div/div/span[2]").Text
                    NF_3705_time = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[3]/div/div/span[2]").Text
                    NF_3705_V = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[2]/span/div").Text
                    NF_3705_I = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[3]/span/div").Text

                    If (NF_3705_V = "n/a") Or (NF_3705_I = "n/a") Then
                        NF_3705_power = "n/a"
                    Else
                        NF_3705_power = Math.Round(((NF_3705_V * NF_3705_I) / 1000), 1)
                    End If

                    For i = 50 To 60
                        BackgroundWorker2.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 32")
                    End Using
                End Try

                Try
                    driver2.Navigate().GoToUrl("https://login.viriciti.com/#vio/newflyer_013/dashboard")  '3706
                    NF_3706_stat = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[2]/ul/li[1]/div/div/h6").Text
                    NF_3706_soc = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[1]/div/div/span[2]").Text
                    NF_3706_range = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[2]/div/div/span[2]").Text
                    NF_3706_time = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[3]/div/div/span[2]").Text
                    NF_3706_V = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[2]/span/div").Text
                    NF_3706_I = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[3]/span/div").Text

                    If (NF_3706_V = "n/a") Or (NF_3706_I = "n/a") Then
                        NF_3706_power = "n/a"
                    Else
                        NF_3706_power = Math.Round(((NF_3706_V * NF_3706_I) / 1000), 1)
                    End If

                    For i = 60 To 70
                        BackgroundWorker2.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 33")
                    End Using
                End Try

                Try
                    driver2.Navigate().GoToUrl("https://login.viriciti.com/#vio/newflyer_015/dashboard") '3707
                    NF_3707_stat = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[2]/ul/li[1]/div/div/h6").Text
                    NF_3707_soc = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[1]/div/div/span[2]").Text
                    NF_3707_range = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[2]/div/div/span[2]").Text
                    NF_3707_time = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[3]/div/div/span[2]").Text
                    NF_3707_V = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[2]/span/div").Text
                    NF_3707_I = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[3]/span/div").Text

                    If (NF_3707_V = "n/a") Or (NF_3707_I = "n/a") Then
                        NF_3707_power = "n/a"
                    Else
                        NF_3707_power = Math.Round(((NF_3707_V * NF_3707_I) / 1000), 1)
                    End If

                    For i = 70 To 80
                        BackgroundWorker2.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 34")
                    End Using
                End Try

                Try
                    driver2.Navigate().GoToUrl("https://login.viriciti.com/#vio/newflyer_016/dashboard") '3708
                    NF_3708_stat = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[2]/ul/li[1]/div/div/h6").Text
                    NF_3708_soc = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[1]/div/div/span[2]").Text
                    NF_3708_range = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[2]/div/div/span[2]").Text
                    NF_3708_time = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[3]/div/div/span[2]").Text
                    NF_3708_V = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[2]/span/div").Text
                    NF_3708_I = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[3]/span/div").Text
                    If (NF_3708_V = "n/a") Or (NF_3708_I = "n/a") Then
                        NF_3708_power = "n/a"
                    Else
                        NF_3708_power = Math.Round(((NF_3708_V * NF_3708_I) / 1000), 1)
                    End If

                    For i = 80 To 90
                        BackgroundWorker2.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 35")
                    End Using
                End Try

                Try
                    driver2.Navigate().GoToUrl("https://login.viriciti.com/#vio/newflyer_028/dashboard") '3709
                    NF_3709_stat = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[2]/ul/li[1]/div/div/h6").Text
                    NF_3709_soc = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[1]/div/div/span[2]").Text
                    NF_3709_range = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[2]/div/div/span[2]").Text
                    NF_3709_time = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[3]/div/div/span[2]").Text
                    NF_3709_V = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[2]/span/div").Text
                    NF_3709_I = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[3]/span/div").Text

                    If (NF_3709_V = "n/a") Or (NF_3709_I = "n/a") Then
                        NF_3709_power = "n/a"
                    Else
                        NF_3709_power = Math.Round(((NF_3709_V * NF_3709_I) / 1000), 1)
                    End If

                    For i = 90 To 100
                        BackgroundWorker2.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 36")
                    End Using
                End Try

                Try
                    driver2.Navigate().GoToUrl("https://login.viriciti.com/#vio/newflyer_020/dashboard") '3710
                    NF_3710_stat = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[2]/ul/li[1]/div/div/h6").Text
                    NF_3710_soc = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[1]/div/div/span[2]").Text
                    NF_3710_range = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[2]/div/div/span[2]").Text
                    NF_3710_time = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[3]/div/div/span[2]").Text
                    NF_3710_V = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[2]/span/div").Text
                    NF_3710_I = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[3]/span/div").Text

                    If (NF_3710_V = "n/a") Or (NF_3710_I = "n/a") Then
                        NF_3710_power = "n/a"
                    Else
                        NF_3710_power = Math.Round(((NF_3710_V * NF_3710_I) / 1000), 1)
                    End If

                    For i = 100 To 110
                        BackgroundWorker2.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 37")
                    End Using
                End Try

                Try
                    driver2.Navigate().GoToUrl("https://login.viriciti.com/#vio/proterra_071/dashboard") '3725
                    P_3725_stat = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[2]/ul/li[1]/div/div/h6").Text
                    P_3725_soc = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[1]/div/div/span[2]").Text
                    P_3725_range = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[2]/div/div/span[2]").Text
                    P_3725_time = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[3]/div/div/span[2]").Text
                    P_3725_V = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[2]/span/div").Text
                    P_3725_I = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[3]/span/div").Text

                    If (P_3725_V = "n/a") Or (P_3725_I = "n/a") Then
                        P_3725_power = "n/a"
                    Else
                        P_3725_V = P_3725_V.Substring(0, P_3725_V.IndexOf(" "))
                        P_3725_I = P_3725_I.Substring(0, P_3725_I.IndexOf(" "))
                        P_3725_power = Math.Round(((P_3725_V * P_3725_I) / 1000), 1)
                    End If

                    For i = 110 To 120
                        BackgroundWorker2.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 38")
                    End Using
                End Try

                Try
                    driver2.Navigate().GoToUrl("https://login.viriciti.com/#vio/proterra_078/dashboard") '3726
                    P_3726_stat = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[2]/ul/li[1]/div/div/h6").Text
                    P_3726_soc = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[1]/div/div/span[2]").Text
                    P_3726_range = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[2]/div/div/span[2]").Text
                    P_3726_time = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[3]/div/div/span[2]").Text
                    P_3726_V = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[2]/span/div").Text
                    P_3726_I = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[3]/span/div").Text

                    If (P_3726_V = "n/a") Or (P_3726_I = "n/a") Then
                        P_3726_power = "n/a"
                    Else
                        P_3726_V = P_3726_V.Substring(0, P_3726_V.IndexOf(" "))
                        P_3726_I = P_3726_I.Substring(0, P_3726_I.IndexOf(" "))
                        P_3726_power = Math.Round(((P_3726_V * P_3726_I) / 1000), 1)
                    End If

                    For i = 120 To 130
                        BackgroundWorker2.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 39")
                    End Using
                End Try

                Try
                    driver2.Navigate().GoToUrl("https://login.viriciti.com/#vio/proterra_079/dashboard") '3727
                    P_3727_stat = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[2]/ul/li[1]/div/div/h6").Text
                    P_3727_soc = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[1]/div/div/span[2]").Text
                    P_3727_range = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[2]/div/div/span[2]").Text
                    P_3727_time = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[3]/div/div/span[2]").Text
                    P_3727_V = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[2]/span/div").Text
                    P_3727_I = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[3]/span/div").Text

                    If (P_3727_V = "n/a") Or (P_3727_I = "n/a") Then
                        P_3727_power = "n/a"
                    Else
                        P_3727_V = P_3727_V.Substring(0, P_3727_V.IndexOf(" "))
                        P_3727_I = P_3727_I.Substring(0, P_3727_I.IndexOf(" "))
                        P_3727_power = Math.Round(((P_3727_V * P_3727_I) / 1000), 1)
                    End If

                    For i = 130 To 140
                        BackgroundWorker2.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 40")
                    End Using
                End Try

                Try
                    driver2.Navigate().GoToUrl("https://dashboard.viriciti.com/#vio/proterra_080/dashboard") '3728
                    P_3728_stat = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[2]/ul/li[1]/div/div/h6").Text
                    P_3728_soc = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[1]/div/div/span[2]").Text
                    P_3728_range = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[2]/div/div/span[2]").Text
                    P_3728_time = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[3]/div/div/span[2]").Text
                    P_3728_V = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[2]/span/div").Text
                    P_3728_I = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[3]/span/div").Text

                    If (P_3728_V = "n/a") Or (P_3728_I = "n/a") Then
                        P_3728_power = "n/a"
                    Else
                        P_3728_V = P_3728_V.Substring(0, P_3728_V.IndexOf(" "))
                        P_3728_I = P_3728_I.Substring(0, P_3728_I.IndexOf(" "))
                        P_3728_power = Math.Round(((P_3728_V * P_3728_I) / 1000), 1)
                    End If

                    For i = 140 To 150
                        BackgroundWorker2.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 41")
                    End Using
                End Try

                Try
                    driver2.Navigate().GoToUrl("https://dashboard.viriciti.com/#vio/proterra_081/dashboard") '3729
                    P_3729_stat = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[2]/ul/li[1]/div/div/h6").Text
                    P_3729_soc = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[1]/div/div/span[2]").Text
                    P_3729_range = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[2]/div/div/span[2]").Text
                    P_3729_time = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[3]/div/div/span[2]").Text
                    P_3729_V = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[2]/span/div").Text
                    P_3729_I = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[3]/span/div").Text

                    If (P_3729_V = "n/a") Or (P_3729_I = "n/a") Then
                        P_3729_power = "n/a"
                    Else
                        P_3729_V = P_3729_V.Substring(0, P_3729_V.IndexOf(" "))
                        P_3729_I = P_3729_I.Substring(0, P_3729_I.IndexOf(" "))
                        P_3729_power = Math.Round(((P_3729_V * P_3729_I) / 1000), 1)
                    End If

                    For i = 150 To 160
                        BackgroundWorker2.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 42")
                    End Using
                End Try

                Try
                    driver2.Navigate().GoToUrl("https://dashboard.viriciti.com/#vio/proterra_082/dashboard") '3730
                    P_3730_stat = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[2]/ul/li[1]/div/div/h6").Text
                    P_3730_soc = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[1]/div/div/span[2]").Text
                    P_3730_range = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[2]/div/div/span[2]").Text
                    P_3730_time = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[3]/div/div/span[2]").Text
                    P_3730_V = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[2]/span/div").Text
                    P_3730_I = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[3]/span/div").Text

                    If (P_3730_V = "n/a") Or (P_3730_I = "n/a") Then
                        P_3730_power = "n/a"
                    Else
                        P_3730_V = P_3730_V.Substring(0, P_3730_V.IndexOf(" "))
                        P_3730_I = P_3730_I.Substring(0, P_3730_I.IndexOf(" "))
                        P_3730_power = Math.Round(((P_3730_V * P_3730_I) / 1000), 1)
                    End If

                    For i = 160 To 170
                        BackgroundWorker2.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 43")
                    End Using
                End Try

                Try
                    driver2.Navigate().GoToUrl("https://dashboard.viriciti.com/#vio/proterra_083/dashboard") '3731
                    P_3731_stat = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[2]/ul/li[1]/div/div/h6").Text
                    P_3731_soc = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[1]/div/div/span[2]").Text
                    P_3731_range = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[2]/div/div/span[2]").Text
                    P_3731_time = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[3]/div/div/span[2]").Text
                    P_3731_V = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[2]/span/div").Text
                    P_3731_I = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[3]/span/div").Text

                    If (P_3731_V = "n/a") Or (P_3731_I = "n/a") Then
                        P_3731_power = "n/a"
                    Else
                        P_3731_V = P_3731_V.Substring(0, P_3731_V.IndexOf(" "))
                        P_3731_I = P_3731_I.Substring(0, P_3731_I.IndexOf(" "))
                        P_3731_power = Math.Round(((P_3731_V * P_3731_I) / 1000), 1)
                    End If

                    For i = 170 To 180
                        BackgroundWorker2.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 44")
                    End Using
                End Try

                Try
                    driver2.Navigate().GoToUrl("https://dashboard.viriciti.com/#vio/proterra_084/dashboard") '3732
                    P_3732_stat = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[2]/ul/li[1]/div/div/h6").Text
                    P_3732_soc = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[1]/div/div/span[2]").Text
                    P_3732_range = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[2]/div/div/span[2]").Text
                    P_3732_time = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[3]/div/div/span[2]").Text
                    P_3732_V = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[2]/span/div").Text
                    P_3732_I = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[3]/span/div").Text

                    If (P_3732_V = "n/a") Or (P_3732_I = "n/a") Then
                        P_3732_power = "n/a"
                    Else
                        P_3732_V = P_3732_V.Substring(0, P_3732_V.IndexOf(" "))
                        P_3732_I = P_3732_I.Substring(0, P_3732_I.IndexOf(" "))
                        P_3732_power = Math.Round(((P_3732_V * P_3732_I) / 1000), 1)
                    End If

                    For i = 180 To 190
                        BackgroundWorker2.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 45")
                    End Using
                End Try

                Try
                    driver2.Navigate().GoToUrl("https://dashboard.viriciti.com/#vio/proterra_085/dashboard") '3733
                    P_3733_stat = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[2]/ul/li[1]/div/div/h6").Text
                    P_3733_soc = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[1]/div/div/span[2]").Text
                    P_3733_range = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[2]/div/div/span[2]").Text
                    P_3733_time = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[3]/div/div/span[2]").Text
                    P_3733_V = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[2]/span/div").Text
                    P_3733_I = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[3]/span/div").Text

                    If (P_3733_V = "n/a") Or (P_3733_I = "n/a") Then
                        P_3733_power = "n/a"
                    Else
                        P_3733_V = P_3733_V.Substring(0, P_3733_V.IndexOf(" "))
                        P_3733_I = P_3733_I.Substring(0, P_3733_I.IndexOf(" "))
                        P_3733_power = Math.Round(((P_3733_V * P_3733_I) / 1000), 1)
                    End If

                    For i = 190 To 200
                        BackgroundWorker2.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 46")
                    End Using
                End Try

                Try
                    driver2.Navigate().GoToUrl("https://dashboard.viriciti.com/#vio/proterra_086/dashboard") '3734
                    P_3734_stat = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[2]/ul/li[1]/div/div/h6").Text
                    P_3734_soc = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[1]/div/div/span[2]").Text
                    P_3734_range = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[2]/div/div/span[2]").Text
                    P_3734_time = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[1]/div[1]/section/div[2]/div[3]/div/div[1]/div/div/ul/li[3]/div/div/span[2]").Text
                    P_3734_V = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[2]/span/div").Text
                    P_3734_I = driver2.FindElementByXPath("//*[@id='all-types-dashboard']/div[2]/div/section/div[2]/div/div[2]/div[3]/span/div").Text

                    If (P_3734_V = "n/a") Or (P_3734_I = "n/a") Then
                        P_3734_power = "n/a"
                    Else
                        P_3734_V = P_3734_V.Substring(0, P_3734_V.IndexOf(" "))
                        P_3734_I = P_3734_I.Substring(0, P_3734_I.IndexOf(" "))
                        P_3734_power = Math.Round(((P_3734_V * P_3734_I) / 1000), 1)
                    End If

                    For i = 210 To 220
                        BackgroundWorker2.ReportProgress(i)
                    Next

                Catch StaleElementReferenceException As Exception
                    Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\Errorlog.txt", False)
                        writer.WriteLine("number 47")
                    End Using
                End Try

                NF3700_soc.InvokeIfRequired(Sub() NF3700_soc.Text = NF_3700_soc)
                If NF_3700_soc = "nothing" Then NF3700_soc.ForeColor = Color.Black Else NF3700_soc.ForeColor = Color.Maroon
                NF3700_stat.InvokeIfRequired(Sub() NF3700_stat.Text = NF_3700_stat)
                If NF_3700_stat = "Idling" Then NF3700_stat.ForeColor = Color.Green Else If NF_3700_stat = "Charging" Then NF3700_stat.ForeColor = Color.Blue Else If NF_3700_stat = "Slow charging" Then NF3700_stat.ForeColor = Color.Blue Else If NF_3700_stat = "Driving" Then NF3700_stat.ForeColor = Color.Purple Else If NF_3700_stat = "Recovering" Then NF3700_stat.ForeColor = Color.Maroon
                NF3700_range.InvokeIfRequired(Sub() NF3700_range.Text = NF_3700_range)
                If NF_3700_range = "nothing" Then NF3700_time.ForeColor = Color.Black Else NF3700_range.ForeColor = Color.Maroon
                NF3700_time.InvokeIfRequired(Sub() NF3700_time.Text = NF_3700_time)
                If NF_3700_time = "nothing" Then NF3700_time.ForeColor = Color.Black Else NF3700_time.ForeColor = Color.Maroon
                NF3700_power.InvokeIfRequired(Sub() NF3700_power.Text = NF_3700_power)
                If NF_3700_power = "nothing" Then NF3700_power.ForeColor = Color.Black Else NF3700_power.ForeColor = Color.Maroon

                NF3701_soc.InvokeIfRequired(Sub() NF3701_soc.Text = NF_3701_soc)
                If NF_3701_soc = "nothing" Then NF3701_soc.ForeColor = Color.Black Else NF3701_soc.ForeColor = Color.Maroon
                NF3701_stat.InvokeIfRequired(Sub() NF3701_stat.Text = NF_3701_stat)
                If NF_3701_stat = "Idling" Then NF3701_stat.ForeColor = Color.Green Else If NF_3701_stat = "Charging" Then NF3701_stat.ForeColor = Color.Blue Else If NF_3701_stat = "Slow charging" Then NF3701_stat.ForeColor = Color.Blue Else If NF_3701_stat = "Driving" Then NF3701_stat.ForeColor = Color.Purple Else If NF_3701_stat = "Recovering" Then NF3701_stat.ForeColor = Color.Maroon
                NF3701_range.InvokeIfRequired(Sub() NF3701_range.Text = NF_3701_range)
                If NF_3701_range = "nothing" Then NF3701_time.ForeColor = Color.Black Else NF3701_range.ForeColor = Color.Maroon
                NF3701_time.InvokeIfRequired(Sub() NF3701_time.Text = NF_3701_time)
                If NF_3701_time = "nothing" Then NF3701_time.ForeColor = Color.Black Else NF3701_time.ForeColor = Color.Maroon
                NF3701_power.InvokeIfRequired(Sub() NF3701_power.Text = NF_3701_power)
                If NF_3701_power = "nothing" Then NF3701_power.ForeColor = Color.Black Else NF3701_power.ForeColor = Color.Maroon

                NF3702_soc.InvokeIfRequired(Sub() NF3702_soc.Text = NF_3702_soc)
                If NF_3702_soc = "nothing" Then NF3702_soc.ForeColor = Color.Black Else NF3702_soc.ForeColor = Color.Maroon
                NF3702_stat.InvokeIfRequired(Sub() NF3702_stat.Text = NF_3702_stat)
                If NF_3702_stat = "Idling" Then NF3702_stat.ForeColor = Color.Green Else If NF_3702_stat = "Charging" Then NF3702_stat.ForeColor = Color.Blue Else If NF_3702_stat = "Slow charging" Then NF3702_stat.ForeColor = Color.Blue Else If NF_3702_stat = "Driving" Then NF3702_stat.ForeColor = Color.Purple Else If NF_3702_stat = "Recovering" Then NF3702_stat.ForeColor = Color.Maroon
                NF3702_range.InvokeIfRequired(Sub() NF3702_range.Text = NF_3702_range)
                If NF_3702_range = "nothing" Then NF3702_time.ForeColor = Color.Black Else NF3702_range.ForeColor = Color.Maroon
                NF3702_time.InvokeIfRequired(Sub() NF3702_time.Text = NF_3702_time)
                If NF_3702_time = "nothing" Then NF3702_time.ForeColor = Color.Black Else NF3702_time.ForeColor = Color.Maroon
                NF3702_power.InvokeIfRequired(Sub() NF3702_power.Text = NF_3702_power)
                If NF_3702_power = "nothing" Then NF3702_power.ForeColor = Color.Black Else NF3702_power.ForeColor = Color.Maroon

                NF3703_soc.InvokeIfRequired(Sub() NF3703_soc.Text = NF_3703_soc)
                If NF_3703_soc = "nothing" Then NF3703_soc.ForeColor = Color.Black Else NF3703_soc.ForeColor = Color.Maroon
                NF3703_stat.InvokeIfRequired(Sub() NF3703_stat.Text = NF_3703_stat)
                If NF_3703_stat = "Idling" Then NF3703_stat.ForeColor = Color.Green Else If NF_3703_stat = "Charging" Then NF3703_stat.ForeColor = Color.Blue Else If NF_3703_stat = "Slow charging" Then NF3703_stat.ForeColor = Color.Blue Else If NF_3703_stat = "Driving" Then NF3703_stat.ForeColor = Color.Purple Else If NF_3703_stat = "Recovering" Then NF3703_stat.ForeColor = Color.Maroon
                NF3703_range.InvokeIfRequired(Sub() NF3703_range.Text = NF_3703_range)
                If NF_3703_range = "nothing" Then NF3703_time.ForeColor = Color.Black Else NF3703_range.ForeColor = Color.Maroon
                NF3703_time.InvokeIfRequired(Sub() NF3703_time.Text = NF_3703_time)
                If NF_3703_time = "nothing" Then NF3703_time.ForeColor = Color.Black Else NF3703_time.ForeColor = Color.Maroon
                NF3703_power.InvokeIfRequired(Sub() NF3703_power.Text = NF_3703_power)
                If NF_3703_power = "nothing" Then NF3703_power.ForeColor = Color.Black Else NF3703_power.ForeColor = Color.Maroon

                NF3704_soc.InvokeIfRequired(Sub() NF3704_soc.Text = NF_3704_soc)
                If NF_3704_soc = "nothing" Then NF3704_soc.ForeColor = Color.Black Else NF3704_soc.ForeColor = Color.Maroon
                NF3704_stat.InvokeIfRequired(Sub() NF3704_stat.Text = NF_3704_stat)
                If NF_3704_stat = "Idling" Then NF3704_stat.ForeColor = Color.Green Else If NF_3704_stat = "Charging" Then NF3704_stat.ForeColor = Color.Blue Else If NF_3704_stat = "Slow charging" Then NF3704_stat.ForeColor = Color.Blue Else If NF_3704_stat = "Driving" Then NF3704_stat.ForeColor = Color.Purple Else If NF_3704_stat = "Recovering" Then NF3704_stat.ForeColor = Color.Maroon
                NF3704_range.InvokeIfRequired(Sub() NF3704_range.Text = NF_3704_range)
                If NF_3704_range = "nothing" Then NF3704_time.ForeColor = Color.Black Else NF3704_range.ForeColor = Color.Maroon
                NF3704_time.InvokeIfRequired(Sub() NF3704_time.Text = NF_3704_time)
                If NF_3704_time = "nothing" Then NF3704_time.ForeColor = Color.Black Else NF3704_time.ForeColor = Color.Maroon
                NF3704_power.InvokeIfRequired(Sub() NF3704_power.Text = NF_3704_power)
                If NF_3704_power = "nothing" Then NF3704_power.ForeColor = Color.Black Else NF3704_power.ForeColor = Color.Maroon

                NF3705_soc.InvokeIfRequired(Sub() NF3705_soc.Text = NF_3705_soc)
                If NF_3705_soc = "nothing" Then NF3705_soc.ForeColor = Color.Black Else NF3705_soc.ForeColor = Color.Maroon
                NF3705_stat.InvokeIfRequired(Sub() NF3705_stat.Text = NF_3705_stat)
                If NF_3705_stat = "Idling" Then NF3705_stat.ForeColor = Color.Green Else If NF_3705_stat = "Charging" Then NF3705_stat.ForeColor = Color.Blue Else If NF_3705_stat = "Slow charging" Then NF3705_stat.ForeColor = Color.Blue Else If NF_3705_stat = "Driving" Then NF3705_stat.ForeColor = Color.Purple Else If NF_3705_stat = "Recovering" Then NF3705_stat.ForeColor = Color.Maroon
                NF3705_range.InvokeIfRequired(Sub() NF3705_range.Text = NF_3705_range)
                If NF_3705_range = "nothing" Then NF3705_time.ForeColor = Color.Black Else NF3705_range.ForeColor = Color.Maroon
                NF3705_time.InvokeIfRequired(Sub() NF3705_time.Text = NF_3705_time)
                If NF_3705_time = "nothing" Then NF3705_time.ForeColor = Color.Black Else NF3705_time.ForeColor = Color.Maroon
                NF3705_power.InvokeIfRequired(Sub() NF3705_power.Text = NF_3705_power)
                If NF_3705_power = "nothing" Then NF3705_power.ForeColor = Color.Black Else NF3705_power.ForeColor = Color.Maroon

                NF3706_soc.InvokeIfRequired(Sub() NF3706_soc.Text = NF_3706_soc)
                If NF_3706_soc = "nothing" Then NF3706_soc.ForeColor = Color.Black Else NF3706_soc.ForeColor = Color.Maroon
                NF3706_stat.InvokeIfRequired(Sub() NF3706_stat.Text = NF_3706_stat)
                If NF_3706_stat = "Idling" Then NF3706_stat.ForeColor = Color.Green Else If NF_3706_stat = "Charging" Then NF3706_stat.ForeColor = Color.Blue Else If NF_3706_stat = "Slow charging" Then NF3706_stat.ForeColor = Color.Blue Else If NF_3706_stat = "Driving" Then NF3706_stat.ForeColor = Color.Purple Else If NF_3706_stat = "Recovering" Then NF3706_stat.ForeColor = Color.Maroon
                NF3706_range.InvokeIfRequired(Sub() NF3706_range.Text = NF_3706_range)
                If NF_3706_range = "nothing" Then NF3706_time.ForeColor = Color.Black Else NF3706_range.ForeColor = Color.Maroon
                NF3706_time.InvokeIfRequired(Sub() NF3706_time.Text = NF_3706_time)
                If NF_3706_time = "nothing" Then NF3706_time.ForeColor = Color.Black Else NF3706_time.ForeColor = Color.Maroon
                NF3706_power.InvokeIfRequired(Sub() NF3706_power.Text = NF_3706_power)
                If NF_3706_power = "nothing" Then NF3706_power.ForeColor = Color.Black Else NF3706_power.ForeColor = Color.Maroon

                NF3707_soc.InvokeIfRequired(Sub() NF3707_soc.Text = NF_3707_soc)
                If NF_3707_soc = "nothing" Then NF3707_soc.ForeColor = Color.Black Else NF3707_soc.ForeColor = Color.Maroon
                NF3707_stat.InvokeIfRequired(Sub() NF3707_stat.Text = NF_3707_stat)
                If NF_3707_stat = "Idling" Then NF3707_stat.ForeColor = Color.Green Else If NF_3707_stat = "Charging" Then NF3707_stat.ForeColor = Color.Blue Else If NF_3707_stat = "Slow charging" Then NF3707_stat.ForeColor = Color.Blue Else If NF_3707_stat = "Driving" Then NF3707_stat.ForeColor = Color.Purple Else If NF_3707_stat = "Recovering" Then NF3707_stat.ForeColor = Color.Maroon
                NF3707_range.InvokeIfRequired(Sub() NF3707_range.Text = NF_3707_range)
                If NF_3707_range = "nothing" Then NF3707_time.ForeColor = Color.Black Else NF3707_range.ForeColor = Color.Maroon
                NF3707_time.InvokeIfRequired(Sub() NF3707_time.Text = NF_3707_time)
                If NF_3707_time = "nothing" Then NF3707_time.ForeColor = Color.Black Else NF3707_time.ForeColor = Color.Maroon
                NF3707_power.InvokeIfRequired(Sub() NF3707_power.Text = NF_3707_power)
                If NF_3707_power = "nothing" Then NF3707_power.ForeColor = Color.Black Else NF3707_power.ForeColor = Color.Maroon

                NF3708_soc.InvokeIfRequired(Sub() NF3708_soc.Text = NF_3708_soc)
                If NF_3708_soc = "nothing" Then NF3708_soc.ForeColor = Color.Black Else NF3708_soc.ForeColor = Color.Maroon
                NF3708_stat.InvokeIfRequired(Sub() NF3708_stat.Text = NF_3708_stat)
                If NF_3708_stat = "Idling" Then NF3708_stat.ForeColor = Color.Green Else If NF_3708_stat = "Charging" Then NF3708_stat.ForeColor = Color.Blue Else If NF_3708_stat = "Slow charging" Then NF3708_stat.ForeColor = Color.Blue Else If NF_3708_stat = "Driving" Then NF3708_stat.ForeColor = Color.Purple Else If NF_3708_stat = "Recovering" Then NF3708_stat.ForeColor = Color.Maroon
                NF3708_range.InvokeIfRequired(Sub() NF3708_range.Text = NF_3708_range)
                If NF_3708_range = "nothing" Then NF3708_time.ForeColor = Color.Black Else NF3708_range.ForeColor = Color.Maroon
                NF3708_time.InvokeIfRequired(Sub() NF3708_time.Text = NF_3708_time)
                If NF_3708_time = "nothing" Then NF3708_time.ForeColor = Color.Black Else NF3708_time.ForeColor = Color.Maroon
                NF3708_power.InvokeIfRequired(Sub() NF3708_power.Text = NF_3708_power)
                If NF_3708_power = "nothing" Then NF3708_power.ForeColor = Color.Black Else NF3708_power.ForeColor = Color.Maroon

                NF3709_soc.InvokeIfRequired(Sub() NF3709_soc.Text = NF_3709_soc)
                If NF_3709_soc = "nothing" Then NF3709_soc.ForeColor = Color.Black Else NF3709_soc.ForeColor = Color.Maroon
                NF3709_stat.InvokeIfRequired(Sub() NF3709_stat.Text = NF_3709_stat)
                If NF_3709_stat = "Idling" Then NF3709_stat.ForeColor = Color.Green Else If NF_3709_stat = "Charging" Then NF3709_stat.ForeColor = Color.Blue Else If NF_3709_stat = "Slow charging" Then NF3709_stat.ForeColor = Color.Blue Else If NF_3709_stat = "Driving" Then NF3709_stat.ForeColor = Color.Purple Else If NF_3709_stat = "Recovering" Then NF3709_stat.ForeColor = Color.Maroon
                NF3709_range.InvokeIfRequired(Sub() NF3709_range.Text = NF_3709_range)
                If NF_3709_range = "nothing" Then NF3709_time.ForeColor = Color.Black Else NF3709_range.ForeColor = Color.Maroon
                NF3709_time.InvokeIfRequired(Sub() NF3709_time.Text = NF_3709_time)
                If NF_3709_time = "nothing" Then NF3709_time.ForeColor = Color.Black Else NF3709_time.ForeColor = Color.Maroon
                NF3709_power.InvokeIfRequired(Sub() NF3709_power.Text = NF_3709_power)
                If NF_3709_power = "nothing" Then NF3709_power.ForeColor = Color.Black Else NF3709_power.ForeColor = Color.Maroon

                NF3710_soc.InvokeIfRequired(Sub() NF3710_soc.Text = NF_3710_soc)
                If NF_3710_soc = "nothing" Then NF3710_soc.ForeColor = Color.Black Else NF3710_soc.ForeColor = Color.Maroon
                NF3710_stat.InvokeIfRequired(Sub() NF3710_stat.Text = NF_3710_stat)
                If NF_3710_stat = "Idling" Then NF3710_stat.ForeColor = Color.Green Else If NF_3710_stat = "Charging" Then NF3710_stat.ForeColor = Color.Blue Else If NF_3710_stat = "Slow charging" Then NF3710_stat.ForeColor = Color.Blue Else If NF_3710_stat = "Driving" Then NF3710_stat.ForeColor = Color.Purple Else If NF_3710_stat = "Recovering" Then NF3710_stat.ForeColor = Color.Maroon
                NF3710_range.InvokeIfRequired(Sub() NF3710_range.Text = NF_3710_range)
                If NF_3710_range = "nothing" Then NF3710_time.ForeColor = Color.Black Else NF3710_range.ForeColor = Color.Maroon
                NF3710_time.InvokeIfRequired(Sub() NF3710_time.Text = NF_3710_time)
                If NF_3710_time = "nothing" Then NF3710_time.ForeColor = Color.Black Else NF3710_time.ForeColor = Color.Maroon
                NF3710_power.InvokeIfRequired(Sub() NF3710_power.Text = NF_3710_power)
                If NF_3710_power = "nothing" Then NF3710_power.ForeColor = Color.Black Else NF3710_power.ForeColor = Color.Maroon

                P3725_soc.InvokeIfRequired(Sub() P3725_soc.Text = P_3725_soc)
                If P_3725_soc = "nothing" Then P3725_soc.ForeColor = Color.Black Else P3725_soc.ForeColor = Color.Maroon
                P3725_stat.InvokeIfRequired(Sub() P3725_stat.Text = P_3725_stat)
                If P_3725_stat = "Idling" Then P3725_stat.ForeColor = Color.Green Else If P_3725_stat = "Charging" Then P3725_stat.ForeColor = Color.Blue Else If P_3725_stat = "Slow charging" Then P3725_stat.ForeColor = Color.Blue Else If P_3725_stat = "Driving" Then P3725_stat.ForeColor = Color.Purple Else If P_3725_stat = "Recovering" Then P3725_stat.ForeColor = Color.Maroon
                P3725_range.InvokeIfRequired(Sub() P3725_range.Text = P_3725_range)
                If P_3725_range = "nothing" Then P3725_time.ForeColor = Color.Black Else P3725_range.ForeColor = Color.Maroon
                P3725_time.InvokeIfRequired(Sub() P3725_time.Text = P_3725_time)
                If P_3725_time = "nothing" Then P3725_time.ForeColor = Color.Black Else P3725_time.ForeColor = Color.Maroon
                P3725_power.InvokeIfRequired(Sub() P3725_power.Text = P_3725_power)
                If P_3725_power = "nothing" Then P3725_power.ForeColor = Color.Black Else P3725_power.ForeColor = Color.Maroon

                P3726_soc.InvokeIfRequired(Sub() P3726_soc.Text = P_3726_soc)
                If P_3726_soc = "nothing" Then P3726_soc.ForeColor = Color.Black Else P3726_soc.ForeColor = Color.Maroon
                P3726_stat.InvokeIfRequired(Sub() P3726_stat.Text = P_3726_stat)
                If P_3726_stat = "Idling" Then P3726_stat.ForeColor = Color.Green Else If P_3726_stat = "Charging" Then P3726_stat.ForeColor = Color.Blue Else If P_3726_stat = "Slow charging" Then P3726_stat.ForeColor = Color.Blue Else If P_3726_stat = "Driving" Then P3726_stat.ForeColor = Color.Purple Else If P_3726_stat = "Recovering" Then P3726_stat.ForeColor = Color.Maroon
                P3726_range.InvokeIfRequired(Sub() P3726_range.Text = P_3725_range)
                If P_3726_range = "nothing" Then P3726_time.ForeColor = Color.Black Else P3726_range.ForeColor = Color.Maroon
                P3726_time.InvokeIfRequired(Sub() P3726_time.Text = P_3726_time)
                If P_3726_time = "nothing" Then P3726_time.ForeColor = Color.Black Else P3726_time.ForeColor = Color.Maroon
                P3726_power.InvokeIfRequired(Sub() P3726_power.Text = P_3726_power)
                If P_3726_power = "nothing" Then P3726_power.ForeColor = Color.Black Else P3726_power.ForeColor = Color.Maroon

                P3727_soc.InvokeIfRequired(Sub() P3727_soc.Text = P_3727_soc)
                If P_3727_soc = "nothing" Then P3727_soc.ForeColor = Color.Black Else P3727_soc.ForeColor = Color.Maroon
                P3727_stat.InvokeIfRequired(Sub() P3727_stat.Text = P_3727_stat)
                If P_3727_stat = "Idling" Then P3727_stat.ForeColor = Color.Green Else If P_3727_stat = "Charging" Then P3727_stat.ForeColor = Color.Blue Else If P_3727_stat = "Slow charging" Then P3727_stat.ForeColor = Color.Blue Else If P_3727_stat = "Driving" Then P3727_stat.ForeColor = Color.Purple Else If P_3727_stat = "Recovering" Then P3727_stat.ForeColor = Color.Maroon
                P3727_range.InvokeIfRequired(Sub() P3727_range.Text = P_3727_range)
                If P_3727_range = "nothing" Then P3727_time.ForeColor = Color.Black Else P3727_range.ForeColor = Color.Maroon
                P3727_time.InvokeIfRequired(Sub() P3727_time.Text = P_3727_time)
                If P_3727_time = "nothing" Then P3727_time.ForeColor = Color.Black Else P3727_time.ForeColor = Color.Maroon
                P3727_power.InvokeIfRequired(Sub() P3727_power.Text = P_3727_power)
                If P_3727_power = "nothing" Then P3727_power.ForeColor = Color.Black Else P3727_power.ForeColor = Color.Maroon

                P3728_soc.InvokeIfRequired(Sub() P3728_soc.Text = P_3728_soc)
                If P_3728_soc = "nothing" Then P3728_soc.ForeColor = Color.Black Else P3728_soc.ForeColor = Color.Maroon
                P3728_stat.InvokeIfRequired(Sub() P3728_stat.Text = P_3728_stat)
                If P_3728_stat = "Idling" Then P3728_stat.ForeColor = Color.Green Else If P_3728_stat = "Charging" Then P3728_stat.ForeColor = Color.Blue Else If P_3728_stat = "Slow charging" Then P3728_stat.ForeColor = Color.Blue Else If P_3728_stat = "Driving" Then P3728_stat.ForeColor = Color.Purple Else If P_3728_stat = "Recovering" Then P3728_stat.ForeColor = Color.Maroon
                P3728_range.InvokeIfRequired(Sub() P3728_range.Text = P_3728_range)
                If P_3728_range = "nothing" Then P3728_time.ForeColor = Color.Black Else P3728_range.ForeColor = Color.Maroon
                P3728_time.InvokeIfRequired(Sub() P3728_time.Text = P_3728_time)
                If P_3728_time = "nothing" Then P3728_time.ForeColor = Color.Black Else P3728_time.ForeColor = Color.Maroon
                P3728_power.InvokeIfRequired(Sub() P3728_power.Text = P_3728_power)
                If P_3728_power = "nothing" Then P3728_power.ForeColor = Color.Black Else P3728_power.ForeColor = Color.Maroon

                P3729_soc.InvokeIfRequired(Sub() P3729_soc.Text = P_3728_soc)
                If P_3729_soc = "nothing" Then P3729_soc.ForeColor = Color.Black Else P3729_soc.ForeColor = Color.Maroon
                P3729_stat.InvokeIfRequired(Sub() P3729_stat.Text = P_3729_stat)
                If P_3729_stat = "Idling" Then P3729_stat.ForeColor = Color.Green Else If P_3729_stat = "Charging" Then P3729_stat.ForeColor = Color.Blue Else If P_3729_stat = "Slow charging" Then P3729_stat.ForeColor = Color.Blue Else If P_3729_stat = "Driving" Then P3729_stat.ForeColor = Color.Purple Else If P_3729_stat = "Recovering" Then P3729_stat.ForeColor = Color.Maroon
                P3729_range.InvokeIfRequired(Sub() P3729_range.Text = P_3729_range)
                If P_3729_range = "nothing" Then P3729_time.ForeColor = Color.Black Else P3729_range.ForeColor = Color.Maroon
                P3729_time.InvokeIfRequired(Sub() P3729_time.Text = P_3729_time)
                If P_3729_time = "nothing" Then P3729_time.ForeColor = Color.Black Else P3729_time.ForeColor = Color.Maroon
                P3729_power.InvokeIfRequired(Sub() P3729_power.Text = P_3729_power)
                If P_3729_power = "nothing" Then P3729_power.ForeColor = Color.Black Else P3729_power.ForeColor = Color.Maroon

                P3730_soc.InvokeIfRequired(Sub() P3730_soc.Text = P_3730_soc)
                If P_3730_soc = "nothing" Then P3730_soc.ForeColor = Color.Black Else P3730_soc.ForeColor = Color.Maroon
                P3730_stat.InvokeIfRequired(Sub() P3730_stat.Text = P_3730_stat)
                If P_3730_stat = "Idling" Then P3730_stat.ForeColor = Color.Green Else If P_3730_stat = "Charging" Then P3730_stat.ForeColor = Color.Blue Else If P_3730_stat = "Slow charging" Then P3730_stat.ForeColor = Color.Blue Else If P_3730_stat = "Driving" Then P3730_stat.ForeColor = Color.Purple Else If P_3730_stat = "Recovering" Then P3730_stat.ForeColor = Color.Maroon
                P3730_range.InvokeIfRequired(Sub() P3730_range.Text = P_3730_range)
                If P_3730_range = "nothing" Then P3730_time.ForeColor = Color.Black Else P3730_range.ForeColor = Color.Maroon
                P3730_time.InvokeIfRequired(Sub() P3730_time.Text = P_3730_time)
                If P_3730_time = "nothing" Then P3730_time.ForeColor = Color.Black Else P3730_time.ForeColor = Color.Maroon
                P3730_power.InvokeIfRequired(Sub() P3730_power.Text = P_3730_power)
                If P_3730_power = "nothing" Then P3730_power.ForeColor = Color.Black Else P3730_power.ForeColor = Color.Maroon

                P3731_soc.InvokeIfRequired(Sub() P3731_soc.Text = P_3731_soc)
                If P_3731_soc = "nothing" Then P3731_soc.ForeColor = Color.Black Else P3731_soc.ForeColor = Color.Maroon
                P3731_stat.InvokeIfRequired(Sub() P3731_stat.Text = P_3731_stat)
                If P_3731_stat = "Idling" Then P3731_stat.ForeColor = Color.Green Else If P_3731_stat = "Charging" Then P3731_stat.ForeColor = Color.Blue Else If P_3731_stat = "Slow charging" Then P3731_stat.ForeColor = Color.Blue Else If P_3731_stat = "Driving" Then P3731_stat.ForeColor = Color.Purple Else If P_3731_stat = "Recovering" Then P3731_stat.ForeColor = Color.Maroon
                P3731_range.InvokeIfRequired(Sub() P3731_range.Text = P_3731_range)
                If P_3731_range = "nothing" Then P3731_time.ForeColor = Color.Black Else P3731_range.ForeColor = Color.Maroon
                P3731_time.InvokeIfRequired(Sub() P3731_time.Text = P_3731_time)
                If P_3731_time = "nothing" Then P3731_time.ForeColor = Color.Black Else P3731_time.ForeColor = Color.Maroon
                P3731_power.InvokeIfRequired(Sub() P3731_power.Text = P_3731_power)
                If P_3731_power = "nothing" Then P3731_power.ForeColor = Color.Black Else P3731_power.ForeColor = Color.Maroon

                P3732_soc.InvokeIfRequired(Sub() P3732_soc.Text = P_3732_soc)
                If P_3732_soc = "nothing" Then P3732_soc.ForeColor = Color.Black Else P3732_soc.ForeColor = Color.Maroon
                P3732_stat.InvokeIfRequired(Sub() P3732_stat.Text = P_3732_stat)
                If P_3732_stat = "Idling" Then P3732_stat.ForeColor = Color.Green Else If P_3732_stat = "Charging" Then P3732_stat.ForeColor = Color.Blue Else If P_3732_stat = "Slow charging" Then P3732_stat.ForeColor = Color.Blue Else If P_3732_stat = "Driving" Then P3732_stat.ForeColor = Color.Purple Else If P_3732_stat = "Recovering" Then P3732_stat.ForeColor = Color.Maroon
                P3731_range.InvokeIfRequired(Sub() P3732_range.Text = P_3732_range)
                If P_3732_range = "nothing" Then P3732_time.ForeColor = Color.Black Else P3732_range.ForeColor = Color.Maroon
                P3732_time.InvokeIfRequired(Sub() P3732_time.Text = P_3732_time)
                If P_3732_time = "nothing" Then P3732_time.ForeColor = Color.Black Else P3732_time.ForeColor = Color.Maroon
                P3731_power.InvokeIfRequired(Sub() P3732_power.Text = P_3732_power)
                If P_3732_power = "nothing" Then P3732_power.ForeColor = Color.Black Else P3732_power.ForeColor = Color.Maroon

                P3733_soc.InvokeIfRequired(Sub() P3733_soc.Text = P_3733_soc)
                If P_3733_soc = "nothing" Then P3733_soc.ForeColor = Color.Black Else P3733_soc.ForeColor = Color.Maroon
                P3733_stat.InvokeIfRequired(Sub() P3733_stat.Text = P_3733_stat)
                If P_3733_stat = "Idling" Then P3733_stat.ForeColor = Color.Green Else If P_3733_stat = "Charging" Then P3733_stat.ForeColor = Color.Blue Else If P_3733_stat = "Slow charging" Then P3733_stat.ForeColor = Color.Blue Else If P_3733_stat = "Driving" Then P3733_stat.ForeColor = Color.Purple Else If P_3733_stat = "Recovering" Then P3733_stat.ForeColor = Color.Maroon
                P3733_range.InvokeIfRequired(Sub() P3733_range.Text = P_3733_range)
                If P_3733_range = "nothing" Then P3733_time.ForeColor = Color.Black Else P3733_range.ForeColor = Color.Maroon
                P3733_time.InvokeIfRequired(Sub() P3733_time.Text = P_3733_time)
                If P_3733_time = "nothing" Then P3733_time.ForeColor = Color.Black Else P3733_time.ForeColor = Color.Maroon
                P3733_power.InvokeIfRequired(Sub() P3733_power.Text = P_3733_power)
                If P_3733_power = "nothing" Then P3733_power.ForeColor = Color.Black Else P3733_power.ForeColor = Color.Maroon

                P3734_soc.InvokeIfRequired(Sub() P3734_soc.Text = P_3734_soc)
                If P_3734_soc = "nothing" Then P3734_soc.ForeColor = Color.Black Else P3734_soc.ForeColor = Color.Maroon
                P3734_stat.InvokeIfRequired(Sub() P3734_stat.Text = P_3734_stat)
                If P_3734_stat = "Idling" Then P3734_stat.ForeColor = Color.Green Else If P_3734_stat = "Charging" Then P3734_stat.ForeColor = Color.Blue Else If P_3734_stat = "Slow charging" Then P3734_stat.ForeColor = Color.Blue Else If P_3734_stat = "Driving" Then P3734_stat.ForeColor = Color.Purple Else If P_3734_stat = "Recovering" Then P3734_stat.ForeColor = Color.Maroon
                P3734_range.InvokeIfRequired(Sub() P3734_range.Text = P_3734_range)
                If P_3734_range = "nothing" Then P3734_time.ForeColor = Color.Black Else P3734_range.ForeColor = Color.Maroon
                P3734_time.InvokeIfRequired(Sub() P3734_time.Text = P_3734_time)
                If P_3734_time = "nothing" Then P3734_time.ForeColor = Color.Black Else P3734_time.ForeColor = Color.Maroon
                P3734_power.InvokeIfRequired(Sub() P3734_power.Text = P_3734_power)
                If P_3734_power = "nothing" Then P3734_power.ForeColor = Color.Black Else P3734_power.ForeColor = Color.Maroon

                'ARROW ROAD
                'Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\AR_VehSoc.txt", False)
                Using writer As New StreamWriter("AR_VehSoc.txt", False)
                    writer.WriteLine(NF_3700_soc + Environment.NewLine + NF_3701_soc + Environment.NewLine + NF_3702_soc + Environment.NewLine + NF_3703_soc + Environment.NewLine + NF_3704_soc + Environment.NewLine +
                                     NF_3705_soc + Environment.NewLine + NF_3706_soc + Environment.NewLine + NF_3707_soc + Environment.NewLine + NF_3708_soc + Environment.NewLine + NF_3709_soc + Environment.NewLine + NF_3710_soc)
                End Using
                'Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\AR_VehStat.txt", False)
                Using writer As New StreamWriter("AR_VehStat.txt", False)
                    writer.WriteLine(NF_3700_stat + Environment.NewLine + NF_3701_stat + Environment.NewLine + NF_3702_stat + Environment.NewLine + NF_3703_stat + Environment.NewLine + NF_3704_stat + Environment.NewLine +
                                     NF_3705_stat + Environment.NewLine + NF_3706_stat + Environment.NewLine + NF_3707_stat + Environment.NewLine + NF_3708_stat + Environment.NewLine + NF_3709_stat + Environment.NewLine + NF_3710_stat)
                End Using
                'Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\AR_VehRange.txt", False)
                Using writer As New StreamWriter("AR_VehRange.txt", False)
                    writer.WriteLine(NF_3700_range + Environment.NewLine + NF_3701_range + Environment.NewLine + NF_3702_range + Environment.NewLine + NF_3703_range + Environment.NewLine + NF_3704_range + Environment.NewLine +
                                     NF_3705_range + Environment.NewLine + NF_3706_range + Environment.NewLine + NF_3707_range + Environment.NewLine + NF_3708_range + Environment.NewLine + NF_3709_range + Environment.NewLine + NF_3710_range)
                End Using
                'Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\AR_VehTime.txt", False)
                Using writer As New StreamWriter("AR_VehTime.txt", False)
                    writer.WriteLine(NF_3700_time + Environment.NewLine + NF_3701_time + Environment.NewLine + NF_3702_time + Environment.NewLine + NF_3703_time + Environment.NewLine + NF_3704_time + Environment.NewLine +
                                     NF_3705_time + Environment.NewLine + NF_3706_time + Environment.NewLine + NF_3707_time + Environment.NewLine + NF_3708_time + Environment.NewLine + NF_3709_time + Environment.NewLine + NF_3710_time)
                End Using
                'Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\AR_VehPower.txt", False)
                Using writer As New StreamWriter("AR_VehPower.txt", False)
                    writer.WriteLine(NF_3700_power + Environment.NewLine + NF_3701_power + Environment.NewLine + NF_3702_power + Environment.NewLine + NF_3703_power + Environment.NewLine + NF_3704_power + Environment.NewLine +
                                     NF_3705_power + Environment.NewLine + NF_3706_power + Environment.NewLine + NF_3707_power + Environment.NewLine + NF_3708_power + Environment.NewLine + NF_3709_power + Environment.NewLine + NF_3710_power)
                End Using

                'MOUNT DENNIS
                'Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\MD_VehSoc.txt", False)
                Using writer As New StreamWriter("MD_VehSoc.txt", False)
                    writer.WriteLine(P_3725_soc + Environment.NewLine + P_3726_soc + Environment.NewLine + P_3727_soc + Environment.NewLine + P_3728_soc + Environment.NewLine + P_3729_soc + Environment.NewLine +
                                     P_3730_soc + Environment.NewLine + P_3731_soc + Environment.NewLine + P_3732_soc + Environment.NewLine + P_3733_soc + Environment.NewLine + P_3734_soc)
                End Using
                'Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\MD_VehStat.txt", False)
                Using writer As New StreamWriter("MD_VehStat.txt", False)
                    writer.WriteLine(P_3725_stat + Environment.NewLine + P_3726_stat + Environment.NewLine + P_3727_stat + Environment.NewLine + P_3728_stat + Environment.NewLine + P_3729_stat + Environment.NewLine +
                                     P_3730_stat + Environment.NewLine + P_3731_stat + Environment.NewLine + P_3732_stat + Environment.NewLine + P_3733_stat + Environment.NewLine + P_3734_stat)
                End Using
                'Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\MD_VehRange.txt", False)
                Using writer As New StreamWriter("MD_VehRange.txt", False)
                    writer.WriteLine(P_3725_range + Environment.NewLine + P_3726_range + Environment.NewLine + P_3727_range + Environment.NewLine + P_3728_range + Environment.NewLine + P_3729_range + Environment.NewLine +
                                     P_3730_range + Environment.NewLine + P_3731_range + Environment.NewLine + P_3732_range + Environment.NewLine + P_3733_range + Environment.NewLine + P_3734_range)
                End Using
                'Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\MD_VehTime.txt", False)
                Using writer As New StreamWriter("MD_VehTime.txt", False)
                    writer.WriteLine(P_3725_time + Environment.NewLine + P_3726_time + Environment.NewLine + P_3727_time + Environment.NewLine + P_3728_time + Environment.NewLine + P_3729_time + Environment.NewLine +
                                     P_3730_time + Environment.NewLine + P_3731_time + Environment.NewLine + P_3732_time + Environment.NewLine + P_3733_time + Environment.NewLine + P_3734_time)
                End Using
                'Using writer As New StreamWriter("C:\inetpub\wwwroot\bin\MD_VehPower.txt", False)
                Using writer As New StreamWriter("MD_VehPower.txt", False)
                    writer.WriteLine(P_3725_power + Environment.NewLine + P_3726_power + Environment.NewLine + P_3727_power + Environment.NewLine + P_3728_power + Environment.NewLine + P_3729_power + Environment.NewLine +
                                     P_3730_power + Environment.NewLine + P_3731_power + Environment.NewLine + P_3732_power + Environment.NewLine + P_3733_power + Environment.NewLine + P_3734_power)
                End Using

            End While
            'Threading.Thread.Sleep(1000)
            driver2.Close()
            driver2.Quit()
            Cycle2 = False

            Label29.ForeColor = Color.Maroon
            Label29.InvokeIfRequired(Sub() Label29.Text = "Stopped, removing drivers...")

        End Using
    End Sub

    Private Sub BackgroundWorker2_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker2.ProgressChanged
        ProgressBar2.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        If e.Cancelled = True Then
            MsgBox("Cancelled")
        ElseIf e.Error IsNot Nothing Then
            MsgBox("Error")
        Else
            Label29.ForeColor = Color.Maroon
            Label29.InvokeIfRequired(Sub() Label29.Text = "Drivers removed!")
        End If
    End Sub

    '----------------------------------------------------------------------------------------
    '                                  CALL SUBS
    '---------------------------------------------------------------------------------------- 
    'Check Color
    Public Sub CheckColor()
        Select Case Charger.Text
            Case "Ready for use"
                Charger.ForeColor = Color.Green
            Case "Charging in progress"
                Charger.ForeColor = Color.Blue
            Case "Status unknown" Or "Charger in error" Or "Unavailable - emergency button pressed" Or "Unavailable - door open"
                Charger.Forecolor = Color.Red
        End Select
    End Sub

    'Check Socket
    Public Sub CheckSoc()
        If VehicleSoc.Text = "nothing" Then
            VehicleSoc.ForeColor = Color.Black
        Else
            VehicleSoc.ForeColor = Color.Maroon
        End If
    End Sub

    'Check Stat
    Public Sub CheckStat()
        Select Case VehicleStat.Text
            Case "Idling"
                VehicleStat.ForeColor = Color.Green
            Case "Charging" Or "Slow charging"
                VehicleStat.ForeColor = Color.Blue
            Case "Driving"
                VehicleStat.ForeColor = Color.Purple
            Case "Recovering"
                VehicleStat.ForeColor = Color.Maroon
        End Select
    End Sub

    'Check Vehicle Health
    Public Sub CheckHlth()
        If VehicleHlth.InvokeRequired Then
            If VehicleHlth.Text = "OFFLINE FOR OVER 1 MINUTE" Then
                VehicleHlth.ForeColor = Color.Red
            Else
                VehicleHlth.Forecolor = Color.Blue
            End If
        Else
            If VehicleHlth.Text = "OFFLINE FOR OVER 1 MINUTE" Then
                VehicleHlth.ForeColor = Color.Red
            Else
                VehicleHlth.Forecolor = Color.Blue
            End If
        End If
    End Sub

End Class
