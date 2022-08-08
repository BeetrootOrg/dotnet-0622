SELECT first_name,
	last_name,
	age
FROM tbl_persons
WHERE LOWER(first_name) = 'dima'
ORDER BY age;