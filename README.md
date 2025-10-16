SELECT
  fk.constraint_name,
  kcu.table_schema      AS fk_schema,
  kcu.table_name        AS fk_table,
  kcu.column_name       AS fk_column,
  pk_tc.table_schema    AS pk_schema,
  pk_kcu.table_name     AS pk_table,
  pk_kcu.column_name    AS pk_column
FROM information_schema.referential_constraints AS fk
JOIN information_schema.key_column_usage AS kcu
  ON kcu.constraint_catalog = fk.constraint_catalog
 AND kcu.constraint_schema  = fk.constraint_schema
 AND kcu.constraint_name    = fk.constraint_name
JOIN information_schema.table_constraints AS pk_tc
  ON pk_tc.constraint_catalog = fk.unique_constraint_catalog
 AND pk_tc.constraint_schema  = fk.unique_constraint_schema
 AND pk_tc.constraint_name    = fk.unique_constraint_name
JOIN information_schema.key_column_usage AS pk_kcu
  ON pk_kcu.constraint_catalog = pk_tc.constraint_catalog
 AND pk_kcu.constraint_schema  = pk_tc.constraint_schema
 AND pk_kcu.constraint_name    = pk_tc.constraint_name
WHERE kcu.table_schema = 'your_schema';
