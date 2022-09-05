USE [BloodBankManagement]
GO

SELECT [donorId]
      ,[donor_name]
      ,[donor_fname]
      ,[dob]
      ,[mobile]
      ,[email]
      ,[city]
      ,[address]
      ,[bloodGroup]
      ,[donorGender]
  FROM [dbo].[donorTable]
GO


SELECT MAX(donor_id) FROM donorTable;