   M S B A M L   `   `   `  ????I  EAdministration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AdministrationAdministration  5   	   +    %Administration.pettype_administration   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Administration     5   	     ? Title$  pettype_administration??5   	   $	??198??6(   $	??231??65   $	??198??6A   $	??231??6Q   .??5	      ? ???	#B2B9B9B9 ? RowDefinitions 5
   
   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   .+?5   
   ? $??Center=?6   $??26??6,   $??Center=?68   $	??211??6S    ? ColumnDefinitions 5      ?? 5      $??2* ?6#   ?? 5      $
??205* ?6#   .+?5      ?? -   5         ??Name$ typeslbl??5      $??	TÍPUSOK:??6&   $
??Left=?69   $??Center=?6T   $??Cascadia Code)?6o   $??2??6?   ?? 5      -   5         ??Name$ typescb??5      $
??Left=?6(   $??64,0,0,0q?6C   $??Center=?6U   $	??140??6p   $??Cascadia Code)?6|   $??1??6?   .@?5      ?? $??
ÚJ TÍPUS??6   5      5      ? 5   
   $??Center=?6   $??40??6,   $??0,0,0,0q?68   $??1??6I   $??Center=?6V   $	??178??6q   .+?5      ?? -   5        $ 
newtypelbl??5      $??Új típus megnevezése:??6(   $??Center=?6H   $	??Top=?6e   $??Cascadia Code)?6}   ?? 5      -   5         ??Name$ 	newtypetb??5      $??Center=?6)   $??0,24,0,0q?6F   $	??Top=?6X    ?? TextWrapping$
 Wrap=?6p   $	??120??6?   $??Cascadia Code)?6?   5      ?? 5   
   -   5         ??Name$ delete??5      $??2??6   $??TÖRLÉS??6.   $??Center=?6?   $??0,0,70,0q?6\   $??Center=?6n   $??Cascadia Code)?6?   6?   ?? 5   
   -   5        $
 save??5      $??2??6   $??MENTÉS??6,   $??Center=?6=   $??70,0,0,0q?6Z   $??Center=?6l   $??Cascadia Code)?6?   6?   ?? 5    
   -   5        $
 back??5       $??3??6   $??VISSZA??6,   $??Center=?6=   $??0,0,0,0q?6Z   $??Center=?6k   $??Cascadia Code)?6?   6?   5!      5"      