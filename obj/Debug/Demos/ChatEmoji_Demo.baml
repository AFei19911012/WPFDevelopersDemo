   M S B A M L   `   `   `  ����L  HWPFDevelopersDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:WPFDevelopersDemo.DemosWPFDevelopersDemo.Demos  5      ,    &WPFDevelopersDemo.Demos.ChatEmoji_Demo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:WPFDevelopersDemo.Demos     5      .��5	      A�   A� Columns$  2��6   $	��800��6   $	��600��6*   .+�5
   
   � $
��10,0q�6      WarningSolidColorBrush#��[  6    � RowDefinitions 5      �� 5      �� 5      $	��100 �6    .+�5      �� -   5         ��Name$ 	_LeftChat��5      ��5      �� 5       �� ImageSource$% ../Resource/Image/Chat/Left.jpg��6!    j� Stretch$
 Fill=�6O   5      � 5      $��1��6    5      �� 5      $
��Auto �6$   �� 5      .+�5      d� -   5         d�Name$ LeftButtonEmoji��5      $
��10,0q�68   $��Emoji��6F   $��40��6V   $
��Left=�6a   � 5      $	��Top=�6    � AllowsTransparency .  � VerticalOffset$ -4��5       � PlacementTarget 5   (   �� 	 �� ElementName$	 LeftButtonEmoji����5      �� $	 LeftButtonEmoji��
 �� Path$
 	IsChecked�.��5      �� $��10q�6     BackgroundSolidColorBrush#���  6)    �� CornerRadius$ 4��6b   $��76��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5          ShadowDepth$ 0Q�6/      
BlurRadius$ 10Q�6?      Opacity$	 0.2Q�6O      Color$ 	#80000000��6]   ._�5"      �� ��6'   �� *
EmojiArray+ �� RelativeSource ��  �� AncestorType$ local:ChatEmoji_DemoL���5#      �� 5$   "   .R�5%   &   ��  ��Name$ PART_Border��6-   -   5        $ 2��5%   B   
 � Tag 5'   -   �� *Key+._�5(   *   �� $��30��5)   0   $��30��6;   $��4q�6G    J� IsHitTestVisible . ��5(   0   �� *Value+ � ToolTip 6I   �� *Name+5*   0   5+   '    �� Triggers 5,   &   P� 5-   *    P� Property �@J�IsMouseOver P� Value . . �5.   .   ��  �� 
TargetName$ PART_Border��6K    �� Property � �� �� Value �	#FFD8D1D16d   5/   +   51   #   ��53      �� 54   "   .R�55   &   � 56   #   58      59      5:      � 5;      $��1��6    � ColumnDefinitions 5<      �� 5=      �� 5>      $
��Auto �6+   .+�5@      �� -   5         ��Name$ 	LeftInput��5@      �� 5A      -   5         ��Name$ LeftSend��5A   :   $��1��6   $��发送��6-     PrimaryButton#��[ 6c   6�   5B      5C      5D      � 5F   
   $
��10,0q�6     SuccessSolidColorBrush#��[ 6    5G      �� 5H      �� 5I      $	��100 �6    .+�5K      �� -   5        $ 
_RightChat��5K      ��5L      �� 5M      $: 4pack://application:,,,/Resource/Image/Chat/Right.jpg��6!   $
 Fill=�6d   5O      � 5Q      $��1��6    5R      �� 5S      $
��Auto �6$   �� 5T      .+�5V      d� -   5        $ RightButtonEmoji��5V      $
��10,0q�69   $��Emoji��6G   $��40��6W   $
��Left=�6b   � 5W      $	��Top=�6    . $ -4��5Y       5W   (   �� $	 RightButtonEmoji����5X      �� $	 RightButtonEmoji��$
 	IsChecked�.��5Z      �� $��10q�6   #���  6)   $ 4��6b   $��76��5[       5\        5]      $ 0Q�6/   $ 10Q�6?   $	 0.2Q�6O   $ 	#80000000��6]   ._�5_      �� ��6'   �� *
EmojiArray+ �� $ local:ChatEmoji_DemoL���5`      �� 5a   "   .R�5b   &   �� $ PART_Border��6-   -   5        $ 2��5b   B    5d   -   �� *Key+._�5e   *   �� $��30��5f   0   $��30��6;   $��4q�6G    . ��5e   0   �� *Value+ 6I   �� *Name+5g   0   5h   '    5i   &   P� 5j   *    �@J�IsMouseOver . . �5k   .   �� $ PART_Border��6K    � �� �	#FFD8D1D16d   5l   +   5n   #   ��5p      �� 5q   "   .R�5r   &   � 5s   #   5u      5v      5w      � 5x      $��1��6    5y      �� 5z      �� 5{      $
��Auto �6+   .+�5}      �� -	   5        $ 
RightInput��5}      �� 5~      -
   5        $ 	RightSend��5~   :   $��1��6   $��发送��6-   #��[ 6e   6�   5      5�      5�      5�      5�      