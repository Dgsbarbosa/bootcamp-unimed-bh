/* Comandos*/

CREATE TABLE pessoas (
    id INT NOT NULL PRYMARY KEY AUTOINCREMENT,
    nome VARCHAR(30) NOT NULL,    
    nascimento DATE         
)

INSERT INTO pessoa (nome, nascimento) VALUES ('Douglas', '1988-05-22');
INSERT INTO pessoa (nome, nascimento) VALUES ('Sabrina', '1993-01-06');
INSERT INTO pessoa (nome, nascimento) VALUES ('Eduarda', '2010-02-20');
INSERT INTO pessoa (nome, nascimento) VALUES ('Leonardo', '2011-07-07');
INSERT INTO pessoa (nome, nascimento) VALUES ('Victória', '2014-10-05');
