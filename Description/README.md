## Решение:
1. Создаем 2 массива одинаковой длины
2. В 1-й массив забиваем значения и количество элементов
3. Создаем числовую переменную int count
4. Создаем цикл for, в котором будем рассматривать каждый элемент i, и условие if, в котором в случае, если элемент 1-го массива <=3, он будет перемещен в переменную count 2-го массива. В данном случае переменная count увеличивается на 1, а затем возвращается к циклу for, где мы переходим к следующему элементу (i+1) и проверяем его до тех пор пока не кончатся все элементы (в данном случае их 7)
5. Выводим результат на экран