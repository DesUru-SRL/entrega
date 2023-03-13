SELECT DISTINCT Persona.Nombre, Persona.Apellido FROM Persona,
Entrevista, Empleado WHERE Persona.CI = Entrevista.Empleado AND
Persona.CI = Empleado.CI AND Empleado.Cargo = "Medico"
AND Entrevista.Fecha > CURRENT - INTERVAL (48) HOUR TO HOUR;
SELECT COUNT(Paciente) AS Cantidad_Pacientes FROM Entrevista WHERE
MONTH(Fecha) = 9;
SELECT DISTINCT Persona.* FROM Persona, Solicitud_Analisis WHERE
Persona.CI = Solicitud_Analisis.Paciente AND Solicitud_Analisis.COD
NOT IN (SELECT Solicitud FROM Resultado_Analisis);
SELECT DISTINCT Persona.* FROM Persona, Paciente WHERE
Paciente.CI = Persona.CI AND Paciente.CI NOT IN
(SELECT Paciente FROM Sintoma);
SELECT DISTINCT Persona.* FROM Persona, Sintoma WHERE
Persona.CI = Sintoma.Paciente AND Sintoma.Sintoma LIKE "%Tos%";
SELECT COUNT(*) AS Cantidad_Pacientes_Tos FROM (SELECT DISTINCT
Persona.* FROM Persona, Sintoma WHERE Persona.CI = Sintoma.Paciente
AND Sintoma.Sintoma LIKE "%Tos%") Pacientes_Con_Tos;
SELECT COUNT(Paciente) AS Cantidad_Pacientes_Enfermos FROM Diagnostico
 WHERE Detalle LIKE "%Padece%" AND
Fecha_Entrevista > CURRENT - INTERVAL (72) HOUR TO HOUR;
SELECT Persona.* FROM Persona, Registra WHERE 
Persona.CI = Registra.Paciente ORDER BY Registra.Fecha DESC LIMIT 1 
GROUP BY Persona.Fecha_Nacimiento;
SELECT Persona.*, Entrevista.Paciente FROM Persona, Empleado, Entrevista
WHERE Persona.CI = Empleado.CI AND Empleado.Cargo = "Medico" AND
Entrevista.Empleado = Empleado.CI ORDER BY Entrevista.Fecha DESC
 GROUP BY Empleado.CI;
SELECT COUNT(*) FROM Diagnostico WHERE Fecha < "2020-09-15" +
INTERVAL (1) DAY AND Fecha >= "2020-09-15" AND Detalle LIKE "%Padece%";
SELECT MIN(Temperatura) AS Minimo, MAX(Temperatura) AS Maximo,
AVG(Temperatura) AS PROMEDIO FROM Entrevista WHERE
Fecha > CURRENT - INTERVAL (24) HOUR TO HOUR;
SELECT Persona.* FROM Persona, Entrevista WHERE Persona.CI =
Entrevista.Paciente AND Entrevista.Empleado = (SELECT CI FROM Persona
WHERE Nombre = "Sebastián" AND Apellido = "Torres");
SELECT Persona.* FROM Paciente, Persona, Plan WHERE
Persona.CI = Paciente.CI AND Paciente.CI = Plan.Paciente AND
Plan.Detalles LIKE "%Reposo%";
SELECT (x.c*100)/(SUM(x.c)) AS Porcentaje_Pacientes,
100-(x.c*100)/(SUM(x.c)) AS Porcentaje_Medicos FROM
(SELECT COUNT(*) AS c FROM Paciente AS p
UNION SELECT COUNT(*) as cc FROM Empleado WHERE Cargo = "Medico")
as x;
