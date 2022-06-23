-- SELECT * FROM sites;
-- SELECT * FROM customers;
-- SELECT * FROM meters;
-- SELECT * FROM connection_logs;

-- DESCRIBE sites;
-- DESCRIBE customers;
-- DESCRIBE meters;
-- DESCRIBE connection_logs;

INSERT INTO sites
(building_number, town, postcode)
VALUES
('10 Downing Street', 'London', 'SW1 ABC'),
('96 Shamrock Road', 'London', 'SE1 XYZ');

INSERT INTO customers
(name, contact_name, telephone)
VALUES
('James' , 'James A.B', '456'),
('William', 'William C.D', '123');

INSERT INTO meters
(serial_number, customer_id, site_id, reference, manufacturer, model)
VALUES
('SN1', 1, 1, 'ref123', 'Manufacturer1', 'model1'),
('SN2', 2, 2, 'ref456', 'Manufacturer2', 'model2');


INSERT INTO connection_logs
(meter_id, start, end)
VALUES
(1, '1000-01-01 00:00:00', '1000-01-01 12:00:00'),
(2, '1000-01-02 00:00:00', '1000-01-02 13:00:00'),
(1, '1000-01-02 00:00:00', '1000-01-02 00:01:30');