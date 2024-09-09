# Решение тестового задания на стажировку для Mindbox
## **Вопрос №1:**

_Был ли у вас опыт веб-разработки? Приложите ссылку на репозиторий с вашим веб-проектом, если возможно._

------------------------

Да, в рамках курса по веб-программированию мною был спроектирован и реализован сайт разработчиков игр с использованием HTML/CSS/PHP/JS

ссылка на данный проект: https://github.com/sashaem1/site

## **Вопрос №2:**

_Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам._

------------------------
Ссылка на саму библиотеку https://github.com/sashaem1/TestForMindbox/blob/main/CulcLib/Shapes.cs

Ссылка на модульные тесты https://github.com/sashaem1/TestForMindbox/blob/main/TestProjectMindbox/UnitTest1.cs

## **Вопрос №3:**

_В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться._

------------------------
### Создание БД
```
CREATE TABLE Products(
id INT PRIMARY KEY IDENTITY, 
name VARCHAR(255) NOT NULL);

CREATE TABLE Category(
id INT PRIMARY KEY IDENTITY,
name VARCHAR(255) NOT NULL);

CREATE TABLE ProdCat(
products_id INT NOT NULL,
category_id INT NOT NULL,
FOREIGN KEY(products_id) REFERENCES Products(id) ON DELETE CASCADE,
FOREIGN KEY(category_id) REFERENCES Category(id) ON DELETE CASCADE);

CREATE UNIQUE INDEX prod_cat ON ProdCat(products_id, category_id);
```
### Заполнение БД данными
```
INSERT INTO Products VALUES('Минеральная вода'), ('Энергетик'), ('Батон'), ('Колбаса');
INSERT INTO Category VALUES('Напитки'), ('Пища');
INSERT INTO ProdCat VALUES(1, 1), (2, 1), (3, 2), (4,2);
```

### Решение задачи
```
SELECT p.name AS product, c.name AS category FROM Products AS p
LEFT JOIN ProdCat AS pc ON p.id = pc.products_id
INNER JOIN Category AS c ON c.id = pc.category_id
ORDER BY product;
```



------------------------

Да, я готов выйти на полный день как после прохождения стажировки, так и во время неё. Также я рассматриваю любой из возможных вариантов работы (удаленно/офис/гибрид)
