USE [FTSDemo]
GO

INSERT INTO [dbo].[Shipments]
           ([FromName]
           ,[ToName])
SELECT 
      [PodName]
      
      ,[PolName]

  FROM [worldwide].dbo.[Information]
GO


USE [FTSDemo];  
GO  
CREATE FULLTEXT CATALOG Shipments_catalog;  
GO  
CREATE FULLTEXT INDEX ON [dbo].[Shipments]
 (   
  [FromName],
  [ToName]  
   
 )   
  KEY INDEX [PK_dbo.Shipments]   
      ON Shipments_catalog;   
GO  

DROP FULLTEXT INDEX ON [dbo].[Shipments]

SELECT 

[GroupBy1].[A1] AS [C1]
FROM ( SELECT
   COUNT(1) AS[A1]
   FROM[dbo].[Shipments]
AS[Extent1]
  WHERE(contains([Extent1].[FromName], 'NIPPON')) OR(contains([Extent1].[ToName], 'NIPPON'))
    )  AS[GroupBy1]