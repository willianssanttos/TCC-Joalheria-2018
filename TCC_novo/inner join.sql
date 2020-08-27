select sc.scat_cod, sc.scat_nome, sc.cat_cod, c.cat_nome 
 from subcategoria sc inner join categoria_produto c on sc.cat_cod = c.cat_cod 