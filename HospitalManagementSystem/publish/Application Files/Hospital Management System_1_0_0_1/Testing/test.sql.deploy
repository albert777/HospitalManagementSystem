SELECT P.*, B.Room 
FROM PATIENTS As P LEFT OUTER JOIN
	 BEDS As B ON P.BedId = B.Id
WHERE P.Id = 1 AND RTRIM(P.Name) LIKE N'%lê%' AND P.IdCard = '' AND P.Phone = ''

SELECT COUNT(*) FROM ACCOUNTS WHERE Username = 'admin' AND Password = 'admin'

SELECT E.Id, E.Name, E.Sex, E.DoB, E.IdCard, E.Address, E.Phone, E.Folk, 
                                   E.HireDate, E.BasicSalary, E.Subsidy, E.Ratio, 
                                   E.Position, E.DeptId, D.Name AS DeptName, S.Name AS SpecName, E.SpecId
                                   FROM EMPLOYEES AS E LEFT OUTER JOIN
                                   SPECIALITIES AS S ON E.SpecId = S.Id LEFT OUTER JOIN
                                   DEPARTMENTS AS D ON E.DeptId = D.Id
                                   WHERE E.Id =1

SELECT * FROM APPOINTMENTS
SELECT * FROM APPOINTMENTLINES

/* important */
SELECT L.Id As LineId, L.Detail 
FROM APPOINTMENTS AS A LEFT OUTER JOIN
	 APPOINTMENTLINES AS L ON A.Id = L.AppointmentId 
	 LEFT OUTER JOIN PATIENTS AS P ON A.PatientId = P.Id
WHERE A.Id = 2

SELECT A.*, P.Name AS PName, E.Name As EName, C.Name AS CName, D.Name As DName 
FROM APPOINTMENTS AS A 
	 LEFT OUTER JOIN PATIENTS AS P ON A.PatientId = P.Id
	 LEFT OUTER JOIN CLINICS AS C ON A.ClinicId = C.Id
	 LEFT OUTER JOIN EMPLOYEES AS E ON A.EmployeeId = E.Id
	 LEFT OUTER JOIN EMPLOYEES AS D ON A.DoctorId = D.Id
WHERE P.Id = 1

SELECT * FROM CLINICS


/* important */

