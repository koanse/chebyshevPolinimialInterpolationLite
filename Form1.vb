Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.AllowDrop = True
        DataSet�������������� = XmlSchema12
        NumericUpDown4.Visible = False
        NumericUpDown5.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        CX = 0
        CY = 1
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents XmlSchema11 As ���___��������.XMLSchema1
    Friend WithEvents XmlSchema12 As ���___��������.XMLSchema1
    Friend WithEvents crystalReport11 As ���___��������.CrystalReport1
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents XmlSchema21 As ���___��������.XMLSchema2
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents XmlSchema31 As ���___��������.XMLSchema3
    Friend WithEvents DataGrid3 As System.Windows.Forms.DataGrid
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents XmlSchema41 As ���___��������.XMLSchema4
    Friend WithEvents DataGrid4 As System.Windows.Forms.DataGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.XmlSchema12 = New ���___��������.XMLSchema1
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataSet1 = New System.Data.DataSet
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.XmlSchema21 = New ���___��������.XMLSchema2
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataGrid3 = New System.Windows.Forms.DataGrid
        Me.XmlSchema31 = New ���___��������.XMLSchema3
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.DataGrid4 = New System.Windows.Forms.DataGrid
        Me.XmlSchema41 = New ���___��������.XMLSchema4
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.Label3 = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.XmlSchema12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XmlSchema21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XmlSchema31, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XmlSchema41, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        '
        'XmlSchema12
        '
        Me.XmlSchema12.DataSetName = "XMLSchema1"
        Me.XmlSchema12.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.DataSource = Me.XmlSchema12.���������������
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.PreferredColumnWidth = 155
        Me.DataGrid1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGrid1.RowHeaderWidth = 30
        Me.DataGrid1.Size = New System.Drawing.Size(488, 432)
        Me.DataGrid1.TabIndex = 3
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "������ �� ����� MS Excel"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'DataGrid2
        '
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.DataSource = Me.XmlSchema21.������������_��������_��������
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.PreferredColumnWidth = 155
        Me.DataGrid2.RowHeaderWidth = 30
        Me.DataGrid2.Size = New System.Drawing.Size(488, 312)
        Me.DataGrid2.TabIndex = 4
        '
        'XmlSchema21
        '
        Me.XmlSchema21.DataSetName = "XMLSchema2"
        Me.XmlSchema21.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(512, 512)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.NumericUpDown5)
        Me.TabPage1.Controls.Add(Me.NumericUpDown4)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.DataGrid1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(504, 486)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "������"
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.Location = New System.Drawing.Point(304, 448)
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(48, 20)
        Me.NumericUpDown5.TabIndex = 9
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Location = New System.Drawing.Point(112, 448)
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(48, 20)
        Me.NumericUpDown4.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(200, 448)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "����� ������� Y"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 448)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 16)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "����� ������� X"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.NumericUpDown2)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.DataGrid3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(504, 486)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "���������������� ����������"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(296, 456)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(48, 20)
        Me.NumericUpDown2.TabIndex = 2
        Me.NumericUpDown2.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 456)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "������� ����������������� ����������"
        Me.Label2.Visible = False
        '
        'DataGrid3
        '
        Me.DataGrid3.DataMember = ""
        Me.DataGrid3.DataSource = Me.XmlSchema31.������������_�����������������_����������
        Me.DataGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid3.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid3.Name = "DataGrid3"
        Me.DataGrid3.PreferredColumnWidth = 155
        Me.DataGrid3.RowHeaderWidth = 30
        Me.DataGrid3.Size = New System.Drawing.Size(488, 440)
        Me.DataGrid3.TabIndex = 0
        '
        'XmlSchema31
        '
        Me.XmlSchema31.DataSetName = "XMLSchema3"
        Me.XmlSchema31.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DataGrid4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(504, 486)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "���������� ���������"
        '
        'DataGrid4
        '
        Me.DataGrid4.DataMember = ""
        Me.DataGrid4.DataSource = Me.XmlSchema41.����������_���������
        Me.DataGrid4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid4.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid4.Name = "DataGrid4"
        Me.DataGrid4.PreferredColumnWidth = 155
        Me.DataGrid4.RowHeaderWidth = 30
        Me.DataGrid4.Size = New System.Drawing.Size(488, 464)
        Me.DataGrid4.TabIndex = 0
        '
        'XmlSchema41
        '
        Me.XmlSchema41.DataSetName = "XMLSchema4"
        Me.XmlSchema41.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.NumericUpDown1)
        Me.TabPage2.Controls.Add(Me.DataGrid2)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(504, 486)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "���������� ��������"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(272, 328)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(72, 20)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "0"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(256, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "����������� ��� �������� ��������"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 456)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "������� ��������"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(296, 456)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(48, 20)
        Me.NumericUpDown1.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 352)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 96)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "������������� �������"
        Me.GroupBox2.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(256, 72)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(80, 20)
        Me.TextBox7.TabIndex = 20
        Me.TextBox7.Text = "0"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(184, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 16)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "�����"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(80, 72)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(80, 20)
        Me.TextBox6.TabIndex = 18
        Me.TextBox6.Text = "0"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "�����"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(80, 48)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(80, 20)
        Me.TextBox3.TabIndex = 12
        Me.TextBox3.Text = "0"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(256, 24)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(80, 20)
        Me.TextBox4.TabIndex = 16
        Me.TextBox4.Text = "0"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(184, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "����� s4"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(256, 48)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(80, 20)
        Me.TextBox5.TabIndex = 14
        Me.TextBox5.Text = "0"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(184, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "����� s3"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "����� s2"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(80, 24)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(80, 20)
        Me.TextBox2.TabIndex = 10
        Me.TextBox2.Text = "0"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "����� s1"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem5})
        Me.MenuItem1.Text = "����"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "������� ..."
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 1
        Me.MenuItem5.Text = "�����"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem8})
        Me.MenuItem2.Text = "����������"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 0
        Me.MenuItem8.Text = "��������� ..."
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(256, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "������� ����������"
        Me.Label3.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(16, 16)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(240, 24)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "������ ����������������� ����������"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(536, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 72)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "��� �������"
        Me.GroupBox1.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(16, 40)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(232, 24)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.Text = "������ ���������� ���������"
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(720, 24)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(48, 20)
        Me.NumericUpDown3.TabIndex = 9
        Me.NumericUpDown3.Visible = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(400, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 32)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "������������ ������� ����������������� ����������"
        Me.Label4.Visible = False
        '
        'SaveFileDialog1
        '
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton3)
        Me.GroupBox3.Controls.Add(Me.RadioButton4)
        Me.GroupBox3.Location = New System.Drawing.Point(536, 496)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(264, 72)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "��� ����� � ��������� �������"
        Me.GroupBox3.Visible = False
        '
        'RadioButton3
        '
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Location = New System.Drawing.Point(16, 40)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(232, 24)
        Me.RadioButton3.TabIndex = 8
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "���� XML"
        '
        'RadioButton4
        '
        Me.RadioButton4.Location = New System.Drawing.Point(16, 16)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(240, 24)
        Me.RadioButton4.TabIndex = 7
        Me.RadioButton4.Text = "���� MS Excel"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(152, 456)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "������� �������"
        '
        'Form1
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(776, 603)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumericUpDown3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximumSize = New System.Drawing.Size(784, 630)
        Me.Menu = Me.MainMenu1
        Me.MinimumSize = New System.Drawing.Size(784, 630)
        Me.Name = "Form1"
        Me.Text = "�������� ��������"
        CType(Me.XmlSchema12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XmlSchema21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XmlSchema31, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DataGrid4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XmlSchema41, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub DrawGraph(ByVal DataSet As DataSet, ByVal ��������������������������������� As Boolean, _
    ByVal �������������� As Boolean, ByVal ������������ As Boolean)
        Dim myBrush1 As New System.Drawing.SolidBrush(System.Drawing.Color.AntiqueWhite)
        Dim myBrush2 As New System.Drawing.SolidBrush(System.Drawing.Color.Red)
        Dim myPen As New System.Drawing.Pen(System.Drawing.Color.Green)
        Dim formGraphics As System.Drawing.Graphics
        Dim ������������������� As New Point, ������������������� As New Point
        Dim ����������������� As New Rectangle, ����� As New Rectangle
        Dim ����������� As Integer, ����������� As Integer
        Dim Zmax As Single, Zmin As Single, tmax As Single, tmin As Single
        Dim x As Single, y As Single, Z As Single, t As Single, xprev As Single, yprev As Single
        Dim ��������������������������������� As Integer, ��������������������������� As Integer
        Dim ����������� As Integer, �������� As Single

        Dim drawString As String
        Dim drawFont As New System.Drawing.Font("Arial", 7)
        Dim drawFormat As New System.Drawing.StringFormat

        Dim i As Integer, n As Integer

        If DataSet.Tables.Count <> 0 Then
            n = DataSet.Tables(0).Rows.Count
        Else
            n = 0
        End If

        �������������������.X = 600 : �������������������.Y = 300
        �������������������.X = 700 : �������������������.Y = 400

        �����������������.Location = �������������������
        �����������������.Height = �������������������.Y - �������������������.Y
        �����������������.Width = �������������������.X - �������������������.X
        ����������� = 25

        ����������� = 6
        �����.Height = �����������
        �����.Width = �����������

        formGraphics = Me.CreateGraphics()
        formGraphics.FillRectangle(myBrush1, �������������������.X - �����������, _
        �������������������.Y - �����������, �����������������.Width + 2 * �����������, _
            �����������������.Height + 2 * �����������)

        If ������������ Or n = 0 Then
            drawFont.Dispose()
            myPen.Dispose()
            myBrush1.Dispose()
            myBrush2.Dispose()
            formGraphics.Dispose()
            Exit Sub
        End If

        ' ����� ������ ����������
        If TypeOf (DataSet.Tables(0).Rows(0).Item(CX)) Is DBNull Then tmin = 0 _
            Else tmin = DataSet.Tables(0).Rows(0).Item(CX)
        If TypeOf (DataSet.Tables(0).Rows(0).Item(CX)) Is DBNull Then tmax = 0 _
            Else tmax = DataSet.Tables(0).Rows(0).Item(CX)
        If TypeOf (DataSet.Tables(0).Rows(0).Item(CY)) Is DBNull Then Zmin = 0 _
            Else Zmin = DataSet.Tables(0).Rows(0).Item(CY)
        If TypeOf (DataSet.Tables(0).Rows(0).Item(CY)) Is DBNull Then Zmax = 0 _
            Else Zmax = DataSet.Tables(0).Rows(0).Item(CY)

        For i = 0 To n - 1
            If TypeOf (DataSet.Tables(0).Rows(i).Item(CX)) Is DBNull Then x = 0 _
                Else x = DataSet.Tables(0).Rows(i).Item(CX)
            If TypeOf (DataSet.Tables(0).Rows(i).Item(CY)) Is DBNull Then y = 0 _
                Else y = DataSet.Tables(0).Rows(i).Item(CY)
            If x < tmin Then tmin = x
            If x > tmax Then tmax = x
            If y < Zmin Then Zmin = y
            If y > Zmax Then Zmax = y
        Next i

        If ares Is Nothing = False And ��������������������������������� Then
            For x = �������������������.X To �������������������.X Step 1
                y = 0
                t = 1
                For i = 0 To ���������������������������
                    y = y + ares(���������������������������)(i) * t
                    t = t * ((x - �������������������.X) * (tmax - tmin) / �����������������.Width + tmin)
                Next i
                If y < Zmin Then Zmin = y
                If y > Zmax Then Zmax = y
            Next x
        End If

        '���
        formGraphics.DrawLine(myPen, �������������������.X - 2, �������������������.Y, _
            �������������������.X + 2, �������������������.Y)
        formGraphics.DrawLine(myPen, �������������������.X, �������������������.Y + 2, _
            �������������������.X, �������������������.Y - 2)


        '����� ����
        ��������������������������������� = 20
        ��������������������������� = _
            Int(�����������������.Width / ���������������������������������)
        ����������� = Int((tmax - tmin) / ��������������������������� / _
            10 ^ Int(Math.Log10((tmax - tmin) / ���������������������������)))
        If ����������� <= 1 Then �������� = 1 * _
            10 ^ Int(Math.Log10((tmax - tmin) / ���������������������������))
        If ����������� > 1 And ����������� <= 2 Then �������� = 2 * _
            10 ^ Int(Math.Log10((tmax - tmin) / ���������������������������))
        If ����������� > 2 And ����������� <= 5 Then �������� = 5 * _
            10 ^ Int(Math.Log10((tmax - tmin) / ���������������������������))
        If ����������� > 5 And ����������� < 10 Then �������� = 10 * _
            10 ^ Int(Math.Log10((tmax - tmin) / ���������������������������))
        tmin = (Fix(tmin / ��������) - 1) * ��������
        tmax = (Fix(tmax / ��������) + 1) * ��������
        �������� = �������� / (tmax - tmin) * �����������������.Width

        x = �������������������.X
        While x <= �������������������.X
            formGraphics.DrawLine(myPen, x, �������������������.Y + 3, _
                        x, �������������������.Y - 3)
            x = x + ��������
        End While

        ��������������������������� = _
           Int(�����������������.Height / ���������������������������������)
        ����������� = Int((Zmax - Zmin) / ��������������������������� / _
            10 ^ Int(Math.Log10((Zmax - Zmin) / ���������������������������)))
        If ����������� <= 1 Then �������� = 1 * _
            10 ^ Int(Math.Log10((Zmax - Zmin) / ���������������������������))
        If ����������� > 1 And ����������� <= 2 Then �������� = 2 * _
            10 ^ Int(Math.Log10((Zmax - Zmin) / ���������������������������))
        If ����������� > 2 And ����������� <= 5 Then �������� = 5 * _
            10 ^ Int(Math.Log10((Zmax - Zmin) / ���������������������������))
        If ����������� > 5 And ����������� < 10 Then �������� = 10 * _
            10 ^ Int(Math.Log10((Zmax - Zmin) / ���������������������������))
        Zmin = (Fix(Zmin / ��������) - 1) * ��������
        Zmax = (Fix(Zmax / ��������) + 1) * ��������
        �������� = �������� / (Zmax - Zmin) * �����������������.Height

        y = �������������������.Y
        While y >= �������������������.Y
            formGraphics.DrawLine(myPen, �������������������.X + 3, y, _
                        �������������������.X - 3, y)
            y = y - ��������
        End While


        '�������
        drawString = CStr(Math.Round(tmin, 1))
        formGraphics.DrawString(drawString, drawFont, myBrush2, _
            �������������������.X - 8, �������������������.Y + 3, drawFormat)
        drawString = CStr(Math.Round(tmax, 1))
        formGraphics.DrawString(drawString, drawFont, myBrush2, _
            �������������������.X - 8, �������������������.Y + 3, drawFormat)
        drawString = CStr(Math.Round(Zmin, 1))
        formGraphics.DrawString(drawString, drawFont, myBrush2, _
            �������������������.X - 25, �������������������.Y - 3, drawFormat)
        drawString = CStr(Math.Round(Zmax, 1))
        formGraphics.DrawString(drawString, drawFont, myBrush2, _
            �������������������.X - 25, �������������������.Y, drawFormat)


        ' ��������� �����
        For i = 0 To n - 1
            If TypeOf (DataSet.Tables(0).Rows(i).Item(CX)) Is DBNull Then t = 0 _
                Else t = DataSet.Tables(0).Rows(i).Item(CX)
            If TypeOf (DataSet.Tables(0).Rows(i).Item(CY)) Is DBNull Then Z = 0 _
                Else Z = DataSet.Tables(0).Rows(i).Item(CY)

            x = (t - tmin) / (tmax - tmin) * �����������������.Width + �������������������.X
            y = �������������������.Y - (Z - Zmin) / (Zmax - Zmin) * �����������������.Height
            �����.X = x - ����������� / 2
            �����.Y = y - ����������� / 2
            formGraphics.FillEllipse(myBrush2, �����)
        Next i

        If ares Is Nothing = False And ��������������������������������� Then
            ' ������ ����������������� ����������
            For x = �������������������.X To �������������������.X Step 3
                y = 0
                t = 1
                For i = 0 To ���������������������������
                    y = y + ares(���������������������������)(i) * t
                    t = t * ((x - �������������������.X) * (tmax - tmin) / �����������������.Width + tmin)
                Next i
                y = �������������������.Y - (y - Zmin) / (Zmax - Zmin) * �����������������.Height
                If x > �������������������.X And _
                    y < �������������������.Y + ����������� And _
                    y > �������������������.Y - ����������� And _
                    yprev < �������������������.Y + ����������� And _
                    yprev > �������������������.Y - ����������� Then _
                    formGraphics.DrawLine(myPen, xprev, yprev, x, y)
                xprev = x
                yprev = y
            Next x
        End If
        If �������������� Then
            ' ������ �� ������
            For i = 0 To n - 1
                If TypeOf (DataSet.Tables(0).Rows(i).Item(CX)) Is DBNull Then t = 0 _
                    Else t = DataSet.Tables(0).Rows(i).Item(CX)
                If TypeOf (DataSet.Tables(0).Rows(i).Item(CY)) Is DBNull Then Z = 0 _
                    Else Z = DataSet.Tables(0).Rows(i).Item(CY)

                x = (t - tmin) / (tmax - tmin) * �����������������.Width + �������������������.X
                y = �������������������.Y - (Z - Zmin) / (Zmax - Zmin) * �����������������.Height
                �����.X = x - ����������� / 2
                �����.Y = y - ����������� / 2
                If i > 0 Then formGraphics.DrawLine(myPen, xprev, yprev, x, y)
                xprev = x
                yprev = y
            Next i
        End If

        drawFont.Dispose()
        myPen.Dispose()
        myBrush1.Dispose()
        myBrush2.Dispose()
        formGraphics.Dispose()
    End Sub

    Dim fi()() As Single    ' ������ ��������� ��������
    Dim m As Integer        ' ������������ ������� �������� (���������� ��������� �� ������� ������)
    Dim a() As Single       ' ������ ������������� ��� ��������� ��������
    Dim ares()() As Single  ' ������ ������������� ������� ����������������� ��������
    Dim betta() As Single   ' ������ ������������� �����
    Dim gamma() As Single   ' ������ ������������� �����
    Dim s1() As Single      ' ������
    Dim s2() As Single      ' ������
    Dim s3() As Single      ' ������
    Dim s4() As Single      ' ������
    Dim CX As Integer ' ����� ������� X �������� ������
    Dim CY As Integer ' ����� ������� Y �������� ������
    Dim DataSet�������������� As DataSet    ' �������� ������


    Public xav As Single, yav As Single, xyav As Single
    Public sx As Single, sy As Single, R As Single
    Dim ��������������������������� As Integer
    Dim ����������������������� As Integer
    Dim ���������������� As Integer
    Sub ������������������()
        Dim n As Integer, i As Integer
        If NumericUpDown3.Value = 0 Then Exit Sub
        If DataSet��������������.Tables.Count = 0 Then Exit Sub
        n = DataSet��������������.Tables(0).Rows.Count
        m = NumericUpDown3.Value
        If n <= m Then
            MsgBox("���������� ����� �� ��������� ������������ ������� ����������������� ����������. ���������� ��������� ������� ����������������� ����������. ", _
                       MsgBoxStyle.Information, "�������������� ����������������")
            NumericUpDown3.Value = 0
            m = 0
            Exit Sub
        End If

        ' �������� ������������ ���� ������
        For i = 0 To n - 1
            If Not TypeOf (DataSet��������������.Tables(0).Rows(i).Item(CX)) Is Single And _
                    Not TypeOf (DataSet��������������.Tables(0).Rows(i).Item(CX)) Is Double And _
                    Not TypeOf (DataSet��������������.Tables(0).Rows(i).Item(CX)) Is DBNull Or _
                    TypeOf (DataSet��������������.Tables(0).Rows(i).Item(CX)) Is String Then
                MsgBox("������������ ��� ������ � ������� X (������ " & CStr(i) & ").", MsgBoxStyle.Information, _
                        "�������������� ����������������")
                NumericUpDown3.Value = 0
                m = 0
                Exit Sub
            End If
            If Not TypeOf (DataSet��������������.Tables(0).Rows(i).Item(CY)) Is Single And _
                    Not TypeOf (DataSet��������������.Tables(0).Rows(i).Item(CY)) Is Double And _
                    Not TypeOf (DataSet��������������.Tables(0).Rows(i).Item(CY)) Is DBNull Or _
                    TypeOf (DataSet��������������.Tables(0).Rows(i).Item(CY)) Is String Then
                MsgBox("������������ ��� ������ � ������� Y (������ " & CStr(i) & ").", MsgBoxStyle.Information, _
                        "�������������� ����������������")
                NumericUpDown3.Value = 0
                m = 0
                Exit Sub
            End If
        Next i
        ���������������������������()
        ��������������������������� = 0
        NumericUpDown1.Maximum = m
        NumericUpDown2.Maximum = m
        NumericUpDown1.Value = 0
        NumericUpDown2.Value = 0
        MsgBox("������� ������� ���������", MsgBoxStyle.Information, "�������������� ����������������")
        ����������������()
        Me.Invalidate()
    End Sub
    Sub ���������������������������()
        Dim DataGrid As DataGrid
        Dim i As Integer, j As Integer, k As Integer, n As Integer
        Dim sum As Single, x As Single, y As Single
        Dim sum1 As Single, sum2 As Single

        fi = New Single(m)() {}
        fi(0) = New Single(0) {}
        fi(1) = New Single(1) {}
        a = New Single(m) {}
        ares = New Single(m)() {}
        betta = New Single(m) {}
        gamma = New Single(m) {}
        s1 = New Single(m) {}
        s2 = New Single(m) {}
        s3 = New Single(m) {}
        s4 = New Single(m) {}

        DataGrid = DataGrid1
        n = DataSet��������������.Tables(0).Rows.Count

        ' ������ ��������� ��������
        sum = 0
        For i = 0 To n - 1
            If TypeOf (DataGrid.Item(i, CX)) Is DBNull Then
                sum = sum
            Else
                sum = sum + DataGrid.Item(i, CX)
            End If
        Next i

        fi(0)(0) = 1
        fi(1)(0) = -sum / n : fi(1)(1) = 1

        For i = 2 To m
            s1(i) = 0 : s2(i) = 0 : s3(i) = 0 : s4(i) = 0
            For j = 0 To n - 1
                If TypeOf (DataGrid.Item(j, CX)) Is DBNull Then x = 0 Else x = DataGrid.Item(j, CX)
                s1(i) = s1(i) + x * ����������������(fi(i - 1), i - 1, x) ^ 2
                s2(i) = s2(i) + ����������������(fi(i - 1), i - 1, x) ^ 2
                s3(i) = s3(i) + x * ����������������(fi(i - 2), i - 2, x) * _
                    ����������������(fi(i - 1), i - 1, x)
                s4(i) = s4(i) + ����������������(fi(i - 2), i - 2, x) ^ 2
            Next j
            betta(i) = -s1(i) / s2(i)
            gamma(i) = -s3(i) / s4(i)

            fi(i) = New Single(i) {}
            fi(i)(0) = betta(i) * fi(i - 1)(0) + gamma(i) * fi(i - 2)(0)
            If i > 2 Then
                For j = 1 To i - 2
                    fi(i)(j) = fi(i - 1)(j - 1) + betta(i) * fi(i - 1)(j) + gamma(i) * fi(i - 2)(j)
                Next j
            End If
            fi(i)(i - 1) = fi(i - 1)(i - 2) + betta(i) * fi(i - 1)(i - 1)
            fi(i)(i) = fi(i - 1)(i - 1)
        Next i

        ' ������ ������������� ��� ��������� ��������
        For i = 0 To m
            sum1 = 0 : sum2 = 0
            For j = 0 To n - 1
                If TypeOf (DataGrid.Item(j, CX)) Is DBNull Then x = 0 Else x = DataGrid.Item(j, CX)
                If TypeOf (DataGrid.Item(j, CY)) Is DBNull Then y = 0 Else y = DataGrid.Item(j, CY)

                sum1 = sum1 + y * ����������������(fi(i), i, x)
                sum2 = sum2 + ����������������(fi(i), i, x) ^ 2
            Next j
            a(i) = sum1 / sum2
        Next i

        ' ������ ������������� ����������������� ����������
        For i = 0 To m
            ares(i) = New Single(i) {}
            For j = 0 To i
                sum = 0
                For k = j To i
                    sum = sum + a(k) * fi(k)(j)
                Next k
                ares(i)(j) = sum
            Next j
        Next i

        ' �������� ������ ���������� ���������� ���������
        For i = 1 To m
            If �������������������(i - 1) < �������������������(i) Then
                MsgBox("��� ������� ���������� ��������� ����������� ������ ���������� ������� �� ������� ���������� " & CStr(i) & ".", _
                                MsgBoxStyle.Information, "�������������� ����������������")
                Exit For
            End If
        Next i
    End Sub
    Function �������������������(ByVal �������������������������������� As Integer) As Single
        Dim i As Integer, j As Integer, n As Integer
        Dim sum As Double, x As Single, y As Single, tmp As Double, res As Double
        n = DataSet��������������.Tables.Item(0).Rows.Count
        sum = 0
        res = 0
        For i = 0 To n - 1
            sum = 0
            tmp = 1
            If TypeOf (DataGrid1.Item(i, CX)) Is DBNull Then x = 0 Else x = DataGrid1.Item(i, CX)
            If TypeOf (DataGrid1.Item(i, CY)) Is DBNull Then y = 0 Else y = DataGrid1.Item(i, CY)
            For j = 0 To ��������������������������������
                sum = sum + ares(��������������������������������)(j) * tmp
                tmp = tmp * x
            Next j
            res = res + (sum - y) ^ 2
        Next i
        ������������������� = res / (n - 2)
    End Function
    Sub ���������������������()
        Dim i As Integer, n As Integer
        Dim x2av As Single, y2av As Single
        n = DataSet1.Tables.Item(0).Rows.Count
        xav = 0 : yav = 0 : xyav = 0 : x2av = 0 : y2av = 0
        For i = 0 To n - 1
            xav = xav + DataGrid1.Item(i, CX)
            yav = yav + DataGrid1.Item(i, CY)
            xyav = xyav + DataGrid1.Item(i, CX) * DataGrid1.Item(i, CY)
            x2av = x2av + DataGrid1.Item(i, CX) ^ 2
            y2av = y2av + DataGrid1.Item(i, CY) ^ 2
        Next i
        xav = xav / n : yav = yav / n : xyav = xyav / n : x2av = x2av / n : y2av = y2av / n
        sx = Math.Sqrt((x2av - xav ^ 2) * n / (n - 1))
        sy = Math.Sqrt((y2av - yav ^ 2) * n / (n - 1))
        R = (xyav - xav * yav) / (sx * sy)
    End Sub
    Private Function ����������������(ByVal �������() As Single, ByVal ������� As Integer, _
            ByVal x As Single) As Single
        Dim i As Integer
        Dim sum As Single, tmp As Single
        sum = 0
        tmp = 1
        For i = 0 To �������
            sum = sum + tmp * �������(i)
            tmp = tmp * x
        Next
        ���������������� = sum
    End Function
    Sub ����������������()
        Dim i As Integer
        XmlSchema21.Clear()
        For i = 0 To �����������������������
            XmlSchema21.������������_��������_��������.Add������������_��������_��������Row(i, _
                fi(�����������������������)(i))
        Next i

        TextBox1.Text = a(�����������������������)
        If ����������������������� >= 2 Then
            TextBox2.Text = s1(�����������������������)
            TextBox3.Text = s2(�����������������������)
            TextBox4.Text = s3(�����������������������)
            TextBox5.Text = s4(�����������������������)
            TextBox6.Text = betta(�����������������������)
            TextBox7.Text = gamma(�����������������������)
        Else
            TextBox2.Text = "����������"
            TextBox3.Text = "����������"
            TextBox4.Text = "����������"
            TextBox5.Text = "����������"
            TextBox6.Text = "����������"
            TextBox7.Text = "����������"
        End If


        XmlSchema31.Clear()
        For i = 0 To ���������������������������
            XmlSchema31.������������_�����������������_����������.Add������������_�����������������_����������Row(i, _
                ares(���������������������������)(i))
        Next i


        XmlSchema41.Clear()
        For i = 0 To m
            If i > 0 Then If �������������������(i - 1) <= �������������������(i) Or _
                �������������������(i) <= 0 Or �������������������(i) >= 9999999 Then Exit For
            XmlSchema41.����������_���������.Add����������_���������Row(i, _
                            �������������������(i))
        Next i

    End Sub
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        If m <> 0 Then
            If RadioButton1.Checked = True Then
                DrawGraph(DataSet��������������, True, False, False)
            Else
                CX = 0 : CY = 1
                DrawGraph(XmlSchema41, False, True, False)
                CX = NumericUpDown4.Value
                CY = NumericUpDown5.Value
            End If
        Else
            DrawGraph(DataSet��������������, True, False, True)
        End If

    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        End
    End Sub
    Private Sub OpenFileDialog1_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim sheet As String
        Dim i As Integer, j As Integer
        Dim col As Integer

        XmlSchema21.Clear()
        XmlSchema31.Clear()
        XmlSchema41.Clear()
        NumericUpDown1.Value = 0
        NumericUpDown2.Value = 0
        NumericUpDown3.Value = 0
        NumericUpDown4.Value = 0
        NumericUpDown5.Value = 0
        NumericUpDown1.Maximum = 0
        NumericUpDown2.Maximum = 0

        If RadioButton4.Checked = True Then
            DataSet1.Clear()
            sheet = InputBox("������� ��� �������� �����", "�������������� ���������������")
            MyConnection = New System.Data.OleDb.OleDbConnection( _
                  "provider=Microsoft.Jet.OLEDB.4.0; " & _
                  "data source=" & CStr(OpenFileDialog1.FileName) & "; " & _
                  "Extended Properties=Excel 8.0;")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter( _
                  "select * from [" & CStr(sheet) & "$];", MyConnection)
            MyCommand.Fill(DataSet1)
            MyConnection.Close()
            MyCommand.Dispose()

            col = DataSet1.Tables(0).Columns.Count
            If col > 0 Then
                NumericUpDown4.Maximum = col - 1
                NumericUpDown5.Maximum = col - 1
            End If
        Else
            XmlSchema12.Clear()
            XmlSchema12.ReadXml(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        ����������������������� = NumericUpDown1.Value
        If �������������������(����������������������� - 1) <= �������������������(�����������������������) Then _
            MsgBox("� ����������� �������� ������ ����������.", MsgBoxStyle.Information, "�������������� ����������������")
        ����������������()
    End Sub

    Private Sub NumericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumericUpDown2.ValueChanged
        ��������������������������� = NumericUpDown2.Value
        If �������������������(��������������������������� - 1) <= �������������������(���������������������������) Then _
            MsgBox("� ����������� �������� ������ ����������.", MsgBoxStyle.Information, "�������������� ����������������")
        ����������������()
        Me.Invalidate()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.Invalidate()
    End Sub

    Private Sub NumericUpDown3_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumericUpDown3.ValueChanged
        '������������������()
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("��������� ������������� ��� ��������������� ���������������� ��� ������ ��������� ��������", MsgBoxStyle.Information, "�������������� ����������������")
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        NumericUpDown3.Value = CInt(InputBox("������� ������������ ������� ����������������� ����������", "�������"))
        ������������������()
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ���������������� = 1
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        If ���������������� = 1 And RadioButton4.Checked Then DataSet1.WriteXml(SaveFileDialog1.FileName)
        If ���������������� = 1 And Not RadioButton4.Checked Then XmlSchema12.WriteXml(SaveFileDialog1.FileName)
        If ���������������� = 2 Then XmlSchema21.WriteXml(SaveFileDialog1.FileName)
        If ���������������� = 3 Then XmlSchema31.WriteXml(SaveFileDialog1.FileName)
        If ���������������� = 4 Then XmlSchema41.WriteXml(SaveFileDialog1.FileName)
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ���������������� = 2
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ���������������� = 3
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ���������������� = 4
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            DataSet�������������� = DataSet1
            DataGrid1.DataSource = DataSet1
            NumericUpDown4.Visible = True
            NumericUpDown5.Visible = True
            Label12.Visible = True
            Label13.Visible = True
            CX = NumericUpDown4.Value
            CY = NumericUpDown5.Value

            XmlSchema21.Clear()
            XmlSchema31.Clear()
            XmlSchema41.Clear()
            NumericUpDown1.Value = 0
            NumericUpDown2.Value = 0
            NumericUpDown3.Value = 0
            NumericUpDown1.Maximum = 0
            NumericUpDown2.Maximum = 0
            m = 0
        Else
            DataSet�������������� = XmlSchema12
            DataGrid1.DataSource = XmlSchema12.���������������
            NumericUpDown4.Visible = False
            NumericUpDown5.Visible = False
            Label12.Visible = False
            Label13.Visible = False
            CX = 0
            CY = 1

            XmlSchema21.Clear()
            XmlSchema31.Clear()
            XmlSchema41.Clear()
            NumericUpDown1.Value = 0
            NumericUpDown2.Value = 0
            NumericUpDown3.Value = 0
            NumericUpDown1.Maximum = 0
            NumericUpDown2.Maximum = 0
            m = 0
        End If
    End Sub

    Private Sub NumericUpDown4_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumericUpDown4.ValueChanged
        Dim Cell As System.Windows.Forms.DataGridCell
        CX = NumericUpDown4.Value
        XmlSchema21.Clear()
        XmlSchema31.Clear()
        XmlSchema41.Clear()
        NumericUpDown1.Value = 0
        NumericUpDown2.Value = 0
        NumericUpDown3.Value = 0
        NumericUpDown1.Maximum = 0
        NumericUpDown2.Maximum = 0
        m = 0
        Cell.ColumnNumber = CX
        Cell.RowNumber = 0
        DataGrid1.CurrentCell = Cell
    End Sub

    Private Sub NumericUpDown5_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumericUpDown5.ValueChanged
        Dim Cell As System.Windows.Forms.DataGridCell
        CY = NumericUpDown5.Value
        XmlSchema21.Clear()
        XmlSchema31.Clear()
        XmlSchema41.Clear()
        NumericUpDown1.Value = 0
        NumericUpDown2.Value = 0
        NumericUpDown3.Value = 0
        NumericUpDown1.Maximum = 0
        NumericUpDown2.Maximum = 0
        m = 0
        Cell.ColumnNumber = CY
        Cell.RowNumber = 0
        DataGrid1.CurrentCell = Cell
    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tmp As Integer
        tmp = CInt(InputBox("������� �������", "�������"))
        If tmp >= NumericUpDown2.Minimum And tmp <= NumericUpDown2.Maximum Then _
            NumericUpDown2.Value = tmp
    End Sub
End Class
