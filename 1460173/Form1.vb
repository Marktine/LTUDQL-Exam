Imports System.IO
Public Class Form1
    Dim SoLuong As Integer
    Dim lst As New List(Of SinhVien)
    Sub DocFile()
        Dim line As String
        Dim reader As New StreamReader("input.txt")
        SoLuong = reader.ReadLine()
        While reader.Peek() >= 0
            Dim sv As New SinhVien()
            line = reader.ReadLine()
            Dim temp = line.Split(vbTab)
            sv.setMSSV(Integer.Parse(temp(0)))
            sv.setHoTen(temp(1))
            sv.setDiaChi(temp(2))
            sv.setDTB(Single.Parse(temp(3)))
            lst.Add(sv)
        End While
        reader.Close()
    End Sub
    Sub LuuFile()
        Dim w As New StreamWriter("output.txt")
        w.WriteLine(lst.Count)
        For i As Integer = 0 To lst.Count - 1 Step 1
            w.WriteLine(String.Format("{0}    {1} {2}  {3}", lst(i).getMSSV(), lst(i).getHoTen, lst(i).getDiaChi(), lst(i).getDTB()))
        Next
        w.Close()
        MessageBox.Show("Lưu file thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DocFile()
        For i As Integer = 0 To lst.Count - 1
            lvSinhVien.Items.Add(lst(i).createNode())
        Next
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim sv As New SinhVien
        sv.setMSSV(Integer.Parse(txtMSSV.Text))
        sv.setHoTen(txtHoTen.Text)
        sv.setDiaChi(txtDiaChi.Text)
        sv.setDTB(Single.Parse(txtDTB.Text))
        lst.Add(sv)
        lvSinhVien.Items.Add(sv.createNode)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        LuuFile()
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        lvSinhVien.Items.Clear()
        lst.Clear()
        DocFile()
        lvSinhVien.View = View.Details
        For i As Integer = 0 To lst.Count - 1
            lvSinhVien.Items.Add(lst(i).createNode())
        Next
    End Sub
End Class
