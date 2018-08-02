select 
  Identifier = substring(name, 11, len(name) - 10),
  Name = substring(name, 11, len(name) - 10),
  Description = value
from sys.extended_properties
where class = 0
  and major_id = 0
  and minor_id = 0
  and name like 'Consensus.%'