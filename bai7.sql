use monstarlab;

create table answers(
	id bigint primary key not null,
    correct_answer varchar(10) not null,
    given_answer varchar(10)
);
insert into answers(id,correct_answer,given_answer)
 values
(1,'a' ,'a'),
(2,'b' ,'null'),
(3,'c' ,'b');

select id ,
CASE
	WHEN correct_answer = given_answer then 'correct'
    WHEN given_answer = 'NULL' then 'no answer'
ELSE 'incorrect'
END AS checks
FROM answers;

select id, if(given_answer = 'NULL','no answer',if(correct_answer = given_answer , 'correct','incorrect') ) AS checks FROM answers