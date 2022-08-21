CREATE TABLE IF NOT EXISTS tbl_reader_story_card(
    ID SERIAL PRIMARY KEY,
    id_account VARCHAR(25) NOT NULL REFERENCES tbl_customers(id_account),
    book INTEGER NOT NULL REFERENCES tbl_books(id),
    datetake DATE NOT NULL,
    returned_book BOOLEAN NOT NULL DEFAULT FALSE,
    date_return DATE
    );