CREATE TABLE artists (  
    id int NOT NULL primary key AUTO_INCREMENT comment 'primary key',
    name varchar(255) NOT NULL comment 'artist name',
    paintings int comment 'artists total paintings',
    deceased TINYINT comment 'artist is deceased'
) default charset utf8 comment '';

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