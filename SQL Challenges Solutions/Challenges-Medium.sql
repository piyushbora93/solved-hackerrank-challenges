DECLARE @maxCount INT


SET @maxCount = (SELECT MAX(cnt) FROM (SELECT Count(Hacker_Id) AS cnt FROM Challenges GROUP BY Hacker_Id) temp1)

SELECT H.Hacker_Id, H.Name, Count(C.Challenge_Id) FROM Hackers H
JOIN Challenges C ON H.Hacker_Id = C.Hacker_Id
GROUP BY H.Hacker_Id, H.Name
HAVING Count(C.Challenge_Id) = @maxCount OR Count(C.Challenge_Id) IN (select t.cnt
         from (select count(*) as cnt 
               from challenges
               group by hacker_id) t
         group by t.cnt
         having count(t.cnt) = 1)
ORDER BY Count(C.Challenge_Id) DESC, H.Hacker_Id
