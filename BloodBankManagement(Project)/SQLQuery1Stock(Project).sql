USE [BloodBankManagement]
GO

SELECT [bid]
      ,[bloodGroup]
      ,[quantity]
  FROM [dbo].[Stock]
GO


SELECT * FROM Stock
insert into Stock(bloodGroup,quantity) values('A+',100);
insert into Stock(bloodGroup,quantity) values('A-',100);
insert into Stock(bloodGroup,quantity) values('B+',100);
insert into Stock(bloodGroup,quantity) values('B-',100);
insert into Stock(bloodGroup,quantity) values('AB+',100);
insert into Stock(bloodGroup,quantity) values('AB-',100);
insert into Stock(bloodGroup,quantity) values('O+',100);
insert into Stock(bloodGroup,quantity) values('O-',100);