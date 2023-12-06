create table members(
	number int primary key identity(1,1),
	name varchar(255),
	gender char(1),
	nic varchar(12),
	address varchar(255)
)