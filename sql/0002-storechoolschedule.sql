CREATE TABLE IF NOT EXISTS tbl_storechoolschedule (
    ID SERIAL PRIMARY KEY,
    lesson_day DATE NOT NULL CHECK(lessonday > NOW() - INTERVAL '1 months'),
    class_name VARCHAR(4) NOT NULL CHECK(LENGTH(class_name) > 1),
    lesson_name VARCHAR(40) NOT NULL,
    number_lesson SMALLSERIAL NOT NULL CHECK(number_lesson < 11),
    full_name_teacher VARCHAR(1000) NOT NULL,
    full_name_assistant VARCHAR(1000) NOT NULL
    );