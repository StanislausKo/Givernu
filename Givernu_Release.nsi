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
  ; File "Binary\Release\*.dll"
  File "Binary\Release\Givernu.exe"
  
SectionEnd ; end the section


!define NameStr "Givernu" ; The string that the context menu will display
 
Section "ADDME"
  SetOutPath "$INSTDIR"
  WriteRegStr HKCR "exefile\shell\${NameStr}\command" "" "Givernu.exe"
  ;File "Givernu.exe"
SectionEnd
