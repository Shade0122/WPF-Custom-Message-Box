   M S B A M L   `   `   `  ����   WPFCustomMessageBox$    WPFCustomMessageBox.MessageBox   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  	Messageox��$	��160��$	��420��$	��750��$	��750��
������  � SizeToContent$ WidthAndHeight=� � WindowStartupLocation$ CenterScreen=� � ShowInTaskbar .   � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � Topmost . .���� 
�����w�$��0q� �� CornerRadius$ 0��._��  � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto �	 � ColumnDefinitions	 �� $
��Auto ��� $��* �.+��� $��1��$��0��$��2��$��2�����	#FF474747�� $��0��$��0��$��2������ 
 �� 
StartPoint$	
 0,0&� �� EndPoint$	 0,1&� �� Opacity$	 0.5Q�.���  � Color$ #26508A�� � Offset$	 0.0Q�� $ #2A739E��$	 1.0Q�� $��0��$��2��$��40��
�������.+��� -   $��MessageTitle��$��Title��$
��Bold"�$��CharacterEllipsis=� �� 
LineHeight$ 22��$��20(�$��Center=�
�������$��40���� -   $��txtMsg��$
��Text��$��Center=�$
��Wrap=�$��1��$��1��$��25(�$ 20��$��75��
�������&   System.Windows.Media.TextOptions   TextHintingMode$ Animated=� �� TextAlignment$ Center=���Z� � $��2��$��2��$��0��.+���  �� Orientation$ 
Horizontal=�$��Right=�.+��� -   $��ButtonOk��$��Ok��$	��3,5q�$��70��$��35��
���   �$��14(�
�������$��Center=�$��Stretch=�$��Center=�$��Center=���Z� �� -   $��	ButtonYes��$	��Yes��$	��3,5q�$��70��$��35��
���   �$��14(�
�������$��Center=�$��Stretch=�$��Center=�$��Center=���Z� �� -   $��ButtonNo��$��No��$	��3,5q�$��70��$��35��
���   �$��14(�
�������$��Center=�$��Stretch=�$��Center=�$��Center=���Z� �� -   $��ButtonCancel��$	��3,5q�$��Cancel��$��70��$��35��
���   �
�������$��14(�$��Center=�$��Stretch=�$��Center=�$��Center=���Z� 