-- select all males
SELECT * FROM tbl_persons
    WHERE gender = 'M'
    
--select all persons with age about 18    
SELECT * FROM tbl_persons
    WHERE age > 18

--select all persons without address
SELECT * FROM tbl_persons
    WHERE address IS null OR address = ''
    
--update age of all persons, add 1 year
UPDATE tbl_persons
    SET age = age + 1

--delete all rows without address
DELETE FROM tbl_persons
    WHERE address IS null OR address = ''
    
--count number of rows in table    
SELECT COUNT(*) FROM tbl_persons

--group persons by age and show how many persons with same age
SELECT age, COUNT(*) FROM tbl_persons 
    GROUP BY age
