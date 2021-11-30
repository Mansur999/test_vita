create database hospital

create table patient(
	id varchar(36) primary key,
	surname varchar(50) not null,
	name varchar(50) not null,
	dad_name varchar(50) not null,
	birthday date not null,
	phone varchar(15) not null
)

create table visit(
	id varchar(36) primary key,
	date_visit date not null,
	diagnosis varchar(36) not null,
	id_patient varchar(36) not null,
	CONSTRAINT FK_visits_To_patients FOREIGN KEY (id_patient) REFERENCES patient (id) ON DELETE CASCADE
)

DELETE FROM visit;

INSERT INTO patient (id,surname,name,dad_name,birthday,phone) VALUES ('1','Потов','Генадий','Вотович','1995-01-01','79678955632');
INSERT INTO patient (id,surname,name,dad_name,birthday,phone) VALUES ('2','Котов','Саша','Ротович','1975-02-02','79678955635');
INSERT INTO patient (id,surname,name,dad_name,birthday,phone) VALUES ('3','Кротов','Валера','Сотович','2001-03-03','79678955633');
INSERT INTO patient (id,surname,name,dad_name,birthday,phone) VALUES ('4','Жотов','Жора','Котович','1998-04-04','79678955631');
INSERT INTO patient (id,surname,name,dad_name,birthday,phone) VALUES ('5','Ботова','Вера','Олеговна','1996-05-05','79678955630');

INSERT INTO visit (id,date_visit,diagnosis,id_patient) VALUES ('1','2021-01-01','G00-G09 ','1');
INSERT INTO visit (id,date_visit,diagnosis,id_patient) VALUES ('2','2021-02-02','G00-G09 ','2');
INSERT INTO visit (id,date_visit,diagnosis,id_patient) VALUES ('3','2021-03-03','G00-G09 ','3');
INSERT INTO visit (id,date_visit,diagnosis,id_patient) VALUES ('4','2021-04-04','M00-G09 ','4');
INSERT INTO visit (id,date_visit,diagnosis,id_patient) VALUES ('5','2021-05-05','L00-G09 ','5');

INSERT INTO visit (id,date_visit,diagnosis,id_patient) VALUES ('6','2021-06-01','H00-G09 ','5');
INSERT INTO visit (id,date_visit,diagnosis,id_patient) VALUES ('7','2021-07-02','J00-G09 ','5');
INSERT INTO visit (id,date_visit,diagnosis,id_patient) VALUES ('8','2021-08-03','G00-G09 ','5');
INSERT INTO visit (id,date_visit,diagnosis,id_patient) VALUES ('9','2021-09-04','M00-G09 ','5');
INSERT INTO visit (id,date_visit,diagnosis,id_patient) VALUES ('10','2021-10-05','L00-G09 ','5');