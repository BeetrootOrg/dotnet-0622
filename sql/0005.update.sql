UPDATE tbl_persons
SET address = 'unknown',
	age = age + 1
WHERE address IS NULL;