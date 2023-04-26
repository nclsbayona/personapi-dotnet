-- Schema persona_db
CREATE DATABASE persona_db;
GO

-- Seleccionamos la base de datos persona_db
USE persona_db;
GO

-- Table persona
CREATE TABLE persona (
  cc INT PRIMARY KEY CHECK (cc >= 0 AND cc <= 999999999999999),
  nombre VARCHAR(45) NOT NULL,
  apellido VARCHAR(45) NOT NULL,
  genero CHAR(1) CHECK (genero = 'M' OR genero = 'F') NOT NULL,
  edad INT CHECK (edad >= 0 AND edad <= 999)
);
GO

-- Table profesion
CREATE TABLE profesion (
  id INT PRIMARY KEY CHECK (id >= 0 AND id <= 999999),
  nom VARCHAR(90) NOT NULL,
  des TEXT
);
GO

-- Table estudios
CREATE TABLE estudios (
  id_prof INT NOT NULL,
  cc_per INT NOT NULL,
  fecha DATE,
  univer VARCHAR(50),
  PRIMARY KEY (id_prof, cc_per),
  FOREIGN KEY (cc_per) REFERENCES persona(cc),
  FOREIGN KEY (id_prof) REFERENCES profesion(id)
);
GO

-- Table telefono
CREATE TABLE telefono (
  num VARCHAR(15) PRIMARY KEY,
  oper VARCHAR(45) NOT NULL,
  duenio INT NOT NULL,
  FOREIGN KEY (duenio) REFERENCES persona(cc)
);
GO