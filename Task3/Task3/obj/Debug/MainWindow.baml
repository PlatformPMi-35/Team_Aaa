   M S B A M L   `   `   `  ����@  <Task3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task3Task3  5   	   -clr-namespace:Task3.ClassesTask3.Classes  5   	       Task3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task3     5   	   .local2clr-namespace:Task3.Classes     5   	     � Title$  Sushi��5	   	   $��463.4��6   $��1006.4��6&   $��1006.4��65   $��463.4��6G   $��1006.4��6Y   $��463.4��6k   $��0q�6}    � 
ResizeMode$ NoResize=�6�    � WindowStartupLocation$ CenterScreen=�6�    � ShowInTaskbar .   J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$$ local2:CommandForButton.ToList��5      6B   .��5      � -   5        $��General_grid��5      $��0,0,-8,0q�6   ��5   
   �� 5       �� ImageSource$ Images/bg_new.jpg��6   6;   .+�5   
   �� $��
763,0,7,79q�6   $��Images/list_ob.png��6$   $
��Fill=�6@   �� 5   
   -   5         ��Name$ buylist��5      $
��Left=�6#   $	��299��6>   $��
794,33,0,0q�6K   $	��Top=�6_   $	��180��6w   ���	#FFEC7505$��Arial)�6�   $��14(�6�   $
��Bold"�6�   ��6�   Z� ��6�   Z�  J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      	   	Direction$		 250Q�6#   
 � ContextMenu
 5      �� 5      .@�5      m� -   5        $��Delete��5       60   5      5      �� 5   
   $��Images/filadelfia_new.png��6   $
��Left=�64   $	��122��6O   $��	10,28,0,0q�6\   $	��Top=�6o   $	��229��6�    J� RenderTransformOrigin$ 
0.486,0.51&�6�   $
��Fill=�6�   �� 5    
   $��Images/big cash.png��6   $
��Left=�6-   $	��117��6H   $��
545,33,0,0q�6U   $	��Top=�6i   $	��220��6�   $
��Fill=�6�   $ 0.777,0.494&�6�   �� 5!   
   $��Images/asorti.png��6   $
��Left=�6+   $	��117��6F   $��
277,28,0,0q�6S   $	��Top=�6g   $	��220��6   $
��Fill=�6�   �� 5"   
   $��Images/california.png��6   $
��Left=�6/   $	��117��6J   $��
10,215,0,0q�6W   $	��Top=�6k   $	��220��6�   $ 0.642,0.372&�6�   $
��Fill=�6�   $��2��6�   �� 5#   
   $��Images/sayak.png��6   $
��Left=�6*   $	��117��6E   $��277,215,0,0q�6R   $	��Top=�6g   $	��220��6   $ 0.642,0.372&�6�   $
��Fill=�6�   �� 5$   
   $��Images/red dragon.png��6   $
��Left=�6/   $	��117��6J   $��545,215,0,0q�6W   $	��Top=�6l   $	��220��6�   $ 0.642,0.372&�6�   $
��Fill=�6�   �� 5%   
   -   5         ��Name$ butt1��5%      $$��local2:CommandForButton.ToList��6    $��	Buy 1 set��6I   $
��Left=�6]   $��	20,28,0,0q�6x   $	��Top=�6�   $	��207��6�   $	��117��6�    J� Opacity$ 0Q�6�   �� 5&   
   -   5        $ butt2��5&      $$��local2:CommandForButton.ToList��6    $��	Buy 1 set��6I   $
��Left=�6]   $��
277,28,0,0q�6x   $	��Top=�6�   $	��220��6�   $ 0Q�6�   $	��117��6�   �� 5'   
   -   5        $ butt3��5'      $$��local2:CommandForButton.ToList��6    $��	Buy 1 set��6I   $
��Left=�6]   $��
545,33,0,0q�6x   $	��Top=�6�   $	��220��6�   $ 0Q�6�   $	��117��6�   �� 5(   
   -   5        $ butt4��5(      $$��local2:CommandForButton.ToList��6    $��	Buy 1 set��6I   $
��Left=�6]   $��
10,215,0,0q�6x   $	��Top=�6�   $	��220��6�   $ 0Q�6�   $	��117��6�   �� 5)   
   -	   5        $ butt5��5)      $$��local2:CommandForButton.ToList��6    $��	Buy 1 set��6I   $
��Left=�6]   $��277,215,0,0q�6x   $	��Top=�6�   $	��220��6�   $ 0Q�6�   $	��117��6�   �� 5*   
   -
   5        $ butt6��5*      $$��local2:CommandForButton.ToList��6    $��	Buy 1 set��6I   $
��Left=�6]   $��545,215,0,0q�6x   $	��Top=�6�   $	��220��6�   $ 0Q�6�   $	��117��6�   �� 5+   
   $��Sum in UAH: ��6   $
��Left=�6'   $��816,308,0,0q�6B   $	��Top=�6W   $��Arial)�6o   $
��Bold"�6�   $��14(�6�   
���  ����6�   Z�  5,        5-         Color$	 Red��6#   $	 0Q�6/      ShadowDepth$ 0Q�6=      
BlurRadius$ 3Q�6M   5/      �� 50   
   $��806,337,0,-5q�6   $��Images/MakeAnOrder.png��6&   $
��Fill=�6F   �� 51   
   -   5         ��Name$
 Sum1��51      $��0��6   $
��Left=�6*   $��905,308,0,0q�6E   $	��Top=�6Z   $��Arial)�6�   $
��Bold"�6�   $��14(�6�   
���  ����6r   Z�  52        53      $	 Red��6#   $	 0Q�6/   $ 0Q�6=   $ 3Q�6M   55      �� 56   
   -   5        $ Order��56      $��Images/Make an order��6    $
��Left=�6U   $��818,349,0,0q�6p   $	��Top=�6�   $	��188��6�   $ 	0.702,0.5&�6�   $ 0Q�6�   $��83��6�   �� 57   
   $��828,-3,64,383q�6   $��Images/YourList.png��6'   $
��Fill=�6D   $ 0.5,0.5&�6S   z�58      V� 59      .~�5:      �� �� 5;      �� 5<       �� Angle$ -6.403Q�6&   T� 5=      5>      5@      5D      5E      