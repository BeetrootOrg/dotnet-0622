/*

    select all males
    select all persons with age about 18
    select all persons without address
    update age of all persons, add 1 year
    delete all rows without address
    count number of rows in table
    group persons by age and show how many persons with same age

*/

SELECT *
FROM tbl_persons
WHERE gender = 'M';

SELECT *
FROM tbl_persons
WHERE age = 18; 

SELECT *
FROM tbl_persons
WHERE address IS null;

UPDATE tbl_persons
SET age = age + 1;

DELETE FROM tbl_persons
WHERE address IS null;


SELECT COUNT(1)
FROM tbl_persons;


SELECT COUNT(1)
FROM tbl_persons
WHERE age IN (
		SELECT age
		FROM tbl_persons
		GROUP BY age
		HAVING COUNT(1) > 1
	);

