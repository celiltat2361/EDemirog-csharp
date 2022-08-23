--Select
Select ContactName, CompanyName, City from Customers

Select * from Customers where City = 'London'

select * from products where CategoryID=1 or CategoryID=3 
select * from Products where CategoryID=3 and UnitPrice >= 12 and UnitsInStock > 1 order by ProductID, ProductName
select count (*) from Products where CategoryID=2

select * from Products where CategoryID=2 order by UnitPrice desc --azalarak sirala

--products icerisinde bulunan categorylerin gruplanmis tablosu. 
select CategoryID from products group by CategoryID

--hangi kategoride kac farkli urunumuz var
select CategoryID,count(*) from products group by CategoryID --group by oldugu icin her kategori icin ayri ayri count olur


--10 urunden az olan categorileri ve mevcut urun sayilarini göster unitprice i 20 den buyuk olanlar
select CategoryID,count(*) from products where UnitPrice>20 group by CategoryID having count(*)<12

--join metodu// urunlerden fiyati 10dan buyuk olan ve buyukten kucuge siralanan urunleri kategori ismiyle birlikte getir
--inner join sadece iki tabloda eslesenleri biraraya getirir
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10
order by UnitPrice desc

--left join => solda olan sagda olmayanlarida ekler sorguya
SELECT * FROM Customers C LEFT JOIN Orders O
ON C.CustomerID = O.CustomerID
WHERE O.CustomerID IS NULL


