   M S B A M L   `   `   `  ����D  @Dictonary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Dictonary	Dictonary  5   	       Dictonary.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Dictonary     5   	     � Title$  Словарь��5   	   $	��374��6   $	��524��6&   .��5	      � .+�5
   
   �� -   5         ��Name$ StackPanelMain��5
       �� Orientation$ Vertical=�6-   .+�5      �� $ Vertical=�6   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��24��6   $��24��6'   $$��../Resources/FlagOfBritany.png��63   $��5px, 0, 0, 0q�6[   �� 5      .��6   /-Введите слово для поиска66   �� 5      -   5         ��Name$! ButtonClearTextBoxSearching��5   D   
�������
�������.��5      �� $��16��6    $��16��6+   $��../Resources/Clear.png��67   $��
0, 0, 0, 0q�6W   5      5      �� 5      -   5         ��Name$ TextBoxWordForSearch��5      6h   5      �� 5      $ Vertical=�6   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��24��6   $��24��6'   $#��../Resources/FlagOfRussia.png��63   $��5px, 0, 0, 0q�6Z   �� 5      .��6   Перевод6%   �� 5      -   5        $% ButtonClearTextBoxTranslateWord��5   D   
�������
�������.��5      �� $��16��6    $��16��6+   $��../Resources/Clear.png��67   $��
0, 0, 0, 0q�6W   5      5      �� 5      -   5        $ TextBoxTranslatingWord��5   ,    �� 
IsReadOnly$
 True��6   6N   �� 5      -   5        $ ButtonAddWord��5      $
��25px��60   $��100px��6>   $
��Left=�6L   $��5px, 5, 0, 5q�6g   .��6�   Добавить слово6�   5      �� 5       -   5         ��Name$ ListBoxAllWords��5    7   ��6P   ��  �� ElementName$ StackPanelMain�� �� Path$ ActualHeight�	 � ContextMenu	 5!      �� 5"      -   5        
 ��Name$
 ContexMenuForListBox��5"   "   .@�5#      m� -	   5         m�Name$ ContextMenuItemTranslate��5#   #   $��Перевести��6k   6�   m� 5$      -
   5        $ ContextMenuItemDeleteWord��5$   #   $��Удалить��6m   6�   5%      5'      5(      5)      5*      