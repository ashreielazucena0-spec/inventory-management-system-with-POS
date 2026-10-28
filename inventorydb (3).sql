-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Oct 28, 2026 at 09:15 AM
-- Server version: 8.0.46
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventorydb`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_account`
--

CREATE TABLE `tbl_account` (
  `acc_id` varchar(10) COLLATE utf8mb4_general_ci NOT NULL,
  `acc_name` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `user_name` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `pass_word` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `gender` varchar(10) COLLATE utf8mb4_general_ci NOT NULL,
  `acc_type` enum('Admin','Cashier','Inventory Staff','Manager') COLLATE utf8mb4_general_ci NOT NULL,
  `phone` varchar(20) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `email` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `user_status` varchar(10) COLLATE utf8mb4_general_ci NOT NULL DEFAULT 'Active',
  `created_at` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_account`
--

INSERT INTO `tbl_account` (`acc_id`, `acc_name`, `user_name`, `pass_word`, `gender`, `acc_type`, `phone`, `email`, `user_status`, `created_at`) VALUES
('ACC-001', 'Ashreiel Azucena', 'wailhi', '100000.gtF+APOSZUd8WUI53d/oVg==.qeiv1D28GhraEmGgttNoBL1iAn3jZt6RZ9988WjvAew=', 'Male', 'Admin', '09163983310', 'aashreiel@gmail.com', 'Active', '2026-09-15 12:34:49'),
('ACC-002', 'Marlon', 'akoni', '100000.TcCL7jiPcpNZPJDhE6f/mA==.xKW1XmZy8wgKp82yleK9mAds6xmXnXvRkyJCa8JBV4o=', 'Male', 'Manager', '0123456789', 'ash@gmail.com', 'Active', '2026-09-15 14:33:13'),
('ACC-005', 'Ashreiel Azucena', 'mechary', '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 'Male', 'Admin', '035926965', 'asjhdsjdhfj@gmail.com', 'Active', '2026-09-28 07:52:55');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_category`
--

CREATE TABLE `tbl_category` (
  `category_id` varchar(10) COLLATE utf8mb4_general_ci NOT NULL,
  `category_name` varchar(100) COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_category`
--

INSERT INTO `tbl_category` (`category_id`, `category_name`) VALUES
('CAT-0011', 'Baby Products'),
('CAT-0001', 'Beverages'),
('CAT-0005', 'Candies & Chocolates'),
('CAT-0004', 'Canned Goods'),
('CAT-0008', 'Cooking Essentials'),
('CAT-0006', 'Dairy & Chilled'),
('CAT-0007', 'Frozen Foods'),
('CAT-0010', 'Household'),
('CAT-0003', 'Instant Food'),
('CAT-0009', 'Personal Care'),
('CAT-0012', 'Pet Supplies'),
('CAT-0013', 'School & Office'),
('CAT-0002', 'Snacks');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_product`
--

CREATE TABLE `tbl_product` (
  `product_id` varchar(10) COLLATE utf8mb4_general_ci NOT NULL,
  `product_name` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `barcode` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `category_id` varchar(10) COLLATE utf8mb4_general_ci NOT NULL,
  `supplier_id` varchar(10) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `cost_price` decimal(12,2) NOT NULL DEFAULT '0.00',
  `selling_price` decimal(12,2) NOT NULL DEFAULT '0.00',
  `product_status` varchar(10) COLLATE utf8mb4_general_ci NOT NULL DEFAULT 'Active',
  `created_at` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_product`
--

INSERT INTO `tbl_product` (`product_id`, `product_name`, `barcode`, `category_id`, `supplier_id`, `cost_price`, `selling_price`, `product_status`, `created_at`) VALUES
('PRD-0001', 'Super crunch Special Chip-Charon', '4800365701088', 'CAT-0002', NULL, 25.00, 30.00, 'Active', '2026-09-15 12:41:31'),
('PRD-0002', 'Nature Spring (500ml)', '4800049720114', 'CAT-0001', NULL, 8.00, 10.00, 'Active', '2026-09-15 14:31:21'),
('PRD-0003', 'Joy Anti-Bact', '4902430468763', 'CAT-0010', NULL, 250.00, 300.00, 'Active', '2026-09-15 18:34:19'),
('PRD-0004', 'Mountain Dew 290ml', '4803925130328', 'CAT-0001', NULL, 20.00, 25.00, 'Active', '2026-10-12 15:39:33'),
('PRD-0005', 'C2 apple(230ml)', '4800016068010', 'CAT-0001', NULL, 15.00, 18.00, 'Active', '2026-10-22 08:22:02'),
('PRD-0006', 'Nature Spring(350ml)', '4800049720107', 'CAT-0001', NULL, 8.00, 10.00, 'Active', '2026-10-22 13:16:51'),
('PRD-0007', 'Pilot marker', '4902505088179', 'CAT-0013', NULL, 20.00, 25.00, 'Active', '2026-10-22 13:18:35'),
('PRD-0008', 'Creamline Cookies n Cream (1.3L)', '4806514104410', 'CAT-0006', NULL, 250.00, 290.00, 'Active', '2026-10-22 18:07:09'),
('PRD-0009', 'Magi Kari', '9556001309167', 'CAT-0003', NULL, 20.00, 25.00, 'Active', '2026-10-24 17:56:44');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_sale`
--

CREATE TABLE `tbl_sale` (
  `sale_id` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  `cashier_id` varchar(10) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `subtotal` decimal(12,2) NOT NULL DEFAULT '0.00',
  `discount_amount` decimal(12,2) NOT NULL DEFAULT '0.00',
  `discount_type` varchar(30) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `discount_approved_by` varchar(10) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `tax_amount` decimal(12,2) NOT NULL DEFAULT '0.00',
  `total_amount` decimal(12,2) NOT NULL DEFAULT '0.00',
  `amount_paid` decimal(12,2) NOT NULL DEFAULT '0.00',
  `change_due` decimal(12,2) NOT NULL DEFAULT '0.00',
  `payment_method` varchar(20) COLLATE utf8mb4_general_ci NOT NULL DEFAULT 'Cash',
  `sale_status` varchar(20) COLLATE utf8mb4_general_ci NOT NULL DEFAULT 'Completed',
  `created_at` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_sale`
--

INSERT INTO `tbl_sale` (`sale_id`, `cashier_id`, `subtotal`, `discount_amount`, `discount_type`, `discount_approved_by`, `tax_amount`, `total_amount`, `amount_paid`, `change_due`, `payment_method`, `sale_status`, `created_at`) VALUES
('SALE-000001', 'ACC-001', 90.00, 0.00, NULL, NULL, 0.00, 90.00, 1000.00, 910.00, 'Cash', 'Completed', '2026-09-15 12:43:21'),
('SALE-000002', 'ACC-001', 30.00, 0.00, NULL, NULL, 0.00, 30.00, 30.00, 0.00, 'Cash', 'Completed', '2026-09-15 12:50:29'),
('SALE-000003', 'ACC-001', 100.00, 20.00, 'Senior/PWD', 'ACC-002', 0.00, 80.00, 100.00, 20.00, 'Cash', 'Completed', '2026-09-15 14:39:13'),
('SALE-000004', 'ACC-001', 600.00, 0.00, NULL, NULL, 0.00, 600.00, 1000.00, 400.00, 'Cash', 'Completed', '2026-09-15 18:35:16'),
('SALE-000005', 'ACC-001', 30.00, 0.00, NULL, NULL, 0.00, 30.00, 35.00, 5.00, 'Cash', 'Completed', '2026-09-30 09:35:25'),
('SALE-000006', 'ACC-001', 10.00, 0.00, NULL, NULL, 1.20, 11.20, 200.00, 188.80, 'Cash', 'Completed', '2026-09-30 15:41:17'),
('SALE-000007', 'ACC-001', 20.00, 0.00, NULL, NULL, 2.40, 22.40, 25.00, 2.60, 'Cash', 'Completed', '2026-10-01 09:09:12'),
('SALE-000008', 'ACC-001', 40.00, 0.00, NULL, NULL, 4.80, 44.80, 50.00, 5.20, 'Cash', 'Completed', '2026-10-05 15:00:13'),
('SALE-000009', 'ACC-002', 40.00, 0.00, NULL, NULL, 4.80, 44.80, 50.00, 5.20, 'Cash', 'Completed', '2026-10-07 09:52:59'),
('SALE-000010', 'ACC-001', 325.00, 0.00, NULL, NULL, 39.00, 364.00, 400.00, 36.00, 'Cash', 'Completed', '2026-10-13 09:27:29'),
('SALE-000011', 'ACC-001', 80.00, 0.00, NULL, NULL, 9.60, 89.60, 100.00, 10.40, 'Cash', 'Completed', '2026-10-13 10:18:36'),
('SALE-000012', 'ACC-001', 325.00, 0.00, NULL, NULL, 39.00, 364.00, 400.00, 36.00, 'Cash', 'Completed', '2026-10-13 10:19:55'),
('SALE-000013', 'ACC-001', 55.00, 0.00, NULL, NULL, 6.60, 61.60, 70.00, 8.40, 'Cash', 'Completed', '2026-10-13 10:20:33'),
('SALE-000014', 'ACC-001', 85.00, 0.00, NULL, NULL, 10.20, 95.20, 100.00, 4.80, 'Cash', 'Completed', '2026-10-13 10:49:14'),
('SALE-000015', 'ACC-001', 385.00, 0.00, NULL, NULL, 46.20, 431.20, 500.00, 68.80, 'Cash', 'Completed', '2026-10-13 10:50:18'),
('SALE-000016', 'ACC-001', 655.00, 0.00, NULL, NULL, 78.60, 733.60, 1000.00, 266.40, 'Cash', 'Completed', '2026-10-13 11:08:58'),
('SALE-000017', 'ACC-001', 325.00, 0.00, NULL, NULL, 39.00, 364.00, 400.00, 36.00, 'Cash', 'Completed', '2026-10-13 11:38:41'),
('SALE-000018', 'ACC-001', 350.00, 0.00, NULL, NULL, 42.00, 392.00, 400.00, 8.00, 'Cash', 'Completed', '2026-10-13 11:44:01'),
('SALE-000019', 'ACC-001', 355.00, 0.00, NULL, NULL, 42.60, 397.60, 400.00, 2.40, 'Cash', 'Completed', '2026-10-13 11:56:05'),
('SALE-000020', 'ACC-001', 355.00, 0.00, NULL, NULL, 42.60, 397.60, 500.00, 102.40, 'Cash', 'Completed', '2026-10-13 11:58:29'),
('SALE-000021', 'ACC-001', 380.00, 0.00, NULL, NULL, 45.60, 425.60, 450.00, 24.40, 'Cash', 'Completed', '2026-10-14 09:49:42'),
('SALE-000022', 'ACC-001', 355.00, 0.00, NULL, NULL, 42.60, 397.60, 400.00, 2.40, 'Cash', 'Completed', '2026-10-14 09:51:19'),
('SALE-000023', 'ACC-001', 350.00, 0.00, NULL, NULL, 42.00, 392.00, 400.00, 8.00, 'Cash', 'Completed', '2026-10-14 09:52:44'),
('SALE-000024', 'ACC-001', 655.00, 0.00, NULL, NULL, 78.60, 733.60, 1000.00, 266.40, 'Cash', 'Completed', '2026-10-14 09:53:35'),
('SALE-000025', 'ACC-001', 355.00, 0.00, NULL, NULL, 42.60, 397.60, 400.00, 2.40, 'Cash', 'Completed', '2026-10-14 13:36:23'),
('SALE-000026', 'ACC-001', 415.00, 0.00, NULL, NULL, 49.80, 464.80, 500.00, 35.20, 'Cash', 'Completed', '2026-10-14 13:37:13'),
('SALE-000027', 'ACC-001', 55.00, 0.00, NULL, NULL, 6.60, 61.60, 70.00, 8.40, 'Cash', 'Completed', '2026-10-14 15:44:27'),
('SALE-000028', 'ACC-001', 355.00, 0.00, NULL, NULL, 42.60, 397.60, 500.00, 102.40, 'Cash', 'Completed', '2026-10-14 15:49:45'),
('SALE-000029', 'ACC-001', 50.00, 0.00, NULL, NULL, 6.00, 56.00, 60.00, 4.00, 'Cash', 'Completed', '2026-10-22 12:10:57'),
('SALE-000030', 'ACC-001', 100.00, 0.00, NULL, NULL, 12.00, 112.00, 113.00, 1.00, 'Cash', 'Completed', '2026-10-22 12:25:51'),
('SALE-000031', 'ACC-001', 150.00, 0.00, NULL, NULL, 18.00, 168.00, 170.00, 2.00, 'Cash', 'Completed', '2026-10-22 12:29:04'),
('SALE-000032', 'ACC-001', 100.00, 0.00, NULL, NULL, 12.00, 112.00, 120.00, 8.00, 'Cash', 'Completed', '2026-10-22 12:32:06'),
('SALE-000033', 'ACC-001', 775.00, 0.00, NULL, NULL, 93.00, 868.00, 1000.00, 132.00, 'Cash', 'Completed', '2026-10-22 13:19:35'),
('SALE-000034', 'ACC-001', 20.00, 0.00, NULL, NULL, 2.40, 22.40, 25.00, 2.60, 'Cash', 'Completed', '2026-10-22 14:11:52'),
('SALE-000035', 'ACC-001', 1000.00, 0.00, NULL, NULL, 120.00, 1120.00, 1500.00, 380.00, 'Cash', 'Completed', '2026-10-22 14:17:55'),
('SALE-000036', 'ACC-001', 75.00, 0.00, NULL, NULL, 9.00, 84.00, 100.00, 16.00, 'Cash', 'Completed', '2026-10-24 17:58:10'),
('SALE-000037', 'ACC-001', 315.00, 0.00, NULL, NULL, 37.80, 352.80, 500.00, 147.20, 'Cash', 'Completed', '2026-10-28 09:14:29'),
('SALE-000038', 'ACC-001', 25.00, 0.00, NULL, NULL, 3.00, 28.00, 65.00, 37.00, 'Cash', 'Completed', '2026-10-28 13:06:07');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_sale_item`
--

CREATE TABLE `tbl_sale_item` (
  `sale_item_id` bigint UNSIGNED NOT NULL,
  `sale_id` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  `product_id` varchar(10) COLLATE utf8mb4_general_ci NOT NULL,
  `quantity` int NOT NULL,
  `unit_price` decimal(12,2) NOT NULL,
  `line_discount` decimal(12,2) NOT NULL DEFAULT '0.00',
  `line_total` decimal(12,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_sale_item`
--

INSERT INTO `tbl_sale_item` (`sale_item_id`, `sale_id`, `product_id`, `quantity`, `unit_price`, `line_discount`, `line_total`) VALUES
(1, 'SALE-000001', 'PRD-0001', 3, 30.00, 0.00, 90.00),
(2, 'SALE-000002', 'PRD-0001', 1, 30.00, 0.00, 30.00),
(3, 'SALE-000003', 'PRD-0002', 10, 10.00, 0.00, 100.00),
(4, 'SALE-000004', 'PRD-0003', 2, 300.00, 0.00, 600.00),
(5, 'SALE-000005', 'PRD-0002', 3, 10.00, 0.00, 30.00),
(6, 'SALE-000006', 'PRD-0002', 1, 10.00, 0.00, 10.00),
(7, 'SALE-000007', 'PRD-0002', 2, 10.00, 0.00, 20.00),
(8, 'SALE-000008', 'PRD-0001', 1, 30.00, 0.00, 30.00),
(9, 'SALE-000008', 'PRD-0002', 1, 10.00, 0.00, 10.00),
(10, 'SALE-000009', 'PRD-0002', 1, 10.00, 0.00, 10.00),
(11, 'SALE-000009', 'PRD-0001', 1, 30.00, 0.00, 30.00),
(12, 'SALE-000010', 'PRD-0004', 1, 25.00, 0.00, 25.00),
(13, 'SALE-000010', 'PRD-0003', 1, 300.00, 0.00, 300.00),
(14, 'SALE-000011', 'PRD-0004', 2, 25.00, 0.00, 50.00),
(15, 'SALE-000011', 'PRD-0001', 1, 30.00, 0.00, 30.00),
(16, 'SALE-000012', 'PRD-0004', 1, 25.00, 0.00, 25.00),
(17, 'SALE-000012', 'PRD-0003', 1, 300.00, 0.00, 300.00),
(18, 'SALE-000013', 'PRD-0004', 1, 25.00, 0.00, 25.00),
(19, 'SALE-000013', 'PRD-0001', 1, 30.00, 0.00, 30.00),
(20, 'SALE-000014', 'PRD-0001', 2, 30.00, 0.00, 60.00),
(21, 'SALE-000014', 'PRD-0004', 1, 25.00, 0.00, 25.00),
(22, 'SALE-000015', 'PRD-0004', 1, 25.00, 0.00, 25.00),
(23, 'SALE-000015', 'PRD-0003', 1, 300.00, 0.00, 300.00),
(24, 'SALE-000015', 'PRD-0001', 2, 30.00, 0.00, 60.00),
(25, 'SALE-000016', 'PRD-0001', 1, 30.00, 0.00, 30.00),
(26, 'SALE-000016', 'PRD-0004', 1, 25.00, 0.00, 25.00),
(27, 'SALE-000016', 'PRD-0003', 2, 300.00, 0.00, 600.00),
(28, 'SALE-000017', 'PRD-0004', 1, 25.00, 0.00, 25.00),
(29, 'SALE-000017', 'PRD-0003', 1, 300.00, 0.00, 300.00),
(30, 'SALE-000018', 'PRD-0004', 2, 25.00, 0.00, 50.00),
(31, 'SALE-000018', 'PRD-0003', 1, 300.00, 0.00, 300.00),
(32, 'SALE-000019', 'PRD-0003', 1, 300.00, 0.00, 300.00),
(33, 'SALE-000019', 'PRD-0004', 1, 25.00, 0.00, 25.00),
(34, 'SALE-000019', 'PRD-0001', 1, 30.00, 0.00, 30.00),
(35, 'SALE-000020', 'PRD-0003', 1, 300.00, 0.00, 300.00),
(36, 'SALE-000020', 'PRD-0001', 1, 30.00, 0.00, 30.00),
(37, 'SALE-000020', 'PRD-0004', 1, 25.00, 0.00, 25.00),
(38, 'SALE-000021', 'PRD-0003', 1, 300.00, 0.00, 300.00),
(39, 'SALE-000021', 'PRD-0004', 2, 25.00, 0.00, 50.00),
(40, 'SALE-000021', 'PRD-0001', 1, 30.00, 0.00, 30.00),
(41, 'SALE-000022', 'PRD-0003', 1, 300.00, 0.00, 300.00),
(42, 'SALE-000022', 'PRD-0004', 1, 25.00, 0.00, 25.00),
(43, 'SALE-000022', 'PRD-0001', 1, 30.00, 0.00, 30.00),
(44, 'SALE-000023', 'PRD-0003', 1, 300.00, 0.00, 300.00),
(45, 'SALE-000023', 'PRD-0004', 2, 25.00, 0.00, 50.00),
(46, 'SALE-000024', 'PRD-0003', 2, 300.00, 0.00, 600.00),
(47, 'SALE-000024', 'PRD-0004', 1, 25.00, 0.00, 25.00),
(48, 'SALE-000024', 'PRD-0001', 1, 30.00, 0.00, 30.00),
(49, 'SALE-000025', 'PRD-0003', 1, 300.00, 0.00, 300.00),
(50, 'SALE-000025', 'PRD-0004', 1, 25.00, 0.00, 25.00),
(51, 'SALE-000025', 'PRD-0001', 1, 30.00, 0.00, 30.00),
(52, 'SALE-000026', 'PRD-0003', 1, 300.00, 0.00, 300.00),
(53, 'SALE-000026', 'PRD-0004', 1, 25.00, 0.00, 25.00),
(54, 'SALE-000026', 'PRD-0001', 3, 30.00, 0.00, 90.00),
(55, 'SALE-000027', 'PRD-0004', 1, 25.00, 0.00, 25.00),
(56, 'SALE-000027', 'PRD-0001', 1, 30.00, 0.00, 30.00),
(57, 'SALE-000028', 'PRD-0003', 1, 300.00, 0.00, 300.00),
(58, 'SALE-000028', 'PRD-0004', 1, 25.00, 0.00, 25.00),
(59, 'SALE-000028', 'PRD-0001', 1, 30.00, 0.00, 30.00),
(60, 'SALE-000029', 'PRD-0004', 2, 25.00, 0.00, 50.00),
(61, 'SALE-000030', 'PRD-0004', 4, 25.00, 0.00, 100.00),
(62, 'SALE-000031', 'PRD-0004', 6, 25.00, 0.00, 150.00),
(63, 'SALE-000032', 'PRD-0004', 4, 25.00, 0.00, 100.00),
(64, 'SALE-000033', 'PRD-0006', 5, 10.00, 0.00, 50.00),
(65, 'SALE-000033', 'PRD-0007', 29, 25.00, 0.00, 725.00),
(66, 'SALE-000034', 'PRD-0006', 2, 10.00, 0.00, 20.00),
(67, 'SALE-000035', 'PRD-0006', 100, 10.00, 0.00, 1000.00),
(68, 'SALE-000036', 'PRD-0009', 3, 25.00, 0.00, 75.00),
(69, 'SALE-000037', 'PRD-0008', 1, 290.00, 0.00, 290.00),
(70, 'SALE-000037', 'PRD-0004', 1, 25.00, 0.00, 25.00),
(71, 'SALE-000038', 'PRD-0009', 1, 25.00, 0.00, 25.00);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_stock`
--

CREATE TABLE `tbl_stock` (
  `stock_id` int UNSIGNED NOT NULL,
  `product_id` varchar(10) COLLATE utf8mb4_general_ci NOT NULL,
  `quantity` int NOT NULL DEFAULT '0',
  `low_stock_threshold` int NOT NULL DEFAULT '10',
  `updated_at` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `tbl_stock`
--

INSERT INTO `tbl_stock` (`stock_id`, `product_id`, `quantity`, `low_stock_threshold`, `updated_at`) VALUES
(1, 'PRD-0002', 48, 10, '2026-10-07 09:52:59'),
(2, 'PRD-0001', 6, 10, '2026-10-14 15:49:45'),
(3, 'PRD-0003', 151, 10, '2026-10-28 11:17:50'),
(7, 'PRD-0004', 110, 10, '2026-10-28 09:14:29'),
(8, 'PRD-0005', 250, 10, '2026-10-22 08:22:02'),
(9, 'PRD-0006', 133, 10, '2026-10-22 14:17:55'),
(10, 'PRD-0007', 201, 10, '2026-10-22 13:19:35'),
(11, 'PRD-0008', 249, 10, '2026-10-28 09:14:29'),
(12, 'PRD-0009', 496, 10, '2026-10-28 13:06:07');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_stock_log`
--

CREATE TABLE `tbl_stock_log` (
  `log_id` bigint UNSIGNED NOT NULL,
  `product_id` varchar(10) COLLATE utf8mb4_general_ci NOT NULL,
  `movement_type` enum('IN','OUT') COLLATE utf8mb4_general_ci NOT NULL,
  `reason` varchar(30) COLLATE utf8mb4_general_ci NOT NULL COMMENT 'PURCHASE, SALE, RETURN, DAMAGED, ADJUSTMENT, EXPIRED',
  `quantity` int NOT NULL,
  `batch_no` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `expiry_date` date DEFAULT NULL,
  `unit_cost` decimal(12,2) DEFAULT NULL,
  `supplier_id` varchar(10) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `reference_id` varchar(20) COLLATE utf8mb4_general_ci DEFAULT NULL COMMENT 'e.g. sale_id or PO number',
  `performed_by` varchar(10) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `remarks` varchar(255) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `created_at` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `tbl_stock_log`
--

INSERT INTO `tbl_stock_log` (`log_id`, `product_id`, `movement_type`, `reason`, `quantity`, `batch_no`, `expiry_date`, `unit_cost`, `supplier_id`, `reference_id`, `performed_by`, `remarks`, `created_at`) VALUES
(1, 'PRD-0001', 'IN', 'PURCHASE', 4, 'BATCH-20260915124131', '2026-09-23', 25.00, NULL, NULL, 'ACC-001', 'Initial stock on product creation', '2026-09-15 12:41:31'),
(2, 'PRD-0001', 'IN', 'PURCHASE', 1, 'BATCH-20260915125110', '2027-09-15', 25.00, NULL, NULL, 'ACC-001', 'Restock via Manage Product', '2026-09-15 12:51:10'),
(3, 'PRD-0002', 'IN', 'PURCHASE', 20, 'BATCH-20260915143121', '2027-09-15', 8.00, NULL, NULL, 'ACC-001', 'Initial stock on product creation', '2026-09-15 14:31:21'),
(4, 'PRD-0003', 'IN', 'PURCHASE', 25, 'BATCH-20260915183419', '2027-09-15', 250.00, NULL, NULL, 'ACC-001', 'Initial stock on product creation', '2026-09-15 18:34:19'),
(8, 'PRD-0001', 'OUT', 'SALE', 3, NULL, NULL, NULL, NULL, 'SALE-000001', 'ACC-001', 'POS sale', '2026-09-15 12:43:21'),
(9, 'PRD-0001', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000002', 'ACC-001', 'POS sale', '2026-09-15 12:50:29'),
(10, 'PRD-0002', 'OUT', 'SALE', 10, NULL, NULL, NULL, NULL, 'SALE-000003', 'ACC-001', 'POS sale', '2026-09-15 14:39:13'),
(11, 'PRD-0003', 'OUT', 'SALE', 2, NULL, NULL, NULL, NULL, 'SALE-000004', 'ACC-001', 'POS sale', '2026-09-15 18:35:16'),
(12, 'PRD-0002', 'OUT', 'DAMAGED', 4, NULL, NULL, NULL, NULL, NULL, 'ACC-001', 'broken cap', '2026-09-17 17:50:07'),
(15, 'PRD-0003', 'OUT', 'DAMAGED', 3, NULL, NULL, NULL, NULL, NULL, 'ACC-001', NULL, '2026-09-21 15:57:48'),
(16, 'PRD-0001', 'IN', 'RECOUNT', 25, NULL, NULL, NULL, NULL, NULL, 'ACC-001', NULL, '2026-09-28 08:28:30'),
(17, 'PRD-0002', 'OUT', 'SALE', 3, NULL, NULL, NULL, NULL, 'SALE-000005', 'ACC-001', 'POS sale', '2026-09-30 09:35:25'),
(18, 'PRD-0002', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000006', 'ACC-001', 'POS sale', '2026-09-30 15:41:17'),
(19, 'PRD-0002', 'OUT', 'SALE', 2, NULL, NULL, NULL, NULL, 'SALE-000007', 'ACC-001', 'POS sale', '2026-10-01 09:09:12'),
(20, 'PRD-0002', 'IN', 'ADJUSTMENT', 50, NULL, NULL, NULL, NULL, NULL, 'ACC-001', NULL, '2026-10-02 07:06:10'),
(21, 'PRD-0001', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000008', 'ACC-001', 'POS sale', '2026-10-05 15:00:13'),
(22, 'PRD-0002', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000008', 'ACC-001', 'POS sale', '2026-10-05 15:00:13'),
(23, 'PRD-0002', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000009', 'ACC-002', 'Sale #SALE-000009', '2026-10-07 09:52:59'),
(24, 'PRD-0001', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000009', 'ACC-002', 'Sale #SALE-000009', '2026-10-07 09:52:59'),
(25, 'PRD-0004', 'IN', 'PURCHASE', 150, 'BATCH-20261012153933', '2028-01-19', 20.00, NULL, NULL, 'ACC-001', 'Initial stock via Manage Stock', '2026-10-12 15:39:33'),
(26, 'PRD-0004', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000010', 'ACC-001', 'POS sale', '2026-10-13 09:27:29'),
(27, 'PRD-0003', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000010', 'ACC-001', 'POS sale', '2026-10-13 09:27:29'),
(28, 'PRD-0004', 'OUT', 'SALE', 2, NULL, NULL, NULL, NULL, 'SALE-000011', 'ACC-001', 'POS sale', '2026-10-13 10:18:36'),
(29, 'PRD-0001', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000011', 'ACC-001', 'POS sale', '2026-10-13 10:18:36'),
(30, 'PRD-0004', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000012', 'ACC-001', 'POS sale', '2026-10-13 10:19:55'),
(31, 'PRD-0003', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000012', 'ACC-001', 'POS sale', '2026-10-13 10:19:55'),
(32, 'PRD-0004', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000013', 'ACC-001', 'POS sale', '2026-10-13 10:20:33'),
(33, 'PRD-0001', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000013', 'ACC-001', 'POS sale', '2026-10-13 10:20:33'),
(34, 'PRD-0001', 'OUT', 'SALE', 2, NULL, NULL, NULL, NULL, 'SALE-000014', 'ACC-001', 'POS sale', '2026-10-13 10:49:14'),
(35, 'PRD-0004', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000014', 'ACC-001', 'POS sale', '2026-10-13 10:49:14'),
(36, 'PRD-0004', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000015', 'ACC-001', 'POS sale', '2026-10-13 10:50:18'),
(37, 'PRD-0003', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000015', 'ACC-001', 'POS sale', '2026-10-13 10:50:18'),
(38, 'PRD-0001', 'OUT', 'SALE', 2, NULL, NULL, NULL, NULL, 'SALE-000015', 'ACC-001', 'POS sale', '2026-10-13 10:50:18'),
(39, 'PRD-0001', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000016', 'ACC-001', 'POS sale', '2026-10-13 11:08:58'),
(40, 'PRD-0004', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000016', 'ACC-001', 'POS sale', '2026-10-13 11:08:58'),
(41, 'PRD-0003', 'OUT', 'SALE', 2, NULL, NULL, NULL, NULL, 'SALE-000016', 'ACC-001', 'POS sale', '2026-10-13 11:08:58'),
(42, 'PRD-0004', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000017', 'ACC-001', 'POS sale', '2026-10-13 11:38:41'),
(43, 'PRD-0003', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000017', 'ACC-001', 'POS sale', '2026-10-13 11:38:41'),
(44, 'PRD-0004', 'OUT', 'SALE', 2, NULL, NULL, NULL, NULL, 'SALE-000018', 'ACC-001', 'POS sale', '2026-10-13 11:44:01'),
(45, 'PRD-0003', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000018', 'ACC-001', 'POS sale', '2026-10-13 11:44:01'),
(46, 'PRD-0003', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000019', 'ACC-001', 'POS sale', '2026-10-13 11:56:05'),
(47, 'PRD-0004', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000019', 'ACC-001', 'POS sale', '2026-10-13 11:56:05'),
(48, 'PRD-0001', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000019', 'ACC-001', 'POS sale', '2026-10-13 11:56:05'),
(49, 'PRD-0003', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000020', 'ACC-001', 'POS sale', '2026-10-13 11:58:29'),
(50, 'PRD-0001', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000020', 'ACC-001', 'POS sale', '2026-10-13 11:58:29'),
(51, 'PRD-0004', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000020', 'ACC-001', 'POS sale', '2026-10-13 11:58:29'),
(52, 'PRD-0003', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000021', 'ACC-001', 'POS sale', '2026-10-14 09:49:42'),
(53, 'PRD-0004', 'OUT', 'SALE', 2, NULL, NULL, NULL, NULL, 'SALE-000021', 'ACC-001', 'POS sale', '2026-10-14 09:49:42'),
(54, 'PRD-0001', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000021', 'ACC-001', 'POS sale', '2026-10-14 09:49:42'),
(55, 'PRD-0003', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000022', 'ACC-001', 'POS sale', '2026-10-14 09:51:19'),
(56, 'PRD-0004', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000022', 'ACC-001', 'POS sale', '2026-10-14 09:51:19'),
(57, 'PRD-0001', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000022', 'ACC-001', 'POS sale', '2026-10-14 09:51:19'),
(58, 'PRD-0003', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000023', 'ACC-001', 'POS sale', '2026-10-14 09:52:44'),
(59, 'PRD-0004', 'OUT', 'SALE', 2, NULL, NULL, NULL, NULL, 'SALE-000023', 'ACC-001', 'POS sale', '2026-10-14 09:52:44'),
(60, 'PRD-0003', 'OUT', 'SALE', 2, NULL, NULL, NULL, NULL, 'SALE-000024', 'ACC-001', 'POS sale', '2026-10-14 09:53:35'),
(61, 'PRD-0004', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000024', 'ACC-001', 'POS sale', '2026-10-14 09:53:35'),
(62, 'PRD-0001', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000024', 'ACC-001', 'POS sale', '2026-10-14 09:53:35'),
(63, 'PRD-0003', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000025', 'ACC-001', 'POS sale', '2026-10-14 13:36:23'),
(64, 'PRD-0004', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000025', 'ACC-001', 'POS sale', '2026-10-14 13:36:23'),
(65, 'PRD-0001', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000025', 'ACC-001', 'POS sale', '2026-10-14 13:36:23'),
(66, 'PRD-0003', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000026', 'ACC-001', 'POS sale', '2026-10-14 13:37:13'),
(67, 'PRD-0004', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000026', 'ACC-001', 'POS sale', '2026-10-14 13:37:13'),
(68, 'PRD-0001', 'OUT', 'SALE', 3, NULL, NULL, NULL, NULL, 'SALE-000026', 'ACC-001', 'POS sale', '2026-10-14 13:37:13'),
(69, 'PRD-0004', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000027', 'ACC-001', 'POS sale', '2026-10-14 15:44:27'),
(70, 'PRD-0001', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000027', 'ACC-001', 'POS sale', '2026-10-14 15:44:27'),
(71, 'PRD-0003', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000028', 'ACC-001', 'POS sale', '2026-10-14 15:49:45'),
(72, 'PRD-0004', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000028', 'ACC-001', 'POS sale', '2026-10-14 15:49:45'),
(73, 'PRD-0001', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000028', 'ACC-001', 'POS sale', '2026-10-14 15:49:45'),
(74, 'PRD-0005', 'IN', 'PURCHASE', 250, 'BATCH-20261022082202', '2026-12-17', 15.00, NULL, NULL, 'ACC-001', 'Initial stock via Manage Stock', '2026-10-22 08:22:02'),
(75, 'PRD-0004', 'OUT', 'SALE', 2, NULL, NULL, NULL, NULL, 'SALE-000029', 'ACC-001', 'POS sale', '2026-10-22 12:10:57'),
(76, 'PRD-0004', 'OUT', 'SALE', 4, NULL, NULL, NULL, NULL, 'SALE-000030', 'ACC-001', 'POS sale', '2026-10-22 12:25:51'),
(77, 'PRD-0004', 'OUT', 'SALE', 6, NULL, NULL, NULL, NULL, 'SALE-000031', 'ACC-001', 'POS sale', '2026-10-22 12:29:04'),
(78, 'PRD-0004', 'OUT', 'SALE', 4, NULL, NULL, NULL, NULL, 'SALE-000032', 'ACC-001', 'POS sale', '2026-10-22 12:32:06'),
(79, 'PRD-0006', 'IN', 'PURCHASE', 240, 'BATCH-20261022131651', '2027-10-22', 8.00, NULL, NULL, 'ACC-001', 'Initial stock via Manage Stock', '2026-10-22 13:16:51'),
(80, 'PRD-0007', 'IN', 'PURCHASE', 230, 'BATCH-20261022131835', '2027-10-22', 20.00, NULL, NULL, 'ACC-001', 'Initial stock via Manage Stock', '2026-10-22 13:18:35'),
(81, 'PRD-0006', 'OUT', 'SALE', 5, NULL, NULL, NULL, NULL, 'SALE-000033', 'ACC-001', 'POS sale', '2026-10-22 13:19:35'),
(82, 'PRD-0007', 'OUT', 'SALE', 29, NULL, NULL, NULL, NULL, 'SALE-000033', 'ACC-001', 'POS sale', '2026-10-22 13:19:35'),
(83, 'PRD-0006', 'OUT', 'SALE', 2, NULL, NULL, NULL, NULL, 'SALE-000034', 'ACC-001', 'POS sale', '2026-10-22 14:11:52'),
(84, 'PRD-0006', 'OUT', 'SALE', 100, NULL, NULL, NULL, NULL, 'SALE-000035', 'ACC-001', 'POS sale', '2026-10-22 14:17:55'),
(85, 'PRD-0008', 'IN', 'PURCHASE', 250, 'BATCH-20261022180709', '2027-12-16', 250.00, NULL, NULL, 'ACC-001', 'Initial stock via Manage Stock', '2026-10-22 18:07:09'),
(86, 'PRD-0009', 'IN', 'PURCHASE', 500, 'BATCH-20261024175644', '2027-12-24', 20.00, NULL, NULL, 'ACC-001', 'Initial stock via Manage Stock', '2026-10-24 17:56:44'),
(87, 'PRD-0009', 'OUT', 'SALE', 3, NULL, NULL, NULL, NULL, 'SALE-000036', 'ACC-001', 'POS sale', '2026-10-24 17:58:10'),
(88, 'PRD-0008', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000037', 'ACC-001', 'POS sale', '2026-10-28 09:14:29'),
(89, 'PRD-0004', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000037', 'ACC-001', 'POS sale', '2026-10-28 09:14:29'),
(90, 'PRD-0003', 'OUT', 'DAMAGED', 2, NULL, NULL, 250.00, NULL, NULL, 'ACC-001', 'punctured casing', '2026-10-28 10:19:19'),
(91, 'PRD-0003', 'IN', 'ADJUSTMENT', 150, NULL, NULL, NULL, NULL, NULL, 'ACC-001', NULL, '2026-10-28 11:17:50'),
(92, 'PRD-0009', 'OUT', 'SALE', 1, NULL, NULL, NULL, NULL, 'SALE-000038', 'ACC-001', 'POS sale', '2026-10-28 13:06:07');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_supplier`
--

CREATE TABLE `tbl_supplier` (
  `supplier_id` varchar(10) COLLATE utf8mb4_general_ci NOT NULL,
  `supplier_name` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `contact_person` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `phone` varchar(20) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `email` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `address` varchar(255) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `created_at` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_supplier`
--

INSERT INTO `tbl_supplier` (`supplier_id`, `supplier_name`, `contact_person`, `phone`, `email`, `address`, `created_at`) VALUES
('SUP-0001', 'Creamline Creamy Ice Cream', 'Jonathan Ng', '09556896549', 'asjeyojrhh@fmail.com', 'philippines', '2026-10-28 14:35:05');

-- --------------------------------------------------------

--
-- Stand-in structure for view `vw_product_stock`
-- (See below for the actual view)
--
CREATE TABLE `vw_product_stock` (
`product_id` varchar(10)
,`current_quantity` int
);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_account`
--
ALTER TABLE `tbl_account`
  ADD PRIMARY KEY (`acc_id`),
  ADD UNIQUE KEY `uq_account_username` (`user_name`);

--
-- Indexes for table `tbl_category`
--
ALTER TABLE `tbl_category`
  ADD PRIMARY KEY (`category_id`),
  ADD UNIQUE KEY `uq_category_name` (`category_name`);

--
-- Indexes for table `tbl_product`
--
ALTER TABLE `tbl_product`
  ADD PRIMARY KEY (`product_id`),
  ADD UNIQUE KEY `uq_product_barcode` (`barcode`),
  ADD KEY `fk_product_category` (`category_id`),
  ADD KEY `fk_product_supplier` (`supplier_id`);

--
-- Indexes for table `tbl_sale`
--
ALTER TABLE `tbl_sale`
  ADD PRIMARY KEY (`sale_id`),
  ADD KEY `fk_sale_cashier` (`cashier_id`),
  ADD KEY `idx_sale_created` (`created_at`),
  ADD KEY `idx_sale_discount_approver` (`discount_approved_by`);

--
-- Indexes for table `tbl_sale_item`
--
ALTER TABLE `tbl_sale_item`
  ADD PRIMARY KEY (`sale_item_id`),
  ADD KEY `idx_saleitem_sale` (`sale_id`),
  ADD KEY `idx_saleitem_product` (`product_id`);

--
-- Indexes for table `tbl_stock`
--
ALTER TABLE `tbl_stock`
  ADD PRIMARY KEY (`stock_id`) USING BTREE,
  ADD UNIQUE KEY `uq_stock_product` (`product_id`) USING BTREE;

--
-- Indexes for table `tbl_stock_log`
--
ALTER TABLE `tbl_stock_log`
  ADD PRIMARY KEY (`log_id`) USING BTREE,
  ADD KEY `idx_stocklog_product` (`product_id`) USING BTREE,
  ADD KEY `idx_stocklog_expiry` (`expiry_date`) USING BTREE,
  ADD KEY `fk_stocklog_supplier` (`supplier_id`) USING BTREE,
  ADD KEY `fk_stocklog_account` (`performed_by`) USING BTREE;

--
-- Indexes for table `tbl_supplier`
--
ALTER TABLE `tbl_supplier`
  ADD PRIMARY KEY (`supplier_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_sale_item`
--
ALTER TABLE `tbl_sale_item`
  MODIFY `sale_item_id` bigint UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=72;

--
-- AUTO_INCREMENT for table `tbl_stock`
--
ALTER TABLE `tbl_stock`
  MODIFY `stock_id` int UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `tbl_stock_log`
--
ALTER TABLE `tbl_stock_log`
  MODIFY `log_id` bigint UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=93;

-- --------------------------------------------------------

--
-- Structure for view `vw_product_stock`
--
DROP TABLE IF EXISTS `vw_product_stock`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_product_stock`  AS SELECT `s`.`product_id` AS `product_id`, `s`.`quantity` AS `current_quantity` FROM `tbl_stock` AS `s` ;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_product`
--
ALTER TABLE `tbl_product`
  ADD CONSTRAINT `fk_product_category` FOREIGN KEY (`category_id`) REFERENCES `tbl_category` (`category_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_product_supplier` FOREIGN KEY (`supplier_id`) REFERENCES `tbl_supplier` (`supplier_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tbl_sale`
--
ALTER TABLE `tbl_sale`
  ADD CONSTRAINT `fk_sale_cashier` FOREIGN KEY (`cashier_id`) REFERENCES `tbl_account` (`acc_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_sale_discount_approver` FOREIGN KEY (`discount_approved_by`) REFERENCES `tbl_account` (`acc_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tbl_sale_item`
--
ALTER TABLE `tbl_sale_item`
  ADD CONSTRAINT `fk_saleitem_product` FOREIGN KEY (`product_id`) REFERENCES `tbl_product` (`product_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_saleitem_sale` FOREIGN KEY (`sale_id`) REFERENCES `tbl_sale` (`sale_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_stock`
--
ALTER TABLE `tbl_stock`
  ADD CONSTRAINT `fk_stock_product` FOREIGN KEY (`product_id`) REFERENCES `tbl_product` (`product_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_stock_log`
--
ALTER TABLE `tbl_stock_log`
  ADD CONSTRAINT `fk_stocklog_account` FOREIGN KEY (`performed_by`) REFERENCES `tbl_account` (`acc_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_stocklog_product` FOREIGN KEY (`product_id`) REFERENCES `tbl_product` (`product_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_stocklog_supplier` FOREIGN KEY (`supplier_id`) REFERENCES `tbl_supplier` (`supplier_id`) ON DELETE SET NULL ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
