   M S B A M L   `   `   `  ����G  CPhoneBookWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PhoneBookWPF.ViewPhoneBookWPF.View  5      ?$clr-namespace:PhoneBookWPF.ViewModelPhoneBookWPF.ViewModel  5      C&clr-namespace:PhoneBookWPF.HelpMethodsPhoneBookWPF.HelpMethods  5      !    PhoneBookWPF.View.RolesView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:PhoneBookWPF.View     5      :	viewModel$clr-namespace:PhoneBookWPF.ViewModel     5      7help&clr-namespace:PhoneBookWPF.HelpMethods     5      .��5      � -   5          �Name$  gRoles��5       � 	Resources 5   
   5   /PhoneBookWPF.ViewModel.PhoneBookWindowViewModel   PhoneBookWindowViewModel4   .PhoneBookWPF.HelpMethods.MyMultiValueConverter  MyMultiValue��%:   &	        &	        5      61     5      6)   5       � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $��6* �6   �� 5      $	��80* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5"   
   �� -   5         ��Name$ spRecordsHeaders��5"      $��1��5#       �� Orientation$ 
Horizontal=�5$      $
��Left=�5%      $��10,5,0,2q�5&      .+�5'      �� -   5         ��Name$ bRoleId��5'      $��RoleId��5(      $	��270��5)      $��0q�5*      $��0q�5+      
�������5,      �� 5-      -   5        $ 	bRoleName��5-      $��RoleName��5.      $��85��5/      $��0q�50      $��0q�51      
�������52      54      �� 57   
   -   5        $ spRolesContent��57      $��2��58      $��10 0 0 0q�59      $
��Left=�5:      $	��Top=�5;      $	��400��5<      $
��Auto=�5=      .+�5>      �� -   5         ��Name$ lbRoles��5>      $��0q�5A      $��0q�5B      ���	#FFDFFFCE$��14(�5D      ��5?      �� *Roles+ �� Source# [  	 �� SelectedItem	 5@      �� *SelectedRole+# [  
 �� UpdateSourceTrigger$
 PropertyChanged=���5E      �� 5F      .R�5G      �� 
���   �$��0 0 0 1q�5H   %    �� Padding$ 0q�5I   %   $��0q�5J   %   ._�5K      �� $ 
Horizontal=�6)   .+�5L   "   ��  ��Name$
 tbId��6,   $	��270��5N   ,   $��0 0 0 0q�5O   ,    �� Padding$ 0q�5P   ,    �� TextAlignment$ Center=�5Q   ,   ��5M   ,   �� *Id+5Q   ,   �� 5R   "   $ 
tbRoleName��6,   $��70��5T   ,   $��0q�5U   ,   $ 0q�5V   ,   $ Center=�5W   ,   ��5S   ,   �� *Name+5W   ,   5Y      5Z      5[      5]      5^      5`      5a      