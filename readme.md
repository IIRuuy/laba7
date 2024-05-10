**Тема:** лабораторной работы: Реализация метода рекурсивного спуска для синтаксического анализа.

Цель работы: Разработать для грамматики алгоритм синтаксического анализа на основе метода рекурсивного спуска.

Задание: В соответствии с вариантом для заданной грамматики необходимо разработать и реализовать алгоритм анализа на основе метода рекурсивного спуска.

## Грамматика:
```
G[<Выражение>]:
     1. <Выражение> = <Слагаемое> { (+|-) <Слагаемое> }
     2. <Слагаемое> = <Множитель> { (*|/) <Множитель> }
     3. <Множитель> = [+|-] <ДробноеЧисло> | <Функция>
     |(<Выражение>)
     4. <ДробноеЧисло> = <ЦелаяЧасть> | <ЦелаяЧасть>
     .<ДробнаяЧасть>
     5. <ЦелаяЧасть> = <Цифра>{<Цифра>}
     6. <ДробнаяЧасть> = <Цифра>{<Цифра>}
     7. <Функция> = <ИмяФункции>(<Выражение>)
<ИмяФункции> = “sin” | “cos” | “tg” | “ctg” | “log” | “ln”
<Цифра> = 0|1|2|3|4|5|6|7|8|9
```

## Тест 1
![изображение](/docs/access.png)

## Тест 2
![изображение](/docs/wrong.png)
