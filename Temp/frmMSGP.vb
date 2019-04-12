

Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text

Public Class frmMSGP

	'Public Shared Function ToDataTable(Of T)(ByVal data As IList(Of T)) As DataTable
	'    Dim props As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
	'    Dim table As DataTable = New DataTable()

	'    For i As Integer = 0 To props.Count - 1
	'        Dim prop As PropertyDescriptor = props(i)
	'        table.Columns.Add(prop.Name, prop.PropertyType)
	'    Next

	'    Dim values As Object() = New Object(props.Count - 1) {}

	'    For Each item As T In data

	'        For i As Integer = 0 To values.Length - 1
	'            values(i) = props(i).GetValue(item)
	'        Next

	'        table.Rows.Add(values)
	'    Next

	'    Return table
	'End Function
	Private VendorMasterInt As Boolean

	Private Sub ListCompanies()

        Try

            Dim msg As String = ""

            Dim ws As New GPSearchLightAPI.Service
            ws.Url = txtURI.Text 'mWebService
            ws.Timeout = txtTimeOut.Text

            msg = ws.HelloWorld()

            Dim lstCompany As New GPSearchLightAPI.CompanyResult()
            lstCompany = ws.GetCompanies

            Dim tb As New DataTable
            tb.TableName = "zzzImport_GPCompanies"
            txtTableName.Text = tb.TableName

            tb.Columns.Add("Text", GetType(String))
            tb.Columns.Add("Value", GetType(String))  'Int32

            For Each Company As GPSearchLightAPI.Company In lstCompany.Companies
                tb.Rows.Add(Company.CompanyName, Company.CompanyID.ToString)
            Next

            cboCompanies.DisplayMember = "Text"
            cboCompanies.ValueMember = "Value"
            cboCompanies.DataSource = tb


            gvwMain.DataSource = tb
            gvwMain.Refresh()


        Catch ex As Exception
            tellUser(ex.Message)
        End Try


    End Sub

	Private Sub lbtngetCompanies_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbtngetCompanies.LinkClicked
		ListCompanies()
	End Sub

	Private Sub getVendors(CompanyCode As String, ByRef dt As DataTable)



		Dim lst As New GPSearchLightAPI.VendorResult()

		Try

			tellUser("Processing ... ")

			Dim cls As New clsData
			Dim ws As New GPSearchLightAPI.Service
			ws.Timeout = txtTimeOut.Text
			ws.Url = txtURI.Text 'mWebService


			lst = ws.GetVendors(CompanyCode)
			txtMSG.Text = "Successful : " & lst.Success
			txtMSG.Text = txtMSG.Text & vbCrLf & lst.ErrorMessage.ToString

			dt.TableName = "zzzImport_GPVendor"
			txtTableName.Text = dt.TableName
			'<GetVendorsResult>
			'<Vendors>
			'  <Vendor>
			'    <CompanyID>string</CompanyID>
			'    <VendorID>string</VendorID>
			'    <VendorName>string</VendorName>
			'    <VendorCheckName>string</VendorCheckName>
			'    <OnHold>boolean</OnHold>
			'    <VendorStatus>int</VendorStatus>
			'    <VendorClass>string</VendorClass>
			'    <VendorContactName>string</VendorContactName>
			'    <VendorAccountNameNumber>string</VendorAccountNameNumber>
			'    <Email>string</Email>
			'    <PostalAddress1>string</PostalAddress1>
			'    <PostalAddress2>string</PostalAddress2>
			'    <PostalCity>string</PostalCity>
			'    <PostalCode>string</PostalCode>
			'    <Telephone>string</Telephone>
			'    <Telephone2>string</Telephone2>
			'    <Telephone3>string</Telephone3>
			'    <FaxNumber>string</FaxNumber>
			'    <PaymentTerms>string</PaymentTerms>
			'    <CompanyRegistrationNo>string</CompanyRegistrationNo>
			'    <VATNumber>string</VATNumber>
			'    <PhysicalAddress1>string</PhysicalAddress1>
			'    <PhysicalAddress2>string</PhysicalAddress2>
			'    <PhysicalCity>string</PhysicalCity>
			'    <PhysicalPostalCode>string</PhysicalPostalCode>
			'    <UseCustomCompanyRef>string</UseCustomCompanyRef>
			'    <UseCustomPayeeRef>string</UseCustomPayeeRef>
			'    <CompanyRef>string</CompanyRef>
			'    <PayeeRef>string</PayeeRef>
			'    <BankName>string</BankName>
			'    <BranchCode>string</BranchCode>
			'    <AccountName>string</AccountName>
			'    <AccountNumber>string</AccountNumber>
			'  </Vendor>

			dt.Columns.Add("CompanyID", GetType(String))
			dt.Columns.Add("VendorID", GetType(String))
			dt.Columns.Add("VendorName", GetType(String))
			dt.Columns.Add("VendorCheckName", GetType(String))
			dt.Columns.Add("OnHold", GetType(Boolean))
			dt.Columns.Add("VendorStatus", GetType(Int32))
			dt.Columns.Add("VendorClass", GetType(String))
			dt.Columns.Add("VendorContactName", GetType(String))
			dt.Columns.Add("VendorAccountNameNumber", GetType(String))
			dt.Columns.Add("Email", GetType(String))
			dt.Columns.Add("PostalAddress1", GetType(String))
			dt.Columns.Add("PostalAddress2", GetType(String))
			dt.Columns.Add("PostalCity", GetType(String))
			dt.Columns.Add("PostalCode", GetType(String))
			dt.Columns.Add("Telephone", GetType(String))
			dt.Columns.Add("Telephone2", GetType(String))
			dt.Columns.Add("Telephone3", GetType(String))
			dt.Columns.Add("FaxNumber", GetType(String))
			dt.Columns.Add("PaymentTerms", GetType(String))
			dt.Columns.Add("CompanyRegistrationNo", GetType(String))
			dt.Columns.Add("VATNumber", GetType(String))
			dt.Columns.Add("PhysicalAddress1", GetType(String))
			dt.Columns.Add("PhysicalAddress2", GetType(String))
			dt.Columns.Add("PhysicalCity", GetType(String))
			dt.Columns.Add("PhysicalPostalCode", GetType(String))
			dt.Columns.Add("UseCustomCompanyRef", GetType(Int32))
			dt.Columns.Add("UseCustomPayeeRef", GetType(Int32))
			dt.Columns.Add("CompanyRef", GetType(String))
			dt.Columns.Add("PayeeRef", GetType(String))
			dt.Columns.Add("BankName", GetType(String))
			dt.Columns.Add("BranchCode", GetType(String))
			dt.Columns.Add("AccountName", GetType(String))
			dt.Columns.Add("AccountNumber", GetType(String))


			For Each t As GPSearchLightAPI.Vendor In lst.Vendors
				dt.Rows.Add(t.CompanyID, t.VendorID, t.VendorName, t.VendorCheckName, t.OnHold, t.VendorStatus, t.VendorClass, t.VendorContactName, t.VendorAccountNameNumber, t.Email, t.PostalAddress1, t.PostalAddress2 _
				, t.PhysicalCity, t.PostalCode, t.Telephone, t.Telephone2, t.Telephone3, t.FaxNumber, t.PaymentTerms, t.CompanyRegistrationNo, t.VATNumber, t.PhysicalAddress1, t.PhysicalAddress2, t.PhysicalCity, t.PhysicalPostalCode, t.UseCustomCompanyRef, t.UseCustomPayeeRef _
				, t.CompanyRef, t.PayeeRef, t.BankName, t.BranchCode, t.AccountName, t.AccountNumber)
			Next



		Catch ex As Exception
			tellUser(ex.Message)
		End Try

	End Sub

	Private Sub getTaxSchedules(CompanyCode As String, ByRef dt As DataTable)


		tellUser("Processing ... ")

		Try

			Dim cls As New clsData
			Dim ws As New GPSearchLightAPI.Service
			ws.Timeout = txtTimeOut.Text
			ws.Url = txtURI.Text 'mWebService

			Dim lst As New GPSearchLightAPI.TaxScheduleResult()
			lst = ws.GetTaxSchedules(CompanyCode)
			txtMSG.Text = "Successful : " & lst.Success
			txtMSG.Text = txtMSG.Text & vbCrLf & lst.ErrorMessage.ToString
			dt.TableName = "zzzImport_GPTaxSchedules"
			txtTableName.Text = dt.TableName

			'   <GetTaxSchedulesResult>
			'  <TaxSchedules>
			'    <TaxSchedule>
			'      <TaxScheduleID>string</TaxScheduleID>
			'      <Description>string</Description>
			'      <TaxType>ttSales Or ttPurchases</TaxType>
			'      <TaxPercentage>decimal</TaxPercentage>
			'    </TaxSchedule>
			dt.Columns.Add("CompanyID", GetType(String))
			dt.Columns.Add("TaxScheduleID", GetType(String))
			dt.Columns.Add("Description", GetType(String))
			dt.Columns.Add("TaxType", GetType(String))
			dt.Columns.Add("TaxPercentage", GetType(Decimal))

			For Each t As GPSearchLightAPI.TaxSchedule In lst.TaxSchedules
				dt.Rows.Add(CompanyCode, t.TaxScheduleID, t.Description, t.TaxType, t.TaxPercentage)
			Next

		Catch ex As Exception
			tellUser(ex.Message)

		End Try

	End Sub

	Private Sub getPaymentTerms(CompanyCode As String, ByRef dt As DataTable)
		Try

			Dim cls As New clsData
			Dim ws As New GPSearchLightAPI.Service
			ws.Timeout = txtTimeOut.Text
			ws.Url = txtURI.Text 'mWebService

			Dim lst As New GPSearchLightAPI.PaymentTermsResult()
			lst = ws.GetPaymentTerms(CompanyCode)
			txtMSG.Text = "Successful : " & lst.Success
			txtMSG.Text = txtMSG.Text & vbCrLf & lst.ErrorMessage.ToString
			dt.TableName = "zzzImport_GPPaymentTerms"
			txtTableName.Text = dt.TableName

			'<AllPaymentTerms>
			'         <PaymentTerms>
			'           <PaymentTermsID>string</PaymentTermsID>
			'           <DueDateDays>int</DueDateDays>
			'         </PaymentTerms>

			dt.Columns.Add("CompanyID", GetType(String))
			dt.Columns.Add("PaymentTermsID", GetType(String))
			dt.Columns.Add("DueDateDays", GetType(String))

			For Each t As GPSearchLightAPI.PaymentTerms In lst.AllPaymentTerms
				dt.Rows.Add(CompanyCode, t.PaymentTermsID, t.DueDateDays)
			Next


		Catch ex As Exception

		End Try
	End Sub

	Private Sub getFP(CompanyCode As String, ByRef dt As DataTable)

		Try

			Dim cls As New clsData
			Dim ws As New GPSearchLightAPI.Service
			ws.Timeout = txtTimeOut.Text
			ws.Url = txtURI.Text 'mWebService


			Dim lst As New GPSearchLightAPI.FinancialPeriodsResult()
			lst = ws.GetFinancialPeriods(CompanyCode)
			txtMSG.Text = "Successful : " & lst.Success
			txtMSG.Text = txtMSG.Text & vbCrLf & lst.ErrorMessage.ToString
			dt.TableName = "zzzImport_GPFP"
			txtTableName.Text = dt.TableName
			'<GetFinancialPeriodsResult>
			'<FinancialPeriods>
			'  <FinancialPeriod>
			'    <Year>int</Year>
			'    <PeriodID>int</PeriodID>
			'    <PeriodName>string</PeriodName>
			'    <PeriodEndDate>dateTime</PeriodEndDate>
			'    <Closed>boolean</Closed>
			'  </FinancialPeriod>
			dt.Columns.Add("CompanyID", GetType(String))
			dt.Columns.Add("Year", GetType(Int32))
			dt.Columns.Add("PeriodID", GetType(Int32))
			dt.Columns.Add("PeriodName", GetType(String))
			dt.Columns.Add("PeriodEndDate", GetType(String))
			dt.Columns.Add("Closed", GetType(Boolean))

			For Each t As GPSearchLightAPI.FinancialPeriod In lst.FinancialPeriods
				dt.Rows.Add(CompanyCode, t.Year, t.PeriodID, t.PeriodName, t.PeriodEndDate, t.Closed)
			Next

		Catch ex As Exception

		End Try
	End Sub

	Private Sub getActuals(CompanyCode As String, ByRef dt As DataTable)
		Try

			Dim cls As New clsData
			Dim ws As New GPSearchLightAPI.Service
			ws.Timeout = txtTimeOut.Text
			ws.Url = txtURI.Text 'mWebService

			Dim lst As New GPSearchLightAPI.ActualsResult
			lst = ws.GetActuals(CompanyCode, "01 Jan 2011", "01 Jan 2010", txtFromID.Text, txtToID.Text)
			txtMSG.Text = "Successful : " & lst.Success
			txtMSG.Text = txtMSG.Text & vbCrLf & lst.ErrorMessage.ToString

			dt.TableName = "zzzImport_GPBudgetActuals"
			txtTableName.Text = dt.TableName

			'<GetActualsResult>
			'<Actuals>
			'  <Actual>
			'    <Year>int</Year>
			'    <PeriodID>int</PeriodID>
			'    <PeriodStartDate>dateTime</PeriodStartDate>
			'    <AccountNumber>string</AccountNumber>
			'    <Amount>decimal</Amount>
			'  </Actual>

			dt.Columns.Add("CompanyID", GetType(String))
			dt.Columns.Add("Year", GetType(Int32))
			dt.Columns.Add("PeriodID", GetType(Int32))
			dt.Columns.Add("PeriodStartDate", GetType(DateTime))
			dt.Columns.Add("AccountNumber", GetType(String))
			dt.Columns.Add("Amount", GetType(Decimal))


			For Each t As GPSearchLightAPI.Actual In lst.Actuals
				dt.Rows.Add(CompanyCode, t.Year, t.PeriodID, t.PeriodStartDate, t.AccountNumber, t.Amount)
			Next

		Catch ex As Exception

		End Try
	End Sub

	Private Sub getAccounts(CompanyCode As String, ByRef dt As DataTable)

		Try

			Dim cls As New clsData
			Dim ws As New GPSearchLightAPI.Service
			ws.Timeout = txtTimeOut.Text
			ws.Url = txtURI.Text 'mWebService

			Dim lst As New GPSearchLightAPI.COAResult()
			lst = ws.GetCOA(CompanyCode, txtFromID.Text, txtToID.Text)
			tellUser("Successful : " & lst.Success)
			tellUser("Err : " & lst.ErrorMessage.ToString)

			dt.TableName = "zzzImport_GPAccount"
			txtTableName.Text = dt.TableName

			'<GetCOAResult>
			'<Accounts>
			'  <Account>
			'    <AccountIndex>int</AccountIndex>
			'    <AccountNumber>string</AccountNumber>
			'    <AccountType>atPostingAccount Or atUnitAccount</AccountType>
			'    <AccountDescription>string</AccountDescription>
			'    <PostingType>ptBalanceSheet Or ptIncomeStatement</PostingType>
			'    <Active>boolean</Active>
			'        <CategoryNum>int</CategoryNum>
			'<CategoryDescription>string</CategoryDescription>
			'  </Account>
			dt.Columns.Add("CompanyID", GetType(String))
			dt.Columns.Add("AccountIndex", GetType(Int32))
			dt.Columns.Add("AccountNumber", GetType(String))
			dt.Columns.Add("AccountType", GetType(String))
			dt.Columns.Add("AccountDescription", GetType(String))
			dt.Columns.Add("PostingType", GetType(String))
			dt.Columns.Add("Active", GetType(Boolean))
			dt.Columns.Add("CategoryNum", GetType(Int32))
			dt.Columns.Add("CategoryDescription", GetType(String))

			For Each t As GPSearchLightAPI.Account In lst.Accounts
				dt.Rows.Add(CompanyCode, t.AccountIndex, t.AccountNumber, t.AccountType, t.AccountDescription, t.PostingType, t.Active, t.CategoryNum, t.CategoryDescription)
			Next


		Catch ex As Exception


		End Try
	End Sub

	Private Sub GetBudgets(CompanyID As String, dt As DataTable)

		Try
			Dim cls As New clsData
			Dim ws As New GPSearchLightAPI.Service
			ws.Timeout = txtTimeOut.Text
			ws.Url = txtURI.Text 'mWebService

			Dim lst As New GPSearchLightAPI.BudgetListResult()
			lst = ws.GetBudgetList(CompanyID)
			txtMSG.Text = "Successful : " & lst.Success
			txtMSG.Text = txtMSG.Text & vbCrLf & lst.ErrorMessage.ToString


			dt.TableName = "zzzImport_GPBudget"
			txtTableName.Text = dt.TableName

			dt.Columns.Add("CompanyID", GetType(String))
			dt.Columns.Add("BudgetComment", GetType(String))
			dt.Columns.Add("BudgetID", GetType(String))
			dt.Columns.Add("FromDate", GetType(Date))
			dt.Columns.Add("ToDate", GetType(Date))
			dt.Columns.Add("Year", GetType(Int32))

			For Each t As GPSearchLightAPI.BudgetHeader In lst.Budgets
				dt.Rows.Add(CompanyID, t.BudgetComment, t.BudgetID, t.FromDate, t.ToDate, t.Year)
			Next


		Catch ex As Exception

			tellUser(ex.Message)

		End Try

	End Sub


	Private Sub getBudgetDetails(CompanyID As String, BudgetID As String, dt As DataTable)
		Try


			Dim cls As New clsData
			Dim ws As New GPSearchLightAPI.Service
			ws.Timeout = txtTimeOut.Text
			ws.Url = txtURI.Text 'mWebService

			Dim lst As New GPSearchLightAPI.BudgetResult()
			lst = ws.GetBudget(CompanyID, BudgetID, txtFromID.Text, txtToID.Text)
			txtMSG.Text = "Successful : " & lst.Success
			txtMSG.Text = txtMSG.Text & vbCrLf & lst.ErrorMessage.ToString
			dt.TableName = "zzzImport_GPBudgetDetails"
			txtTableName.Text = dt.TableName
			'<AccountNumber>string</AccountNumber>
			'  <PeriodID>int</PeriodID>
			'  <PeriodStartDate>dateTime</PeriodStartDate>
			'  <BudgetAmount>decimal</BudgetAmount>
			'  <Year>int</Year>
			dt.Columns.Add("CompanyID", GetType(String))
			dt.Columns.Add("BudgetID", GetType(String))
			dt.Columns.Add("AccountNumber", GetType(String))
			dt.Columns.Add("PeriodID", GetType(String))
			dt.Columns.Add("PeriodStartDate", GetType(DateTime))
			dt.Columns.Add("BudgetAmount", GetType(Decimal))
			dt.Columns.Add("Year", GetType(Int32))

			For Each t As GPSearchLightAPI.BudgetLine In lst.BudgetLines
				dt.Rows.Add(CompanyID, BudgetID, t.AccountNumber, t.PeriodID, t.PeriodStartDate, t.BudgetAmount, t.Year)
			Next

		Catch ex As Exception

		End Try



	End Sub







	'---------------------------------------------------------


	Private Sub tellUser(tMSG As String)

		Application.DoEvents()
		ss1.Text = tMSG
		txtMSG.Text = tMSG & vbCrLf & txtMSG.Text


		ssDTRows.Text = "Grid Rows : " & gvwMain.Rows.Count

		Application.DoEvents()

		Try
			txtMSG.Text = txtMSG.Text & vbCrLf & "Table Name : " & gvwMain.DataSource.ToString

		Catch ex As Exception

		End Try


	End Sub

	Private Sub lbtnGetBudget_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbtnGetBudget.LinkClicked

		Dim dt As New DataTable
		dt.TableName = "zzzImport_GPBudgetHeader"
		txtTableName.Text = dt.TableName

		GetBudgets(cboCompanies.SelectedValue, dt)


		cboBudget.DisplayMember = "BudgetComment"
		cboBudget.ValueMember = "BudgetID"
		cboBudget.DataSource = dt

		gvwMain.DataSource = dt
		gvwMain.Refresh()

	End Sub


	Private Sub lbtnListBudgets_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbtnListBudgets.LinkClicked


	End Sub

	Private Sub lstTaxSchedules_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lstTaxSchedules.LinkClicked



	End Sub

	Private Sub lbtnPaymentTerms_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbtnPaymentTerms.LinkClicked

	End Sub

	Private Sub lbtnFP_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbtnFP.LinkClicked

	End Sub

	Private Sub lbtnListVendors_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbtnListVendors.LinkClicked

		Dim dt As New DataTable
		getVendors(cboCompanies.SelectedValue, dt)

		gvwMain.DataSource = dt
		gvwMain.Refresh()

	End Sub

	Private Sub ltbgetVendor_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles txtVendorAcc.LinkClicked

		Try

			'MessageBox.Show(gvwMain.SelectedRows(0).Cells(1).Value)

			Dim VendorId = txtVendorID.Text   'gvwMain.SelectedRows(0).Cells(1).Value 'InputBox("Vendor ID", "-1")

			tellUser("Processing ... ")

			Dim cls As New clsData
			Dim ws As New GPSearchLightAPI.Service
			ws.Timeout = txtTimeOut.Text
			ws.Url = txtURI.Text 'mWebService

			Dim lst As New GPSearchLightAPI.VendorResult
			lst = ws.GetVendor(cboCompanies.SelectedValue, VendorId)
			txtMSG.Text = "Successful : " & lst.Success
			txtMSG.Text = txtMSG.Text & vbCrLf & lst.ErrorMessage.ToString

			Dim dt As New DataTable

			dt.Columns.Add("CompanyID", GetType(String))
			dt.Columns.Add("VendorID", GetType(String))
			dt.Columns.Add("VendorName", GetType(String))
			dt.Columns.Add("VendorCheckName", GetType(String))
			dt.Columns.Add("OnHold", GetType(Boolean))
			dt.Columns.Add("VendorStatus", GetType(Int32))
			dt.Columns.Add("VendorClass", GetType(String))
			dt.Columns.Add("VendorContactName", GetType(String))
			dt.Columns.Add("VendorAccountNameNumber", GetType(String))
			dt.Columns.Add("Email", GetType(String))
			dt.Columns.Add("PostalAddress1", GetType(String))
			dt.Columns.Add("PostalAddress2", GetType(String))
			dt.Columns.Add("PostalCity", GetType(String))
			dt.Columns.Add("PostalCode", GetType(String))
			dt.Columns.Add("Telephone", GetType(String))
			dt.Columns.Add("Telephone2", GetType(String))
			dt.Columns.Add("Telephone3", GetType(String))
			dt.Columns.Add("FaxNumber", GetType(String))
			dt.Columns.Add("PaymentTerms", GetType(String))
			dt.Columns.Add("CompanyRegistrationNo", GetType(String))
			dt.Columns.Add("VATNumber", GetType(String))
			dt.Columns.Add("PhysicalAddress1", GetType(String))
			dt.Columns.Add("PhysicalAddress2", GetType(String))
			dt.Columns.Add("PhysicalCity", GetType(String))
			dt.Columns.Add("PhysicalPostalCode", GetType(String))
			dt.Columns.Add("UseCustomCompanyRef", GetType(String))
			dt.Columns.Add("UseCustomPayeeRef", GetType(String))
			dt.Columns.Add("CompanyRef", GetType(String))
			dt.Columns.Add("PayeeRef", GetType(String))
			dt.Columns.Add("BankName", GetType(String))
			dt.Columns.Add("BranchCode", GetType(String))
			dt.Columns.Add("AccountName", GetType(String))
			dt.Columns.Add("AccountNumber", GetType(String))


			For Each t As GPSearchLightAPI.Vendor In lst.Vendors
				dt.Rows.Add(t.CompanyID, t.VendorID, t.VendorName, t.VendorCheckName, t.OnHold, t.VendorStatus, t.VendorClass, t.VendorContactName, t.VendorAccountNameNumber, t.Email, t.PostalAddress1, t.PostalAddress2 _
				, t.PhysicalCity, t.PostalCode, t.Telephone, t.Telephone2, t.Telephone3, t.FaxNumber, t.PaymentTerms, t.CompanyRegistrationNo, t.VATNumber, t.PhysicalAddress1, t.PhysicalAddress2, t.PhysicalCity, t.PhysicalPostalCode, t.UseCustomCompanyRef, t.UseCustomPayeeRef _
				, t.CompanyRef, t.PayeeRef, t.BankName, t.BranchCode, t.AccountName, t.AccountNumber)
			Next

			gvwMain.DataSource = dt
			gvwMain.Refresh()

			tellUser("Complete")



			'Load Text Boxes on vendor update

			If Not (String.IsNullOrEmpty(dt.Rows(0)("CompanyID"))) Then txtVCompanyID.Text = dt.Rows(0)("CompanyID").ToString() Else txtVCompanyID.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("VendorID"))) Then txtVVendorID.Text = dt.Rows(0)("VendorID").ToString() Else txtVVendorID.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("VendorName"))) Then txtVVendorName.Text = dt.Rows(0)("VendorName").ToString() Else txtVVendorName.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("VendorCheckName"))) Then txtVVendorCheckName.Text = dt.Rows(0)("VendorCheckName").ToString() Else txtVVendorCheckName.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("OnHold"))) Then txtVOnHold.Text = dt.Rows(0)("OnHold").ToString() Else txtVOnHold.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("VendorStatus"))) Then txtVVendorStatus.Text = dt.Rows(0)("VendorStatus").ToString() Else txtVVendorStatus.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("VendorClass"))) Then txtVVendorClass.Text = dt.Rows(0)("VendorClass").ToString() Else txtVVendorClass.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("VendorContactName"))) Then txtVVendorContactName.Text = dt.Rows(0)("VendorContactName").ToString() Else txtVVendorContactName.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("VendorAccountNameNumber"))) Then txtVVendorAccNameNr.Text = dt.Rows(0)("VendorAccountNameNumber").ToString() Else txtVVendorAccNameNr.Text = ""
			If Not (IsDBNull(dt.Rows(0)("Email"))) Then txtVEmail.Text = dt.Rows(0)("Email").ToString() Else txtVEmail.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("PostalAddress1"))) Then txtVPostalAddr1.Text = dt.Rows(0)("PostalAddress1").ToString() Else txtVPostalAddr1.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("PostalAddress2"))) Then txtVPostalAddr2.Text = dt.Rows(0)("PostalAddress2").ToString() Else txtVPostalAddr2.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("PostalCity"))) Then txtVPostalCity.Text = dt.Rows(0)("PostalCity").ToString() Else txtVPostalCity.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("PostalCode"))) Then txtVPostalCode.Text = dt.Rows(0)("PostalCode").ToString() Else txtVPostalCode.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("Telephone"))) Then txtVTel.Text = dt.Rows(0)("Telephone").ToString() Else txtVTel.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("Telephone2"))) Then txtVTel2.Text = dt.Rows(0)("Telephone2").ToString() Else txtVTel2.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("Telephone3"))) Then txtVTel3.Text = dt.Rows(0)("Telephone3").ToString() Else txtVTel3.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("FaxNumber"))) Then txtVFaxNr.Text = dt.Rows(0)("FaxNumber").ToString() Else txtVFaxNr.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("PaymentTerms"))) Then txtVPaymentTerm.Text = dt.Rows(0)("PaymentTerms").ToString() Else txtVPaymentTerm.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("CompanyRegistrationNo"))) Then txtVCompanyRegNr.Text = dt.Rows(0)("CompanyRegistrationNo").ToString() Else txtVCompanyRegNr.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("VATNumber"))) Then txtVVATNr.Text = dt.Rows(0)("VATNumber").ToString() Else txtVVATNr.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("PhysicalAddress1"))) Then txtVPysicalAddr1.Text = dt.Rows(0)("PhysicalAddress1").ToString() Else txtVPysicalAddr1.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("PhysicalAddress2"))) Then txtVPysicalAddr2.Text = dt.Rows(0)("PhysicalAddress2").ToString() Else txtVPysicalAddr2.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("PhysicalCity"))) Then txtVPysicalCity.Text = dt.Rows(0)("PhysicalCity").ToString() Else txtVPysicalCity.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("PhysicalPostalCode"))) Then txtVPysicalPostalCode.Text = dt.Rows(0)("PhysicalPostalCode").ToString() Else txtVPysicalPostalCode.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("UseCustomCompanyRef"))) Then txtVUseCustomCompanyRef.Text = dt.Rows(0)("UseCustomCompanyRef").ToString() Else txtVUseCustomCompanyRef.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("UseCustomPayeeRef"))) Then txtVUseCustomPayeeRef.Text = dt.Rows(0)("UseCustomPayeeRef").ToString() Else txtVUseCustomPayeeRef.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("CompanyRef"))) Then txtVCompanyRef.Text = dt.Rows(0)("CompanyRef").ToString() Else txtVCompanyRef.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("PayeeRef"))) Then txtVPayeeRef.Text = dt.Rows(0)("PayeeRef").ToString() Else txtVPayeeRef.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("BankName"))) Then txtVBankName.Text = dt.Rows(0)("BankName").ToString() Else txtVBankName.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("BranchCode"))) Then txtVBrancCode.Text = dt.Rows(0)("BranchCode").ToString() Else txtVBrancCode.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("AccountName"))) Then txtVAccName.Text = dt.Rows(0)("AccountName").ToString() Else txtVAccName.Text = ""
			If Not (String.IsNullOrEmpty(dt.Rows(0)("AccountNumber"))) Then txtVAccNr.Text = dt.Rows(0)("AccountNumber").ToString() Else txtVAccNr.Text = ""


		Catch ex As Exception
			tellUser(ex.Message)

		End Try
	End Sub

	Private Sub lbtnGetCOA_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbtnGetCOA.LinkClicked


	End Sub

	Private Sub lbtnGetAccounts_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbtnGetAccounts.LinkClicked

		Dim VendorId = InputBox("Account", "-1")

		tellUser("Processing ... ")

		Dim cls As New clsData
		Dim ws As New GPSearchLightAPI.Service
		ws.Timeout = txtTimeOut.Text
		ws.Url = txtURI.Text 'mWebService

		Dim lst As New GPSearchLightAPI.COAResult
		lst = ws.GetAccount(cboCompanies.SelectedValue, VendorId)
		txtMSG.Text = "Successful : " & lst.Success
		txtMSG.Text = txtMSG.Text & vbCrLf & lst.ErrorMessage.ToString

		Dim dt As New DataTable

		dt.Columns.Add("AccountIndex", GetType(Int32))
		dt.Columns.Add("AccountNumber", GetType(String))
		dt.Columns.Add("AccountType", GetType(String))
		dt.Columns.Add("AccountDescription", GetType(String))
		dt.Columns.Add("PostingType", GetType(String))
		dt.Columns.Add("Active", GetType(Boolean))

		For Each t As GPSearchLightAPI.Account In lst.Accounts
			dt.Rows.Add(t.AccountIndex, t.AccountNumber, t.AccountType, t.AccountDescription, t.PostingType, t.Active)
		Next

		gvwMain.DataSource = dt
		gvwMain.Refresh()

		tellUser("Complete")
	End Sub

	Private Sub lbtnActuals_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbtnActuals.LinkClicked

	End Sub

	Private Sub lstActual_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lstActual.LinkClicked


		Dim VendorId = InputBox("Account", "-1")

		tellUser("Processing ... ")

		Dim cls As New clsData
		Dim ws As New GPSearchLightAPI.Service
		ws.Timeout = txtTimeOut.Text
		ws.Url = txtURI.Text 'mWebService

		Dim lst As New GPSearchLightAPI.ActualsResult
		lst = ws.GetActualsForAccount(cboCompanies.SelectedValue, VendorId)
		txtMSG.Text = "Successful : " & lst.Success
		txtMSG.Text = txtMSG.Text & vbCrLf & lst.ErrorMessage.ToString

		Dim dt As New DataTable

		dt.Columns.Add("Year", GetType(Int32))
		dt.Columns.Add("PeriodID", GetType(Int32))
		dt.Columns.Add("PeriodStartDate", GetType(DateTime))
		dt.Columns.Add("AccountNumber", GetType(String))
		dt.Columns.Add("Amount", GetType(Decimal))


		For Each t As GPSearchLightAPI.Actual In lst.Actuals
			dt.Rows.Add(t.Year, t.PeriodID, t.PeriodStartDate, t.AccountNumber, t.Amount)
		Next

		gvwMain.DataSource = dt
		gvwMain.Refresh()

		tellUser("Complete")

	End Sub

	Private Sub lbtnLOACheckSum_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbtnLOACheckSum.LinkClicked

		Try

			tellUser("Processing ... ")

			Dim cls As New clsData
			Dim ws As New GPSearchLightAPI.Service
			ws.Timeout = txtTimeOut.Text
			ws.Url = txtURI.Text 'mWebService

			Dim lst As New GPSearchLightAPI.ChecksumResult
			lst = ws.GetCOAChecksum(cboCompanies.SelectedValue)

			txtMSG.Text = "Successful : " & lst.Success
			txtMSG.Text = txtMSG.Text & vbCrLf & lst.ErrorMessage.ToString

			Dim dt As New DataTable
			dt.Columns.Add("Checksum", GetType(String))

			dt.Rows.Add(lst.Checksum)

			gvwMain.DataSource = dt
			gvwMain.Refresh()

			tellUser("Complete")


		Catch ex As Exception
			tellUser(ex.Message)
		End Try

	End Sub

	Private Sub lbtnActualsCheckSum_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbtnActualsCheckSum.LinkClicked

		tellUser("Processing ... ")

		Dim cls As New clsData
		Dim ws As New GPSearchLightAPI.Service
		ws.Timeout = txtTimeOut.Text
		ws.Url = txtURI.Text 'mWebService

		Dim lst As New GPSearchLightAPI.ChecksumResult
		lst = ws.GetActualsChecksum(cboCompanies.SelectedValue)

		txtMSG.Text = "Successful : " & lst.Success
		txtMSG.Text = txtMSG.Text & vbCrLf & lst.ErrorMessage.ToString

		Dim dt As New DataTable
		dt.Columns.Add("Checksum", GetType(String))

		dt.Rows.Add(lst.Checksum)

		gvwMain.DataSource = dt
		gvwMain.Refresh()

		tellUser("Complete")
	End Sub

	Private Sub lbtnSaveToDB_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbtnSaveToDB.LinkClicked
		Dim cls As New clsData
		Dim dt As New DataTable
		dt = gvwMain.DataSource

		Dim consString As String = cls.GetCNstr 'ConfigurationManager.ConnectionStrings("constr").ConnectionString


		tellUser(CreateCopyTableDataSQLServer(dt, txtTableName.Text, consString, chkDropTable.Checked))

	End Sub

	Public Shared Function CreateCopyTableDataSQLServer(ByVal dt As DataTable, ByVal tableName As String, ByVal connectionString As String, ByVal DropCreateTable As Boolean) As String
		Dim sql As String = String.Empty
		Dim retValue As String = String.Empty
		Dim sbu As StringBuilder

		Try

			If dt.Rows.Count = 0 Then
				retValue += "The table " & tableName & " was NOT created because the source table contained zero (0) rows of data"
			Else


				If DropCreateTable Then

					sbu = New StringBuilder(String.Format("IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[{0}]') AND type in (N'U')) DROP TABLE [dbo].[{0}] ", tableName))
					sbu.Append("Create Table " & tableName & " (")
					Dim dataType As String = String.Empty

					For Each column As DataColumn In dt.Columns

						Select Case column.DataType.Name
							Case "String"
								dataType = " nvarchar(MAX) "
							Case "DateTime"
								dataType = " nvarchar(MAX) "
							Case "Boolean"
								dataType = " nvarchar(MAX) "
							Case "Int32"
								dataType = " int "
							Case "Byte[]"
								dataType = " varbinary(8000) "
							Case Else
								dataType = " nvarchar(MAX) "
						End Select

						Dim columnName As String = column.ColumnName.ToString()
						'columnName = columnName.FormatProperNameCase()
						'columnName = column.ColumnName.ToString().Replace(" ", "_").Replace("-", "_").Replace("#", "_").FormatRemoveNonLettersNumbers()
						sbu.Append("[" & columnName & "]" & dataType & " null, ")
					Next

					sbu.Remove(sbu.Length - 2, 2)
					sbu.Append(")")
					sql = sbu.ToString()
					sql = sql.Replace("/", "_").Replace("\", "_")
				Else
					sql = "select 1"
				End If

				Dim errorRetValue As Boolean = SQLServerBulkCopy(dt, sql, tableName, connectionString)

				If Not errorRetValue Then
					retValue += " " & vbCrLf
					retValue += "There was an error!"
				End If
			End If

			Return retValue
		Catch ex As Exception
			retValue = String.Format("Error - There was a problem with table {0} and thus it's data has NOT been transferred - {1}", tableName, ex.Message)
			Return retValue
		End Try
	End Function

	Public Shared Function SQLServerBulkCopy(ByVal dt As DataTable, ByVal Sql As String, ByVal TableName As String, ByVal connectionString As String, ByVal Optional connectionTypeSQL As Boolean = True) As Boolean
		Try

			If connectionTypeSQL Then

				Using conn As SqlConnection = New SqlConnection(connectionString)
					conn.Open()

					Using sqlcpy As SqlBulkCopy = New SqlBulkCopy(conn)

						Using cmd As SqlCommand = New SqlCommand(Sql, conn)
							cmd.ExecuteNonQuery()
							sqlcpy.DestinationTableName = TableName
							sqlcpy.BatchSize = 4000
							sqlcpy.WriteToServer(dt)
						End Using
					End Using
				End Using

				Return True
			Else
				Throw New ArgumentOutOfRangeException("This method is only for SQL Server Engines")
			End If

		Catch ex As Exception
			Return False
		End Try
	End Function

	Private Sub lbtnCheckSum_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbtnCheckSum.LinkClicked
		'SELECT CHECKSUM_AGG(CHECKSUM(*)) FROM zzz_GP_Staging;

		Try

			Dim cls As New clsData
			Dim dt As New DataTable
			Dim sql As String = "SELECT CHECKSUM_AGG(CHECKSUM(*)) FROM " & txtTableName.Text
			cls.GetDT(sql, dt)

			tellUser(dt.Rows(0)(0))



		Catch ex As Exception
			tellUser(ex.Message)
		End Try
	End Sub

	Private Sub lbtnVendorCheckSum_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbtnVendorCheckSum.LinkClicked

		tellUser("Processing ... ")

		Dim cls As New clsData
		Dim ws As New GPSearchLightAPI.Service
		ws.Timeout = txtTimeOut.Text
		ws.Url = txtURI.Text 'mWebService

		Dim lst As New GPSearchLightAPI.ChecksumResult
		lst = ws.GetVendorChecksum(cboCompanies.SelectedValue)

		tellUser("Successful : " & lst.Success)
		tellUser("Err:" & lst.ErrorMessage.ToString)

		Dim dt As New DataTable
		dt.Columns.Add("Checksum", GetType(String))

		dt.Rows.Add(lst.Checksum)

		gvwMain.DataSource = dt
		gvwMain.Refresh()

		tellUser("Complete")
	End Sub

	Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtTest.CheckedChanged

		If rbtTest.Checked Then txtURI.Text = "http://154.72.246.172/GPSearchlightAPI/Service.asmx"
		If rbtUAT.Checked Then txtURI.Text = "http://hssgpuatdbvm01/ACSearchlightWS/Service.asmx"


	End Sub

	Private Sub lbltnSbmtInvc_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbltnSbmtInvc.LinkClicked
		tellUser("Processing ... ")

		Dim cls As New clsData
		Dim ws As New GPSearchLightAPI.Service
		ws.Timeout = txtTimeOut.Text
		ws.Url = txtURI.Text 'mWebService

		'tbOutput.Text = "Batch nr: " & invc.BatchNumber & " Charge Amount:" & invc.ChargeAmount & " Discount Amount: " & invc.DiscountAmount.ToString & " DocumentAmount: " & invc.DocumentAmount & " DocumentDate: " & invc.DocumentDate.ToString & " DocumentType: " & invc.DocumentType & " DueDate: " + invc.DueDate.ToString & " InvoiceNr: " & invc.InvoiceNumber & " PONr: " & invc.PONumber & " PostingDate: " & invc.PostingDate.ToString & " PurchaseAmount: " & invc.PurchasesAmount.ToString & " TaxAmount: " & invc.TaxAmount.ToString & " TaxScheduleID: " & invc.TaxScheduleID & " TransactionDes: " & invc.TransactionDescription & " VendorID: " & invc.VendorID + "Lines AccNr: " + invc.Lines(0).AccountNumber


		tInvoice.Lines = tInvoiceLines.ToArray


		Dim lst As New GPSearchLightAPI.InvoiceResult
		lst = ws.CreateInvoice(txtCompanyID.Text, tInvoice)


		tellUser("Successful : " & lst.Success)
		tellUser("Error : " & lst.ErrorMessage.ToString)
		tellUser("Voucher Number" & lst.VoucherNumber)

		Dim dt As New DataTable

		dt.Columns.Add("VoucherNumber", GetType(String))
		dt.Rows.Add(lst.VoucherNumber)

		gvwMain.DataSource = dt
		gvwMain.Refresh()

		'tellUser("Complete")
	End Sub


	Dim tInvoiceLines As New List(Of GPSearchLightAPI.InvoiceLine)
	Dim tInvoice As New GPSearchLightAPI.Invoice

	Private Sub lbtnCreateInvoice_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbtnCreateInvoice.LinkClicked

		tInvoice.BatchNumber = tbBatchNr.Text '"001_test"
		tInvoice.VendorID = tbVendorID.Text '"ACETRAVE0001"
		tInvoice.InvoiceNumber = tbInvoiceNr.Text '"001_test"
		tInvoice.DocumentType = GPSearchLightAPI.enDocumentType.dtInvoice
		tInvoice.DocumentAmount = CDec(tbDocumentAM.Text) '100.0
		tInvoice.DocumentDate = "01 Feb 2019" ' Date.Now
		tInvoice.PostingDate = "01 Feb 2019"
		tInvoice.TaxScheduleID = txtTaxScheduleID.Text '"Taxid_001"
		tInvoice.DueDate = "20 Feb 2019"
		tInvoice.PurchasesAmount = CDec(tbPurchaseAM.Text) ' 200.0
		tInvoice.ChargeAmount = CDec(tbChargeAM.Text) ' 300.0
		tInvoice.TransactionDescription = tbTransactionDes.Text ' "This is a test transaction"
		tInvoice.DiscountAmount = CDec(tbDiscountAM.Text) ' 0.0
		tInvoice.TaxAmount = CDec(tbTaxAM.Text) '50.0
		tInvoice.PONumber = tbPOnr.Text '"PO_001"

		Dim filename = "C:\Temp\TestInvoice.txt"
		Dim bytes As Byte() = System.IO.File.ReadAllBytes(filename)
		tInvoice.InvoiceScan = bytes

		' Not sure what data this is supose to be 
		' ReDim Preserve invc.InvoiceScan(1)
		' invc.InvoiceScan(0) = "" 'Convert.ToByte("12")


		'invcLn.PurchaseAmount = CDec(txtInvLineAmount.Text) ' 100.0
		'invcLn.TaxAmount = CDec(txtInvLineTaxAmount.Text) ' 50.0
		'invcLn.AccountNumber = txtInvLineAccount.Text '"ACETRAVE0001"
		'invcLns(0) = invcLn
		'invc.Lines = invcLns

	End Sub

	Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked



		Dim invLine As New GPSearchLightAPI.InvoiceLine
		invLine.AccountNumber = txtInvLineAccount.Text
		invLine.CompanyCode = txtCompanyID.Text
		invLine.PurchaseAmount = txtInvLineAmount.Text
		invLine.TaxAmount = txtInvLineTaxAmount.Text

		tInvoiceLines.Add(invLine)

		tellUser("Inv line added" & tInvoiceLines.Count)


	End Sub

	Private Sub lbltnCreateVendor_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbltnCreateVendor.LinkClicked
		'tellUser("WIP")
		tellUser("Processing ... ")

		Dim cls As New clsData
		Dim ws As New GPSearchLightAPI.Service
		Dim tVendor As New GPSearchLightAPI.Vendor

		ws.Timeout = txtTimeOut.Text
		ws.Url = txtURI.Text

		tVendor.VendorID = ""

		tVendor.AccountName = txtVAccName.Text
		tVendor.AccountNumber = txtVAccNr.Text
		tVendor.BankName = txtVBankName.Text
		tVendor.BranchCode = txtVBrancCode.Text
		tVendor.CompanyID = txtVCompanyID.Text
		tVendor.CompanyRef = txtVCompanyRef.Text
		tVendor.CompanyRegistrationNo = txtVCompanyRegNr.Text
		tVendor.Email = txtVEmail.Text
		tVendor.FaxNumber = txtVFaxNr.Text
		tVendor.OnHold = If(txtVOnHold.Text = "True", True, False)
		tVendor.PayeeRef = txtVPayeeRef.Text
		tVendor.PaymentTerms = txtVPaymentTerm.Text
		tVendor.PhysicalAddress1 = txtVPostalAddr1.Text
		tVendor.PhysicalAddress2 = txtVPostalAddr2.Text
		tVendor.PhysicalCity = txtVPostalCity.Text
		tVendor.PhysicalPostalCode = txtVPysicalPostalCode.Text
		tVendor.PostalAddress1 = txtVPysicalAddr1.Text
		tVendor.PostalAddress2 = txtVPysicalAddr2.Text
		tVendor.PostalCity = txtVPysicalCity.Text
		tVendor.PostalCode = txtVPostalCode.Text
		tVendor.Telephone = txtVTel.Text
		tVendor.Telephone2 = txtVTel2.Text
		tVendor.Telephone3 = txtVTel3.Text
		tVendor.UseCustomCompanyRef = txtVUseCustomCompanyRef.Text
		tVendor.UseCustomPayeeRef = txtVUseCustomPayeeRef.Text
		tVendor.VATNumber = txtVVATNr.Text
		tVendor.VendorAccountNameNumber = txtVVendorAccNameNr.Text
		tVendor.VendorCheckName = txtVVendorCheckName.Text
		tVendor.VendorClass = txtVVendorClass.Text
		tVendor.VendorContactName = txtVVendorContactName.Text

		tVendor.VendorName = txtVVendorName.Text
		tVendor.VendorStatus = txtVVendorStatus.Text


		Dim lst As New GPSearchLightAPI.CreateVendorResult
		lst = ws.CreateVendor(txtVCompanyID.Text, tVendor)


		tellUser("Successful : " & lst.Success)
		tellUser("Error : " & lst.ErrorMessage.ToString)
		tellUser("New Vendor Created at VendorID : " & lst.VendorID)

		Dim dt As New DataTable

		dt.Columns.Add("VendorID", GetType(String))
		dt.Rows.Add(lst.VendorID)

		gvwMain.DataSource = dt
		gvwMain.Refresh()

		'tellUser("Complete")
	End Sub

	Private Sub rbCreateVendor_CheckedChanged(sender As Object, e As EventArgs) Handles rbCreateVendor.CheckedChanged
		If (rbCreateVendor.Checked = True) Then
			txtVVendorID.Enabled = False
			lbltnCreateVendor.Visible = True
			lbtnEditVendor.Visible = False
		End If
	End Sub

	Private Sub rbEditVendor_CheckedChanged(sender As Object, e As EventArgs) Handles rbEditVendor.CheckedChanged
		If (rbEditVendor.Checked = True) Then
			txtVVendorID.Enabled = True
			lbtnEditVendor.Visible = True
			lbltnCreateVendor.Visible = False
		End If
	End Sub

	Private Sub lbtnEditVendor_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbtnEditVendor.LinkClicked

		tellUser("Processing ... ")

		Dim cls As New clsData
		Dim ws As New GPSearchLightAPI.Service
		Dim tVendor As New GPSearchLightAPI.Vendor

		ws.Timeout = txtTimeOut.Text
		ws.Url = txtURI.Text


		tVendor.VendorID = txtVVendorID.Text
		tVendor.AccountName = txtVAccName.Text
		tVendor.AccountNumber = txtVAccNr.Text
		tVendor.BankName = txtVBankName.Text
		tVendor.BranchCode = txtVBrancCode.Text
		tVendor.CompanyID = txtVCompanyID.Text
		tVendor.CompanyRef = txtVCompanyRef.Text
		tVendor.CompanyRegistrationNo = txtVCompanyRegNr.Text
		tVendor.Email = txtVEmail.Text
		tVendor.FaxNumber = txtVFaxNr.Text
		tVendor.OnHold = If(txtVOnHold.Text = "True", True, False)
		tVendor.PayeeRef = txtVPayeeRef.Text
		tVendor.PaymentTerms = txtVPaymentTerm.Text
		tVendor.PhysicalAddress1 = txtVPostalAddr1.Text
		tVendor.PhysicalAddress2 = txtVPostalAddr2.Text
		tVendor.PhysicalCity = txtVPostalCity.Text
		tVendor.PhysicalPostalCode = txtVPysicalPostalCode.Text
		tVendor.PostalAddress1 = txtVPysicalAddr1.Text
		tVendor.PostalAddress2 = txtVPysicalAddr2.Text
		tVendor.PostalCity = txtVPysicalCity.Text
		tVendor.PostalCode = txtVPostalCode.Text
		tVendor.Telephone = txtVTel.Text
		tVendor.Telephone2 = txtVTel2.Text
		tVendor.Telephone3 = txtVTel3.Text
		tVendor.UseCustomCompanyRef = txtVUseCustomCompanyRef.Text
		tVendor.UseCustomPayeeRef = txtVUseCustomPayeeRef.Text
		tVendor.VATNumber = txtVVATNr.Text
		tVendor.VendorAccountNameNumber = txtVVendorAccNameNr.Text
		tVendor.VendorCheckName = txtVVendorCheckName.Text
		tVendor.VendorClass = txtVVendorClass.Text
		tVendor.VendorContactName = txtVVendorContactName.Text
		tVendor.VendorName = txtVVendorName.Text
		tVendor.VendorStatus = txtVVendorStatus.Text


		Dim lst As New GPSearchLightAPI.CreateVendorResult
		lst = ws.UpdateVendor(txtVCompanyID.Text, tVendor)

		tellUser("Successful : " & lst.Success)
		tellUser("Error : " & lst.ErrorMessage.ToString)
		tellUser("Updated Vendor at VendorID : " & lst.VendorID)

		Dim dt As New DataTable

		dt.Columns.Add("VendorID", GetType(String))
		dt.Rows.Add(lst.VendorID)

		gvwMain.DataSource = dt
		gvwMain.Refresh()

		'tellUser("Complete")


	End Sub

	Private Sub txtVCompanyID_TextChanged(sender As Object, e As EventArgs) Handles txtVCompanyID.TextChanged

	End Sub

	Private Sub txtVVendorID_TextChanged(sender As Object, e As EventArgs) Handles txtVVendorID.TextChanged

	End Sub

	Private Sub cbVOnHold_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtVOnHold.SelectedIndexChanged

	End Sub

	Private Sub lbtnLoadNewInvoives_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbtnLoadNewInvoives.LinkClicked
		LoadGPImportTable(1)

	End Sub

	Private Sub LoadGPImportTable(statusID As Int32)

		Dim cls As New clsData
		Dim sql As String = "Select * from GPInvExport WHERE StatusID = " & statusID
		Dim dt As New DataTable
		Dim r As String = ""
		r = cls.GetDT(sql, dt)

		gvwInvoices.DataSource = dt
		gvwInvoices.Refresh()
	End Sub

	Private Sub lbtnSendSelectedInvoices_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbtnSendSelectedInvoices.LinkClicked

		Dim cls As New clsData
		Dim sql As String = "" '= "Select * from GPInvExport WHERE StatusID = 1"
		Dim dt As New DataTable
		Dim r As String = ""


		Dim InvNumberStart As String = ""
		Dim InvNumberNew As String = ""
		Dim SLINVHeaderID As String = ""
		Dim CompanyCode As String = "" ' THIC

		Dim i As Int32 = 0


		Dim tmpInvoiceLines As New List(Of GPSearchLightAPI.InvoiceLine)

		For Each dr As DataGridViewRow In gvwInvoices.SelectedRows
			i = i + 1
			InvNumberNew = dr.Cells("SLInvNumber").Value
			SLINVHeaderID = dr.Cells("SLINVHeaderID").Value
			'Add Lines ------------------
			Dim invLine As New GPSearchLightAPI.InvoiceLine


			CompanyCode = dr.Cells("CompanyCode").Value
			invLine.CompanyCode = dr.Cells("CompanyCode").Value 'THIC

			invLine.AccountNumber = dr.Cells("AccountNumber").Value   'txtVendorID.Text '  "000-4100-00" 'dr.Cells("AccountNumber").Value
			invLine.PurchaseAmount = dr.Cells("PurchaseAmount").Value
			invLine.TaxAmount = dr.Cells("TaxAmount").Value
			invLine.DistributionRef = "GPInvExportID : " & dr.Cells("GPInvExportID").Value
			tmpInvoiceLines.Add(invLine)
			'---------------------------


			If (InvNumberStart <> InvNumberNew And InvNumberStart <> "") Or gvwInvoices.SelectedRows.Count = i Then


				Dim tmpInvoice As New GPSearchLightAPI.Invoice

				tmpInvoice.BatchNumber = dr.Cells("SLINVHeaderID").Value
				tmpInvoice.VendorID = dr.Cells("VendorID").Value '"MAR001-1360"
				tmpInvoice.InvoiceNumber = dr.Cells("SLInvNumber").Value
				tmpInvoice.DocumentType = GPSearchLightAPI.enDocumentType.dtInvoice



				tmpInvoice.DocumentAmount = dr.Cells("DocumentAmount").Value
				tmpInvoice.DocumentDate = dr.Cells("DocumentDate").Value
				tmpInvoice.PostingDate = Now.ToLongDateString
				tmpInvoice.TaxScheduleID = dr.Cells("TaxScheduleID").Value
				tmpInvoice.DueDate = dr.Cells("DueDate").Value
				tmpInvoice.PurchasesAmount = dr.Cells("PurchasesAmount").Value
				tmpInvoice.ChargeAmount = dr.Cells("ChargeAmount").Value
				tmpInvoice.TransactionDescription = dr.Cells("TransactionDescription").Value
				tmpInvoice.DiscountAmount = dr.Cells("DiscountAmount").Value
				tmpInvoice.TaxAmount = dr.Cells("TaxAmount").Value
				tmpInvoice.PONumber = dr.Cells("PONumber").Value

				Dim ws As New GPSearchLightAPI.Service
				ws.Timeout = txtTimeOut.Text
				ws.Url = txtURI.Text 'mWebService

				tmpInvoice.Lines = tmpInvoiceLines.ToArray


				Dim filename = "C:\Temp\TestInvoice.txt"
				Dim bytes As Byte() = System.IO.File.ReadAllBytes(filename)
				tmpInvoice.InvoiceScan = bytes




				Dim lst As New GPSearchLightAPI.InvoiceResult
				lst = ws.CreateInvoice(CompanyCode, tmpInvoice)

				Dim SuccessMsg As String = lst.Success
				Dim ErrMsg As String = lst.ErrorMessage.ToString
				Dim Voucher_Number As String = lst.VoucherNumber

				tellUser(" Success " & lst.Success & " | Fail Msg : " & ErrMsg & " | Voucher Number : " & Voucher_Number)



				If SuccessMsg = "True" Then
					r = cls.ExecuteSQL("UPDATE GPInvExport set Note = 'Success',GPVoucherNumber='" & Voucher_Number & "',DateLastTried=getdate(),DateComplete=getdate(),DateExportEnd=getdate() WHERE SLINVHeaderID = " & SLINVHeaderID)
				Else
					r = cls.ExecuteSQL("UPDATE GPInvExport set Note = '" & ErrMsg & "',DateLastTried=getdate() WHERE SLINVHeaderID = " & SLINVHeaderID)
				End If

				tellUser("DB UPDATE " & r)

				'clear
				tmpInvoiceLines.Clear()

			End If

			InvNumberStart = dr.Cells("SLInvNumber").Value

		Next


		LoadGPImportTable(1)


		' Dim filename = "C:\Temp\TestInvoice.txt"
		'Dim bytes As Byte() = System.IO.File.ReadAllBytes(filename)
		'tmpInvoice.InvoiceScan = bytes


	End Sub

	Private Sub cmdFullMasterLoad_Click(sender As Object, e As EventArgs) Handles cmdFullMasterLoad.Click



		Dim cls As New clsData
		Dim sql As String = ""
		Dim dt As New DataTable
		Dim r As String = ""



		Dim consString As String = cls.GetCNstr 'ConfigurationManager.ConnectionStrings("constr").ConnectionString

		For i As Integer = 0 To chkBoxSystems.Items.Count - 1

			If chkBoxSystems.GetItemCheckState(i) = CheckState.Checked Then

				Dim tCompanyCode = chkBoxSystems.Items(i)

				tellUser("Starting ..........." & tCompanyCode)

				'Vendor
				If chkVendor.Checked Then

					dt.Reset()
					getVendors(tCompanyCode, dt)
					cls.ExecuteSQL("Delete " & dt.TableName & " where CompanyID = '" & tCompanyCode & "'")

					If dt.Rows.Count = 0 Then
						tellUser("Vendor ...........No Rows - check web service")
						Exit For
					Else
						tellUser("Vendor ..........." & CreateCopyTableDataSQLServer(dt, dt.TableName, consString, chkDropRecreateStagingTables.Checked))
					End If

				End If


				' 1 TAX
				If chkTAX.Checked Then
					dt.Reset()
					getTaxSchedules(tCompanyCode, dt)
					cls.ExecuteSQL("Delete " & dt.TableName & " where CompanyID = '" & tCompanyCode & "'")
					tellUser("TAX Schedules ..........." & CreateCopyTableDataSQLServer(dt, dt.TableName, consString, chkDropRecreateStagingTables.Checked))
				End If

				' 2 Payment Terms
				If chkPaymentTerms.Checked Then
					dt.Reset()
					getPaymentTerms(tCompanyCode, dt)
					cls.ExecuteSQL("Delete " & dt.TableName & " where CompanyID = '" & tCompanyCode & "'")
					tellUser("Payment Terms ..........." & CreateCopyTableDataSQLServer(dt, dt.TableName, consString, chkDropRecreateStagingTables.Checked))
				End If


				'3 FP
				If chkFinacialPeriods.Checked Then
					dt.Reset()
					getFP(tCompanyCode, dt)
					cls.ExecuteSQL("Delete " & dt.TableName & " where CompanyID = '" & tCompanyCode & "'")
					tellUser("Financial Periods ..........." & CreateCopyTableDataSQLServer(dt, dt.TableName, consString, chkDropRecreateStagingTables.Checked))
				End If



				'4 Actuals
				If chkActuals.Checked Then
					dt.Reset()
					getActuals(tCompanyCode, dt)
					cls.ExecuteSQL("Delete " & dt.TableName & " where CompanyID = '" & tCompanyCode & "'")
					tellUser("Actuals ..........." & CreateCopyTableDataSQLServer(dt, dt.TableName, consString, chkDropRecreateStagingTables.Checked))
				End If


				'5 Accounts
				If chkAccounts.Checked Then
					dt.Reset()
					getAccounts(tCompanyCode, dt)
					cls.ExecuteSQL("Delete " & dt.TableName & " where CompanyID = '" & tCompanyCode & "'")
					tellUser("Accounts ..........." & CreateCopyTableDataSQLServer(dt, dt.TableName, consString, chkDropRecreateStagingTables.Checked))
				End If


				'6 Budgets
				If chkBudgets.Checked Then
					dt.Reset()
					GetBudgets(tCompanyCode, dt)
					cls.ExecuteSQL("Delete " & dt.TableName & " where CompanyID = '" & tCompanyCode & "'")
					tellUser("Accounts ..........." & CreateCopyTableDataSQLServer(dt, dt.TableName, consString, chkDropRecreateStagingTables.Checked))

					' Only get 2019 budget details


					Dim dtBudget As New DataTable
					sql = "select top 1 BudgetID from zzzImport_GPBudget where YEAR = '2019' and CompanyID = '" & tCompanyCode & "'"
					r = cls.GetDT(sql, dtBudget)
					If dtBudget.Rows.Count > 0 Then
						Dim tBudgetHeaderCode = dtBudget.Rows(0)("BudgetID")

						dt.Reset()
						getBudgetDetails(tCompanyCode, tBudgetHeaderCode, dt)
						cls.ExecuteSQL("Delete " & dt.TableName & " where CompanyID = '" & tCompanyCode & "'")
						tellUser("Accounts ..........." & CreateCopyTableDataSQLServer(dt, dt.TableName, consString, chkDropRecreateStagingTables.Checked))

					Else
						tellUser("***************No 2019 budget found*************")
					End If



				End If



				tellUser("Complete ..........." & tCompanyCode)
			End If


		Next


		'dt.Reset()
		'  GetBudgets(cboCompanies.SelectedValue, dt)
		'tellUser(CreateCopyTableDataSQLServer(dt, "zzzImport_GPBudgets", consString, False))



	End Sub

	Private Sub lbtnListAccSegments_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbtnListAccSegments.LinkClicked

		Try

			tellUser("Processing ... ")

			Dim cls As New clsData
			Dim ws As New GPSearchLightAPI.Service
			ws.Timeout = txtTimeOut.Text
			ws.Url = txtURI.Text 'mWebService

			Dim lst As New GPSearchLightAPI.AccountSegmentResult()

			lst = ws.GetAccountSegments(cboCompanies.SelectedValue)

			tellUser(Now.ToLongTimeString)


			tellUser("Successful : " & lst.Success)
			tellUser("Err : " & lst.ErrorMessage.ToString)



			Dim dt As New DataTable
			dt.TableName = "zzzImport_GPAccountSegments"
			txtTableName.Text = dt.TableName

			'     <GetAccountSegmentsResult>
			'  <Segments>
			'    <AccountSegment>
			'      <SegmentNumber>int</SegmentNumber>
			'      <SegmentID>string</SegmentID>
			'      <Description>string</Description>
			'    </AccountSegment>
			'</GetAccountSegmentsResult>

			dt.Columns.Add("CompanyID", GetType(String))
			dt.Columns.Add("SegmentNumber", GetType(Int32))
			dt.Columns.Add("SegmentID", GetType(String))
			dt.Columns.Add("Description", GetType(String))


			For Each t As GPSearchLightAPI.AccountSegment In lst.Segments
				dt.Rows.Add(cboCompanies.SelectedValue, t.SegmentNumber, t.SegmentID, t.Description)
			Next

			gvwMain.DataSource = dt
			gvwMain.Refresh()


			tellUser("Complete")



		Catch ex As Exception
			tellUser(ex.Message)

		End Try
	End Sub

	Private Sub gvwMain_SelectionChanged(sender As Object, e As EventArgs) Handles gvwMain.SelectionChanged

		Try
			txtVendorID.Text = gvwMain.SelectedRows(0).Cells(1).Value 'InputBox("Vendor ID", "-1")

			If VendorMasterInt = True Then
				tbVendorID_Integration.Text = gvwMain.SelectedRows(0).Cells("LOBVendorNumber").Value
				lbtnDisplayDiff.Enabled = True

			Else
				lbtnDisplayDiff.Enabled = False

			End If

		Catch ex As Exception

		End Try


	End Sub

	Private Sub lbtnSearchSysLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbtnSearchSysLink.LinkClicked
		Dim cls As clsData = New clsData()
		Dim Sql As String = ""
		Dim dt As DataTable = New DataTable()
		Dim SLDB As String = ""

		SLDB = cls.GetSystemParameter("SLDBName")
		SLDB &= ".."

		Sql = "Select vsl.LOBVendorNumber, v.Name as [Vendor Name], ls.Name as [LOB System], vsl.IsPrimaryLink "
		Sql &= " From " & SLDB & " VendorSystemLink vsl "
		Sql &= " Inner join " & SLDB & "LOBSystem ls on ls.LOBSystemID=vsl.LOBSystemID "
		Sql &= " Inner Join " & SLDB & "Vendor v on v.VendorID=vsl.VendorID "

		cls.GetDT(Sql, dt)

		gvwMain.DataSource = dt
		gvwMain.Columns.Item("LOBVendorNumber").Visible = False
		gvwMain.Refresh()

	End Sub


	Private Sub lbtnDisplayDiff_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbtnDisplayDiff.LinkClicked
		Dim cls As clsData = New clsData()
		Dim Sql As String = ""
		Dim dt As DataTable = New DataTable()
		Dim SLDB As String = ""

		SLDB = cls.GetSystemParameter("SLDBName")
		SLDB &= ".."

		Sql = "exec " & SLDB & "[GPShowVendorDelta]"
		cls.ExecuteSQL(Sql)

		Sql = "Select * From " & SLDB & "Delta_Vendor Where VendorID = '" & cls.CsSQLInjection(tbVendorID_Integration.Text) & "'"
		cls.GetDT(Sql, dt)

		gvwMain.DataSource = dt
		gvwMain.Refresh()

	End Sub

	Private Sub tabInvoiceProcess_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabInvoiceProcess.SelectedIndexChanged
		If tabInvoiceProcess.SelectedIndex = tabInvoiceProcess.TabPages.IndexOf(tpVendorMasterIntegration) Then
			VendorMasterInt = True
		Else
			VendorMasterInt = False
		End If
	End Sub

	Private Sub tbVendorID_Integration_TextChanged(sender As Object, e As EventArgs) Handles tbVendorID_Integration.TextChanged

	End Sub

	Public Sub MyTest(int As Integer)
		Dim restult As Integer = int + int
	End Sub
End Class