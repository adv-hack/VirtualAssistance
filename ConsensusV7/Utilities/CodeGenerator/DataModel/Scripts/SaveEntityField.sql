-- Code Name
if not exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = {2} and name = 'consensus.name') and '{4}' <> ''
  exec ('exec sys.sp_addextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @level2type = ''column'', @level2name = ''{3}'', @name = ''consensus.name'', @value = ''{4}''')
else if exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = {2} and name = 'consensus.name') and '{4}' = ''
  exec ('exec sys.sp_dropextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @level2type = ''column'', @level2name = ''{3}'', @name = ''consensus.name''')
else if exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = {2} and name = 'consensus.name')
  exec ('exec sys.sp_updateextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @level2type = ''column'', @level2name = ''{3}'', @name = ''consensus.name'', @value = ''{4}''')

-- Code Description
if not exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = {2} and name = 'consensus.description') and '{5}' <> ''
  exec ('exec sys.sp_addextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @level2type = ''column'', @level2name = ''{3}'', @name = ''consensus.description'', @value = ''{5}''')
else if exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = {2} and name = 'consensus.description') and '{5}' = ''
  exec ('exec sys.sp_dropextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @level2type = ''column'', @level2name = ''{3}'', @name = ''consensus.description''')
else if exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = {2} and name = 'consensus.description')
  exec ('exec sys.sp_updateextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @level2type = ''column'', @level2name = ''{3}'', @name = ''consensus.description'', @value = ''{5}''')

-- Related Object
if not exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = {2} and name = 'consensus.related.object') and '{6}' <> ''
  exec ('exec sys.sp_addextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @level2type = ''column'', @level2name = ''{3}'', @name = ''consensus.related.object'', @value = ''{6}''')
else if exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = {2} and name = 'consensus.related.object') and '{6}' = ''
  exec ('exec sys.sp_dropextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @level2type = ''column'', @level2name = ''{3}'', @name = ''consensus.related.object''')
else if exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = {2} and name = 'consensus.related.object')
  exec ('exec sys.sp_updateextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @level2type = ''column'', @level2name = ''{3}'', @name = ''consensus.related.object'', @value = ''{6}''')

-- Related Field
if not exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = {2} and name = 'consensus.related.column') and '{7}' <> ''
  exec ('exec sys.sp_addextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @level2type = ''column'', @level2name = ''{3}'', @name = ''consensus.related.column'', @value = ''{7}''')
else if exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = {2} and name = 'consensus.related.column') and '{7}' = ''
  exec ('exec sys.sp_dropextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @level2type = ''column'', @level2name = ''{3}'', @name = ''consensus.related.column''')
else if exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = {2} and name = 'consensus.related.column')
  exec ('exec sys.sp_updateextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @level2type = ''column'', @level2name = ''{3}'', @name = ''consensus.related.column'', @value = ''{7}''')

-- Code Header
if not exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = {2} and name = 'consensus.codeheader') and '{8}' <> ''
  exec ('exec sys.sp_addextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @level2type = ''column'', @level2name = ''{3}'', @name = ''consensus.codeheader'', @value = ''{8}''')
else if exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = {2} and name = 'consensus.codeheader') and '{8}' = ''
  exec ('exec sys.sp_dropextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @level2type = ''column'', @level2name = ''{3}'', @name = ''consensus.codeheader''')
else if exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = {2} and name = 'consensus.codeheader')
  exec ('exec sys.sp_updateextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @level2type = ''column'', @level2name = ''{3}'', @name = ''consensus.codeheader'', @value = ''{8}''')

-- IsUnique
if not exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = {2} and name = 'consensus.isunique') and {9} <> 0
  exec ('exec sys.sp_addextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @name = ''consensus.isunique'', @value = {9}')
else if exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = {2} and name = 'consensus.isunique') and {9} = 0
  exec ('exec sys.sp_dropextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @name = ''consensus.isunique''')
else if exists (select * from sys.extended_properties where class = 1 and major_id = {0} and minor_id = 0 and name = 'consensus.isunique')
  exec ('exec sys.sp_updateextendedproperty @level0type = ''schema'', @level0name = ''dbo'', @level1type = ''table'', @level1name = ''{1}'', @name = ''consensus.isunique'', @value = {9}')

