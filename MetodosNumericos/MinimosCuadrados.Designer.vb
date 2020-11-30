<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MinimosCuadrados
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
        Me.lbTxtUno = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.vx = New System.Windows.Forms.TextBox()
        Me.tn = New System.Windows.Forms.TextBox()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.lc = New System.Windows.Forms.Label()
        Me.lbA = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGraficar = New System.Windows.Forms.Button()
        Me.lbVx = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbB = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.graf = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1.SuspendLayout()
        CType(Me.nav_Home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.graf, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 89
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
        Me.Label5.Size = New System.Drawing.Size(343, 44)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Mínimos Cuadrados"
        '
        'lbTxtUno
        '
        Me.lbTxtUno.AutoSize = True
        Me.lbTxtUno.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTxtUno.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbTxtUno.Location = New System.Drawing.Point(83, 113)
        Me.lbTxtUno.Name = "lbTxtUno"
        Me.lbTxtUno.Size = New System.Drawing.Size(108, 17)
        Me.lbTxtUno.TabIndex = 103
        Me.lbTxtUno.Text = "Valor a Interpolar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(83, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "# de Parejas"
        '
        'vx
        '
        Me.vx.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.vx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vx.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vx.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vx.Location = New System.Drawing.Point(198, 110)
        Me.vx.Name = "vx"
        Me.vx.Size = New System.Drawing.Size(165, 25)
        Me.vx.TabIndex = 98
        '
        'tn
        '
        Me.tn.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.tn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tn.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tn.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tn.Location = New System.Drawing.Point(198, 79)
        Me.tn.Name = "tn"
        Me.tn.Size = New System.Drawing.Size(165, 25)
        Me.tn.TabIndex = 96
        '
        'tc
        '
        Me.tc.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.tc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tc.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tc.Location = New System.Drawing.Point(198, 141)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(165, 25)
        Me.tc.TabIndex = 101
        '
        'lc
        '
        Me.lc.AutoSize = True
        Me.lc.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lc.Location = New System.Drawing.Point(83, 144)
        Me.lc.Name = "lc"
        Me.lc.Size = New System.Drawing.Size(75, 17)
        Me.lc.TabIndex = 99
        Me.lc.Text = "Dame cifras"
        '
        'lbA
        '
        Me.lbA.AutoSize = True
        Me.lbA.Font = New System.Drawing.Font("Advent Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbA.Location = New System.Drawing.Point(693, 79)
        Me.lbA.Name = "lbA"
        Me.lbA.Size = New System.Drawing.Size(161, 19)
        Me.lbA.TabIndex = 94
        Me.lbA.Text = "Aún no se ha encontrado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Advent Pro Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(570, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 22)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "a = "
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.DarkGray
        Me.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnLimpiar.Location = New System.Drawing.Point(86, 298)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(293, 34)
        Me.BtnLimpiar.TabIndex = 92
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
        Me.BtnSalir.Location = New System.Drawing.Point(86, 338)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(293, 34)
        Me.BtnSalir.TabIndex = 91
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
        Me.BtnCalcular.Location = New System.Drawing.Point(86, 218)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(293, 34)
        Me.BtnCalcular.TabIndex = 90
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'Salida
        '
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Salida.Location = New System.Drawing.Point(56, 384)
        Me.Salida.Name = "Salida"
        Me.Salida.Size = New System.Drawing.Size(418, 135)
        Me.Salida.TabIndex = 102
        '
        'Column1
        '
        Me.Column1.HeaderText = "Indice"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "x"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "y"
        Me.Column3.Name = "Column3"
        '
        'btnGraficar
        '
        Me.btnGraficar.BackColor = System.Drawing.Color.Purple
        Me.btnGraficar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGraficar.FlatAppearance.BorderSize = 0
        Me.btnGraficar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficar.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraficar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGraficar.Location = New System.Drawing.Point(87, 258)
        Me.btnGraficar.Name = "btnGraficar"
        Me.btnGraficar.Size = New System.Drawing.Size(293, 34)
        Me.btnGraficar.TabIndex = 104
        Me.btnGraficar.Text = "Graficar"
        Me.btnGraficar.UseVisualStyleBackColor = False
        '
        'lbVx
        '
        Me.lbVx.AutoSize = True
        Me.lbVx.Font = New System.Drawing.Font("Advent Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVx.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbVx.Location = New System.Drawing.Point(693, 123)
        Me.lbVx.Name = "lbVx"
        Me.lbVx.Size = New System.Drawing.Size(188, 22)
        Me.lbVx.TabIndex = 106
        Me.lbVx.Text = "Aún no se ha encontrado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Advent Pro Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(570, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 22)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Interpolación"
        '
        'lbB
        '
        Me.lbB.AutoSize = True
        Me.lbB.Font = New System.Drawing.Font("Advent Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbB.Location = New System.Drawing.Point(693, 101)
        Me.lbB.Name = "lbB"
        Me.lbB.Size = New System.Drawing.Size(161, 19)
        Me.lbB.TabIndex = 108
        Me.lbB.Text = "Aún no se ha encontrado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Advent Pro Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(570, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 22)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "b ="
        '
        'graf
        '
        Me.graf.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        Me.graf.BorderlineWidth = 5
        Me.graf.BorderSkin.BorderWidth = 5
        ChartArea1.Name = "ChartArea1"
        Me.graf.ChartAreas.Add(ChartArea1)
        Legend1.Alignment = System.Drawing.StringAlignment.Center
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.Font = New System.Drawing.Font("Advent Pro", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.graf.Legends.Add(Legend1)
        Me.graf.Location = New System.Drawing.Point(497, 160)
        Me.graf.Name = "graf"
        Me.graf.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series1.Legend = "Legend1"
        Series1.MarkerSize = 8
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.Name = "Series2"
        Me.graf.Series.Add(Series1)
        Me.graf.Series.Add(Series2)
        Me.graf.Size = New System.Drawing.Size(475, 359)
        Me.graf.TabIndex = 110
        Me.graf.Text = "Chart1"
        '
        'MinimosCuadrados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 541)
        Me.Controls.Add(Me.graf)
        Me.Controls.Add(Me.lbB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbVx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnGraficar)
        Me.Controls.Add(Me.lbTxtUno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.vx)
        Me.Controls.Add(Me.tn)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.lc)
        Me.Controls.Add(Me.lbA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MinimosCuadrados"
        Me.Text = "MinimosCuadrados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nav_Home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.graf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents nav_Home As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbTxtUno As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents vx As TextBox
    Friend WithEvents tn As TextBox
    Friend WithEvents tc As TextBox
    Friend WithEvents lc As Label
    Friend WithEvents lbA As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents Salida As DataGridView
    Friend WithEvents btnGraficar As Button
    Friend WithEvents lbVx As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbB As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents graf As DataVisualization.Charting.Chart
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
