CREATE DATABASE News_project;
USE News_project;

CREATE TABLE USER (
	id_user INT(11) AUTO_INCREMENT,
    name VARCHAR(70) NOT NULL,
    email VARCHAR(70) NOT NULL,
    password VARCHAR(25) NOT NULL,
    userProfile VARCHAR(14) NOT NULL,
    PRIMARY KEY(id_user)
);

CREATE TABLE CATEGORY (
	id_category INT(11) AUTO_INCREMENT,
    name_category VARCHAR(50) NOT NULL,
    PRIMARY KEY(id_category)
);

CREATE TABLE NEWS(
	id_news INT(11) AUTO_INCREMENT,
    id_category INT(11) NOT NULL,
    title VARCHAR(100) NOT NULL,
    subTitle VARCHAR(100) NOT NULL,
    body LONGTEXT NOT NULL,
    author VARCHAR(70) NOT NULL,
    date Date NOT NULL,
    PRIMARY KEY(id_news),
	FOREIGN KEY (id_category) REFERENCES CATEGORY(id_category)
);

CREATE TABLE COMMENT(
	id_comment INT(11) AUTO_INCREMENT,
    body LONGTEXT NOT NULL,
    date DATE NOT NULL,
    id_news INT(11) NOT NULL,
    PRIMARY KEY(id_comment),
    FOREIGN KEY (id_news) REFERENCES NEWS(id_news)
);

INSERT INTO USER (name, email, password, userProfile) VALUES("lucas", "lucas@gmail.com", "123456", "Administrador");
INSERT INTO USER (name, email, password, userProfile) VALUES("Maria", "maria@gmail.com", "maria123", "Jornalista");
INSERT INTO USER (name, email, password, userProfile) VALUES("Joao", "joao@gmail.com", "joao852", "Cliente");

INSERT INTO CATEGORY(name_category) VALUES("Esporte");
INSERT INTO CATEGORY(name_category) VALUES("Cultura");
INSERT INTO CATEGORY(name_category) VALUES("Ciencia");

INSERT INTO COMMENT(body, date, id_news) VALUES("test", "2020/11/26", 1);
INSERT INTO COMMENT(body, date, id_news) VALUES("test2", "2020/11/26", 2);
INSERT INTO COMMENT(body, date, id_news) VALUES("test3", "2020/11/26", 3);

INSERT INTO NEWS(title, subTitle, body, author, date, id_category) VALUES("d", "dd", "hjgffhjg", "eu", "2020/11/26", 1);
INSERT INTO NEWS(title, subTitle, body, author, date, id_category) VALUES("b", "bb", "dsasdas", "eu", "2020/11/26", 2);
INSERT INTO NEWS(title, subTitle, body, author, date, id_category) VALUES("c", "cc", "dfsgsdf", "eu", "2020/11/26", 3);