
/* historia-visitas 
DONDE ID MASCOTA=1 */
SELECT * 
FROM historia as H 
INNER JOIN visita as V ON H.IDHISTORIA =V.IDHISTORIA 
WHERE H.IDMASCOTA=1; 


/* autoincremento */
ALTER TABLE `visita` CHANGE `IDVISITA` `IDVISITA` INT(11) NOT NULL AUTO_INCREMENT; 