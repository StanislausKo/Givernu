; The name of the installer
Name "Givernu"

; The file to write
OutFile "Givernu_Setup.exe"

; The default installation directory
InstallDir "$DESKTOP\Givernu"

; Request application privileges for Windows Vista
RequestExecutionLevel user

; Pages
Page Directory
Page Instfiles
;--------------------------------
; The stuff to install
Section "Files" 
  ; Set output path to the installation directory.
  ; CreateDirectory "$INSTDIR"
  SetOutPath "$INSTDIR"
  
  ; Put files there
  ; File "Binary\Debug\*.dll"
  File "Binary\Debug\Givernu.exe"
  
SectionEnd ; end the section
