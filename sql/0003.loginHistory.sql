CREATE TABLE IF NOT EXISTS tbl_login_histories (
   id SERIAL PRIMARY KEY,
   user_name VARCHAR(255) NOT NULL,
   user_ip VARCHAR(15),
   date_time_of_login TIMESTAMP WITH TIME ZONE NOT NULL,
   login_country VARCHAR(255),
   login_city VARCHAR(255)
);