-----============================Transection Details=============================

SELECT     dbo.Transection.id, dbo.Transection.TransectionID, dbo.Transection.Date, dbo.Transection.No, dbo.Transection.TransectionType,  
dbo.Transection.Amount_Dr, dbo.Transection.Amount_Cr, dbo.Transection.Mode, dbo.Transection.BankName, dbo.Transection.ChequeNo, dbo.Transection.ChequeDate, dbo.Transection.Narration, 
dbo.Transection.Status, dbo.Transection.Transection_Ref_No,

------------------------------Ledger From To-----------------------------------
dbo.Transection.LedgerIdFrom, Ledgers_From.LedgerName  AS LedgerName_From,
dbo.Transection.LedgerIdTo, Ledgers_To.LedgerName AS LedgerName_To

----------------------------------Joining--------------------------------------------
FROM         dbo.Transection INNER JOIN
dbo.Ledgers AS Ledgers_From ON Ledgers_From.LedgerId = dbo.Transection.LedgerIdFrom INNER JOIN
dbo.Ledgers AS Ledgers_To ON Ledgers_To.LedgerId = dbo.Transection.LedgerIdTo 

-----------------------------------Group By-------------------------------------
group By  dbo.Transection.id, dbo.Transection.TransectionID, dbo.Transection.Date, dbo.Transection.No, dbo.Transection.TransectionType,  
dbo.Transection.Amount_Dr, dbo.Transection.Amount_Cr, dbo.Transection.Mode, dbo.Transection.BankName, dbo.Transection.ChequeNo, dbo.Transection.ChequeDate, dbo.Transection.Narration, 
dbo.Transection.Status, dbo.Transection.Transection_Ref_No,
Ledgers_From.LedgerName,LedgerIdFrom,Ledgers_To.LedgerName,LedgerIdTo
-------------------------------------Order By------------------------------------
order by Id,date,Transection_Ref_No
---------------===================================(End)===============================================