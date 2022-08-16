// CREATE TABLE IF NOT EXISTS tbl_loans (
// 	loan_date DATETIME NOT NULL,
// 	loans_is_active BOOLEAN NOT NULL,
// 	custumer_id INT NOT NULL REFERENCES tbl_customers(customer_id),
// 	book_id INT NOT NULL REFERENCES tbl_books(book_id),
// 	librarian_id INT NOT NULL REFERENCES tbl_librarians(librarian_id)
// );