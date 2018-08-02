select 
  ObjectId        = columns.column_id,
  ObjectName      = columns.name,
  ObjectType      = types.name,
  ObjectTypeFull  = types.name + case 
    when types.name in ('nchar', 'nvarchar', 'ntext') then '(' + convert(varchar, columns.max_length / 2) + ')'
	when types.name in ('binary', 'char', 'varbinary', 'varchar') then '(' + convert(varchar, columns.max_length) + ')'
	when types.name in ('decimal', 'money', 'numeric') then '(' + convert(varchar, columns.precision) + ', ' + convert(varchar, columns.scale) + ')'
	else '' end,
  ObjectNull      = columns.is_nullable,
  CodeName        = isNull(ext1.value, ''),
  CodeDescription = isNull(ext2.value, ''),
  IsPrimaryKey    = convert(bit, case when indexes.index_id is null and columns.column_id = 1 then 1 when index_columns.column_id = columns.column_id then 1 else 0 end),
  RelatedEntity   = isNull(ext3.value, ''),
  RelatedField    = isNull(ext4.value, ''),
  CodeHeader      = isNull(ext5.value, ''),
  IsUnique        = convert(bit, case when ext6.value = 1 then 1 else 0 end)
from sys.objects
join sys.columns on columns.object_id = objects.object_id
join sys.types on types.user_type_id = columns.user_type_id
left join sys.indexes on indexes.object_id = objects.object_id and indexes.is_primary_key = 1
left join sys.index_columns on index_columns.object_id = objects.object_id and index_columns.column_id = columns.column_id and index_columns.index_id = indexes.index_id
left join sys.extended_properties as ext1 on ext1.class = 1 and ext1.major_id = objects.object_id and ext1.minor_id = columns.column_id and ext1.name = 'consensus.name'
left join sys.extended_properties as ext2 on ext2.class = 1 and ext2.major_id = objects.object_id and ext2.minor_id = columns.column_id and ext2.name = 'consensus.description'
left join sys.extended_properties as ext3 on ext3.class = 1 and ext3.major_id = objects.object_id and ext3.minor_id = columns.column_id and ext3.name = 'consensus.related.object'
left join sys.extended_properties as ext4 on ext4.class = 1 and ext4.major_id = objects.object_id and ext4.minor_id = columns.column_id and ext4.name = 'consensus.related.column'
left join sys.extended_properties as ext5 on ext5.class = 1 and ext5.major_id = objects.object_id and ext5.minor_id = columns.column_id and ext5.name = 'consensus.codeheader'
left join sys.extended_properties as ext6 on ext6.class = 1 and ext6.major_id = objects.object_id and ext6.minor_id = columns.column_id and ext6.name = 'consensus.isunique'
where objects.object_id = '{0}'