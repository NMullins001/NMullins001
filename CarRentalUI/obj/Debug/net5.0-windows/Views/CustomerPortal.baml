   M S B A M L   `   `   `  ����F  BCarRentalUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CarRentalUI.ViewsCarRentalUI.Views  5      &     CarRentalUI.Views.CustomerPortal   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:CarRentalUI.Views     5        N� Title$  CustomerPortal��5	      .��5      � 
���   � � RowDefinitions 5      �� 5   
   $��70 �6   �� 5   
   $	��44* �6   �� 5   
   $	��65* �6   �� 5   
   $	��65* �6    � ColumnDefinitions 5      �� 5   
   $��* �6   �� 5   
   $��3* �6   �� 5   
   $��* �6   .+�5      �� $%��https://i.imgur.com/5qTD4ma.png��6   $��0��65   $��0��6E   $
��Left=�6R   $��1��6m   �� 5   
   -   5         ��Name$ CustomerLabel��5      $��Customer��6'   $��Center=�6;   
�������$��45(�6t   $��Center=�6�   $��1��6�   6�   �� 5   
   -   5         ��Name$ NavigationBox��5      $��4��6*   $��10,10,10,11q�6:   $��Center=�6O   $��Center=�6q   
���   � �� Text$ 
Navigation��6�   .@�5      ��  �� 
IsSelected$
 TRUE��6   .��6-   
Navigation69   �� 5      -   5        .��5   =   Customer Management6R   �� 5      -   5        .��5   =   Employee Management6R   �� 5      -   5        .��5   8   
Sign Out6B   5       �� 5!      -   5        $��1��5!      $#��Add A New Rental for Customer��6   $��2��6G   $��Center=�6T   
������$��25(�6�   $��10,10,10,10q�6�   6�   �� 5"      -   5        $��1��5"      $(��"View Existing Rentals for Customer��6   $��3��6L   $��Center=�6Y   
������$��25(�6�   $��10,10,10,10q�6�   6�   5$      5%      