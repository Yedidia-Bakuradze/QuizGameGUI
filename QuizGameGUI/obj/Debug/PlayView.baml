   M S B A M L   `   `   `  ����F  BQuizGameGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:QuizGameGUIQuizGameGUI  5          QuizGameGUI.PlayView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:QuizGameGUI     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $	��185 �6   �� 5      $��80 �6   �� 5      $��10 �6   �� 5      $��80 �6   �� 5      $��50 �6   .+�5   
   �� -   5         ��Name$ questionCountLable��5      $��Question x out of y��6,   $��10q�6J   $��12(�6V   $	��Top=�5      $
��Left=�6(   �� 5   
   -   5        $ creatorUsername��5      $��0��6)   $��0��66   $��4��6F   $��Creator: Unlnow��5      $��0,10,0,0q�6*   $��Center=�6<   $	��Top=�6Y   $��12(�6q   �� 5   
   -   5        $ rightQuestionsCounter��5      $��DemoDemo��6/   $��0��6B   $��0��6R   $��4��6_   $	��Top=�5      $��Center=�6/   $��0,50,0,0q�6L   �� 5    
   -   5        $��3��5       $��0��6!   $��Right=�6.   $��28��5!      $��68��6   $
��Exit��6(   $	��Top=�67   $��	0,10,10,0q�6O   6b   �� 5%   
   -   5        $ questionTitle��5%      $��0��6'   $��1��64   $��2��6D   $��The Question��6X   $��Center=�5&      $��Center=�6-   $��24(�5'      �� 5(   
   -   5         ��Name$
 btn1��5(      $��1��6   $��1��6,   $��0,0,5,0q�6<   6M   �� 5)   
   -   5        $
 btn2��5)      $��1��6   $��2��6,   $��5,0,0,0q�6<   6M   �� 5*   
   -   5        $
 btn3��5*      $��3��6   $��1��6,   $��0,0,5,0q�6<   6M   �� 5+   
   -	   5        $
 btn4��5+      $��3��6   $��2��6,   $��5,0,0,0q�6<   6M   �� 5-   
   -
   5        $ submitAnswerButton��5-      {�.  $��1��6?   $��4��6O   $��2��6\   $	��Top=�5.      $��Center=�6)   $	��100��6F   $��40��6R   $��0,10,0,0q�5/      $��Next Question��6#   6;   52      53      