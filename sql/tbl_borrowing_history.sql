CREATE TABLE IF NOT EXISTS tbl_borrowing_history(
    book_id INT NOT NULL REFERENCES tbl_books(id),
    customer_id INT NOT NULL REFERENCES tbl_customers(id),
    date_of_borrowing DATE NOT NULL,
    date_of_returning DATE
);

-- there is no "is_returned" column, because it duplicate information (if "date_of_returning" is NULL, then "is_returned" - false)
-- also, i am not sure about primary key here