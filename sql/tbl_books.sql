CREATE TABLE IF NOT EXISTS tbl_books(
    id SERIAL PRIMARY KEY, 
	name VARCHAR(50) NOT NULL,
    author INT NOT NULL REFERENCES tbl_authors(id),
    genre varchar(50) NOT NULL,
    year_of_publication VARCHAR(4) NOT NULL,
    count INT NOT NULL
);