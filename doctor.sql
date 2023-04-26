
-- Creating Doctor table
CREATE TABLE Doctor (Did INT PRIMARY KEY, dname VARCHAR(50),daddress VARCHAR(100),qualification VARCHAR(50),noofpatient_handled INT);

-- Inserting data into Doctor table
INSERT INTO Doctor (Did, dname, daddress, qualification, noofpatient_handled)
VALUES 
  (1, 'Ketan', '123 Main St, Pune', 'MBBS', 50),
  (2, 'prathamesh', '456  St,	Pune', 'MD', 75),
  (3, 'Sanket', '789 Pine St, Mumbai', 'MBBS', 100),
  (4, 'Ajay', '246 Elm St, Ahmednagar', 'MD', 25),
  (5, 'smita', '135 Maple St, Delhi', 'MBBS', 80);

  select * from Doctor;

-- Creating PatientMaster table
CREATE TABLE PatientMaster (Pcode INT PRIMARY KEY,pname VARCHAR(50),paddr VARCHAR(100),age varchar(30),gender CHAR(1),bloodgroup VARCHAR(3));

-- Inserting data into PatientMaster table
INSERT INTO PatientMaster (Pcode, pname, paddr, age, gender, bloodgroup)
VALUES 
  (1001, 'Sanket ', '246 Park Ln, Mumbai', 25, 'M', 'AB+'),
  (1002, 'Smita ', '789 Maple Rd, Delhi', 35, 'F', 'O-'),
  (1003, 'Rahul', '135 Oak St, Ahmednagar', 45, 'M', 'B+'),
  (1004, 'kanchan', '246 Pine Ave, Pune', 55, 'F', 'AB-'),
  (1005, 'Sam', '123 Elm St, Pune', 65, 'M', 'A+');

  select * from PatientMaster;


-- Creating AdmittedPatient table

CREATE TABLE AdmittedPatient (Pcode INT NOT NULL PRIMARY KEY,Entry_date DATE NOT NULL,Discharge_date DATE,Wardno INT,Disease VARCHAR(50),Did INT);

-- Inserting records into AdmittedPatient table
INSERT INTO AdmittedPatient (Pcode, Entry_date, Discharge_date, Wardno, Disease, Did)
VALUES
(1001, '2022-01-01', '2022-01-05', 101, 'Malaria', 1),
(1002, '2022-02-01', '2022-02-07', 102, 'Typhoid', 2),
(1003, '2022-03-01', '2022-03-09', 103, 'Pneumonia', 3),
(1004, '2022-04-01', '2022-04-13', 104, 'Tuberculosis', 4),
(1005, '2022-05-01', '2022-05-18', 105, 'Meningitis', 5);

select * from AdmittedPatient;

-- Creating Bill table
CREATE TABLE Bill (Pcode INT NOT NULL,Bill_amount DECIMAL(8, 2) NOT NULL,PRIMARY KEY (Pcode),CONSTRAINT fk_Patient_code FOREIGN KEY (Pcode)
REFERENCES AdmittedPatient (Pcode));

-- Inserting records into Bill table
INSERT INTO Bill (Pcode, Bill_amount)
VALUES
(1001, 5000.00),
(1002, 10000.00),
(1003, 7500.00),
(1004, 12000.00),
(1005, 9000.00);

select * from Bill;

--2)	write a query to describe above tables;

exec sp_help Doctor;
 
exec sp_help PatientMaster;

exec sp_help AdmittedPatient;

exec sp_help Bill; 



--3)write a query to drop primary key from patientMaster
alter table PatientMaster drop  Pcode  ;

--4)	Suppose Discharge _date is not present into AdmittedPatient write query to add Discharge_date column into the AdmittedPatient

alter table AdmittedPatient add Dischargedate varchar(30) ;

--5)	write a query to add primary key to patientMaster



--6)	write a query to insert 5 records into the Doctor table

select * from Doctor;

--7)	write a query find the no. of doctors as per qualification

select count (qualification) from Doctor;


--8)	find the doctors whose qualification is MD or MBBS

SELECT Did, dname, qualification FROM Doctor WHERE qualification IN ('MD', 'MBBS');


--9)	find patients whose age is between 21to 27  with bloodgroup A+

SELECT * FROM PatientMaster WHERE age BETWEEN 21 AND 27 AND bloodgroup = 'AB+';

--10)	find the doctors whose address is mumbai and noofpatient_handle are 10

SELECT dname, qualification FROM Doctor WHERE daddress='Mumbai' AND noofpatient_handled=100;

--11)	find the count of pateint as per the blood group


  select * from PatientMaster;

SELECT bloodgroup, COUNT(Pcode ) FROM PatientMaster GROUP BY bloodgroup;

--12)	find the maximum bill amount

select * from Bill;

select MAX(Bill_amount) from Bill;

--13)	find the doctors who has noofpatient_handle are more than 10;
  select * from Doctor;

  SELECT dname  FROM Doctor WHERE noofpatient_handled > 10;

 -- 14)	find the number of patients who live in pune;

 select * from PatientMaster where paddr='Pune';


 --15)	find the patients whose bloodgroup is AB+ and gender is the male

 SELECT * FROM PatientMaster WHERE bloodgroup = 'AB+' AND gender = 'M';

--17)	delete the patient whose wardno is 4 and 6 and Disease is dengoue 
DELETE FROM AdmittedPatient WHERE wardno IN (4, 6) AND Disease = 'dengue';

--18)	remove all records from bill table

 DROP TABLE Bill;