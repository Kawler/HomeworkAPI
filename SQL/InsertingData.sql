use Homework

create table Subjects(
	SubjectId int identity(1,1) constraint PK_Subjects primary key,
	Classroom int,
	SubjectName nvarchar(30)
) 

create table Schedule(
	ScheduleId int identity(1,1) constraint  PK_Schedule primary key,
	DayOfTheWeek nvarchar(20)
)

create table ScheduleSubject(
	ScheduleSubjectId int identity(1,1) constraint PK_ScheduleSubject primary key,
	ScheduleId int constraint FK_ScheduleSubject_Schedule references Schedule(ScheduleId),
	SubjectId int constraint FK_ScheduleSubject_Subjects references Subjects(SubjectId) on delete cascade
)

create table Teacher(
	Id int identity(1,1) constraint PK_Teachers primary key,
	TeachersName nvarchar(50),
	TaughtSubject int constraint FK_Teacher_Subjects references Subjects(SubjectId) on delete cascade
)

insert into Subjects
	(Classroom, SubjectName)
values
	(319,'Math'),
	(403,'Economics'),
	(100,'PE'),
	(304,'CS'),
	(113,'Biology'),
	(214,'Web'),
	(104,'Art'),
	(307,'English'),
	(318,'Physics')

insert into Schedule
	(DayOfTheWeek)
values
	('Monday'),
	('Tuesday'),
	('Wednesday'),
	('Thusrday'),
	('Friday')

insert into Teacher 
	(TeachersName, TaughtSubject)
values
	('Michael',1),
	('Michel',2),
	('Mike',3),
	('Moroz',4),
	('Mirror',5),
	('Katerine',6),
	('Bob',7),
	('Joe',8),
	('Dave',9),
	('Dave',3),
	('Clark',8),
	('Utop',8)


insert into ScheduleSubject 
(ScheduleId, SubjectId)
values
	(1,2),
	(1,3),
	(1,4),
	(1,2),
	(2,3),
	(2,3),
	(2,5),
	(3,5),
	(4,6),
	(4,1),
	(4,5),
	(5,8),
	(5,9),
	(5,7)
