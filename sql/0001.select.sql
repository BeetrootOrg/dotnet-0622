SELECT title,
	(total - current_taken) AS left
FROM tbl_books AS b
	JOIN (
		SELECT r.book_id,
			COUNT(1) AS current_taken
		FROM tbl_books AS b
			JOIN tbl_rents AS r ON b.id = r.book_id
		WHERE r.returned_at IS NULL
		GROUP BY r.book_id
	) AS r ON b.id = r.book_id;