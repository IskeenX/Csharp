   M S B A M L   `   `   `  ����C  ?PizzaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PizzaAppPizzaApp  5   	       PizzaApp.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:PizzaApp     5   	     � Title$  Pizza ordering��5   	   $	��800��6    $	��800��6-   $��20(�5	   	    � 	Resources 5
        PizzaApp.Converter   boolConverter��%   &	          5   
   6   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� .+�5      �� $��
Pizza name��6   
����� �6)   �� 5      -   5         ��Name$	 cmb��5       �� DisplayMemberPath$
 Name��5       �� SelectedValuePath$ Price��5       �� SelectedValue 5      ��  �� Path$
 Name��� 5      $��Price (EUR)��6   
����� �6*   �� 5      ��6   ��  �� ElementName$	 cmb��$ SelectedValue��� 5      -   5        	 ��Name$	 	chcGluten��5      $��Gluten free?��6*   �� 5      -   5        
 ��Name$
 btnAdd��5      $��Add to order��6%   $��5q�6<   6G   5      �� 5   
   $��1��6   .+�5      �� -   5         ��Name$	 lbx��5      $��Stretch=�6#   ��5      �� 5       .R�5!      �� 
���   �$��1q�65   ._�5"      �� .+�5#   "   ��  �� ContentStringFormat$ 	Name: {0}��6A   ��6(   �� *Name+6A   �� 5$   "   $ 
Price: {0}��6B   ��6(   �� *Price+6B   �� 5%   "   $ Gluten-free: {0}��6s   ��6(   �� *IsGlutenfree+ �� 	Converter# [  6s   5&      5'      5(      5*      5+      5,      5-      