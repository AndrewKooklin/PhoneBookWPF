   M S B A M L   `   `   `  ����G  CPhoneBookWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PhoneBookWPF.ViewPhoneBookWPF.View  5      ?$clr-namespace:PhoneBookWPF.ViewModelPhoneBookWPF.ViewModel  5      C&clr-namespace:PhoneBookWPF.HelpMethodsPhoneBookWPF.HelpMethods  5      #    PhoneBookWPF.View.RecordsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:PhoneBookWPF.View     5      :	viewModel$clr-namespace:PhoneBookWPF.ViewModel     5      7help&clr-namespace:PhoneBookWPF.HelpMethods     5      $��0 10 0 0q�5      .��5      � -   5          �Name$  gRecords��5      $	��400��5      $	��400��5      $
��Left=�5       � 	Resources 5   
   5   /PhoneBookWPF.ViewModel.PhoneBookWindowViewModel   PhoneBookWindowViewModel4   .PhoneBookWPF.HelpMethods.MyMultiValueConverter  MyMultiValue��%:   &	        &	        5      61     5      6)   5       � RowDefinitions 5   
   �� 5      $��6* �6   �� 5      $	��80* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ spRecordsHeaders��5      $��0��5        �� Orientation$ 
Horizontal=�5!      $
��Left=�5"      $��10,5,0,2q�5#      .+�5$      �� -   5         ��Name$	 bId��5$      $��Id��5%      $��35��5&      $��0q�5'      
�������5(      �� 5)      -   5        $ 	bLastName��5)      $��Фамилия��5*      $	��111��5+      $��0q�5,      
�������5-      �� 5.      -   5        $ 
bFirstName��5.      $��Имя��5/      $	��111��50      $��0q�51      
�������52      �� 53      -   5        $ bFathersName��53      $��Отчество��54      $	��113��55      $��0q�56      
�������57      59      �� 5;   
   -   5        $ spRecordsContent��5;      $��1��5<      $��10 0 0 0q�5=      $
��Left=�5>      $	��Top=�5?      $	��400��5@      $
��Auto=�5A      .+�5B      �� -   5         ��Name$ lbPhoneBookRecords��5B      $��0q�5E      ���	#FFDFFFCE$��14(�5G      ��5C      �� *
PhoneBooks+ �� Source# [  	 �� SelectedItem	 5D      �� *SelectedRecord+# [  
 �� UpdateSourceTrigger$
 PropertyChanged=���5H      �� 5I      .R�5J      �� 
���   �$��0 0 0 1q�5K   %    �� Padding$ 0q�5L   %   $��0q�5M   %   ._�5N      �� $ 
Horizontal=�6)   .+�5O   "   ��  ��Name$
 tbId��6,   $��35��5Q   0   $��0 0 0 0q�5R   0   ��5P   0   �� *Id+5R   0   �� 5S   "   $ 
tbLastName��6,   $	��105��5U   0   $��0 0 0 0q�5V   0   ��5T   0   �� *
LastName+5V   0   �� 5W   "   $ tbFirstName��6,   $	��105��5Y   0   $��3 0 0 0q�5Z   0   ��5X   0   �� *	FirstName+5Z   0   �� 5[   "   $ tbFathersName��6,   $	��105��5]   0   $��3 0 0 0q�5^   0   ��5\   0   �� *FathersName+5^   0   5`      5a      5b      5d      5e      5g      5h      