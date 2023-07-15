CREATE DATABASE db_alunos;

USE db_alunos;

CREATE TABLE tb_alunos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    ano INT NOT NULL,
    nome VARCHAR(100) NOT NULL,
    nota1 FLOAT NOT NULL,
    nota2 FLOAT NOT NULL
);

SELECT ID FROM tb_alunos;
