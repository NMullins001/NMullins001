   M S B A M L   `   `   `  ����F  BCarRentalUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CarRentalUI.ViewsCarRentalUI.Views  5      &     CarRentalUI.Views.AddNewCustomer   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:CarRentalUI.Views     5        N� Title$  AddNewCustomer��5	      .��5
      � 
���   � � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��* �6   .+�5   
   �� $%��https://i.imgur.com/5qTD4ma.png��6   $��0��69   $��0��6I   $
��Left=�6V   $��1��6q   �� 5   
   -   5         ��Name$ CustomerLabel��5      $��Add A New Customer��6'   $��Center=�6E   
�������$��45(�6~   $��Center=�6�   $��3��6�   $��1��6�   �� 5   
   -   5         ��Name$ NavigationBox��5      $��4��6*   $��10,10,10,11q�6:   $��Center=�6O   $��Center=�6q   
���   � �� Text$ 
Navigation��6�   .@�5       ��  �� 
IsSelected$
 TRUE��6   .��6-   
Navigation69   �� 5!      -   5        .��5!   =   Customer Management6R   �� 5"      -   5        .��5"   =   Employee Management6R   �� 5#      -   5        .��5#   8   
Sign Out6B   5$      �� 5%   
   -   5         ��Name$ FirstNameBox��5%      $��2��6(   $��1��65   $��25q�6E   $��
First Name��6Z    �� TextAlignment$ Center=�6l   $��Center=�6�   
���   �$��20(�6�   6�   �� 5&   
   -   5        $ MiddleNameBox��5&      $��2��6)   $��2��66   $��25q�6F   $��Middle Name��6[   $ Center=�6n   $��Center=�6�   
���   �$��20(�6�   6�   �� 5'   
   -   5        $ LastNameBox��5'      $��2��6'   $��3��64   $��25q�6D   $��	Last Name��6Y   $ Center=�6j   $��Center=�6�   
���   �$��20(�6�   6�   �� 5(   
   -	   5        $ PhoneNumberBox��5(      $��3��6*   $��2��67   $��25q�6G   $��PH:123-456-6789��6\   $ Center=�6s   $��Center=�6�   
���   �$��20(�6�   6�   �� 5)   
   -
   5        $ EmailAddressBox��5)      $��3��6+   $��3��68   $��25q�6H   $��Email Address��6]   $ Center=�6r   $��Center=�6�   
���   �$��20(�6�   6�   �� 5*   
   -   5        $ 
AddressBox��5*      $��4��6&   $��1��63   $��3��6C   $��25q�6W   $��Address��6l   $ Center=�6{   $��Center=�6�   
���   �$��20(�6�   6�   �� 5+   
   -   5        $ CityBox��5+      $��5��6#   $��1��60   $��25q�6@   $
��City��6U   $ Center=�6a   $��Center=�6x   
���   �$��20(�6�   6�   �� 5,   
   -   5        $ StateBox��5,      $��5��6$   $��2��61   $��25q�6A   $��State��6V   $ Center=�6c   $��Center=�6z   
���   �$��20(�6�   6�   �� 5-   
   -   5        $ PostalCodeBox��5-      $��5��6)   $��3��66   $��25q�6F   $��Postal Code��6[   $ Center=�6n   $��Center=�6�   
���   �$��20(�6�   6�   (  "System.Windows.Controls.DatePicker  5.   
   -   5        	  Name$	 
DatePicker��5.      $��3��6)   $��1��66   $��Center=�6G   $��25q�6i   
���   �$��20(�6�   �� 50   
   -   5        $��6��50      $��2��6   $��25q�6/   
���   �$��Sign Up��6X   $��20(�6j   
������6�   52      53      