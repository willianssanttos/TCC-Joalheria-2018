Select p.pro_cod, p.umed_cod, p.cat_cod, p.scat_cod, p.codigo_barras, p.data_cadastro, p.pro_nome, p.pro_descricao, p.pro_foto,
 p.pro_valorpago, p.pro_valorvenda, p.pro_qtde, p.pro_esto_atual, p.fornecedor, u.umed_nome, c.cat_nome, sc.scat_nome
 from Produto p inner join undmedida u on p.umed_cod = u.umed_cod inner join categoria_produto c on p.cat_cod = c.cat_cod 
 inner join subcategoria sc on p.scat_cod = sc.scat_cod

