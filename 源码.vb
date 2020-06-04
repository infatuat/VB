	Sub copy()
		 r = Cells(Rows.Count, 3).End(xlUp).Row
		 c = ActiveSheet.UsedRange.Columns.Count
		For i = 2 To c
			
			
			Sheets("资料").Select
			Range("a3:b48").copy
			Sheets.Add
			Range("A1").PasteSpecial
			Sheets("资料").Select
			Columns(2).Delete
		   ' Sheet1.Select
			'Range(Cells(3, i), Cells(48, i)).copy
		   ' Sheet(i).Select
		   ' Range("B1").PasteSpecial
		Next
	End Sub