   M S B A M L   `   `   `  ����G  CWoodCalc_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:WoodCalc_WPF._viewmodelWoodCalc_WPF._viewmodel  5   D   1    +WoodCalc_WPF._view._userControls.SettingsUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5      6
_viewmodel%clr-namespace:WoodCalc_WPF._viewmodel  6D     � 	Resources  5
       �� 
TargetType �� Property �� Value   	baseStyle �� BasedOn  BrushPrimary1��%�  '��       '�� �     '�� L    7   7  �� 5   
   " ��6   .�5      ��  � ��$ Center=�62   �� 5       �@��TextAlignment$ Center=�6.   5      �� 5   
   " ��6   .�5      ��  � ��$ Center=�62   �� 5       �@��TextAlignment$ Center=�6.   �� 5       � ��$ 25��6*   �� 5       � ��$ 25��6)   5      �� 5   
   " ��6   8   .�5      ��  � ��8  6,   5      5      .��5      �� $
��Auto=�6   .��5   
   � $��5q�6   .+�5      ]� .+�5      �� $��
Nastavení��6   $
��Left=�6.   .��5      � .+�5      �� -   5         ��Name$ spMain��5   #   $	��305��63   $	��250��6?   $
��Left=�6L    �� Orientation$ Vertical=�6g   $	��Top=�6~   .+�5       �� $ 
Horizontal=�6)   $��5q�5!   !   $	��Top=�5"   !   .+�5#   "   �� Výchozí metoda výpočtu:5%   #   �� 5&   "   $��5,0,0,0q�5'   #    �� SelectedIndex 5&   +   ��  �� Path$ DefalutCalculationMethod�	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� Mode$
 TwoWay=���5'   4   �� *CalculationMethods+5(      �� 5)      -   5        $ stcpn_decialCount��5)   B   $ 
Horizontal=�6)   $	��Top=�5*   !   $��5,5,5,0q�66   .+�5+   "   �� ��6,   ��  �� ElementName$ stcpn_decialCount��$ Height�)'Počet desetinných míst ve výpočtu:5-   #   �� 5.   "   $
��Auto��5/   "   $��5,0,0,0q�6/    �� TextAlignment$ Center=�50   "   ��5.   *   �� $ DecimalPlacesCount�$	 Default=�.��50   9   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 51   &   +  %Microsoft.Xaml.Behaviors.EventTrigger  52   *      	EventName$ PreviewTextInput��69   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 53   .   4  .Microsoft.Xaml.Behaviors.Core.CallMethodAction     
MethodName$ Decimal_Checker��6Z      TargetObject 6A   �� 6Z   54   +   .��55   >   56   #   57      �� 58      $	��Top=�6'   $��5,5,5,0q�6<   $��14(�6M   $��0q�6[   ��59   "   �� 5:   &   -   5         ��Name$ barkIsActive��5:   /   $"��Zahrnutí kůry do výpočtu��6E   $��14(�6�    d� 	IsChecked 6h   �� $ BarkBox�$	 PropertyChanged=�$
 TwoWay=�6�   .��5<   "   �� -   5        $ sp_bark��5<   X   $ 
Horizontal=�6-   $��25,0,0,0q�6F   {�5=   %   �� $ barkIsActive��$ 	IsChecked�.+�5>   &   �� $��5,0,0,0q�6,   $��Center=�6=   .��6X   Výchozí tloušťka kůry:5@   '   �� 5A   &   $��50��5B   *   $��5,0,5,0q�65   $ Center=�5C   *   ��5A   .   �� $ DefaultThickness�$	 	LostFocus=�$
 TwoWay=�.��5C   e    5D   *     5E   .   $ PreviewTextInput��6=   . 5F   2     $ Decimal_Checker��6^    6E   �� 6^   5G   /   .��5H   B   5I   '   �� 5J   &   $��Center=�6,   .��6G   cm5L   '   5M   #   5N      �� 5V      $"��Aktivovat  jakostní třídy��6'   $	��Top=�5X      $��14,5,5,0q�5Y        5W      �� $ 
QualityBox�$
 TwoWay=�5Y       �� 5Z      $"��Aktivovat pole pro poznámky��6'   $	��Top=�5\      $��14,5,5,0q�5]        5[      �� $ TagBox�$
 TwoWay=�5]       �� 5^      $��Aktivovat druhy stromů��6'   $	��Top=�5`      $��14,5,5,0q�5a        5_      �� $ TypeOfTreeBox�$
 TwoWay=�5a       �� 5b      $	��Top=�6'   $	��5,5q�6<   ��5c   "   �� 5d   &   -   5        $ chckbxPrice��5d   /   $��Výpočet ceny za m³��6D    6a   �� *
PriceBox+$
 TwoWay=�.��5f   "   �� $ 
Horizontal=�6-   ��6F   �� $ sp_bark��$ Margin�{�6z   �� $ chckbxPrice��$ 	IsChecked�.+�5g   &   �� $��Center=�6j   {�6,   �� $ chckbxPrice��$ 	IsChecked�.��6�   Cena za m³:5i   '   �� 5j   &   $��60��6/   ��6:   �� $ PriceCalculation�$
 TwoWay=�$	 	LostFocus=�.��6�    5k   *     5l   .   $ PreviewTextInput��6=   . 5m   2     $ Decimal_Checker��6^    6E   �� 6^   5n   /   .��5o   B   5p   '   5q   #   5r      �� 5s      5t      5�      5�      5�      5�      5�      5�      