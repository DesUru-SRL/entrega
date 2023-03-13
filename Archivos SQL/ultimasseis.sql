select empleado.ci, persona.nombre, persona.apellido, count(entrevista.paciente) as "Cantidad de pacientes"
from empleado, persona, entrevista where empleado.ci = persona.ci and empleado.cargo = "Medico"
and empleado.ci = entrevista.empleado group by empleado.ci;
select diagnostico.* from (select * from persona where nombre = "Sebastian" and apellido = "Torres") As Seba,
diagnostico where seba.ci = diagnostico.paciente;
select persona.nombre, persona.apellido from entrevista, persona where persona.ci = entrevista.paciente and
entrevista.temperatura > 37.5;
select distinct persona.nombre, persona.apellido from persona, paciente_estado where paciente_estado.fecha < curdate()
+ interval 1 day;
select distinct sintoma from sintoma where fecha_entrevista >= curdate() and fecha_entrevista < curdate() + interval 1
day;
select count(paciente) from sintoma where fecha_entrevista < curdate() + interval 1 day and fecha_entrevista > curdate()
- interval 14 day;
