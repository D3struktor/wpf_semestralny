   M S B A M L   `   `   `  ����N  JWPF-semestralnyCore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:wpf_semestralnywpf_semestralny  5   	   "    wpf_semestralny.Performances   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:wpf_semestralny     5   	     � Title$  Performances��5   	   $	��450��6   $	��800��6+   .��5	      � .+�5
   
   ��  �� CornerRadius$ 10��6   ��5      �� 5      .��5      �  � Color$ #9a9aa6��6#    � Offset$	 0.1Q�63   � 5      $ #aa23ba��6#   $	 1.5Q�63   5      5      �� 5   
   .+�5      �� -   5        $��btnBack��5      $	��100��6;   $��40��6G   $��Wróć��6S   $��
20,3,670,0q�6b   
�������6v   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Wystepy��5      $��Center=�6:   $	��Top=�6W      CanUserAddRows$
 True��6o      CanUserDeleteRows$ False��6�      AutoGenerateColumns$ False��6�   $	��800��6�   $��0,48,0,0q�6�   ��6$   Z�    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6%   
   
IsReadOnly$

 True��6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   ��  �� Path$ ID�6M     5      $	 Zespół��6%    65   �� $
 Name�  5      $	 Cena wstępu��6%    6:   �� $
 Cost�4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 Data Koncertu��6)      CellTemplate 5      �� 5      .R�5      (  "System.Windows.Controls.DatePicker     SelectedDateFormat$
 Long=�6)      FirstDayOfWeek$ Monday=�6f      SelectedDate 6C   �� $
 Date�6f   5      5       4  .System.Windows.Controls.DataGridComboBoxColumn  5!      -   5        ListaPracownikow��$	 	Pracownik��5!   C      SelectedValueBinding 6V   �� $ 	Pracownik�  5"      $	 Usuń��6)    5#      �� 5$      .R�5%      �� -   5        ��5%   %   �� $ ID�.��6]   Usun5'      5(      5*      5,      5-      5.      