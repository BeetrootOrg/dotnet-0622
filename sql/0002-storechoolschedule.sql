CREATE TABLE IF NOT EXISTS tbl_storechoolschedule (
    id SERIAL PRIMARY KEY,
    lessonday DATE NOT NULL CHECK(lessonday > NOW() - INTERVAL '1 months'),
    classname VARCHAR(4) NOT NULL CHECK(LENGTH(classname)>1),
    lessonname VARCHAR(40) NOT NULL,
    numberlesson SMALLSERIAL NOT NULL CHECK(numberlesson < 11)
    );