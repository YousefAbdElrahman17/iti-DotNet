-- Company

use  Company

--INSERT INTO DEPARTMENT (DNUMBER, DNAME, MGRSSN, MGRSTARTDATE) VALUES
--(10, 'Research', NULL, '2020-01-01'),
--(20, 'Administration', NULL, '2019-05-15'),
--(30, 'Headquarters', NULL, '2018-03-10');
--
--
--
--INSERT INTO EMPLOYEE (SSN, FNAME, LNAME, BDATE, ADDRESS, SEX, SALARY, SUPERSSN, DNO) VALUES
--('111111111', 'Ahmed', 'Hassan', '1985-04-10', 'Cairo, Egypt', 'M', 1500.00, NULL, 10),
--('222222222', 'Sara', 'Ali', '1990-07-22', 'Giza, Egypt', 'F', 1200.00, '111111111', 10),
--('333333333', 'Mohamed', 'Kamal', '1988-11-05', 'Alexandria, Egypt', 'M', 900.00, '111111111', 20),
--('444444444', 'Nour', 'Ibrahim', '1992-02-18', 'Cairo, Egypt', 'F', 2000.00, NULL, 30),
--('968574', 'Omar', 'Saeed', '1980-09-30', 'Cairo, Egypt', 'M', 2500.00, NULL, 10);
--
--
--UPDATE DEPARTMENT SET MGRSSN = '968574' WHERE DNUMBER = 10;
--UPDATE DEPARTMENT SET MGRSSN = '333333333' WHERE DNUMBER = 20;
--UPDATE DEPARTMENT SET MGRSSN = '444444444' WHERE DNUMBER = 30;
--
--
--INSERT INTO DEPT_LOCATIONS (DNUMBER, DLOCATION) VALUES
--(10, 'Cairo'),
--(10, 'Giza'),
--(20, 'Alexandria'),
--(30, 'Cairo');
--
--
--INSERT INTO PROJECT (PNUMBER, PNAME, PLOCATION, DNUM) VALUES
--(1, 'ProductX', 'Cairo', 10),
--(2, 'ProductY', 'Giza', 10),
--(3, 'Computerization', 'Alexandria', 20),
--(4, 'Reorganization', 'Cairo', 30);
--
--
--INSERT INTO WORKS_ON (ESSN, PNO, HOURS) VALUES
--('111111111', 1, 20.0),
--('111111111', 2, 15.5),
--('222222222', 1, 30.0),
--('333333333', 3, 25.0),
--('444444444', 4, 10.0),
--('968574', 2, 12.0);
--
--
--INSERT INTO DEPENDENT (ESSN, DEPENDENT_NAME, SEX, BDATE, RELATIONSHIP) VALUES
--('111111111', 'Laila Hassan', 'F', '2010-03-12', 'Daughter'),
--('111111111', 'Yousef Hassan', 'M', '2012-08-25', 'Son'),
--('333333333', 'Mona Kamal', 'F', '2015-01-05', 'Daughter'),
--('968574', 'Hana Saeed', 'F', '2005-06-14', 'Daughter');

--INSERT INTO DEPARTMENT (DNUMBER, DNAME, MGRSSN, MGRSTARTDATE) VALUES
--(10, 'Research', NULL, '2020-01-01'),
--(20, 'Administration', NULL, '2019-05-15'),
--(30, 'Headquarters', NULL, '2018-03-10');
--
--
--
--INSERT INTO EMPLOYEE (SSN, FNAME, LNAME, BDATE, ADDRESS, SEX, SALARY, SUPERSSN, DNO) VALUES
--('111111111', 'Ahmed', 'Hassan', '1985-04-10', 'Cairo, Egypt', 'M', 1500.00, NULL, 10),
--('222222222', 'Sara', 'Ali', '1990-07-22', 'Giza, Egypt', 'F', 1200.00, '111111111', 10),
--('333333333', 'Mohamed', 'Kamal', '1988-11-05', 'Alexandria, Egypt', 'M', 900.00, '111111111', 20),
--('444444444', 'Nour', 'Ibrahim', '1992-02-18', 'Cairo, Egypt', 'F', 2000.00, NULL, 30),
--('968574', 'Omar', 'Saeed', '1980-09-30', 'Cairo, Egypt', 'M', 2500.00, NULL, 10);
--
--
--UPDATE DEPARTMENT SET MGRSSN = '968574' WHERE DNUMBER = 10;
--UPDATE DEPARTMENT SET MGRSSN = '333333333' WHERE DNUMBER = 20;
--UPDATE DEPARTMENT SET MGRSSN = '444444444' WHERE DNUMBER = 30;
--
--
--INSERT INTO DEPT_LOCATIONS (DNUMBER, DLOCATION) VALUES
--(10, 'Cairo'),
--(10, 'Giza'),
--(20, 'Alexandria'),
--(30, 'Cairo');
--
--
--INSERT INTO PROJECT (PNUMBER, PNAME, PLOCATION, DNUM) VALUES
--(1, 'ProductX', 'Cairo', 10),
--(2, 'ProductY', 'Giza', 10),
--(3, 'Computerization', 'Alexandria', 20),
--(4, 'Reorganization', 'Cairo', 30);
--
--
--INSERT INTO WORKS_ON (ESSN, PNO, HOURS) VALUES
--('111111111', 1, 20.0),
--('111111111', 2, 15.5),
--('222222222', 1, 30.0),
--('333333333', 3, 25.0),
--('444444444', 4, 10.0),
--('968574', 2, 12.0);
--
--
--INSERT INTO DEPENDENT (ESSN, DEPENDENT_NAME, SEX, BDATE, RELATIONSHIP) VALUES
--('111111111', 'Laila Hassan', 'F', '2010-03-12', 'Daughter'),
--('111111111', 'Yousef Hassan', 'M', '2012-08-25', 'Son'),
--('333333333', 'Mona Kamal', 'F', '2015-01-05', 'Daughter'),
--('968574', 'Hana Saeed', 'F', '2005-06-14', 'Daughter');

--INSERT INTO DEPARTMENT (DNUMBER, DNAME, MGRSSN, MGRSTARTDATE) VALUES
--(10, 'Research', NULL, '2020-01-01'),
--(20, 'Administration', NULL, '2019-05-15'),
--(30, 'Headquarters', NULL, '2018-03-10');
--
--
--
--INSERT INTO EMPLOYEE (SSN, FNAME, LNAME, BDATE, ADDRESS, SEX, SALARY, SUPERSSN, DNO) VALUES
--('111111111', 'Ahmed', 'Hassan', '1985-04-10', 'Cairo, Egypt', 'M', 1500.00, NULL, 10),
--('222222222', 'Sara', 'Ali', '1990-07-22', 'Giza, Egypt', 'F', 1200.00, '111111111', 10),
--('333333333', 'Mohamed', 'Kamal', '1988-11-05', 'Alexandria, Egypt', 'M', 900.00, '111111111', 20),
--('444444444', 'Nour', 'Ibrahim', '1992-02-18', 'Cairo, Egypt', 'F', 2000.00, NULL, 30),
--('968574', 'Omar', 'Saeed', '1980-09-30', 'Cairo, Egypt', 'M', 2500.00, NULL, 10);
--
--
--UPDATE DEPARTMENT SET MGRSSN = '968574' WHERE DNUMBER = 10;
--UPDATE DEPARTMENT SET MGRSSN = '333333333' WHERE DNUMBER = 20;
--UPDATE DEPARTMENT SET MGRSSN = '444444444' WHERE DNUMBER = 30;
--
--
--INSERT INTO DEPT_LOCATIONS (DNUMBER, DLOCATION) VALUES
--(10, 'Cairo'),
--(10, 'Giza'),
--(20, 'Alexandria'),
--(30, 'Cairo');
--
--
--INSERT INTO PROJECT (PNUMBER, PNAME, PLOCATION, DNUM) VALUES
--(1, 'ProductX', 'Cairo', 10),
--(2, 'ProductY', 'Giza', 10),
--(3, 'Computerization', 'Alexandria', 20),
--(4, 'Reorganization', 'Cairo', 30);
--
--
--INSERT INTO WORKS_ON (ESSN, PNO, HOURS) VALUES
--('111111111', 1, 20.0),
--('111111111', 2, 15.5),
--('222222222', 1, 30.0),
--('333333333', 3, 25.0),
--('444444444', 4, 10.0),
--('968574', 2, 12.0);
--
--
--INSERT INTO DEPENDENT (ESSN, DEPENDENT_NAME, SEX, BDATE, RELATIONSHIP) VALUES
--('111111111', 'Laila Hassan', 'F', '2010-03-12', 'Daughter'),
--('111111111', 'Yousef Hassan', 'M', '2012-08-25', 'Son'),
--('333333333', 'Mona Kamal', 'F', '2015-01-05', 'Daughter'),
--('968574', 'Hana Saeed', 'F', '2005-06-14', 'Daughter');

-- day2

SELECT * FROM EMPLOYEE;

SELECT FNAME, LNAME, SALARY, DNO
FROM EMPLOYEE;

SELECT FNAME + ' ' + LNAME AS FULL_NAME,
       (SALARY * 12) * 0.10 AS ANNUAL_COMM
FROM EMPLOYEE;

SELECT SSN, FNAME + ' ' + LNAME AS NAME
FROM EMPLOYEE
	WHERE SALARY > 1000;

SELECT SSN, FNAME + ' ' + LNAME AS NAME
FROM EMPLOYEE
	WHERE (SALARY * 12) > 10000;

SELECT FNAME + ' ' + LNAME AS NAME, SALARY
FROM EMPLOYEE
	WHERE SEX = 'F';

SELECT DNUMBER, DNAME
FROM DEPARTMENT
	WHERE MGRSSN = '968574';

SELECT PNUMBER, PNAME, PLOCATION
FROM PROJECT
	WHERE DNUM = 10;

-------------------------------------------------------------------------

--day3

Select D.DNUMBER, D.DNAME, E.SSN As MANAGER_ID, E.FNAME + ' ' + E.LNAME As MANAGER_NAME
From DEPARTMENT D
Join EMPLOYEE E On D.MGRSSN = E.SSN;

Select D.DNAME, P.PNAME
From DEPARTMENT D
Join PROJECT P On D.DNUMBER = P.DNUM;

Select E.FNAME + ' ' + E.LNAME As EMPLOYEE_NAME, DEP.*
From DEPENDENT DEP
Join EMPLOYEE E On DEP.ESSN = E.SSN;

Select PNUMBER, PNAME, PLOCATION
From PROJECT
Where PLOCATION In ('Cairo', 'Alexandria');

Select *
From PROJECT
Where PNAME Like 'A%';

Select *
From EMPLOYEE
Where DNO = 30 And SALARY Between 1000 And 2000;

Select E.FNAME + ' ' + E.LNAME As NAME
From EMPLOYEE E
Join WORKS_ON W On E.SSN = W.ESSN
Join PROJECT P On W.PNO = P.PNUMBER
Where E.DNO = 10 And P.PNAME = 'AL_Kabwahy' And W.HOURS >= 10;

Select E.FNAME + ' ' + E.LNAME As NAME
From EMPLOYEE E
Join EMPLOYEE S On E.SUPERSSN = S.SSN
Where S.FNAME = 'Kamel' And S.LNAME = 'Mohamed';

Select E.FNAME + ' ' + E.LNAME As EMPLOYEE_NAME, P.PNAME
From EMPLOYEE E
Join WORKS_ON W On E.SSN = W.ESSN
Join PROJECT P On W.PNO = P.PNUMBER
Order By P.PNAME;

Select P.PNUMBER, D.DNAME As CONTROLLING_DEPT, M.LNAME As MANAGER_LASTNAME, M.ADDRESS, M.BDATE
From PROJECT P
Join DEPARTMENT D On P.DNUM = D.DNUMBER
Join EMPLOYEE M On D.MGRSSN = M.SSN
Where P.PLOCATION = 'Cairo';

Select E.*
From EMPLOYEE E
Where E.SSN In (Select MGRSSN From DEPARTMENT Where MGRSSN Is Not Null);

Select E.*, DEP.*
From EMPLOYEE E
Left outer Join DEPENDENT DEP On E.SSN = DEP.ESSN;

Insert Into EMPLOYEE (SSN, FNAME, LNAME, BDATE, ADDRESS, SEX, SALARY, SUPERSSN, DNO) Values
('102672', 'Yousef', 'Samy', '1990-04-10', 'Cairo, Egypt', 'M', 3000.00, 112233, 30);
Insert Into EMPLOYEE (SSN, FNAME, LNAME, BDATE, ADDRESS, SEX, DNO) Values
('102660', 'Nader', 'Ibrahim', '1980-09-10', 'Giza, Egypt', 'M', 30);

Update EMPLOYEE Set SALARY = SALARY*1.2 WHERE SSN = '102672';


----------------------------------------------------------------------------------------


-- day4
-- 1
Select DEP.DEPENDENT_NAME, DEP.SEX
From DEPENDENT DEP
	Join EMPLOYEE E On DEP.ESSN = E.SSN
		Where DEP.SEX = 'F' And E.SEX = 'F'
			Union
Select DEP.DEPENDENT_NAME, DEP.SEX
From DEPENDENT DEP
	Join EMPLOYEE E On DEP.ESSN = E.SSN
		Where DEP.SEX = 'M' And E.SEX = 'M';

-- 2
Select P.PNAME, Sum(W.HOURS) As TOTAL_HOURS
From PROJECT P
	Join WORKS_ON W On P.PNUMBER = W.PNO
		Group By P.PNAME;

-- 3
Select D.*
From DEPARTMENT D
Where D.DNUMBER = (
    Select DNO From EMPLOYEE
    Where SSN = (Select Min(SSN) From EMPLOYEE)
	);

-- 4
Select D.DNAME, Max(E.SALARY) As MAX_SALARY, Min(E.SALARY) As MIN_SALARY, Avg(E.SALARY) As AVG_SALARY
From DEPARTMENT D
	Join EMPLOYEE E On D.DNUMBER = E.DNO
		Group By D.DNAME;

-- 5
Select E.FNAME + ' ' + E.LNAME As MANAGER_NAME
From EMPLOYEE E
	Where E.SSN In (Select MGRSSN From DEPARTMENT Where MGRSSN Is Not Null)
		And E.SSN Not In (Select ESSN From DEPENDENT);

-- 6
Select D.DNUMBER, D.DNAME, Count(E.SSN) As EMP_COUNT
From DEPARTMENT D
	Join EMPLOYEE E On D.DNUMBER = E.DNO
		Group By D.DNUMBER, D.DNAME
		Having Avg(E.SALARY) < (Select Avg(SALARY) From EMPLOYEE);

-- 7
Select E.DNO, E.LNAME, E.FNAME, P.PNAME
From EMPLOYEE E
	Join WORKS_ON W On E.SSN = W.ESSN
	Join PROJECT P On W.PNO = P.PNUMBER
		Order By E.DNO, E.LNAME, E.FNAME;

-- 8
Select Max(SALARY) As TOP_SALARY
From EMPLOYEE
	Union
Select Max(SALARY) As SECOND_SALARY
From EMPLOYEE
	Where SALARY Not In (Select Max(SALARY) From EMPLOYEE);

-- 9
Select E.FNAME + ' ' + E.LNAME As EMPLOYEE_NAME
From EMPLOYEE E
	Where Exists (
	Select 1 From DEPENDENT DEP
    	Where DEP.DEPENDENT_NAME Like '%' + E.FNAME + '%'
       		Or DEP.DEPENDENT_NAME Like '%' + E.LNAME + '%'
);

-- 10
Select E.SSN, E.FNAME + ' ' + E.LNAME As NAME
From EMPLOYEE E
	Where Exists (Select 1 From DEPENDENT DEP Where DEP.ESSN = E.SSN);

-- 11
Insert Into DEPARTMENT (DNUMBER, DNAME, MGRSSN, MGRSTARTDATE) Values
(100, 'DEPT IT', '112233', '2006-11-01');

-- 12
Update DEPARTMENT Set MGRSSN = '968574', MGRSTARTDATE = GetDate() Where DNUMBER = 100;

-- 12
Update DEPARTMENT Set MGRSSN = '102672', MGRSTARTDATE = GetDate() Where DNUMBER = 20;
Update EMPLOYEE Set DNO = 20 Where SSN = '102672';

-- 12
Update EMPLOYEE Set SUPERSSN = '102672' Where SSN = '102660';

-- 13
Delete From DEPENDENT Where ESSN = '223344';
Delete From WORKS_ON Where ESSN = '223344';
Update EMPLOYEE Set SUPERSSN = '102672' Where SUPERSSN = '223344';
Update DEPARTMENT Set MGRSSN = '102672', MGRSTARTDATE = GetDate() Where MGRSSN = '223344';
Delete From EMPLOYEE Where SSN = '223344';

-- 14
Update EMPLOYEE
Set SALARY = SALARY * 1.30
Where SSN In (
    Select ESSN From WORKS_ON W
    Join PROJECT P On W.PNO = P.PNUMBER
    Where P.PNAME = 'Al Rabwah'
);
