   M S B A M L   `   `   `  ���� F  Bwoodcalc_00, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:woodcalc_00._viewmodelwoodcalc_00._viewmodel  0    *woodcalc_00._view._userControls.SettingsUC   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5
_viewmodel$clr-namespace:woodcalc_00._viewmodel    � 	Resources   �� 
TargetType �� Property �� Value   	baseStyle �� BasedOn  BrushPrimary1��%  '��       '�� O     '�� �     7   7  �� " ��.���  � ��$ Center=���  �@��TextAlignment$ Center=��� " ��.���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ 25����  � ��$ 25���� " ��8   .���  � ��8  .���� $
��Auto=�.��� $��5q�.+�]� .+��� $��
Nastavení��$
��Left=�.��� .+��� -    ��Name$ spMain��$	��305��$	��250��$
��Left=� �� Orientation$ Vertical=�$	��Top=�.+��� $ 
Horizontal=�$��5q�$	��Top=�.+��� Výchozí metoda výpočtu:�� $��5,0,0,0q� �� SelectedIndex ��  �� Path$ DefalutCalculationMethod�	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� Mode$
 TwoWay=����� *CalculationMethods+�� -   $ stcpn_decialCount��$ 
Horizontal=�$	��Top=�$��5,5,5,0q�.+��� ����  �� ElementName$ stcpn_decialCount��$ Height�)'Počet desetinných míst ve výpočtu:�� $
��Auto��$��5,0,0,0q� �� TextAlignment$ Center=����� $ DecimalPlacesCount�$	 Default=�.��*  $Microsoft.Xaml.Behaviors.Interaction   Triggers +  %Microsoft.Xaml.Behaviors.EventTrigger     	EventName$ PreviewTextInput��*  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 4  .Microsoft.Xaml.Behaviors.Core.CallMethodAction     
MethodName$ Decimal_Checker��   TargetObject �� .���� $	��Top=�$��5,5,5,0q�$��14(�$��0q����� -    ��Name$ barkIsActive��$"��Zahrnutí kůry do výpočtu��$��14(� d� 	IsChecked �� $ BarkBox�$	 PropertyChanged=�$
 TwoWay=�.���� -   $ sp_bark��$ 
Horizontal=�$��25,0,0,0q�{��� $ barkIsActive��$ 	IsChecked�.+��� $��5,0,0,0q�$��Center=�.��Výchozí tloušťka kůry:�� $��50��$��5,0,5,0q�$ Center=����� $ DefaultThickness�$	 	LostFocus=�$
 TwoWay=�.��   $ PreviewTextInput��.   $ Decimal_Checker�� �� .���� $��Center=�.��cm�� $"��Aktivovat  jakostní třídy��$	��Top=�$��14,5,5,0q� �� $ 
QualityBox�$
 TwoWay=��� $"��Aktivovat pole pro poznámky��$	��Top=�$��14,5,5,0q� �� $ TagBox�$
 TwoWay=��� $��Aktivovat druhy stromů��$	��Top=�$��14,5,5,0q� �� $ TypeOfTreeBox�$
 TwoWay=��� $	��Top=�$	��5,5q����� -   $ chckbxPrice��$��Výpočet ceny za m³�� �� *
PriceBox+$
 TwoWay=�.���� $ 
Horizontal=����� $ sp_bark��$ Margin�{��� $ chckbxPrice��$ 	IsChecked�.+��� $��Center=�{��� $ chckbxPrice��$ 	IsChecked�.��Cena za m³:�� $��60������ $ PriceCalculation�$
 TwoWay=�$	 	LostFocus=�.��   $ PreviewTextInput��.   $ Decimal_Checker�� �� .���� 