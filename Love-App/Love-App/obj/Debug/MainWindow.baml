   M S B A M L   `   `   `  ����C  ?Love-App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Love_AppLove_App  5   	       Love_App.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Love_App     5   	   -   5          � Title$  
StartSeite��5   	   $	��450��6   $	��800��6)   $	��750��65   $	��400��6D    � WindowStartupLocation$ CenterScreen=�6u    � WindowState$ 	Maximized=�6�   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6   6*   �� 5      $
��0.2* �6   �� 5      $��3* �6   �� 5      $��3* �6   �� 5      $��3* �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   6,   �� 5      $��2* �6   6,   �� 5      $��2* �6   6,   �� 5      $��2* �6   6,   .+�5   
   �� $��4��6   $��1��6&   $9��3blurred-valentine-s-day-wallpaper_23-2148819570.jpg��6�   $
��Fill=�6  ��67   �� *ActualHeight+ �� RelativeSource ��  �� AncestorType$
 GridL���6�   �� *ActualWidth+ �� $
 GridL�6  � 5   
   $��0��6   $��3��6    5      �� 5      $��1* �6    6.   �� 5      $��1* �6    6.   �� 5      $��1* �6    6.   �� 5      $��1* �6    6.   �� 5      $��1* �6    6.   �� 5       $��1* �6    6.   �� 5!      $��1* �6    6.    5#      �� 5$      $��1* �6#   60   �� 5%      $��1* �6#   60   �� 5&      $��1* �6#   60   .+�5(      �� $��1��6   $��1��6    
���   �	 �� X1$ 0��6>   	 �� Y1$ 0��6E   		 �� Y2$	 0��6�   
���   �	
 �� X2
 6L   �� *ActualWidth+ �� $
 GridL���6�   �� *ActualHeight+ �� $
 GridL��� 5)      $��3��6   $��1��6    
���   �$ 0��6>   $ 0��6E   $	 0��6�   
���   �
 6L   �� *ActualWidth+ �� $
 GridL���6�   �� *ActualHeight+ �� $
 GridL��� 5*      $��5��6   $��1��6    
���   �$ 0��6>   $ 0��6E   $	 0��6�   
���   �
 6L   �� *ActualWidth+ �� $
 GridL���6�   �� *ActualHeight+ �� $
 GridL�� 5+      $��1��6   $��1��6#   $��5��60   .+�5,      �� -   5         J� Opacity$	 0.0Q�5,       � Cursor$
 Hand��6'   6L   5-      5.      � 5/   
   $��0��6   $��1��6   $��2��6,    50      �� 51      $
��0.5* �6    60   �� 52      $��4* �6    6.   �� 53      $
��0.5* �6    60   .+�55      � $��1��6   $��1��6#   .+�56      �� $�� Smooch Finder ��57      $��1��6   $��1��6-   $��Monotype Corsiva)�58   �    �� TextAlignment$ Center=�6�   $��Center=�6�   ��6   �� *ActualWidth+ �� $
 GridL���6X   �� *ActualHeight+ �� $
 GridL���6�   �� *ActualHeight+ �� $
 GridL�59      5:      � 5;   
   $��0��6   $��0��6    5<      �� 5=      �� 5>      $��0* �6     5@      �� 5A      $
��0.5* �6#   .+�5C      A� $��0��6   $��1��6#   
���   �$��2��5G      ��5D      �� *ActualHeight+ �� $
 GridL���5E      �� *ActualHeight+ �� $
 GridL���5H      �� 5I       �� ImageSource$ RegenschirmGmbH.png��6!   6E   5K      5L      � 5M   
   -   5         �Name$ DropDown��5M      $��3��6!   $��1��61   $��2��6>   $y�Hidden=�6O    K� ZIndex$ 1��6c    J� Effect 5N      3  -System.Windows.Media.Effects.DropShadowEffect  5O      .+�5Q      �� -   5         ��Name$ BoxAnim��5Q      
�������6:   � 5R      .+�5S      � $��0��6   $��2��6$    5T      �� 5U      $��1* �6$   62   �� 5V      $��1* �6$   62   .+�5Y      �� 
��� � �
���   �$��2��6�   ��6-   �� *ActualHeight+ �� $
 GridL���6�   �� *ActualWidth+ �� $
 GridL��� 5Z      -   5         ��Name$ DropLoginButton��5Z      $��0��66   $��Login��6C   6h   �� 5[      -   5        $ DropRegButton��5[      $��1��64   $	��Reg��6A   6b   5\      5]      5^      � 5_   
   $��1��6   $��4��6   $��4��6-   $ 0Q�6A   6O    � 5`   
   -   5          �Name$
 Main��5`   5   $��4��6   $��5��6$     � NavigationUIVisibility$ Hidden=�6C   6e   5a      5b      