   M S B A M L   `   `   `  ����L  HConwaysGameOfLife, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ConwaysGameOfLifeConwaysGameOfLife  5   	   "    ConwaysGameOfLife.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ConwaysGameOfLife     5   	     � Title$  Conways game of lief��5   	   $	��500��6&   $	��625��63   .��5	      ]� 
���������. .+�5   
   �� -   5         ��Name$ Controls��5      $��Right=�5      
���� ��$��Right=�5      $	��110��5       � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5      " ��6   .�5      ��  � ��
 �����69   �� 5       � ��$ 5q�65   �� 5       � ��$ Right=�6I   �� 5       � ��$ 8(�67   �� 5       � ��$ 45��64   5      5      .+�5      �� $��Controls��6   $��DemiBold"�5      �� 5-      -   5        $��Randomize Cells��5-      $��5q�5.      5/      �� 51       �� Orientation$ 
Horizontal=�6   .+�52      �� $��% Living : ��6   �� 53      $��5q�54      $��45��55      ��56      ��  �� Path$ LivingPercent� �� Mode$ TwoWay=�57      �� 58      $ 
Horizontal=�59      .+�5;      �� $��Height :��6   �� 5<      $��5q�5=      $��45��5>      ��5?      �� $ 
GridHeight�5@      �� 5B      $ 
Horizontal=�5C      .+�5E      �� $��Width : ��5F      �� 5H      $��5q�5I      $��45��5J      ��5K      �� *	GridWidth+5M      �� 5N      -   5        	 ��Name$	 RemakeBoard��5N      $��5q�5O      $��Remake Board��5P      6,   �� 5Q      
 � Maximum$
 60Q�6    � Minimum$ 1Q�5R      $	��100��5S      $��5q�5T       �� TickFrequency$ 1Q�5U       �� IsSnapToTickEnabled .  � Value 5V      �� $ Speed�$ TwoWay=�5W      �� 5Y      $ 
Horizontal=�6   .+�5Z      �� $��Auto :��6   �� 5[      ��6   �� $ 
PlayItself�$ OneWay=�5\      �� 5]      $ 
Horizontal=�6   .+�5^      �� $��Speed :��6   �� 5_      ��6   �� $ Speed�$ OneWay=�5`      �� 5a      $ 
Horizontal=�6   .+�5b      �� -   5        $��5q�5c      $
��Step��5d      $��45��5e      5f      �� 5g      -   5        $��5q�5h      $
��Play��5i      $��45��5j      5k      5l      5p      � 5r   
   -   5         �Name$ Board��5r      $
��Left=�5s      $��2q�5t       � DataContext$ GameController.Board��5u      5v      5w      5x      