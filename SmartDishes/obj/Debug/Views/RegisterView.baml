   M S B A M L   `   `   `  ����F  BSmartDishes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:SmartDishes.ViewModelsSmartDishes.ViewModels  5   	   $    SmartDishes.Views.RegisterView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;
viewModels$clr-namespace:SmartDishes.ViewModels     5   	   -   5          � Title$  RegisterView��5   	   $	��500��5	   	   $	��350��6    � WindowStyle$
 None=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � Cursor$  ��5   &    � DataContext 5      .   (SmartDishes.ViewModels.RegisterViewModel  5   
   .��5      �� ���#23242a �� CornerRadius$ 35��6"   ._�5   
   � $	��350��6   $	��300��6    � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       	 � ColumnDefinitions	 5#      �� 5$      �� 5%      .+�5(      �� $��Enter your name: ��6   $	��Top=�5)      $��Center=�5*      
�������$��0,14,0,0q�5,      $��0��5-      �� 5/      -   5        
 ��Name$

 Name��5/      $	��140��51      $��20��52      $	��Top=�53      $
��Left=�54      $��1��55      $��0��56      $��0,20,0,0q�57      ��50      �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�57      �� 59      $��Enter your login: ��6   $	��Top=�61   $��Center=�6I   
�������$��0,14,0,0q�6y   $��1��6�   �� 5;      -   5        $
 Login��5;      $	��140��5=      $��20��5>      $	��Top=�5?      $
��Left=�5@      $��1��5A      $��1��5B      $��0,20,0,0q�5C      ��5<      �� *Login+$ PropertyChanged=�5C      �� 5E      $��Enter your email: ��6   $��2��61   $	��Top=�6?   $��Center=�6W   
�������$��0,14,0,0q�6�   �� 5G      -   5        $
 Email��5G      $	��140��5I      $��20��5J      $	��Top=�5K      $
��Left=�5L      $��1��5M      $��2��5N      $��0,20,0,0q�5O      ��5H      �� *Email+$ PropertyChanged=�5O      �� 5R      $��Enter your password: ��6   $��3��64   $	��Top=�6B   $��Center=�6Z   
�������$��0,14,0,0q�6�   G� 5T      -   5         G�Name$ Password��5U      $	��140��5W      $��20��5X      $	��Top=�5Y      $
��Left=�5Z      $��1��5[      $��3��5\      $��0,20,0,0q�5]      �� 5_      $��Confirm your password: ��6   $��4��66   $	��Top=�6D   $��Center=�6\   
�������$��0,14,0,0q�6�   G� 5a      -   5        $ ConfirmPassword��5a      $	��140��5c      $��20��5d      $	��Top=�5e      $
��Left=�5f      $��1��5g      $��4��5h      $��0,20,0,0q�5i      �� 5k      -   5         ��Name$ btnRegister��5k      $	��200��5l      $��5��5m      $��14(�5n      $
 Hand��5o      $��	50,8,50,8q�5p      $��Register��5q      
���   �$
��Bold"�5t      $��Cooper Black)�5u      $��2��6/   ��5r      Z� ��5w      �� 5x       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5y      �  � Color$ 	#FF432371��6'    � Offset$ 0.519Q�69   � 5z      $ 	#FF5E09D5��6'   $ 1Q�69   � 5{      $ 	#FF5E09D5��6'   $ 0Q�69   5|      5~      �� 5�      -   5        $��6��5�      $
��Left=�5�      
������ $��Already have an account?��5�      $��10(�5�      
����  �$��2��5�      $��
86,10,0,20q�5�      
������ ��5�      �� *ViewLoginCommand+5�   /   5�      5�      5�      