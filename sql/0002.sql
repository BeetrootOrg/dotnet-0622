--select all persons without address
SELECT * 
FROM tbl_persons
WHERE address IS NULL;