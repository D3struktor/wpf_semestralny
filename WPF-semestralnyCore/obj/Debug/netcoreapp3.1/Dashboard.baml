   M S B A M L   `   `   `  ����N  JWPF-semestralnyCore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:wpf_semestralnywpf_semestralny  5   	       wpf_semestralny.Dashboard   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:wpf_semestralny     5   	     � Title$  	Dashboard��5   	   $	��450��6   $	��800��6(   .��5	      � .+�5
   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ #9a9aa6��6'    � Offset$	 0.1Q�67   � 5      $ #aa23ba��6'   $	 1.5Q�67   5      5      �� 5      $��1��6   $
��Left=�6%   $	��100��6@   $��
490,50,0,0q�6M   $	��Top=�6a   $	��100��6y    J� OpacityMask 5      �� 5      -   5        Loog_dashboard�� �� ImageSource$ 	/logo.png��5   9    j� Stretch$
 Fill=�6Q    j� ViewboxUnits$ Absolute=�6`   	 j� ViewportUnits$	 Absolute=�6x   5      �� 5      $��Center=�6   .+�5      �� $��	/logo.png��6   $��50��6+   $��50��66   �� 5       $��Krakowski Klub Muzyczny��6   $��Light"�5!      $��	helvetica)�5"      $��22(�5#      
�������$��37��5%      $	��249��6(   5&      �� 5)      
 �� Orientation$
 
Horizontal=�6   $��0,50,0,0q�62   $��2��6D   �� 5*      $
 
Horizontal=�6   $��0,50,0,0q�62   $��2��6D   .+�5+      �� -   5        $��btnItems��5+      $	��150��6@   $��40��6L   $��Sprzet do wynajecia��6X   $��110,300,0,15q�6v   
�������6�   �� 5,      -   5         ��Name$ btnPerformance��5,      $	��150��6N   $��40��6Z   $��Lista koncertow��6f   $��60,300,60,15q�6�   
�������6�   �� 5-      -   5        $ btnStaff��5-      $	��150��6B   $��40��6N   $��Lista Pracownikow��6Z   $��0,300,60,15q�6v   
�������6�   5.      52      53      55      