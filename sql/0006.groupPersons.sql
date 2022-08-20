SELECT age, COUNT(1)
    FROM tbl_persons
    GROUP BY age
    HAVING COUNT(1) > 1;