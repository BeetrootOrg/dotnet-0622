SELECT age,
    COUNT(*)
FROM tbl_persons
GROUP BY age
ORDER BY age ASC;