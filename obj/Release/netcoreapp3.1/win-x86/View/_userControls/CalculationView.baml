   M S B A M L   `   `   `  ���� F  Bwoodcalc_00, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:woodcalc_00._viewmodelwoodcalc_00._viewmodel  5    /woodcalc_00._view._userControls.CalculationView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      Bd2http://schemas.microsoft.com/expression/blend/2008      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  4	viewModel$clr-namespace:woodcalc_00._viewmodel    � 	Resources     	BoolToVis  stcpnl_Left �� 
TargetType �� Property �� Value  	baseStyle �� BasedOn  customBorder��%  &	        &	      '�� �     7  '��     &	 o    �� �� " ��.���  � ��$
 Left=���  �@��Orientation$ Vertical=���  � ��$	 110����  � ��$ 5,2.5,2.5,5q��� " ��8   .���  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=���  � ��$ 25���� " ��.���  � ��$ Center=���  �@��TextAlignment$
 Left=���  � ��$ 14(��� " ��.���  � ��$	 1.5q���  � �� �#189ab4��  �@��CornerRadius$ 5��.���  � ColumnDefinitions �� $	��380 ��� $��* ��� $��1�� � RowDefinitions �� $��50 ��� $��50 ��� $��50 ��� $��* ��� $��50���� $��50 �.+��� $��0��$��6��#��[ $��5q�$	��370��._�� -   $��WP_calValues��$	��360��$��Center=�$��0��$��7��.+���  �� Orientation$ 
Horizontal=�$	��350��$	��5,5q�.+��� $��Výpočet dle: ��$
��Auto�� �� Padding$ 5q�$��14(��� -   	 ��Name$	 cbCalMethods��$	��155��$��Center=�$��14(�
 �� SelectedItem
 ��  �� Path$ SelectedCalculation� �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=� �� SelectedIndex �� $ DefaultIndex�$ OneWay=����� $ CalculationMethods��� $
��24.5��$��25��$
��80,0q�
�������$��0q� � ToolTip$ Vyčistit formulář������ *ClearCommand+.���� $"��/Icon/delete-property-32.png���� #��[ $	��350��$ 
Horizontal=�.+��� $ 
Horizontal=�$	��170��.+��� $��Objem��$��Center=�$
��Left=�$��0,5,10,5q�$
��Auto��$ 0,0,0,0q�$��16(��� -   $��volume��$
��Auto��$��30��$��16(� �� TextAlignment$ Center=�$��Center=����� $ Default=�$" CurrectDeliveredClass.Volume�$ PropertyChanged=��� $	��m³��$
 10,0q�$��16(��� -    ��Name$ stckpnl_Price��$ 
Horizontal=�$	��170��y��� $ PriceBox� �� 	Converter# [  .+��� $
��Cena��$��5q�$��16(��� -    ��Name$ price��$ Center=�$
��Auto��$��16(�$��30������ $$ CurrectDeliveredClass.LogValue�$ PropertyChanged=��� $��16(�$	 3,0q�Kč�� -   $��sp_TreeClass��$	��170������ " ��# [ .���  � y�$ 	Collapsed=� �� Triggers ��  �� Binding �� $- 'CurrectDeliveredClass.TypeOfCalculation� �� Value ČSN 48 0009.a���  � y�$ Visible=�.+��� $��Skupina dřeviny���� $��25��$��14(�����  �� ElementName$ sp_TreeClass��$ Width� �� *)'CurrectDeliveredClass.SelectedTreeClass+$ PropertyChanged=�$ TwoWay=����� *#!CurrectDeliveredClass.TreeClasses+*  $Microsoft.Xaml.Behaviors.Interaction   Triggers +  %Microsoft.Xaml.Behaviors.EventTrigger     	EventName$ SelectionChanged��*  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 4  .Microsoft.Xaml.Behaviors.Core.CallMethodAction     
MethodName$ TreeListSelectionChanged��   TargetObject �� �� -   $��sp_Diameter_Bottom������ $ sp_Diameter_Bottom��$ Width����� " ��# [ .���  � y�$ Visible=� ��  �� $- 'CurrectDeliveredClass.TypeOfCalculation� Huberův vzorec.a���  � y�$ 	Collapsed=���  �� $- 'CurrectDeliveredClass.TypeOfCalculation� ČSN 48 0007.a���  � y�$ 	Collapsed=���  �� $- 'CurrectDeliveredClass.TypeOfCalculation� ČSN 48 0009.a���  � y�$ 	Collapsed=�.+��� Čepová tloušťka (cm)�� -   $��diameterBottom��$
��Left=�$B <Tloušťka měřená na tenkém konci (čepu) v centimetrech������ $ sp_Diameter_Top��$ Width����� $ TwoWay=�$ PropertyChanged=�$* $CurrectDeliveredClass.DiameterBottom� �� Delay$	 250��.��   $ PreviewTextInput��.   $ Decimal_Checker�� �� .���� -	   $��sp_Diameter_Middle������ $ 	SP_length��$ Width����� " ��# [ .���  � y�$ Visible=� ��  �� $- 'CurrectDeliveredClass.TypeOfCalculation� Smalianův vzorec.a���  � y�$ 	Collapsed=�.+��� $< 6Tlošťka měřená uprostřed kulatiny v centimetrech��Středová tloušťka (cm)�� -
   $��diameterMiddle�� �� TextAlignment$ Center=����� $ sp_Diameter_Middle��$ Width����� $ Default=�$ PropertyChanged=�$* $CurrectDeliveredClass.DiameterMiddle�$
 1000��.��   $ PreviewTextInput��.   $ Decimal_Checker�� �� .���� -   $��sp_Diameter_Top������ $ 	SP_length��$ Width����� " ��# [ .���  � y�$ Visible=� ��  �� $- 'CurrectDeliveredClass.TypeOfCalculation� Huberův vzorec.a���  � y�$ 	Collapsed=���  �� $- 'CurrectDeliveredClass.TypeOfCalculation� ČSN 48 0007.a���  � y�$ 	Collapsed=���  �� $- 'CurrectDeliveredClass.TypeOfCalculation� ČSN 48 0009.a���  � y�$ 	Collapsed=�.+��� $; 5Tloušťka měřená na tlustém konci v centimetrech��Čelová tloušťka (cm)�� -   $��diameterTop��$ Center=����� $ sp_Diameter_Bottom��$ Width����� $ TwoWay=�$ PropertyChanged=�$' !CurrectDeliveredClass.DiameterTop�$	 250��.��   $ PreviewTextInput��.   $ Decimal_Checker�� �� .���� -   $��	SP_length��#��[ $	��170��.+��� $ Délka kulatiny v metrech��
Délka (m)�� -   $��length��$ Center=����� $ PropertyChanged=�$&  CurrectDeliveredClass.TreeLength�$	 250��$ TwoWay=�.��   $ PreviewTextInput��.   $ Decimal_Checker�� �� .���� -   $ spckpnl_typeOfTree2������ " ��# [ .���  � y�$ 	Collapsed=� ��  �� $- 'CurrectDeliveredClass.TypeOfCalculation� ČSN 48 0009.a���  � y�$ Visible=���  � ��$	 170��.+��� Druh dřeviny��  �� 
IsReadOnly$
 True��$��14(�$��25������ $ spckpnl_typeOfTree2��$ Width����� $ TypeOfTreeList�
 �� *" CurrectDeliveredClass.TypeOfTree+$ OneWayToSource=� �� *TypeOfTreeSelectedIndex+$ TwoWay=�� .+��� -   $ spckpnl_typeOfTree������ " ��# [ .���  � y� �� $ TypeOfTreeBox�# [   ��  �� $- 'CurrectDeliveredClass.TypeOfCalculation� ČSN 48 0009.a���  � y�$ 	Collapsed=�.+��� Druh dřeviny�� $
 True��$��14(�$��25������ $ spckpnl_typeOfTree��$ Width����� $ TypeOfTreeList�
 �� *" CurrectDeliveredClass.TypeOfTree+ �� *TypeOfTreeSelectedIndex+$ TwoWay=��� -   $��spcpnl_Bark������ " ��# [ .���  � y� �� $ BarkBox�# [   ��  �� $- 'CurrectDeliveredClass.TypeOfCalculation� ČSN 48 0009.a���  � y�$ 	Collapsed=�.+��� Tloušťka kůry�� $% Tloušťka kůry v centimetrech��$ Center=����� *CurrectDeliveredClass.Bark+$ PropertyChanged=�$ TwoWay=�$
 1000��  �� StringFormat$	  0.0��.��   $ PreviewTextInput��.   $ Decimal_Checker�� �� .���� -   $ stckpnl_quality��#��[ y��� $ 
QualityBox�# [  .+��� Jakost�� $
 True��$	��2.5q�$��14(�$��25��$��Center=�$��Center=����� $ stckpnl_quality��$ Width����� $ QualityList�
 �� $# CurrectDeliveredClass.Quality�$ TwoWay=� �� *QualitySelectedIndex+$ TwoWay=��� -   $��
spcpnl_Tag��#��[ $	��347��$ Vertical=�y��� $ TagBox�# [  .+��� 	Poznámka�� $) #Počet kusů se stejnými parametry��$
 Left=����� *CurrectDeliveredClass.Tag+$ PropertyChanged=�.��]� -   $��
SP_Buttons��$��Center=�$��30��$	��350��$��	5,5,5,2.5q�.+��� -   $��	addButton��  styledButton#��[ $	��350��! �� 	IsDefault$
! True������ $ SaveChangesCommand����� *
ButtonText+�� #��[ $��1��$��2��$��0��$��5��$��0,5,5,0q�._�&   System.Windows.Controls.DataGrid  -   "  Name$" logDataGrid��  DataGridColumnHeaderStyle1#   ColumnHeaderStyle## �  $   RowHeaderWidth$$ 20Q�%   GridLinesVisibility$% 
Horizontal=�$��0q�&   CanUserAddRows$& False��'   CanUserReorderColumns$
' True��(   AutoGenerateColumns$( False��)   MinColumnWidth$	) 100Q�$	��Top=�*   
IsReadOnly$
* True��$+   HorizontalScrollBarVisibility$
+ Auto=�",   VerticalScrollBarVisibility$
, Auto=����� *Data+- �� AlternationCount- �� *
Data.Count+.   RowHeaderStyle. �� :  4System.Windows.Controls.Primitives.DataGridRowHeader"  # [ .���  � �� �� $ AlternationIndex�/ �� RelativeSource/ �� 0 �� AncestorType0 DataGridRow1   Columns1 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn2   Header$2 Průměr čela��3   Width5	  /System.Windows.Controls.DataGridLengthConverter$3 *	 1
  +System.Windows.Controls.DataGridBoundColumn4 
  Binding4 �� $ DiameterTop�$  0.# cm��5   
Visibility5 �� 6 �� Source6 %  System.Windows.Markup.Reference  7   Name$7 sp_Diameter_Top��$ 
Visibility�  $2 Průměr uprostřed��$3 *	 4 �� $ DiameterMiddle�$  0.# cm��5 �� 6   $7 sp_Diameter_Middle��$ 
Visibility�  $2 Průměr čepu��$3 *	 4 �� $ DiameterBottom�$  0.# cm��5 �� 6   $7 sp_Diameter_Bottom��$ 
Visibility�  $2 Délka��$3 *	 4 �� $ Length�$  0.# m��  $2 Objem��$3 *	 4 �� $ Volume�$  0.############## m³��  $2 Kůra��$3 *	 4 �� $
 Bark�$  0.# cm��5 �� 6   $7 spcpnl_Bark��$ 
Visibility�  $2 Druh dřeviny��$3 *	 4 �� $ Tree.TypeOfTree�5 �� 6   $7 spckpnl_typeOfTree��$ 
Visibility�  $2 Druh dřeviny��$3 *	 4 �� $ Tree.TypeOfTree�5 �� 6   $7 spckpnl_typeOfTree2��$ 
Visibility�  $2 Jakost��$3 *	 4 �� $ Quality.QualityClass�5 �� 6   $7 stckpnl_Price��$ 
Visibility�  $
2 Cena��$3 *	 4 �� $ Value�$  	##### Kč��5 �� 6   $7 stckpnl_Price��$ 
Visibility�  $2 	Poznámka��$3 *	 4 �� $	 Tag�5 �� 6   $7 
spcpnl_Tag��$ 
Visibility�4  .System.Windows.Controls.DataGridTemplateColumn  8   MaxWidth$8 50Q�9   CellTemplate9 �� .R��� : ��Name$: DG_edit_button��
������ $��0q�$ Upravit výpočet������ / �� "0  $ DataContext.EditCommand����� .���� $��/Icon/edit-2-16.png��  $8 50Q�2 �� -   $: btnDeleteAll��
������ $��0q�$ Smazat veškeré záznamy������ / �� "0  $" DataContext.DeleteAllCommand����� .���� $��/Icon/delete-48.png��9 �� .R��� $: DG_delete_button��
������ $��0q�$ Smazat výpočet������ / �� "0  $ DataContext.DeleteCommand����� .���� $��/Icon/delete-2-16.png���� $��Center=�$��1��$��3��$��6��$��40��$��0,5,5,5q�#��[ ._�]� $��Stretch=����� $ logDataGrid��$ Width�.+��� $ 
Horizontal=�$��Center=�$
��Left=�$
��15,0q�.+��� $��16(�Celkový objem:�� $��16(�$	 5,5q����� *TotalVolume+�� $��16(�$	��m³���� $ 
Horizontal=�$
��15,0q�y��� $ stckpnl_Price��$ 
Visibility�.+��� $��16(�Celková hodnota:�� $��16(�$	 5,5q����� *
TotalPrice+�� $��16(�$	��Kč��