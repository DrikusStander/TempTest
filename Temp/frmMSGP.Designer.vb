<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMSGP
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.ss1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ssDTRows = New System.Windows.Forms.ToolStripStatusLabel()
		Me.lbtnListVendors = New System.Windows.Forms.LinkLabel()
		Me.lbtnFP = New System.Windows.Forms.LinkLabel()
		Me.txtVendorAcc = New System.Windows.Forms.LinkLabel()
		Me.lbtnPaymentTerms = New System.Windows.Forms.LinkLabel()
		Me.lbtnGetCOA = New System.Windows.Forms.LinkLabel()
		Me.lstTaxSchedules = New System.Windows.Forms.LinkLabel()
		Me.lbtnGetAccounts = New System.Windows.Forms.LinkLabel()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.lbtnActuals = New System.Windows.Forms.LinkLabel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.lstActual = New System.Windows.Forms.LinkLabel()
		Me.txtToID = New System.Windows.Forms.TextBox()
		Me.lbtnLOACheckSum = New System.Windows.Forms.LinkLabel()
		Me.txtFromID = New System.Windows.Forms.TextBox()
		Me.lbtnActualsCheckSum = New System.Windows.Forms.LinkLabel()
		Me.cboBudget = New System.Windows.Forms.ComboBox()
		Me.lbtnSaveToDB = New System.Windows.Forms.LinkLabel()
		Me.lbtnGetBudget = New System.Windows.Forms.LinkLabel()
		Me.txtTableName = New System.Windows.Forms.TextBox()
		Me.lbtnCheckSum = New System.Windows.Forms.LinkLabel()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.cboCompanies = New System.Windows.Forms.ComboBox()
		Me.lbtnVendorCheckSum = New System.Windows.Forms.LinkLabel()
		Me.txtURI = New System.Windows.Forms.TextBox()
		Me.txtMSG = New System.Windows.Forms.TextBox()
		Me.rbtTest = New System.Windows.Forms.RadioButton()
		Me.lbtngetCompanies = New System.Windows.Forms.LinkLabel()
		Me.rbtUAT = New System.Windows.Forms.RadioButton()
		Me.lbtnListBudgets = New System.Windows.Forms.LinkLabel()
		Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
		Me.tabInvoiceProcess = New System.Windows.Forms.TabControl()
		Me.tbMaster = New System.Windows.Forms.TabPage()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.chkRunDataProcs = New System.Windows.Forms.CheckBox()
		Me.chkDropRecreateStagingTables = New System.Windows.Forms.CheckBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.chkFinacialPeriods = New System.Windows.Forms.CheckBox()
		Me.chkPaymentTerms = New System.Windows.Forms.CheckBox()
		Me.chkAccounts = New System.Windows.Forms.CheckBox()
		Me.chkBudgets = New System.Windows.Forms.CheckBox()
		Me.chkActuals = New System.Windows.Forms.CheckBox()
		Me.chkTAX = New System.Windows.Forms.CheckBox()
		Me.chkVendor = New System.Windows.Forms.CheckBox()
		Me.chkBoxSystems = New System.Windows.Forms.CheckedListBox()
		Me.cmdFullMasterLoad = New System.Windows.Forms.Button()
		Me.tbInv = New System.Windows.Forms.TabPage()
		Me.lbtnSendAllInvoices = New System.Windows.Forms.LinkLabel()
		Me.lbtnSendSelectedInvoices = New System.Windows.Forms.LinkLabel()
		Me.lbtnLoadNewInvoives = New System.Windows.Forms.LinkLabel()
		Me.gvwInvoices = New System.Windows.Forms.DataGridView()
		Me.tpMain = New System.Windows.Forms.TabPage()
		Me.txtVendorID = New System.Windows.Forms.TextBox()
		Me.lbtnListAccSegments = New System.Windows.Forms.LinkLabel()
		Me.chkDropTable = New System.Windows.Forms.CheckBox()
		Me.Label34 = New System.Windows.Forms.Label()
		Me.txtTimeOut = New System.Windows.Forms.TextBox()
		Me.tpInvc = New System.Windows.Forms.TabPage()
		Me.lbtnCreateInvoice = New System.Windows.Forms.LinkLabel()
		Me.tbDueDate = New System.Windows.Forms.TextBox()
		Me.tbTaxAM = New System.Windows.Forms.TextBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.txtInvLineTaxAmount = New System.Windows.Forms.TextBox()
		Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
		Me.txtInvLineAmount = New System.Windows.Forms.TextBox()
		Me.txtInvLineAccount = New System.Windows.Forms.TextBox()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.Label26 = New System.Windows.Forms.Label()
		Me.txtInvLnCompanyID = New System.Windows.Forms.TextBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.tbInvoiceScan = New System.Windows.Forms.TextBox()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.tbPOnr = New System.Windows.Forms.TextBox()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.Label21 = New System.Windows.Forms.Label()
		Me.tbDiscountAM = New System.Windows.Forms.TextBox()
		Me.Label22 = New System.Windows.Forms.Label()
		Me.tbTransactionDes = New System.Windows.Forms.TextBox()
		Me.Label23 = New System.Windows.Forms.Label()
		Me.tbChargeAM = New System.Windows.Forms.TextBox()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.tbPurchaseAM = New System.Windows.Forms.TextBox()
		Me.Label25 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.txtTaxScheduleID = New System.Windows.Forms.TextBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.tbPostingDate = New System.Windows.Forms.TextBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.tbDocumentDate = New System.Windows.Forms.TextBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.tbDocumentAM = New System.Windows.Forms.TextBox()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.tbInvoiceNr = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.tbVendorID = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.tbBatchNr = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtCompanyID = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.lbltnSbmtInvc = New System.Windows.Forms.LinkLabel()
		Me.tpVendor = New System.Windows.Forms.TabPage()
		Me.lbtnEditVendor = New System.Windows.Forms.LinkLabel()
		Me.rbEditVendor = New System.Windows.Forms.RadioButton()
		Me.rbCreateVendor = New System.Windows.Forms.RadioButton()
		Me.txtVOnHold = New System.Windows.Forms.ComboBox()
		Me.txtVVendorStatus = New System.Windows.Forms.TextBox()
		Me.Label57 = New System.Windows.Forms.Label()
		Me.txtVVendorName = New System.Windows.Forms.TextBox()
		Me.Label58 = New System.Windows.Forms.Label()
		Me.txtVVendorID = New System.Windows.Forms.TextBox()
		Me.Label59 = New System.Windows.Forms.Label()
		Me.txtVVendorContactName = New System.Windows.Forms.TextBox()
		Me.Label61 = New System.Windows.Forms.Label()
		Me.txtVVendorClass = New System.Windows.Forms.TextBox()
		Me.Label62 = New System.Windows.Forms.Label()
		Me.txtVVendorCheckName = New System.Windows.Forms.TextBox()
		Me.Label51 = New System.Windows.Forms.Label()
		Me.txtVVendorAccNameNr = New System.Windows.Forms.TextBox()
		Me.Label52 = New System.Windows.Forms.Label()
		Me.txtVVATNr = New System.Windows.Forms.TextBox()
		Me.Label53 = New System.Windows.Forms.Label()
		Me.txtVUseCustomPayeeRef = New System.Windows.Forms.TextBox()
		Me.Label55 = New System.Windows.Forms.Label()
		Me.txtVUseCustomCompanyRef = New System.Windows.Forms.TextBox()
		Me.Label56 = New System.Windows.Forms.Label()
		Me.txtVPostalCode = New System.Windows.Forms.TextBox()
		Me.Label45 = New System.Windows.Forms.Label()
		Me.txtVPostalCity = New System.Windows.Forms.TextBox()
		Me.Label46 = New System.Windows.Forms.Label()
		Me.txtVPostalAddr2 = New System.Windows.Forms.TextBox()
		Me.Label47 = New System.Windows.Forms.Label()
		Me.txtVPostalAddr1 = New System.Windows.Forms.TextBox()
		Me.Label48 = New System.Windows.Forms.Label()
		Me.txtVPysicalPostalCode = New System.Windows.Forms.TextBox()
		Me.Label49 = New System.Windows.Forms.Label()
		Me.txtVPysicalCity = New System.Windows.Forms.TextBox()
		Me.Label50 = New System.Windows.Forms.Label()
		Me.txtVPysicalAddr2 = New System.Windows.Forms.TextBox()
		Me.Label39 = New System.Windows.Forms.Label()
		Me.txtVPysicalAddr1 = New System.Windows.Forms.TextBox()
		Me.Label40 = New System.Windows.Forms.Label()
		Me.txtVPaymentTerm = New System.Windows.Forms.TextBox()
		Me.Label41 = New System.Windows.Forms.Label()
		Me.txtVPayeeRef = New System.Windows.Forms.TextBox()
		Me.Label42 = New System.Windows.Forms.Label()
		Me.Label43 = New System.Windows.Forms.Label()
		Me.txtVTel3 = New System.Windows.Forms.TextBox()
		Me.Label44 = New System.Windows.Forms.Label()
		Me.txtVTel2 = New System.Windows.Forms.TextBox()
		Me.Label35 = New System.Windows.Forms.Label()
		Me.txtVTel = New System.Windows.Forms.TextBox()
		Me.Label36 = New System.Windows.Forms.Label()
		Me.txtVFaxNr = New System.Windows.Forms.TextBox()
		Me.Label37 = New System.Windows.Forms.Label()
		Me.txtVEmail = New System.Windows.Forms.TextBox()
		Me.Label38 = New System.Windows.Forms.Label()
		Me.txtVCompanyRegNr = New System.Windows.Forms.TextBox()
		Me.Label33 = New System.Windows.Forms.Label()
		Me.txtVCompanyRef = New System.Windows.Forms.TextBox()
		Me.Label32 = New System.Windows.Forms.Label()
		Me.txtVBrancCode = New System.Windows.Forms.TextBox()
		Me.Label31 = New System.Windows.Forms.Label()
		Me.txtVBankName = New System.Windows.Forms.TextBox()
		Me.Label30 = New System.Windows.Forms.Label()
		Me.txtVAccNr = New System.Windows.Forms.TextBox()
		Me.Label29 = New System.Windows.Forms.Label()
		Me.txtVAccName = New System.Windows.Forms.TextBox()
		Me.Label28 = New System.Windows.Forms.Label()
		Me.txtVCompanyID = New System.Windows.Forms.TextBox()
		Me.Label27 = New System.Windows.Forms.Label()
		Me.lbltnCreateVendor = New System.Windows.Forms.LinkLabel()
		Me.tpVendorMasterIntegration = New System.Windows.Forms.TabPage()
		Me.lbtnDisplayDiff = New System.Windows.Forms.LinkLabel()
		Me.tbVendorID_Integration = New System.Windows.Forms.TextBox()
		Me.lbtnSearchSysLink = New System.Windows.Forms.LinkLabel()
		Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
		Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
		Me.gvwMain = New System.Windows.Forms.DataGridView()
		Me.Panel1.SuspendLayout()
		Me.StatusStrip1.SuspendLayout()
		CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tabInvoiceProcess.SuspendLayout()
		Me.tbMaster.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.tbInv.SuspendLayout()
		CType(Me.gvwInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tpMain.SuspendLayout()
		Me.tpInvc.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.tpVendor.SuspendLayout()
		Me.tpVendorMasterIntegration.SuspendLayout()
		CType(Me.gvwMain, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.White
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(901, 48)
		Me.Panel1.TabIndex = 13
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
		Me.Label2.Location = New System.Drawing.Point(54, 26)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(168, 15)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "This form is for administrators"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(14, 4)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(180, 17)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "Microsoft GP Web Services"
		'
		'StatusStrip1
		'
		Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ss1, Me.ssDTRows})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 522)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 14, 0)
		Me.StatusStrip1.Size = New System.Drawing.Size(901, 28)
		Me.StatusStrip1.TabIndex = 20
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'ss1
		'
		Me.ss1.AutoSize = False
		Me.ss1.Name = "ss1"
		Me.ss1.Size = New System.Drawing.Size(200, 23)
		Me.ss1.Text = "Msg"
		'
		'ssDTRows
		'
		Me.ssDTRows.AutoSize = False
		Me.ssDTRows.Name = "ssDTRows"
		Me.ssDTRows.Size = New System.Drawing.Size(200, 23)
		Me.ssDTRows.Text = "Rows..."
		'
		'lbtnListVendors
		'
		Me.lbtnListVendors.AutoSize = True
		Me.lbtnListVendors.Location = New System.Drawing.Point(17, 257)
		Me.lbtnListVendors.Name = "lbtnListVendors"
		Me.lbtnListVendors.Size = New System.Drawing.Size(65, 13)
		Me.lbtnListVendors.TabIndex = 31
		Me.lbtnListVendors.TabStop = True
		Me.lbtnListVendors.Text = "List Vendors"
		'
		'lbtnFP
		'
		Me.lbtnFP.AutoSize = True
		Me.lbtnFP.Location = New System.Drawing.Point(14, 180)
		Me.lbtnFP.Name = "lbtnFP"
		Me.lbtnFP.Size = New System.Drawing.Size(100, 13)
		Me.lbtnFP.TabIndex = 30
		Me.lbtnFP.TabStop = True
		Me.lbtnFP.Text = "List Fiancial Periods"
		'
		'txtVendorAcc
		'
		Me.txtVendorAcc.AutoSize = True
		Me.txtVendorAcc.Location = New System.Drawing.Point(195, 285)
		Me.txtVendorAcc.Name = "txtVendorAcc"
		Me.txtVendorAcc.Size = New System.Drawing.Size(111, 13)
		Me.txtVendorAcc.TabIndex = 32
		Me.txtVendorAcc.TabStop = True
		Me.txtVendorAcc.Text = "Get Specific Vendor..."
		'
		'lbtnPaymentTerms
		'
		Me.lbtnPaymentTerms.AutoSize = True
		Me.lbtnPaymentTerms.Location = New System.Drawing.Point(14, 156)
		Me.lbtnPaymentTerms.Name = "lbtnPaymentTerms"
		Me.lbtnPaymentTerms.Size = New System.Drawing.Size(99, 13)
		Me.lbtnPaymentTerms.TabIndex = 29
		Me.lbtnPaymentTerms.TabStop = True
		Me.lbtnPaymentTerms.Text = "List Payment Terms"
		'
		'lbtnGetCOA
		'
		Me.lbtnGetCOA.AutoSize = True
		Me.lbtnGetCOA.Location = New System.Drawing.Point(14, 204)
		Me.lbtnGetCOA.Name = "lbtnGetCOA"
		Me.lbtnGetCOA.Size = New System.Drawing.Size(83, 13)
		Me.lbtnGetCOA.TabIndex = 33
		Me.lbtnGetCOA.TabStop = True
		Me.lbtnGetCOA.Text = "List of Accounts"
		'
		'lstTaxSchedules
		'
		Me.lstTaxSchedules.AutoSize = True
		Me.lstTaxSchedules.Location = New System.Drawing.Point(14, 134)
		Me.lstTaxSchedules.Name = "lstTaxSchedules"
		Me.lstTaxSchedules.Size = New System.Drawing.Size(97, 13)
		Me.lstTaxSchedules.TabIndex = 28
		Me.lstTaxSchedules.TabStop = True
		Me.lstTaxSchedules.Text = "List Tax Schedules"
		'
		'lbtnGetAccounts
		'
		Me.lbtnGetAccounts.AutoSize = True
		Me.lbtnGetAccounts.Location = New System.Drawing.Point(127, 204)
		Me.lbtnGetAccounts.Name = "lbtnGetAccounts"
		Me.lbtnGetAccounts.Size = New System.Drawing.Size(81, 13)
		Me.lbtnGetAccounts.TabIndex = 34
		Me.lbtnGetAccounts.TabStop = True
		Me.lbtnGetAccounts.Text = "List Account ... "
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(673, 180)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(16, 13)
		Me.Label4.TabIndex = 27
		Me.Label4.Text = "to"
		'
		'lbtnActuals
		'
		Me.lbtnActuals.AutoSize = True
		Me.lbtnActuals.Location = New System.Drawing.Point(14, 106)
		Me.lbtnActuals.Name = "lbtnActuals"
		Me.lbtnActuals.Size = New System.Drawing.Size(73, 13)
		Me.lbtnActuals.TabIndex = 35
		Me.lbtnActuals.TabStop = True
		Me.lbtnActuals.Text = "List of Actuals"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(565, 180)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(30, 13)
		Me.Label3.TabIndex = 26
		Me.Label3.Text = "From"
		'
		'lstActual
		'
		Me.lstActual.AutoSize = True
		Me.lstActual.Location = New System.Drawing.Point(130, 107)
		Me.lstActual.Name = "lstActual"
		Me.lstActual.Size = New System.Drawing.Size(71, 13)
		Me.lstActual.TabIndex = 36
		Me.lstActual.TabStop = True
		Me.lstActual.Text = "List Actual ... "
		'
		'txtToID
		'
		Me.txtToID.Location = New System.Drawing.Point(705, 176)
		Me.txtToID.Name = "txtToID"
		Me.txtToID.Size = New System.Drawing.Size(62, 20)
		Me.txtToID.TabIndex = 25
		Me.txtToID.Text = "1000"
		'
		'lbtnLOACheckSum
		'
		Me.lbtnLOACheckSum.AutoSize = True
		Me.lbtnLOACheckSum.Location = New System.Drawing.Point(242, 204)
		Me.lbtnLOACheckSum.Name = "lbtnLOACheckSum"
		Me.lbtnLOACheckSum.Size = New System.Drawing.Size(124, 13)
		Me.lbtnLOACheckSum.TabIndex = 37
		Me.lbtnLOACheckSum.TabStop = True
		Me.lbtnLOACheckSum.Text = "List Account Check Sum"
		'
		'txtFromID
		'
		Me.txtFromID.Location = New System.Drawing.Point(601, 176)
		Me.txtFromID.Name = "txtFromID"
		Me.txtFromID.Size = New System.Drawing.Size(62, 20)
		Me.txtFromID.TabIndex = 24
		Me.txtFromID.Text = "1"
		'
		'lbtnActualsCheckSum
		'
		Me.lbtnActualsCheckSum.AutoSize = True
		Me.lbtnActualsCheckSum.Location = New System.Drawing.Point(245, 107)
		Me.lbtnActualsCheckSum.Name = "lbtnActualsCheckSum"
		Me.lbtnActualsCheckSum.Size = New System.Drawing.Size(119, 13)
		Me.lbtnActualsCheckSum.TabIndex = 38
		Me.lbtnActualsCheckSum.TabStop = True
		Me.lbtnActualsCheckSum.Text = "List Actuals Check Sum"
		'
		'cboBudget
		'
		Me.cboBudget.FormattingEnabled = True
		Me.cboBudget.Location = New System.Drawing.Point(116, 49)
		Me.cboBudget.Name = "cboBudget"
		Me.cboBudget.Size = New System.Drawing.Size(154, 21)
		Me.cboBudget.TabIndex = 22
		'
		'lbtnSaveToDB
		'
		Me.lbtnSaveToDB.AutoSize = True
		Me.lbtnSaveToDB.Location = New System.Drawing.Point(746, 116)
		Me.lbtnSaveToDB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lbtnSaveToDB.Name = "lbtnSaveToDB"
		Me.lbtnSaveToDB.Size = New System.Drawing.Size(66, 13)
		Me.lbtnSaveToDB.TabIndex = 39
		Me.lbtnSaveToDB.TabStop = True
		Me.lbtnSaveToDB.Text = "Save To DB"
		'
		'lbtnGetBudget
		'
		Me.lbtnGetBudget.AutoSize = True
		Me.lbtnGetBudget.Location = New System.Drawing.Point(14, 52)
		Me.lbtnGetBudget.Name = "lbtnGetBudget"
		Me.lbtnGetBudget.Size = New System.Drawing.Size(65, 13)
		Me.lbtnGetBudget.TabIndex = 21
		Me.lbtnGetBudget.TabStop = True
		Me.lbtnGetBudget.Text = "List Budgets"
		'
		'txtTableName
		'
		Me.txtTableName.Location = New System.Drawing.Point(505, 113)
		Me.txtTableName.Margin = New System.Windows.Forms.Padding(2)
		Me.txtTableName.Name = "txtTableName"
		Me.txtTableName.Size = New System.Drawing.Size(130, 20)
		Me.txtTableName.TabIndex = 40
		Me.txtTableName.Text = "zzz_GP_Staging"
		'
		'lbtnCheckSum
		'
		Me.lbtnCheckSum.AutoSize = True
		Me.lbtnCheckSum.Location = New System.Drawing.Point(678, 134)
		Me.lbtnCheckSum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lbtnCheckSum.Name = "lbtnCheckSum"
		Me.lbtnCheckSum.Size = New System.Drawing.Size(62, 13)
		Me.lbtnCheckSum.TabIndex = 41
		Me.lbtnCheckSum.TabStop = True
		Me.lbtnCheckSum.Text = "Check Sum"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(620, 155)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(122, 13)
		Me.Label5.TabIndex = 42
		Me.Label5.Text = "Limits (where applicable)"
		'
		'cboCompanies
		'
		Me.cboCompanies.FormattingEnabled = True
		Me.cboCompanies.Location = New System.Drawing.Point(116, 21)
		Me.cboCompanies.Name = "cboCompanies"
		Me.cboCompanies.Size = New System.Drawing.Size(154, 21)
		Me.cboCompanies.TabIndex = 17
		'
		'lbtnVendorCheckSum
		'
		Me.lbtnVendorCheckSum.AutoSize = True
		Me.lbtnVendorCheckSum.Location = New System.Drawing.Point(247, 257)
		Me.lbtnVendorCheckSum.Name = "lbtnVendorCheckSum"
		Me.lbtnVendorCheckSum.Size = New System.Drawing.Size(123, 13)
		Me.lbtnVendorCheckSum.TabIndex = 43
		Me.lbtnVendorCheckSum.TabStop = True
		Me.lbtnVendorCheckSum.Text = "List Vendors Check Sum"
		'
		'txtURI
		'
		Me.txtURI.Location = New System.Drawing.Point(505, 77)
		Me.txtURI.Margin = New System.Windows.Forms.Padding(2)
		Me.txtURI.Name = "txtURI"
		Me.txtURI.Size = New System.Drawing.Size(338, 20)
		Me.txtURI.TabIndex = 44
		'
		'txtMSG
		'
		Me.txtMSG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtMSG.Location = New System.Drawing.Point(4, 466)
		Me.txtMSG.MinimumSize = New System.Drawing.Size(68, 18)
		Me.txtMSG.Multiline = True
		Me.txtMSG.Name = "txtMSG"
		Me.txtMSG.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.txtMSG.Size = New System.Drawing.Size(859, 54)
		Me.txtMSG.TabIndex = 15
		Me.txtMSG.WordWrap = False
		'
		'rbtTest
		'
		Me.rbtTest.AutoSize = True
		Me.rbtTest.Location = New System.Drawing.Point(579, 50)
		Me.rbtTest.Margin = New System.Windows.Forms.Padding(2)
		Me.rbtTest.Name = "rbtTest"
		Me.rbtTest.Size = New System.Drawing.Size(46, 17)
		Me.rbtTest.TabIndex = 45
		Me.rbtTest.TabStop = True
		Me.rbtTest.Text = "Test"
		Me.rbtTest.UseVisualStyleBackColor = True
		'
		'lbtngetCompanies
		'
		Me.lbtngetCompanies.AutoSize = True
		Me.lbtngetCompanies.Location = New System.Drawing.Point(14, 24)
		Me.lbtngetCompanies.Name = "lbtngetCompanies"
		Me.lbtngetCompanies.Size = New System.Drawing.Size(78, 13)
		Me.lbtngetCompanies.TabIndex = 14
		Me.lbtngetCompanies.TabStop = True
		Me.lbtngetCompanies.Text = "List Companies"
		'
		'rbtUAT
		'
		Me.rbtUAT.AutoSize = True
		Me.rbtUAT.Location = New System.Drawing.Point(644, 50)
		Me.rbtUAT.Margin = New System.Windows.Forms.Padding(2)
		Me.rbtUAT.Name = "rbtUAT"
		Me.rbtUAT.Size = New System.Drawing.Size(47, 17)
		Me.rbtUAT.TabIndex = 46
		Me.rbtUAT.TabStop = True
		Me.rbtUAT.Text = "UAT"
		Me.rbtUAT.UseVisualStyleBackColor = True
		'
		'lbtnListBudgets
		'
		Me.lbtnListBudgets.AutoSize = True
		Me.lbtnListBudgets.Location = New System.Drawing.Point(14, 80)
		Me.lbtnListBudgets.Name = "lbtnListBudgets"
		Me.lbtnListBudgets.Size = New System.Drawing.Size(100, 13)
		Me.lbtnListBudgets.TabIndex = 23
		Me.lbtnListBudgets.TabStop = True
		Me.lbtnListBudgets.Text = "List Budgets Details"
		'
		'tabInvoiceProcess
		'
		Me.tabInvoiceProcess.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tabInvoiceProcess.Controls.Add(Me.tbMaster)
		Me.tabInvoiceProcess.Controls.Add(Me.tbInv)
		Me.tabInvoiceProcess.Controls.Add(Me.tpMain)
		Me.tabInvoiceProcess.Controls.Add(Me.tpInvc)
		Me.tabInvoiceProcess.Controls.Add(Me.tpVendor)
		Me.tabInvoiceProcess.Controls.Add(Me.tpVendorMasterIntegration)
		Me.tabInvoiceProcess.Location = New System.Drawing.Point(5, 52)
		Me.tabInvoiceProcess.Margin = New System.Windows.Forms.Padding(2)
		Me.tabInvoiceProcess.MaximumSize = New System.Drawing.Size(2000, 2000)
		Me.tabInvoiceProcess.Name = "tabInvoiceProcess"
		Me.tabInvoiceProcess.SelectedIndex = 0
		Me.tabInvoiceProcess.Size = New System.Drawing.Size(859, 343)
		Me.tabInvoiceProcess.TabIndex = 47
		'
		'tbMaster
		'
		Me.tbMaster.Controls.Add(Me.GroupBox3)
		Me.tbMaster.Controls.Add(Me.GroupBox2)
		Me.tbMaster.Controls.Add(Me.chkBoxSystems)
		Me.tbMaster.Controls.Add(Me.cmdFullMasterLoad)
		Me.tbMaster.Location = New System.Drawing.Point(4, 22)
		Me.tbMaster.Name = "tbMaster"
		Me.tbMaster.Size = New System.Drawing.Size(851, 317)
		Me.tbMaster.TabIndex = 4
		Me.tbMaster.Text = "Master Data Load "
		Me.tbMaster.UseVisualStyleBackColor = True
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.chkRunDataProcs)
		Me.GroupBox3.Controls.Add(Me.chkDropRecreateStagingTables)
		Me.GroupBox3.Location = New System.Drawing.Point(313, 15)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(228, 185)
		Me.GroupBox3.TabIndex = 4
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Load"
		'
		'chkRunDataProcs
		'
		Me.chkRunDataProcs.AutoSize = True
		Me.chkRunDataProcs.Location = New System.Drawing.Point(18, 42)
		Me.chkRunDataProcs.Name = "chkRunDataProcs"
		Me.chkRunDataProcs.Size = New System.Drawing.Size(179, 17)
		Me.chkRunDataProcs.TabIndex = 1
		Me.chkRunDataProcs.Text = "Move staging data to production"
		Me.chkRunDataProcs.UseVisualStyleBackColor = True
		'
		'chkDropRecreateStagingTables
		'
		Me.chkDropRecreateStagingTables.AutoSize = True
		Me.chkDropRecreateStagingTables.Checked = True
		Me.chkDropRecreateStagingTables.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkDropRecreateStagingTables.Location = New System.Drawing.Point(18, 19)
		Me.chkDropRecreateStagingTables.Name = "chkDropRecreateStagingTables"
		Me.chkDropRecreateStagingTables.Size = New System.Drawing.Size(170, 17)
		Me.chkDropRecreateStagingTables.TabIndex = 0
		Me.chkDropRecreateStagingTables.Text = "Drop Recreate Staging Tables"
		Me.chkDropRecreateStagingTables.UseVisualStyleBackColor = True
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.chkFinacialPeriods)
		Me.GroupBox2.Controls.Add(Me.chkPaymentTerms)
		Me.GroupBox2.Controls.Add(Me.chkAccounts)
		Me.GroupBox2.Controls.Add(Me.chkBudgets)
		Me.GroupBox2.Controls.Add(Me.chkActuals)
		Me.GroupBox2.Controls.Add(Me.chkTAX)
		Me.GroupBox2.Controls.Add(Me.chkVendor)
		Me.GroupBox2.Location = New System.Drawing.Point(148, 15)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(147, 185)
		Me.GroupBox2.TabIndex = 3
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Options"
		'
		'chkFinacialPeriods
		'
		Me.chkFinacialPeriods.AutoSize = True
		Me.chkFinacialPeriods.Checked = True
		Me.chkFinacialPeriods.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkFinacialPeriods.Location = New System.Drawing.Point(20, 89)
		Me.chkFinacialPeriods.Name = "chkFinacialPeriods"
		Me.chkFinacialPeriods.Size = New System.Drawing.Size(106, 17)
		Me.chkFinacialPeriods.TabIndex = 8
		Me.chkFinacialPeriods.Text = "Financial Periods"
		Me.chkFinacialPeriods.UseVisualStyleBackColor = True
		'
		'chkPaymentTerms
		'
		Me.chkPaymentTerms.AutoSize = True
		Me.chkPaymentTerms.Checked = True
		Me.chkPaymentTerms.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkPaymentTerms.Location = New System.Drawing.Point(20, 71)
		Me.chkPaymentTerms.Name = "chkPaymentTerms"
		Me.chkPaymentTerms.Size = New System.Drawing.Size(99, 17)
		Me.chkPaymentTerms.TabIndex = 7
		Me.chkPaymentTerms.Text = "Payment Terms"
		Me.chkPaymentTerms.UseVisualStyleBackColor = True
		'
		'chkAccounts
		'
		Me.chkAccounts.AutoSize = True
		Me.chkAccounts.Checked = True
		Me.chkAccounts.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkAccounts.Location = New System.Drawing.Point(20, 107)
		Me.chkAccounts.Name = "chkAccounts"
		Me.chkAccounts.Size = New System.Drawing.Size(71, 17)
		Me.chkAccounts.TabIndex = 6
		Me.chkAccounts.Text = "Accounts"
		Me.chkAccounts.UseVisualStyleBackColor = True
		'
		'chkBudgets
		'
		Me.chkBudgets.AutoSize = True
		Me.chkBudgets.Checked = True
		Me.chkBudgets.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkBudgets.Location = New System.Drawing.Point(20, 37)
		Me.chkBudgets.Name = "chkBudgets"
		Me.chkBudgets.Size = New System.Drawing.Size(65, 17)
		Me.chkBudgets.TabIndex = 5
		Me.chkBudgets.Text = "Budgets"
		Me.chkBudgets.UseVisualStyleBackColor = True
		'
		'chkActuals
		'
		Me.chkActuals.AutoSize = True
		Me.chkActuals.Checked = True
		Me.chkActuals.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkActuals.Location = New System.Drawing.Point(20, 124)
		Me.chkActuals.Name = "chkActuals"
		Me.chkActuals.Size = New System.Drawing.Size(61, 17)
		Me.chkActuals.TabIndex = 4
		Me.chkActuals.Text = "Actuals"
		Me.chkActuals.UseVisualStyleBackColor = True
		'
		'chkTAX
		'
		Me.chkTAX.AutoSize = True
		Me.chkTAX.Checked = True
		Me.chkTAX.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkTAX.Location = New System.Drawing.Point(20, 54)
		Me.chkTAX.Name = "chkTAX"
		Me.chkTAX.Size = New System.Drawing.Size(100, 17)
		Me.chkTAX.TabIndex = 3
		Me.chkTAX.Text = "TAX Schedules"
		Me.chkTAX.UseVisualStyleBackColor = True
		'
		'chkVendor
		'
		Me.chkVendor.AutoSize = True
		Me.chkVendor.Location = New System.Drawing.Point(20, 19)
		Me.chkVendor.Name = "chkVendor"
		Me.chkVendor.Size = New System.Drawing.Size(65, 17)
		Me.chkVendor.TabIndex = 2
		Me.chkVendor.Text = "Vendors"
		Me.chkVendor.UseVisualStyleBackColor = True
		'
		'chkBoxSystems
		'
		Me.chkBoxSystems.FormattingEnabled = True
		Me.chkBoxSystems.Items.AddRange(New Object() {"THIC", "HLAC"})
		Me.chkBoxSystems.Location = New System.Drawing.Point(30, 15)
		Me.chkBoxSystems.Name = "chkBoxSystems"
		Me.chkBoxSystems.Size = New System.Drawing.Size(98, 184)
		Me.chkBoxSystems.TabIndex = 1
		'
		'cmdFullMasterLoad
		'
		Me.cmdFullMasterLoad.Location = New System.Drawing.Point(689, 15)
		Me.cmdFullMasterLoad.Name = "cmdFullMasterLoad"
		Me.cmdFullMasterLoad.Size = New System.Drawing.Size(127, 26)
		Me.cmdFullMasterLoad.TabIndex = 0
		Me.cmdFullMasterLoad.Text = "Run Master Data Load"
		Me.cmdFullMasterLoad.UseVisualStyleBackColor = True
		'
		'tbInv
		'
		Me.tbInv.Controls.Add(Me.lbtnSendAllInvoices)
		Me.tbInv.Controls.Add(Me.lbtnSendSelectedInvoices)
		Me.tbInv.Controls.Add(Me.lbtnLoadNewInvoives)
		Me.tbInv.Controls.Add(Me.gvwInvoices)
		Me.tbInv.Location = New System.Drawing.Point(4, 22)
		Me.tbInv.Name = "tbInv"
		Me.tbInv.Padding = New System.Windows.Forms.Padding(3)
		Me.tbInv.Size = New System.Drawing.Size(851, 317)
		Me.tbInv.TabIndex = 3
		Me.tbInv.Text = "Transction Integration"
		Me.tbInv.UseVisualStyleBackColor = True
		'
		'lbtnSendAllInvoices
		'
		Me.lbtnSendAllInvoices.AutoSize = True
		Me.lbtnSendAllInvoices.Location = New System.Drawing.Point(272, 206)
		Me.lbtnSendAllInvoices.Name = "lbtnSendAllInvoices"
		Me.lbtnSendAllInvoices.Size = New System.Drawing.Size(89, 13)
		Me.lbtnSendAllInvoices.TabIndex = 3
		Me.lbtnSendAllInvoices.TabStop = True
		Me.lbtnSendAllInvoices.Text = "Send All Invoices"
		'
		'lbtnSendSelectedInvoices
		'
		Me.lbtnSendSelectedInvoices.AutoSize = True
		Me.lbtnSendSelectedInvoices.Location = New System.Drawing.Point(122, 206)
		Me.lbtnSendSelectedInvoices.Name = "lbtnSendSelectedInvoices"
		Me.lbtnSendSelectedInvoices.Size = New System.Drawing.Size(120, 13)
		Me.lbtnSendSelectedInvoices.TabIndex = 2
		Me.lbtnSendSelectedInvoices.TabStop = True
		Me.lbtnSendSelectedInvoices.Text = "Send Selected Invoices"
		'
		'lbtnLoadNewInvoives
		'
		Me.lbtnLoadNewInvoives.AutoSize = True
		Me.lbtnLoadNewInvoives.Location = New System.Drawing.Point(6, 206)
		Me.lbtnLoadNewInvoives.Name = "lbtnLoadNewInvoives"
		Me.lbtnLoadNewInvoives.Size = New System.Drawing.Size(91, 13)
		Me.lbtnLoadNewInvoives.TabIndex = 1
		Me.lbtnLoadNewInvoives.TabStop = True
		Me.lbtnLoadNewInvoives.Text = "List New Invoices"
		'
		'gvwInvoices
		'
		Me.gvwInvoices.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.gvwInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.gvwInvoices.Location = New System.Drawing.Point(8, 7)
		Me.gvwInvoices.Name = "gvwInvoices"
		Me.gvwInvoices.Size = New System.Drawing.Size(837, 185)
		Me.gvwInvoices.TabIndex = 0
		'
		'tpMain
		'
		Me.tpMain.Controls.Add(Me.txtVendorID)
		Me.tpMain.Controls.Add(Me.lbtnListAccSegments)
		Me.tpMain.Controls.Add(Me.chkDropTable)
		Me.tpMain.Controls.Add(Me.Label34)
		Me.tpMain.Controls.Add(Me.txtTimeOut)
		Me.tpMain.Controls.Add(Me.cboBudget)
		Me.tpMain.Controls.Add(Me.rbtUAT)
		Me.tpMain.Controls.Add(Me.lbtngetCompanies)
		Me.tpMain.Controls.Add(Me.rbtTest)
		Me.tpMain.Controls.Add(Me.txtURI)
		Me.tpMain.Controls.Add(Me.cboCompanies)
		Me.tpMain.Controls.Add(Me.lbtnVendorCheckSum)
		Me.tpMain.Controls.Add(Me.Label5)
		Me.tpMain.Controls.Add(Me.lbtnCheckSum)
		Me.tpMain.Controls.Add(Me.lbtnGetBudget)
		Me.tpMain.Controls.Add(Me.txtTableName)
		Me.tpMain.Controls.Add(Me.lbtnListBudgets)
		Me.tpMain.Controls.Add(Me.lbtnSaveToDB)
		Me.tpMain.Controls.Add(Me.txtFromID)
		Me.tpMain.Controls.Add(Me.lbtnActualsCheckSum)
		Me.tpMain.Controls.Add(Me.txtToID)
		Me.tpMain.Controls.Add(Me.lbtnLOACheckSum)
		Me.tpMain.Controls.Add(Me.Label3)
		Me.tpMain.Controls.Add(Me.lstActual)
		Me.tpMain.Controls.Add(Me.Label4)
		Me.tpMain.Controls.Add(Me.lbtnActuals)
		Me.tpMain.Controls.Add(Me.lstTaxSchedules)
		Me.tpMain.Controls.Add(Me.lbtnGetAccounts)
		Me.tpMain.Controls.Add(Me.lbtnPaymentTerms)
		Me.tpMain.Controls.Add(Me.lbtnGetCOA)
		Me.tpMain.Controls.Add(Me.lbtnFP)
		Me.tpMain.Controls.Add(Me.txtVendorAcc)
		Me.tpMain.Controls.Add(Me.lbtnListVendors)
		Me.tpMain.Location = New System.Drawing.Point(4, 22)
		Me.tpMain.Margin = New System.Windows.Forms.Padding(2)
		Me.tpMain.Name = "tpMain"
		Me.tpMain.Padding = New System.Windows.Forms.Padding(2)
		Me.tpMain.Size = New System.Drawing.Size(851, 317)
		Me.tpMain.TabIndex = 0
		Me.tpMain.Text = "Settings"
		Me.tpMain.UseVisualStyleBackColor = True
		'
		'txtVendorID
		'
		Me.txtVendorID.Location = New System.Drawing.Point(17, 282)
		Me.txtVendorID.Name = "txtVendorID"
		Me.txtVendorID.Size = New System.Drawing.Size(158, 20)
		Me.txtVendorID.TabIndex = 51
		Me.txtVendorID.Text = "SEA006-02"
		'
		'lbtnListAccSegments
		'
		Me.lbtnListAccSegments.AutoSize = True
		Me.lbtnListAccSegments.Location = New System.Drawing.Point(130, 227)
		Me.lbtnListAccSegments.Name = "lbtnListAccSegments"
		Me.lbtnListAccSegments.Size = New System.Drawing.Size(116, 13)
		Me.lbtnListAccSegments.TabIndex = 50
		Me.lbtnListAccSegments.TabStop = True
		Me.lbtnListAccSegments.Text = "List Account Segments"
		'
		'chkDropTable
		'
		Me.chkDropTable.AutoSize = True
		Me.chkDropTable.Location = New System.Drawing.Point(640, 116)
		Me.chkDropTable.Name = "chkDropTable"
		Me.chkDropTable.Size = New System.Drawing.Size(101, 17)
		Me.chkDropTable.TabIndex = 49
		Me.chkDropTable.Text = "Drop Create Tbl"
		Me.chkDropTable.UseVisualStyleBackColor = True
		'
		'Label34
		'
		Me.Label34.AutoSize = True
		Me.Label34.Location = New System.Drawing.Point(565, 205)
		Me.Label34.Name = "Label34"
		Me.Label34.Size = New System.Drawing.Size(121, 13)
		Me.Label34.TabIndex = 48
		Me.Label34.Text = "Time Out (Milli Seconds)"
		'
		'txtTimeOut
		'
		Me.txtTimeOut.Location = New System.Drawing.Point(705, 201)
		Me.txtTimeOut.Margin = New System.Windows.Forms.Padding(2)
		Me.txtTimeOut.Name = "txtTimeOut"
		Me.txtTimeOut.Size = New System.Drawing.Size(62, 20)
		Me.txtTimeOut.TabIndex = 47
		Me.txtTimeOut.Text = "10000"
		'
		'tpInvc
		'
		Me.tpInvc.Controls.Add(Me.lbtnCreateInvoice)
		Me.tpInvc.Controls.Add(Me.tbDueDate)
		Me.tpInvc.Controls.Add(Me.tbTaxAM)
		Me.tpInvc.Controls.Add(Me.GroupBox1)
		Me.tpInvc.Controls.Add(Me.tbInvoiceScan)
		Me.tpInvc.Controls.Add(Me.Label19)
		Me.tpInvc.Controls.Add(Me.tbPOnr)
		Me.tpInvc.Controls.Add(Me.Label20)
		Me.tpInvc.Controls.Add(Me.Label21)
		Me.tpInvc.Controls.Add(Me.tbDiscountAM)
		Me.tpInvc.Controls.Add(Me.Label22)
		Me.tpInvc.Controls.Add(Me.tbTransactionDes)
		Me.tpInvc.Controls.Add(Me.Label23)
		Me.tpInvc.Controls.Add(Me.tbChargeAM)
		Me.tpInvc.Controls.Add(Me.Label24)
		Me.tpInvc.Controls.Add(Me.tbPurchaseAM)
		Me.tpInvc.Controls.Add(Me.Label25)
		Me.tpInvc.Controls.Add(Me.Label11)
		Me.tpInvc.Controls.Add(Me.txtTaxScheduleID)
		Me.tpInvc.Controls.Add(Me.Label12)
		Me.tpInvc.Controls.Add(Me.tbPostingDate)
		Me.tpInvc.Controls.Add(Me.Label13)
		Me.tpInvc.Controls.Add(Me.tbDocumentDate)
		Me.tpInvc.Controls.Add(Me.Label14)
		Me.tpInvc.Controls.Add(Me.tbDocumentAM)
		Me.tpInvc.Controls.Add(Me.Label15)
		Me.tpInvc.Controls.Add(Me.ComboBox1)
		Me.tpInvc.Controls.Add(Me.Label10)
		Me.tpInvc.Controls.Add(Me.tbInvoiceNr)
		Me.tpInvc.Controls.Add(Me.Label8)
		Me.tpInvc.Controls.Add(Me.tbVendorID)
		Me.tpInvc.Controls.Add(Me.Label9)
		Me.tpInvc.Controls.Add(Me.tbBatchNr)
		Me.tpInvc.Controls.Add(Me.Label7)
		Me.tpInvc.Controls.Add(Me.txtCompanyID)
		Me.tpInvc.Controls.Add(Me.Label6)
		Me.tpInvc.Controls.Add(Me.lbltnSbmtInvc)
		Me.tpInvc.Location = New System.Drawing.Point(4, 22)
		Me.tpInvc.Margin = New System.Windows.Forms.Padding(2)
		Me.tpInvc.Name = "tpInvc"
		Me.tpInvc.Padding = New System.Windows.Forms.Padding(2)
		Me.tpInvc.Size = New System.Drawing.Size(851, 317)
		Me.tpInvc.TabIndex = 1
		Me.tpInvc.Text = "Post Invoice"
		Me.tpInvc.UseVisualStyleBackColor = True
		'
		'lbtnCreateInvoice
		'
		Me.lbtnCreateInvoice.AutoSize = True
		Me.lbtnCreateInvoice.Location = New System.Drawing.Point(422, 119)
		Me.lbtnCreateInvoice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lbtnCreateInvoice.Name = "lbtnCreateInvoice"
		Me.lbtnCreateInvoice.Size = New System.Drawing.Size(76, 13)
		Me.lbtnCreateInvoice.TabIndex = 84
		Me.lbtnCreateInvoice.TabStop = True
		Me.lbtnCreateInvoice.Text = "Create Invoice"
		'
		'tbDueDate
		'
		Me.tbDueDate.Location = New System.Drawing.Point(158, 228)
		Me.tbDueDate.Name = "tbDueDate"
		Me.tbDueDate.Size = New System.Drawing.Size(100, 20)
		Me.tbDueDate.TabIndex = 82
		Me.tbDueDate.Text = "28 Feb 2019"
		'
		'tbTaxAM
		'
		Me.tbTaxAM.Location = New System.Drawing.Point(294, 228)
		Me.tbTaxAM.Name = "tbTaxAM"
		Me.tbTaxAM.Size = New System.Drawing.Size(100, 20)
		Me.tbTaxAM.TabIndex = 81
		Me.tbTaxAM.Text = "0"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.txtInvLineTaxAmount)
		Me.GroupBox1.Controls.Add(Me.LinkLabel1)
		Me.GroupBox1.Controls.Add(Me.txtInvLineAmount)
		Me.GroupBox1.Controls.Add(Me.txtInvLineAccount)
		Me.GroupBox1.Controls.Add(Me.Label16)
		Me.GroupBox1.Controls.Add(Me.Label26)
		Me.GroupBox1.Controls.Add(Me.txtInvLnCompanyID)
		Me.GroupBox1.Controls.Add(Me.Label17)
		Me.GroupBox1.Controls.Add(Me.Label18)
		Me.GroupBox1.Location = New System.Drawing.Point(594, 15)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(159, 250)
		Me.GroupBox1.TabIndex = 80
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Invoice Line"
		'
		'txtInvLineTaxAmount
		'
		Me.txtInvLineTaxAmount.Location = New System.Drawing.Point(22, 150)
		Me.txtInvLineTaxAmount.Name = "txtInvLineTaxAmount"
		Me.txtInvLineTaxAmount.Size = New System.Drawing.Size(100, 20)
		Me.txtInvLineTaxAmount.TabIndex = 45
		Me.txtInvLineTaxAmount.Text = "0"
		'
		'LinkLabel1
		'
		Me.LinkLabel1.AutoSize = True
		Me.LinkLabel1.Location = New System.Drawing.Point(43, 226)
		Me.LinkLabel1.Name = "LinkLabel1"
		Me.LinkLabel1.Size = New System.Drawing.Size(49, 13)
		Me.LinkLabel1.TabIndex = 44
		Me.LinkLabel1.TabStop = True
		Me.LinkLabel1.Text = "Add Line"
		'
		'txtInvLineAmount
		'
		Me.txtInvLineAmount.Location = New System.Drawing.Point(22, 100)
		Me.txtInvLineAmount.Name = "txtInvLineAmount"
		Me.txtInvLineAmount.Size = New System.Drawing.Size(100, 20)
		Me.txtInvLineAmount.TabIndex = 39
		Me.txtInvLineAmount.Text = "100"
		'
		'txtInvLineAccount
		'
		Me.txtInvLineAccount.Location = New System.Drawing.Point(22, 197)
		Me.txtInvLineAccount.Name = "txtInvLineAccount"
		Me.txtInvLineAccount.Size = New System.Drawing.Size(100, 20)
		Me.txtInvLineAccount.TabIndex = 43
		Me.txtInvLineAccount.Text = "000-4100-00"
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Location = New System.Drawing.Point(19, 37)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(79, 13)
		Me.Label16.TabIndex = 36
		Me.Label16.Text = "Company Code"
		'
		'Label26
		'
		Me.Label26.AutoSize = True
		Me.Label26.Location = New System.Drawing.Point(19, 180)
		Me.Label26.Name = "Label26"
		Me.Label26.Size = New System.Drawing.Size(87, 13)
		Me.Label26.TabIndex = 42
		Me.Label26.Text = "Account Number"
		'
		'txtInvLnCompanyID
		'
		Me.txtInvLnCompanyID.Location = New System.Drawing.Point(22, 55)
		Me.txtInvLnCompanyID.Name = "txtInvLnCompanyID"
		Me.txtInvLnCompanyID.Size = New System.Drawing.Size(100, 20)
		Me.txtInvLnCompanyID.TabIndex = 37
		Me.txtInvLnCompanyID.Text = "1234"
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Location = New System.Drawing.Point(19, 83)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(96, 13)
		Me.Label17.TabIndex = 38
		Me.Label17.Text = "Purchases Amount"
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.Location = New System.Drawing.Point(19, 134)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(64, 13)
		Me.Label18.TabIndex = 40
		Me.Label18.Text = "Tax Amount"
		'
		'tbInvoiceScan
		'
		Me.tbInvoiceScan.Location = New System.Drawing.Point(424, 82)
		Me.tbInvoiceScan.Name = "tbInvoiceScan"
		Me.tbInvoiceScan.Size = New System.Drawing.Size(100, 20)
		Me.tbInvoiceScan.TabIndex = 79
		'
		'Label19
		'
		Me.Label19.AutoSize = True
		Me.Label19.Location = New System.Drawing.Point(422, 66)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(70, 13)
		Me.Label19.TabIndex = 78
		Me.Label19.Text = "Invoice Scan"
		'
		'tbPOnr
		'
		Me.tbPOnr.Location = New System.Drawing.Point(424, 37)
		Me.tbPOnr.Name = "tbPOnr"
		Me.tbPOnr.Size = New System.Drawing.Size(100, 20)
		Me.tbPOnr.TabIndex = 77
		Me.tbPOnr.Text = "PO_001"
		'
		'Label20
		'
		Me.Label20.AutoSize = True
		Me.Label20.Location = New System.Drawing.Point(422, 21)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(62, 13)
		Me.Label20.TabIndex = 76
		Me.Label20.Text = "PO Number"
		'
		'Label21
		'
		Me.Label21.AutoSize = True
		Me.Label21.Location = New System.Drawing.Point(291, 210)
		Me.Label21.Name = "Label21"
		Me.Label21.Size = New System.Drawing.Size(64, 13)
		Me.Label21.TabIndex = 75
		Me.Label21.Text = "Tax Amount"
		'
		'tbDiscountAM
		'
		Me.tbDiscountAM.Location = New System.Drawing.Point(294, 179)
		Me.tbDiscountAM.Name = "tbDiscountAM"
		Me.tbDiscountAM.Size = New System.Drawing.Size(100, 20)
		Me.tbDiscountAM.TabIndex = 74
		Me.tbDiscountAM.Text = "0"
		'
		'Label22
		'
		Me.Label22.AutoSize = True
		Me.Label22.Location = New System.Drawing.Point(291, 163)
		Me.Label22.Name = "Label22"
		Me.Label22.Size = New System.Drawing.Size(88, 13)
		Me.Label22.TabIndex = 73
		Me.Label22.Text = "Discount Amount"
		'
		'tbTransactionDes
		'
		Me.tbTransactionDes.Location = New System.Drawing.Point(294, 134)
		Me.tbTransactionDes.Name = "tbTransactionDes"
		Me.tbTransactionDes.Size = New System.Drawing.Size(100, 20)
		Me.tbTransactionDes.TabIndex = 72
		Me.tbTransactionDes.Text = "Test Inv Post"
		'
		'Label23
		'
		Me.Label23.AutoSize = True
		Me.Label23.Location = New System.Drawing.Point(291, 117)
		Me.Label23.Name = "Label23"
		Me.Label23.Size = New System.Drawing.Size(119, 13)
		Me.Label23.TabIndex = 71
		Me.Label23.Text = "Transaction Description"
		'
		'tbChargeAM
		'
		Me.tbChargeAM.Location = New System.Drawing.Point(294, 82)
		Me.tbChargeAM.Name = "tbChargeAM"
		Me.tbChargeAM.Size = New System.Drawing.Size(100, 20)
		Me.tbChargeAM.TabIndex = 70
		Me.tbChargeAM.Text = "100"
		'
		'Label24
		'
		Me.Label24.AutoSize = True
		Me.Label24.Location = New System.Drawing.Point(291, 66)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(80, 13)
		Me.Label24.TabIndex = 69
		Me.Label24.Text = "Charge Amount"
		'
		'tbPurchaseAM
		'
		Me.tbPurchaseAM.Location = New System.Drawing.Point(294, 37)
		Me.tbPurchaseAM.Name = "tbPurchaseAM"
		Me.tbPurchaseAM.Size = New System.Drawing.Size(100, 20)
		Me.tbPurchaseAM.TabIndex = 68
		Me.tbPurchaseAM.Text = "100"
		'
		'Label25
		'
		Me.Label25.AutoSize = True
		Me.Label25.Location = New System.Drawing.Point(291, 21)
		Me.Label25.Name = "Label25"
		Me.Label25.Size = New System.Drawing.Size(96, 13)
		Me.Label25.TabIndex = 67
		Me.Label25.Text = "Purchases Amount"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(154, 210)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(53, 13)
		Me.Label11.TabIndex = 66
		Me.Label11.Text = "Due Date"
		'
		'txtTaxScheduleID
		'
		Me.txtTaxScheduleID.Location = New System.Drawing.Point(158, 179)
		Me.txtTaxScheduleID.Name = "txtTaxScheduleID"
		Me.txtTaxScheduleID.Size = New System.Drawing.Size(100, 20)
		Me.txtTaxScheduleID.TabIndex = 65
		Me.txtTaxScheduleID.Text = "INPSTD"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(154, 163)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(87, 13)
		Me.Label12.TabIndex = 64
		Me.Label12.Text = "Tax Schedule ID"
		'
		'tbPostingDate
		'
		Me.tbPostingDate.Location = New System.Drawing.Point(158, 134)
		Me.tbPostingDate.Name = "tbPostingDate"
		Me.tbPostingDate.Size = New System.Drawing.Size(100, 20)
		Me.tbPostingDate.TabIndex = 63
		Me.tbPostingDate.Text = "01 Feb 2019"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(154, 117)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(68, 13)
		Me.Label13.TabIndex = 62
		Me.Label13.Text = "Posting Date"
		'
		'tbDocumentDate
		'
		Me.tbDocumentDate.Location = New System.Drawing.Point(158, 82)
		Me.tbDocumentDate.Name = "tbDocumentDate"
		Me.tbDocumentDate.Size = New System.Drawing.Size(100, 20)
		Me.tbDocumentDate.TabIndex = 61
		Me.tbDocumentDate.Text = "01 Feb 2019"
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Location = New System.Drawing.Point(154, 66)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(82, 13)
		Me.Label14.TabIndex = 60
		Me.Label14.Text = "Document Date"
		'
		'tbDocumentAM
		'
		Me.tbDocumentAM.Location = New System.Drawing.Point(158, 37)
		Me.tbDocumentAM.Name = "tbDocumentAM"
		Me.tbDocumentAM.Size = New System.Drawing.Size(100, 20)
		Me.tbDocumentAM.TabIndex = 59
		Me.tbDocumentAM.Text = "100"
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Location = New System.Drawing.Point(154, 21)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(95, 13)
		Me.Label15.TabIndex = 58
		Me.Label15.Text = "Document Amount"
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Items.AddRange(New Object() {"dtInvoice ", "dtFinanceCharge", "dtMiscillaneousCharge", "dtReturn", "dtCreditNote"})
		Me.ComboBox1.Location = New System.Drawing.Point(26, 227)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
		Me.ComboBox1.TabIndex = 57
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(22, 210)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(83, 13)
		Me.Label10.TabIndex = 56
		Me.Label10.Text = "Document Type"
		'
		'tbInvoiceNr
		'
		Me.tbInvoiceNr.Location = New System.Drawing.Point(26, 179)
		Me.tbInvoiceNr.Name = "tbInvoiceNr"
		Me.tbInvoiceNr.Size = New System.Drawing.Size(100, 20)
		Me.tbInvoiceNr.TabIndex = 55
		Me.tbInvoiceNr.Text = "INV001"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(22, 163)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(82, 13)
		Me.Label8.TabIndex = 54
		Me.Label8.Text = "Invoice Number"
		'
		'tbVendorID
		'
		Me.tbVendorID.Location = New System.Drawing.Point(26, 134)
		Me.tbVendorID.Name = "tbVendorID"
		Me.tbVendorID.Size = New System.Drawing.Size(100, 20)
		Me.tbVendorID.TabIndex = 53
		Me.tbVendorID.Text = "MAR001-1360"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(22, 117)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(55, 13)
		Me.Label9.TabIndex = 52
		Me.Label9.Text = "Vendor ID"
		'
		'tbBatchNr
		'
		Me.tbBatchNr.Location = New System.Drawing.Point(26, 82)
		Me.tbBatchNr.Name = "tbBatchNr"
		Me.tbBatchNr.Size = New System.Drawing.Size(100, 20)
		Me.tbBatchNr.TabIndex = 51
		Me.tbBatchNr.Text = "001"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(22, 66)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(75, 13)
		Me.Label7.TabIndex = 50
		Me.Label7.Text = "Batch Number"
		'
		'txtCompanyID
		'
		Me.txtCompanyID.Location = New System.Drawing.Point(26, 37)
		Me.txtCompanyID.Name = "txtCompanyID"
		Me.txtCompanyID.Size = New System.Drawing.Size(100, 20)
		Me.txtCompanyID.TabIndex = 49
		Me.txtCompanyID.Text = "TWO01"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(22, 21)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(65, 13)
		Me.Label6.TabIndex = 48
		Me.Label6.Text = "Company ID"
		'
		'lbltnSbmtInvc
		'
		Me.lbltnSbmtInvc.AutoSize = True
		Me.lbltnSbmtInvc.Location = New System.Drawing.Point(422, 230)
		Me.lbltnSbmtInvc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lbltnSbmtInvc.Name = "lbltnSbmtInvc"
		Me.lbltnSbmtInvc.Size = New System.Drawing.Size(77, 13)
		Me.lbltnSbmtInvc.TabIndex = 0
		Me.lbltnSbmtInvc.TabStop = True
		Me.lbltnSbmtInvc.Text = "Submit Invoice"
		'
		'tpVendor
		'
		Me.tpVendor.Controls.Add(Me.lbtnEditVendor)
		Me.tpVendor.Controls.Add(Me.rbEditVendor)
		Me.tpVendor.Controls.Add(Me.rbCreateVendor)
		Me.tpVendor.Controls.Add(Me.txtVOnHold)
		Me.tpVendor.Controls.Add(Me.txtVVendorStatus)
		Me.tpVendor.Controls.Add(Me.Label57)
		Me.tpVendor.Controls.Add(Me.txtVVendorName)
		Me.tpVendor.Controls.Add(Me.Label58)
		Me.tpVendor.Controls.Add(Me.txtVVendorID)
		Me.tpVendor.Controls.Add(Me.Label59)
		Me.tpVendor.Controls.Add(Me.txtVVendorContactName)
		Me.tpVendor.Controls.Add(Me.Label61)
		Me.tpVendor.Controls.Add(Me.txtVVendorClass)
		Me.tpVendor.Controls.Add(Me.Label62)
		Me.tpVendor.Controls.Add(Me.txtVVendorCheckName)
		Me.tpVendor.Controls.Add(Me.Label51)
		Me.tpVendor.Controls.Add(Me.txtVVendorAccNameNr)
		Me.tpVendor.Controls.Add(Me.Label52)
		Me.tpVendor.Controls.Add(Me.txtVVATNr)
		Me.tpVendor.Controls.Add(Me.Label53)
		Me.tpVendor.Controls.Add(Me.txtVUseCustomPayeeRef)
		Me.tpVendor.Controls.Add(Me.Label55)
		Me.tpVendor.Controls.Add(Me.txtVUseCustomCompanyRef)
		Me.tpVendor.Controls.Add(Me.Label56)
		Me.tpVendor.Controls.Add(Me.txtVPostalCode)
		Me.tpVendor.Controls.Add(Me.Label45)
		Me.tpVendor.Controls.Add(Me.txtVPostalCity)
		Me.tpVendor.Controls.Add(Me.Label46)
		Me.tpVendor.Controls.Add(Me.txtVPostalAddr2)
		Me.tpVendor.Controls.Add(Me.Label47)
		Me.tpVendor.Controls.Add(Me.txtVPostalAddr1)
		Me.tpVendor.Controls.Add(Me.Label48)
		Me.tpVendor.Controls.Add(Me.txtVPysicalPostalCode)
		Me.tpVendor.Controls.Add(Me.Label49)
		Me.tpVendor.Controls.Add(Me.txtVPysicalCity)
		Me.tpVendor.Controls.Add(Me.Label50)
		Me.tpVendor.Controls.Add(Me.txtVPysicalAddr2)
		Me.tpVendor.Controls.Add(Me.Label39)
		Me.tpVendor.Controls.Add(Me.txtVPysicalAddr1)
		Me.tpVendor.Controls.Add(Me.Label40)
		Me.tpVendor.Controls.Add(Me.txtVPaymentTerm)
		Me.tpVendor.Controls.Add(Me.Label41)
		Me.tpVendor.Controls.Add(Me.txtVPayeeRef)
		Me.tpVendor.Controls.Add(Me.Label42)
		Me.tpVendor.Controls.Add(Me.Label43)
		Me.tpVendor.Controls.Add(Me.txtVTel3)
		Me.tpVendor.Controls.Add(Me.Label44)
		Me.tpVendor.Controls.Add(Me.txtVTel2)
		Me.tpVendor.Controls.Add(Me.Label35)
		Me.tpVendor.Controls.Add(Me.txtVTel)
		Me.tpVendor.Controls.Add(Me.Label36)
		Me.tpVendor.Controls.Add(Me.txtVFaxNr)
		Me.tpVendor.Controls.Add(Me.Label37)
		Me.tpVendor.Controls.Add(Me.txtVEmail)
		Me.tpVendor.Controls.Add(Me.Label38)
		Me.tpVendor.Controls.Add(Me.txtVCompanyRegNr)
		Me.tpVendor.Controls.Add(Me.Label33)
		Me.tpVendor.Controls.Add(Me.txtVCompanyRef)
		Me.tpVendor.Controls.Add(Me.Label32)
		Me.tpVendor.Controls.Add(Me.txtVBrancCode)
		Me.tpVendor.Controls.Add(Me.Label31)
		Me.tpVendor.Controls.Add(Me.txtVBankName)
		Me.tpVendor.Controls.Add(Me.Label30)
		Me.tpVendor.Controls.Add(Me.txtVAccNr)
		Me.tpVendor.Controls.Add(Me.Label29)
		Me.tpVendor.Controls.Add(Me.txtVAccName)
		Me.tpVendor.Controls.Add(Me.Label28)
		Me.tpVendor.Controls.Add(Me.txtVCompanyID)
		Me.tpVendor.Controls.Add(Me.Label27)
		Me.tpVendor.Controls.Add(Me.lbltnCreateVendor)
		Me.tpVendor.Location = New System.Drawing.Point(4, 22)
		Me.tpVendor.Margin = New System.Windows.Forms.Padding(2)
		Me.tpVendor.Name = "tpVendor"
		Me.tpVendor.Padding = New System.Windows.Forms.Padding(2)
		Me.tpVendor.Size = New System.Drawing.Size(851, 317)
		Me.tpVendor.TabIndex = 2
		Me.tpVendor.Text = "Vendor"
		Me.tpVendor.UseVisualStyleBackColor = True
		'
		'lbtnEditVendor
		'
		Me.lbtnEditVendor.AutoSize = True
		Me.lbtnEditVendor.Location = New System.Drawing.Point(717, 204)
		Me.lbtnEditVendor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lbtnEditVendor.Name = "lbtnEditVendor"
		Me.lbtnEditVendor.Size = New System.Drawing.Size(79, 13)
		Me.lbtnEditVendor.TabIndex = 126
		Me.lbtnEditVendor.TabStop = True
		Me.lbtnEditVendor.Text = "Update Vendor"
		'
		'rbEditVendor
		'
		Me.rbEditVendor.AutoSize = True
		Me.rbEditVendor.Location = New System.Drawing.Point(166, 5)
		Me.rbEditVendor.Margin = New System.Windows.Forms.Padding(2)
		Me.rbEditVendor.Name = "rbEditVendor"
		Me.rbEditVendor.Size = New System.Drawing.Size(80, 17)
		Me.rbEditVendor.TabIndex = 125
		Me.rbEditVendor.Text = "Edit Vendor"
		Me.rbEditVendor.UseVisualStyleBackColor = True
		'
		'rbCreateVendor
		'
		Me.rbCreateVendor.AutoSize = True
		Me.rbCreateVendor.Checked = True
		Me.rbCreateVendor.Location = New System.Drawing.Point(52, 5)
		Me.rbCreateVendor.Margin = New System.Windows.Forms.Padding(2)
		Me.rbCreateVendor.Name = "rbCreateVendor"
		Me.rbCreateVendor.Size = New System.Drawing.Size(93, 17)
		Me.rbCreateVendor.TabIndex = 124
		Me.rbCreateVendor.TabStop = True
		Me.rbCreateVendor.Text = "Create Vendor"
		Me.rbCreateVendor.UseVisualStyleBackColor = True
		'
		'txtVOnHold
		'
		Me.txtVOnHold.FormattingEnabled = True
		Me.txtVOnHold.Items.AddRange(New Object() {"True", "False"})
		Me.txtVOnHold.Location = New System.Drawing.Point(322, 54)
		Me.txtVOnHold.Margin = New System.Windows.Forms.Padding(2)
		Me.txtVOnHold.Name = "txtVOnHold"
		Me.txtVOnHold.Size = New System.Drawing.Size(100, 21)
		Me.txtVOnHold.TabIndex = 122
		'
		'txtVVendorStatus
		'
		Me.txtVVendorStatus.Location = New System.Drawing.Point(720, 143)
		Me.txtVVendorStatus.Name = "txtVVendorStatus"
		Me.txtVVendorStatus.Size = New System.Drawing.Size(100, 20)
		Me.txtVVendorStatus.TabIndex = 121
		Me.txtVVendorStatus.Text = "3"
		'
		'Label57
		'
		Me.Label57.AutoSize = True
		Me.Label57.Location = New System.Drawing.Point(717, 126)
		Me.Label57.Name = "Label57"
		Me.Label57.Size = New System.Drawing.Size(74, 13)
		Me.Label57.TabIndex = 120
		Me.Label57.Text = "Vendor Status"
		'
		'txtVVendorName
		'
		Me.txtVVendorName.Location = New System.Drawing.Point(722, 97)
		Me.txtVVendorName.Name = "txtVVendorName"
		Me.txtVVendorName.Size = New System.Drawing.Size(100, 20)
		Me.txtVVendorName.TabIndex = 119
		Me.txtVVendorName.Text = "Temp Trading"
		'
		'Label58
		'
		Me.Label58.AutoSize = True
		Me.Label58.Location = New System.Drawing.Point(718, 80)
		Me.Label58.Name = "Label58"
		Me.Label58.Size = New System.Drawing.Size(72, 13)
		Me.Label58.TabIndex = 118
		Me.Label58.Text = "Vendor Name"
		'
		'txtVVendorID
		'
		Me.txtVVendorID.Location = New System.Drawing.Point(722, 54)
		Me.txtVVendorID.Name = "txtVVendorID"
		Me.txtVVendorID.Size = New System.Drawing.Size(100, 20)
		Me.txtVVendorID.TabIndex = 117
		Me.txtVVendorID.Text = "Temp Trading"
		'
		'Label59
		'
		Me.Label59.AutoSize = True
		Me.Label59.Location = New System.Drawing.Point(718, 36)
		Me.Label59.Name = "Label59"
		Me.Label59.Size = New System.Drawing.Size(55, 13)
		Me.Label59.TabIndex = 116
		Me.Label59.Text = "Vendor ID"
		'
		'txtVVendorContactName
		'
		Me.txtVVendorContactName.Location = New System.Drawing.Point(580, 286)
		Me.txtVVendorContactName.Name = "txtVVendorContactName"
		Me.txtVVendorContactName.Size = New System.Drawing.Size(100, 20)
		Me.txtVVendorContactName.TabIndex = 113
		Me.txtVVendorContactName.Text = "Jhon"
		'
		'Label61
		'
		Me.Label61.AutoSize = True
		Me.Label61.Location = New System.Drawing.Point(578, 269)
		Me.Label61.Name = "Label61"
		Me.Label61.Size = New System.Drawing.Size(112, 13)
		Me.Label61.TabIndex = 112
		Me.Label61.Text = "Vendor Contact Name"
		'
		'txtVVendorClass
		'
		Me.txtVVendorClass.Location = New System.Drawing.Point(580, 240)
		Me.txtVVendorClass.Name = "txtVVendorClass"
		Me.txtVVendorClass.Size = New System.Drawing.Size(100, 20)
		Me.txtVVendorClass.TabIndex = 111
		'
		'Label62
		'
		Me.Label62.AutoSize = True
		Me.Label62.Location = New System.Drawing.Point(578, 223)
		Me.Label62.Name = "Label62"
		Me.Label62.Size = New System.Drawing.Size(69, 13)
		Me.Label62.TabIndex = 110
		Me.Label62.Text = "Vendor Class"
		'
		'txtVVendorCheckName
		'
		Me.txtVVendorCheckName.Location = New System.Drawing.Point(580, 191)
		Me.txtVVendorCheckName.Name = "txtVVendorCheckName"
		Me.txtVVendorCheckName.Size = New System.Drawing.Size(100, 20)
		Me.txtVVendorCheckName.TabIndex = 109
		Me.txtVVendorCheckName.Text = "Temp Trading"
		'
		'Label51
		'
		Me.Label51.AutoSize = True
		Me.Label51.Location = New System.Drawing.Point(578, 174)
		Me.Label51.Name = "Label51"
		Me.Label51.Size = New System.Drawing.Size(106, 13)
		Me.Label51.TabIndex = 108
		Me.Label51.Text = "Vendor Check Name"
		'
		'txtVVendorAccNameNr
		'
		Me.txtVVendorAccNameNr.Location = New System.Drawing.Point(580, 143)
		Me.txtVVendorAccNameNr.Name = "txtVVendorAccNameNr"
		Me.txtVVendorAccNameNr.Size = New System.Drawing.Size(100, 20)
		Me.txtVVendorAccNameNr.TabIndex = 107
		'
		'Label52
		'
		Me.Label52.AutoSize = True
		Me.Label52.Location = New System.Drawing.Point(578, 126)
		Me.Label52.Name = "Label52"
		Me.Label52.Size = New System.Drawing.Size(108, 13)
		Me.Label52.TabIndex = 106
		Me.Label52.Text = "Vendor Acc Name Nr"
		'
		'txtVVATNr
		'
		Me.txtVVATNr.Location = New System.Drawing.Point(450, 289)
		Me.txtVVATNr.Name = "txtVVATNr"
		Me.txtVVATNr.Size = New System.Drawing.Size(100, 20)
		Me.txtVVATNr.TabIndex = 105
		'
		'Label53
		'
		Me.Label53.AutoSize = True
		Me.Label53.Location = New System.Drawing.Point(447, 271)
		Me.Label53.Name = "Label53"
		Me.Label53.Size = New System.Drawing.Size(68, 13)
		Me.Label53.TabIndex = 104
		Me.Label53.Text = "VAT Number"
		'
		'txtVUseCustomPayeeRef
		'
		Me.txtVUseCustomPayeeRef.Location = New System.Drawing.Point(583, 97)
		Me.txtVUseCustomPayeeRef.Name = "txtVUseCustomPayeeRef"
		Me.txtVUseCustomPayeeRef.Size = New System.Drawing.Size(100, 20)
		Me.txtVUseCustomPayeeRef.TabIndex = 101
		'
		'Label55
		'
		Me.Label55.AutoSize = True
		Me.Label55.Location = New System.Drawing.Point(580, 80)
		Me.Label55.Name = "Label55"
		Me.Label55.Size = New System.Drawing.Size(117, 13)
		Me.Label55.TabIndex = 100
		Me.Label55.Text = "Use Custom Payee Ref"
		'
		'txtVUseCustomCompanyRef
		'
		Me.txtVUseCustomCompanyRef.Location = New System.Drawing.Point(580, 54)
		Me.txtVUseCustomCompanyRef.Name = "txtVUseCustomCompanyRef"
		Me.txtVUseCustomCompanyRef.Size = New System.Drawing.Size(100, 20)
		Me.txtVUseCustomCompanyRef.TabIndex = 99
		'
		'Label56
		'
		Me.Label56.AutoSize = True
		Me.Label56.Location = New System.Drawing.Point(578, 36)
		Me.Label56.Name = "Label56"
		Me.Label56.Size = New System.Drawing.Size(134, 13)
		Me.Label56.TabIndex = 98
		Me.Label56.Text = "Use  Custom Company Ref"
		'
		'txtVPostalCode
		'
		Me.txtVPostalCode.Location = New System.Drawing.Point(449, 240)
		Me.txtVPostalCode.Name = "txtVPostalCode"
		Me.txtVPostalCode.Size = New System.Drawing.Size(100, 20)
		Me.txtVPostalCode.TabIndex = 97
		'
		'Label45
		'
		Me.Label45.AutoSize = True
		Me.Label45.Location = New System.Drawing.Point(448, 223)
		Me.Label45.Name = "Label45"
		Me.Label45.Size = New System.Drawing.Size(64, 13)
		Me.Label45.TabIndex = 96
		Me.Label45.Text = "Postal Code"
		'
		'txtVPostalCity
		'
		Me.txtVPostalCity.Location = New System.Drawing.Point(451, 191)
		Me.txtVPostalCity.Name = "txtVPostalCity"
		Me.txtVPostalCity.Size = New System.Drawing.Size(100, 20)
		Me.txtVPostalCity.TabIndex = 95
		'
		'Label46
		'
		Me.Label46.AutoSize = True
		Me.Label46.Location = New System.Drawing.Point(448, 174)
		Me.Label46.Name = "Label46"
		Me.Label46.Size = New System.Drawing.Size(56, 13)
		Me.Label46.TabIndex = 94
		Me.Label46.Text = "Postal City"
		'
		'txtVPostalAddr2
		'
		Me.txtVPostalAddr2.Location = New System.Drawing.Point(451, 141)
		Me.txtVPostalAddr2.Name = "txtVPostalAddr2"
		Me.txtVPostalAddr2.Size = New System.Drawing.Size(100, 20)
		Me.txtVPostalAddr2.TabIndex = 93
		'
		'Label47
		'
		Me.Label47.AutoSize = True
		Me.Label47.Location = New System.Drawing.Point(448, 125)
		Me.Label47.Name = "Label47"
		Me.Label47.Size = New System.Drawing.Size(86, 13)
		Me.Label47.TabIndex = 92
		Me.Label47.Text = "Postal Address 2"
		'
		'txtVPostalAddr1
		'
		Me.txtVPostalAddr1.Location = New System.Drawing.Point(452, 97)
		Me.txtVPostalAddr1.Name = "txtVPostalAddr1"
		Me.txtVPostalAddr1.Size = New System.Drawing.Size(100, 20)
		Me.txtVPostalAddr1.TabIndex = 91
		'
		'Label48
		'
		Me.Label48.AutoSize = True
		Me.Label48.Location = New System.Drawing.Point(449, 80)
		Me.Label48.Name = "Label48"
		Me.Label48.Size = New System.Drawing.Size(86, 13)
		Me.Label48.TabIndex = 90
		Me.Label48.Text = "Postal Address 1"
		'
		'txtVPysicalPostalCode
		'
		Me.txtVPysicalPostalCode.Location = New System.Drawing.Point(453, 54)
		Me.txtVPysicalPostalCode.Name = "txtVPysicalPostalCode"
		Me.txtVPysicalPostalCode.Size = New System.Drawing.Size(100, 20)
		Me.txtVPysicalPostalCode.TabIndex = 89
		'
		'Label49
		'
		Me.Label49.AutoSize = True
		Me.Label49.Location = New System.Drawing.Point(450, 36)
		Me.Label49.Name = "Label49"
		Me.Label49.Size = New System.Drawing.Size(106, 13)
		Me.Label49.TabIndex = 88
		Me.Label49.Text = "Physical Postal Code"
		'
		'txtVPysicalCity
		'
		Me.txtVPysicalCity.Location = New System.Drawing.Point(322, 289)
		Me.txtVPysicalCity.Name = "txtVPysicalCity"
		Me.txtVPysicalCity.Size = New System.Drawing.Size(100, 20)
		Me.txtVPysicalCity.TabIndex = 87
		'
		'Label50
		'
		Me.Label50.AutoSize = True
		Me.Label50.Location = New System.Drawing.Point(319, 271)
		Me.Label50.Name = "Label50"
		Me.Label50.Size = New System.Drawing.Size(66, 13)
		Me.Label50.TabIndex = 86
		Me.Label50.Text = "Physical City"
		'
		'txtVPysicalAddr2
		'
		Me.txtVPysicalAddr2.Location = New System.Drawing.Point(322, 239)
		Me.txtVPysicalAddr2.Name = "txtVPysicalAddr2"
		Me.txtVPysicalAddr2.Size = New System.Drawing.Size(100, 20)
		Me.txtVPysicalAddr2.TabIndex = 85
		'
		'Label39
		'
		Me.Label39.AutoSize = True
		Me.Label39.Location = New System.Drawing.Point(319, 223)
		Me.Label39.Name = "Label39"
		Me.Label39.Size = New System.Drawing.Size(96, 13)
		Me.Label39.TabIndex = 84
		Me.Label39.Text = "Physical Address 2"
		'
		'txtVPysicalAddr1
		'
		Me.txtVPysicalAddr1.Location = New System.Drawing.Point(322, 191)
		Me.txtVPysicalAddr1.Name = "txtVPysicalAddr1"
		Me.txtVPysicalAddr1.Size = New System.Drawing.Size(100, 20)
		Me.txtVPysicalAddr1.TabIndex = 83
		'
		'Label40
		'
		Me.Label40.AutoSize = True
		Me.Label40.Location = New System.Drawing.Point(319, 174)
		Me.Label40.Name = "Label40"
		Me.Label40.Size = New System.Drawing.Size(96, 13)
		Me.Label40.TabIndex = 82
		Me.Label40.Text = "Physical Address 1"
		'
		'txtVPaymentTerm
		'
		Me.txtVPaymentTerm.Location = New System.Drawing.Point(322, 141)
		Me.txtVPaymentTerm.Name = "txtVPaymentTerm"
		Me.txtVPaymentTerm.Size = New System.Drawing.Size(100, 20)
		Me.txtVPaymentTerm.TabIndex = 81
		'
		'Label41
		'
		Me.Label41.AutoSize = True
		Me.Label41.Location = New System.Drawing.Point(319, 125)
		Me.Label41.Name = "Label41"
		Me.Label41.Size = New System.Drawing.Size(75, 13)
		Me.Label41.TabIndex = 80
		Me.Label41.Text = "Payment Term"
		'
		'txtVPayeeRef
		'
		Me.txtVPayeeRef.Location = New System.Drawing.Point(322, 97)
		Me.txtVPayeeRef.Name = "txtVPayeeRef"
		Me.txtVPayeeRef.Size = New System.Drawing.Size(100, 20)
		Me.txtVPayeeRef.TabIndex = 79
		'
		'Label42
		'
		Me.Label42.AutoSize = True
		Me.Label42.Location = New System.Drawing.Point(320, 80)
		Me.Label42.Name = "Label42"
		Me.Label42.Size = New System.Drawing.Size(57, 13)
		Me.Label42.TabIndex = 78
		Me.Label42.Text = "Payee Ref"
		'
		'Label43
		'
		Me.Label43.AutoSize = True
		Me.Label43.Location = New System.Drawing.Point(321, 36)
		Me.Label43.Name = "Label43"
		Me.Label43.Size = New System.Drawing.Size(46, 13)
		Me.Label43.TabIndex = 76
		Me.Label43.Text = "On Hold"
		'
		'txtVTel3
		'
		Me.txtVTel3.Location = New System.Drawing.Point(190, 289)
		Me.txtVTel3.Name = "txtVTel3"
		Me.txtVTel3.Size = New System.Drawing.Size(100, 20)
		Me.txtVTel3.TabIndex = 75
		'
		'Label44
		'
		Me.Label44.AutoSize = True
		Me.Label44.Location = New System.Drawing.Point(187, 271)
		Me.Label44.Name = "Label44"
		Me.Label44.Size = New System.Drawing.Size(67, 13)
		Me.Label44.TabIndex = 74
		Me.Label44.Text = "Telephone 3"
		'
		'txtVTel2
		'
		Me.txtVTel2.Location = New System.Drawing.Point(190, 239)
		Me.txtVTel2.Name = "txtVTel2"
		Me.txtVTel2.Size = New System.Drawing.Size(100, 20)
		Me.txtVTel2.TabIndex = 73
		'
		'Label35
		'
		Me.Label35.AutoSize = True
		Me.Label35.Location = New System.Drawing.Point(187, 223)
		Me.Label35.Name = "Label35"
		Me.Label35.Size = New System.Drawing.Size(67, 13)
		Me.Label35.TabIndex = 72
		Me.Label35.Text = "Telephone 2"
		'
		'txtVTel
		'
		Me.txtVTel.Location = New System.Drawing.Point(190, 191)
		Me.txtVTel.Name = "txtVTel"
		Me.txtVTel.Size = New System.Drawing.Size(100, 20)
		Me.txtVTel.TabIndex = 71
		Me.txtVTel.Text = "0210000000"
		'
		'Label36
		'
		Me.Label36.AutoSize = True
		Me.Label36.Location = New System.Drawing.Point(187, 174)
		Me.Label36.Name = "Label36"
		Me.Label36.Size = New System.Drawing.Size(58, 13)
		Me.Label36.TabIndex = 70
		Me.Label36.Text = "Telephone"
		'
		'txtVFaxNr
		'
		Me.txtVFaxNr.Location = New System.Drawing.Point(190, 141)
		Me.txtVFaxNr.Name = "txtVFaxNr"
		Me.txtVFaxNr.Size = New System.Drawing.Size(100, 20)
		Me.txtVFaxNr.TabIndex = 69
		Me.txtVFaxNr.Text = "0210000000"
		'
		'Label37
		'
		Me.Label37.AutoSize = True
		Me.Label37.Location = New System.Drawing.Point(187, 125)
		Me.Label37.Name = "Label37"
		Me.Label37.Size = New System.Drawing.Size(64, 13)
		Me.Label37.TabIndex = 68
		Me.Label37.Text = "Fax Number"
		'
		'txtVEmail
		'
		Me.txtVEmail.Location = New System.Drawing.Point(190, 97)
		Me.txtVEmail.Name = "txtVEmail"
		Me.txtVEmail.Size = New System.Drawing.Size(100, 20)
		Me.txtVEmail.TabIndex = 67
		Me.txtVEmail.Text = "info@TempTrading.co.za"
		'
		'Label38
		'
		Me.Label38.AutoSize = True
		Me.Label38.Location = New System.Drawing.Point(188, 80)
		Me.Label38.Name = "Label38"
		Me.Label38.Size = New System.Drawing.Size(32, 13)
		Me.Label38.TabIndex = 66
		Me.Label38.Text = "Email"
		'
		'txtVCompanyRegNr
		'
		Me.txtVCompanyRegNr.Location = New System.Drawing.Point(191, 54)
		Me.txtVCompanyRegNr.Name = "txtVCompanyRegNr"
		Me.txtVCompanyRegNr.Size = New System.Drawing.Size(100, 20)
		Me.txtVCompanyRegNr.TabIndex = 63
		'
		'Label33
		'
		Me.Label33.AutoSize = True
		Me.Label33.Location = New System.Drawing.Point(189, 36)
		Me.Label33.Name = "Label33"
		Me.Label33.Size = New System.Drawing.Size(91, 13)
		Me.Label33.TabIndex = 62
		Me.Label33.Text = "Company Reg No"
		'
		'txtVCompanyRef
		'
		Me.txtVCompanyRef.Location = New System.Drawing.Point(54, 289)
		Me.txtVCompanyRef.Name = "txtVCompanyRef"
		Me.txtVCompanyRef.Size = New System.Drawing.Size(100, 20)
		Me.txtVCompanyRef.TabIndex = 61
		'
		'Label32
		'
		Me.Label32.AutoSize = True
		Me.Label32.Location = New System.Drawing.Point(52, 269)
		Me.Label32.Name = "Label32"
		Me.Label32.Size = New System.Drawing.Size(71, 13)
		Me.Label32.TabIndex = 60
		Me.Label32.Text = "Company Ref"
		'
		'txtVBrancCode
		'
		Me.txtVBrancCode.Location = New System.Drawing.Point(54, 240)
		Me.txtVBrancCode.Name = "txtVBrancCode"
		Me.txtVBrancCode.Size = New System.Drawing.Size(100, 20)
		Me.txtVBrancCode.TabIndex = 59
		'
		'Label31
		'
		Me.Label31.AutoSize = True
		Me.Label31.Location = New System.Drawing.Point(50, 223)
		Me.Label31.Name = "Label31"
		Me.Label31.Size = New System.Drawing.Size(69, 13)
		Me.Label31.TabIndex = 58
		Me.Label31.Text = "Branch Code"
		'
		'txtVBankName
		'
		Me.txtVBankName.Location = New System.Drawing.Point(54, 191)
		Me.txtVBankName.Name = "txtVBankName"
		Me.txtVBankName.Size = New System.Drawing.Size(100, 20)
		Me.txtVBankName.TabIndex = 57
		'
		'Label30
		'
		Me.Label30.AutoSize = True
		Me.Label30.Location = New System.Drawing.Point(50, 174)
		Me.Label30.Name = "Label30"
		Me.Label30.Size = New System.Drawing.Size(63, 13)
		Me.Label30.TabIndex = 56
		Me.Label30.Text = "Bank Name"
		'
		'txtVAccNr
		'
		Me.txtVAccNr.Location = New System.Drawing.Point(54, 143)
		Me.txtVAccNr.Name = "txtVAccNr"
		Me.txtVAccNr.Size = New System.Drawing.Size(100, 20)
		Me.txtVAccNr.TabIndex = 55
		Me.txtVAccNr.Text = "Temp Trading"
		'
		'Label29
		'
		Me.Label29.AutoSize = True
		Me.Label29.Location = New System.Drawing.Point(50, 126)
		Me.Label29.Name = "Label29"
		Me.Label29.Size = New System.Drawing.Size(87, 13)
		Me.Label29.TabIndex = 54
		Me.Label29.Text = "Account Number"
		'
		'txtVAccName
		'
		Me.txtVAccName.Location = New System.Drawing.Point(54, 97)
		Me.txtVAccName.Name = "txtVAccName"
		Me.txtVAccName.Size = New System.Drawing.Size(100, 20)
		Me.txtVAccName.TabIndex = 53
		Me.txtVAccName.Text = "Temp Trading"
		'
		'Label28
		'
		Me.Label28.AutoSize = True
		Me.Label28.Location = New System.Drawing.Point(51, 80)
		Me.Label28.Name = "Label28"
		Me.Label28.Size = New System.Drawing.Size(78, 13)
		Me.Label28.TabIndex = 52
		Me.Label28.Text = "Account Name"
		'
		'txtVCompanyID
		'
		Me.txtVCompanyID.Location = New System.Drawing.Point(54, 53)
		Me.txtVCompanyID.Name = "txtVCompanyID"
		Me.txtVCompanyID.Size = New System.Drawing.Size(100, 20)
		Me.txtVCompanyID.TabIndex = 51
		Me.txtVCompanyID.Text = "TWO01"
		'
		'Label27
		'
		Me.Label27.AutoSize = True
		Me.Label27.Location = New System.Drawing.Point(51, 36)
		Me.Label27.Name = "Label27"
		Me.Label27.Size = New System.Drawing.Size(65, 13)
		Me.Label27.TabIndex = 50
		Me.Label27.Text = "Company ID"
		'
		'lbltnCreateVendor
		'
		Me.lbltnCreateVendor.AutoSize = True
		Me.lbltnCreateVendor.Location = New System.Drawing.Point(717, 174)
		Me.lbltnCreateVendor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lbltnCreateVendor.Name = "lbltnCreateVendor"
		Me.lbltnCreateVendor.Size = New System.Drawing.Size(75, 13)
		Me.lbltnCreateVendor.TabIndex = 0
		Me.lbltnCreateVendor.TabStop = True
		Me.lbltnCreateVendor.Text = "Create Vendor"
		'
		'tpVendorMasterIntegration
		'
		Me.tpVendorMasterIntegration.Controls.Add(Me.lbtnDisplayDiff)
		Me.tpVendorMasterIntegration.Controls.Add(Me.tbVendorID_Integration)
		Me.tpVendorMasterIntegration.Controls.Add(Me.lbtnSearchSysLink)
		Me.tpVendorMasterIntegration.Location = New System.Drawing.Point(4, 22)
		Me.tpVendorMasterIntegration.Name = "tpVendorMasterIntegration"
		Me.tpVendorMasterIntegration.Size = New System.Drawing.Size(851, 317)
		Me.tpVendorMasterIntegration.TabIndex = 5
		Me.tpVendorMasterIntegration.Text = "Vendor Master Integration"
		Me.tpVendorMasterIntegration.UseVisualStyleBackColor = True
		'
		'lbtnDisplayDiff
		'
		Me.lbtnDisplayDiff.AutoSize = True
		Me.lbtnDisplayDiff.Enabled = False
		Me.lbtnDisplayDiff.Location = New System.Drawing.Point(5, 56)
		Me.lbtnDisplayDiff.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lbtnDisplayDiff.Name = "lbtnDisplayDiff"
		Me.lbtnDisplayDiff.Size = New System.Drawing.Size(87, 13)
		Me.lbtnDisplayDiff.TabIndex = 87
		Me.lbtnDisplayDiff.TabStop = True
		Me.lbtnDisplayDiff.Text = "Display Diffrence"
		'
		'tbVendorID_Integration
		'
		Me.tbVendorID_Integration.Enabled = False
		Me.tbVendorID_Integration.Location = New System.Drawing.Point(8, 72)
		Me.tbVendorID_Integration.Name = "tbVendorID_Integration"
		Me.tbVendorID_Integration.Size = New System.Drawing.Size(152, 20)
		Me.tbVendorID_Integration.TabIndex = 86
		'
		'lbtnSearchSysLink
		'
		Me.lbtnSearchSysLink.AutoSize = True
		Me.lbtnSearchSysLink.Location = New System.Drawing.Point(5, 15)
		Me.lbtnSearchSysLink.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lbtnSearchSysLink.Name = "lbtnSearchSysLink"
		Me.lbtnSearchSysLink.Size = New System.Drawing.Size(155, 13)
		Me.lbtnSearchSysLink.TabIndex = 85
		Me.lbtnSearchSysLink.TabStop = True
		Me.lbtnSearchSysLink.Text = "Display System Linked Vendors"
		'
		'gvwMain
		'
		Me.gvwMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.gvwMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.gvwMain.Location = New System.Drawing.Point(5, 395)
		Me.gvwMain.Name = "gvwMain"
		Me.gvwMain.Size = New System.Drawing.Size(856, 67)
		Me.gvwMain.TabIndex = 48
		'
		'frmMSGP
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(901, 550)
		Me.Controls.Add(Me.gvwMain)
		Me.Controls.Add(Me.tabInvoiceProcess)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.txtMSG)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "frmMSGP"
		Me.ShowIcon = False
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tabInvoiceProcess.ResumeLayout(False)
		Me.tbMaster.ResumeLayout(False)
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.tbInv.ResumeLayout(False)
		Me.tbInv.PerformLayout()
		CType(Me.gvwInvoices, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tpMain.ResumeLayout(False)
		Me.tpMain.PerformLayout()
		Me.tpInvc.ResumeLayout(False)
		Me.tpInvc.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.tpVendor.ResumeLayout(False)
		Me.tpVendor.PerformLayout()
		Me.tpVendorMasterIntegration.ResumeLayout(False)
		Me.tpVendorMasterIntegration.PerformLayout()
		CType(Me.gvwMain, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents ss1 As ToolStripStatusLabel
	Friend WithEvents ssDTRows As ToolStripStatusLabel
	Friend WithEvents lbtnListBudgets As LinkLabel
	Friend WithEvents rbtUAT As RadioButton
	Friend WithEvents lbtngetCompanies As LinkLabel
	Friend WithEvents rbtTest As RadioButton
	Friend WithEvents txtMSG As TextBox
	Friend WithEvents txtURI As TextBox
	Friend WithEvents txtTableName As TextBox
	Friend WithEvents txtFromID As TextBox
	Friend WithEvents txtToID As TextBox
	Friend WithEvents lbtnVendorCheckSum As LinkLabel
	Friend WithEvents cboCompanies As ComboBox
	Friend WithEvents Label5 As Label
	Friend WithEvents lbtnCheckSum As LinkLabel
	Friend WithEvents lbtnGetBudget As LinkLabel
	Friend WithEvents lbtnSaveToDB As LinkLabel
	Friend WithEvents cboBudget As ComboBox
	Friend WithEvents lbtnActualsCheckSum As LinkLabel
	Friend WithEvents lbtnLOACheckSum As LinkLabel
	Friend WithEvents lstActual As LinkLabel
	Friend WithEvents Label3 As Label
	Friend WithEvents lbtnActuals As LinkLabel
	Friend WithEvents Label4 As Label
	Friend WithEvents lbtnGetAccounts As LinkLabel
	Friend WithEvents lstTaxSchedules As LinkLabel
	Friend WithEvents lbtnGetCOA As LinkLabel
	Friend WithEvents lbtnPaymentTerms As LinkLabel
	Friend WithEvents txtVendorAcc As LinkLabel
	Friend WithEvents lbtnFP As LinkLabel
	Friend WithEvents lbtnListVendors As LinkLabel
	Friend WithEvents BindingSource1 As BindingSource
	Friend WithEvents tabInvoiceProcess As TabControl
	Friend WithEvents tpMain As TabPage
	Friend WithEvents tpInvc As TabPage
	Friend WithEvents lbltnSbmtInvc As LinkLabel
	Friend WithEvents tbDueDate As TextBox
	Friend WithEvents tbTaxAM As TextBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents txtInvLineTaxAmount As TextBox
	Friend WithEvents LinkLabel1 As LinkLabel
	Friend WithEvents txtInvLineAmount As TextBox
	Friend WithEvents txtInvLineAccount As TextBox
	Friend WithEvents Label16 As Label
	Friend WithEvents Label26 As Label
	Friend WithEvents txtInvLnCompanyID As TextBox
	Friend WithEvents Label17 As Label
	Friend WithEvents Label18 As Label
	Friend WithEvents tbInvoiceScan As TextBox
	Friend WithEvents Label19 As Label
	Friend WithEvents tbPOnr As TextBox
	Friend WithEvents Label20 As Label
	Friend WithEvents Label21 As Label
	Friend WithEvents tbDiscountAM As TextBox
	Friend WithEvents Label22 As Label
	Friend WithEvents tbTransactionDes As TextBox
	Friend WithEvents Label23 As Label
	Friend WithEvents tbChargeAM As TextBox
	Friend WithEvents Label24 As Label
	Friend WithEvents tbPurchaseAM As TextBox
	Friend WithEvents Label25 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents txtTaxScheduleID As TextBox
	Friend WithEvents Label12 As Label
	Friend WithEvents tbPostingDate As TextBox
	Friend WithEvents Label13 As Label
	Friend WithEvents tbDocumentDate As TextBox
	Friend WithEvents Label14 As Label
	Friend WithEvents tbDocumentAM As TextBox
	Friend WithEvents Label15 As Label
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents Label10 As Label
	Friend WithEvents tbInvoiceNr As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents tbVendorID As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents tbBatchNr As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents txtCompanyID As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
	Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
	Friend WithEvents lbtnCreateInvoice As LinkLabel
	Friend WithEvents tpVendor As TabPage
	Friend WithEvents lbltnCreateVendor As LinkLabel
	Friend WithEvents txtVAccNr As TextBox
	Friend WithEvents Label29 As Label
	Friend WithEvents txtVAccName As TextBox
	Friend WithEvents Label28 As Label
	Friend WithEvents txtVCompanyID As TextBox
	Friend WithEvents Label27 As Label
	Friend WithEvents txtVBankName As TextBox
	Friend WithEvents Label30 As Label
	Friend WithEvents txtVBrancCode As TextBox
	Friend WithEvents Label31 As Label
	Friend WithEvents txtVCompanyRegNr As TextBox
	Friend WithEvents Label33 As Label
	Friend WithEvents txtVCompanyRef As TextBox
	Friend WithEvents Label32 As Label
	Friend WithEvents txtVTel2 As TextBox
	Friend WithEvents Label35 As Label
	Friend WithEvents txtVTel As TextBox
	Friend WithEvents Label36 As Label
	Friend WithEvents txtVFaxNr As TextBox
	Friend WithEvents Label37 As Label
	Friend WithEvents txtVEmail As TextBox
	Friend WithEvents Label38 As Label
	Friend WithEvents txtVPysicalAddr2 As TextBox
	Friend WithEvents Label39 As Label
	Friend WithEvents txtVPysicalAddr1 As TextBox
	Friend WithEvents Label40 As Label
	Friend WithEvents txtVPaymentTerm As TextBox
	Friend WithEvents Label41 As Label
	Friend WithEvents txtVPayeeRef As TextBox
	Friend WithEvents Label42 As Label
	Friend WithEvents Label43 As Label
	Friend WithEvents txtVTel3 As TextBox
	Friend WithEvents Label44 As Label
	Friend WithEvents txtVPostalCode As TextBox
	Friend WithEvents Label45 As Label
	Friend WithEvents txtVPostalCity As TextBox
	Friend WithEvents Label46 As Label
	Friend WithEvents txtVPostalAddr2 As TextBox
	Friend WithEvents Label47 As Label
	Friend WithEvents txtVPostalAddr1 As TextBox
	Friend WithEvents Label48 As Label
	Friend WithEvents txtVPysicalPostalCode As TextBox
	Friend WithEvents Label49 As Label
	Friend WithEvents txtVPysicalCity As TextBox
	Friend WithEvents Label50 As Label
	Friend WithEvents txtVVendorCheckName As TextBox
	Friend WithEvents Label51 As Label
	Friend WithEvents txtVVendorAccNameNr As TextBox
	Friend WithEvents Label52 As Label
	Friend WithEvents txtVVATNr As TextBox
	Friend WithEvents Label53 As Label
	Friend WithEvents txtVUseCustomPayeeRef As TextBox
	Friend WithEvents Label55 As Label
	Friend WithEvents txtVUseCustomCompanyRef As TextBox
	Friend WithEvents Label56 As Label
	Friend WithEvents txtVVendorStatus As TextBox
	Friend WithEvents Label57 As Label
	Friend WithEvents txtVVendorName As TextBox
	Friend WithEvents Label58 As Label
	Friend WithEvents txtVVendorID As TextBox
	Friend WithEvents Label59 As Label
	Friend WithEvents txtVVendorContactName As TextBox
	Friend WithEvents Label61 As Label
	Friend WithEvents txtVVendorClass As TextBox
	Friend WithEvents Label62 As Label
	Friend WithEvents txtVOnHold As ComboBox
	Friend WithEvents rbEditVendor As RadioButton
	Friend WithEvents rbCreateVendor As RadioButton
	Friend WithEvents lbtnEditVendor As LinkLabel
	Friend WithEvents gvwMain As DataGridView
	Friend WithEvents tbInv As TabPage
	Friend WithEvents lbtnSendSelectedInvoices As LinkLabel
	Friend WithEvents lbtnLoadNewInvoives As LinkLabel
	Friend WithEvents gvwInvoices As DataGridView
	Friend WithEvents lbtnSendAllInvoices As LinkLabel
	Friend WithEvents Label34 As Label
	Friend WithEvents txtTimeOut As TextBox
	Friend WithEvents chkDropTable As CheckBox
	Friend WithEvents tbMaster As TabPage
	Friend WithEvents chkBoxSystems As CheckedListBox
	Friend WithEvents cmdFullMasterLoad As Button
	Friend WithEvents lbtnListAccSegments As LinkLabel
	Friend WithEvents txtVendorID As TextBox
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents chkRunDataProcs As CheckBox
	Friend WithEvents chkDropRecreateStagingTables As CheckBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents chkFinacialPeriods As CheckBox
	Friend WithEvents chkPaymentTerms As CheckBox
	Friend WithEvents chkAccounts As CheckBox
	Friend WithEvents chkBudgets As CheckBox
	Friend WithEvents chkActuals As CheckBox
	Friend WithEvents chkTAX As CheckBox
	Friend WithEvents chkVendor As CheckBox
	Friend WithEvents tpVendorMasterIntegration As TabPage
	Friend WithEvents lbtnSearchSysLink As LinkLabel
	Friend WithEvents lbtnDisplayDiff As LinkLabel
	Friend WithEvents tbVendorID_Integration As TextBox
End Class
