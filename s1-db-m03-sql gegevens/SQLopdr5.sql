SELECT tblEvent.EventName, tblEvent.EventDate 
FROM tblEvent
WHERE tblEvent.EventName LIKE '%Teletubbies%'
OR
tblEvent.EventName LIKE '%Pandy%';