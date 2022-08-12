-- group persons by age and show how many persons with same age
SELECT age, COUNT(*)
FROM tbl_persons
GROUP BY age;