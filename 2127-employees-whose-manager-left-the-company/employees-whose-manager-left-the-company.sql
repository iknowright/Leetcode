select employee_id from Employees e
where salary < 30000 and manager_id is not null 
and not exists(SELECT 1 FROM Employees m WHERE m.employee_id = e.manager_id)
order by employee_id;