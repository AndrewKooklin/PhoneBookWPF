   M S B A M L   `   `   `  ����G  CPhoneBookWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PhoneBookWPF.ViewPhoneBookWPF.View  5      ?$clr-namespace:PhoneBookWPF.ViewModelPhoneBookWPF.ViewModel  5      C&clr-namespace:PhoneBookWPF.HelpMethodsPhoneBookWPF.HelpMethods  5      #    PhoneBookWPF.View.RecordsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:PhoneBookWPF.View     5      :	viewModel$clr-namespace:PhoneBookWPF.ViewModel     5      7help&clr-namespace:PhoneBookWPF.HelpMethods     5      .��5      � -   5          �Name$  gRecords��5       � 	Resources 5   
   5   /PhoneBookWPF.ViewModel.PhoneBookWindowViewModel   PhoneBookWindowViewModel4   .PhoneBookWPF.HelpMethods.MyMultiValueConverter  MyMultiValue��%:   &	        &	        5      61     5      6)   5       � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $��6* �6   �� 5      $	��80* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ ErrorSelection��5      $��17(�5      
��� ���$��2q�5       $
��Left=�5!      ��5      �� *ErrorSelection+ �� Source# [  5!      �� 5#   
   -   5         ��Name$ spRecordsHeaders��5#      $��1��5$       �� Orientation$ 
Horizontal=�5%      $
��Left=�5&      $��10,5,0,2q�5'      .+�5(      �� -   5         ��Name$	 bId��5(      $��Id��5)      $��35��5*      $��0q�5+      
�������5,      �� 5-      -   5        $ 	bLastName��5-      $��Фамилия��5.      $	��111��5/      $��0q�50      
�������51      �� 52      -   5        $ 
bFirstName��52      $��Имя��53      $	��111��54      $��0q�55      
�������56      �� 57      -   5        $ bFathersName��57      $��Отчество��58      $	��113��59      $��0q�5:      
�������5;      5=      �� 5@   
   -   5        $ spRecordsContent��5@      $��2��5A      $��10 0 0 0q�5B      $
��Left=�5C      $	��Top=�5D      $	��400��5E      $
��Auto=�5F      .+�5G      �� -	   5        	 ��Name$	 lbPhoneBookRecords��5G      $��0q�5J      ���	#FFDFFFCE$��14(�5L      ��5H      �� *
PhoneBooks+# [  
 �� SelectedItem
 5I      �� *SelectedRecord+# [   �� UpdateSourceTrigger$ PropertyChanged=���5M      �� 5N      .R�5O      �� 
���   �$��0 0 0 1q�5P   %    �� Padding$ 0q�5Q   %   $��0q�5R   %   ._�5S      �� $ 
Horizontal=�6)   .+�5T   "   ��  ��Name$
 tbId��6,   $��35��5V   0   $��0 0 0 0q�5W   0   ��5U   0   �� *Id+5W   0   �� 5X   "   $ 
tbLastName��6,   $	��105��5Z   0   $��0 0 0 0q�5[   0   ��5Y   0   �� *
LastName+5[   0   �� 5\   "   $ tbFirstName��6,   $	��105��5^   0   $��3 0 0 0q�5_   0   ��5]   0   �� *	FirstName+5_   0   �� 5`   "   $ tbFathersName��6,   $	��105��5b   0   $��3 0 0 0q�5c   0   ��5a   0   �� *FathersName+5c   0   5e      5f      5g      5i      5j      5l      5m      