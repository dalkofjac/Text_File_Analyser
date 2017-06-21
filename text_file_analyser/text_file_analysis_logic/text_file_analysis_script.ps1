# Script by Dalibor Kofjac, Jurica Bunic - FOI (2017)

# Path finding for c# frontend app
cd ..\..\..\text_file_analysis_logic

# Output paths
$rtfdumpOutputPath = ".\results\rtfdump_rezultati.txt"
$splitOutputPath = ".\results\split_rezultati.txt"
$base64dumpOutputPath = ".\results\base64dump_rezultati.txt"
$bytestatsOutputPath = ".\results\bytestats_rezultati.txt"
$filescannerOutputPath = ".\results\filescanner_rezultati.txt"
$researchOutputPath = ".\results\research_rezultati.txt"
$pdfconverterOutputPath = ".\results\pdfconverter_rezultati.txt"

# Text file path
$textFilePath = $args[2]

function Print-Info
{
 param( [string]$Name )
 Write-Output ""
 Write-Output "------------ $Name ------------"
 Write-Output ""
}

 $arg1 = $args[0]
 $arg2 = $args[1]

 switch ($arg1){
    1 {
        Print-Info -Name "rtfdump - rezultati" |  Out-File -filepath $rtfdumpOutputPath

        python .\programs\rtfdump\rtfdump.py $textFilePath |  Out-File -filepath $rtfdumpOutputPath -Append

        Start-Sleep -s 2

        Invoke-Item $rtfdumpOutputPath
    }
    2 {
        Print-Info -Name "split - rezultati" |  Out-File -filepath $splitOutputPath

        Write-Output "Datoteka uspjesno podijeljena na $arg2 instance/i" | Out-File -filepath $splitOutputPath -Append

        python .\programs\split\split.py -p $arg2 $textFilePath |  Out-File -filepath $splitOutputPath -Append

        Start-Sleep -s 2

        Invoke-Item $splitOutputPath
    }
    3 {
        Print-Info -Name "base64dump - rezultati" |  Out-File -filepath $base64dumpOutputPath

        python .\programs\base64dump\base64dump.py $textFilePath |  Out-File -filepath $base64dumpOutputPath -Append

        Start-Sleep -s 2

        Invoke-Item $base64dumpOutputPath
    }
    4 {
        Print-Info -Name "byte-stats - rezultati" |  Out-File -filepath $bytestatsOutputPath

        python .\programs\byte-stats\byte-stats.py -a $textFilePath |  Out-File -filepath $bytestatsOutputPath -Append

        Start-Sleep -s 2

        Invoke-Item $bytestatsOutputPath
    }
    5 {
        Print-Info -Name "filescanner - rezultati" |  Out-File -filepath $filescannerOutputPath

        .\programs\filescanner\FileScanner.exe -f $textFilePath |  Out-File -filepath $filescannerOutputPath -Append

        Start-Sleep -s 2

        Invoke-Item $filescannerOutputPath
    }
    6 {
        Print-Info -Name "re-search - rezultati" |  Out-File -filepath $researchOutputPath

        python .\programs\re-search\re-search.py -g $arg2 $textFilePath |  Out-File -filepath $researchOutputPath -Append

        Start-Sleep -s 2

        Invoke-Item $researchOutputPath
    }7 {
        Print-Info -Name "pdf-converter - rezultati" |  Out-File -filepath $pdfconverterOutputPath

        Write-Output "Datoteka uspjesno pretvorena u .pdf dokument" | Out-File -filepath $pdfconverterOutputPath -Append

        python .\programs\pdf_converter\pdf_converter.py $textFilePath

        Start-Sleep -s 2

        Invoke-Item $pdfconverterOutputPath
    }
    default { "Krivi unos!" }
}