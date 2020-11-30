<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GaussSeidel
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.nav_Home = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.b3 = New System.Windows.Forms.TextBox()
        Me.a33 = New System.Windows.Forms.TextBox()
        Me.lbraiz = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.a32 = New System.Windows.Forms.TextBox()
        Me.a31 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b2 = New System.Windows.Forms.TextBox()
        Me.a22 = New System.Windows.Forms.TextBox()
        Me.a23 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.a11 = New System.Windows.Forms.TextBox()
        Me.a21 = New System.Windows.Forms.TextBox()
        Me.a12 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.a13 = New System.Windows.Forms.TextBox()
        Me.b1 = New System.Windows.Forms.TextBox()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.lc = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.nav_Home, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label5.Size = New System.Drawing.Size(221, 44)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Gauss Seidel"
        '
        'b3
        '
        Me.b3.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.b3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.b3.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.b3.Location = New System.Drawing.Point(497, 156)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(100, 25)
        Me.b3.TabIndex = 134
        '
        'a33
        '
        Me.a33.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.a33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a33.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a33.ForeColor = System.Drawing.SystemColors.WindowText
        Me.a33.Location = New System.Drawing.Point(359, 156)
        Me.a33.Name = "a33"
        Me.a33.Size = New System.Drawing.Size(100, 25)
        Me.a33.TabIndex = 133
        '
        'lbraiz
        '
        Me.lbraiz.AutoSize = True
        Me.lbraiz.Font = New System.Drawing.Font("Advent Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbraiz.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbraiz.Location = New System.Drawing.Point(746, 93)
        Me.lbraiz.Name = "lbraiz"
        Me.lbraiz.Size = New System.Drawing.Size(188, 22)
        Me.lbraiz.TabIndex = 112
        Me.lbraiz.Text = "Aún no se ha encontrado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Advent Pro Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(465, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 17)
        Me.Label11.TabIndex = 132
        Me.Label11.Text = "z ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Advent Pro Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(637, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 22)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "LA RAÍZ ES: "
        '
        'a32
        '
        Me.a32.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.a32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a32.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a32.ForeColor = System.Drawing.SystemColors.WindowText
        Me.a32.Location = New System.Drawing.Point(216, 156)
        Me.a32.Name = "a32"
        Me.a32.Size = New System.Drawing.Size(100, 25)
        Me.a32.TabIndex = 131
        '
        'a31
        '
        Me.a31.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.a31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a31.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a31.ForeColor = System.Drawing.SystemColors.WindowText
        Me.a31.Location = New System.Drawing.Point(78, 156)
        Me.a31.Name = "a31"
        Me.a31.Size = New System.Drawing.Size(100, 25)
        Me.a31.TabIndex = 130
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Advent Pro Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(322, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 17)
        Me.Label12.TabIndex = 129
        Me.Label12.Text = "y +"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Advent Pro Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(184, 159)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 17)
        Me.Label13.TabIndex = 128
        Me.Label13.Text = "x +"
        '
        'Salida
        '
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.Salida.Location = New System.Drawing.Point(42, 378)
        Me.Salida.Name = "Salida"
        Me.Salida.Size = New System.Drawing.Size(869, 135)
        Me.Salida.TabIndex = 113
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
        'Column4
        '
        Me.Column4.HeaderText = "z"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "ex"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "ey"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "ez"
        Me.Column7.Name = "Column7"
        '
        'b2
        '
        Me.b2.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.b2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.b2.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.b2.Location = New System.Drawing.Point(497, 125)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(100, 25)
        Me.b2.TabIndex = 127
        '
        'a22
        '
        Me.a22.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.a22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a22.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a22.ForeColor = System.Drawing.SystemColors.WindowText
        Me.a22.Location = New System.Drawing.Point(216, 125)
        Me.a22.Name = "a22"
        Me.a22.Size = New System.Drawing.Size(100, 25)
        Me.a22.TabIndex = 124
        '
        'a23
        '
        Me.a23.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.a23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a23.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a23.ForeColor = System.Drawing.SystemColors.WindowText
        Me.a23.Location = New System.Drawing.Point(359, 125)
        Me.a23.Name = "a23"
        Me.a23.Size = New System.Drawing.Size(100, 25)
        Me.a23.TabIndex = 126
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Advent Pro Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(184, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(25, 17)
        Me.Label14.TabIndex = 114
        Me.Label14.Text = "x +"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Advent Pro Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(465, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 17)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "z ="
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Advent Pro Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(322, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 17)
        Me.Label10.TabIndex = 115
        Me.Label10.Text = "y +"
        '
        'a11
        '
        Me.a11.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.a11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a11.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.a11.Location = New System.Drawing.Point(78, 94)
        Me.a11.Name = "a11"
        Me.a11.Size = New System.Drawing.Size(100, 25)
        Me.a11.TabIndex = 116
        '
        'a21
        '
        Me.a21.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.a21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a21.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a21.ForeColor = System.Drawing.SystemColors.WindowText
        Me.a21.Location = New System.Drawing.Point(78, 125)
        Me.a21.Name = "a21"
        Me.a21.Size = New System.Drawing.Size(100, 25)
        Me.a21.TabIndex = 123
        '
        'a12
        '
        Me.a12.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.a12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a12.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a12.ForeColor = System.Drawing.SystemColors.WindowText
        Me.a12.Location = New System.Drawing.Point(216, 94)
        Me.a12.Name = "a12"
        Me.a12.Size = New System.Drawing.Size(100, 25)
        Me.a12.TabIndex = 117
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Advent Pro Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(322, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 17)
        Me.Label8.TabIndex = 122
        Me.Label8.Text = "y +"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Advent Pro Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(465, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 17)
        Me.Label6.TabIndex = 118
        Me.Label6.Text = "z ="
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Advent Pro Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(184, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 17)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "x +"
        '
        'a13
        '
        Me.a13.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.a13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a13.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a13.ForeColor = System.Drawing.SystemColors.WindowText
        Me.a13.Location = New System.Drawing.Point(359, 94)
        Me.a13.Name = "a13"
        Me.a13.Size = New System.Drawing.Size(100, 25)
        Me.a13.TabIndex = 119
        '
        'b1
        '
        Me.b1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.b1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.b1.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.b1.Location = New System.Drawing.Point(497, 94)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(100, 25)
        Me.b1.TabIndex = 120
        '
        'tc
        '
        Me.tc.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.tc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tc.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tc.Location = New System.Drawing.Point(182, 205)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(165, 25)
        Me.tc.TabIndex = 139
        '
        'lc
        '
        Me.lc.AutoSize = True
        Me.lc.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lc.Location = New System.Drawing.Point(101, 208)
        Me.lc.Name = "lc"
        Me.lc.Size = New System.Drawing.Size(75, 17)
        Me.lc.TabIndex = 138
        Me.lc.Text = "Dame cifras"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.DarkGray
        Me.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnLimpiar.Location = New System.Drawing.Point(78, 286)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(293, 34)
        Me.BtnLimpiar.TabIndex = 137
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
        Me.BtnSalir.Location = New System.Drawing.Point(78, 326)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(293, 34)
        Me.BtnSalir.TabIndex = 136
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
        Me.BtnCalcular.Location = New System.Drawing.Point(78, 246)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(293, 34)
        Me.BtnCalcular.TabIndex = 135
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'GaussSeidel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 541)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.lc)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.b3)
        Me.Controls.Add(Me.a33)
        Me.Controls.Add(Me.lbraiz)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.a32)
        Me.Controls.Add(Me.a31)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.a22)
        Me.Controls.Add(Me.a23)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.a11)
        Me.Controls.Add(Me.a21)
        Me.Controls.Add(Me.a12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.a13)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "GaussSeidel"
        Me.Text = "GaussSeidel"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nav_Home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents nav_Home As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents b3 As TextBox
    Friend WithEvents a33 As TextBox
    Friend WithEvents lbraiz As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents a32 As TextBox
    Friend WithEvents a31 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents b2 As TextBox
    Friend WithEvents a22 As TextBox
    Friend WithEvents a23 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents a11 As TextBox
    Friend WithEvents a21 As TextBox
    Friend WithEvents a12 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents a13 As TextBox
    Friend WithEvents b1 As TextBox
    Friend WithEvents tc As TextBox
    Friend WithEvents lc As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCalcular As Button
End Class
