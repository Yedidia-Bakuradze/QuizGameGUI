   M S B A M L   `   `   `  ����F  BQuizGameGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:QuizGameGUIQuizGameGUI  5          QuizGameGUI.SignupView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:QuizGameGUI     5      .��5	      � ���	#FF252737  � ColumnDefinitions  5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��* �6   .+�5   
   �� $��
Full Name:��6   $��1��6%   $��0��65   $��Bottom=�5      $
��Left=�6+   $��Arial)�5      
�������$��16(�66   ��5   F   Z� 5   6   �� 5   
   $��	Username:��6   $��1��6$   $��2��64   $��Bottom=�5      $
��Left=�6+   $��Arial)�6F   ���	#FFFDFDFD$��16(�5   '   �� 5    
   $��	Password:��6   $��1��6$   $��4��64   $��Bottom=�5!      $
��Left=�6+   $��Arial)�6F   
�������$��16(�5"   #   �� 5%   
   -   5         ��Name$ 	nameField��5%      $��1��6%   $��1��65   $��24(�5&   4   $��Center=�6B   .��6d   ��5'      �� 5(       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5)      �  � Color$ 	#FFB9B4C7��6#   � 5*      $ 	#FFB9B4C7��6#    � Offset$ 1Q�65   5+      .��5,   "   5-      �� 5.   
   -   5        $ usernameField��5.      $��1��6)   $��3��69   $��24(�5/   4   $��Center=�6B   ���	#FFB9B4C76d   �� 50   
   -   5        $ passwordField��50      $��1��6)   $��5��69   $��Arial)�51   4   $��24(�6G   $��Center=�6U   ���	#FFB9B4C752      �� 54   
   -   5         ��Name$ submitButton��54      $��1��6'   {�.  $��6��6I   $��0,20,0,0q�55      $	��100��6#   $	��Top=�6/   $��Center=�6G   $��Submit��56      ���	#FF16AFFB67   �� 59   
   -   5         ��Name$ loginRediraction��59      $y�Hidden=�6/   $��1��6C   $��8��6S   	 �� Orientation$	 
Horizontal=�6`   $��Center=�6y   $��Center=�6�   .+�5:      �� -   5        
 ��Name$
 errorMessage��5:      $��User already exists��6*   
���  ��6H   �� 5;      -   5        $��
Login Here��5;      $��10,0,0,0q�6*   6<   5<      5A      5B      