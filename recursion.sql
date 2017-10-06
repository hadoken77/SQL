-- sample of recursion in SQL
 
 with a as (select 1 as num
           union all
           select num + 1
           from a
           where num < 10
           )
select * 
from a
