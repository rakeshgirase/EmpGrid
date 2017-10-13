Drop table EmployeeHours;

Drop table Employee;

CREATE TABLE Employee (
	EmpId INT,
	EmpLastName VARCHAR(20),
	EmpFirstName VARCHAR(20),
	Hiredate DATE
	CONSTRAINT PK_EMPID PRIMARY KEY (EMPID)
);



CREATE TABLE EmployeeHours (
	EmpId INT,
	WorkDate Date  ,
	Description VARCHAR(50) ,
	HoursWorked INT ,
	CONSTRAINT FK_EMPID FOREIGN KEY(EMPID)
    REFERENCES Employee(EMPID),
	--CONSTRAINT CHK_Description CHECK (Description in ('Shift-A','Shift-B','Shift-C', 'Shift-D')),
	CONSTRAINT CHK_HoursWorked CHECK (HoursWorked Between 1 and 600),
	CONSTRAINT UC_EMP_WORK_DATE UNIQUE (EmpId, WorkDate)
);


select * from Employee;
SET DATEFORMAT MDY;

-- Employee
insert into Employee (EMPID, EmpLastName, EmpFirstName, HireDate) values (7001, 'Burgess','Mark', '10/1/2016');
insert into Employee (EMPID, EmpLastName, EmpFirstName, HireDate) values (7002, 'Collinge','Richard', '5/21/2007');
insert into Employee (EMPID, EmpLastName, EmpFirstName, HireDate) values (7003, 'Congdon','Bevan', '1/16/2011');
insert into Employee (EMPID, EmpLastName, EmpFirstName, HireDate) values (7004, 'Coman','Peter', '5/31/2013');
insert into Employee (EMPID, EmpLastName, EmpFirstName, HireDate) values (7005, 'Hastings','Brian', '12/21/2010');

-- EmployeeHours
select * from EmployeeHours;
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7001,GETDATE()+1, 'Shift-A;', 240);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7001,GETDATE()+2, 'Shift-B;', 125);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7001,GETDATE()+3, 'Shift-A', 50);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7001,GETDATE()+4, 'Shift-C;Shift-A;', 15);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7001,GETDATE()+5, 'Shift-C;Shift-D;', 136);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7001,GETDATE()+6, 'Shift-A;', 240);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7001,GETDATE()+7, 'Shift-B;', 125);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7001,GETDATE()+8, 'Shift-A', 50);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7001,GETDATE()+9, 'Shift-C;Shift-A;', 15);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7001,GETDATE()+10, 'Shift-C;Shift-D;', 136);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7001,GETDATE()+11, 'Shift-A;', 240);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7001,GETDATE()+12, 'Shift-B;', 125);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7001,GETDATE()+13, 'Shift-A', 50);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7001,GETDATE()+14, 'Shift-C;Shift-A;', 15);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7001,GETDATE()+15, 'Shift-C;Shift-D;', 136);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7001,GETDATE()+16, 'Shift-A;', 240);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7001,GETDATE()+17, 'Shift-B;', 125);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7001,GETDATE()+18, 'Shift-A', 50);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7001,GETDATE()+19, 'Shift-C;Shift-A;', 15);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7001,GETDATE()+20, 'Shift-C;Shift-D;', 136);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7002,GETDATE()+1, 'Shift-A;', 245);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7002,GETDATE()+2, 'Shift-B;', 90);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7002,GETDATE()+3, 'Shift-A', 150);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7002,GETDATE()+4, 'Shift-C;Shift-A;', 198);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7002,GETDATE()+5, 'Shift-C;Shift-D;', 100);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7002,GETDATE()+6, 'Shift-A;', 245);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7002,GETDATE()+7, 'Shift-B;', 90);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7002,GETDATE()+8, 'Shift-A', 150);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7002,GETDATE()+9, 'Shift-C;Shift-A;', 198);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7002,GETDATE()+10, 'Shift-C;Shift-D;', 100);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7002,GETDATE()+11, 'Shift-A;', 245);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7002,GETDATE()+12, 'Shift-B;', 90);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7002,GETDATE()+13, 'Shift-A', 150);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7002,GETDATE()+14, 'Shift-C;Shift-A;', 198);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7002,GETDATE()+15, 'Shift-C;Shift-D;', 100);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7002,GETDATE()+16, 'Shift-A;', 245);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7002,GETDATE()+17, 'Shift-B;', 90);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7002,GETDATE()+18, 'Shift-A', 150);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7002,GETDATE()+19, 'Shift-C;Shift-A;', 198);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7002,GETDATE()+20, 'Shift-C;Shift-D;', 100);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7003,GETDATE()+1, 'Shift-A;', 55);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7003,GETDATE()+2, 'Shift-B;', 80);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7003,GETDATE()+3, 'Shift-A', 10);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7003,GETDATE()+4, 'Shift-C;Shift-A;', 138);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7003,GETDATE()+5, 'Shift-C;Shift-D;', 30);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7003,GETDATE()+6, 'Shift-A;', 55);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7003,GETDATE()+7, 'Shift-B;', 80);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7003,GETDATE()+8, 'Shift-A', 10);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7003,GETDATE()+9, 'Shift-C;Shift-A;', 138);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7003,GETDATE()+10, 'Shift-C;Shift-D;', 30);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7003,GETDATE()+11, 'Shift-A;', 55);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7003,GETDATE()+12, 'Shift-B;', 80);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7003,GETDATE()+13, 'Shift-A', 10);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7003,GETDATE()+14, 'Shift-C;Shift-A;', 138);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7003,GETDATE()+15, 'Shift-C;Shift-D;', 30);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7003,GETDATE()+16, 'Shift-A;', 55);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7003,GETDATE()+17, 'Shift-B;', 80);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7003,GETDATE()+18, 'Shift-A', 10);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7003,GETDATE()+19, 'Shift-C;Shift-A;', 138);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7003,GETDATE()+20, 'Shift-C;Shift-D;', 30);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7004,GETDATE()+1, 'Shift-A;', 78);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7004,GETDATE()+2, 'Shift-B;', 36);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7004,GETDATE()+3, 'Shift-A', 165);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7004,GETDATE()+4, 'Shift-C;Shift-A;', 115);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7004,GETDATE()+5, 'Shift-C;Shift-A;', 30);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7004,GETDATE()+6, 'Shift-A;', 78);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7004,GETDATE()+7, 'Shift-B;', 36);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7004,GETDATE()+8, 'Shift-A', 165);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7004,GETDATE()+9, 'Shift-C;Shift-A;', 115);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7004,GETDATE()+10, 'Shift-C;Shift-A;', 30);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7004,GETDATE()+11, 'Shift-A;', 78);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7004,GETDATE()+12, 'Shift-B;', 36);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7004,GETDATE()+13, 'Shift-A', 165);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7004,GETDATE()+14, 'Shift-C;Shift-A;', 115);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7004,GETDATE()+15, 'Shift-C;Shift-A;', 30);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7004,GETDATE()+16, 'Shift-A;', 78);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7004,GETDATE()+17, 'Shift-B;', 36);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7004,GETDATE()+18, 'Shift-A', 165);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7004,GETDATE()+19, 'Shift-C;Shift-A;', 115);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7004,GETDATE()+20, 'Shift-C;Shift-A;', 30);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7005,GETDATE()+1, 'Shift-A;', 510);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7005,GETDATE()+2, 'Shift-B;', 365);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7005,GETDATE()+3, 'Shift-A', 16);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7005,GETDATE()+4, 'Shift-C;Shift-A;', 11);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7005,GETDATE()+5, 'Shift-C;Shift-A;', 306);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7005,GETDATE()+6, 'Shift-A;', 510);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7005,GETDATE()+7, 'Shift-B;', 365);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7005,GETDATE()+8, 'Shift-A', 16);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7005,GETDATE()+9, 'Shift-C;Shift-A;', 11);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7005,GETDATE()+10, 'Shift-C;Shift-A;', 306);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7005,GETDATE()+11, 'Shift-A;', 510);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7005,GETDATE()+12, 'Shift-B;', 365);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7005,GETDATE()+13, 'Shift-A', 16);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7005,GETDATE()+14, 'Shift-C;Shift-A;', 11);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7005,GETDATE()+15, 'Shift-C;Shift-A;', 306);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7005,GETDATE()+16, 'Shift-A;', 510);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7005,GETDATE()+17, 'Shift-B;', 365);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7005,GETDATE()+18, 'Shift-A', 16);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7005,GETDATE()+19, 'Shift-C;Shift-A;', 11);
insert into EmployeeHours (EMPID, WorkDate, Description, HoursWorked) values(7005,GETDATE()+20, 'Shift-C;Shift-A;', 306);
