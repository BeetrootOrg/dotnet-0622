SELECT *
    FROM tbl_persons
    WHERE age IN (SELECT age
    FROM tbl_persons
    GROUP BY age
    HAVING COUNT(1) > 1);