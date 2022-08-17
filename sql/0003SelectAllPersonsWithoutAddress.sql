--select all persons without address
SELECT * 
    FROM tbl_persons 
    WHERE address IS NULL OR LENGTH(address) < 1
    ;