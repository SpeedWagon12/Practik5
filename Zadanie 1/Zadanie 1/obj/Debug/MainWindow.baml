   M S B A M L   `   `   `  ����D  @Zadanie 1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Zadanie_1	Zadanie_1  5   	       Zadanie_1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Zadanie_1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��500��6)    � 
ResizeMode$ NoResize=�65   $��Candara)�6K   .��5	      �  � RowDefinitions 5
   
   �� 5      $��70 �6   6*   �� 5      $	��150 �6   6+   �� 5      6   �� 5      $��70 �6   6+    � ColumnDefinitions 5   
   �� 5      $	��160 �6   6-   �� 5      6!   .+�5   
   �� $��Данные:   ��6   $��Right=�6&   $��Center=�6B   $��10,6,0,6q�6]   $��17(�6o   �� 5   
   $%��Входные данные:   ��6   $��1��60   $��Right=�6=   $	��Top=�6Y   $��	15,15,0,0q�6q   $��17(�6�   �� 5   
   -   5        $��Answer��5      $��    Ответ: ��6"   $��2��65   $��0��6B   $��2��6R   $��17(�6f   $
��Left=�6t   $��Stretch=�6�   $��15q�6�   �� 5   
   -   5        $	��Dan��5      $��1��6   $
��Left=�6-   $��Center=�6H   $��80��6k   $��2q�6v   $��
10,10,0,10q�6�   $
��10 0q�6�   �� 5   
   -   5        $��BtnAdd��5      $��Добавить��6   $��1��62   $��119,10,8,10q�6B   ���#fff65a
���   �6   �� 5   
   -   5        $��ListBoxData��5      $��1��6%   $��1��62   $��Visible=�6B   $
��10 0q�6u   $��1q�6�   �� 5   
   $��3��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��
100,0,83,0q�6X   $	��300��6l   $��2��6x   .+�5       �� -   5         ��Name$ BtnOK��5       $��OK��6$   $��80��5!      $��24��6   $��25q�6   ���#fff65a
���   � �� 	IsDefault . 5%      �� 5&      -   5        $ 	BtnCancel��5&      $��Cancel��6(   $��80��5'      $��24��6   $��3q�6   ���#fff65a
���   � �� IsCancel . 5*      5,      5-      5.      