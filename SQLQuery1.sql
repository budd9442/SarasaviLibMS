create table books(
	id int PRIMARY KEY identity(1,1),
	classification char NULL,
	number int NULL,
	author VARCHAR(30) NULL,
	title VARCHAR(30) NULL,
	borrowable BIT NULL,
	status VARCHAR(20) NULL
)

