   M S B A M L   `   `   `  ����L  HNCS_Formacion_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:NCS_Formacion_WPFNCS_Formacion_WPF  5   	   %    NCS_Formacion_WPF.Busqueda_View   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:NCS_Formacion_WPF     5   	     � Title$  Busqueda��5   	   $��343.926��6   $��697.343��6+   .��5      ]� .+�5   
   �� -   5        $��ListaBusqueda��5      $
��Left=�6'   $��20��6=   ��5      �� 5       �� 
TargetType" ��6    �� Triggers 5      :� 5       :� RoutedEvent$ 
MouseLeave��6'   [�5      �� 5   "   .��5   &   �� .��5   *   W�  g� Duration$ 	0:0:0.800D�6:    �� TargetProperty$ Width�6O   	 W� To$ 20X�6q   5   '   5   #   5      :� 5      $ 
MouseEnter��6'   [�5      �� 5   "   .��5    &   �� .��5!   *   W� $ 	0:0:0.300D�6:   $ Width�6O   $	 100X�6q   5"   '   5#   #   5%      5'      ��5*      �� 5+      .R�5,      �  �Name$ Busqueda��6   $	��0,2q�6/    � ColumnDefinitions 5.      �� 5/      $��* �6/   �� 50      $	��100 �6/   .+�52      �� ��6$   �� *NombreBusqueda+53      54      57      � 59   
   $��0,0,-8,0q�6   .+�5<      �� -   5        	 ��Name$	 	txbTitulo��5<      $
��Left=�6)   $��23��6D   $��	77,79,0,0q�6P   
 �� TextWrapping$

 Wrap=�6c   $	��Top=�6�   $	��120��6�   ��6w   �� *Busqueda_Model.Titulo+6�   �� 5=      -   5        $	 txbAno��5=      $
��Left=�6&   $��23��6A   $��
216,79,0,0q�6M   $

 Wrap=�6a   $	��Top=�6�   $	��120��6�   ��6u   �� *Busqueda_Model.Ano+6�   �� 5>      -   5        $	 	txbGenero��5>      $
��Left=�6)   $��23��6D   $��
353,79,0,0q�6P   $

 Wrap=�6d   $	��Top=�6�   $	��120��6�   ��6x   �� *Busqueda_Model.Genero+6�   �� 5?      -   5         ��Name$ button��5?      $��Buscar��6%   $
��Left=�66   $��
494,79,0,0q�6Q   $	��Top=�6e   $��75��6}   ��6�   �� *BuscarPelicula+�� 5B      -   5         ��Name$ label��5B      $��Titulo��6#   $
��Left=�64   $��	77,48,0,0q�6O   $	��Top=�6b   �� 5C      -   5        $ label1��5C      $
��Año��6$   $
��Left=�62   $��
216,48,0,0q�6M   $	��Top=�6a   �� 5D      -   5        $ label2��5D      $��Genero��6$   $
��Left=�65   $��
353,48,0,0q�6P   $	��Top=�6d   �� 5E      -	   5        $ label3��5E      $��	Resultado��6$   $
��Left=�68   $��
77,119,0,0q�6S   $	��Top=�6g   �� 5G      -
   5        $��ResultadoListView��5G      $
��Left=�6R   $	��107��6m   $��
77,150,0,0q�6z   $	��Top=�6�   $	��396��6�   ��60   �� *	Resultado+ �� View 5H      �� 5I      -   5        Pelicula��.P�5J      �� $��Title��6)    �� Width$	 120��68    �� DisplayMemberBinding 6D   �� *Title+�� 5K      $
��Year��6)   $ 50��67    6B   �� *Year+�� 5L      $
��Type��6)   $	 150��67    6C   �� *Type+5M      5O      5T      5W      5X      