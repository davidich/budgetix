# budgetix
Budgetix app (final project at UCLA Extension)

An app feature list:
- Shipped with SqlExpress, prefilled with data (Stores, Categories, Items, Receipts)
- Add / edit / delete / view list of Item Categories in a modal form
	- Data access via DataSets
	- All data fetch, validation and save logic is in a base Form
	- Use of delegates
- App makes sure, that user don't loose data when he closes the form.
- Add / edit / delete / view list of Items in a modal form (DataSets).
- Add / edit / delete / view list of Stores in a modal form (DataSets).
- Grid data formatting (phone is stored in DB as a Int64 value).
- Create/Save/View receipts (MDI child form, ADO.Net + Dapper)
	- Data access via Custom Models + ADO.Net + Dapper + Transactions
	- Receipt Create Date is stored in UTC, but shown in Pacific Time zone
- Refresh list of stores on a receipt screen after it was updated
- Print recept
	- Use of PrintDocument class
	- Produce a well formatted screen report
- Main form is MDI document
	- Form Navigation
