   M S B A M L   `   `   `  ���� E  AEnglishApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:EnglishApp
EnglishApp      EnglishApp.Categories   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     *localclr-namespace:EnglishApp       N� Title$  
Categories�� N� 
Background
 ��� � � 	Resources    
TextBlock1 �� 
TargetType �� Property �� Value  
TextBlock2 �� BasedOn �� 
TargetType  PBWords �� CornerRadius	 �� Padding
 �� Path �� RelativeSource �� AncestorType��%�  &	        &	 u     7   &	 �     �� " ��.���  � ��$ Center=���  � ��$ Center=���  � ��$ 
0 -14 30 0q���  � ��$ 16(��� " ��8   .���  � ��$ 	0 -14 0 0q��� " �.R��� $ 4��$	 5q�$��
50 5 50 20q�$��30��$��2q�
����� �._�� ���� .���  �@�Value �� $
 Value� �� " ���  � ��
 �  ����  � ��
 � �����  �@�Maximum$ 30Q�.���� .���� 
��� � �$��50 30 50 30q�.+��� .+�   EnglishApp.UserControl1  -     Name$ AnimalsC��   EnglishApp.UserControl1   MouseLeftButtonUp$  AnimalsC_MouseLeftButtonUp��   
FirstImage$ Resources\capibar.jpg��   FirstOne$	 Red��   	SecondOne$ White��   FirstCategory$ Animals��� .+�� -    �Name$ 
Animals_PB�� � Value$ 0Q�#��[ �� -   $��TB_Animals_1��$��0��#��[  �� $	��/15��#��[ �� .+�  -   $ Music_C��$ Music_C_MouseLeftButtonUp��$&  Resources\rat_playing_guitar.png��$ Yellow��$ White��$��	0 -10 0 0q�$ Music instruments��� .+�� -   $��Music_PB��$ 0Q�#��[ �� -   $��
TB_Music_1��$��0��#��[  �� $	��/15��#��[ �� .+�  -   $ Verbs_C��$ Verbs_C_MouseLeftButtonUp��$% Resources\cat_running_verbs.png��$
 Blue��$ White��$��	0 -10 0 0q�$ Verbs��� .+�� -   $��Verbs_PB��$ 0Q�#��[ �� -	   $��
TB_Verbs_1��$��0��#��[  �� $	��/15��#��[ �� .+�  -
   $ 	PHVerbs_C��$! PHVerbs_C_MouseLeftButtonUp��$) #Resources\boss_misunderstanding.png��$ Purple��$ White��$��	0 -10 0 0q�$ Phrasal verbs��� .+�� -   $��
PhVerbs_PB��$ 0Q�#��[ �� -   $��TB_PHVerbs_1��$��0��#��[  �� $	��/15��#��[ 