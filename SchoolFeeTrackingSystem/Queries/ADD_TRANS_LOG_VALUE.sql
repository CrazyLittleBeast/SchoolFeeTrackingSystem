DECLARE @Guardian_ID int
DECLARE @LRN bigint
DECLARE @SY varchar(9)

set @Guardian_ID = 5
set @LRN = 256665666666
set @SY = '2015-2016';

WITH G_Trans
AS
(
SELECT g.guardian_ID, gt.amount, gt.trans_date, (u.Fname +' '+ u.Lname) as u_name
FROM Guardian as g
INNER JOIN G_Trans_LOG as gt
ON g.guardian_ID = gt.guardian_ID
INNER JOIN SFTS_User as u
ON gt.[user_ID] = u.[user_ID]
WHERE (gt.guardian_ID = @Guardian_ID) AND (gt.SY = @SY)
),

A
AS
(
SELECT s.LRN, gtrans.amount, gtrans.trans_date ,gtrans.u_name
FROM
STUDENT AS s
INNER JOIN G_Trans as gtrans
ON s.guardian_ID = gtrans.guardian_ID
),

B
AS
(
SELECT st.LRN, st.amount, st.trans_date, (u.Fname +' '+ u.Lname) as u_name
FROM S_TRANS_LOG as st
INNER JOIN SFTS_User as u
ON st.[user_ID] = u.[user_ID]
WHERE (st.LRN = @LRN) AND (st.SY = @SY)
)

SELECT CONVERT(datetime2(0),trans_date) as trans_date, SUM(amount) AS [Total], u_name
FROM
(
	SELECT CONVERT(datetime2(0),trans_date) as trans_date ,amount, u_name
	FROM A

	UNION

	SELECT CONVERT(datetime2(0),trans_date) as trans_date ,amount , u_name
	FROM B
)amt
Group by trans_date, u_name

