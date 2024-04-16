USE master
GO

IF EXISTS (SELECT NAME FROM master.dbo.sysdatabases
WHERE name = 'Movie_Max')
          BEGIN
		       DROP DATABASE Movie_Max
			   PRINT 'Existing database Movie_Max deleted'
		  END
GO

CREATE DATABASE Movie_Max
ON PRIMARY
(
              NAME = 'Movie_Max_data',
			  FILENAME = 'C:\SqlJavaProject\Movie_Max_data.mdf',
			  SIZE = 5MB,
			  FILEGROWTH = 10%
)
LOG ON
(

              NAME = 'Movie_Max_log',
			  FILENAME = 'C:\SqlJavaProject\Movie_Max_log.ldf',
			  SIZE = 5MB,
			  FILEGROWTH = 10%
)

ALTER DATABASE Movie_Max
ADD FILEGROUP Movie_Max_filegroup
GO

ALTER DATABASE Movie_Max
ADD FILE
(
           NAME = Movie_Max_info,
		   FILENAME = 'C:\SqlJavaProject\Movie_Max_ndf',
		   SIZE = 5MB
)
GO


CREATE TABLE genre
(
             genreID INT NOT NULL PRIMARY KEY,
			 genreName VARCHAR (30) NOT NULL
)
GO

CREATE TABLE movie
(
             movieID INT NOT NULL PRIMARY KEY,
			 movieName VARCHAR (70) NOT NULL,
			 descriptions TEXT NOT NULL,
			 genreID INT NOT NULL,
			 FOREIGN KEY (genreID) REFERENCES genre(genreID) 
			
			      
)
GO

CREATE TABLE users
(
             userID INT NOT NULL PRIMARY KEY,
			 username VARCHAR (40) NOT NULL,
			 password_ VARCHAR (30) NOT NULL
)
GO

INSERT INTO genre 
VALUES
             (11, 'Drama' ),
			 (12, 'Action'),
			 (13, 'Thriller'),
			 (14, 'Animation'),
			 (15, 'Comedy'),
			 (16, 'Romance'),
			 (17, 'Biography'),
			 (18, 'Fantasy'),
			 (19, 'Mystery'),
			 (20, 'Adventure')
GO



INSERT INTO movie
VALUES
             (1, 'Glass', 'Security guard David Dunn uses his 
			 supernatural abilities to track Kevin Wendell Crumb,
			  a disturbed man who has twenty-four personalities.', 11),
			 (2, 'The Kid Who Would Be King', 'A band of kids embark on an epic quest to thwart
			  a medieval menace.', 12),
			  (3, 'Miss Bala', 'Gloria finds a power she never knew she had when she
			   is drawn into a dangerous world of cross-border crime. 
			   Surviving will require all of her cunning, inventiveness,
			    and strength. Based on the Spanish-language film.', 13),
			  (4, 'The Lego Movie 2',  'It has been five years since everything was awesome
			   and the citizens are facing a huge new threat: Lego Duplo
			    invaders from outer space, wrecking everything faster than 
				they can rebuild.', 14),
			  (5,'What Men Want',  'A woman is boxed out by the male sports agents in her
			   profession, but gains an unexpected edge over them when
			    she develops the ability to hear men s thoughts.', 15),
			  (6,'Alita: Battle Angel',  'A deactivated female cyborg is revived, but cannot 
			  remember anything of her past life and goes on a quest
			   to find out who she is.', 16),
			  (7, 'Fighting with My Family ', 'A former wrestler and his family make a living performing
			   at small venues around the country while his kids dream of
			    joining World Wrestling Entertainment.', 17),
			  (8, 'Is It Not Romantic', 'A young woman disenchanted with love mysteriously
			   finds herself trapped inside a romantic comedy.', 18),
			  (9,'Happy Death Day 2U',  'Tree Gelbman discovers that dying over and over 
			  was surprisingly easier than the dangers that lie ahead.', 19),
			  (10,'How To Train Your Dragon: The Hidden World',  'When Hiccup discovers Toothless is not the only Night Fury,
			   he must seek "The Hidden World", a secret Dragon Utopia before
			    a hired tyrant named Grimmel finds it first.', 20)
GO

INSERT INTO users
VALUES
              (00, 'marc', '1234' )

GO