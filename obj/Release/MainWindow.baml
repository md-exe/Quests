   M S B A M L   `   `   `  ���� A  =Quests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:QuestsQuests      Quests.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     &localclr-namespace:Quests     -     �Name$
  Form�� � Title$ 
MainWindow��$	��465��$	��700�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterOwner=� � WindowStyle$
 None=� � AllowsTransparency . .���  � ShowGridLines .   � ColumnDefinitions �� $	��180 ��� $��70 ��� $��* ��� $��* ��� $��* � � RowDefinitions �� $��25 ��� $��25 ��� �� �� �� �� .+��� 
���   �$��1q�$��5��$��7���� -   	 ��Name$	 
ToDoWindow��$��5��$��6��$��1��.+��� -   
 ��Name$
 Scroll����. $	��440��.��&   System.Windows.Controls.DataGrid  -     Name$ ToDoList��   AutoGenerateColumns .  $��4��$��15(�$��Cascadia Code)�   CanUserResizeRows .     AreRowDetailsFrozen . ��Z� ��Z�    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ Дата��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 180    CanUserResize .  1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ CreationDate�4  .System.Windows.Controls.DataGridCheckBoxColumn  -   
DoneColumn�� .  $ Готово?��$ 70  .   �� $ IsDone� �� UpdateSourceTrigger$ PropertyChanged=�   .  $ Задача��$ *  .     CanUserSort .  �� $ TaskText�   ElementStyle ��  �� 
TargetType" ��.���  �� Property � �� �� Value$
 Wrap=��� -   $	 ToolbarPanel��$��5�����#52506e.+��� -    ��Name$ CloseButton��$��Right=�$��2q�$��20��$��20�����#8c373c$��1q����#262533.���� -    ��Name$ 
CloseLabel��$��X��$��Cascadia Code)� �� TextAlignment$ Center=�$��Center=�$��Center=�$��17(�
��������� -	   $ MinimizeButton��$��Right=�$��
0 -24 27 0q�$��20��$��20��$��20(�
����������#3e4547$��1q����#262533$��Cascadia Code)�.���� -
   $ MinimizeLabel��$��-��$��Cascadia Code)�$ Center=�$��Center=�$��Center=�$��20(�
��������� ���#262533$��1q�