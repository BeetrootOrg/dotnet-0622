CREATE TABLE IF NOT EXISTS tbl_authors(
    id SERIAL PRIMARY KEY, 
	first_name VARCHAR(150) NOT NULL,
	last_name VARCHAR(150) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_books(
    id SERIAL PRIMARY KEY, 
	name VARCHAR(150) NOT NULL,
    author_id INT NOT NULL REFERENCES tbl_authors(id),
    genre varchar(150) NOT NULL,
    year_of_publication INT NOT NULL,
    count INT NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_customers(
    id SERIAL PRIMARY KEY,
    first_name VARCHAR(150) NOT NULL,
    last_name VARCHAR(150) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_borrowing_history(
    book_id INT NOT NULL REFERENCES tbl_books(id),
    customer_id INT NOT NULL REFERENCES tbl_customers(id),
    date_of_borrowing DATE NOT NULL,
    date_of_returning DATE
);