# Titel              <PS-Backup-Skript>
# Autor              <Ameo Wehrli>
# Datum              <30.12.2020>
# Dokument-Name      <PS-Backup-Skript>

# ------------- #
# Backup Script #
# ------------- #



# ============= #
#     Prüfen    #
# ============= #
function CheckPath {

    param(
        [string]$CheckTopSrc, #Pfad von Source Struktur
        [string]$CheckTopBck, #Pfad von Backup Struktur
        [string]$CheckLogPath #Pfad von Logdatei Struktur
    )

    #Prüft ob alle drei Pfade vorhanden sind
    if (Test-Path -Path "$CheckTopSrc") {
        if (Test-Path -Path "$CheckTopBck") {
            if (Test-Path -Path "$CheckLogPath") {
                return 1
            }
        }
    }
    else {
        return 0
    }
}

# ============= #
#      Log      #
# ============= #
function Log {

    param
    (
        [string]$Path,                           #Pfad des zu logender Struktur
        [string]$LogPath,                        #Pfad von Logdatei
        [string]$LogFileName = "LogFile"         #Name von Logdatei
    )

    #Generieren von Logdateiname aus angegeben String und aktuellen Datum
    [string]$LogFileName = ((("$LogFileName " + (Get-Date -Format "dd/MM/yyyy hh:mm:ss")) -replace '\s', '_' -replace ':', '-') + ".txt")

    #Einmaliges Erstellen von Log-Datei
    New-Item -path $LogPath -name $LogFileName -ItemType file

    #Zusammenführung von Logdateiname und Pfad zu vollständigem Pfad
    $LogPath += ("\" + $LogFileName)
    
    write-host("Das zu Logende Verzeichis: $Path")
  
    #Erstellen von Header in Logdatei
    Add-Content -path $LogPath -value ("
    #########################################################
    #                Header zu BackUp-Skript                #
    #########################################################

    Das zu Logende Verzeichis: $Path")

    [string]$RecursivePath = $Path

    #Rekursive Schlaufe zum erreichen von jeder Datei und Ordner
    Get-ChildItem -Path $RecursivePath | 
    ForEach-Object {

        #Prüfung ob es sich um einen Ordner handelt
        if (Test-Path -Path $_.FullName -PathType Container) {
           
            #Erstellen von Logeintrag
            Add-Content -path $LogPath -value ((Get-Date -Format "dddd dd/MM/yyyy hh:mm:ss") + " | Created by PS-Backup-Skript" + " | Folder | " + $_.FullName)
            
            #Aktualisierung von Pfad
            $RecursivePath = ($RecursivePath + "\" + $_.Name)

            #Wiederholung von oben
            Get-ChildItem -Path $RecursivePath | ForEach-Object {

                if (Test-Path -Path $_.Fullname -PathType Container) {
           
                    Add-Content -path $LogPath -value ((Get-Date -Format "dddd dd/MM/yyyy hh:mm:ss") + " | Created by PS-Backup-Skript" + " | Folder | " + $_.FullName)
                    
                    $RecursivePath = ($RecursivePath + "\" + $_.Name)

                    #Wiederholung von oben
                    Get-ChildItem -Path $RecursivePath | ForEach-Object {
                        

                        if (Test-Path -Path $_.Fullname -PathType Container) {
           
                            Add-Content -path $LogPath -value ((Get-Date -Format "dddd dd/MM/yyyy hh:mm:ss") + " | Created by PS-Backup-Skript" + " | Folder | " + $_.FullName)
                            
                            $RecursivePath = ($RecursivePath + "\" + $_.Name)

                            #Wiederholung von oben
                            Get-ChildItem -Path $RecursivePath | ForEach-Object {
                                
                                Add-Content -path $LogPath -value ((Get-Date -Format "dddd dd/MM/yyyy hh:mm:ss") + " | Created by PS-Backup-Skript" + " |  File  | " + $_.FullName)

                            }
                            
                            $RecursivePath = Split-Path -Path $RecursivePath

                        }
                        else {
                            
                            Add-Content -path $LogPath -value ((Get-Date -Format "dddd dd/MM/yyyy hh:mm:ss") + " | Created by PS-Backup-Skript" + " |  File  | " + $_.FullName)

                        }
                    }

                    $RecursivePath = Split-Path -Path $RecursivePath

                }
                else {
                    Add-Content -path $LogPath -value ((Get-Date -Format "dddd dd/MM/yyyy hh:mm:ss") + " | Created by PS-Backup-Skript" + " |  File  | " + $_.FullName)
                }
            }

            $RecursivePath = Split-Path -Path $RecursivePath
 
        }
        #Handelt es sich nicht um einen Ordner, so wird einfach ein Logeintrag erstellt.
        else {
            Add-Content -path $LogPath -value ((Get-Date -Format "dddd dd/MM/yyyy hh:mm:ss") + " | Created by PS-Backup-Skript" + " |  File  | " + $_.FullName)
        }
    }

    #Rückgabe des vollständigen Pfades der Logdatei
    return [string]$LogPath
}


# ============= #
#    Kopieren   #
# ============= #
function PS-Backup-Skript {
    
    param
        (
            [string]$Src,              #Pfad von Source Struktur
            [string]$Bck,              #Pfad von Backup Struktur
            [string]$LogPath,          #Pfad von Logdatei
            [string]$CopyLogFileName   #Name von Logdatei
         )

    #Generieren von Logdateiname aus angegeben String und aktuellen Datum
    [string]$CopyLogFileName = ((("$CopyLogFileName " + (Get-Date -Format "dd/MM/yyyy hh:mm:ss")) -replace '\s', '_' -replace ':', '-') + ".txt")

    #Einmaliges Erstellen von Log-Datei
    New-Item -path $LogPath -name $CopyLogFileName -ItemType file

    #Zusammenführung von Logdateiname und Pfad zu vollständigem Pfad
    $LogPath += ("\" + $CopyLogFileName)

    write-host("Das Source Verzeichis: " + $Src)
    write-host("Das Destination Verzeichnis: " + $Bck)

    #Erstellen von Header in Logdatei
    Add-Content -path $LogPath -value ("
    #########################################################
    #                Header zu BackUp-Skript                #
    #########################################################

    Das Source Verzeichis     : $Src
    Das Backup Verzeichnis    : $Bck
    
    ")

    [string]$RecursiveSrc = $Src
    [string]$RecursiveBck = $Bck

    #Rekursive Schlaufe zum erreichen von jeder Datei und Ordner
    Get-ChildItem -Path $RecursiveSrc | 
    ForEach-Object {

        #Prüfung ob es sich um einen Ordner handelt
        if (Test-Path -Path $_.FullName -PathType Container) {
           
            #Erstellen von Ordner in Backup Struktur
            New-Item -Path $RecursiveBck -Name $_.Name -ItemType Directory
            #Erstellen von Logeintrag
            Add-Content -path $LogPath -value ((Get-Date -Format "dddd dd/MM/yyyy hh:mm:ss") + " | Created by PS-Backup-Skript" + " | Folder | " + $_.FullName)

            #Aktualisierung von Pfad
            $RecursiveSrc = ($RecursiveSrc + "\" + $_.Name)
            $RecursiveBck = ($RecursiveBck + "\" + $_.Name)

            #Wiederholung von oben
            Get-ChildItem -Path $RecursiveSrc | ForEach-Object {

                if (Test-Path -Path $_.Fullname -PathType Container) {
           
                    
                    New-Item -Path $RecursiveBck -Name $_.Name -ItemType Directory
                    Add-Content -path $LogPath -value ((Get-Date -Format "dddd dd/MM/yyyy hh:mm:ss") + " | Created by PS-Backup-Skript" + " | Folder | " + $_.FullName)
                    
                    $RecursiveSrc = ($RecursiveSrc + "\" + $_.Name)
                    $RecursiveBck = ($RecursiveBck + "\" + $_.Name)

                    Get-ChildItem -Path $RecursiveSrc | ForEach-Object {
                        

                        if (Test-Path -Path $_.Fullname -PathType Container) {
           
                            
                            New-Item -Path $RecursiveBck -Name $_.Name -ItemType Directory
                            Add-Content -path $LogPath -value ((Get-Date -Format "dddd dd/MM/yyyy hh:mm:ss") + " | Created by PS-Backup-Skript" + " | Folder | " + $_.FullName)
                            
                            $RecursiveSrc = ($RecursiveSrc + "\" + $_.Name)
                            $RecursiveBck = ($RecursiveBck + "\" + $_.Name)

                            Get-ChildItem -Path $RecursiveSrc | ForEach-Object {
                                
                                Copy-Item -Path $_.FullName -Destination $RecursiveBck
                                Add-Content -path $LogPath -value ((Get-Date -Format "dddd dd/MM/yyyy hh:mm:ss") + " | Created by PS-Backup-Skript" + " |  File  | " + $_.FullName)

                            }
                            
                            $RecursiveSrc = Split-Path -Path $RecursiveSrc
                            $RecursiveBck = Split-Path -Path $RecursiveBck

                        }
                        else {
                            
                            Copy-Item -Path $_.FullName -Destination $RecursiveBck
                            Add-Content -path $LogPath -value ((Get-Date -Format "dddd dd/MM/yyyy hh:mm:ss") + " | Created by PS-Backup-Skript" + " |  File  | " + $_.FullName)

                        }
                    }

                    $RecursiveSrc = Split-Path -Path $RecursiveSrc
                    $RecursiveBck = Split-Path -Path $RecursiveBck

                }
                else {
                    Copy-Item -Path $_.FullName -Destination $RecursiveBck
                    Add-Content -path $LogPath -value ((Get-Date -Format "dddd dd/MM/yyyy hh:mm:ss") + " | Created by PS-Backup-Skript" + " |  File  | " + $_.FullName)
                }
            }

            $RecursiveSrc = Split-Path -Path $RecursiveSrc
            $RecursiveBck = Split-Path -Path $RecursiveBck
 
        }
        #Handelt es sich nicht um einen Ordner, so wird einfach ein Logeintrag erstellt.
        else {

            Copy-Item -Path $_.FullName -Destination $RecursiveBck
            Add-Content -path $LogPath -value ((Get-Date -Format "dddd dd/MM/yyyy hh:mm:ss") + " | Created by PS-Backup-Skript" + " |  File  | " + $_.FullName)
        }
    }

    #Rückgabe des vollständigen Pfades der Logdatei
    return [string]$LogPath
}

# ============= #
#  Validierung  #
# ============= #
function CheckBck{

    param(
        #[string]$LogPath,             #Pfad von Source Struktur
        [string]$SrcLogFilePath,       #Pfad von Sourcelogdatei
        [string]$CopyLogFilePath,      #Pfad von Copylogdatei
        [string]$BckLogFilePath        #Prad von Backuplogdatei
    )

    #Zählen der Anzahl Linien in den Logdateiten
    [int]$AnzSrcFiles = (Get-Content -Path $SrcLogFilePath | Measure-Object –Line).Lines
    [int]$AnzBckFiles = (Get-Content -Path $BckLogFilePath | Measure-Object –Line).Lines

    #Zwischenspeichern von aktuellem Datum
    [string]$TempDate = (Get-Date -Format "dddd dd/MM/yyyy hh:mm:ss")

    #Eintrag in Logdatei
    Add-Content -Path $CopyLogFilePath -value ("
    $TempDate | Validation created by PS-Backup-Skript
        
    Anzahl Files in Source Struktur: $AnzSrcFiles
    Anzahl Files in Backup Struktur: $AnzBckFiles")

    if($AnzSrcFiles -eq $AnzBckFiles){
        #Vorgang erfolgreich
        write-host("`tDer Vorgang war erfolgreich!")
        Add-Content -Path $CopyLogFilePath -value ("`n`tDer Vorgang war erfolgreich!")

    } else {
        #Vorgang nicht erfolgreich
        write-host("`tDer Vorgang war nicht erfolgreich!")
        Add-Content -Path $CopyLogFilePath -value ("`n`tDer Vorgang war nicht erfolgreich!")
    }
}


# ============= #
# HauptFunktion #
# ============= #
function BackupMain() {
    param(
        [string]$TopSrc = "C:\TopSrc",  #Pfad von Source Struktur
        [string]$TopBck = "C:\TopBck",  #Pfad von Backup Struktur
        [string]$LogPath = "C:\TopTop"  #Pfad von Logdatei
    )                                   

    [string]$ConstSrcLogFileName = "SrcLogFile"       #Standartname von Sourcelogdatei
    [string]$ConstCopyLogFileName = "CopyLogFile"     #Standartname von Copylogdatei
    [string]$ConstBckLogFileName = "BckLogFile"       #Standartname von Backuplogdatei
                                                      
    #Überprüfung ob Pfade existieren
    if (CheckPath $TopSrc $TopBck $LogPath -eq 1) {
        write-host Angegebener Pfad Vorhanden
        
        #Source Verzeichnis logen
        $SrcLogFilePath = Log $TopSrc $LogPath $ConstSrcLogFileName

        #Files kopieren
        $CopyLogFilePath = PS-Backup-Skript $TopSrc $TopBck $LogPath $ConstCopyLogFileName

        #Backup Verzeichnis logen
        $BckLogFilePath = Log $TopBck $LogPath $ConstBckLogFileName

        #Überprüfung des Backups
        CheckBck $SrcLogFilePath.FullName $CopyLogFilePath[0].FullName $BckLogFilePath.FullName

    }
    #Fehler -> Abbrechen
    else { write-host Nicht Vorhanden }

}


# ============= #
#   Ausführen   #
# ============= #

# BackupMain *Source Pfad* *Backup Pfad* *Logdatei Pfad*