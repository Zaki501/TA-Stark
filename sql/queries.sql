/*
Q2 - Write a SELECT statement which uses joins to return the following columns:
• meters – serial_number
• meters – manufacturer
• meters – model
• customers – name
• customers – contact_name
• customers – telephone
• sites – building_number
• sites – postcode
*/

SELECT  meters.serial_number, meters.manufacturer, meters.model,
        customers.name, customers.contact_name, customers.telephone,
        sites.building_number, sites.postcode
FROM customers
JOIN meters ON customers.id = meters.customer_id
JOIN sites ON sites.id = meters.site_id;

/*
Q3 - Write a SELECT statement that queries the connection_log table and returns:
• meter_id
• The total time of each connection displayed in minutes.
*/
SELECT meter_id, TIMESTAMPDIFF(MINUTE, start, end)
FROM connection_logs;

/*
Q4 AND Q5 - Dont have this data, skipped

Q6 - Connections which are longer than two minutes usually indicate that there is an issue
with the meter. Write a CREATE VIEW statement to create a view called meters_report.
This view should display the following:
• meters – serial_number
• total connection time in minutes
• customers – name
• customers – contact_name
• customers - telephone
Only rows where the connection time is greater than two minutes should be displayed.
Rows should be in descending order by total connection time, so that the longest
connections are displayed fir
*/

-- DESCRIBE meters_report;
-- select * from meters_report;

-- DROP VIEW meters_report;

CREATE VIEW meters_report AS
SELECT meters.serial_number,
TIMESTAMPDIFF(MINUTE, connection_logs.start, connection_logs.end) AS connection_time,
customers.name, customers.contact_name, customers.telephone
FROM customers
JOIN meters ON customers.id = meters.customer_id
JOIN connection_logs ON connection_logs.meter_id = meters.id
HAVING connection_time > 2
ORDER BY connection_time DESC;

