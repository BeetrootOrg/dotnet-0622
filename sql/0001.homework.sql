SELECT *
	FROM tbl_persons
	WHERE gender = 'M';
	
SELECT *
	FROM tbl_persons
	WHERE age >= 18;
	
SELECT *
	FROM tbl_persons
	WHERE address IS NULL OR address = '';

SELECT *
	FROM tbl_persons
	WHERE address IS NULL;
	
UPDATE tbl_persons
	SET age = age + 1;
	
DELETE FROM tbl_persons
	WHERE address IS NULL;
	
SELECT COUNT(1)
	FROM tbl_persons;
	
SELECT age, COUNT(1)
	FROM tbl_persons
	GROUP BY age;