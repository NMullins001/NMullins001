   M S B A M L   `   `   `  ����F  BCarRentalUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CarRentalUI.ViewsCarRentalUI.Views  5      %    CarRentalUI.Views.AddNewVehicle   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:CarRentalUI.Views     5        N� Title$  AddNewVehicle��5	      .��5      � 
���   � � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��* �6   .+�5   
   �� $%��https://i.imgur.com/5qTD4ma.png��6   $��0��69   $��0��6I   $
��Left=�6V   $��1��6q   �� 5   
   -   5         ��Name$ CustomerLabel��5      $��Add A New Vehicle��6'   $��Center=�6D   
�������$��45(�6}   $��Center=�6�   $��3��6�   $��1��6�   �� 5!   
   -   5         ��Name$ NavigationBox��5!      $��4��6*   $��10,10,10,11q�6:   $��Center=�6O   $��Center=�6q   
���   � �� Text$ 
Navigation��6�   .@�5"      ��  �� 
IsSelected$
 TRUE��6   .��6-   
Navigation69   �� 5#      -   5        .��5#   <   Vehicle Management6P   �� 5$      -   5        .��5$   =   Employee Management6R   �� 5%      -   5        .��5%   .   
Sign Out68   5&      �� 5(   
   -   5         ��Name$ VinNumberBox��5(      $��2��6(   $��1��65   $��25q�6E   $��
VIN Number��6Z    �� TextAlignment$ Center=�6l   $��Center=�6�   
���   �$��20(�6�   6�   �� 5)   
   -   5        $ ManufacturerBox��5)      $��2��6+   $��2��68   $��25q�6H   $��Manufacturer��6]   $ Center=�6q   $��Center=�6�   
���   �$��20(�6�   6�   �� 5*   
   -   5        $ ModelBox��5*      $��2��6$   $��3��61   $��25q�6A   $��Model��6V   $ Center=�6c   $��Center=�6z   
���   �$��20(�6�   6�   �� 5+   
   -	   5        $ ColorBox��5+      $��3��6$   $��2��61   $��25q�6A   $��Color��6V   $ Center=�6c   $��Center=�6z   
���   �$��20(�6�   6�   �� 5,   
   -
   5        $ VehicleTypeBox��5,      $��3��6*   $��3��67   $��25q�6G   $��Vehicle Type��6\   $ Center=�6p   $��Center=�6�   
���   �$��20(�6�   6�   �� 5-   
   -   5        $ ConditionBox��5-      $��5��6(   $��1��65   $��3��6E   $��25q�6Y   $��	Condition��6n   $ Center=�6   $��Center=�6�   
���   �$��20(�6�   6�   �� 5.   
   -   5        $ YearBox��5.      $��3��6#   $��1��60   $��25q�6@   $
��Year��6U   $ Center=�6a   $��Center=�6x   
���   �$��20(�6�   6�   �� 5/   
   -   5        $ MilesBox��5/      $��4��6$   $��1��61   $��25q�6A   $��Miles��6V   $ Center=�6c   $��Center=�6z   
���   �$��20(�6�   6�   �� 50   
   -   5        $ PricePerDay��50      $��4��6'   $��2��64   $��25q�6D   $��Price Per Day��6Y   $ Center=�6n   $��Center=�6�   
���   �$��20(�6�   6�   �� 52   
   -   5        $��6��52      $��2��6   $��25q�6/   
���   �$��Add Vehicle��6X   $��20(�6n   
������6�   53      54      