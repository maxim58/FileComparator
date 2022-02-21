# FileComparator
Выполняется на C# в виде Windows Forms  приложения, .NET Framework версии не ниже 3.5.
Программа анализирует два текстовых файла. Второй файл получен из первого путем добавления/удаления/изменения строк:
●	Может быть удалена любая строка файла. При удалении строки происходит “схлопывание” файла на ее месте.
●	В любое место файла может быть добавлена строка.
●	Измененная строка рассматривается как сочетание удаления строки и добавления в это же место новой строки.
Программа анализирует внесенные изменения и отображает результат на экране.  Выводится содержимое второго файла, включая удаленные строки.  Удаленные строки показываются красным цветом, добавленные - желтым, неизмененные - зеленым.