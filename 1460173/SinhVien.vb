Public Class SinhVien
    Private MSSV As Integer
    Private DiaChi As String
    Private HoTen As String
    Private DTB As Single

    Public Function createNode() As ListViewItem
        Dim res As New ListViewItem(Me.MSSV)
        res.SubItems.Add(Me.HoTen)
        res.SubItems.Add(Me.DiaChi)
        res.SubItems.Add(Me.DTB)
        Return res
    End Function

    Public Function getMSSV()
        Return MSSV
    End Function
    Public Sub setMSSV(ByVal mssv As Integer)
        Me.MSSV = mssv
    End Sub
    Public Function getDiaChi()
        Return DiaChi
    End Function
    Public Sub setDiaChi(ByVal diachi As String)
        Me.DiaChi = diachi
    End Sub
    Public Function getHoTen()
        Return HoTen
    End Function
    Public Sub setHoTen(ByVal hoten As String)
        Me.HoTen = hoten
    End Sub
    Public Function getDTB()
        Return DTB
    End Function
    Public Sub setDTB(ByVal dtb As Single)
        Me.DTB = dtb
    End Sub
End Class


