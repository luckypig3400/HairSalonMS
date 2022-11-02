/*
 Navicat Premium Data Transfer

 Source Server         : mysql
 Source Server Type    : MySQL
 Source Server Version : 80019
 Source Host           : localhost:3306
 Source Schema         : csharp_hrms

 Target Server Type    : MySQL
 Target Server Version : 80019
 File Encoding         : 65001

 Date: 11/01/2021 19:06:12
*/
create database csharp_hair_salon_ms;
use csharp_hair_salon_ms;
SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for t_attendance
-- ----------------------------
DROP TABLE IF EXISTS `t_attendance`;
CREATE TABLE `t_attendance`  (
  `empNo` bigint(0) NOT NULL COMMENT '員工編號',
  `attendanceDays` int(0) NULL DEFAULT NULL COMMENT '應出勤天數',
  `actualDays` int(0) NULL DEFAULT NULL COMMENT '實際出勤天數',
  `overtimeHours` int(0) NULL DEFAULT NULL COMMENT '加班小時數',
  `lateNumber` int(0) NULL DEFAULT NULL COMMENT '遲到次數',
  `earlyLeaveNumber` int(0) NULL DEFAULT NULL COMMENT '早退次數',
  `absenteeism` int(0) NULL DEFAULT NULL COMMENT '曠到次數',
  PRIMARY KEY (`empNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_attendance
-- ----------------------------
INSERT INTO `t_attendance` VALUES (20201529, 22, 22, 40, 2, 1, 0);
INSERT INTO `t_attendance` VALUES (20201568, 22, 22, 8, 0, 0, 0);
INSERT INTO `t_attendance` VALUES (20209902, 22, 0, 0, 0, 0, 0);

-- ----------------------------
-- Table structure for t_rolepower
-- ----------------------------
DROP TABLE IF EXISTS `t_rolepower`;
CREATE TABLE `t_rolepower`  (
  `role` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `manage_dept` tinyint(1) NOT NULL DEFAULT 0,
  `manage_teacher` tinyint(1) NOT NULL DEFAULT 0,
  `manage_emp` tinyint(1) NOT NULL DEFAULT 0,
  `manege_attendance` tinyint(1) NOT NULL DEFAULT 0,
  `manage_salary` tinyint(1) NOT NULL DEFAULT 0,
  `apply` tinyint(1) NOT NULL DEFAULT 0,
  `personalInfo` tinyint(1) NOT NULL DEFAULT 0,
  `managesystem` tinyint(1) NOT NULL DEFAULT 0
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_rolepower
-- ----------------------------
INSERT INTO `t_rolepower` VALUES ('員工', 0, 0, 0, 0, 0, 0, 1, 0);
INSERT INTO `t_rolepower` VALUES ('管理員', 1, 1, 1, 1, 1, 0, 0, 0);
INSERT INTO `t_rolepower` VALUES ('系統管理員', 1, 1, 1, 1, 1, 0, 0, 1);


-- ----------------------------
-- Table structure for t_salary
-- ----------------------------
DROP TABLE IF EXISTS `t_salary`;
CREATE TABLE `t_salary`  (
  `empNo` bigint(0) NOT NULL COMMENT '員工編號',
  `baseSalary` decimal(10, 2) NULL DEFAULT NULL COMMENT '底薪',
  `bonus` decimal(10, 2) NULL DEFAULT NULL COMMENT '獎金',
  `subsidies` decimal(10, 2) NULL DEFAULT NULL COMMENT '補貼',
  `overtimePay` decimal(10, 2) NULL DEFAULT NULL COMMENT '加班費',
  `deductPay` decimal(10, 2) NULL DEFAULT NULL COMMENT '應扣工資',
  `salary` decimal(10, 2) NULL DEFAULT NULL COMMENT '應發工資',
  `rate` double(10, 2) NULL DEFAULT NULL COMMENT '稅率',
  `realSalary` decimal(10, 2) NULL DEFAULT NULL COMMENT '實發工資',
  PRIMARY KEY (`empNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_salary
-- ----------------------------
INSERT INTO `t_salary` VALUES (20201529, 5000.00, 500.00, 500.00, 2000.00, 100.00, 7950.00, 0.06, 7502.00);
INSERT INTO `t_salary` VALUES (20201568, 5000.00, 500.00, 0.00, 500.00, 0.00, 6000.00, 0.00, 6000.00);
INSERT INTO `t_salary` VALUES (20209902, 5000.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00);

-- ----------------------------
-- Table structure for t_employee
-- ----------------------------
DROP TABLE IF EXISTS `employee`;
CREATE TABLE `t_employee`  (
  `empNo` bigint(0) NOT NULL COMMENT '員工編號',
  `name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '姓名',
  `gender` enum('男','女') CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '性別',
  `age` int(0) NULL DEFAULT NULL COMMENT '年齡',
  `IDcardNo` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '身份證號',
  `bankCardNo` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '匯款帳號',
  `status` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '在職狀態',
  PRIMARY KEY (`empNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_employee
-- ----------------------------
INSERT INTO `t_employee` VALUES (20201529 , '張凱', '男', 30, '555555555555555555', '666666666666666666', '在職');
INSERT INTO `t_employee` VALUES (20201568 , '王陽', '男', 43, '885555555555555555', '622255454534534555', '在職');
INSERT INTO `t_employee` VALUES (20209902, '劉洋', '女', 34,  '545357221553645535', '622545345345345344', '在職');

-- ----------------------------
-- Table structure for t_user
-- ----------------------------
DROP TABLE IF EXISTS `t_user`;
CREATE TABLE `t_user`  (
  `username` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL COMMENT '用戶名',
  `password` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL COMMENT '密碼',
  `email` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL COMMENT '郵箱',
  `role` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL COMMENT '角色',
  `empNo` bigint(0) NULL DEFAULT NULL COMMENT '員工編號',
  PRIMARY KEY (`username`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_user
-- ----------------------------
INSERT INTO `t_user` VALUES ('admin', '123', '123456@qq.com', '管理員', NULL);
INSERT INTO `t_user` VALUES ('root', '123', '162.163.com', '系統管理員', NULL);
INSERT INTO `t_user` VALUES ('小劉', '123', '888@163.com', '員工', 20209902);

-- ----------------------------
-- Triggers structure for table t_employee
-- ----------------------------
DROP TRIGGER IF EXISTS `teaAllInfo_t`;
delimiter ;;
CREATE TRIGGER `teaAllInfo_t` AFTER INSERT ON `t_employee` FOR EACH ROW BEGIN
INSERT INTO t_attendance
VALUES (NEW.empNo,22,0,0,0,0,0);
INSERT INTO t_salary
VALUES (NEW.empNo,5000,0,0,0,0,0,0,0);


END
;;
delimiter ;

SET FOREIGN_KEY_CHECKS = 1;
