   M S B A M L   `   `   `  ????I  EAdministration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AdministrationAdministration  5   	   +    %Administration.petmood_administration   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Administration     5   	     ? Title$  petmood_administration??5   	   $	??178??6(   $	??234??65   $	??178??6A   $	??234??6Q   .??5	      ? ???	#B2B9B9B9 ? RowDefinitions 5
   
   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   .+?5   
   ? $??Center=?6   $??24??6,   $??0,0,0,0q?68   $??Center=?6I   $	??207??6d   .+?5      ?? -   5         ??Name$ moodslbl??5      $??HANGULATOK:??6&   $
??Left=?6<   $??Center=?6W   $??Cascadia Code)?6r   ?? 5      -   5         ??Name$ moodscb??5      $
??Left=?6(   $??87,0,0,0q?6C   $??Center=?6U   $	??120??6p   $??Cascadia Code)?6|   .@?5      ?? $??ÚJ HANGULAT??6    ?? 
IsSelected$
 True??65   6I   5      5      ? 5   
   $??Center=?6   $??40??6,   $??0,0,0,0q?68   $??1??6I   $??Center=?6V   $	??178??6q   .+?5      ?? -   5        $ 
newmoodlbl??5      $ ??Új hangulat megnevezése:??6(   $??Center=?6K   $	??Top=?6h   $??Cascadia Code)?6?   ?? 5      -   5         ??Name$ 	newmoodtb??5      $??Center=?6)   $??0,24,0,0q?6F   $	??Top=?6X    ?? TextWrapping$
 Wrap=?6p   $	??120??6?   $??Cascadia Code)?6?   5      ?? 5   
   -   5         ??Name$ delete??5      $??2??6   $??TÖRLÉS??6.   $??Center=?6?   $??0,0,70,0q?6\   $??Center=?6n   $??Cascadia Code)?6?   6?   ?? 5   
   -   5        $
 save??5      $??2??6   $??MENTÉS??6,   $??Center=?6=   $??70,0,0,0q?6Z   $??Center=?6l   $??Cascadia Code)?6?   6?   ?? 5   
   -   5        $
 back??5      $??3??6   $??VISSZA??6,   $??Center=?6=   $??0,0,0,0q?6Z   $??Center=?6k   $??Cascadia Code)?6?   6?   5      5      