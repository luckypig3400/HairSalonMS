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
-- Table structure for t_department
-- ----------------------------
DROP TABLE IF EXISTS `t_department`;
CREATE TABLE `t_department`  (
  `departmentNo` bigint(0) NOT NULL COMMENT '部門編號',
  `deptName` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '部門名稱',
  `address` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '部門地址',
  `empNumber` int(0) NULL DEFAULT 0 COMMENT '部門員工人數',
  `telephone` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '部門電話',
  PRIMARY KEY (`departmentNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_department
-- ----------------------------
INSERT INTO `t_department` VALUES (1015, '電計系體育部', '學院辦公樓1樓105', 1, '6106067');
INSERT INTO `t_department` VALUES (1031, '電計係人事部', '系辦公樓2樓206', 1, '6106066');
INSERT INTO `t_department` VALUES (1066, '核能係辦公室', '學院辦公樓3樓301', 0, '6106088');
INSERT INTO `t_department` VALUES (1101, '電計系辦公室', '學院辦公樓2樓202', 8, '6106063');
INSERT INTO `t_department` VALUES (1106, '電計系教師辦公室', '學院辦公樓3樓301', 1, '6106068');

-- ----------------------------
-- Table structure for t_employee
-- ----------------------------
DROP TABLE IF EXISTS `t_employee`;
CREATE TABLE `t_employee`  (
  `empNo` bigint(0) NOT NULL COMMENT '教職工編號',
  `departmentNo` bigint(0) NULL DEFAULT NULL COMMENT '部門編號',
  `name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '姓名',
  `gender` enum('男','女') CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '性別',
  `age` int(0) NULL DEFAULT NULL COMMENT '年齡',
  `nativePlace` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '籍貫',
  `IDcardNo` varchar(0) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '身份證號',
  `bankCardNo` varchar(0) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '銀行卡號',
  PRIMARY KEY (`empNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for t_family
-- ----------------------------
DROP TABLE IF EXISTS `t_family`;
CREATE TABLE `t_family`  (
  `empNo` bigint(0) NOT NULL COMMENT '員工編號',
  `familyMemberName` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '家庭成員名',
  `relationship` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '關係',
  `telephone` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '電話',
  PRIMARY KEY (`empNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

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
INSERT INTO `t_rolepower` VALUES ('教師', 0, 0, 0, 0, 0, 0, 1, 0);
INSERT INTO `t_rolepower` VALUES ('教職工', 0, 0, 0, 0, 0, 0, 1, 0);
INSERT INTO `t_rolepower` VALUES ('管理員', 1, 1, 1, 1, 1, 0, 0, 0);
INSERT INTO `t_rolepower` VALUES ('系統管理員', 1, 1, 1, 1, 1, 0, 0, 1);
INSERT INTO `t_rolepower` VALUES ('遊客', 0, 0, 0, 0, 0, 1, 0, 0);

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
-- Table structure for t_teacher
-- ----------------------------
DROP TABLE IF EXISTS `t_teacher`;
CREATE TABLE `t_teacher`  (
  `teacherNo` bigint(0) NOT NULL COMMENT '教師編號',
  `departmentNo` bigint(0) NULL DEFAULT NULL COMMENT '所在部門編號',
  `name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '姓名',
  `gender` enum('男','女') CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '性別',
  `age` int(0) NULL DEFAULT NULL COMMENT '年齡',
  `stuStatus` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '學籍',
  `education` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '學歷',
  `birthday` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '生日',
  `teaching` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '授課科目',
  `IDcardNo` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '身份證號',
  `bankCardNo` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '銀行卡號',
  `status` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL COMMENT '在職狀態',
  PRIMARY KEY (`teacherNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_teacher
-- ----------------------------
INSERT INTO `t_teacher` VALUES (20201529, 1031, '張凱', '男', 30, '清華大學', '博士', '1990/6/1', '物理', '555555555555555555', '666666666666666666', '在職');
INSERT INTO `t_teacher` VALUES (20201568, 1015, '王陽', '男', 43, '成都理工大學', '碩士', '1975/10/1', '大學體育', '885555555555555555', '622255454534534555', '在職');
INSERT INTO `t_teacher` VALUES (20209902, 1031, '劉洋', '女', 34, '西南大學', '碩士', '1982/2/10', '心理學', '545357221553645535', '622545345345345344', '在職');

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
INSERT INTO `t_user` VALUES ('小劉', '123', '888@163.com', '教師', 20209902);
INSERT INTO `t_user` VALUES ('小明', '123', '456465@163.com', '遊客', NULL);
INSERT INTO `t_user` VALUES ('小王', '123', '88888@163.com', '教師', 20201568);
INSERT INTO `t_user` VALUES ('小張', '123', '156@163.com', '教師', 20201529);

-- ----------------------------
-- Triggers structure for table t_teacher
-- ----------------------------
DROP TRIGGER IF EXISTS `teaAllInfo_t`;
delimiter ;;
CREATE TRIGGER `teaAllInfo_t` AFTER INSERT ON `t_teacher` FOR EACH ROW BEGIN
INSERT INTO t_attendance
VALUES (NEW.teacherNo,22,0,0,0,0,0);
INSERT INTO t_salary
VALUES (NEW.teacherNo,5000,0,0,0,0,0,0,0);
UPDATE t_department SET empNumber=empNumber+1 
WHERE departmentNo=NEW.departmentNo;

END
;;
delimiter ;

SET FOREIGN_KEY_CHECKS = 1;
