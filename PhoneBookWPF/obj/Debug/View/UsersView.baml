   M S B A M L   `   `   `  ����G  CPhoneBookWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PhoneBookWPF.ViewPhoneBookWPF.View  5      ?$clr-namespace:PhoneBookWPF.ViewModelPhoneBookWPF.ViewModel  5      7 clr-namespace:PhoneBookWPF.ModelPhoneBookWPF.Model  5      C&clr-namespace:PhoneBookWPF.HelpMethodsPhoneBookWPF.HelpMethods  5	      !    PhoneBookWPF.View.UsersView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:PhoneBookWPF.View     5      :	viewModel$clr-namespace:PhoneBookWPF.ViewModel     5      2model clr-namespace:PhoneBookWPF.Model     5      7help&clr-namespace:PhoneBookWPF.HelpMethods     5	      $��0 10 0 0q�5      .��5      � -   5          �Name$  gRecords��5      $	��400��5      $	��400��5      $��Stretch=�5       � 	Resources 5   
   5   /PhoneBookWPF.ViewModel.PhoneBookWindowViewModel   PhoneBookViewModel"   PhoneBookWPF.Model.UserModel  	UserModel4   .PhoneBookWPF.HelpMethods.MyMultiValueConverter  MyMultiValue��%W   &	        &	      &	 &       5      61     5      6     5      6)   5       � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��2* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5!   
   �� -   5         ��Name$ spUsersHeaders��5!      $��0��5"       �� Orientation$ 
Horizontal=�5#      $
��Left=�5$      $��10,5,0,2q�5%      .+�5&      �� -   5         ��Name$ bUserId��5&      $��UserId��5'      $	��150��5(      $��0q�5)      
�������5*      �� 5+      -   5        $ bEmail��5+      $��Email��5,      $	��120��5-      $��0q�5.      
�������5/      �� 50      -   5        $ bRoles��50      $��Roles��51      $��80��52      $��0q�53      
�������54      55      � 57   
   $��1��6   $��0��58       59      ��%    5:       5;      �� 5<      $
��200* �6#   �� 5=      $
��0.5* �6#    5?      �� 5@      $��* �6    .+�5B      �� $��0��6   $��0 2 0 0q�5C      $
��Auto=�5D      $
��Left=�5E      $	��Top=�5F      $	��370��5G      $��2��5H      .��5I      �� -   5        $ spUsersContent��5I      $��10 0 0 0q�5J      $
��Left=�5K      $	��Top=�5L      $	��300��5M      .+�5N      �� -   5         ��Name$ lbUsers��5N      $��0q�5Q      ���	#FFDFFFCE$��14(�5S      ��5O      �� *Users+ �� Source# [  	 �� SelectedItem	 5P      �� *SelectedUser+# [  
 �� UpdateSourceTrigger$
 PropertyChanged=���5T      �� 5U      .R�5V   "   �� 
���   �$��0 0 0 1q�5W   %    �� Padding$ 0q�5X   %   $��0q�5Y   %   ._�5Z   &   �� $ 
Horizontal=�61   .+�5[   *   ��  ��Name$
 tbId��64   $	��150��5]   0   $��0 0 0 0q�5^   0   $
��Wrap=�5_   0   ��5\   0   ��  �� Path$ User.Id�5_   0   �� 5`   *   $ tbEmail��64   $	��115��5b   0   $��0 0 0 0q�5c   0    �� TextAlignment$ Center=�5d   0   ��5a   0   �� $ 
User.Email�5d   0   �� 5e   *   $ lbRoles��62   $��0q�5g   2   $��0q�5h   2   $��70��5i   2   ���	#FFDFFFCE$��14(�5k   2   ��5f   2   �� $ Roles�5l   +   5m   '   5n   #   5o      5q      5r      5s      5t      5u      5v      