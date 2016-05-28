<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim AGaugeRange1 As System.Windows.Forms.AGaugeRange = New System.Windows.Forms.AGaugeRange()
        Dim AGaugeRange2 As System.Windows.Forms.AGaugeRange = New System.Windows.Forms.AGaugeRange()
        Dim AGaugeRange3 As System.Windows.Forms.AGaugeRange = New System.Windows.Forms.AGaugeRange()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DegreeLabel = New System.Windows.Forms.Label()
        Me.TiltReading = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.VoltageLabel = New System.Windows.Forms.Label()
        Me.SolarReading = New System.Windows.Forms.Label()
        Me.SolarEnergyReading = New System.Windows.Forms.TextBox()
        Me.AngleOfTilt = New System.Windows.Forms.TextBox()
        Me.SolarEnergyGauge = New System.Windows.Forms.AGauge()
        Me.TiltGauge = New System.Windows.Forms.AGauge()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort2 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DegreeLabel)
        Me.GroupBox2.Controls.Add(Me.TiltReading)
        Me.GroupBox2.Location = New System.Drawing.Point(357, 232)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(132, 44)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'DegreeLabel
        '
        Me.DegreeLabel.AutoSize = True
        Me.DegreeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DegreeLabel.Location = New System.Drawing.Point(50, 14)
        Me.DegreeLabel.Name = "DegreeLabel"
        Me.DegreeLabel.Size = New System.Drawing.Size(81, 16)
        Me.DegreeLabel.TabIndex = 1
        Me.DegreeLabel.Text = "DEGREES"
        '
        'TiltReading
        '
        Me.TiltReading.AutoSize = True
        Me.TiltReading.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TiltReading.Location = New System.Drawing.Point(6, 12)
        Me.TiltReading.Name = "TiltReading"
        Me.TiltReading.Size = New System.Drawing.Size(40, 18)
        Me.TiltReading.TabIndex = 0
        Me.TiltReading.Text = "0.00"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.VoltageLabel)
        Me.GroupBox1.Controls.Add(Me.SolarReading)
        Me.GroupBox1.Location = New System.Drawing.Point(100, 247)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(80, 34)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'VoltageLabel
        '
        Me.VoltageLabel.AutoSize = True
        Me.VoltageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VoltageLabel.Location = New System.Drawing.Point(43, 9)
        Me.VoltageLabel.Name = "VoltageLabel"
        Me.VoltageLabel.Size = New System.Drawing.Size(18, 16)
        Me.VoltageLabel.TabIndex = 1
        Me.VoltageLabel.Text = "V"
        '
        'SolarReading
        '
        Me.SolarReading.AutoSize = True
        Me.SolarReading.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolarReading.Location = New System.Drawing.Point(7, 8)
        Me.SolarReading.Name = "SolarReading"
        Me.SolarReading.Size = New System.Drawing.Size(40, 18)
        Me.SolarReading.TabIndex = 0
        Me.SolarReading.Text = "0.00"
        '
        'SolarEnergyReading
        '
        Me.SolarEnergyReading.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SolarEnergyReading.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SolarEnergyReading.Cursor = System.Windows.Forms.Cursors.No
        Me.SolarEnergyReading.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolarEnergyReading.Location = New System.Drawing.Point(12, 23)
        Me.SolarEnergyReading.Name = "SolarEnergyReading"
        Me.SolarEnergyReading.Size = New System.Drawing.Size(261, 21)
        Me.SolarEnergyReading.TabIndex = 20
        Me.SolarEnergyReading.Text = "SOLAR ENERGY READING"
        Me.SolarEnergyReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AngleOfTilt
        '
        Me.AngleOfTilt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AngleOfTilt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AngleOfTilt.Cursor = System.Windows.Forms.Cursors.No
        Me.AngleOfTilt.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AngleOfTilt.Location = New System.Drawing.Point(328, 25)
        Me.AngleOfTilt.Name = "AngleOfTilt"
        Me.AngleOfTilt.Size = New System.Drawing.Size(207, 21)
        Me.AngleOfTilt.TabIndex = 19
        Me.AngleOfTilt.Text = "ANGLE OF TILT"
        Me.AngleOfTilt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SolarEnergyGauge
        '
        Me.SolarEnergyGauge.BaseArcColor = System.Drawing.Color.Gray
        Me.SolarEnergyGauge.BaseArcRadius = 80
        Me.SolarEnergyGauge.BaseArcStart = 135
        Me.SolarEnergyGauge.BaseArcSweep = 135
        Me.SolarEnergyGauge.BaseArcWidth = 2
        Me.SolarEnergyGauge.Center = New System.Drawing.Point(100, 100)
        AGaugeRange1.Color = System.Drawing.Color.Cyan
        AGaugeRange1.EndValue = 25.0!
        AGaugeRange1.InnerRadius = 20
        AGaugeRange1.InRange = False
        AGaugeRange1.Name = "GaugeRange1"
        AGaugeRange1.OuterRadius = 80
        AGaugeRange1.StartValue = 0.0!
        AGaugeRange2.Color = System.Drawing.Color.Lime
        AGaugeRange2.EndValue = 45.0!
        AGaugeRange2.InnerRadius = 20
        AGaugeRange2.InRange = False
        AGaugeRange2.Name = "GaugeRange2"
        AGaugeRange2.OuterRadius = 80
        AGaugeRange2.StartValue = 25.0!
        AGaugeRange3.Color = System.Drawing.Color.Red
        AGaugeRange3.EndValue = 60.0!
        AGaugeRange3.InnerRadius = 20
        AGaugeRange3.InRange = False
        AGaugeRange3.Name = "GaugeRange3"
        AGaugeRange3.OuterRadius = 80
        AGaugeRange3.StartValue = 45.0!
        Me.SolarEnergyGauge.GaugeRanges.Add(AGaugeRange1)
        Me.SolarEnergyGauge.GaugeRanges.Add(AGaugeRange2)
        Me.SolarEnergyGauge.GaugeRanges.Add(AGaugeRange3)
        Me.SolarEnergyGauge.Location = New System.Drawing.Point(62, 50)
        Me.SolarEnergyGauge.MaxValue = 60.0!
        Me.SolarEnergyGauge.MinValue = 0.0!
        Me.SolarEnergyGauge.Name = "SolarEnergyGauge"
        Me.SolarEnergyGauge.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray
        Me.SolarEnergyGauge.NeedleColor2 = System.Drawing.Color.DimGray
        Me.SolarEnergyGauge.NeedleRadius = 80
        Me.SolarEnergyGauge.NeedleType = System.Windows.Forms.NeedleType.Advance
        Me.SolarEnergyGauge.NeedleWidth = 2
        Me.SolarEnergyGauge.ScaleLinesInterColor = System.Drawing.Color.Black
        Me.SolarEnergyGauge.ScaleLinesInterInnerRadius = 73
        Me.SolarEnergyGauge.ScaleLinesInterOuterRadius = 80
        Me.SolarEnergyGauge.ScaleLinesInterWidth = 1
        Me.SolarEnergyGauge.ScaleLinesMajorColor = System.Drawing.Color.Black
        Me.SolarEnergyGauge.ScaleLinesMajorInnerRadius = 1
        Me.SolarEnergyGauge.ScaleLinesMajorOuterRadius = 1
        Me.SolarEnergyGauge.ScaleLinesMajorStepValue = 5.0!
        Me.SolarEnergyGauge.ScaleLinesMajorWidth = 2
        Me.SolarEnergyGauge.ScaleLinesMinorColor = System.Drawing.Color.Gray
        Me.SolarEnergyGauge.ScaleLinesMinorInnerRadius = 75
        Me.SolarEnergyGauge.ScaleLinesMinorOuterRadius = 80
        Me.SolarEnergyGauge.ScaleLinesMinorTicks = 9
        Me.SolarEnergyGauge.ScaleLinesMinorWidth = 1
        Me.SolarEnergyGauge.ScaleNumbersColor = System.Drawing.Color.Black
        Me.SolarEnergyGauge.ScaleNumbersFormat = Nothing
        Me.SolarEnergyGauge.ScaleNumbersRadius = 95
        Me.SolarEnergyGauge.ScaleNumbersRotation = 0
        Me.SolarEnergyGauge.ScaleNumbersStartScaleLine = 0
        Me.SolarEnergyGauge.ScaleNumbersStepScaleLines = 1
        Me.SolarEnergyGauge.Size = New System.Drawing.Size(123, 180)
        Me.SolarEnergyGauge.TabIndex = 1
        Me.SolarEnergyGauge.Text = "AGauge1"
        Me.SolarEnergyGauge.Value = 0.0!
        '
        'TiltGauge
        '
        Me.TiltGauge.BaseArcColor = System.Drawing.Color.Gray
        Me.TiltGauge.BaseArcRadius = 80
        Me.TiltGauge.BaseArcStart = 0
        Me.TiltGauge.BaseArcSweep = -180
        Me.TiltGauge.BaseArcWidth = 2
        Me.TiltGauge.Center = New System.Drawing.Point(110, 120)
        Me.TiltGauge.Location = New System.Drawing.Point(290, 50)
        Me.TiltGauge.MaxValue = 180.0!
        Me.TiltGauge.MinValue = 0.0!
        Me.TiltGauge.Name = "TiltGauge"
        Me.TiltGauge.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray
        Me.TiltGauge.NeedleColor2 = System.Drawing.Color.DimGray
        Me.TiltGauge.NeedleRadius = 80
        Me.TiltGauge.NeedleType = System.Windows.Forms.NeedleType.Advance
        Me.TiltGauge.NeedleWidth = 2
        Me.TiltGauge.ScaleLinesInterColor = System.Drawing.Color.Black
        Me.TiltGauge.ScaleLinesInterInnerRadius = 0
        Me.TiltGauge.ScaleLinesInterOuterRadius = 0
        Me.TiltGauge.ScaleLinesInterWidth = 0
        Me.TiltGauge.ScaleLinesMajorColor = System.Drawing.Color.Black
        Me.TiltGauge.ScaleLinesMajorInnerRadius = 1
        Me.TiltGauge.ScaleLinesMajorOuterRadius = 80
        Me.TiltGauge.ScaleLinesMajorStepValue = 90.0!
        Me.TiltGauge.ScaleLinesMajorWidth = 1
        Me.TiltGauge.ScaleLinesMinorColor = System.Drawing.Color.Gray
        Me.TiltGauge.ScaleLinesMinorInnerRadius = 75
        Me.TiltGauge.ScaleLinesMinorOuterRadius = 80
        Me.TiltGauge.ScaleLinesMinorTicks = 14
        Me.TiltGauge.ScaleLinesMinorWidth = 1
        Me.TiltGauge.ScaleNumbersColor = System.Drawing.Color.Black
        Me.TiltGauge.ScaleNumbersFormat = Nothing
        Me.TiltGauge.ScaleNumbersRadius = 100
        Me.TiltGauge.ScaleNumbersRotation = 0
        Me.TiltGauge.ScaleNumbersStartScaleLine = 0
        Me.TiltGauge.ScaleNumbersStepScaleLines = 1
        Me.TiltGauge.Size = New System.Drawing.Size(221, 149)
        Me.TiltGauge.TabIndex = 8
        Me.TiltGauge.Text = "TiltGauge"
        Me.TiltGauge.Value = 0.0!
        '
        'SerialPort1
        '
        Me.SerialPort1.DtrEnable = True
        Me.SerialPort1.PortName = "COM3"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'SerialPort2
        '
        Me.SerialPort2.DtrEnable = True
        Me.SerialPort2.PortName = "COM4"
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 314)
        Me.Controls.Add(Me.TiltGauge)
        Me.Controls.Add(Me.SolarEnergyGauge)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SolarEnergyReading)
        Me.Controls.Add(Me.AngleOfTilt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DegreeLabel As System.Windows.Forms.Label
    Friend WithEvents TiltReading As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents VoltageLabel As System.Windows.Forms.Label
    Friend WithEvents SolarReading As System.Windows.Forms.Label
    Friend WithEvents SolarEnergyReading As System.Windows.Forms.TextBox
    Friend WithEvents AngleOfTilt As System.Windows.Forms.TextBox
    Friend WithEvents SolarEnergyGauge As System.Windows.Forms.AGauge
    Friend WithEvents TiltGauge As System.Windows.Forms.AGauge
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SerialPort2 As System.IO.Ports.SerialPort
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
