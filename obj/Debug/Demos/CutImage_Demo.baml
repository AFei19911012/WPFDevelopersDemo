   M S B A M L   `   `   `  ����  WPFDevelopersDemo+    %WPFDevelopersDemo.Demos.CutImage_Demo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      H DWPFDevelopers, Version=1.1.0.1, Culture=neutral, PublicKeyToken=null>wpfdev1https://github.com/WPFDevelopersOrg/WPFDevelopers  5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   %  WPFDevelopers.Controls.CutImage  -   5          Name$ 
cutCustoms��5      $	��400��6.   $	��380��6:   �� 5   
   $��1��6   $	��Top=�6%   $��	58,58,0,0q�6>   .+�5      �� 
�������$��1q�6(   $	��120��6<   $	��120��6H   $
��Left=�6U   ��5      �� 5      -   5        
image2�� �� ImageSource 5   1   ��  �� ElementName$ 
cutCustoms�� �� Path$ SaveImageSource�5      �� 5      $��预览120x120��6   $
��0,10q�6)   5      �� 5   
   $��1��6   $��2��6"    �� Orientation$ 
Horizontal=�66   $��Center=�6O   .+�5      �� -   5         ��Name$ 	btnImport��5      $��选择图片��6(   $��
0 20 10 20q�67      DefaultButton#��[  6K   �� 5      -   5        $ btnSave��5      $��保存图片��6&   $��
0 20 10 20q�65   {�.    PrimaryButton#��[ 6[   5       5!      5"      