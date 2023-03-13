select persona.ci, persona.apellido from paciente, persona where paciente.ci = persona.ci order by apellido;
select persona.nombre, persona.apellido, persona.telefono from persona, paciente where paciente.ci = persona.ci;
select persona.telefono from persona, paciente where paciente.ci = persona.ci and persona.nombre = "Sebastian" and
persona.apellido = "Torres";
select paciente, count(paciente) as cantidad_entrevistas from entrevista group by paciente;
select max(fecha), paciente from entrevista where paciente = "12345678" group by paciente;
select estado.tipo, count(paciente_estado.paciente) from paciente_estado, estado where estado.cod = paciente_estado.estado
group by estado.tipo;
select count(*) from diagnostico where month(fecha) = 7;
select paciente, count(paciente) as cantidad_entrevistas from entrevista group by paciente order by
cantidad_entrevistas desc limit 1;
select count(*) from empleado where cargo = "Medico";
