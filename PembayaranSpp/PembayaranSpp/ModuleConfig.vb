Imports System.Data.OleDb
Module ModuleConfig
    Public ds As DataSet
    Public conn As OleDbConnection
    Public da As OleDbDataAdapter
    Public dr As OleDbDataReader
    Public cmd As OleDbCommand
    Public lokasidata

    Sub koneksiDB()
        Try
            lokasidata = "provider = Microsoft.ACE.OLEDB.12.0; data source = okeDB.accdb"
            conn = New OleDbConnection(lokasidata)
            conn.Open()
            'MsgBox("Sukses")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
