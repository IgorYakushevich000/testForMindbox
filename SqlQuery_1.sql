--создадим таблицы Товаров и Категорий и заполним их тестовыми данными:

CREATE TABLE Goods( 
  id INT PRIMARY KEY, 
  title VARCHAR(255), 
  amount NUMERIC(10,2), 
  description TEXT 
); 
 
CREATE TABLE Category( 
  id INT PRIMARY KEY, 
  title VARCHAR(255), 
  description TEXT 
); 
-- свзяь многие ко многим реализуется в sql через промежуточную таблицу и нешние ключи, сохдадим их
CREATE TABLE Goods_Category ( 
  id INT PRIMARY KEY, 
  id_good INT, 
  id_category INT, 
  FOREIGN KEY (id_good) REFERENCES Goods(id), 
  FOREIGN KEY (id_category) REFERENCES Category(id) 
) ;
-- тестовые данные
INSERT INTO Goods (id, title, amount, description) VALUES 
(1, 'Ноутбук', 50000.00, 'Мощный ноутбук для работы и игр'), 
(2, 'Смартфон', 25000.00, 'Современный смартфон с большим экраном'), 
(3, ' Стол', 30000.00, 'Стол кухонный'); 
 
INSERT INTO Category (id, title, description) VALUES 
(1, 'Электроника', 'Техника для дома и офиса'), 
(2, 'Бытовая техника', 'Крупная и мелкая бытовая техника'); 
 -- тестовые отношения
INSERT INTO Goods_Category (id, id_good , id_category ) VALUES 
(1, 1, 1), 
(2, 1, 2), 
(3, 2, 1);
 

 -- после этого выполним запрос на выборку товаров и категорий

SELECT Goods.title, Category.title 
FROM Goods 
LEFT JOIN Goods_Category ON Goods.id = Goods_Category .id_good 
LEFT JOIN Category ON Goods_Category .id_category = Category.id 
