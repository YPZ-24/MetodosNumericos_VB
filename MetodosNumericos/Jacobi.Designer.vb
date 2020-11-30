<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jacobi
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
        Me.panel_Biseccion = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.lc = New System.Windows.Forms.Label()
        Me.b3 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.a33 = New System.Windows.Forms.TextBox()
        Me.lbraiz = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.a32 = New System.Windows.Forms.TextBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.a31 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnCalcular = New System.Windows.Forms.Button()
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
        Me.Panel1.SuspendLayout()
        CType(Me.nav_Home, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Biseccion.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label5.Size = New System.Drawing.Size(115, 44)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Jacobi"
        '
        'panel_Biseccion
        '
        Me.panel_Biseccion.BackColor = System.Drawing.Color.White
        Me.panel_Biseccion.Controls.Add(Me.btnSalir)
        Me.panel_Biseccion.Controls.Add(Me.tc)
        Me.panel_Biseccion.Controls.Add(Me.lc)
        Me.panel_Biseccion.Controls.Add(Me.b3)
        Me.panel_Biseccion.Controls.Add(Me.Panel2)
        Me.panel_Biseccion.Controls.Add(Me.a33)
        Me.panel_Biseccion.Controls.Add(Me.lbraiz)
        Me.panel_Biseccion.Controls.Add(Me.Label11)
        Me.panel_Biseccion.Controls.Add(Me.Label2)
        Me.panel_Biseccion.Controls.Add(Me.a32)
        Me.panel_Biseccion.Controls.Add(Me.BtnLimpiar)
        Me.panel_Biseccion.Controls.Add(Me.a31)
        Me.panel_Biseccion.Controls.Add(Me.Label12)
        Me.panel_Biseccion.Controls.Add(Me.BtnCalcular)
        Me.panel_Biseccion.Controls.Add(Me.Label13)
        Me.panel_Biseccion.Controls.Add(Me.Salida)
        Me.panel_Biseccion.Controls.Add(Me.b2)
        Me.panel_Biseccion.Controls.Add(Me.a22)
        Me.panel_Biseccion.Controls.Add(Me.a23)
        Me.panel_Biseccion.Controls.Add(Me.Label14)
        Me.panel_Biseccion.Controls.Add(Me.Label7)
        Me.panel_Biseccion.Controls.Add(Me.Label10)
        Me.panel_Biseccion.Controls.Add(Me.a11)
        Me.panel_Biseccion.Controls.Add(Me.a21)
        Me.panel_Biseccion.Controls.Add(Me.a12)
        Me.panel_Biseccion.Controls.Add(Me.Label8)
        Me.panel_Biseccion.Controls.Add(Me.Label6)
        Me.panel_Biseccion.Controls.Add(Me.Label9)
        Me.panel_Biseccion.Controls.Add(Me.a13)
        Me.panel_Biseccion.Controls.Add(Me.b1)
        Me.panel_Biseccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_Biseccion.Font = New System.Drawing.Font("Advent Pro Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel_Biseccion.Location = New System.Drawing.Point(0, 0)
        Me.panel_Biseccion.Name = "panel_Biseccion"
        Me.panel_Biseccion.Size = New System.Drawing.Size(984, 541)
        Me.panel_Biseccion.TabIndex = 93
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSalir.Location = New System.Drawing.Point(69, 336)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(293, 34)
        Me.btnSalir.TabIndex = 110
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'tc
        '
        Me.tc.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.tc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tc.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tc.Location = New System.Drawing.Point(173, 215)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(165, 25)
        Me.tc.TabIndex = 109
        '
        'lc
        '
        Me.lc.AutoSize = True
        Me.lc.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lc.Location = New System.Drawing.Point(92, 218)
        Me.lc.Name = "lc"
        Me.lc.Size = New System.Drawing.Size(75, 17)
        Me.lc.TabIndex = 108
        Me.lc.Text = "Dame cifras"
        '
        'b3
        '
        Me.b3.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.b3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.b3.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.b3.Location = New System.Drawing.Point(488, 166)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(100, 25)
        Me.b3.TabIndex = 107
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(984, 58)
        Me.Panel2.TabIndex = 88
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MetodosNumericos.My.Resources.Resources.Imagen1__2_
        Me.PictureBox1.Location = New System.Drawing.Point(12, -21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Antic Slab", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(172, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jacobi"
        '
        'a33
        '
        Me.a33.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.a33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a33.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a33.ForeColor = System.Drawing.SystemColors.WindowText
        Me.a33.Location = New System.Drawing.Point(350, 166)
        Me.a33.Name = "a33"
        Me.a33.Size = New System.Drawing.Size(100, 25)
        Me.a33.TabIndex = 106
        '
        'lbraiz
        '
        Me.lbraiz.AutoSize = True
        Me.lbraiz.Font = New System.Drawing.Font("Advent Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbraiz.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbraiz.Location = New System.Drawing.Point(737, 103)
        Me.lbraiz.Name = "lbraiz"
        Me.lbraiz.Size = New System.Drawing.Size(188, 22)
        Me.lbraiz.TabIndex = 78
        Me.lbraiz.Text = "Aún no se ha encontrado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Advent Pro Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(456, 170)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 17)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "z ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Advent Pro Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(628, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 22)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "LA RAÍZ ES: "
        '
        'a32
        '
        Me.a32.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.a32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a32.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a32.ForeColor = System.Drawing.SystemColors.WindowText
        Me.a32.Location = New System.Drawing.Point(207, 166)
        Me.a32.Name = "a32"
        Me.a32.Size = New System.Drawing.Size(100, 25)
        Me.a32.TabIndex = 104
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.DarkGray
        Me.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnLimpiar.Location = New System.Drawing.Point(69, 296)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(293, 34)
        Me.BtnLimpiar.TabIndex = 76
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'a31
        '
        Me.a31.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.a31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a31.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a31.ForeColor = System.Drawing.SystemColors.WindowText
        Me.a31.Location = New System.Drawing.Point(69, 166)
        Me.a31.Name = "a31"
        Me.a31.Size = New System.Drawing.Size(100, 25)
        Me.a31.TabIndex = 103
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Advent Pro Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(313, 169)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 17)
        Me.Label12.TabIndex = 102
        Me.Label12.Text = "y +"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCalcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCalcular.FlatAppearance.BorderSize = 0
        Me.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalcular.Font = New System.Drawing.Font("Advent Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnCalcular.Location = New System.Drawing.Point(69, 256)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(293, 34)
        Me.BtnCalcular.TabIndex = 74
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Advent Pro Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(175, 169)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 17)
        Me.Label13.TabIndex = 101
        Me.Label13.Text = "x +"
        '
        'Salida
        '
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.Salida.Location = New System.Drawing.Point(33, 388)
        Me.Salida.Name = "Salida"
        Me.Salida.Size = New System.Drawing.Size(869, 135)
        Me.Salida.TabIndex = 86
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
        Me.b2.Location = New System.Drawing.Point(488, 135)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(100, 25)
        Me.b2.TabIndex = 100
        '
        'a22
        '
        Me.a22.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.a22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a22.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a22.ForeColor = System.Drawing.SystemColors.WindowText
        Me.a22.Location = New System.Drawing.Point(207, 135)
        Me.a22.Name = "a22"
        Me.a22.Size = New System.Drawing.Size(100, 25)
        Me.a22.TabIndex = 97
        '
        'a23
        '
        Me.a23.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.a23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a23.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a23.ForeColor = System.Drawing.SystemColors.WindowText
        Me.a23.Location = New System.Drawing.Point(350, 135)
        Me.a23.Name = "a23"
        Me.a23.Size = New System.Drawing.Size(100, 25)
        Me.a23.TabIndex = 99
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Advent Pro Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(175, 107)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(25, 17)
        Me.Label14.TabIndex = 87
        Me.Label14.Text = "x +"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Advent Pro Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(456, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 17)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "z ="
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Advent Pro Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(313, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 17)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "y +"
        '
        'a11
        '
        Me.a11.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.a11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a11.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.a11.Location = New System.Drawing.Point(69, 104)
        Me.a11.Name = "a11"
        Me.a11.Size = New System.Drawing.Size(100, 25)
        Me.a11.TabIndex = 89
        '
        'a21
        '
        Me.a21.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.a21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a21.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a21.ForeColor = System.Drawing.SystemColors.WindowText
        Me.a21.Location = New System.Drawing.Point(69, 135)
        Me.a21.Name = "a21"
        Me.a21.Size = New System.Drawing.Size(100, 25)
        Me.a21.TabIndex = 96
        '
        'a12
        '
        Me.a12.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.a12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a12.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a12.ForeColor = System.Drawing.SystemColors.WindowText
        Me.a12.Location = New System.Drawing.Point(207, 104)
        Me.a12.Name = "a12"
        Me.a12.Size = New System.Drawing.Size(100, 25)
        Me.a12.TabIndex = 90
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Advent Pro Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(313, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 17)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "y +"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Advent Pro Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(456, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 17)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "z ="
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Advent Pro Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(175, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 17)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "x +"
        '
        'a13
        '
        Me.a13.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.a13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a13.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a13.ForeColor = System.Drawing.SystemColors.WindowText
        Me.a13.Location = New System.Drawing.Point(350, 104)
        Me.a13.Name = "a13"
        Me.a13.Size = New System.Drawing.Size(100, 25)
        Me.a13.TabIndex = 92
        '
        'b1
        '
        Me.b1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.b1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.b1.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.b1.Location = New System.Drawing.Point(488, 104)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(100, 25)
        Me.b1.TabIndex = 93
        '
        'Jacobi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 541)
        Me.Controls.Add(Me.panel_Biseccion)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Jacobi"
        Me.Text = "Jacobi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nav_Home, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Biseccion.ResumeLayout(False)
        Me.panel_Biseccion.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents nav_Home As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents panel_Biseccion As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbraiz As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents Salida As DataGridView
    Friend WithEvents b3 As TextBox
    Friend WithEvents a33 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents a32 As TextBox
    Friend WithEvents a31 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
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
    Friend WithEvents btnSalir As Button
End Class
