// GENERISANJE TABELE I PODATAKA

CREATE DATABASE snakegame;
use snakegame;


CREATE TABLE `users` (
  `id` int(11) NOT NULL PRIMARY KEY,
  `username` varchar(10) NOT NULL,
  `password` varchar(12) NOT NULL,
  `highscore` int(11) NOT NULL DEFAULT 0
);


INSERT INTO `users` (`id`, `username`, `password`, `highscore`) VALUES
(1, 'admin', 'admin', 3),
(2, 'uros', '123', 7),
(3, 'treci', '123', 999),
(4, 'qwe', '123', 0),
(5, '', '', 0),
(6, 'korisnik', '123', 3),
(7, 'lav', '123', 1),
(8, 'marko', '123', 0),
(9, 'moker', '123', 0);