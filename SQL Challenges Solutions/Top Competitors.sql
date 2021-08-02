select H.hacker_id, H.name from Hackers H
inner join Submissions s on h.hacker_id = s.hacker_id
inner join challenges c on s.challenge_id = c.challenge_id
inner join difficulty d on c.difficulty_level = d.difficulty_level
WHERE s.score = d.score
group by H.hacker_id, H.name
having count(s.submission_id) > 1
order by count(s.submission_id) desc, H.hacker_id ASC
