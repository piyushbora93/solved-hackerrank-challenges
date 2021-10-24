select * from Functions F
WHERE F.X = F.Y
GROUP BY F.X,F.Y
HAVING COUNT(*) > 1
UNION
SELECT F1.X, F1.Y FROM Functions F1, Functions F2
WHERE F1.X <> F1.Y AND F1.X < F1.Y AND F1.X = F2.Y AND F1.Y = F2.X
