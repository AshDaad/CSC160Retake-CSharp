   M S B A M L   `   `   `  ����N  JDataBindingExercise, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:DataBindingExerciseDataBindingExercise  5   	   $    DataBindingExercise.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:DataBindingExercise     5   	     � Title$  Random Person Generator��5   	   $	��350��6)   $	��525��66   .��5	      � -   5         �Name$ MainGrid��5	       � RowDefinitions 5
   
   �� 5      �� 5      $��3* �6   .+�5   
   � -   5        $ 
ButtonGrid��5      $��0��5      ���#8FAE44 � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� -   5         ��Name$ Randomise_Button��5      $��0��5      $��	Randomise��5      $	��100��5      $��50��5      $
��Left=�5      $
��10 5q�5      5      �� 5       -   5        $ Close_Button��5       $��1��5!      $��Close��5"      $	��100��5#      $��50��5$      $��Right=�5%      $
��10 5q�5&      5'      5(      � 5+   
   -   5        $ 	LabelGrid��5+      $��1��5,      ���#8E3870 5.      �� 50      $��2* �6#   �� 51      $��2* �6#    54      �� 55      �� 56      �� 57      �� 58      �� 59      .+�5<      �� -   5         ��Name$ 	NameLabel��5<      $��0��5=      $��1��5>      $��Name:��5?      $��	10 10 0 0q�5@      $��Right=�5A      $��14(�5B      $
��Bold"�5C      �� 5E      -   5        $ AgeLabel��5E      $��0��5F      $��2��5G      $
��Age:��5H      $��	10 10 0 0q�5I      $��Right=�5J      $��14(�5K      $
��Bold"�5L      �� 5N      -   5        $ GenderLabel��5N      $��0��5O      $��3��5P      $��Gender:��5Q      $��	10 10 0 0q�5R      $��Right=�5S      $��14(�5T      $
��Bold"�5U      �� 5X      -	   5        $ NameOutputLabel��5X      $��1��5Y      $��1��5Z      $��	0 10 10 0q�5[      $
��Left=�5\      $��14(�5]      $
��Bold"�5^      ��5_      ��  �� Path$
 Name� �� Mode$ OneWay=��� 5`      -
   5        $ AgeOutputLabel��5`      $��1��5a      $��2��5b      $��	0 10 10 0q�5c      $
��Left=�5d      $��14(�5e      $
��Bold"�5f      ��5g      �� $	 Age�$ OneWay=��� 5h      -   5        $ GenderOutputLabel��5h      $��1��5i      $��3��5j      $��	0 10 10 0q�5k      $
��Left=�5l      $��14(�5m      $
��Bold"�5n      ��5o      �� $ Gender�$ OneWay=�5q      5r      5s      