--group persons by age and show how many persons with same age
SELECT age, COUNT(1)
FROM tbl_persons
GROUP BY age
HAVING COUNT(1) > 1;

--group persons by age and show how many persons with same age (in total)
SELECT COUNT(1)
FROM tbl_persons
WHERE age IN 
(
	SELECT age
	FROM tbl_persons
	GROUP BY age
	HAVING COUNT(1) > 1
);