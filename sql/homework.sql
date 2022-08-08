SELECT * FROM tbl_persons
    WHERE gender = 'F';

SELECT * FROM tbl_persons
    WHERE age >= 18;

SELECT * FROM tbl_persons
    WHERE address IS NULL;

UPDATE tbl_persons
SET	age = age + 1;

DELETE FROM tbl_persons
    WHERE address IS NULL;

SELECT COUNT(1)
FROM tbl_persons

SELECT COUNT(1)
FROM tbl_persons
WHERE age IN ( 
		SELECT age
		FROM tbl_persons
		GROUP BY age
        HAVING COUNT(1) > 1
        );

