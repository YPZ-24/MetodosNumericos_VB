<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Integracion_Simpson
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.nav_Home = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnGraficar = New System.Windows.Forms.Button()
        Me.grafica = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbresu = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ta = New System.Windows.Forms.TextBox()
        Me.tb = New System.Windows.Forms.TextBox()
        Me.lbTxtDos = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.lc = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.nav_Home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grafica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Panel1.Controls.Add(Me.nav_Home)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 58)
        Me.Panel1.TabIndex = 91
        '
        'nav_Home
        '
        Me.nav_Home.Image = Global.MetodosNumericos.My.Resources.Resources.Imagen1__2_
        Me.nav_Home.Location = New System.Drawing.Point(12, -21)
        Me.nav_Home.Name = "nav_Home"
        Me.nav_Home.Size = New System.Drawing.Size(130, 100)
        Me.nav_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.nav_Home.TabIndex = 5
        Me.nav_Home.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Antic Slab", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(172, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(381, 44)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Integración (Simpson)"
        '
        'btnGraficar
        '
        Me.btnGraficar.BackColor = System.Drawing.Color.Purple
        Me.btnGraficar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGraficar.FlatAppearance.BorderSize = 0
        Me.btnGraficar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficar.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraficar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGraficar.Location = New System.Drawing.Point(68, 253)
        Me.btnGraficar.Name = "btnGraficar"
        Me.btnGraficar.Size = New System.Drawing.Size(293, 34)
        Me.btnGraficar.TabIndex = 151
        Me.btnGraficar.Text = "Graficar"
        Me.btnGraficar.UseVisualStyleBackColor = False
        '
        'grafica
        '
        Me.grafica.BorderSkin.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.grafica.ChartAreas.Add(ChartArea1)
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.Name = "Legend1"
        Me.grafica.Legends.Add(Legend1)
        Me.grafica.Location = New System.Drawing.Point(591, 142)
        Me.grafica.Name = "grafica"
        Me.grafica.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        Series1.BackSecondaryColor = System.Drawing.Color.Purple
        Series1.BorderWidth = 5
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.CustomProperties = "DrawingStyle=Wedge"
        Series1.Font = New System.Drawing.Font("HP Simplified", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsVisibleInLegend = False
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
        Series2.Legend = "Legend1"
        Series2.Name = "Series2"
        Me.grafica.Series.Add(Series1)
        Me.grafica.Series.Add(Series2)
        Me.grafica.Size = New System.Drawing.Size(381, 300)
        Me.grafica.TabIndex = 150
        Me.grafica.Text = "Chart1"
        '
        'Salida
        '
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Salida.Location = New System.Drawing.Point(12, 385)
        Me.Salida.Name = "Salida"
        Me.Salida.Size = New System.Drawing.Size(564, 127)
        Me.Salida.TabIndex = 149
        '
        'Column1
        '
        Me.Column1.HeaderText = "n"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "integral"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "error"
        Me.Column3.Name = "Column3"
        '
        'lbresu
        '
        Me.lbresu.AutoSize = True
        Me.lbresu.Font = New System.Drawing.Font("Advent Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbresu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbresu.Location = New System.Drawing.Point(575, 83)
        Me.lbresu.Name = "lbresu"
        Me.lbresu.Size = New System.Drawing.Size(188, 22)
        Me.lbresu.TabIndex = 148
        Me.lbresu.Text = "Aún no se ha encontrado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Advent Pro Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(451, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 22)
        Me.Label2.TabIndex = 147
        Me.Label2.Text = "RESULTADO = "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(65, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 17)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "a"
        '
        'ta
        '
        Me.ta.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ta.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ta.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ta.Location = New System.Drawing.Point(180, 111)
        Me.ta.Name = "ta"
        Me.ta.Size = New System.Drawing.Size(165, 25)
        Me.ta.TabIndex = 145
        '
        'tb
        '
        Me.tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tb.Location = New System.Drawing.Point(180, 142)
        Me.tb.Name = "tb"
        Me.tb.Size = New System.Drawing.Size(165, 25)
        Me.tb.TabIndex = 144
        '
        'lbTxtDos
        '
        Me.lbTxtDos.AutoSize = True
        Me.lbTxtDos.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTxtDos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbTxtDos.Location = New System.Drawing.Point(65, 145)
        Me.lbTxtDos.Name = "lbTxtDos"
        Me.lbTxtDos.Size = New System.Drawing.Size(15, 17)
        Me.lbTxtDos.TabIndex = 143
        Me.lbTxtDos.Text = "b"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.DarkGray
        Me.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnLimpiar.Location = New System.Drawing.Point(68, 293)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(293, 34)
        Me.BtnLimpiar.TabIndex = 142
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnSalir.Location = New System.Drawing.Point(68, 333)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(293, 34)
        Me.BtnSalir.TabIndex = 141
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCalcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCalcular.FlatAppearance.BorderSize = 0
        Me.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalcular.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnCalcular.Location = New System.Drawing.Point(68, 213)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(293, 34)
        Me.BtnCalcular.TabIndex = 140
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(65, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "Dame la función"
        '
        'tf
        '
        Me.tf.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.tf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tf.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tf.Location = New System.Drawing.Point(180, 80)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(165, 25)
        Me.tf.TabIndex = 136
        '
        'tc
        '
        Me.tc.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.tc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tc.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tc.Location = New System.Drawing.Point(180, 173)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(165, 25)
        Me.tc.TabIndex = 139
        '
        'lc
        '
        Me.lc.AutoSize = True
        Me.lc.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lc.Location = New System.Drawing.Point(65, 176)
        Me.lc.Name = "lc"
        Me.lc.Size = New System.Drawing.Size(75, 17)
        Me.lc.TabIndex = 137
        Me.lc.Text = "Dame cifras"
        '
        'Integracion_Simpson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 541)
        Me.Controls.Add(Me.btnGraficar)
        Me.Controls.Add(Me.grafica)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.lbresu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ta)
        Me.Controls.Add(Me.tb)
        Me.Controls.Add(Me.lbTxtDos)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tf)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.lc)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Integracion_Simpson"
        Me.Text = "Integracion_Simpson"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nav_Home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grafica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents nav_Home As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnGraficar As Button
    Friend WithEvents grafica As DataVisualization.Charting.Chart
    Friend WithEvents Salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents lbresu As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ta As TextBox
    Friend WithEvents tb As TextBox
    Friend WithEvents lbTxtDos As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tf As TextBox
    Friend WithEvents tc As TextBox
    Friend WithEvents lc As Label
End Class
