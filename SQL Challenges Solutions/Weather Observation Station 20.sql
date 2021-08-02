select distinct
  cast(
     round(
       PERCENTILE_DISC (.5) WITHIN GROUP (order by lat_n) OVER()
     ,4) 
   as decimal(18,4))
from station
