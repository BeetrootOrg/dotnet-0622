SELECT * FROM tbl_persons WHERE gender = 'M';

SELECT * FROM tbl_persons WHERE age >= 18;

SELECT * FROM tbl_persons WHERE address IS NULL OR address = '';

UPDATE tbl_persons
SET age = age+1;

DELETE FROM tbl_persons WHERE address IS NULL OR address ='';

SELECT Count(1) 
FROM tbl_persons;

SELECT age, Count(1) 
FROM tbl_persons 
GROUP BY age;