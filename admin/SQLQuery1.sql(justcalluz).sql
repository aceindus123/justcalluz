



select * from DataStatus_Details

select * from modulesdata

select * from Cities where state_name='Andhra Pradesh'

select * from Cities

select top 10 * from modulesdata where Category='Builders' (Category='5 Star Hotels' or Category='Luxury Restaurants' or Category='Hotels & Resorts' or Category='Restaurant & Pubs') and ApprovedStatus=1

select * from Admin_WebAdminCreation where email='ramesh@justcalluz.com'

select * from Admin_WebAdminCreation

update Admin_WebAdminCreation set UInfo=1 where empid=1

alter table Admin_WebAdminCreation add Country nvarchar(50)

select * from  Register

select * from ModulesData where module='Hotel' and UserLoginId='mahi.siddineni@gmail.com'

select * from ModulesData where (Category=('Dth Broadcast-Tata Sky') or company_name=('Dth Broadcast-Tata Sky') or SubCategory=('Dth Broadcast-Tata Sky')) and City='Hyderabad' and ApprovedStatus='1' order by id desc

select * from impordsample_ss
insert into impordsample_ss(sname) values('ss')

SELECT *
INTO Wizardsemail9.TableName
FROM jcalluz.jcalluz_exception


select * from jcalluz_exception order by 1 desc



select * from ModulesData where Category='Dth Broadcast-Tata Sky' or Category='5 Star Hotels'

update modulesdata set company_name='Leonia Holistic Destination' where id=2252 


select * from ModulesData where Category='Dth Broadcast-Tata Sky' or company_name='Dth Broadcast-Tata Sky'



D_Rol2.wmv

select * from Ads 

update Ads set City ='Hyderabad' where adID=27

select * from Adreviews

select * from SuccessStories 

update SuccessStories set PhotoName='Image009.jpg' where PhotoName='image/pjpeg'
update SuccessStories set PhotoContentType='image/pjpeg' where PhotoContentType='Adimin control.jpg'

update SuccessStories set VideoName='D_Roll1.wmv' where VideoName='D_Rol2.wmv'


select * from Movies where URL='http://www.inox.co.in/'

update Movies set URL='http://www.inox.co.in/' where URL='http://www.inox.com'

update Movies set URL='http://www.inox.co.in/' where URL='http://www.inoxmovies.com'

select * from register where email='ssiddineni_aceindus@yahoo.com' order by 1 desc

select * from  Registrationform
select * from Advertising

select * from ModulesData order by 1 desc

update register set iStatus=0 where email='ssiddineni@aceindus.in'

select * from register where email='ssiddineni@aceindus.in' order by 1 desc
delete register where email='ssiddineni@aceindus.in'

select * from LoggedInUser

select * from [Room]

select * from [User]

select * from LoggedInUser

select column_name,data_type from information_schema.columns where table_name='LoggedInUser'

select column_name,data_type from information_schema.columns where table_name='User'

select column_name,data_type from information_schema.columns where table_name='Room'


alter table Room drop column Userid

alter table Room add Userid int default(0)

