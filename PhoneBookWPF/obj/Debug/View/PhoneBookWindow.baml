   M S B A M L   `   `   `  ����G  CPhoneBookWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PhoneBookWPF.ViewPhoneBookWPF.View  5   	   ?$clr-namespace:PhoneBookWPF.ViewModelPhoneBookWPF.ViewModel  5   	   C&clr-namespace:PhoneBookWPF.HelpMethodsPhoneBookWPF.HelpMethods  5   	   '    !PhoneBookWPF.View.PhoneBookWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:PhoneBookWPF.View     5   	   :	viewModel$clr-namespace:PhoneBookWPF.ViewModel     5   	   7help&clr-namespace:PhoneBookWPF.HelpMethods     5   	     � Title$  	PhoneBook��5
   	   $	��460��5   	   $	��460��5   	   $	��640��5   	   $	��640��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5      5   /PhoneBookWPF.ViewModel.PhoneBookWindowViewModel   PhoneBookWindowViewModel4   .PhoneBookWPF.HelpMethods.MyMultiValueConverter  MyMultiValueConverter��%:   &	        &	        5   
   6-     5   
   6%   5      .��5      �  5   
     TextBlockStyle �� 
TargetType �� Property �� Value��%�   &	       �� 5      " ��6+   .�5      ��  � ��$ 15(�6-   �� 5       � ��$ 0q�6+   �� 5       � ��
 ���� 6/   5      5        � RowDefinitions 5"   
   �� 5#      $��8* �6   �� 5$      $
��132* �6    � ColumnDefinitions 5&   
   �� 5'      $
��410* �6   $	��410��6,   6=   �� 5(      $
��210* �6   $	��210��6,   6=   .+�5+   
   o� -   5         o�Name$ mTopLeft��5+      $��0��5,      $��24��5-      $	��Top=�5.      $
��Left=�5/      $��15(�50      
�������.@�53      m� -   5        	 m�Name$	 	miRecords��53      $��Records��54      
 � Cursor$

 Hand��55      .@�56      m� -   5        $	 miGetRecords��56      $%��Прочитать записи��57      $

 Hand��58       m� Command 59      �� *UpdateViewCommand+ �� Source# [   m� CommandParameter 5:      �� *Header+ �� ElementName$ miGetRecords��5;      m� 5<      -   5        $	 miGetDetails��5<      $��Детали записи��5=      $

 Hand��5>       5?      �� *UpdateViewCommand+# [   5@      �� *Header+$ miGetDetails��5A      m� 5B      -   5        $	 miAddRecord��5B      $#��Добавить запись��5C      $y�	Collapsed=�5D      $

 Hand��5E       5F      �� *UpdateViewCommand+# [   5G      �� *Header+$ miAddRecord��5H      m� 5I      -   5        $	 miChangeRecord��5I      $#��Изменить запись��5J      $y�	Collapsed=�5K      $

 Hand��5L       5M      �� *UpdateViewCommand+# [   5N      �� *Header+$ miChangeRecord��5O      m� 5P      -   5        $	 miDeleteRecord��5P      $!��Удалить запись��5Q      $y�	Collapsed=�5R      $

 Hand��5S       5T      �� *UpdateViewCommand+# [   5U      �� *Header+$ miDeleteRecord��5V      5W      m� 5X      -   5        $	 miUsers��5X      $��Users��5Y      $y�	Collapsed=�5Z      $

 Hand��5[      .@�5\      m� -	   5        $	 
miGetUsers��5\      $-��'Список пользователей��5]      $

 Hand��5^       5_      �� *UpdateViewCommand+# [   5`      �� *Header+$ 
miGetUsers��5a      m� 5b      -
   5        $	 	miAddUser��5b      $/��)Добавить пользователя��5c      $

 Hand��5d       5e      �� *UpdateViewCommand+# [   5f      �� *Header+$ 	miAddUser��5g      m� 5h      -   5        $	 miDeleteUser��5h      $-��'Удалить пользователя��5i      $

 Hand��5j       5k      �� *UpdateViewCommand+# [   5l      �� *Header+$ miDeleteUser��5m      m� 5n      -   5        $	 miAddRoleUser��5n      $8��2Добавить роль пользователю��5o      $

 Hand��5p       5q      �� *UpdateViewCommand+# [   5r      �� *Header+$ miAddRoleUser��5s      m� 5t      -   5        $	 miDeleteRoleUser��5t      $9��3Удалить роль у пользователя��5u      $

 Hand��5v       5w      �� *UpdateViewCommand+# [   5x      �� *Header+$ miDeleteRoleUser��5y      5z      m� 5{      -   5        $	 miRoles��5{      $��Roles��5|      $y�	Collapsed=�5}      $

 Hand��5~      .@�5      m� -   5        $	 
miGetRoles��5      $��Список ролей��5�       5�      �� *UpdateViewCommand+# [   5�      �� *Header+$ 
miGetRoles��5�      m� 5�      -   5        $	 	miAddRole��5�      $��Добавить роль��5�      $

 Hand��5�       5�      �� *UpdateViewCommand+# [   5�      �� *Header+$ 	miAddRole��5�      m� 5�      -   5        $	 miDeleteRole��5�      $��Удалить роль��5�      $

 Hand��5�       5�      �� *UpdateViewCommand+# [   5�      �� *Header+$ miDeleteRole��5�      5�      5�      o� 5�   
   -   5        $ 	mTopRight��5�      $��1��5�      $��24��5�      $
��auto��5�      $	��Top=�5�      $��Right=�5�      $��15(�5�      
�������.@�5�      m� -   5        $	 miLogIn��5�      $��Login��5�      $

 Hand��5�      $��0 0 2 0q�5�      $  ��5�       5�      �� *OpenLogInWindowCommand+# [  5�      m� 5�      -   5        $	 
miRegister��5�      $��Register��5�      
���   �$��0 0 2 0q�5�      $

 Hand��5�      $  ��5�       5�      �� *OpenRegisterWindowCommand+# [  5�      m� 5�      -   5        $	 
miUserName��5�      $y�	Collapsed=�5�      $�� ��5�      
���P��$
 Arrow��5�      $��0 0 2 0q�5�      5�      m� 5�      -   5        $	 miLogOut��5�      $y�	Collapsed=�5�      $��Logout��5�      $

 Hand��5�      $��0 0 2 0q�5�      $  ��5�       5�      �� *LogOutCommand+# [  5�      5�      �� 5�   
   $��1��6   $��2��5�      
����p��.+�5�      �  5�      �� 5�      $
��400* �6'   $	��400��64   6E   �� 5�      $
��205* �6'   $	��205��64   6E   .+�5�      �� -   5         ��Name$ ccLeftPartPage��5�   !   ��5�      �� *LeftCurrentView+# [   �� UpdateSourceTrigger$ PropertyChanged=�5�      �� 5�      -   5        $ ccRightPartPage��5�   !   $��1��5�      ��5�      �� *RightCurrentView+# [  $ PropertyChanged=�5�      5�      5�      5�      5�      