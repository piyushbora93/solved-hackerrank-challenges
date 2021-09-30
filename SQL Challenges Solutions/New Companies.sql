select distinct C.Company_Code, C.Founder, COUNT(distinct LM.Lead_Manager_Code), COUNT(distinct SM.Senior_Manager_Code), COUNT(distinct M.manager_code), COUNT(distinct E.employee_code)
FROM Company C 
JOIN Lead_Manager LM ON C.company_code = LM.company_code
JOIN Senior_Manager SM ON LM.Lead_Manager_Code = SM.Lead_Manager_Code AND LM.Company_Code = SM.Company_Code
JOIN Manager M ON SM.senior_manager_code = M.senior_manager_code AND SM.lead_manager_code = M.lead_manager_code AND SM.Company_Code = M.Company_Code
JOIN Employee E ON M.manager_code = E.manager_code AND M.senior_manager_code = E.senior_manager_code AND M.lead_manager_code = E.lead_manager_code AND M.Company_Code = E.company_code
GROUP BY C.Company_Code, C.Founder
ORDER BY C.Company_Code ASC
