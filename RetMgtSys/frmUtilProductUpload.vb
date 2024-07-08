Imports System.IO
Imports ggcRetailParams
Imports Microsoft.Office.Interop.Excel

Public Class frmUtilProductUpload
    Private pnLoadx As Integer
    Private poControl As Control

    Private WithEvents p_oRecord As clsInventory
    Private p_nEditMode As Integer
    Private pnSeek As Integer
    Private pnIndx As Integer

    Private pnRow As Integer
    Private pnCol As Integer
    Private filePath As String

    Private Sub frmUtilProductUpload_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If pnLoadx = 1 Then
            pnLoadx = 2
        End If
    End Sub

    Private Sub frmUtilProductUpload_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Return, Keys.Up, Keys.Down
                Select Case e.KeyCode
                    Case Keys.Return, Keys.Down
                        SetNextFocus()
                    Case Keys.Up
                        SetPreviousFocus()
                End Select
        End Select
    End Sub

    Private Sub frmUtilProductUpload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If pnLoadx = 0 Then
            p_oRecord = New clsInventory(p_oAppDriver)


            Call grpEventHandler(Me, GetType(System.Windows.Forms.TextBox), "txtField", "LostFocus", AddressOf txtField_LostFocus)
            pnLoadx = 1
        End If
    End Sub


    Function BrowseFile() As String
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"
        openFileDialog.Title = "Select an Excel File"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Return openFileDialog.FileName
        Else
            Return String.Empty
        End If
    End Function


    Private Function ReadExcelFile()
        Dim excelApp As Application = New Application()
        Dim workbooks As Workbooks = excelApp.Workbooks
        Dim workbook As Workbook = workbooks.Open(filePath)
        Dim worksheet As Worksheet = CType(workbook.Sheets(1), Worksheet)
        Dim range As Range = worksheet.UsedRange
        Dim lnStockID As String = ""
        Dim lbNewRecord As Boolean = True
        Dim lnStockExist() As String = {}
        Dim pnSuccess As Integer

        Dim rows As Integer = range.Rows.Count
        Dim cols As Integer = range.Columns.Count
        pnSuccess = 0
        For i As Integer = pnRow To rows

            Dim lnRow As Integer = 1
            For j As Integer = pnCol To cols
                Select Case lnRow
                    Case 1
                        lnStockID = If(range.Cells(i, j).Value2 IsNot Nothing, range.Cells(i, j).Value2.ToString(), "")
                        If Not p_oRecord.OpenRecord(lnStockID) Then
                            p_oRecord.NewRecord()
                            lbNewRecord = True
                        Else
                            Dim lnCtr As Integer = lnStockExist.Length
                            ReDim Preserve lnStockExist(lnCtr)
                            lnStockExist(lnCtr) = lnStockID

                            lbNewRecord = False
                            Exit For
                        End If

                    Case 2
                        p_oRecord.Master(2) = If(range.Cells(i, j).Value2 IsNot Nothing, range.Cells(i, j).Value2.ToString(), "")
                        p_oRecord.Master(3) = p_oRecord.Master(2)
                    Case 3
                        p_oRecord.Master(80) = If(range.Cells(i, j).Value2 IsNot Nothing, range.Cells(i, j).Value2.ToString(), "")
                    Case 4
                        p_oRecord.Master(85) = If(range.Cells(i, j).Value2 IsNot Nothing, range.Cells(i, j).Value2.ToString(), "")
                    Case 5
                        p_oRecord.Master(8) = If(range.Cells(i, j).Value2 IsNot Nothing, range.Cells(i, j).Value2.ToString(), "")
                    Case 6
                        p_oRecord.Master(9) = If(range.Cells(i, j).Value2 IsNot Nothing, range.Cells(i, j).Value2.ToString(), "")
                End Select
                lnRow = lnRow + 1

            Next

            If lbNewRecord Then
                p_oRecord.SaveRecord()
                pnSuccess = pnSuccess + 1
            End If
        Next
        Dim lnMsgStock As String = ""
        For lnstockCtr As Integer = 0 To lnStockExist.Length - 1
            lnMsgStock = lnMsgStock + lnStockExist(lnstockCtr) + ", "
        Next

        If lnStockExist.Length > 0 Then
            If pnSuccess > 0 Then
                MsgBox(" Record Uploaded Successfuly. " & vbCrLf & " Duplicate Record Found! " & vbCrLf _
                    & lnMsgStock, MsgBoxStyle.Information, "Success w/ Duplicate")
            Else
                MsgBox(" Record Already exist! " & vbCrLf _
                    & lnMsgStock, MsgBoxStyle.Information, "Unable to Save Record")
            End If
        Else
            MsgBox(" Record Uploaded Successfuly.", MsgBoxStyle.Information, "Success")
        End If
        workbook.Close(False)
        excelApp.Quit()



        System.Runtime.InteropServices.Marshal.ReleaseComObject(range)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(workbooks)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)

        range = Nothing
        worksheet = Nothing
        workbook = Nothing
        workbooks = Nothing
        excelApp = Nothing

        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Function

    Private Sub cmdButton_Click(sender As Object, e As EventArgs) Handles cmdButton02.Click, cmdButton01.Click, cmdButton08.Click
        Dim loChk As System.Windows.Forms.Button
        loChk = CType(sender, System.Windows.Forms.Button)

        Dim lnIndex As Integer
        lnIndex = Val(Mid(loChk.Name, 10))

        Select Case lnIndex
            Case 1 ' Browse file

                filePath = BrowseFile()
                txtField00.Text = filePath
                txtField01.Text = "5"
                pnRow = 5
                txtField02.Text = "1"
                pnCol = 1

            Case 2 ' Read file
                If Not String.IsNullOrEmpty(filePath) Then

                    ReadExcelFile()
                Else

                    MsgBox("Please Browse a File.", MsgBoxStyle.Information, "Info")
                End If
            Case 8 'close
                Me.Close()
                GoTo endProc
        End Select
endProc:
        Exit Sub
    End Sub

    Private Sub txtField_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtField01.KeyPress, txtField02.KeyPress

        If e.KeyChar = vbCr Then
            SetNextFocus()
        End If
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtField_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim loTxt As System.Windows.Forms.TextBox
        loTxt = CType(sender, System.Windows.Forms.TextBox)

        Dim loIndex As Integer
        loIndex = Val(Mid(loTxt.Name, 9))

        If Mid(loTxt.Name, 1, 8) = "txtField" Then
            Select Case loIndex
                Case 1
                    pnRow = Integer.Parse(loTxt.Text)
                Case 2
                    pnCol = Integer.Parse(loTxt.Text)

            End Select
        End If

        loTxt.BackColor = SystemColors.Window
        poControl = Nothing
    End Sub
End Class