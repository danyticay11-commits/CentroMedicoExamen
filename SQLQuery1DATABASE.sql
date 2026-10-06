
CREATE DATABASE DB_CentroMedico_Examen;

USE DB_CentroMedico_Examen;



CREATE TABLE Med_Roles (
    ID_Rol INT IDENTITY(1,1) PRIMARY KEY,
    NombreRol VARCHAR(50) NOT NULL UNIQUE
);


CREATE TABLE Med_Usuarios (
    ID_Usuario INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Contrasena VARCHAR(255) NOT NULL,
    ID_Rol INT NOT NULL,
    Estado BIT DEFAULT 1,
    FechaCreacion DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (ID_Rol) REFERENCES Med_Roles(ID_Rol)
);


CREATE TABLE Med_Especialidades (
    ID_Especialidad INT IDENTITY(1,1) PRIMARY KEY,
    NombreEspecialidad VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(255)
);


CREATE TABLE Med_Medicos (
    ID_Medico INT IDENTITY(1,1) PRIMARY KEY,
    ID_Usuario INT UNIQUE NULL,
    ID_Especialidad INT NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    LicenciaMedica VARCHAR(50) NOT NULL UNIQUE,
    Telefono VARCHAR(20),
    Email VARCHAR(100),
    FOREIGN KEY (ID_Usuario) REFERENCES Med_Usuarios(ID_Usuario),
    FOREIGN KEY (ID_Especialidad) REFERENCES Med_Especialidades(ID_Especialidad)
);


CREATE TABLE Med_Pacientes (
    ID_Paciente INT IDENTITY(1,1) PRIMARY KEY,
    DNI_Cedula VARCHAR(20) NOT NULL UNIQUE,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    Genero CHAR(1) CHECK (Genero IN ('M', 'F', 'O')),
    Telefono VARCHAR(20),
    Direccion VARCHAR(200),
    ContactoEmergencia VARCHAR(100),
    FechaRegistro DATETIME DEFAULT GETDATE()
);


CREATE TABLE Med_EstadosCita (
    ID_EstadoCita INT IDENTITY(1,1) PRIMARY KEY,
    Estado VARCHAR(30) NOT NULL
);


CREATE TABLE Med_Citas (
    ID_Cita INT IDENTITY(1,1) PRIMARY KEY,
    ID_Paciente INT NOT NULL,
    ID_Medico INT NOT NULL,
    ID_EstadoCita INT NOT NULL,
    FechaHora DATETIME NOT NULL,
    Motivo VARCHAR(255),
    FechaCreacion DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (ID_Paciente) REFERENCES Med_Pacientes(ID_Paciente),
    FOREIGN KEY (ID_Medico) REFERENCES Med_Medicos(ID_Medico),
    FOREIGN KEY (ID_EstadoCita) REFERENCES Med_EstadosCita(ID_EstadoCita)
);


CREATE TABLE Med_Consultas (
    ID_Consulta INT IDENTITY(1,1) PRIMARY KEY,
    ID_Cita INT UNIQUE NOT NULL,
    FechaConsulta DATETIME DEFAULT GETDATE(),
    Sintomas VARCHAR(MAX) NOT NULL,
    Diagnostico VARCHAR(MAX) NOT NULL,
    NotasMedicas VARCHAR(MAX),
    FOREIGN KEY (ID_Cita) REFERENCES Med_Citas(ID_Cita)
);


CREATE TABLE Med_Medicamentos (
    ID_Medicamento INT IDENTITY(1,1) PRIMARY KEY,
    NombreMedicamento VARCHAR(100) NOT NULL,
    Presentacion VARCHAR(50),
    Stock INT DEFAULT 0
);


CREATE TABLE Med_RecetasDetalle (
    ID_Receta INT IDENTITY(1,1) PRIMARY KEY,
    ID_Consulta INT NOT NULL,
    ID_Medicamento INT NOT NULL,
    Dosis VARCHAR(100) NOT NULL,
    Duracion VARCHAR(50) NOT NULL,
    FOREIGN KEY (ID_Consulta) REFERENCES Med_Consultas(ID_Consulta),
    FOREIGN KEY (ID_Medicamento) REFERENCES Med_Medicamentos(ID_Medicamento)
);

INSERT INTO Med_Roles (NombreRol) VALUES ('Administrador'), ('Medico'), ('Recepcionista');

INSERT INTO Med_Usuarios (Username, Contrasena, ID_Rol) VALUES ('admin', 'admin123', 1);

INSERT INTO Med_EstadosCita (Estado) VALUES ('Programada'), ('Atendida'), ('Cancelada');

INSERT INTO Med_Especialidades (NombreEspecialidad, Descripcion) VALUES 
('Medicina General', 'Atención médica primaria'),
('Pediatría', 'Atención para niños');