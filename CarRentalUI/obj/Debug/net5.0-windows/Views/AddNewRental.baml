   M S B A M L   `   `   `  ����F  BCarRentalUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CarRentalUI.ViewsCarRentalUI.Views  5      $    CarRentalUI.Views.AddNewRental   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:CarRentalUI.Views     5        N� Title$  AddNewRental��5	      .��5      � 
���   � � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��* �6   .+�5   
   �� $%��https://i.imgur.com/5qTD4ma.png��6   $��0��69   $��0��6I   $
��Left=�6V   $��1��6q   �� 5   
   -   5         ��Name$ CustomerLabel��5      $��Add Rental For Customer��6'   $��Center=�6J   
�������$��45(�6�   $��Center=�6�   $��3��6�   $��1��6�   6�   �� 5   
   -   5         ��Name$ NavigationBox��5      $��4��6*   $��10,10,10,11q�6:   $��Center=�6O   $��Center=�6q   
���   � �� Text$ 
Navigation��6�   .@�5       ��  �� 
IsSelected$
 TRUE��6   .��6-   
Navigation69   �� 5!      -   5        .��5!   ?   Current Customer Portal6X   �� 5"      -   5        .��5"   H   New Customer6V   �� 5#      -   5        .��5#   G   View Existing Customers6`   �� 5$      -   5        .��5$   C   Customer Management6X   �� 5%      -   5        .��5%   ?   Employee Management6T   �� 5&      -   5        .��5&   .   
Sign Out68   5'      �� 5)   
   $��3��6   $��1��6   $��3��6-   $	��Top=�6A   
�������$��
Start Date��6w   $��Center=�6�   $��30(�6�   $��	0,17,0,37q�6�   �� 5*   
   $��4��6   $��1��6   $��3��6-   $	��Top=�6A   
�������$��End Date��6w   $��Center=�6�   $��30(�6�   $��	0,17,0,37q�6�   �� 5+   
   -	   5         ��Name$ VinNumberBox��5+      $��2��6(   $��1��65   $��3��6E   $��25q�6Y   $��
VIN Number��6n    �� TextAlignment$ Center=�6�   $��Center=�6�   
���   �$��20(�6�   6�   (  "System.Windows.Controls.DatePicker  5,   
   -
   5        	  Name$	 StartingDateBox��5,      $��3��6.   $��1��6;   $��3��6K   
   Text$
 
Start Date��6`   $��Bottom=�6s   
���   �$��20(�6�   $��21,72,0,104q�6�   $��2��6�     5-   
   -   5        $	 EndingDateBox��5-      $��4��6,   $��1��69   $��3��6I   $
 End Date��6^   $��Bottom=�6o   
���   �$��20(�6�   $��	21,67,0,0q�6�   �� 5/   
   -   5        $��6��5/      $��2��6   $��25q�6/   
���   �$��
Add Rental��6X   $��20(�6m   
������6�   52      53      