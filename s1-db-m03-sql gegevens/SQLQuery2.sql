SELECT tblAuthor.AuthorName, tblEpisode.Title, tblDoctor.DoctorName, tblEnemy.EnemyName, tblEpisodeEnemy.EpisodeId [Totaal]
FROM tblEpisode
INNER JOIN tblAuthor
ON tblEpisode.AuthorId = tblAuthor.AuthorId
INNER JOIN tblDoctor
ON tblEpisode.DoctorId = tblDoctor.DoctorId
FULL OUTER JOIN tblEpisodeEnemy
ON tblEpisode.EpisodeId = tblEpisodeEnemy.EpisodeId
INNER JOIN tblEnemy
ON tblEpisodeEnemy.EnemyId = tblEnemy.EnemyId
WHERE tblEpisodeEnemy.EpisodeId = COUNT(tblAuthor.AuthorName) + COUNT(tblEpisode.Title) + COUNT(tblDoctor.DoctorName) + COUNT(tblEnemy.EnemyName)
ORDEtblEpisodeEnemy.EpisodeId < 40;