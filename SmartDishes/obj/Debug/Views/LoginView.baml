   M S B A M L   `   `   `  ����F  BSmartDishes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:SmartDishes.ViewModelsSmartDishes.ViewModels  5   	   G(clr-namespace:SmartDishes.CustomControlsSmartDishes.CustomControls  5   	   !    SmartDishes.Views.LoginView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;
viewModels$clr-namespace:SmartDishes.ViewModels     5   	   Ccustomcontrols(clr-namespace:SmartDishes.CustomControls     5   	   -   5          � Title$  	LoginView��5	   	   $	��350��5
   	   $	��350��6    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ 	CanResize=�5   	   
������  � AllowsTransparency .  � DataContext 5      +   %SmartDishes.ViewModels.LoginViewModel  5   
    � 	Resources 5         BooleanToVisiblity��%   &	        �� 5   
   6'   5      y�5      �� 5   
    �� Path$ IsViewVisible�6    �� Mode$ TwoWay=�6'   	 �� 	Converter#	 [  65   .��5      �� 
 �� CornerRadius$
 35��6   ��5   
   �� 5       �� 
StartPoint$	 1,0&�6"    �� EndPoint$	 1,1&�63   .��5       �  � Color$ #180632��6    � Offset$ 0Q�6/   � 5!      $ #5e09d5��6   $	 0.5Q�6/   � 5"      $ #180632��6   $ 1Q�6/   5#      ._�5%   
   � $	��300��6   $	��300��6    � RowDefinitions 5'      �� 5(      �� 5)      �� 5*      �� 5+      �� 5,      �� 5-      .+�5/      �� $��2��6   .+�50      �� 
�������$��Dane do logowania: ��6+   $��16(�6I   $��33��6W   �� 51      
�������$*��$Admin: Login: admin Hasło: admin123��6+   $��12(�6Y   �� 52      
�������$/��)Użytkownik: Login: bigi Hasło: bogus123��6+   53      �� 54      $��Login:��6   
�������$��2��69   $��0,12,255,10q�6F   �� 56      -   5         ��Name$ txtLogin��56      $��2��57      $	��170��59      $��20��5:      $	��Top=�5;      $
��Left=�5<      
������ 
�������$��
130,12,0,0q�5?      ��58      �� *Login+ �� UpdateSourceTrigger$ PropertyChanged=�5?      �� 5B      $��Enter your password: ��6   
�������$��0,10,177,12q�6G   $��3��6\   4   .SmartDishes.CustomControls.BindablePasswordBox  5D      
������ 
�������$��3��5H      $��130,14,0,16q�5I       � Cursor$  ��6&      Password 5E      �� *
Password+$ TwoWay=�$ PropertyChanged=�5I   &   �� 5L      
���  ��$��12(�5N      $��0,0,0,21q�5O      $��3��5P      ��5L      �� *ErrorMessage+5P      �� 5R      -   5         ��Name$ btnLogin��5R      $��4��5T      $��14(�5U      $
 Hand��5V      $��
78,3,78,12q�5W      $��Log in��5X      
���   �$
��Bold"�5[      $��Cooper Black)�5\      ��5S      �� *LoginCommand+��5Y      Z� ��5^      �� 5_      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5`      � $ 	#FF432371��6'   $ 0.519Q�69   � 5a      $ 	#FF5E09D5��6'   $ 1Q�69   � 5b      $ 	#FF5E09D5��6'   $ 0Q�69   5c      5e      �� 5g      $��Don't have an account? ��6   $��5��5h      
�������5i      �� 5k      -   5        $��5��5k      $
��Left=�5l      
������ 
���   �$��Register now!��5o      $��10(�5q      $��
183,0,0,30q�5r      
������ ��5p      �� *ViewRegisterCommand+5s   /   5u      5v      5w      