   M S B A M L   `   `   `  ����K  G8GroupAssignment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:_8GroupAssignment.Items_8GroupAssignment.Items  5   	   &     _8GroupAssignment.Items.wndItems   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:_8GroupAssignment.Items     5   	     � Title$  wndItems��5   	   $��569.118��6   $��486.331��6+   .��5	      � ���	#FF9C9C9C.+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
dgItemView��5
      $	��399��6'   $��
10,10,10,0q�64   $	��Top=�6H      AutoGenerateColumns .     CanUserResizeColumns .     CanUserReorderColumns .  $��14(�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Code��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6R      
FontWeight$
 Bold"�6^   	   FontSize$	 16Q�6p   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 63   ��  �� Path$
 Code�   ElementStyle 5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value$ Right=�6D   5      5        5      $
 Cost��6%   $ 80 6b   $	 14Q�6m   
 63   �� $
 Cost� �� StringFormat$ c�� 5      �� 5      " ��6    .�5      ��  � ��$ Right=�6D   5      5        5      $ Description��6%   $ * 6`   $	 14Q�6j   
 6:   �� $ Description�6z   5      �� 5   
   -   5         ��Name$ btnDeleteItem��5      $��Delete��6(   $��50��69   $��186,450,185,0q�6E   $	��Top=�6\   
�������$
��Bold"�6�   �� 5    
   -   5        $ btnClose��5       $��Close��6#   $��
0,450,32,0q�63   $	��Top=�6G   $��50��6v   $��Right=�6�   $	��125��6�   
�������$
��Bold"�6�   �� 5!   
   -   5        $ 
btnAddItem��5!      $��Add Item��6%   $
��Left=�68   $��50��6S   $��
33,450,0,0q�6_   $	��Top=�6s   $	��125��6�   
�������$
��Bold"�6�   5#      5$      