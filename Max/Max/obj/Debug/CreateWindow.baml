   M S B A M L   `   `   `  ����>  :Max, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MaxMax  5   P       Max.CreateWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   !maxclr-namespace:Max     6P     � Title$  
Заказ��5   	   $	��450��6   $	��800��6$   .��5      �  � ColumnDefinitions 5	   
   �� 5
      $	��300 �6   �� 5      $��1* �6   .+�5   
   �� $	��280��5      $	��280��5      ��5      �� *CurrentService.ImagePreview+�� 5   
   $��5q�6   $��1��6!   .+�5      �� $!��Название авто
��6   �� 5      ��6   �� *CurrentService.Number+�� 5      $��Цена��6   �� 5      ��6   �� *CurrentService.Price+�� 5      $6��0Дата заключения контракта��6   �� 5      ��6   �� *CurrentService.StartTimeText+�� 5      $��Выбор клиента��6   �� 5      $
��left=�5      ��5      �� *
ClientList+ �� SelectedItem 5      �� *CurrentService.AutoserviceMax+��5      �� 5      .R�5       �� ��6    �� *
Fullname+5!      5#      �� 5$      $+��%Выбор cостояния авто��6   �� 5%      $
��left=�5&      ��5'      �� *
RoleList+ 5(      �� *CurrentService.RoleMax+��5)      �� 5*      .R�5+      �� ��6    �� *Title+5,      5.      �� 5/      -   5        $��5q�5/      $
��Left=�6    .��6X   #!Получить картинку6k   �� 50      -   5        $��5q�50      $
��Left=�6    .��6T   Сохранить6_   51      52      53      