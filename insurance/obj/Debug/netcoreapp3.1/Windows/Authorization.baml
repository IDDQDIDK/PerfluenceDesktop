   M S B A M L   `   `   `  ����D  @insurance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:insurance.Windowsinsurance.Windows  5   	   %    insurance.Windows.Authorization   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:insurance.Windows     5   	     � Title$  Авторизация��5   	   $	��800��6   $
��1200��6*   $��20(�67   $��Comic Sans MS)�6E    � WindowStartupLocation$ CenterScreen=�6`    � WindowStyle$
 None=�6�    � 
ResizeMode$ NoResize=�6�   .��5	      � .+�5
   
   � $��50��6   
���q�<� J� RenderTransformOrigin$ 0.5,0.5&�67   z�5      V� 5      .~�5      �� �� 5      �� 5      -   5        MostPale�� �� Angle$
 -280Q�5   8   T� 5      5      5      � 5   
   $	��100��6   
�������$ 0.5,0.5&�66   z�5      V� 5      .~�5      �� �� 5      �� 5      -   5        Pale��$ 59Q�5   4   T� 5      5      5      � 5   
   $	��200��6   
���2�2�$ 0.5,0.5&�63   z�5      V� 5       .~�5!      �� �� 5"      �� 5#      -   5        Lime��$	 100Q�5#   4   T� 5$      5%      5'      � 5(   
   -   5         �Name$ 	GreenBack��5(      $	��300��6"   $ 0.5,0.5&�6/   
��� � �z�5)      V� 5*      .~�5+      �� �� 5,      �� 5-      -   5        	Green��$	 -36Q�5-   5   T� 5.      5/      51       � 52   
   -   5          �Name$
 Main��52        � NavigationUIVisibility$ Hidden=�6   6@   �� 53   
   	 �� Orientation$	 
Horizontal=�6   $��Right=�6.   .+�54      �� .+�55      �� �� 56      -   5        
 ��Name$
 Close��56      $��45��6(   .��6G   X6J   57      �� 58      59      �� 5:   
   $	 
Horizontal=�6   $��Bottom=�6.   $
��Left=�6I   .+�5;      �� �� 5<      .+�5=      �� -   5        $
 Logout��5=      $��50��6)   $y�Hidden=�6I   .��6]   🚪6a   �� 5>      5?      5@      �� 5A   
   -	   5         ��Name$
 Auth��5A      $��Center=�6#   $��Center=�6@   .+�5B      �� $	��250��6   $	��100��6    $��/Assets/logo.png��6-   �� 5C      �� 5D      $	 
Horizontal=�6   .+�5E      �� $	��100��6   $��Center=�6(   Логин:6K   �� 5F      -
   5         ��Name$ Login��5F      $	��300��6)   $��40��65   5G      �� 5H      �� 5I      $	 
Horizontal=�6   .+�5J      �� $	��100��6   $��Center=�6(   Пароль:6L   �� 5K      -   5        $ Passcode��5K      $	��300��6,   $��40��68   5L      �� 5M      �� 5N      -   5        $
 Enter��5N      $��45��6$   $��20(�60   $��Comic Sans MS)�6>   .��6m   
Войти6t   5O      5P      5Q      