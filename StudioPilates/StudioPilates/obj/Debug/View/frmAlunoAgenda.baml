   M S B A M L   `   `   `  ����H  DStudioPilates, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:StudioPilates.ViewStudioPilates.View  5   	   '    !StudioPilates.View.frmAlunoAgenda   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:StudioPilates.View     5   	     � Title$  
Aluno Aula��5   	   $��391.491��6   $	��571��6-   .��5	      � $��0,0,2,0q�6    � ColumnDefinitions 5
   
   �� 5      $	��59* �6   �� 5      $	��41* �6   .+�5   
   �� -   5         ��Name$ cmbAula��5      $
��Left=�6$   $��
109,28,0,0q�6?   $	��Top=�6S   $	��154��6k    �� SelectedValuePath$
 Aula��6w    �� DisplayMemberPath$
 Aula��5      $��2��66   �� 5   
   -   5        $ cmbAluno��5      $
��Left=�6%   $��0,28,0,0q�6@   $	��Top=�6R   $	��154��6j   $
 Nome��6v   $
 Nome��5      $��1��67   �� 5   
   -   5         ��Name$ lblAula��5      $
��Aula��6!   $
��Left=�60   $��	49,24,0,0q�6K   $	��Top=�6^   �� 5   
   -   5        $ lblAluno��5      $��Aluno��6"   $
��Left=�62   $��
280,24,0,0q�6M   $	��Top=�6a   $��2��6y   �� 5   
   -   5         ��Name$ 	btnGravar��5      $��Gravar��6$   $
��Left=�65   $��	79,55,0,0q�6P   $	��Top=�6c   $��75��6{   $��1��6�   � 5   
   $��2��6   $��10,90,52,10q�6#    5      �� 5      $
��514* �6#   �� 5      $��7* �6#   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5   3      AutoGenerateColumns .  $	��260��6E   	   
IsReadOnly	 . $��	0,0,-44,0q�6}   $��2��6�   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   ��  �� Path$ AlunoAgendaID�6\     5      $ Agenda��6)   $	 200 6Y    69   �� $ Agenda�6Y     5      $ Aluno��6)   $	 200 6W    68   �� $ Aluno�6W   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ 80 6-      CellTemplate 5       �� 5!      .R�5"   "   �� $ 
btnRemover��6)   -   5        $��Remover��5"   �   ��6V   �� *AlunoAgendaID+6�   5#      5%      5'      5(      5)      5*      