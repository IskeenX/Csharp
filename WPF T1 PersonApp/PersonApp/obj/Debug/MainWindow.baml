   M S B A M L   `   `   `  ����D  @PersonApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PersonApp	PersonApp  5   	       PersonApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PersonApp     5   	     � Title$  Person Application��5   	   $	��350��6$   $	��525��61   $��18(�6=   $��Segoe UI Light)�6K   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��1��6$   $��28(�61   $��Personal Information��5      $��3��60   $��0,0,0,10q�5      �� 5!   
   $��1��6   $��2��6$   $��SemiBold"�61   $��
First Name��5"      $��Segoe UI)�6&   �� 5#   
   $��1��6   $��3��6$   $��SemiBold"�61   $��	Last Name��5$      $��Segoe UI)�6%   �� 5&   
   -   5         ��Name$ txtBxFirstName��5&      $��2��6*   $��2��6:   $	��150��6G   �� 5'   
   -   5        $ txtBxLastName��5'      $��2��6)   $��3��69   $	��150��6F   �� 5)   
   -   5         ��Name$ 
bttnSubmit��5)      $��Run me��6%   $��1��66   $��5��6F   $��2��6S   $��10q�6g   5*      5+      5,      