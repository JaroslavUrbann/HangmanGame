   M S B A M L   `   `   `  ����L  HSPSSE Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:hangmanhangman  5   	   5clr-namespace:hangman.ViewModelhangman.ViewModel  5   	   ?$clr-namespace:hangman.View.Converterhangman.View.Converter  5   	       hangman.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   'localclr-namespace:hangman     5   	   .vmclr-namespace:hangman.ViewModel     5   	   5conv$clr-namespace:hangman.View.Converter     5   	     � Title$  Aplikace��5   	   ��5   	   ��    Settings �� Source# [   �� Path$ MainWindowHeight� �� Mode$ TwoWay=���5	   	   �� # [  $ MainWindowWidth�$ TwoWay=� � Left 5
   	   �� # [  $ MainWindowLeft�$ TwoWay=�
 � Top 5   	   �� # [  $ MainWindowTop�$ TwoWay=� � 	Resources 5      /  )hangman.View.Converter.DoNothingConverter  testConverter$  hangman.View.Converter.Obrazek  obrazek��%:   &	       &	        5   
   6"     5   
   6)   5       � DataContext 5      %  hangman.ViewModel.MainViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��4* �6   6*   �� 5      $��3* �6   6*   �� 5      $��4* �6   6*   	 � ColumnDefinitions	 5   
   �� 5      6!   .+�5   
   �� 
 �� Padding$
 100,30,100,30q�6   $��Stretch=�6)   $��Stretch=�6E   $��1��6c   $��1q�6p   
���   �$��50,10,50,10q�6�   $��50��6�   $	��100��6�   ._�5      �� -   5         ��Name$ textBox��5   r   $��Stretch=�6    �� TextAlignment$ Center=�65   $��20(�6L   $��Stretch=�6�   $��1��6�   ��6Z   �� *Slovo2+6�   5      � 5   
   -   5         �Name$
 wrap��5   [   $��Stretch=�6   $��Stretch=�62   $��2��6N   6k   �� 5    
   -   5        $��a1��5       $��0��6   ��6'   �� *	Obrazek+ �� 	Converter# [ 6h   5!      5#      