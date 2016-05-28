Public Class Form1

    'Definitions
    Dim TiltString As String
    Dim SolarString As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set up for the TiltMeter
        DegreeLabel.Text = Chr(176) 'Degrees'
        SerialPort1.Open()
        Timer1.Start()

        'Set up for the Solar Voltmeter
        VoltageLabel.Text = "V"
        SerialPort2.Open()
        Timer2.Start()

    End Sub

    'Tilt Sensor Code
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TiltString = SerialPort1.ReadLine()

        If TiltString <> "" Then
            'Read the values from 1 to 25, if you match then go on
            If Mid(TiltString, 1, 25) = "The Xangle in degrees is " Then

                'Begin getting the value from the 26th position and store as Text, accurate to 2 decimals
                TiltReading.Text = FormatNumber(CDbl(Mid(TiltString, 26, (Len(TiltString) - 25))), 2)

                'Set value equal to what you've read
                TiltGauge.Value = Mid(TiltString, 26, (Len(TiltString) - 1))

                'Refresh the display to get accurate readings
                TiltGauge.Refresh()
            End If
        End If
    End Sub

    'Solar Sensor Code
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        SolarString = SerialPort2.ReadLine()

        If SolarString <> "" Then
            'Read the values from 1 to 23, if you match then go on
            If Mid(SolarString, 1, 23) = "The voltage reading is " Then

                'Begin getting the value from the 24th position and store as Text, accurate to 2 decimals
                SolarReading.Text = FormatNumber(CDbl(Mid(SolarString, 24, (Len(SolarString) - 23))), 2)

                'Set value equal to what you've read
                SolarEnergyGauge.Value = Mid(SolarString, 24, (Len(SolarString) - 1))

                'Refresh the display to get accurate readings
                SolarEnergyGauge.Refresh()
            End If
        End If
    End Sub
End Class