   M S B A M L   `   `   `  ����E  AEnglishApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:EnglishApp
EnglishApp  5          EnglishApp.Categories   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:EnglishApp     5        N� Title$  
Categories��5
       N� 
Background
 ��� � � 	Resources 5         
TextBlock1 �� 
TargetType �� Property �� Value  
TextBlock2 �� BasedOn �� 
TargetType  PBWords �� CornerRadius	 �� Padding
 �� Path �� RelativeSource �� AncestorType��%�  &	        &	 �     7   &	     �� 5   
   " ��6#   .�5      ��  � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � ��$ 
0 -14 30 0q�6'   �� 5       � ��$ 16(�6)   5      �� 5   
   " ��6#   8   .�5      ��  � ��$ 	0 -14 0 0q�6'   5      �� 5   
   " �6   .R�5      �� $ 4��6   $	 5q�6&   $��
50 5 50 20q�62   $��30��6F   $��2q�6R   
����� �._�5      � ��5      �� 5      .�5      ��  �@�Value 5   %   �� $
 Value� �� " ��� 5        � ��
 �  ��6G   �� 5!       � ��
 � ���6G   �� 5"       �@�Maximum$ 30Q�6D   5#      5%      5&      5'      5(      .��5)      �� .��5+      �� 
��� � �$��50 30 50 30q�6$   .+�5,      �� .+�5-   
      EnglishApp.UserControl1  -   5          Name$ AnimalsC��5.   G      EnglishApp.UserControl1   MouseLeftButtonUp$  AnimalsC_MouseLeftButtonUp��6Y      
FirstImage$ Resources\capibar.jpg��5-         FirstOne$	 Red��6@      	SecondOne$ White��5.         FirstCategory$ Animals��6/   6Y   � 5/      .+�50      � -   5         �Name$ 
Animals_PB��50   )    � Value$ 0Q�6   #��[ 6=   6z   �� 51      -   5        $��TB_Animals_1��51   I   $��0��6   #��[  6%   6I   �� 52      $	��/15��6   #��[ 6'   53      54      �� 55      .+�56        -   5        $ Music_C��58   ?   $ Music_C_MouseLeftButtonUp��59      $&  Resources\rat_playing_guitar.png��56   %   $ Yellow��6S   $ White��57      $��	0 -10 0 0q�6/   $ Music instruments��58      59      � 5:      .+�5;      � -   5        $��Music_PB��5;   (   $ 0Q�6   #��[ 68   6\   �� 5<      -   5        $��
TB_Music_1��5<   I   $��0��6   #��[  6%   6I   �� 5=      $	��/15��6   #��[ 6'   5>      5?      �� 5@      .+�5B        -   5        $ Verbs_C��5D   3   $ Verbs_C_MouseLeftButtonUp��6D   $% Resources\cat_running_verbs.png��5B   %   $
 Blue��6R   $ White��5C      $��	0 -10 0 0q�6/   $ Verbs��5D      6D   � 5E      .+�5F      � -   5        $��Verbs_PB��5F   (   $ 0Q�6   #��[ 68   6\   �� 5G      -	   5        $��
TB_Verbs_1��5G   I   $��0��6   #��[  6%   6I   �� 5H      $	��/15��6   #��[ 6'   5I      5J      �� 5L      .+�5M        -
   5        $ 	PHVerbs_C��5O   ;   $! PHVerbs_C_MouseLeftButtonUp��6N   $) #Resources\boss_misunderstanding.png��5M   %   $ Purple��6V   $ White��5N      $��	0 -10 0 0q�6/   $ Phrasal verbs��5O      6N   � 5P      .+�5Q      � -   5        $��
PhVerbs_PB��5Q   (   $ 0Q�6   #��[ 6:   6^   �� 5R      -   5        $��TB_PHVerbs_1��5R   I   $��0��6   #��[  6%   6I   �� 5S      $	��/15��6   #��[ 6'   5T      5U      5V      5W      5X      