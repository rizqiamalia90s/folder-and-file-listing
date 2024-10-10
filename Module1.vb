Imports System.IO 'kelas/fungsi untk operasi i/o
Imports System.Threading 'kelas/fungsi untk operasi thread

Module Module1

    Sub Main()
        Dim folderPath As String = "C:\Users\L13\Desktop\fsy" 'menyesuaikan path mana yang akan di baca

        'periksa apakah folder ada
        If Directory.Exists(folderPath) Then
            'nenampilkan folder-folder
            Console.WriteLine("Daftar Folder:")
            Dim directories As String() = Directory.GetDirectories(folderPath)
            For Each dir As String In directories
                Console.WriteLine(Path.GetFileName(dir))
                Thread.Sleep(200)
            Next
            'menampilkan file-file
            Console.WriteLine(vbNewLine & "Daftar File:")
            Dim files As String() = Directory.GetFiles(folderPath)
            For Each file As String In files
                Console.WriteLine(Path.GetFileName(file))
                Thread.Sleep(200)
            Next
        Else
            Console.WriteLine("Folder tidak ditemukan.")
        End If

        'ending
        Console.WriteLine(vbNewLine & "Tekan sembarang tombol untuk keluar...")
        Console.ReadKey()
    End Sub

End Module
