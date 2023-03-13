{ DATABASE desuru  delimiter | }

grant dba to "informix";
grant dba to "administrador";
grant connect to "medico";
grant connect to "auxiliar";
grant connect to "paciente";











{ TABLE "informix".persona row size = 171 number of columns = 7 index size = 14 }

{ unload file name = perso00101.unl number of rows = 8 }

create table "informix".persona 
  (
    fecha_nacimiento date,
    direccion varchar(64,64),
    nombre varchar(32,32) not null ,
    apellido varchar(32,32) not null ,
    contrasena varchar(16,16) not null ,
    telefono varchar(9,9),
    ci varchar(8,8) not null ,
    primary key (ci)  constraint "informix".ci
  );

revoke all on "informix".persona from "public" as "informix";

{ TABLE "informix".administrador row size = 9 number of columns = 1 index size = 14 }

{ unload file name = admin00106.unl number of rows = 1 }

create table "informix".administrador 
  (
    ci varchar(8,8) not null ,
    primary key (ci)  constraint "informix".ciadmin
  );

revoke all on "informix".administrador from "public" as "informix";

{ TABLE "informix".empleado row size = 18 number of columns = 2 index size = 14 }

{ unload file name = emple00107.unl number of rows = 2 }

create table "informix".empleado 
  (
    ci varchar(8,8) not null ,
    cargo varchar(8,8) not null ,
    
    check ((cargo = 'Medico' ) OR (cargo = 'Auxiliar' ) ) constraint "informix".checkcargo,
    primary key (ci)  constraint "informix".empleadoprimary
  );

revoke all on "informix".empleado from "public" as "informix";

{ TABLE "informix".paciente row size = 9 number of columns = 1 index size = 14 }

{ unload file name = pacie00108.unl number of rows = 5 }

create table "informix".paciente 
  (
    ci varchar(8,8) not null ,
    primary key (ci)  constraint "informix".pacienteprimary
  );

revoke all on "informix".paciente from "public" as "informix";

{ TABLE "informix".dolor row size = 8 number of columns = 2 index size = 9 }

{ unload file name = dolor00120.unl number of rows = 1 }

create table "informix".dolor 
  (
    cod integer not null ,
    valor integer not null ,
    
    check ((valor >= 0 ) AND (valor <= 10 ) ) constraint "informix".checkdolor,
    primary key (cod)  constraint "informix".dolorprimary
  );

revoke all on "informix".dolor from "public" as "informix";

{ TABLE "informix".glasgow row size = 16 number of columns = 4 index size = 9 }

{ unload file name = glasg00131.unl number of rows = 1 }

create table "informix".glasgow 
  (
    cod integer not null ,
    ocular integer not null ,
    verbal integer not null ,
    motora integer not null ,
    
    check ((((((ocular >= 1 ) AND (ocular < 5 ) ) AND (verbal >= 1 ) ) AND (verbal 
              < 6 ) ) AND (motora >= 1 ) ) AND (motora < 7 ) ) constraint "informix".checkglasgow,
    primary key (cod)  constraint "informix".glasgowprimary
  );

revoke all on "informix".glasgow from "public" as "informix";

{ TABLE "informix".estado row size = 5 number of columns = 2 index size = 9 }

{ unload file name = estad00132.unl number of rows = 5 }

create table "informix".estado 
  (
    cod integer not null ,
    tipo char(1) not null ,
    primary key (cod)  constraint "informix".estadoprimary
  );

revoke all on "informix".estado from "public" as "informix";

{ TABLE "informix".fisico row size = 169 number of columns = 6 index size = 9 }

{ unload file name = fisic00162.unl number of rows = 0 }

create table "informix".fisico 
  (
    cod integer not null ,
    piel varchar(32,32) not null ,
    bucofaringeo varchar(32,32) not null ,
    cuello varchar(32,32) not null ,
    linfogaglionar varchar(32,32) not null ,
    mamas varchar(32,32) not null ,
    primary key (cod)  constraint "informix".fisicoprimary
  );

revoke all on "informix".fisico from "public" as "informix";

{ TABLE "informix".agrega_empleado row size = 22 number of columns = 3 index size = 28 }

{ unload file name = agreg00166.unl number of rows = 2 }

create table "informix".agrega_empleado 
  (
    empleado varchar(8,8) not null ,
    administrador varchar(8,8) not null ,
    fecha date not null ,
    primary key (empleado)  constraint "informix".agrega_empleadoprimary
  );

revoke all on "informix".agrega_empleado from "public" as "informix";

{ TABLE "informix".formulario row size = 30 number of columns = 4 index size = 9 }

{ unload file name = formu00170.unl number of rows = 13 }

create table "informix".formulario 
  (
    empleado varchar(8,8) not null ,
    paciente varchar(8,8) not null ,
    cod integer not null ,
    fecha datetime year to second not null ,
    primary key (cod)  constraint "informix".formularioprimary
  );

revoke all on "informix".formulario from "public" as "informix";

{ TABLE "informix".paciente_estado row size = 21 number of columns = 3 index size = 45 }

{ unload file name = pacie00171.unl number of rows = 10 }

create table "informix".paciente_estado 
  (
    paciente varchar(8,8) not null ,
    fecha datetime year to second not null ,
    estado integer not null ,
    primary key (paciente,fecha)  constraint "informix".pacienteestadoprimary
  );

revoke all on "informix".paciente_estado from "public" as "informix";

{ TABLE "informix".registra row size = 26 number of columns = 3 index size = 51 }

{ unload file name = regis00174.unl number of rows = 0 }

create table "informix".registra 
  (
    empleado varchar(8,8) not null ,
    paciente varchar(8,8) not null ,
    fecha datetime year to second not null ,
    primary key (empleado,paciente)  constraint "informix".registraprimary
  );

revoke all on "informix".registra from "public" as "informix";

{ TABLE "informix".sintoma row size = 91 number of columns = 4 index size = 96 }

{ unload file name = sinto00176.unl number of rows = 4 }

create table "informix".sintoma 
  (
    empleado varchar(8,8) not null ,
    paciente varchar(8,8) not null ,
    fecha_entrevista datetime year to second not null ,
    sintoma varchar(64,64) not null ,
    primary key (empleado,paciente,fecha_entrevista,sintoma)  constraint "informix".primarysintoma
  );

revoke all on "informix".sintoma from "public" as "informix";

{ TABLE "informix".solicitud_analisis row size = 51 number of columns = 6 index size = 39 }

{ unload file name = solic00177.unl number of rows = 3 }

create table "informix".solicitud_analisis 
  (
    cod integer not null ,
    empleado varchar(8,8) not null ,
    paciente varchar(8,8) not null ,
    fecha_entrevista datetime year to second not null ,
    diagnostico integer not null ,
    tipo varchar(16,16) not null ,
    primary key (cod,empleado,paciente,fecha_entrevista,diagnostico)  constraint 
              "informix".solicitudanalisisprimary
  );

revoke all on "informix".solicitud_analisis from "public" as "informix";

{ TABLE "informix".entrevista row size = 308 number of columns = 12 index size = 59 }

{ unload file name = entre00178.unl number of rows = 4 }

create table "informix".entrevista 
  (
    empleado varchar(8,8) not null ,
    paciente varchar(8,8) not null ,
    fecha datetime year to second not null ,
    actitud varchar(16,16) not null ,
    estado_nutricional varchar(16,16) not null ,
    pulso varchar(16,16) not null ,
    frecuencia_cardiaca integer not null ,
    frecuencia_respiratoria integer not null ,
    motivo varchar(200) not null ,
    estado_general varchar(16,16) not null ,
    temperatura decimal(4,1) not null ,
    colabora char(1) not null ,
    primary key (empleado,paciente,fecha)  constraint "informix".entrevistaprimary
  );

revoke all on "informix".entrevista from "public" as "informix";

{ TABLE "informix".diagnostico row size = 272 number of columns = 7 index size = 35 }

{ unload file name = diagn00180.unl number of rows = 3 }

create table "informix".diagnostico 
  (
    paciente varchar(8,8) not null ,
    fecha_entrevista datetime year to second not null ,
    tipo varchar(32,32) not null ,
    detalle varchar(200) not null ,
    fecha datetime year to second not null ,
    cod integer not null ,
    empleado varchar(8,8) not null ,
    primary key (cod,empleado,paciente,fecha_entrevista)  constraint "informix".diagnosticoprimary
  );

revoke all on "informix".diagnostico from "public" as "informix";

{ TABLE "informix".plan row size = 239 number of columns = 6 index size = 35 }

{ unload file name = plan_00181.unl number of rows = 2 }

create table "informix".plan 
  (
    cod integer not null ,
    empleado varchar(8,8) not null ,
    paciente varchar(8,8) not null ,
    fecha_entrevista datetime year to second not null ,
    detalles varchar(200) not null ,
    fecha datetime year to second not null ,
    primary key (cod,empleado,paciente,fecha_entrevista)  constraint "informix".planprimary
  );

revoke all on "informix".plan from "public" as "informix";

{ TABLE "informix".resultado_analisis row size = 247 number of columns = 8 index size = 43 }

{ unload file name = resul00182.unl number of rows = 2 }

create table "informix".resultado_analisis 
  (
    cod integer not null ,
    empleado varchar(8,8) not null ,
    paciente varchar(8,8) not null ,
    fecha_entrevista datetime year to second not null ,
    diagnostico integer not null ,
    solicitud integer not null ,
    detalles varchar(200) not null ,
    fecha datetime year to second not null ,
    primary key (cod,empleado,paciente,fecha_entrevista,diagnostico,solicitud)  constraint 
              "informix".resultadoanalprimary
  );

revoke all on "informix".resultado_analisis from "public" as "informix";

{ TABLE "informix".fiebre row size = 205 number of columns = 2 index size = 9 }

{ unload file name = fiebr00184.unl number of rows = 1 }

create table "informix".fiebre 
  (
    cod integer not null ,
    descripcion varchar(200) not null 
  );

revoke all on "informix".fiebre from "public" as "informix";

{ TABLE "informix".control row size = 243 number of columns = 7 index size = 39 }

{ unload file name = contr00185.unl number of rows = 3 }

create table "informix".control 
  (
    cod integer not null ,
    empleado varchar(8,8) not null ,
    paciente varchar(8,8) not null ,
    fecha_entrevista datetime year to second not null ,
    plan integer not null ,
    detalles varchar(200) not null ,
    fecha datetime year to second not null ,
    primary key (cod,empleado,paciente,fecha_entrevista,plan)  constraint "informix".controlprimary
  );

revoke all on "informix".control from "public" as "informix";




grant select on "informix".persona to "auxiliar" as "informix";
grant update on "informix".persona to "auxiliar" as "informix";
grant insert on "informix".persona to "auxiliar" as "informix";
grant delete on "informix".persona to "auxiliar" as "informix";
grant select on "informix".persona to "medico" as "informix";
grant update on "informix".persona to "medico" as "informix";
grant insert on "informix".persona to "medico" as "informix";
grant delete on "informix".persona to "medico" as "informix";
grant select on "informix".paciente to "auxiliar" as "informix";
grant update on "informix".paciente to "auxiliar" as "informix";
grant insert on "informix".paciente to "auxiliar" as "informix";
grant delete on "informix".paciente to "auxiliar" as "informix";
grant select on "informix".paciente to "medico" as "informix";
grant update on "informix".paciente to "medico" as "informix";
grant insert on "informix".paciente to "medico" as "informix";
grant delete on "informix".paciente to "medico" as "informix";
grant select on "informix".formulario to "auxiliar" as "informix";
grant insert on "informix".formulario to "auxiliar" as "informix";
grant select on "informix".formulario to "medico" as "informix";
grant insert on "informix".formulario to "medico" as "informix";
grant insert on "informix".solicitud_analisis to "auxiliar" as "informix";
grant select on "informix".solicitud_analisis to "medico" as "informix";
grant insert on "informix".solicitud_analisis to "medico" as "informix";
grant select on "informix".entrevista to "auxiliar" as "informix";
grant insert on "informix".entrevista to "auxiliar" as "informix";
grant select on "informix".entrevista to "medico" as "informix";
grant insert on "informix".entrevista to "medico" as "informix";
grant select on "informix".diagnostico to "medico" as "informix";
grant insert on "informix".diagnostico to "medico" as "informix";
grant select on "informix".diagnostico to "paciente" as "informix";
grant select on "informix".plan to "medico" as "informix";
grant insert on "informix".plan to "medico" as "informix";
grant select on "informix".plan to "paciente" as "informix";
grant select on "informix".resultado_analisis to "medico" as "informix";
grant insert on "informix".resultado_analisis to "medico" as "informix";
grant select on "informix".resultado_analisis to "paciente" as "informix";
grant select on "informix".control to "medico" as "informix";
grant insert on "informix".control to "medico" as "informix";
grant select on "informix".control to "paciente" as "informix";
















revoke usage on language SPL from public ;

grant usage on language SPL to public ;








alter table "informix".administrador add constraint (foreign 
    key (ci) references "informix".persona  on delete cascade 
    constraint "informix".ciadminforeign);
alter table "informix".empleado add constraint (foreign key (ci) 
    references "informix".persona  on delete cascade constraint 
    "informix".empleadoforeign);
alter table "informix".paciente add constraint (foreign key (ci) 
    references "informix".persona  on delete cascade constraint 
    "informix".pacienteforeign);
alter table "informix".dolor add constraint (foreign key (cod) 
    references "informix".formulario  on delete cascade constraint 
    "informix".dolorforeign);
alter table "informix".glasgow add constraint (foreign key (cod) 
    references "informix".formulario  on delete cascade constraint 
    "informix".glasgowforeign);
alter table "informix".fisico add constraint (foreign key (cod) 
    references "informix".formulario  on delete cascade constraint 
    "informix".fisicoforeign);
alter table "informix".agrega_empleado add constraint (foreign 
    key (empleado) references "informix".empleado  on delete cascade 
    constraint "informix".agregaempforeign);
alter table "informix".agrega_empleado add constraint (foreign 
    key (administrador) references "informix".administrador  on 
    delete cascade constraint "informix".adminagregaforeign);
alter table "informix".paciente_estado add constraint (foreign 
    key (paciente) references "informix".paciente  on delete cascade 
    constraint "informix".pepaciente);
alter table "informix".paciente_estado add constraint (foreign 
    key (estado) references "informix".estado  on delete cascade 
    constraint "informix".peestado);
alter table "informix".registra add constraint (foreign key (empleado) 
    references "informix".empleado  on delete cascade constraint 
    "informix".pempleado);
alter table "informix".registra add constraint (foreign key (paciente) 
    references "informix".paciente  on delete cascade constraint 
    "informix".ppaciente);
alter table "informix".entrevista add constraint (foreign key 
    (paciente) references "informix".paciente  on delete cascade 
    constraint "informix".entrevistaforeignpaciente);
alter table "informix".entrevista add constraint (foreign key 
    (empleado) references "informix".empleado  on delete cascade 
    constraint "informix".entrevistaforeignempleado);
alter table "informix".fiebre add constraint (foreign key (cod) 
    references "informix".formulario  on delete cascade constraint 
    "informix".fiebreforeign);






update statistics medium for table "informix".sysaggregates (
     owner) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".sysams (
     am_owner) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".sysblobs (
     colno) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".syscasts (
     argument_xid, result_xid) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".syschecks (
     seqno, type) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".syscolauth (
     colno, grantee, grantor) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".syscoldepend (
     colno) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".syscolumns (
     colno) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".sysconstraints (
     owner) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".sysdefaults (
     class, colno) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".sysdistrib (
     colno, seqno) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".sysfragments (
     evalpos, fragtype, indexname) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".sysindices (
     owner) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".syslangauth (
     grantee, grantor) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".sysobjstate (
     name, owner) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".sysopclasses (
     owner) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".sysprocauth (
     grantee, grantor) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".sysprocbody (
     datakey, seqno) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".sysproccolumns (
     paramid) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".sysprocedures (
     isproc, numargs, owner) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".sysprocplan (
     datakey, planid, seqno) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".systabauth (
     grantee, grantor) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".systables (
     owner) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".sysviews (
     seqno) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".sysxtddesc (
     seqno) 
     resolution   2.00000   0.95000 ;
update statistics medium for table "informix".sysxtdtypes (
     owner, source) 
     resolution   2.00000   0.95000 ;

 



