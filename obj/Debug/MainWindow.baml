   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��700��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��115* �6   �� 5      $
��577* �6   .+�5   
   �� $��
Zoo List
��6   $
��Left=�6-   $��	28,10,0,0q�6H   $	��Top=�6[   �� 5   
   -   5        $��listZoos��5      $
��Left=�6"   $	��201��6=   $��	10,42,0,0q�6J   $	��Top=�6]   $	��187��6u   $��2��6�   �� 5   
   $ ��Associated Animals List

��6   $
��Left=�6A   $��
144,10,0,0q�6\   $	��Top=�6p   $��1��6�   �� 5   
   -   5         ��Name$ listAssociatedAnimals��5      $
��Left=�61   $	��200��6L   $��
126,43,0,0q�6Y   $	��Top=�6m   $	��187��6�   $��1��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   �� 5   
   -   5        $ listAllAnimals��5      $
��Left=�6*   $	��324��6E   $��
369,43,0,0q�6R   $	��Top=�6f   $	��187��6~   $��1��6�   �� 5   
   -   5        $��
Delete Zoo��5      $
��Left=�6&   $��
28,288,0,0q�6A   $	��Top=�6U   $	��146��6m   $��27��6y   $��2��6�   6�   �� 5   
   -   5        $��Remove Animal��5      $
��Left=�6)   $��144,288,0,0q�6D   $	��Top=�6Y   $	��146��6q   $��27��6}   $��1��6�   �� 5   
   $��Delete Animal��6   $
��Left=�6)   $��397,372,0,0q�6D   $	��Top=�6Y   $	��146��6q   $��27��6}   $��1��6�   �� 5   
   $��Add Animal to Zoo��6   $
��Left=�6-   $��
397,11,0,0q�6H   $	��Top=�6\   $	��146��6t   $��27��6�   $��1��6�   �� 5   
   -   5        $��
Update Zoo��5      $
��Left=�6&   $��
28,372,0,0q�6A   $	��Top=�6U   $	��146��6m   $��37��6y   $��2��6�   6�   �� 5   
   $��Add Zoo��6   $
��Left=�6#   $��
28,324,0,0q�6>   $	��Top=�6R   $	��146��6j   $��43��6v   $��2��6�   �� 5   
   $��Update Animal��6   $
��Left=�6)   $��144,372,0,0q�6D   $	��Top=�6Y   $	��146��6q   $��37��6}   $��1��6�   �� 5   
   $��Add Animal Zoo��6   $
��Left=�6*   $��144,324,0,0q�6E   $	��Top=�6Z   $	��146��6r   $��43��6~   $��1��6�   �� 5   
   $��2��6   $
��Left=�6&   $��35��6A   $��
10,248,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $��TextBox��6u   $	��Top=�6�   $	��418��6�   5      5      