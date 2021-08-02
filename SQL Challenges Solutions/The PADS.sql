SELECT CONCAT(Name,'(', Substring(Occupation,1,1), ')') FROM OCCUPATIONS ORDER BY Name

SELECT CONCAT('There are a total of ', Count(*),' ', lower(Occupation), 's.') FROM OCCUPATIONS GROUP BY Occupation order by Count(*) ASC, Occupation ASC
