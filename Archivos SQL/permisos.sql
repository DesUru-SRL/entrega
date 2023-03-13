



grant dba to administrador;
grant connect to medico;
grant select, insert, update, delete on persona to medico;
grant select, insert, update, delete on paciente to medico;
grant select, insert on entrevista to medico;
grant select, insert on formulario to medico;
grant select, insert on diagnostico to medico;
grant select, insert on plan to medico;
grant select, insert on control to medico;
grant select, insert on solicitud_analisis to medico;
grant select, insert on resultado_analisis to medico;
grant connect to auxiliar;
grant select, insert, update, delete on persona to auxiliar;
grant select, insert, update, delete on paciente to auxiliar;
grant select, insert on entrevista to auxiliar;
grant select, insert on formulario to auxiliar;
grant insert on solicitud_analisis to auxiliar;
grant connect to paciente;
grant select on resultado_analisis to paciente;
grant select on diagnostico to paciente;
grant select on plan to paciente;
grant select on control to paciente;
