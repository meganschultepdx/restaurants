-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: May 09, 2019 at 09:13 PM
-- Server version: 5.6.38
-- PHP Version: 7.2.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `restaurants_test`
--
CREATE DATABASE IF NOT EXISTS `restaurants_test` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `restaurants_test`;

-- --------------------------------------------------------

--
-- Table structure for table `cuisine_test`
--

CREATE TABLE `cuisine_test` (
  `id` int(11) NOT NULL,
  `cuisine_type` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `restaurants_test`
--

CREATE TABLE `restaurants_test` (
  `id` int(11) NOT NULL,
  `restaurant_name` varchar(255) NOT NULL,
  `cuisine_type_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cuisine_test`
--
ALTER TABLE `cuisine_test`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `restaurants_test`
--
ALTER TABLE `restaurants_test`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cuisine_test`
--
ALTER TABLE `cuisine_test`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `restaurants_test`
--
ALTER TABLE `restaurants_test`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
