-- phpMyAdmin SQL Dump
-- version 3.4.10.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Mar 24, 2013 at 12:40 PM
-- Server version: 5.6.10
-- PHP Version: 5.3.10

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `runuo`
--

-- --------------------------------------------------------

--
-- Table structure for table `datetime`
--

CREATE TABLE IF NOT EXISTS `datetime` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `serial` int(255) NOT NULL,
  `dateTime` bigint(20) NOT NULL,
  `Iden` int(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=74 ;

-- --------------------------------------------------------

--
-- Table structure for table `decimal`
--

CREATE TABLE IF NOT EXISTS `decimal` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `serial` int(255) NOT NULL,
  `decimal` decimal(65,30) NOT NULL,
  `Iden` int(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=24 ;

-- --------------------------------------------------------

--
-- Table structure for table `double`
--

CREATE TABLE IF NOT EXISTS `double` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `serial` int(255) NOT NULL,
  `double` decimal(65,30) NOT NULL,
  `Iden` int(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

-- --------------------------------------------------------

--
-- Table structure for table `int`
--

CREATE TABLE IF NOT EXISTS `int` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `serial` int(255) NOT NULL,
  `int` int(255) NOT NULL,
  `Iden` int(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=37 ;

-- --------------------------------------------------------

--
-- Table structure for table `ipaddress`
--

CREATE TABLE IF NOT EXISTS `ipaddress` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `serial` int(255) NOT NULL,
  `ipaddress` bigint(20) NOT NULL,
  `Iden` int(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=39 ;

-- --------------------------------------------------------

--
-- Table structure for table `long`
--

CREATE TABLE IF NOT EXISTS `long` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `serial` int(255) NOT NULL,
  `long` bigint(40) NOT NULL,
  `Iden` int(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=22 ;

-- --------------------------------------------------------

--
-- Table structure for table `short`
--

CREATE TABLE IF NOT EXISTS `short` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `serial` int(255) NOT NULL,
  `short` int(255) NOT NULL,
  `Iden` int(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

-- --------------------------------------------------------

--
-- Table structure for table `string`
--

CREATE TABLE IF NOT EXISTS `string` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `serial` int(255) NOT NULL,
  `string` longtext NOT NULL,
  `Iden` int(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=74 ;

-- --------------------------------------------------------

--
-- Table structure for table `timespan`
--

CREATE TABLE IF NOT EXISTS `timespan` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `serial` int(255) NOT NULL,
  `timespan` bigint(20) NOT NULL,
  `Iden` int(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=35 ;

-- --------------------------------------------------------

--
-- Table structure for table `uint`
--

CREATE TABLE IF NOT EXISTS `uint` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `serial` int(255) NOT NULL,
  `uint` bigint(40) NOT NULL,
  `Iden` int(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=19 ;

-- --------------------------------------------------------

--
-- Table structure for table `ushort`
--

CREATE TABLE IF NOT EXISTS `ushort` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `serial` int(255) NOT NULL,
  `ushort` int(255) NOT NULL,
  `Iden` int(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
