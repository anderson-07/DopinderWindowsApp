Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography

Public Class MainDashboard

    Private Sub MainDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialize Components
        'Initialize panels to be hidden

        Timer1.Enabled = True

        'Set Current Date on Form Load
        Dim formattedDate As String = Today.ToString("MM-dd-yyyy")
        currentDate.Text = formattedDate

        ' Set initial location label
        lbl_location.Text = "Home"

        'Set Current User on Form Load
        panel_resident_info.Visible = False
        panel_home.Visible = True
        panel_blotter_reports.Visible = False
        panel_baranggay_clearance.Visible = False
        panel_settings.Visible = False
        panel_permits.Visible = False
        panel_reports.Visible = False
        panel_sms.Visible = False

        resident_information_display.Enabled = False
        blotter_reports_display.Enabled = False
        baranggay_clearance_display.Enabled = False
        permits_display.Enabled = False

    End Sub

    Private Function RoundedRectangle(rect As RectangleF, diam As Single) As Drawing2D.GraphicsPath
        Dim path As New Drawing2D.GraphicsPath
        path.AddArc(rect.Left, rect.Top, diam, diam, 180, 90)
        path.AddArc(rect.Right - diam, rect.Top, diam, diam, 270, 90)
        path.AddArc(rect.Right - diam, rect.Bottom - diam, diam, diam, 0, 90)
        path.AddArc(rect.Left, rect.Bottom - diam, diam, diam, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_resident_info.Click
        'Show Resident Information Panel and hide others

        lbl_location.Text = "Resident Information"

        panel_resident_info.Visible = True
        panel_home.Visible = False
        panel_blotter_reports.Visible = False
        panel_baranggay_clearance.Visible = False
        panel_settings.Visible = False
        panel_permits.Visible = False
        panel_reports.Visible = False
        panel_sms.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_blotter_reports.Click
        'Show Blotter Reports Panel and hide others

        lbl_location.Text = "Blotter Reports"

        panel_resident_info.Visible = False
        panel_home.Visible = False
        panel_blotter_reports.Visible = True
        panel_baranggay_clearance.Visible = False
        panel_settings.Visible = False
        panel_permits.Visible = False
        panel_reports.Visible = False
        panel_sms.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_baranggay_clearance.Click
        'Show Barangay Clearance Panel and hide others

        lbl_location.Text = "Barangay Clearance"

        panel_resident_info.Visible = False
        panel_home.Visible = False
        panel_blotter_reports.Visible = False
        panel_baranggay_clearance.Visible = True
        panel_settings.Visible = False
        panel_permits.Visible = False
        panel_reports.Visible = False
        panel_sms.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_permits.Click
        'Show Permits Panel and hide others

        lbl_location.Text = "Permits & Certifications"

        panel_resident_info.Visible = False
        panel_home.Visible = False
        panel_blotter_reports.Visible = False
        panel_baranggay_clearance.Visible = False
        panel_settings.Visible = False
        panel_permits.Visible = True
        panel_reports.Visible = False
        panel_sms.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_sms.Click
        'Show SMS Panel and hide others

        lbl_location.Text = "SMS Notifications"

        panel_resident_info.Visible = False
        panel_home.Visible = False
        panel_blotter_reports.Visible = False
        panel_baranggay_clearance.Visible = False
        panel_settings.Visible = False
        panel_permits.Visible = False
        panel_reports.Visible = False
        panel_sms.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn_reports.Click
        'Show Reports Panel and hide others

        lbl_location.Text = "Reports"

        panel_resident_info.Visible = False
        panel_home.Visible = False
        panel_blotter_reports.Visible = False
        panel_baranggay_clearance.Visible = False
        panel_settings.Visible = False
        panel_permits.Visible = False
        panel_reports.Visible = True
        panel_sms.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btn_settings.Click
        'Show Settings Panel and hide others

        lbl_location.Text = "Settings"

        panel_resident_info.Visible = False
        panel_home.Visible = False
        panel_blotter_reports.Visible = False
        panel_baranggay_clearance.Visible = False
        panel_settings.Visible = True
        panel_permits.Visible = False
        panel_reports.Visible = False
        panel_sms.Visible = False
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        'Show Home Panel and hide others

        lbl_location.Text = "Home"

        panel_resident_info.Visible = False
        panel_home.Visible = True
        panel_blotter_reports.Visible = False
        panel_baranggay_clearance.Visible = False
        panel_settings.Visible = False
        panel_permits.Visible = False
        panel_reports.Visible = False
        panel_sms.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        currentTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles btn_close.MouseEnter
        btn_close.BackColor = Color.FromArgb(255, 0, 0) ' Change to orange on hover
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_close_MouseLeave(sender As Object, e As EventArgs) Handles btn_close.MouseLeave
        btn_close.BackColor = Color.FromArgb(255, 128, 128) ' Change back to original color
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub resident_information_display_Click(sender As Object, e As EventArgs) Handles resident_information_display.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class
