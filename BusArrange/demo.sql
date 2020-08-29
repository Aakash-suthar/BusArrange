-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Aug 29, 2020 at 04:38 AM
-- Server version: 5.7.31
-- PHP Version: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `demo`
--

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `firstname` varchar(20) NOT NULL,
  `lastname` varchar(20) NOT NULL,
  `email` varchar(20) NOT NULL,
  `phoneno` double NOT NULL,
  `password` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `firstname`, `lastname`, `email`, `phoneno`, `password`) VALUES
(1, 'akash', 'suthar', 'akash@gmail.com', 123456789, '123456789'),
(2, 'akash', 'suthar', 'akashsuthar62@gmail.', 1234567890, '123456789a'),
(3, 'akash', 'suthar', 'akashsuthar62@gmail.', 1234567890, '123456789a'),
(4, 'akash', 'suthar', 'akashsuthar62@gmail.', 1234567890, '123456789a'),
(5, 'akash', 'suthar', 'akashsuthar62@gmail.', 1234567890, '123456789a'),
(6, 'akash', 'suthar', 'akashsuthar62@gmail.', 1234567890, '123456789a'),
(7, 'vishal', 'suthar', 'visha@gmail.cxom', 1234567890, '123456789a'),
(8, 'akash', 'ajsbda', 'jb@gmail.com', 2345678900, '2345678ids'),
(9, 'Disha', 'Suthar', 'admin@gmail.com', 1234567890, '12345678a');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
