-- C# operator && == SQL operator AND
-- C# operator || == SQL operator OR
-- C# operator == == SQL operator =
SELECT first_name,
	last_name,
	age
FROM tbl_persons
WHERE LOWER(first_name) = 'dima'
	AND age > 24
ORDER BY age;

SELECT *
FROM tbl_persons
WHERE address IS NULL;
SELECT *
FROM tbl_persons
WHERE address IS NULL;

SELECT first_name,
	COUNT(1),
	AVG(age),
	MIN(age) AS min_age,
	MAX(age) AS max_age
FROM tbl_persons
GROUP BY first_name
HAVING COUNT(1) > 1;

SELECT *
FROM tbl_persons
WHERE first_name IN (
		SELECT first_name
		FROM tbl_persons
		GROUP BY first_name
		HAVING COUNT(1) > 1
	);