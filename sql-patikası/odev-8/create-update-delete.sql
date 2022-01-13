/*
1. test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.
2. Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
3. Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.
4. Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.
*/
/*
CREATE TABLE employee(
	id SERIAL PRIMARY KEY,
	name VARCHAR(50) NOT NULL,
	birthday DATE,
	email VARCHAR(100)
);
*/

/*
insert into employee (name, birthday, email) values ('Vasily', null, null);
insert into employee (name, birthday, email) values ('Jose', '1941-07-27', 'jmabley1@lulu.com');
insert into employee (name, birthday, email) values ('Lambert', '1916-11-04', 'lmcwilliam2@friendfeed.com');
insert into employee (name, birthday, email) values ('Ki', '1951-05-28', 'kabbett3@fda.gov');
insert into employee (name, birthday, email) values ('Humfried', '1906-08-29', 'hodwyer4@ask.com');
insert into employee (name, birthday, email) values ('Sal', '1933-08-07', 'schrestien5@dell.com');
insert into employee (name, birthday, email) values ('Althea', '1992-09-03', 'athynn6@oaic.gov.au');
insert into employee (name, birthday, email) values ('Lalo', '1981-02-14', 'lucceli7@mapy.cz');
insert into employee (name, birthday, email) values ('Kelsey', null, 'kclines8@privacy.gov.au');
insert into employee (name, birthday, email) values ('Conrade', '1992-11-26', 'chunday9@mtv.com');
insert into employee (name, birthday, email) values ('Adria', null, 'agiacobellia@photobucket.com');
insert into employee (name, birthday, email) values ('Ruddy', '1905-10-11', 'rlednerb@craigslist.org');
insert into employee (name, birthday, email) values ('Brook', '1928-05-31', 'bbrierleyc@google.co.uk');
insert into employee (name, birthday, email) values ('Parsifal', '1951-03-13', 'pmayhod@icio.us');
insert into employee (name, birthday, email) values ('Tobit', '1991-02-10', 'tosullivane@digg.com');
insert into employee (name, birthday, email) values ('Magda', '1912-11-13', 'mcapinif@bandcamp.com');
insert into employee (name, birthday, email) values ('Keane', '1959-05-13', 'kfeenyg@ifeng.com');
insert into employee (name, birthday, email) values ('Huberto', null, null);
insert into employee (name, birthday, email) values ('Shamus', '1977-08-27', 'sbalassai@ow.ly');
insert into employee (name, birthday, email) values ('Halli', null, null);
insert into employee (name, birthday, email) values ('Corinne', '1939-09-17', 'cmeredithk@imdb.com');
insert into employee (name, birthday, email) values ('Johnathon', null, 'jbockingl@reuters.com');
insert into employee (name, birthday, email) values ('Ernesta', '1946-11-19', 'enorcockm@google.com.au');
insert into employee (name, birthday, email) values ('Skye', '1970-03-07', 'stytcombn@spotify.com');
insert into employee (name, birthday, email) values ('Gale', '1992-11-30', 'gforkano@ebay.co.uk');
insert into employee (name, birthday, email) values ('Saunderson', '1913-06-24', null);
insert into employee (name, birthday, email) values ('Coleen', '1943-05-26', null);
insert into employee (name, birthday, email) values ('Hattie', '1900-08-07', 'htoothillr@purevolume.com');
insert into employee (name, birthday, email) values ('Branden', '1982-08-21', 'bmoorings@yale.edu');
insert into employee (name, birthday, email) values ('Tessy', '1924-07-15', 'theigoldt@about.me');
insert into employee (name, birthday, email) values ('Zacharie', '1937-08-28', 'zgiraudotu@technorati.com');
insert into employee (name, birthday, email) values ('Joey', '1981-08-14', 'jmioniv@bandcamp.com');
insert into employee (name, birthday, email) values ('Bobby', '1957-03-09', 'bpurverw@businesswire.com');
insert into employee (name, birthday, email) values ('Ethe', null, 'edelchecolox@goo.ne.jp');
insert into employee (name, birthday, email) values ('Oona', '1947-08-30', 'oglisaney@sciencedaily.com');
insert into employee (name, birthday, email) values ('Aurora', '1939-02-09', 'awillowbyz@umich.edu');
insert into employee (name, birthday, email) values ('Wheeler', null, 'wkubacek10@hexun.com');
insert into employee (name, birthday, email) values ('Craggy', '1969-11-26', 'cmarham11@illinois.edu');
insert into employee (name, birthday, email) values ('Nicolas', '1936-03-18', 'npandya12@slashdot.org');
insert into employee (name, birthday, email) values ('Minny', '1939-05-09', 'mhunnicutt13@fc2.com');
insert into employee (name, birthday, email) values ('Carlie', '1980-02-19', 'cphythian14@irs.gov');
insert into employee (name, birthday, email) values ('Kylynn', '1917-10-13', null);
insert into employee (name, birthday, email) values ('Moreen', '1995-07-24', 'mwallwork16@businesswire.com');
insert into employee (name, birthday, email) values ('Lurline', null, 'lwyllis17@friendfeed.com');
insert into employee (name, birthday, email) values ('Minnnie', '1903-09-26', 'mkelling18@ucoz.com');
insert into employee (name, birthday, email) values ('Taddeusz', '1990-03-23', 'tpitone19@msu.edu');
insert into employee (name, birthday, email) values ('Zane', '1904-03-09', 'zomoylane1a@unicef.org');
insert into employee (name, birthday, email) values ('Clint', '1972-12-06', 'cfehner1b@cbc.ca');
insert into employee (name, birthday, email) values ('Efren', null, 'edaldan1c@csmonitor.com');
insert into employee (name, birthday, email) values ('Chrysler', '1923-01-10', 'cburtwhistle1d@bloglines.com');
*/

/*
UPDATE employee
SET name = 'MMM'
WHERE name LIKE 'M%'
RETURNING *

UPDATE employee
SET birthday = '1899-01-01'
WHERE birthday IS NULL
RETURNING * ;

UPDATE employee
SET name = 'noname'
WHERE email IS NULL
RETURNING *

UPDATE employee
SET name = 'test-name'
WHERE id < 5
RETURNING *

UPDATE employee
SET name = 'AAA'
WHERE name LIKE 'A%'
RETURNING *
*/

/*
DELETE FROM employee
WHERE id < 5
RETURNING *

DELETE FROM employee
WHERE email IS null
RETURNING *

DELETE FROM employee
WHERE name = 'AAA'
RETURNING *

DELETE FROM employee
WHERE name = 'MMM'
RETURNING *

DELETE FROM employee
WHERE birthday = '1899-01-01'
RETURNING *
*/

