   M S B A M L   `   `   `  ���� F  Bwoodcalc_00, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:woodcalc_00._viewmodelwoodcalc_00._viewmodel  0    *woodcalc_00._view._userControls.ExportView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;
viewModels$clr-namespace:woodcalc_00._viewmodel       � 	Resources   �� 
TargetType   	baseStyle �� BasedOn �� Property �� Value  customBorder��%  '	�       7   '�� \     &	      �� " 	�8   .���  � ��$ Center=���  � ��$ Center=���  � ��$ 30���� " ��.���  � ��$ 14(��� " ��.���  � ��$	 1.5q���  � �� �#189ab4��  �@��CornerRadius$ 5��.��]� .+��� #��[ $��5q� �� Padding$ 5q�$	��320��._��� $
��Left=�$
��Left=�$��0q�.+�	�  d� 	IsChecked �� *AllDataActive+.��Uložit veškerá data	� -    	�Name$ rbsSpecificMethod��$��Center=�.����  �� Orientation$ 
Horizontal=�$��25��.+��� -   	 ��Name$	 tbSave��$ ��Uložit data dle výpočtu��$��Center=��� $	��5,0q�$	��140������ *CalculationMethods+{��� 
 �� ElementName$
 rbsSpecificMethod�� �� Path$ 	IsChecked� �� SelectedItem �� *TypeOfCalculation+ �� Mode$ OneWayToSource=��� $ 
Horizontal=�$��25��$��0,2.5q�.+��� $��Uložit do:��$��65��$��Center=��� -    ��Name$ FilePathTextBox��$	��200��$��0,0,0,0q�$��25��$	��215������ *Path+�� -   $��25��
�������
�������.���� $��/Icon/folder-3-16.png���� $ 
Horizontal=�$��0,2.5q�$��25��$��Center=�.+��� $��Formát Souboru��$��Center=��� $	��5,0q�$��50��$��14(� �� SelectedValue �� *Format+.@��� .��xlsx�� .��csv�� $��30��  styledButton#��[ $��Uložit������ *SaveFileCommand+�� #��[ $��0,5,5,5q�._��� ���� *
DataList+���� " ��.���  � ��$ Center=� �� View ��  �� AllowsColumnReorder$
 true��.P��� $��ID�� �� Width$ 80�� �� DisplayMemberBinding �� *Id+�� $	 150�� �� *Calculation.TypeOfCalculation+.���� .��	Výpočet � ContextMenu �� -   $��
LastNameCM��.@�m� $��	Ascending��m� $��
Descending���� $��Objem (m³)��$	 100�� �� *Volume+�� $��
Délka (m)��$	 100�� �� *Length+�� $��Průměr čepu��$	 100�� �� *DiameterBottom+�� $��Průměr středu��$	 100�� �� *DiameterMiddle+�� $��Průměr čela��$	 100�� �� *DiameterTop+�� $��
Cena (Kč)��$	 100�� �� *Value+�� $��Jakost��$ 60�� �� *Quality.QualityClass+�� $��Druh Dřeviny��$
 Auto�� �� *Tree.TypeOfTree+�� $��Kůra��$ 60�� �� *Bark+�� $��	Poznámka��$	 200�� �� *Tag+