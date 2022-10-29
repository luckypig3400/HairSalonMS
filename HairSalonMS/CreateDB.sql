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
create database csharp_hrms;
use csharp_hrms;
SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for t_attendance
-- ----------------------------
DROP TABLE IF EXISTS `t_attendance`;
CREATE TABLE `t_attendance`  (
  `empNo` bigint(0) NOT NULL COMMENT '员工编号',
  `attendanceDays` int(0) NULL DEFAULT NULL COMMENT '应出勤天数',
  `actualDays` int(0) NULL DEFAULT NULL COMMENT '实际出勤天数',
  `overtimeHours` int(0) NULL DEFAULT NULL COMMENT '加班小时数',
  `lateNumber` int(0) NULL DEFAULT NULL COMMENT '迟到次数',
  `earlyLeaveNumber` int(0) NULL DEFAULT NULL COMMENT '早退次数',
  `absenteeism` int(0) NULL DEFAULT NULL COMMENT '旷到次数',
  PRIMARY KEY (`empNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = gb2312 COLLATE = gb2312_chinese_ci ROW_FORMAT = Dynamic;

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
  `departmentNo` bigint(0) NOT NULL COMMENT '部门编号',
  `deptName` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL COMMENT '部门名称',
  `address` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL COMMENT '部门地址',
  `empNumber` int(0) NULL DEFAULT 0 COMMENT '部门员工人数',
  `telephone` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL COMMENT '部门电话',
  PRIMARY KEY (`departmentNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = gb2312 COLLATE = gb2312_chinese_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_department
-- ----------------------------
INSERT INTO `t_department` VALUES (1015, '电计系体育部', '学院办公楼1楼105', 1, '6106067');
INSERT INTO `t_department` VALUES (1031, '电计系人事部', '系办公楼2楼206', 1, '6106066');
INSERT INTO `t_department` VALUES (1066, '核能系办公室', '学院办公楼3楼301', 0, '6106088');
INSERT INTO `t_department` VALUES (1101, '电计系办公室', '学院办公楼2楼202', 8, '6106063');
INSERT INTO `t_department` VALUES (1106, '电计系教师办公室', '学院办公楼3楼301', 1, '6106068');

-- ----------------------------
-- Table structure for t_employee
-- ----------------------------
DROP TABLE IF EXISTS `t_employee`;
CREATE TABLE `t_employee`  (
  `empNo` bigint(0) NOT NULL COMMENT '教职工编号',
  `departmentNo` bigint(0) NULL DEFAULT NULL COMMENT '部门编号',
  `name` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL COMMENT '姓名',
  `gender` enum('男','女') CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL COMMENT '性别',
  `age` int(0) NULL DEFAULT NULL COMMENT '年龄',
  `nativePlace` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL COMMENT '籍贯',
  `IDcardNo` varchar(0) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL COMMENT '身份证号',
  `bankCardNo` varchar(0) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL COMMENT '银行卡号',
  PRIMARY KEY (`empNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = gb2312 COLLATE = gb2312_chinese_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for t_family
-- ----------------------------
DROP TABLE IF EXISTS `t_family`;
CREATE TABLE `t_family`  (
  `empNo` bigint(0) NOT NULL COMMENT '员工编号',
  `familyMemberName` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL COMMENT '家庭成员名',
  `relationship` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL COMMENT '关系',
  `telephone` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL COMMENT '电话',
  PRIMARY KEY (`empNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = gb2312 COLLATE = gb2312_chinese_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for t_rolepower
-- ----------------------------
DROP TABLE IF EXISTS `t_rolepower`;
CREATE TABLE `t_rolepower`  (
  `role` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NOT NULL,
  `manage_dept` tinyint(1) NOT NULL DEFAULT 0,
  `manage_teacher` tinyint(1) NOT NULL DEFAULT 0,
  `manage_emp` tinyint(1) NOT NULL DEFAULT 0,
  `manege_attendance` tinyint(1) NOT NULL DEFAULT 0,
  `manage_salary` tinyint(1) NOT NULL DEFAULT 0,
  `apply` tinyint(1) NOT NULL DEFAULT 0,
  `personalInfo` tinyint(1) NOT NULL DEFAULT 0,
  `managesystem` tinyint(1) NOT NULL DEFAULT 0
) ENGINE = InnoDB CHARACTER SET = gb2312 COLLATE = gb2312_chinese_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_rolepower
-- ----------------------------
INSERT INTO `t_rolepower` VALUES ('教师', 0, 0, 0, 0, 0, 0, 1, 0);
INSERT INTO `t_rolepower` VALUES ('教职工', 0, 0, 0, 0, 0, 0, 1, 0);
INSERT INTO `t_rolepower` VALUES ('管理员', 1, 1, 1, 1, 1, 0, 0, 0);
INSERT INTO `t_rolepower` VALUES ('系统管理员', 1, 1, 1, 1, 1, 0, 0, 1);
INSERT INTO `t_rolepower` VALUES ('游客', 0, 0, 0, 0, 0, 1, 0, 0);

-- ----------------------------
-- Table structure for t_salary
-- ----------------------------
DROP TABLE IF EXISTS `t_salary`;
CREATE TABLE `t_salary`  (
  `empNo` bigint(0) NOT NULL COMMENT '员工编号',
  `baseSalary` decimal(10, 2) NULL DEFAULT NULL COMMENT '底薪',
  `bonus` decimal(10, 2) NULL DEFAULT NULL COMMENT '奖金',
  `subsidies` decimal(10, 2) NULL DEFAULT NULL COMMENT '补贴',
  `overtimePay` decimal(10, 2) NULL DEFAULT NULL COMMENT '加班费',
  `deductPay` decimal(10, 2) NULL DEFAULT NULL COMMENT '应扣工资',
  `salary` decimal(10, 2) NULL DEFAULT NULL COMMENT '应发工资',
  `rate` double(10, 2) NULL DEFAULT NULL COMMENT '税率',
  `realSalary` decimal(10, 2) NULL DEFAULT NULL COMMENT '实发工资',
  PRIMARY KEY (`empNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = gb2312 COLLATE = gb2312_chinese_ci ROW_FORMAT = Dynamic;

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
  `teacherNo` bigint(0) NOT NULL COMMENT '教师编号',
  `departmentNo` bigint(0) NULL DEFAULT NULL COMMENT '所在部门编号',
  `name` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL COMMENT '姓名',
  `gender` enum('男','女') CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL COMMENT '性别',
  `age` int(0) NULL DEFAULT NULL COMMENT '年龄',
  `stuStatus` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL COMMENT '学籍',
  `education` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL COMMENT '学历',
  `birthday` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL COMMENT '生日',
  `teaching` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL COMMENT '授课科目',
  `IDcardNo` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL COMMENT '身份证号',
  `bankCardNo` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL COMMENT '银行卡号',
  `status` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NULL DEFAULT NULL COMMENT '在职状态',
  PRIMARY KEY (`teacherNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = gb2312 COLLATE = gb2312_chinese_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_teacher
-- ----------------------------
INSERT INTO `t_teacher` VALUES (20201529, 1031, '张凯', '男', 30, '清华大学', '博士', '1990/6/1', '物理', '555555555555555555', '666666666666666666', '在职');
INSERT INTO `t_teacher` VALUES (20201568, 1015, '王阳', '男', 43, '成都理工大学', '硕士', '1975/10/1', '大学体育', '885555555555555555', '622255454534534555', '在职');
INSERT INTO `t_teacher` VALUES (20209902, 1031, '刘洋', '女', 34, '西南大学', '硕士', '1982/2/10', '心理学', '545357221553645535', '622545345345345344', '在职');

-- ----------------------------
-- Table structure for t_user
-- ----------------------------
DROP TABLE IF EXISTS `t_user`;
CREATE TABLE `t_user`  (
  `username` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NOT NULL COMMENT '用户名',
  `password` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NOT NULL COMMENT '密码',
  `email` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NOT NULL COMMENT '邮箱',
  `role` varchar(255) CHARACTER SET gb2312 COLLATE gb2312_chinese_ci NOT NULL COMMENT '角色',
  `empNo` bigint(0) NULL DEFAULT NULL COMMENT '员工编号',
  PRIMARY KEY (`username`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = gb2312 COLLATE = gb2312_chinese_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_user
-- ----------------------------
INSERT INTO `t_user` VALUES ('admin', '123', '123456@qq.com', '管理员', NULL);
INSERT INTO `t_user` VALUES ('root', '123', '162.163.com', '系统管理员', NULL);
INSERT INTO `t_user` VALUES ('小刘', '123', '888@163.com', '教师', 20209902);
INSERT INTO `t_user` VALUES ('小明', '123', '456465@163.com', '游客', NULL);
INSERT INTO `t_user` VALUES ('小王', '123', '88888@163.com', '教师', 20201568);
INSERT INTO `t_user` VALUES ('小张', '123', '156@163.com', '教师', 20201529);

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
