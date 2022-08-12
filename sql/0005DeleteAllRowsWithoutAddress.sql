--delete all rows without address
DELETE FROM tbl_persons WHERE address IS NULL OR LENGTH(address) < 1