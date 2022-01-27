SELECT        Employee.ID, Department.NAME AS DEPARTMENT_NAME, Employee.NAME, Employee.SALARY, Chief.SALARY AS CHIEF_SALARY
FROM            Department INNER JOIN
                         Employee ON Department.ID = Employee.DEPARTMENT_ID INNER JOIN
                         Employee AS Chief ON Employee.CHIEF_ID = Chief.ID
WHERE Employee.SALARY > Chief.SALARY