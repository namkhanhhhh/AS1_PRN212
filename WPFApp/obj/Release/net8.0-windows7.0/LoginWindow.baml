   M S B A M L   `   `   `  ���� 
  WPFApp    WPFApp.LoginWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Login��$	��300��$	��400�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�����  �� 
StartPoint$	 0,0&� �� EndPoint$	 1,1&�.���  � Color$ 	LightBlue�� � Offset$	 0.0Q�� $ LightSkyBlue��$	 1.0Q� � 	Resources  �� 
TargetType	 �� Property
 �� Value �� Triggers P� Property P� Value��%�  '��       �� " ��.��� 	 � ��$
 Segoe UI)��� 	 � ��$
 14(��� 	 � ��$	
 5,2q��� 	 � ��$
 5q��� 	 � ��

 ������� 	 � ��

 ������� 	 � ��$
 1q��� 	 �@�Cursor$

 Hand���� 	 �@^�ToolTip$
 Click to update profile�� P�  �@J�IsMouseOver$
 True��. ��� 	 � ��

 ��ح�P�  � ��$
 True��. ��� 	 � ��

 ��·�.���  � ColumnDefinitions �� $	��49* ��� .+��� 
������� �� CornerRadius$ 10��$��
30,20,1,10q� �� Padding$ 20q�
�������$��1q�._�� $��0,2,-11,-13q� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � �� $
��Auto ��� $��* �.+��� $��Please Log In��$��18(�$
��Bold"�
�������$��0��$��2��$��Center=�$��0,0,0,20q��� $��Email:��$��1��$��0��$��Right=�$��Center=�$��10q��� -    ��Name$ txtEmail��$!��admin@FUMiniHotelSystem.com��$��1��$��1��$��10q�$	��200���� $��	Password:��$��2��$��0��$��Right=�$��Center=�$��10q�G� -    G�Name$ txtPassword�� G� Password$ 
@@abc123@@��$��2��$��1��$��10q�$	��200���� -   $��Login��$��3��$
��Left=�$	��Top=�$	��100��$��6,37,0,0q�
����·�
�������$
��Bold"�$��2��$��26��$��1���� -   $��Cancel��$��4��$
��Left=�$	��Top=�$	��100��$��
132,37,0,0q�
����·�
�������$
��Bold"� J� RenderTransformOrigin$ 0.523,-0.108&�$��1��$��26���� -    ��Name$ ErrorMessage��$��4��$��2��$��Center=�
���  ��$��10q�$y�	Collapsed=�