if not exists (select * from sys.extended_properties where class = 0 and name = 'Consensus.{0}') and '{1}' <> ''
  exec ('exec sys.sp_addextendedproperty @name = ''Consensus.{0}'', @value = ''{2}''')
else if exists (select * from sys.extended_properties where class = 0 and name = 'Consensus.{0}') and '{1}' = ''
  exec ('exec sys.sp_dropextendedproperty @name = ''consensus.{0}''')