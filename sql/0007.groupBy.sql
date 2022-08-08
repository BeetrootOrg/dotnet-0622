SELECT age,
    COUNT(*) AS same_age
FROM tbl_persons
GROUP BY age