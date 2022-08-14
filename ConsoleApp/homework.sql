SELECT * FROM tbl_persons

INSERT INTO public.tbl_persons (first_name, last_name, age, gender, address)
VALUES ('D', 'H', '25', 'F', NULL)
    ('Oles', 'Borys', '27', 'M', 'Kyiv'),
    ('O', 'B', '15', 'M', 'K'),
    ('B', 'O', '25', 'M', 'L'),
    ('Hello', 'World', '42', 'M', 'NA'),
    ('CI', 'CD', '21', 'M', 'AN')

UPDATE tbl_persons
SET address = NULL 
WHERE address = ''
    
SELECT * FROM tbl_persons
WHERE gender = 'M'

SELECT * FROM tbl_persons
WHERE age > 18

SELECT * FROM tbl_persons
WHERE address IS NULL

UPDATE tbl_persons
SET age = age + 1

DELETE FROM tbl_persons 
WHERE address IS NULL

SELECT COUNT(*)
FROM tbl_persons

SELECT age, COUNT(*)
FROM tbl_persons
GROUP BY age