   M S B A M L   `   `   `  ���� D  @Dictonary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Dictonary	Dictonary      Dictonary.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:Dictonary       � Title$  Словарь��$	��374��$	��524��.��� .+��� -    ��Name$ StackPanelMain�� �� Orientation$ Vertical=�.+��� $ Vertical=�.+��� $ 
Horizontal=�.+��� $��24��$��24��$$��../Resources/FlagOfBritany.png��$��5px, 0, 0, 0q��� .��/-Введите слово для поиска�� -    ��Name$! ButtonClearTextBoxSearching��
�������
�������.���� $��16��$��16��$��../Resources/Clear.png��$��
0, 0, 0, 0q��� -    ��Name$ TextBoxWordForSearch���� $ Vertical=�.+��� $ 
Horizontal=�.+��� $��24��$��24��$#��../Resources/FlagOfRussia.png��$��5px, 0, 0, 0q��� .��Перевод�� -   $% ButtonClearTextBoxTranslateWord��
�������
�������.���� $��16��$��16��$��../Resources/Clear.png��$��
0, 0, 0, 0q��� -   $ TextBoxTranslatingWord�� �� 
IsReadOnly$
 True���� -   $ ButtonAddWord��$
��25px��$��100px��$
��Left=�$��5px, 5, 0, 5q�.��Добавить слово�� -    ��Name$ ListBoxAllWords������  �� ElementName$ StackPanelMain�� �� Path$ ActualHeight�	 � ContextMenu	 �� -   
 ��Name$
 ContexMenuForListBox��.@�m� -	    m�Name$ ContextMenuItemTranslate��$��Перевести��m� -
   $ ContextMenuItemDeleteWord��$��Удалить��