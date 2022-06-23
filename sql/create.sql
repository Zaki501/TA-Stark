-- DROP TABLE connection_logs;
-- DROP TABLE meters;
-- DROP TABLE customers;
-- DROP TABLE sites;

CREATE TABLE customers (
  id int AUTO_INCREMENT PRIMARY KEY,
  name varchar(250),
  contact_name varchar(250),
  telephone varchar(250)
);

CREATE TABLE sites (
  id int AUTO_INCREMENT PRIMARY KEY,
  building_number varchar(250),
  town varchar(250),
  postcode varchar(8)
);

CREATE TABLE meters (
  id int AUTO_INCREMENT PRIMARY KEY,
  serial_number varchar(25),
  customer_id int,
  site_id int,
  reference varchar(50),
  manufacturer varchar(250),
  model varchar(50),
 	FOREIGN KEY (customer_id) REFERENCES customers(id),
    FOREIGN KEY (site_id) REFERENCES sites(id)
 );


CREATE TABLE connection_logs (
  id int AUTO_INCREMENT PRIMARY KEY,	
  meter_id int,
  start datetime,
  end datetime,
    FOREIGN KEY (meter_id) REFERENCES meters(id)
  );
 