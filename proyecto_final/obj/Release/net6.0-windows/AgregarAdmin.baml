   M S B A M L   `   `   `  ���� I  Eproyecto_final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:proyecto_finalproyecto_final  !    proyecto_final.AgregarAdmin   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:proyecto_final       � Title$  AgregarAdmin��$	��600��$
��1000�� � 	Resources    FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonConfirm �� 
TargetType �� 
TargetType	 ��Name
 �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName  FocusVisual1  Button.Static.Background1  Button.Static.Border1   Button.MouseOver.Background1  Button.MouseOver.Border1  Button.Pressed.Background1  Button.Pressed.Border1  Button.Disabled.Background1  Button.Disabled.Border1  Button.Disabled.Foreground1  
ButtonBack��%D	  &	        &	 R     &	 g     &	 |     &	 �     &	 �     &	 �     &	 �     &	 �     &		 �     &	
     7   7  7  7  7  7  7  7  7  7 	 &	     &	 ^    &	 s    &	 �    &	 �    &	 �    &	 �    &	 �    &	 �    &	     &	     7  7  7  7  7  7  7  7  7  7  �� .���  � �� �� .R��� $��2q�$	 1 2R�#��� ��$
 true��$��1���� $ 	#FFDDDDDD���� $ 	#FF707070���� $ 	#FFBEE6FD���� $ 	#FF3C7FB1���� $ 	#FFC4E5F6���� $ 	#FF2C628B���� $ 	#FFF4F4F4���� $ 	#FFADB2B5���� $ 	#FF838383���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $	 border��$
 7��#��z��#��z��#��z��$
 true��._��� $ contentPresenter��$|�False��#��z��#��z��$
��True��# z #��z�� P�  �@��IsDefaulted$
 true��. ��� $ border��# � �� � ��P�  �@J�IsMouseOver$
 true��. ��� $ border��8   � ���� $ border��8   � ��P�  � ��$
 true��. ��� $ border��8   � ���� $ border��8   � ��P�  � {�$ false��. ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8 	  � ���� .���  � �� �� .R��� $��2q�$	 1 2R�#��� ��$
 true��$��1���� $ 	#FFDDDDDD���� $ 	#FF707070���� $ 	#FFBEE6FD���� $ 	#FF3C7FB1���� $ 	#FFC4E5F6���� $ 	#FF2C628B���� $ 	#FFF4F4F4���� $ 	#FFADB2B5���� $ 	#FF838383���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $	 border��$
 7��#��z��#��z��#��z��$
 true��._��� $ contentPresenter��$|�False��#��z��#��z��$
��True��# z #��z�� P�  �@��IsDefaulted$
 true��. ��� $ border��# � �� � ��P�  �@J�IsMouseOver$
 true��. ��� $ border��8   � ���� $ border��8   � ��P�  � ��$
 true��. ��� $ border��8   � ���� $ border��8   � ��P�  � {�$ false��. ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8 	  � ��.��(� .��� 
������� � RowDefinitions �� $
��251* ��� $
��183* �.+��� -    ��Name$ 
bloqueUser��$��Center=�$��	0,218,0,0q�$
��Wrap=�$��Ingrese usuario��$	��Top=� K� ZIndex$ 1��
���   �$��Cascadia Code SemiBold)�$��22(��� -    ��Name$ Usuario��$��Center=�$��	0,276,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��288��$ 1��$��33��$��20(��� -   $ bloqueContraseña��$��Center=�$��	0,331,0,0q�$
��Wrap=�$��Ingrese contraseña��$	��Top=�$ 1��
���   �$��Cascadia Code SemiBold)�$��22(��� $��Center=�$��	0,442,0,0q�$
��Wrap=�$��Confirme contraseña��$	��Top=�$ 1��
���   �$��Cascadia Code SemiBold)�$��22(��� -   $ email��$��Center=�$��0,98,0,0q�$
 Wrap=�$	��Top=�$	��288��$ 1��$��1��$��33��$��20(��� $��Center=�$��0,49,0,0q�$
��Wrap=�$��Ingrese Email��$	��Top=�$ 1��
���   �$��Cascadia Code SemiBold)�$��22(�$��1���� $��Center=�$��0,58,0,0q�$
��Wrap=�$!��Agregar nuevo administrador��$	��Top=�$��48(�$ 1��
���   �$��Cascadia Code SemiBold)�$	��119��$	��380���� -    ��Name$ 	confirmar��#��� 
 $��	Confirmar��$��Center=�$��	0,189,0,0q�$	��Top=�$ 1�����	#FF5FB2A8$��Cascadia Code SemiBold)�$��20(�$��42��$	��174��$��1��
��������� -   $ salir��#���  $��Volver��$
��Left=�$��1252,226,0,0q�$	��Top=�$	��160��$��Cascadia Code SemiBold)�$��20(����	#FF5FB2A8$��1��
�������$��42���� $��/CUDI-principal-1.png��$
��Fill=�$��10,10,1328,334q�G� -    G�Name$ passBox��$��Center=�$��	0,381,0,0q�$	��Top=�$	��288��$��33��$��20(�G� -   $ passBox2��$��Center=�$��	0,493,0,0q�$	��Top=�$	��288��$��33��$��2��$��20(�