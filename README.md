# Контрольная работа

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием рещения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что все залито одним коммитом, как минимум
этапы 2, 3 и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. Прии решении не рекомендуется пользоваться коллекциями, лучше обойтись 
исключительно массивами.

# Описание решения

1. Задаем первоначальный массив строк на старте алгоритма.
2. Создаем результирующий массив строк, вызывая метод ArrayOfLessThree(будет описан далее).
3. Выводим на экран символ "[".
4. Выводим на экран результирующий массив, используя метод String.Join.
5. Выводим на экран символ "]".

## Метод  ArrayOfLessThree

1. Принимаем на вход первоначальный массив строк.
2. Задаем пустой временный массив строк размер которого равен размеру первоначального массива.
3. Задаем переменную number = 0 - счетчик элементов массива длиной меньше или равных 3 символа.
4. Задаем счетчик цикла i = 0, условие выхода из цикла - i < длины первоначального массива,  задаем увеличение i на единицу (i++).
5. Берем i-й элемент первоначального массива.
6. Если i-й элемент первоначального массива удовлетворяет условию "длина строки <= 3"

    6.1 тогда записываем i-й элемент первоначального массива в временный массив с индексом number.

    6.2 увеличиваем счетчик number на 1.

    6.3 переходим к следующей итерации.

7. Если i-й элемент первоначального массива не удовлетворяет условию "длина строки <= 3"

    7.1 сразу переходим к следующей итерации.
8. Повторяем действия 5-7 пока верно условие, заданное в п. 4

9. Задаем пустой результирующий массив строк размер которого равен number (посчитанному в цикле 4-8).

10.  Задаем счетчик цикла i = 0, условие выхода из цикла - i < number, задаем увеличение i на единицу (i++).

11. Записываем i-й элемент временного массива в результирующий на i-ю позицию.

12. Повторяем действие п. 11 пока верно условие в п. 10.

13. Возвращаем заполненный результирующий массив
