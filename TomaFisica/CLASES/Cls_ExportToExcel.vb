Imports Excel = Microsoft.Office.Interop.Excel
Public Class Cls_ExportToExcel
    Public Sub ExportToExcel(dgv As DataGridView)
        Dim appXL As Excel.Application
        Dim wbXL As Excel.Workbook
        Dim shXL As Excel.Worksheet
        Dim indiceTitulo As Integer = 1
        Dim indiceContenido As Integer = 2

        appXL = CreateObject("Excel.Application")
        appXL.Visible = False
        wbXL = appXL.Workbooks.Add()
        shXL = wbXL.ActiveSheet

        Dim formato As Excel.Range

        For index = 1 To dgv.Columns.Count
            shXL.Cells(1, indiceTitulo).Value = dgv.Columns(index - 1).HeaderText
            indiceTitulo += 1
        Next

        For i = 0 To dgv.Rows.Count - 1
            For j = 0 To dgv.Columns.Count - 1
                shXL.Cells(i + indiceContenido, j + 1).Value = dgv(j, i).Value
            Next
            indiceContenido += 1
        Next

        SaveExcel(wbXL)

        appXL.Workbooks.Close()
        appXL.Quit()

    End Sub

    Private Sub SaveExcel(wbxl)
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Title = "Guardar documento Excel"
        saveFileDialog1.Filter = "Excel File|*.xls"
        saveFileDialog1.FileName = "Usuarios_web"
        saveFileDialog1.ShowDialog()
        wbxl.SaveAs(saveFileDialog1.FileName)
    End Sub
End Class