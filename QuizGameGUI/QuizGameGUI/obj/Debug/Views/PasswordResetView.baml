   M S B A M L   `   `   `  ����F  BQuizGameGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:QuizGameGUIQuizGameGUI  5      #    QuizGameGUI.PasswordResetView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:QuizGameGUI     5      .��5	      � ���	#FF252737  � ColumnDefinitions  5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��0��6    $
��Left=�6-   $��Bottom=�6H   $��Enter your new password:��5      
�������$
��Bold"�6B   �� 5   
   $��1��6   $��2��6    $
��Left=�6-   $��Bottom=�6H   $$��Enter your new password again:��5      
�������$
��Bold"�6H   ��6Z   Z� �� 5   
   $��Reset password��6   $��1��6(   $��0��68   $��0,24,0,0q�6E   $��Center=�6W   $	��Top=�5       �� TextAlignment$ Center=�6*   ���	#FF37EEED$��24(�6n   $��Arial Black)�6|   ��6A   Z� 6|   �� 5    
   -   5         ��Name$ newPasswordField��5       $��1��6,   $��1��6<   $��24(�5!      $��Center=�6    ���	#FF353340
�������6{   �� 5"   
   -   5        $ newPasswordFieldAgain��5"      $��1��61   $��3��6A   $��24(�5#      $��Center=�6    ���	#FF353340
�������6{   �� 5&   
   -   5         ��Name$ submitButton��5&      $��1��6'   $��4��67   $��Center=�6D   $	��Top=�6a   $��0,10,0,0q�6y   $��Submit��5'      $	��100��6   
�������$
��Bold"�6b   $��14(�6t   ��69   Z� 6t   �� 5*   
   -   5         ��Name$ errorMessage��5*      $��1��6&   $��4��66   $��Center=�6C   $��Center=�6^   $1��+Both fields have to contain the same value!��5+      $y�Hidden=�6B   
���  ��6V   5,      5-      