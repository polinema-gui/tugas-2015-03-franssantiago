Public Class matrik_kalkulator
    Dim cekkolom As Boolean = True
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Dim barisMatrik1 As Integer = matrik1.Lines.Count
            Dim kolomMatrik1 As Integer = matrik1.Lines.ElementAt(0).Split(" ").Length
            Dim barisMatrik2 As Integer = matrik2.Lines.Count
            Dim kolomMatrik2 As Integer = matrik2.Lines.ElementAt(0).Split(" ").Length
            Dim copyMatrik1(barisMatrik1, kolomMatrik1) As Integer
            Dim copyMatrik2(barisMatrik2, kolomMatrik2) As Integer
            cek(barisMatrik1, barisMatrik2, kolomMatrik1, kolomMatrik2)
            copyToArray(barisMatrik1, barisMatrik2, kolomMatrik1, kolomMatrik2, copyMatrik1, copyMatrik2)
            operasi(copyMatrik1, copyMatrik2, barisMatrik1, kolomMatrik2)
        Catch ex As Exception
            MsgBox("Masukan Bukan Angka")

        End Try
    End Sub
    Private Sub copyToArray(ByVal baris1 As Integer, baris2 As Integer, kolom1 As Integer, kolom2 As Integer, ByRef nilai1(,) As Integer, ByRef nilai2(,) As Integer)
        If (Me.cekkolom) Then
            For baris As Integer = 0 To baris1 - 1
                For kolom As Integer = 0 To kolom1 - 1
                    nilai1(baris, kolom) = matrik1.Lines.ElementAt(baris).Split(" ").ElementAt(kolom)
                    nilai2(baris, kolom) = matrik2.Lines.ElementAt(baris).Split(" ").ElementAt(kolom)
                Next
            Next
        End If
    End Sub
    Private Sub cek(ByVal baris1 As Integer, baris2 As Integer, kolom1 As Integer, kolom2 As Integer)
        Dim tmp As Boolean = True
        For baris = 0 To baris1 - 2
            If (matrik1.Lines.ElementAt(baris).Split(" ").Length <> matrik1.Lines.ElementAt(baris + 1).Split(" ").Length) Then
                tmp = False
            End If
        Next
        For baris = 0 To baris2 - 2
            If (matrik2.Lines.ElementAt(baris).Split(" ").Length <> matrik2.Lines.ElementAt(baris + 1).Split(" ").Length) Then
                tmp = False
            End If
        Next
        If (tmp = False) Then
            Me.cekkolom = False
            Convert.ToInt32(matrik1.Text)
            Convert.ToInt32(matrik2.Text)
            MsgBox("Matriks Tidak Valid")
        ElseIf (baris1 = baris2 And kolom1 = kolom2) Then
            Me.cekkolom = True
        Else
            Me.cekkolom = False
            MsgBox("Baris dan Kolom Semua Matriks Harus Sama")
        End If
    End Sub
    Private Sub operasi(ByVal matriks1(,) As Integer, matriks2(,) As Integer, batasBaris As Integer, batasKolom As Integer)
        Dim hasil As String = ""
        If (Me.cekkolom) Then
            Select Case ComboBox1.Text
                Case "Tambah"
                    For baris As Integer = 0 To batasBaris - 1
                        For kolom As Integer = 0 To batasKolom - 1
                            hasil &= (matriks1(baris, kolom) + matriks2(baris, kolom)).ToString & vbTab
                        Next
                        hasil &= vbNewLine
                    Next
                Case "Kurang"
                    For baris As Integer = 0 To batasBaris - 1
                        For kolom As Integer = 0 To batasKolom - 1
                            hasil &= (matriks1(baris, kolom) - matriks2(baris, kolom)).ToString & vbTab
                        Next
                        hasil &= vbNewLine
                    Next
                Case Else
                    MsgBox("Anda Belum Memilih Operasi")
            End Select
            TextBox4.Text = hasil
        End If
    End Sub
End Class