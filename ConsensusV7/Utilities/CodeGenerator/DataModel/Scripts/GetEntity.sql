select 
  ObjectId        = objects.object_id, 
  ObjectName      = objects.name, 
  CodeDomain      = isNull(ext1.value, ''),
  CodeName        = isNull(ext2.value, objects.name),
  CodeDescription = isNull(ext3.value, ''),
  CodeFlags       = isNull(ext5.value, 7)
from sys.schemas
join sys.objects on objects.schema_id = schemas.schema_id
left join sys.extended_properties as ext1 on ext1.class = 1 and ext1.major_id = objects.object_id and ext1.minor_id = 0 and ext1.name = 'consensus.domain'
left join sys.extended_properties as ext2 on ext2.class = 1 and ext2.major_id = objects.object_id and ext2.minor_id = 0 and ext2.name = 'consensus.name'
left join sys.extended_properties as ext3 on ext3.class = 1 and ext3.major_id = objects.object_id and ext3.minor_id = 0 and ext3.name = 'consensus.description'
left join sys.extended_properties as ext4 on ext4.class = 1 and ext4.major_id = objects.object_id and ext4.minor_id = 0 and ext4.name = 'consensus.included'
left join sys.extended_properties as ext5 on ext5.class = 1 and ext5.major_id = objects.object_id and ext5.minor_id = 0 and ext5.name = 'consensus.flags'
where schemas.name = 'dbo' and objects.type = 'u' and isnull(ext1.value, '') = '{0}'
order by objects.name