-- Code Name
if not exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = 0 and name = 'consensus.name') and '{2}' <> ''
  exec ('exec sys.sp_addextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @name = ''consensus.name'', @value = ''{2}''')
else if exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = 0 and name = 'consensus.name') and '{2}' = ''
  exec ('exec sys.sp_dropextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @name = ''consensus.name''')
else if exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = 0 and name = 'consensus.name')
  exec ('exec sys.sp_updateextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @name = ''consensus.name'', @value = ''{2}''')

-- Description
if not exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = 0 and name = 'consensus.description') and '{3}' <> ''
  exec ('exec sys.sp_addextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @name = ''consensus.description'', @value = ''{3}''')
else if exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = 0 and name = 'consensus.description') and '{3}' = ''
  exec ('exec sys.sp_dropextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @name = ''consensus.description''')
else if exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = 0 and name = 'consensus.description')
  exec ('exec sys.sp_updateextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @name = ''consensus.description'', @value = ''{3}''')

-- Domain
if not exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = 0 and name = 'consensus.domain') and '{4}' <> ''
  exec ('exec sys.sp_addextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @name = ''consensus.domain'', @value = ''{4}''')
else if exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = 0 and name = 'consensus.domain') and '{4}' = ''
  exec ('exec sys.sp_dropextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @name = ''consensus.domain''')
else if exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = 0 and name = 'consensus.domain') 
  exec ('exec sys.sp_updateextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @name = ''consensus.domain'', @value = ''{4}''')

-- Flags
if not exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = 0 and name = 'consensus.flags') and {5} <> 7
  exec ('exec sys.sp_addextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @name = ''consensus.flags'', @value = {5}')
else if exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = 0 and name = 'consensus.flags') and {5} = 7
  exec ('exec sys.sp_dropextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @name = ''consensus.flags''')
else if exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = 0 and name = 'consensus.flags')
  exec ('exec sys.sp_updateextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @name = ''consensus.flags'', @value = {5}')
