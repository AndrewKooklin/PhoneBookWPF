   M S B A M L   `   `   `  ����G  CPhoneBookWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PhoneBookWPF.ViewPhoneBookWPF.View  5   	   ?$clr-namespace:PhoneBookWPF.ViewModelPhoneBookWPF.ViewModel  5   	   C&clr-namespace:PhoneBookWPF.HelpMethodsPhoneBookWPF.HelpMethods  5   	   '    !PhoneBookWPF.View.PhoneBookWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:PhoneBookWPF.View     5   	   :	viewModel$clr-namespace:PhoneBookWPF.ViewModel     5   	   7help&clr-namespace:PhoneBookWPF.HelpMethods     5   	     � Title$  	PhoneBook��5
   	   $	��420��5   	   $	��420��5   	   $	��640��5   	   $	��640��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5      5   /PhoneBookWPF.ViewModel.PhoneBookWindowViewModel   PhoneBookWindowViewModel4   .PhoneBookWPF.HelpMethods.MyMultiValueConverter  MyMultiValueConverter��%:   &	        &	        5   
   6-     5   
   6%   5      .��5      �  5   
   ��%    5       � RowDefinitions 5   
   �� 5      $��8* �6   �� 5      $
��132* �6    � ColumnDefinitions 5   
   �� 5       $
��400* �6   $	��400��6,   6=   �� 5!      $
��202* �6   $	��202��6,   6=   .+�5$   
   o� -   5         o�Name$ mTopLeft��5$      $��0��5%      $��24��5&      $	��Top=�5'      $
��Left=�5(      $��15(�5)      
�������.@�5,      m� -   5         m�Name$ 	miRecords��5,      $��Records��5-       � Cursor$
 Hand��5.      .@�5/      m� -   5        $ miGetRecords��5/      $%��Прочитать записи��50      $
 Hand��51       m� Command 52      �� *UpdateViewCommand+	 �� Source#	 [  
 m� CommandParameter
 53      �� *Header+ �� ElementName$ miGetRecords��54      m� 55      -   5        $ miGetDetails��55      $��Детали записи��56      $
 Hand��57       58      �� *UpdateViewCommand+#	 [  
 59      �� *Header+$ miGetDetails��5:      m� 5;      -   5        $ miAddRecord��5;      $#��Добавить запись��5<      $y�	Collapsed=�5=      $
 Hand��5>       5?      �� *UpdateViewCommand+#	 [  
 5@      �� *Header+$ miAddRecord��5A      m� 5B      -   5        $ miChangeRecord��5B      $#��Изменить запись��5C      $y�	Collapsed=�5D      $
 Hand��5E       5F      �� *UpdateViewCommand+#	 [  
 5G      �� *Header+$ miChangeRecord��5H      m� 5I      -   5        $ miDeleteRecord��5I      $!��Удалить запись��5J      $y�	Collapsed=�5K      $
 Hand��5L       5M      �� *UpdateViewCommand+#	 [  
 5N      �� *Header+$ miDeleteRecord��5O      5P      m� 5Q      -   5        $ miUsers��5Q      $��Users��5R      $y�	Collapsed=�5S      $
 Hand��5T      .@�5U      m� -	   5        $ 
miGetUsers��5U      $-��'Список пользователей��5V      $
 Hand��5W       5X      �� *UpdateViewCommand+#	 [  
 5Y      �� *Header+$ 
miGetUsers��5Z      m� 5[      -
   5        $ 	miAddUser��5[      $/��)Добавить пользователя��5\      $
 Hand��5]       5^      �� *UpdateViewCommand+#	 [  
 5_      �� *Header+$ 	miAddUser��5`      m� 5a      -   5        $ miDeleteUser��5a      $-��'Удалить пользователя��5b      $
 Hand��5c       5d      �� *UpdateViewCommand+#	 [  
 5e      �� *Header+$ miDeleteUser��5f      m� 5g      -   5        $ miAddRoleUser��5g      $8��2Добавить роль пользователю��5h      $
 Hand��5i       5j      �� *UpdateViewCommand+#	 [  
 5k      �� *Header+$ miAddRoleUser��5l      m� 5m      -   5        $ miDeleteRoleUser��5m      $9��3Удалить роль у пользователя��5n      $
 Hand��5o       5p      �� *UpdateViewCommand+#	 [  
 5q      �� *Header+$ miDeleteRoleUser��5r      5s      m� 5t      -   5        $ miRoles��5t      $��Roles��5u      $y�	Collapsed=�5v      $
 Hand��5w      .@�5x      m� -   5        $ 
miGetRoles��5x      $��Список ролей��5y       5z      �� *UpdateViewCommand+#	 [  
 5{      �� *Header+$ 
miGetRoles��5|      m� 5}      -   5        $ 	miAddRole��5}      $��Добавить роль��5~      $
 Hand��5       5�      �� *UpdateViewCommand+#	 [  
 5�      �� *Header+$ 	miAddRole��5�      m� 5�      -   5        $ miDeleteRole��5�      $��Удалить роль��5�      $
 Hand��5�       5�      �� *UpdateViewCommand+#	 [  
 5�      �� *Header+$ miDeleteRole��5�      5�      5�      o� 5�   
   -   5        $ 	mTopRight��5�      $��1��5�      $��24��5�      $
��auto��5�      $	��Top=�5�      $��Right=�5�      $��15(�5�      
�������.@�5�      m� -   5        $ miLogIn��5�      $��Login��5�      $
 Hand��5�      $��0 0 2 0q�5�      $
  ��5�       5�      �� *OpenLogInWindowCommand+#	 [  5�      m� 5�      -   5        $ 
miRegister��5�      $��Register��5�      
���   �$��0 0 2 0q�5�      $
 Hand��5�      $
  ��5�       5�      �� *OpenRegisterWindowCommand+#	 [  5�      m� 5�      -   5        $ 
miUserName��5�      $y�	Collapsed=�5�      $�� ��5�      
���   �{�.  $��0 0 2 0q�5�      5�      m� 5�      -   5        $ miLogOut��5�      $y�	Collapsed=�5�      $��Logout��5�      $
 Hand��5�      $��0 0 2 0q�5�      $
  ��5�       5�      �� *LogOutCommand+#	 [  5�      5�      �� 5�   
   $��1��6   $��2��5�      
����p��.+�5�      �  5�      �� 5�      $
��400* �6'   $	��400��64   6E   �� 5�      $
��205* �6'   $	��205��64   6E   .+�5�      �� -   5         ��Name$ ccLeftPartPage��5�   !   ��5�      �� *LeftCurrentView+#	 [   �� UpdateSourceTrigger$ PropertyChanged=�5�      �� 5�      -   5        $ ccRightPartPage��5�   !   $��1��5�      ��5�      �� *RightCurrentView+#	 [  $ PropertyChanged=�5�      5�      5�      5�      5�      