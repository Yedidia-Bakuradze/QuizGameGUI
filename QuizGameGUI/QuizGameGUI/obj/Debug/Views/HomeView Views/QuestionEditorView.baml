   M S B A M L   `   `   `  ����F  BQuizGameGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:QuizGameGUIQuizGameGUI  5      $    QuizGameGUI.QuestionEditorView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:QuizGameGUI     5      .��5	      �� ���	#FF252737  �� CornerRadius$  10��6$   ._�5
   
   � -   5         �Name$ questionEditor��5
       � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $	��240 �6#   �� 5      $	��240 �6#   �� 5      $��* �6#    � RowDefinitions 5      �� 5      $��* �6    �� 5      $��10 �6    �� 5      $��40 �6    �� 5      $��10 �6    �� 5      $��40 �6    �� 5      $��10 �6    �� 5      $��40 �6    �� 5      $��10 �6    �� 5      $��40 �6    �� 5      $��* �6    .+�5      �� -   5         ��Name$ questionCounterField��5      $��10��62   $��1��6@   $��2��6P   $��Center=�5       $��Bottom=�61   $��0,0,0,15q�5!      $��Question Number: ��6&   $��24(�6B   
�������6P   �� 5$      $��0��6   $��1��6!   $��2��61   $��Whats the Question?��6E   $��Center=�5%      $��Center=�61   $
��Bold"�6L   $��14(�5&      $��Arial Black)�6"   $��0,0,0,40q�6;   
�������6M   �� 5'      -   5         ��Name$ theQuestionFiled��5'      $��0��60   $��1��6=   $��2��6M   $��Center=�5(      $��Bottom=�63   $��0,0,0,10q�6N   $
��Left=�5)      $��Center=�68   $��24(�5*      $	��300��6$   $��40��60   
����������	#FF3533405+   )   �� 50      $��2��6   $��1��6!   $$��Enter Your first wrong answer:��61   $
��Left=�51      $��Center=�6/   $
��Bold"�6J   $��Arial Black)�6\   
�������6u   �� 52      $��4��6   $��1��6!   $%��Enter Your second wrong answer:��61   $
��Left=�53      $��Center=�6/   $
��Bold"�6J   $��Arial Black)�6\   
�������6u   �� 54      $��6��6   $��1��6!   $$��Enter Your third wrong answer:��61   $
��Left=�55      $��Center=�6/   $
��Bold"�6J   $��Arial Black)�6\   
�������6u   �� 56      $��8��6   $��1��6!   $"��Enter Your only ture answer:��61   $
��Left=�57      $��Center=�6/   $
��Bold"�6J   $��Arial Black)�6\   
�������6u   �� 5:      -   5        $ 
fAns1Field��5:      $��2��6*   $��2��67   $��24(�5;      $��Center=�6$   ���	#FF353340
�������6   �� 5<      -   5        $ 
fAns2Field��5<      $��4��6*   $��2��67   $��24(�5=      $��Center=�6$   ���	#FF353340
�������6   �� 5>      -   5        $ 
fAns3Field��5>      $��6��6*   $��2��67   $��24(�5?      $��Center=�6$   
����������	#FF3533406{   �� 5@      -   5        $ 	tAnsField��5@      $��8��6)   $��2��66   $��24(�5A      $��Center=�6$   
����������	#FF3533406{   �� 5D      -   5         ��Name$ quizDoneButton��5D      $��2��6-   $��10��6>   $��Center=�5E      $	��Top=�6.   $��5q�6F   $��Finish The Quiz��5F      $	��250��6+   $��30��67   
�������$��14(�5G   >   $
��Bold"�5H      {�.  ��5G      Z� ��5H   '   Z� 6>   �� 5J      -	   5        $ nextQuestionButton��5J      $��1��61   $��10��6A   $��Center=�5K      $	��Top=�62   $��5q�6J   $��Add Another Question��5L      $	��250��64   $��30��6@   
�������$��14(�5N      $
��Bold"�6#   {�.  ��5M   <   Z� ��5N   5   Z� 6L   �� 5Q      -
   5         ��Name$ 
finalField��5R   8   $��0��5Q      $��4��6)   $y�Hidden=�6=   $��0��5R      $��11��6&   $��Center=�5S      $��Center=�66   .+�5V      �� ���#FFFFFF$ ��Enter the name of the quiz��61   �� 5W      $	��250��6   $��40��6%   ���	#FF353340$  5��6H   ._�5X      �� -   5        $ quizNameField��5Z      $��21(�5X      $��Center=�6,   ���#FFFFFF
������ $��0q�5Z   N   6b   5[      �� 5^      $��0,10,0,0q�6   ���#FFFFFF$%��Enter a discription of the quiz��6C   �� 5_      $	��250��6   $��40��6%   ���	#FF353340$  5��6H   ._�5`      �� -   5        $ quizDiscription��5a   3   $��21(�5`      $��Center=�6,   ���#FFFFFF
������ $��0q�5a   e   6y   5b      �� 5e      $��0,10,0,0q�6   ���#FFFFFF$��Choose a category��6C   �� 5g      $  5��6   ���	#FF353340._�5h      �� -   5         ��Name$ catergoryList��5h      $��0q�65   
������ 
�������$��Center=�5i      .@�5j      �� $��0,10,0,0q�6&   $��Science��68   �� 5k      $��0,10,0,0q�6&   $��Mathematics��68   �� 5l      $��0,10,0,0q�6&   $��History��68   �� 5m      $��	0,10,0,10q�6&   $��Programming��69   5n      5o      �� 5q      -   5        $ 	btnSubmit��5q      $��0,10,0,0q�6,   ���#3FC845$��Submit Quiz��6S   ���#FFFFFF   SubmitButtonRoundingStyle#��[  5r      $��30��6L   $	��100��6X   {�.  5s   +   �� 5v      -   5        $ errorMsg��5v      $�� ��6*   $��Center=�5w      
���  ��6<   5y      5z      5{      5|      