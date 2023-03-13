{ DATABASE desuru  delimiter | }

grant dba to "informix";











{ TABLE "informix".persona row size = 102 number of columns = 5 index size = 14 }

{ unload file name = perso00101.unl number of rows = 0 }

create table "informix".persona 
  (
    nombre varchar(32,32) not null ,
    apellido varchar(32,32) not null ,
    contrasena varchar(16,16) not null ,
    telefono varchar(9,9),
    ci varchar(8,8) not null ,
    primary key (ci)  constraint "informix".ci
  );

revoke all on "informix".persona from "public" as "informix";

{ TABLE "informix".administrador row size = 9 number of columns = 1 index size = 14 }

{ unload file name = admin00106.unl number of rows = 0 }

create table "informix".administrador 
  (
    ci varchar(8,8) not null ,
    primary key (ci)  constraint "informix".ciadmin
  );

revoke all on "informix".administrador from "public" as "informix";

{ TABLE "informix".empleado row size = 18 number of columns = 2 index size = 14 }

{ unload file name = emple00107.unl number of rows = 0 }

create table "informix".empleado 
  (
    ci varchar(8,8) not null ,
    cargo varchar(8,8) not null ,
    
    check ((cargo = 'Medico' ) OR (cargo = 'Auxiliar' ) ) constraint "informix".checkcargo,
    primary key (ci)  constraint "informix".empleadoprimary
  );

revoke all on "informix".empleado from "public" as "informix";

{ TABLE "informix".paciente row size = 9 number of columns = 1 index size = 14 }

{ unload file name = pacie00108.unl number of rows = 0 }

create table "informix".paciente 
  (
    ci varchar(8,8) not null ,
    primary key (ci)  constraint "informix".pacienteprimary
  );

revoke all on "informix".paciente from "public" as "informix";

{ TABLE "informix".entrevista row size = 364 number of columns = 12 index size = 53 }

{ unload file name = entre00115.unl number of rows = 0 }

create table "informix".entrevista 
  (
    empleado varchar(8,8) not null ,
    paciente varchar(8,8) not null ,
    fecha datetime minute to minute not null ,
    actitud varchar(16,16) not null ,
    estado_nutricional varchar(32,32) not null ,
    pulso varchar(16,16) not null ,
    frecuencia_cardiaca integer not null ,
    frecuencia_respiratoria integer not null ,
    motivo varchar(200,200) not null ,
    estado_general varchar(64,64) not null ,
    temperatura decimal(2,2) not null ,
    colabora char(1) not null ,
    primary key (empleado,paciente,fecha)  constraint "informix".entrevistaprimary
  );

revoke all on "informix".entrevista from "public" as "informix";

{ TABLE "informix".formulario row size = 24 number of columns = 4 index size = 34 }

{ unload file name = formu00117.unl number of rows = 0 }

create table "informix".formulario 
  (
    empleado varchar(8,8) not null ,
    paciente varchar(8,8) not null ,
    cod integer not null ,
    fecha datetime minute to minute not null ,
    primary key (cod)  constraint "informix".formularioprimary
  );

revoke all on "informix".formulario from "public" as "informix";

{ TABLE "informix".fiebre row size = 205 number of columns = 2 index size = 9 }

{ unload file name = fiebr00119.unl number of rows = 0 }

create table "informix".fiebre 
  (
    cod integer not null ,
    descripcion varchar(200,200) not null 
  );

revoke all on "informix".fiebre from "public" as "informix";

{ TABLE "informix".dolor row size = 8 number of columns = 2 index size = 9 }

{ unload file name = dolor00120.unl number of rows = 0 }

create table "informix".dolor 
  (
    cod integer not null ,
    valor integer not null ,
    
    check ((valor >= 0 ) AND (valor <= 10 ) ) constraint "informix".checkdolor,
    primary key (cod)  constraint "informix".dolorprimary
  );

revoke all on "informix".dolor from "public" as "informix";

{ TABLE "informix".diagnostico row size = 260 number of columns = 7 index size = 54 }

{ unload file name = diagn00121.unl number of rows = 0 }

create table "informix".diagnostico 
  (
    paciente varchar(8,8) not null ,
    fecha_entrevista datetime minute to minute not null ,
    tipo varchar(32,32) not null ,
    detalle varchar(200,200) not null ,
    fecha datetime minute to minute not null ,
    cod integer not null ,
    empleado varchar(8,8) not null ,
    primary key (cod,empleado,paciente,fecha_entrevista)  constraint "informix".diagnosticoprimary
  );

revoke all on "informix".diagnostico from "public" as "informix";

{ TABLE "informix".solicitud_analisis row size = 61 number of columns = 6 index size = 62 }

{ unload file name = solic00128.unl number of rows = 0 }

create table "informix".solicitud_analisis 
  (
    cod integer not null ,
    empleado varchar(8,8) not null ,
    paciente varchar(8,8) not null ,
    fecha_entrevista datetime minute to minute not null ,
    diagnostico integer not null ,
    tipo varchar(32,32) not null ,
    primary key (cod,empleado,paciente,fecha_entrevista,diagnostico)  constraint 
              "informix".solicitudanalisisprimary
  );

revoke all on "informix".solicitud_analisis from "public" as "informix";

{ TABLE "informix".fisico row size = 553 number of columns = 6 index size = 9 }

{ unload file name = fisic00130.unl number of rows = 0 }

create table "informix".fisico 
  (
    cod integer not null ,
    piel varchar(32,32) not null ,
    bucofaringeo varchar(128,128) not null ,
    cuello varchar(128,128) not null ,
    linfogaglionar varchar(128,128) not null ,
    mamas varchar(128,128) not null ,
    primary key (cod)  constraint "informix".fisicoprimary
  );

revoke all on "informix".fisico from "public" as "informix";

{ TABLE "informix".glasgow row size = 16 number of columns = 4 index size = 9 }

{ unload file name = glasg00131.unl number of rows = 0 }

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

{ unload file name = estad00132.unl number of rows = 0 }

create table "informix".estado 
  (
    cod integer not null ,
    tipo char(1) not null ,
    primary key (cod)  constraint "informix".estadoprimary
  );

revoke all on "informix".estado from "public" as "informix";

{ TABLE "informix".paciente_estado row size = 15 number of columns = 3 index size = 39 }

{ unload file name = pacie00138.unl number of rows = 0 }

create table "informix".paciente_estado 
  (
    paciente varchar(8,8) not null ,
    fecha datetime minute to minute not null ,
    estado integer not null ,
    primary key (paciente,fecha)  constraint "informix".pacienteestadoprimary
  );

revoke all on "informix".paciente_estado from "public" as "informix";

{ TABLE "informix".plan row size = 538 number of columns = 6 index size = 54 }

{ unload file name = plan_00139.unl number of rows = 0 }

create table "informix".plan 
  (
    cod integer not null ,
    empleado varchar(8,8) not null ,
    paciente varchar(8,8) not null ,
    fecha_entrevista datetime minute to minute not null ,
    detalles char(512) not null ,
    fecha datetime minute to minute not null ,
    primary key (cod,empleado,paciente,fecha_entrevista)  constraint "informix".planprimary
  );

revoke all on "informix".plan from "public" as "informix";

{ TABLE "informix".registra row size = 20 number of columns = 3 index size = 51 }

{ unload file name = regis00142.unl number of rows = 0 }

create table "informix".registra 
  (
    empleado varchar(8,8) not null ,
    paciente varchar(8,8) not null ,
    fecha datetime minute to minute not null ,
    primary key (empleado,paciente)  constraint "informix".registraprimary
  );

revoke all on "informix".registra from "public" as "informix";

{ TABLE "informix".control row size = 231 number of columns = 7 index size = 62 }

{ unload file name = contr00143.unl number of rows = 0 }

create table "informix".control 
  (
    cod integer not null ,
    empleado varchar(8,8) not null ,
    paciente varchar(8,8) not null ,
    fecha_entrevista datetime minute to minute not null ,
    plan integer not null ,
    detalles varchar(200,200) not null ,
    fecha datetime minute to minute not null ,
    primary key (cod,empleado,paciente,fecha_entrevista,plan)  constraint "informix".controlprimary
  );

revoke all on "informix".control from "public" as "informix";

{ TABLE "informix".resultado_analisis row size = 235 number of columns = 8 index size = 70 }

{ unload file name = resul00144.unl number of rows = 0 }

create table "informix".resultado_analisis 
  (
    cod integer not null ,
    empleado varchar(8,8) not null ,
    paciente varchar(8,8) not null ,
    fecha_entrevista datetime minute to minute not null ,
    diagnostico integer not null ,
    solicitud integer not null ,
    detalles varchar(200,200) not null ,
    fecha datetime minute to minute not null ,
    primary key (cod,empleado,paciente,fecha_entrevista,diagnostico,solicitud)  constraint 
              "informix".resultadoanalprimary
  );

revoke all on "informix".resultado_analisis from "public" as "informix";

{ TABLE "informix".agrega_empleado row size = 20 number of columns = 3 index size = 28 }

{ unload file name = agreg00145.unl number of rows = 0 }

create table "informix".agrega_empleado 
  (
    empleado varchar(8,8) not null ,
    administrador varchar(8,8) not null ,
    fecha datetime minute to minute not null ,
    primary key (empleado)  constraint "informix".agrega_empleadoprimary
  );

revoke all on "informix".agrega_empleado from "public" as "informix";

{ TABLE "informix".sintoma row size = 53 number of columns = 4 index size = 25 }

{ unload file name = sinto00146.unl number of rows = 0 }

create table "informix".sintoma 
  (
    empleado varchar(8,8) not null ,
    paciente varchar(8,8) not null ,
    fecha_entrevista datetime minute to minute not null ,
    sintoma varchar(32,32) not null ,
    primary key (empleado,paciente,fecha_entrevista)  constraint "informix".sintomaprimary
  );

revoke all on "informix".sintoma from "public" as "informix";




grant select on "informix".persona to "public" as "informix";
grant update on "informix".persona to "public" as "informix";
grant insert on "informix".persona to "public" as "informix";
grant delete on "informix".persona to "public" as "informix";
grant index on "informix".persona to "public" as "informix";
grant select on "informix".administrador to "public" as "informix";
grant update on "informix".administrador to "public" as "informix";
grant insert on "informix".administrador to "public" as "informix";
grant delete on "informix".administrador to "public" as "informix";
grant index on "informix".administrador to "public" as "informix";
grant select on "informix".empleado to "public" as "informix";
grant update on "informix".empleado to "public" as "informix";
grant insert on "informix".empleado to "public" as "informix";
grant delete on "informix".empleado to "public" as "informix";
grant index on "informix".empleado to "public" as "informix";
grant select on "informix".paciente to "public" as "informix";
grant update on "informix".paciente to "public" as "informix";
grant insert on "informix".paciente to "public" as "informix";
grant delete on "informix".paciente to "public" as "informix";
grant index on "informix".paciente to "public" as "informix";
grant select on "informix".entrevista to "public" as "informix";
grant update on "informix".entrevista to "public" as "informix";
grant insert on "informix".entrevista to "public" as "informix";
grant delete on "informix".entrevista to "public" as "informix";
grant index on "informix".entrevista to "public" as "informix";
grant select on "informix".formulario to "public" as "informix";
grant update on "informix".formulario to "public" as "informix";
grant insert on "informix".formulario to "public" as "informix";
grant delete on "informix".formulario to "public" as "informix";
grant index on "informix".formulario to "public" as "informix";
grant select on "informix".fiebre to "public" as "informix";
grant update on "informix".fiebre to "public" as "informix";
grant insert on "informix".fiebre to "public" as "informix";
grant delete on "informix".fiebre to "public" as "informix";
grant index on "informix".fiebre to "public" as "informix";
grant select on "informix".dolor to "public" as "informix";
grant update on "informix".dolor to "public" as "informix";
grant insert on "informix".dolor to "public" as "informix";
grant delete on "informix".dolor to "public" as "informix";
grant index on "informix".dolor to "public" as "informix";
grant select on "informix".diagnostico to "public" as "informix";
grant update on "informix".diagnostico to "public" as "informix";
grant insert on "informix".diagnostico to "public" as "informix";
grant delete on "informix".diagnostico to "public" as "informix";
grant index on "informix".diagnostico to "public" as "informix";
grant select on "informix".solicitud_analisis to "public" as "informix";
grant update on "informix".solicitud_analisis to "public" as "informix";
grant insert on "informix".solicitud_analisis to "public" as "informix";
grant delete on "informix".solicitud_analisis to "public" as "informix";
grant index on "informix".solicitud_analisis to "public" as "informix";
grant select on "informix".fisico to "public" as "informix";
grant update on "informix".fisico to "public" as "informix";
grant insert on "informix".fisico to "public" as "informix";
grant delete on "informix".fisico to "public" as "informix";
grant index on "informix".fisico to "public" as "informix";
grant select on "informix".glasgow to "public" as "informix";
grant update on "informix".glasgow to "public" as "informix";
grant insert on "informix".glasgow to "public" as "informix";
grant delete on "informix".glasgow to "public" as "informix";
grant index on "informix".glasgow to "public" as "informix";
grant select on "informix".estado to "public" as "informix";
grant update on "informix".estado to "public" as "informix";
grant insert on "informix".estado to "public" as "informix";
grant delete on "informix".estado to "public" as "informix";
grant index on "informix".estado to "public" as "informix";
grant select on "informix".paciente_estado to "public" as "informix";
grant update on "informix".paciente_estado to "public" as "informix";
grant insert on "informix".paciente_estado to "public" as "informix";
grant delete on "informix".paciente_estado to "public" as "informix";
grant index on "informix".paciente_estado to "public" as "informix";
grant select on "informix".plan to "public" as "informix";
grant update on "informix".plan to "public" as "informix";
grant insert on "informix".plan to "public" as "informix";
grant delete on "informix".plan to "public" as "informix";
grant index on "informix".plan to "public" as "informix";
grant select on "informix".registra to "public" as "informix";
grant update on "informix".registra to "public" as "informix";
grant insert on "informix".registra to "public" as "informix";
grant delete on "informix".registra to "public" as "informix";
grant index on "informix".registra to "public" as "informix";
grant select on "informix".control to "public" as "informix";
grant update on "informix".control to "public" as "informix";
grant insert on "informix".control to "public" as "informix";
grant delete on "informix".control to "public" as "informix";
grant index on "informix".control to "public" as "informix";
grant select on "informix".resultado_analisis to "public" as "informix";
grant update on "informix".resultado_analisis to "public" as "informix";
grant insert on "informix".resultado_analisis to "public" as "informix";
grant delete on "informix".resultado_analisis to "public" as "informix";
grant index on "informix".resultado_analisis to "public" as "informix";
grant select on "informix".agrega_empleado to "public" as "informix";
grant update on "informix".agrega_empleado to "public" as "informix";
grant insert on "informix".agrega_empleado to "public" as "informix";
grant delete on "informix".agrega_empleado to "public" as "informix";
grant index on "informix".agrega_empleado to "public" as "informix";
grant select on "informix".sintoma to "public" as "informix";
grant update on "informix".sintoma to "public" as "informix";
grant insert on "informix".sintoma to "public" as "informix";
grant delete on "informix".sintoma to "public" as "informix";
grant index on "informix".sintoma to "public" as "informix";
















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
alter table "informix".entrevista add constraint (foreign key 
    (paciente) references "informix".paciente  on delete cascade 
    constraint "informix".entrevistaforeignpaciente);
alter table "informix".entrevista add constraint (foreign key 
    (empleado) references "informix".empleado  on delete cascade 
    constraint "informix".entrevistaforeignempleado);
alter table "informix".formulario add constraint (foreign key 
    (empleado,paciente,fecha) references "informix".entrevista 
     on delete cascade constraint "informix".formularioforeign);
    
alter table "informix".fiebre add constraint (foreign key (cod) 
    references "informix".formulario  on delete cascade constraint 
    "informix".fiebreforeign);
alter table "informix".dolor add constraint (foreign key (cod) 
    references "informix".formulario  on delete cascade constraint 
    "informix".dolorforeign);
alter table "informix".diagnostico add constraint (foreign key 
    (empleado,paciente,fecha_entrevista) references "informix"
    .entrevista  on delete cascade constraint "informix".diagnosticoforeign 
    index disabled);
alter table "informix".solicitud_analisis add constraint (foreign 
    key (diagnostico,empleado,paciente,fecha_entrevista) references 
    "informix".diagnostico  on delete cascade constraint "informix"
    .solicitudanalisisforeign);
alter table "informix".fisico add constraint (foreign key (cod) 
    references "informix".formulario  on delete cascade constraint 
    "informix".fisicoforeign);
alter table "informix".glasgow add constraint (foreign key (cod) 
    references "informix".formulario  on delete cascade constraint 
    "informix".glasgowforeign);
alter table "informix".paciente_estado add constraint (foreign 
    key (paciente) references "informix".paciente  on delete cascade 
    constraint "informix".pepaciente);
alter table "informix".paciente_estado add constraint (foreign 
    key (estado) references "informix".estado  on delete cascade 
    constraint "informix".peestado);
alter table "informix".plan add constraint (foreign key (empleado,
    paciente,fecha_entrevista) references "informix".entrevista 
     on delete cascade constraint "informix".planforeign);
alter table "informix".registra add constraint (foreign key (empleado) 
    references "informix".empleado  on delete cascade constraint 
    "informix".pempleado);
alter table "informix".registra add constraint (foreign key (paciente) 
    references "informix".paciente  on delete cascade constraint 
    "informix".ppaciente);
alter table "informix".control add constraint (foreign key (plan,
    empleado,paciente,fecha_entrevista) references "informix".plan 
     on delete cascade constraint "informix".controlforeign);
alter table "informix".resultado_analisis add constraint (foreign 
    key (solicitud,empleado,paciente,fecha_entrevista,diagnostico) 
    references "informix".solicitud_analisis  on delete cascade 
    constraint "informix".resultadoanalforeign);
alter table "informix".agrega_empleado add constraint (foreign 
    key (empleado) references "informix".empleado  on delete cascade 
    constraint "informix".agregaempforeign);
alter table "informix".agrega_empleado add constraint (foreign 
    key (administrador) references "informix".administrador  on 
    delete cascade constraint "informix".adminagregaforeign);
alter table "informix".sintoma add constraint (foreign key (empleado,
    paciente,fecha_entrevista) references "informix".entrevista 
     on delete cascade constraint "informix".sintomaforeign);







 



