CREATE TABLE artists (  
    id int NOT NULL primary key AUTO_INCREMENT comment 'primary key',
    name varchar(255) NOT NULL comment 'artist name',
    paintings int comment 'artists total paintings',
    deceased TINYINT comment 'artist is deceased'
) default charset utf8 comment '';

/* Create */
INSERT INTO artists (
  name,
  paintings,
  deceased
) VALUES
(
  "Van Gogh",
  75,
  1
)
/* Get All */
SELECT * FROM artists;

/* GetBy*/
SELECT * FROM artists WHERE id = 2;

UPDATE artists SET name = "Van Going" WHERE id = 2;

DELETE FROM artists WHERE id = 2;

/*DANGER ZONE*/
-- DELETE FROM artists; //REMOVES WHOLE TABLE

-- DROP TABLE artists; //REMOVES entire Database

--DROP CLASSROOM; 