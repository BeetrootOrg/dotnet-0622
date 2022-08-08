SELECT gender 
FROM tbl_persons 
WHERE gender = 'M';

SELECT first_name,
	last_name,
	age
FROM tbl_persons
WHERE age > 18; 

SELECT first_name,
	last_name,
	address
FROM tbl_persons
WHERE address IS NULL OR address = '';

UPDATE tbl_persons
SET age = age + 1; 

DELETE FROM tbl_persons
WHERE address = '' OR address IS NULL;

SELECT COUNT(*)
FROM tbl_persons

SELECT age,
	COUNT(1)
FROM tbl_persons
GROUP BY age;