Imports System.IO
Imports iTextSharp.text.pdf
Imports ClosedXML.Excel
Imports System.Drawing.Printing
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateComboBoxWithFolders(ComboBox1, "R:\Documents\Packet Generator\Configurations\")
    End Sub

    Private Sub PopulateComboBoxWithFolders(comboBox As ComboBox, directoryPath As String)
        Try
            comboBox.Items.Clear()

            Dim folders() As String = Directory.GetDirectories(directoryPath)
            For Each folder As String In folders
                comboBox.Items.Add(Path.GetFileName(folder))
            Next
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem Is Nothing Then Return

        Dim baseImagePath As String = "R:\Documents\Packet Generator\Images\"
        Dim selectedFolder As String = ComboBox1.SelectedItem.ToString()
        Dim imagePath As String = Path.Combine(baseImagePath, selectedFolder + ".png")

        If File.Exists(imagePath) Then
            If PictureBox1.Image IsNot Nothing Then
                PictureBox1.Image.Dispose() ' Dispose the old image to prevent memory leaks
            End If
            PictureBox1.Image = New Bitmap(imagePath)
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Else
            PictureBox1.Image = Nothing
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sourceFolder As String = "R:\Documents\Packet Generator\Configurations\"
        Dim outputFolder As String = "R:\Documents\Packet Generator\Test Folder\PDFs\"
        Dim excelOutputFolder As String = "R:\Documents\Packet Generator\Test Folder\Panel Builder\" ' New folder for Panel Builder file
        Dim selectedFolderName As String = If(ComboBox1.SelectedItem IsNot Nothing, ComboBox1.SelectedItem.ToString(), "")
        Dim salesOrderNumber As String = TextBox1.Text.Trim()
        Dim KineticQuoteNumber As String = TextBox5.Text.Trim()
        Dim OrderNumber As String = TextBox6.Text.Trim()

        If String.IsNullOrEmpty(selectedFolderName) OrElse String.IsNullOrEmpty(salesOrderNumber) Then
            MessageBox.Show("Please select a configuration and enter a sales order number.")
            Return
        End If

        Dim sourcePdfPath As String = Path.Combine(sourceFolder, selectedFolderName, selectedFolderName & ".pdf")
        Dim outputPdfPath As String = Path.Combine(outputFolder, salesOrderNumber & ".pdf")
        Dim excelFilePath As String = Path.Combine(sourceFolder, selectedFolderName, selectedFolderName & ".xlsx")
        ' Define the path for the tab-delimited text output
        Dim tabDelimitedOutputPath As String = Path.Combine(excelOutputFolder, salesOrderNumber & ".txt")

        Try
            ' Modify PDF
            Using reader As New PdfReader(sourcePdfPath)
                Using fileStream As New FileStream(outputPdfPath, FileMode.Create, FileAccess.Write)
                    Dim stamper As New PdfStamper(reader, fileStream)
                    Dim formFields As AcroFields = stamper.AcroFields
                    formFields.SetField("SALESORDER", salesOrderNumber)
                    formFields.SetField("KQ", KineticQuoteNumber)
                    formFields.SetField("FWC", OrderNumber)
                    stamper.FormFlattening = True
                    stamper.Close()
                End Using
            End Using

            ' Export range as tab-delimited text file
            ExportRangeAsTabDelimited(excelFilePath, tabDelimitedOutputPath, salesOrderNumber)

            MessageBox.Show("PDF modified and Excel range exported to text file successfully." & vbCrLf & "CAD Packet Sent to Job Scans, Panel Builder File Sent to Computair Downloads.")

        Catch ex As FileNotFoundException
            MessageBox.Show($"Error: {ex.Message}. Make sure the file exists.")
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try

        If CheckBox1.Checked Then
            'Print the PDF file
            PrintPDF(outputPdfPath)
        Else

        End If

        If CheckBox2.Checked Then
            'Print the tab-delimited text file
            PrintTextFile(tabDelimitedOutputPath)
        Else

        End If

    End Sub
    ' Method to print PDF using default system handler
    Private Sub PrintPDF(filePath As String)
        Try
            Dim process As New Process()
            process.StartInfo = New ProcessStartInfo() With {
            .Verb = "print",
            .FileName = filePath,
            .CreateNoWindow = True,
            .UseShellExecute = True
        }
            process.Start()
        Catch ex As Exception
            MessageBox.Show($"Failed to print PDF: {ex.Message}")
        End Try
    End Sub
    ' New subroutine to handle Excel file updates and export a range as tab-delimited
    Private Sub ExportRangeAsTabDelimited(excelFilePath As String, textOutputFilePath As String, salesOrderNumber As String)
        Dim workbook As XLWorkbook = New XLWorkbook(excelFilePath)
        Dim worksheet = workbook.Worksheet("Sheet1")

        ' Update the cell value as before
        worksheet.Cell("Z1").Value = salesOrderNumber
        workbook.CalculateMode = XLCalculateMode.Auto
        workbook.RecalculateAllFormulas()

        ' Find the last row used in column Y
        Dim lastRow As Integer = worksheet.Column("Y").LastCellUsed().Address.RowNumber

        ' Open a StreamWriter to write the tab-delimited text
        Using writer As New StreamWriter(textOutputFilePath, False)
            ' Iterate through each row in the range
            For rowNum As Integer = 3 To lastRow
                Dim rowValues As New List(Of String)

                ' Get the value of the cell in the first column (Column A)
                Dim cell = worksheet.Cell(rowNum, 1) ' Column A

                ' Convert the value only if it is a numeric date value
                Dim cellValue As String = cell.Value.ToString()
                Dim dateValue As Double
                If Double.TryParse(cellValue, dateValue) AndAlso dateValue >= 1 AndAlso dateValue < 2958466 Then ' Excel date range from 1/1/1900 to 12/31/9999
                    ' Convert the numeric date value to a DateTime object
                    Dim dateTimeValue As DateTime = DateTime.FromOADate(dateValue)
                    ' Format the date value as desired
                    cellValue = dateTimeValue.ToString("MM/dd/yy")
                End If

                ' Add the processed value to the list of row values
                rowValues.Add(cellValue)

                ' Collect each cell's value in the remaining columns (B to Y)
                For colNum As Integer = 2 To 25 ' B=2, Y=25
                    rowValues.Add(worksheet.Cell(rowNum, colNum).Value.ToString())
                Next

                ' Join the values with a tab delimiter and write to the file
                Dim line As String = String.Join(vbTab, rowValues)
                writer.WriteLine(line)
            Next
        End Using

        ' No need to save the workbook as .xlsx here since we're exporting to a text file
    End Sub
    Private WithEvents printDocument1 As New PrintDocument

    Private Sub PrintTextFile(filePath As String)

        ' Start Notepad and instruct it to print the file
        Dim processInfo As New ProcessStartInfo()
        processInfo.FileName = "notepad.exe"
        processInfo.Arguments = "/p """ & filePath & """" ' /p argument instructs Notepad to print the file
        Process.Start(processInfo)
    End Sub


End Class
