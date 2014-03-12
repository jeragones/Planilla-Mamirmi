use Mamirmi
Go
--Creacion de tipos de datos, reglas y valores por defecto


go
create default DidBranchOffice as 'Manufacturera'
go
create default DidDepartment as 'Pelador'
go
create default Dworkday as 'diurnal'
go
create rule RBranchOffice  as ( @idBranchOffice  in('Financiera','Manufacturera'))
go
exec sp_addtype 'TidBranchOffice','varchar (50)', 'not null'
go
exec sp_bindrule 'RBranchOffice', 'TidBranchOffice'
go
exec sp_bindefault 'TidBranchOffice','DidBranchOffice'

go
create rule RDepartment as (@idDepartment like '%')
go
exec sp_addtype 'TidDepartment','varchar(50)', 'not null'
go
exec sp_bindrule 'RDepartment','TidDepartment'
go
exec sp_bindefault 'DidBranchOffice','TidBranchOffice'

go
create rule Rworkday as (@workday in ('diurnal', 'nocturnal', 'mixed'))
go
exec sp_addtype 'Tworkday','varchar(9)', 'not null'
go
exec sp_bindrule 'Rworkday','Tworkday'
go
exec sp_bindefault 'Dworkday','Tworkday'

CREATE RULE RID_Person AS (@Person like '[0-9]-[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'
					or
					@Person like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
GO
EXEC sp_addtype		'TId','char (12)', 'not null'
GO
EXEC sp_bindrule	'RID_Person','TId'
GO
CREATE RULE RTelephone AS
	(@telephone like '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]')
	or
	(@telephone like '([0-9][0-9][0-9]) [0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]')
GO
EXEC sp_addtype		'TTelephone', 'varchar (17)', 'not null'
GO
EXEC sp_bindrule	'RTelephone','TTelephone'
GO　
CREATE DEFAULT DGender AS 'F'
go
CREATE RULE RGender AS (@Gender in ('F','M'))
GO
EXEC sp_addtype		'TGender', 'char (1)', 'not null'
GO
EXEC sp_bindrule	'RGender','TGender'
GO
EXEC sp_bindefault	'DGender','TGender'
GO　
















--Creacion de tablas
--creacion de la tabla Person

CREATE TABLE person
(
	id		 TId,
	name		 VARCHAR(30)		NOT NULL,
	lastname1	 VARCHAR(30)		NOT NULL,
	lastname2	 VARCHAR(30)		NOT NULL,
	age tinyint NOT NULL,
	Nacionality VARCHAR(30) NOT NULL,
	direction	 VARCHAR(200)	 NOT NULL,
	sex			 Tgender,
	income_date VARCHAR(20)
	CONSTRAINT pk_id_person PRIMARY KEY (id),
)
GO

go
--Creacion de la tabla branch office, tabla que especifica la sucursal de la empresa 
create table BranchOffice 
(
	idBranchOffice TidBranchOffice,
	location varchar (200),
	typeBranchOffice varchar(20),
	fax varchar(11),

	constraint pk_ID_BranchOffice primary key (idBranchOffice),
	constraint unique_IdBranchOffice unique (idBranchOffice),
)
--Especifica el departamento al cual trabajan los empleados
create table Department
(
	idDepartment TidDepartment,
	Name varchar(30),
	BranchOffice varchar(50) not null,
	Manager char (12),
	SubManager char(12),
	

	constraint pk_ID_Department primary key(idDepartment),
	constraint unique_IdDepartment unique (idDepartment),
	constraint fk_ID_BranchOffice foreign key (Branchoffice) references BranchOffice,
	constraint fk_Department_Person_Manager foreign key(Manager) references Person,
	constraint fk_Department_Person_subManager foreign key(SubManager) references Person
)

go
CREATE TABLE Employee
(
	
	ID_Employee		TINYINT		NOT NULL,
	ID_Persona char(12) NOT NULL,
	BankAccBN		VARCHAR(15) NOT NULL,
	BankAccBP		VARCHAR(15) NOT NULL,
	
	CONSTRAINT pk_ID_Persona PRIMARY KEY (ID_Employee,ID_Persona),
	CONSTRAINT fk_ID_Employee FOREIGN KEY (ID_Persona) REFERENCES Person
)

GO
--Tabla tarros que especifica la cantidad de tarros que retorna un empleado de la fabrica
CREATE TABLE Barrel
(
	IDPerson		char(12)		not null,
	Total_Barrels	TINYINT		null,
	Date_Barrels	DATE		not null,
	
	
	CONSTRAINT pk_ID_Person_Date_Barrel PRIMARY KEY (IDPerson,Date_Barrels),
	CONSTRAINT fk_ID_Person_Barrel FOREIGN KEY (IDPerson) REFERENCES Person
)

--Guarda informacion de las incapacidades que ha tenido un empleado
CREATE TABLE Incapacity
(
	IDPerson						char(12)		not null,
	Departure_Date_Incapacity		DATE			not null,
	Entry_Date_Incapacity			DATE			not null,
	Incapacity_Info					VARCHAR(200)		null,
	
	CONSTRAINT pk_ID_Person_Incapacity  PRIMARY KEY (IDPerson),
	CONSTRAINT fk_ID_Person_Incapacity  FOREIGN KEY (IDPerson) REFERENCES Person	
)
--Tabla de los salarios que se le pagan a los empleados
create table Salary
(
	ID_Person char(12) not null,
	Gross_salary decimal(20,8) not null,
	Net_salary decimal (20,8)not null,
	Workday Tworkday,--jornada laboral
	CCSS decimal(20,8) not null,
	Christmas_savings decimal(16,6),
	School_saving decimal(16,6),
	Salary_Date date,
	Others decimal(16,6),
	idSalary  int  identity(1,1)

	constraint pk_ID_Salary_Salary primary key (idSalary,ID_Person) ,
	constraint fk_ID_Person_Salary foreign key (ID_Person) references Person,
)
--Tabla de horas que ha trabajado un empleado en un lapso determinado
create table Hours
(
	idHours int identity(1,1),
	ID_Person char(12) not null,
	Initial_date date not null,
	Final_date date not null,
	Ordinary_Hours decimal(10,5) not null,
	Extras_Hours decimal (10,5) not null

	constraint pk_ID_Hours_hours primary key (idHours),
	constraint fk_ID_Person_Person_hours foreign key(ID_Person) references Person
)

CREATE TABLE Telephone
(
	id			CHAR(12)	NOT NULL,
	telephone	TTelephone	NOT NULL,
	CONSTRAINT	pk_idTelephone_Telephone	PRIMARY KEY (id,telephone),
	CONSTRAINT	fk_id_telephone			FOREIGN KEY (id) REFERENCES person
)
GO
　
CREATE TABLE Resignation
(
	ID_Person			char(12) NOT NULL,
	DepartureDate		TINYINT		NOT NULL,
	ResignationInfo		VARCHAR(15) NOT NULL,
	CONSTRAINT fk_ID_Person_Resegnation FOREIGN KEY (ID_Person) REFERENCES Person
)
go
create table "Christmas box"
(
ID_Employee	tinyint NOT NULL,
Christmas_box_Payment money NOT NULL,
Christmas_box_Date date NOT NULL,
CONSTRAINT fk_employee_cb FOREIGN KEY (ID_Employee) REFERENCES Employee
)
go

create table Vacation
(
ID_Employee	 tinyint NOT NULL,
Entry_Date date NOT NULL,
Departure_Date date NOT NULL,
Vacation_Days int NOT NULL,

CONSTRAINT fk_ID_Employee_Vacation FOREIGN KEY (ID_Employee) REFERENCES Employee
)

--Procedimentos de insersion, modificacion y borrado de las tablas

go

create procedure insertPerson
(
 @ID_Person		char(12),
 @Name			varchar(30),
 @Last_Name1    varchar(30), 
 @Last_Name2	varchar(30), 
 @Age           tinyint, 
 @Nacionality	varchar(30), 
 @Direction		varchar(200),	 
 @Gender        char(1), 
 @Department	varchar(50)
)
as
begin
  insert Person values (@ID_Person, @Name, @Last_Name1,  @Last_Name2,  @Age,  @Nacionality,  @Direction, @Gender,NULL ,  @Department)
end

go
create procedure insertDepartment
(
	@idDepartment varchar(50),
	@name varchar(30),
	@branch varchar(50),
	@manager char(12),
	@submanager char(12),
	@cost decimal (20,8)
)
as
begin
	IF (@manager='')
	begin
		select @Manager = null
	end
	if (@subManager='')
	begin
		select @subManager = null
	end
	if (@cost=0)
	begin
		select @cost = null
	end
	insert Department (idDepartment, Name, BranchOffice, Manager, SubManager, Hour_Cost) 
	values (@idDepartment, @name,@branch,@Manager, @submanager,@cost)
end
go
 create procedure insertBarrel
 (
	@ID_Person char(12),
	@Barrel_Date date,
	@Total_Barrel tinyint


 )as
 begin
	insert Barrel
		values(@ID_Person, @Barrel_Date, @Total_Barrel)
end
go

create procedure insertBranch
(
	@idBranch varchar(50),
	@location varchar(200),
	@type varchar(20),
	@fax varchar(11)
)as
begin
	if (@fax='')
	begin
		select @fax=null
	end
	insert BranchOffice values (@idBranch,@location, @type,@fax)
end

go
create procedure insertIncapacity
(
	@idEmployee char(12),
	@info varchar(200),
	@Departure_Date date,
	@Entry_Date date
)
as
begin
	insert Incapacity values (@idEmployee,@info, @Departure_date,@Entry_Date)
end
go
create procedure insertSalary
(
	@person char(12),
	@gross decimal (20,8),
	@christmas decimal (20,8),
	@school decimal(20,8),
	@date date,
	@other decimal (20,8)
)
as
begin	
declare
		@net decimal (20,8),
		@ccss decimal (20,8)
	--print ('No sirve convertir los numero')
	select @ccss = ((@gross)*(9.17/100))
	select @net = (select @gross)-(select @christmas)-(select @school)-(select @other)-(select @ccss)
	insert Salary (ID_Person, Gross_salary,Net_salary,CCSS,Christmas_savings,School_saving,Salary_Date,Others) 
		   values (@person,@gross,@net,@ccss,@christmas,@school,@date,@other)
end

go
 create procedure insertHours
 (
	@ID_Person char(12),
	@Initial_date date,
	@Final_date date,
	@Ordinay_Hours decimal(10,5),
	@Extras_Hours decimal (10,5)

 )as
 begin
	insert Hours(ID_Person,Initial_date,Final_date,Ordinary_Hours, Extras_Hours)
		values(@ID_Person,@Initial_date,@Final_date,@Ordinay_Hours,@Extras_Hours)
end
go
create procedure insertResignation
(
	@ID_Person		char(12),
	@DepartureDate  date,
	@ResignationInfo  varchar (15),
	@Resignation_Payment   decimal(20,8)
)
as
begin
insert Resignation values(@ID_Person, @DepartureDate, @ResignationInfo, @Resignation_Payment)
end
GO
CREATE PROCEDURE insertChristmasBox
(
	@Christmas_box_Payment money,
	@Christmas_box_Date date,
	@ID_Person char(12)
	
)
AS
BEGIN
	insert [Christmas box] values (@Christmas_box_Payment,@Christmas_box_Date,@ID_Person)	
END
go

create procedure insertTelephone
(
 @ID_Person char(12),
 @Telephone varchar(17)

)
as
begin
  insert Telephone values (@ID_Person, @Telephone)
end


go
create procedure insetVacation
(
 @ID_Person char(12),
 @Departure_Date date,
 @Entry_Date date
)
as
begin
	insert Vacation values (@ID_Person,@Departure_Date,@Entry_Date)
end



GO　
Create procedure insertAdditionalInformation
(
	@Person char(12),
	@Color_Skin char(10),
	@Mustache char(10),
	@Eyes char(10),
	@Height char(10),
	@Face char(30),
	@Hair char(10),
	@Texture char(10),
	@Teeth char(10),
	@Tic char(30),
	@Tattoo char(30),
	@Write bit,
	@Read bit,
	@FatherName char(30),
	@FatherProfession char(10),
	@FatherWorkplace char(20),
	@Fatheradress char(50),
	@MotherName char(30),
	@Motheradress char(50),
	@MotherWorkplace char(20),
	@MotherProfession char(50),
	@SpouseName char(30),
	@SpouseProfession char(10),
	@SpouseAdress char(50),
	@SpouseWorkplace char(20),
	@Disease char(100),
	@Smoke bit,
	@Drunk bit,
	@BloodGroup char(3),
	@EmergencyTeleph char(16)
)
AS
BEGIN
	if (@Person = '')
	BEGIN
		ROLLBACK TRAN
	END	
	if (@Color_Skin = '')
	BEGIN
		select @Color_Skin = NULL
	END	
	if (@Eyes = '')
	BEGIN
		select @Eyes = NULL
	END	
	if (@Mustache= '')
	BEGIN
		select @Mustache = NULL
	END	
	if (@Height = '')
	BEGIN
		select @Height = NULL
	END	
	if (@Face = '')
	BEGIN
		select @Face = NULL
	END	
	if (@Hair = '')
	BEGIN
		select @Hair= NULL
	END	
	if (@Texture = '')
	BEGIN
		select @Texture = NULL
	END	
	if (@Teeth = '')
	BEGIN
		select @Teeth = NULL
	END	
	if (@Tic= '')
	BEGIN
		select @Tattoo = NULL
	END	
	if (@FatherName = '')
	BEGIN
		select @FatherName = NULL
	END	
	if (@FatherWorkplace = '')
	BEGIN
		select @FatherWorkplace = NULL
	END	
	if (@FatherProfession = '')
	BEGIN
		select @FatherProfession = NULL
	END	
	if (@Fatheradress = '')
	BEGIN
		select @Fatheradress = NULL
	END	
	if (@MotherName = '')
	BEGIN
		select @MotherName = NULL
	END	
	if (@MotherProfession= '')
	BEGIN
		select @MotherProfession = NULL
	END	
	if (@Motheradress = '')
	BEGIN
		select @Motheradress = NULL
	END	
	if (@MotherWorkplace = '')
	BEGIN
		select @MotherWorkplace = NULL
	END	
	if (@SpouseAdress = '')
	BEGIN
		select @SpouseAdress = NULL
	END	
	if (@SpouseName = '')
	BEGIN
		select @SpouseName = NULL
	END	
	if (@SpouseProfession = '')
	BEGIN
		select @SpouseProfession = NULL
	END	
	if (@SpouseWorkplace = '')
	BEGIN
		select @SpouseWorkplace = NULL
	END	
	if (@Disease = '')
	BEGIN
		select @Disease = NULL
	END	
	if (@BloodGroup= '')
	BEGIN
		select @SpouseWorkplace = NULL
	END	
	if (@EmergencyTeleph= '')
	BEGIN
		select @EmergencyTeleph = NULL
	END	
	insert [Additional Information] values (
	@Person,
	@Color_Skin,
	@Mustache,
	@Eyes,
	@Height,
	@Face,
	@Hair,
	@Texture,
	@Teeth,
	@Tic,
	@Tattoo,
	@Write,
	@Read,
	@FatherName,
	@FatherProfession,
	@FatherWorkplace,
	@Fatheradress,
	@MotherName,
	@Motheradress,
	@MotherWorkplace,
	@MotherProfession,
	@SpouseName,
	@SpouseProfession,
	@SpouseAdress,
	@SpouseWorkplace,
	@Disease,
	@Smoke,
	@Drunk,
	@BloodGroup,
	@EmergencyTeleph 
END

create procedure updatePerson 
(
 @ID_Person		char(12),
 @Name			varchar(30),
 @Last_Name1    varchar(30),
 @Last_Name2	varchar(30),
 @Age           tinyint,
 @Nacionality	varchar(30),
 @Direction		varchar(200), 
 @Gender        char(1), 
 @Entry_Date    varchar(20),
 @Department	varchar(50)
)
as
begin
  update Person set  Name = @Name, Last_Name1 =  @Last_Name1, Last_Name2 = @Last_Name2, Age = @Age, Nacionality = @Nacionality, Direction = @Direction,
					 Gender = @Gender, Entry_date = @Entry_Date , Department = @Department where ID_Persona = @ID_Person
end

go
create procedure updateBranch
(
	@branch varchar(50),
	@location varchar(200),
	@type varchar(20),
	@fax varchar(11)
)
as
begin
	update BranchOffice set location=@location, typeBranchOffice=@type,fax=@fax
		where idBranchOffice=@branch
end

go

--Consultas con alto grado de procesamieno


GO
create procedure updateBarrel
(
 @IDPerson char(12),
 @Total_Barrels tinyint,
 @Date_Barrels date
 
)
as
begin
	update Barrel
	set	Total_Barrels = @Total_Barrels,
		Date_Barrels = @Date_Barrels
	where IDPerson = @IDPerson
end

GO

create procedure updateIncapacity
(
 @IDPerson char(12),
 @Departure_Date_Incapacity date,
 @Entry_Date_Incapacity date,
 @Incapacity_Info varchar(200)
 
)
as
begin
	update Incapacity
	set	Departure_Date_Incapacity = Departure_Date_Incapacity,
		Entry_Date_Incapacity = @Entry_Date_Incapacity,
		Incapacity_Info = @Incapacity_Info
	where IDPerson = @IDPerson
end

go


create procedure updatePerson 
(
 @ID_Person		char(12),
 @Name			varchar(30),
 @Last_Name1    varchar(30),
 @Last_Name2	varchar(30),
 @Age           tinyint,
 @Nacionality	varchar(30),
 @Direction		varchar(200), 
 @Gender        char(1), 
 @Entry_Date    varchar(20),
 @Department	varchar(50)
)
as
begin
  update Person set  Name = @Name, Last_Name1 =  @Last_Name1, Last_Name2 = @Last_Name2, Age = @Age, Nacionality = @Nacionality, Direction = @Direction,
					 Gender = @Gender, Entry_date = @Entry_Date , Department = @Department where ID_Persona = @ID_Person
end
go



--consulta que devuelve una tabla con el promedio de las horas ordinarias y extras que tiene cada departamento,
--para la realizacion de esta consulta fue necesario la utilizacion de una tabla temporal y un cursor
create procedure queryAverage_Hours_Department
AS
begin
	declare
		@idDepa varchar(50),
		@OH decimal (20,8),
		@EH decimal (20,8)

	create table #T
	(
		Departamento varchar (50),
		"Promedio de horas extra" decimal (20,8),
		"Promedio de horas ordinarias" decimal (20,8)
	)
		declare Depa cursor
	for 
		select idDepartment from Department
	open Depa
	Fetch next from Depa into @idDepa
	while @@FETCH_STATUS=0
	begin
		select @EH = 
		(
			select  avg(ph.Extras_Hours) from Department d inner join
			(
				select * from Person p inner join Hours as h on p.ID_Persona = h.ID_Person
			) as 
			ph on ph.Department = @idDepa
		)
		select @OH = 
		(
			select  avg(ph.Ordinary_Hours) from Department d inner join
			(
				select *from Person p inner join Hours as h on p.ID_Persona = h.ID_Person
			) as ph on ph.Department=@idDepa
		)
		insert #T values(@idDepa,@EH,@OH)
		fetch next from Depa into @idDepa
	end
	close Depa
	deallocate Depa
	select *from #T order by #T.[Promedio de horas ordinarias] DESC
	drop table #T
end

--consulta que devuelve una table con el promedio de horas extras y ordinarias que ha tenido cada empleado
--para la realizacion de esta consulta fue necesario la creacion de una tabla temporal
go
create procedure queryAverage_Hours_Person
AS
	declare
		@idper varchar(50),
		@OH decimal (20,8),
		@EH decimal (20,8)

	create table #T
	(
		Persona char (12),
		"Promedio de horas extra" decimal (20,8),
		"Promedio de horas ordinarias" decimal (20,8)
	)
		declare cursorPersona cursor
	for 
		select ID_Persona from Person
	open cursorPersona
	Fetch next from cursorPersona into @idper
	while @@FETCH_STATUS=0
	begin
		select @EH = 
		(
			select avg(h.Extras_Hours) from Hours h where h.ID_Person=@idper 
		)
		select @OH = 
		(
			select  avg(h.Ordinary_Hours) from Hours h where h.ID_Person=@idper
		)
		insert #T values(@idper,@EH,@OH)
		fetch next from cursorPersona into @idper
	end
	close cursorPersona
	deallocate cursorPersona
	select #T.Persona, (p.Last_Name1+' '+p.Last_Name2+' '+p.Name) as "Nombre completo",#T.[Promedio de horas extra],#T.[Promedio de horas ordinarias]  
	from person as p inner join #T on #T.Persona = p.ID_Persona
	 order by #T.[Promedio de horas ordinarias] DESC
	drop table #T



--consulta que devuelve el promedio de salario neto que han ganado los empleados
--para la realizacion de esta consulta fue necesario una tabla temporal
go
create procedure queryAverage_Salary_Person
as
	declare
	@idper char (12),
	@sala decimal(20,8)
	create table #T
	(
		Person char (12),
		salary decimal(20,8)
	)
	declare cursorPersona cursor
	for 
		select ID_Persona from Person
	open cursorPersona
	Fetch next from cursorPersona into @idper
	while @@FETCH_STATUS = 0
		begin
			select @sala = (select avg(Net_Salary )from Salary s where s.ID_Person = @idper )
			insert #T values(@idper,@sala)
			Fetch next from cursorPersona into @idper
		end
	close cursorPersona
	deallocate cursorPersona
	select *from #T
	drop table #T


--esta consulta es devuelve una consulta con el promedio de los salarios netos que trabajan en un departamento
--para la realizacion de esta consulta fue necesario la creacion de una tabla temporal y un cursor
go
create procedure queryAverage_Salary_Department
AS
	declare
		@idDepa varchar(50),
		@sala decimal (20,8)
	create table #T
	(
		Departamento varchar (50),
		"Promedio de salario" decimal (20,8)
	)
		declare Depa cursor
	for 
		select idDepartment from Department
	open Depa

	Fetch next from Depa into @idDepa
	while @@FETCH_STATUS=0
	begin
		select @sala = 
		(
			select avg(Net_salary)from Salary as s inner join 
			(
				select *from Person p where p.Department=@idDepa
			
			) pd on s.ID_Person=pd.ID_Persona
		)
		insert #T values(@idDepa,@sala)
		fetch next from Depa into @idDepa
	end
	close Depa
	deallocate Depa
	select *from #T order by #T.[Promedio de salario] DESC
	drop table #T
go
CREATE PROCEDURE queryMinMaxBarrels
AS
BEGIN
	
	DECLARE @IDPerson char(12)
	DECLARE @MaxBarrel decimal(2,1)
	DECLARE @MinBarrel decimal(2,1)
	
	CREATE TABLE #T 
	(
		IDPerson char(12) not null,
		MaxBarrel decimal (2,1),
		MinBarrel decimal(2,1) 
	)
	
	DECLARE cr_ListaBarriles CURSOR
	for select distinct Barrel.IDPerson 
	from Barrel
	
	OPEN cr_ListaBarriles
	
	FETCH NEXT FROM cr_ListaBarriles into @IDPerson
	
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
	
	
		select @MinBarrel = (select MIN(Barrel.Total_Barrels)
							from Barrel
							where @IDPerson = Barrel.IDPerson)
		
		select @MaxBarrel = (select MAX(Barrel.Total_Barrels)
							from Barrel
							where @IDPerson = Barrel.IDPerson)
							
		insert #T values (@IDPerson,@MaxBarrel,@MinBarrel)
		
		FETCH NEXT FROM cr_ListaBarriles into @IDPerson

	END
	
	CLOSE cr_ListaBarriles
	DEALLOCATE cr_ListaBarriles
	select * from #T
END

GO

CREATE PROCEDURE queryPercentByDepartment
AS
BEGIN
	DECLARE @TotalNumEmpleados int 
	DECLARE @numempleados int 
	DECLARE @Department varchar(50)
	
	CREATE TABLE #Y
	(
		PercentageEmployees decimal(5,2),
		Department varchar(50)
	)
	
	
	DECLARE cr_ViewEmployeesXDepartment cursor for  
	select * from UnitEmployeeXDepartment 
	
	OPEN cr_viewEmployeesXDepartment
	FETCH NEXT FROM cr_ViewEmployeesXDepartment into @numempleados,@Department
	
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		
		insert #Y values((@numempleados*100)/(select SUM(NumEmployees) from UnitEmployeeXDepartment),@Department)
		FETCH NEXT FROM cr_ViewEmployeesXDepartment into @numempleados,@Department
	END
	
	CLOSE cr_ViewEmployeesXDepartment
	DEALLOCATE cr_ViewEmployeesXDepartment 
	select * from #Y
END

go
create procedure queryPromBarrel(
@IDPerson  char(12),
@Inicial_Date date,
@End_Date date
)
AS
begin
select IDPerson, AVG(Total_Barrels) as "Promedio de Barriles" from Barrel  where IDPerson = @IDPerson and 
(@Inicial_Date <= Date_Barrels and Date_Barrels <=@End_Date) group by IDPerson
end

go
create procedure querryPromBarrelAllEmployee
as
begin
select IDPerson, AVG(Total_Barrels) as "Promedio de Barriles" from Barrel inner join Employee on ID_Person = IDPerson  group by IDPerson order by "Promedio de Barriles" desc 
end

go
create procedure querryPromHoursEmployee
as
begin
select H.ID_Person, AVG(Ordinary_hours) as "Promedio de Horas Ordinarias", AVG(Extras_Hours) as "Promedio de Horas Extras" from [Hours] as H inner join Employee as E on H.ID_Person = E.ID_Person
group by h.ID_Person order by "Promedio de Horas Ordinarias" DESC
end

go
create procedure querryEmployDay
AS
begin

select ID_Persona as 'Activos', ((year(GETDATE()) - Year(Entry_date))*365) + ((MONTH(GETDATE())-MONTH(Entry_date)))*30 + DAY(GETDATE())-DAY(Entry_date) as Dias from Person
inner join Employee on ID_Persona = ID_Person 

select ID_Persona as 'Despedidos', (year(DepartureDate) - Year(Entry_date)*365) + (MONTH(DepartureDate)-MONTH(Entry_date))  as Dias from Person
inner join Resignation on ID_Persona = ID_Person 
end

GO

create procedure queryIncapacity
(
 @IDPerson char(12)
)
as
begin
	select * from Person
	where ID_Persona = @IDPerson
end
GO

create procedure queryVacation
(
 @IDPerson char(12)
)
as
begin
	select *
	from Vacation
	where ID_Person = @IDPerson
end

go
create procedure queryBranch
(
	@idBranch varchar(50)
)
as
begin
	select *from BranchOffice bo where bo.idBranchOffice=@idBranch 
end
go
create procedure queryDepartment
(
	@department varchar (50)
)
as
begin
	select *from Department where idDepartment =@department
end
go

create procedure querySalary
(
	@person char (12),
	@date date
)
as
begin
	select *from Salary s where s.ID_Person=@person and s.Salary_Date=@date
end

go

GO

create procedure deleteIncapacity
(
 @IDPerson char(12)
)
as
begin
	delete Incapacity
	where IDPerson = @IDPerson
end

GO

create procedure deleteBarrel
(
 @IDPerson char(12),
 @Date_Barrels date
)
as
begin
	delete Barrel
	where IDPerson = @IDPerson and Date_Barrels = @Date_Barrels
end

go

create procedure deleteIncapacity
(
 @IDPerson char(12),
 @Departure_Date_Inpacity date,
 @Entry_Date_Inpacity date,
 @Incapacity_Info varchar(200)
)
as
begin
	delete Incapacity
	where IDPerson = @IDPerson
end


create procedure deleteAdditionalinformation
(@ID_Person char (12))
AS
begin
delete [Additional Information] where @ID_Person = Person
end
create procedure deleteSalary
(
	@person char(12)
)
as
begin
	declare
		@cant int
	select @cant = (select count(@person) from Salary)
	if (@cant>0)
	begin
		delete Salary where ID_Person=@person
	end
	else
	begin
		print ('No tiene Salarios asignados')
	end
end
 go
create procedure deleteVacation
(
 @ID_Person char(12)

)
as
begin
  delete Vacation where  ID_Person = @ID_Person
end


go
create procedure deletePerson
(
 @ID_Person		char(12)
)
as
begin
  delete Telephone where ID_Telephone = @ID_Person
  delete Barrel where IDPerson = @ID_Person
  delete Incapacity where IDPerson = @ID_Person
  delete [Christmas box] where ID_Person = @ID_Person
  delete Salary where ID_Person = @ID_Person
  delete [Vacation] where ID_Person = @ID_Person
  if (Select * from Deparment where Manager = @ID_Person) is NULL
  begin
	update Deparment set Manager = NULL
  end
  if (Select * from Deparment where SubManager = @ID_Person) is NULL
  begin
	update Department set SubManager = NULL
  end 
  delete Resignation where ID_Person = @ID_Person
  delete Employee where ID_Person = @ID_Person
  delete Person where ID_Persona = @ID_Person
end





---Trigger de las tablas de la base de datos

--Triger que se ejecuta cuado se inserta un nuevo salario de una persona y valida que no se puedan insertar salarios netos mayores a un salario bruto
create trigger trigger_Salary_NetSalary
on Salary
for insert
as
	declare
		@net decimal(20,8),
		@gross decimal(20,8)
	select @net = (select Net_salary from inserted)
	select @gross = (select Gross_salary from inserted)

	if (@net >@gross)
	begin
	print (' No es posible realizar su transaccion ')
		rollback tran
	end
go


create trigger trigger_Hours_Initial_Final
on Hours
for insert
	as
	declare
		@ini date = (select Initial_date from inserted),
		@fin date = (select Final_date from inserted)
	if (@ini>@fin)
	begin
		print ('Error procesando las fechas')
		rollback tran
	end

go
create trigger trigger_Department_Cost_Hour
on Department
for	update
as
	declare 
		@per char(12),
		@idDepa varchar(50)
		select @idDepa = (select idDepartment from updated)
	Declare Person cursor
	For 
		select ID_Persona from Person
	open Person
	Fetch next from Person into @per
	while @@FETCH_STATUS=0
	begin
		declare
			@cost decimal (20,8) = (select Hour_Cost from Employee e where e.ID_Person = @per),
			@costDepa decimal(20,8) = (select Hour_Cost from Department d where d.idDepartment = @idDEpa )
		
			if (@cost<= @costDepa )
			begin
				update Employee  
				set Hour_Cost = (select Hour_cost from updated ) 
				where ID_Person = @per
			end
		fetch next from Person into @per
	end
	close Person
	deallocate Person

go
CREATE TRIGGER  TRG_ValidarVacacionesBarriles
on Barrel
for insert
AS
BEGIN
	DECLARE @Date date
	DECLARE @IDPerson char(12)
	
	DECLARE cr_ListaBarriles cursor for 
	select IDPerson,Date_Barrels from inserted
	
	OPEN cr_ListaBarriles
	
	FETCH NEXT FROM cr_ListaBarriles INTO @IDPerson,@Date
	
	WHILE (@@FETCH_STATUS = 0)
	BEGIN 
	
		DECLARE cr_ListaVacaciones CURSOR for 
		select Vacation.Departure_Date, Vacation.Entry_Date
		from Vacation 
		Where Vacation.ID_Person = @IDPerson
		
		OPEN cr_ListaVacaciones
		
		DECLARE @Entrada date
		Declare @Salida date
		
		FETCH NEXT FROM cr_ListaVacaciones into @Entrada, @salida
		
		WHILE(@@FETCH_STATUS = 0)
		BEGIN
		
			if (@Date<@Entrada or @Date >= @Salida)
			BEGIN
				COMMIT TRAN
			END
			
			else
			BEGIN
				raiserror('El usuario insertado está en vacaciones!',1,1)
				ROLLBACK TRAN
			END
		END
		CLOSE cr_ListaVacaciones 
		DEALLOCATE cr_ListaVacaciones
	END
	CLOSE cr_ListaBarriles 
	DEALLOCATE cr_ListaBarriles
END

GO



CREATE TRIGGER  TRG_ValidarIncapacidadBarriles
on Barrel
for insert
AS
BEGIN
	DECLARE @Date date
	DECLARE @IDPerson char(12)
	
	DECLARE cr_ListaBarriles cursor for 
	select IDPerson,Date_Barrels from inserted
	
	OPEN cr_ListaBarriles
	
	FETCH NEXT FROM cr_ListaBarriles INTO @IDPerson,@Date
	
	WHILE (@@FETCH_STATUS = 0)
	BEGIN 
	
		DECLARE cr_ListaVacaciones CURSOR for 
		select Incapacity.Departure_Date_Incapacity, Incapacity.Entry_Date_Incapacity
		from Incapacity 
		Where Incapacity.IDPerson = @IDPerson
		
		OPEN cr_ListaVacaciones
		
		DECLARE @Entrada date
		Declare @Salida date
		
		FETCH NEXT from cr_ListaVacaciones  into @Entrada, @salida
		
		WHILE(@@FETCH_STATUS = 0)
		BEGIN
		
			if (@Date<@Entrada or @Date >= @Salida)
			BEGIN
				COMMIT TRAN
			END
			
			else
			BEGIN
				raiserror('El usuario insertado está incapacitado!',1,1)
				ROLLBACK TRAN
			END
		END
		CLOSE cr_ListaVacaciones 
		DEALLOCATE cr_ListaVacaciones
	END
	CLOSE cr_ListaBarriles 
	DEALLOCATE cr_ListaBarriles
END

--- Creacion de vistas



go
create view info_Employee
AS (
Select ID_Employee, ID_Persona ,name, last_Name1, Last_Name2, Age, Nacionality, Direction, Gender, Entry_date, Department, BankAccBN, BankAccBP from Person as P inner join Employee as E on p.ID_Persona = E.ID_Person)

create view Telephone_Person AS
(
Select ID_Persona, name, last_Name1, Last_Name2, Age, Nacionality, Direction, Gender, Entry_date, Department, Telephone from Person as P inner join Telephone as T on P.ID_Persona = T.ID_Person)


create view Resignation_Person
AS
(Select ID_Persona, name, last_Name1, Last_Name2, Age, Nacionality, Direction, Gender, Entry_date, Department, DepartureDate, ResignationInfo  from Person as P inner join Resignation as R on P.ID_Persona = R.ID_Person)

create view Person_Vacation
AS
(Select ID_Persona, name, last_Name1, Last_Name2, Age, Nacionality, Direction, Gender, Department, Departure_Date, V.Entry_Date from Person as P
inner join Vacation as V on P.ID_Persona = V.ID_Person)
select * from Telephone_Person


















