CREATE TABLE IF NOT EXISTS tbl_school_schedule(
    period_date DATE NOT NULL,
    period_time TIME WITHOUT TIME ZONE NOT NULL,
    period SMALLINT NOT NULL,
    subject VARCHAR NOT NULL,
    room SMALLINT
);