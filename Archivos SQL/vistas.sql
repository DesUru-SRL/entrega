CREATE VIEW Paciente_Direccion_Edad AS
SELECT Persona.Nombre, Persona.Apellido, Persona.Direccion, FLOOR(DATEDIFF(CURDATE(), Persona.Fecha_Nacimiento) / 365.25) FROM Persona, Paciente WHERE Persona.CI = Paciente.CI;

CREATE VIEW Paciente_Atendidos_Por_Seba AS
SELECT Persona.* FROM Persona, Entrevista WHERE Persona.CI = Entrevista.Paciente AND Entrevista.Empleado = (SELECT CI FROM Persona WHERE Nombre = "Sebastián" AND Apellido = "Torres") AND Entrevista.Fecha > CURDATE();

CREATE VIEW Paciente_Ultimo_Medico AS
SELECT Persona.CI, Persona.Nombre, Persona.Apellido, Entrevista.Fecha, Entrevista.Empleado FROM Persona, Entrevista WHERE Persona.CI = Entrevista.Paciente GROUP BY Persona.CI ORDER BY Entrevista.Fecha;

CREATE VIEW Medico_Direccion AS
SELECT Persona.Nombre, Persona.Apellido, Persona.Direccion FROM Persona, Empleado WHERE Persona.CI = Empleado.CI AND Empleado.Cargo = "Médico";

CREATE VIEW Pacientes_Coronavirus AS
SELECT Persona.* FROM Persona, Diagnostico WHERE Persona.CI = Diagnostico.Paciente AND (Detalle LIKE "%Coronavirus%" OR Detalle LIKE "%COVID-19%");

CREATE VIEW Cantidad_Sintomas AS
SELECT Paciente, COUNT(Sintoma) AS Cantidad_Sintomas FROM Sintoma GROUP BY Paciente;
               
CREATE VIEW Poblacion_Riesgo AS
SELECT Persona.* FROM Paciente, Persona, Diagnostico WHERE Persona.CI = Paciente.CI AND Paciente.CI = Diagnostico.Paciente AND Diagnostico.Detalle LIKE "%Población de riesgo%";

CREATE VIEW Pacientes_Nunca_Atendidos AS
SELECT Persona.* FROM Paciente, Persona WHERE Persona.CI = Paciente.CI AND Persona.CI NOT IN (SELECT Paciente FROM Entrevista);
