   M S B A M L   `   `   `  ����   Max    Max.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  AutoService��$	��450��$	��800��.���  � ColumnDefinitions �� $	��150 ��� $��1* �.+��� $��5q�$��./logo/auto.png��$	��Top=���  �� Orientation$ Vertical=�$��Bottom=�.+��� -   $��	AddButton��$��5q�$��Добавление���� -    ��Name$ 
EditOrdBtn��$��5q�$%��Изменение Заказа���� -   $ 	DelOrdBtn��$��5q�$#��Удаление Заказа���� -   $��
ExitButton��$��5q�$��
Выход��� $��1�� � RowDefinitions �� $��30 ��� $��1* ��� $��30 �.+��� $ 
Horizontal=�$��Center=�.+��� $��
Цена: ��	� -    	� 	GroupName$ Price��
 � Tag$ 1��$!��по возрастанию�� d� 	IsChecked$
 TrueY�$��Center=�	� -   $ Price��$ 2��$��по убыванию��$��Center=��� $&�� Фильтр по скидке: ��$��10,0,0,0q�$��Center=��� -   $��DiscountFilterComboBox�� �� SelectedIndex$ 0������ *FilterByDiscountNamesList+�� $��
Поиск���� -   	 ��Name$	 SearchFilterTextBox��$��70��$��Center=��� -	   
 ��Name$
 ProductListView��$��1������ *ServiceList+����  �� 
TargetType" �� �� Triggers ��  �� Binding �� *
MaxBalance+ �� Value True.a���  �� Property � �� �� Value �	#FF08F9F9.���  � ��$ Stretch=����� .R��� $��1q�
���   � �� CornerRadius$ 5��._�� $��10q�$��Stretch=� �� $��64 ��� $��* ��� $	��100 �.+��� $��64��$��64������  �� Path$ ImagePreview��� $��2��$��Right=�$��10q����� *BalanceString+� $��1��$��5q� �� $��20 ��� $��20 ��� $��* �.+��� $ 
Horizontal=�.+��� ���� *Number+�� $	�� | ���� ���� *CompanyMax.Service+�� $��1������ *Count+�� $��2������ *StartTimeText+�� $ 
Horizontal=�$��Bottom=�$��1��$��2��.+��� ���� *FilteredProductCount+�� $��/���� ���� *ProductCount+