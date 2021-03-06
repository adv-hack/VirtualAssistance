﻿
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusAccountPerson'))
BEGIN
	exec ('create view [dbo].[vConsensusAccountPerson] as select 1 TEMP')
END
GO


ALTER VIEW [dbo].[vConsensusAccountPerson]

AS

SELECT 
ACXREF_ID,
ACXREF_ACC_ID,
ACXREF_ORG_ID,
ACXREF_ADD_ID, 
ACXREF_PROLE_ID, 
ACXREF_MAIN, 
ACXREF_INVOICE, 
ACXREF_STATEMENT, 
ACXREF_NO_ADD_CHANGE, 
ACXREF_FOR_ATTN_OF,
ACXREF_NOMINATED, 
ACXREF_INCL_HIERARCHY,
ACXREF_FROM_HIERARCHY, 
PROLE_PN_NAME, 
ORG_NAME, 
ADD_MAILSTRING,
uri = 'finance/AccountXref/' + convert(varchar, ACXREF_ID) 
FROM dbo.Account_Xref 
INNER JOIN dbo.Address ON ADD_ID = ACXREF_ADD_ID 
LEFT OUTER JOIN dbo.Person_Role ON PROLE_ID = ACXREF_PROLE_ID 
LEFT OUTER JOIN dbo.Organisation ON ORG_ID = ACXREF_ORG_ID


GO


