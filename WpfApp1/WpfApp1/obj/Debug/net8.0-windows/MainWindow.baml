   M S B A M L   `   `   `  ����  WpfApp1    WpfApp1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Gyümölcs Adatok��5   	   $	��450��6!   $	��800��6.   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��2��6   $!��Gyümölcs Adatok Kezelése��61   $��24(�6T   $
��Bold"�6b   $��Center=�6t   $��10q�6�   �� 5   
   -   5         ��Name$ lista��5      $��1��6!   $��2��6.   $��10q�6B   �� 5   
   -   5         ��Name$ betoltes��5      $��2��6#   $��0��60   $��Adatok betöltése��6@   $��10q�6[   6g   �� 5   
   -   5        $ atlag��5      $��2��6    $��1��6-   $��Átlag számítása��6=   $��10q�6W   6c   �� 5   
   -   5        $ osszeg��5      $��3��6!   $��0��6.   $��Összeg számítása��6>   $��10q�6Y   6e   �� 5   
   -   5        $ maximum��5      $��3��6"   $��1��6/   $��Maximum keresése��6?   $��10q�6Z   6f   �� 5    
   -   5         ��Name$ eredmenyTextBlock��5       $��4��6/   $��2��6<   $��10q�6P   $��16(�6\   $
��Wrap=�6j   5!      5"      